namespace TestingApp
{
    partial class frm_DepartmentwiseBeds
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ddlDept = new System.Windows.Forms.ComboBox();
            this.lstPersonSubwise = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lstPersonSubwise)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(548, 16);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-91, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Select Subject";
            // 
            // ddlDept
            // 
            this.ddlDept.FormattingEnabled = true;
            this.ddlDept.Location = new System.Drawing.Point(200, 18);
            this.ddlDept.Name = "ddlDept";
            this.ddlDept.Size = new System.Drawing.Size(332, 21);
            this.ddlDept.TabIndex = 9;
            // 
            // lstPersonSubwise
            // 
            this.lstPersonSubwise.AllowUserToAddRows = false;
            this.lstPersonSubwise.AllowUserToDeleteRows = false;
            this.lstPersonSubwise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lstPersonSubwise.Location = new System.Drawing.Point(12, 61);
            this.lstPersonSubwise.Name = "lstPersonSubwise";
            this.lstPersonSubwise.Size = new System.Drawing.Size(890, 377);
            this.lstPersonSubwise.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fachabteilungen/Department";
            // 
            // frm_DepartmentwiseBeds
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ddlDept);
            this.Controls.Add(this.lstPersonSubwise);
            this.Name = "frm_DepartmentwiseBeds";
            this.Text = "frm_DepartmentwiseBeds";
            ((System.ComponentModel.ISupportInitialize)(this.lstPersonSubwise)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ddlDept;
        private System.Windows.Forms.DataGridView lstPersonSubwise;
        private System.Windows.Forms.Label label2;
    }
}