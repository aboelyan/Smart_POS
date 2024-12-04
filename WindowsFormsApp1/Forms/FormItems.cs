using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Smart_POS.Classes;

namespace Smart_POS.Forms
{
    public partial class FormItems : Form
    {
        private SqlDataAdapter adapter;
        private DataTable dataTable;
        private DataRow row;
        private int index;
        public FormItems()
        {
            InitializeComponent();
        }

        private void FormItems_Load(object sender, EventArgs e)
        {
            HelperClass.fillCombo(cmbCat, "Select ID,DES from tbl_Category ");
            adapter = new SqlDataAdapter("Select * From tbl_Item", adoClass.sqlCon);
            dataTable = new DataTable();
            adapter.Fill(dataTable);
            index = 0;
            LoadData(0);
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            FormSelect select = new FormSelect("Select ID,DES from tbl_Item");
            select.des = "DES";
            if (select.ShowDialog() == DialogResult.OK)
            {
                LoadData(int.Parse(select.result));
            }
        }
        private void dataFillRow()
        {
            row["DES"] = txtDes.Text;
            row["CategoryID"] = ((comboItemClass)cmbCat.SelectedItem).Id;
            row["Price"] = txtPrice.Text;
            row["Nots"] = txtNots.Text;
            if (pictureBox1.BackgroundImage != null)
            {
                row["Image"] = HelperClass.ImageToByte(pictureBox1.BackgroundImage);
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDes.Text == string.Empty)
            {
                MessageBox.Show("this Data Requrid");
                txtDes.Focus();
                return;
            }

            if (MessageBox.Show("Save New Data", "Wirning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SaveData();
            }
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            row = null;
            foreach (Control ctr in this.Controls)
            {
                if (ctr is TextBox)
                {
                    ctr.Text = string.Empty;
                }
                if (ctr is ComboBox)
                {
                    ctr.Text = "";
                }
            }
            pictureBox1.BackgroundImage = null;
            txtDes.Focus();
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
                txtDes.Text = row["DES"].ToString();
                cmbCat.Text = HelperClass.getComboItemVal(cmbCat, row["CategoryID"].ToString());
                txtPrice.Text = row["Price"].ToString();
                txtPrice.Text = row["Nots"].ToString();
                if (row["Image"] != DBNull.Value)
                {
                    pictureBox1.BackgroundImage = HelperClass.ByteToImage(row["Image"]);
                }
                else
                {
                    pictureBox1.BackgroundImage = null;
                }
            }

        }
        private void LoadDataWithIndex(int _index)
        {
            index = _index;
            if (dataTable.Rows.Count > 0 && _index >= 0 && _index <= dataTable.Rows.Count - 1)
            {
                txtDes.Text = dataTable.Rows[_index]["DES"].ToString();
                cmbCat.Text = HelperClass.getComboItemVal(cmbCat, dataTable.Rows[_index]["CategoryID"].ToString());
                txtPrice.Text = dataTable.Rows[_index]["Price"].ToString();
                txtPrice.Text = dataTable.Rows[_index]["Nots"].ToString();
                if (dataTable.Rows[_index]["Image"] != DBNull.Value)
                {
                    pictureBox1.BackgroundImage = HelperClass.ByteToImage(dataTable.Rows[_index]["Image"]);
                }
                else
                {
                    pictureBox1.BackgroundImage =null;
                }
                row = dataTable.Rows[_index];
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Images|*.png";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                txtImage.Text = fileDialog.FileName;
                pictureBox1.BackgroundImage = new Bitmap(txtImage.Text);
            }
        }

        private void calcCheck()
        {
            double x = 0;
        }
    }
}
