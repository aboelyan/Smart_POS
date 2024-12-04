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
    public partial class frm_MainOptions : Form
    {
        private SqlDataAdapter adapter;
        private DataTable dataTable;
        private DataRow row;

        public frm_MainOptions()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frm_MainOptions_Load(object sender, EventArgs e)
        {
            HelperClass.fillCombo(cmbCat, "Select ID,DES from tbl_Category ");
            adapter = new SqlDataAdapter("Select Top 1 * From tbl_Option", adoClass.sqlCon);
            dataTable = new DataTable();
            try
            {
                adapter.Fill(dataTable);
                if (dataTable.Rows.Count > 0)
                {
                    row = dataTable.Rows[0];
                    for (int i = 0; i <= dataTable.Rows.Count - 1; i++)
                    {
                        txtResName.Text = dataTable.Rows[i]["RestName"].ToString();
                        txtAddress1.Text = dataTable.Rows[i]["RestAddress"].ToString();
                        txtPhone.Text = dataTable.Rows[i]["Telphone"].ToString();
                        txtPrenter.Text = dataTable.Rows[i]["PrenterName"].ToString();
                        txtResiptLine1.Text = dataTable.Rows[i]["ReciptLine1"].ToString();
                        txtResiptLine2.Text = dataTable.Rows[i]["ReciptLine2"].ToString();
                        if (dataTable.Rows[i]["Logo"] !=DBNull.Value)
                        {
                            pictureBox1.BackgroundImage = HelperClass.ByteToImage(dataTable.Rows[i]["Logo"]);
                        }
                        cmbCat.Text = HelperClass.getComboItemVal(cmbCat, dataTable.Rows[i]["defaultCategoryId"].ToString());
                    }
                }
                else
                {
                    row = null;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void SaveData()
        {
            if (txtResName.Text == string.Empty)
            {
                MessageBox.Show("Resturant Name Requrid");

                txtResName.Focus();
                return;
            }

            if (txtPhone.Text == string.Empty)
            {
                MessageBox.Show("Phone Number Requrid");

                txtPhone.Focus();
                return;
            }
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
            if (MessageBox.Show("Save New Data", "Wirning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SaveData();
            }

        }

        private void dataFillRow()
        {
            row["RestName"] = txtResName.Text;
            row["PrenterName"] = txtPrenter.Text;
            row["RestAddress"] = txtAddress1.Text;
            row["ReciptLine1"] = txtResiptLine1.Text;
            row["ReciptLine2"] = txtResiptLine2.Text;
            row["Telphone"] = txtPhone.Text;
            if (pictureBox1.BackgroundImage != null)
            {
                row["Logo"] = HelperClass.ImageToByte(pictureBox1.BackgroundImage);
            }
            if(cmbCat.Text !="")
            row["defaultCategoryId"] = ((comboItemClass)cmbCat.SelectedItem).Id;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Images|*.png";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                txtLogo.Text = fileDialog.FileName;
                pictureBox1.BackgroundImage = new Bitmap(txtLogo.Text);
            }
        }
    }
}
