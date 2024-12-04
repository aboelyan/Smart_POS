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
using Smart_POS.Classes;

namespace Smart_POS.Forms
{
    public partial class FormUsers : Form
    {
        private SqlDataAdapter adapter;
        private DataTable dataTable;
        private DataRow row;
        private int index;
        public FormUsers()
        {
            InitializeComponent();
        }
        private void LoadDataWithIndex(int _index)
        {
            index = _index;
            if (dataTable.Rows.Count > 0 && _index >= 0 && _index <= dataTable.Rows.Count - 1)
            {
                txtUserName.Text = dataTable.Rows[_index]["Username"].ToString();
                txtPass.Text = dataTable.Rows[_index]["Password"].ToString();
                txtFullName.Text = dataTable.Rows[_index]["Fullname"].ToString();
                txtEmail.Text = dataTable.Rows[_index]["Emaile"].ToString();
                txtPhone.Text = dataTable.Rows[_index]["Phone"].ToString();
                txtJobDes.Text = dataTable.Rows[_index]["JobDes"].ToString();
                row = dataTable.Rows[_index];
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("Select * From tbl_User", adoClass.sqlCon);
            dataTable = new DataTable();
            adapter.Fill(dataTable);
            index = 0;
            LoadData(0);
        }
        private void LoadData(int Id)
        {
            DataRow[] dataRows = null;
            if (Id == 0)
            {
                dataRows = dataTable.Select();
            }
            else
            {
                dataRows = dataTable.Select("ID ='" + Id + "'");
            }
            if (dataRows.Length > 0)
            {
                row = dataRows[0];
                txtUserName.Text = row["Username"].ToString();
                txtPass.Text = row["Password"].ToString();
                txtFullName.Text = row["Fullname"].ToString();
                txtEmail.Text = row["Emaile"].ToString();
                txtPhone.Text = row["Phone"].ToString();
                txtJobDes.Text = row["JobDes"].ToString();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            row = null;
            foreach (Control ctr in this.Controls)
            {
                if (ctr is TextBox)
                {
                    ctr.Text = string.Empty;
                }
            }
            txtUserName.Focus();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == string.Empty)
            {
                MessageBox.Show("this Data Requrid");
                txtUserName.Focus();
                return;
            }
            if (txtPass.Text == string.Empty)
            {
                MessageBox.Show("this Data Requrid");
                txtPass.Focus();
                return;
            }
            if (txtFullName.Text == string.Empty)
            {
                MessageBox.Show("this Data Requrid");
                txtFullName.Focus();
                return;
            }
            if (MessageBox.Show("Save New Data", "Wirning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SaveData();
            }
        }
        private void SaveData()
        {
            if (row == null)
            {
                row = dataTable.NewRow();
                dataFillRow();
                dataTable.Rows.Add(row);
            }
            else
            {
                row.BeginEdit();
                dataFillRow();
                row.EndEdit();
            }
            try
            {
                adoClass.builder = new SqlCommandBuilder(adapter);
                adapter.Update(dataTable);
                MessageBox.Show("Data has been updated");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void dataFillRow()
        {
            row["Username"] = txtUserName.Text;
            row["Password"] = txtPass.Text;
            row["Fullname"] = txtFullName.Text;
            row["Emaile"] = txtEmail.Text;
            row["Phone"] = txtPhone.Text;
            row["JobDes"] = txtJobDes.Text;

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            LoadDataWithIndex(0);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
                LoadDataWithIndex(index);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (index < dataTable.Rows.Count - 1)
            {
                index++;
                LoadDataWithIndex(index);
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            LoadDataWithIndex(dataTable.Rows.Count - 1);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            FormSelect select = new FormSelect("Select ID,Fullname from tbl_User");
            select.des = "Fullname";
            if (select.ShowDialog() == DialogResult.OK)
            {
                LoadData(int.Parse(select.result));
            }

        }
    }

}
