using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc4xMApp
{

    class Controller
    {
        Model model;
        View view;
        ViewCalc viewCalc;
        ModelCalc modelCalc;
        ViewGraph viewGraph;
        ModelGraph modelGraph;

        public Controller()
        {
            model = new Model();
            view = new View();

            viewCalc = new ViewCalc();
            modelCalc = new ModelCalc();
            viewGraph = new ViewGraph();
            modelGraph = new ModelGraph();

            //Ligar o evento da View ao método do Controller
            //de forma desacopolada porque a View não sabe quem responderá ao evento
            view.UtilizadorClicouNoBotaoCalculadora += UtilizadorClicouNoBotaoCalc;
            view.UtilizadorClicouNoBotaoGrafico += UtilizadorClicouNoBotaoGraph;

            viewGraph.UtilizadorClicouNoBotaoRecolhaDadosManual += UtilizadorClicouNoBotaoRecolhaDadosManual;
            viewGraph.UtilizadorClicouNoBotaoRecolhaDadosCSV += UtilizadorClicouNoBotaoRecolhaDadosCSV;

            viewGraph.LimparDadosCSV += modelGraph.LimparDadosCSV;
            modelGraph.LimpaDadosCSV += viewGraph.ClearDataCSV;

            viewGraph.LimparDadosManual += modelGraph.LimparDadosManual;
            modelGraph.LimpaDadosManual += viewGraph.ClearDataManual;

            viewCalc.UtilizadorClicouNumBotaoDaCalculadora += UtilizadorClicouNumBotaoDaCalc;

            modelCalc.EstadoCalculadoraAlterado += viewCalc.AtualizarEstadoCalculadora;
            viewCalc.SolicitarNovoEstadoCalculadora += modelCalc.NovoEstadoCalculadora;

            viewGraph.UtilizadorClicouNumBotaoLoad += UtilizadorClicouNumBotaoLoad;
            viewGraph.SolicitacaoAtualizarNovoGrafico += modelGraph.GetCoordnadas;
        }

        public void IniciarPrograma()
        {
            //Implementar
            view.AtivarInterface();
        }

        //chama o método da view para desenhar a interface da calculadora
        public void UtilizadorClicouNoBotaoCalc(object fonte, System.EventArgs args)
        {
            viewCalc.AtivarViewCalc();
        }

        //chama o método da view para desenhar a interface do gráfico
        public void UtilizadorClicouNoBotaoGraph(object fonte, System.EventArgs args)
        {
            viewGraph.AtivarViewGraph();
        }

        //chama o método do model
        public void UtilizadorClicouNumBotaoDaCalc(object fonte, String textoBotao)
        {
            modelCalc.AtualizarEstadoDaCalculadora(textoBotao);
        }

        //chama o método da view para desenhar a interface do Recolha Dados Manual
        private void UtilizadorClicouNoBotaoRecolhaDadosManual(object sender, EventArgs e)
        {
            modelGraph.SetTipoGraph(viewGraph.GetTipoGraph());
            viewGraph.AtivarRecolhaDadosManual();
        }

        //chama o método da view para desenhar a interface do Recolha Dados CSV
        public void UtilizadorClicouNoBotaoRecolhaDadosCSV(object fonte, System.EventArgs args)
        {
            viewGraph.AtivarRecolhaDadosCSV();
        }

        //chama o método do model
        public void UtilizadorClicouNumBotaoLoad(object sender, String args)
        {
            modelGraph.AddCoordenada(args);
        }
    }
}
