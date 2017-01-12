namespace Bingo.View
{
    partial class FrmRodadas
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
            this.gbxApostadoresNumeros = new System.Windows.Forms.GroupBox();
            this.cbxQuantApostadores = new System.Windows.Forms.ComboBox();
            this.lblQuantApostadores = new System.Windows.Forms.Label();
            this.lblBrindeRodada = new System.Windows.Forms.Label();
            this.cbxBrindes = new System.Windows.Forms.ComboBox();
            this.btnGeraCartelas = new System.Windows.Forms.Button();
            this.btnSorteia = new System.Windows.Forms.Button();
            this.lblNumeroSorteado = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gbxApostadoresNumeros
            // 
            this.gbxApostadoresNumeros.Location = new System.Drawing.Point(12, 78);
            this.gbxApostadoresNumeros.Name = "gbxApostadoresNumeros";
            this.gbxApostadoresNumeros.Size = new System.Drawing.Size(639, 408);
            this.gbxApostadoresNumeros.TabIndex = 1;
            this.gbxApostadoresNumeros.TabStop = false;
            this.gbxApostadoresNumeros.Text = "Apostadores/Cartelas";
            // 
            // cbxQuantApostadores
            // 
            this.cbxQuantApostadores.FormattingEnabled = true;
            this.cbxQuantApostadores.Items.AddRange(new object[] {
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbxQuantApostadores.Location = new System.Drawing.Point(169, 46);
            this.cbxQuantApostadores.Name = "cbxQuantApostadores";
            this.cbxQuantApostadores.Size = new System.Drawing.Size(404, 21);
            this.cbxQuantApostadores.TabIndex = 14;
            this.cbxQuantApostadores.Text = "Selecione a quantidade de apostadores";
            // 
            // lblQuantApostadores
            // 
            this.lblQuantApostadores.AutoSize = true;
            this.lblQuantApostadores.Location = new System.Drawing.Point(57, 49);
            this.lblQuantApostadores.Name = "lblQuantApostadores";
            this.lblQuantApostadores.Size = new System.Drawing.Size(101, 13);
            this.lblQuantApostadores.TabIndex = 13;
            this.lblQuantApostadores.Text = "Quant. Apostadores";
            // 
            // lblBrindeRodada
            // 
            this.lblBrindeRodada.AutoSize = true;
            this.lblBrindeRodada.Location = new System.Drawing.Point(57, 17);
            this.lblBrindeRodada.Name = "lblBrindeRodada";
            this.lblBrindeRodada.Size = new System.Drawing.Size(93, 13);
            this.lblBrindeRodada.TabIndex = 12;
            this.lblBrindeRodada.Text = "Brinde da Rodada";
            // 
            // cbxBrindes
            // 
            this.cbxBrindes.FormattingEnabled = true;
            this.cbxBrindes.Location = new System.Drawing.Point(169, 14);
            this.cbxBrindes.Name = "cbxBrindes";
            this.cbxBrindes.Size = new System.Drawing.Size(404, 21);
            this.cbxBrindes.TabIndex = 11;
            this.cbxBrindes.Text = "Selecione o brinde da rodada";
            // 
            // btnGeraCartelas
            // 
            this.btnGeraCartelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeraCartelas.Location = new System.Drawing.Point(12, 496);
            this.btnGeraCartelas.Name = "btnGeraCartelas";
            this.btnGeraCartelas.Size = new System.Drawing.Size(115, 71);
            this.btnGeraCartelas.TabIndex = 17;
            this.btnGeraCartelas.Text = "Gera Cartelas";
            this.btnGeraCartelas.UseVisualStyleBackColor = true;
            this.btnGeraCartelas.Click += new System.EventHandler(this.btnGeraCartelas_Click);
            // 
            // btnSorteia
            // 
            this.btnSorteia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSorteia.Location = new System.Drawing.Point(548, 496);
            this.btnSorteia.Name = "btnSorteia";
            this.btnSorteia.Size = new System.Drawing.Size(103, 71);
            this.btnSorteia.TabIndex = 16;
            this.btnSorteia.Text = "Sorteio";
            this.btnSorteia.UseVisualStyleBackColor = true;
            this.btnSorteia.Click += new System.EventHandler(this.btnSorteia_Click);
            // 
            // lblNumeroSorteado
            // 
            this.lblNumeroSorteado.AutoSize = true;
            this.lblNumeroSorteado.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroSorteado.Location = new System.Drawing.Point(293, 504);
            this.lblNumeroSorteado.Name = "lblNumeroSorteado";
            this.lblNumeroSorteado.Size = new System.Drawing.Size(78, 55);
            this.lblNumeroSorteado.TabIndex = 15;
            this.lblNumeroSorteado.Text = "00";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(594, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(57, 55);
            this.btnSair.TabIndex = 18;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FrmRodadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 579);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnGeraCartelas);
            this.Controls.Add(this.btnSorteia);
            this.Controls.Add(this.lblNumeroSorteado);
            this.Controls.Add(this.cbxQuantApostadores);
            this.Controls.Add(this.lblQuantApostadores);
            this.Controls.Add(this.lblBrindeRodada);
            this.Controls.Add(this.cbxBrindes);
            this.Controls.Add(this.gbxApostadoresNumeros);
            this.Name = "FrmRodadas";
            this.Text = "Rodadas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbxApostadoresNumeros;
        private System.Windows.Forms.ComboBox cbxQuantApostadores;
        private System.Windows.Forms.Label lblQuantApostadores;
        private System.Windows.Forms.Label lblBrindeRodada;
        private System.Windows.Forms.ComboBox cbxBrindes;
        private System.Windows.Forms.Button btnGeraCartelas;
        private System.Windows.Forms.Button btnSorteia;
        private System.Windows.Forms.Label lblNumeroSorteado;
        private System.Windows.Forms.Button btnSair;
    }
}