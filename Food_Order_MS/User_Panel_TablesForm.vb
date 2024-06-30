Imports System.Data.SqlClient

Public Class User_Panel_TablesForm
    Public Sub Fill_Dgv()
        Me.Usp_Get_TablesDataUserTableAdapter.Fill(Me.Poject_FOMSDataSet2.Usp_Get_TablesDataUser)
    End Sub
    Private Sub Stable_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Fill_Dgv()
    End Sub

    Private Sub Stable_DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Stable_DGV.CellClick
        Try
            TableIdTb.Text = Stable_DGV.Rows(e.RowIndex).Cells(0).Value
        Catch ex As Exception
            MsgBox("Select A Row")
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        Me.Hide()
        Reset()
    End Sub

    Private Sub Itemsbtn_Click(sender As Object, e As EventArgs) Handles TableBookBtn.Click
        Dim param As New List(Of SqlParameter) From {
            New SqlParameter("@TableNo", TableIdTb.Text)
        }
        Dim Query As String = "Usp_Book_Table"
        Dim Result As Integer = InsertUpdateDelete(Query, param, CommandType.StoredProcedure)
        If Result = 0 Then
            MsgBox("Table Booked Successfully")
            Fill_Dgv()
        End If
    End Sub

    Private Sub Reset()
        TableIdTb.Text = ""
    End Sub

End Class