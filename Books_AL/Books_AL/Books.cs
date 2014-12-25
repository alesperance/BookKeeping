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
    public partial class Books : Form
    {
        public string CURRENT_MONTH;

        public Month January = new Month();
        public Month February = new Month();
        public Month March = new Month();
        public Month April = new Month();
        public Month May = new Month();
        public Month June = new Month();
        public Month July = new Month();
        public Month August = new Month();
        public Month September = new Month();
        public Month October = new Month();
        public Month November = new Month();
        public Month December = new Month();


        public Books()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Once a month has been selected, this button will access the next dialog to obtain the needed finicial information.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainEnterButton_Click(object sender, EventArgs e)
        {
            //if nothing is selected then show the user they need to enter something and try again.
            if (monthSelectionBox.Text.Equals(""))
                MessageBox.Show("You didn't select anything.  Please select a month and try again");

            else
            {
                CURRENT_MONTH = monthSelectionBox.Text;

                //Display the dialog box to enter in data
                DataForm dataForm = new DataForm();
                if (dataForm.ShowDialog() != DialogResult.OK) return;
                dataForm.Show();
            }

        }

        /// <summary>
        /// Close the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mainExitButton_Click(object sender, EventArgs e)
        {
            Close();
        }


        /// <summary>
        /// Loads serialized data.  to be implementated later.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadButton_Click(object sender, EventArgs e)
        {
            //TODO: load data
        }
    }
}
