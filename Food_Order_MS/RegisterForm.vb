Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class Register_form
    Dim Conne As New SqlConnection(_constr)
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        LoginForm.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles AddUserBtn.Click
        If FnameTb.Text = "" Or LnameTb.Text = "" Or PhoneTb.Text = "" Or UserNameTb.Text = "" Or PasswordTb.Text = "" Or CpasswordTb.Text = "" Then
            MsgBox("Missing Information")
        ElseIf PasswordTb.Text <> CpasswordTb.Text Then
            MsgBox("Password Doesn't Match")
        ElseIf UserIdLbl.Text <> "" Then
            MsgBox("Can't Add Exisiting Data")
        Else
            Dim Query As String = "Usp_Add_User"
            Dim Param As New List(Of SqlParameter) From {
                New SqlParameter("@FName", FnameTb.Text),
                New SqlParameter("@LName", LnameTb.Text),
                New SqlParameter("@Phone", PhoneTb.Text),
                New SqlParameter("@UName", UserNameTb.Text),
                New SqlParameter("@Password", PasswordTb.Text),
                New SqlParameter("@IsAdmin", IsAdminChkB.Checked)
            }
            Dim result As Integer = InsertUpdateDelete(Query, Param, CommandType.StoredProcedure)
            If result = 0 Then
                Me.Usp_Get_UsersTableAdapter.Fill(Me.Poject_FOMSDataSet5.Usp_Get_Users)
                MsgBox("User Added Successfully")
                Reset()
            End If
        End If
    End Sub

    Private Sub IsAdminChkB_CheckedChanged(sender As Object, e As EventArgs) Handles IsAdminChkB.CheckedChanged
        If IsAdminChkB.Checked = True Then
            IsAdminChkB.BackColor = Color.Green
        Else
            IsAdminChkB.BackColor = Color.Crimson
        End If
    End Sub

    Private Sub Register_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Poject_FOMSDataSet5.Usp_Get_Users' table. You can move, or remove it, as needed.
        Me.Usp_Get_UsersTableAdapter.Fill(Me.Poject_FOMSDataSet5.Usp_Get_Users)
    End Sub

    Private Sub UsersDgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles UsersDgv.CellClick
        Try
            UserIdLbl.Text = UsersDgv.Rows(e.RowIndex).Cells(0).Value
            FnameTb.Text = UsersDgv.Rows(e.RowIndex).Cells(1).Value
            LnameTb.Text = UsersDgv.Rows(e.RowIndex).Cells(2).Value
            PhoneTb.Text = UsersDgv.Rows(e.RowIndex).Cells(3).Value
            UserNameTb.Text = UsersDgv.Rows(e.RowIndex).Cells(4).Value
            IsAdminChkB.Checked = UsersDgv.Rows(e.RowIndex).Cells(5).Value
        Catch ex As Exception
            MsgBox("Select A Row")
        End Try
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        If FnameTb.Text = "" Or LnameTb.Text = "" Or PhoneTb.Text = "" Or UserNameTb.Text = "" Or PasswordTb.Text = "" Or CpasswordTb.Text = "" Or UserIdLbl.Text = "" Then
            MsgBox("Missing Information")
        ElseIf PasswordTb.Text <> CpasswordTb.Text Then
            MsgBox("Password Doesn't Match")
        Else
            Dim Query As String = "Usp_Update_Users"
            Dim Param As New List(Of SqlParameter) From {
                New SqlParameter("@Id", UserIdLbl.Text),
                New SqlParameter("@FName", FnameTb.Text),
                New SqlParameter("@LName", LnameTb.Text),
                New SqlParameter("@Phone", PhoneTb.Text),
                New SqlParameter("@UName", UserNameTb.Text),
                New SqlParameter("@Password", PasswordTb.Text),
                New SqlParameter("@IsAdmin", IsAdminChkB.Checked)
            }
            Dim result As Integer = InsertUpdateDelete(Query, Param, CommandType.StoredProcedure)
            If result = 0 Then
                Me.Usp_Get_UsersTableAdapter.Fill(Me.Poject_FOMSDataSet5.Usp_Get_Users)
                MsgBox("User Details Updated Successfully")
                Reset()
            End If
        End If
    End Sub

    Private Sub RemoveUserBtn_Click(sender As Object, e As EventArgs) Handles RemoveUserBtn.Click
        If FnameTb.Text = "" Or LnameTb.Text = "" Or PhoneTb.Text = "" Or UserNameTb.Text = "" Then
            MsgBox("Missing Information")
        Else
            Dim Query As String = "Usp_Delete_User"
            Dim Param As New List(Of SqlParameter) From {
                New SqlParameter("@Id", UserIdLbl.Text)
            }
            Dim result As Integer = InsertUpdateDelete(Query, Param, CommandType.StoredProcedure)
            If result = 0 Then
                Me.Usp_Get_UsersTableAdapter.Fill(Me.Poject_FOMSDataSet5.Usp_Get_Users)
                MsgBox("User Removed Successfully")
                Reset()
            End If
        End If
    End Sub

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Reset()
    End Sub
    Private Sub Reset()
        UserIdLbl.Text = ""
        FnameTb.Text = ""
        LnameTb.Text = ""
        PhoneTb.Text = ""
        UserNameTb.Text = ""
        PasswordTb.Text = ""
        CpasswordTb.Text = ""
        IsAdminChkB.Checked = False
    End Sub
End Class