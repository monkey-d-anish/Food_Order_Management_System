Imports System.Data.SqlClient

Module sqlModule
    '
    'Anish Acharya connection String:
    Public _constr As String = "Data Source=DESKTOP-A0E57PR\SQLEXPRESS;Initial Catalog=Poject_FOMS;Persist Security Info=True;User ID=sa;Password=Anish@07;"
    '
    '



    Public Function InsertUpdateDelete(ByVal Query As String, ByVal Param As List(Of SqlParameter), ByVal CmdType As CommandType) As Integer
        Using Con As New SqlConnection(_constr)
            Using Cmd As New SqlCommand(Query, Con)
                If Param IsNot Nothing Then
                    Cmd.Parameters.AddRange(Param.ToArray)
                End If
                Cmd.CommandType = CmdType
                Try
                    Con.Open()
                    Cmd.ExecuteNonQuery()
                    Return 0
                Catch ex As Exception
                    MsgBox("DataBase Expection " & ex.Message.ToString)
                    Return 1
                End Try
            End Using
        End Using
    End Function
    Public Function Login(ByVal Query As String, ByVal Param As List(Of SqlParameter), ByVal CmdType As CommandType) As Integer
        Dim ResponseMessage As Integer
        Using Con As New SqlConnection(_constr)
            Using Cmd As New SqlCommand(Query, Con)
                If Param IsNot Nothing Then
                    Cmd.Parameters.AddRange(Param.ToArray)
                End If
                Cmd.CommandType = CmdType
                Try
                    Con.Open()
                    ResponseMessage = Cmd.ExecuteScalar()
                    Return ResponseMessage
                Catch ex As Exception
                    MsgBox("DataBase Expection " & ex.Message.ToString)
                    Return 69
                End Try
            End Using
        End Using
    End Function
    Public Function GetData(ByVal Query As String, ByVal Param As List(Of SqlParameter), ByVal CmdType As CommandType) As DataTable
        Dim RDataTable As New DataTable()
        Using Con As New SqlConnection(_constr)
            Using Cmd As New SqlCommand(Query, Con)
                If Param IsNot Nothing Then
                    Cmd.Parameters.AddRange(Param.ToArray)
                End If
                Cmd.CommandType = CmdType
                Try
                    Con.Open()
                    Dim Adapter As New SqlDataAdapter(Cmd)
                    RDataTable = New DataTable()
                    Adapter.Fill(RDataTable)
                    Return RDataTable
                Catch ex As Exception
                    MsgBox("DataBase Expection " & ex.Message.ToString)
                    Return RDataTable
                End Try
            End Using
        End Using
    End Function
End Module
