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
    public partial class frmInventory : Form
    {
        public frmInventory()
        {
            InitializeComponent();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPage(new uchomepage());
        }
        private void ShowPage(UserControl page)
        {
            pnlcontent.Controls.Clear();
            page.Dock = DockStyle.Fill;
            pnlcontent.Controls.Add(page);
        }

        private void productListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPage(new ucproductlist());
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult userresponse = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (userresponse == DialogResult.Yes)
            {
                Application.Exit();
            }7  
        }
    }     
}
