Imports System.Data.SqlClient

Public Class Admin_Panel_AddCategoryTableForm
    Private Sub Fill_Dgv()
        'TODO: This line of code loads data into the 'Poject_FOMSDataSet8.Usp_Get_TableCategory' table. You can move, or remove it, as needed.
        Me.Usp_Get_TableCategoryTableAdapter.Fill(Me.Poject_FOMSDataSet8.Usp_Get_TableCategory)
    End Sub
    Private Sub Admin_Panel_AddCategoryTableForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fill_Dgv()
    End Sub

    Private Sub Exitbtn_Click(sender As Object, e As EventArgs) Handles Exitbtn.Click
        Me.Close()
    End Sub

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Reset()
    End Sub

    Private Sub Reset()
        TablecategoryIdtb.Text = ""
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

    Private Sub AddtableCategoryBtn_Click(sender As Object, e As EventArgs) Handles AddtableCategoryBtn.Click
        If categorytb.Text = "" Or IsActiveChkB.Checked = False Then
            MsgBox("Missing Information")
        ElseIf TablecategoryIdtb.Text <> "" Then
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
                MsgBox("Table Category Added Successfully")
                Reset()
            End If
        End If
    End Sub

    Private Sub UpdateTablecategoryBtn_Click(sender As Object, e As EventArgs) Handles UpdatetablecategoryBtn.Click
        If TablecategoryIdtb.Text = "" Or categorytb.Text = "" Then
            MsgBox("Missing Information")
        Else
            Dim Query As String = "Usp_Update_ItemsCategory"
            Dim Param As New List(Of SqlParameter) From {
                New SqlParameter("@Id", TablecategoryIdtb.Text),
                New SqlParameter("@ItemCategory", categorytb.Text),
                New SqlParameter("@IsActive", IsActiveChkB.Checked)
            }
            Dim result As Integer = InsertUpdateDelete(Query, Param, CommandType.StoredProcedure)
            If result = 0 Then
                Fill_Dgv()
                MsgBox("Table Category Details Updated Successfully")
                Reset()
            End If
        End If
    End Sub

    Private Sub TableCategoryDgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TableCategoryDgv.CellClick
        Try
            TablecategoryIdtb.Text = TableCategoryDgv.Rows(e.RowIndex).Cells(0).Value
            categorytb.Text = TableCategoryDgv.Rows(e.RowIndex).Cells(1).Value
            IsActiveChkB.Checked = TableCategoryDgv.Rows(e.RowIndex).Cells(2).Value
        Catch ex As Exception
            MsgBox("Select A Row")
        End Try
    End Sub

End Class