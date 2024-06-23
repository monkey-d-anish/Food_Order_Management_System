<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transaction_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transaction_Form))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Transaction_DGV = New System.Windows.Forms.DataGridView()
        Me.TrsViewBtn = New System.Windows.Forms.Button()
        Me.TrsRemoveBtn = New System.Windows.Forms.Button()
        Me.TrsDeleteBtn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Transaction_DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gold
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1000, 35)
        Me.Panel1.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.IndianRed
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(964, 1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(36, 31)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "X"
        Me.Button2.UseVisualStyleBackColor = False
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
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.IndianRed
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1064, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(36, 31)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 38)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Transaction"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.AliceBlue
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(5, 36)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(42, 44)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        '
        'Transaction_DGV
        '
        Me.Transaction_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Transaction_DGV.Location = New System.Drawing.Point(12, 90)
        Me.Transaction_DGV.Name = "Transaction_DGV"
        Me.Transaction_DGV.RowHeadersWidth = 51
        Me.Transaction_DGV.RowTemplate.Height = 24
        Me.Transaction_DGV.Size = New System.Drawing.Size(802, 602)
        Me.Transaction_DGV.TabIndex = 29
        '
        'TrsViewBtn
        '
        Me.TrsViewBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrsViewBtn.Location = New System.Drawing.Point(840, 498)
        Me.TrsViewBtn.Name = "TrsViewBtn"
        Me.TrsViewBtn.Size = New System.Drawing.Size(138, 43)
        Me.TrsViewBtn.TabIndex = 30
        Me.TrsViewBtn.Text = "View Details"
        Me.TrsViewBtn.UseVisualStyleBackColor = True
        '
        'TrsRemoveBtn
        '
        Me.TrsRemoveBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrsRemoveBtn.Location = New System.Drawing.Point(840, 573)
        Me.TrsRemoveBtn.Name = "TrsRemoveBtn"
        Me.TrsRemoveBtn.Size = New System.Drawing.Size(138, 43)
        Me.TrsRemoveBtn.TabIndex = 31
        Me.TrsRemoveBtn.Text = "Remove "
        Me.TrsRemoveBtn.UseVisualStyleBackColor = True
        '
        'TrsDeleteBtn
        '
        Me.TrsDeleteBtn.BackColor = System.Drawing.Color.Red
        Me.TrsDeleteBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrsDeleteBtn.Location = New System.Drawing.Point(840, 639)
        Me.TrsDeleteBtn.Name = "TrsDeleteBtn"
        Me.TrsDeleteBtn.Size = New System.Drawing.Size(138, 43)
        Me.TrsDeleteBtn.TabIndex = 32
        Me.TrsDeleteBtn.Text = "Delete All"
        Me.TrsDeleteBtn.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Panel2.Location = New System.Drawing.Point(820, 271)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(158, 57)
        Me.Panel2.TabIndex = 33
        '
        'Transaction_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 704)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.TrsDeleteBtn)
        Me.Controls.Add(Me.TrsRemoveBtn)
        Me.Controls.Add(Me.TrsViewBtn)
        Me.Controls.Add(Me.Transaction_DGV)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Transaction_Form"
        Me.Text = "Transaction_Form"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Transaction_DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Transaction_DGV As DataGridView
    Friend WithEvents TrsViewBtn As Button
    Friend WithEvents TrsRemoveBtn As Button
    Friend WithEvents TrsDeleteBtn As Button
    Friend WithEvents Panel2 As Panel
End Class
