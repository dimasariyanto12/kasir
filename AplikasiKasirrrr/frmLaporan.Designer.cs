namespace AplikasiKasirrrr
{
    partial class frmLaporan
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.kasirrrDataSet = new AplikasiKasirrrr.kasirrrDataSet();
            this.LaporanBarangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LaporanBarangTableAdapter = new AplikasiKasirrrr.kasirrrDataSetTableAdapters.LaporanBarangTableAdapter();
            this.kasirrrDataSet1 = new AplikasiKasirrrr.kasirrrDataSet1();
            this.Vw_penjualanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Vw_penjualanTableAdapter = new AplikasiKasirrrr.kasirrrDataSet1TableAdapters.Vw_penjualanTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tab1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kasirrrDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LaporanBarangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasirrrDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vw_penjualanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(966, 684);
            this.tabControl1.TabIndex = 0;
            // 
            // tab1
            // 
            this.tab1.Controls.Add(this.reportViewer1);
            this.tab1.Location = new System.Drawing.Point(4, 32);
            this.tab1.Name = "tab1";
            this.tab1.Padding = new System.Windows.Forms.Padding(3);
            this.tab1.Size = new System.Drawing.Size(958, 648);
            this.tab1.TabIndex = 0;
            this.tab1.Text = "LAPORAN BARANG";
            this.tab1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.reportViewer2);
            this.tabPage2.Location = new System.Drawing.Point(4, 32);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(958, 648);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "LAPORAN PENJUALAN";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.LaporanBarangBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "AplikasiKasirrrr.LaporanBarsng.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 3);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(952, 642);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportViewer2
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.Vw_penjualanBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "AplikasiKasirrrr.Penjualan.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 6);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.Size = new System.Drawing.Size(955, 639);
            this.reportViewer2.TabIndex = 0;
            // 
            // kasirrrDataSet
            // 
            this.kasirrrDataSet.DataSetName = "kasirrrDataSet";
            this.kasirrrDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // LaporanBarangBindingSource
            // 
            this.LaporanBarangBindingSource.DataMember = "LaporanBarang";
            this.LaporanBarangBindingSource.DataSource = this.kasirrrDataSet;
            // 
            // LaporanBarangTableAdapter
            // 
            this.LaporanBarangTableAdapter.ClearBeforeFill = true;
            // 
            // kasirrrDataSet1
            // 
            this.kasirrrDataSet1.DataSetName = "kasirrrDataSet1";
            this.kasirrrDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Vw_penjualanBindingSource
            // 
            this.Vw_penjualanBindingSource.DataMember = "Vw_penjualan";
            this.Vw_penjualanBindingSource.DataSource = this.kasirrrDataSet1;
            // 
            // Vw_penjualanTableAdapter
            // 
            this.Vw_penjualanTableAdapter.ClearBeforeFill = true;
            // 
            // frmLaporan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(966, 684);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmLaporan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLaporan";
            this.Load += new System.EventHandler(this.FrmLaporan_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kasirrrDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LaporanBarangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasirrrDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Vw_penjualanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab1;
        private System.Windows.Forms.TabPage tabPage2;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource LaporanBarangBindingSource;
        private kasirrrDataSet kasirrrDataSet;
        private kasirrrDataSetTableAdapters.LaporanBarangTableAdapter LaporanBarangTableAdapter;
        private System.Windows.Forms.BindingSource Vw_penjualanBindingSource;
        private kasirrrDataSet1 kasirrrDataSet1;
        private kasirrrDataSet1TableAdapters.Vw_penjualanTableAdapter Vw_penjualanTableAdapter;
    }
}