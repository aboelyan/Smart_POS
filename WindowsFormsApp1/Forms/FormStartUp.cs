using Smart_POS.Classes;
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
    public partial class FormStartUp : Form
    {
        public FormStartUp()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblInfo.Text = "Loading..............";

            if (progressBarX1.Value == 30)
            {
                lblInfo.Text = "Loading System Options";
                ClassLoading loading = new ClassLoading();
                loading.loadSystemOptions();
            }
            if (progressBarX1.Value == 100)
            {
                Close();
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                progressBarX1.Value++;
                progressBarX1.Refresh();
            }
        }
    }
}
