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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            
            if (Models.Current.checker == false)
            {
                label1.Text = "Moderator " + Models.Current.Username;
            }
            else { label1.Text = "Admin " + Models.Current.Username; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin_Panel ap = new Admin_Panel();
            ap.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Expense_Panel ep = new Expense_Panel();
            ep.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bank b = new Bank();
            b.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Customers cm = new Customers();
            cm.ShowDialog();
        }
    }
}
