<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin_Panel_AddCategoryForm
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
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.AddCategoryLbl = New System.Windows.Forms.Label()
        Me.tblcategorybtn = New System.Windows.Forms.Button()
        Me.itmcategorybtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ExitBtn
        '
        Me.ExitBtn.BackColor = System.Drawing.Color.IndianRed
        Me.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ExitBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitBtn.Location = New System.Drawing.Point(434, 1)
        Me.ExitBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(23, 25)
        Me.ExitBtn.TabIndex = 1
        Me.ExitBtn.Text = "X"
        Me.ExitBtn.UseVisualStyleBackColor = False
        '
        'AddCategoryLbl
        '
        Me.AddCategoryLbl.AutoSize = True
        Me.AddCategoryLbl.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.AddCategoryLbl.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddCategoryLbl.Location = New System.Drawing.Point(1, 1)
        Me.AddCategoryLbl.Name = "AddCategoryLbl"
        Me.AddCategoryLbl.Size = New System.Drawing.Size(207, 40)
        Me.AddCategoryLbl.TabIndex = 2
        Me.AddCategoryLbl.Text = "Add Category"
        '
        'tblcategorybtn
        '
        Me.tblcategorybtn.BackColor = System.Drawing.Color.DimGray
        Me.tblcategorybtn.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tblcategorybtn.Location = New System.Drawing.Point(12, 118)
        Me.tblcategorybtn.Name = "tblcategorybtn"
        Me.tblcategorybtn.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.tblcategorybtn.Size = New System.Drawing.Size(196, 68)
        Me.tblcategorybtn.TabIndex = 3
        Me.tblcategorybtn.Text = "Table Category"
        Me.tblcategorybtn.UseVisualStyleBackColor = False
        '
        'itmcategorybtn
        '
        Me.itmcategorybtn.BackColor = System.Drawing.Color.DimGray
        Me.itmcategorybtn.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itmcategorybtn.Location = New System.Drawing.Point(240, 118)
        Me.itmcategorybtn.Name = "itmcategorybtn"
        Me.itmcategorybtn.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.itmcategorybtn.Size = New System.Drawing.Size(196, 68)
        Me.itmcategorybtn.TabIndex = 4
        Me.itmcategorybtn.Text = "Item Category"
        Me.itmcategorybtn.UseVisualStyleBackColor = False
        '
        'Admin_Panel_AddCategoryForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(458, 228)
        Me.Controls.Add(Me.itmcategorybtn)
        Me.Controls.Add(Me.tblcategorybtn)
        Me.Controls.Add(Me.AddCategoryLbl)
        Me.Controls.Add(Me.ExitBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Admin_Panel_AddCategoryForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AddCategory"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ExitBtn As Button
    Friend WithEvents AddCategoryLbl As Label
    Friend WithEvents tblcategorybtn As Button
    Friend WithEvents itmcategorybtn As Button
End Class
