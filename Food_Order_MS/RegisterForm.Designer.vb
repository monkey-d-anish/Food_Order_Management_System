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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LnameTb = New System.Windows.Forms.TextBox()
        Me.FnameTb = New System.Windows.Forms.TextBox()
        Me.PhoneTb = New System.Windows.Forms.TextBox()
        Me.CpasswordTb = New System.Windows.Forms.TextBox()
        Me.PasswordTb = New System.Windows.Forms.TextBox()
        Me.AddUserBtn = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.UserNameTb = New System.Windows.Forms.TextBox()
        Me.UserNameLbl = New System.Windows.Forms.Label()
        Me.IsAdminChkB = New System.Windows.Forms.CheckBox()
        Me.UpdateBtn = New System.Windows.Forms.Button()
        Me.RemoveUserBtn = New System.Windows.Forms.Button()
        Me.UsersDgv = New System.Windows.Forms.DataGridView()
        Me.UserIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UserNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsAdminDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.UspGetUsersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Poject_FOMSDataSet5 = New Food_Order_MS.Poject_FOMSDataSet5()
        Me.Usp_Get_UsersTableAdapter = New Food_Order_MS.Poject_FOMSDataSet5TableAdapters.Usp_Get_UsersTableAdapter()
        Me.UserIdLbl = New System.Windows.Forms.Label()
        Me.ResetBtn = New System.Windows.Forms.Button()
        CType(Me.UsersDgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UspGetUsersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Poject_FOMSDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(79, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(377, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Signup to Resturant Food Order Management"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(47, 97)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(45, 167)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Last Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(47, 232)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Mobile Number"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(277, 167)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 19)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Enter Password"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(278, 232)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 19)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Confirm Password"
        '
        'LnameTb
        '
        Me.LnameTb.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LnameTb.Location = New System.Drawing.Point(48, 192)
        Me.LnameTb.Margin = New System.Windows.Forms.Padding(2)
        Me.LnameTb.Name = "LnameTb"
        Me.LnameTb.Size = New System.Drawing.Size(155, 23)
        Me.LnameTb.TabIndex = 7
        '
        'FnameTb
        '
        Me.FnameTb.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FnameTb.Location = New System.Drawing.Point(46, 124)
        Me.FnameTb.Margin = New System.Windows.Forms.Padding(2)
        Me.FnameTb.Name = "FnameTb"
        Me.FnameTb.Size = New System.Drawing.Size(155, 23)
        Me.FnameTb.TabIndex = 8
        '
        'PhoneTb
        '
        Me.PhoneTb.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PhoneTb.Location = New System.Drawing.Point(50, 257)
        Me.PhoneTb.Margin = New System.Windows.Forms.Padding(2)
        Me.PhoneTb.Name = "PhoneTb"
        Me.PhoneTb.Size = New System.Drawing.Size(155, 23)
        Me.PhoneTb.TabIndex = 9
        '
        'CpasswordTb
        '
        Me.CpasswordTb.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CpasswordTb.Location = New System.Drawing.Point(281, 256)
        Me.CpasswordTb.Margin = New System.Windows.Forms.Padding(2)
        Me.CpasswordTb.Name = "CpasswordTb"
        Me.CpasswordTb.Size = New System.Drawing.Size(155, 23)
        Me.CpasswordTb.TabIndex = 10
        '
        'PasswordTb
        '
        Me.PasswordTb.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTb.Location = New System.Drawing.Point(281, 192)
        Me.PasswordTb.Margin = New System.Windows.Forms.Padding(2)
        Me.PasswordTb.Name = "PasswordTb"
        Me.PasswordTb.Size = New System.Drawing.Size(155, 23)
        Me.PasswordTb.TabIndex = 11
        '
        'AddUserBtn
        '
        Me.AddUserBtn.BackColor = System.Drawing.Color.Yellow
        Me.AddUserBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddUserBtn.Location = New System.Drawing.Point(72, 360)
        Me.AddUserBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.AddUserBtn.Name = "AddUserBtn"
        Me.AddUserBtn.Size = New System.Drawing.Size(327, 37)
        Me.AddUserBtn.TabIndex = 13
        Me.AddUserBtn.Text = "Add User"
        Me.AddUserBtn.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(1201, 11)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(23, 29)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "X"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'UserNameTb
        '
        Me.UserNameTb.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserNameTb.Location = New System.Drawing.Point(281, 124)
        Me.UserNameTb.Margin = New System.Windows.Forms.Padding(2)
        Me.UserNameTb.Name = "UserNameTb"
        Me.UserNameTb.Size = New System.Drawing.Size(155, 23)
        Me.UserNameTb.TabIndex = 18
        '
        'UserNameLbl
        '
        Me.UserNameLbl.AutoSize = True
        Me.UserNameLbl.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserNameLbl.Location = New System.Drawing.Point(278, 93)
        Me.UserNameLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.UserNameLbl.Name = "UserNameLbl"
        Me.UserNameLbl.Size = New System.Drawing.Size(121, 19)
        Me.UserNameLbl.TabIndex = 17
        Me.UserNameLbl.Text = "Enter User Name"
        '
        'IsAdminChkB
        '
        Me.IsAdminChkB.BackColor = System.Drawing.Color.Crimson
        Me.IsAdminChkB.FlatAppearance.BorderSize = 0
        Me.IsAdminChkB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IsAdminChkB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsAdminChkB.Location = New System.Drawing.Point(301, 303)
        Me.IsAdminChkB.Name = "IsAdminChkB"
        Me.IsAdminChkB.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.IsAdminChkB.Size = New System.Drawing.Size(125, 33)
        Me.IsAdminChkB.TabIndex = 19
        Me.IsAdminChkB.Text = "Is Admin"
        Me.IsAdminChkB.UseVisualStyleBackColor = False
        '
        'UpdateBtn
        '
        Me.UpdateBtn.BackColor = System.Drawing.Color.Yellow
        Me.UpdateBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateBtn.Location = New System.Drawing.Point(72, 414)
        Me.UpdateBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.Size = New System.Drawing.Size(327, 37)
        Me.UpdateBtn.TabIndex = 20
        Me.UpdateBtn.Text = "Update User"
        Me.UpdateBtn.UseVisualStyleBackColor = False
        '
        'RemoveUserBtn
        '
        Me.RemoveUserBtn.BackColor = System.Drawing.Color.Yellow
        Me.RemoveUserBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemoveUserBtn.Location = New System.Drawing.Point(72, 467)
        Me.RemoveUserBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.RemoveUserBtn.Name = "RemoveUserBtn"
        Me.RemoveUserBtn.Size = New System.Drawing.Size(327, 37)
        Me.RemoveUserBtn.TabIndex = 21
        Me.RemoveUserBtn.Text = "Remove User"
        Me.RemoveUserBtn.UseVisualStyleBackColor = False
        '
        'UsersDgv
        '
        Me.UsersDgv.AllowUserToAddRows = False
        Me.UsersDgv.AllowUserToDeleteRows = False
        Me.UsersDgv.AutoGenerateColumns = False
        Me.UsersDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.UsersDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsersDgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UserIdDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.PhoneNumberDataGridViewTextBoxColumn, Me.UserNameDataGridViewTextBoxColumn, Me.IsAdminDataGridViewCheckBoxColumn})
        Me.UsersDgv.DataSource = Me.UspGetUsersBindingSource
        Me.UsersDgv.Location = New System.Drawing.Point(514, 59)
        Me.UsersDgv.Name = "UsersDgv"
        Me.UsersDgv.ReadOnly = True
        Me.UsersDgv.RowHeadersVisible = False
        Me.UsersDgv.Size = New System.Drawing.Size(690, 445)
        Me.UsersDgv.TabIndex = 22
        '
        'UserIdDataGridViewTextBoxColumn
        '
        Me.UserIdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.UserIdDataGridViewTextBoxColumn.DataPropertyName = "User Id"
        Me.UserIdDataGridViewTextBoxColumn.FillWeight = 50.0!
        Me.UserIdDataGridViewTextBoxColumn.HeaderText = "User Id"
        Me.UserIdDataGridViewTextBoxColumn.Name = "UserIdDataGridViewTextBoxColumn"
        Me.UserIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        Me.LastNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PhoneNumberDataGridViewTextBoxColumn
        '
        Me.PhoneNumberDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "Phone Number"
        Me.PhoneNumberDataGridViewTextBoxColumn.HeaderText = "Phone Number"
        Me.PhoneNumberDataGridViewTextBoxColumn.Name = "PhoneNumberDataGridViewTextBoxColumn"
        Me.PhoneNumberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UserNameDataGridViewTextBoxColumn
        '
        Me.UserNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.UserNameDataGridViewTextBoxColumn.DataPropertyName = "User Name"
        Me.UserNameDataGridViewTextBoxColumn.HeaderText = "User Name"
        Me.UserNameDataGridViewTextBoxColumn.Name = "UserNameDataGridViewTextBoxColumn"
        Me.UserNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IsAdminDataGridViewCheckBoxColumn
        '
        Me.IsAdminDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IsAdminDataGridViewCheckBoxColumn.DataPropertyName = "Is Admin"
        Me.IsAdminDataGridViewCheckBoxColumn.FillWeight = 50.0!
        Me.IsAdminDataGridViewCheckBoxColumn.HeaderText = "Is Admin"
        Me.IsAdminDataGridViewCheckBoxColumn.Name = "IsAdminDataGridViewCheckBoxColumn"
        Me.IsAdminDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'UspGetUsersBindingSource
        '
        Me.UspGetUsersBindingSource.DataMember = "Usp_Get_Users"
        Me.UspGetUsersBindingSource.DataSource = Me.Poject_FOMSDataSet5
        '
        'Poject_FOMSDataSet5
        '
        Me.Poject_FOMSDataSet5.DataSetName = "Poject_FOMSDataSet5"
        Me.Poject_FOMSDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Usp_Get_UsersTableAdapter
        '
        Me.Usp_Get_UsersTableAdapter.ClearBeforeFill = True
        '
        'UserIdLbl
        '
        Me.UserIdLbl.AutoSize = True
        Me.UserIdLbl.Location = New System.Drawing.Point(46, 59)
        Me.UserIdLbl.Name = "UserIdLbl"
        Me.UserIdLbl.Size = New System.Drawing.Size(0, 13)
        Me.UserIdLbl.TabIndex = 23
        Me.UserIdLbl.Visible = False
        '
        'ResetBtn
        '
        Me.ResetBtn.BackColor = System.Drawing.SystemColors.Control
        Me.ResetBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetBtn.Location = New System.Drawing.Point(46, 326)
        Me.ResetBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.Size = New System.Drawing.Size(92, 30)
        Me.ResetBtn.TabIndex = 24
        Me.ResetBtn.Text = "Reset"
        Me.ResetBtn.UseVisualStyleBackColor = False
        '
        'Register_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1235, 520)
        Me.Controls.Add(Me.ResetBtn)
        Me.Controls.Add(Me.UserIdLbl)
        Me.Controls.Add(Me.UsersDgv)
        Me.Controls.Add(Me.RemoveUserBtn)
        Me.Controls.Add(Me.UpdateBtn)
        Me.Controls.Add(Me.IsAdminChkB)
        Me.Controls.Add(Me.UserNameTb)
        Me.Controls.Add(Me.UserNameLbl)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.AddUserBtn)
        Me.Controls.Add(Me.PasswordTb)
        Me.Controls.Add(Me.CpasswordTb)
        Me.Controls.Add(Me.PhoneTb)
        Me.Controls.Add(Me.FnameTb)
        Me.Controls.Add(Me.LnameTb)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Register_form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.UsersDgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UspGetUsersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Poject_FOMSDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents LnameTb As TextBox
    Friend WithEvents FnameTb As TextBox
    Friend WithEvents PhoneTb As TextBox
    Friend WithEvents CpasswordTb As TextBox
    Friend WithEvents PasswordTb As TextBox
    Friend WithEvents AddUserBtn As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents UserNameTb As TextBox
    Friend WithEvents UserNameLbl As Label
    Friend WithEvents IsAdminChkB As CheckBox
    Friend WithEvents UpdateBtn As Button
    Friend WithEvents RemoveUserBtn As Button
    Friend WithEvents UsersDgv As DataGridView
    Friend WithEvents Poject_FOMSDataSet5 As Poject_FOMSDataSet5
    Friend WithEvents UspGetUsersBindingSource As BindingSource
    Friend WithEvents Usp_Get_UsersTableAdapter As Poject_FOMSDataSet5TableAdapters.Usp_Get_UsersTableAdapter
    Friend WithEvents UserIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PhoneNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UserNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IsAdminDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents UserIdLbl As Label
    Friend WithEvents ResetBtn As Button
End Class
