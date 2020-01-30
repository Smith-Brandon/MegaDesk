using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MegaDesk
{
    public partial class AddQuote : Form
    {
        string name = "";
        int width;
        int depth;
        int drawers = 0;
        string material;
        int rush = 0;
        int totalCost;

        int widthMin = 24;
        int widthMax = 96;
        int depthMin = 12;
        int depthMax = 48;
        MegaDesk.Desk d = new Desk();
        MegaDesk.DeskQuote dq = new DeskQuote();
        
        public AddQuote()
        {
            InitializeComponent();
        }

        public void submitQuote() 
        {
            // Pull data from form
            name = nameField.Text;
            width = Convert.ToInt32(widthNum.Value);
            depth = Convert.ToInt32(depthNum.Value);
            drawers = int.Parse(drawersString.Text);
            material = materialString.Text;
            rush = int.Parse(rushString.Text);


            #region          
            // The required try and catch which makes 
            // things more difficult than it needs to be
            try
            {
                
                //if ((material != "Oak") || (material != "Laminate") || (material != "Rosewood") || (material != "Veneer") || (material != "Pine"))
                if(String.IsNullOrEmpty(material))
                {
                    throw new Exception("Surface Material not selected.");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);                
                this.Close();
            }

            // This section stops the form from allowing users to enter invalid data
            if (name == "") {
                MessageBox.Show("Please enter your name.");
            }
            else if ((width == 0) || (width < widthMin) || (width > widthMax)) {
                MessageBox.Show("You must enter a valid Width between 24 and 96.");
            }
            else if ((depth == 0) || (depth < depthMin) || (depth > depthMax))
            {
                MessageBox.Show("You must enter a valid Depth between 12 and 48.");
            }
            #endregion
            else
            {
                calculateTotal(name, width, depth, drawers, material, rush);
            }

}
        public void calculateTotal(string name, int width, int depth, int drawers, string material, int rush)
        {
            //Test with Desk Class
            int deskArea = d.GetSurfaceArea(width, depth);
            int materialCost = d.GetMaterialCost(material);
            int drawerCost = d.GetDrawerCost(drawers);

            totalCost = dq.CalculateQuote(deskArea, materialCost, drawerCost, rush);
            
            // Stream Info to AllQuotes.txt
            StreamWriter AllQuotesDoc = File.AppendText("AllQuotes.json");

            AllQuotesDoc.WriteLine("Name: " + name);
            AllQuotesDoc.WriteLine(material);
            AllQuotesDoc.WriteLine(DateTime.Now);
            AllQuotesDoc.WriteLine("Width: " + width);
            AllQuotesDoc.WriteLine("Depth: " + depth);
            AllQuotesDoc.WriteLine("Drawers: " + drawers);
            AllQuotesDoc.WriteLine("Rush Time: " + rush);
            AllQuotesDoc.WriteLine("Total Cost: " + totalCost);           
            AllQuotesDoc.Close();

            DisplayQuote CurrentQuote = new DisplayQuote(width, depth, drawers, material, rush, totalCost);
            CurrentQuote.Tag = this;
            CurrentQuote.Show(this);
        }
        private void Submit_Click(object sender, EventArgs e)
        {
            submitQuote();
        }
    }
}
