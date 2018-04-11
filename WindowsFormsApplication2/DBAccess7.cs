using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    
    public class DBAccess7
    {
       
        SqlConnection conn;
        DataTable dt2;
        DataTable dt3;
        
        

        public DBAccess7()
        {
            conn = ConnectionManager.GetConnection();
        }
      
        public DataTable getmachine()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select MachineID,Type,InstallDate,ServiceDate,PurchasePrice,PurchaseCompany,EstimatedLife  from dbo.Machines";
            

           
            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds2 = new DataSet();
            dt2 = new DataTable();
            da.Fill(ds2, "Machines");
            dt2 = ds2.Tables["Machines"];
            
            
            conn.Close();

            return dt2;
        }
        public DataTable getparts()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select PartID,Type,PurchasePrice,Quantity,InstallDate,PurchaseCompany,PurchaseDate from dbo.Part order by part_id asc";



            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds3 = new DataSet();
            dt3 = new DataTable();
            da.Fill(ds3, "Part");
            dt3 = ds3.Tables["Part"];


            conn.Close();

            return dt3;
        }
        public DataTable getservice()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newcmd = conn.CreateCommand();
            newcmd.Connection = conn;
            newcmd.CommandType = CommandType.Text;
            newcmd.CommandText = "select ServiceNO,MachineID,ServiceDate,ServiceTimePeriod,Cost,ServiceStation from dbo.MachineServices";

            SqlDataAdapter da = new SqlDataAdapter(newcmd);
            DataSet ds = new DataSet();
            dt2 = new DataTable();
            da.Fill(ds, "MachineServices");
            dt2 = ds.Tables["MachineServices"];


            conn.Close();

            return dt2;
        }

        public DataTable getrepaire()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newcmd = conn.CreateCommand();
            newcmd.Connection = conn;
            newcmd.CommandType = CommandType.Text;
            newcmd.CommandText = "select RepaireNO,MachineID,RepaireType,RepaireCost,Date,Month,Year from dbo.Repaire order by repaire_id asc";



            SqlDataAdapter da = new SqlDataAdapter(newcmd);
            DataSet ds = new DataSet();
            dt2 = new DataTable();
            da.Fill(ds, "Repaire");
            dt2 = ds.Tables["Repaire"];

          

            conn.Close();

            return dt2;
        }
        public DataTable getcost()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newcmd = conn.CreateCommand();
            newcmd.Connection = conn;
            newcmd.CommandType = CommandType.Text;
            newcmd.CommandText = "select cast(round(sum(RepaireCost),2)as numeric (12,2)) from dbo.Repaire";
           


             SqlDataAdapter da = new SqlDataAdapter(newcmd);
            DataSet ds = new DataSet();
            dt2 = new DataTable();
            da.Fill(ds, "Repaire");
            dt2 = ds.Tables["Repaire"];



            conn.Close();

            return dt2;
        }
        public int getmothlycost(string month,int year)
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newcmd = conn.CreateCommand();
            newcmd.Connection = conn;
            newcmd.CommandType = CommandType.Text;

            newcmd.CommandText = "select sum(RepaireCost) from dbo.Repaire where Month='"+month+"' and Year='"+year+"'";



            int cost = (int)newcmd.ExecuteScalar();
            return cost;
     
        }
        public int getannualcost(int year)
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newcmd = conn.CreateCommand();
            newcmd.Connection = conn;
            newcmd.CommandType = CommandType.Text;

            newcmd.CommandText = "select sum(RepaireCost) from dbo.Repaire where Year between '" + year + "' and '" + year + "'";



            int cost =(int)newcmd.ExecuteScalar();
            return cost;

        }
        public DataSet getpartshistory()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newcmd = conn.CreateCommand();
            newcmd.Connection = conn;
            newcmd.CommandType = CommandType.Text;
            newcmd.CommandText = "select PartID, Type,PurchasePrice,Quantity,PurchaseCompany,PurchaseDate from dbo.Part";
            
            SqlDataAdapter da = new SqlDataAdapter(newcmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Part");

            conn.Close();

            return ds;
        }
        public DataSet getdepreciation()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newcmd = conn.CreateCommand();
            newcmd.Connection = conn;
            newcmd.CommandType = CommandType.Text;
            newcmd.CommandText = "select MachineID,Type,InstallDate ,PurchasePrice,EstimatedLife  from dbo.Machines";
            
            SqlDataAdapter da = new SqlDataAdapter(newcmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Machines");

            conn.Close();

            return ds;
        }
   
      
           public bool addrepaire( string macno, string type, string cost, string date,string month,string year)
            {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "insert into dbo.Repaire(MachineID, RepaireType, RepaireCost,Date,Month,Year)values ( '" + macno + "','" + type + "','" + cost + "','" + date+ "','"+month+"','"+ year + "')";

            newCmd.ExecuteNonQuery();

            status = true;

            return status;

        }
        public bool addmachine(string Type, string indate,string serdate,string price,string purcom,string life)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "insert into dbo.Machines(Type,InstallDate,ServiceDate,PurchasePrice,PurchaseCompany,EstimatedLife)values ( '" + Type + "','" + indate + "','" + serdate + "','" + price + "','"+ purcom + "','"+life+"')";

            newCmd.ExecuteNonQuery();

            status = true;

            return status;

        }
        public bool addparts(string Type, string qty, string purprice, string indate, string purcom,string purdate)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "insert into dbo.Part(Type,Quantity,PurchasePrice,InstallDate,PurchaseCompany,PurchaseDate)values ( '" + Type + "','" + qty + "','" + purprice + "','" + indate + "','" + purcom + "','"+ purdate + "')";

            newCmd.ExecuteNonQuery();

            status = true;

            return status;

        }
        public bool addservice(string macno,string serdate,string sper,string cost,string serstate)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "insert into dbo.MachineServices(MachineID,ServiceDate,ServiceTimePeriod,Cost,ServiceStation)values ( '" + macno + "','" + serdate + "','" + sper + "','" + cost + "','" + serstate + "')";

            newCmd.ExecuteNonQuery();

            status = true;

            return status;

        }











        public bool updatemachine(string mid,string type, string insdate,string serdate,string purprice,string purcom,int life)
        {
            bool status = false;
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd3 = conn.CreateCommand();
            btn_demo md = new btn_demo();
            newCmd3.Connection = conn;
            newCmd3.CommandType = CommandType.Text;
            newCmd3.CommandText = "update Machines set Type='"+ type + "',InstallDate='" + insdate + "',ServiceDate='" + serdate + "',PurchasePrice='" + purprice + "',PurchaseCompany='" + purcom + "',EstimatedLife='"+life+"' where  MachineID='" + mid +"';";

            
            newCmd3.ExecuteNonQuery();

            status = true;

            return status;

        }
        public bool updateservice(string seno, string date, string machno, string serper, string sercost, string serstat)
        {
            bool status = false;
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd3 = conn.CreateCommand();
            btn_demo md = new btn_demo();
            newCmd3.Connection = conn;
            newCmd3.CommandType = CommandType.Text;
            newCmd3.CommandText = "update MachineServices set  ServiceDate='" + date + "',MachineID='" + machno + "',ServiceTimePeriod='" + serper + "',Cost='" + sercost + "',ServiceStation='" + serstat + "' where ServiceNO='" + seno + "' ;";
            
                  newCmd3.ExecuteNonQuery();

            status = true;

            return status;

        }


        public bool updateparts(string id, string type, string purprice, int qty, string indate,string purcom,string purdate)
        {
            bool status = false;
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd3 = conn.CreateCommand();
            btn_demo md = new btn_demo();
            newCmd3.Connection = conn;
            newCmd3.CommandType = CommandType.Text;
            newCmd3.CommandText = "update Part set  Type='" + type + "',PurchasePrice='" + purprice + "',Quantity='" + qty + "',InstallDate='" + indate + "',PurchaseCompany='" + purcom + "',PurchaseDate='" + purdate + "' where PartID='" + id + "' ;";
            
                 newCmd3.ExecuteNonQuery();

            status = true;

            return status;

        }
        public bool deletemachine(string mashine)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "delete from Machines where MachineID='" + mashine+ "';";
            newCmd.ExecuteNonQuery();

            status = true;

            return status;
        }
        public bool deleteparts(string part)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "delete from Part where PartID='" + part + "';";
            newCmd.ExecuteNonQuery();

            status = true;

            return status;
        }
        public bool deleteservice(string service)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "delete from MachineServices where ServiceNO='" + service + "';";
            newCmd.ExecuteNonQuery();

            status = true;

            return status;
        }
        public bool deleterepaire(string rep)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "delete from Repaire where RepaireNO='" + rep + "';";
            newCmd.ExecuteNonQuery();

            status = true;

            return status;
        }







    }
}