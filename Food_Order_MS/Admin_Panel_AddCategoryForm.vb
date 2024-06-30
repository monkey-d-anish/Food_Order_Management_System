Public Class Admin_Panel_AddCategoryForm
    Private Sub tblcategorybtn_Click(sender As Object, e As EventArgs) Handles tblcategorybtn.Click
        Admin_Panel_AddCategoryTableForm.Show()
        Admin_Panel_AddCategoryTableForm.BringToFront()
    End Sub

    Private Sub itmcategorybtn_Click(sender As Object, e As EventArgs) Handles itmcategorybtn.Click
        Admin_Panel_AddCategoryItemForm.Show()
        Admin_Panel_AddCategoryItemForm.BringToFront()
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub
End Class