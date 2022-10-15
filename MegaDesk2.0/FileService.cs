using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization.Formatters.Binary;
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
        private const string JsonQuotesFile = @"Data\quotes.json";
        public QuotesList Quoteslist {get => _quotesList; set => _quotesList = value; }


        public FileService()
        {
            _quotesList = new QuotesList();
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

        public DeskQuote ReadQuotesAndLoopThrough(string searchMaterial)
        {
            ReadFromFile();
            List<DeskQuote> quotes = _quotesList.DeskQuotes;
            //string result = "";
            for (int i = 0; i < quotes.Count; i++)
            {
                if (quotes[i].DesktopMaterial == searchMaterial)
                {
                    
                    
                    return quotes[i];
                }
                
            }

            return null;

            //foreach (DeskQuote deskquote in _quotesList.DeskQuotes)
            //{
            //    deskquote.DesktopMaterial.IndexOf(searchMaterial);
            //    if (deskquote.DesktopMaterial == searchMaterial)
            //}
            //var materialMatch = _quotesList.DeskQuotes.Where(m => m.DesktopMaterial.Equals(searchMaterial));
            //foreach (DeskQuote deskQuote in _quotesMaterialMatch.DeskQuotes)
            //{
            //    // _quotesMaterialMatch.DeskQuotes.Text = deskQuote.ToString();
            //    SearchQuotes.searchResult = deskQuote.ToString();
            //}

            //// display in searchQuote that there aew no order matches for that material
            //SearchQuotes.searchResult = ($"There are currently no orders with {searchMaterial}");

        }
        }
    
    }

