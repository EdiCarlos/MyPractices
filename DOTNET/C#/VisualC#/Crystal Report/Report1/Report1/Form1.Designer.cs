namespace Report1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.mainbilllBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MyDataBaseDataSet1 = new Report1.MyDataBaseDataSet1();
            this.billBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainbilllTableAdapter = new Report1.MyDataBaseDataSet1TableAdapters.mainbilllTableAdapter();
            this.billTableAdapter1 = new Report1.MyDataBaseDataSet1TableAdapters.billTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mainbilllBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyDataBaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "MyDataBaseDataSet1_mainbilll";
            reportDataSource1.Value = this.mainbilllBindingSource;
            reportDataSource2.Name = "MyDataBaseDataSet1_bill";
            reportDataSource2.Value = this.billBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Report1.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 39);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ShowBackButton = false;
            this.reportViewer1.Size = new System.Drawing.Size(898, 475);
            this.reportViewer1.TabIndex = 0;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(266, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(238, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // mainbilllBindingSource
            // 
            this.mainbilllBindingSource.DataMember = "mainbilll";
            this.mainbilllBindingSource.DataSource = this.MyDataBaseDataSet1;
            // 
            // MyDataBaseDataSet1
            // 
            this.MyDataBaseDataSet1.DataSetName = "MyDataBaseDataSet1";
            this.MyDataBaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billBindingSource
            // 
            this.billBindingSource.DataMember = "bill";
            this.billBindingSource.DataSource = this.MyDataBaseDataSet1;
            // 
            // mainbilllTableAdapter
            // 
            this.mainbilllTableAdapter.ClearBeforeFill = true;
            // 
            // billTableAdapter1
            // 
            this.billTableAdapter1.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 526);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainbilllBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyDataBaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource mainbilllBindingSource;
        private MyDataBaseDataSet1 MyDataBaseDataSet1;
        private Report1.MyDataBaseDataSet1TableAdapters.mainbilllTableAdapter mainbilllTableAdapter;
        private Report1.MyDataBaseDataSet1TableAdapters.billTableAdapter billTableAdapter1;
        private System.Windows.Forms.BindingSource billBindingSource;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

