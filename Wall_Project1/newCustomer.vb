Imports System.Data.SqlClient
Imports TennisDLL
Public Class newCustomer
    Dim Tennis As New TennisConnection
    Dim first As String
    Dim last As String
    Dim address As String
    Dim email As String
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        first = txtFirst.Text.ToString
        last = txtLast.Text.ToString
        address = txtAddress.Text.ToString
        email = txtEmail.Text.ToString
        If (email.Contains("@gmail.com") Or email.Contains("@yahoo.com") Or email.Contains("@outlook.com") Or email.Contains("@hotmail.com")) Then
            If (Tennis.addCust(first, last, address, email) = True) Then
                Dim Cart As New Cart
                Cart.Show()
                Me.Close()
            End If
        Else
            MessageBox.Show("Please enter a valid email.")
        End If

    End Sub
End Class