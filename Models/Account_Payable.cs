using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMS.Models
{
    class Account_Payable
    {
        public int AP_ID { get; set; }
        public int E_ID { get; set; }
        public void add()
        {
            Models.Expense ex = new Models.Expense();
            ex.getlastid();
            string q = "Insert Into Account_Payable values (" + ex.E_ID + ")";
            SqlCommand cmd = new SqlCommand(q,Connection.Get());
            cmd.ExecuteNonQuery();
        }
    }
}
