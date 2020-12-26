using Fireon.Classes;
using Fireon.UserControls;
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
        clsFireonFunctions ff = new clsFireonFunctions();
        clsFileOperations fo = new clsFileOperations();
        #region TRIGGERS AND EVENTS
        /// <summary>
        /// CLASS CONSTRUCTOR
        /// </summary>
        public frmFireonPayroll()
        {
            InitializeComponent(); // CREATE ALL ITEMS INSIDE THIS FORM
            displayUserControl("Dashboard"); // DISPLAY DASHBOARD FIRST
            lblGreeting.Text = Properties.Resources.str_dashboard_greetings;
            lblGreeting.Text = String.Concat(Properties.Resources.str_dashboard_greetings, Properties.Settings.Default.lastLoggedInUsername);
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
        private void btnMenu_Click(object sender, EventArgs e)
        {
            pnlMenu.BringToFront(); // BRINGS THE MENU PANEL TO FRONT
            pnlMenu.Visible = !pnlMenu.Visible; // CHANGES THE STATE OF VISIBILITY OF PANEL MENU
        }
        /// <summary>
        /// WHEN THE USER CLICKS LOGOUT
        /// </summary>
        private void btn_logout_Click(object sender, EventArgs e)
        {
            pnlMenu.Visible = !pnlMenu.Visible; // HIDES THE MENU PANEL
            // ASK THE USER FIRST FOR CONFIRMATION
            if (MessageBox.Show(Properties.Resources.msg_logout_confirmation, Properties.Resources.str_program_title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                this.Dispose(); // DISPOSES THIS FORM
                clsProgram.programInstance.Show(); // SHOWS THE LOGIN FORM BACK TO LIFE
            }
        }
        #endregion
        #region LEFT SIDEBAR CLICK EVENTS
        /// <summary>
        /// WHEN THE LEFT SIDE BAR BUTTONS ARE CLICKED. SAME GOES WITH ALL OTHER 12 BUTTONS BELOW.
        /// </summary>
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            displayUserControl("Dashboard");
        }
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            displayUserControl("Employee");
        }
        private void btnLeave_Click(object sender, EventArgs e)
        {
            displayUserControl("Leave");
        }
        private void btnOvertime_Click(object sender, EventArgs e)
        {
            displayUserControl("Overtime");
        }
        private void btnHoliday_Click(object sender, EventArgs e)
        {
            displayUserControl("Holiday");
        }
        private void btnViolation_Click(object sender, EventArgs e)
        {
            displayUserControl("Violation");
        }
        private void btnCashAdvance_Click(object sender, EventArgs e)
        {
            displayUserControl("Cash Advance");
        }
        private void btnDeduction_Click(object sender, EventArgs e)
        {
            displayUserControl("Deduction");
        }
        private void btnAllowance_Click(object sender, EventArgs e)
        {
            displayUserControl("Allowance");
        }
        private void btnAll_Click(object sender, EventArgs e)
        {
            //displayUserControl("All");
        }
        private void btnDepartment_Click(object sender, EventArgs e)
        {
            //displayUserControl("Department");
        }
        private void btnSinglePosting_Click(object sender, EventArgs e)
        {
            //displayUserControl("Single Posting");
        }
        private void btnSettings_Click(object sender, EventArgs e)
        {
            displayUserControl("Settings");
        }
        #endregion
        #region CUSTOM BUILT FUNCTIONS
        /// <summary>
        /// THIS METHOD GETS CALLED WHENEVER THE USER CLICKS A BUTTON ON THE SIDEBAR
        /// WHAT THIS DOES IS IT RESETS ALL THE BACKGROUND IMAGE OF THE BUTTONS TO ITS' UNCLICKED STATE
        /// </summary>
        public void setActive(String mode)
        {
            btnDashboard.BackgroundImage = Properties.Resources.btnDashboard; // RESET BUTTON BG
            btnEmployee.BackgroundImage = Properties.Resources.btnEmployee; // RESET BUTTON BG
            btnLeave.BackgroundImage = Properties.Resources.btnLeave; // RESET BUTTON BG
            btnOvertime.BackgroundImage = Properties.Resources.btnOvertime; // RESET BUTTON BG
            btnHoliday.BackgroundImage = Properties.Resources.btnHoliday; // RESET BUTTON BG
            btnViolation.BackgroundImage = Properties.Resources.btnViolation; // RESET BUTTON BG
            btnSettings.BackgroundImage = Properties.Resources.btnSettings; // RESET BUTTON BG
            btnCashAdvance.BackgroundImage = Properties.Resources.btnCashAdvance; // RESET BUTTON BG
            btnAllowance.BackgroundImage = Properties.Resources.btnAllowance; // RESET BUTTON BG
            btnDeduction.BackgroundImage = Properties.Resources.btnDeduction; // RESET BUTTON BG
            btnAll.BackgroundImage = Properties.Resources.btnAll; // RESET BUTTON BG
            btnDepartment.BackgroundImage = Properties.Resources.btnDepartment; // RESET BUTTON BG
            btnSinglePosting.BackgroundImage = Properties.Resources.btnSinglePosting; // RESET BUTTON BG

            switch (mode)
            {
                case "Fireon Payroll System | Dashboard":
                    btnDashboard.BackgroundImage = Properties.Resources.btnDashboardActive; // SET BUTTON ACTIVE
                    this.Text = "Fireon Payroll System | Dashboard";
                    break;
                case "Fireon Payroll System | Employee":
                    btnEmployee.BackgroundImage = Properties.Resources.btnEmployeeActive; // SET BUTTON ACTIVE
                    this.Text = "Fireon Payroll System | Employee";
                    break;
                case "Fireon Payroll System | Leave":
                    btnLeave.BackgroundImage = Properties.Resources.btnLeaveActive; // SET BUTTON ACTIVE
                    this.Text = "Fireon Payroll System | Leave";
                    break;
                case "Fireon Payroll System | Overtime":
                    btnOvertime.BackgroundImage = Properties.Resources.btnOvertimeActive; // SET BUTTON ACTIVE
                    this.Text = "Fireon Payroll System | Overtime";
                    break;
                case "Fireon Payroll System | Holiday":
                    btnHoliday.BackgroundImage = Properties.Resources.btnHolidayActive; // SET BUTTON ACTIVE
                    this.Text = "Fireon Payroll System | Holiday";
                    break;
                case "Fireon Payroll System | Violation":
                    btnViolation.BackgroundImage = Properties.Resources.btnViolationActive; // SET BUTTON ACTIVE
                    this.Text = "Fireon Payroll System | Violation";
                    break;
                case "Fireon Payroll System | Cash Advance":
                    btnCashAdvance.BackgroundImage = Properties.Resources.btnCashAdvanceActive; // SET BUTTON ACTIVE
                    this.Text = "Fireon Payroll System | Cash Advance";
                    break;
                case "Fireon Payroll System | Deduction":
                    btnDeduction.BackgroundImage = Properties.Resources.btnDeductionActive; // SET BUTTON ACTIVE
                    this.Text = "Fireon Payroll System | Deduction";
                    break;
                case "Fireon Payroll System | Allowance":
                    btnAllowance.BackgroundImage = Properties.Resources.btnAllowanceActive; // SET BUTTON ACTIVE
                    this.Text = "Fireon Payroll System | Allowance";
                    break;
                case "Fireon Payroll System | All":
                    btnAll.BackgroundImage = Properties.Resources.btnAllActive; // SET BUTTON ACTIVE
                    this.Text = "Fireon Payroll System | All";
                    break;
                case "Fireon Payroll System | Department":
                    btnDepartment.BackgroundImage = Properties.Resources.btnDepartmentActive; // SET BUTTON ACTIVE
                    this.Text = "Fireon Payroll System | Department";
                    break;
                case "Fireon Payroll System | Single Posting":
                    btnSinglePosting.BackgroundImage = Properties.Resources.btnSinglePostingActive; // SET BUTTON ACTIVE
                    this.Text = "Fireon Payroll System | Single Posting";
                    break;
                case "Fireon Payroll System | Settings":
                    btnSettings.BackgroundImage = Properties.Resources.btnSettingsActive; // SET BUTTON ACTIVE
                    this.Text = "Fireon Payroll System | Settings";
                    break;
            }



        }
        /// <summary>
        /// CALL THIS TO SHOW ITEMS ON THE DASHBOARD
        /// </summary>
        public void displayUserControl(string mode)
        {
            // CLOSES MENU THREE DOTS PANEL
            pnlMenu.Visible = false;
            switch (mode)
            {
                case "Dashboard":
                    if (this.Text != "Fireon Payroll System | Dashboard")
                    {
                        ff.displayUserControl(pnlSelected, new ucDashboard());
                        setActive("Fireon Payroll System | Dashboard");
                        break;
                    }
                    else { break; };

                case "Employee":
                    if (this.Text != "Fireon Payroll System | Employee")
                    {
                        ff.displayUserControl(pnlSelected, new ucEmployee());
                        setActive("Fireon Payroll System | Employee");
                        break;
                    }
                    else { break; };

                case "Leave":
                    if (this.Text != "Fireon Payroll System | Leave")
                    {
                        ff.displayUserControl(pnlSelected, new ucLeave());
                        setActive("Fireon Payroll System | Leave");
                        break;
                    }
                    else { break; };

                case "Overtime":
                    if (this.Text != "Fireon Payroll System | Overtime")
                    {
                        ff.displayUserControl(pnlSelected, new ucOvertime());
                        setActive("Fireon Payroll System | Overtime");
                        break;
                    }
                    else { break; };

                case "Holiday":
                    if (this.Text != "Fireon Payroll System | Holiday")
                    {
                        ff.displayUserControl(pnlSelected, new ucHoliday());
                        setActive("Fireon Payroll System | Holiday");
                        break;
                    }
                    else { break; };

                case "Violation":
                    if (this.Text != "Fireon Payroll System | Violation")
                    {
                        ff.displayUserControl(pnlSelected, new ucViolation());
                        setActive("Fireon Payroll System | Violation");
                        break;
                    }
                    else { break; };

                case "Cash Advance":
                    if (this.Text != "Fireon Payroll System | Cash Advance")
                    {
                        ff.displayUserControl(pnlSelected, new ucCashAdvance());
                        setActive("Fireon Payroll System | Cash Advance");
                        break;
                    }
                    else { break; };

                case "Deduction":
                    if (this.Text != "Fireon Payroll System | Deduction")
                    {
                        ff.displayUserControl(pnlSelected, new ucDeduction());
                        setActive("Fireon Payroll System | Deduction");
                        break;
                    }
                    else { break; };

                case "Allowance":
                    if (this.Text != "Fireon Payroll System | Allowance")
                    {
                        ff.displayUserControl(pnlSelected, new ucAllowance());
                        setActive("Fireon Payroll System | Allowance");
                        break;
                    }
                    else { break; };

                //case "All":
                //    if (this.Text != "Fireon Payroll System | All")
                //    {
                //        pnl_selected.Controls.Clear(); // CLEARS ALL CHILDREN OF pnl_selected
                //        setActive(); // RESETS ALL BUTTON TO EMPTY STATE
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
                //        setActive(); // RESETS ALL BUTTON TO EMPTY STATE
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
                //        setActive(); // RESETS ALL BUTTON TO EMPTY STATE
                //        btn_single_posting.BackgroundImage = Properties.Resources.btn_single_active; // SET BUTTON ACTIVE
                //        ucSinglePosting ucSinglePosting = new ucSinglePosting(); // CREATES A NEW UserControl
                //        ucSinglePosting.Parent = pnl_selected; // SET PARENT OF NEW DASHBOARD
                //        ucSinglePosting.Dock = DockStyle.Fill; // SET THE DOCKSTYLE
                //        this.Text = "Fireon Payroll System | Single Posting";
                //        break;
                //    }
                //    else { break; };

                case "Settings":
                    if (this.Text != "Fireon Payroll System | Settings")
                    {
                        ff.displayUserControl(pnlSelected, new ucSettings());
                        setActive("Fireon Payroll System | Settings");
                        break;
                    }
                    else { break; };

                default:
                    ff.displayUserControl(pnlSelected, new ucDashboard());
                    setActive("Fireon Payroll System | Dashboard");
                    break;
            }
        }
        #endregion
    }
}
