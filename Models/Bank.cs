using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMS.Models
{
    class Bank
    {
        public int B_ID { get; set; }
        public string Name { get; set; }
        public decimal Balance { get; set; }
        public void add()
        {
            string q = "Insert into Bank values ('" + Name + "'," + Balance + ")";
            SqlCommand cmd = new SqlCommand(q, Connection.Get());
            cmd.ExecuteNonQuery();
        }
        public void checkbyname()
        {
            string q = "Select * from Bank Where Name =  '" + Name + "'";
            SqlCommand cmd = new SqlCommand(q, Connection.Get());
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                B_ID = (int)sdr[0];
                Name = (string)sdr[1];
                Balance = (decimal)sdr[2];
            }
            sdr.Close();
        }
        public List<Bank> all()
        {
            string q = "Select * from Bank";
            SqlCommand cmd = new SqlCommand(q, Connection.Get());
            SqlDataReader sdr = cmd.ExecuteReader();
            List<Bank> abc = new List<Bank>();
            while (sdr.Read())
            {
                Bank bk = new Bank();
                bk.B_ID = (int)sdr[0];
                bk.Name = (string)sdr[1];
                bk.Balance = (decimal)sdr[2];
                abc.Add(bk);
            }
            sdr.Close();
            return abc;

        }
        public void update()
        {
            string q = "Update Bank Set Balance =" + Balance + "Where B_ID = " + B_ID ;
            SqlCommand cmd = new SqlCommand(q, Connection.Get());
            cmd.ExecuteNonQuery();
        }
    }
}
