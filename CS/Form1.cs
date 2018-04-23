using System;
using System.Windows.Forms;

using DevExpress.XtraReports.UserDesigner;
// ...

namespace EUD_ExecCommandCS {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {
            // Create an End-User Designer form instance.
            XRDesignFormEx designForm = new XRDesignFormEx();

            // Handle its Load event.
            designForm.Load += new EventHandler(designForm_Load);

            // Show this form modally.
            designForm.ShowDialog();
        }

        private void designForm_Load(object sender, EventArgs e) {
            // Create a new report and run the Report Wizard every time a form is loaded.
            ((XRDesignFormEx)sender).DesignPanel.ExecCommand(ReportCommand.NewReportWizard);
        }
    }
}