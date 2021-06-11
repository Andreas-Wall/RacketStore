Imports System.Data.SqlClient
Imports TennisDLL
Public Class Cart
    Dim Tennis As New TennisConnection
    Dim Table As DataTable
    Private Sub ReturnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReturnToolStripMenuItem.Click
        Dim main As New TennisEmporium()
        main.Show()
        Me.Close()
    End Sub
    Private Sub btnPurchase_Click(sender As Object, e As EventArgs) Handles btnPurchase.Click
        Dim cartReport As New CartReport
        cartReport.Show()
        Me.Close()
    End Sub

    Private Sub Cart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tennis.cart()
        Table = New DataTable()
        Tennis.fillTable(Table)
        dgvCart.DataSource = Table
        Tennis.stopConnect()
    End Sub
End Class