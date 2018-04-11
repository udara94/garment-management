using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace WindowsFormsApplication2
{
    public class DBAccess1
    {
        SqlConnection conn;

        public DBAccess1()
        {
            conn = ConnectionManager.GetConnection();
        }

       

        public DataTable selectItems()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select RawStockId ,SupplierId,Picture,MaterialType,UnitMeasurement,Quantity,UnitPrice,QuantityPrice,Allocations,AvailableQuantity,Remarks,ReOrderLevel,ReorderQuantity from dbo.RawMaterials";
            
            

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "RawMaterials");
            dt = ds.Tables["RawMaterials"];

            conn.Close();

            return dt;
        }

        public int getMax()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select max(RawStockId) from dbo.RawMaterials";



           // SqlCeCommand comSelect = new SqlCeCommand(query, connection);
            int ID = (int)newCmd.ExecuteScalar();

            conn.Close();

            return ID;
        }

        public DataTable Suppliers()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select SupplierId from dbo.Suppliers ORDER BY SupplierId ASC";



            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "Suppliers");
            dt = ds.Tables["Suppliers"];

            conn.Close();

            return dt;
        }

        public bool AddRawDetails(string supid,string mat,string um,double qu,double up,double qp,string allo,double aq,double rol,string rem,byte[] image,double requan)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "insert into  dbo.RawMaterials(SupplierId,Picture,MaterialType,UnitMeasurement,Quantity,UnitPrice,QuantityPrice,Allocations,AvailableQuantity,ReOrderLevel,Remarks,ReorderQuantity) values ('"+supid+"',@photo,'"+mat+"','"+um+"','"+qu+"','"+up+"','"+qp+"','"+allo+"','"+aq+"','"+rol+"','"+rem+"','"+requan+"')";
            //newCmd.Parameters.Add(new SqlParameter("@photo", image));
            // newCmd.Parameters.Add("@photo", SqlDbType.Image);
            // newCmd.Parameters.AddWithValue("@Department").Value = image;

              newCmd.Parameters.Add("@photo", SqlDbType.Image);

              if(image == null)
              {
                  newCmd.Parameters["@photo"].Value = DBNull.Value;
              }
              else
              {
                  newCmd.Parameters["@photo"].Value = image;
              } 

           // newCmd.Parameters.Add("@parameter", SqlDBType, size).value = TextBox1.Text


            newCmd.ExecuteNonQuery();

            status = true;

            return status;

        }

        public bool drawfromrow(int rawid)
        {
            bool status = false;
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd3 = conn.CreateCommand();

            newCmd3.Connection = conn;
            newCmd3.CommandType = CommandType.Text;
            newCmd3.CommandText = "delete from dbo.RawMaterials where RawStockId = '"+rawid+"'";

            newCmd3.ExecuteNonQuery();

            status = true;

            return status;

        }

        public DataTable Stocks()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select RawStockId from dbo.RawMaterials ORDER BY RawStockId ASC";



            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "RawMaterials");
            dt = ds.Tables["RawMaterials"];

            conn.Close();

            return dt;
        }

        public bool UpdateRawDetails( int rawId,string mat, string um, double qu, double up, double qp, string allo, double aq, double rol, string rem, byte[] image,double roq)
        {
            
            bool status = false;
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            

                SqlCommand newCmd3 = conn.CreateCommand();

            newCmd3.Connection = conn;
            newCmd3.CommandType = CommandType.Text;
            newCmd3.CommandText = "update  dbo.RawMaterials set Picture=@photo,MaterialType='"+mat+"',UnitMeasurement='"+um+"',Quantity='"+qu+"',UnitPrice='"+up+"',QuantityPrice='"+qp+"',Allocations='"+allo+"',AvailableQuantity='"+aq+"',Remarks='"+rem+"',ReOrderLevel='"+rol+"',ReorderQuantity='"+roq+"' where RawStockId = '" + rawId + "'";
            //newCmd3.Parameters.Add(new SqlParameter("@photo", image));

            newCmd3.Parameters.Add("@photo", SqlDbType.Image);

            if (image == null)
            {
                newCmd3.Parameters["@photo"].Value = DBNull.Value;
            }
            else
            {
                newCmd3.Parameters["@photo"].Value = image;
            }

            newCmd3.ExecuteNonQuery();

            status = true;

            return status;

        }

        public DataTable GetProductStocksDetails()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from dbo.ProductStocks";



            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "ProductStocks");
            dt = ds.Tables["ProductStocks"];

            conn.Close();

            return dt;
        }

        public DataTable GetProIds()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select p_id from dbo.product_details";



            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "product_details");
            dt = ds.Tables["product_details"];

            conn.Close();

            return dt;
        }

        public DataTable GetOrdIds()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select OrderID from dbo.Orders";



            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "Orders");
            dt = ds.Tables["Orders"];

            conn.Close();

            return dt;
        }

        public bool AddProStock1(string pid, string cat, string qua, string size, int quan)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "insert into  dbo.ProductStocks(ProductID,Category,Quality,Size,Quantity) values('"+pid+ "','" + cat + "','" + qua + "','" + size + "','" + quan + "')";
            
            newCmd.ExecuteNonQuery();

            status = true;

            return status;

        }

        public bool AddProStock2(string pid, string cat, string qua, string size, int quan, string mar, int aa, string ordId, int avquan)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "insert into  dbo.ProductStocks(ProductID,Category,Quality,Size,Quantity,AllocationMarket,AllocatedAmount,AllocatedOrderID,AvilableQuantity) values('" + pid + "','" + cat + "','" + qua + "','" + size + "','" + quan + "','" + mar + "','" + aa + "','" + ordId + "','" + avquan + "')";

            newCmd.ExecuteNonQuery();

            status = true;

            return status;

        }

        public bool drawfromPro(string ProductID)
        {
            bool status = false;
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd3 = conn.CreateCommand();

            newCmd3.Connection = conn;
            newCmd3.CommandType = CommandType.Text;
            newCmd3.CommandText = "delete from dbo.ProductStocks where ProductID = '" + ProductID + "'";

            newCmd3.ExecuteNonQuery();

            status = true;

            return status;

        }


        public bool UpdateProDetails1(string pid, string cat, string qua, string size, int quan)
        {
            bool status = false;
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd3 = conn.CreateCommand();

            newCmd3.Connection = conn;
            newCmd3.CommandType = CommandType.Text;
            newCmd3.CommandText = "update dbo.ProductStocks set Category='"+pid+"',Quality='"+qua+"',Size='"+size+"',Quantity='"+quan+"' where ProductID='"+pid+"'";
            newCmd3.ExecuteNonQuery();

            status = true;

            return status;

        }
        public bool UpdateProDetail2(string pid, string cat, string qua, string size, int quan, string mar, int aa, string ordId, int avquan)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "update dbo.ProductStocks set Category='"+cat+"',Quality='"+qua+"',Size='"+size+"',Quantity='"+quan+"',AllocationMarket='"+mar+"',AllocatedAmount='"+aa+"',AllocatedOrderID='"+ordId+"',AvilableQuantity='"+avquan+"' where ProductID='"+pid+"'";

            newCmd.ExecuteNonQuery();

            status = true;

            return status;

        }

        public DataTable rawDamage()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from dbo.RawStockDamagedHistory";



            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "RawStockDamagedHistory");
            dt = ds.Tables["RawStockDamagedHistory"];

            conn.Close();

            return dt;
        }

        public double getCost(int id)
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select UnitPrice from dbo.RawMaterials where RawStockId='"+id+"'";



            // SqlCeCommand comSelect = new SqlCeCommand(query, connection);
            decimal rid = ((decimal)newCmd.ExecuteScalar());
            double ID = Convert.ToDouble(rid);

            conn.Close();

            return ID;
        }

        public string getMeasure(int id)
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select UnitMeasurement from dbo.RawMaterials where RawStockId='" + id + "'";



            // SqlCeCommand comSelect = new SqlCeCommand(query, connection);
            string mes = (String)newCmd.ExecuteScalar();
           // double ID = Convert.ToDouble(rid);

            conn.Close();

            return mes;
        }

        public bool AddDamRaw(string dat, int id, string added, string mes, double quan, double cos, double recCos, double net)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "insert into  dbo.RawStockDamagedHistory(DateDamaged,RawStockID,DetailsAddedDate,StockMeasurement,Quantity,DamageCost,RecoveredCost,NetDamagedCost) values('" + dat + "','" + id + "','" + added + "','" + mes + "','" + quan + "','" + cos + "','" + recCos + "','" + net + "')";

            newCmd.ExecuteNonQuery();

            status = true;

            return status;

        }

        public DataTable proDamage()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from dbo.ProductStocksDamagedHistory";



            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "ProductStocksDamagedHistory");
            dt = ds.Tables["ProductStocksDamagedHistory"];

            conn.Close();

            return dt;
        }

        public string getCat(string id)
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select Category from dbo.ProductStocks where ProductID='" + id + "'";



            // SqlCeCommand comSelect = new SqlCeCommand(query, connection);
            string pro = (string)newCmd.ExecuteScalar();
            //double ID = Convert.ToDouble(rid);

            conn.Close();

            return pro;
        }

        public DataTable GetProIdsFrmStk()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select ProductID from dbo.ProductStocks";



            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "ProductStocks");
            dt = ds.Tables["ProductStocks"];

            conn.Close();

            return dt;
        }

        public string getSize(string id)
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select Size from dbo.ProductStocks where ProductID='" + id + "'";



            // SqlCeCommand comSelect = new SqlCeCommand(query, connection);
            string pro = (string)newCmd.ExecuteScalar();
            //double ID = Convert.ToDouble(rid);

            conn.Close();

            return pro;
        }

        public string getProCost(string id)
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select unit_price from dbo.product_details where p_id='" + id + "'";



            // SqlCeCommand comSelect = new SqlCeCommand(query, connection);
            string pro = (string)newCmd.ExecuteScalar();
            //double ID = Convert.ToDouble(rid);

            conn.Close();

            return pro;
        }

        public bool AddDamPro(string dat, string added, string pid, string cat, string size, int quan,double cost,double rec, double net)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "insert into  dbo.ProductStocksDamagedHistory(DamagedDate,DetailsAddedDate,ProductID,Category,Size,DamagedQuantity,DamageCost,RecoveredCost,NetDamagedCost) values('" + dat + "','" + added + "','" + pid + "','" + cat + "','" + size + "','" + quan + "','" + cost + "','" + rec + "','" + net + "')";

            newCmd.ExecuteNonQuery();

            status = true;

            return status;

        }

        public DataTable rol()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select RawStockId ,SupplierId,AvailableQuantity,ReOrderLevel,ReorderQuantity from dbo.RawMaterials";



            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "RawMaterials");
            dt = ds.Tables["RawMaterials"];

            conn.Close();

            return dt;
        }

        public bool UpdateRol(int rawId, double rol, double roq)
        {

            bool status = false;
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }


            SqlCommand newCmd3 = conn.CreateCommand();

            newCmd3.Connection = conn;
            newCmd3.CommandType = CommandType.Text;
            newCmd3.CommandText = "update  dbo.RawMaterials set ReOrderLevel='" + rol + "',ReorderQuantity='"+roq+"' where RawStockId = '" + rawId + "'";
            newCmd3.ExecuteNonQuery();

            status = true;

            return status;

        }

        public DataTable getSuppliers()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from dbo.Suppliers";



            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "Suppliers");
            dt = ds.Tables["Suppliers"];

            conn.Close();

            return dt;
        }

        public int getMaxSup()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select max(SupplierId) from dbo.Suppliers";



            // SqlCeCommand comSelect = new SqlCeCommand(query, connection);
            int ID = (int)newCmd.ExecuteScalar();

            conn.Close();

            return ID;
        }

        public bool AddSups1(string nic, string name, string adderss, int contact, string email)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "insert into  dbo.Suppliers(NIC,Name,Address,ContactNo,Email) values('" + nic + "','" + name + "','" + adderss + "','" + contact + "','" + email + "')";

            newCmd.ExecuteNonQuery();

            status = true;

            return status;

        }

        public bool AddSups2(string nic, string name, string adderss, int contact)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "insert into  dbo.Suppliers(NIC,Name,Address,ContactNo) values('" + nic + "','" + name + "','" + adderss + "','" + contact + "')";

            newCmd.ExecuteNonQuery();

            status = true;

            return status;

        }


        public bool drawfromsup(int empid)
        {
            bool status = false;
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }
            SqlCommand newCmd3 = conn.CreateCommand();

            newCmd3.Connection = conn;
            newCmd3.CommandType = CommandType.Text;
            newCmd3.CommandText = "delete from dbo.Suppliers where SupplierId = '" + empid + "'";

            newCmd3.ExecuteNonQuery();

            status = true;

            return status;

        }

        public bool UpdateSupDetails1(int id,string nic, string name, string adderss, int contact,string email)
        {

            bool status = false;
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }


            SqlCommand newCmd3 = conn.CreateCommand();

            newCmd3.Connection = conn;
            newCmd3.CommandType = CommandType.Text;
            newCmd3.CommandText = "update  dbo.Suppliers set NIC='" + nic + "',Name='" + name + "',Address='" + adderss + "',ContactNo='" + contact + "',Email='" + email + "' where SupplierId = '" + id + "'";

            newCmd3.ExecuteNonQuery();

            status = true;

            return status;

        }

        public bool UpdateSupDetails2(int id, string nic, string name, string adderss, int contact)
        {

            bool status = false;
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }


            SqlCommand newCmd3 = conn.CreateCommand();

            newCmd3.Connection = conn;
            newCmd3.CommandType = CommandType.Text;
            newCmd3.CommandText = "update  dbo.Suppliers set NIC='" + nic + "',Name='" + name + "',Address='" + adderss + "',ContactNo='" + contact + "' where SupplierId = '" + id + "'";

            newCmd3.ExecuteNonQuery();

            status = true;

            return status;

        }

        public DataTable getSupPayment()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select * from dbo.SuppleirPaymentHistory";



            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "SuppleirPaymentHistory");
            dt = ds.Tables["SuppleirPaymentHistory"];

            conn.Close();

            return dt;
        }

        public bool AddSupPay(int id, string date, double payment)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "insert into  dbo.SuppleirPaymentHistory(SupplierId,RegisteredDate,Payment) values('" + id + "','" + date + "','" + payment + "')";

            newCmd.ExecuteNonQuery();

            status = true;

            return status;

        }


    }



}
