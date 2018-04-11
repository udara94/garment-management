using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace WindowsFormsApplication2
{
    public class DBAccess
    {
        SqlConnection conn;

        public DBAccess()
        {
            conn = ConnectionManager.GetConnection();
        }


        public DataTable getproduct_details()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select p_id as 'Product_ID', category as Category, size as Size, colour as Colour, unit_price as 'Unit Price', salse_price as 'Sales Price',profit as Profit, quality as Quality, allocations as Allocations, product_details as 'Product Details', Date as Date, Month as Month from product_details";


            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "product_details");
            dt = ds.Tables["product_details"];


            conn.Close();

            return dt;
        }


        //add product details
        public bool add_details(string pid, string category, string size, string colour, string unit_price, string salse_price, string profit, string quality, string product_details, string lbl, string product_dateTime,string month)

        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "insert into product_details(p_id,category,size,colour,unit_price,salse_price,profit,quality,product_details,allocations,Date,Month) values ('" + pid + "','" + category + "','" + size + "','" + colour + "','" + unit_price + "','" + salse_price + "','" + profit + "','" + quality + "','" + product_details + "','" + lbl + "','" + product_dateTime + "','"+month+"')";



            newCmd.ExecuteNonQuery();

            status = true;
            return status;


        }

        //add rejected sales
        
        public bool addSalesR_details(string pid, string category,string allocation, string unit_price, string quality, string reason, string date, string month)

        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "insert into RejectedItems(productID,category,Allocation,UnitPrice,quality,Reason,Date,Month) values ('" + pid + "','" + category + "','" + allocation + "','" + unit_price + "','" + quality + "','" + reason + "','" + date + "','" + month +  "')";



            newCmd.ExecuteNonQuery();

            status = true;
            return status;


        }


        //get rejected item details
        public DataTable getrejected_details()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select productID as Product_ID, category as Category, Allocation as Allocation,UnitPrice as 'Unit Price' , quality as Quality,Reason as Reason, Date as Date, Month as Month from RejectedItems";


            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "RejectedItems");
            dt = ds.Tables["RejectedItems"];


            conn.Close();

            return dt;
        }

        //add rejected items
        public bool rejected_details(string pid, string category, string allocation, string unit_price, string quality, string product_dateTime,string month)

        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "insert into RejectedItems(productID,category,Allocation,UnitPrice,quality,Date,Month) values ('" + pid + "','" + category + "','" + allocation + "','" + unit_price + "','" + quality + "','" + product_dateTime + "','"+ month + "')";



            newCmd.ExecuteNonQuery();



            status = true;
            return status;


        }

        //add export product details
        public bool export_details(string pid, string category, string allocation, string unit_price,string sellingPrice,string profit, string quality, string product_details,string product_dateTime)

        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "insert into ExportProductDetails(Product_ID, category, Allocation, UnitPrice,SellingPrice, profit, Quality,ProductDetails,Date) values ('" + pid + "','" + category + "','" + allocation + "','" + unit_price + "','"+ sellingPrice + "','"+ profit + "','" + quality + "','"+ product_details + "','" + product_dateTime + "')";

            newCmd.ExecuteNonQuery();

            status = true;
            return status;

        }


        //add product process                   
        public bool add_process(string pid, string section_id, string in_process, string out_process, string pending_quantity, string quality_status)

        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "insert into product_process(process_id,section_id,in_pro,out_pro,pending_quantity,status) values ('" + pid + "','" + section_id + "','" + in_process + "','" + out_process + "','" + pending_quantity + "','" + quality_status + "')";

            try
            {
                newCmd.ExecuteNonQuery();
            }
            catch { }

            status = true;
            return status;

        }

        //get process details
        public DataTable get_process()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select process_id as Process_ID, section_id as 'Section ID', in_pro as 'In Process Amount', out_pro as 'Out Process Amount', pending_quantity as 'Pending Quantity', status as Status, Allocation as Allocation from product_process";


            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "product_process");
            dt = ds.Tables["product_process"];


            conn.Close();

            return dt;
        }

        //get export details
        public DataTable get_export_details()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from ExportProductDetails";


            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "ExportProductDetails");
            dt = ds.Tables["ExportProductDetails"];


            conn.Close();

            return dt;
        }



        //get sales details
        public DataTable get_sales_details()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from sales_details";


            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "sales_details");
            dt = ds.Tables["sales_details"];


            conn.Close();

            return dt;
        }

        public DataTable get_calculation_details()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from Calculations";


            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "Calculations");
            dt = ds.Tables["Calculations"];


            conn.Close();

            return dt;
        }




        //delete product process
        public bool delete_process(string pp_proid)
        {
            bool status = false;
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "delete from dbo.product_process where process_id = '" + pp_proid + "'";

            try
            {
                newCmd.ExecuteNonQuery();
            }
            catch { }

            status = true;
            return status;
        }

        //delete product details
        public bool delete_pdetails(string p_pid_txt)
        {
            bool status = false;
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "delete from dbo.product_details where p_id = '" + p_pid_txt + "'";

            try
            {
                newCmd.ExecuteNonQuery();
            }
            catch { }

            status = true;
            return status;
        }

        //delete rejected items
        public bool delete_rejectedItems(string rejectedID_txt)
        {
            bool status = false;
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "delete from dbo.RejectedItems where productID = '" + rejectedID_txt + "'";

            try
            {
                newCmd.ExecuteNonQuery();
            }
            catch { }

            status = true;
            return status;
        }


        //update for product details
        public bool p_details(string product_ID, string category, string size, string colour, string uprice, string selprice, string profit, string pquality, string allocation, string product_details)
        {

            bool status = false;
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "update product_details set category='" + category + "', size='" + size + "', colour = '" + colour + "' ,unit_price='" + uprice + "', salse_price='" + selprice + "', profit='" + profit + "', quality='" + pquality + "',allocations='" + allocation + "', product_details = '" + product_details + "' where p_id='" + product_ID + "'";


            newCmd.ExecuteNonQuery();

            status = true;
            return status;
        }

       


        //Upadte for product process
        public bool product_process(string process_id, string sectionID, string in_pro_amount, string out_pro_amount, string pending_quantity, string status_process)
        {

            bool status = false;
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "update product_process set section_id='" + sectionID + "',in_pro='" + in_pro_amount + "', out_pro = '" + out_pro_amount + "' ,pending_quantity='" + pending_quantity + "', status='" + status_process + "' where process_id='" + process_id + "'";

            try
            {
                newCmd.ExecuteNonQuery();
            }
            catch { }

            status = true;
            return status;
        }
        
      

        // calculate rejected items value
        public string rejected_price(string productID)
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select sum(UnitPrice) from product_details ";// where month ='" + Date + "'";


            double value = (Int32)newCmd.ExecuteScalar();
            string sum = value.ToString();


            conn.Close();

            return sum;

        }


        //add cal details
        public bool add_cal(string TableName, string month, string productUnit_Tot, string pro_rejectUnitPrice, string product_profit)

        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "insert into Calculations(TableName,month,unit_tot_price,rejectUnitPrice, pro_profit) values ('" + TableName + "','" + month + "','" + productUnit_Tot + "','" + pro_rejectUnitPrice + "','"+ product_profit + "')";



            newCmd.ExecuteNonQuery();

            status = true;
            return status;
        }



        //order details

        public DataTable get_orders()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from order_p_details";


            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "order_p_details");
            dt = ds.Tables["order_p_details"];


            conn.Close();

            return dt;
        }

        //update order values
        public bool upd_orders(string oredrID, string status_process, string finishDate)
        {

            bool status = false;
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "update order_p_details set completed_status='" + status_process + "' ,finish_date='" + finishDate + "' where order_id='" + oredrID + "'";


            newCmd.ExecuteNonQuery();


            status = true;
            return status;
        }

        //update rejected table
        public bool upd_rejected(string productID, string reason)
        {

            bool status = false;
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "update RejectedItems set Reason ='" + reason + "'  where ProductID ='" + productID + "'";


            newCmd.ExecuteNonQuery();


            status = true;
            return status;

        }

        

/*

        //update rejected sales
        public bool updSales_rejected(string productID, string reason)
        {

            bool status = false;
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "update RejectedItems set Reason ='" + reason + "'  where p_id ='" + p_id + "'";


            newCmd.ExecuteNonQuery();


            status = true;
            return status;

        }*/
        

        //for product details calculation
        public string product_unit(string month)
        {

           
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select SUM(CAST(unit_price as int)) from product_details where month= '"+month+"'";

            

            double price = (Int32)newCmd.ExecuteScalar();
            string amount = price.ToString();
            conn.Close();

            return amount;
            

        }

        //for product details profit calculation
        public int product_profit(string month)
        {


            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            
            newCmd.CommandText = "select SUM(CAST(profit as int)) from product_details where month= '" + month + "'";


            int price1 = (Int32)newCmd.ExecuteScalar();
            //string amount1 = price1.ToString();
            conn.Close();
            return price1;
            //return amount1;


        }

        //for rejected items calculation
        public string rejected_unit(string month)
        {


            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select SUM(CAST(UnitPrice as int)) from RejectedItems where month= '" + month + "'";


            double price = (Int32)newCmd.ExecuteScalar();
            string amount = price.ToString();
            conn.Close();

            return amount;


        }
/*
        //get sales for reject
        public DataTable getsales_details()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select p_id as 'Product_ID', category as Category, size as Size, colour as Colour, unit_price as 'Unit Price', salse_price as 'Sales Price',profit as Profit, quality as Quality, allocations as Allocations, product_details as 'Product Details', Date as Date, Month as Month from product_details";


            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "product_details");
            dt = ds.Tables["product_details"];


            conn.Close();

            return dt;
        }*/


    }

}
