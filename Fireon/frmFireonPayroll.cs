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
            // CREATE ALL ITEMS INSIDE THIS FORM
            InitializeComponent();

            // DISPLAY DASHBOARD FIRST
            displayUserControl("Dashboard");
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
        /// VIBIESCA
        /// CALL THIS TO SHOW ITEMS ON THE DASHBOARD
        /// </summary>
        public void displayUserControl(string name)
        {
            switch (name)
            {
                case "Dashboard":
                    if (this.Text != "Fireon Payroll System | Dashboard")
                    {
                        pnl_selected.Controls.Clear(); // CLEARS ALL CHILDREN OF pnl_selected
                        deactivate_button(); // RESETS ALL BUTTON TO EMPTY STATE
                        btn_dashboard.BackgroundImage = Properties.Resources.btn_dashboard_active; // SET BUTTON ACTIVE
                        ucDashboard ucDashboard = new ucDashboard(); // CREATES A NEW UserControl
                        ucDashboard.Parent = pnl_selected; // SET PARENT OF NEW DASHBOARD
                        ucDashboard.Dock = DockStyle.Fill; // SET THE DOCKSTYLE
                        this.Text = "Fireon Payroll System | Dashboard";
                        break;                    
                    }
                    else { break; };

                case "Employee":
                    if (this.Text != "Fireon Payroll System | Employee")
                    {
                        pnl_selected.Controls.Clear(); // CLEARS ALL CHILDREN OF pnl_selected
                        deactivate_button(); // RESETS ALL BUTTON TO EMPTY STATE
                        btn_employee.BackgroundImage = Properties.Resources.btn_employee_active; // SET BUTTON ACTIVE
                        ucEmployee ucEmployee = new ucEmployee(); // CREATES A NEW UserControl
                        ucEmployee.Parent = pnl_selected; // SET PARENT OF NEW DASHBOARD
                        ucEmployee.Dock = DockStyle.Fill; // SET THE DOCKSTYLE
                        this.Text = "Fireon Payroll System | Employee";
                        break;                    
                    }
                    else { break; };

                case "Leave":
                    if (this.Text != "Fireon Payroll System | Leave")
                    {
                        pnl_selected.Controls.Clear(); // CLEARS ALL CHILDREN OF pnl_selected
                        deactivate_button(); // RESETS ALL BUTTON TO EMPTY STATE
                        btn_leave.BackgroundImage = Properties.Resources.btn_leave_active; // SET BUTTON ACTIVE
                        ucLeave ucLeave = new ucLeave(); // CREATES A NEW UserControl
                        ucLeave.Parent = pnl_selected; // SET PARENT OF NEW DASHBOARD
                        ucLeave.Dock = DockStyle.Fill; // SET THE DOCKSTYLE
                        this.Text = "Fireon Payroll System | Leave";
                        break;
                    }
                    else { break; };











                default:
                    break;
            }
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
            displayUserControl("Dashboard");
        }
        private void btn_employee_Click(object sender, EventArgs e)
        {
            displayUserControl("Employee");
        }
        private void btn_leave_Click(object sender, EventArgs e)
        {
            displayUserControl("Leave");
        }
        private void btn_overtime_Click(object sender, EventArgs e)
        {
        }
        private void btn_holiday_Click(object sender, EventArgs e)
        {
        }
        private void btn_violations_Click(object sender, EventArgs e)
        {
        }
        private void btn_cash_advance_Click(object sender, EventArgs e)
        {
        }
        private void btn_deductions_Click(object sender, EventArgs e)
        {
        }
        private void btn_allowances_Click(object sender, EventArgs e)
        {
        }
        private void btn_all_Click(object sender, EventArgs e)
        {
        }
        private void btn_department_Click(object sender, EventArgs e)
        {
        }
        private void btn_single_posting_Click(object sender, EventArgs e)
        {
        }
        private void btn_settings_Click(object sender, EventArgs e)
        {
        }
        #endregion

        /// <summary>
        /// VIBIESCA
        /// THIS METHOD GETS CALLED WHENVER THE USER RESIZES THE FORM (FOR RESPONSIVENESS)
        /// </summary>
        private void frmFireonPayroll_SizeChanged(object sender, EventArgs e)
        {
            int formDefaultHeight = 680;
            int picbFireonHeight = 50;
            int pnlSeparatorHeight = 10;

            if (this.Size.Height > formDefaultHeight)
            {
                picb_fireon.Height = picbFireonHeight + ((this.Size.Height - formDefaultHeight) / 3);
                pnl_separator_0.Height = pnlSeparatorHeight + ((this.Size.Height - formDefaultHeight) / 5);
                pnl_separator_1.Height = pnlSeparatorHeight + ((this.Size.Height - formDefaultHeight) / 5);
            }
            else
            {
                picb_fireon.Height = picbFireonHeight - ((this.Size.Height - formDefaultHeight) / 3);
                pnl_separator_0.Height = pnlSeparatorHeight - ((this.Size.Height - formDefaultHeight) / 5);
                pnl_separator_1.Height = pnlSeparatorHeight - ((this.Size.Height - formDefaultHeight) / 5);
            }
        }
    }
}
