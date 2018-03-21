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
    public partial class Parts : Form
    {
        public Parts()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();

        private void homeButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void addButton2_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void addButton2_Click_1(object sender, EventArgs e)
        {
            tempListBox.Items.Add(txtBoxRecent.Text);
            txtBoxRecent.Clear();
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            table.Rows.Add(txtBoxAvaliable.Text);
            PartsDataGrid.DataSource = table;

        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            int index = 0;
            string search = txtBoxSearch.Text;
            foreach (var item in PartsDataGrid.Rows)
            {
                if (item.ToString() == search)
                {
                    MessageBox.Show("Item is avaliable.");
                }
                else
                {
                    index++;
                    if (index == PartsDataGrid.Columns.Count)
                    {
                        MessageBox.Show("Item is not avaliable.");
                    }
                }
            }
        }

        private void partsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.partsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.customersDataSet);

        }

        private void Parts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customersDataSet.Parts' table. You can move, or remove it, as needed.
            this.partsTableAdapter.Fill(this.customersDataSet.Parts);
            table.Columns.Add("Parts", typeof(string));

            PartsDataGrid.DataSource = table;


        }

        private void homeButton2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {

            {
            
                int index = 0;
                string search = txtBoxSearch.Text;
                foreach (var item in PartsDataGrid.Rows)
                {
                    if (item.ToString() == search)
                    {
                        MessageBox.Show("Item is avaliable.");
                    }
                    else
                    {
                        index++;
                        if (index == PartsDataGrid.Columns.Count)
                        {
                            MessageBox.Show("Item is not avaliable.");
                        }
                    }
                }
            }
        }
    }
}
                
            
        
    

