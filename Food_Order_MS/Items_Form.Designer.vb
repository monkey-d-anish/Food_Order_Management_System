<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Items_Form
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Items_Form))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Items_DGV = New System.Windows.Forms.DataGridView()
        Me.Name_lbl = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ItemnameTb = New System.Windows.Forms.TextBox()
        Me.ItemunitTb = New System.Windows.Forms.TextBox()
        Me.ItempriceTb = New System.Windows.Forms.TextBox()
        Me.ItemcategoryCb = New System.Windows.Forms.ComboBox()
        Me.ImagePnl = New System.Windows.Forms.Panel()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.UpdateBtn = New System.Windows.Forms.Button()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.ResetBtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Items_DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gold
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1100, 35)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.IndianRed
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1061, 1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(36, 31)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(214, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = " Food Order Management "
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.AliceBlue
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 35)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(42, 44)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(45, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 38)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Items"
        '
        'Items_DGV
        '
        Me.Items_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Items_DGV.Location = New System.Drawing.Point(474, 78)
        Me.Items_DGV.Name = "Items_DGV"
        Me.Items_DGV.RowHeadersWidth = 51
        Me.Items_DGV.RowTemplate.Height = 24
        Me.Items_DGV.Size = New System.Drawing.Size(614, 610)
        Me.Items_DGV.TabIndex = 3
        '
        'Name_lbl
        '
        Me.Name_lbl.AutoSize = True
        Me.Name_lbl.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_lbl.Location = New System.Drawing.Point(34, 142)
        Me.Name_lbl.Name = "Name_lbl"
        Me.Name_lbl.Size = New System.Drawing.Size(64, 25)
        Me.Name_lbl.TabIndex = 4
        Me.Name_lbl.Text = "Name "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(46, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Unit"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(42, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Price"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 284)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 25)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Category"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(87, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(87, 195)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(15, 20)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(87, 236)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(15, 20)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = ":"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(87, 288)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 20)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = ":"
        '
        'ItemnameTb
        '
        Me.ItemnameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ItemnameTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemnameTb.Location = New System.Drawing.Point(108, 143)
        Me.ItemnameTb.Name = "ItemnameTb"
        Me.ItemnameTb.Size = New System.Drawing.Size(253, 28)
        Me.ItemnameTb.TabIndex = 12
        '
        'ItemunitTb
        '
        Me.ItemunitTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ItemunitTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemunitTb.Location = New System.Drawing.Point(108, 195)
        Me.ItemunitTb.Name = "ItemunitTb"
        Me.ItemunitTb.Size = New System.Drawing.Size(253, 28)
        Me.ItemunitTb.TabIndex = 13
        '
        'ItempriceTb
        '
        Me.ItempriceTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ItempriceTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItempriceTb.Location = New System.Drawing.Point(108, 236)
        Me.ItempriceTb.Name = "ItempriceTb"
        Me.ItempriceTb.Size = New System.Drawing.Size(253, 28)
        Me.ItempriceTb.TabIndex = 14
        '
        'ItemcategoryCb
        '
        Me.ItemcategoryCb.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ItemcategoryCb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemcategoryCb.FormattingEnabled = True
        Me.ItemcategoryCb.Location = New System.Drawing.Point(108, 280)
        Me.ItemcategoryCb.Name = "ItemcategoryCb"
        Me.ItemcategoryCb.Size = New System.Drawing.Size(253, 30)
        Me.ItemcategoryCb.TabIndex = 15
        '
        'ImagePnl
        '
        Me.ImagePnl.BackColor = System.Drawing.SystemColors.GrayText
        Me.ImagePnl.Location = New System.Drawing.Point(149, 346)
        Me.ImagePnl.Name = "ImagePnl"
        Me.ImagePnl.Size = New System.Drawing.Size(138, 116)
        Me.ImagePnl.TabIndex = 16
        '
        'AddBtn
        '
        Me.AddBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBtn.Location = New System.Drawing.Point(12, 619)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(138, 43)
        Me.AddBtn.TabIndex = 17
        Me.AddBtn.Text = "Add Item"
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'UpdateBtn
        '
        Me.UpdateBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateBtn.Location = New System.Drawing.Point(162, 619)
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.Size = New System.Drawing.Size(138, 43)
        Me.UpdateBtn.TabIndex = 18
        Me.UpdateBtn.Text = "Update Item"
        Me.UpdateBtn.UseVisualStyleBackColor = True
        '
        'DeleteBtn
        '
        Me.DeleteBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBtn.Location = New System.Drawing.Point(319, 619)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(138, 43)
        Me.DeleteBtn.TabIndex = 19
        Me.DeleteBtn.Text = "Delete Item"
        Me.DeleteBtn.UseVisualStyleBackColor = True
        '
        'ResetBtn
        '
        Me.ResetBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ResetBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetBtn.Location = New System.Drawing.Point(162, 560)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.Size = New System.Drawing.Size(138, 43)
        Me.ResetBtn.TabIndex = 20
        Me.ResetBtn.Text = "Reset"
        Me.ResetBtn.UseVisualStyleBackColor = False
        '
        'Items_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1100, 700)
        Me.Controls.Add(Me.ResetBtn)
        Me.Controls.Add(Me.DeleteBtn)
        Me.Controls.Add(Me.UpdateBtn)
        Me.Controls.Add(Me.AddBtn)
        Me.Controls.Add(Me.ImagePnl)
        Me.Controls.Add(Me.ItemcategoryCb)
        Me.Controls.Add(Me.ItempriceTb)
        Me.Controls.Add(Me.ItemunitTb)
        Me.Controls.Add(Me.ItemnameTb)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Name_lbl)
        Me.Controls.Add(Me.Items_DGV)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Items_Form"
        Me.Text = "Items_Form"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Items_DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Items_DGV As DataGridView
    Friend WithEvents Name_lbl As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ItemnameTb As TextBox
    Friend WithEvents ItemunitTb As TextBox
    Friend WithEvents ItempriceTb As TextBox
    Friend WithEvents ItemcategoryCb As ComboBox
    Friend WithEvents ImagePnl As Panel
    Friend WithEvents AddBtn As Button
    Friend WithEvents UpdateBtn As Button
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents ResetBtn As Button
End Class
