using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace WindowsFormsApplication2
{
    class DBAccess2
    {
        SqlConnection conn;

        public DBAccess2()
        {
            conn = ConnectionManager.GetConnection();
        }


        /****************************
           Other Transaction Details
          ****************************/
        public DataTable getOtherTran()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select Tran_Id as ID,Tran_descript as Description,Tran_type as Type,Tran_amount as Amount,Tran_date as Date from OtherTransactions";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "OtherTransactions");
            dt = ds.Tables["OtherTransactions"];

            conn.Close();

            return dt;
        }
        /************************************
          Add New Other Transacions Details
         ************************************/
        public bool addOtherTran(string name, string type, double amount, string date)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "insert into  OtherTransactions(Tran_descript,Tran_type,Tran_amount,Tran_date) values ('" + name + "', '" + type + "','" + amount + "','" + date + "')";
            newCmd.ExecuteNonQuery();
            newCmd.CommandText = "insert into Expenditure(ID, Date, Amount) select Tran_ID, Tran_date, Tran_amount from OtherTransactions where Tran_ID in (select Top 1 Tran_ID from OtherTransactions order by Tran_ID desc)";
            newCmd.ExecuteNonQuery();


            status = true;

            return status;

        }
        /***************************************
           Update New Other Transacions Details
          ***************************************/
        public bool updateOtherTran(string name, string type, string amount, string date, string ID)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "update OtherTransactions set Tran_descript='" + name + "',Tran_type = '" + type + "',Tran_amount='" + amount + "',Tran_date='" + date + "' where Tran_ID='" + ID + "'";
            newCmd.ExecuteNonQuery();

            status = true;

            return status;

        }
        /***********************************
           Delete Other Transacions Details
          ***********************************/
        public bool deleteOtherTran(string Id)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "delete from OtherTransactions where Tran_ID ='" + Id + "'";
            newCmd.ExecuteNonQuery();

            status = true;

            return status;
        }




        /****************************
           Driver ID Details
          ****************************/
        public DataTable getDriverID()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("DriverID", typeof(string));

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select DriverID from dbo.DBDriver";
            SqlDataReader dr = newCmd.ExecuteReader();
            while (dr.Read())
            {
                dt.Rows.Add(dr["DriverID"]);
            }
            conn.Close();
            return dt;
        }

        /************************
           Driver Salary Details
          ************************/
        public DataTable getDriverSalaryDetails()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from DriverSalary";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "itpusers");
            dt = ds.Tables["itpusers"];

            conn.Close();

            return dt;
        }

        /**************************
          Add Driver Salary Details
         ****************************/
        public bool addDriverSalaryDetails(string ID, string date, int atten, string payday, int turn, string payturn, string netSalary)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "insert into DriverSalary(DriverID,Date,NumberOfAttendDates,PaymentForOneday,PaymentPerTurn,NumberOfTurns,NetSalary) values ('" + ID + "','" + date + "', '" + atten + "','" + payday + "','" + turn + "','" + payturn + "','" + netSalary + "')";
            newCmd.ExecuteNonQuery();

            status = true;

            return status;

        }


        /************************
           Employee Salary Details
          ************************/
        public DataTable getEmployeeSalaryDetails()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select empid, basic_salary, Net_salary from dbo.empsalary2";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "Employees");
            dt = ds.Tables["Employees"];

            conn.Close();

            return dt;
        }





        /***************
          Income Details
         ****************/
        public DataTable getIncome()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select Year(date) as Year , month(date) as Month,sum(Amount) as MonthIncome from Income group by year(date),month(Date)";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "Income");
            dt = ds.Tables["Income"];

            conn.Close();

            return dt;
        }
        /***************
          Cost Details
         **************/
        public DataTable getCost()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select Year(date) as Year,month(date) as Month,sum(Amount) as MonthExpends from Expenditure group by year(date),month(Date)";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "Expenditure");
            dt = ds.Tables["Expenditure"];

            conn.Close();

            return dt;
        }


        /**********************
          Sales Profit Details
         **********************/
        public DataTable getSalesProfit()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select RetailID,Month,TotalPrice from SalesDetails";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "Sales");
            dt = ds.Tables["Sales"];

            conn.Close();

            return dt;
        }


        /********************
          Order Profit Details
         ********************/
        public DataTable getOrderProft()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select o.OrderID,o.OrderDate,(p.salse_price*o.Quantity) as Income,(p.unit_price*o.Quantity) as cost,(p.profit*o.Quantity) as profit from Orders o ,product_details p where o.Size = p.size";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "Income");
            dt = ds.Tables["Income"];

            conn.Close();

            return dt;
        }


        /****************************
          Order ID Details
         ****************************/
        public DataTable getOrderID()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("DriverID", typeof(string));

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select OrderID from Orders";
            SqlDataReader dr = newCmd.ExecuteReader();
            while (dr.Read())
            {
                dt.Rows.Add(dr["OrderID"]);
            }
            conn.Close();
            return dt;
        }


        /****************************
          Retail ID Details
         ****************************/
        public DataTable getRetailID()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("DriverID", typeof(string));

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select RetailID from SalesDetails";
            SqlDataReader dr = newCmd.ExecuteReader();
            while (dr.Read())
            {
                dt.Rows.Add(dr["RetailID"]);
            }
            conn.Close();
            return dt;
        }
    }
    }
