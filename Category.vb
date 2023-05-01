Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Data.OleDb
Imports System.Globalization


Public Class Category
    Private Sub Category_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadCategoryData()
    End Sub

    Private Sub LoadCategoryData()
        Dim connectionString As String = "Server=localhost;Database=restaurant;Uid=root;Pwd=july032002;"
        Dim connection As New MySqlConnection(connectionString)
        connection.Open()

        Dim query As String = "SELECT * FROM category"
        Dim command As New MySqlCommand(query, connection)
        Dim adapter As New MySqlDataAdapter(command)
        Dim dt As New DataTable()
        adapter.Fill(dt)

        Guna2DataGridView1.DataSource = dt

        connection.Close()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Guna2TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        Dim Obj = New Login
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

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click
        Dim Obj = New Products
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click
        Dim Obj = New Products
        Obj.Show()
        Me.Hide()

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim Obj = New CategoryPrompts
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Guna2DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Guna2DataGridView1.CellContentClick

        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = Guna2DataGridView1.Rows(e.RowIndex)
            Dim categoryID As Integer = Convert.ToInt32(selectedRow.Cells("categoryId").Value)
            Dim categoryName As String = selectedRow.Cells("categoryName").Value.ToString()
            Dim categoryDescription As String = selectedRow.Cells("description").Value.ToString()

            MessageBox.Show($"Category ID: {categoryID}" & vbCrLf &
                        $"Category Name: {categoryName}" & vbCrLf &
                        $"Category Description: {categoryDescription}")
        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim Obj = New Cdelete
        Obj.Show()
        Me.Hide()
    End Sub


    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click

        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "CSV files (*.csv)|*.csv"
        openFileDialog1.Title = "Select a CSV file"

        If openFileDialog1.ShowDialog() = DialogResult.OK Then

            Dim filePath As String = openFileDialog1.FileName.Replace("\", "/")

            Try

                Dim lines As String() = File.ReadAllLines(filePath)


                Dim dt As New DataTable()
                dt.Columns.Add("categoryName", GetType(String))
                dt.Columns.Add("description", GetType(String))


                For i As Integer = 1 To lines.Length - 1
                    Dim fields As String() = lines(i).Split(",")
                    Dim row As DataRow = dt.NewRow()

                    row("categoryName") = fields(0)
                    row("description") = fields(1)

                    dt.Rows.Add(row)
                Next


                Using connection As New MySqlConnection("Server=localhost;Database=restaurant;Uid=root;Pwd=july032002;")
                    connection.Open()

                    For Each row As DataRow In dt.Rows
                        Dim command As New MySqlCommand()
                        command.Connection = connection
                        command.CommandType = CommandType.Text
                        command.CommandText = "INSERT INTO category (categoryName, description) " &
                                      "VALUES (@categoryName, @description)"

                        command.Parameters.Clear()
                        command.Parameters.AddWithValue("@categoryName", row("categoryName"))
                        command.Parameters.AddWithValue("@description", row("description"))

                        command.ExecuteNonQuery()
                    Next


                    Guna2DataGridView1.DataSource = Nothing


                    Dim adapter As New MySqlDataAdapter("SELECT * FROM category", connection)
                    Dim data As New DataTable()
                    adapter.Fill(data)


                    For Each row As DataRow In data.Rows
                        Dim newRow As DataRow = dt.NewRow()
                        newRow("categoryName") = row("categoryName")
                        newRow("description") = row("description")
                        dt.Rows.Add(newRow)
                    Next


                    Guna2DataGridView1.DataSource = dt

                    MessageBox.Show("Data inserted successfully into the database.")
                End Using
            Catch ex As Exception
                MessageBox.Show("Error inserting data into the database: " & ex.Message)
            End Try
        End If
    End Sub



    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click

        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "SQL files (*.sql)|*.sql"
        saveFileDialog1.Title = "Save as SQL"


        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            Try

                Dim connectionString As String = "Server=localhost;Database=restaurant;Uid=root;Pwd=july032002;"


                Dim processInfo As New ProcessStartInfo()
                processInfo.FileName = "mysqldump"
                processInfo.Arguments = String.Format("--user={0} --password={1} --host={2} --protocol={3} --port={4} --default-character-set={5} --single-transaction=TRUE --routines --databases {6}", "root", "july032002", "localhost", "tcp", "3306", "utf8mb4", "restaurant")
                processInfo.RedirectStandardInput = False
                processInfo.RedirectStandardOutput = True
                processInfo.CreateNoWindow = True
                processInfo.UseShellExecute = False

                Using process As Process = Process.Start(processInfo)
                    Using writer As StreamWriter = New StreamWriter(saveFileDialog1.FileName)
                        writer.WriteLine(process.StandardOutput.ReadToEnd())
                    End Using
                End Using

                MessageBox.Show("SQL file saved successfully.")
            Catch ex As Exception
                MessageBox.Show("Error saving SQL file: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub Guna2Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2Button5_Click_1(sender As Object, e As EventArgs) Handles Guna2Button5.Click

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