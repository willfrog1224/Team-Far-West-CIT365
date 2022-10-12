namespace MegaDesk_Towne
{
    partial class AddQuote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.nameLabel = new System.Windows.Forms.Label();
            this.CustomerNameInput = new System.Windows.Forms.TextBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.widthLabel = new System.Windows.Forms.Label();
            this.depthLabel = new System.Windows.Forms.Label();
            this.drawerNumberLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboBoxDrawers = new System.Windows.Forms.ComboBox();
            this.desktopMaterialLabel = new System.Windows.Forms.Label();
            this.DeskWidthInput = new System.Windows.Forms.TextBox();
            this.DepthInput = new System.Windows.Forms.TextBox();
            this.ComboBoxMaterials = new System.Windows.Forms.ComboBox();
            this.CheckBox1 = new System.Windows.Forms.CheckBox();
            this.rushOrderDaysLabel = new System.Windows.Forms.Label();
            this.DaysComboBox = new System.Windows.Forms.ComboBox();
            this.MenuButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(32, 54);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(194, 29);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Customer Name:";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomerNameInput
            // 
            this.CustomerNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameInput.Location = new System.Drawing.Point(276, 54);
            this.CustomerNameInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CustomerNameInput.Name = "CustomerNameInput";
            this.CustomerNameInput.Size = new System.Drawing.Size(349, 30);
            this.CustomerNameInput.TabIndex = 1;
            this.CustomerNameInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustomerNameInput_KeyPress);
            this.CustomerNameInput.Validating += new System.ComponentModel.CancelEventHandler(this.CustomerNameInput_Validating);
            // 
            // SubmitButton
            // 
            this.SubmitButton.AutoSize = true;
            this.SubmitButton.BackColor = System.Drawing.Color.PaleGreen;
            this.SubmitButton.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.SubmitButton.FlatAppearance.BorderSize = 15;
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SubmitButton.Location = new System.Drawing.Point(638, 424);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(202, 69);
            this.SubmitButton.TabIndex = 2;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.Location = new System.Drawing.Point(36, 214);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(80, 29);
            this.widthLabel.TabIndex = 3;
            this.widthLabel.Text = "Width:";
            this.widthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthLabel.Location = new System.Drawing.Point(36, 279);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(83, 29);
            this.depthLabel.TabIndex = 4;
            this.depthLabel.Text = "Depth:";
            this.depthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // drawerNumberLabel
            // 
            this.drawerNumberLabel.AutoSize = true;
            this.drawerNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawerNumberLabel.Location = new System.Drawing.Point(313, 214);
            this.drawerNumberLabel.Name = "drawerNumberLabel";
            this.drawerNumberLabel.Size = new System.Drawing.Size(228, 29);
            this.drawerNumberLabel.TabIndex = 7;
            this.drawerNumberLabel.Text = "Number of Drawers:";
            this.drawerNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 36);
            this.label3.TabIndex = 8;
            this.label3.Text = "Desk Info:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComboBoxDrawers
            // 
            this.ComboBoxDrawers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxDrawers.FormattingEnabled = true;
            this.ComboBoxDrawers.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.ComboBoxDrawers.Location = new System.Drawing.Point(576, 214);
            this.ComboBoxDrawers.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboBoxDrawers.Name = "ComboBoxDrawers";
            this.ComboBoxDrawers.Size = new System.Drawing.Size(101, 33);
            this.ComboBoxDrawers.TabIndex = 9;
            this.ComboBoxDrawers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBoxDrawers_KeyPress);
            this.ComboBoxDrawers.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBoxDrawers_Validating);
            // 
            // desktopMaterialLabel
            // 
            this.desktopMaterialLabel.AutoSize = true;
            this.desktopMaterialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desktopMaterialLabel.Location = new System.Drawing.Point(313, 282);
            this.desktopMaterialLabel.Name = "desktopMaterialLabel";
            this.desktopMaterialLabel.Size = new System.Drawing.Size(200, 29);
            this.desktopMaterialLabel.TabIndex = 10;
            this.desktopMaterialLabel.Text = "Desktop Material:";
            this.desktopMaterialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeskWidthInput
            // 
            this.DeskWidthInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskWidthInput.Location = new System.Drawing.Point(133, 212);
            this.DeskWidthInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeskWidthInput.Name = "DeskWidthInput";
            this.DeskWidthInput.Size = new System.Drawing.Size(105, 30);
            this.DeskWidthInput.TabIndex = 11;
            this.DeskWidthInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DeskWidthInput_KeyPress);
            this.DeskWidthInput.Validating += new System.ComponentModel.CancelEventHandler(this.DeskWidthInput_Validating);
            // 
            // DepthInput
            // 
            this.DepthInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepthInput.Location = new System.Drawing.Point(133, 279);
            this.DepthInput.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DepthInput.Name = "DepthInput";
            this.DepthInput.Size = new System.Drawing.Size(105, 30);
            this.DepthInput.TabIndex = 12;
            this.DepthInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DepthInput_KeyPress);
            this.DepthInput.Validating += new System.ComponentModel.CancelEventHandler(this.DepthInput_Validating);
            // 
            // ComboBoxMaterials
            // 
            this.ComboBoxMaterials.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxMaterials.FormattingEnabled = true;
            this.ComboBoxMaterials.Location = new System.Drawing.Point(544, 282);
            this.ComboBoxMaterials.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ComboBoxMaterials.Name = "ComboBoxMaterials";
            this.ComboBoxMaterials.Size = new System.Drawing.Size(257, 33);
            this.ComboBoxMaterials.TabIndex = 13;
            this.ComboBoxMaterials.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBoxMaterials_KeyPress);
            this.ComboBoxMaterials.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBoxMaterials_Validating);
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBox1.Location = new System.Drawing.Point(42, 360);
            this.CheckBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(175, 33);
            this.CheckBox1.TabIndex = 15;
            this.CheckBox1.Text = "Rush Order?";
            this.CheckBox1.UseVisualStyleBackColor = true;
            this.CheckBox1.CheckStateChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // rushOrderDaysLabel
            // 
            this.rushOrderDaysLabel.AutoSize = true;
            this.rushOrderDaysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rushOrderDaysLabel.Location = new System.Drawing.Point(36, 424);
            this.rushOrderDaysLabel.Name = "rushOrderDaysLabel";
            this.rushOrderDaysLabel.Size = new System.Drawing.Size(72, 29);
            this.rushOrderDaysLabel.TabIndex = 16;
            this.rushOrderDaysLabel.Text = "Days:";
            this.rushOrderDaysLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rushOrderDaysLabel.Visible = false;
            // 
            // DaysComboBox
            // 
            this.DaysComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DaysComboBox.FormattingEnabled = true;
            this.DaysComboBox.Items.AddRange(new object[] {
            "3",
            "5",
            "7"});
            this.DaysComboBox.Location = new System.Drawing.Point(133, 424);
            this.DaysComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DaysComboBox.Name = "DaysComboBox";
            this.DaysComboBox.Size = new System.Drawing.Size(101, 33);
            this.DaysComboBox.TabIndex = 17;
            this.DaysComboBox.Visible = false;
            this.DaysComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DaysComboBox_KeyPress);
            this.DaysComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.DaysComboBox_Validating);
            // 
            // MenuButton
            // 
            this.MenuButton.AutoSize = true;
            this.MenuButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.MenuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuButton.Location = new System.Drawing.Point(367, 424);
            this.MenuButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(202, 69);
            this.MenuButton.TabIndex = 18;
            this.MenuButton.Text = "Main Menu";
            this.MenuButton.UseVisualStyleBackColor = true;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(898, 534);
            this.Controls.Add(this.MenuButton);
            this.Controls.Add(this.DaysComboBox);
            this.Controls.Add(this.rushOrderDaysLabel);
            this.Controls.Add(this.CheckBox1);
            this.Controls.Add(this.ComboBoxMaterials);
            this.Controls.Add(this.DepthInput);
            this.Controls.Add(this.DeskWidthInput);
            this.Controls.Add(this.desktopMaterialLabel);
            this.Controls.Add(this.ComboBoxDrawers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.drawerNumberLabel);
            this.Controls.Add(this.depthLabel);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.CustomerNameInput);
            this.Controls.Add(this.nameLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddQuote";
            this.Text = "Add Quote";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddQuote_FormClosing);
            this.Load += new System.EventHandler(this.AddQuote_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox CustomerNameInput;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.Label drawerNumberLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboBoxDrawers;
        private System.Windows.Forms.Label desktopMaterialLabel;
        private System.Windows.Forms.TextBox DeskWidthInput;
        private System.Windows.Forms.TextBox DepthInput;
        private System.Windows.Forms.ComboBox ComboBoxMaterials;
        private System.Windows.Forms.CheckBox CheckBox1;
        private System.Windows.Forms.Label rushOrderDaysLabel;
        private System.Windows.Forms.ComboBox DaysComboBox;
        private System.Windows.Forms.Button MenuButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}