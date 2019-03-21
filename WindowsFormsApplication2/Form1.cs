using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rectangleShape1_Click(object sender, EventArgs e)
        {
           
        }

        private void Login_Load(object sender, EventArgs e)
        {
            email.Select();
        }

        private void email_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void password_Click(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = true;
            password.Text = "";
        }

        private void username_Click(object sender, EventArgs e)
        {
            email.Text = "";
        }

        private void button_Click(object sender, EventArgs e)
        {
            
            perpustakaan tampil = new perpustakaan();
            tampil.Show();
            this.Hide();
        }
    }
}
