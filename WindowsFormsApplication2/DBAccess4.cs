
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace WindowsFormsApplication2
{
    public class DBAccess4
    {
        SqlConnection conn;

        public DBAccess4()
        {
            conn = ConnectionManager.GetConnection();
        }


        //get customer details

        public DataTable getCustomer()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select CustomerID,NIC,Name,Address,ContactNumber,Email from dbo.WholeSailCustomer";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "WholeSailCustomer");
            dt = ds.Tables["WholeSailCustomer"];

            conn.Close();

            return dt;
        }

        //Add data to DB

        //add customer

        public bool addCustomer( string Nic, string Name, string richAddress, string ContNumber, string Email)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "insert into WholeSailCustomer(NIC,Name, Address,ContactNumber,Email) values ( '" + Nic + "','" + Name + "','" + richAddress + "','" + ContNumber + "','" + Email + "')";

            newCmd.ExecuteNonQuery();

            status = true;

            return status;

        }



        //customer update
        public bool updateCustomer( string CusID ,string Nic, string Name, string richAddress, string ContNumber, string Email)
        {
            bool status = false;
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd3 = conn.CreateCommand();

            newCmd3.Connection = conn;
            newCmd3.CommandType = CommandType.Text;
            newCmd3.CommandText = "update WholeSailCustomer set NIC = '" + Nic + "', Name = '" + Name + "', Address = '" + richAddress + "',ContactNumber = '" + ContNumber + "',Email = '" + Email + "'where CustomerID = '"+ CusID +"' ";

            newCmd3.ExecuteNonQuery();

            status = true;

            return status;

        }

//Order

        public DataTable getOrders()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select OrderID,CustomerID,ClothsType,Size,Color,Design,Quantity,OrderType,OrderDate,DueDate,ComplementStatus,FullPayment,AdvancePayement,Arrear,SubmittedDate,SubmittedSatus from dbo.orders";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "orders");
            dt = ds.Tables["orders"];

            conn.Close();

            return dt;
        }

        //add orders

        public bool addOrders(string cusIDtextBox,string typecomboBox, string sizecomboBox, string ColortextBox, string DesigntextBox, float QuantytextBox, string ortypecomboBox, string ordateTimePicker, string duedateTimePicker, string comstatecomboBox,string fullpaytextBox, string advancetextBox, string labelarrear, string substatuscomboBox, string subdatetextBox)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "insert into Orders(CustomerID,ClothsType,Size,Color,Design,Quantity,OrderType,OrderDate,DueDate,ComplementStatus,FullPayment,AdvancePayement, Arrear ,SubmittedDate,SubmittedSatus) values ( '" + cusIDtextBox + "','" + typecomboBox + "','" + sizecomboBox + "','" + ColortextBox + "','" + DesigntextBox + "','" + QuantytextBox + "','" + ortypecomboBox + "','" + ordateTimePicker + "','" + duedateTimePicker + "','" + comstatecomboBox + "','" + fullpaytextBox + "','" + advancetextBox + "','" + labelarrear + "','" + subdatetextBox + "','" + substatuscomboBox + "')";

            newCmd.ExecuteNonQuery();

            status = true;

            return status;

        }
      
        //Order update
       public bool updateOrders(string OrderID, string cusIDtextBox, string typecomboBox, string sizecomboBox, string ColortextBox, string DesigntextBox, string QuantytextBox, string ortypecomboBox, string ordateTimePicker, string duedateTimePicker, string comstatecomboBox, string fullpaytextBox, string advancetextBox, string labelarrear, string substatuscomboBox,  string subdatetextBox)
        {
            bool status = false;
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd3 = conn.CreateCommand();

            newCmd3.Connection = conn;
            newCmd3.CommandType = CommandType.Text;
            newCmd3.CommandText = "update Orders set CustomerID = '" + cusIDtextBox + "',ClothsType = '" + typecomboBox + "',Size = '" + sizecomboBox + "',Color = '" + ColortextBox + "',Design = '" + DesigntextBox + "',Quantity = '" + QuantytextBox + "', OrderType = '" + ortypecomboBox + "', OrderDate = '" + ordateTimePicker + "',DueDate = '" + duedateTimePicker + "',ComplementStatus = '" + comstatecomboBox + "',FullPayment = '" + fullpaytextBox + "',AdvancePayement = '" + advancetextBox + "',Arrear = '" + labelarrear + "',SubmittedSatus = '" + substatuscomboBox + "',SubmittedDate = '" + subdatetextBox + "' where OrderID = '" + OrderID + "' ";

            newCmd3.ExecuteNonQuery();

            status = true;

            return status;

        }
        //view best details
        public DataSet getViewBestDetails()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select OrderID,CustomerID, from dbo.Orders";
            newCmd.CommandText = "select Ratings from dbo.WholeSailCustomer";
            

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            da.Fill(ds, "Orders");
            da.Fill(ds, "WholeSailCustomer");

            conn.Close();

            return ds;
        }


        //get paymentHistory
        public DataTable getpayHistory()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select OrdID,CusID,TotalAmount,Advance,lastpayDate,Arear,MontlyRental,paymethod,paymentstatus,rating,RentalDone from dbo.PaymentHistory";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "PaymentHistory");
            dt = ds.Tables["PaymentHistory"];

            conn.Close();

            return dt;
        }
        //add paymentHistory

        public bool addPayHistory(string ortextBox, string custexbox, Double amounttextBox, string addvtextBox,string labelArear, string dateTimePicker1,  string fullpaystatuscomboBox,string paymethodtextBox, string donecomboBox,string rentallabel)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "insert into PaymentHistory(OrdID,CusID,TotalAmount,Advance,Arear,lastpayDate,paymethod,paymentstatus,RentalDone,MontlyRental) Values ('" + ortextBox + "','" + custexbox + "','" + amounttextBox + "','" + addvtextBox + "','" + labelArear + "','" + dateTimePicker1 + "','" + paymethodtextBox + "','" + fullpaystatuscomboBox + "','" + donecomboBox + "','" + rentallabel + "')";
            newCmd.ExecuteNonQuery();

            status = true;

            return status;

        }
        //update payment history 
        //not working


        public bool updatePayHistory(string ortextBox,string dateTimePicker1,string paymethodtextBox,string rentallabel,string donecomboBox,string fullpaystatuscomboBox)
        {
            bool status = false;
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd3 = conn.CreateCommand();

            newCmd3.Connection = conn;
            newCmd3.CommandType = CommandType.Text;
            newCmd3.CommandText = "update PaymentHistory set lastpayDate='" + dateTimePicker1 + "',paymethod = '" + paymethodtextBox + "',MontlyRental = '" + rentallabel + "',RentalDone = '" + donecomboBox + "',  paymentstatus = '" + fullpaystatuscomboBox + "'where OrdID= '" + ortextBox + "' ";

            newCmd3.ExecuteNonQuery();

            status = true;

            return status;

        }

        //view best Details
        public DataTable getbest()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select CusID,OrdID,rating from dbo.PaymentHistory order by rating desc";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "PaymentHistory");
            dt = ds.Tables["PaymentHistory"];

            conn.Close();

            return dt;
        }

        //add point
        public bool addpoint(string ortextBox, string newpointlabel)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "insert into PaymentHistory(rating) values ( '" + newpointlabel + "') where OrdID = '" + ortextBox + "' ";

            newCmd.ExecuteNonQuery();

            status = true;

            return status;

        }





        //Customer Remove button
        public bool deleteCustomer(string cusIDtextBox)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "delete from WholeSailCustomer where CustomerID ='" + cusIDtextBox + "'";


            newCmd.ExecuteNonQuery();

            status = true;

            conn.Close();

            return status;
        }
        //Order Remove button
        public bool deleteOrder(string Oid)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "delete from orders where OrderID ='" + Oid + "'";


            newCmd.ExecuteNonQuery();

            status = true;

            conn.Close();

            return status;
        }
        //payhistory remove
        public bool deletphistory(string Orid)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "delete from PaymentHistory where OrdID ='" + Orid + "'";


            newCmd.ExecuteNonQuery();

            status = true;

            conn.Close();

            return status;
        }




        //calling method
        //cid call
        public string selectvalues(string ortextBox)
        {


            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select CustomerID from Orders where OrderID = '" + ortextBox + "'";
            string cid = Convert.ToString(newCmd.ExecuteScalar());

            newCmd.CommandText = "select FullPayment from Orders where OrderID = '" + ortextBox + "'";
            string fpay = Convert.ToString(newCmd.ExecuteScalar());

            //newCmd.ExecuteNonQuery();



            conn.Close();

            return cid;

        }
        //fullpay call
        public string selectpay(string ortextBox)
        {


            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;


            newCmd.CommandText = "select FullPayment from Orders where OrderID = '" + ortextBox + "'";
            string fpay = Convert.ToString(newCmd.ExecuteScalar());

            //newCmd.ExecuteNonQuery();



            conn.Close();

            return fpay;

        }
        // advance cellect
        public string selectadvance(string ortextBox)
        {


            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;


            newCmd.CommandText = "select AdvancePayement from Orders where OrderID = '" + ortextBox + "'";
            string adv = Convert.ToString(newCmd.ExecuteScalar());

            //newCmd.ExecuteNonQuery();



            conn.Close();

            return adv;

        }
        //arrear call
        public string selectarrear(string ortextBox)
        {


            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;


            newCmd.CommandText = "select Arrear from Orders where OrderID = '" + ortextBox + "'";
            string arr = Convert.ToString(newCmd.ExecuteScalar());

            //newCmd.ExecuteNonQuery();



            conn.Close();

            return arr;

        }
        //monthly rental status call
        public string selectrental(string ortextBox)
        {


            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;


            newCmd.CommandText = "select RentalDone from PaymentHistory where OrdID = '" + ortextBox + "'";
            string rd = Convert.ToString(newCmd.ExecuteScalar());

            conn.Close();

            return rd;

        }
        //fullpayDone status call
        public string selectfullPDone(string ortextBox)
        {


            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;


            newCmd.CommandText = "select paymentstatus from PaymentHistory where OrdID = '" + ortextBox + "'";
            string fd = Convert.ToString(newCmd.ExecuteScalar());

            conn.Close();

            return fd;

        }
        //current raite call
        public string selectrate(string ortextBox)
        {


            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;


            newCmd.CommandText = "select rating from PaymentHistory where OrdID = '" + ortextBox + "'";
            string rp = Convert.ToString(newCmd.ExecuteScalar());

            conn.Close();

            return rp;

        }

        //add(Update) point to payHistory 
        public bool updatepoint(string newpointlabel, string ortextBox)
        {
            bool status = false;
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd3 = conn.CreateCommand();

            newCmd3.Connection = conn;
            newCmd3.CommandType = CommandType.Text;
            newCmd3.CommandText = "update PaymentHistory set rating = '" + newpointlabel + "' where OrdID = '" + ortextBox + "' ";

            newCmd3.ExecuteNonQuery();

            status = true;

            return status;

        }





    }



}
