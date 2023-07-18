Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlServerCe
Imports Microsoft.VisualBasic.FileIO.FileSystem
Public Class MoldsSQLCE
    'SQL Connection

    Private SQLCon As New SqlCeConnection("Data Source=" & My.Computer.FileSystem.SpecialDirectories.Desktop & "\Molds.sdf;")
    Public SQLCmd As New SqlCeCommand

    'SQL Data
    Public SQLDA As New SqlCeDataAdapter
    Public SQLDS As New DataSet

    'Query Parameters
    Public Params As New List(Of SqlCeParameter)

    'Query Statistics
    Public RecordCount As Integer
    Public TotalRecordCount As Integer
    Public Exception As String

    Public Sub ExecQuery(Query As String, isCount As Boolean)
        Try
            SQLCon.Open()
            If isCount = True Then
                'Create SQL Command

                SQLCmd = New SqlCeCommand(Query, SQLCon)
                TotalRecordCount = CStr(SQLCmd.ExecuteScalar)
            Else
                'Create SQL Command
                SQLCmd = New SqlCeCommand(Query, SQLCon)
            End If


            'Load Parameters into SQL Command
            Params.ForEach(Sub(x) SQLCmd.Parameters.Add(x))

            'Clear Parameters List
            Params.Clear()

            'Execute Command and fill dataset
            SQLDS = New DataSet
            SQLDA = New SqlCeDataAdapter(SQLCmd)
            SQLDA.Fill(SQLDS)


            SQLCon.Close()
        Catch ex As Exception
            'Capture errors
            Exception = ex.Message
        End Try

        'Make sure connection is closed
        If SQLCon.State = ConnectionState.Open Then SQLCon.Close()
    End Sub

    Public Sub AddParam(Name As String, Value As Object)
        Dim NewParam As New SqlCeParameter(Name, Value)
        Params.Add(NewParam)
    End Sub

End Class

