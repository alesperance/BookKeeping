namespace Books_AL
{
    partial class DataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataForm));
            this.categorySelectionBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.monthLabel = new System.Windows.Forms.Label();
            this.amountEntryBox = new System.Windows.Forms.TextBox();
            this.amountLabel = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.totalButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // categorySelectionBox
            // 
            this.categorySelectionBox.FormattingEnabled = true;
            this.categorySelectionBox.Items.AddRange(new object[] {
            "Purchases",
            "Supplies",
            "Memberships",
            "Education",
            "Travel",
            "Postage",
            "Telephone",
            "Rent",
            "Insurance"});
            this.categorySelectionBox.Location = new System.Drawing.Point(138, 78);
            this.categorySelectionBox.Name = "categorySelectionBox";
            this.categorySelectionBox.Size = new System.Drawing.Size(121, 21);
            this.categorySelectionBox.TabIndex = 0;
            this.categorySelectionBox.SelectedIndexChanged += new System.EventHandler(this.categorySelectionBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Category : ";
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Font = new System.Drawing.Font("Minya Nouvelle", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthLabel.Location = new System.Drawing.Point(88, 22);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(88, 32);
            this.monthLabel.TabIndex = 2;
            this.monthLabel.Text = "label2";
            // 
            // amountEntryBox
            // 
            this.amountEntryBox.Location = new System.Drawing.Point(156, 122);
            this.amountEntryBox.Name = "amountEntryBox";
            this.amountEntryBox.Size = new System.Drawing.Size(103, 20);
            this.amountEntryBox.TabIndex = 3;
            this.amountEntryBox.Visible = false;
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountLabel.Location = new System.Drawing.Point(12, 123);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(138, 16);
            this.amountLabel.TabIndex = 4;
            this.amountLabel.Text = "Enter Amount To Add:";
            this.amountLabel.Visible = false;
            // 
            // addButton
            // 
            this.addButton.Enabled = false;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(94, 157);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(91, 23);
            this.addButton.TabIndex = 5;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // returnButton
            // 
            this.returnButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnButton.Location = new System.Drawing.Point(94, 215);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(91, 23);
            this.returnButton.TabIndex = 6;
            this.returnButton.Text = "Return";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // totalButton
            // 
            this.totalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalButton.Location = new System.Drawing.Point(94, 186);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(91, 23);
            this.totalButton.TabIndex = 7;
            this.totalButton.Text = "View Totals";
            this.totalButton.UseVisualStyleBackColor = true;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.amountEntryBox);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.categorySelectionBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DataForm";
            this.Text = "DataForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox categorySelectionBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.TextBox amountEntryBox;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Button totalButton;
    }
}