using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc4xM
{
    public partial class View : Form
    {
        private Controller controller;
        private Model model;
        internal View(Controller c, Model m)
        {
            controller = c;
            model = m;
        }

        public void AtivarInterface(){
            //Conectar os objetos do model e do Controller
            //Desenhar janelas e botões ocorre no código automático da API WindForms
            //A animação do clique do botão é gerada pelo código da API WinForms
        }
    }
}
