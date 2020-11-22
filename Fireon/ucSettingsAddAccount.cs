using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fireon
{
    public partial class Settings_Add_Account : UserControl
    {
        public Settings_Add_Account()
        {
            InitializeComponent();
        }


        private void btn_cancel_add_account_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
