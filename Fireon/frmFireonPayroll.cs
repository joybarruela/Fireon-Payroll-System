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
    public partial class frmFireonPayroll : MetroFramework.Forms.MetroForm
    {
        public frmFireonPayroll()
        {
            InitializeComponent();
        }

        public void deactivate_button()
        {
            btn_dashboard.Image = Properties.Resources.btn_dashboard;
            btn_employee.Image = Properties.Resources.btn_employee;
            btn_leave.Image = Properties.Resources.btn_leave;
            btn_overtime.Image = Properties.Resources.btn_overtime;
            btn_holiday.Image = Properties.Resources.btn_holiday;
            btn_violations.Image = Properties.Resources.btn_violation;
            btn_settings.Image = Properties.Resources.btn_settings;
            btn_cash_advance.Image = Properties.Resources.btn_cash_advance;
            btn_allowances.Image = Properties.Resources.btn_allowances;
            btn_deductions.Image = Properties.Resources.btn_deductions;
            btn_all.Image = Properties.Resources.btn_all;
            btn_department.Image = Properties.Resources.btn_department;
            btn_single_posting.Image = Properties.Resources.btn_single_posting;
        }

        public void hide_user_control()
        {
            uc_all.Hide();
            uc_allowances.Hide();
            uc_cash_advance.Hide();
            uc_dashboard.Hide(); ;
            uc_deductions.Hide();
            uc_department.Hide();
            uc_employee.Hide();
            uc_holiday.Hide();
            uc_leave.Hide();
            uc_overtime.Hide();
            uc_settings.Hide();
            uc_single_posting.Hide();
            uc_violations.Hide();
        }
        private void Fireon_Load(object sender, EventArgs e)
        {
            btn_dashboard.Image = Properties.Resources.btn_dashboard_active;
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            hide_user_control();
            uc_dashboard.Visible = true;
            //uc_dashboard.SetBounds(258, 81, 1060, 680);
            uc_dashboard.Dock = DockStyle.Fill;
            uc_dashboard.BringToFront();
            deactivate_button();
            btn_dashboard.Image = Properties.Resources.btn_dashboard_active;
        }

        private void btn_employee_Click(object sender, EventArgs e)
        {
            hide_user_control();
            uc_employee.Visible = true;
            //uc_employee.SetBounds(258, 81, 1060, 680);
            uc_employee.Dock = DockStyle.Fill;
            uc_employee.BringToFront();
            deactivate_button();
            btn_employee.Image = Properties.Resources.btn_employee_active;
        }

        private void btn_leave_Click(object sender, EventArgs e)
        {
            hide_user_control();
            uc_leave.Visible = true;
            //uc_leave.SetBounds(258, 81, 1060, 680);
            uc_leave.Dock = DockStyle.Fill;
            uc_leave.BringToFront();
            deactivate_button();
            btn_leave.Image = Properties.Resources.btn_leave_active;
        }

        private void btn_overtime_Click(object sender, EventArgs e)
        {
            hide_user_control();
            uc_overtime.Visible = true;
            //uc_overtime.SetBounds(258, 81, 1060, 680);
            uc_overtime.Dock = DockStyle.Fill;
            uc_overtime.BringToFront();
            deactivate_button();
            btn_overtime.Image = Properties.Resources.btn_overtime_active;
        }

        private void btn_holiday_Click(object sender, EventArgs e)
        {
            hide_user_control();
            uc_holiday.Visible = true;
            //uc_holiday.SetBounds(258, 81, 1060, 680);
            uc_holiday.Dock = DockStyle.Fill;
            uc_holiday.BringToFront();
            deactivate_button();
            btn_holiday.Image = Properties.Resources.btn_holiday_active;
        }

        private void btn_violations_Click(object sender, EventArgs e)
        {
            hide_user_control();
            uc_violations.Visible = true;
            //uc_violations.SetBounds(258, 81, 1060, 680);
            uc_violations.Dock = DockStyle.Fill;
            uc_violations.BringToFront();
            deactivate_button();
            btn_violations.Image = Properties.Resources.btn_violations_active;
        }

        private void btn_cash_advance_Click(object sender, EventArgs e)
        {
            hide_user_control();
            uc_cash_advance.Visible = true;
            //uc_cash_advance.SetBounds(258, 81, 1060, 680);
            uc_cash_advance.Dock = DockStyle.Fill;
            uc_cash_advance.BringToFront();
            deactivate_button();
            btn_cash_advance.Image = Properties.Resources.btn_cash_advance_active;
        }

        private void btn_deductions_Click(object sender, EventArgs e)
        {
            hide_user_control();
            uc_deductions.Visible = true;
            pnl_header.BringToFront();
            //uc_deductions.SetBounds(258, 81, 1060, 680);
            uc_deductions.Dock = DockStyle.Fill;
            uc_deductions.BringToFront();
            deactivate_button();
            btn_deductions.Image = Properties.Resources.btn_deductions_active;
        }

        private void btn_allowances_Click(object sender, EventArgs e)
        {
            hide_user_control();
            uc_allowances.Visible = true;
            //uc_allowances.SetBounds(258, 81, 1060, 680);
            uc_allowances.Dock = DockStyle.Fill;
            uc_allowances.BringToFront();
            deactivate_button();
            btn_allowances.Image = Properties.Resources.btn_allowances_active;
        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            hide_user_control();
            uc_all.Visible = true;
            pnl_header.BringToFront();
            //uc_all.SetBounds(258, 81, 1060, 680);
            uc_all.Dock = DockStyle.Fill;
            uc_all.BringToFront();
            deactivate_button();
            btn_all.Image = Properties.Resources.btn_all_active;
        }

        private void btn_department_Click(object sender, EventArgs e)
        {
            hide_user_control();
            uc_department.Visible = true;
            pnl_header.BringToFront();
            //uc_department.SetBounds(258, 81, 1060, 680);
            uc_department.Dock = DockStyle.Fill;
            uc_department.BringToFront();
            deactivate_button();
            btn_department.Image = Properties.Resources.btn_department_active;
        }

        private void btn_single_posting_Click(object sender, EventArgs e)
        {
            hide_user_control();
            uc_single_posting.Visible = true;
            pnl_header.BringToFront();
            //uc_single_posting.SetBounds(258, 81, 1060, 680);
            uc_single_posting.Dock = DockStyle.Fill;
            uc_single_posting.BringToFront();
            deactivate_button();
            btn_single_posting.Image = Properties.Resources.btn_single_active;
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            hide_user_control();
            uc_settings.Visible = true;
            //uc_settings.SetBounds(258, 81, 1060, 680);
            uc_settings.Dock = DockStyle.Fill;
            uc_settings.BringToFront();
            deactivate_button();
            btn_settings.Image = Properties.Resources.btn_settings_active;
        }

        private void hide_menu_panel()
        {

        }
        private void btn_menu_Click(object sender, EventArgs e)
        {
            //Hide and show menu panel.
            pnl_menu.BringToFront();
            pnl_menu.Visible = !pnl_menu.Visible;
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            frmLogin main_form = new frmLogin();
            this.Visible = false;
            main_form.Show();   
        }

      
    }
}
