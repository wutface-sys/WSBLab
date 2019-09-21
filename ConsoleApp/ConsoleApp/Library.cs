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
    public partial class Library : Form
    {
        public Library()
        {
            InitializeComponent();
        }

        private void chkBtn_Click(object sender, EventArgs e)
        {
            String chk = bookText.Text;
            StreamReader sr = new StreamReader(@"C:\Users\studentwsb\Documents\Nowy folder\ConsoleApp\books.txt");
            string[] lines = File.ReadAllLines(@"C:\Users\studentwsb\Documents\Nowy folder\ConsoleApp\books.txt");
            bool isMatch = false;
            for (int x = 0; x < lines.Length - 1; x++)
            {
                if (chk == lines[x])
                {
                    sr.Close();
                    chkLbl.Text = "There is a match";
                    isMatch = true;
                }
            }
            if (!isMatch)
            {
                sr.Close();
                chkLbl.Text  = "There is no match";
            }
        }
    }
}
