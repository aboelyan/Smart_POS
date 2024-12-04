using Smart_POS.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Smart_POS.Forms
{
    public partial class FormPermitions : Form
    {
        private int counter;
        private SqlCommand cmd;
        private SqlDataReader dr;
        public FormPermitions()
        {
            InitializeComponent();
        }

        private void FormPermitions_Load(object sender, EventArgs e)
        {
            HelperClass.fillCombo(cmbUsers, "Select  ID,Fullname From tbl_User");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkAll(Control.ControlCollection controls, bool status)
        {
            foreach (Control control in controls)
            {
                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = status;
                }
                if (control.Controls.Count > 0)
                {
                    checkAll(control.Controls, status);
                }
            }
        }

        private void btnCheckAll_Click(object sender, EventArgs e)
        {
            checkAll(this.Controls, true);
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            checkAll(this.Controls, false);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbUsers.Text == "")
            {
                MessageBox.Show("Select User for Permotions");
                return;
            }
            string userCode = ((comboItemClass)cmbUsers.SelectedItem).Id;
            saveData(userCode);
        }
        private void savCmd(string Tex)
        {
            cmd = new SqlCommand(Tex, adoClass.sqlCon);
            try
            {
                if (adoClass.sqlCon.State != ConnectionState.Open) adoClass.sqlCon.Open();
                cmd.ExecuteReader();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                adoClass.sqlCon.Close();
            }
        }
        private void saveData(string userCode)
        {
            string delText = "Delete from UserPermition where UserId ='" + userCode + "'";
            savCmd(delText);
            counter = 1;
            string insertText = getDataCbx(this.Controls, userCode);
            savCmd(insertText);
            MessageBox.Show("Success");
        }



        private string getDataCbx(Control.ControlCollection controls, string userCode)
        {
            string xResult = string.Empty;
            foreach (Control control in controls)
            {
                if (control is CheckBox)
                {
                    CheckBox checkBox = (CheckBox)control;
                    xResult += " Insert Into UserPermition(pIndex,mainScreen,permition,UserId,theCase)";
                    xResult += " Values ( " + counter;
                    xResult += ", '" + checkBox.AccessibleDescription + "' ";
                    xResult += ", '" + checkBox.AccessibleName + "'";
                    xResult += "," + userCode;
                    xResult += "," + (checkBox.Checked ? 1 : 0) + ")";
                    xResult += " \n";
                    counter++;
                }
                if (control.Controls.Count > 0)
                {
                    xResult += getDataCbx(control.Controls, userCode);

                }
            }
            return xResult;
        }

        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            checkAll(this.Controls, false);
            if (cmbUsers.Text == "")
            {
                return;
            }

            string userCode = ((comboItemClass)cmbUsers.SelectedItem).Id;
            fillDataPermitions(userCode);
        }
        private void fillDataPermitions(string userCode)
        {
            cmd = new SqlCommand("Select * from UserPermition where UserId ='" + userCode + "'", adoClass.sqlCon);
            dr = null;
            try
            {
                if (adoClass.sqlCon.State != ConnectionState.Open) adoClass.sqlCon.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    checkchbx(this.Controls,
                        bool.Parse(dr["theCase"].ToString()),
                        dr["mainScreen"].ToString(),
                        dr["permition"].ToString());
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                adoClass.sqlCon.Close();
            }
        }

        private void checkchbx(Control.ControlCollection controls, bool status, string mainScreen, string permition)
        {
            foreach (Control control in controls)
            {
                if (control is CheckBox)
                {
                    CheckBox checkBoxs = (CheckBox)control;
                    if (checkBoxs.AccessibleDescription == mainScreen && checkBoxs.AccessibleDescription == permition)
                    {
                        checkBoxs.Checked = status;
                    }
                }
                if (control.Controls.Count > 0)
                {
                    checkchbx(control.Controls, status, mainScreen, permition);
                }
            }
        }
    }
}
