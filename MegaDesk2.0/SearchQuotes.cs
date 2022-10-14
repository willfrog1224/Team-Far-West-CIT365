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
using System.IO;
using System.Runtime.CompilerServices;
//using System.Text.Json;

namespace MegaDesk_2
{
    public partial class SearchQuotes : Form
    {
        private MainMenu mainMenu1;
        public static string DeskMaterial;
        public static string searchMaterial;
        public static string material;
        public static string searchResult;


        //private const string JsonQuoteFile = @"Data\quotes.json";

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

        private void button1_Click(object sender, EventArgs e, List<QuotesList> incomingQuotes)
        {
            // get material from enum
            // search through all quotes in JSON file for material matching with material enum, 
            // if matching then display
            // if not a match, ignore
            // if no matches then diplay message that there are no matches for material

            //material = ComboBoxMaterialsSearch.Text;
            FileService fileService = new FileService();
            fileService.ReadQuotesAndLoopThrough();



            /*if (incomingQuotes != null && incomingQuotes.Count > 0)
            {
                var material = ComboBoxMaterialsSearch.Text;
                var materialMatch = incomingQuotes.Where(m => m.DesktopMaterial.Equals(material));
                foreach (var quote in materialMatch)
                {
                    // display in searchQuote
                    // how do we deal with an unknown number of results returning to display on page?
                    searchResult.Text = quote.ToString();
                }
            }
            else
            {
                // display in searchQuote that there aew no order matches for that material
                searchResult.Text = ($"There are currently no orders with {ComboBoxMaterialsSearch.Text}");
            }*/
        }
    }
}
