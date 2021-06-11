Imports TennisDLL
Public Class CartReport
    Private Sub CartReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim report = New CartCReport()
        report.SetDatabaseLogon("mawall", "1175037")
        crvCart.ReportSource = report
        Dim Tennis As New TennisConnection

        Tennis.clearCart()
    End Sub
End Class