using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMS.Models
{
    class Cash
    {
        
        public decimal CB { get; set; }
        public decimal get()
        {
            string q = "Select CB from Cash Where C_ID = " + 1 ;
            SqlCommand cmd = new SqlCommand(q,Connection.Get());
            SqlDataReader sdr = cmd.ExecuteReader();
            while (sdr.Read())
            {
                decimal j = (decimal)sdr[0];
                sdr.Close();
                return j;
                
            }
            return 0;
          
        }
        public void update()
        {
            string q = "Update Cash Set CB ="+ CB + " Where C_ID = " + 1;
            SqlCommand cmd = new SqlCommand(q, Connection.Get());
            cmd.ExecuteNonQuery();
        }
    }
}
