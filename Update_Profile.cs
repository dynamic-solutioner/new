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
    public partial class Update_Profile : Form
    {
        public Update_Profile()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Update_Profile_Load(object sender, EventArgs e)
        {
            if (Admin_Panel.admin || Admin_Panel.moderator)
            {
                textBox5.Visible = false;
            }
            else
            {
                textBox1.Text = Models.Current.Name;
                textBox2.Text = Models.Current.Username;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Admin_Panel.admin)
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
                {
                    if (textBox3.Text == textBox4.Text)
                    {
                        Models.Admin ad = new Models.Admin();
                        ad.Name = textBox1.Text;
                        ad.Username = textBox2.Text;
                        ad.Password = textBox3.Text;
                        ad.Add();
                        MessageBox.Show("added sucessfully");
                        this.Hide();
                        Admin_Panel ap = new Admin_Panel();
                        ap.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Password Didnt Match");
                    }
                }
                else
                {
                    MessageBox.Show("Incomplete Data");
                }
            }
            else if (Admin_Panel.moderator)
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
                {
                    if (textBox3.Text == textBox4.Text)
                    {
                        Models.Moderator ad = new Models.Moderator();
                        ad.Name = textBox1.Text;
                        ad.Username = textBox2.Text;
                        ad.Password = textBox3.Text;
                        ad.Add();
                        MessageBox.Show("added sucessfully");
                        this.Hide();
                        Admin_Panel ap = new Admin_Panel();
                        ap.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Password Didnt Match");
                    }
                }
                else { MessageBox.Show("Incomplete Data"); }
            }
            else
            {
                if (textBox3.Text == Models.Current.Password)
                {
                    if (textBox4.Text == textBox5.Text)
                    {
                        if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "")
                        {
                            if (Models.Current.checker)
                            {
                                Models.Admin ad = new Models.Admin();
                                ad.Admin_ID = Models.Current.ID;
                                ad.Name = textBox1.Text;
                                ad.Username = textBox2.Text;
                                ad.Password = textBox4.Text;
                                ad.update();
                                MessageBox.Show("Update Sucess");
                                Models.Current.Name = textBox1.Text;

                                Models.Current.Username = textBox2.Text;

                                Models.Current.Password = textBox4.Text;
                                
                                this.Hide();
                                Admin_Panel ap = new Admin_Panel();
                                ap.ShowDialog();
                            }
                            else
                            {
                                Models.Moderator md = new Models.Moderator();
                                md.M_ID = Models.Current.ID;
                                md.Name = textBox1.Text;
                                md.Username = textBox2.Text;
                                md.Password = textBox4.Text;
                                Models.Current.Name = textBox1.Text;
                                Models.Current.Username = textBox2.Text;
                                Models.Current.Password = textBox4.Text;
                                MessageBox.Show("Update Sucess");
                                this.Hide();
                                Admin_Panel ap = new Admin_Panel();
                                ap.ShowDialog();
                                
                            }
                        }
                        else
                        {
                            MessageBox.Show("Incomplete Input");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password Didnt Match");
                    }
                }
                else { MessageBox.Show("Invalid Password"); }
            }

        }
    }
}
