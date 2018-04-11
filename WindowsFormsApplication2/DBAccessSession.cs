using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;

namespace WindowsFormsApplication2
{
    class DBAccessSession
    {
        Security sec = new Security();
        SqlConnection conn;

        public DBAccessSession()
        {
            conn = ConnectionManager.GetConnection();
        }


        /*Upload Picture*/
        public bool addPic(byte[] name)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "insert into  Users(UserPhoto) values (@photo)";
            newCmd.Parameters.Add(new SqlParameter("@photo", name));
            newCmd.ExecuteNonQuery();

            status = true;

            return status;

        }

        /*Retreive Picture*/
        public DataTable getPic()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select UserPhoto from Users";

            //where UserName = '"+uname+"' and UserPassword = '"+pwd+"'

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "Users");
            dt = ds.Tables["Users"];

            conn.Close();

            return dt;
        }

        public bool updateUser(string pwd, string uname, byte[] name)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "update Users set UserPassword='" + pwd + "',UserPhoto=@photo where UserName='" + uname + "'";
            //newCmd.Parameters.Add(new SqlParameter("@photo", name));
            newCmd.Parameters.Add("@photo", SqlDbType.Image);

            if (name == null)
            {
                newCmd.Parameters["@photo"].Value = DBNull.Value;
            }
            else
            {
                newCmd.Parameters["@photo"].Value = name;
            }

            newCmd.ExecuteNonQuery();

            status = true;

            return status;

        }
        public DataTable getUserDetails(string user, string pwd)
        {

            string ConStr = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            SqlConnection NewCon = new SqlConnection(ConStr);
            NewCon.Open();

            SqlCommand newCmd = NewCon.CreateCommand();
            newCmd.Connection = NewCon;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select Users_ID,UserName,UserType,UserPhoto,UserPassword from Users where UserName = '" + user + "' and UserPassword = '" + pwd + "'";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "Users2");
            dt = ds.Tables["Users2"];

            NewCon.Close();

            return dt;
        }

        public bool AdminAddUser(string name,string pwd,string type)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "insert into  Users(UserName,UserPassword,UserType) values ('"+name+ "','" +sec.Encrypt(pwd) + "','" + type + "')";
            newCmd.ExecuteNonQuery();

            status = true;

            return status;

        }
        public DataTable AdminLoadUserDetails()
        {

            string ConStr = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            SqlConnection NewCon = new SqlConnection(ConStr);
            NewCon.Open();

            SqlCommand newCmd = NewCon.CreateCommand();
            newCmd.Connection = NewCon;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select Users_ID,UserName,UserPassword,UserType from Users ";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "Users3");
            dt = ds.Tables["Users3"];

            NewCon.Close();

            return dt;
        }

        public bool AdminDeleteUser(string Id)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "delete from Users where Users_ID ='" + Id + "'";
            newCmd.ExecuteNonQuery();

            status = true;

            return status;
        }


        public bool AdminupdateUsers(string ID,string name, string pwd, string type)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "update Users set UserName='" + name + "',UserPassword = '" + pwd + "',UserType='" + type + "' where Users_ID='" + ID + "'";
            newCmd.ExecuteNonQuery();

            status = true;

            return status;

        }


        public bool SendMsg(DateTime date,string To, string from, string msg)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "insert into  Notification(Msg_Date,Msg_To,Msg_from,Msg) values ('" + date + "','" + To + "','" + from + "','" + msg + "')";
            newCmd.ExecuteNonQuery();

            status = true;

            return status;

        }

        public DataTable ReceiveMsg(string to)
        {

            string ConStr = ConfigurationManager.ConnectionStrings["ConString"].ConnectionString;
            SqlConnection NewCon = new SqlConnection(ConStr);
            NewCon.Open();

            SqlCommand newCmd = NewCon.CreateCommand();
            newCmd.Connection = NewCon;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select Msg_Date,Msg_from,Msg from Notification where Msg_To = '" + to + "' ";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "Notification");
            dt = ds.Tables["Notification"];

            NewCon.Close();

            return dt;
        }

        public DataTable getUsersname()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Username", typeof(string));

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select UserName from Users";
            SqlDataReader dr = newCmd.ExecuteReader();
            while (dr.Read())
            {
                dt.Rows.Add(dr["UserName"]);
            }
            conn.Close();
            return dt;
        }


    }
}
