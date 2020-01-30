using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    class DeskQuote
    {
        int rushCost;
        int totalCost;
        
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
