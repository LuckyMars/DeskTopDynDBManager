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
        WebApiHelper aliyunApi = new WebApiHelper("http://47.93.50.106:5000");

        private async void Main_Load(object sender, EventArgs e)
        {
            //WebApiHelper pp = new WebApiHelper("");

            //var result = WebApiHelper.GetData("/api/Table");

            //this.TV_Table.BeginInvoke(new Action(() => { this.TV_Table.Text = result.Result; }));

            //Console.Write(result);
            await Run();
        }

        private async Task Run()
        {
            
            var result = await aliyunApi.GetData("/api/Table");
            var stuff = JsonConvert.DeserializeObject<string[]>(result);
            


            for (int i = 0; i < stuff.Length; i++)
            {
                this.TV_Table.Nodes.Add(stuff[i], stuff[i]);
            }
           
            
        }

        private dynamic PostResultData = null;

        private string[] SelectedTableFields = null;

        private string[] ProjectFieldsNames =null;

        private async void TV_Table_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.TV_Table.Enabled = false;
            this.DG_DataResult.Enabled = false;
            SelectedTableFields = null;
            ProjectFieldsNames = null;
            PostResultData = null;
            this.DG_DataResult.DataSource = null;
            var tableName = this.TV_Table.SelectedNode.Text;
            var fieldsResult = await aliyunApi.GetData("/api/Table/"+ tableName);
            var fieldsResultDyn = JsonConvert.DeserializeObject<dynamic>(fieldsResult);
            SelectedTableFields = ((JArray)fieldsResultDyn).Where(p=>!p["name"].ToString().Contains("Dic")).Select(x => x["key"].ToString()).ToArray();

            MyPipeline myPipeline = new MyPipeline();
            myPipeline.Conditions = new SearchCondition[]{};
            if (!string.IsNullOrEmpty(myPipeline.Projects))
            {
                ProjectFieldsNames = myPipeline.Projects.Split(',');
            }
            else
            {
                ProjectFieldsNames = SelectedTableFields;
            }
            AddDgRow(ProjectFieldsNames);


            var result = await aliyunApi.PostData("/api/Table/"+ tableName, myPipeline);
            PostResultData = BsonSerializer.Deserialize<dynamic>(result);
            

            this.DG_DataResult.DataSource = PostResultData;

            this.TV_Table.Enabled = true;
            this.DG_DataResult.Enabled = true;
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
            if (ProjectFieldsNames == null || PostResultData == null)
                return;
            string value = GetValue(e.RowIndex, e.ColumnIndex, PostResultData, ProjectFieldsNames);
            e.Value = value;


        }
       

        private string GetValue(int rowIndex, int colIndex, dynamic result,string[] fieldsName)
        {
            var UperName = (fieldsName[colIndex])[0].ToString().ToLower() + (fieldsName[colIndex]).Substring(1);
            if ((result[rowIndex] as IDictionary<string, object>)[UperName] ==null)
            {
                return string.Empty;
            }

            return (result[rowIndex] as IDictionary<string, object>)[UperName].ToString();
        }
    }

    
}
