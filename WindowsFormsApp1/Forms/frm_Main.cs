using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Smart_POS.Classes;
using Smart_POS.Forms;

namespace Smart_POS
{
    public partial class frm_Main : Form
    {
        private Button CurrentButton;
        private Form activeForm;
        public frm_Main()
        {
            InitializeComponent();
        }
        private Color SelectTheame()
        {
            if (CurrentButton.Text == "Sales Of Point")
            {
                return Color.Gray;
            }
            else if (CurrentButton.Text == "Settings")
            {
                return Color.Red;
            }
            else if (CurrentButton.Text == "Reports")
            {
                return Color.Blue;
            }
            else if (CurrentButton.Text == "Options")
            {
                return Color.Green;
            }
            return Color.White;
        }
        private void ActiveButton(object sender)
        {
            if (sender != null)
            {
                
                if (CurrentButton != (Button)sender)
                {
                    unSelectButton();
                    CurrentButton = (Button)sender;
                    Color color = SelectTheame();                    
                    CurrentButton.BackColor = color;
                    CurrentButton.ForeColor = Color.White;
                    CurrentButton.Font = new Font("Droid Sans Arabic", 11F, FontStyle.Bold);
                    pnTitel.BackColor = color;
                    lblTitel.Text = CurrentButton.Text;
                }
            }
        }
        private void OpenChiledForm(Form cForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = cForm;
            ActiveButton(btnSender);
            cForm.TopLevel = false;
            cForm.FormBorderStyle = FormBorderStyle.None;
            cForm.Dock = DockStyle.Fill;
            pnMainForm.Controls.Add(cForm);
            pnMainForm.Tag = cForm;
            cForm.BringToFront();
            cForm.Show();
        }
        private void unSelectButton()
        {
            foreach (Control ctr in pnlMinu.Controls)
            {
                if (ctr.GetType() == typeof(Button))
                {
                    ctr.BackColor = Color.Gray;
                    ctr.ForeColor = Color.White;
                    ctr.Font = new Font("Droid Sans Arabic", 11F, FontStyle.Regular);
                }
            }
        }

        private void btnSalesPoint_Click(object sender, EventArgs e)
        {
            OpenChiledForm(new frm_MainPointSales(),sender);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            OpenChiledForm(new frm_MainSetup(), sender);
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            OpenChiledForm(new frm_MainReport(), sender);
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            OpenChiledForm(new frm_MainOptions(), sender);
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToShortDateString();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.lblUserFullName.Text = declerationClass.userFullName;
            HelperClass.loadPermitions(this.Controls, "Main");
        }
       
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimer.Text = DateTime.Now.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("www.Google.com");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

