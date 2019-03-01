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
    public partial class Admin_Panel : Form
    {
        public static bool update = false;
        public static bool admin = false;
        public static bool moderator = false;
        public Admin_Panel()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            update = true;
            admin = false;
            moderator = false;
            Update_Profile up = new Update_Profile();
            up.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            update = false;
            admin = true;
            moderator = false;
            Update_Profile up = new Update_Profile();
            up.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            update = false;
            admin = false;
            moderator = true;
            Update_Profile up = new Update_Profile();
            up.ShowDialog();
        }
    }
}
