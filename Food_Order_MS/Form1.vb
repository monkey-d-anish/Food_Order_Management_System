Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports Microsoft.VisualBasic.ApplicationServices

Public Class Form1
    Dim connect As New SqlConnection(" Data Source = LAPTOP-796R91OO\MYSQL; Initial Catalog=Form_db ; Integrated Security = True")
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles User_txt.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Me.Hide()
        Form2.Show()

    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles User_txt.Leave
        If String.IsNullOrEmpty(User_txt.Text) = True Then
            User_txt.Focus()
            ErrorProvider1.SetError(Me.User_txt, "Please enter your user name first ")
        Else
            ErrorProvider1.Clear()

        End If
    End Sub

    Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles Password_txt.Leave
        If String.IsNullOrEmpty(Password_txt.Text) = True Then
            Password_txt.Focus()
            ErrorProvider2.SetError(Me.Password_txt, "Please enter the password to proceed")
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Password_txt.PasswordChar = ""
        Else
            Password_txt.PasswordChar = "*"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If String.IsNullOrEmpty(User_txt.Text) = True Then
            MessageBox.Show("Please enter the User name to signin ")
        ElseIf String.IsNullOrEmpty(Password_txt.Text) = True Then
            MessageBox.Show("Please enter the password to sign in ")
        ElseIf ComboBox1.Text = "User" Then
            Dim comd As New SqlCommand("select * from tbl_login where First_Name= '" & User_txt.Text & "' and Password = '" & Password_txt.Text & "'", connect)
            Dim adapt As SqlDataAdapter = New SqlDataAdapter(comd)
            Dim tabl As DataTable = New DataTable()
            adapt.Fill(tabl)
            If (tabl.Rows.Count > 0) Then
                MessageBox.Show("LOG IN SUCCESSFUL ")
                Me.Hide()
                User_form.Show()
            Else
                MessageBox.Show("Please Enter the correct user name or Password")
                User_txt.Clear()
                User_txt.Focus()
                Password_txt.Clear()

            End If
        ElseIf ComboBox1.Text = "Admin" Then
                Me.Hide()
                Admin_form.Show()
            Else
                MessageBox.Show("Please select the User type to continue")
        End If
    End Sub
End Class
