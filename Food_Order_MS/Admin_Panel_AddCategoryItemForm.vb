Imports System.Data.SqlClient

Public Class Admin_Panel_AddCategoryItemForm
    Private Sub Exitbtn_Click_1(sender As Object, e As EventArgs) Handles Exitbtn.Click
        Me.Close()
    End Sub

    Private Sub Fill_Dgv()
        'TODO: This line of code loads data into the 'Poject_FOMSDataSet6.Usp_Get_ItemsCategory' table. You can move, or remove it, as needed.
        Me.Usp_Get_ItemsCategoryTableAdapter.Fill(Me.Poject_FOMSDataSet6.Usp_Get_ItemsCategory)
    End Sub
    Private Sub Admin_Panel_AddCategoryItemForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fill_Dgv()
    End Sub

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Reset()
    End Sub

    Private Sub Reset()
        itemcategoryIdtb.Text = ""
        categorytb.Text = ""
        IsActiveChkB.Checked = False
    End Sub

    Private Sub IsActiveChkB_CheckedChanged(sender As Object, e As EventArgs) Handles IsActiveChkB.CheckedChanged
        If IsActiveChkB.Checked = True Then
            IsActiveChkB.BackColor = Color.Green
        Else
            IsActiveChkB.BackColor = Color.Crimson
        End If
    End Sub

    Private Sub AdditemCategoryBtn_Click(sender As Object, e As EventArgs) Handles AdditemCategoryBtn.Click
        If categorytb.Text = "" Or IsActiveChkB.Checked = False Then
            MsgBox("Missing Information")
        ElseIf itemcategoryIdtb.Text <> "" Then
            MsgBox("Can't Add Exisiting Data")
        Else
            Dim Query As String = "Usp_Add_ItemsCategory"
            Dim Param As New List(Of SqlParameter) From {
                New SqlParameter("@Item_Category", categorytb.Text),
                New SqlParameter("@IsActive", IsActiveChkB.Checked)
            }
            Dim result As Integer = InsertUpdateDelete(Query, Param, CommandType.StoredProcedure)
            If result = 0 Then
                Fill_Dgv()
                MsgBox("Item Category Added Successfully")
                Reset()
            End If
        End If
    End Sub

    Private Sub UpdateItemcategoryBtn_Click(sender As Object, e As EventArgs) Handles UpdateItemcategoryBtn.Click
        If itemcategoryIdtb.Text = "" Or categorytb.Text = "" Then
            MsgBox("Missing Information")
        Else
            Dim Query As String = "Usp_Update_ItemsCategory"
            Dim Param As New List(Of SqlParameter) From {
                New SqlParameter("@Id", itemcategoryIdtb.Text),
                New SqlParameter("@ItemCategory", categorytb.Text),
                New SqlParameter("@IsActive", IsActiveChkB.Checked)
            }
            Dim result As Integer = InsertUpdateDelete(Query, Param, CommandType.StoredProcedure)
            If result = 0 Then
                Fill_Dgv()
                MsgBox("Item Category Details Updated Successfully")
                Reset()
            End If
        End If
    End Sub

    Private Sub ItemsCategoryDgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ItemsCategoryDgv.CellClick
        Try
            itemcategoryIdtb.Text = ItemsCategoryDgv.Rows(e.RowIndex).Cells(0).Value
            categorytb.Text = ItemsCategoryDgv.Rows(e.RowIndex).Cells(1).Value
            IsActiveChkB.Checked = ItemsCategoryDgv.Rows(e.RowIndex).Cells(2).Value
        Catch ex As Exception
            MsgBox("Select A Row")
        End Try
    End Sub
End Class