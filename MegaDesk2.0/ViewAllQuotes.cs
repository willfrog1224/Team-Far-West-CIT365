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
            QuotesList quotes = new QuotesList();
            FileService fileService = new FileService();
            DataGridView1.DataSource = fileService.getQuotesArray();
            for (int i = 0; i < DataGridView1.ColumnCount; i++)
            {
                DataGridView1.AutoResizeColumn(i);
            }

        }
    } 
    
}
