Imports System.Data.SqlClient

Public Class Admin_Panel_TransactionForm
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Reset()
    End Sub

    Private Sub Admin_Panel_TransactionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Poject_FOMSDataSet4.Usp_Get_TransactionsByTable' table. You can move, or remove it, as needed.
        Me.Usp_Get_TransactionsByTableTableAdapter.Fill(Me.Poject_FOMSDataSet4.Usp_Get_TransactionsByTable)
        'TODO: This line of code loads data into the 'Poject_FOMSDataSet3.Usp_Get_Transactions' table. You can move, or remove it, as needed.
        Me.Usp_Get_TransactionsTableAdapter.Fill(Me.Poject_FOMSDataSet3.Usp_Get_Transactions)

    End Sub

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        Dim Query As String = "Usp_Get_TransactionsByDate"
        Dim Param As New List(Of SqlParameter) From {
                New SqlParameter("@FDate", FromDTP.Value),
                New SqlParameter("@TDate", ToDTP.Value)
        }
        Dim TBl As New DataTable
        TBl = GetData(Query, Param, CommandType.StoredProcedure)
        Transaction_DGV.DataSource = TBl
        GetTransactionsByTableByDate()
    End Sub
    Private Sub GetTransactionsByTableByDate()
        Dim Query = "Usp_Get_DistinctTransactionsByDate"
        Dim Param As New List(Of SqlParameter) From {
                New SqlParameter("@FDate", FromDTP.Value),
                New SqlParameter("@TDate", ToDTP.Value)
        }
        Dim TBl As New DataTable
        TBl = GetData(Query, Param, CommandType.StoredProcedure)
        DistinctTransactionsDGV.DataSource = TBl
    End Sub

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        Transaction_DGV.DataSource = Poject_FOMSDataSet3.Usp_Get_Transactions
        DistinctTransactionsDGV.DataSource = Poject_FOMSDataSet4.Usp_Get_TransactionsByTable
    End Sub
End Class