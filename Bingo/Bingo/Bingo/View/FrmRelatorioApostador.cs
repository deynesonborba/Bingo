using Bingo.DAO;
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
    public partial class FrmRelatorioApostador : Form
    {
        public FrmRelatorioApostador()
        {
            InitializeComponent();
        }

        private void FrmRelatorioApostador_Load(object sender, EventArgs e)
        {
            //ApostadorDAO apostadorDao = new ApostadorDAO();
            
            this.rpVApostadores.RefreshReport();
        }
    }
}
