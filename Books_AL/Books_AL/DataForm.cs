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
                    getList(categorySelectionBox.Text).Add(entry);
                    MessageBox.Show("added");
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

        private List<double> getList(string expense)
        {
            string currentExpense = expense;
            switch (currentExpense)
            {
                case "Purchases":
                    return month._listPurchases;
                case "Supplies":
                    return month._listSupplies;
                case "Memberships":
                    return month._listMembership;
                case "Education":
                    return month._listEducation;
                case "Travel":
                    return month._listTravel;
                case "Postage":
                    return month._listPostage;
                case "Telephone":
                    return month._listTelephone;
                case "Rent":
                    return month._listRent;
                case "Insurance":
                    return month._listInsurance;
                default:
                    return null;
            }
        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Purchases: " + month.getTotals(month._listPurchases).ToString()
                +"\n Supplies: " + month.getTotals(month._listSupplies).ToString()
                + "\n Memberships: " + month.getTotals(month._listMembership).ToString()
                + "\n Education: " + month.getTotals(month._listEducation).ToString()
                + "\n Travel: " + month.getTotals(month._listTravel).ToString()
                + "\n Postage: " + month.getTotals(month._listPostage).ToString()
                + "\n Telephone: " + month.getTotals(month._listTelephone).ToString()
                + "\n Rent: " + month.getTotals(month._listRent).ToString()
                + "\n Insurance: " + month.getTotals(month._listInsurance).ToString());


        }
    }
}
