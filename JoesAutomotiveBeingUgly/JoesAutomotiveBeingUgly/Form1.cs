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

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string number = txtBoxPhoneNum.Text;
            string email = txtBoxEmail.Text;
            string zip = txtBoxZip.Text;
            string city = txtBoxCity.Text;
            string state = txtBoxState.Text;
            string name = txtBoxName.Text;
        }

        private void joesAutomotiveMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customersDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.customersDataSet.Customers);
            //List boxes 
            //Click the customers name that is searched and all new information should be displayed in the text boxes above.
            //So any data we have about the person it's information should automatically be in all the data.


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private bool IsVaildNumber(string str)
        {
            const int VAILD_LENGTH = 10;
            bool vaild = true;

            if (str.Length == VAILD_LENGTH)
            {
                foreach (char ch in str)
                {

                    if (!char.IsDigit(ch))
                    {
                        vaild = false;
                    }
                }
            }
            else
            {
                vaild = false;
            }
            return vaild;
        }

        // The TelephoneFormat method accepts a string argument by reference and formats it as a telephone number.
        private void TelephoneFormat(ref string str)
        {
            //First, insert the left paren at position 0.
            str = str.Insert(0, "(");

            //Next, insert the right paren at postion 4.
            str = str.Insert(4, ")");

            //Next, insert the hypen at postion 8/
            str = str.Insert(8, "-");
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear Button allows the user to earse all the data from the table above and not the user from the list box.
            txtBoxCity.Clear();
            txtBoxName.Clear();
            txtBoxEmail.Clear();
            txtBoxZip.Clear();
            txtBoxPhoneNum.Clear();
            txtBoxState.Clear();

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //Get the zip code, name, email, phone number, state, and city into the list box down below. Be able to click 
            // and have a new form pop up to show information.
            string name = txtBoxName.Text;

        }

        private void loadButton_Click(object sender, EventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.customersDataSet);

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            this.customersTableAdapter.searchName(
                this.customersDataSet.Customers, searchButton.Text);
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            this.customersTableAdapter.Fill(this.customersDataSet.Customers);
        }

        private void customersBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.customersDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customersDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.customersDataSet.Customers);

        }

        private void customersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void vehicleButton_Click_1(object sender, EventArgs e)
        {
            Automobile f2 = new Automobile();
            f2.ShowDialog();
        }

        private void partsButton_Click_1(object sender, EventArgs e)
        {
            Parts f3 = new Parts();
            f3.ShowDialog();
        }

        private void invoiceButton_Click_1(object sender, EventArgs e)
        {
            Invoice f4 = new Invoice();
            f4.ShowDialog();
        }

        private void addButton_Click_1(object sender, EventArgs e)
        {
            string number = txtBoxPhoneNum.Text;
            string email = txtBoxEmail.Text;
            string zip = txtBoxZip.Text;
            string city = txtBoxCity.Text;
            string state = txtBoxState.Text;
            string name = txtBoxName.Text;
            string id = txtBoxIDNum.Text;


            
            this.customersDataSet.Customers.Rows.Add (id, email, number, name, city, state, zip );


        }
    }
}
