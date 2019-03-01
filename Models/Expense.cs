using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMS.Models
{
    class Expense
    {
        public int E_ID { get; set; }
        public int EC_ID  { get; set; }
        public decimal Amount { get; set; }
        public string Date { get; set; }
        public string  EAB { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
        public void add(string ac)
        {
            Expense_Cat ec = new Expense_Cat();
            ec.E_Name = ac;
            ec.idbyname();
            DateTime today = DateTime.Today;
            string q = "Insert Into Expense values (" + ec.EC_ID + "," + Amount + ",'" + today.ToString("dd/MM/yyyy") + "','" + Current.Username + "','" + Description + "', 1)";
            SqlCommand cmd = new SqlCommand(q,Connection.Get());
           cmd.ExecuteNonQuery();
        }
        public void getlastid()
        {
            string q = "select top 1 E_ID,Date,Amount From Expense ORDER BY  E_ID DESC";
            SqlCommand cmd = new SqlCommand(q,Connection.Get());
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                E_ID = (int)sdr[0];
                Date = (string)sdr[1];
                Amount = (decimal)sdr[2];
            }
            sdr.Close();
        }
    }
}
