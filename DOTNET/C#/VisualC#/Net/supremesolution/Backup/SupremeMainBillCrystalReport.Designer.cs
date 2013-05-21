namespace SupremeTransport
{
    partial class SupremeMainBillCrystalReport
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
            this.mainbillBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.maindataset = new SupremeTransport.maindataset();
            this.billBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.mainbillTableAdapter = new SupremeTransport.maindatasetTableAdapters.mainbillTableAdapter();
            this.billTableAdapter = new SupremeTransport.maindatasetTableAdapters.billTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mainbillBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maindataset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // mainbillBindingSource
            // 
            this.mainbillBindingSource.DataMember = "mainbill";
            this.mainbillBindingSource.DataSource = this.maindataset;
            // 
            // maindataset
            // 
            this.maindataset.DataSetName = "maindataset";
            this.maindataset.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // billBindingSource
            // 
            this.billBindingSource.DataMember = "bill";
            this.billBindingSource.DataSource = this.maindataset;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "maindataset_bill";
            reportDataSource1.Value = this.billBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "SupremeTransport.TempSupreme.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1371, 758);
            this.reportViewer1.TabIndex = 0;
            // 
            // mainbillTableAdapter
            // 
            this.mainbillTableAdapter.ClearBeforeFill = true;
            // 
            // billTableAdapter
            // 
            this.billTableAdapter.ClearBeforeFill = true;
            // 
            // SupremeMainBillCrystalReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 758);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "SupremeMainBillCrystalReport";
            this.Text = "SupremeMainBillCrystalReport";
            this.Load += new System.EventHandler(this.SupremeMainBillCrystalReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mainbillBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maindataset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.billBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource mainbillBindingSource;
        private maindataset maindataset;
        private System.Windows.Forms.BindingSource billBindingSource;
        private SupremeTransport.maindatasetTableAdapters.mainbillTableAdapter mainbillTableAdapter;
        private SupremeTransport.maindatasetTableAdapters.billTableAdapter billTableAdapter;
    }
}