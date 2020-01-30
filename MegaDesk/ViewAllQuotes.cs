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
    public partial class ViewAllQuotes : Form
    {
        int counter = 0;

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

        public ViewAllQuotes()
        {
            InitializeComponent();
            ShowListView();

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

        }
        private void ShowListView() {

            this.orderGridView.Visible = false;
            AllQuoteOutput.ResetText();
            StreamReader AllQuotesDoc = new StreamReader("AllQuotes.json");
            while (AllQuotesDoc.EndOfStream == false)
            {
                // Add a space in between orders 
                if (counter == 8)
                {
                    AllQuoteOutput.AppendText(Environment.NewLine);
                    AllQuoteOutput.AppendText(Environment.NewLine);
                    counter = 0;
                }
                counter++;
                string line = AllQuotesDoc.ReadLine();
                AllQuoteOutput.AppendText(line);
                AllQuoteOutput.AppendText(Environment.NewLine);                
            }
            AllQuotesDoc.Close();
        }
        private void showGridView() {

        }
        private void listButton_Click(object sender, EventArgs e)
        {
            AllQuoteOutput.Visible = true;
            orderGridView.Visible = false;
            ShowListView();
        }

        private void gridButton_Click(object sender, EventArgs e)
        {

            AllQuoteOutput.Visible = false;
            orderGridView.Visible = true;

            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Material");
            dt.Columns.Add("Date");
            dt.Columns.Add("Width");
            dt.Columns.Add("Depth");
            dt.Columns.Add("Drawers");
            dt.Columns.Add("Rush");
            dt.Columns.Add("Total");

            for (counter = 0; counter < MAX_ORDERS; counter++)
            {
                DataRow row = dt.NewRow();
                row["Name"] = Orders[counter].name;
                row["Material"] = Orders[counter].material;
                row["Date"] = Orders[counter].date;
                row["Width"] = Orders[counter].width;
                row["Depth"] = Orders[counter].depth;
                row["Drawers"] = Orders[counter].drawers;
                row["Rush"] = Orders[counter].rush;
                row["Total"] = Orders[counter].totalCost;
                dt.Rows.Add(row);
            }
            this.orderGridView.DataSource = dt;
        }
    }
}
