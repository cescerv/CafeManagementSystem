Imports MySql.Data.MySqlClient

Public Class Orders
    Private Sub Orders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Call the method to load data into DataGridView
        LoadOrderData()
    End Sub

    Private Sub LoadOrderData()
        ' Establish MySQL connection
        Dim connectionString As String = "Server=localhost;Database=restaurant;Uid=root;Pwd=july032002;"
        Dim connection As New MySqlConnection(connectionString)
        connection.Open()

        ' Retrieve data from "orders" table with backticks around table name
        Dim query As String = "SELECT * FROM `order`"
        Dim command As New MySqlCommand(query, connection)
        Dim adapter As New MySqlDataAdapter(command)
        Dim dt As New DataTable()
        adapter.Fill(dt)

        ' Bind data to DataGridView
        Guna2DataGridView1.DataSource = dt

        ' Close MySQL connection
        connection.Close()
    End Sub


    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs) Handles Guna2Button5.Click
        Dim Obj = New Login
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Dim Obj = OrderDetails
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim Obj = New Dashboard
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Dim Obj = New Category
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        ' Do nothing, as the user is already on the Orders page
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Dim Obj = New Products
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick
        ' Example of retrieving data from selected row in DataGridView
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = Guna2DataGridView1.Rows(e.RowIndex)
            Dim orderID As Integer = Convert.ToInt32(selectedRow.Cells("orderId").Value)
            Dim userID As Integer = Convert.ToInt32(selectedRow.Cells("userId").Value)
            Dim email As String = selectedRow.Cells("email").Value.ToString()
            Dim phone As String = selectedRow.Cells("phone").Value.ToString()
            Dim address As String = selectedRow.Cells("address").Value.ToString()
            Dim orderAmount As Double = Convert.ToDouble(selectedRow.Cells("orderAmount").Value)

            ' Display the retrieved data in MessageBox
            MessageBox.Show($"Order ID: {orderID}" & vbCrLf &
                            $"User ID: {userID}" & vbCrLf &
                            $"Email: {email}" & vbCrLf &
                            $"Phone: {phone}" & vbCrLf &
                            $"Address: {address}" & vbCrLf &
                            $"Order Amount: {orderAmount}")
        End If
    End Sub
End Class
