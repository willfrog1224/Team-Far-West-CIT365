using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_2
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddQuote addQuoteForm = new AddQuote(this);
            addQuoteForm.Show();
            Hide();

        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewAllQuotesForm = new ViewAllQuotes(this);
            viewAllQuotesForm.Show();
            Hide();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            SearchQuotes searchQuotesForm = new SearchQuotes(this);
            searchQuotesForm.Show();
            Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
