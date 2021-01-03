using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fireon.Classes;

namespace Fireon.UserControls
{
    public partial class ucPrint : UserControl
    {
        clsDatabaseFunctions db = new clsDatabaseFunctions();
        clsDepartmentAndPositions dp = new clsDepartmentAndPositions();
        clsFireonFunctions ff = new clsFireonFunctions();
        clsFileOperations fo = new clsFileOperations();
        clsStringFunctions sf = new clsStringFunctions();
        clsDatabaseQueries dq = new clsDatabaseQueries();
        clsPayroll pr = new clsPayroll();

        public ucPrint()
        {
            InitializeComponent();
        }
        #region TRIGGERS AND EVENTS
        private void ucPrint_Load(object sender, EventArgs e)
        {
            displayUserControl("List Employee");
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            pr.computePayroll(); // COMPUTES THE PAYROLL HERE
            db.dbSearch(pnlPrint, ff.employeeDetailsSearch(txtbxSearch, this.cmbxEmployeeStatus, this.cmbxDepartment, this.cmbxPosition, this.cmbxMonth, this.cmbxYear));
        }
        private void txtbxSearch_Enter(object sender, EventArgs e)
        {
            ff.ghostText("Search", this.txtbxSearch);
        }
        private void txtbxSearch_Leave(object sender, EventArgs e)
        {
            ff.ghostText("Search", this.txtbxSearch);
        }
        private void cmbxDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            ff.departmentChange(cmbxDepartment, cmbxPosition, "List Employee Part");
        }
        #endregion
        #region CUSTOM FUNCTIONS
        /// <summary>
        /// DISPLAYS USER CONTROL
        /// </summary>
        /// <param name="mode"></param>
        public void displayUserControl(string mode)
        {
            switch (mode)
            {
                case "New Employee":
                    ff.displayUserControl(pnlPrint, new ucNewEmployee());
                    pnlFilters.Hide();
                    btnSearch.Hide();
                    break;
                case "List Employee":
                    ff.displayUserControl(pnlPrint, new ucDataGridView());
                    pnlFilters.Show();
                    btnSearch.Show();
                    // cmbx[0] = cmbxemployeestatus
                    // cmbx[1] = cmbxdepartment
                    // cmbx[2] = cmbxposition
                    // cmbx[3] = cmbxmonth
                    // cmbx[4] = cmbxyear
                    ff.prepComboBoxesEmployee(this.cmbxEmployeeStatus, this.cmbxDepartment, this.cmbxPosition, this.cmbxMonth, this.cmbxYear);
                    ff.resetFilterComboBoxes(this.cmbxEmployeeStatus, this.cmbxDepartment, this.cmbxPosition, this.cmbxMonth, this.cmbxYear);
                    ff.ghostText("Search", this.txtbxSearch, true);
                    pr.computePayroll(); // COMPUTES THE PAYROLL HERE
                    db.dbSearch(pnlPrint, ff.employeeDetailsSearch(txtbxSearch, this.cmbxEmployeeStatus, this.cmbxDepartment, this.cmbxPosition, this.cmbxMonth, this.cmbxYear));
                    break;
                default:
                    pnlFilters.Show();
                    btnSearch.Show();
                    break;
            }
        }
        #endregion
    }
}
