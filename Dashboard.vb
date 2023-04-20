
Public Class Dashboard
    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Dim Obj = New Category
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim Obj = New Products
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Dim Obj = New Orders
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Button6_Click(sender As Object, e As EventArgs) Handles Guna2Button6.Click
        Dim Obj = New Login
        Obj.Show()
        Me.Hide()
    End Sub

    Private Sub Guna2Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Guna2Panel1.Paint

    End Sub

    Private Sub Guna2TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Guna2TextBox5_TextChanged_1(sender As Object, e As EventArgs) Handles Guna2TextBox5.TextChanged

    End Sub

    Private Sub Guna2PictureBox3_Click(sender As Object, e As EventArgs) Handles Guna2PictureBox3.Click

    End Sub
End Class