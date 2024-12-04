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

namespace Smart_POS.Forms
{
    public partial class FormLogIn : Form
    {
       private SqlCommand cmd;
        private SqlDataReader dr;
        public FormLogIn()
        {
            InitializeComponent();
        }

        private void FormLogIn_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUuserName.Text =="")
            {
                MessageBox.Show("Enter UserName");
                return;
            }
            if (txtPass.Text == "")
            {
                MessageBox.Show("Enter Password");
                return;
            }
            logIn();
        }
        private void logIn()
        {
            string selectSql = "Select * from tbl_User where Username=@Username and Password=@Password";
            cmd = new SqlCommand(selectSql, adoClass.sqlCon);
            dr = null;
            cmd.Parameters.Add(new SqlParameter("@Username", SqlDbType.NVarChar));
            cmd.Parameters.Add(new SqlParameter("@Password", SqlDbType.NVarChar));
            cmd.Parameters["@Username"].Value=txtUuserName.Text;
            cmd.Parameters["@Password"].Value = txtPass.Text;
            try
            {
                if ( adoClass.sqlCon.State != ConnectionState.Open)adoClass.sqlCon.Open();
                dr=cmd.ExecuteReader();
                if(dr.HasRows)
                {

                    while (dr.Read())
                    {
                        declerationClass.userId = int.Parse(dr["ID"].ToString());
                        declerationClass.userFullName = dr["Fullname"].ToString();
                        this.DialogResult = DialogResult.OK;
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("LogIn Field");
                    return;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }finally { adoClass.sqlCon.Close(); }
            if (declerationClass.userId >0)
            {
                loadPermition(declerationClass.userId.ToString());
            }
        }

        private void loadPermition(string userCode)
        {
            declerationClass.permitions = new List<modelPermition>();
            string selectSql = "Select * from UserPermition where UserId ='" + userCode + "'";
            cmd = new SqlCommand(selectSql, adoClass.sqlCon);
            dr = null;
            try
            {
                if (adoClass.sqlCon.State != ConnectionState.Open) adoClass.sqlCon.Open();
                dr = cmd.ExecuteReader();
                modelPermition model = null;
                while (dr.Read())
                {
                    model= new modelPermition();
                    model.mainScreen = dr["mainScreen"].ToString() ;
                    model.permition = dr["permition"].ToString();
                    model.theCase = bool.Parse(dr["theCase"].ToString());
                    declerationClass.permitions.Add(model);
                }

                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally { adoClass.sqlCon.Close(); }
        }
    }
}
