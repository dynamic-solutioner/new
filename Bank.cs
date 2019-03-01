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
    public partial class Bank : Form
    {
        public Bank()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Models.Bank b = new Models.Bank();
            b.Name = textBox1.Text;
            b.Balance = Convert.ToDecimal( textBox2.Text);
            b.add();
        }
        
        
    }
}
