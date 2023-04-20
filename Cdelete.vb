Imports MySql.Data.MySqlClient
Public Class Cdelete
    Private connectionString As String = "server=localhost;user=root;password=july032002;database=restaurant;"

    Private Sub Guna2Button2_Click_1(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim categoryID As Integer = Integer.Parse(UnameTb.Text)

        Dim confirmResult As DialogResult = MessageBox.Show("Are you sure to delete this category?", "Confirm Delete", MessageBoxButtons.YesNo)
        If confirmResult = DialogResult.Yes Then
            Try
                Using connection As New MySqlConnection(connectionString)
                    connection.Open()

                    ' Delete the category from "category" table
                    Dim query As String = "DELETE FROM category WHERE categoryID=@categoryID"
                    Using command As New MySqlCommand(query, connection)
                        command.Parameters.AddWithValue("@categoryID", categoryID)
                        Dim result As Integer = command.ExecuteNonQuery()
                        If result > 0 Then
                            ' Show success message
                            MessageBox.Show("Category has been deleted.")
                            UnameTb.Clear()

                            ' Reset the auto-increment sequence for categoryId column
                            Dim resetQuery As String = "ALTER TABLE category AUTO_INCREMENT = 1;"
                            Using resetCommand As New MySqlCommand(resetQuery, connection)
                                resetCommand.ExecuteNonQuery()
                            End Using
                        Else
                            ' Show error message
                            MessageBox.Show("Category not found.")
                        End If
                    End Using
                End Using
            Catch ex As Exception
                ' Show error message
                MessageBox.Show("Error deleting category: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub Guna2Button1_Click_1(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim Obj = New Category
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub UnameTb_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CategoryNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles UnameTb.TextChanged

    End Sub

    Private Sub DescriptionTextBox_TextChanged(sender As Object, e As EventArgs) Handles DescriptionTextBox.TextChanged

    End Sub
End Class
