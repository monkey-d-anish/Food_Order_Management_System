<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Register_form
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LnameTb = New System.Windows.Forms.TextBox()
        Me.FnameTb = New System.Windows.Forms.TextBox()
        Me.PhoneTb = New System.Windows.Forms.TextBox()
        Me.CpasswordTb = New System.Windows.Forms.TextBox()
        Me.PasswordTb = New System.Windows.Forms.TextBox()
        Me.EmailTb = New System.Windows.Forms.TextBox()
        Me.SignupBtn = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider3 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider4 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider5 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider6 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(105, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(457, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Signup to Resturant Food Order Management"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(59, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(371, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 23)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Last Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(59, 226)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 23)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Email Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(371, 226)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 23)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Mobile Number"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(59, 335)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 23)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Enter Password"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(371, 335)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(156, 23)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Confirm Password"
        '
        'LnameTb
        '
        Me.LnameTb.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnameTb.Location = New System.Drawing.Point(375, 153)
        Me.LnameTb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LnameTb.Name = "LnameTb"
        Me.LnameTb.Size = New System.Drawing.Size(205, 27)
        Me.LnameTb.TabIndex = 7
        '
        'FnameTb
        '
        Me.FnameTb.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FnameTb.Location = New System.Drawing.Point(61, 153)
        Me.FnameTb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.FnameTb.Name = "FnameTb"
        Me.FnameTb.Size = New System.Drawing.Size(205, 27)
        Me.FnameTb.TabIndex = 8
        '
        'PhoneTb
        '
        Me.PhoneTb.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneTb.Location = New System.Drawing.Point(375, 270)
        Me.PhoneTb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PhoneTb.Name = "PhoneTb"
        Me.PhoneTb.Size = New System.Drawing.Size(205, 27)
        Me.PhoneTb.TabIndex = 9
        '
        'CpasswordTb
        '
        Me.CpasswordTb.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CpasswordTb.Location = New System.Drawing.Point(375, 382)
        Me.CpasswordTb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.CpasswordTb.Name = "CpasswordTb"
        Me.CpasswordTb.Size = New System.Drawing.Size(205, 27)
        Me.CpasswordTb.TabIndex = 10
        '
        'PasswordTb
        '
        Me.PasswordTb.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTb.Location = New System.Drawing.Point(61, 382)
        Me.PasswordTb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PasswordTb.Name = "PasswordTb"
        Me.PasswordTb.Size = New System.Drawing.Size(205, 27)
        Me.PasswordTb.TabIndex = 11
        '
        'EmailTb
        '
        Me.EmailTb.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTb.Location = New System.Drawing.Point(61, 270)
        Me.EmailTb.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.EmailTb.Name = "EmailTb"
        Me.EmailTb.Size = New System.Drawing.Size(205, 27)
        Me.EmailTb.TabIndex = 12
        '
        'SignupBtn
        '
        Me.SignupBtn.BackColor = System.Drawing.Color.Yellow
        Me.SignupBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignupBtn.Location = New System.Drawing.Point(61, 443)
        Me.SignupBtn.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SignupBtn.Name = "SignupBtn"
        Me.SignupBtn.Size = New System.Drawing.Size(592, 46)
        Me.SignupBtn.TabIndex = 13
        Me.SignupBtn.Text = "Signup"
        Me.SignupBtn.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(172, 510)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(211, 23)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Already have an account? "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(371, 510)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 23)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Sign in"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(683, 1)
        Me.Button2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(31, 36)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "X"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'ErrorProvider3
        '
        Me.ErrorProvider3.ContainerControl = Me
        '
        'ErrorProvider4
        '
        Me.ErrorProvider4.ContainerControl = Me
        '
        'ErrorProvider5
        '
        Me.ErrorProvider5.ContainerControl = Me
        '
        'ErrorProvider6
        '
        Me.ErrorProvider6.ContainerControl = Me
        '
        'Register_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 553)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.SignupBtn)
        Me.Controls.Add(Me.EmailTb)
        Me.Controls.Add(Me.PasswordTb)
        Me.Controls.Add(Me.CpasswordTb)
        Me.Controls.Add(Me.PhoneTb)
        Me.Controls.Add(Me.FnameTb)
        Me.Controls.Add(Me.LnameTb)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Register_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LnameTb As TextBox
    Friend WithEvents FnameTb As TextBox
    Friend WithEvents PhoneTb As TextBox
    Friend WithEvents CpasswordTb As TextBox
    Friend WithEvents PasswordTb As TextBox
    Friend WithEvents EmailTb As TextBox
    Friend WithEvents SignupBtn As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents ErrorProvider3 As ErrorProvider
    Friend WithEvents ErrorProvider4 As ErrorProvider
    Friend WithEvents ErrorProvider5 As ErrorProvider
    Friend WithEvents ErrorProvider6 As ErrorProvider
End Class
