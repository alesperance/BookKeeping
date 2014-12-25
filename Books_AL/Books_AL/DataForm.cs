using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Books_AL
{
    public partial class DataForm : Form
    {
        Month month;

        public DataForm(string currentMonth, Month month)
        {
            InitializeComponent();
            monthLabel.Text = currentMonth;
            this.month = month;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (!amountEntryBox.Text.Equals(""))
            {
                try
                {
                    double entry = Convert.ToDouble(amountEntryBox.Text);

                }
                catch(Exception ex)
                {
                    MessageBox.Show("You entered in something other than a number.  Please retry with a valid number");
                }
            }
        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void categorySelectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!categorySelectionBox.Text.Equals(""))
            {
                amountLabel.Visible = true;
                amountEntryBox.Visible = true;
                addButton.Enabled = true;
            }
        }
    }
}
