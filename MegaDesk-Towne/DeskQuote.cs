using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Towne
{
    public class DeskQuote
    {
        
        public string CustomerName;
        public string QuoteDate;
        private static Desk desk;
        public int ProductionDays;

        public DeskQuote(int productionDays, string customerName, int width, int depth, int drawers, string desktopMaterial)
        {
            desk = new Desk(width, depth,  drawers, desktopMaterial);
            ProductionDays = productionDays;
            CustomerName = customerName;
            DateTime currentDate = DateTime.Today;
            QuoteDate = currentDate.ToString("MM/dd/yyyy");
        }

        public int GetWidth()
        {
            return desk.Width;
        }

        public int GetDepth()
        {
            return desk.Depth;
        }

        public int GetDrawers()
        {
            return desk.Drawers;
        }

        public string GetDesktopMaterial()
        {
            return desk.DesktopMaterial;
        }
        public double CalculatePrice()
        { 
            int surfaceArea = GetWidth() * GetDepth();
            int addedPrice = 0;
            if (surfaceArea > 1000)
            {
                addedPrice = surfaceArea - 1000;
            }

            int drawerTotal = desk.Drawers * 50;
            int materialCost = 0;
            switch (desk.DesktopMaterial)
            {
                case "Oak":
                    materialCost = 200;
                    break;
                case "Laminate":
                    materialCost = 100;
                    break;
                case "Pine":
                    materialCost = 50;
                    break;
                case "Rosewood":
                    materialCost = 300;
                    break;
                case "Veneer":
                    materialCost = 125;
                    break;
            }

            double price = 0;
            if (ProductionDays == 0)
            {
                price = 200 + drawerTotal + addedPrice + materialCost;
            }
            else
            {
                int rushCost = 0;
                switch (ProductionDays)
                {
                    case 3:
                        if (surfaceArea < 1000)
                        {
                            rushCost = 60;
                        } else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                        {
                            rushCost = 70;
                        }
                        else
                        {
                            rushCost = 80;
                        }
                        break;
                    case 5:
                        if (surfaceArea < 1000)
                        {
                            rushCost = 40;
                        }
                        else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                        {
                            rushCost = 50;
                        }
                        else
                        {
                            rushCost = 60;
                        }
                        break;
                    case 7:
                        if (surfaceArea < 1000)
                        {
                            rushCost = 30;
                        }
                        else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                        {
                            rushCost = 35;
                        }
                        else
                        {
                            rushCost = 40;
                        }
                        break;
                    default:
                        break;

                }
                price = 200 + drawerTotal + addedPrice + materialCost + rushCost;
            }

            return price;
        }


    }
}
