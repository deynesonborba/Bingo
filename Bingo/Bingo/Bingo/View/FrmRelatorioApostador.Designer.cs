namespace Bingo.View
{
    partial class FrmRelatorioApostador
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
            this.rpVApostadores = new Microsoft.Reporting.WinForms.ReportViewer();
            this.contextBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ApostadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apostadorDAOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contextBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.contextBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApostadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apostadorDAOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // rpVApostadores
            // 
            this.rpVApostadores.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "dsApostadores";
            reportDataSource1.Value = this.contextBindingSource;
            this.rpVApostadores.LocalReport.DataSources.Add(reportDataSource1);
            this.rpVApostadores.LocalReport.ReportEmbeddedResource = "Bingo.View.RelatorioApostadores.rdlc";
            this.rpVApostadores.Location = new System.Drawing.Point(0, 0);
            this.rpVApostadores.Name = "rpVApostadores";
            this.rpVApostadores.Size = new System.Drawing.Size(610, 312);
            this.rpVApostadores.TabIndex = 0;
            // 
            // contextBindingSource
            // 
            this.contextBindingSource.DataSource = typeof(Bingo.Context);
            // 
            // ApostadorBindingSource
            // 
            this.ApostadorBindingSource.DataSource = typeof(Bingo.Model.Apostador);
            // 
            // apostadorDAOBindingSource
            // 
            this.apostadorDAOBindingSource.DataSource = typeof(Bingo.DAO.ApostadorDAO);
            // 
            // contextBindingSource1
            // 
            this.contextBindingSource1.DataSource = typeof(Bingo.Context);
            // 
            // FrmRelatorioApostador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 312);
            this.Controls.Add(this.rpVApostadores);
            this.Name = "FrmRelatorioApostador";
            this.Text = "FrmRelatorioApostador";
            this.Load += new System.EventHandler(this.FrmRelatorioApostador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contextBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ApostadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apostadorDAOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpVApostadores;
        private System.Windows.Forms.BindingSource ApostadorBindingSource;
        private System.Windows.Forms.BindingSource contextBindingSource;
        private System.Windows.Forms.BindingSource apostadorDAOBindingSource;
        private System.Windows.Forms.BindingSource contextBindingSource1;
    }
}