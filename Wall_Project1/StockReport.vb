Public Class StockReport
    Private Sub StockReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim report = New StockCReport()
        report.SetDatabaseLogon("mawall", "1175037")
        crvStock.ReportSource = report
    End Sub
End Class