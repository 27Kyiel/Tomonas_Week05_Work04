using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tomonas_Week06_Work05
{
    public partial class ucproductlist : UserControl
    {
        public ucproductlist()
        {
            InitializeComponent();
        }

        string[] units = { "Piece", "box", "KG" };
        List<string> shopinglist = new List<string>();

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ucproductlist_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(units);
            comboBox1.SelectedIndex = 0;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            string item = txtdescription.Text;

            // Safely check if txtamount.Text is a valid number
            if (!double.TryParse(txtamount.Text, out double amount))
            {
                MessageBox.Show("Please enter a valid number for the amount.", "Invalid Input");
                txtamount.Focus();
                return; // Stop running the rest of the code
            }


            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a unit.", "Missing Unit");
                return;
            }

            string unit = comboBox1.SelectedItem.ToString();

            string row = $"{item}\t\t {amount} {unit}";
            shopinglist.Add(row);
            updateGUI();

            MessageBox.Show("Item Added");
            txtamount.Clear();
        }


        
            private void updateGUI()
            {
                lbxItems.Items.Clear();

                foreach (string item in shopinglist)
                {
                    lbxItems.Items.Add(item);
                }
            }

        private void lbxItems_SelectedIndexChanged(object sender, EventArgs e)
        {
 
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int index = lbxItems.SelectedIndex;

            if (index != -1)
            {
                DialogResult deleteMessage = MessageBox.Show("Are you sure you want to delete?", "Delete Confirmation", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                MessageBox.Show(shopinglist[index] + "Delete.");

                shopinglist.RemoveAt(index);
                updateGUI();
            }
            else
            {
                lblPrompt.Text = "Please select an item to delete.";
                lblPrompt.Visible = true;
            }
        }

        private void lblPrompt_Click(object sender, EventArgs e)
        {
            lblPrompt.Text = "";
            lblPrompt.Visible = false;
        }
    }
    }
