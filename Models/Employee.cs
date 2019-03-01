using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace KMS.Models
{
    class Employee
    {
        public int EMP_ID { get; set; }
        public string EMP_Name { get; set; }
        public int EMP_Age { get; set; }
        public int EMP_CNIC { get; set; }
        public string EMP_Desig { get; set; }
        public decimal EMP_Sal { get; set; }
        public decimal EMP_Loan { get; set; }

        public void add()
        {
            string q = "Insert Into Employee Values('" + EMP_Name + "', " + EMP_Age + ", " + EMP_CNIC + ", '" + EMP_Desig + "'," + EMP_Sal + "," + EMP_Loan + ")";
            SqlCommand cmd = new SqlCommand(q, Connection.Get());
            cmd.ExecuteNonQuery();
        }

        public List<Employee> all()
        {
            List<Employee> lst = new List<Employee>();
            string q = "Select * From Employee";
            SqlCommand cmd = new SqlCommand(q, Connection.Get());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Employee emp = new Employee();
                emp.EMP_ID = (int)reader[0];
                emp.EMP_Name = (string)reader[1];
                emp.EMP_Age = (int)reader[2];
                emp.EMP_CNIC = (int)reader[3];
                emp.EMP_Desig = (string)reader[4];
                emp.EMP_Sal = (decimal)reader[5];
                emp.EMP_Loan = (decimal)reader[6];
                lst.Add(emp);
            }
            reader.Close();
            return lst;
        }
    }
}
