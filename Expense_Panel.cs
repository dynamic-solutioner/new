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
    public partial class Expense_Panel : Form
    {
        public Expense_Panel()
        {
            InitializeComponent();
        }
        
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked || radioButton2.Checked)
            {
                comboBox3.Visible = false;
                textBox6.Visible = false;
            }
            else if (radioButton3.Checked)
            {
                comboBox3.Visible = true;
                textBox6.Visible = false;
            }
            else
            {
                comboBox3.Visible = true;
                textBox6.Visible = true;
            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Models.Expense_Cat ex = new Models.Expense_Cat();
            List<Models.Expense_Cat> ch = ex.all();
            bool check = true;
            for (int i = 0; i < ch.Count; i++)
            {
                if (ch[i].E_Name == textBox2.Text)
                {
                    check = false;
                }
            }
            if (check)
            {
                ex.E_Name = textBox2.Text;
                ex.add();
            }
            else
            {
                MessageBox.Show("Category Already Exist");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked ||radioButton2.Checked)
            {
                if (comboBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
                {
                    if (radioButton1.Checked)
                    {
                        Models.Expense ex = new Models.Expense();
                        ex.Amount = Convert.ToDecimal(textBox3.Text);
                        ex.Description = textBox4.Text;
                        ex.add(comboBox2.Text);
                        Models.Cash_Transitions ct = new Models.Cash_Transitions();
                        ct.addexpense();
                    }
                    else if (radioButton2.Checked)
                    {
                        Models.Expense ex = new Models.Expense();
                        ex.Amount = Convert.ToDecimal(textBox3.Text);
                        ex.Description = textBox4.Text;
                        ex.add(comboBox2.Text);
                        Models.Account_Payable ap = new Models.Account_Payable();
                        ap.add();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Input");
                }
            }
            if (radioButton3.Checked)
            {
                Models.Expense ex = new Models.Expense();
                ex.Amount = Convert.ToDecimal(textBox3.Text);
                ex.Description = textBox4.Text;
                ex.add(comboBox2.Text);
                Models.Bank_Transition bt = new Models.Bank_Transition();
                bt.addexpense(comboBox3.Text);

            }
            else if (radioButton4.Checked)
            {
                Models.Expense ex = new Models.Expense();
                ex.Amount = Convert.ToDecimal(textBox3.Text);
                ex.Description = textBox4.Text;
                ex.add(comboBox2.Text);
                Models.Bank_Transition bt = new Models.Bank_Transition();
                bt.addexpense(comboBox3.Text);
                Models.Cheque chq = new Models.Cheque();
                chq.insert(textBox6.Text);
            }
        }

        private void Expense_Panel_Load(object sender, EventArgs e)
        {
            Models.Expense_Cat x = new Models.Expense_Cat();
            List<Models.Expense_Cat> abc = x.all();
            for (int i = 0; i < abc.Count; i++)
            {
                comboBox2.Items.Add(abc[i].E_Name);
            }
            Models.Bank b = new Models.Bank();
            List<Models.Bank> bk = new List<Models.Bank>();

            bk = b.all();
            for (int i = 0; i < bk.Count; i++)
            {
                comboBox3.Items.Add(bk[i].Name);
            }
        }
    }
}
