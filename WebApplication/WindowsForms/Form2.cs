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
    public partial class Form2 : Form
    {
        public Form2(AccountData accountData)
        {

            InitializeComponent();
            txtFullName.Text = accountData.FullName;
            txtDateOfBirth.Text = accountData.DateOfBirth;
            txtHomeTown.Text = accountData.HomeTown;
            txtIDCart.Text = accountData.IDCart;
            txtNation.Text = accountData.Nation;
            txtReligion.Text = accountData.Religion;
            label3.Text = accountData.FullName;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //AccountData accountData = new AccountData();
           
        }

        private void btLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            fLogin f1 = new fLogin();
            f1.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btNext_Click(object sender, EventArgs e)
        {
            pn1.Visible = false;
            pnDanhmuc1.Visible = false;
            pn2.Visible = true;
            pnDanhMuc2.Visible = true;
        }

        private void btExitpn3_2_Click(object sender, EventArgs e)
        {
            pn1.Visible = true;
            pnDanhmuc1.Visible = true;
            pn2.Visible = false;
            pnDanhMuc2.Visible = false;
        }

        private void btNextpn3_2_Click(object sender, EventArgs e)
        {
            pn2.Visible = false;
            pnDanhMuc2.Visible = false;
            pn3.Visible = true;
            pnDanhMuc3.Visible = true;
        }

        private void btExitpn3_3_Click(object sender, EventArgs e)
        {
            pn3.Visible = false;
            pnDanhMuc3.Visible = false;
            pn2.Visible = true;
            pnDanhMuc2.Visible = true;
        }

        private void cbDieuKhoan_CheckedChanged(object sender, EventArgs e)
        {
            if (cbDieuKhoan.Checked = true)
            {
                btNextpn3_2.Enabled = true;
            }
        }
    }
}
