using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            AccountData accountData = new AccountData();
            accountData.GetData(txtAccount.Text);
            if (accountData.Password == txtPassword.Text)
            {
                MessageBox.Show("Login Success!");
                //Form f1 = new Form();
                Form2 f2 = new Form2(accountData);
                this.Hide();
                f2.Show();
            }
            else
            {
                MessageBox.Show("Login Fail!");
            }
        }
    }
}
