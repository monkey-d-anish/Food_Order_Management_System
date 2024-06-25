Public Class Admin_form
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Signoutbtn.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Itemsbtn.Click
        Items_Form.Show()
    End Sub

    Private Sub Tabletbn_Click(sender As Object, e As EventArgs) Handles Tabletbn.Click
        ' Table_Form.Show()
    End Sub

    Private Sub Transaction_Click(sender As Object, e As EventArgs) Handles Transaction.Click
        Transaction_Form.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Application.Exit()
    End Sub
End Class