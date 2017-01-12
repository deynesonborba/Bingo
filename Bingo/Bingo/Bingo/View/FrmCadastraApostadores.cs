using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bingo.Model;
using Bingo.DAO;

namespace Bingo.View
{
    public partial class FrmCadastraApostadores : Form
    {
        public object rn { get; private set; }
        public bool edicao { get; set; }

        public FrmCadastraApostadores()
        {
            InitializeComponent();
            edicao = false;
        }

        public FrmCadastraApostadores(Apostador apostador)
        {
            InitializeComponent();
            edicao = true;
            txtId.Text = apostador.IdApostador.ToString();
            txtId.ReadOnly = true;
            txtNome.Text = apostador.Nome;
            txtCpf.Text = apostador.Cpf;
            txtCpf.ReadOnly = true;
            MSKTelefone.Text = apostador.Telefone;



        }

        private void btnGeraCartela_Click(object sender, EventArgs e)
        {
            Model.Apostador apostador = new Model.Apostador();

            if (edicao)
            {
                apostador.IdApostador = int.Parse(txtId.Text);
                apostador.Nome = txtNome.Text;
                apostador.Cpf = txtCpf.Text;
                apostador.Telefone = MSKTelefone.Text;

                ApostadorDAO apostadorDao = new ApostadorDAO();
                apostadorDao.alterarApostador(apostador);
                limparCampos();

                MessageBox.Show("Apostador alterado com sucesso!");
                this.Close();
                
            }
            else {
                
                bool cpfValido = validarCpf(txtCpf.Text);
                if (cpfValido)
                {
                    apostador.IdApostador.ToString();
                    apostador.Nome = txtNome.Text;
                    apostador.Telefone = MSKTelefone.Text;
                    apostador.Cpf = txtCpf.Text;

                    DAO.ApostadorDAO salvar = new ApostadorDAO();
                    salvar.insertApostador(apostador);
                    limparCampos();

                    MessageBox.Show("Apostatador salvo com sucesso!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("CPF inválido!");
                }                
            }
        }

        private void AbrirCartela()
        {
            FrmRodadas cart = new FrmRodadas();
            cart.Show();
        }

        private void limparCampos()
        {
            txtId.Clear();
            txtNome.Clear();
            MSKTelefone.Clear();
            txtCpf.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool validarCpf(String cpf)
        {
            ApostadorDAO apostadorDao = new ApostadorDAO();
            Apostador apostador = apostadorDao.buscarPeloCpf(cpf);

            if(apostador == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
