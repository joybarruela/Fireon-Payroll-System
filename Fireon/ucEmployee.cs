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

    }
}
