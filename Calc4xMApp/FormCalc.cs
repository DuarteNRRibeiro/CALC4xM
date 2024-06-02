using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc4xMApp
{
    public partial class FormCalc : Form
    {
        ViewCalc viewCalc;
        public FormCalc()
        {
            InitializeComponent();
        }

        //associar a view
        public ViewCalc ViewCalc { get => viewCalc; set => viewCalc = value; }

        private void button1_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            string textoBotao = botaoClicado.Text;
            viewCalc.CliqueNumBotaoDaCalculadora(textoBotao);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            string textoBotao = botaoClicado.Text;
            viewCalc.CliqueNumBotaoDaCalculadora(textoBotao);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            string textoBotao = botaoClicado.Text;
            viewCalc.CliqueNumBotaoDaCalculadora(textoBotao);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            string textoBotao = botaoClicado.Text;
            viewCalc.CliqueNumBotaoDaCalculadora(textoBotao);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            string textoBotao = botaoClicado.Text;
            viewCalc.CliqueNumBotaoDaCalculadora(textoBotao);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            string textoBotao = botaoClicado.Text;
            viewCalc.CliqueNumBotaoDaCalculadora(textoBotao);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            string textoBotao = botaoClicado.Text;
            viewCalc.CliqueNumBotaoDaCalculadora(textoBotao);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            string textoBotao = botaoClicado.Text;
            viewCalc.CliqueNumBotaoDaCalculadora(textoBotao);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            string textoBotao = botaoClicado.Text;
            viewCalc.CliqueNumBotaoDaCalculadora(textoBotao);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            string textoBotao = botaoClicado.Text;
            viewCalc.CliqueNumBotaoDaCalculadora(textoBotao);
        }

        private void buttonRaiz_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            string textoBotao = botaoClicado.Text;
            viewCalc.CliqueNumBotaoDaCalculadora(textoBotao);
        }

        private void buttonPerc_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            string textoBotao = botaoClicado.Text;
            viewCalc.CliqueNumBotaoDaCalculadora(textoBotao);
        }

        private void buttonQuad_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            string textoBotao = botaoClicado.Text;
            viewCalc.CliqueNumBotaoDaCalculadora(textoBotao);
        }

        private void buttonInv_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            string textoBotao = botaoClicado.Text;
            viewCalc.CliqueNumBotaoDaCalculadora(textoBotao);
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            string textoBotao = botaoClicado.Text;
            viewCalc.CliqueNumBotaoDaCalculadora(textoBotao);
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            string textoBotao = botaoClicado.Text;
            viewCalc.CliqueNumBotaoDaCalculadora(textoBotao);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            string textoBotao = botaoClicado.Text;
            viewCalc.CliqueNumBotaoDaCalculadora(textoBotao);
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            string textoBotao = botaoClicado.Text;
            viewCalc.CliqueNumBotaoDaCalculadora(textoBotao);
        }

        private void buttonMult_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            string textoBotao = botaoClicado.Text;
            viewCalc.CliqueNumBotaoDaCalculadora(textoBotao);
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            string textoBotao = botaoClicado.Text;
            viewCalc.CliqueNumBotaoDaCalculadora(textoBotao);
        }

        private void buttonAD_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            string textoBotao = botaoClicado.Text;
            viewCalc.CliqueNumBotaoDaCalculadora(textoBotao);
        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            string textoBotao = botaoClicado.Text;
            viewCalc.CliqueNumBotaoDaCalculadora(textoBotao);
        }

        private void buttonVirg_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            string textoBotao = botaoClicado.Text;
            viewCalc.CliqueNumBotaoDaCalculadora(textoBotao);
        }

        private void buttonSinal_Click(object sender, EventArgs e)
        {
            Button botaoClicado = (Button)sender;
            string textoBotao = botaoClicado.Text;
            viewCalc.CliqueNumBotaoDaCalculadora(textoBotao);
        }

        public void AtualizarVisor(string novoEstado)
        {
            textBoxVisor.Text = novoEstado;
        }
    }
}
