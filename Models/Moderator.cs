using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMS.Models
{
    class Moderator
    {
        public int M_ID { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public void Add()
        {
            string q = "Insert Into [Moderator] Values ('" + Name + "','" + Username + "','" + Password + "')";
            SqlCommand cmd = new SqlCommand(q, Connection.Get());
            cmd.ExecuteNonQuery();
        }
        public void update()
        {
            string q = "Update [Moderator] Set Name = '" + Name + "', Username = '" + Username + "',Password = '" + Password + "' Where M_ID = " + M_ID;
            SqlCommand cmd = new SqlCommand(q, Connection.Get());
            cmd.ExecuteNonQuery();
        }
        public List<Models.Moderator> show()
        {
            string q = "Select * from [Moderator]";
            SqlCommand cmd = new SqlCommand(q, Connection.Get());
            List<Models.Moderator> lis = new List<Models.Moderator>();
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                Models.Moderator ad = new Models.Moderator();
                ad.M_ID = (int)sdr[0];
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
            string q = "Delete [Moderator] Where M_ID = " + M_ID;
            SqlCommand cmd = new SqlCommand(q, Connection.Get());
            cmd.ExecuteNonQuery();
        }
        public bool login()
        {

            string q = "Select * from [Moderator]";
            SqlCommand cmd = new SqlCommand(q, Connection.Get());
            List<Models.Moderator> lis = new List<Models.Moderator>();
            SqlDataReader sdr = cmd.ExecuteReader();
            bool u = false;
            bool p = false;
            while (sdr.Read())
            {
                if (Username == (string)sdr[2] )
                {
                    u = true;
                    if (Password == (string)sdr[3])
                    {

                        p = true;
                        Name = (string)sdr[1];
                        M_ID = (int)sdr[0];
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
