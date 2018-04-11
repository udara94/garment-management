using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
//using static System.NullReferenceException;

namespace WindowsFormsApplication2
{
    public class DBAccess9
    {
        SqlConnection conn;

        public DBAccess9()
        {
            conn = ConnectionManager.GetConnection();
        }

        public DataTable getCustomer()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select CustomerId,NIC,Shop,Name,Address,ContactNumber,Email from RetailCustomer";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "RetailCustomer");
            dt = ds.Tables["RetailCustomer"];

            conn.Close();

            return dt;
        }
        public DataTable getSales()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select RetailID,Month,Shop,Item,SalesPrice,Quantity,TotalPrice,AdvancePayment,Arrear from dbo.SalesDetails";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "SalesDetails");
            dt = ds.Tables["SalesDetails"];

            conn.Close();

            return dt;


        }
        public DataTable getSalesman()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from dbo.Salesman";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "Salesman");
            dt = ds.Tables["Salesman"];

            conn.Close();

            return dt;


        }
        public DataTable getSalesRate()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from dbo.SalesRate";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "SalesRate");
            dt = ds.Tables["SalesRate"];

            conn.Close();

            return dt;


        }
        public DataTable getSalesRateOnly()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select SalesRate,Month from dbo.SalesRate";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "SalesRate");
            dt = ds.Tables["SalesRate"];

            conn.Close();

            return dt;


        }

        public DataTable getReturnHis()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from dbo.ReturnHistory";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "ReturnHistory");
            dt = ds.Tables["ReturnHistory"];

            conn.Close();

            return dt;


        }
        public bool addCus(string CusID, string NIC, string Shop, string Name, string Address, string contact, string mail)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "insert into dbo.RetailCustomer(NIC,Shop,Name,Address,ContactNumber,Email)values ('" + NIC + "','" + Shop + "','" + Name + "','" + Address + "','" + contact + "','" + mail + "')";

            newCmd.ExecuteNonQuery();
            status = true;
            return status;


        }
        public bool deleteCus(string CustomerId, string NIC)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "delete from dbo.RetailCustomer where CustomerId ='" + CustomerId + "' AND NIC='" + NIC + "'";


            newCmd.ExecuteNonQuery();

            status = true;
            return status;
        }
        public bool UpdateCus(string Shop, string Name, string Address, string ContactNumber, string Email, string CustomerId, string NIC)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "Update RetailCustomer set Shop='" + Shop + "' , Name='" + Name + "',Address='" + Address + "',ContactNumber='" + ContactNumber + "',Email='" + Email + "' where CustomerId = '" + CustomerId + "' AND NIC = '" + NIC + "'";
            newCmd.ExecuteNonQuery();

            status = true;
            return status;

        }


        public bool addSales(string RetailID, string Month, string Shop, string ItemName, string SalesPrice, string Quantity, string Total, string AdvancePayment, string Arrear)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "insert into dbo.SalesDetails(Month,Shop,Item,SalesPrice,Quantity,TotalPrice,AdvancePayment,Arrear)values ('" + Month + "','" + Shop + "', '" + ItemName + "','" + SalesPrice + "','" + Quantity + "','" + Total + "','" + AdvancePayment + "','" + Arrear + "')";


            newCmd.ExecuteNonQuery();


            status = true;
            return status;


        }
        public bool deleteSales(string RetailID)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "delete from dbo.SalesDetails where RetailID ='" + RetailID + "'";


            newCmd.ExecuteNonQuery();

            status = true;
            return status;
        }

        public bool UpdateSales(string month, string Shop, string ItemName, string SalesPrice, string Quantity, string Total, string AdvancePayment, string Arrear, string RetailID)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "Update SalesDetails set Month ='" + month + "', Shop ='" + Shop + "' , Item ='" + ItemName + "',SalesPrice='" + SalesPrice + "',Quantity='" + Quantity + "', TotalPrice='" + Total + "', AdvancePayment='" + AdvancePayment + "',Arrear='" + Arrear + "' where RetailID = '" + RetailID+"'";
            newCmd.ExecuteNonQuery();

            status = true;
            return status;


        }
        public bool addSalesman(string EmployeeID, string NoOfShops, string Region)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "insert into dbo.Salesman(EmpID,NuOfShops,Region)values ('" + EmployeeID + "','" + NoOfShops + "', '" + Region + "')";


            newCmd.ExecuteNonQuery();


            status = true;
            return status;


        }
        public bool deleteSalesman(string EmpID)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "delete from dbo.Salesman where EmpID ='" + EmpID + "'";


            newCmd.ExecuteNonQuery();

            status = true;
            return status;
        }
        public bool UpdateSalesman(string EmpID, string NuOfShops,  string Region)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "Update Salesman set NuOfShops ='" + NuOfShops + "',Region='" +Region + "' where EmpID = '" + EmpID + "'";
            newCmd.ExecuteNonQuery();

            status = true;
            return status;


        }

        public bool addSaleRate(string Month, string income, string rate)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "insert into dbo.SalesRate(Month,Income,SalesRate)values ('" + Month + "','" + income + "', '" + rate + "')";


            newCmd.ExecuteNonQuery();


            status = true;
            return status;


        }
        public bool deleteSalesRate(string Month)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "delete from dbo.SalesRate where Month ='" + Month + "'";


            newCmd.ExecuteNonQuery();

            status = true;
            return status;

        }
        public bool UpdateSalesRate(string Month, string Income, string Rate)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "Update SalesRate set Income ='" + Income + "' , SalesRate ='" + Rate + "' where Month = '" + Month + "'";
            newCmd.ExecuteNonQuery();

            status = true;
            return status;


        }
        public bool addReturnHis(string RetailID, string Description, string Reallocations, string Loss)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "insert into dbo.ReturnHistory (RetailID,Description,Reallocations,Loss)values ('" + RetailID + "','" + Description + "', '" + Reallocations + "','" + Loss + "')";


            newCmd.ExecuteNonQuery();


            status = true;
            return status;


        }
        public bool deleteReturnHis(string RetailID)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "delete from dbo.ReturnHistory where RetailID ='" + RetailID + "'";


            newCmd.ExecuteNonQuery();

            status = true;
            return status;

        }
        public bool UpdateReturnHis(string RetailID, string Description, string Reallocation, string Loss)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "Update ReturnHistory set Description ='" + Description + "' , Reallocations ='" + Reallocation + "', Loss = '" + Loss + "' where RetailID = '" + RetailID + "'";
            newCmd.ExecuteNonQuery();

            status = true;
            return status;


        }
        public bool CalcIncome(string Month)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select SUM(TotalPrice) from dbo.SalesDetails where Month='" + Month + "'";
            newCmd.ExecuteNonQuery();

            //  string income = newCmd.CommandText;


            // double  income = (double)newCmd.ExecuteScalar();


            conn.Close();
            status = true;
            return status;
            // return income;
            // return dt;
            //return Convert.ToBoolean(income);

        }
        public double calculation(string Month)
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select SUM(TotalPrice) as TotalIncome from dbo.SalesDetails where Month='" + Month + "'";

            double sum = (double)newCmd.ExecuteScalar();
            return sum;

        }
       public double LastMonthIncome(string month)
       {
            //DateTime dateadd = new DateTime();
            if (conn.State.ToString() == "Closed")
            {
               conn.Open();
            }
            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select SUM(TotalPrice) as TotalIncomes from dbo.SalesDetails where Month = (select datename(month, dateadd  (month ,-1,getdate())))";

            double summation = (double)newCmd.ExecuteScalar();
            return summation;

            
        }
    }
}

