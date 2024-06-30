Public Class Admin_Panel_Form
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Signoutbtn.Click
        LoginForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Itemsbtn.Click
        Admin_Panel_ItemsForm.Show()
        Admin_Panel_ItemsForm.BringToFront()
    End Sub

    Private Sub Tabletbn_Click(sender As Object, e As EventArgs) Handles Tabletbn.Click
        Admin_Panel_TablesForm.Show()
        Admin_Panel_TablesForm.BringToFront()
    End Sub

    Private Sub Transaction_Click(sender As Object, e As EventArgs) Handles Transaction.Click
        Admin_Panel_TransactionForm.Show()
        Admin_Panel_TransactionForm.BringToFront()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub

    Private Sub AddCategoryBtn_Click(sender As Object, e As EventArgs) Handles AddCategoryBtn.Click
        Admin_Panel_AddCategoryForm.Show()
        Admin_Panel_AddCategoryForm.BringToFront()
    End Sub
End Class