Imports DevExpress.XtraReports.UserDesigner
' ...

Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim designForm As New XRDesignFormEx()
        AddHandler designForm.Load, AddressOf designForm_Load
        designForm.ShowDialog()
    End Sub

    Private Sub designForm_Load(ByVal sender As Object, ByVal e As EventArgs)
        CType(sender, XRDesignFormEx).DesignPanel.ExecCommand(ReportCommand.NewReportWizard)
    End Sub
End Class
