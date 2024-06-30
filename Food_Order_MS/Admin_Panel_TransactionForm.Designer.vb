<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Admin_Panel_TransactionForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Admin_Panel_TransactionForm))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Transaction_DGV = New System.Windows.Forms.DataGridView()
        Me.TransactionIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UspGetTransactionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Poject_FOMSDataSet3 = New Food_Order_MS.Poject_FOMSDataSet3()
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.FromDateLbl = New System.Windows.Forms.Label()
        Me.ToDateLbl = New System.Windows.Forms.Label()
        Me.FromDTP = New System.Windows.Forms.DateTimePicker()
        Me.ToDTP = New System.Windows.Forms.DateTimePicker()
        Me.Usp_Get_TransactionsTableAdapter = New Food_Order_MS.Poject_FOMSDataSet3TableAdapters.Usp_Get_TransactionsTableAdapter()
        Me.DistinctTransactionsDGV = New System.Windows.Forms.DataGridView()
        Me.TableIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalAmountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UspGetTransactionsByTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Poject_FOMSDataSet4 = New Food_Order_MS.Poject_FOMSDataSet4()
        Me.Usp_Get_TransactionsByTableTableAdapter = New Food_Order_MS.Poject_FOMSDataSet4TableAdapters.Usp_Get_TransactionsByTableTableAdapter()
        Me.ResetBtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Transaction_DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UspGetTransactionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Poject_FOMSDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DistinctTransactionsDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UspGetTransactionsByTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Poject_FOMSDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gold
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(964, 28)
        Me.Panel1.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.IndianRed
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(935, 3)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(27, 25)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "X"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(2, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(174, 19)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = " Food Order Management "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(37, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 30)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Transaction"
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.AliceBlue
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(4, 29)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(32, 36)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 6
        Me.PictureBox4.TabStop = False
        '
        'Transaction_DGV
        '
        Me.Transaction_DGV.AllowUserToAddRows = False
        Me.Transaction_DGV.AllowUserToDeleteRows = False
        Me.Transaction_DGV.AllowUserToResizeColumns = False
        Me.Transaction_DGV.AllowUserToResizeRows = False
        Me.Transaction_DGV.AutoGenerateColumns = False
        Me.Transaction_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Transaction_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Transaction_DGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TransactionIDDataGridViewTextBoxColumn, Me.TableDataGridViewTextBoxColumn, Me.AmountDataGridViewTextBoxColumn, Me.DateDataGridViewTextBoxColumn})
        Me.Transaction_DGV.DataSource = Me.UspGetTransactionsBindingSource
        Me.Transaction_DGV.Location = New System.Drawing.Point(9, 155)
        Me.Transaction_DGV.Margin = New System.Windows.Forms.Padding(2)
        Me.Transaction_DGV.Name = "Transaction_DGV"
        Me.Transaction_DGV.ReadOnly = True
        Me.Transaction_DGV.RowHeadersVisible = False
        Me.Transaction_DGV.RowHeadersWidth = 51
        Me.Transaction_DGV.RowTemplate.Height = 30
        Me.Transaction_DGV.Size = New System.Drawing.Size(601, 407)
        Me.Transaction_DGV.TabIndex = 29
        '
        'TransactionIDDataGridViewTextBoxColumn
        '
        Me.TransactionIDDataGridViewTextBoxColumn.DataPropertyName = "Transaction ID"
        Me.TransactionIDDataGridViewTextBoxColumn.HeaderText = "Transaction ID"
        Me.TransactionIDDataGridViewTextBoxColumn.Name = "TransactionIDDataGridViewTextBoxColumn"
        Me.TransactionIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TableDataGridViewTextBoxColumn
        '
        Me.TableDataGridViewTextBoxColumn.DataPropertyName = "Table"
        Me.TableDataGridViewTextBoxColumn.HeaderText = "Table"
        Me.TableDataGridViewTextBoxColumn.Name = "TableDataGridViewTextBoxColumn"
        Me.TableDataGridViewTextBoxColumn.ReadOnly = True
        '
        'AmountDataGridViewTextBoxColumn
        '
        Me.AmountDataGridViewTextBoxColumn.DataPropertyName = "Amount"
        Me.AmountDataGridViewTextBoxColumn.HeaderText = "Amount"
        Me.AmountDataGridViewTextBoxColumn.Name = "AmountDataGridViewTextBoxColumn"
        Me.AmountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateDataGridViewTextBoxColumn
        '
        Me.DateDataGridViewTextBoxColumn.DataPropertyName = "Date"
        Me.DateDataGridViewTextBoxColumn.HeaderText = "Date"
        Me.DateDataGridViewTextBoxColumn.Name = "DateDataGridViewTextBoxColumn"
        Me.DateDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UspGetTransactionsBindingSource
        '
        Me.UspGetTransactionsBindingSource.DataMember = "Usp_Get_Transactions"
        Me.UspGetTransactionsBindingSource.DataSource = Me.Poject_FOMSDataSet3
        '
        'Poject_FOMSDataSet3
        '
        Me.Poject_FOMSDataSet3.DataSetName = "Poject_FOMSDataSet3"
        Me.Poject_FOMSDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SearchBtn
        '
        Me.SearchBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBtn.Location = New System.Drawing.Point(449, 99)
        Me.SearchBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(79, 35)
        Me.SearchBtn.TabIndex = 31
        Me.SearchBtn.Text = "Search"
        Me.SearchBtn.UseVisualStyleBackColor = True
        '
        'FromDateLbl
        '
        Me.FromDateLbl.AutoSize = True
        Me.FromDateLbl.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FromDateLbl.Location = New System.Drawing.Point(11, 106)
        Me.FromDateLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.FromDateLbl.Name = "FromDateLbl"
        Me.FromDateLbl.Size = New System.Drawing.Size(82, 20)
        Me.FromDateLbl.TabIndex = 34
        Me.FromDateLbl.Text = "From Date:"
        '
        'ToDateLbl
        '
        Me.ToDateLbl.AutoSize = True
        Me.ToDateLbl.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToDateLbl.Location = New System.Drawing.Point(238, 106)
        Me.ToDateLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ToDateLbl.Name = "ToDateLbl"
        Me.ToDateLbl.Size = New System.Drawing.Size(64, 20)
        Me.ToDateLbl.TabIndex = 35
        Me.ToDateLbl.Text = "To Date:"
        '
        'FromDTP
        '
        Me.FromDTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FromDTP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FromDTP.Location = New System.Drawing.Point(98, 105)
        Me.FromDTP.Name = "FromDTP"
        Me.FromDTP.Size = New System.Drawing.Size(126, 26)
        Me.FromDTP.TabIndex = 36
        Me.FromDTP.Value = New Date(2024, 6, 29, 0, 0, 0, 0)
        '
        'ToDTP
        '
        Me.ToDTP.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToDTP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ToDTP.Location = New System.Drawing.Point(307, 105)
        Me.ToDTP.Name = "ToDTP"
        Me.ToDTP.Size = New System.Drawing.Size(126, 26)
        Me.ToDTP.TabIndex = 37
        Me.ToDTP.Value = New Date(2024, 6, 29, 0, 0, 0, 0)
        '
        'Usp_Get_TransactionsTableAdapter
        '
        Me.Usp_Get_TransactionsTableAdapter.ClearBeforeFill = True
        '
        'DistinctTransactionsDGV
        '
        Me.DistinctTransactionsDGV.AllowUserToAddRows = False
        Me.DistinctTransactionsDGV.AllowUserToDeleteRows = False
        Me.DistinctTransactionsDGV.AllowUserToResizeColumns = False
        Me.DistinctTransactionsDGV.AllowUserToResizeRows = False
        Me.DistinctTransactionsDGV.AutoGenerateColumns = False
        Me.DistinctTransactionsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DistinctTransactionsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DistinctTransactionsDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TableIdDataGridViewTextBoxColumn, Me.TotalAmountDataGridViewTextBoxColumn})
        Me.DistinctTransactionsDGV.DataSource = Me.UspGetTransactionsByTableBindingSource
        Me.DistinctTransactionsDGV.Location = New System.Drawing.Point(638, 155)
        Me.DistinctTransactionsDGV.Margin = New System.Windows.Forms.Padding(2)
        Me.DistinctTransactionsDGV.Name = "DistinctTransactionsDGV"
        Me.DistinctTransactionsDGV.ReadOnly = True
        Me.DistinctTransactionsDGV.RowHeadersVisible = False
        Me.DistinctTransactionsDGV.RowHeadersWidth = 51
        Me.DistinctTransactionsDGV.RowTemplate.Height = 30
        Me.DistinctTransactionsDGV.Size = New System.Drawing.Size(315, 406)
        Me.DistinctTransactionsDGV.TabIndex = 38
        '
        'TableIdDataGridViewTextBoxColumn
        '
        Me.TableIdDataGridViewTextBoxColumn.DataPropertyName = "TableId"
        Me.TableIdDataGridViewTextBoxColumn.HeaderText = "TableId"
        Me.TableIdDataGridViewTextBoxColumn.Name = "TableIdDataGridViewTextBoxColumn"
        Me.TableIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TotalAmountDataGridViewTextBoxColumn
        '
        Me.TotalAmountDataGridViewTextBoxColumn.DataPropertyName = "Total Amount"
        Me.TotalAmountDataGridViewTextBoxColumn.HeaderText = "Total Amount"
        Me.TotalAmountDataGridViewTextBoxColumn.Name = "TotalAmountDataGridViewTextBoxColumn"
        Me.TotalAmountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'UspGetTransactionsByTableBindingSource
        '
        Me.UspGetTransactionsByTableBindingSource.DataMember = "Usp_Get_TransactionsByTable"
        Me.UspGetTransactionsByTableBindingSource.DataSource = Me.Poject_FOMSDataSet4
        '
        'Poject_FOMSDataSet4
        '
        Me.Poject_FOMSDataSet4.DataSetName = "Poject_FOMSDataSet4"
        Me.Poject_FOMSDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Usp_Get_TransactionsByTableTableAdapter
        '
        Me.Usp_Get_TransactionsByTableTableAdapter.ClearBeforeFill = True
        '
        'ResetBtn
        '
        Me.ResetBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResetBtn.Location = New System.Drawing.Point(532, 99)
        Me.ResetBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.ResetBtn.Name = "ResetBtn"
        Me.ResetBtn.Size = New System.Drawing.Size(78, 35)
        Me.ResetBtn.TabIndex = 39
        Me.ResetBtn.Text = "Reset"
        Me.ResetBtn.UseVisualStyleBackColor = True
        '
        'Admin_Panel_TransactionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(964, 572)
        Me.Controls.Add(Me.ResetBtn)
        Me.Controls.Add(Me.DistinctTransactionsDGV)
        Me.Controls.Add(Me.ToDTP)
        Me.Controls.Add(Me.FromDTP)
        Me.Controls.Add(Me.ToDateLbl)
        Me.Controls.Add(Me.FromDateLbl)
        Me.Controls.Add(Me.SearchBtn)
        Me.Controls.Add(Me.Transaction_DGV)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Admin_Panel_TransactionForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transaction_Form"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Transaction_DGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UspGetTransactionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Poject_FOMSDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DistinctTransactionsDGV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UspGetTransactionsByTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Poject_FOMSDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents Transaction_DGV As DataGridView
    Friend WithEvents SearchBtn As Button
    Friend WithEvents FromDateLbl As Label
    Friend WithEvents ToDateLbl As Label
    Friend WithEvents FromDTP As DateTimePicker
    Friend WithEvents ToDTP As DateTimePicker
    Friend WithEvents Poject_FOMSDataSet3 As Poject_FOMSDataSet3
    Friend WithEvents UspGetTransactionsBindingSource As BindingSource
    Friend WithEvents Usp_Get_TransactionsTableAdapter As Poject_FOMSDataSet3TableAdapters.Usp_Get_TransactionsTableAdapter
    Friend WithEvents TransactionIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TableDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DistinctTransactionsDGV As DataGridView
    Friend WithEvents Poject_FOMSDataSet4 As Poject_FOMSDataSet4
    Friend WithEvents UspGetTransactionsByTableBindingSource As BindingSource
    Friend WithEvents Usp_Get_TransactionsByTableTableAdapter As Poject_FOMSDataSet4TableAdapters.Usp_Get_TransactionsByTableTableAdapter
    Friend WithEvents TableIdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalAmountDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ResetBtn As Button
End Class
