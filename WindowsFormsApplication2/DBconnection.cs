using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace WindowsFormsApplication2
{
    public class DBconnection
    {
        SqlConnection conn;

        public DBconnection()
        {
            conn = ConnectionManager.GetConnection();
        }

        public DataTable getDriver()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select DriverID,NIC,Name,DAddress,ContactNumber,JoinDate,LicenseNumber,LicenseIssueDate,LicenseType From dbo.DBDriver";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "DBDriver");
            dt = ds.Tables["DBDriver"];

            conn.Close();

            return dt;
        }


        public bool insertDriver(string nic, string name, string address, string telephone, string joindate, string lnumber, string lidate, string ltype)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "insert into dbo.DBDriver(NIC, Name, DAddress, ContactNumber, JoinDate,LicenseNumber,LicenseIssueDate,LicenseType) values ('" + nic + "', '" + name + "','" + address + "','" + telephone + "','" + joindate + "','" + lnumber + "','" + lidate + "','" + ltype + "')";


            newCmd.ExecuteNonQuery();




            status = true;

            return status;

        }

        public bool saveDriver()
        {

            return true;
        }

        public bool deleteDriver(string DriverID, string NIC)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "delete from dbo.DBDriver where DriverID ='" + DriverID + "' AND NIC='" + NIC + "'";


            newCmd.ExecuteNonQuery();

            status = true;
            return status;
        }


        public bool updateDriver(string nic, string name, string address, string telephone, string joindate, string lnumber, string lidate, string ltype)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "Update dbo.DBDriver set NIC ='" + nic + "',Name='" + name + "',DAddress='" + address + "',ContactNumber='" + telephone + "',JoinDate='" + joindate + "',LicenseNumber='" + lnumber + "',LicenseIssueDate='" + lidate + "',LicenseType = '" + ltype + "' where NIC ='" + nic + "'";


            newCmd.ExecuteNonQuery();

            status = true;
            return status;
        }




        //vehicle data

        public DataTable getVehicle()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select vehicleID,VehicleNumber,vType,MaxWeight,LicenseInsurranceNu,LicenseInsurrenceExpDate from dbo.DBVehicle";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "DBVehicle");
            dt = ds.Tables["DBVehicle"];

            conn.Close();

            return dt;
        }

        public bool insertVehicle(string vnu, string vtype, string vmw, string vlin, string vlied)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "insert into dbo.DBVehicle(VehicleNumber, vType, MaxWeight, LicenseInsurranceNu, LicenseInsurrenceExpDate) values ('" + vnu + "','" + vtype + "', '" + vmw + "','" + vlin + "','" + vlied + "')";


            newCmd.ExecuteNonQuery();




            status = true;

            return status;

        }

        public bool deleteVehicle(string vehicleID)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "delete from dbo.DBVehicle where vehicleID ='" + vehicleID + "'";


            newCmd.ExecuteNonQuery();

            status = true;
            return status;
        }

        public bool updateVehicle(string vnu, string vtype, string vmw, string linn, string linexd)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "Update dbo.DBVehicle set vType ='" + vtype + "',MaxWeight='" + vmw + "',LicenseInsurranceNu='" + linn + "',LicenseInsurrenceExpDate='" + linexd + "' where VehicleNumber ='" + vnu + "'";


            newCmd.ExecuteNonQuery();

            status = true;
            return status;
        }

        //-------------------------------running Chart-------------

        public DataTable getrunningChart()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select RunnigChartNumber,DriverID,VehicleID,OutTime,InTime,Date,Distance,Start,Destination From dbo.DBRunning";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "DBRunning");
            dt = ds.Tables["DBRunning"];

            conn.Close();

            return dt;
        }

        public bool insertrunningdata(string did, string vid, string outtm, string intm, string date, string km, string fm, string t)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "insert into dbo.DBRunning(DriverID,VehicleID,OutTime, InTime, Date,Distance,Start,Destination) values ('" + did  + "','" + vid + "','" + outtm + "', '" + intm + "','" + date + "','" + km + "','" + fm + "','" + t + "')";


            newCmd.ExecuteNonQuery();




            status = true;

            return status;

        }

        //------------------transpotation Cost-----------------------

        public DataTable gettranspocost()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select TranspotationID,VehicleID,Kilometers,FuelType,DriverCost,OtherCost,TransportCost From dbo.DBTransCost";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "DBTransCost");
            dt = ds.Tables["DBTransCost"];

            conn.Close();

            return dt;
        }


        public bool inserttransportc(string vid, string km, string ftype, string dc, string oc,string tc)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "insert into dbo.DBTransCost(VehicleID,Kilometers,FuelType, DriverCost, OtherCost,TransportCost) values ('" + vid + "','" + km + "','" + ftype + "', '" + dc + "','" + oc + "','" + tc + "')";


            newCmd.ExecuteNonQuery();




            status = true;

            return status;

        }

        public bool deleteTranspotaioncost(string tID)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "delete from dbo.DBTransCost where TranspotationID ='" + tID + "'";


            newCmd.ExecuteNonQuery();

            status = true;
            return status;
        }


        //----------------------Availability-------------------------


        public DataTable availability()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * From dbo.DBAvailability";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "DBAvailability");
            dt = ds.Tables["DBAvailability"];

            conn.Close();

            return dt;
        }


        public bool insertAvailability(string did, string vid, string av)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "insert into dbo.DBAvailability(DriverID,VehicleID,Availablility) values ('" + did + "','" + vid + "','" + av + "')";


            newCmd.ExecuteNonQuery();




            status = true;

            return status;

        }
        public bool updateAvailability(string did, string vid, string av)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "Update dbo.DBAvailability set DriverID ='" + did + "',VehicleID='" + vid + "',Availablility='" + av + "' where DriverID ='" + did + "'";

            newCmd.ExecuteNonQuery();

            status = true;
            return status;
        }

       

    }
}







