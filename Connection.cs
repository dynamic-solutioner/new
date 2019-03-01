using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace KMS
{
    class Connection
    {
      public static  SqlConnection sc;
        public static SqlConnection Get()
        {
            if (sc == null)
            {
                sc = new SqlConnection();
                sc.ConnectionString = "Data Source =RUDOLF ; Initial Catalog =Karwan; Integrated Security = SSPI;";
                sc.Open();
            }
            return sc;
        }
    }
}
