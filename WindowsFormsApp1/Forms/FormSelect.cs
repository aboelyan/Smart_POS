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
    public partial class FormSelect : Form
    {
        public FormSelect(string _selectText)
        {
            InitializeComponent();
            selectText = _selectText;
            txtDes.Focus();
        }
        private SqlDataAdapter adapter;
        private DataTable dataTable;
        public string selectText { get; set; }
        public string des { get; set; }
        public string result { get; set; }

        private void txtDes_KeyUp(object sender, KeyEventArgs e)
        {
            LoadSelect();
        }
        private void LoadSelect()
        {
            DataRow[] rows = dataTable.Select(des + " LIKE '%'+'" + txtDes.Text + "'+'%' ");
            dgvItems.Rows.Clear();
            for (int i = 0; i <= rows.Length -1; i++)
            {
                dgvItems.Rows.Add(new object[]
                {
                 rows[i][0],
                 rows[i][des]
                });
            }
        }
        private void FormSelect_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter(selectText, adoClass.sqlCon);
            dataTable = new DataTable();
            try
            {
                adapter.Fill(dataTable);
                LoadSelect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvItems.Rows.Count > 0)
            {
                result = dgvItems[ColID.Index, dgvItems.CurrentRow.Index].Value.ToString();
                this.DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
