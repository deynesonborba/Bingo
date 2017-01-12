using Bingo.DAO;
using Bingo.Model;
using System;
using System.Collections;
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
    public partial class FrmListaBrindes : Form
    {
        BrindeDAO brindeDao = new BrindeDAO();
        public FrmListaBrindes()
        {
            InitializeComponent();
            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLocalizaBrinde_Click(object sender, EventArgs e)
        {
            
                //dgvListaBrindes.DataSource = brindeDao.ListaBrindes();
                dgvListaBrindes.Rows.Clear();
                Brinde brinde = new Brinde();
                brinde.NomeBrinde = txtNomeBrinde.Text;

                foreach (Brinde x in BrindeDAO.buscarBrindePorNomeString(brinde))
                {
                    dgvListaBrindes.Rows.Add(x.IdBrindes, x.NomeBrinde, x.Situacao);
                }
            
            
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            FrmCadastraBrindes cadastraBrindes = new FrmCadastraBrindes();
            cadastraBrindes.ShowDialog();

            dgvListaBrindes.Refresh();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridViewRow linha = dgvListaBrindes.SelectedRows[0];
            DataGridViewCell celulaBrindeId = linha.Cells[0]; 

            int BrindeId = int.Parse(celulaBrindeId.Value.ToString());

            Brinde brinde = brindeDao.buscarBrindePorId(BrindeId);

            if (brinde.Situacao != "Sorteado")
            {
                FrmCadastraBrindes cadastraBrindes = new FrmCadastraBrindes(brinde);
                cadastraBrindes.ShowDialog();                
            }
            else
            {
                MessageBox.Show("Esse brinde já foi sorteado e não permite edição!");
            }
            
            dgvListaBrindes.Refresh();
        }
    }
}
