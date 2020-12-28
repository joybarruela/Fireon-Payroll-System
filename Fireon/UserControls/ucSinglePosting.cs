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
    public partial class ucSinglePosting : UserControl
    {
        clsDatabaseFunctions db = new clsDatabaseFunctions();
        clsDepartmentAndPositions dp = new clsDepartmentAndPositions();
        clsFireonFunctions ff = new clsFireonFunctions();
        clsFileOperations fo = new clsFileOperations();
        clsStringFunctions sf = new clsStringFunctions();
        clsDatabaseQueries dq = new clsDatabaseQueries();
        clsPayroll pr = new clsPayroll();
        clsSinglePosting sp = new clsSinglePosting();

        public ucSinglePosting()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // TODO VALIDATIONS HERE
            if (String.IsNullOrEmpty(txtbxSearch.Text) == false) // IF SEARCHBOX IS NOT EMPTY
            {
                sp.searchAndDisplayEmployee(
                txtbxSearch.Text,
                this.lblEmployeeID,
                this.lblEmployeeFirstName,
                this.lblEmployeeDepartment,
                this.lblEmployeeContactNumber,
                this.lblEmployeeEmailAddress,
                this.lblEmployeeHomeAddress,
                this.lblAccountUsername,
                this.lblDateProcessed,
                this.lblPayrollNetPay
                );
            }
        }
        #region SEARCHBOX LOGIC AND VALIDATIONS
        private void txtbxSearch_Enter(object sender, EventArgs e)
        {
            ff.ghostText("Search", this.txtbxSearch);
        }
        private void txtbxSearch_Leave(object sender, EventArgs e)
        {
            ff.ghostText("Search", this.txtbxSearch);
        }
        private void txtbxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            sf.secondRegex(e);
        }
        #endregion


        #region PRINT FUNCTION
        Bitmap bmp;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(pnlSinglePosting.Size.Width, pnlSinglePosting.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.PointToScreen(pnlSinglePosting.Location).X, pnlSinglePosting.PointToScreen(pnlSinglePosting.Location).Y, 0, 0, pnlSinglePosting.Size);
            //mg.ScaleTransform(1.5F, 2.0F);
            printPreviewDialog1.Document.DefaultPageSettings.Landscape = true;
            printPreviewDialog1.ShowDialog();
        }
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        } 
        #endregion
    }
}
