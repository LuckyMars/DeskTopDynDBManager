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
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DG_DataResult)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.TV_Table);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.DG_DataResult);
            this.splitContainer1.Size = new System.Drawing.Size(951, 530);
            this.splitContainer1.SplitterDistance = 317;
            this.splitContainer1.TabIndex = 0;
            // 
            // TV_Table
            // 
            this.TV_Table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TV_Table.Location = new System.Drawing.Point(0, 0);
            this.TV_Table.Name = "TV_Table";
            this.TV_Table.Size = new System.Drawing.Size(317, 530);
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
            this.DG_DataResult.Size = new System.Drawing.Size(630, 530);
            this.DG_DataResult.TabIndex = 0;
            this.DG_DataResult.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.DG_DataResult_CellValueNeeded);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 530);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DG_DataResult)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView TV_Table;
        private System.Windows.Forms.DataGridView DG_DataResult;
    }
}