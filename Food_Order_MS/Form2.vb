Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class Register_form
    Dim Conne As New SqlConnection("Data Source =LAPTOP-796R91OO\MYSQL ; Initial Catalog = Form_db ; Integrated Security = True")
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Me.Hide()
        LoginForm.Show()
    End Sub

    Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles FnameTb.Leave
        If String.IsNullOrEmpty(FnameTb.Text) = True Then
            FnameTb.Focus()
            ErrorProvider1.SetError(Me.FnameTb, "Please enter the first name")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles LnameTb.Leave
        If String.IsNullOrEmpty(LnameTb.Text) = True Then
            LnameTb.Focus()
            ErrorProvider1.SetError(Me.LnameTb, "Please enter the first name")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub TextBox6_Leave(sender As Object, e As EventArgs) Handles EmailTb.Leave
        Dim pat As String = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
        If Regex.IsMatch(EmailTb.Text, pat) = False Then
            EmailTb.Focus()
            ErrorProvider3.SetError(Me.EmailTb, "Please enter correct email address ")
        Else
            ErrorProvider3.Clear()

        End If
    End Sub

    Private Sub TextBox3_Leave(sender As Object, e As EventArgs) Handles PhoneTb.Leave
        If String.IsNullOrEmpty(PhoneTb.Text) = True Then
            PhoneTb.Focus()
            ErrorProvider4.SetError(Me.PhoneTb, "Enter Password to proceed")
        Else
            ErrorProvider4.Clear()

        End If
    End Sub

    Private Sub TextBox4_Leave(sender As Object, e As EventArgs) Handles CpasswordTb.Leave
        If PasswordTb.Text = CpasswordTb.Text Then
            ErrorProvider5.Clear()
        Else
            CpasswordTb.Focus()
            ErrorProvider5.SetError(Me.CpasswordTb, "please retype the password correctly")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SignupBtn.Click
        If String.IsNullOrEmpty(LnameTb.Text) = True Then

            MessageBox.Show("You are required to fill the Last Name field to sign up  ")
            LnameTb.Focus()


        ElseIf String.IsNullOrEmpty(FnameTb.Text) = True Then

            MessageBox.Show("You are required to fill the First Name  field to sign up  ")
            FnameTb.Focus()

        ElseIf String.IsNullOrEmpty(PhoneTb.Text) = True Then

            MessageBox.Show("You are required to fill the Mobile number field to sign up  ")
            PhoneTb.Focus()

        ElseIf String.IsNullOrEmpty(CpasswordTb.Text) = True Then

            MessageBox.Show("You are required to fill the Confirm Password  field to sign up ")
            CpasswordTb.Focus()

        ElseIf String.IsNullOrEmpty(PasswordTb.Text) = True Then

            MessageBox.Show("You are required to fill the Password field to sign up  ")
            PasswordTb.Focus()

        ElseIf String.IsNullOrEmpty(EmailTb.Text) = True Then

            MessageBox.Show("You are required to fill the Emaid  field to sign up  ")
            EmailTb.Focus()

        Else

            Try
                Dim comm As New SqlCommand("insert into tbl_login([First_Name] ,[Last_Name], [Phone_Number], [Email_id] , [Password] ) values ('" & FnameTb.Text & "','" & LnameTb.Text & "', '" & PhoneTb.Text & "','" & EmailTb.Text & "','" & PasswordTb.Text & "') ", Conne)
                Conne.Open()
                comm.ExecuteNonQuery()
                Conne.Close()
                MsgBox("Registered successfully")
                Me.Close()
                LoginForm.Show()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub TextBox5_Leave(sender As Object, e As EventArgs) Handles PasswordTb.Leave
        Dim rat As String = "^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$"
        If Regex.IsMatch(PasswordTb.Text, rat) = False Then
            PasswordTb.Focus()
            ErrorProvider6.SetError(Me.PasswordTb, "The password must contain one uppercase letter, one lowercase letter, and one number or special character ")
        Else
            ErrorProvider6.Clear()

        End If
    End Sub
End Class