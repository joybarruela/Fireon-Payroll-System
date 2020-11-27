using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics; // FOR READING THE PROCESS OBJECT
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fireon
{
    public partial class frmFireonPayroll : Form
    {
        public frmFireonPayroll()
        {
            InitializeComponent();
        }

        public void deactivate_button()
        {
            btn_dashboard.BackgroundImage = Properties.Resources.btn_dashboard;
            btn_employee.BackgroundImage = Properties.Resources.btn_employee;
            btn_leave.BackgroundImage = Properties.Resources.btn_leave;
            btn_overtime.BackgroundImage = Properties.Resources.btn_overtime;
            btn_holiday.BackgroundImage = Properties.Resources.btn_holiday;
            btn_violations.BackgroundImage = Properties.Resources.btn_violation;
            btn_settings.BackgroundImage = Properties.Resources.btn_settings;
            btn_cash_advance.BackgroundImage = Properties.Resources.btn_cash_advance;
            btn_allowances.BackgroundImage = Properties.Resources.btn_allowances;
            btn_deductions.BackgroundImage = Properties.Resources.btn_deductions;
            btn_all.BackgroundImage = Properties.Resources.btn_all;
            btn_department.BackgroundImage = Properties.Resources.btn_department;
            btn_single_posting.BackgroundImage = Properties.Resources.btn_single_posting;
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
            btn_dashboard.BackgroundImage = Properties.Resources.btn_dashboard_active;
        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            hide_user_control();
            uc_dashboard.Visible = true;
            uc_dashboard.Dock = DockStyle.Fill;
            uc_dashboard.BringToFront();
            deactivate_button();
            btn_dashboard.BackgroundImage = Properties.Resources.btn_dashboard_active;
        }

        private void btn_employee_Click(object sender, EventArgs e)
        {
            hide_user_control();
            uc_employee.Visible = true;
            uc_employee.Dock = DockStyle.Fill;
            uc_employee.BringToFront();
            deactivate_button();
            btn_employee.BackgroundImage = Properties.Resources.btn_employee_active;
        }

        private void btn_leave_Click(object sender, EventArgs e)
        {
            hide_user_control();
            uc_leave.Visible = true;
            uc_leave.Dock = DockStyle.Fill;
            uc_leave.BringToFront();
            deactivate_button();
            btn_leave.BackgroundImage = Properties.Resources.btn_leave_active;
        }

        private void btn_overtime_Click(object sender, EventArgs e)
        {
            hide_user_control();
            uc_overtime.Visible = true;
            uc_overtime.Dock = DockStyle.Fill;
            uc_overtime.BringToFront();
            deactivate_button();
            btn_overtime.BackgroundImage = Properties.Resources.btn_overtime_active;
        }

        private void btn_holiday_Click(object sender, EventArgs e)
        {
            hide_user_control();
            uc_holiday.Visible = true;
            uc_holiday.Dock = DockStyle.Fill;
            uc_holiday.BringToFront();
            deactivate_button();
            btn_holiday.BackgroundImage = Properties.Resources.btn_holiday_active;
        }
        private void btn_violations_Click(object sender, EventArgs e)
        {
            hide_user_control();
            uc_violations.Visible = true;
            uc_violations.Dock = DockStyle.Fill;
            uc_violations.BringToFront();
            deactivate_button();
            btn_violations.BackgroundImage = Properties.Resources.btn_violations_active;
        }

        private void btn_cash_advance_Click(object sender, EventArgs e)
        {
            hide_user_control();
            uc_cash_advance.Visible = true;
            uc_cash_advance.Dock = DockStyle.Fill;
            uc_cash_advance.BringToFront();
            deactivate_button();
            btn_cash_advance.BackgroundImage = Properties.Resources.btn_cash_advance_active;
        }

        private void btn_deductions_Click(object sender, EventArgs e)
        {
            hide_user_control();
            uc_deductions.Visible = true;
            uc_deductions.Dock = DockStyle.Fill;
            uc_deductions.BringToFront();
            deactivate_button();
            btn_deductions.BackgroundImage = Properties.Resources.btn_deductions_active;
        }

        private void btn_allowances_Click(object sender, EventArgs e)
        {
            hide_user_control();
            uc_allowances.Visible = true;
            pnl_header.BringToFront();
            uc_allowances.Dock = DockStyle.Fill;
            uc_allowances.BringToFront();
            deactivate_button();
            btn_allowances.BackgroundImage = Properties.Resources.btn_allowances_active;
        }

        private void btn_all_Click(object sender, EventArgs e)
        {
            hide_user_control();
            uc_all.Visible = true;
            uc_all.Dock = DockStyle.Fill;
            uc_all.BringToFront();
            deactivate_button();
            btn_all.BackgroundImage = Properties.Resources.btn_all_active;
        }

        private void btn_department_Click(object sender, EventArgs e)
        {
            hide_user_control();
            uc_department.Visible = true;
            pnl_header.BringToFront();
            uc_department.Dock = DockStyle.Fill;
            uc_department.BringToFront();
            deactivate_button();
            btn_department.BackgroundImage = Properties.Resources.btn_department_active;
        }

        private void btn_single_posting_Click(object sender, EventArgs e)
        {
            hide_user_control();
            uc_single_posting.Visible = true;
            pnl_header.BringToFront();
            uc_single_posting.Dock = DockStyle.Fill;
            uc_single_posting.BringToFront();
            deactivate_button();
            btn_single_posting.BackgroundImage = Properties.Resources.btn_single_active;
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            hide_user_control();
            uc_settings.Visible = true;
            uc_settings.Dock = DockStyle.Fill;
            uc_settings.BringToFront();
            deactivate_button();
            btn_settings.BackgroundImage = Properties.Resources.btn_settings_active;
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            //Hide and show menu panel.
            pnl_menu.BringToFront();
            pnl_menu.Visible = !pnl_menu.Visible;
        }

        /// <summary>
        /// BARRUELA, VIBIESCA
        /// WHEN THE USER CLICKS LOGOUT
        /// </summary>
        private void btn_logout_Click(object sender, EventArgs e)
        {
            pnl_menu.Visible = !pnl_menu.Visible; // HIDES THE MENU PANEL.
            // ASK THE USER FIRST FOR CONFIRMATION
            if (MessageBox.Show(Properties.Resources.str_logout_confirmation, Properties.Resources.str_program_title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Dispose(); // DISPOSES THIS FORM.
                clsProgram.programInstance.Show(); // SHOWS THE LOGIN FORM BACK TO LIFE.
            }
        }

        /// <summary>
        /// VIBIESCA
        /// WHEN THIS FORM IS CLOSED, EXECUTE THE ENTIRE PROGRAM, BY THAT I MEAN KILL THE LOGIN PROCESS AND END ALL.
        /// </summary>
        private void frmFireonPayroll_FormClosed(object sender, FormClosedEventArgs e)
        {
            clsProgram.programInstance.Dispose(); // THIS LINE WILL KILL THE programInstance OBJECT WHICH IS THE frmLogin OBJECT
        }
    }
}
