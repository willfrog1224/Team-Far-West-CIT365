using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MegaDesk_2
{
    public class FileService
    {
        private static QuotesList _quotesList;
        private static QuotesList _quotesMaterialMatch;
        private const string JsonQuotesFile = @"Data\quotes.json";
        

        public FileService()
        {
            _quotesList = new QuotesList();
            _quotesMaterialMatch = new QuotesList();
        }
        public void AddQuoteToFile(DeskQuote deskQuote)
        {
            ReadFromFile();
            AddQuoteToList(deskQuote);
            SaveQuotesListToFile();
        }
        public void ReadFromFile()
        {
            if (File.Exists(JsonQuotesFile))
            {
                try
                {
                    var jsonData = File.ReadAllText(JsonQuotesFile);
                    if (jsonData.Length > 0)
                    {
                        _quotesList.DeskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(jsonData);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            else
            {
                Console.WriteLine("File not found");
            }
        }
        public void AddQuoteToList(DeskQuote deskQuote)
        {
            _quotesList.DeskQuotes.Add(deskQuote);
        }
        public void SaveQuotesListToFile()
        {
            if (File.Exists(JsonQuotesFile))
            {
                try
                {
                    var jsonData = JsonConvert.SerializeObject(_quotesList.DeskQuotes, Formatting.Indented);
                    File.WriteAllText(JsonQuotesFile, jsonData);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            else
            {
                Console.WriteLine("File not found");
            }
        }
        public void ReadQuotesAndLoopThrough()
        {
            

            if (File.Exists(JsonQuotesFile))
            {
                string[] incomingQuotes = File.ReadAllLines(JsonQuotesFile);
                var material = SearchQuotes.material;
                var materialMatch = incomingQuotes.Where(m => m.DesktopMaterial.Equals(material));

                try
                {
                    var jsonData = File.ReadAllText(JsonQuotesFile);
                    if (jsonData.Length > 0)
                    {
                        _quotesMaterialMatch.DeskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(jsonData);
                        foreach (DeskQuote deskQuote in _quotesMaterialMatch.DeskQuotes)
                        {
                         // _quotesMaterialMatch.DeskQuotes.Text = deskQuote.ToString();
                            SearchQuotes.searchResult= deskQuote.ToString();
                        }
                        
                    }
                    else
                    {
                    // display in searchQuote that there aew no order matches for that material
                    SearchQuotes.searchResult = ($"There are currently no orders with {material}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            else
            {
                Console.WriteLine("File not found");
            }
        }
    }
}