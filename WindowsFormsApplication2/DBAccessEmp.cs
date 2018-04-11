using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace WindowsFormsApplication2
{
    public class DBAccessEmp
    {
        SqlConnection conn;

        public DBAccessEmp()
        {
            conn = ConnectionManager.GetConnection();
        }

        //select all data from employee table
        public DataTable getAllJobs()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select empid as EmpId,name as Name,address as Address,phone as Phone,age as Age,nic as NIC,birthday as Birthday,possition as Possition,Basic_salary as Basic_Salary,experience as Experience,join_date as Join_Date,image as Image from employee";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "employee");
            dt = ds.Tables["employee"];

            conn.Close();

            return dt;
        }

        //select all data from attendence table
        public DataTable getallattendence()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select empid as EmpID,day as Date,time as Time,type as Type, duration as Duration from attendence";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "attendence");
            dt = ds.Tables["attendence"];

            conn.Close();

            return dt;
        }


        //new employee add to table
        public bool addemp(string name, string age, string conno, string nic, string birth_date, string addre, string pos, string exp, string join_date, string basic, byte[] p_name)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "insert into dbo.employee(name,age,phone,nic,birthday,address,possition,experience,join_date,Basic_salary,image) values ('" + name + "','" + age + "','" + conno + "','" + nic + "','" + birth_date + "','" + addre + "','" + pos + "','" + exp + "','" + join_date + "','"+basic+"',@photo)";
            newCmd.Parameters.Add(new SqlParameter("@photo", p_name));


            newCmd.ExecuteNonQuery();


            status = true;

            conn.Close();

            return status;

        }

        public bool addatten(string empid, string date)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "insert into recorde_attendence(empid,date) values ('" + empid + "','" + date + "')";

            try
            {
                newCmd.ExecuteNonQuery();
            }
            catch { }
            status = true;

            conn.Close();

            return status;

        }

        /*  public bool selectempid(string empid, string date)
          {

              attendence atten = new attendence();
              bool status = false;

              if (conn.State.ToString() == "Closed")
              {
                  conn.Open();
              }

              SqlCommand newCmd = conn.CreateCommand();

              newCmd.Connection = conn;
              newCmd.CommandType = CommandType.Text;
              newCmd.CommandText = "select empid from recorde_attendence where textbox1.text=empid;

              try
              {
                  newCmd.ExecuteNonQuery();
              }
              catch { }
              status = true;

              return status;

          }*/


        public bool addattendence(string empid, string day, string month, string year,string type, string time, string duration)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "insert into attendence(empid,day,month,year,type,time,duration) values ('" + empid + "','" + day + "','" + month + "','" + year + "','" + type + "','" + time + "','"+ duration + "')";

            
                newCmd.ExecuteNonQuery();
            
            status = true;

            conn.Close();

            return status;

        }


        //Delete emp Details

        public bool deleteemp(string Id)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "delete from employee where empid ='" + Id + "'";


            newCmd.ExecuteNonQuery();

            status = true;

            conn.Close();

            return status;
        }


        //Update employee Details

        public bool updateemployee(string empid, string name, string age, string conno, string nic, string birth_date, string addre, string pos, string exp, string join_date,string basic, byte[] p_name)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "update employee set name = '" + name + "',age='" + age + "',phone='" + conno + "',nic = '" + nic + "',birthday = '" + birth_date + "',address = '" + addre + "', possition = '" + pos + "',experience = '" + exp + "',join_date = '" + join_date + "',Basic_salary ='"+basic+ "',image = @photo  where empid='" + empid + "'";
           
            newCmd.Parameters.Add(new SqlParameter("@photo", p_name));

            newCmd.ExecuteNonQuery();

            status = true;

            conn.Close();

            return status;

        }
        




          public string selectmaxrow(string id)
          {
              

              if (conn.State.ToString() == "Closed")
              {
                  conn.Open();
              }

              SqlCommand newCmd = conn.CreateCommand();

              newCmd.Connection = conn;
              newCmd.CommandType = CommandType.Text;
              newCmd.CommandText = "select MAX(counting) from attendence where empid= '" + id + "'";

            double val = (Int32)newCmd.ExecuteScalar();
            string max = val.ToString();
            // newCmd.ExecuteNonQuery();



            conn.Close();

              return max;

          }
        public string typedefine(string coun)
        {

            // 1-use for in 0-use for out
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select type from attendence where counting= '" + coun + "'";

            string val = (string)newCmd.ExecuteScalar();
            //string state = val.ToString();
            // newCmd.ExecuteNonQuery();



            conn.Close();

            return val;

        }

        public string selectemp(string empid)
        {

            string result;
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select empid from attendence where empid= '" + empid + "'";

            var firstColumn = newCmd.ExecuteScalar();

            if (firstColumn != null)
            {
               result = firstColumn.ToString();
            }
            else
            {
                result = "null";
            }
            //double val = (Int32)newCmd.ExecuteScalar();
            //string max = val.ToString();
            // newCmd.ExecuteNonQuery();



            conn.Close();

            return result;

        }



        //select all data from leaving table
        public DataTable leave()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select no as ID,empid as EmpId,reason as Reason,l_photo as Photo from leaving";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "leaving");
            dt = ds.Tables["leaving"];

            conn.Close();

            return dt;
        }

        // add leave request to table
        public bool addleave(string empid, string reason, string start, string enddate, byte[] photo2)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "insert into dbo.leaving(empid,reason,start,enddate,l_photo) values ('" + empid + "','" + reason + "','"+start+"','"+enddate+"',@photo2)";
            newCmd.Parameters.Add(new SqlParameter("@photo2", photo2));


            newCmd.ExecuteNonQuery();


            status = true;

            conn.Close();

            return status;

        }

        //Delete leaveing Details

        public bool deleteleave(string no)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "delete from leaving where no='" + no + "'";



            newCmd.ExecuteNonQuery();

            status = true;

            conn.Close();

            return status;
        }
        // select empid
        /* public DataTable getattendence2()
         {
             attendence att = new attendence();
             if (conn.State.ToString() == "Closed")
             {
                 conn.Open();
             }

             SqlCommand newCmd = conn.CreateCommand();
             newCmd.Connection = conn;
             newCmd.CommandType = CommandType.Text;
             string no2 = att.textBox1.Text;
             newCmd.CommandText = "select max(atten_id) from attendence2 where empid ='" + no2 + "'";


             SqlDataAdapter da = new SqlDataAdapter(newCmd);
             DataSet ds = new DataSet();
             DataTable dt = new DataTable();
             da.Fill(ds, "attendence");
             dt = ds.Tables["attendence"];

             conn.Close();

             return dt;
         }*/

        // attendence atn = new attendence();

        /* public DataTable gettype()
         {

             attendence att = new attendence();
             if (conn.State.ToString() == "Closed")
             {
                 conn.Open();
             }

             SqlCommand newCmd = conn.CreateCommand();
             newCmd.Connection = conn;
             newCmd.CommandType = CommandType.Text;
             string no2 = att.textBox1.Text;
             newCmd.CommandText = "select type from attendence2 where empid ='" + atn.max + "'";


             SqlDataAdapter da = new SqlDataAdapter(newCmd);
             DataSet ds = new DataSet();
             DataTable dt = new DataTable();
             da.Fill(ds, "attendence");
             dt = ds.Tables["attendence"];

             conn.Close();

             return dt;
         }*/



        /*public bool selectmaxatten(string no2)
        {
            attendence att = new attendence();
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            no2 = att.textBox1.Text;
            newCmd.CommandText = "select max(atten_id) from attendence2 where empid ='" + no2 + "'";



            newCmd.ExecuteNonQuery();

            status = true;

            conn.Close();

            return status;


        }*/

        public DataTable getid_name()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select empid,name,Basic_salary from employee";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "employee");
            dt = ds.Tables["employee"];

            conn.Close();

            return dt;
        }

       /* public bool select_hour(string id)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select hours from attendence where = '" + id + "'";


            newCmd.ExecuteNonQuery();*/
            /*caclulate_salary sal = new caclulate_salary();
            sal.textBox3 = newCmd;*/

           /* status = true;

            conn.Close();

            return status;

        }*/
        //insert salary details

        public bool addsalary(string empid, string basic, string hour, string rate,string allowence, string salary, string date)
        {
            bool status = false;

            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "insert into empsalary2(empid,basic_salary,working_hours,Hour_rate,allowence,Net_salary,date) values ('" + empid+"','" + basic + "','" + hour + "','"+ rate + "','"+ allowence +"','"+ salary+"', '"+date+ "')";

            
                newCmd.ExecuteNonQuery();
           
            status = true;

            conn.Close();

            return status;

        }
        //select all data from salary table
        public DataTable getAllsalary()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select empid as EmpId,working_hours as Working_Days,date as Date,basic_salary as Basic,Hour_rate as Day_rate,allowence as Allowence,Net_salary as Net_Salary from empsalary2";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "empsalary2");
            dt = ds.Tables["empsalary2"];

            conn.Close();

            return dt;
        }

        //counting working days 
       /* public string work_days(string id,string date)
        {


            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select count(counting) from attendence where empid= '" + id + "' AND month = '"+ date +"' AND type ='1'";

            double val = (Int32)newCmd.ExecuteScalar();
            string count = val.ToString();
            // newCmd.ExecuteNonQuery();



            conn.Close();

            return count;

        }*/
        //select empid and name for addleaving letter from employee table
        public DataTable selectidname()
        {
            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();
            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select empid,name from employee";

            SqlDataAdapter da = new SqlDataAdapter(newCmd);
            DataSet ds = new DataSet();
            DataTable dt = new DataTable();
            da.Fill(ds, "employee");
            dt = ds.Tables["employee"];

            conn.Close();

            return dt;
        }
        /* public bool addsalary(string empid, string basic, string hour, string rate, string allowence, string salary, string date)
         {
             bool status = false;

             if (conn.State.ToString() == "Closed")
             {
                 conn.Open();
             }

             SqlCommand newCmd = conn.CreateCommand();

             newCmd.Connection = conn;
             newCmd.CommandType = CommandType.Text;
             newCmd.CommandText = "insert into dbo.Table_1(basic_salary) values ('" + basic + "')";
            // newCmd.Parameters.Add(new SqlParameter("@photo", p_name));


             newCmd.ExecuteNonQuery();


             status = true;

             conn.Close();

             return status;

         }*/
         //select last attendence 
        public string get_last_atten(string id)
        {


            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select MAX(counting) from attendence where empid= '" + id + "' AND type ='1'";

            double val = (Int32)newCmd.ExecuteScalar();
            string max = val.ToString();
            // newCmd.ExecuteNonQuery();



            conn.Close();

            return max;

        }
        //select last attendence 
        public string get_last_time(string count)
        {


            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select time from attendence where counting= '" + count + "'";

            var firstColumn = newCmd.ExecuteScalar();
            string result;
            if (firstColumn != null)
            {
                result = firstColumn.ToString();
            }
            else
            {
                result = "null";
            }
            //double val = (Int32)newCmd.ExecuteScalar();
            //string max = val.ToString();
            // newCmd.ExecuteNonQuery();



            conn.Close();

            return result;

        }
        //count working houres
        public string calwork_houres(string id, string date)
        {


            if (conn.State.ToString() == "Closed")
            {
                conn.Open();
            }

            SqlCommand newCmd = conn.CreateCommand();

            newCmd.Connection = conn;
            newCmd.CommandType = CommandType.Text;
            newCmd.CommandText = "select SUM(CAST(duration as int)) from attendence where empid= '" + id + "' AND month = '" + date + "' AND type ='0'";

            double val = (Int32)newCmd.ExecuteScalar();
            string count = val.ToString();
            // newCmd.ExecuteNonQuery();



            conn.Close();

            return count;

        }
    }
}
