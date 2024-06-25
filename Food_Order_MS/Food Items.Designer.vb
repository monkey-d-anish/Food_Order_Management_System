<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Food_Items
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
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TblNolbl = New System.Windows.Forms.Label()
        Me.CusNulbl = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AddtoCartBtn = New System.Windows.Forms.Button()
        Me.namelbl = New System.Windows.Forms.Label()
        Me.QuantityTb = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.OrderBtn = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.UpdateBtn = New System.Windows.Forms.Button()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.Dltallbtn = New System.Windows.Forms.Button()
        Me.Cart_DGV = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.Cart_DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Moccasin
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1200, 35)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(248, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "FOOD ORDER MANAGEMENT SYSTEM"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.IndianRed
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1164, 0)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 32)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Controls.Add(Me.CusNulbl)
        Me.Panel2.Controls.Add(Me.TblNolbl)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(861, 58)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(326, 89)
        Me.Panel2.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(70, 17)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Table no :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(2, 47)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 21)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Customer Contact :"
        '
        'TblNolbl
        '
        Me.TblNolbl.AutoSize = True
        Me.TblNolbl.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TblNolbl.ForeColor = System.Drawing.Color.Black
        Me.TblNolbl.Location = New System.Drawing.Point(148, 17)
        Me.TblNolbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TblNolbl.Name = "TblNolbl"
        Me.TblNolbl.Size = New System.Drawing.Size(56, 21)
        Me.TblNolbl.TabIndex = 6
        Me.TblNolbl.Text = "Tbl No"
        '
        'CusNulbl
        '
        Me.CusNulbl.AutoSize = True
        Me.CusNulbl.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CusNulbl.ForeColor = System.Drawing.Color.Black
        Me.CusNulbl.Location = New System.Drawing.Point(148, 47)
        Me.CusNulbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.CusNulbl.Name = "CusNulbl"
        Me.CusNulbl.Size = New System.Drawing.Size(63, 21)
        Me.CusNulbl.TabIndex = 7
        Me.CusNulbl.Text = "Contact"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel3.Controls.Add(Me.QuantityTb)
        Me.Panel3.Controls.Add(Me.namelbl)
        Me.Panel3.Controls.Add(Me.AddtoCartBtn)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(861, 167)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(326, 201)
        Me.Panel3.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(101, 15)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 25)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Food Item"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(7, 96)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 21)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Quantity :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(25, 63)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 21)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Name :"
        '
        'AddtoCartBtn
        '
        Me.AddtoCartBtn.BackColor = System.Drawing.Color.White
        Me.AddtoCartBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddtoCartBtn.ForeColor = System.Drawing.Color.Black
        Me.AddtoCartBtn.Location = New System.Drawing.Point(106, 141)
        Me.AddtoCartBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.AddtoCartBtn.Name = "AddtoCartBtn"
        Me.AddtoCartBtn.Size = New System.Drawing.Size(104, 35)
        Me.AddtoCartBtn.TabIndex = 18
        Me.AddtoCartBtn.Text = "Add to Cart"
        Me.AddtoCartBtn.UseVisualStyleBackColor = False
        '
        'namelbl
        '
        Me.namelbl.AutoSize = True
        Me.namelbl.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.namelbl.ForeColor = System.Drawing.Color.Black
        Me.namelbl.Location = New System.Drawing.Point(102, 63)
        Me.namelbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.namelbl.Name = "namelbl"
        Me.namelbl.Size = New System.Drawing.Size(44, 21)
        Me.namelbl.TabIndex = 19
        Me.namelbl.Text = "Nam"
        '
        'QuantityTb
        '
        Me.QuantityTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.QuantityTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityTb.Location = New System.Drawing.Point(97, 93)
        Me.QuantityTb.Margin = New System.Windows.Forms.Padding(2)
        Me.QuantityTb.Name = "QuantityTb"
        Me.QuantityTb.Size = New System.Drawing.Size(139, 24)
        Me.QuantityTb.TabIndex = 20
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Cart_DGV)
        Me.Panel4.Controls.Add(Me.Dltallbtn)
        Me.Panel4.Controls.Add(Me.DeleteBtn)
        Me.Panel4.Controls.Add(Me.UpdateBtn)
        Me.Panel4.Controls.Add(Me.OrderBtn)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(861, 386)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(326, 402)
        Me.Panel4.TabIndex = 4
        '
        'OrderBtn
        '
        Me.OrderBtn.BackColor = System.Drawing.Color.White
        Me.OrderBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderBtn.ForeColor = System.Drawing.Color.Black
        Me.OrderBtn.Location = New System.Drawing.Point(114, 317)
        Me.OrderBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.OrderBtn.Name = "OrderBtn"
        Me.OrderBtn.Size = New System.Drawing.Size(104, 35)
        Me.OrderBtn.TabIndex = 18
        Me.OrderBtn.Text = "Order"
        Me.OrderBtn.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(107, 11)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 25)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Your Cart"
        '
        'UpdateBtn
        '
        Me.UpdateBtn.BackColor = System.Drawing.Color.White
        Me.UpdateBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateBtn.ForeColor = System.Drawing.Color.Black
        Me.UpdateBtn.Location = New System.Drawing.Point(6, 356)
        Me.UpdateBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.Size = New System.Drawing.Size(104, 35)
        Me.UpdateBtn.TabIndex = 19
        Me.UpdateBtn.Text = "Update"
        Me.UpdateBtn.UseVisualStyleBackColor = False
        '
        'DeleteBtn
        '
        Me.DeleteBtn.BackColor = System.Drawing.Color.White
        Me.DeleteBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBtn.ForeColor = System.Drawing.Color.Black
        Me.DeleteBtn.Location = New System.Drawing.Point(114, 356)
        Me.DeleteBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(104, 35)
        Me.DeleteBtn.TabIndex = 20
        Me.DeleteBtn.Text = "Delete"
        Me.DeleteBtn.UseVisualStyleBackColor = False
        '
        'Dltallbtn
        '
        Me.Dltallbtn.BackColor = System.Drawing.Color.White
        Me.Dltallbtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dltallbtn.ForeColor = System.Drawing.Color.Black
        Me.Dltallbtn.Location = New System.Drawing.Point(220, 356)
        Me.Dltallbtn.Margin = New System.Windows.Forms.Padding(2)
        Me.Dltallbtn.Name = "Dltallbtn"
        Me.Dltallbtn.Size = New System.Drawing.Size(104, 35)
        Me.Dltallbtn.TabIndex = 21
        Me.Dltallbtn.Text = "Delete All"
        Me.Dltallbtn.UseVisualStyleBackColor = False
        '
        'Cart_DGV
        '
        Me.Cart_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Cart_DGV.Location = New System.Drawing.Point(6, 51)
        Me.Cart_DGV.Name = "Cart_DGV"
        Me.Cart_DGV.Size = New System.Drawing.Size(317, 247)
        Me.Cart_DGV.TabIndex = 22
        '
        'Food_Items
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1200, 800)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Food_Items"
        Me.Text = "v"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.Cart_DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents CusNulbl As Label
    Friend WithEvents TblNolbl As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents AddtoCartBtn As Button
    Friend WithEvents namelbl As Label
    Friend WithEvents QuantityTb As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents OrderBtn As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Cart_DGV As DataGridView
    Friend WithEvents Dltallbtn As Button
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents UpdateBtn As Button
End Class
