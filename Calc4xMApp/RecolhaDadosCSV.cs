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
    public partial class RecolhaDadosCSV : Form
    {
        string tipoGrafico;
        ViewGraph viewGraph;
        IGraph graph = new Graph();
        public RecolhaDadosCSV(string escolhido)
        {
            InitializeComponent();
            tipoGrafico = escolhido;
        }

        //associar a view
        public ViewGraph ViewGraph { get => viewGraph; set => viewGraph = value; }

        private void LoadPath_Click(object sender, EventArgs e)
        {
            //exemplo   ..\..\..\data.csv
            string path = pathBox.Text;

            // Verifica se o caminho não está vazio
            if (!string.IsNullOrWhiteSpace(path))
            {
                // Verifica se o arquivo existe antes de tentar ler
                if (File.Exists(path))
                {
                    LerCSV(path);
                }
                else
                {
                    MessageBox.Show("O arquivo especificado não existe.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, insira um caminho válido para o arquivo CSV.");
            }
        }

        //remover o grafico atual e apresenta o novo
        public void AtualizarGrafico(string coordenadas)
        {
            double[][] coor;
            coor = graph.ConverterString(coordenadas);
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

        //lê o ficheiro csv, converte-o numa string e envia para o model
        private void LerCSV(String path)
        {
            string caminhoFicheiro = @path;
            double x, y;
            StringBuilder coordenadas = new StringBuilder();

            try
            {
                using (StreamReader leitor = new StreamReader(caminhoFicheiro))
                {
                    string linha;
                    while ((linha = leitor.ReadLine()) != null)
                    {
                        viewGraph.CliqueNoBotaoLoad(linha);
                    }
                    leitor.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            viewGraph.AtualizarGrafico();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            viewGraph.LimparOsDadosCSV(this, e);
        }

        private void clearData_Click(object sender, EventArgs e)
        {
            // Limpar os dados
            viewGraph.LimparOsDadosCSV(this, e);
        }

        public void LimparDadosCSV()
        {
            zedGraphControl1.GraphPane.CurveList.Clear();
            zedGraphControl1.GraphPane.GraphObjList.Clear(); // Limpar objetos gráficos adicionais
            zedGraphControl1.AxisChange();
            zedGraphControl1.Invalidate();

            //tipo = string.Empty;
            pathBox.Text = string.Empty;
        }
    }
}
