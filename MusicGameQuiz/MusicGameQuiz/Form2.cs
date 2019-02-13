using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicGameQuiz
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSubmitLogin_Click(object sender, EventArgs e)
        {
            string username = txtUname.Text;
            string password = txtPwd.Text;

            if (username == "admin" && password == "admin")
            {
                this.Close();
            }
            else {
                lblLoginDetailIncorrect.Text = "Your login details are incorrect!";
            }
        }
    }
}
