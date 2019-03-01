using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMS.Models
{
    class Cheque
    {
        public int C_ID { get; set; }
        public int C_Number { get; set; }
        public bool C_Status { get; set; }
        public int B_ID { get; set; }
        public void insert(string n)
        {
            Bank_Transition bt = new Bank_Transition();
            string q = "insert into Cheque values (" + Convert.ToInt32(n) + ",1," + bt.lasttrans() + ")";
            SqlCommand cmd = new SqlCommand(q, Connection.Get());
            cmd.ExecuteNonQuery();
        }
    }
}
