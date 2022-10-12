using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MegaDesk_Towne
{
    public partial class DisplayQuote : Form
    {
        private MainMenu mainMenu1;
        public static double Price;
        public DisplayQuote(MainMenu mainMenu, DeskQuote deskQuote)
        {
            InitializeComponent();
            mainMenu1 = mainMenu;
            Price = deskQuote.CalculatePrice();
            priceText.Text = "$" + Convert.ToString(Price);
            dateText.Text = deskQuote.QuoteDate;
            nameText.Text = deskQuote.CustomerName;
            widthText.Text = Convert.ToString(deskQuote.GetWidth() ) + " in.";
            depthText.Text = Convert.ToString(deskQuote.GetDepth()) + " in.";
            drawersText.Text = Convert.ToString(deskQuote.GetDrawers());
            materialText.Text = deskQuote.GetDesktopMaterial();
            if (AddQuote.ProductionDays != 14)
            {
                ProductionDaysText.Text = Convert.ToString(AddQuote.ProductionDays) + " days" ;
                ProductionDaysText.Visible = true;
                ProductionDaysLabel.Visible = true;
            }
            else
            {
                ProductionDaysText.Text = Convert.ToString(deskQuote.ProductionDays) + " days";
            }
        }

        private void DisplayQuote_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            mainMenu1.Show();
            Hide();
        }

    }
}
