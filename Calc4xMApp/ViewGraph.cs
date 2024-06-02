using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc4xMApp
{
    public class ViewGraph
    {
        GraphLinhas janelaGrafico;
        RecolhaDadosManual recolhaDadosManual;
        RecolhaDadosCSV recolhaDadosCSV;
        Form pai;
        String tipoGraph;

        public event System.EventHandler<String> UtilizadorClicouNumBotaoLoad;

        public event System.EventHandler UtilizadorClicouNoBotaoRecolhaDadosManual;
        public event System.EventHandler UtilizadorClicouNoBotaoRecolhaDadosCSV;
        public event System.EventHandler UtilizadorClicouNoBotaoFinalizarRecolhaDadosManual;
        public event System.EventHandler UtilizadorClicouNoBotaoFinalizarRecolhaDadosCSV;
        public event System.EventHandler LimparDadosCSV;
        public event System.EventHandler LimparDadosManual;

        public delegate string SolicitacaoAtualizarGrafico();
        public event SolicitacaoAtualizarGrafico SolicitacaoAtualizarNovoGrafico;

        public ViewGraph()
        {
            janelaGrafico = new GraphLinhas();
        }

        internal void AtivarViewGraph()
        {
            janelaGrafico = new GraphLinhas();
            janelaGrafico.ViewGraph = this;
            janelaGrafico.ShowDialog();
        }

        internal void AtivarRecolhaDadosManual()
        {
            recolhaDadosManual = new RecolhaDadosManual(tipoGraph);
            recolhaDadosManual.ViewGraph = this;
            recolhaDadosManual.ShowDialog();
        }

        internal void AtivarRecolhaDadosCSV()
        {
            recolhaDadosCSV = new RecolhaDadosCSV(tipoGraph);
            recolhaDadosCSV.ViewGraph = this;
            recolhaDadosCSV.ShowDialog();
        }

        //definir tipo de grafico
        public void SetTipoGraph(String tipo)
        {
            tipoGraph = tipo;
        }

        public String GetTipoGraph()
        {
            return tipoGraph;
        }
        //inicia o form RecolhaDadosManual
        public void CliqueNoBotaoRecolhaDadosManual(object origem, EventArgs e)
        {
            UtilizadorClicouNoBotaoRecolhaDadosManual(origem, e);
        }
        //inicia o form RecolhaDadosCSV
        public void CliqueNoBotaoRecolhaDadosCSV(object origem, EventArgs e)
        {
            UtilizadorClicouNoBotaoRecolhaDadosCSV(origem, e);
        }

        public void CliqueNoBotaoFinalizarRecolhaDadosManual(object origem, EventArgs e)
        {
            UtilizadorClicouNoBotaoFinalizarRecolhaDadosManual(origem, e);
        }

        public void CliqueNoBotaoFinalizarRecolhaDadosCSV(object origem, EventArgs e)
        {
            UtilizadorClicouNoBotaoFinalizarRecolhaDadosCSV(origem, e);
        }

        public void LimparOsDadosCSV(object origem, EventArgs e)
        {
            LimparDadosCSV(origem, e);
        }

        public void ClearDataCSV()
        {
            recolhaDadosCSV.LimparDadosCSV();
        }

        public void LimparOsDadosManual(object origem, EventArgs e)
        {
            LimparDadosManual(origem, e);
        }

        public void ClearDataManual()
        {
            recolhaDadosManual.LimparDadosManual();
        }

        //envia os pontos para o model
        public void CliqueNoBotaoLoad(string ponto)
        {
            UtilizadorClicouNumBotaoLoad(this, ponto);
        }

        //resebe a string envida pelo model
        public void AtualizarGrafico()
        {
            //Console.WriteLine("A atualizar estado da Calculadora");
            string coor = SolicitacaoAtualizarNovoGrafico();

            if (recolhaDadosManual != null)
            {
                recolhaDadosManual.AtualizarGrafico(coor);
            }

            if (recolhaDadosCSV != null)
            {
                recolhaDadosCSV.AtualizarGrafico(coor);
            }

        }
    }
}
