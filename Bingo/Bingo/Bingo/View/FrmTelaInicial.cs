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
    public partial class FrmTelaInicial : Form
    {
        public FrmTelaInicial()
        {
            InitializeComponent();
        }

        private void btnaceitar_Click(object sender, EventArgs e)
        {
            FrmCadastraApostadores cad = new FrmCadastraApostadores();
            cad.Show();
        }

        private void btnCadastraApostadores_Click(object sender, EventArgs e)
        {
            //FrmCadastraApostadores cadastaApostadores = new FrmCadastraApostadores();
            //cadastaApostadores.ShowDialog();
            FrmListaAspostadores frmListaApostadores = new FrmListaAspostadores();
            frmListaApostadores.ShowDialog();
        }

        private void btnCadastraBrindes_Click(object sender, EventArgs e)
        {
            //FrmCadastraBrindes cadastaBrindes = new FrmCadastraBrindes();
            //cadastaBrindes.ShowDialog();
            FrmListaBrindes listaBrindes = new FrmListaBrindes();
            listaBrindes.ShowDialog();
            
        }

        private void btnIniciaRodada_Click(object sender, EventArgs e)
        {
            FrmRodadas iniciaRodadas = new FrmRodadas();
            iniciaRodadas.ShowDialog();
        }

        private void btnGeraRelatórios_Click(object sender, EventArgs e)
        {
            FrmRelatorios relatorios = new FrmRelatorios();
            relatorios.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
