Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices

Public Class Admin_Panel_TablesForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Reset()
    End Sub

    Public Sub Fill_Dgv()
        Me.Usp_Get_TableDataAdminTableAdapter.Fill(Me.Poject_FOMSDataSet1.Usp_Get_TableDataAdmin)
    End Sub

    Private Sub Table_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillCb()
        Fill_Dgv()
    End Sub

    Private Sub Reset()
        For Each control As Control In Me.Controls
            If TypeOf control Is TextBox Then
                control.Text = ""
            End If
        Next
        IsActiveChkB.Checked = False
        TablecategoryCb.Text = ""
    End Sub

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Reset()
    End Sub

    Private Sub AddBtn_Click(sender As Object, e As EventArgs) Handles AddBtn.Click
        If TablenoTb.Text = "" Or TableCapacitytb.Text = "" Or TablecategoryCb.Text = "" Then
            MsgBox("Missing Information")
        Else
            Dim param As New List(Of SqlParameter) From {
            New SqlParameter("@T_No", TablenoTb.Text),
            New SqlParameter("@T_Capacity", TableCapacitytb.Text),
            New SqlParameter("@T_Category", TablecategoryCb.Text.ToString()),
            New SqlParameter("@T_Active", IsActiveChkB.Checked)
        }
            Dim Query As String = "Usp_Add_Table"
            Dim Result As Integer = InsertUpdateDelete(Query, param, CommandType.StoredProcedure)
            If Result = 0 Then
                Fill_Dgv()
                MsgBox("Table Added Successfully")
                Reset()
            End If
        End If
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        If TablenoTb.Text = "" Or TableCapacitytb.Text = "" Or TablecategoryCb.Text = "" Then
            MsgBox("Missing Information")
        Else
            Dim param As New List(Of SqlParameter) From {
           New SqlParameter("U_T_No", TablenoTb.Text.ToString()),
           New SqlParameter("@U_T_Capacity", TableCapacitytb.Text.ToString()),
           New SqlParameter("@U_T_Category", TablecategoryCb.Text.ToString()),
           New SqlParameter("@U_T_Active", IsActiveChkB.Checked)
        }
            Dim Query As String = "Usp_Update_TablesData"
            Dim Result As Integer = InsertUpdateDelete(Query, param, CommandType.StoredProcedure)
            If Result = 0 Then
                Fill_Dgv()
                MsgBox("Table Details Updated Successfully Successfully")
                Reset()
            End If
        End If
    End Sub

    Private Sub Table_Dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Table_Dgv.CellClick
        Try
            TablenoTb.Text = Table_Dgv.Rows(e.RowIndex).Cells(0).Value
            TableCapacitytb.Text = Table_Dgv.Rows(e.RowIndex).Cells(1).Value
            TablecategoryCb.Text = Table_Dgv.Rows(e.RowIndex).Cells(2).Value
            IsActiveChkB.Checked = Table_Dgv.Rows(e.RowIndex).Cells(3).Value
        Catch ex As Exception
            MsgBox("Select A Row")
        End Try
    End Sub

    Private Sub IsAdminChkB_CheckedChanged(sender As Object, e As EventArgs) Handles IsActiveChkB.CheckedChanged
        If IsActiveChkB.Checked = True Then
            IsActiveChkB.BackColor = Color.Green
        Else
            IsActiveChkB.BackColor = Color.Crimson
        End If
    End Sub

    Private Sub FillCb()
        Dim Query As String = "Usp_Get_ActiveTablesCategory"
        Dim Param As New List(Of SqlParameter) From {}
        Dim Tbl As New DataTable
        Tbl = GetData(Query, Param, CommandType.StoredProcedure)
        TablecategoryCb.DataSource = Tbl
        TablecategoryCb.DisplayMember = "Table Category"
        TablecategoryCb.ValueMember = "Table Category"
    End Sub

    Private Sub TablecategoryCb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TablecategoryCb.SelectedIndexChanged
        TablecategoryCb.Text = ""
    End Sub
End Class