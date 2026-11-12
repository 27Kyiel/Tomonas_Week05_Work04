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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            String username = tbusername.Text;
            String password = tbpassword.Text;

            if (tbusername.Text == username && tbpassword.Text == password)
            {

                MessageBox.Show(
                       "Username" + username,
                       "Login Information",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Information
                       );

                frmInventory inventory = new frmInventory();
                inventory.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("WRONGG");
            }

        }
    }
}
