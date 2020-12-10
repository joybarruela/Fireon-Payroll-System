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
    public partial class ucEmployee : UserControl
    {
        public ucEmployee()
        {
            InitializeComponent();
        }

        private void Employee_Load(object sender, EventArgs e)
        {

        }

        private void btn_hire_employees_Click(object sender, EventArgs e)
        {
            ucNewEmployee newEmployee = new ucNewEmployee();

            newEmployee.Dock = DockStyle.Fill;
            newEmployee.BringToFront();
        }
    }
}
