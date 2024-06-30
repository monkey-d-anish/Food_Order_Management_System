<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin_Panel_AddCategoryTableForm
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
        Me.ResetBtn = New System.Windows.Forms.Button()
        Me.UpdatetablecategoryBtn = New System.Windows.Forms.Button()
        Me.AddtableCategoryBtn = New System.Windows.Forms.Button()
        Me.IsActiveChkB = New System.Windows.Forms.CheckBox()
        Me.categorytb = New System.Windows.Forms.TextBox()
        Me.TablecategoryIdtb = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Exitbtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableCategoryDgv = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableCategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsActiveDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.UspGetTableCategoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Poject_FOMSDataSet8 = New Food_Order_MS.Poject_FOMSDataSet8()
        Me.Usp_Get_TableCategoryTableAdapter = New Food_Order_MS.Poject_FOMSDataSet8TableAdapters.Usp_Get_TableCategoryTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.TableCategoryDgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UspGetTableCategoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Poject_FOMSDataSet8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ResetBtn
        '
        Me.ResetBtn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ResetBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetBtn.Location = New System.Drawing.Point(73, 269)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.Size = New System.Drawing.Size(91, 37)
        Me.ResetBtn.TabIndex = 33
        Me.ResetBtn.Text = "Reset"
        Me.ResetBtn.UseVisualStyleBackColor = False
        '
        'UpdatetablecategoryBtn
        '
        Me.UpdatetablecategoryBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UpdatetablecategoryBtn.Location = New System.Drawing.Point(127, 332)
        Me.UpdatetablecategoryBtn.Name = "UpdatetablecategoryBtn"
        Me.UpdatetablecategoryBtn.Size = New System.Drawing.Size(108, 49)
        Me.UpdatetablecategoryBtn.TabIndex = 32
        Me.UpdatetablecategoryBtn.Text = "Update"
        Me.UpdatetablecategoryBtn.UseVisualStyleBackColor = True
        '
        'AddtableCategoryBtn
        '
        Me.AddtableCategoryBtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddtableCategoryBtn.Location = New System.Drawing.Point(12, 332)
        Me.AddtableCategoryBtn.Name = "AddtableCategoryBtn"
        Me.AddtableCategoryBtn.Size = New System.Drawing.Size(90, 49)
        Me.AddtableCategoryBtn.TabIndex = 31
        Me.AddtableCategoryBtn.Text = "Add"
        Me.AddtableCategoryBtn.UseVisualStyleBackColor = True
        '
        'IsActiveChkB
        '
        Me.IsActiveChkB.BackColor = System.Drawing.Color.Crimson
        Me.IsActiveChkB.FlatAppearance.BorderSize = 0
        Me.IsActiveChkB.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IsActiveChkB.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IsActiveChkB.Location = New System.Drawing.Point(98, 196)
        Me.IsActiveChkB.Name = "IsActiveChkB"
        Me.IsActiveChkB.Padding = New System.Windows.Forms.Padding(25, 0, 0, 0)
        Me.IsActiveChkB.Size = New System.Drawing.Size(125, 33)
        Me.IsActiveChkB.TabIndex = 30
        Me.IsActiveChkB.Text = "Is Active"
        Me.IsActiveChkB.UseVisualStyleBackColor = False
        '
        'categorytb
        '
        Me.categorytb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.categorytb.Location = New System.Drawing.Point(98, 147)
        Me.categorytb.Name = "categorytb"
        Me.categorytb.Size = New System.Drawing.Size(137, 26)
        Me.categorytb.TabIndex = 29
        '
        'TablecategoryIdtb
        '
        Me.TablecategoryIdtb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TablecategoryIdtb.Location = New System.Drawing.Point(99, 109)
        Me.TablecategoryIdtb.Name = "TablecategoryIdtb"
        Me.TablecategoryIdtb.ReadOnly = True
        Me.TablecategoryIdtb.Size = New System.Drawing.Size(136, 26)
        Me.TablecategoryIdtb.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 21)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Category :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(56, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 21)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Id :"
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
        Me.Panel1.TabIndex = 25
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(2, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 30)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Table Category"
        '
        'TableCategoryDgv
        '
        Me.TableCategoryDgv.AllowUserToAddRows = False
        Me.TableCategoryDgv.AllowUserToDeleteRows = False
        Me.TableCategoryDgv.AutoGenerateColumns = False
        Me.TableCategoryDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TableCategoryDgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.TableCategoryDataGridViewTextBoxColumn, Me.IsActiveDataGridViewCheckBoxColumn})
        Me.TableCategoryDgv.DataSource = Me.UspGetTableCategoryBindingSource
        Me.TableCategoryDgv.Location = New System.Drawing.Point(240, 79)
        Me.TableCategoryDgv.Name = "TableCategoryDgv"
        Me.TableCategoryDgv.ReadOnly = True
        Me.TableCategoryDgv.RowHeadersVisible = False
        Me.TableCategoryDgv.Size = New System.Drawing.Size(298, 308)
        Me.TableCategoryDgv.TabIndex = 34
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
        'TableCategoryDataGridViewTextBoxColumn
        '
        Me.TableCategoryDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TableCategoryDataGridViewTextBoxColumn.DataPropertyName = "Table Category"
        Me.TableCategoryDataGridViewTextBoxColumn.HeaderText = "Table Category"
        Me.TableCategoryDataGridViewTextBoxColumn.Name = "TableCategoryDataGridViewTextBoxColumn"
        Me.TableCategoryDataGridViewTextBoxColumn.ReadOnly = True
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
        'UspGetTableCategoryBindingSource
        '
        Me.UspGetTableCategoryBindingSource.DataMember = "Usp_Get_TableCategory"
        Me.UspGetTableCategoryBindingSource.DataSource = Me.Poject_FOMSDataSet8
        '
        'Poject_FOMSDataSet8
        '
        Me.Poject_FOMSDataSet8.DataSetName = "Poject_FOMSDataSet8"
        Me.Poject_FOMSDataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Usp_Get_TableCategoryTableAdapter
        '
        Me.Usp_Get_TableCategoryTableAdapter.ClearBeforeFill = True
        '
        'Admin_Panel_AddCategoryTableForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 400)
        Me.Controls.Add(Me.TableCategoryDgv)
        Me.Controls.Add(Me.ResetBtn)
        Me.Controls.Add(Me.UpdatetablecategoryBtn)
        Me.Controls.Add(Me.AddtableCategoryBtn)
        Me.Controls.Add(Me.IsActiveChkB)
        Me.Controls.Add(Me.categorytb)
        Me.Controls.Add(Me.TablecategoryIdtb)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Admin_Panel_AddCategoryTableForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admin_Panel_AddCategoryTableForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.TableCategoryDgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UspGetTableCategoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Poject_FOMSDataSet8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ResetBtn As Button
    Friend WithEvents UpdatetablecategoryBtn As Button
    Friend WithEvents AddtableCategoryBtn As Button
    Friend WithEvents IsActiveChkB As CheckBox
    Friend WithEvents categorytb As TextBox
    Friend WithEvents TablecategoryIdtb As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Exitbtn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TableCategoryDgv As DataGridView
    Friend WithEvents Poject_FOMSDataSet8 As Poject_FOMSDataSet8
    Friend WithEvents UspGetTableCategoryBindingSource As BindingSource
    Friend WithEvents Usp_Get_TableCategoryTableAdapter As Poject_FOMSDataSet8TableAdapters.Usp_Get_TableCategoryTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TableCategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IsActiveDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
End Class
