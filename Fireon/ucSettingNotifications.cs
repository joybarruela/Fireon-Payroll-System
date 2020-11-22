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
    public partial class Setting_Notifications : UserControl
    {
        public Setting_Notifications()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();    
        }

        private void btn_update_notif_1_Click(object sender, EventArgs e)
        {
            uc_update_notification.BringToFront();
            uc_update_notification.Visible = true;
            uc_update_notification.SetBounds(116, 180, 738, 441);
        }

        private void btn_add_notification_Click(object sender, EventArgs e)
        {
            uc_add_notification.BringToFront();
            uc_add_notification.Visible = true;
            uc_add_notification.SetBounds(116, 180, 738, 441);
        }

    }
}
