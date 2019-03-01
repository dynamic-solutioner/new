using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace KMS.Models
{
    class Inventory
    {
        public int In_ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
<<<<<<< HEAD
        public string Added_Date { get; set; }
=======
>>>>>>> 59ee30f28fc28fa58010d24d9d656a7d159d326c
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Total { get; set; }
        public int E_ID { get; set; }
        public int IC_ID { get; set; }

        public void add()
        {
            string q = "Insert Into Inventory Values('" + Name + "' ,'" + Description + "', " + Quantity + ", " + Price + ", " + Total + ", " + E_ID + ", " + IC_ID + ")";
            SqlCommand cmd = new SqlCommand(q, Connection.Get());
            cmd.ExecuteNonQuery();
        }

        public List<Inventory> ShowAll()
        {
            string q = "Select * From Inventory";
            SqlCommand cmd = new SqlCommand(q,Connection.Get());
            SqlDataReader reader = cmd.ExecuteReader();
            List<Inventory> lst = new List<Inventory>();
            while (reader.Read())
            {
                Inventory inventory = new Inventory();
                inventory.In_ID = (int)reader[0];
                inventory.Description = (string)reader[2];
                inventory.Quantity = (int)reader[3];
                inventory.Price = (decimal)reader[4];
                inventory.Total = (decimal)reader[5];
                inventory.E_ID = (int)reader[6];
                inventory.IC_ID = (int)reader[7];
                lst.Add(inventory);
            }
            reader.Close();
            return lst;
        }

        public Inventory ShowInventoryByIC_ID(int IC_ID)
        {
            Inventory inventory = new Inventory();
            this.IC_ID = IC_ID;
            string q = "Select * From Invetory Where IC_ID=" + IC_ID + "";
            //string q = "Select * From Inventory";
            SqlCommand cmd = new SqlCommand(q, Connection.Get());
            SqlDataReader reader = cmd.ExecuteReader();
            inventory.In_ID = (int)reader[0];
            inventory.Description = (string)reader[1];
            inventory.Quantity = (int)reader[2];
            inventory.Price = (decimal)reader[3];
            inventory.Total = (decimal)reader[4];
            inventory.E_ID = (int)reader[5];
            inventory.IC_ID = (int)reader[6];
            reader.Close();
            return inventory;
        }

        public List<Inventory> ShowInventoryByID(int IC_ID)
        {
            List<Inventory> lst = new List<Inventory>();    
            string q = "Select * From Invetory Where IC_ID=" + IC_ID + "";
            SqlCommand cmd = new SqlCommand(q, Connection.Get());
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Inventory inventory = new Inventory();
                //string q = "Select * From Inventory";
                inventory.In_ID = (int)reader[0];
                inventory.Description = (string)reader[1];
                inventory.Quantity = (int)reader[2];
                inventory.Price = (decimal)reader[3];
                inventory.Total = (decimal)reader[4];
                inventory.E_ID = (int)reader[5];
                inventory.IC_ID = (int)reader[6];
                lst.Add(inventory);
            }
            reader.Close();
            return lst;
        }

        public void Delete()
        {
            string q = "Delete [Inventory] Where In_ID=" + In_ID + "";
            SqlCommand cmd = new SqlCommand(q, Connection.Get());
            cmd.ExecuteNonQuery();
        }

        public void Update()
        {
            string q = "Update [Inventory] Set Description = " + Description + ", Quantity= " + Quantity + ", Price=" + Price + ", Total=" + Total + "";
            SqlCommand cmd = new SqlCommand(q, Connection.Get());
            cmd.ExecuteNonQuery();
        }
    }
}
