using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fireon
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
          
        }

        private void btn_login_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Loading will take some time, please be patient.", "Logging In", MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmFireonPayroll main_form = new frmFireonPayroll();
            this.Visible = false;
            main_form.Show();   
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {

        }
    }
}
