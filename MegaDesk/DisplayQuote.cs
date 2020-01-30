using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote(int width, int depth, int drawers, string material, int rush, int totalCost)
        {
            InitializeComponent();
            AreaOutput.Text = (width * depth).ToString();
            DrawerOutput.Text = drawers.ToString();
            SurfaceOutput.Text = material;
            RushOutput.Text = rush.ToString();
            totalCostOutput.Text = totalCost.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
