namespace MegaDesk_2
{
    partial class SearchQuotes
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
            this.menuButton = new System.Windows.Forms.Button();
            this.ComboBoxMaterialsSearch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateText = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.priceText = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.ProductionDaysText = new System.Windows.Forms.Label();
            this.ProductionDaysLabel = new System.Windows.Forms.Label();
            this.drawersText = new System.Windows.Forms.Label();
            this.materialText = new System.Windows.Forms.Label();
            this.depthText = new System.Windows.Forms.Label();
            this.widthText = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.drawerNumberLabel = new System.Windows.Forms.Label();
            this.desktopMaterialLabel = new System.Windows.Forms.Label();
            this.depthLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuButton
            // 
            this.menuButton.AutoSize = true;
            this.menuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(245)))));
            this.menuButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.menuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.Location = new System.Drawing.Point(305, 656);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(202, 69);
            this.menuButton.TabIndex = 19;
            this.menuButton.Text = "Main Menu";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // ComboBoxMaterialsSearch
            // 
            this.ComboBoxMaterialsSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboBoxMaterialsSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxMaterialsSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxMaterialsSearch.FormattingEnabled = true;
            this.ComboBoxMaterialsSearch.Location = new System.Drawing.Point(327, 54);
            this.ComboBoxMaterialsSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComboBoxMaterialsSearch.Name = "ComboBoxMaterialsSearch";
            this.ComboBoxMaterialsSearch.Size = new System.Drawing.Size(180, 37);
            this.ComboBoxMaterialsSearch.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 29);
            this.label1.TabIndex = 21;
            this.label1.Text = "Search for orders with: ";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(610, 51);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 46);
            this.button1.TabIndex = 22;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dateText);
            this.groupBox1.Controls.Add(this.dateLabel);
            this.groupBox1.Controls.Add(this.priceText);
            this.groupBox1.Controls.Add(this.priceLabel);
            this.groupBox1.Controls.Add(this.ProductionDaysText);
            this.groupBox1.Controls.Add(this.ProductionDaysLabel);
            this.groupBox1.Controls.Add(this.drawersText);
            this.groupBox1.Controls.Add(this.materialText);
            this.groupBox1.Controls.Add(this.depthText);
            this.groupBox1.Controls.Add(this.widthText);
            this.groupBox1.Controls.Add(this.nameText);
            this.groupBox1.Controls.Add(this.nameLabel);
            this.groupBox1.Controls.Add(this.drawerNumberLabel);
            this.groupBox1.Controls.Add(this.desktopMaterialLabel);
            this.groupBox1.Controls.Add(this.depthLabel);
            this.groupBox1.Controls.Add(this.widthLabel);
            this.groupBox1.Location = new System.Drawing.Point(110, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 453);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(304, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 32);
            this.label2.TabIndex = 44;
            this.label2.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(24, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 37);
            this.label3.TabIndex = 43;
            this.label3.Text = "Price:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateText
            // 
            this.dateText.AutoSize = true;
            this.dateText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateText.ForeColor = System.Drawing.SystemColors.Highlight;
            this.dateText.Location = new System.Drawing.Point(304, 118);
            this.dateText.Name = "dateText";
            this.dateText.Size = new System.Drawing.Size(92, 32);
            this.dateText.TabIndex = 42;
            this.dateText.Text = "label1";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(26, 122);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(69, 29);
            this.dateLabel.TabIndex = 41;
            this.dateLabel.Text = "Date:";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // priceText
            // 
            this.priceText.AutoSize = true;
            this.priceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceText.ForeColor = System.Drawing.SystemColors.Highlight;
            this.priceText.Location = new System.Drawing.Point(450, -36);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(92, 32);
            this.priceText.TabIndex = 40;
            this.priceText.Text = "label1";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.priceLabel.Location = new System.Drawing.Point(170, -36);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(104, 37);
            this.priceLabel.TabIndex = 39;
            this.priceLabel.Text = "Price:";
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProductionDaysText
            // 
            this.ProductionDaysText.AutoSize = true;
            this.ProductionDaysText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductionDaysText.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ProductionDaysText.Location = new System.Drawing.Point(304, 368);
            this.ProductionDaysText.Name = "ProductionDaysText";
            this.ProductionDaysText.Size = new System.Drawing.Size(92, 32);
            this.ProductionDaysText.TabIndex = 38;
            this.ProductionDaysText.Text = "label5";
            // 
            // ProductionDaysLabel
            // 
            this.ProductionDaysLabel.AutoSize = true;
            this.ProductionDaysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductionDaysLabel.Location = new System.Drawing.Point(26, 368);
            this.ProductionDaysLabel.Name = "ProductionDaysLabel";
            this.ProductionDaysLabel.Size = new System.Drawing.Size(197, 29);
            this.ProductionDaysLabel.TabIndex = 37;
            this.ProductionDaysLabel.Text = "Production Time:";
            this.ProductionDaysLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // drawersText
            // 
            this.drawersText.AutoSize = true;
            this.drawersText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawersText.ForeColor = System.Drawing.SystemColors.Highlight;
            this.drawersText.Location = new System.Drawing.Point(304, 319);
            this.drawersText.Name = "drawersText";
            this.drawersText.Size = new System.Drawing.Size(92, 32);
            this.drawersText.TabIndex = 36;
            this.drawersText.Text = "label5";
            // 
            // materialText
            // 
            this.materialText.AutoSize = true;
            this.materialText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialText.ForeColor = System.Drawing.SystemColors.Highlight;
            this.materialText.Location = new System.Drawing.Point(304, 267);
            this.materialText.Name = "materialText";
            this.materialText.Size = new System.Drawing.Size(92, 32);
            this.materialText.TabIndex = 35;
            this.materialText.Text = "label4";
            // 
            // depthText
            // 
            this.depthText.AutoSize = true;
            this.depthText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthText.ForeColor = System.Drawing.SystemColors.Highlight;
            this.depthText.Location = new System.Drawing.Point(304, 218);
            this.depthText.Name = "depthText";
            this.depthText.Size = new System.Drawing.Size(92, 32);
            this.depthText.TabIndex = 34;
            this.depthText.Text = "label3";
            // 
            // widthText
            // 
            this.widthText.AutoSize = true;
            this.widthText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthText.ForeColor = System.Drawing.SystemColors.Highlight;
            this.widthText.Location = new System.Drawing.Point(304, 168);
            this.widthText.Name = "widthText";
            this.widthText.Size = new System.Drawing.Size(92, 32);
            this.widthText.TabIndex = 33;
            this.widthText.Text = "label2";
            // 
            // nameText
            // 
            this.nameText.AutoSize = true;
            this.nameText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameText.ForeColor = System.Drawing.SystemColors.Highlight;
            this.nameText.Location = new System.Drawing.Point(304, 65);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(92, 32);
            this.nameText.TabIndex = 32;
            this.nameText.Text = "label1";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(26, 72);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(194, 29);
            this.nameLabel.TabIndex = 31;
            this.nameLabel.Text = "Customer Name:";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // drawerNumberLabel
            // 
            this.drawerNumberLabel.AutoSize = true;
            this.drawerNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawerNumberLabel.Location = new System.Drawing.Point(26, 319);
            this.drawerNumberLabel.Name = "drawerNumberLabel";
            this.drawerNumberLabel.Size = new System.Drawing.Size(228, 29);
            this.drawerNumberLabel.TabIndex = 30;
            this.drawerNumberLabel.Text = "Number of Drawers:";
            this.drawerNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // desktopMaterialLabel
            // 
            this.desktopMaterialLabel.AutoSize = true;
            this.desktopMaterialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desktopMaterialLabel.Location = new System.Drawing.Point(26, 267);
            this.desktopMaterialLabel.Name = "desktopMaterialLabel";
            this.desktopMaterialLabel.Size = new System.Drawing.Size(200, 29);
            this.desktopMaterialLabel.TabIndex = 29;
            this.desktopMaterialLabel.Text = "Desktop Material:";
            this.desktopMaterialLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthLabel.Location = new System.Drawing.Point(26, 218);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(83, 29);
            this.depthLabel.TabIndex = 28;
            this.depthLabel.Text = "Depth:";
            this.depthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.Location = new System.Drawing.Point(26, 168);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(80, 29);
            this.widthLabel.TabIndex = 27;
            this.widthLabel.Text = "Width:";
            this.widthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(117, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 37);
            this.label5.TabIndex = 24;
            this.label5.Text = "label4";
            this.label5.Visible = false;
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 760);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboBoxMaterialsSearch);
            this.Controls.Add(this.menuButton);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchQuotes_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.ComboBox ComboBoxMaterialsSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label dateText;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label priceText;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label ProductionDaysText;
        private System.Windows.Forms.Label ProductionDaysLabel;
        private System.Windows.Forms.Label drawersText;
        private System.Windows.Forms.Label materialText;
        private System.Windows.Forms.Label depthText;
        private System.Windows.Forms.Label widthText;
        private System.Windows.Forms.Label nameText;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label drawerNumberLabel;
        private System.Windows.Forms.Label desktopMaterialLabel;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        //private System.Windows.Forms.Label searchResult;
    }
}