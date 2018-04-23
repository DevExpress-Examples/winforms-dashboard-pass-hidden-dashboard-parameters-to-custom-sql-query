using DevExpress.DashboardCommon;
using System.Linq;

namespace Dashboard_CustomParameters_Win {
    public partial class Form1 : DevExpress.XtraEditors.XtraForm {
        public Form1() {
            InitializeComponent();

            dashboardViewer1.LoadDashboard(@"..\..\Data\Dashboard.xml");
        }

        private void dashboardViewer1_CustomParameters(object sender, CustomParametersEventArgs e) {
            var custIDParameter = e.Parameters.FirstOrDefault(p => p.Name == "custIDDashboardParameter");
            if (custIDParameter != null) {
                custIDParameter.Value = "AROUT";
            }
        }
    }
}
