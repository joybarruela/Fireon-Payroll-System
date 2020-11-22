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
    public partial class ucSettings : UserControl
    {
        public ucSettings()
        {
            InitializeComponent();
        }

        private void btn_accounts_Click(object sender, EventArgs e)
        {
            uc_setting_accounts.Show();
            uc_setting_accounts.BringToFront();
            uc_setting_accounts.SetBounds(0,0, 1060, 680);
        }

        private void btn_notifications_Click(object sender, EventArgs e)
        {
            uc_setting_notifications.Show();
            uc_setting_notifications.BringToFront();
            uc_setting_notifications.SetBounds(0, 0, 1060, 680);

        }
    }
}
