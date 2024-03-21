using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Formula1 {
    public partial class Form1 : Form
    {
        double numEtapas = 1;
        
        public Form1()
        {
            InitializeComponent();
        }

        private int randomizacao()
        {
            Random aleatorio = new Random();
            return aleatorio.Next(0, 20);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            lblConfianca.Text = "O quão confiante está com a vitória?";
            lblPiloto.Text = "Você confiou no...";
            txtConta.Text = "0,00";
            txtConta.Enabled = true;
            lblConta.Text = "Insira sua conta atual:";
            lblVencedor.Text = "Vencedor: ";
            tkbDinheiro.Value = 0;
            pcbPiloto.Image = Properties.Resources.driverlineup;
            pcbVencedor.Image = Properties.Resources.vencedor;
        }

        private void tkbDinheiro_Scroll(object sender, EventArgs e)
        {
            tkbDinheiro.BackColor = Color.FromArgb(0, tkbDinheiro.Value, 0);
            double aposta = tkbDinheiro.Value * 4;
            txtDinheiro.Text = aposta.ToString("C", new System.Globalization.CultureInfo("pt-BR"));

            converterMoeda();
            
        }

        private void ddlSelecionar_SelectedIndexChanged(object sender, EventArgs e)
        {
            selecionarPilotos();
        }

        private void semApostar()
        {
            converterMoeda();
            if (ddlSelecionar.SelectedIndex == -1 || tkbDinheiro.Value == 0)
            {
                lblVencedor.Text = "Vencedor: ";
                lblConta.Text = "Insira sua conta atual: ";
                txtConta.Text = "0,00";
                tkbDinheiro.Value = 0;
                lblConfianca.Text = "O quão confiante está com a vitória?";
                pcbPiloto.Image = Properties.Resources.driverlineup;
                pcbVencedor.Image = Properties.Resources.vencedor; 
            }
            else
            {
                numEtapas += 1;
            }

            if (ddlSelecionar.SelectedIndex == -1 )
            {
                MessageBox.Show("Não selecionou nenhum piloto para apostar!", "Piloto indefinido");
            }
            
            if (tkbDinheiro.Value == 0)
            {
                MessageBox.Show("Não selecionou nenhuma quantia de dinheiro para apostar!", "Aposta indefinida");
            }
        }

        private void btnApostar_Click(object sender, EventArgs e)
        {
            int numPiloto = randomizacao();

            exibirVencedor();

            double conta, total;

            double aposta = Convert.ToDouble(tkbDinheiro.Value) * 4;
            conta = double.Parse(txtConta.Text);

            if (numPiloto == ddlSelecionar.SelectedIndex)
            {
                lblConfianca.Text = "Parabéns! Seu piloto venceu a corrida";
                total = conta + aposta;
            }
            else
            {
                lblConfianca.Text = "Que pena! Algm perdeu uma grana";
                total = conta - aposta;
            }

            txtConta.Text = Convert.ToString(total);

            txtConta.Enabled = false;
            lblConta.Text = "Aposte c/ moderação";

            calendario();
            semApostar();
        }

        private void ddlMoeda_SelectedIndexChanged(object sender, EventArgs e)
        {
            converterMoeda();
        }

        private void converterMoeda()
        {
            double aposta = tkbDinheiro.Value * 4;
            if (ddlMoeda.SelectedIndex == 0)
            {
                txtDinheiro.Text = aposta.ToString("C", new System.Globalization.CultureInfo("pt-BR"));
            }
            if (ddlMoeda.SelectedIndex == 1)
            {
                txtDinheiro.Text = aposta.ToString("C", new System.Globalization.CultureInfo("en-US"));
            }
            if (ddlMoeda.SelectedIndex == 2)
            {
                txtDinheiro.Text = aposta.ToString("C", new System.Globalization.CultureInfo("fr-FR"));
            }
            if (ddlMoeda.SelectedIndex == 3)
            {
                txtDinheiro.Text = aposta.ToString("C", new System.Globalization.CultureInfo("ja-JP"));
            }
            if (ddlMoeda.SelectedIndex == 4)
            {
                txtDinheiro.Text = aposta.ToString("C", new System.Globalization.CultureInfo("en-GB"));
            }
            if (ddlMoeda.SelectedIndex == 5)
            {
                txtDinheiro.Text = aposta.ToString("C", new System.Globalization.CultureInfo("zh-CN"));
            }
            if (ddlMoeda.SelectedIndex == 6)
            {
                txtDinheiro.Text = aposta.ToString("C", new System.Globalization.CultureInfo("es-VE"));
            }
            if (ddlMoeda.SelectedIndex == 7)
            {
                txtDinheiro.Text = aposta.ToString("N8");
            }
        }

        private void selecionarPilotos()
        {

            lblPiloto.Text = "Você confiou no " + ddlSelecionar.SelectedItem;

            if (ddlSelecionar.SelectedIndex == 0)
            {
                pcbPiloto.Image = Properties.Resources.verstappen;
            }
            else if (ddlSelecionar.SelectedIndex == 1)
            {
                pcbPiloto.Image = Properties.Resources.perez;
            }
            else if (ddlSelecionar.SelectedIndex == 2)
            {
                pcbPiloto.Image = Properties.Resources.lecrerc;
            }
            else if (ddlSelecionar.SelectedIndex == 3)
            {
                pcbPiloto.Image = Properties.Resources.sainz;
            }
            else if (ddlSelecionar.SelectedIndex == 4)
            {
                pcbPiloto.Image = Properties.Resources.hamilton;
            }
            else if (ddlSelecionar.SelectedIndex == 5)
            {
                pcbPiloto.Image = Properties.Resources.russell;
            }
            else if (ddlSelecionar.SelectedIndex == 6)
            {
                pcbPiloto.Image = Properties.Resources.norris;
            }
            else if (ddlSelecionar.SelectedIndex == 7)
            {
                pcbPiloto.Image = Properties.Resources.piastri;
            }
            else if (ddlSelecionar.SelectedIndex == 8)
            {
                pcbPiloto.Image = Properties.Resources.bottas;
            }
            else if (ddlSelecionar.SelectedIndex == 9)
            {
                pcbPiloto.Image = Properties.Resources.zhou;
            }
            else if (ddlSelecionar.SelectedIndex == 10)
            {
                pcbPiloto.Image = Properties.Resources.gasly;
            }
            else if (ddlSelecionar.SelectedIndex == 11)
            {
                pcbPiloto.Image = Properties.Resources.ocon;
            }
            else if (ddlSelecionar.SelectedIndex == 12)
            {
                pcbPiloto.Image = Properties.Resources.tsunoda;
            }
            else if (ddlSelecionar.SelectedIndex == 13)
            {
                pcbPiloto.Image = Properties.Resources.devries;
            }
            else if (ddlSelecionar.SelectedIndex == 14)
            {
                pcbPiloto.Image = Properties.Resources.magnussen;
            }
            else if (ddlSelecionar.SelectedIndex == 15)
            {
                pcbPiloto.Image = Properties.Resources.hulkenberg;
            }
            else if (ddlSelecionar.SelectedIndex == 16)
            {
                pcbPiloto.Image = Properties.Resources.stroll;
            }
            else if (ddlSelecionar.SelectedIndex == 17)
            {
                pcbPiloto.Image = Properties.Resources.alonso;
            }
            else if (ddlSelecionar.SelectedIndex == 18)
            {
                pcbPiloto.Image = Properties.Resources.albon;
            }
            else if (ddlSelecionar.SelectedIndex == 19)
            {
                pcbPiloto.Image = Properties.Resources.sargeant;
            }

        }

        private void exibirVencedor()
        {
            int numPiloto = randomizacao();
            string msgvencedor = "Vencedor: ";

            if (ddlSelecionar.SelectedIndex == -1)
            {
                // semApostar();
            }
            else if (numPiloto == 0)
            {
                pcbVencedor.Image = Properties.Resources.verstappen;
                lblVencedor.Text = msgvencedor + "Verstappen";
            }
            else if (numPiloto == 1)
            {
                pcbVencedor.Image = Properties.Resources.perez;
                lblVencedor.Text = msgvencedor + "Perez";
            }
            else if (numPiloto == 2)
            {
                pcbVencedor.Image = Properties.Resources.lecrerc;
                lblVencedor.Text = msgvencedor + "Lecrerc";
            }
            else if (numPiloto == 3)
            {
                pcbVencedor.Image = Properties.Resources.sainz;
                lblVencedor.Text = msgvencedor + "Sainz";
            }
            else if (numPiloto == 4)
            {
                pcbVencedor.Image = Properties.Resources.hamilton;
                lblVencedor.Text = msgvencedor + "Hamilton";
            }
            else if (numPiloto == 5)
            {
                pcbVencedor.Image = Properties.Resources.russell;
                lblVencedor.Text = msgvencedor + "Russell";
            }
            else if (numPiloto == 6)
            {
                pcbVencedor.Image = Properties.Resources.norris;
                lblVencedor.Text = msgvencedor + "Norris";
            }
            else if (numPiloto == 7)
            {
                pcbVencedor.Image = Properties.Resources.piastri;
                lblVencedor.Text = msgvencedor + "Piastri";
            }
            else if (numPiloto == 8)
            {
                pcbVencedor.Image = Properties.Resources.bottas;
                lblVencedor.Text = msgvencedor + "Bottas";
            }
            else if (numPiloto == 9)
            {
                pcbVencedor.Image = Properties.Resources.zhou;
                lblVencedor.Text = msgvencedor + "Zhou";
            }
            else if (numPiloto == 10)
            {
                pcbVencedor.Image = Properties.Resources.gasly;
                lblVencedor.Text = msgvencedor + "Gasly";
            }
            else if (numPiloto == 11)
            {
                pcbVencedor.Image = Properties.Resources.ocon;
                lblVencedor.Text = msgvencedor + "Ocon";
            }
            else if (numPiloto == 12)
            {
                pcbVencedor.Image = Properties.Resources.tsunoda;
                lblVencedor.Text = msgvencedor + "Tsunoda";
            }
            else if (numPiloto == 13)
            {
                pcbVencedor.Image = Properties.Resources.devries;
                lblVencedor.Text = msgvencedor + "De Vries";
            }
            else if (numPiloto == 14)
            {
                pcbVencedor.Image = Properties.Resources.magnussen;
                lblVencedor.Text = msgvencedor + "Magnussen";
            }
            else if (numPiloto == 15)
            {
                pcbVencedor.Image = Properties.Resources.hulkenberg;
                lblVencedor.Text = msgvencedor + "Hulkenberg";
            }
            else if (numPiloto == 16)
            {
                pcbVencedor.Image = Properties.Resources.stroll;
                lblVencedor.Text = msgvencedor + "Stroll";
            }
            else if (numPiloto == 17)
            {
                pcbVencedor.Image = Properties.Resources.alonso;
                lblVencedor.Text = msgvencedor + "Alonso";
            }
            else if (numPiloto == 18)
            {
                pcbVencedor.Image = Properties.Resources.albon;
                lblVencedor.Text = msgvencedor + "Albon";
            }
            else if (numPiloto == 19)
            {
                pcbVencedor.Image = Properties.Resources.sargeant;
                lblVencedor.Text = msgvencedor + "Sargeant";
            }

        }

        private void calendario()
        {
            string msgPrxEtapa = "Próxima etapa: ";

            if (numEtapas == 1)
            {
                lblEtapa.Text = msgPrxEtapa + "Japão";
                lblEtapa.ForeColor = Color.White;
                mthCalendario.TodayDate = new DateTime(2023, 9, 24);
                mthCalendario.SelectionRange = new SelectionRange(
                    new DateTime(2023, 9, 18),
                    new DateTime(2023, 9, 24)
                );
            }

            if (numEtapas == 2)
            {
                lblEtapa.Text = msgPrxEtapa + "Qatar";
                lblEtapa.ForeColor = Color.Maroon;
                mthCalendario.TodayDate = new DateTime(2023, 10, 8);
                mthCalendario.SelectionRange = new SelectionRange(
                    new DateTime(2023, 9, 24),
                    new DateTime(2023, 10, 8)
                );
            }
            if (numEtapas == 3)
            {
                lblEtapa.Text = msgPrxEtapa + "EUA";
                lblEtapa.ForeColor = Color.Blue;
                mthCalendario.TodayDate = new DateTime(2023, 10, 22);
                mthCalendario.SelectionRange = new SelectionRange(
                    new DateTime(2023, 10, 8),
                    new DateTime(2023, 10, 22)
                );
            }
            if (numEtapas == 4)
            {
                lblEtapa.Text = msgPrxEtapa + "México";
                lblEtapa.ForeColor = Color.Green;
                mthCalendario.TodayDate = new DateTime(2023, 10, 29);
                mthCalendario.SelectionRange = new SelectionRange(
                    new DateTime(2023, 10, 22),
                    new DateTime(2023, 10, 29)
                );
            }
            if (numEtapas == 5)
            {
                lblEtapa.Text = msgPrxEtapa + "Brasil";
                lblEtapa.ForeColor = Color.Yellow;
                mthCalendario.TodayDate = new DateTime(2023, 11, 5);
                mthCalendario.SelectionRange = new SelectionRange(
                    new DateTime(2023, 10, 29),
                    new DateTime(2023, 11, 5)
                );
            }
            if (numEtapas == 6)
            {
                lblEtapa.Text = msgPrxEtapa + "Las Vegas";
                lblEtapa.ForeColor = Color.Blue;
                mthCalendario.TodayDate = new DateTime(2023, 11, 18);
                mthCalendario.SelectionRange = new SelectionRange(
                    new DateTime(2023, 11, 5),
                    new DateTime(2023, 11, 18)
                );
            }
            if (numEtapas == 7)
            {
                lblEtapa.Text = msgPrxEtapa + "Abu Dhabi";
                lblEtapa.ForeColor = Color.DarkGreen;
                mthCalendario.TodayDate = new DateTime(2023, 11, 26);
                mthCalendario.SelectionRange = new SelectionRange(
                    new DateTime(2023, 11, 18),
                    new DateTime(2023, 11, 26)
                );
            }
            if (numEtapas == 8)
            {
                lblEtapa.Text = msgPrxEtapa + "Bahrain";
                lblEtapa.ForeColor = Color.Red;
                mthCalendario.TodayDate = new DateTime(2024, 3, 2);
                mthCalendario.SelectionRange = new SelectionRange(
                    new DateTime(2023, 11, 26),
                    new DateTime(2024, 3, 2)
                );
            }
            if (numEtapas == 9)
            {
                lblEtapa.Text = msgPrxEtapa + "Arábia Saudita";
                lblEtapa.ForeColor = Color.DarkSeaGreen;
                mthCalendario.TodayDate = new DateTime(2024, 3, 9);
                mthCalendario.SelectionRange = new SelectionRange(
                    new DateTime(2024, 3, 2),
                    new DateTime(2024, 3, 9)
                );
            }
            if (numEtapas == 10)
            {
                lblEtapa.Text = msgPrxEtapa + "Austrália";
                lblEtapa.ForeColor = Color.DarkSlateBlue;
                mthCalendario.TodayDate = new DateTime(2024, 3, 24);
                mthCalendario.SelectionRange = new SelectionRange(
                    new DateTime(2024, 3, 9),
                    new DateTime(2024, 3, 24)
                );
            }
            if (numEtapas == 11)
            {
                lblEtapa.Text = msgPrxEtapa + "Japão";
                lblEtapa.ForeColor = Color.White;
                mthCalendario.TodayDate = new DateTime(2024, 4, 3);
                mthCalendario.SelectionRange = new SelectionRange(
                    new DateTime(2024, 3, 24),
                    new DateTime(2024, 4, 3)
                );
            }
            if (numEtapas == 12)
            {
                lblEtapa.Text = msgPrxEtapa + "China";
                lblEtapa.ForeColor = Color.Red;
                mthCalendario.TodayDate = new DateTime(2024, 4, 21);
                mthCalendario.SelectionRange = new SelectionRange(
                    new DateTime(2024, 4, 3),
                    new DateTime(2024, 4, 21)
                );
            }
            if (numEtapas == 13)
            {
                lblEtapa.Text = msgPrxEtapa + "Miami";
                lblEtapa.ForeColor = Color.Blue;
                mthCalendario.TodayDate = new DateTime(2024, 5, 4);
                mthCalendario.SelectionRange = new SelectionRange(
                    new DateTime(2024, 4, 21),
                    new DateTime(2024, 5, 4)
                );
            }
            if (numEtapas == 14)
            {
                lblEtapa.Text = msgPrxEtapa + "Ímola";
                lblEtapa.ForeColor = Color.LawnGreen;
                mthCalendario.TodayDate = new DateTime(2024, 5, 19);
                mthCalendario.SelectionRange = new SelectionRange(
                    new DateTime(2024, 5, 4),
                    new DateTime(2024, 5, 19)
                );
            }
            if (numEtapas == 15)
            {
                lblEtapa.Text = msgPrxEtapa + "Mônaco";
                lblEtapa.ForeColor = Color.White;
                mthCalendario.TodayDate = new DateTime(2024, 5, 26);
                mthCalendario.SelectionRange = new SelectionRange(
                    new DateTime(2024, 5, 19),
                    new DateTime(2024, 5, 26)
                );
            }
            if (numEtapas == 16)
            {
                lblEtapa.Text = msgPrxEtapa + "Canadá";
                lblEtapa.ForeColor = Color.Red;
                mthCalendario.TodayDate = new DateTime(2024, 6, 9);
                mthCalendario.SelectionRange = new SelectionRange(
                    new DateTime(2024, 5, 26),
                    new DateTime(2024, 6, 9)
                );
            }
            if (numEtapas == 17)
            {
                lblEtapa.Text = msgPrxEtapa + "Espanha";
                lblEtapa.ForeColor = Color.Yellow;
                mthCalendario.TodayDate = new DateTime(2024, 6, 23);
                mthCalendario.SelectionRange = new SelectionRange(
                    new DateTime(2024, 6, 9),
                    new DateTime(2024, 6, 23)
                );
            }
            if (numEtapas == 18)
            {
                lblEtapa.Text = msgPrxEtapa + "Áustria";
                lblEtapa.ForeColor = Color.White;
                mthCalendario.TodayDate = new DateTime(2024, 6, 30);
                mthCalendario.SelectionRange = new SelectionRange(
                    new DateTime(2024, 6, 23),
                    new DateTime(2024, 6, 30)
                );
            }
            if (numEtapas == 19)
            {
                lblEtapa.Text = msgPrxEtapa + "Inglaterra";
                lblEtapa.ForeColor = Color.AliceBlue;
                mthCalendario.TodayDate = new DateTime(2024, 7, 7);
                mthCalendario.SelectionRange = new SelectionRange(
                    new DateTime(2024, 6, 30),
                    new DateTime(2024, 7, 7)
               );
            }
            if (numEtapas == 20)
            {
                lblEtapa.Text = msgPrxEtapa + "Hungria";
                lblEtapa.ForeColor = Color.LightSeaGreen;
                mthCalendario.TodayDate = new DateTime(2024, 7, 21);
                mthCalendario.SelectionRange = new SelectionRange(
                    new DateTime(2024, 7, 7),
                    new DateTime(2024, 7, 21)
                );
            }
            if (numEtapas == 21)
            {
                lblEtapa.Text = msgPrxEtapa + "Bélgica";
                lblEtapa.ForeColor = Color.LightGoldenrodYellow;
                mthCalendario.TodayDate = new DateTime(2024, 7, 28);
                mthCalendario.SelectionRange = new SelectionRange(
                    new DateTime(2024, 7, 7),
                    new DateTime(2024, 7, 28)
                );
            }
            if (numEtapas == 22)
            {
                lblEtapa.Text = msgPrxEtapa + "Holanda";
                lblEtapa.ForeColor = Color.CadetBlue;
                mthCalendario.TodayDate = new DateTime(2024, 8, 25);
                mthCalendario.SelectionRange = new SelectionRange(
                    new DateTime(2024, 7, 28),
                    new DateTime(2024, 8, 25)
                );
            }
            if (numEtapas == 23)
            {
                lblEtapa.Text = msgPrxEtapa + "Itália";
                lblEtapa.ForeColor = Color.ForestGreen;
                mthCalendario.TodayDate = new DateTime(2024, 9, 1);
                mthCalendario.SelectionRange = new SelectionRange(
                    new DateTime(2024, 8, 25),
                    new DateTime(2024, 9, 1)
                );
            }
            if (numEtapas == 24)
            {
                lblEtapa.Text = msgPrxEtapa + "Azerbaijão";
                lblEtapa.ForeColor = Color.DeepSkyBlue;
                mthCalendario.TodayDate = new DateTime(2024, 9, 15);
                mthCalendario.SelectionRange = new SelectionRange(
                    new DateTime(2024, 9, 1),
                    new DateTime(2024, 9, 15)
                );
            }
            if (numEtapas == 25)
            {
                lblEtapa.Text = "Fim da temporada(Tente novamente)";
                lblEtapa.ForeColor = Color.White;
                mthCalendario.TodayDate = new DateTime(2024, 9, 15);
                mthCalendario.SelectionRange = new SelectionRange(
                    new DateTime(2024, 9, 1),
                    new DateTime(2024, 9, 15)
                );
                numEtapas = 0;
            }

        }

        private void txtConta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                if (((int)e.KeyChar) != ((int)Keys.Back))
                    if (e.KeyChar != ',')
                        e.Handled = true;
                    else if (txtConta.Text.IndexOf(',') > 0)
                        e.Handled = true;
            }
        }
    }
    
}