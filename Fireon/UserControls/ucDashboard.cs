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

namespace Fireon
{
    public partial class ucDashboard : UserControl
    {
        clsDashboard dh = new clsDashboard();
        public ucDashboard()
        {
            InitializeComponent();
        }
        private void ucDashboard_Load(object sender, EventArgs e)
        {
            dh.retrieveDashboardStatistics(
                this.lblTotalEmployeesCount,
                this.lblTotalMaleCount,
                this.lblTotalFemaleCount,
                this.lblTotalContractualCount,
                this.lblTotalRegularCount,
                this.lblAdministrativeCount,
                this.lblCustomerServiceCount,
                this.lblFinanceCount,
                this.lblHumanResourceCount,
                this.lblInformationTechnologyCount,
                this.lblLegalCount,
                this.lblMarketingCount,
                this.lblOperationCount,
                this.lblProductionCount,
                this.lblPurchasingCount,
                this.lblResearchAndDevelopmentCount,
                this.lblSalesCount);
        }

        private void lblTotalContractual_Click(object sender, EventArgs e)
        {

        }
    }
}
