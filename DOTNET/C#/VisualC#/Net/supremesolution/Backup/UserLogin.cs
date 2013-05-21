using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using DevExpress.XtraEditors;


namespace SupremeTransport
{
    enum userGroup
    {
        Supreme,
        Zahid
    };
    class UserLogin
    {
        static string CSupCon = System.Configuration.ConfigurationManager.ConnectionStrings["supremeCon"].ToString();
        static bool authenticate = false;
        static int userid = 0;
        static string usertype;

        static userGroup usergroup;

       static  internal userGroup Usergroup
        {
            get { return usergroup; }
            set { usergroup = value; }
        }
       
        private static string userName;

        public static string UserName
        {
            get
            {
                if (userName.Length <= 0)
                {
                    throw new NullReferenceException("Value of user name is not set please login first");
                }
                else
                {
                    return userName;
                }
            }
            set
            {
                userName = value;
            }
        }

        /// <summary>
        /// Returns SqlConnection
        /// </summary>
        public static SqlConnection SqlCon()
        {
            SqlConnection con = new SqlConnection(CSupCon);
            return con;
        }

        public static bool CheckUser(TextBox user, TextBox pass, ComboBoxEdit cbEdit,Button btn)
        {
            userid = 0;
            SqlConnection con = SqlCon();
             
            bool retUserst = false;
            string query = String.Empty;
            if(btn.Name == "btnSLogin")
            {
                query = "select * from sup.usertable";
                Usergroup = userGroup.Supreme;
            }
            if (btn.Name == "btnZlogin")
            {
                query = "select * from zah.usertable";
                Usergroup = userGroup.Zahid;
            }

            try
            {

                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    if (dr["username"].ToString().ToLower().Trim().Equals(user.Text.Trim().ToLower()) & dr["userpass"].ToString().ToLower().Trim().Equals(pass.Text.Trim().ToLower()) & dr["usertype"].ToString().ToLower().Trim().Equals(cbEdit.SelectedItem.ToString().Trim().ToLower()))
                    {
                        retUserst = true;
                        UserLogin.UserName = dr["username"].ToString();
                        UserLogin.UserId = Convert.ToInt32(dr["userid"].ToString());
                        UserLogin.Usertype = dr["usertype"].ToString();
                        break;
                    }
                }
                dr.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return retUserst;
        }
        
        public static bool Authenticated
        {
            get
            {
                return UserLogin.authenticate;
            }
            set
            {
                UserLogin.authenticate = value;
            }
        }
        public static int UserId
        {
            get
            {
                return UserLogin.userid;
            }
            set
            {
                UserLogin.userid = value;
            }
        }
        public static string Usertype
        {
            get { return UserLogin.usertype; }
            set { UserLogin.usertype = value; }
        }
    }
}
