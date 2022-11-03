using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BusinessLayer;

namespace DataAccessLayer
{
    public class schooldetails
    {
        public List<classes> GetProducts()
        {
            // SqlConnection c = new SqlConnection("Data Source=LAPTOP-IJMFGUQ1\\SQLEXPRESS;Initial Catalog=School;Integrated Security=True");//
            SqlConnection c = new SqlConnection("Server=tcp:narenskserver.database.windows.net,1433;Initial Catalog=MySchool;Persist Security Info=False;User ID=NAREN;Password=Sk9677384564;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            SqlCommand cmd = new SqlCommand("select *from classes", c);
            c.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<classes> plist = new List<classes>();

            while (dr.Read())
            {
                plist.Add(new classes { class_roomno = Convert.ToInt32(dr[0]), class_strength = Convert.ToInt32(dr[1]) });

            }
            c.Close();
            c.Dispose();
            return plist;

        }
        public List<subjects> GetProducts1()
        {
          //  SqlConnection c = new SqlConnection("Data Source=LAPTOP-IJMFGUQ1\\SQLEXPRESS;Initial Catalog=School;Integrated Security=True");//
            SqlConnection c = new SqlConnection("Server=tcp:narenskserver.database.windows.net,1433;Initial Catalog=MySchool;Persist Security Info=False;User ID=NAREN;Password=Sk9677384564;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

            SqlCommand cmd = new SqlCommand("select *from subjects", c);
            c.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<subjects> plist = new List<subjects>();

            while (dr.Read())
            {
                plist.Add(new subjects { subject_id = Convert.ToInt32(dr[0]), subject_name = dr[1].ToString() });

            }
            c.Close();
            c.Dispose();
            return plist;

        }
        public List<students> GetProducts2()
        {
            //SqlConnection c = new SqlConnection("Data Source=LAPTOP-IJMFGUQ1\\SQLEXPRESS;Initial Catalog=School;Integrated Security=True");
            SqlConnection c = new SqlConnection("Server=tcp:narenskserver.database.windows.net,1433;Initial Catalog=MySchool;Persist Security Info=False;User ID=NAREN;Password=Sk9677384564;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

            SqlCommand cmd = new SqlCommand("select *from students ", c);
            c.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            List<students> plist = new List<students>();

            while (dr.Read())
            {
                plist.Add(new students { student_id = Convert.ToInt32(dr[0]), student_name = dr[1].ToString(), student_class = Convert.ToInt32(dr[2]) });

            }
            c.Close();
            c.Dispose();
            return plist;

        }

    }
}
