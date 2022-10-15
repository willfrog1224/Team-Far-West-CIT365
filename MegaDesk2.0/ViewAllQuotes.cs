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


    }
}
