using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MegaDesk_2
{
    public partial class DisplayQuote : Form
    {
        private MainMenu mainMenu1;
        public DisplayQuote(MainMenu mainMenu, DeskQuote deskQuote)
        {
            InitializeComponent();
            mainMenu1 = mainMenu;
            priceText.Text = "$" + Convert.ToString(deskQuote.Price);
            dateText.Text = deskQuote.QuoteDate;
            nameText.Text = deskQuote.CustomerName;
            widthText.Text = Convert.ToString(deskQuote.Width ) + " in.";
            depthText.Text = Convert.ToString(deskQuote.Depth) + " in.";
            drawersText.Text = Convert.ToString(deskQuote.Drawers);
            materialText.Text = deskQuote.DesktopMaterial;
            if (deskQuote.ProductionDays != 14)
            {
                ProductionDaysText.Text = Convert.ToString(deskQuote.ProductionDays) + " days" ;
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
