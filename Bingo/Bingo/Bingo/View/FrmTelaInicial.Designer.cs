namespace Bingo.View
{
    partial class FrmTelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTelaInicial));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnGeraRelatórios = new System.Windows.Forms.Button();
            this.btnIniciaRodada = new System.Windows.Forms.Button();
            this.btnCadastraBrindes = new System.Windows.Forms.Button();
            this.btnCadastraApostadores = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(247, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 303);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.WaitOnLoad = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(22, 292);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(207, 23);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnGeraRelatórios
            // 
            this.btnGeraRelatórios.Location = new System.Drawing.Point(22, 140);
            this.btnGeraRelatórios.Name = "btnGeraRelatórios";
            this.btnGeraRelatórios.Size = new System.Drawing.Size(207, 23);
            this.btnGeraRelatórios.TabIndex = 11;
            this.btnGeraRelatórios.Text = "Gera Relatórios";
            this.btnGeraRelatórios.UseVisualStyleBackColor = true;
            this.btnGeraRelatórios.Click += new System.EventHandler(this.btnGeraRelatórios_Click);
            // 
            // btnIniciaRodada
            // 
            this.btnIniciaRodada.Location = new System.Drawing.Point(22, 99);
            this.btnIniciaRodada.Name = "btnIniciaRodada";
            this.btnIniciaRodada.Size = new System.Drawing.Size(207, 23);
            this.btnIniciaRodada.TabIndex = 10;
            this.btnIniciaRodada.Text = "Inicia Rodada";
            this.btnIniciaRodada.UseVisualStyleBackColor = true;
            this.btnIniciaRodada.Click += new System.EventHandler(this.btnIniciaRodada_Click);
            // 
            // btnCadastraBrindes
            // 
            this.btnCadastraBrindes.Location = new System.Drawing.Point(22, 56);
            this.btnCadastraBrindes.Name = "btnCadastraBrindes";
            this.btnCadastraBrindes.Size = new System.Drawing.Size(207, 23);
            this.btnCadastraBrindes.TabIndex = 9;
            this.btnCadastraBrindes.Text = "Brindes";
            this.btnCadastraBrindes.UseVisualStyleBackColor = true;
            this.btnCadastraBrindes.Click += new System.EventHandler(this.btnCadastraBrindes_Click);
            // 
            // btnCadastraApostadores
            // 
            this.btnCadastraApostadores.Location = new System.Drawing.Point(22, 12);
            this.btnCadastraApostadores.Name = "btnCadastraApostadores";
            this.btnCadastraApostadores.Size = new System.Drawing.Size(207, 23);
            this.btnCadastraApostadores.TabIndex = 8;
            this.btnCadastraApostadores.Text = "Apostadores";
            this.btnCadastraApostadores.UseVisualStyleBackColor = true;
            this.btnCadastraApostadores.Click += new System.EventHandler(this.btnCadastraApostadores_Click);
            // 
            // FrmTelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 331);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGeraRelatórios);
            this.Controls.Add(this.btnIniciaRodada);
            this.Controls.Add(this.btnCadastraBrindes);
            this.Controls.Add(this.btnCadastraApostadores);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmTelaInicial";
            this.Text = "FrmTelaInicial";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnGeraRelatórios;
        private System.Windows.Forms.Button btnIniciaRodada;
        private System.Windows.Forms.Button btnCadastraBrindes;
        private System.Windows.Forms.Button btnCadastraApostadores;
    }
}