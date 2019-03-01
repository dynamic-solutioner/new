using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMS.Models
{
    class Bank_Transition
    {
        public int BT_ID { get; set; }
        public bool Expense { get; set; }
        public int E_ID { get; set; }
        public bool Invoice { get; set; }
        public int I_ID { get; set; }
        public string Transition_Date { get; set; }
        public int B_ID { get; set; }
        public decimal Balance { get; set; }
        public int AP_ID { get; set; }
        public bool AR { get; set; }
        public int AR_ID { get; set; }
        public decimal BPB { get; set; }

        public void addexpense(string k)
        {
            Expense e = new Models.Expense();
            e.getlastid();
            Bank b = new Bank();
            b.Name = k;
            b.checkbyname();
            string q = "Insert Into Bank_Transitions (Expense,E_ID,Invoice,Transition_Date,B_ID,Balance,AP,AR,BPB) values (1," + e.E_ID + ",0,'" + e.Date + "'," + b.B_ID + "," + (b.Balance - e.Amount) + ",0,0," + b.Balance + ")";
            SqlCommand cmd = new SqlCommand(q,Connection.Get());
            cmd.ExecuteNonQuery();
            b.Balance -= e.Amount;
            b.update();
        }
        public int lasttrans()
        {
            string q = "Select TOP 1 B_ID from Bank_Transitions ORDER BY B_ID DESC";
            SqlCommand cmd = new SqlCommand(q,Connection.Get());
            SqlDataReader sdr = cmd.ExecuteReader();
            int k = 0;
            while (sdr.Read())
            {
                k = (int)sdr[0];
           
            }
            sdr.Close();
            return (k);
        }

    }
}
