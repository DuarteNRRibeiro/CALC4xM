using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace Calc4xMApp
{
    public partial class GraphLinhas : Form
    {
        ViewGraph viewGraph;
        private RecolhaDadosManual recolhaDadosManual;
        private RecolhaDadosCSV recolhaDadosCSV;
        RecolhaDadosCSV csv;
        string tipo;

        public GraphLinhas()
        {
            InitializeComponent();
        }

        //associar a view
        public ViewGraph ViewGraph { get => viewGraph; set => viewGraph = value; }

        private void GraphDispersao_Click(object sender, EventArgs e)
        {
            tipo = "dispersao";

            //destacar botão quando premido
            ResetButtonColors();
            GraphDispersao.BackColor = Color.Gray;
            GraphDispersao.ForeColor = Color.Green;
        }

        private void GraphLinha_Click(object sender, EventArgs e)
        {
            tipo = "linhas";

            //destacar botão quando premido
            ResetButtonColors();
            GraphLinha.BackColor = Color.Gray;
            GraphLinha.ForeColor = Color.Green;
        }

        private void GraphBarras_Click(object sender, EventArgs e)
        {
            tipo = "barras";

            //destacar botão quando premido
            ResetButtonColors();
            GraphBarras.BackColor = Color.Gray;
            GraphBarras.ForeColor = Color.Green;
        }

        private void button1CarregarDadosManual_Click(object sender, EventArgs e)
        {
            viewGraph.SetTipoGraph(tipo);
            viewGraph.CliqueNoBotaoRecolhaDadosManual(sender, e);
        }

        private void button1CarregarDadosCSV_Click(object sender, EventArgs e)
        {
            viewGraph.SetTipoGraph(tipo);
            viewGraph.CliqueNoBotaoRecolhaDadosCSV(sender, e);
        }

        private void ResetButtonColors()
        {
            //Repor color original
            GraphLinha.BackColor = Color.White;
            GraphLinha.ForeColor = Color.Black;
            GraphBarras.BackColor = Color.White;
            GraphBarras.ForeColor = Color.Black;
            GraphDispersao.BackColor = Color.White;
            GraphDispersao.ForeColor = Color.Black;

            //reativar botões
            button1CarregarDadosManual.Enabled = true;
            button1CarregarDadosCSV.Enabled = true;
        }

    }
}
