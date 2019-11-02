namespace AplikasiKasirrrr
{
    partial class frmCetak
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvCetak = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cetak1 = new AplikasiKasirrrr.cetak();
            this.vwcetakBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_cetakTableAdapter = new AplikasiKasirrrr.cetakTableAdapters.vw_cetakTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cetak1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwcetakBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 46);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(483, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 38);
            this.button1.TabIndex = 15;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // dgvCetak
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.vwcetakBindingSource;
            this.dgvCetak.LocalReport.DataSources.Add(reportDataSource1);
            this.dgvCetak.LocalReport.ReportEmbeddedResource = "AplikasiKasirrrr.Cetak.rdlc";
            this.dgvCetak.Location = new System.Drawing.Point(8, 52);
            this.dgvCetak.Name = "dgvCetak";
            this.dgvCetak.Size = new System.Drawing.Size(519, 509);
            this.dgvCetak.TabIndex = 16;
            // 
            // cetak1
            // 
            this.cetak1.DataSetName = "cetak";
            this.cetak1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vwcetakBindingSource
            // 
            this.vwcetakBindingSource.DataMember = "vw_cetak";
            this.vwcetakBindingSource.DataSource = this.cetak1;
            // 
            // vw_cetakTableAdapter
            // 
            this.vw_cetakTableAdapter.ClearBeforeFill = true;
            // 
            // frmCetak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 573);
            this.Controls.Add(this.dgvCetak);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmCetak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCetak";
            this.Load += new System.EventHandler(this.FrmCetak_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cetak1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwcetakBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private Microsoft.Reporting.WinForms.ReportViewer dgvCetak;
        private cetak cetak1;
        private System.Windows.Forms.BindingSource vwcetakBindingSource;
        private cetakTableAdapters.vw_cetakTableAdapter vw_cetakTableAdapter;
    }
}