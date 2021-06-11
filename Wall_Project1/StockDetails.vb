Imports System.Data.SqlClient
Imports TennisDLL
Public Class StockDetails
    Dim Tennis As New TennisConnection
    Dim Table As DataTable
    Private Sub StockDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tennis.details()
        Table = New DataTable()
        Tennis.fillTable(Table)
        dvgInventory.DataSource = Table
        Tennis.stopConnect()
    End Sub

    Private Sub ReturnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnToolStripMenuItem.Click
        Dim main As New TennisEmporium()
        main.Show()
        Me.Close()
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim report As New StockReport()
        report.Show()
        Me.Close()
    End Sub
End Class