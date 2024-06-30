<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class User_Panel_TablesForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.Stable_DGV = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UspGetTablesDataUserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Poject_FOMSDataSet2 = New Food_Order_MS.Poject_FOMSDataSet2()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TableBookBtn = New System.Windows.Forms.Button()
        Me.TableIdLbl = New System.Windows.Forms.Label()
        Me.TableIdTb = New System.Windows.Forms.TextBox()
        Me.Usp_Get_TablesDataUserTableAdapter = New Food_Order_MS.Poject_FOMSDataSet2TableAdapters.Usp_Get_TablesDataUserTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.Stable_DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UspGetTablesDataUserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Poject_FOMSDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Moccasin
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.CloseBtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(736, 34)
        Me.Panel1.TabIndex = 0
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
        'CloseBtn
        '
        Me.CloseBtn.BackColor = System.Drawing.Color.IndianRed
        Me.CloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CloseBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CloseBtn.Location = New System.Drawing.Point(689, 0)
        Me.CloseBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(34, 32)
        Me.CloseBtn.TabIndex = 1
        Me.CloseBtn.Text = "X"
        Me.CloseBtn.UseVisualStyleBackColor = False
        '
        'Stable_DGV
        '
        Me.Stable_DGV.AllowUserToAddRows = False
        Me.Stable_DGV.AllowUserToDeleteRows = False
        Me.Stable_DGV.AutoGenerateColumns = False
        Me.Stable_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Stable_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Stable_DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.Stable_DGV.DataSource = Me.UspGetTablesDataUserBindingSource
        Me.Stable_DGV.Location = New System.Drawing.Point(7, 76)
        Me.Stable_DGV.Margin = New System.Windows.Forms.Padding(2)
        Me.Stable_DGV.Name = "Stable_DGV"
        Me.Stable_DGV.ReadOnly = True
        Me.Stable_DGV.RowHeadersVisible = False
        Me.Stable_DGV.RowHeadersWidth = 51
        Me.Stable_DGV.RowTemplate.Height = 24
        Me.Stable_DGV.Size = New System.Drawing.Size(717, 351)
        Me.Stable_DGV.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Table No"
        Me.DataGridViewTextBoxColumn1.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "Table No"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Capacity"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Capacity"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Category"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Category"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'UspGetTablesDataUserBindingSource
        '
        Me.UspGetTablesDataUserBindingSource.DataMember = "Usp_Get_TablesDataUser"
        Me.UspGetTablesDataUserBindingSource.DataSource = Me.Poject_FOMSDataSet2
        '
        'Poject_FOMSDataSet2
        '
        Me.Poject_FOMSDataSet2.DataSetName = "Poject_FOMSDataSet2"
        Me.Poject_FOMSDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 42)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Select Table"
        '
        'TableBookBtn
        '
        Me.TableBookBtn.BackColor = System.Drawing.Color.Silver
        Me.TableBookBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableBookBtn.Location = New System.Drawing.Point(573, 443)
        Me.TableBookBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.TableBookBtn.Name = "TableBookBtn"
        Me.TableBookBtn.Size = New System.Drawing.Size(140, 52)
        Me.TableBookBtn.TabIndex = 7
        Me.TableBookBtn.Text = "Book Table"
        Me.TableBookBtn.UseVisualStyleBackColor = False
        '
        'TableIdLbl
        '
        Me.TableIdLbl.AutoSize = True
        Me.TableIdLbl.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableIdLbl.Location = New System.Drawing.Point(11, 456)
        Me.TableIdLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TableIdLbl.Name = "TableIdLbl"
        Me.TableIdLbl.Size = New System.Drawing.Size(69, 21)
        Me.TableIdLbl.TabIndex = 8
        Me.TableIdLbl.Text = "Table Id :"
        '
        'TableIdTb
        '
        Me.TableIdTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableIdTb.Location = New System.Drawing.Point(83, 457)
        Me.TableIdTb.Name = "TableIdTb"
        Me.TableIdTb.ReadOnly = True
        Me.TableIdTb.Size = New System.Drawing.Size(80, 22)
        Me.TableIdTb.TabIndex = 11
        '
        'Usp_Get_TablesDataUserTableAdapter
        '
        Me.Usp_Get_TablesDataUserTableAdapter.ClearBeforeFill = True
        '
        'User_Panel_TablesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 519)
        Me.Controls.Add(Me.TableIdTb)
        Me.Controls.Add(Me.TableIdLbl)
        Me.Controls.Add(Me.TableBookBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Stable_DGV)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "User_Panel_TablesForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Stable_form"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Stable_DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UspGetTablesDataUserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Poject_FOMSDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents CloseBtn As Button
    Friend WithEvents Stable_DGV As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents TableBookBtn As Button
    Friend WithEvents TableIdLbl As Label
    Friend WithEvents TableIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TableNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CapacityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TableIdTb As TextBox
    Friend WithEvents Poject_FOMSDataSet2 As Poject_FOMSDataSet2
    Friend WithEvents UspGetTablesDataUserBindingSource As BindingSource
    Friend WithEvents Usp_Get_TablesDataUserTableAdapter As Poject_FOMSDataSet2TableAdapters.Usp_Get_TablesDataUserTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
End Class
