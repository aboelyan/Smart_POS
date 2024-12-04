using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_POS.Forms
{
    public partial class frm_MainSetup : Form
    {
        public frm_MainSetup()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            FormUsers frm = new FormUsers();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormCategories formDes = new FormCategories();
            formDes.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormItems formItems = new FormItems();
            formItems.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormPayments formPayments = new FormPayments();
            formPayments.ShowDialog();
        }

        private void btnPermitions_Click(object sender, EventArgs e)
        {
            FormPermitions formPermitions = new FormPermitions();
            formPermitions.ShowDialog();
        }
    }
}
