using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JoesAutomotiveImprovedUgly
{
    public partial class Invoice : Form
    {
        public Invoice()
        {
            InitializeComponent();
        }


        private void homeButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBoxPurch_TextChanged(object sender, EventArgs e)
        {

        }

        private void Invoice_Load(object sender, EventArgs e)
        {

        }

        private void clearButton3_Click(object sender, EventArgs e)
        {
            txtBoxPurch.Clear();
        }

        private void Save_Click(object sender, EventArgs e)
        {

        }

        private void clearButton3_Click_1(object sender, EventArgs e)
        {
            txtBoxPurch.Clear();
            partPurchListBox.ClearSelected();
        }

        private void addButton3_Click_1(object sender, EventArgs e)
        {

            if (checkBoxWheels.Checked == true)
            {
                partPurchListBox.Items.Add(checkBoxWheels.Text + " $65");
            }

            if (ignitionChckBox.Checked == true)
            {
                partPurchListBox.Items.Add (ignitionChckBox.Text + " $25");
            }
            
            if (brakesChckBox.Checked == true)
            {
                partPurchListBox.Items.Add (brakesChckBox.Text + " $50");
            }

            if ( FluidChckBox.Checked == true)
            {
                partPurchListBox.Items.Add (FluidChckBox.Text + " $20");
            }

            if (EngineChckBox.Checked == true)
            {
                partPurchListBox.Items.Add (EngineChckBox.Text + " $200");
            }


            if (txtBoxPurch.Text != "")
            {
                try
                {
                    partPurchListBox.Items.Add(txtBoxPurch.Text);
                }
                catch { MessageBox.Show("It already exist."); }
            }
            else MessageBox.Show("Please fill in what part you've purchured.");
        }
    }
}
