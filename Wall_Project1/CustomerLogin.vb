Imports System.Data.SqlClient
Imports TennisDLL
Public Class CustomerLogin
    Dim Tennis As New TennisConnection
    Dim user As String
    Dim pass As String
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        user = txtUsername.Text.ToString
        pass = txtPassword.Text.ToString
        If (Tennis.custLogin(user, pass) = True) Then
            Dim Cart As New Cart
            Cart.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click
        Dim newCust As New newCustomer
        newCust.Show()
        Me.Close()
    End Sub
End Class