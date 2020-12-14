using System;
// FOR READING THE PROCESS OBJECT
using System.Windows.Forms;

namespace Fireon
{
    /// <summary>
    /// VIBIESCA, BARRUELA
    /// THE MAIN FORM OF THE PROGRAM.
    /// </summary>
    public partial class frmFireonPayroll : Form
    {
        #region CUSTOM BUILT FUNCTIONS
        /// <summary>
        /// THIS METHOD GETS CALLED WHENEVER THE USER CLICKS A BUTTON ON THE SIDEBAR.
        /// WHAT THIS DOES IS IT RESETS ALL THE BACKGROUND IMAGE OF THE BUTTONS TO ITS' UNCLICKED STATE.
        /// </summary>
        public void deactivate_button()
        {
            btnDashboard.BackgroundImage = Properties.Resources.btnDashboard; // RESET BUTTON BG
            btnEmployee.BackgroundImage = Properties.Resources.btnEmployee; // RESET BUTTON BG
            btnLeave.BackgroundImage = Properties.Resources.btnLeave; // RESET BUTTON BG
            btnOvertime.BackgroundImage = Properties.Resources.btnOvertime; // RESET BUTTON BG
            btnHoliday.BackgroundImage = Properties.Resources.btnHoliday; // RESET BUTTON BG
            btnViolations.BackgroundImage = Properties.Resources.btnViolation; // RESET BUTTON BG
            btnSettings.BackgroundImage = Properties.Resources.btnSettings; // RESET BUTTON BG
            btnCashAdvance.BackgroundImage = Properties.Resources.btnCashAdvance; // RESET BUTTON BG
            btnAllowances.BackgroundImage = Properties.Resources.btnAllowance; // RESET BUTTON BG
            btnDeductions.BackgroundImage = Properties.Resources.btnDeduction; // RESET BUTTON BG
            btnAll.BackgroundImage = Properties.Resources.btnAll; // RESET BUTTON BG
            btnDepartment.BackgroundImage = Properties.Resources.btnDepartment; // RESET BUTTON BG
            btnSinglePosting.BackgroundImage = Properties.Resources.btnSinglePosting; // RESET BUTTON BG
        }
        /// <summary>
        /// CALL THIS TO SHOW ITEMS ON THE DASHBOARD
        /// </summary>
        public void displayUserControl(string name)
        {
            // CLOSES MENU THREE DOTS PANEL
            pnlMenu.Visible = false;
            switch (name)
            {
                case "Dashboard":
                    if (this.Text != "Fireon Payroll System | Dashboard")
                    {
                        pnlSelected.Controls.Clear(); // CLEARS ALL CHILDREN OF pnl_selected
                        deactivate_button(); // RESETS ALL BUTTON TO EMPTY STATE
                        btnDashboard.BackgroundImage = Properties.Resources.btnDashboardActive; // SET BUTTON ACTIVE
                        ucDashboard ucDashboard = new ucDashboard(); // CREATES A NEW UserControl
                        ucDashboard.Parent = pnlSelected; // SET PARENT OF NEW DASHBOARD
                        ucDashboard.Dock = DockStyle.Fill; // SET THE DOCKSTYLE
                        this.Text = "Fireon Payroll System | Dashboard";
                        break;                    
                    }
                    else { break; };

                case "Employee":
                    if (this.Text != "Fireon Payroll System | Employee")
                    {
                        pnlSelected.Controls.Clear(); // CLEARS ALL CHILDREN OF pnl_selected
                        deactivate_button(); // RESETS ALL BUTTON TO EMPTY STATE
                        btnEmployee.BackgroundImage = Properties.Resources.btnEmployeeActive; // SET BUTTON ACTIVE
                        ucEmployee ucEmployee = new ucEmployee(); // CREATES A NEW UserControl
                        ucEmployee.Parent = pnlSelected; // SET PARENT OF NEW DASHBOARD
                        ucEmployee.Dock = DockStyle.Fill; // SET THE DOCKSTYLE
                        this.Text = "Fireon Payroll System | Employee";
                        break;                    
                    }
                    else { break; };

                case "Leave":
                    if (this.Text != "Fireon Payroll System | Leave")
                    {
                        pnlSelected.Controls.Clear(); // CLEARS ALL CHILDREN OF pnl_selected
                        deactivate_button(); // RESETS ALL BUTTON TO EMPTY STATE
                        btnLeave.BackgroundImage = Properties.Resources.btnLeaveActive; // SET BUTTON ACTIVE
                        ucLeave ucLeave = new ucLeave(); // CREATES A NEW UserControl
                        ucLeave.Parent = pnlSelected; // SET PARENT OF NEW DASHBOARD
                        ucLeave.Dock = DockStyle.Fill; // SET THE DOCKSTYLE
                        this.Text = "Fireon Payroll System | Leave";
                        break;
                    }
                    else { break; };

                //case "Overtime":
                //    if (this.Text != "Fireon Payroll System | Overtime")
                //    {
                //        pnl_selected.Controls.Clear(); // CLEARS ALL CHILDREN OF pnl_selected
                //        deactivate_button(); // RESETS ALL BUTTON TO EMPTY STATE
                //        btn_overtime.BackgroundImage = Properties.Resources.btn_overtime_active; // SET BUTTON ACTIVE
                //        ucOvertime ucOvertime = new ucOvertime(); // CREATES A NEW UserControl
                //        ucOvertime.Parent = pnl_selected; // SET PARENT OF NEW DASHBOARD
                //        ucOvertime.Dock = DockStyle.Fill; // SET THE DOCKSTYLE
                //        this.Text = "Fireon Payroll System | Overtime";
                //        break;
                //    }
                //    else { break; };

                //case "Holiday":
                //    if (this.Text != "Fireon Payroll System | Holiday")
                //    {
                //        pnl_selected.Controls.Clear(); // CLEARS ALL CHILDREN OF pnl_selected
                //        deactivate_button(); // RESETS ALL BUTTON TO EMPTY STATE
                //        btn_holiday.BackgroundImage = Properties.Resources.btn_holiday_active; // SET BUTTON ACTIVE
                //        ucHoliday ucHoliday = new ucHoliday(); // CREATES A NEW UserControl
                //        ucHoliday.Parent = pnl_selected; // SET PARENT OF NEW DASHBOARD
                //        ucHoliday.Dock = DockStyle.Fill; // SET THE DOCKSTYLE
                //        this.Text = "Fireon Payroll System | Holiday";
                //        break;
                //    }
                //    else { break; };

                //case "Violation":
                //    if (this.Text != "Fireon Payroll System | Violation")
                //    {
                //        pnl_selected.Controls.Clear(); // CLEARS ALL CHILDREN OF pnl_selected
                //        deactivate_button(); // RESETS ALL BUTTON TO EMPTY STATE
                //        btn_violations.BackgroundImage = Properties.Resources.btn_violations_active; // SET BUTTON ACTIVE
                //        ucViolations ucViolations = new ucViolations(); // CREATES A NEW UserControl
                //        ucViolations.Parent = pnl_selected; // SET PARENT OF NEW DASHBOARD
                //        ucViolations.Dock = DockStyle.Fill; // SET THE DOCKSTYLE
                //        this.Text = "Fireon Payroll System | Violation";
                //        break;
                //    }
                //    else { break; };

                //case "Cash Advance":
                //    if (this.Text != "Fireon Payroll System | Cash Advance")
                //    {
                //        pnl_selected.Controls.Clear(); // CLEARS ALL CHILDREN OF pnl_selected
                //        deactivate_button(); // RESETS ALL BUTTON TO EMPTY STATE
                //        btn_cash_advance.BackgroundImage = Properties.Resources.btn_cash_advance_active; // SET BUTTON ACTIVE
                //        ucCashAdvance ucCashAdvance = new ucCashAdvance(); // CREATES A NEW UserControl
                //        ucCashAdvance.Parent = pnl_selected; // SET PARENT OF NEW DASHBOARD
                //        ucCashAdvance.Dock = DockStyle.Fill; // SET THE DOCKSTYLE
                //        this.Text = "Fireon Payroll System | Cash Advance";
                //        break;
                //    }
                //    else { break; };

                //case "Deduction":
                //    if (this.Text != "Fireon Payroll System | Deduction")
                //    {
                //        pnl_selected.Controls.Clear(); // CLEARS ALL CHILDREN OF pnl_selected
                //        deactivate_button(); // RESETS ALL BUTTON TO EMPTY STATE
                //        btn_deductions.BackgroundImage = Properties.Resources.btn_deductions_active; // SET BUTTON ACTIVE
                //        ucDeductions ucDeductions = new ucDeductions(); // CREATES A NEW UserControl
                //        ucDeductions.Parent = pnl_selected; // SET PARENT OF NEW DASHBOARD
                //        ucDeductions.Dock = DockStyle.Fill; // SET THE DOCKSTYLE
                //        this.Text = "Fireon Payroll System | Deduction";
                //        break;
                //    }
                //    else { break; };

                //case "Allowance":
                //    if (this.Text != "Fireon Payroll System | Allowance")
                //    {
                //        pnl_selected.Controls.Clear(); // CLEARS ALL CHILDREN OF pnl_selected
                //        deactivate_button(); // RESETS ALL BUTTON TO EMPTY STATE
                //        btn_allowances.BackgroundImage = Properties.Resources.btn_allowances_active; // SET BUTTON ACTIVE
                //        ucAllowances ucAllowances = new ucAllowances(); // CREATES A NEW UserControl
                //        ucAllowances.Parent = pnl_selected; // SET PARENT OF NEW DASHBOARD
                //        ucAllowances.Dock = DockStyle.Fill; // SET THE DOCKSTYLE
                //        this.Text = "Fireon Payroll System | Allowance";
                //        break;
                //    }
                //    else { break; };

                //case "All":
                //    if (this.Text != "Fireon Payroll System | All")
                //    {
                //        pnl_selected.Controls.Clear(); // CLEARS ALL CHILDREN OF pnl_selected
                //        deactivate_button(); // RESETS ALL BUTTON TO EMPTY STATE
                //        btn_all.BackgroundImage = Properties.Resources.btn_all_active; // SET BUTTON ACTIVE
                //        ucAll ucAll = new ucAll(); // CREATES A NEW UserControl
                //        ucAll.Parent = pnl_selected; // SET PARENT OF NEW DASHBOARD
                //        ucAll.Dock = DockStyle.Fill; // SET THE DOCKSTYLE
                //        this.Text = "Fireon Payroll System | All";
                //        break;
                //    }
                //    else { break; };

                //case "Department":
                //    if (this.Text != "Fireon Payroll System | Department")
                //    {
                //        pnl_selected.Controls.Clear(); // CLEARS ALL CHILDREN OF pnl_selected
                //        deactivate_button(); // RESETS ALL BUTTON TO EMPTY STATE
                //        btn_department.BackgroundImage = Properties.Resources.btn_department_active; // SET BUTTON ACTIVE
                //        ucDepartment ucDepartment = new ucDepartment(); // CREATES A NEW UserControl
                //        ucDepartment.Parent = pnl_selected; // SET PARENT OF NEW DASHBOARD
                //        ucDepartment.Dock = DockStyle.Fill; // SET THE DOCKSTYLE
                //        this.Text = "Fireon Payroll System | Department";
                //        break;
                //    }
                //    else { break; };

                //case "Single Posting":
                //    if (this.Text != "Fireon Payroll System | Single Posting")
                //    {
                //        pnl_selected.Controls.Clear(); // CLEARS ALL CHILDREN OF pnl_selected
                //        deactivate_button(); // RESETS ALL BUTTON TO EMPTY STATE
                //        btn_single_posting.BackgroundImage = Properties.Resources.btn_single_active; // SET BUTTON ACTIVE
                //        ucSinglePosting ucSinglePosting = new ucSinglePosting(); // CREATES A NEW UserControl
                //        ucSinglePosting.Parent = pnl_selected; // SET PARENT OF NEW DASHBOARD
                //        ucSinglePosting.Dock = DockStyle.Fill; // SET THE DOCKSTYLE
                //        this.Text = "Fireon Payroll System | Single Posting";
                //        break;
                //    }
                //    else { break; };

                //case "Setting":
                //    if (this.Text != "Fireon Payroll System | Setting")
                //    {
                //        pnl_selected.Controls.Clear(); // CLEARS ALL CHILDREN OF pnl_selected
                //        deactivate_button(); // RESETS ALL BUTTON TO EMPTY STATE
                //        btn_settings.BackgroundImage = Properties.Resources.btn_settings_active; // SET BUTTON ACTIVE
                //        ucSettings ucSettings = new ucSettings(); // CREATES A NEW UserControl
                //        ucSettings.Parent = pnl_selected; // SET PARENT OF NEW DASHBOARD
                //        ucSettings.Dock = DockStyle.Fill; // SET THE DOCKSTYLE
                //        this.Text = "Fireon Payroll System | Setting";
                //        break;
                //    }
                //    else { break; };

                default:
                    pnlSelected.Controls.Clear(); // CLEARS ALL CHILDREN OF pnl_selected
                    deactivate_button(); // RESETS ALL BUTTON TO EMPTY STATE
                    btnDashboard.BackgroundImage = Properties.Resources.btnDashboardActive; // SET BUTTON ACTIVE
                    ucDashboard ucDashboardDefault = new ucDashboard(); // CREATES A NEW UserControl
                    ucDashboardDefault.Parent = pnlSelected; // SET PARENT OF NEW DASHBOARD
                    ucDashboardDefault.Dock = DockStyle.Fill; // SET THE DOCKSTYLE
                    this.Text = "Fireon Payroll System | Dashboard";
                    break;  
            }
        }
        #endregion
        #region TRIGGERS AND EVENTS
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
        /// WHEN THIS FORM IS CLOSED, EXECUTE THE ENTIRE PROGRAM, BY THAT I MEAN KILL THE LOGIN PROCESS AND END ALL.
        /// </summary>
        private void frmFireonPayroll_FormClosed(object sender, FormClosedEventArgs e)
        {
            clsProgram.programInstance.Dispose(); // THIS LINE WILL KILL THE programInstance OBJECT WHICH IS THE frmLogin OBJECT.
        }
        /// <summary>
        /// THIS METHOD GETS CALLED WHENEVER THE USER RESIZES THE FORM (FOR RESPONSIVENESS)
        /// </summary>
        private void frmFireonPayroll_SizeChanged(object sender, EventArgs e)
        {
            int formDefaultHeight = 680;
            int picbFireonHeight = 50;
            int pnlSeparatorHeight = 10;

            if (this.Size.Height > formDefaultHeight)
            {
                picbFireon.Height = picbFireonHeight + ((this.Size.Height - formDefaultHeight) / 3);
                pnlSeparator0.Height = pnlSeparatorHeight + ((this.Size.Height - formDefaultHeight) / 5);
                pnlSeparator1.Height = pnlSeparatorHeight + ((this.Size.Height - formDefaultHeight) / 5);
            }
            else
            {
                picbFireon.Height = picbFireonHeight - ((this.Size.Height - formDefaultHeight) / 3);
                pnlSeparator0.Height = pnlSeparatorHeight - ((this.Size.Height - formDefaultHeight) / 5);
                pnlSeparator1.Height = pnlSeparatorHeight - ((this.Size.Height - formDefaultHeight) / 5);
            }
        }
        #endregion
        #region MENU ITEMS CLICK EVENTS
        /// <summary>
        /// THIS METHOD GETS CALLED WHEN THE USER CLICKS THE MENU BUTTON ON THE UPPER RIGHT SIDE. (THE THREE DOTS).
        /// </summary>
        private void btn_menu_Click(object sender, EventArgs e)
        {
            pnlMenu.BringToFront(); // BRINGS THE MENU PANEL TO FRONT.
            pnlMenu.Visible = !pnlMenu.Visible; // CHANGES THE STATE OF VISIBILITY OF PANEL MENU.
        }
        /// <summary>
        /// WHEN THE USER CLICKS LOGOUT
        /// </summary>
        private void btn_logout_Click(object sender, EventArgs e)
        {
            pnlMenu.Visible = !pnlMenu.Visible; // HIDES THE MENU PANEL.
            // ASK THE USER FIRST FOR CONFIRMATION
            if (MessageBox.Show(Properties.Resources.msg_logout_confirmation, Properties.Resources.str_program_title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Dispose(); // DISPOSES THIS FORM.
                clsProgram.programInstance.Show(); // SHOWS THE LOGIN FORM BACK TO LIFE.
            }
        }
        #endregion
        #region LEFT SIDEBAR CLICK EVENTS
        /// <summary>
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
            //displayUserControl("Overtime");
        }
        private void btn_holiday_Click(object sender, EventArgs e)
        {
            //displayUserControl("Holiday");
        }
        private void btn_violations_Click(object sender, EventArgs e)
        {
            //displayUserControl("Violation");
        }
        private void btn_cash_advance_Click(object sender, EventArgs e)
        {
            //displayUserControl("Cash Advance");
        }
        private void btn_deductions_Click(object sender, EventArgs e)
        {
            //displayUserControl("Deduction");
        }
        private void btn_allowances_Click(object sender, EventArgs e)
        {
            //displayUserControl("Allowance");
        }
        private void btn_all_Click(object sender, EventArgs e)
        {
            //displayUserControl("All");
        }
        private void btn_department_Click(object sender, EventArgs e)
        {
            //displayUserControl("Department");
        }
        private void btn_single_posting_Click(object sender, EventArgs e)
        {
            //displayUserControl("Single Posting");
        }
        private void btn_settings_Click(object sender, EventArgs e)
        {
            //displayUserControl("Setting");
        }
        #endregion
    }
}
