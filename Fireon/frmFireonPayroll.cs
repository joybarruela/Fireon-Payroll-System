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
    /// <summary>
    /// VIBIESCA, BARRUELA
    /// THE MAIN FORM OF THE PROGRAM.
    /// </summary>
    public partial class frmFireonPayroll : Form
    {
        /// <summary>
        /// CLASS CONSTRUCTOR.
        /// </summary>
        public frmFireonPayroll()
        {
            InitializeComponent();

            btn_dashboard.BackgroundImage = Properties.Resources.btn_dashboard_active; // DEFAULT SELECTED
            uc_dashboard.BringToFront(); // DEFAULT SELECTED

            uc_dashboard.Visible = true; // PRE HIDES THE UC ON RUNTIME
            uc_all.Visible = true; // PRE HIDES THE UC ON RUNTIME
            uc_allowances.Visible = true; // PRE HIDES THE UC ON RUNTIME
            uc_cash_advance.Visible = true; // PRE HIDES THE UC ON RUNTIME
            uc_deductions.Visible = true; // PRE HIDES THE UC ON RUNTIME
            uc_department.Visible = true; // PRE HIDES THE UC ON RUNTIME
            uc_employee.Visible = true; // PRE HIDES THE UC ON RUNTIME
            uc_holiday.Visible = true; // PRE HIDES THE UC ON RUNTIME
            uc_leave.Visible = true; // PRE HIDES THE UC ON RUNTIME
            uc_overtime.Visible = true; // PRE HIDES THE UC ON RUNTIME
            uc_settings.Visible = true; // PRE HIDES THE UC ON RUNTIME
            uc_single_posting.Visible = true; // PRE HIDES THE UC ON RUNTIME
            uc_violations.Visible = true; // PRE HIDES THE UC ON RUNTIME

            uc_dashboard.Dock = DockStyle.Fill; // PRE FILLS THE UC ON RUNTIME
            uc_all.Dock = DockStyle.Fill; // PRE FILLS THE UC ON RUNTIME
            uc_allowances.Dock = DockStyle.Fill; // PRE FILLS THE UC ON RUNTIME
            uc_cash_advance.Dock = DockStyle.Fill; // PRE FILLS THE UC ON RUNTIME
            uc_deductions.Dock = DockStyle.Fill; // PRE FILLS THE UC ON RUNTIME
            uc_department.Dock = DockStyle.Fill; // PRE FILLS THE UC ON RUNTIME
            uc_employee.Dock = DockStyle.Fill; // PRE FILLS THE UC ON RUNTIME
            uc_holiday.Dock = DockStyle.Fill; // PRE FILLS THE UC ON RUNTIME
            uc_leave.Dock = DockStyle.Fill; // PRE FILLS THE UC ON RUNTIME
            uc_overtime.Dock = DockStyle.Fill; // PRE FILLS THE UC ON RUNTIME
            uc_settings.Dock = DockStyle.Fill; // PRE FILLS THE UC ON RUNTIME
            uc_single_posting.Dock = DockStyle.Fill; // PRE FILLS THE UC ON RUNTIME
            uc_violations.Dock = DockStyle.Fill; // PRE FILLS THE UC ON RUNTIME
        }
        /// <summary>
        /// WHEN THE PROGRAM LOADS.
        /// THE PURPOSE OF THE PRE FILLS IS FOR THE PROGRAM TO DO IT EARLY BECAUSE THIS FORM IS LOADED
        /// ON THE LOGIN PHASE ALREADY, SO IT'S BETTER TO SET THE POSITIONS BEFORE IT GETS LOADED.
        /// IT IS TO KEEP VISUAL LAG.
        /// </summary>
        private void Fireon_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// BARRUELA
        /// THIS METHOD GETS CALLED WHENEVER THE USER CLICKS A BUTTON ON THE SIDEBAR.
        /// WHAT THIS DOES IS IT RESETS ALL THE BACKGROUND IMAGE OF THE BUTTONS TO ITS' UNCLICKED STATE.
        /// </summary>
        public void deactivate_button()
        {
            btn_dashboard.BackgroundImage = Properties.Resources.btn_dashboard; // RESET BUTTON BG
            btn_employee.BackgroundImage = Properties.Resources.btn_employee; // RESET BUTTON BG
            btn_leave.BackgroundImage = Properties.Resources.btn_leave; // RESET BUTTON BG
            btn_overtime.BackgroundImage = Properties.Resources.btn_overtime; // RESET BUTTON BG
            btn_holiday.BackgroundImage = Properties.Resources.btn_holiday; // RESET BUTTON BG
            btn_violations.BackgroundImage = Properties.Resources.btn_violation; // RESET BUTTON BG
            btn_settings.BackgroundImage = Properties.Resources.btn_settings; // RESET BUTTON BG
            btn_cash_advance.BackgroundImage = Properties.Resources.btn_cash_advance; // RESET BUTTON BG
            btn_allowances.BackgroundImage = Properties.Resources.btn_allowances; // RESET BUTTON BG
            btn_deductions.BackgroundImage = Properties.Resources.btn_deductions; // RESET BUTTON BG
            btn_all.BackgroundImage = Properties.Resources.btn_all; // RESET BUTTON BG
            btn_department.BackgroundImage = Properties.Resources.btn_department; // RESET BUTTON BG
            btn_single_posting.BackgroundImage = Properties.Resources.btn_single_posting; // RESET BUTTON BG
        }
        /// <summary>
        /// BARRUELA
        /// THIS METHOD IS CALLED WHENEVER THE USER CLICKS ON THE LEFT SIDEBAR.
        /// PURPOSE OF THIS IS TO HIDE ALL USER CONTROLS.
        /// </summary>
        public void hide_user_control()
        {
            //uc_all.Hide(); // HIDE THIS USER CONTROL.
            //uc_allowances.Hide(); // HIDE THIS USER CONTROL.
            //uc_cash_advance.Hide(); // HIDE THIS USER CONTROL.
            //uc_dashboard.Hide(); ; // HIDE THIS USER CONTROL.
            //uc_deductions.Hide(); // HIDE THIS USER CONTROL.
            //uc_department.Hide(); // HIDE THIS USER CONTROL.
            //uc_employee.Hide(); // HIDE THIS USER CONTROL.
            //uc_holiday.Hide(); // HIDE THIS USER CONTROL.
            //uc_leave.Hide(); // HIDE THIS USER CONTROL.
            //uc_overtime.Hide(); // HIDE THIS USER CONTROL.
            //uc_settings.Hide(); // HIDE THIS USER CONTROL.
            //uc_single_posting.Hide(); // HIDE THIS USER CONTROL.
            //uc_violations.Hide(); // HIDE THIS USER CONTROL.

            uc_all.SendToBack(); // SendToBack THIS USER CONTROL.
            uc_allowances.SendToBack(); // SendToBack THIS USER CONTROL.
            uc_cash_advance.SendToBack(); // SendToBack THIS USER CONTROL.
            uc_dashboard.SendToBack(); ; // SendToBack THIS USER CONTROL.
            uc_deductions.SendToBack(); // SendToBack THIS USER CONTROL.
            uc_department.SendToBack(); // SendToBack THIS USER CONTROL.
            uc_employee.SendToBack(); // SendToBack THIS USER CONTROL.
            uc_holiday.SendToBack(); // SendToBack THIS USER CONTROL.
            uc_leave.SendToBack(); // SendToBack THIS USER CONTROL.
            uc_overtime.SendToBack(); // SendToBack THIS USER CONTROL.
            uc_settings.SendToBack(); // SendToBack THIS USER CONTROL.
            uc_single_posting.SendToBack(); // SendToBack THIS USER CONTROL.
            uc_violations.SendToBack(); // SendToBack THIS USER CONTROL.
        }
        /// <summary>
        /// THIS METHOD GETS CALLED WHEN THE USER CLICKS THE MENU BUTTON ON THE UPPER RIGHT SIDE. (THE THREE DOTS).
        /// </summary>
        private void btn_menu_Click(object sender, EventArgs e)
        {
            pnl_menu.BringToFront(); // BRINGS THE MENU PANEL TO FRONT.
            pnl_menu.Visible = !pnl_menu.Visible; // CHANGES THE STATE OF VISIBILITY OF PANEL MENU.
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
            clsProgram.programInstance.Dispose(); // THIS LINE WILL KILL THE programInstance OBJECT WHICH IS THE frmLogin OBJECT.
        }
        #region LEFT SIDEBAR CLICK EVENTS
        /// <summary>
        /// BARRUELA, VIBIESCA
        /// WHEN THE LEFT SIDE BAR BUTTONS ARE CLICKED. SAME GOES WITH ALL OTHER 12 BUTTONS BELOW.
        /// </summary>
        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            deactivate_button(); // DEACTIVATE BUTTON RESETS ALL THE BG IMAGE OF LEFT SIDEBAR BUTTONS.
            uc_dashboard.BringToFront(); // BRING TO FRONT.
            btn_dashboard.BackgroundImage = Properties.Resources.btn_dashboard_active; // ONLY CHANGE THE CURRENT SELECTED BUTTON.
        }
        private void btn_employee_Click(object sender, EventArgs e)
        {
            deactivate_button();
            uc_employee.BringToFront();
            btn_employee.BackgroundImage = Properties.Resources.btn_employee_active;
        }
        private void btn_leave_Click(object sender, EventArgs e)
        {
            deactivate_button();
            uc_leave.BringToFront();
            btn_leave.BackgroundImage = Properties.Resources.btn_leave_active;
        }
        private void btn_overtime_Click(object sender, EventArgs e)
        {
            deactivate_button();
            uc_overtime.BringToFront();
            btn_overtime.BackgroundImage = Properties.Resources.btn_overtime_active;
        }
        private void btn_holiday_Click(object sender, EventArgs e)
        {
            deactivate_button();
            uc_holiday.BringToFront();
            btn_holiday.BackgroundImage = Properties.Resources.btn_holiday_active;
        }
        private void btn_violations_Click(object sender, EventArgs e)
        {
            deactivate_button();
            uc_violations.BringToFront();
            btn_violations.BackgroundImage = Properties.Resources.btn_violations_active;
        }
        private void btn_cash_advance_Click(object sender, EventArgs e)
        {
            deactivate_button();
            uc_cash_advance.BringToFront();
            btn_cash_advance.BackgroundImage = Properties.Resources.btn_cash_advance_active;
        }
        private void btn_deductions_Click(object sender, EventArgs e)
        {
            deactivate_button();
            uc_deductions.BringToFront();
            btn_deductions.BackgroundImage = Properties.Resources.btn_deductions_active;
        }
        private void btn_allowances_Click(object sender, EventArgs e)
        {
            deactivate_button();
            uc_allowances.BringToFront();
            btn_allowances.BackgroundImage = Properties.Resources.btn_allowances_active;
        }
        private void btn_all_Click(object sender, EventArgs e)
        {
            deactivate_button();
            uc_all.BringToFront();
            btn_all.BackgroundImage = Properties.Resources.btn_all_active;
        }
        private void btn_department_Click(object sender, EventArgs e)
        {
            deactivate_button();
            uc_department.BringToFront();
            btn_department.BackgroundImage = Properties.Resources.btn_department_active;
        }
        private void btn_single_posting_Click(object sender, EventArgs e)
        {
            deactivate_button();
            uc_single_posting.BringToFront();
            btn_single_posting.BackgroundImage = Properties.Resources.btn_single_active;
        }
        private void btn_settings_Click(object sender, EventArgs e)
        {
            deactivate_button();
            uc_settings.BringToFront();
            btn_settings.BackgroundImage = Properties.Resources.btn_settings_active;
        }
        //private void btn_dashboard_Click(object sender, EventArgs e) // BACKUP
        //{
        //    hide_user_control(); // HIDES ALL THE USER CONTROL.
        //    uc_dashboard.Visible = true; // ONLY SHOW THE DASHBOARD USER CONTROL.
        //    uc_dashboard.Dock = DockStyle.Fill; // TO FIT ON THE WINDOW.
        //    uc_dashboard.BringToFront(); // BRING TO FRONT.
        //    deactivate_button(); // DEACTIVATE BUTTON RESETS ALL THE BG IMAGE OF LEFT SIDEBAR BUTTONS.
        //    btn_dashboard.BackgroundImage = Properties.Resources.btn_dashboard_active; // ONLY CHANGE THE CURRENT SELECTED BUTTON.
        //}
        #endregion
    }
}
