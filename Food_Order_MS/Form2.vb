Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class Form2
    Dim Conne As New SqlConnection("Data Source =LAPTOP-796R91OO\MYSQL ; Initial Catalog = Form_db ; Integrated Security = True")
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles TextBox2.Leave
        If String.IsNullOrEmpty(TextBox2.Text) = True Then
            TextBox2.Focus()
            ErrorProvider1.SetError(Me.TextBox2, "Please enter the first name")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        If String.IsNullOrEmpty(TextBox1.Text) = True Then
            TextBox1.Focus()
            ErrorProvider1.SetError(Me.TextBox1, "Please enter the first name")
        Else
            ErrorProvider1.Clear()
        End If
    End Sub

    Private Sub TextBox6_Leave(sender As Object, e As EventArgs) Handles TextBox6.Leave
        Dim pat As String = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
        If Regex.IsMatch(TextBox6.Text, pat) = False Then
            TextBox6.Focus()
            ErrorProvider3.SetError(Me.TextBox6, "Please enter correct email address ")
        Else
            ErrorProvider3.Clear()

        End If
    End Sub

    Private Sub TextBox3_Leave(sender As Object, e As EventArgs) Handles TextBox3.Leave
        If String.IsNullOrEmpty(TextBox3.Text) = True Then
            TextBox3.Focus()
            ErrorProvider4.SetError(Me.TextBox3, "Enter Password to proceed")
        Else
            ErrorProvider4.Clear()

        End If
    End Sub

    Private Sub TextBox4_Leave(sender As Object, e As EventArgs) Handles TextBox4.Leave
        If TextBox5.Text = TextBox4.Text Then
            ErrorProvider5.Clear()
        Else
            TextBox4.Focus()
            ErrorProvider5.SetError(Me.TextBox4, "please retype the password correctly")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrEmpty(TextBox1.Text) = True Then

            MessageBox.Show("You are required to fill the Last Name field to sign up  ")
            TextBox1.Focus()


        ElseIf String.IsNullOrEmpty(TextBox2.Text) = True Then

            MessageBox.Show("You are required to fill the First Name  field to sign up  ")
            TextBox2.Focus()

        ElseIf String.IsNullOrEmpty(TextBox3.Text) = True Then

            MessageBox.Show("You are required to fill the Mobile number field to sign up  ")
            TextBox3.Focus()

        ElseIf String.IsNullOrEmpty(TextBox4.Text) = True Then

            MessageBox.Show("You are required to fill the Confirm Password  field to sign up ")
            TextBox4.Focus()

        ElseIf String.IsNullOrEmpty(TextBox5.Text) = True Then

            MessageBox.Show("You are required to fill the Password field to sign up  ")
            TextBox5.Focus()

        ElseIf String.IsNullOrEmpty(TextBox6.Text) = True Then

            MessageBox.Show("You are required to fill the Emaid  field to sign up  ")
            TextBox6.Focus()

        Else

            Try
                Dim comm As New SqlCommand("insert into tbl_login([First_Name] ,[Last_Name], [Phone_Number], [Email_id] , [Password] ) values ('" & TextBox2.Text & "','" & TextBox1.Text & "', '" & TextBox3.Text & "','" & TextBox6.Text & "','" & TextBox5.Text & "') ", Conne)
                Conne.Open()
                comm.ExecuteNonQuery()
                Conne.Close()
                MsgBox("Registered successfully")
                Me.Close()
                Form1.Show()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub TextBox5_Leave(sender As Object, e As EventArgs) Handles TextBox5.Leave
        Dim rat As String = "^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$"
        If Regex.IsMatch(TextBox5.Text, rat) = False Then
            TextBox5.Focus()
            ErrorProvider6.SetError(Me.TextBox5, "The password must contain one uppercase letter, one lowercase letter, and one number or special character ")
        Else
            ErrorProvider6.Clear()

        End If
    End Sub
End Class