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
    public partial class Settings_Update_Account : UserControl
    {
        public Settings_Update_Account()
        {
            InitializeComponent();
        }
        private void btn_cancel_update_account_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_update_account_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
