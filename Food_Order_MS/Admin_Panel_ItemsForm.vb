Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices


Public Class Admin_Panel_ItemsForm

    Public Sub Fill_Dgv()
        Me.Usp_Get_FoodItemsTableAdapter.Fill(Me.Poject_FOMSDataSet.Usp_Get_FoodItems)
    End Sub
    Private Sub Items_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCb()
        Fill_Dgv()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Reset()
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        If fid_lbl.Text <> "" Then
            MsgBox("Error!!! Hit Reset Button and Try Again")
        ElseIf ItemnameTb.Text = "" Or ItemunitTb.Text = "" Or ItempriceTb.Text = "" Or ItemcategoryCb.Text = "" Then
            MsgBox("Missing Information")
        Else
            Dim param As New List(Of SqlParameter) From {
            New SqlParameter("@Fname", ItemnameTb.Text.ToString()),
            New SqlParameter("@Unit", ItemunitTb.Text.ToString()),
            New SqlParameter("@Price", ItempriceTb.Text.ToString()),
            New SqlParameter("@Category", ItemcategoryCb.Text.ToString())
            }
            Dim Query As String = "Usp_Add_FoodItems"
            Dim Con As New SqlConnection(_constr)
            Dim Cmd As New SqlCommand(Query, Con)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.AddRange(param.ToArray())
            Con.Open()
            Cmd.ExecuteNonQuery()
            Con.Close()
            Fill_Dgv()
            MsgBox("Food Item Added Successfully")
            Reset()
        End If

    End Sub
    Private Sub Reset()
        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Then
                control.Text = ""
            End If
        Next
        fid_lbl.Text = ""
        ItemcategoryCb.Text = ""
    End Sub
    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Reset()
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        If fid_lbl.Text = "" Then
            MsgBox("Error!!!Select Item and Try Again")
        Else
            Dim param As New List(Of SqlParameter) From {
            New SqlParameter("@U_FoodId", fid_lbl.Text.ToString()),
            New SqlParameter("@U_Fname", ItemnameTb.Text.ToString()),
            New SqlParameter("@U_Unit", ItemunitTb.Text.ToString()),
            New SqlParameter("@U_Price", ItempriceTb.Text.ToString()),
            New SqlParameter("@U_Category", ItemcategoryCb.Text.ToString())
        }
            Dim Query As String = "Usp_Update_FoodItems"
            Dim Con As New SqlConnection(_constr)
            Dim Cmd As New SqlCommand(Query, Con)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.AddRange(param.ToArray())
            Con.Open()
            Cmd.ExecuteNonQuery()
            Con.Close()
            Fill_Dgv()
            MsgBox("Item Details Updated Successfully")
            Reset()
        End If
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles DeleteBtn.Click
        If fid_lbl.Text = "" Then
            MsgBox("Error!!!Select Item and Try Again")
        Else
            Dim param As New List(Of SqlParameter) From
        {
            New SqlParameter("@D_FoodId", fid_lbl.Text.ToString())
        }
            Dim query As String = "Usp_Delete_FoodItem"
            Dim con As New SqlConnection(_constr)
            Dim cmd As New SqlCommand(query, con)
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddRange(param.ToArray())
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
            Fill_Dgv()
            MsgBox(" Item Removed Successfully")
            Reset()
        End If
    End Sub

    Private Sub Items_DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Items_DGV.CellClick
        Try
            fid_lbl.Text = Items_DGV.Rows(e.RowIndex).Cells(0).Value
            ItemnameTb.Text = Items_DGV.Rows(e.RowIndex).Cells(1).Value.ToString()
            ItemunitTb.Text = Items_DGV.Rows(e.RowIndex).Cells(2).Value.ToString()
            ItempriceTb.Text = Items_DGV.Rows(e.RowIndex).Cells(3).Value.ToString()
            ItemcategoryCb.Text = Items_DGV.Rows(e.RowIndex).Cells(4).Value.ToString()
        Catch ex As Exception
            MsgBox("Select A Row")
        End Try
    End Sub

    Private Sub ItemcategoryCb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ItemcategoryCb.SelectedIndexChanged
        ItemcategoryCb.Text = ""
    End Sub

    Private Sub FillCb()
        Dim Query As String = "Usp_Get_ActiveItemsCategory"
        Dim Param As New List(Of SqlParameter) From {}
        Dim Tbl As New DataTable
        Tbl = GetData(Query, Param, CommandType.StoredProcedure)
        ItemcategoryCb.DataSource = Tbl
        ItemcategoryCb.DisplayMember = "Items Category"
        ItemcategoryCb.ValueMember = "Items Category"
    End Sub

    Private Sub ItemcategoryCb_Enter(sender As Object, e As EventArgs) Handles ItemcategoryCb.Enter
        FillCb()
    End Sub
End Class