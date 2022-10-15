namespace MegaDesk_2
{
    partial class ViewAllQuotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAllQuotes));
            this.menuButton = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuButton
            // 
            this.menuButton.AutoSize = true;
            this.menuButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(249)))), ((int)(((byte)(245)))));
            this.menuButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Highlight;
            this.menuButton.Font = new System.Drawing.Font("Bookman Old Style", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuButton.Location = new System.Drawing.Point(55, 539);
            this.menuButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(194, 55);
            this.menuButton.TabIndex = 20;
            this.menuButton.Text = "Main Menu";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.MenuButton_Click);
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(55, 113);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersWidth = 62;
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.Size = new System.Drawing.Size(1124, 324);
            this.DataGridView1.TabIndex = 21;
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1241, 633);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.menuButton);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewAllQuotes_FormClosing);
            this.Load += new System.EventHandler(this.ViewAllQuotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.DataGridView DataGridView1;
    }
}