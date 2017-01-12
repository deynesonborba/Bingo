using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bingo.DAO;
using Bingo.Model;

namespace Bingo.View
{
    public partial class FrmListaAspostadores : Form
    {
        public FrmListaAspostadores()
        {
            InitializeComponent();
        }

        private void btnBuscarPeloNome_Click(object sender, EventArgs e)
        {
            ApostadorDAO apostadorDao = new ApostadorDAO();

            if ((txtBuscarPeloNome.Text != "" || txtBuscarPeloNome.Text == "") && mktBuscaCPF.Text == "   ,   ,   -")
            {
                //    dgvListaApostadores.DataSource = apostadorDao.listarApostadores();
                //}
                //if (txtBuscarPeloNome.Text != "" && mktBuscaCPF.Text == "")
                //{
                //    List<Apostador> listaApostadores = new List<Apostador>();
                //    listaApostadores.Add(apostadorDao.buscarApostadorPeloNome(txtBuscarPeloNome.Text));
                //    dgvListaApostadores.DataSource = listaApostadores;
                dgvListaApostadores.Refresh();
                dgvListaApostadores.Rows.Clear();
                Apostador apostador = new Apostador();
                apostador.Nome = txtBuscarPeloNome.Text;

                foreach (Apostador x in ApostadorDAO.buscarApostadorPeloNomeString(apostador))
                {
                    dgvListaApostadores.Rows.Add(x.IdApostador, x.Nome, x.Cpf, x.Telefone);
                }

            }
            if (txtBuscarPeloNome.Text == "" && mktBuscaCPF.Text != "   ,   ,   -")
            {
                //List<Apostador> listaApostadores = new List<Apostador>();
                //listaApostadores.Add(apostadorDao.buscarPeloCpf(mktBuscaCPF.Text));
                //dgvListaApostadores.DataSource = listaApostadores;

                
                dgvListaApostadores.Refresh();
                dgvListaApostadores.Rows.Clear();
                Apostador apostador = new Apostador();
                apostador.Cpf = mktBuscaCPF.Text;
                List<Apostador> listaApostadores = new List<Apostador>();
                listaApostadores.Add(ApostadorDAO.buscarPeloCpfTela(apostador));
                foreach (Apostador x in listaApostadores)
                {
                    dgvListaApostadores.Rows.Add(x.IdApostador, x.Nome, x.Cpf, x.Telefone);
                }

            }
            if (txtBuscarPeloNome.Text != "" && mktBuscaCPF.Text != "   ,   ,   -")
            {
                MessageBox.Show("Necessário preencher apenas o nome ou CPF!");
            }
        }

        
        private void brnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmCadastraApostadores frmCadastrarApostadores = new FrmCadastraApostadores();
            frmCadastrarApostadores.ShowDialog();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dgvListaApostadores.SelectedRows[0];
            DataGridViewCell cell = row.Cells[0];

            int idApostador = int.Parse(cell.Value.ToString());

            ApostadorDAO apostadorDao = new ApostadorDAO();
            Apostador apostador = apostadorDao.buscarApostardorPorId(idApostador);

            FrmCadastraApostadores frmCadastarApostadores = new FrmCadastraApostadores(apostador);
            frmCadastarApostadores.ShowDialog();
        }
    }
}
