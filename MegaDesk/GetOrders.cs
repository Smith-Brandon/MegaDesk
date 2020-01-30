using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MegaDesk
{
    class GetOrders
    {
        //Max Orders allowed
        const int MAX_ORDERS = 200;

        //Structure to feed data from file into
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

        internal Array GetOrderArray() {
            int counter = 1;
            StreamReader AllQuotesDoc = new StreamReader("AllQuotes.txt");
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
            return Orders;
        }
        
    
    }
}
