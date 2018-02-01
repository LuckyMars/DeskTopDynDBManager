namespace DeskTopDynDBManager
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.TV_Table = new System.Windows.Forms.TreeView();
            this.DG_DataResult = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Next = new System.Windows.Forms.Button();
            this.btn_Previous = new System.Windows.Forms.Button();
            this.tb_Limit = new System.Windows.Forms.TextBox();
            this.tb_Skip = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_DataResult)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 33);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TV_Table);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DG_DataResult);
            this.splitContainer1.Size = new System.Drawing.Size(951, 475);
            this.splitContainer1.SplitterDistance = 317;
            this.splitContainer1.TabIndex = 0;
            // 
            // TV_Table
            // 
            this.TV_Table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TV_Table.Location = new System.Drawing.Point(0, 0);
            this.TV_Table.Name = "TV_Table";
            this.TV_Table.Size = new System.Drawing.Size(317, 475);
            this.TV_Table.TabIndex = 0;
            this.TV_Table.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.TV_Table_MouseDoubleClick);
            // 
            // DG_DataResult
            // 
            this.DG_DataResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_DataResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DG_DataResult.Location = new System.Drawing.Point(0, 0);
            this.DG_DataResult.Name = "DG_DataResult";
            this.DG_DataResult.RowTemplate.Height = 23;
            this.DG_DataResult.Size = new System.Drawing.Size(630, 475);
            this.DG_DataResult.TabIndex = 0;
            this.DG_DataResult.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.DG_DataResult_CellValueNeeded);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 508);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(951, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(131, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_Next);
            this.panel1.Controls.Add(this.btn_Previous);
            this.panel1.Controls.Add(this.tb_Limit);
            this.panel1.Controls.Add(this.tb_Skip);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 33);
            this.panel1.TabIndex = 3;
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(794, 4);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(28, 23);
            this.btn_Next.TabIndex = 1;
            this.btn_Next.Text = "后";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // btn_Previous
            // 
            this.btn_Previous.Location = new System.Drawing.Point(678, 6);
            this.btn_Previous.Name = "btn_Previous";
            this.btn_Previous.Size = new System.Drawing.Size(28, 23);
            this.btn_Previous.TabIndex = 1;
            this.btn_Previous.Text = "前";
            this.btn_Previous.UseVisualStyleBackColor = true;
            this.btn_Previous.Click += new System.EventHandler(this.btn_Previous_Click);
            // 
            // tb_Limit
            // 
            this.tb_Limit.Location = new System.Drawing.Point(753, 6);
            this.tb_Limit.Name = "tb_Limit";
            this.tb_Limit.Size = new System.Drawing.Size(35, 21);
            this.tb_Limit.TabIndex = 0;
            // 
            // tb_Skip
            // 
            this.tb_Skip.Location = new System.Drawing.Point(712, 6);
            this.tb_Skip.Name = "tb_Skip";
            this.tb_Skip.Size = new System.Drawing.Size(35, 21);
            this.tb_Skip.TabIndex = 0;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 530);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_DataResult)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView TV_Table;
        private System.Windows.Forms.DataGridView DG_DataResult;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Button btn_Previous;
        private System.Windows.Forms.TextBox tb_Limit;
        private System.Windows.Forms.TextBox tb_Skip;
    }
}