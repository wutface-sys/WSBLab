using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PWtext.PasswordChar = '*';
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = UNtext.Text;
            string password = PWtext.Text;
            StreamReader ab = new StreamReader(@"C:\Users\studentwsb\Documents\Nowy folder\ConsoleApp\users.txt");
            string line1 = ab.ReadLine();
            string line2 = ab.ReadLine();

                if (username == line1 && password == line2)
                {
                    var frm = new Library();
                    frm.Location = this.Location;
                    frm.StartPosition = FormStartPosition.Manual;
                    frm.FormClosing += delegate { this.Show(); };
                    frm.Show();
                    this.Hide();

                }
                else
                {
                    errorLabel.Text = "Blad logowania";

                }

        }
    }
}
