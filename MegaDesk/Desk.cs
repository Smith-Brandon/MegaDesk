using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    enum DesktopMaterial
    {
        Laminate = 100,
        Oak = 200,
        Pine = 50,
        Rosewood = 100,
        Veneer = 125
    };

    class Desk
    {
        int deskSurfaceArea;
        int materialCost;
        int drawerCost;
        int widthMin = 24;
        int widthMax = 96;
        int depthMin = 12;
        int depthMax = 48;
       
        internal int GetSurfaceArea(int width, int depth)
        {
            if((width >= widthMin) && (width <= widthMax) && (depth >= depthMin) && (depth <= depthMax))
            {
                deskSurfaceArea = width * depth;
            }
                
            return deskSurfaceArea;
        }
        internal int GetMaterialCost(string material)
        {
            if (material == "Laminate")
            {
                materialCost = 100;
            }
            else if (material == "Oak")
            {
                materialCost = 200;
            }
            else if (material == "Pine")
            {
                materialCost = 50;
            }
            else if (material == "Rosewood")
            {
                materialCost = 100;
            }
            else
            {
                materialCost = 125;
            }
            return materialCost;
        }
        internal int GetDrawerCost(int drawers)
        {
            drawerCost = drawers * 50;
            return drawerCost;
        }
    }
}
