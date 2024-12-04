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
    public partial class POSForm : Form
    {
        private SqlDataAdapter adapter;
        private DataTable _itemDt;
        private string CheckId;
        public POSForm()
        {
            InitializeComponent();
            CheckId = "0";
        }
        private void POSForm_Load(object sender, EventArgs e)
        {
            HelperClass.fillCombo(cmbPayment, "Select ID,DES from tbl_Payment ");
            cmbPayment.Text = HelperClass.getComboItemVal(cmbPayment, "1");
            //string catId = declerationClass.systemOptions["defaultCategoryId"].ToString();
            //  fillItems(catId);
            fillCategories();
            btn0.Click += num_Click;
            btn1.Click += num_Click;
            btn2.Click += num_Click;
            btn3.Click += num_Click;
            btn4.Click += num_Click;
            btn5.Click += num_Click;
            btn6.Click += num_Click;
            btn7.Click += num_Click;
            btn8.Click += num_Click;
            btn9.Click += num_Click;
            btnDot.Click += num_Click;
            btnC.Click += num_Click;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void fillCategories()
        {
            adapter = new SqlDataAdapter("Select ID,DES from tbl_Category ", adoClass.sqlCon);
            _itemDt = new DataTable();
            try
            {
                adapter.Fill(_itemDt);
                DataRow[] drs = _itemDt.Select();
                int x = 3, y = 3, count = 1;
                pnItem.Controls.Clear();
                for (int i = 0; i <= drs.Length - 1; i++)
                {
                    Button catBtn = new Button();
                    catBtn.AccessibleName = "CAT";
                    catBtn.AccessibleDescription = drs[i]["ID"].ToString();
                    catBtn.Name = "btnCat" + drs[i]["ID"].ToString();
                    catBtn.Text = drs[i]["DES"].ToString();
                    catBtn.Size = new Size(100, 100);
                    catBtn.Click += catBtn_Click;
                    catBtn.Location = new Point(x, y);
                    pnItem.Controls.Add(catBtn);
                    x += 103;
                    if (count == 7)
                    {
                        y += 103;
                        x = 1;
                        count = 1;
                    }
                    else
                    {
                        count++;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void catBtn_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.AccessibleName == "CAT")
            {
                string CatId = button.AccessibleDescription;
                fillItems(CatId);
            }
            else if (button.AccessibleName == "IT")
            {
                double Qty = 0;
                double.TryParse(txtItemQty.Text, out Qty);

                if (Qty == 0)
                {
                    Qty = 1;
                }
                double totalPrice = 0;
                double itemPrice = 0;
                double.TryParse(button.Tag.ToString(), out itemPrice);
                totalPrice = Qty * itemPrice;
                dgvItems.Rows.Add(new object[]
                {
                    button.AccessibleDescription,
                    button.Text,
                    Qty,
                    itemPrice,
                   totalPrice
                });
                txtItemQty.Text = "0";
            }
            else
            {
                fillCategories();
            }
            calcCheck();
        }
        private void fillItems(string catId)
        {
            adapter = new SqlDataAdapter("Select * from tbl_Item where CategoryID='" + catId + "' ", adoClass.sqlCon);
            _itemDt = new DataTable();
            try
            {
                adapter.Fill(_itemDt);
                DataRow[] drs = _itemDt.Select();
                int x = 3, y = 3, count = 1;
                pnItem.Controls.Clear();
                Button catBtn;
                for (int i = 0; i <= drs.Length - 1; i++)
                {
                    catBtn = new Button();
                    catBtn.AccessibleName = "IT";
                    catBtn.AccessibleDescription = drs[i]["Id"].ToString();
                    catBtn.Name = "btnCat" + drs[i]["Id"].ToString();
                    catBtn.Text = drs[i]["DES"].ToString();
                    catBtn.Tag = drs[i]["Price"].ToString();
                    catBtn.TextAlign = ContentAlignment.BottomRight;
                    catBtn.Image = HelperClass.ByteToImage(drs[i]["Image"]);
                    catBtn.Size = new Size(100, 100);
                    catBtn.Click += catBtn_Click;
                    catBtn.Location = new Point(x, y);
                    pnItem.Controls.Add(catBtn);
                    x += 103;
                    if (count == 7)
                    {
                        y += 103;
                        x = 1;
                        count = 1;
                    }
                    else
                    {
                        count++;
                    }
                }
                catBtn = new Button();
                catBtn.AccessibleName = "_";
                catBtn.Size = new Size(100, 100);
                catBtn.Name = "btnEnd" + catId;
                catBtn.Text = "Cancel";
                catBtn.Location = new Point(x, y);
                catBtn.Click += catBtn_Click;
                catBtn.BackColor = Color.Red;
                pnItem.Controls.Add(catBtn);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            dgvItems.Rows.Clear();
            calcCheck();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (dgvItems.Rows.Count > 0)
            {
                dgvItems.Rows.Remove(dgvItems.CurrentRow);
                calcCheck();
            }
        }
        private void calcCheck()
        {
            double x = 0;
            double result = 0;
            for (int i = 0; i <= dgvItems.Rows.Count - 1; i++)
            {
                double.TryParse(dgvItems[ColPrice.Index, i].Value.ToString(), out x);
                result += x;
            }
            txtTotal.Text = result.ToString();
        }
        private void num_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Text == "C")
            {
                txtItemQty.Text = "0";
            }
            else if (button.Text == ".")
            {
                if (!txtItemQty.Text.Contains("."))
                {
                    if (int.Parse(txtItemQty.Text) == 0)
                    {
                        button.Text = "0.";
                    }
                    else
                    {
                        txtItemQty.Text += button.Text;
                    }
                }
            }
            else
            {
                if (int.Parse(txtItemQty.Text) == 0)
                {
                    txtItemQty.Text = button.Text;
                }
                else
                {
                    txtItemQty.Text += button.Text;
                }
            }
        }
        private void saveCheck()
        {
            string inserSql = "Insert into tbl_Check(CheckDate,UserID,TotalCheck,Status)";
            inserSql += "values(@CheckDate,@UserID,@TotalCheck,@Status); ";
            inserSql += "SELECT @CheckId = SCOPE_IDENTITY(); ";
            SqlCommand sqlCmd = new SqlCommand(inserSql, adoClass.sqlCon);
            sqlCmd.Parameters.Add("CheckDate", SqlDbType.DateTime);
            sqlCmd.Parameters.Add("UserID", SqlDbType.Int);
            sqlCmd.Parameters.Add("TotalCheck", SqlDbType.Decimal);
            sqlCmd.Parameters.Add("Status", SqlDbType.VarChar);
            sqlCmd.Parameters.Add("CheckId", SqlDbType.Int);
            try
            {
                sqlCmd.Parameters["CheckId"].Direction = ParameterDirection.Output;
                sqlCmd.Parameters["CheckDate"].Value = DateTime.Now;
                sqlCmd.Parameters["UserID"].Value = declerationClass.userId;
                sqlCmd.Parameters["TotalCheck"].Value = double.Parse(txtTotal.Text);
                sqlCmd.Parameters["Status"].Value = "Close";
                if (adoClass.sqlCon.State != ConnectionState.Open)
                {
                    adoClass.sqlCon.Open();
                }
                sqlCmd.ExecuteNonQuery();
                CheckId = sqlCmd.Parameters["CheckId"].Value.ToString();
                this.Text += " : ID :" + CheckId + " : ";
                SaveDataItems(CheckId);
                SaveDataPayments(CheckId);
                MessageBox.Show("Done");

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

        private void SaveDataItems(string checkId)
        {
            adapter = new SqlDataAdapter("Select Top 1 * from CheckItems", adoClass.sqlCon);
            _itemDt = new DataTable();
            try
            {
                adapter.Fill(_itemDt);
                for (int i = 0; i < dgvItems.Rows.Count - 1; i++)
                {
                    DataRow row = _itemDt.NewRow();
                    row["CheckId"] = checkId;
                    row["ItemID"] = dgvItems[ColID.Index, i].Value;

                    row["Qty"] = dgvItems[ColQTY.Index, i].Value;
                    row["Price"] = dgvItems[ColItemPrice.Index, i].Value;
                    row["TotalPrice"] = dgvItems[ColPrice.Index, i].Value;
                    _itemDt.Rows.Add(row);

                }
                SaveDate();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void SaveDataPayments(string checkId)
        {
            adapter = new SqlDataAdapter("Select Top 1 * from tbl_ChecksPay", adoClass.sqlCon);
            _itemDt = new DataTable();
            try
            {
                adapter.Fill(_itemDt);

                DataRow row = _itemDt.NewRow();
                row["CheckId"] = checkId;
                row["PaymentID"] = ((comboItemClass)cmbPayment.SelectedItem).Id;
                row["PayVal"] = double.Parse(txtPaied.Text);
                _itemDt.Rows.Add(row);

                SaveDate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SaveDate()
        {
            adoClass.builder = new SqlCommandBuilder(adapter);
            adapter.Update(_itemDt);
        }
        private void btnPay_Click(object sender, EventArgs e)
        {
            double totalCheck = 0;
            double totalPay = 0;
            double.TryParse(txtTotal.Text, out totalCheck);
            double.TryParse(txtItemQty.Text, out totalPay);
            if (totalCheck == 0)
            {
                MessageBox.Show("Can't Save Empty Check");
                return;
            }
            if (totalPay == 0)
            {
                MessageBox.Show("Can't Save without mony");
                return;
            }
            if (totalPay < totalCheck)
            {
                MessageBox.Show("The Payment not enough");
                return;
            }
            if (cmbPayment.Text == string.Empty)
            {
                MessageBox.Show("Select Pay Method");
                return;
            }
            txtPaied.Text = totalCheck.ToString();
            txtChange.Text = (totalPay - totalCheck).ToString();
            saveCheck();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (CheckId != "0")
            {
                printChecks checks = new printChecks();
                checks.runPrintCheck(int.Parse(CheckId));
            }
            else
            {
                MessageBox.Show("Can't Print Non Paid Check");
            }

        }
    }
}
