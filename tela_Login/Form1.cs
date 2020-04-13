using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tela_Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtUser.Text == "admin" && txtPass.Text == "1234")

                {
                    this.Hide();
                    Form f = new Main();
                    f.Closed += (s, args) => this.Close();
                    f.Show();
                }else
            {
                MessageBox.Show("User or Password Invalid");
            }
        }
    }
}
