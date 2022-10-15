using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace MegaDesk_2
{
    public partial class SearchQuotes : Form
    {
        private MainMenu mainMenu1;
        public static string DeskMaterial;
        public SearchQuotes(MainMenu mainMenu)
        {
            InitializeComponent();
            mainMenu1 = mainMenu;
            ComboBoxMaterialsSearch.DataSource = Enum.GetNames(typeof(DesktopMaterial));
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            mainMenu1.Show();
            Hide();
        }

        private void SearchQuotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            FileService fileService = new FileService();
            var material = ComboBoxMaterialsSearch.Text;
            DeskQuote deskQuote = fileService.ReadQuotesAndLoopThrough(material);
            if (deskQuote != null)
            {
                label5.Visible = false;
                groupBox1.Visible = true;
                label2.Text = "$" + Convert.ToString(deskQuote.CalculatePrice());
                nameText.Text = deskQuote.CustomerName;
                dateText.Text = deskQuote.QuoteDate;
                widthText.Text = Convert.ToString(deskQuote.Width);
                depthText.Text = Convert.ToString(deskQuote.Depth);
                materialText.Text = deskQuote.DesktopMaterial;
                drawersText.Text = Convert.ToString(deskQuote.Drawers);
                ProductionDaysText.Text = Convert.ToString(deskQuote.ProductionDays);
            }
            else
            {
                groupBox1.Visible = false;
                label5.Visible = true;
                label5.Text = $"There are currently no orders with {material}";
            }
        }
    }
}
