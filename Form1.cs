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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
               MessageBox.Show("Updated");
            }
            if (comboBox1.Text == "Moderator")
            {
                Models.Moderator m = new Models.Moderator();
                m.Username = textBox1.Text;
                m.Password = textBox2.Text;
                if (m.login())
                {
                    this.Hide();
                    Dashboard d = new Dashboard();
                    d.ShowDialog();
                   
                    return;
                }
            }
            else if (comboBox1.Text == "Admin")
            {
                Models.Admin ad = new Models.Admin();
                ad.Username = textBox1.Text;
                ad.Password = textBox2.Text;
                if (ad.login())
                {
                    this.Hide();
                    Dashboard d = new Dashboard();
                    d.ShowDialog();
            
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
