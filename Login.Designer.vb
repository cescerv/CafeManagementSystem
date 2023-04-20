<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.PasswordTb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.UnameTb = New Guna.UI2.WinForms.Guna2TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(378, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Welcome!"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.AutoRoundedCorners = True
        Me.Guna2Button1.BorderRadius = 12
        Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
        Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
        Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
        Me.Guna2Button1.FillColor = System.Drawing.Color.Blue
        Me.Guna2Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.White
        Me.Guna2Button1.Location = New System.Drawing.Point(443, 312)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.Size = New System.Drawing.Size(135, 27)
        Me.Guna2Button1.TabIndex = 5
        Me.Guna2Button1.Text = "LOGIN"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Guna2ControlBox2)
        Me.Panel1.Controls.Add(Me.Guna2ControlBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(716, 37)
        Me.Panel1.TabIndex = 7
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(641, 4)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(33, 30)
        Me.Guna2ControlBox2.TabIndex = 9
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.Black
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(680, 4)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(33, 30)
        Me.Guna2ControlBox1.TabIndex = 8
        '
        'PasswordTb
        '
        Me.PasswordTb.Animated = True
        Me.PasswordTb.AutoRoundedCorners = True
        Me.PasswordTb.BorderColor = System.Drawing.Color.Blue
        Me.PasswordTb.BorderRadius = 21
        Me.PasswordTb.BorderThickness = 2
        Me.PasswordTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.PasswordTb.DefaultText = ""
        Me.PasswordTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.PasswordTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.PasswordTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PasswordTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.PasswordTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PasswordTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTb.ForeColor = System.Drawing.Color.Black
        Me.PasswordTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PasswordTb.IconLeftOffset = New System.Drawing.Point(7, 0)
        Me.PasswordTb.IconRight = Global.CafeManagementSystem.My.Resources.Resources.pass
        Me.PasswordTb.IconRightOffset = New System.Drawing.Point(5, 0)
        Me.PasswordTb.Location = New System.Drawing.Point(375, 216)
        Me.PasswordTb.Name = "PasswordTb"
        Me.PasswordTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.PasswordTb.PlaceholderText = "Password"
        Me.PasswordTb.SelectedText = ""
        Me.PasswordTb.Size = New System.Drawing.Size(269, 45)
        Me.PasswordTb.TabIndex = 4
        Me.PasswordTb.TextOffset = New System.Drawing.Point(10, 0)
        Me.PasswordTb.UseSystemPasswordChar = True
        '
        'UnameTb
        '
        Me.UnameTb.Animated = True
        Me.UnameTb.AutoRoundedCorners = True
        Me.UnameTb.BorderColor = System.Drawing.Color.Blue
        Me.UnameTb.BorderRadius = 21
        Me.UnameTb.BorderThickness = 2
        Me.UnameTb.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.UnameTb.DefaultText = ""
        Me.UnameTb.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.UnameTb.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.UnameTb.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UnameTb.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.UnameTb.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UnameTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnameTb.ForeColor = System.Drawing.Color.Black
        Me.UnameTb.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.UnameTb.IconLeftOffset = New System.Drawing.Point(7, 0)
        Me.UnameTb.IconRight = Global.CafeManagementSystem.My.Resources.Resources.user1
        Me.UnameTb.IconRightOffset = New System.Drawing.Point(5, 0)
        Me.UnameTb.Location = New System.Drawing.Point(375, 150)
        Me.UnameTb.Name = "UnameTb"
        Me.UnameTb.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.UnameTb.PlaceholderText = "Username"
        Me.UnameTb.SelectedText = ""
        Me.UnameTb.Size = New System.Drawing.Size(269, 45)
        Me.UnameTb.TabIndex = 3
        Me.UnameTb.TextOffset = New System.Drawing.Point(10, 0)
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.CafeManagementSystem.My.Resources.Resources.cafe
        Me.PictureBox2.Location = New System.Drawing.Point(318, 57)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(54, 54)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.CafeManagementSystem.My.Resources.Resources.묹턜_포카는_영만이에게_on_Twitter___レトロ_背景__おしゃれな壁紙背景__レトロ_壁紙
        Me.PictureBox1.Location = New System.Drawing.Point(-3, -45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(287, 584)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 410)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.PasswordTb)
        Me.Controls.Add(Me.UnameTb)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents UnameTb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents PasswordTb As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents PictureBox2 As PictureBox
End Class
