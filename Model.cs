using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc4xM
{
    class Model{
        private Controller controller;
        private View view;
        private ViewCalc viewCalc;
        private ViewGraph viewGraph;
        public Model(Controller c, View v, ViewCalc vCalc, ViewGraph vGraph){
            controller = c;
            view = v;
            viewCalc = vCalc;
            viewGraph = vGraph;
        }
    }
}
