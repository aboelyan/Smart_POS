using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_POS.Classes
{
    public class HelperClass
    {
        public static Byte[] ImageToByte(Image img)
        {
            Byte[] bResult = null;
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, ImageFormat.Png);
                bResult = ms.ToArray();
            }
            return bResult;
        }
        public static Image ByteToImage(object obj)
        {
            Byte[] myImg = (Byte[])obj;
            Image image = null;
            using (MemoryStream ms = new MemoryStream(myImg, 0, myImg.Length))
            {
                ms.Write(myImg, 0, myImg.Length);
                image = Image.FromStream(ms, true);
            }
            return image;

        }


        public static string getComboItemVal(ComboBox combo, string key)
        {
            string x = string.Empty;
            foreach (var item in combo.Items)
            {
                comboItemClass cItem = (comboItemClass)item;
                if (cItem.Id == key)
                {
                    x = cItem.Des;
                }
            }
            return x;
        }
        public static void fillCombo(ComboBox combo, string selectText)
        {
            SqlCommand command = new SqlCommand(selectText, adoClass.sqlCon);
            SqlDataReader dataReader = null;
            try
            {
                if (adoClass.sqlCon.State != ConnectionState.Open) adoClass.sqlCon.Open();
                combo.Items.Clear();
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    comboItemClass item = new comboItemClass(
                        dataReader[0].ToString(),
                        dataReader[1].ToString());
                    combo.Items.Add(item);
                }
                combo.Items.Add(new comboItemClass("", ""));
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
        public static void loadPermitions(Control.ControlCollection controls, string mainScreen)
        {
            foreach (Control control in controls)
            {
                modelPermition model = declerationClass.permitions.Where(x => x.mainScreen == mainScreen && 
                                                                              x.permition == control.AccessibleName).FirstOrDefault();
                if (model != null)
                {
                    control.Enabled = model.theCase;
                }
                if (control.Controls.Count > 0)
                {
                    loadPermitions(control.Controls, mainScreen);
                }
            }
        }
    }
}
