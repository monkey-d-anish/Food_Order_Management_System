<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class User_Panel_CartForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(User_Panel_CartForm))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ViewCartBtn = New System.Windows.Forms.Button()
        Me.TablesIdCb = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ItemNameTb = New System.Windows.Forms.TextBox()
        Me.ItemIdTb = New System.Windows.Forms.TextBox()
        Me.AmountTb = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.QuantityTb = New System.Windows.Forms.TextBox()
        Me.AddtoCartBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Cart_Dgv = New System.Windows.Forms.DataGridView()
        Me.CartIdLbl = New System.Windows.Forms.Label()
        Me.TotalAmountTb = New System.Windows.Forms.TextBox()
        Me.TableIdVCLbl = New System.Windows.Forms.Label()
        Me.BillBtn = New System.Windows.Forms.Button()
        Me.TableIdLbl = New System.Windows.Forms.Label()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.OrderBtn = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Menu_Dgv = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UspGetFoodItemsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Poject_FOMSDataSet = New Food_Order_MS.Poject_FOMSDataSet()
        Me.MenuPnl = New System.Windows.Forms.Panel()
        Me.ClearSrcLbl = New System.Windows.Forms.Label()
        Me.SearchbyItemCategoryCb = New System.Windows.Forms.ComboBox()
        Me.SearchLbl = New System.Windows.Forms.Label()
        Me.Usp_Get_FoodItemsTableAdapter = New Food_Order_MS.Poject_FOMSDataSetTableAdapters.Usp_Get_FoodItemsTableAdapter()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.Cart_Dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Menu_Dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UspGetFoodItemsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Poject_FOMSDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuPnl.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Moccasin
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1200, 35)
        Me.Panel1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(907, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Food Order Management System : User"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Moccasin
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(31, 31)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(37, 9)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 21)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Order"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.IndianRed
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1164, 0)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(34, 32)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Controls.Add(Me.ViewCartBtn)
        Me.Panel2.Controls.Add(Me.TablesIdCb)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(12, 57)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(667, 50)
        Me.Panel2.TabIndex = 2
        '
        'ViewCartBtn
        '
        Me.ViewCartBtn.BackColor = System.Drawing.Color.White
        Me.ViewCartBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ViewCartBtn.ForeColor = System.Drawing.Color.Black
        Me.ViewCartBtn.Location = New System.Drawing.Point(428, 10)
        Me.ViewCartBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.ViewCartBtn.Name = "ViewCartBtn"
        Me.ViewCartBtn.Size = New System.Drawing.Size(104, 35)
        Me.ViewCartBtn.TabIndex = 19
        Me.ViewCartBtn.Text = "View Cart"
        Me.ViewCartBtn.UseVisualStyleBackColor = False
        '
        'TablesIdCb
        '
        Me.TablesIdCb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TablesIdCb.FormattingEnabled = True
        Me.TablesIdCb.Location = New System.Drawing.Point(139, 14)
        Me.TablesIdCb.Name = "TablesIdCb"
        Me.TablesIdCb.Size = New System.Drawing.Size(284, 28)
        Me.TablesIdCb.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(29, 16)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 21)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Select Table :"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel3.Controls.Add(Me.ItemNameTb)
        Me.Panel3.Controls.Add(Me.ItemIdTb)
        Me.Panel3.Controls.Add(Me.AmountTb)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.QuantityTb)
        Me.Panel3.Controls.Add(Me.AddtoCartBtn)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(699, 57)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(489, 252)
        Me.Panel3.TabIndex = 3
        '
        'ItemNameTb
        '
        Me.ItemNameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ItemNameTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemNameTb.Location = New System.Drawing.Point(120, 83)
        Me.ItemNameTb.Margin = New System.Windows.Forms.Padding(2)
        Me.ItemNameTb.Name = "ItemNameTb"
        Me.ItemNameTb.ReadOnly = True
        Me.ItemNameTb.Size = New System.Drawing.Size(185, 24)
        Me.ItemNameTb.TabIndex = 26
        '
        'ItemIdTb
        '
        Me.ItemIdTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ItemIdTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemIdTb.Location = New System.Drawing.Point(120, 48)
        Me.ItemIdTb.Margin = New System.Windows.Forms.Padding(2)
        Me.ItemIdTb.Name = "ItemIdTb"
        Me.ItemIdTb.ReadOnly = True
        Me.ItemIdTb.Size = New System.Drawing.Size(185, 24)
        Me.ItemIdTb.TabIndex = 25
        '
        'AmountTb
        '
        Me.AmountTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AmountTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmountTb.Location = New System.Drawing.Point(122, 159)
        Me.AmountTb.Margin = New System.Windows.Forms.Padding(2)
        Me.AmountTb.Name = "AmountTb"
        Me.AmountTb.Size = New System.Drawing.Size(185, 24)
        Me.AmountTb.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(65, 162)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 21)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Price :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(55, 48)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 21)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Item Id:"
        '
        'QuantityTb
        '
        Me.QuantityTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.QuantityTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantityTb.Location = New System.Drawing.Point(120, 118)
        Me.QuantityTb.Margin = New System.Windows.Forms.Padding(2)
        Me.QuantityTb.Name = "QuantityTb"
        Me.QuantityTb.Size = New System.Drawing.Size(185, 24)
        Me.QuantityTb.TabIndex = 20
        '
        'AddtoCartBtn
        '
        Me.AddtoCartBtn.BackColor = System.Drawing.Color.White
        Me.AddtoCartBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddtoCartBtn.ForeColor = System.Drawing.Color.Black
        Me.AddtoCartBtn.Location = New System.Drawing.Point(184, 205)
        Me.AddtoCartBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.AddtoCartBtn.Name = "AddtoCartBtn"
        Me.AddtoCartBtn.Size = New System.Drawing.Size(104, 35)
        Me.AddtoCartBtn.TabIndex = 18
        Me.AddtoCartBtn.Text = "Add to Cart"
        Me.AddtoCartBtn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(57, 82)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 21)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Name :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(3, 121)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 21)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Enter Quantity:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(179, 12)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(103, 25)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Food Item"
        '
        'Cart_Dgv
        '
        Me.Cart_Dgv.AllowUserToAddRows = False
        Me.Cart_Dgv.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cart_Dgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Cart_Dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Cart_Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Cart_Dgv.DefaultCellStyle = DataGridViewCellStyle2
        Me.Cart_Dgv.GridColor = System.Drawing.SystemColors.AppWorkspace
        Me.Cart_Dgv.Location = New System.Drawing.Point(718, 380)
        Me.Cart_Dgv.Name = "Cart_Dgv"
        Me.Cart_Dgv.ReadOnly = True
        Me.Cart_Dgv.RowHeadersVisible = False
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cart_Dgv.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.Cart_Dgv.Size = New System.Drawing.Size(456, 320)
        Me.Cart_Dgv.TabIndex = 24
        '
        'CartIdLbl
        '
        Me.CartIdLbl.AutoSize = True
        Me.CartIdLbl.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CartIdLbl.ForeColor = System.Drawing.Color.Black
        Me.CartIdLbl.Location = New System.Drawing.Point(817, 729)
        Me.CartIdLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.CartIdLbl.Name = "CartIdLbl"
        Me.CartIdLbl.Size = New System.Drawing.Size(58, 21)
        Me.CartIdLbl.TabIndex = 28
        Me.CartIdLbl.Text = "Cart ID"
        '
        'TotalAmountTb
        '
        Me.TotalAmountTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TotalAmountTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TotalAmountTb.Location = New System.Drawing.Point(1065, 735)
        Me.TotalAmountTb.Margin = New System.Windows.Forms.Padding(2)
        Me.TotalAmountTb.Name = "TotalAmountTb"
        Me.TotalAmountTb.ReadOnly = True
        Me.TotalAmountTb.Size = New System.Drawing.Size(114, 24)
        Me.TotalAmountTb.TabIndex = 27
        '
        'TableIdVCLbl
        '
        Me.TableIdVCLbl.AutoSize = True
        Me.TableIdVCLbl.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableIdVCLbl.ForeColor = System.Drawing.Color.Black
        Me.TableIdVCLbl.Location = New System.Drawing.Point(790, 356)
        Me.TableIdVCLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TableIdVCLbl.Name = "TableIdVCLbl"
        Me.TableIdVCLbl.Size = New System.Drawing.Size(0, 21)
        Me.TableIdVCLbl.TabIndex = 26
        '
        'BillBtn
        '
        Me.BillBtn.BackColor = System.Drawing.Color.White
        Me.BillBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BillBtn.ForeColor = System.Drawing.Color.Black
        Me.BillBtn.Location = New System.Drawing.Point(937, 731)
        Me.BillBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.BillBtn.Name = "BillBtn"
        Me.BillBtn.Size = New System.Drawing.Size(114, 30)
        Me.BillBtn.TabIndex = 25
        Me.BillBtn.Text = "Generate Amount"
        Me.BillBtn.UseVisualStyleBackColor = False
        '
        'TableIdLbl
        '
        Me.TableIdLbl.AutoSize = True
        Me.TableIdLbl.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TableIdLbl.ForeColor = System.Drawing.Color.Black
        Me.TableIdLbl.Location = New System.Drawing.Point(714, 356)
        Me.TableIdLbl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TableIdLbl.Name = "TableIdLbl"
        Me.TableIdLbl.Size = New System.Drawing.Size(73, 21)
        Me.TableIdLbl.TabIndex = 25
        Me.TableIdLbl.Text = "Table No:"
        '
        'DeleteBtn
        '
        Me.DeleteBtn.BackColor = System.Drawing.Color.White
        Me.DeleteBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBtn.ForeColor = System.Drawing.Color.Black
        Me.DeleteBtn.Location = New System.Drawing.Point(718, 724)
        Me.DeleteBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(90, 35)
        Me.DeleteBtn.TabIndex = 20
        Me.DeleteBtn.Text = "Cancel"
        Me.DeleteBtn.UseVisualStyleBackColor = False
        '
        'OrderBtn
        '
        Me.OrderBtn.BackColor = System.Drawing.Color.White
        Me.OrderBtn.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OrderBtn.ForeColor = System.Drawing.Color.Black
        Me.OrderBtn.Location = New System.Drawing.Point(1060, 777)
        Me.OrderBtn.Margin = New System.Windows.Forms.Padding(2)
        Me.OrderBtn.Name = "OrderBtn"
        Me.OrderBtn.Size = New System.Drawing.Size(119, 35)
        Me.OrderBtn.TabIndex = 18
        Me.OrderBtn.Text = "Check Out"
        Me.OrderBtn.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(911, 341)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(97, 25)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Your Cart"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(23, 6)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 30)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Menu"
        '
        'Menu_Dgv
        '
        Me.Menu_Dgv.AllowUserToAddRows = False
        Me.Menu_Dgv.AllowUserToDeleteRows = False
        Me.Menu_Dgv.AutoGenerateColumns = False
        Me.Menu_Dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.Menu_Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Menu_Dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.ItemNameDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn2, Me.PriceDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn3})
        Me.Menu_Dgv.DataSource = Me.UspGetFoodItemsBindingSource
        Me.Menu_Dgv.Location = New System.Drawing.Point(19, 52)
        Me.Menu_Dgv.Name = "Menu_Dgv"
        Me.Menu_Dgv.ReadOnly = True
        Me.Menu_Dgv.RowHeadersVisible = False
        Me.Menu_Dgv.Size = New System.Drawing.Size(623, 623)
        Me.Menu_Dgv.TabIndex = 22
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.FillWeight = 50.0!
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'ItemNameDataGridViewTextBoxColumn
        '
        Me.ItemNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ItemNameDataGridViewTextBoxColumn.DataPropertyName = "Item Name"
        Me.ItemNameDataGridViewTextBoxColumn.HeaderText = "Item Name"
        Me.ItemNameDataGridViewTextBoxColumn.Name = "ItemNameDataGridViewTextBoxColumn"
        Me.ItemNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Unit"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Unit"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        Me.PriceDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Category"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Category"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'UspGetFoodItemsBindingSource
        '
        Me.UspGetFoodItemsBindingSource.DataMember = "Usp_Get_FoodItems"
        Me.UspGetFoodItemsBindingSource.DataSource = Me.Poject_FOMSDataSet
        '
        'Poject_FOMSDataSet
        '
        Me.Poject_FOMSDataSet.DataSetName = "Poject_FOMSDataSet"
        Me.Poject_FOMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MenuPnl
        '
        Me.MenuPnl.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.MenuPnl.Controls.Add(Me.ClearSrcLbl)
        Me.MenuPnl.Controls.Add(Me.SearchbyItemCategoryCb)
        Me.MenuPnl.Controls.Add(Me.SearchLbl)
        Me.MenuPnl.Controls.Add(Me.Menu_Dgv)
        Me.MenuPnl.Controls.Add(Me.Label8)
        Me.MenuPnl.Location = New System.Drawing.Point(12, 125)
        Me.MenuPnl.Name = "MenuPnl"
        Me.MenuPnl.Size = New System.Drawing.Size(667, 687)
        Me.MenuPnl.TabIndex = 39
        '
        'ClearSrcLbl
        '
        Me.ClearSrcLbl.AutoSize = True
        Me.ClearSrcLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearSrcLbl.Location = New System.Drawing.Point(296, 20)
        Me.ClearSrcLbl.Name = "ClearSrcLbl"
        Me.ClearSrcLbl.Size = New System.Drawing.Size(85, 16)
        Me.ClearSrcLbl.TabIndex = 31
        Me.ClearSrcLbl.Text = "Clear Search"
        '
        'SearchbyItemCategoryCb
        '
        Me.SearchbyItemCategoryCb.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.SearchbyItemCategoryCb.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchbyItemCategoryCb.FormattingEnabled = True
        Me.SearchbyItemCategoryCb.Location = New System.Drawing.Point(396, 16)
        Me.SearchbyItemCategoryCb.Margin = New System.Windows.Forms.Padding(2)
        Me.SearchbyItemCategoryCb.Name = "SearchbyItemCategoryCb"
        Me.SearchbyItemCategoryCb.Size = New System.Drawing.Size(191, 25)
        Me.SearchbyItemCategoryCb.TabIndex = 30
        '
        'SearchLbl
        '
        Me.SearchLbl.AutoSize = True
        Me.SearchLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchLbl.Location = New System.Drawing.Point(592, 20)
        Me.SearchLbl.Name = "SearchLbl"
        Me.SearchLbl.Size = New System.Drawing.Size(50, 16)
        Me.SearchLbl.TabIndex = 23
        Me.SearchLbl.Text = "Search"
        '
        'Usp_Get_FoodItemsTableAdapter
        '
        Me.Usp_Get_FoodItemsTableAdapter.ClearBeforeFill = True
        '
        'User_Panel_CartForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1200, 824)
        Me.Controls.Add(Me.Cart_Dgv)
        Me.Controls.Add(Me.CartIdLbl)
        Me.Controls.Add(Me.MenuPnl)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.TotalAmountTb)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableIdVCLbl)
        Me.Controls.Add(Me.OrderBtn)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.BillBtn)
        Me.Controls.Add(Me.DeleteBtn)
        Me.Controls.Add(Me.TableIdLbl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "User_Panel_CartForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "`"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.Cart_Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Menu_Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UspGetFoodItemsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Poject_FOMSDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuPnl.ResumeLayout(False)
        Me.MenuPnl.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents AddtoCartBtn As Button
    Friend WithEvents QuantityTb As TextBox
    Friend WithEvents OrderBtn As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents DeleteBtn As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FoodItemDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UnitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceunitDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label9 As Label
    Friend WithEvents IdDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents FoodItemDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label8 As Label
    Friend WithEvents Menu_Dgv As DataGridView
    Friend WithEvents MenuPnl As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents AmountTb As TextBox
    Friend WithEvents SearchLbl As Label
    Friend WithEvents BillBtn As Button
    Friend WithEvents ViewCartBtn As Button
    Friend WithEvents TablesIdCb As ComboBox
    Friend WithEvents TableIdVCLbl As Label
    Friend WithEvents TableIdLbl As Label
    Friend WithEvents Poject_FOMSDataSet As Poject_FOMSDataSet
    Friend WithEvents UspGetFoodItemsBindingSource As BindingSource
    Friend WithEvents Usp_Get_FoodItemsTableAdapter As Poject_FOMSDataSetTableAdapters.Usp_Get_FoodItemsTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents ItemNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents ItemNameTb As TextBox
    Friend WithEvents ItemIdTb As TextBox
    Friend WithEvents TotalAmountTb As TextBox
    Friend WithEvents CartIdLbl As Label
    Friend WithEvents Cart_Dgv As DataGridView
    Friend WithEvents SearchbyItemCategoryCb As ComboBox
    Friend WithEvents ClearSrcLbl As Label
End Class
