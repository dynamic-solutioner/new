using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
<<<<<<< HEAD
using System.Globalization;
=======
>>>>>>> 59ee30f28fc28fa58010d24d9d656a7d159d326c
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

<<<<<<< HEAD
namespace KMS
=======
namespace KMS.Models
>>>>>>> 59ee30f28fc28fa58010d24d9d656a7d159d326c
{
    public partial class Inventory_Panel : Form
    {
        public Inventory_Panel()
        {
            InitializeComponent();
        }

<<<<<<< HEAD
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            DateTime result;
            if (DateTime.TryParseExact(textBox5.Text, new string[] { "d-M", "d/M", "d.M" }, CultureInfo.CurrentCulture, DateTimeStyles.AssumeLocal, out result))
            {
                textBox5.Text = result.ToShortDateString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                Models.Inventory inventory = new Models.Inventory();
                List<Models.Inventory> lst = inventory.ShowAll();
                bool check = true;
                for (int i = 0; i < lst.Count; i++)
                {
                    if (lst[i].Name == textBox1.Text)
                    {
                        check = false;
                        lst[i].Quantity = int.Parse(textBox3.Text);
                        lst[i].Price += Convert.ToDecimal(textBox4.Text);
                        lst[i].Total += lst[i].Price;
                        break;
                    }
                }
                if (check)
                {
                    inventory.Name = textBox1.Text;
                    inventory.Description = textBox2.Text;
                    inventory.Quantity = int.Parse(textBox3.Text);
                    inventory.Price = Convert.ToDecimal(textBox4.Text);
                    inventory.Total += inventory.Price;
                    inventory.add();
                }
                else
                {
                    MessageBox.Show("Inventory already exists and changes are overwritten");
                }
=======
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
            {
                Models.Inventory invent = new Models.Inventory()
                {

                };
>>>>>>> 59ee30f28fc28fa58010d24d9d656a7d159d326c
            }
        }
    }
}
