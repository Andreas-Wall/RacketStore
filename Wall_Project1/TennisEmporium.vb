Imports System.Data.SqlClient
Imports System.Threading
Imports TennisDLL

Public Class TennisEmporium
    Dim Tennis As New TennisConnection

    Dim Table As DataTable

    Dim bm As BindingManagerBase

    Dim count As Integer
    Dim brand As String
    Dim name As String
    Dim price As Decimal
    Dim stock As Integer

    Private Sub exitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles exitToolStripMenuItem.Click

        Tennis.stopConnect()
        Me.Close()
    End Sub

    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim splash As New splash()
        splash.Show()
        Dim i As Integer

        Tennis.loadConnect()
        Table = New DataTable()
        Tennis.fillTable(Table)
        Tennis.clearCart()

        lblName.DataBindings.Add("Text", Table, "Name")
        lblBrand.DataBindings.Add("Text", Table, "Brand")
        lblQuantity.DataBindings.Add("Text", Table, "Stock")
        lblPrice.DataBindings.Add("Text", Table, "Price")
        lblDesc.DataBindings.Add("Text", Table, "Description")
        bm = Me.BindingContext(Table)

        Tennis.stopConnect()
        Table.Dispose()
        pbxImage.Image = ImageList1.Images(0)
        count = 0

        For i = 0 To 10
            Thread.Sleep(1000)
            splash.steps($"On step {i} of 10...")
        Next
        splash.steps("Done!")
        splash.Close()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        bm.Position += 1
        If (count < 9) Then
            count += 1
        End If
        pbxImage.Image = ImageList1.Images(count)
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        bm.Position -= 1
        If (count > 0) Then
            count -= 1
        End If
        pbxImage.Image = ImageList1.Images(count)
    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        count = 0
        bm.Position = 0
        pbxImage.Image = ImageList1.Images(count)
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        count = 9
        bm.Position = bm.Count - 1
        pbxImage.Image = ImageList1.Images(count)
    End Sub

    Private Sub AboutToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem1.Click
        Dim ab As New AboutBox1()
        ab.Show()
    End Sub

    Private Sub loginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles loginToolStripMenuItem.Click
        Dim login As New Login()
        login.Show()
    End Sub

    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click
        brand = lblBrand.Text
        name = lblName.Text
        price = Decimal.Parse(lblPrice.Text)
        stock = Integer.Parse(lblQuantity.Text)
        If (stock > 0) Then
            Tennis.AddCart(brand, name, price)
            MessageBox.Show(lblName.Text + " was added to the cart.")
            stock -= 1
            Tennis.StockUpdate(stock, name)

            Try
                Tennis.loadConnect()
                Table = New DataTable
                Tennis.fillTable(Table)
                lblQuantity.DataBindings.Clear()
                lblQuantity.DataBindings.Add("Text", Table, "Stock")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try

            Tennis.stopConnect()

        Else
            MessageBox.Show("Sorry, that item is out of stock.")
        End If

    End Sub

    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click
        Dim check As New CustomerLogin()
        check.Show()
    End Sub
End Class
