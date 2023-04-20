Imports MySql.Data.MySqlClient

Public Class CategoryPrompts

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim Obj = New Category
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click

        Dim categoryName As String = Guna2TextBox1.Text
        Dim categoryDescription As String = Guna2TextBox2.Text


        Dim connectionString As String = "Server=localhost;Database=restaurant;Uid=root;Pwd=july032002;"
        Using connection As New MySqlConnection(connectionString)
            connection.Open()


            Dim query As String = "INSERT INTO category (categoryName, description) VALUES (@categoryName, @description)"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@categoryName", categoryName)
                command.Parameters.AddWithValue("@description", categoryDescription)
                command.ExecuteNonQuery()
            End Using

            Dim resetQuery As String = "ALTER TABLE category AUTO_INCREMENT = 1;"
            Using resetCommand As New MySqlCommand(resetQuery, connection)
                resetCommand.ExecuteNonQuery()
            End Using

            MessageBox.Show("New category added successfully!")

            connection.Close()
        End Using
    End Sub
End Class

