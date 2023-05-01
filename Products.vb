Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data.OleDb
Imports System.Globalization


Public Class Products
    Private Sub Products_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadProductData()
    End Sub

    Private Sub LoadProductData()

        Dim connectionString As String = "server=localhost;user=root;password=july032002;database=restaurant;"
        Dim connection As New MySqlConnection(connectionString)
        connection.Open()

        Dim query As String = "SELECT productId, categoryId, title, description, unitPrice, salePrice FROM product"
        Dim command As New MySqlCommand(query, connection)
        Dim adapter As New MySqlDataAdapter(command)
        Dim dt As New DataTable()
        adapter.Fill(dt)


        Guna2DataGridView1.DataSource = dt


        connection.Close()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Dim Obj = New Orders
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Dim Obj = New Dashboard
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Dim Obj = New Category
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Dim Obj = New Products
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim Obj = New productprompt
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        Dim Obj = New Login
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick

        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = Guna2DataGridView1.Rows(e.RowIndex)
            Dim productID As Integer = Convert.ToInt32(selectedRow.Cells("productId").Value)
            Dim categoryID As Integer = Convert.ToInt32(selectedRow.Cells("categoryId").Value)
            Dim title As String = selectedRow.Cells("title").Value.ToString()
            Dim description As String = selectedRow.Cells("description").Value.ToString()
            Dim unitPrice As Decimal = Convert.ToDecimal(selectedRow.Cells("unitPrice").Value)
            Dim salePrice As Decimal = Convert.ToDecimal(selectedRow.Cells("salePrice").Value)


            MessageBox.Show($"Product ID: {productID}" & vbCrLf &
                            $"Category ID: {categoryID}" & vbCrLf &
                            $"Title: {title}" & vbCrLf &
                            $"Description: {description}" & vbCrLf &
                            $"Unit Price: {unitPrice}" & vbCrLf &
                            $"Sale Price: {salePrice}")
        End If
    End Sub

    Private Sub Guna2Button3_Click(sender As Object, e As EventArgs) Handles Guna2Button3.Click

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click

    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click

        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "CSV files (*.csv)|*.csv"
        saveFileDialog1.Title = "Save as CSV"


        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            Try

                Using writer As New StreamWriter(saveFileDialog1.FileName)
                    ' Write the header row
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
