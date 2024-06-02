using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZedGraph;

namespace Calc4xMApp
{
    internal class ModelGraph
    {
        public delegate void NotificarLimparDados();
        public event NotificarLimparDados LimpaDadosCSV;
        public event NotificarLimparDados LimpaDadosManual;

        private ViewGraph viewGraph;
        string tipoGraph;
        string coordenadas;

        public ModelGraph() { viewGraph = new ViewGraph(); }

        public void SetTipoGraph(String tipo)
        {
            tipoGraph = tipo;
        }

        public String GetTipoGraph()
        {
            return tipoGraph;
        }

        public void AddCoordenada(String ponto)
        {
            if (coordenadas == null)
            {
                coordenadas = ponto;
            }
            else
            {
                coordenadas = coordenadas + ";" + ponto;
            }
        }

        public String GetCoordnadas()
        {
            return coordenadas;
        }

        public void ResetCoordnadas()
        {
            coordenadas = null;
        }

        public void LimparDadosCSV(object sender, EventArgs e)
        {
            ResetCoordnadas();
            LimpaDadosCSV();
        }

        public void LimparDadosManual(object sender, EventArgs e)
        {
            ResetCoordnadas();
            LimpaDadosManual();
        }
    }
}
