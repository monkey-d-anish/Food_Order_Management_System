Imports System.Data.SqlClient
Imports System.Drawing.Imaging

Public Class User_Panel_CartForm
    Dim Unit_Price As Double = 0
    Dim Total_Price As Double = 0
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Reset_All()
    End Sub

    Public Sub Fill_Dgv1()
        'Me.Usp_Get_FoodItemsTableAdapter.Fill(Me.Poject_FOMSDataSet.Usp_Get_FoodItems)
        Try
            Me.Usp_Get_FoodItemsTableAdapter.Fill(Me.Poject_FOMSDataSet.Usp_Get_FoodItems)
        Catch ex As Exception
            MsgBox("Error filling Menu_Dgv: " & ex.Message)
        End Try
    End Sub
    Public Sub Fill_Dgv2()
        Dim Query As String = "Usp_Get_Cart"
        Dim Param As New List(Of SqlParameter) From {
                New SqlParameter("@TId", TableIdVCLbl.Text.ToString())
        }
        Dim TBl As New DataTable
        TBl = GetData(Query, Param, CommandType.StoredProcedure)
        Cart_Dgv.DataSource = TBl
    End Sub
    Private Sub FillCb()
        Dim Query As String = "Usp_Get_BookedTablesDataUser"
        Dim Param As New List(Of SqlParameter) From {}
        Dim Tbl As New DataTable
        Tbl = GetData(Query, Param, CommandType.StoredProcedure)
        TablesIdCb.DataSource = Tbl
        TablesIdCb.DisplayMember = "Table No"
        TablesIdCb.ValueMember = "Table No"
    End Sub

    Private Sub Food_Items_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCb()
        Fill_Dgv1()
        Fill_SearchCb()
    End Sub

    Private Sub AddtoCartBtn_Click(sender As Object, e As EventArgs) Handles AddtoCartBtn.Click
        If TablesIdCb.Text = "" Then
            MsgBox("Select a Table")
        ElseIf AmountTb.Text = "" Then
            MsgBox("Missing Information")
        Else
            Dim param As New List(Of SqlParameter) From {
                New SqlParameter("@TblId", TableIdVCLbl.Text.ToString()),
                New SqlParameter("@FoodId", ItemIdTb.Text.ToString()),
                New SqlParameter("@Qty", QuantityTb.Text.ToString()),
                New SqlParameter("@Amount", AmountTb.Text.ToString())
            }
            Dim Query As String = "Usp_Add_ToCart"
            Dim Result As Integer = InsertUpdateDelete(Query, param, CommandType.StoredProcedure)
            If Result = 0 Then
                Fill_Dgv2()
                Reset()
            End If
        End If
    End Sub
    Private Sub Reset_All()
        ItemIdTb.Text = ""
        ItemNameTb.Text = ""
        QuantityTb.Text = ""
        AmountTb.Text = ""
        CartIdLbl.Text = "Cart ID"
        TotalAmountTb.Text = ""
        TablesIdCb.Text = ""
        SearchbyItemCategoryCb.Text = ""
    End Sub
    Private Sub Reset()
        ItemIdTb.Text = ""
        ItemNameTb.Text = ""
        QuantityTb.Text = ""
        AmountTb.Text = ""
    End Sub
    Private Sub TablesIdCb_Enter(sender As Object, e As EventArgs) Handles TablesIdCb.Enter
        FillCb()
    End Sub

    Private Sub Menu_Dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Menu_Dgv.CellClick
        Try
            ItemIdTb.Text = Menu_Dgv.Rows(e.RowIndex).Cells(0).Value
            ItemNameTb.Text = Menu_Dgv.Rows(e.RowIndex).Cells(1).Value.ToString()
            Unit_Price = Menu_Dgv.Rows(e.RowIndex).Cells(3).Value.ToString()
        Catch ex As Exception
            MsgBox("Select A Row")
        End Try
    End Sub

    Private Sub QuantityTb_TextChanged(sender As Object, e As EventArgs) Handles QuantityTb.TextChanged
        Try
            AmountTb.Text = Unit_Price * QuantityTb.Text
        Catch ex As Exception
        End Try
    End Sub

    Private Sub ViewCartBtn_Click(sender As Object, e As EventArgs) Handles ViewCartBtn.Click
        TableIdVCLbl.Text = TablesIdCb.SelectedValue
        Fill_Dgv2()
    End Sub



    Private Sub BillBtn_Click(sender As Object, e As EventArgs) Handles BillBtn.Click
        Total_Price = 0
        Dim Rows As DataGridViewRow
        For Each Rows In Cart_Dgv.Rows
            Total_Price += Rows.Cells(3).Value
        Next
        TotalAmountTb.Text = Total_Price
    End Sub

    Private Sub TablesIdCb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TablesIdCb.SelectedIndexChanged
        Cart_Dgv.DataSource = ""
    End Sub

    Private Sub Cart_Dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Cart_Dgv.CellClick
        Try
            CartIdLbl.Text = Cart_Dgv.Rows(e.RowIndex).Cells(0).Value
        Catch ex As Exception
            MsgBox("Select A Row")
        End Try
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If CartIdLbl.Text = "" Then
            MsgBox("Select Cart Id")
        Else
            Dim param As New List(Of SqlParameter) From {
                New SqlParameter("@CId", CartIdLbl.Text)
            }
            Dim Query As String = "Usp_Delete_CartItem"
            Dim Result As Integer = InsertUpdateDelete(Query, param, CommandType.StoredProcedure)
            If Result = 0 Then
                Fill_Dgv2()
                Reset()
            End If
        End If
    End Sub
    Private Sub OrderBtn_Click(sender As Object, e As EventArgs) Handles OrderBtn.Click
        If TotalAmountTb.Text = "" Or Cart_Dgv.RowCount = 0 Then
            MsgBox("Invalid Information! Check Again")
        Else
            Dim param As New List(Of SqlParameter) From {
                New SqlParameter("@Tid", TableIdVCLbl.Text),
                New SqlParameter("@Amount", TotalAmountTb.Text)
            }
            Dim Query As String = "Usp_Add_Transactions"
            Dim Result As Integer = InsertUpdateDelete(Query, param, CommandType.StoredProcedure)
            If Result = 0 Then
                Fill_Dgv2()
                Reset()
            End If
        End If
    End Sub

    Private Sub Fill_SearchCb()
        Dim Query As String = "Usp_Get_ActiveItemsCategory"
        Dim Param As New List(Of SqlParameter) From {}
        Dim Tbl As New DataTable
        Tbl = GetData(Query, Param, CommandType.StoredProcedure)
        SearchbyItemCategoryCb.DataSource = Tbl
        SearchbyItemCategoryCb.DisplayMember = "Items Categorygory"
        SearchbyItemCategoryCb.ValueMember = "Items Category"
    End Sub

    Private Sub SearchbyItemCategoryCb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SearchbyItemCategoryCb.SelectedIndexChanged
        SearchbyItemCategoryCb.Text = ""
    End Sub

    Private Sub ClearSrcLbl_Click(sender As Object, e As EventArgs) Handles ClearSrcLbl.Click
        SearchbyItemCategoryCb.Text = ""
        Menu_Dgv.DataSource = Poject_FOMSDataSet.Usp_Get_FoodItems
    End Sub

    Private Sub Search_Dgv()
        Try
            If SearchbyItemCategoryCb.Text = "" Then
                MsgBox("Select Category")
            Else
                Dim Query As String = "Usp_Get_FoodItems_Search"
                Dim Param As New List(Of SqlParameter) From {
                        New SqlParameter("@Search_Category", SearchbyItemCategoryCb.Text.ToString())
                }
                Dim TBl1 As New DataTable
                TBl1 = GetData(Query, Param, CommandType.StoredProcedure)
                Menu_Dgv.DataSource = TBl1 ' Assign new data source
            End If
        Catch ex As Exception
            MsgBox("Error retrieving search results: " & ex.Message)
        End Try
    End Sub

    Private Sub SearchLbl_Click(sender As Object, e As EventArgs) Handles SearchLbl.Click
        Search_Dgv()
    End Sub
End Class