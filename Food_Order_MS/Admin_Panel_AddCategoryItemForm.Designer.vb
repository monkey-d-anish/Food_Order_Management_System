<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Panel_AddCategoryItemForm
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Exitbtn = New System.Windows.Forms.Button()
        Me.ItemsCategoryDgv = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemCategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsActiveDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.UspGetItemsCategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Poject_FOMSDataSet6 = New Food_Order_MS.Poject_FOMSDataSet6()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.itemcategoryIdtb = New System.Windows.Forms.TextBox()
        Me.categorytb = New System.Windows.Forms.TextBox()
        Me.IsActiveChkB = New System.Windows.Forms.CheckBox()
        Me.AdditemCategoryBtn = New System.Windows.Forms.Button()
        Me.UpdateItemcategoryBtn = New System.Windows.Forms.Button()
        Me.ResetBtn = New System.Windows.Forms.Button()
        Me.Usp_Get_ItemsCategoryTableAdapter = New Food_Order_MS.Poject_FOMSDataSet6TableAdapters.Usp_Get_ItemsCategoryTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.ItemsCategoryDgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UspGetItemsCategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Poject_FOMSDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(162, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Items Category"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gold
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Exitbtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(540, 28)
        Me.Panel1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 4)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(222, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = " Food Order Management System "
        '
        'Exitbtn
        '
        Me.Exitbtn.BackColor = System.Drawing.Color.IndianRed
        Me.Exitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Exitbtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Exitbtn.Location = New System.Drawing.Point(512, 1)
        Me.Exitbtn.Margin = New System.Windows.Forms.Padding(2)
        Me.Exitbtn.Name = "Exitbtn"
        Me.Exitbtn.Size = New System.Drawing.Size(27, 25)
        Me.Exitbtn.TabIndex = 1
        Me.Exitbtn.Text = "X"
        Me.Exitbtn.UseVisualStyleBackColor = False
        '
        'ItemsCategoryDgv
        '
        Me.ItemsCategoryDgv.AllowUserToAddRows = False
        Me.ItemsCategoryDgv.AllowUserToDeleteRows = False
        Me.ItemsCategoryDgv.AutoGenerateColumns = False
        Me.ItemsCategoryDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ItemsCategoryDgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.ItemCategoryDataGridViewTextBoxColumn, Me.IsActiveDataGridViewCheckBoxColumn})
        Me.ItemsCategoryDgv.DataSource = Me.UspGetItemsCategoryBindingSource
        Me.ItemsCategoryDgv.Location = New System.Drawing.Point(241, 80)
        Me.ItemsCategoryDgv.Name = "ItemsCategoryDgv"
        Me.ItemsCategoryDgv.ReadOnly = True
        Me.ItemsCategoryDgv.RowHeadersVisible = False
        Me.ItemsCategoryDgv.Size = New System.Drawing.Size(298, 308)
        Me.ItemsCategoryDgv.TabIndex = 4
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.FillWeight = 40.0!
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ItemCategoryDataGridViewTextBoxColumn
        '
        Me.ItemCategoryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ItemCategoryDataGridViewTextBoxColumn.DataPropertyName = "Item Category"
        Me.ItemCategoryDataGridViewTextBoxColumn.HeaderText = "Item Category"
        Me.ItemCategoryDataGridViewTextBoxColumn.Name = "ItemCategoryDataGridViewTextBoxColumn"
        Me.ItemCategoryDataGridViewTextBoxColumn.ReadOnly = True
        '
        'IsActiveDataGridViewCheckBoxColumn
        '
        Me.IsActiveDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.IsActiveDataGridViewCheckBoxColumn.DataPropertyName = "Is Active"
        Me.IsActiveDataGridViewCheckBoxColumn.FillWeight = 50.0!
        Me.IsActiveDataGridViewCheckBoxColumn.HeaderText = "Is Active"
        Me.IsActiveDataGridViewCheckBoxColumn.Name = "IsActiveDataGridViewCheckBoxColumn"
        Me.IsActiveDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'UspGetItemsCategoryBindingSource
        '
        Me.UspGetItemsCategoryBindingSource.DataMember = "Usp_Get_ItemsCategory"
        Me.UspGetItemsCategoryBindingSource.DataSource = Me.Poject_FOMSDataSet6
        '
        'Poject_FOMSDataSet6
        '
        Me.Poject_FOMSDataSet6.DataSetName = "Poject_FOMSDataSet6"
        Me.Poject_FOMSDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(56, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 21)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Id :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 21)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Category :"
        '
        'itemcategoryIdtb
        '
        Me.itemcategoryIdtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.itemcategoryIdtb.Location = New System.Drawing.Point(99, 107)
        Me.itemcategoryIdtb.Name = "itemcategoryIdtb"
        Me.itemcategoryIdtb.ReadOnly = True
        Me.itemcategoryIdtb.Size = New System.Drawing.Size(136, 26)
        Me.itemcategoryIdtb.TabIndex = 7
        '
        'categorytb
        '
        Me.categorytb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.categorytb.Location = New System.Drawing.Point(98, 145)
        Me.categorytb.Name = "categorytb"
        Me.categorytb.Size = New System.Drawing.Size(137, 26)
        Me.categorytb.TabIndex = 8
        '
        'IsActiveChkB
        '
        Me.IsActiveChkB.BackColor = System.Drawing.Color.Crimson
        Me.IsActiveChkB.FlatAppearance.BorderSize = 0
        Me.IsActiveChkB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IsActiveChkB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsActiveChkB.Location = New System.Drawing.Point(98, 194)
        Me.IsActiveChkB.Name = "IsActiveChkB"
        Me.IsActiveChkB.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.IsActiveChkB.Size = New System.Drawing.Size(125, 33)
        Me.IsActiveChkB.TabIndex = 20
        Me.IsActiveChkB.Text = "Is Active"
        Me.IsActiveChkB.UseVisualStyleBackColor = False
        '
        'AdditemCategoryBtn
        '
        Me.AdditemCategoryBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdditemCategoryBtn.Location = New System.Drawing.Point(12, 330)
        Me.AdditemCategoryBtn.Name = "AdditemCategoryBtn"
        Me.AdditemCategoryBtn.Size = New System.Drawing.Size(90, 49)
        Me.AdditemCategoryBtn.TabIndex = 21
        Me.AdditemCategoryBtn.Text = "Add"
        Me.AdditemCategoryBtn.UseVisualStyleBackColor = True
        '
        'UpdateItemcategoryBtn
        '
        Me.UpdateItemcategoryBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdateItemcategoryBtn.Location = New System.Drawing.Point(127, 330)
        Me.UpdateItemcategoryBtn.Name = "UpdateItemcategoryBtn"
        Me.UpdateItemcategoryBtn.Size = New System.Drawing.Size(108, 49)
        Me.UpdateItemcategoryBtn.TabIndex = 22
        Me.UpdateItemcategoryBtn.Text = "Update"
        Me.UpdateItemcategoryBtn.UseVisualStyleBackColor = True
        '
        'ResetBtn
        '
        Me.ResetBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ResetBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetBtn.Location = New System.Drawing.Point(73, 267)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.Size = New System.Drawing.Size(91, 37)
        Me.ResetBtn.TabIndex = 23
        Me.ResetBtn.Text = "Reset"
        Me.ResetBtn.UseVisualStyleBackColor = False
        '
        'Usp_Get_ItemsCategoryTableAdapter
        '
        Me.Usp_Get_ItemsCategoryTableAdapter.ClearBeforeFill = True
        '
        'Admin_Panel_AddCategoryItemForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 400)
        Me.Controls.Add(Me.ResetBtn)
        Me.Controls.Add(Me.UpdateItemcategoryBtn)
        Me.Controls.Add(Me.AdditemCategoryBtn)
        Me.Controls.Add(Me.IsActiveChkB)
        Me.Controls.Add(Me.categorytb)
        Me.Controls.Add(Me.itemcategoryIdtb)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ItemsCategoryDgv)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Admin_Panel_AddCategoryItemForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin_Panel_AddCategoryItemForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.ItemsCategoryDgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UspGetItemsCategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Poject_FOMSDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Exitbtn As Button
    Friend WithEvents ItemsCategoryDgv As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents itemcategoryIdtb As TextBox
    Friend WithEvents categorytb As TextBox
    Friend WithEvents IsActiveChkB As CheckBox
    Friend WithEvents AdditemCategoryBtn As Button
    Friend WithEvents UpdateItemcategoryBtn As Button
    Friend WithEvents ResetBtn As Button
    Friend WithEvents Poject_FOMSDataSet6 As Poject_FOMSDataSet6
    Friend WithEvents UspGetItemsCategoryBindingSource As BindingSource
    Friend WithEvents Usp_Get_ItemsCategoryTableAdapter As Poject_FOMSDataSet6TableAdapters.Usp_Get_ItemsCategoryTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemCategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IsActiveDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
End Class
