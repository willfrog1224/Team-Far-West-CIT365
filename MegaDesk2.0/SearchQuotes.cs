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

namespace MegaDesk_2
{
    public partial class SearchQuotes : Form
    {
        private MainMenu mainMenu1;
        public static string DeskMaterial;
        public SearchQuotes(MainMenu mainMenu)
        {
            InitializeComponent();
            mainMenu1 = mainMenu;
            ComboBoxMaterials.DataSource = Enum.GetNames(typeof(DesktopMaterial));
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

        private void button1_Click(object sender, EventArgs e)
        {
            // search through all quotes in JSON file for matching material, 
            // if matching then display
            // if not a match, ignore
            // if no matches then diplay message that there are no matches for material

        }
    }
}
