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
        clsDatabaseFunctions db = new clsDatabaseFunctions(); // CREATE AN INSTANCE OF clsDatabaseFunctions.
        /// <summary>
        /// VIBIESCA
        /// Default stuff
        /// </summary>
        public ucEmployee()
        {
            InitializeComponent();
        }
        /// <summary>
        /// VIBIESCA
        /// EVERY TIME ucEmployee LOADS ONTO THE MEMORY, CALL DISPLAY USER CONTROL TO DISPLAY THE EMPLOYEE LIST
        /// </summary>
        private void ucEmployee_Load(object sender, EventArgs e)
        {
            displayUserControl("List Employee");
        }
        /// <summary>
        /// VIBIESCA
        /// EVERY TIME THAT THE NEW BUTTON IS CLICKED
        /// </summary>
        private void btnHireEmployees_Click(object sender, EventArgs e)
        {
            displayUserControl("New Employee");
        }
        public void displayUserControl(string name)
        {
            switch (name)
            {
                case "New Employee":
                    pnlEmployee.Controls.Clear(); // CLEARS ALL CHILDREN OF pnlEmployee
                    ucNewEmployee ucNewEmployee = new ucNewEmployee(); // CREATES A NEW UserControl
                    ucNewEmployee.Parent = pnlEmployee; // SET PARENT OF NEW DASHBOARD
                    ucNewEmployee.Dock = DockStyle.Fill; // SET THE DOCKSTYLE
                    pnlFilters.Hide();
                    btnCancel.Show();
                    break;
                case "List Employee":
                    pnlEmployee.Controls.Clear(); // CLEARS ALL CHILDREN OF pnlEmployee
                    ucDataGridView ucDataGridView = new ucDataGridView(); // CREATES A NEW UserControl
                    ucDataGridView.Parent = pnlEmployee; // SET PARENT OF NEW DASHBOARD
                    ucDataGridView.Dock = DockStyle.Fill; // SET THE DOCKSTYLE
                    db.dbRead("SELECT * FROM tbl_employee", ucDataGridView.theDataGridView); // USE THE CLASS WE INITIATED ABOVE AND USED THE dbRead FUNCTION OF IT.
                    pnlFilters.Show();
                    btnCancel.Hide();
                    break;
                default:
                    pnlEmployee.Controls.Clear(); // CLEARS ALL CHILDREN OF pnlEmployee
                    ucDataGridView ucDataGridViewDefault = new ucDataGridView(); // CREATES A NEW UserControl
                    ucDataGridViewDefault.Parent = pnlEmployee; // SET PARENT OF NEW DASHBOARD
                    ucDataGridViewDefault.Dock = DockStyle.Fill; // SET THE DOCKSTYLE
                    db.dbRead("SELECT * FROM tbl_employee", ucDataGridViewDefault.theDataGridView); // USE THE CLASS WE INITIATED ABOVE AND USED THE dbRead FUNCTION OF IT.
                    pnlFilters.Show();
                    btnCancel.Hide();
                    break;
            }
        }

        #region COOL SEARCH BOX LOOGIC
        private void txtbxSearch_Enter(object sender, EventArgs e)
        {
            if (String.Compare(txtbxSearch.Text, "Search") == 0)
            {
                txtbxSearch.Text = "";
                txtbxSearch.ForeColor = Color.Black;
            }
        }

        private void txtbxSearch_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtbxSearch.Text) == true)
            {
                txtbxSearch.Text = "Search";
                txtbxSearch.ForeColor = Color.Gray;
            }
        }
        #endregion
        #region COMBOBOX LOGIC
        /// <summary>
        /// VIBIESCA
        /// POSITION LIST BOX ITEMS WILL CHANGE DEPENDING ON THE SELECTED DEPARTMENT
        /// </summary>
        private void cmbxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            // INDEX LIST ON THIS COMBOBOX GUIDE
            //0  Administrative
            //1  Customer Service
            //2  Finance
            //3  Human Resource
            //4  Information Technology
            //5  Legal
            //6  Marketing
            //7  Operations
            //8  Production
            //9  Purchasing
            //10 Research and Development
            //11 Sales

            cmbxPosition.Items.Clear(); // FIRSTLY REMOVES ALL ITEMS ON THE LIST BEFORE ADDING 1 BASED ON SELECTED
            switch (cmbxDepartment.SelectedIndex) // BASICALLY THE CHOICES OF POSITION COMBOBOX JUST CHANGE BASED ON WHAT'S SELECTED ON THE DEPARTMENT
            {
                case 0:
                    this.cmbxPosition.Items.AddRange(new object[] {
                    "Administrator",
                    "Administrative Coordinator",
                    "Administrative Director",
                    "Administrative Manager",
                    "Administrative Specialist",
                    "Services Manager",
                    "Secretary",
                    "Administrative Assistant Director",
                    });
                    break;
                case 1:
                    this.cmbxPosition.Items.AddRange(new object[] {
                    "Customer Experience Specialist",
                    "Customer Support Associate",
                    "Customer Service Agent",
                    "Retail Associate",
                    "Telephone Support Specialist",
                    "Customer Interaction Management Specialist",
                    "Call Center Customer Support",
                    "Customer Care Operator",
                    });
                    break;
                case 2:
                    this.cmbxPosition.Items.AddRange(new object[] {
                    "Payroll Clerk",
                    "Financial Analyst",
                    "Payroll Assistant",
                    "Finance Clerk",
                    "Financial Advisor Assistant",
                    "Purchasing Clerk",
                    "Accountant",
                    "Assistant Accountant",
                    "Auditor",
                    });
                    break;
                case 3:
                    this.cmbxPosition.Items.AddRange(new object[] {
                    "Human Resource Generalist",
                    "Human Resource Assistant",
                    "Human Resource Associate",
                    "Human Resource Representative",
                    "Human Resource Administrator",
                    "Human Resource Analyst",
                    "Human Resource Specialist",
                    "Human Resource Supervisor",
                    "Human Resource Manager",
                    "Human Resource Director",
                    });
                    break;
                case 4:
                    this.cmbxPosition.Items.AddRange(new object[] {
                    "IT Technician",
                    "Network Administrator",
                    "System Analyst",
                    "IT Director",
                    "IT Support Specialist",
                    "Database Administrator",
                    "Security Specialist",
                    "Application Developer",
                    "Web Developer"
                    });
                    break;
                case 5:
                    this.cmbxPosition.Items.AddRange(new object[] {
                    "Arbitrator",
                    "Attorney",
                    "Case Manager",
                    "Jury Consultant",
                    "Law ﬁrm Administrator",
                    "Legal Analyst",
                    "Legal Services Director",
                    });
                    break;
                case 6:
                    this.cmbxPosition.Items.AddRange(new object[] {
                    "Marketing Director",
                    "Marketing Manager",
                    "Communication Manager",
                    "Product Manager",
                    "Marketing Consultant",
                    });
                    break;
                case 7:
                    this.cmbxPosition.Items.AddRange(new object[] {
                    "Operations Manager",
                    "Operations Supervisor",
                    "Operations Assistant",
                    "Operations Analyst",
                    "Facilities Coordinator",
                    "Logistics Manager",
                    });
                    break;
                case 8:
                    this.cmbxPosition.Items.AddRange(new object[] {
                    "Robotics Technician",
                    "Mechatronic Engineer",
                    "Assembler",
                    "Machinist",
                    "Production Manager",
                    "Quality Control Inspector",
                    "Product Designer",
                    });
                    break;
                case 9:
                    this.cmbxPosition.Items.AddRange(new object[] {
                    "Purchasing Manager ",
                    "Materials Manager",
                    "Purchasing Director",
                    "Purchasing Supervisor",
                    "Purchasing Agent",
                    "Purchasing Assistant",
                    "Purchasing Clerk",
                    "Production Planner",
                    });
                    break;
                case 10:
                    this.cmbxPosition.Items.AddRange(new object[] {
                    "Research Assistant ",
                    "R&D Manager",
                    "R&D Supervisor",
                    "R&D Specialist",
                    });
                    break;
                case 11:
                    this.cmbxPosition.Items.AddRange(new object[] {
                    "Sales Collection Agent",
                    "Sales Account Manager",
                    "Sales Account Executive",
                    "Sales Manager",
                    "Sales Representative",
                    "Sales Consultant",
                    });
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}
