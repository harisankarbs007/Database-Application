Imports System.Net.Sockets
Imports System.Text

Public Class EthernetListener

    Private Listener As TcpListener
    Private Client As TcpClient
    Private Stream As NetworkStream
    Private BufferSize As Integer = 1024
    Private Port As Integer = 1234 ' Change to your desired port number

    Private Sub ListenForCommands()
        Listener = New TcpListener(System.Net.IPAddress.Any, Port)
        Listener.Start()
        While True
            Client = Listener.AcceptTcpClient()
            Stream = Client.GetStream()

            Dim Command As String = ReadCommand()
            RunFunction(Command)

            Stream.Close()
            Client.Close()
        End While
    End Sub

    Private Function ReadCommand() As String
        Dim Buffer(BufferSize) As Byte
        Dim Data As String = ""
        While Stream.DataAvailable
            Dim BytesRead As Integer = Stream.Read(Buffer, 0, BufferSize)
            Data += Encoding.ASCII.GetString(Buffer, 0, BytesRead)
        End While
        Return Data
    End Function

    Private Sub RunFunction(Command As String)
        ' Implement your function based on the received command
        Select Case Command
            Case "start"
                StartFunction()
            Case Else
                ' Invalid command
                Console.WriteLine("Invalid command received: " & Command)
        End Select
    End Sub

    Private Sub StartFunction()
        ' Implement your start function here
        Console.WriteLine("Starting function...")
    End Sub

    Friend Sub Start()
        Dim ListenThread As New Threading.Thread(AddressOf ListenForCommands)
        ListenThread.Start()
    End Sub
    Private Sub stopthread()
        Dim ListenThread As New Threading.Thread(AddressOf ListenForCommands)
        ListenThread.Abort()
    End Sub
End Class
