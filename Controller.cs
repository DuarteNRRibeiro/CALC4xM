using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc4xM
{

    class Controller{
        Model model;
        View view;
        ViewCalc viewCalc;
        ViewGraph viewGraph;

        public Controller() {
            model = new Model(this, view, viewCalc, viewGraph);
            view = new View(this, model);
            viewCalc = new ViewCalc(this, model);
            viewGraph = new ViewGraph(this, model);
        }
        
        public void IniciarPrograma(){
            //Implementar
            view.AtivarInterface();
        }

        public void UtilizadorClicouNoBotaoCalculadora(){
            //Implementar
            
        }
    }
}
