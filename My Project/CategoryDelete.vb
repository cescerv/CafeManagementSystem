Imports MySql.Data.MySqlClient

Public Class CategoryDelete
    Private Sub UnameTb_TextChanged(sender As Object, e As EventArgs) Handles UnameTb.TextChanged

    End Sub

    Private Sub CategoryNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles CategoryNameTextBox.TextChanged

    End Sub

    Private Sub DescriptionTextBox_TextChanged(sender As Object, e As EventArgs) Handles DescriptionTextBox.TextChanged

    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        ' Get the category ID from the UnameTb TextBox
        Dim categoryID As Integer
        If Integer.TryParse(UnameTb.Text, categoryID) Then
            ' Create a MySQL connection and command
            Dim connectionString As String = "server=localhost;user=root;password=july032002;database=restaurant;"
            Dim connection As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand()
            command.Connection = connection

            ' Construct the SQL query to delete the category with the given ID
            command.CommandText = "DELETE FROM categories WHERE category_id = @categoryID"
            command.Parameters.AddWithValue("@categoryID", categoryID)

            ' Execute the query
            Try
                connection.Open()
                Dim rowsAffected As Integer = command.ExecuteNonQuery()
                If rowsAffected > 0 Then
                    MessageBox.Show("Category deleted successfully.")
                Else
                    MessageBox.Show("Category not found.")
                End If
            Catch ex As Exception
                MessageBox.Show("Error deleting category: " & ex.Message)
            Finally
                connection.Close()
            End Try
        Else
            MessageBox.Show("Invalid category ID. Please enter a valid integer value.")
        End If
    End Sub
End Class
