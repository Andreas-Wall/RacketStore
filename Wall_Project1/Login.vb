Public Class Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim user As String = txtUsername.Text()
        Dim pass As String = txtPassword.Text()

        If (user = "admin" And pass = "12345") Then
            Dim stock As New StockDetails()
            stock.Show()
            Me.Close()
        Else
            MessageBox.Show("Incorrect login information")
            txtUsername.Select()
        End If
    End Sub

End Class