using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace KMS.Models
{
    class Expense_Cat
    {
        public int EC_ID { get; set; }
        public string E_Name { get; set; }
        public void add()
        {
            string q = "Insert Into Expense_Cat values ('" + E_Name + "')";
            SqlCommand cmd = new SqlCommand(q, Connection.Get());
            cmd.ExecuteNonQuery();
        }
        public List<Expense_Cat> all()
        {
            string q = "Select * from Expense_Cat";
            SqlCommand cmd = new SqlCommand(q,Connection.Get());
            SqlDataReader sdr = cmd.ExecuteReader();
            List<Expense_Cat> exl = new List<Expense_Cat>();
            while (sdr.Read())
            {
                Expense_Cat e = new Expense_Cat();
                e.EC_ID = (int)sdr[0];
                e.E_Name = (string)sdr[1];
                exl.Add(e);
            }
            sdr.Close();
            return exl;
        }
        public void idbyname()
        {
            string q = "Select EC_ID from Expense_Cat Where E_Name = '" + E_Name + "'"; 
            SqlCommand cmd = new SqlCommand(q,Connection.Get());
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                EC_ID = (int)sdr[0];
            }
            sdr.Close();
        }
    }
}
