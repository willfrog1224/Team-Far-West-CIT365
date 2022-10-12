using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;
using TextBox = System.Windows.Forms.TextBox;

namespace MegaDesk_Towne
{
    public partial class AddQuote : Form
    {
        private MainMenu mainMenu1;
        public static string CustomerName;
        public static int DeskWidth;
        public static int Depth;
        public static int Drawers;
        public static string DeskMaterial
            ;
        public static int ProductionDays = 14;
        

        public AddQuote(MainMenu mainMenu)
        {
            InitializeComponent();
            mainMenu1 = mainMenu;
            ComboBoxMaterials.DataSource = Enum.GetNames(typeof(DesktopMaterial));
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                DeskQuote deskQuote = new DeskQuote(ProductionDays, CustomerName, DeskWidth, Depth, Drawers, DeskMaterial);
                DisplayQuote displayQuoteForm = new DisplayQuote(mainMenu1, deskQuote);
                var list = JsonConvert.DeserializeObject<ListBox<(DeskQuote)>>("qoutes.json");
                displayQuoteForm.Show();
                Hide();
            }
        }

        private void CustomerNameInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void DeskWidthInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void DepthInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ComboBoxDrawers_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ComboBoxMaterials_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void DaysComboBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            ProductionDays = 14;
            DaysComboBox.Text = "";
            if (CheckBox1.Checked)
            {
                rushOrderDaysLabel.Visible = true;
                DaysComboBox.Visible = true;
            }
            else if (!CheckBox1.Checked)
            {
                rushOrderDaysLabel.Visible = false;
                DaysComboBox.Visible = false;
                errorProvider1.SetError(DaysComboBox, "");
            }
        }
        private void CustomerNameInput_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                CustomerName = CustomerNameInput.Text;

                if (CustomerName.Equals(""))
                {
                    errorProvider1.SetError(CustomerNameInput, "Please enter a Full Name");
                    e.Cancel = true;

                }
                else
                {
                    errorProvider1.SetError(CustomerNameInput, "");
                    e.Cancel = false;
                }
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(CustomerNameInput, ex.Message);
                e.Cancel = true;

            }
        }

        private void DeskWidthInput_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                DeskWidth = Convert.ToInt32(DeskWidthInput.Text);
                if (DeskWidth >= 24 && DeskWidth <= 96)
                {
                    errorProvider1.SetError(DeskWidthInput, "");
                    e.Cancel = false;
                }
                else
                {
                    errorProvider1.SetError(DeskWidthInput, "Please enter a width between 24 - 96 in.");
                    e.Cancel = true;
                }

            }
            catch (Exception ex)
            {
                if (DeskWidthInput.Text.Equals(""))
                {
                    errorProvider1.SetError(DeskWidthInput, "Please enter a width between 24 - 96 in.");
                    e.Cancel = false;
                }
                else
                {
                    errorProvider1.SetError(DeskWidthInput, ex.Message);
                }
                e.Cancel = true;
            }
        }

        private void DepthInput_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                Depth = Convert.ToInt32(DepthInput.Text);
                if (Depth >= 12 && Depth <= 48)
                {
                    errorProvider1.SetError(DepthInput, "");
                    e.Cancel = false;
                }
                else
                {
                    errorProvider1.SetError(DepthInput, "Please enter a depth between 12 - 48 in.");
                    e.Cancel = true;
                }

            }
            catch (Exception ex)
            {
                if (DepthInput.Text.Equals(""))
                {
                    errorProvider1.SetError(DepthInput, "Please enter a depth between 12 - 48 in.");
                }
                else
                {
                    errorProvider1.SetError(DepthInput, ex.Message);
                }
                e.Cancel = true;
            }

        }

        private void ComboBoxMaterials_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                DeskMaterial = ComboBoxMaterials.Text;
                DesktopMaterial material;
                if (Enum.TryParse(DeskMaterial, out material))
                {
                    errorProvider1.SetError(ComboBoxMaterials, "");
                    e.Cancel = false;
                }
                else
                {
                    errorProvider1.SetError(ComboBoxMaterials, "Please enter a valid Desktop Material");
                    e.Cancel = true;
                }

            }
            catch (Exception ex)
            {
                if (ComboBoxMaterials.Text.Equals(""))
                {
                    errorProvider1.SetError(ComboBoxMaterials, "Please enter a valid Desktop Material");
                }
                else
                {
                    errorProvider1.SetError(ComboBoxDrawers, ex.Message);
                }
                e.Cancel = true;
            }
        }

        private void ComboBoxDrawers_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                Drawers = Convert.ToInt32(ComboBoxDrawers.Text);
                if (Drawers >= 0 && Drawers <= 7)
                {
                    errorProvider1.SetError(ComboBoxDrawers, "");
                    e.Cancel = false;
                }
                else
                {
                    errorProvider1.SetError(ComboBoxDrawers, "Please enter a drawer number between 0 - 7");
                    e.Cancel = true;
                }

            }
            catch (Exception ex)
            {
                if (ComboBoxDrawers.Text.Equals(""))
                {
                    errorProvider1.SetError(ComboBoxDrawers, "Please enter a drawer number between 0 - 7");
                }
                else
                {
                    errorProvider1.SetError(ComboBoxDrawers, ex.Message);
                }
                e.Cancel = true;
            }
        }

        private void DaysComboBox_Validating(object sender, CancelEventArgs e)
        {
            if (CheckBox1.Checked)
            {
                try
                {
                    ProductionDays = Convert.ToInt32(DaysComboBox.Text);
                    if (ProductionDays == 3 || ProductionDays == 5 || ProductionDays == 7)
                    {
                        errorProvider1.SetError(DaysComboBox, "");
                        e.Cancel = false;
                    }
                    else
                    {
                        errorProvider1.SetError(DaysComboBox, "Please choose only between 3, 5, or 7 days");
                        e.Cancel = true;
                    }

                }
                catch (Exception ex)
                {
                    if (DaysComboBox.Text.Equals(""))
                    {
                        errorProvider1.SetError(DaysComboBox, "Please choose only between 3, 5, or 7 days");
                    }
                    else
                    {
                        errorProvider1.SetError(ComboBoxDrawers, ex.Message);
                    }
                    e.Cancel = true;
                }
            }
            
        }


        private void AddQuote_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MenuButton_Click(object sender, EventArgs e)
        {
            mainMenu1.Show();
            this.Hide();
        }

        

        private void AddQuote_Load(object sender, EventArgs e)
        {
            errorProvider1.SetIconAlignment(CustomerNameInput, ErrorIconAlignment.MiddleRight);
            errorProvider1.SetIconAlignment(DeskWidthInput, ErrorIconAlignment.MiddleRight);
            errorProvider1.SetIconAlignment(ComboBoxDrawers, ErrorIconAlignment.MiddleRight);
            errorProvider1.SetIconAlignment(ComboBoxMaterials, ErrorIconAlignment.MiddleRight);
            errorProvider1.SetIconAlignment(DaysComboBox, ErrorIconAlignment.MiddleRight);
        }

        
    }
}

