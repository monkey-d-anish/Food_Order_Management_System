<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin_Panel_TablesForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin_Panel_TablesForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ResetBtn = New System.Windows.Forms.Button()
        Me.UpdateBtn = New System.Windows.Forms.Button()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.TablecategoryCb = New System.Windows.Forms.ComboBox()
        Me.TableCapacitytb = New System.Windows.Forms.TextBox()
        Me.TablenoTb = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Name_lbl = New System.Windows.Forms.Label()
        Me.Table_Dgv = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsActiveDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.UspGetTableDataAdminBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Poject_FOMSDataSet1 = New Food_Order_MS.Poject_FOMSDataSet1()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Usp_Get_TableDataAdminTableAdapter = New Food_Order_MS.Poject_FOMSDataSet1TableAdapters.Usp_Get_TableDataAdminTableAdapter()
        Me.IsActiveChkB = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        CType(Me.Table_Dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UspGetTableDataAdminBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Poject_FOMSDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gold
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 28)
        Me.Panel1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(222, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = " Food Order Management System "
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.IndianRed
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(771, 3)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(27, 25)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ResetBtn
        '
        Me.ResetBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ResetBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetBtn.Location = New System.Drawing.Point(7, 317)
        Me.ResetBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.Size = New System.Drawing.Size(104, 35)
        Me.ResetBtn.TabIndex = 33
        Me.ResetBtn.Text = "Reset"
        Me.ResetBtn.UseVisualStyleBackColor = False
        '
        'UpdateBtn
        '
        Me.UpdateBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateBtn.Location = New System.Drawing.Point(240, 317)
        Me.UpdateBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.UpdateBtn.Name = "UpdateBtn"
        Me.UpdateBtn.Size = New System.Drawing.Size(104, 35)
        Me.UpdateBtn.TabIndex = 31
        Me.UpdateBtn.Text = "Update Table"
        Me.UpdateBtn.UseVisualStyleBackColor = True
        '
        'AddBtn
        '
        Me.AddBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBtn.Location = New System.Drawing.Point(122, 317)
        Me.AddBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(104, 35)
        Me.AddBtn.TabIndex = 30
        Me.AddBtn.Text = "Add Table"
        Me.AddBtn.UseVisualStyleBackColor = True
        '
        'TablecategoryCb
        '
        Me.TablecategoryCb.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.TablecategoryCb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TablecategoryCb.FormattingEnabled = True
        Me.TablecategoryCb.Location = New System.Drawing.Point(96, 203)
        Me.TablecategoryCb.Margin = New System.Windows.Forms.Padding(2)
        Me.TablecategoryCb.Name = "TablecategoryCb"
        Me.TablecategoryCb.Size = New System.Drawing.Size(191, 25)
        Me.TablecategoryCb.TabIndex = 29
        '
        'TableCapacitytb
        '
        Me.TableCapacitytb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TableCapacitytb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableCapacitytb.Location = New System.Drawing.Point(96, 159)
        Me.TableCapacitytb.Margin = New System.Windows.Forms.Padding(2)
        Me.TableCapacitytb.Name = "TableCapacitytb"
        Me.TableCapacitytb.Size = New System.Drawing.Size(190, 24)
        Me.TableCapacitytb.TabIndex = 27
        '
        'TablenoTb
        '
        Me.TablenoTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TablenoTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TablenoTb.Location = New System.Drawing.Point(96, 121)
        Me.TablenoTb.Margin = New System.Windows.Forms.Padding(2)
        Me.TablenoTb.Name = "TablenoTb"
        Me.TablenoTb.Size = New System.Drawing.Size(190, 24)
        Me.TablenoTb.TabIndex = 26
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 208)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 20)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Category :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 163)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 20)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Capacity :"
        '
        'Name_lbl
        '
        Me.Name_lbl.AutoSize = True
        Me.Name_lbl.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_lbl.Location = New System.Drawing.Point(7, 125)
        Me.Name_lbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Name_lbl.Name = "Name_lbl"
        Me.Name_lbl.Size = New System.Drawing.Size(75, 20)
        Me.Name_lbl.TabIndex = 22
        Me.Name_lbl.Text = "Table No :"
        '
        'Table_Dgv
        '
        Me.Table_Dgv.AllowUserToAddRows = False
        Me.Table_Dgv.AllowUserToDeleteRows = False
        Me.Table_Dgv.AutoGenerateColumns = False
        Me.Table_Dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Table_Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Table_Dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.IsActiveDataGridViewCheckBoxColumn})
        Me.Table_Dgv.DataSource = Me.UspGetTableDataAdminBindingSource
        Me.Table_Dgv.Location = New System.Drawing.Point(375, 81)
        Me.Table_Dgv.Name = "Table_Dgv"
        Me.Table_Dgv.ReadOnly = True
        Me.Table_Dgv.RowHeadersVisible = False
        Me.Table_Dgv.Size = New System.Drawing.Size(413, 321)
        Me.Table_Dgv.TabIndex = 35
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Table No"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Table No"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Capacity"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Capacity"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Category"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Category"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'IsActiveDataGridViewCheckBoxColumn
        '
        Me.IsActiveDataGridViewCheckBoxColumn.DataPropertyName = "Is Active"
        Me.IsActiveDataGridViewCheckBoxColumn.HeaderText = "Is Active"
        Me.IsActiveDataGridViewCheckBoxColumn.Name = "IsActiveDataGridViewCheckBoxColumn"
        Me.IsActiveDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'UspGetTableDataAdminBindingSource
        '
        Me.UspGetTableDataAdminBindingSource.DataMember = "Usp_Get_TableDataAdmin"
        Me.UspGetTableDataAdminBindingSource.DataSource = Me.Poject_FOMSDataSet1
        '
        'Poject_FOMSDataSet1
        '
        Me.Poject_FOMSDataSet1.DataSetName = "Poject_FOMSDataSet1"
        Me.Poject_FOMSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.AliceBlue
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(0, 28)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 36)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 36
        Me.PictureBox3.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(35, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 30)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Tables"
        '
        'Usp_Get_TableDataAdminTableAdapter
        '
        Me.Usp_Get_TableDataAdminTableAdapter.ClearBeforeFill = True
        '
        'IsActiveChkB
        '
        Me.IsActiveChkB.BackColor = System.Drawing.Color.Crimson
        Me.IsActiveChkB.FlatAppearance.BorderSize = 0
        Me.IsActiveChkB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IsActiveChkB.Font = New System.Drawing.Font("Yu Gothic UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsActiveChkB.Location = New System.Drawing.Point(96, 242)
        Me.IsActiveChkB.Name = "IsActiveChkB"
        Me.IsActiveChkB.Padding = New System.Windows.Forms.Padding(50, 0, 0, 0)
        Me.IsActiveChkB.Size = New System.Drawing.Size(190, 33)
        Me.IsActiveChkB.TabIndex = 38
        Me.IsActiveChkB.Text = "Is Active"
        Me.IsActiveChkB.UseVisualStyleBackColor = False
        '
        'Admin_Panel_TablesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 414)
        Me.Controls.Add(Me.IsActiveChkB)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.Table_Dgv)
        Me.Controls.Add(Me.ResetBtn)
        Me.Controls.Add(Me.UpdateBtn)
        Me.Controls.Add(Me.AddBtn)
        Me.Controls.Add(Me.TablecategoryCb)
        Me.Controls.Add(Me.TableCapacitytb)
        Me.Controls.Add(Me.TablenoTb)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Name_lbl)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Admin_Panel_TablesForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Table_Form"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Table_Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UspGetTableDataAdminBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Poject_FOMSDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents ResetBtn As Button
    Friend WithEvents UpdateBtn As Button
    Friend WithEvents AddBtn As Button
    Friend WithEvents TablecategoryCb As ComboBox
    Friend WithEvents TableCapacitytb As TextBox
    Friend WithEvents TablenoTb As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Name_lbl As Label
    Friend WithEvents Table_Dgv As DataGridView
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TableIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TableNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CapacityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Poject_FOMSDataSet1 As Poject_FOMSDataSet1
    Friend WithEvents UspGetTableDataAdminBindingSource As BindingSource
    Friend WithEvents Usp_Get_TableDataAdminTableAdapter As Poject_FOMSDataSet1TableAdapters.Usp_Get_TableDataAdminTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents IsActiveDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents IsActiveChkB As CheckBox
End Class
