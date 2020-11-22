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
    public partial class Setting_Accounts : UserControl
    {
        public Setting_Accounts()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void uc_update_account_Load(object sender, EventArgs e)
        {

        }

        private void btn_add_account_Click(object sender, EventArgs e)
        {
         
            uc_add_account.Show();
            uc_add_account.BringToFront();
            uc_add_account.SetBounds(5, 79, 1048, 523);
        }

        private void btn_update_account_1_Click(object sender, EventArgs e)
        {
            uc_update_account.Show();
            uc_update_account.BringToFront();
            uc_update_account.SetBounds(5, 80, 1048, 523);
        }

      
        
    
    }
}
