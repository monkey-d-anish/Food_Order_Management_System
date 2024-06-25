<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Stable_form
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Stable_DGV = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Tableno_tb = New System.Windows.Forms.TextBox()
        Me.CusContact_tb = New System.Windows.Forms.TextBox()
        Me.Itemsbtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.Stable_DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Moccasin
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(981, 42)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.IndianRed
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(919, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(46, 40)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(14, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(302, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "FOOD ORDER MANAGEMENT SYSTEM"
        '
        'Stable_DGV
        '
        Me.Stable_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Stable_DGV.Location = New System.Drawing.Point(9, 94)
        Me.Stable_DGV.Name = "Stable_DGV"
        Me.Stable_DGV.RowHeadersWidth = 51
        Me.Stable_DGV.RowTemplate.Height = 24
        Me.Stable_DGV.Size = New System.Drawing.Size(956, 432)
        Me.Stable_DGV.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 31)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Select Table"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(96, 550)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 28)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Table no :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 587)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(178, 28)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Customer Contact :"
        '
        'Tableno_tb
        '
        Me.Tableno_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Tableno_tb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tableno_tb.Location = New System.Drawing.Point(205, 544)
        Me.Tableno_tb.Name = "Tableno_tb"
        Me.Tableno_tb.Size = New System.Drawing.Size(330, 34)
        Me.Tableno_tb.TabIndex = 5
        '
        'CusContact_tb
        '
        Me.CusContact_tb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CusContact_tb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CusContact_tb.Location = New System.Drawing.Point(205, 593)
        Me.CusContact_tb.Name = "CusContact_tb"
        Me.CusContact_tb.Size = New System.Drawing.Size(330, 34)
        Me.CusContact_tb.TabIndex = 6
        '
        'Itemsbtn
        '
        Me.Itemsbtn.BackColor = System.Drawing.Color.Silver
        Me.Itemsbtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Itemsbtn.Location = New System.Drawing.Point(779, 563)
        Me.Itemsbtn.Name = "Itemsbtn"
        Me.Itemsbtn.Size = New System.Drawing.Size(186, 64)
        Me.Itemsbtn.TabIndex = 7
        Me.Itemsbtn.Text = "Next"
        Me.Itemsbtn.UseVisualStyleBackColor = False
        '
        'Stable_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(981, 639)
        Me.Controls.Add(Me.Itemsbtn)
        Me.Controls.Add(Me.CusContact_tb)
        Me.Controls.Add(Me.Tableno_tb)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Stable_DGV)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Stable_form"
        Me.Text = "Stable_form"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Stable_DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Stable_DGV As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Tableno_tb As TextBox
    Friend WithEvents CusContact_tb As TextBox
    Friend WithEvents Itemsbtn As Button
End Class
