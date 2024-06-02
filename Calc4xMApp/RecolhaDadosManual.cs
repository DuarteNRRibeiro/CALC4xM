using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace Calc4xMApp
{
    public partial class RecolhaDadosManual : Form
    {
        ViewGraph viewGraph;
        string tipoGrafico;
        IGraph graph = new Graph();


        public RecolhaDadosManual(string escolhido)
        {
            InitializeComponent();
            tipoGrafico = escolhido;
        }

        //associar a view
        public ViewGraph ViewGraph { get => viewGraph; set => viewGraph = value; }

        private void button1Load_Click(object sender, EventArgs e)
        {
            String ponto = textX.Text + "," + textY.Text;
            viewGraph.CliqueNoBotaoLoad(ponto);
        }

        private void buttonRender_Click(object sender, EventArgs e)
        {
            viewGraph.AtualizarGrafico();
        }

        //remover o grafico atual e apresenta o novo
        public void AtualizarGrafico(string coordenadas)
        {
            double[][] coor;
            coor =graph.ConverterString(coordenadas);
            if (coor == null)
            {
                return;
            }
            LineItem lineItem;
            zedGraphControl1.GraphPane.CurveList.Clear();

            switch (tipoGrafico)
            {
                case "linhas":


                    lineItem = zedGraphControl1.GraphPane.AddCurve("Linhas", coor[0], coor[1], Color.Black, SymbolType.Circle);
                    lineItem.Line.IsVisible = true;

                    zedGraphControl1.GraphPane.Title.Text = $"Linhas";
                    zedGraphControl1.GraphPane.XAxis.Title.Text = "X";
                    zedGraphControl1.GraphPane.YAxis.Title.Text = "Y";

                    zedGraphControl1.AxisChange();
                    zedGraphControl1.Refresh();
                    break;

                case "dispersao":
                    lineItem = zedGraphControl1.GraphPane.AddCurve("Dispersao", coor[0], coor[1], Color.Black, SymbolType.Circle);
                    lineItem.Line.IsVisible = false;

                    zedGraphControl1.GraphPane.Title.Text = $"Dispersao";
                    zedGraphControl1.GraphPane.XAxis.Title.Text = "X";
                    zedGraphControl1.GraphPane.YAxis.Title.Text = "Y";

                    zedGraphControl1.AxisChange();
                    zedGraphControl1.Refresh();
                    break;

                case "barras":
                    zedGraphControl1.GraphPane.AddBar("Barras", coor[0], coor[1], Color.Blue);

                    zedGraphControl1.GraphPane.Title.Text = $"Barras";
                    zedGraphControl1.GraphPane.XAxis.Title.Text = "Horizontal";
                    zedGraphControl1.GraphPane.YAxis.Title.Text = "Vertical";

                    zedGraphControl1.AxisChange();
                    zedGraphControl1.Refresh();
                    break;

                default:
                    Console.WriteLine("Nope");
                    break;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            viewGraph.LimparOsDadosManual(this, e);
        }

        private void ClearDados_Click(object sender, EventArgs e)
        {
            viewGraph.LimparOsDadosManual(this, e);
        }

        public void LimparDadosManual()
        {
            zedGraphControl1.GraphPane.CurveList.Clear();
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();

            textX.Text = string.Empty;
            textY.Text = string.Empty;
        }
    }
}
