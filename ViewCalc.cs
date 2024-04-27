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
    public partial class ViewCalc : Form
    {
        private Controller controller;
        private Model model;
        internal ViewCalc(Controller c, Model m)
        {
            controller = c;
            model = m;
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}
