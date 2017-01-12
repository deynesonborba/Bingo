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
using System.Data.SqlClient;
using Bingo.DAO;

namespace Bingo.View
{
    public partial class FrmRodadas : Form
    {
        int numeroApostadores;
        List<ComboBox> cbxApostadores = new List<ComboBox>();
        bool InseridaCartelasBd = false;

        int pontucaoCartela01 = 0;
        int pontucaoCartela02 = 0;
        int pontucaoCartela03 = 0;
        int pontucaoCartela04 = 0;
        int pontucaoCartela05 = 0;
        int pontucaoCartela06 = 0;
        int pontucaoCartela07 = 0;
        int pontucaoCartela08 = 0;
        int pontucaoCartela09 = 0;
        int pontucaoCartela10 = 0;

        int QuantNumerosSorteados = 0;

        bool primeiroNumSorteado = true;

        List<int> numerosSorteados = new List<int>();

        public FrmRodadas()
        {
            InitializeComponent();
            buscaBrindes();
            btnSorteia.Enabled = false;
        }

        private void buscaBrindes()
        {
            Context con = new Context();
            var listaBrindes = new List<string>();
            Brinde b = new Brinde();
            b.NomeBrinde = "Selecione o brinde";
            listaBrindes.Add(b.NomeBrinde);
            foreach (var brinde in con.Brindes.ToList())
            {
                if (brinde.Situacao == "Disponivel")
                {
                    listaBrindes.Add(brinde.NomeBrinde);
                }
                
            }
            cbxBrindes.DataSource = listaBrindes.ToList();
        }


        private void btnGeraCartelas_Click(object sender, EventArgs e)
        {
            int quantApostadoresSelecionado;
            if (cbxQuantApostadores.SelectedItem == null)
            {
                MessageBox.Show("Selecione quantos apostadores participaram da rodada!");
            }
            else
            {
                quantApostadoresSelecionado = int.Parse(cbxQuantApostadores.SelectedItem.ToString());
                gbxApostadoresNumeros.Controls.Clear();
                InserirApostadores(gbxApostadoresNumeros, quantApostadoresSelecionado);
                numeroApostadores = quantApostadoresSelecionado;
            }
            btnSorteia.Enabled = true;
        }

        private void InserirApostadores(GroupBox gbxApostadoresNumeros, int quantApostadores)
        {
            Random rd = new Random();
            // i é o indice do apostador impresso no combobox
            for (int i = 0; i < quantApostadores; i++)
            {
                Context con = new Context();
                ComboBox cbApostador = new ComboBox();
                var listaApostadores = new List<string>();
                Apostador a = new Apostador();
                a.Nome = "Selecione";
                a.IdApostador = 0;
                listaApostadores.Add(a.Nome);
                foreach (var apostadores in con.Apostadores.ToList())
                {
                    listaApostadores.Add(apostadores.Nome);
                }
                cbApostador.DataSource = listaApostadores.ToList();
                cbApostador.Size = new Size(130, 20);
                cbApostador.Location = new Point(30, 35 * (i + 1));
                cbApostador.Name = i.ToString();
                int distInicial = 200;
                gbxApostadoresNumeros.Controls.Add(cbApostador);
                TextBox txtNumeros = new TextBox();
                txtNumeros.Name = i.ToString();
                txtNumeros.Location = new Point(600, 35 * (i + 1));
                txtNumeros.Size = new Size(200, 20);

                //Com esse método eu garanto que não haverá números iguais em uma mesma cartela.
                List<int> cartelaNumeros = new List<int>();
                int qtd = 10;
                for (int n = 0; n < qtd; n++)
                {
                    int num = rd.Next(1, 100);
                    if (!cartelaNumeros.Contains(num))
                        cartelaNumeros.Add(num);
                    else
                        qtd += 1;
                }

                //j é o indice da numero sorteado impresso na label
                //int[] cartelaNumeros = new int[10];
                //for (int k = 0; k < 10; k++)
                //{
                //  cartelaNumeros[k] = rd.Next(1, 100);
                //}

                cartelaNumeros.Sort();

                //for (int j = 0; j < 10; j++)
                //{
                //    Label lbl = new Label();
                //    lbl.Name = i.ToString() + j.ToString();
                //
                //    lbl.Text = cartelaNumeros[j].ToString();
                //    lbl.Size = new Size(35, 20);
                //    lbl.Location = new Point(distInicial, 35 * (i + 1));
                //    lbl.Font = new Font(lbl.Font.FontFamily, 10, FontStyle.Bold);
                //    lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                //    distInicial += 40;
                //    gbxApostadoresNumeros.Controls.Add(lbl);
                //    txtNumeros.Text += lbl.Text + " ";
                //    txtNumeros.Visible = false;
                //}

                foreach (int j in cartelaNumeros)
                {
                    Label lbl = new Label();
                    lbl.Name = i.ToString() + j.ToString();
                    lbl.Text = j.ToString();
                    lbl.Size = new Size(35, 20);
                    lbl.Location = new Point(distInicial, 35 * (i + 1));
                    lbl.Font = new Font(lbl.Font.FontFamily, 10, FontStyle.Bold);
                    lbl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    distInicial += 40;
                    gbxApostadoresNumeros.Controls.Add(lbl);
                    txtNumeros.Text += lbl.Text + " ";
                    txtNumeros.Visible = false;
                }
                gbxApostadoresNumeros.Controls.Add(txtNumeros);
                cbxApostadores.Add(cbApostador);
            }

        }

        private void btnSorteia_Click(object sender, EventArgs e)
        {
            bool camposValidados = ValidaCampos();

            if (camposValidados && !InseridaCartelasBd)
            {
                InseridaCartelasBd = insereCartelasBd();
            }
            if (camposValidados && InseridaCartelasBd)
            {
                efetuarSorteio();
            }
        }

        private bool insereCartelasBd()
        {
            bool InseridaCartelasBd = true;
            Model.Cartela cartela = new Model.Cartela();

            Object b = cbxBrindes.SelectedItem;
            BrindeDAO brindeDao = new BrindeDAO();
            Brinde brinde = brindeDao.buscarBrindePorNome(b);

            Rodada rodada = new Rodada();
            rodada.IdBrindes = brinde.IdBrindes;
            rodada.DataRodada = DateTime.Now;

            rodada.IdCartela = cartela.IdCartela;
            RodadaDAO rodadaDao = new RodadaDAO();
            rodadaDao.SalvarRodada(rodada);

            foreach (var c in cbxApostadores)
            {
                var nomeApostador = c.SelectedValue;
                ApostadorDAO apostadorDao = new ApostadorDAO();
                Apostador BuscaApostador = apostadorDao.buscarApostadorPeloNome(nomeApostador);
                cartela.IdApostador = BuscaApostador.IdApostador;
                cartela.IdRodadas = rodada.IdRodadas;

                CartelaDAO cartelaDao = new CartelaDAO();
                cartelaDao.SalvarCartela(cartela);

                bool validaInsercao = false; //variavel para verificar se o foreach já foi executado
                foreach (Control d in gbxApostadoresNumeros.Controls)
                {
                    if (!validaInsercao)
                    {
                        if (d.GetType() == typeof(TextBox))
                        {
                            if (d.Name == "0")
                            {
                                cartela.NumerosCartela = d.Text;
                                cartelaDao.AlteraCartela(cartela);
                                validaInsercao = true;
                                d.Name = "0_importado"; //essa alteração é para que após executado a primeira vez ele não entre novamente neste if
                            }
                            if (d.Name == "1")
                            {
                                cartela.NumerosCartela = d.Text;
                                cartelaDao.AlteraCartela(cartela);
                                validaInsercao = true;
                                d.Name = "1_importado";
                            }
                            if (d.Name == "2")
                            {
                                cartela.NumerosCartela = d.Text;
                                cartelaDao.AlteraCartela(cartela);
                                validaInsercao = true;
                                d.Name = "2_importado";
                            }
                            if (d.Name == "3")
                            {
                                cartela.NumerosCartela = d.Text;
                                cartelaDao.AlteraCartela(cartela);
                                validaInsercao = true;
                                d.Name = "3_importado";
                            }
                            if (d.Name == "4")
                            {
                                cartela.NumerosCartela = d.Text;
                                cartelaDao.AlteraCartela(cartela);
                                validaInsercao = true;
                                d.Name = "4_importado";
                            }
                            if (d.Name == "5")
                            {
                                cartela.NumerosCartela = d.Text;
                                cartelaDao.AlteraCartela(cartela);
                                validaInsercao = true;
                                d.Name = "5_importado";
                            }
                            if (d.Name == "6")
                            {
                                cartela.NumerosCartela = d.Text;
                                cartelaDao.AlteraCartela(cartela);
                                validaInsercao = true;
                                d.Name = "6_importado";
                            }
                            if (d.Name == "7")
                            {
                                cartela.NumerosCartela = d.Text;
                                cartelaDao.AlteraCartela(cartela);
                                validaInsercao = true;
                                d.Name = "7_importado";
                            }
                            if (d.Name == "8")
                            {
                                cartela.NumerosCartela = d.Text;
                                cartelaDao.AlteraCartela(cartela);
                                validaInsercao = true;
                                d.Name = "8_importado";
                            }
                            if (d.Name == "9")
                            {
                                cartela.NumerosCartela = d.Text;
                                cartelaDao.AlteraCartela(cartela);
                                validaInsercao = true;
                                d.Name = "9_importado";
                            }
                        }
                    }
                }
            }//foreach no cbx
            return InseridaCartelasBd;
        }//metodo

        private void efetuarSorteio()
        {
            sortearNumero();
            compararNumerosSorteadoComNumerosDasCartelas();
        }

        private void compararNumerosSorteadoComNumerosDasCartelas()
        {
            int indiceLbl = 1;
            String strNomeApostador = null;
            foreach (Control c in gbxApostadoresNumeros.Controls)
            {
                if (c is ComboBox)
                {
                    strNomeApostador = c.Text;
                }
                if (c is Label)
                {
                    if (lblNumeroSorteado.Text == c.Text)
                    {
                        c.ForeColor = System.Drawing.Color.Red;
                        incrementarAcertos(indiceLbl, strNomeApostador);
                    }
                    indiceLbl++;
                }
            }
        }

        private void incrementarAcertos(int indiceLbl, String strNomeApostador)
        {
            if (indiceLbl > 0 && indiceLbl <= 10)
            {
                pontucaoCartela01++;
                if (pontucaoCartela01 == 10)
                {
                    String strNumerosCartela = null;
                    foreach(Control txtCartela in gbxApostadoresNumeros.Controls)
                    {
                        if(txtCartela.Name == "0_importado")
                        {
                            strNumerosCartela = txtCartela.Text;
                        }
                    }
                    salvarGanhadorDaRodada(strNumerosCartela);
                }
            }
            if (indiceLbl > 10 && indiceLbl <= 20)
            {
                pontucaoCartela02++;
                if (pontucaoCartela02 == 10)
                {
                    String strNumerosCartela = null;
                    foreach (Control txtCartela in gbxApostadoresNumeros.Controls)
                    {
                        if (txtCartela.Name == "1_importado")
                        {
                            strNumerosCartela = txtCartela.Text;
                        }
                    }
                    salvarGanhadorDaRodada(strNumerosCartela);
                }
            }
            if (indiceLbl > 20 && indiceLbl <= 30)
            {
                pontucaoCartela03++;
                if (pontucaoCartela03 == 10)
                {
                    String strNumerosCartela = null;
                    foreach (Control txtCartela in gbxApostadoresNumeros.Controls)
                    {
                        if (txtCartela.Name == "2_importado")
                        {
                            strNumerosCartela = txtCartela.Text;
                        }
                    }
                    salvarGanhadorDaRodada(strNumerosCartela);
                }
            }
            if (indiceLbl > 30 && indiceLbl <= 40)
            {
                pontucaoCartela04++;
                if (pontucaoCartela04 == 10)
                {
                    String strNumerosCartela = null;
                    foreach (Control txtCartela in gbxApostadoresNumeros.Controls)
                    {
                        if (txtCartela.Name == "3_importado")
                        {
                            strNumerosCartela = txtCartela.Text;
                        }
                    }
                    salvarGanhadorDaRodada(strNomeApostador);
                }
            }
            if (indiceLbl > 40 && indiceLbl <= 50)
            {
                pontucaoCartela05++;
                if (pontucaoCartela05 == 10)
                {
                    String strNumerosCartela = null;
                    foreach (Control txtCartela in gbxApostadoresNumeros.Controls)
                    {
                        if (txtCartela.Name == "4_importado")
                        {
                            strNumerosCartela = txtCartela.Text;
                        }
                    }
                    salvarGanhadorDaRodada(strNomeApostador);
                }
            }
            if (indiceLbl > 50 && indiceLbl <= 60)
            {
                pontucaoCartela06++;
                if (pontucaoCartela06 == 10)
                {
                    String strNumerosCartela = null;
                    foreach (Control txtCartela in gbxApostadoresNumeros.Controls)
                    {
                        if (txtCartela.Name == "5_importado")
                        {
                            strNumerosCartela = txtCartela.Text;
                        }
                    }
                    salvarGanhadorDaRodada(strNomeApostador);
                }
            }
            if (indiceLbl > 60 && indiceLbl <= 70)
            {
                pontucaoCartela07++;
                if (pontucaoCartela07 == 10)
                {
                    String strNumerosCartela = null;
                    foreach (Control txtCartela in gbxApostadoresNumeros.Controls)
                    {
                        if (txtCartela.Name == "6_importado")
                        {
                            strNumerosCartela = txtCartela.Text;
                        }
                    }
                    salvarGanhadorDaRodada(strNomeApostador);
                }
            }
            if (indiceLbl > 70 && indiceLbl <= 80)
            {
                pontucaoCartela08++;
                if (pontucaoCartela08 == 10)
                {
                    String strNumerosCartela = null;
                    foreach (Control txtCartela in gbxApostadoresNumeros.Controls)
                    {
                        if (txtCartela.Name == "7_importado")
                        {
                            strNumerosCartela = txtCartela.Text;
                        }
                    }
                    salvarGanhadorDaRodada(strNomeApostador);
                }
            }
            if (indiceLbl > 80 && indiceLbl <= 90)
            {
                pontucaoCartela09++;
                if (pontucaoCartela09 == 10)
                {
                    String strNumerosCartela = null;
                    foreach (Control txtCartela in gbxApostadoresNumeros.Controls)
                    {
                        if (txtCartela.Name == "8_importado")
                        {
                            strNumerosCartela = txtCartela.Text;
                        }
                    }
                    salvarGanhadorDaRodada(strNomeApostador);
                }
            }
            if (indiceLbl > 90 && indiceLbl <= 100)
            {
                pontucaoCartela10++;
                if (pontucaoCartela10 == 10)
                {
                    String strNumerosCartela = null;
                    foreach (Control txtCartela in gbxApostadoresNumeros.Controls)
                    {
                        if (txtCartela.Name == "9_importado")
                        {
                            strNumerosCartela = txtCartela.Text;
                        }
                    }
                    salvarGanhadorDaRodada(strNomeApostador);

                    
                }
            }
        }

        private void salvarGanhadorDaRodada(String strNumerosCartela)
        {
            CartelaDAO cartelaDao = new CartelaDAO();
            Model.Cartela cartela = cartelaDao.buscarCartelaPelosNumeros(strNumerosCartela);
            
            ApostadorDAO apostadorDao = new ApostadorDAO();
            Apostador apostador = apostadorDao.buscarApostardorPorId(cartela.IdApostador);

            RodadaDAO rodadaDao = new RodadaDAO();
            Rodada rodada = rodadaDao.buscarRodadaPorId(cartela.IdRodadas);

            BrindeDAO brindeDao = new BrindeDAO();
            Brinde brinde = brindeDao.buscarBrindePorId(rodada.IdBrindes);
            brinde.Situacao = "Sorteado";
            brindeDao.AlteraBrinde(brinde);

            rodada.IdCartela = cartela.IdCartela;
            rodada.NumerosSorteados = strNumerosCartela;
            rodada.QuantNumerosSorteados = QuantNumerosSorteados;

            rodadaDao.AlterarRodada(rodada);
            
            //TESTE DE SAÍDA
            MessageBox.Show("Apostador vencedor: " + apostador.Nome + "\nCartela: " + cartela.NumerosCartela +
                "\nRodada: " + rodada.IdRodadas + "\nData: " + rodada.DataRodada);
            btnSorteia.Enabled = false;
           
        }

        private void sortearNumero()
        {
            Random rd = new Random();
            int num = rd.Next(1, 100);

            if (primeiroNumSorteado)
            {
                numerosSorteados.Add(num);
                primeiroNumSorteado = false;
            }
            else
            {
                bool alterou = true;
                while (alterou)
                {
                    alterou = false;
                    foreach (int listNum in numerosSorteados)
                    {
                        if (num == listNum)
                        {
                            num = rd.Next(1, 100);
                            alterou = true;
                        }
                    }                    
                }
                numerosSorteados.Add(num);
                QuantNumerosSorteados++;
            }
            lblNumeroSorteado.Text = num.ToString();
        }

        private bool ValidaCampos()
        {
            bool camposValidados = true;

            if (cbxBrindes.SelectedIndex == 0)
            {
                MessageBox.Show(" Selecione um Brinde ");
                camposValidados = false;
            }
            else
            {
                foreach (ComboBox c in cbxApostadores)
                {
                    if (c.SelectedIndex == 0)
                    {
                        camposValidados = false;
                    }
                }
                if (!camposValidados)
                    MessageBox.Show(" Selecione um Apostador ");
            }

            return camposValidados;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }//class
}//namespace
