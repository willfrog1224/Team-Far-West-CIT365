using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MegaDesk_2
{
    public class DeskQuote
    {
        private string _customerName;
        private string _quoteDate;
        private int _productionDays;
        private Desk _desk;
        private string[,] rushArr = new string[3,3];
        private int _price;

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
            Price = CalculatePrice();
           
        }

        public int Width { get => _desk.Width; set => _desk.Width = value; }
        public int Depth { get => _desk.Depth; set => _desk.Depth = value; }
        public int Drawers{ get => _desk.Drawers; set => _desk.Drawers = value; }
        public string DesktopMaterial { get => _desk.DesktopMaterial; set => _desk.DesktopMaterial = value; }
        public int ProductionDays { get => _productionDays; }
        public string CustomerName { get => _customerName; }
        public string QuoteDate { get => _quoteDate; }
        public int Price { get => _price; set => _price = value; }


        public int CalculatePrice()
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

            int price = 0;
            if (ProductionDays == 0)
            {
                price = 200 + drawerTotal + addedPrice + materialCost;
            }
            else
            {
                string rushCost = "0";
                GetRushOrder();
                switch (ProductionDays)
                {
                    case 3:
                        if (surfaceArea < 1000)
                        {
                            rushCost = this.rushArr[0,0];
                        } else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                        {
                            rushCost = this.rushArr[0,1];
                        }
                        else
                        {
                            rushCost = this.rushArr[0,2];
                        }
                        break;
                    case 5:
                        if (surfaceArea < 1000)
                        {
                            rushCost = this.rushArr[1,0];
                        }
                        else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                        {
                            rushCost = this.rushArr[1,1];
                        }
                        else
                        {
                            rushCost = this.rushArr[1,2];
                        }
                        break;
                    case 7:
                        if (surfaceArea < 1000)
                        {
                            rushCost = this.rushArr[2,0];
                        }
                        else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                        {
                            rushCost = this.rushArr[2,1];
                        }
                        else
                        {
                            rushCost = this.rushArr[2,2];
                        }
                        break;
                    default:
                        break;

                }
                price = 200 + drawerTotal + addedPrice + materialCost + int.Parse(rushCost);
            }

            return price;
        }
        public void GetRushOrder()
        {
            try
            {
                int col = 0;
                int row = 0;

                string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
                string file = "\\Data\\rushOrderPrices.txt";

                string[] prices = File.ReadAllLines(path + file);

                foreach(string cost in prices)
                {
                    this.rushArr[col, row] = cost;
                    row++;

                    if(row == 3)
                    {
                        col++;
                        row = 0;
                    }
                }
            }
            catch(Exception err)
            {
                Debug.WriteLine("Err: " + err);
            }
        }

    }
}
