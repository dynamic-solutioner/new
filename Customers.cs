using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMS
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                comboBox1.Visible = true;
            }
            else
            {
                comboBox1.Visible = false;
                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;
            }
        }

        private void Customers_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            Models.Customer c = new Models.Customer();
            List<Models.Customer> cm = c.showall();
            for (int i = 0; i < cm.Count; i++)
            {
                comboBox1.Items.Add(cm[i].Name);
            }
            Models.Packages p = new Models.Packages();
            List<Models.Packages> pp = p.all();
            for (int i = 0; i < pp.Count; i++)
            {
                comboBox2.Items.Add(pp[i].Name);
            }
<<<<<<< HEAD
=======
=======
            MessageBox.Show("Hello");
            MessageBox.Show("world");
>>>>>>> parent of ba5b198... Merge branch 'master' of https://github.com/dynamic-solutioner/KMS
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if (checkBox1.Checked)
            {
                if (comboBox1.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" && comboBox2.Text != "")
                {
                    Models.Customer c = new Models.Customer();
                    c.Name = comboBox1.Text;
                    Models.Invoice i = new Models.Invoice();
                    Models.Packages p = new Models.Packages();
                    p.Name = comboBox2.Text;
                    i.C_ID = c.getid();
                    i.Discount_A = Convert.ToDecimal(textBox6.Text);
                    i.PaidA = Convert.ToDecimal(textBox7.Text);
                    i.Package_ID = p.getid();
                    i.Description = textBox8.Text;
                    i.add();
                }
                else
                {
                    MessageBox.Show("Incomplete Data");
                }
            }
            else
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox7.Text != "" && textBox8.Text != "" && textBox9.Text != "" && comboBox2.Text != "")
                {
                    Models.Customer c = new Models.Customer();
                    c.Name = textBox1.Text;
                    c.Passport = textBox2.Text;
                    c.Contact = textBox3.Text;
                    c.Address = textBox4.Text;
                    c.email = textBox5.Text;
                    c.add();
                    Models.Invoice i = new Models.Invoice();
                    Models.Packages p = new Models.Packages();
                    p.Name = comboBox2.Text;
                    i.C_ID = c.getid();
                    i.Discount_A = Convert.ToDecimal(textBox6.Text);
                    i.PaidA = Convert.ToDecimal(textBox7.Text);
                    i.Package_ID = p.getid();
                    i.Description = textBox8.Text;
                    i.add();
                }
                else
                {
                    MessageBox.Show("Incomplete Data");
                }
            }
>>>>>>> parent of 74d81a1... mm
=======
            MessageBox.Show("Hello");
            MessageBox.Show("world");
>>>>>>> parent of e624f26... Merge branch 'master' of https://github.com/dynamic-solutioner/KMS
=======
            MessageBox.Show("Hello");
            MessageBox.Show("world");
>>>>>>> parent of ba5b198... Merge branch 'master' of https://github.com/dynamic-solutioner/KMS
=======
            MessageBox.Show("Hello");
            MessageBox.Show("world");
>>>>>>> parent of e624f26... Merge branch 'master' of https://github.com/dynamic-solutioner/KMS
        }
<<<<<<< HEAD

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
=======
>>>>>>> parent of ba5b198... Merge branch 'master' of https://github.com/dynamic-solutioner/KMS

        }
=======
>>>>>>> parent of a66a4cb... 5:47
    }
}
