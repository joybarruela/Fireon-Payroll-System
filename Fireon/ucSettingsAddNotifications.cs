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
    public partial class Settings_Add_Notifications : UserControl
    {
        public Settings_Add_Notifications()
        {
            InitializeComponent();
        }
        private void btn_cancel_add_notif_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_add_notif_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
