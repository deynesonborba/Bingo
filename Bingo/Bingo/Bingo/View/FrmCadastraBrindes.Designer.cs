namespace Bingo.View
{
    partial class FrmCadastraBrindes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtNomeBrinde = new System.Windows.Forms.TextBox();
            this.txtIdBrinde = new System.Windows.Forms.TextBox();
            this.lblDescricaoBrinde = new System.Windows.Forms.Label();
            this.lblIdBrinde = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSair);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.txtNomeBrinde);
            this.groupBox1.Controls.Add(this.txtIdBrinde);
            this.groupBox1.Controls.Add(this.lblDescricaoBrinde);
            this.groupBox1.Controls.Add(this.lblIdBrinde);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 212);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro de Brindes";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(224, 183);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "S&alvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtNomeBrinde
            // 
            this.txtNomeBrinde.Location = new System.Drawing.Point(9, 68);
            this.txtNomeBrinde.Multiline = true;
            this.txtNomeBrinde.Name = "txtNomeBrinde";
            this.txtNomeBrinde.Size = new System.Drawing.Size(372, 98);
            this.txtNomeBrinde.TabIndex = 3;
            // 
            // txtIdBrinde
            // 
            this.txtIdBrinde.Location = new System.Drawing.Point(43, 24);
            this.txtIdBrinde.Name = "txtIdBrinde";
            this.txtIdBrinde.ReadOnly = true;
            this.txtIdBrinde.Size = new System.Drawing.Size(100, 20);
            this.txtIdBrinde.TabIndex = 2;
            // 
            // lblDescricaoBrinde
            // 
            this.lblDescricaoBrinde.AutoSize = true;
            this.lblDescricaoBrinde.Location = new System.Drawing.Point(6, 52);
            this.lblDescricaoBrinde.Name = "lblDescricaoBrinde";
            this.lblDescricaoBrinde.Size = new System.Drawing.Size(88, 13);
            this.lblDescricaoBrinde.TabIndex = 1;
            this.lblDescricaoBrinde.Text = "Descrição Brinde";
            // 
            // lblIdBrinde
            // 
            this.lblIdBrinde.AutoSize = true;
            this.lblIdBrinde.Location = new System.Drawing.Point(6, 27);
            this.lblIdBrinde.Name = "lblIdBrinde";
            this.lblIdBrinde.Size = new System.Drawing.Size(16, 13);
            this.lblIdBrinde.TabIndex = 0;
            this.lblIdBrinde.Text = "Id";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(306, 183);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FrmCadastraBrindes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 250);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmCadastraBrindes";
            this.Text = "Cadastra Brindes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtNomeBrinde;
        private System.Windows.Forms.TextBox txtIdBrinde;
        private System.Windows.Forms.Label lblDescricaoBrinde;
        private System.Windows.Forms.Label lblIdBrinde;
        private System.Windows.Forms.Button btnSair;
    }
}