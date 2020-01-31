using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MegaDesk
{
    class DeskQuote
    {
        int rushCost;
        int totalCost;

        struct rushPrices 
        {
            public string rush3_1000;
            public string rush3_2000;
            public string rush3_2001;
            public string rush5_1000;
            public string rush5_2000;
            public string rush5_2001;
            public string rush7_1000;
            public string rush7_2000;
            public string rush7_2001;
        }
        rushPrices[] rushPriceArray = new rushPrices[9];
        internal int GetRushOrder() {

            int counter = 1;
            StreamReader AllQuotesDoc = new StreamReader("AllQuotes.json");

            while (AllQuotesDoc.EndOfStream == false)
            {
                string line = AllQuotesDoc.ReadLine();
                rushPriceArray[counter].rush3_1000 = line;
            }

                return rushCost;
        }

        internal int CalculateQuote(int area, int materialCost, int drawerCost, int rush)
        {

            if (rush == 0)
            {
                rushCost = 0;
            }
            else if (rush == 3)
            {
                if (area < 1000)
                {
                    rushCost = 60;
                }
                else if (area <= 2000)
                {
                    rushCost = 70;
                }
                else if (area > 2000)
                {
                    rushCost = 80;
                }
            }
            else if (rush == 5)
            {
                if (area < 1000)
                {
                    rushCost = 40;
                }
                else if (area <= 2000)
                {
                    rushCost = 50;
                }
                else if (area > 2000)
                {
                    rushCost = 60;
                }
            }
            else if (rush == 7)
            {
                if (area < 1000)
                {
                    rushCost = 30;
                }
                else if (area <= 2000)
                {
                    rushCost = 35;
                }
                else if (area > 2000)
                {
                    rushCost = 40;
                }
            }
            totalCost = 200 + rushCost + area + materialCost + drawerCost;

            return totalCost;
        }
    }
}
