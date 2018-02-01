using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using MongoDB.Bson;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Serializers;
using MongoDB.Bson.Serialization.Attributes;
using System.Diagnostics;

namespace DeskTopDynDBManager
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            //DG_DataResult.EnableGrouping = false;
            DG_DataResult.VirtualMode = true;
            DG_DataResult.ReadOnly = true;
        }
        //private static readonly string aliyunApiBaseUri = 
        //WebApiHelper aliyunApi = new WebApiHelper("http://localhost:33386");
        WebApiHelper aliyunApi = new WebApiHelper("http://47.93.50.106:5000");

        private async void Main_Load(object sender, EventArgs e)
        {
            this.tb_Skip.Text = "0";
            this.tb_Limit.Text = "20";
            await RunIniTableTree();
            this.tb_Skip.Enabled = false;
            this.tb_Limit.Enabled = false;
            this.btn_Previous.Enabled = false;
            this.btn_Next.Enabled = false;
        }

        private async Task RunIniTableTree()
        {
            
            var result = await aliyunApi.GetData("/api/Table");
            var stuff = JsonConvert.DeserializeObject<string[]>(result);
            


            for (int i = 0; i < stuff.Length; i++)
            {
                this.TV_Table.Nodes.Add(stuff[i], stuff[i]);
            }
           
            
        }

        private async void TV_Table_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            MyPipeline myPipeline = new MyPipeline();
            myPipeline.Conditions = new SearchCondition[] { };
            myPipeline.SkipSize = int.Parse(tb_Skip.Text);
            myPipeline.LimitSize = int.Parse(tb_Limit.Text);
            await BeginAdvanceSearch(this.TV_Table.SelectedNode.Text, myPipeline);
        }


        private void AddDgRow(string[] fields)
        {
            DG_DataResult.Columns.Clear();
            for (int i = 0; i < fields.Length; i++)
            {
                this.DG_DataResult.Columns.Add(fields[i], fields[i]);
            }
        }

        private void DG_DataResult_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            //if (ProjectFieldsNames == null || PostResultData == null)
            //    return;
            var rowData = this.DG_DataResult.CurrentRow.DataBoundItem as IDictionary<string, object>;
            string value = GetValue(e.RowIndex, e.ColumnIndex, rowData, this.DG_DataResult.Columns[e.ColumnIndex].Name);
            e.Value = value;


        }
       

        private string GetValue(int rowIndex, int colIndex, IDictionary<string, object> dataRow,string fieldName)
        {
            var UperName = fieldName[0].ToString().ToLower() + fieldName.Substring(1);
            if (dataRow[UperName] ==null)
            {
                return string.Empty;
            }

            return dataRow[UperName].ToString();
        }

        private async Task BeginAdvanceSearch(string tableName, MyPipeline myPipeline)
        {
            //UI控制
            this.TV_Table.Enabled = false;
            this.DG_DataResult.Enabled = false;
            this.tb_Skip.Enabled = false;
            this.tb_Limit.Enabled = false;
            this.btn_Previous.Enabled = false;
            this.btn_Next.Enabled = false;
            this.toolStripStatusLabel1.Text = "获取数据中.......";
            //开始秒表计时
            Stopwatch timer = new Stopwatch();
            timer.Start();
            //数据清空
            string[] ProjectFieldsNames = null;

            this.DG_DataResult.DataSource = null;
            
            var fieldsResult = await aliyunApi.GetData("/api/Table/" + tableName);
            var fieldsResultDyn = JsonConvert.DeserializeObject<dynamic>(fieldsResult);
            var SelectedTableFields = ((JArray)fieldsResultDyn).Where(p => !p["name"].ToString().Contains("Dic")).Select(x => x["key"].ToString()).ToArray();

         
            if (!string.IsNullOrEmpty(myPipeline.Projects))
            {
                ProjectFieldsNames = myPipeline.Projects.Split(',');
            }
            else
            {
                ProjectFieldsNames = SelectedTableFields;
            }
            AddDgRow(ProjectFieldsNames);


            var result = await aliyunApi.PostData("/api/Table/" + tableName, myPipeline);
            var PostResultData = BsonSerializer.Deserialize<dynamic>(result);


            this.DG_DataResult.DataSource = PostResultData;

            this.TV_Table.Enabled = true;
            this.DG_DataResult.Enabled = true;
            this.tb_Skip.Enabled = true;
            this.tb_Limit.Enabled = true;
            this.btn_Previous.Enabled = true;
            this.btn_Next.Enabled = true;
            timer.Stop();
            this.toolStripStatusLabel1.Text = "共" + this.DG_DataResult.RowCount.ToString() + "行;" + "耗时:" + timer.ElapsedMilliseconds.ToString() + "毫秒";
        }

        private async void btn_Previous_Click(object sender, EventArgs e)
        {
            if (int.Parse(tb_Skip.Text) <= 0)
            {
                return;
            }

            MyPipeline myPipeline = new MyPipeline();
            myPipeline.Conditions = new SearchCondition[] { };
            myPipeline.SkipSize = int.Parse(tb_Skip.Text) - int.Parse(tb_Limit.Text);
            myPipeline.LimitSize = int.Parse(tb_Limit.Text);
            await BeginAdvanceSearch(this.TV_Table.SelectedNode.Text, myPipeline);
            tb_Skip.Text = myPipeline.SkipSize .ToString();
        }

        private async void btn_Next_Click(object sender, EventArgs e)
        {
            MyPipeline myPipeline = new MyPipeline();
            myPipeline.Conditions = new SearchCondition[] { };
            myPipeline.SkipSize = int.Parse(tb_Skip.Text) + int.Parse(tb_Limit.Text);
            myPipeline.LimitSize = int.Parse(tb_Limit.Text);
            await BeginAdvanceSearch(this.TV_Table.SelectedNode.Text, myPipeline);
            tb_Skip.Text = myPipeline.SkipSize.ToString();
        }
    }

    
}
