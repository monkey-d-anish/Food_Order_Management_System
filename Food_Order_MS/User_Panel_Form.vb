Public Class User_Panel_Form
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Application.Exit()
    End Sub
    Private Sub TableBtn_Click(sender As Object, e As EventArgs) Handles TableBtn.Click
        User_Panel_TablesForm.Show()
        User_Panel_TablesForm.BringToFront()
    End Sub
    Private Sub CartBtn_Click(sender As Object, e As EventArgs) Handles CartBtn.Click
        User_Panel_CartForm.Show()
        User_Panel_TablesForm.BringToFront()
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Hide()
        LoginForm.Show()
    End Sub
End Class