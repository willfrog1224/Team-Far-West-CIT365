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
        private MainMenu mainMenu1;
        public ViewAllQuotes(MainMenu mainMenu)
        {
            InitializeComponent();
            mainMenu1 = mainMenu;
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            mainMenu1.Show();
            Hide();
        }

        private void ViewAllQuotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {
            FileService fileService = new FileService();
            //fileService.ReadFromFile();
            dataGridView.DataSource = fileService.Quoteslist;
            
        }

     /*   public DataTable jsonDataDiplay()
        {
            FileService fileService = new FileService();
            string json = fileService.ReadFromFile();
            dynamic table = JsonConvert.DeserializeObject(json);
            DataTable newTable = new DataTable();
            newTable.Columns.Add("Width", typeof(string));
            newTable.Columns.Add("Depth", typeof(string));
            newTable.Columns.Add("Drawers", typeof(string));
            newTable.Columns.Add("DesktopMaterial", typeof(string));
            newTable.Columns.Add("ProductionDays", typeof(string));
            newTable.Columns.Add("CustomerName", typeof(string));
            newTable.Columns.Add("QuoteDate", typeof(string));

            foreach (var row in table.value.data)
            {
                newTable.Rows.Add(row.Width, row.Depth, row.Drawers, row.DesktopMaterial, row.ProductionDays, row.CustomerName, row.QuoteDate);
            }
            return newTable;
        }*/
        
    }
}
