Imports System.Data.SqlClient
Imports System.Windows.Forms
Imports System.Net
Imports System.Net.Mail

Public Class TennisConnection

    Dim Connection As SqlConnection
    Dim Command As SqlCommand
    Dim Adapter As SqlDataAdapter
    Dim Table As DataTable
    Dim datareader As SqlDataReader
    Public Function loadConnect()
        Connection = New SqlConnection(" ")
        Connection.Open()
        Command = New SqlCommand("Select Brand, Name, Price, Stock, Description from wallM_Project1.dbo.Inventory", Connection)
        Adapter = New SqlDataAdapter()
        Adapter.SelectCommand = Command
    End Function
    Public Function custLogin(user As String, pass As String) As Boolean
        Connection = New SqlConnection("")
        Connection.Open()
        Command = New SqlCommand("select Email, (cast(CustomerID as nvarchar) + (FirstName + LastName)) from wallM_Project1.dbo.Customers where Email = '" + user + "' and (cast(CustomerID as nvarchar) + (FirstName + LastName)) ='" + pass + "'", Connection)

        datareader = Command.ExecuteReader()
        Try
            If datareader.Read() Then
                If (user = datareader(0).ToString() And pass = datareader(1).ToString()) Then
                    MessageBox.Show("Logged in")
                    Return True
                Else
                    MessageBox.Show("Incorrect loggin information")
                End If
            Else
                MessageBox.Show("Incorrect loggin information")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Connection.Close()
        Connection.Dispose()
        Command.Dispose()
        datareader.Close()
    End Function
    Public Function addCust(first As String, last As String, address As String, email As String) As Boolean
        Connection = New SqlConnection("")
        Connection.Open()
        Try
            Command = New SqlCommand("insert into wallM_Project1.dbo.Customers values ('" + first + "','" + last + "','" + address + "','" + email + "')", Connection)
            datareader = Command.ExecuteReader()
            emailLogin(email)
            Return True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Connection.Close()
        Connection.Dispose()
        Command.Dispose()
    End Function

    Public Function emailLogin(customer As String)
        Dim Message As MailMessage
        Dim smtp As SmtpClient
        Message = New MailMessage()
        smtp = New SmtpClient()
        Dim smtpServer As String = ""
        Dim email As String = " "
        Dim pass As String = " "
        Dim user As String
        Dim password As String

        Connection = New SqlConnection("")
        Connection.Open()
        Command = New SqlCommand("select Email, (cast(CustomerID as nvarchar) + (FirstName + LastName)) from wallM_Project1.dbo.Customers where Email = '" + customer + "'", Connection)
        datareader = Command.ExecuteReader()

        If datareader.Read() Then
            user = datareader(0).ToString()
            password = datareader(1).ToString()
        End If

        Try
            If (email.Contains("@gmail.com")) Then
                smtpServer = "smtp.gmail.com"
            ElseIf (email.Contains("@yahoo.com")) Then
                smtpServer = "smtp.mail.yahoo.com"
            ElseIf (email.Contains("@outlook.com")) Then
                smtpServer = "smtp-mail.outlook.com"
            ElseIf (email.Contains("@hotmail.com")) Then
                smtpServer = "smtp.live.com"
            End If

            smtp.Host = smtpServer
            smtp.Port = 25
            smtp.EnableSsl = True
            smtp.Credentials = New NetworkCredential(email, pass)

            Message.From = New MailAddress(email)
            Message.To.Add(customer)

            Message.Subject = "Login"
            Message.Body = ""

            smtp.Send(Message)

            MessageBox.Show("Your account has been made! Your Login has been emailed to you!")

            Message.To.Clear()
            Message.Body = "Username = " + user + " password = " + password

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function
    Public Function order()

    End Function

    Public Function cart()
        Connection = New SqlConnection("")
        Connection.Open()
        Command = New SqlCommand("Select * from wallM_Project1.dbo.cart", Connection)
        Adapter = New SqlDataAdapter()
        Adapter.SelectCommand = Command
    End Function
    Public Function details()
        Connection = New SqlConnection("")
        Connection.Open()
        Command = New SqlCommand("Select Brand, Name, Price, Stock from wallM_Project1.dbo.Inventory", Connection)
        Adapter = New SqlDataAdapter()
        Adapter.SelectCommand = Command
    End Function
    Public Function clearCart()
        Connection = New SqlConnection("7")
        Connection.Open()
        Command = New SqlCommand("Delete from wallM_Project1.dbo.cart")
        Adapter = New SqlDataAdapter()
        Adapter.SelectCommand = Command
    End Function

    Public Function AddCart(brand As String, name As String, price As Decimal)
        Connection = New SqlConnection(" ")
        Connection.Open()
        Command = New SqlCommand("Insert into wallM_Project1.dbo.cart(Brand, Name, Price)values(@Brand, @Name, @Price)", Connection)
        Command.Parameters.AddWithValue("@Brand", brand)
        Command.Parameters.AddWithValue("@Name", name)
        Command.Parameters.AddWithValue("@Price", price)
        Command.ExecuteNonQuery()
        Connection.Close()
        Connection.Dispose()
        Command.Dispose()
    End Function
    Public Function StockUpdate(stock As Integer, name As String)
        Connection = New SqlConnection(" ")
        Connection.Open()
        Try
            Command = New SqlCommand("update wallM_Project1.dbo.Inventory set  Stock = " + stock.ToString + " where name ='" + name + "'", Connection)
            datareader = Command.ExecuteReader()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Connection.Close()
        Connection.Dispose()
        Command.Dispose()
    End Function

    Public Function stopConnect()
        Connection.Close()
        Connection.Dispose()
        Command.Dispose()
        Adapter.Dispose()
    End Function

    Public Sub fillTable(table As DataTable)
        Adapter.Fill(table)
    End Sub




End Class
