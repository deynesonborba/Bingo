namespace Bingo.View
{
    partial class FrmCadastraApostadores
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
            this.t = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.btnSalvarApostador = new System.Windows.Forms.Button();
            this.MSKTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.t.SuspendLayout();
            this.SuspendLayout();
            // 
            // t
            // 
            this.t.Controls.Add(this.txtId);
            this.t.Controls.Add(this.btnSair);
            this.t.Controls.Add(this.txtCpf);
            this.t.Controls.Add(this.lblCPF);
            this.t.Controls.Add(this.btnSalvarApostador);
            this.t.Controls.Add(this.MSKTelefone);
            this.t.Controls.Add(this.txtNome);
            this.t.Controls.Add(this.lblNome);
            this.t.Controls.Add(this.lblTelefone);
            this.t.Controls.Add(this.lblid);
            this.t.Location = new System.Drawing.Point(12, 12);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(327, 263);
            this.t.TabIndex = 0;
            this.t.TabStop = false;
            this.t.Text = "Cadastro Apostador";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(74, 27);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 8;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(229, 218);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtCpf
            // 
            this.txtCpf.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.txtCpf.Location = new System.Drawing.Point(74, 144);
            this.txtCpf.Mask = "000.000.000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(127, 20);
            this.txtCpf.TabIndex = 5;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(18, 151);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCPF.TabIndex = 6;
            this.lblCPF.Text = "CPF";
            // 
            // btnSalvarApostador
            // 
            this.btnSalvarApostador.Location = new System.Drawing.Point(148, 218);
            this.btnSalvarApostador.Name = "btnSalvarApostador";
            this.btnSalvarApostador.Size = new System.Drawing.Size(75, 23);
            this.btnSalvarApostador.TabIndex = 6;
            this.btnSalvarApostador.Tag = "";
            this.btnSalvarApostador.Text = "S&alvar";
            this.btnSalvarApostador.UseVisualStyleBackColor = true;
            this.btnSalvarApostador.Click += new System.EventHandler(this.btnGeraCartela_Click);
            // 
            // MSKTelefone
            // 
            this.MSKTelefone.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.MSKTelefone.Location = new System.Drawing.Point(74, 100);
            this.MSKTelefone.Mask = "(99)0000-0000";
            this.MSKTelefone.Name = "MSKTelefone";
            this.MSKTelefone.Size = new System.Drawing.Size(127, 20);
            this.MSKTelefone.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(71, 59);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(233, 20);
            this.txtNome.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(18, 66);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(18, 108);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 1;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(18, 30);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(16, 13);
            this.lblid.TabIndex = 0;
            this.lblid.Text = "Id";
            // 
            // FrmCadastraApostadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 289);
            this.Controls.Add(this.t);
            this.Name = "FrmCadastraApostadores";
            this.Text = "Cadastra Apostadores";
            this.t.ResumeLayout(false);
            this.t.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox t;
        private System.Windows.Forms.MaskedTextBox MSKTelefone;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Button btnSalvarApostador;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtId;
    }
}