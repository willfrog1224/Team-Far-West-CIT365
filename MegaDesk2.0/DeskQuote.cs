using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MegaDesk_2
{
    public class DeskQuote
    {
        private string _customerName;
        private string _quoteDate;
        private int _productionDays;
        private Desk _desk;

        public DeskQuote(int productionDays, string customerName, int width, int depth, int drawers, string desktopMaterial)
        {
            _desk = new Desk(width, depth,  drawers, desktopMaterial);
            _customerName = customerName;
            DateTime currentDate = DateTime.Today;
            _quoteDate = currentDate.ToString("MM/dd/yyyy");
            _productionDays = productionDays;
            Width = _desk.Width;
            Depth = _desk.Depth;
            Drawers = _desk.Drawers;
            DesktopMaterial = _desk.DesktopMaterial;
        }

        public int Width { get => _desk.Width; set => _desk.Width = value; }
        public int Depth { get => _desk.Depth; set => _desk.Depth = value; }
        public int Drawers{ get => _desk.Drawers; set => _desk.Drawers = value; }
        public string DesktopMaterial { get => _desk.DesktopMaterial; set => _desk.DesktopMaterial = value; }
        public int ProductionDays { get => _productionDays;}
        public string CustomerName { get => _customerName; }
        public string QuoteDate { get => _quoteDate; }


        
        public double CalculatePrice()
        { 
            int surfaceArea = _desk.Width * _desk.Depth;
            int addedPrice = 0;
            if (surfaceArea > 1000)
            {
                addedPrice = surfaceArea - 1000;
            }

            int drawerTotal = _desk.Drawers * 50;
            int materialCost = 0;
            switch (_desk.DesktopMaterial)
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
