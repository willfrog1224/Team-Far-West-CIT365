namespace MegaDesk_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddQuote));
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
            this.nameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(189)))), ((int)(((byte)(192)))));
            this.nameLabel.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(58, 77);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(174, 23);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Customer Name:";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomerNameInput
            // 
            this.CustomerNameInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(245)))));
            this.CustomerNameInput.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameInput.Location = new System.Drawing.Point(255, 69);
            this.CustomerNameInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CustomerNameInput.Name = "CustomerNameInput";
            this.CustomerNameInput.Size = new System.Drawing.Size(234, 31);
            this.CustomerNameInput.TabIndex = 1;
            this.CustomerNameInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CustomerNameInput_KeyPress);
            this.CustomerNameInput.Validating += new System.ComponentModel.CancelEventHandler(this.CustomerNameInput_Validating);
            // 
            // SubmitButton
            // 
            this.SubmitButton.AutoSize = true;
            this.SubmitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(245)))));
            this.SubmitButton.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.SubmitButton.FlatAppearance.BorderSize = 15;
            this.SubmitButton.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubmitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SubmitButton.Location = new System.Drawing.Point(504, 439);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(142, 51);
            this.SubmitButton.TabIndex = 2;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(189)))), ((int)(((byte)(192)))));
            this.widthLabel.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.Location = new System.Drawing.Point(58, 177);
            this.widthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(74, 23);
            this.widthLabel.TabIndex = 3;
            this.widthLabel.Text = "Width:";
            this.widthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(189)))), ((int)(((byte)(192)))));
            this.depthLabel.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthLabel.Location = new System.Drawing.Point(58, 226);
            this.depthLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(76, 23);
            this.depthLabel.TabIndex = 4;
            this.depthLabel.Text = "Depth:";
            this.depthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // drawerNumberLabel
            // 
            this.drawerNumberLabel.AutoSize = true;
            this.drawerNumberLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(189)))), ((int)(((byte)(192)))));
            this.drawerNumberLabel.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawerNumberLabel.Location = new System.Drawing.Point(241, 174);
            this.drawerNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.drawerNumberLabel.Name = "drawerNumberLabel";
            this.drawerNumberLabel.Size = new System.Drawing.Size(207, 23);
            this.drawerNumberLabel.TabIndex = 7;
            this.drawerNumberLabel.Text = "Number of Drawers:";
            this.drawerNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(189)))), ((int)(((byte)(192)))));
            this.label3.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(58, 130);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "Desk Info:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComboBoxDrawers
            // 
            this.ComboBoxDrawers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(245)))));
            this.ComboBoxDrawers.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.ComboBoxDrawers.Location = new System.Drawing.Point(484, 174);
            this.ComboBoxDrawers.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComboBoxDrawers.Name = "ComboBoxDrawers";
            this.ComboBoxDrawers.Size = new System.Drawing.Size(68, 31);
            this.ComboBoxDrawers.TabIndex = 9;
            this.ComboBoxDrawers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBoxDrawers_KeyPress);
            this.ComboBoxDrawers.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBoxDrawers_Validating);
            // 
            // desktopMaterialLabel
            // 
            this.desktopMaterialLabel.AutoSize = true;
            this.desktopMaterialLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(189)))), ((int)(((byte)(192)))));
            this.desktopMaterialLabel.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desktopMaterialLabel.Location = new System.Drawing.Point(264, 231);
            this.desktopMaterialLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.desktopMaterialLabel.Name = "desktopMaterialLabel";
            this.desktopMaterialLabel.Size = new System.Drawing.Size(184, 23);
            this.desktopMaterialLabel.TabIndex = 10;
            this.desktopMaterialLabel.Text = "Desktop Material:";
            this.desktopMaterialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DeskWidthInput
            // 
            this.DeskWidthInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(245)))));
            this.DeskWidthInput.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeskWidthInput.Location = new System.Drawing.Point(144, 177);
            this.DeskWidthInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeskWidthInput.Name = "DeskWidthInput";
            this.DeskWidthInput.Size = new System.Drawing.Size(72, 31);
            this.DeskWidthInput.TabIndex = 11;
            this.DeskWidthInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DeskWidthInput_KeyPress);
            this.DeskWidthInput.Validating += new System.ComponentModel.CancelEventHandler(this.DeskWidthInput_Validating);
            // 
            // DepthInput
            // 
            this.DepthInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(245)))));
            this.DepthInput.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DepthInput.Location = new System.Drawing.Point(144, 220);
            this.DepthInput.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DepthInput.Name = "DepthInput";
            this.DepthInput.Size = new System.Drawing.Size(72, 31);
            this.DepthInput.TabIndex = 12;
            this.DepthInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DepthInput_KeyPress);
            this.DepthInput.Validating += new System.ComponentModel.CancelEventHandler(this.DepthInput_Validating);
            // 
            // ComboBoxMaterials
            // 
            this.ComboBoxMaterials.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboBoxMaterials.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxMaterials.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxMaterials.FormattingEnabled = true;
            this.ComboBoxMaterials.Location = new System.Drawing.Point(484, 223);
            this.ComboBoxMaterials.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComboBoxMaterials.Name = "ComboBoxMaterials";
            this.ComboBoxMaterials.Size = new System.Drawing.Size(173, 31);
            this.ComboBoxMaterials.TabIndex = 13;
            this.ComboBoxMaterials.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ComboBoxMaterials_KeyPress);
            this.ComboBoxMaterials.Validating += new System.ComponentModel.CancelEventHandler(this.ComboBoxMaterials_Validating);
            // 
            // CheckBox1
            // 
            this.CheckBox1.AutoSize = true;
            this.CheckBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(189)))), ((int)(((byte)(192)))));
            this.CheckBox1.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBox1.Location = new System.Drawing.Point(62, 294);
            this.CheckBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CheckBox1.Name = "CheckBox1";
            this.CheckBox1.Size = new System.Drawing.Size(154, 27);
            this.CheckBox1.TabIndex = 15;
            this.CheckBox1.Text = "Rush Order?";
            this.CheckBox1.UseVisualStyleBackColor = false;
            this.CheckBox1.CheckStateChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // rushOrderDaysLabel
            // 
            this.rushOrderDaysLabel.AutoSize = true;
            this.rushOrderDaysLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(189)))), ((int)(((byte)(192)))));
            this.rushOrderDaysLabel.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rushOrderDaysLabel.Location = new System.Drawing.Point(59, 354);
            this.rushOrderDaysLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rushOrderDaysLabel.Name = "rushOrderDaysLabel";
            this.rushOrderDaysLabel.Size = new System.Drawing.Size(65, 23);
            this.rushOrderDaysLabel.TabIndex = 16;
            this.rushOrderDaysLabel.Text = "Days:";
            this.rushOrderDaysLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rushOrderDaysLabel.Visible = false;
            // 
            // DaysComboBox
            // 
            this.DaysComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(245)))));
            this.DaysComboBox.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DaysComboBox.FormattingEnabled = true;
            this.DaysComboBox.Items.AddRange(new object[] {
            "3",
            "5",
            "7"});
            this.DaysComboBox.Location = new System.Drawing.Point(144, 346);
            this.DaysComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DaysComboBox.Name = "DaysComboBox";
            this.DaysComboBox.Size = new System.Drawing.Size(68, 31);
            this.DaysComboBox.TabIndex = 17;
            this.DaysComboBox.Visible = false;
            this.DaysComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DaysComboBox_KeyPress);
            this.DaysComboBox.Validating += new System.ComponentModel.CancelEventHandler(this.DaysComboBox_Validating);
            // 
            // MenuButton
            // 
            this.MenuButton.AutoSize = true;
            this.MenuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(245)))));
            this.MenuButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.MenuButton.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuButton.Location = new System.Drawing.Point(49, 439);
            this.MenuButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MenuButton.Name = "MenuButton";
            this.MenuButton.Size = new System.Drawing.Size(142, 51);
            this.MenuButton.TabIndex = 18;
            this.MenuButton.Text = "Main Menu";
            this.MenuButton.UseVisualStyleBackColor = false;
            this.MenuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(693, 535);
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
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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