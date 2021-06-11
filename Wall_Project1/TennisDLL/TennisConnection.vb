
Public Class TennisConnection
    Dim Connection As SqlConnection
    Dim Command As SqlCommand
    Dim Adapter As SqlDataAdapter
    Dim Table As DataTable
    Dim Manager As CurrencyManager
    Dim bm As BindingManagerBase
    Dim count As Integer

    Public Function loadConnect()
        Connection = New SqlConnection(" ")
        Connection.Open()

        Command = New SqlCommand("Select Brand, Name, Price, Stock, Description from wallM_Project1.dbo.Inventory", Connection)
        Adapter = New SqlDataAdapter()
        Adapter.SelectCommand = Command
        Table = New DataTable()
        Adapter.Fill(Table)


        lblName.DataBindings.Add("Text", Table, "Name")
        lblBrand.DataBindings.Add("Text", Table, "Brand")
        lblQuantity.DataBindings.Add("Text", Table, "Stock")
        lblPrice.DataBindings.Add("Text", Table, "Price")
        lblDesc.DataBindings.Add("Text", Table, "Description")
        bm = Me.BindingContext(Table)

        Connection.Close()
        Connection.Dispose()
        Command.Dispose()
        Adapter.Dispose()
        Table.Dispose()
    End Function


End Class
