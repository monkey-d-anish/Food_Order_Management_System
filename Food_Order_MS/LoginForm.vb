Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.VisualBasic.ApplicationServices

Public Class LoginForm
    Dim connect As New SqlConnection(_constr)
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub
    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles UnameTb.Leave
        If String.IsNullOrEmpty(UnameTb.Text) = True Then
            UnameTb.Focus()
            ErrorProvider1.SetError(Me.UnameTb, "Please enter your user name first ")
        Else
            ErrorProvider1.Clear()

        End If
    End Sub
    Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles PasswordTb.Leave
        If String.IsNullOrEmpty(PasswordTb.Text) = True Then
            PasswordTb.Focus()
            ErrorProvider2.SetError(Me.PasswordTb, "Please enter the password to proceed")
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            PasswordTb.PasswordChar = ""
        Else
            PasswordTb.PasswordChar = "*"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Query As String = "Usp_Get_Login"
        Dim Param As New List(Of SqlParameter) From {
                New SqlParameter("@UserName", UnameTb.Text),
                New SqlParameter("@Password", PasswordTb.Text)
        }
        Dim result As Integer = Login(Query, Param, CommandType.StoredProcedure)
        If result = 1 Then
            Me.Hide()
            Admin_Panel_Form.Show()
        ElseIf result = 0 Then
            Me.Hide()
            User_Panel_Form.Show()
        ElseIf UnameTb.Text = "Admin" And PasswordTb.Text = "Admin" Then
            Me.Hide()
            Register_form.Show()
        ElseIf result = 404 Then
            MsgBox("Wrong UserName Or Password")
        End If
        Reset()
    End Sub
    Private Sub Reset()
        UnameTb.Text = ""
        PasswordTb.Text = ""
    End Sub
End Class