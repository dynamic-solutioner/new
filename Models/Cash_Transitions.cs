using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMS.Models
{
    class Cash_Transitions
    {
        public int Transition_ID { get; set; }
        public bool Expense { get; set; }
        public int E_ID { get; set; }

        public bool invoice { get; set; }
        public int I_ID { get; set; }
        public string Transition_Date { get; set; }
        public decimal CB { get; set; }
        public void addexpense()
        {
            Expense e = new Models.Expense();
            e.getlastid();
            Cash c = new Cash();
            decimal k = c.get();
            k -= e.Amount;
            c.CB = k;
            c.update();
            string q = "Insert into Cash_Transitions (Expense,E_ID,Invoice,Transition_Date,CB,AP,AR) values (1" + "," + e.E_ID + ",0,'" + e.Date + "'," + k + ",0,0)";
            SqlCommand cmd = new SqlCommand(q, Connection.Get());
            cmd.ExecuteNonQuery();
        }
    }
}
