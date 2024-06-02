using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc4xMApp
{
    public class View
    {
        private FormMain janelaPrincipal;
        private ViewCalc viewCalc;
        private ViewGraph viewGraph;

        public event System.EventHandler UtilizadorClicouNoBotaoCalculadora;
        public event System.EventHandler UtilizadorClicouNoBotaoGrafico;

        internal View()
        {
            viewCalc = new ViewCalc();
            viewGraph = new ViewGraph();
        }

        public void AtivarInterface()
        {
            janelaPrincipal = new FormMain();
            janelaPrincipal.View = this;
            janelaPrincipal.ShowDialog();
        }

        public void CliqueNoBotaoCalculadora(object origem, EventArgs e)
        {
            UtilizadorClicouNoBotaoCalculadora(origem, e);
        }

        public void CliqueNoBotaoGrafico(object origem, EventArgs e)
        {
            UtilizadorClicouNoBotaoGrafico(origem, e);
        }
    }
}
