Imports System.Data.Odbc

Module Connection

    Public Connection As OdbcConnection = New OdbcConnection("DSN=laundryOK")
    Public Command As New OdbcCommand

    Public Sub SetConnection()
        If Connection.State = ConnectionState.Closed Then Connection.Open()
    End Sub

    Public Sub SetTableHeader(Table As DataGridView, Columns() As String)
        For i As Int32 = 0 To Columns.Count - 1
            Table.Columns(i).HeaderText = Columns(i)
        Next
    End Sub

    Function GetDataSourceFromDB(Query As String) As DataTable

        Dim DataTable = New DataTable()

        Try

            Command.Connection = Connection
            Command.CommandText = Query

            Dim DataReader As OdbcDataReader = Command.ExecuteReader()
            DataTable.Load(DataReader)
            DataReader.Close()

            Return DataTable

        Catch ex As Exception

            MessageBox.Show(ex.ToString(), "Fatar Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return DataTable

        End Try

    End Function

End Module
