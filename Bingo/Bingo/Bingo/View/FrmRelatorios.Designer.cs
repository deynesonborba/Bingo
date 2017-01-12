namespace Bingo.View
{
    partial class FrmRelatorios
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
            this.btnRelApostadores = new System.Windows.Forms.Button();
            this.btnRelBrindes = new System.Windows.Forms.Button();
            this.btnRelRodadas = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRelApostadores
            // 
            this.btnRelApostadores.Enabled = false;
            this.btnRelApostadores.Location = new System.Drawing.Point(58, 25);
            this.btnRelApostadores.Name = "btnRelApostadores";
            this.btnRelApostadores.Size = new System.Drawing.Size(155, 23);
            this.btnRelApostadores.TabIndex = 0;
            this.btnRelApostadores.Text = "Relatório de Apostadores";
            this.btnRelApostadores.UseVisualStyleBackColor = true;
            this.btnRelApostadores.Click += new System.EventHandler(this.btnRelApostadores_Click);
            // 
            // btnRelBrindes
            // 
            this.btnRelBrindes.Enabled = false;
            this.btnRelBrindes.Location = new System.Drawing.Point(58, 54);
            this.btnRelBrindes.Name = "btnRelBrindes";
            this.btnRelBrindes.Size = new System.Drawing.Size(155, 23);
            this.btnRelBrindes.TabIndex = 1;
            this.btnRelBrindes.Text = "Relatório de Brindes";
            this.btnRelBrindes.UseVisualStyleBackColor = true;
            // 
            // btnRelRodadas
            // 
            this.btnRelRodadas.Enabled = false;
            this.btnRelRodadas.Location = new System.Drawing.Point(58, 83);
            this.btnRelRodadas.Name = "btnRelRodadas";
            this.btnRelRodadas.Size = new System.Drawing.Size(155, 23);
            this.btnRelRodadas.TabIndex = 2;
            this.btnRelRodadas.Text = "Relatório de Rodadas";
            this.btnRelRodadas.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(58, 134);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(155, 23);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FrmRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 217);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnRelRodadas);
            this.Controls.Add(this.btnRelBrindes);
            this.Controls.Add(this.btnRelApostadores);
            this.Name = "FrmRelatorios";
            this.Text = "Relatórios";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRelApostadores;
        private System.Windows.Forms.Button btnRelBrindes;
        private System.Windows.Forms.Button btnRelRodadas;
        private System.Windows.Forms.Button btnSair;
    }
}