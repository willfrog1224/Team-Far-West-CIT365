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
//using System.Text.Json;

namespace MegaDesk_2
{
    public partial class SearchQuotes : Form
    {
        private MainMenu mainMenu1;
        public static string DeskMaterial;
        public static string searchMaterial;

        private const string JsonQuoteFile = @"Data\quotes.json";

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

        /*private static void ReadFromJsonFile()
        {
            if (File.Exists(JsonQuoteFile))
            {
                try
                {
                    var jsonData = File.ReadAllText(JsonQuoteFile);
                    if (jsonData.Length > 0)
                    {
                        QuotesList.DeskQuotes = JsonConvert.DeserializeObject<List<DeskQuotes>>(jsonData);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            else
            {
                Console.WriteLine("Error: Could not find JSON file.");
            }
        }*/

        private void button1_Click(object sender, EventArgs e, List<QuotesList> incomingQuotes)
        {
            // get material from enum
            // search through all quotes in JSON file for material matching with material enum, 
            // if matching then display
            // if not a match, ignore
            // if no matches then diplay message that there are no matches for material


            // changes incoming to incomingQuotes, not workings still but all incoming & incomingQuotes were all the same name at one point
            // Pluralsight on youtube
            var incoming = new List<QuotesList>();

            using (StreamReader m = new StreamReader("quotes.json"))
            {
                var json = m.ReadToEnd();
                incomingQuotes = JsonSerializer.Deserialize<List<QuotesList>>(incomingQuotes);
            }

            if (incomingQuotes != null && incomingQuotes.Count > 0)
            {
                // the StartsWith should be something else to match the desktopMaterial but I don't know what yet
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
            }
        }
    }
}
