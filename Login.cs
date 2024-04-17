using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtBloq
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if(usernameBox.Text == "admin" && passwordBox.Text == "admin")
            {
                MessageBox.Show("Successfully logged in", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                Form1 form1 = new Form1();
                form1.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login failed","Retry",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
