using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Towne
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
    }
}
