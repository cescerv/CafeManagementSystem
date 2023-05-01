Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data.OleDb
Imports System.Globalization

Public Class Orders
    Private Sub Orders_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadOrderData()
    End Sub

    Private Sub LoadOrderData()
        Dim connectionString As String = "Server=localhost;Database=restaurant;Uid=root;Pwd=july032002;"
        Dim connection As New MySqlConnection(connectionString)
        connection.Open()

        Dim query As String = "SELECT * FROM `order`"
        Dim command As New MySqlCommand(query, connection)
        Dim adapter As New MySqlDataAdapter(command)
        Dim dt As New DataTable()
        adapter.Fill(dt)

        Guna2DataGridView1.DataSource = dt

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

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Dim Obj = New Products
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick

        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = Guna2DataGridView1.Rows(e.RowIndex)
            Dim orderID As Integer = Convert.ToInt32(selectedRow.Cells("orderId").Value)
            Dim userID As Integer = Convert.ToInt32(selectedRow.Cells("userId").Value)
            Dim email As String = selectedRow.Cells("email").Value.ToString()
            Dim phone As String = selectedRow.Cells("phone").Value.ToString()
            Dim address As String = selectedRow.Cells("address").Value.ToString()
            Dim orderAmount As Double = Convert.ToDouble(selectedRow.Cells("orderAmount").Value)


            MessageBox.Show($"Order ID: {orderID}" & vbCrLf &
                            $"User ID: {userID}" & vbCrLf &
                            $"Email: {email}" & vbCrLf &
                            $"Phone: {phone}" & vbCrLf &
                            $"Address: {address}" & vbCrLf &
                            $"Order Amount: {orderAmount}")
        End If
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click

        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "CSV files (*.csv)|*.csv"
        saveFileDialog1.Title = "Save as CSV"

        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            Try

                Using writer As New StreamWriter(saveFileDialog1.FileName)

                    For Each column As DataGridViewColumn In Guna2DataGridView1.Columns
                        writer.Write(column.HeaderText & ",")
                    Next
                    writer.Write(Environment.NewLine)

                    For Each row As DataGridViewRow In Guna2DataGridView1.Rows

                        For Each cell As DataGridViewCell In row.Cells

                            If cell.Value IsNot Nothing AndAlso Not IsDBNull(cell.Value) Then
                                writer.Write(cell.Value.ToString() & ",")
                            Else
                                writer.Write(",")
                            End If
                        Next


                        writer.Write(Environment.NewLine)
                    Next


                    MessageBox.Show("CSV file saved successfully.")
                End Using
            Catch ex As Exception
                MessageBox.Show("Error saving CSV file: " & ex.Message)
            End Try
        End If
    End Sub
End Class
