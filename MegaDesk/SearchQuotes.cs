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
    public partial class SearchQuotes : Form
    {
        enum materials
        { 
        Laminate,
        Oak,
        Rosewood,
        Veneer,
        Pine
        }

        List<materials> materialList = new List<materials>();
        private DataGridView orderGridView = new DataGridView();

        const int MAX_ORDERS = 200;
        struct CustomerOrders
        {
            public string name;
            public string material;
            public string date;
            public string width;
            public string depth;
            public string drawers;
            public string rush;
            public string totalCost;
        };
        CustomerOrders[] Orders = new CustomerOrders[MAX_ORDERS];

        public SearchQuotes()
        {
            InitializeComponent();
            materialList.Add(materials.Laminate);
            materialList.Add(materials.Oak);
            materialList.Add(materials.Rosewood);
            materialList.Add(materials.Veneer);
            materialList.Add(materials.Pine);
            MaterialSelect.DataSource = materialList;
            
                        int counter = 1;
                        StreamReader AllQuotesDoc = new StreamReader("AllQuotes.json");
                        // Read Data from file into an array of CustomerOrders Struct
                        while (AllQuotesDoc.EndOfStream == false)
                        {
                            string line = AllQuotesDoc.ReadLine();
                            Orders[counter].name = line;
                            string line2 = AllQuotesDoc.ReadLine();
                            Orders[counter].material = line2;
                            string line3 = AllQuotesDoc.ReadLine();
                            Orders[counter].date = line3;
                            string line4 = AllQuotesDoc.ReadLine();
                            Orders[counter].width = line4;
                            string line5 = AllQuotesDoc.ReadLine();
                            Orders[counter].depth = line5;
                            string line6 = AllQuotesDoc.ReadLine();
                            Orders[counter].drawers = line6;
                            string line7 = AllQuotesDoc.ReadLine();
                            Orders[counter].rush = line7;
                            string line8 = AllQuotesDoc.ReadLine();
                            Orders[counter].totalCost = line8;

                            counter++;
                        }
                        AllQuotesDoc.Close();
            

            // An attempt to make a reusable class to return an array containing 
            // Customer data. The array is made of the CustomerOrder struct
            /*
            MegaDesk.GetOrders o = new GetOrders();

            OrdersTest = o.GetOrderArray();
            */
        }

        
        private void MaterialSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            String ChosenMat = MaterialSelect.Text;
            int counter;
            // Empty textbox on new selection
            SelectByMatDisplay.Text = "";
            //Search through Orders array by CustomerOrders Struct .material
            for (counter = 0; counter < MAX_ORDERS; counter++)
            {
                if (Orders[counter].material == ChosenMat)
                {
                    //If the material chosen matches the material in the array running in the for loop
                    // Then show the info in Display
                    SelectByMatDisplay.AppendText(Orders[counter].name);
                    SelectByMatDisplay.AppendText(Environment.NewLine);
                    SelectByMatDisplay.AppendText(Orders[counter].material);
                    SelectByMatDisplay.AppendText(Environment.NewLine);
                    SelectByMatDisplay.AppendText(Orders[counter].date);
                    SelectByMatDisplay.AppendText(Environment.NewLine);
                    SelectByMatDisplay.AppendText(Orders[counter].width);
                    SelectByMatDisplay.AppendText(Environment.NewLine);
                    SelectByMatDisplay.AppendText(Orders[counter].depth);
                    SelectByMatDisplay.AppendText(Environment.NewLine);
                    SelectByMatDisplay.AppendText(Orders[counter].drawers);
                    SelectByMatDisplay.AppendText(Environment.NewLine);
                    SelectByMatDisplay.AppendText(Orders[counter].rush);
                    SelectByMatDisplay.AppendText(Environment.NewLine);
                    SelectByMatDisplay.AppendText(Orders[counter].totalCost);
                    SelectByMatDisplay.AppendText(Environment.NewLine);
                    SelectByMatDisplay.AppendText(Environment.NewLine);
                }
                else
                {
                  
                }

            }
        }
    }
}
