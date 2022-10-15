using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_2
{
    public partial class ViewAllQuotes : Form
    {
        private readonly MainMenu mainMenu1;
        public ViewAllQuotes(MainMenu mainMenu)
        {
            InitializeComponent();
            mainMenu1 = mainMenu;
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            mainMenu1.Show();
            Hide();
        }

        private void ViewAllQuotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {
            DataTable datatable = DgridView();

            dataGridView.DataSource = datatable;         


        }
        public DataTable DgridView()
        {
            StreamReader sr = new StreamReader(@"Data\quotes.json");
            string json = sr.ReadToEnd();
            dynamic table = JsonConvert.DeserializeObject(json);
            DataTable newTable = new DataTable();
            newTable.Columns.Add("Date", typeof(string));
            newTable.Columns.Add("Name", typeof(string));
            newTable.Columns.Add("Material", typeof(string));
            newTable.Columns.Add("Width", typeof(string));
            newTable.Columns.Add("Depth", typeof(string));
            newTable.Columns.Add("Drawers", typeof(string));
            newTable.Columns.Add("Production", typeof(string));
            newTable.Columns.Add("Price", typeof(string));


            foreach (var row in table)
            {
                newTable.Rows.Add(row.QuoteDate, row.CustomerName, row.DesktopMaterial, row.Width, row.Depth, row.Drawers, row.ProductionDays, row.Price);
            }
            return newTable;
        }

    } 
    
}
