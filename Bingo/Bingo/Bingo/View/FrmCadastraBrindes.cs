using Bingo.DAO;
using Bingo.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bingo.View
{
    public partial class FrmCadastraBrindes : Form
    {
        Brinde brinde = new Brinde();
        BrindeDAO brindeDao = new BrindeDAO();

        public bool Edicao { get; set; }

        public FrmCadastraBrindes()
        {
            InitializeComponent();
            Edicao = false;
        }

        public FrmCadastraBrindes(Brinde brinde)
        {
            InitializeComponent();
            Edicao = true;

           txtIdBrinde.Text = brinde.IdBrindes.ToString();
           txtNomeBrinde.Text = brinde.NomeBrinde;
           
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (!Edicao)
            {
                brinde.NomeBrinde = txtNomeBrinde.Text;
                brinde.Situacao = "Disponivel";

                brindeDao.insertBrinde(brinde);
                txtNomeBrinde.ReadOnly = true;

                MessageBox.Show("Brinde salvo com sucesso!");
            }
            else
            {
                brinde.IdBrindes = int.Parse(txtIdBrinde.Text);
                brinde.NomeBrinde = txtNomeBrinde.Text;
                brinde.Situacao = "Disponivel";
                brindeDao.AlteraBrinde(brinde);
                txtNomeBrinde.ReadOnly = true;

                MessageBox.Show("Brinde alterado com sucesso!");
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtIdBrinde.ReadOnly = true;
            txtNomeBrinde.ReadOnly = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
