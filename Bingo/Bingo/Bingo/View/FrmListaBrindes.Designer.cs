namespace Bingo.View
{
    partial class FrmListaBrindes
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
            this.lblNomeBrinde = new System.Windows.Forms.Label();
            this.txtNomeBrinde = new System.Windows.Forms.TextBox();
            this.btnLocalizaBrinde = new System.Windows.Forms.Button();
            this.dgvListaBrindes = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.IdBrindes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeBrinde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaBrindes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeBrinde
            // 
            this.lblNomeBrinde.AutoSize = true;
            this.lblNomeBrinde.Location = new System.Drawing.Point(12, 23);
            this.lblNomeBrinde.Name = "lblNomeBrinde";
            this.lblNomeBrinde.Size = new System.Drawing.Size(68, 13);
            this.lblNomeBrinde.TabIndex = 0;
            this.lblNomeBrinde.Text = "Nome Brinde";
            // 
            // txtNomeBrinde
            // 
            this.txtNomeBrinde.Location = new System.Drawing.Point(97, 20);
            this.txtNomeBrinde.Name = "txtNomeBrinde";
            this.txtNomeBrinde.Size = new System.Drawing.Size(511, 20);
            this.txtNomeBrinde.TabIndex = 1;
            // 
            // btnLocalizaBrinde
            // 
            this.btnLocalizaBrinde.Location = new System.Drawing.Point(631, 18);
            this.btnLocalizaBrinde.Name = "btnLocalizaBrinde";
            this.btnLocalizaBrinde.Size = new System.Drawing.Size(75, 23);
            this.btnLocalizaBrinde.TabIndex = 2;
            this.btnLocalizaBrinde.Text = "&Localiza";
            this.btnLocalizaBrinde.UseVisualStyleBackColor = true;
            this.btnLocalizaBrinde.Click += new System.EventHandler(this.btnLocalizaBrinde_Click);
            // 
            // dgvListaBrindes
            // 
            this.dgvListaBrindes.AllowUserToAddRows = false;
            this.dgvListaBrindes.AllowUserToDeleteRows = false;
            this.dgvListaBrindes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaBrindes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdBrindes,
            this.NomeBrinde,
            this.Situacao});
            this.dgvListaBrindes.Location = new System.Drawing.Point(15, 57);
            this.dgvListaBrindes.Name = "dgvListaBrindes";
            this.dgvListaBrindes.ReadOnly = true;
            this.dgvListaBrindes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaBrindes.Size = new System.Drawing.Size(691, 272);
            this.dgvListaBrindes.TabIndex = 3;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(631, 350);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(550, 350);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(469, 350);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 6;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // IdBrindes
            // 
            this.IdBrindes.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.IdBrindes.HeaderText = "IdBrinde";
            this.IdBrindes.Name = "IdBrindes";
            this.IdBrindes.ReadOnly = true;
            this.IdBrindes.Width = 69;
            // 
            // NomeBrinde
            // 
            this.NomeBrinde.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NomeBrinde.HeaderText = "Nome Brinde";
            this.NomeBrinde.Name = "NomeBrinde";
            this.NomeBrinde.ReadOnly = true;
            this.NomeBrinde.Width = 91;
            // 
            // Situacao
            // 
            this.Situacao.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Situacao.HeaderText = "Situação";
            this.Situacao.Name = "Situacao";
            this.Situacao.ReadOnly = true;
            this.Situacao.Width = 72;
            // 
            // FrmListaBrindes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 385);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.dgvListaBrindes);
            this.Controls.Add(this.btnLocalizaBrinde);
            this.Controls.Add(this.txtNomeBrinde);
            this.Controls.Add(this.lblNomeBrinde);
            this.Name = "FrmListaBrindes";
            this.Text = "FrmListaBrindes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaBrindes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeBrinde;
        private System.Windows.Forms.TextBox txtNomeBrinde;
        private System.Windows.Forms.Button btnLocalizaBrinde;
        private System.Windows.Forms.DataGridView dgvListaBrindes;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdBrindes;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeBrinde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Situacao;
    }
}