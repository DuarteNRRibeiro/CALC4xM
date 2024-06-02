using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc4xMApp
{
    public partial class FormMain : Form
    {
        View view;
        public FormMain()
        {
            InitializeComponent();
        }
        public View View { get => view; set => view = value; }

        private void buttonCalculadora_Click(object sender, EventArgs e)
        {
            view.CliqueNoBotaoCalculadora(sender, e);
        }

        private void buttonGrafico_Click(object sender, EventArgs e)
        {
            view.CliqueNoBotaoGrafico(sender, e);
        }
    }
}
