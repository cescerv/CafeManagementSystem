Imports MySql.Data.MySqlClient
Public Class Login
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim connectionString As String = "server=localhost;user=root;password=july032002;database=restaurant;"
        Dim connection As MySqlConnection = New MySqlConnection(connectionString)

        connection.Open()


        Dim query As String = "SELECT * FROM login WHERE username = @username AND password = @password"
        Dim command As MySqlCommand = New MySqlCommand(query, connection)
        command.Parameters.AddWithValue("@username", UnameTb.Text)
        command.Parameters.AddWithValue("@password", PasswordTb.Text)

        Dim reader As MySqlDataReader = command.ExecuteReader()


        If reader.Read() Then
            Dim Obj As Dashboard = New Dashboard()
            Obj.Show()
            Me.Hide()
        Else
            MsgBox("Wrong UserName or Password")
            UnameTb.Text = ""
            PasswordTb.Text = ""
        End If

        reader.Close()
        connection.Close()
    End Sub


    Private Sub Label2_Click(sender As Object, e As EventArgs)
        Dim Obj = New Dashboard
        Obj.Show()
        Me.Hide()

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
