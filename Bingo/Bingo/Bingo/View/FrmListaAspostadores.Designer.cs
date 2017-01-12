namespace Bingo.View
{
    partial class FrmListaAspostadores
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
            this.lnlBuscarPeloNome = new System.Windows.Forms.Label();
            this.txtBuscarPeloNome = new System.Windows.Forms.TextBox();
            this.btnBuscarPeloNome = new System.Windows.Forms.Button();
            this.dgvListaApostadores = new System.Windows.Forms.DataGridView();
            this.lblBuscarPeloCpf = new System.Windows.Forms.Label();
            this.brnSair = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.mktBuscaCPF = new System.Windows.Forms.MaskedTextBox();
            this.IdApostador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaApostadores)).BeginInit();
            this.SuspendLayout();
            // 
            // lnlBuscarPeloNome
            // 
            this.lnlBuscarPeloNome.AutoSize = true;
            this.lnlBuscarPeloNome.Location = new System.Drawing.Point(12, 17);
            this.lnlBuscarPeloNome.Name = "lnlBuscarPeloNome";
            this.lnlBuscarPeloNome.Size = new System.Drawing.Size(95, 13);
            this.lnlBuscarPeloNome.TabIndex = 0;
            this.lnlBuscarPeloNome.Text = "Buscar pelo nome:";
            // 
            // txtBuscarPeloNome
            // 
            this.txtBuscarPeloNome.Location = new System.Drawing.Point(113, 14);
            this.txtBuscarPeloNome.Name = "txtBuscarPeloNome";
            this.txtBuscarPeloNome.Size = new System.Drawing.Size(455, 20);
            this.txtBuscarPeloNome.TabIndex = 1;
            // 
            // btnBuscarPeloNome
            // 
            this.btnBuscarPeloNome.Location = new System.Drawing.Point(573, 12);
            this.btnBuscarPeloNome.Name = "btnBuscarPeloNome";
            this.btnBuscarPeloNome.Size = new System.Drawing.Size(75, 49);
            this.btnBuscarPeloNome.TabIndex = 2;
            this.btnBuscarPeloNome.Text = "&Localizar";
            this.btnBuscarPeloNome.UseVisualStyleBackColor = true;
            this.btnBuscarPeloNome.Click += new System.EventHandler(this.btnBuscarPeloNome_Click);
            // 
            // dgvListaApostadores
            // 
            this.dgvListaApostadores.AllowUserToAddRows = false;
            this.dgvListaApostadores.AllowUserToDeleteRows = false;
            this.dgvListaApostadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaApostadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdApostador,
            this.Nome,
            this.Cpf,
            this.Telefone});
            this.dgvListaApostadores.Location = new System.Drawing.Point(12, 86);
            this.dgvListaApostadores.Name = "dgvListaApostadores";
            this.dgvListaApostadores.ReadOnly = true;
            this.dgvListaApostadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaApostadores.Size = new System.Drawing.Size(637, 214);
            this.dgvListaApostadores.TabIndex = 3;
            // 
            // lblBuscarPeloCpf
            // 
            this.lblBuscarPeloCpf.AutoSize = true;
            this.lblBuscarPeloCpf.Location = new System.Drawing.Point(12, 44);
            this.lblBuscarPeloCpf.Name = "lblBuscarPeloCpf";
            this.lblBuscarPeloCpf.Size = new System.Drawing.Size(89, 13);
            this.lblBuscarPeloCpf.TabIndex = 4;
            this.lblBuscarPeloCpf.Text = "Buscar pelo CPF:";
            // 
            // brnSair
            // 
            this.brnSair.Location = new System.Drawing.Point(574, 306);
            this.brnSair.Name = "brnSair";
            this.brnSair.Size = new System.Drawing.Size(75, 23);
            this.brnSair.TabIndex = 7;
            this.brnSair.Text = "&Sair";
            this.brnSair.UseVisualStyleBackColor = true;
            this.brnSair.Click += new System.EventHandler(this.brnSair_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(493, 306);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "&Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(412, 306);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(75, 23);
            this.btnNovo.TabIndex = 9;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // mktBuscaCPF
            // 
            this.mktBuscaCPF.Location = new System.Drawing.Point(113, 41);
            this.mktBuscaCPF.Mask = "000.000.000-00";
            this.mktBuscaCPF.Name = "mktBuscaCPF";
            this.mktBuscaCPF.Size = new System.Drawing.Size(262, 20);
            this.mktBuscaCPF.TabIndex = 10;
            // 
            // IdApostador
            // 
            this.IdApostador.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.IdApostador.HeaderText = "ID";
            this.IdApostador.Name = "IdApostador";
            this.IdApostador.Width = 41;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.Width = 58;
            // 
            // Cpf
            // 
            this.Cpf.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Cpf.HeaderText = "Cpf";
            this.Cpf.Name = "Cpf";
            this.Cpf.Width = 46;
            // 
            // Telefone
            // 
            this.Telefone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.Width = 72;
            // 
            // FrmListaAspostadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 341);
            this.Controls.Add(this.mktBuscaCPF);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.brnSair);
            this.Controls.Add(this.lblBuscarPeloCpf);
            this.Controls.Add(this.dgvListaApostadores);
            this.Controls.Add(this.btnBuscarPeloNome);
            this.Controls.Add(this.txtBuscarPeloNome);
            this.Controls.Add(this.lnlBuscarPeloNome);
            this.Name = "FrmListaAspostadores";
            this.Text = "FrmListaAspostadores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaApostadores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lnlBuscarPeloNome;
        private System.Windows.Forms.TextBox txtBuscarPeloNome;
        private System.Windows.Forms.Button btnBuscarPeloNome;
        private System.Windows.Forms.DataGridView dgvListaApostadores;
        private System.Windows.Forms.Label lblBuscarPeloCpf;
        private System.Windows.Forms.Button brnSair;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.MaskedTextBox mktBuscaCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdApostador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
    }
}