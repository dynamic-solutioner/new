using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMS.Models
{
    class Admin
    {
        public int Admin_ID { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public void Add()
        {
            string q = "Insert Into [Admin] Values ('" + Name + "','" + Username + "','" + Password + "')";
            SqlCommand cmd = new SqlCommand(q,Connection.Get());
            cmd.ExecuteNonQuery();
        }
        public void update()
        {
            string q = "Update [Admin] Set Name = '" + Name + "', Username = '" + Username + "',Password = '" + Password + "' Where Admin_ID = " + Admin_ID;
            SqlCommand cmd = new SqlCommand(q, Connection.Get());
            cmd.ExecuteNonQuery();
        }
        public List<Admin> show()
        {
            string q = "Select * from [Admin]";
            SqlCommand cmd = new SqlCommand(q,Connection.Get());
            List<Admin> lis = new List<Admin>();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                Admin ad = new Admin();
                ad.Admin_ID = (int)sdr[0];
                ad.Name = (string)sdr[1];
                ad.Username = (string)sdr[2];
                ad.Password = (string)sdr[3];
                lis.Add(ad);
            }
            sdr.Close();
            return lis;
        }
        public void delete()
        {
            string q = "Delete [Admin] Where Admin_ID = " + Admin_ID;
            SqlCommand cmd = new SqlCommand(q,Connection.Get());
            cmd.ExecuteNonQuery();
        }
        public bool login()
        {
            string q = "Select * from [Admin]";
            SqlCommand cmd = new SqlCommand(q, Connection.Get());
            SqlDataReader sdr = cmd.ExecuteReader();
            bool u = false;
            bool p = false;
            while (sdr.Read())
            {
                if (Username == (string)sdr[2])
                {
                    u = true;
                    if (Password == (string)sdr[3])
                    {
                        p = true;
                        Name = (string)sdr[1];
                        Admin_ID = (int)sdr[0];
                        break;
                    }
                }
            }
            if (u && p)
            {
                Current.Name = (string)sdr[1];
                Current.Username = (string)sdr[2];
                Current.Password = (string)sdr[3];
                Current.ID = (int)sdr[0];
                Current.checker = true;

                sdr.Close();
                return true;
            }
            if (u == false)
            {
                MessageBox.Show("Invalid Password");

                sdr.Close();
                return false;
            }
            else
            {
                MessageBox.Show("Not Password");

                sdr.Close();
                return false;
            }
        }
    }
}
