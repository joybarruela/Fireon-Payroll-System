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
    public partial class ucCashAdvance : UserControl
    {
        clsDatabaseFunctions db = new clsDatabaseFunctions();
        clsDepartmentAndPositions dp = new clsDepartmentAndPositions();
        clsFireonFunctions ff = new clsFireonFunctions();
        clsFileOperations fo = new clsFileOperations();
        clsStringFunctions sf = new clsStringFunctions();
        clsDatabaseQueries dq = new clsDatabaseQueries();
        public ucCashAdvance()
        {
            InitializeComponent();
            db.dbRead(dq.queryEmployeeDetails[0], dtgvCashAdvance);
        }
        private void txtbxCashAdvance_KeyPress(object sender, KeyPressEventArgs e)
        {
            sf.secondRegex(e);
        }


        private void btnCashAdvance_Click(object sender, EventArgs e)
        {
            /* ALGO
             * 1. Check if there is a typed value on the textbox
             * 2. Get the data on the selected row.
             * 3. Compare the details if the input is compatible with what's selected on the datagridview
             * 4. If yes then run the database query
             */

            int cashAdvanceValue = 0; // DEPENDS ON WHAT IS TYPED ON THE TEXTBOX
            if (String.IsNullOrEmpty(txtbxCashAdvance.Text) == false)
            {
                DataGridViewRow selectedRow = dtgvCashAdvance.SelectedRows[0]; // gets the first selected row

                // 2, 3, 4 is sick, vacation, and maternity leave on dtgv consecutively
                int currentCashAdvance = int.Parse(selectedRow.Cells[8].Value.ToString());

                if(currentCashAdvance - int.Parse(txtbxCashAdvance.Text) >= 0){
                    cashAdvanceValue = int.Parse(txtbxCashAdvance.Text);
                    // #5
                    // THINGS TO PASS HERE
                    // 1. EID
                    // 2. THE DEDUCTORY VALUE
                    db.addCashAdvance(selectedRow.Cells[0].Value.ToString(), cashAdvanceValue);
                    db.dbRead(dq.queryEmployeeDetails[0], dtgvCashAdvance);
                    MessageBox.Show(null, Properties.Resources.msg_cash_advance_added, Properties.Resources.str_program_title, MessageBoxButtons.OK);
                    Console.WriteLine(Properties.Resources.msg_cash_advance_added);
                    return;
                }
            }
        }
    }
}
