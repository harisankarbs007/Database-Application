Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports AdvancedHMIDrivers
Imports Keyence.AutoID.SDK
Imports Keyence
Imports MfgControl.AdvancedHMI.Drivers.Common
Imports System.Drawing.Drawing2D
Imports System.Net
Imports System.Net.NetworkInformation
Imports MfgControl.AdvancedHMI.Drivers.AllenBradley.PCCC
Imports System.IO


Public Class MainForm
    '*******************************************************************************
    '* Stop polling when the form is not visible in order to reduce communications
    '* Copy this section of code to every new form created
    '*******************************************************************************
    Private NotFirstShow As Boolean
    Dim m_reader As New ReaderAccessor()
    Dim camfailcount As Integer = 0



    Private Sub Form_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.VisibleChanged
        '* Do not start comms on first show in case it was set to disable in design mode
        If NotFirstShow Then
            AdvancedHMIDrivers.Utilities.StopComsOnHidden(components, Me)
        Else
            NotFirstShow = True
        End If
    End Sub

    '***************************************************************
    '* .NET does not close hidden forms, so do it here
    '* to make sure forms are disposed and drivers close
    '***************************************************************
    Private Sub MainForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim index As Integer
        While index < My.Application.OpenForms.Count
            If My.Application.OpenForms(index) IsNot Me Then
                My.Application.OpenForms(index).Close()
            End If
            index += 1
        End While
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Writetolog("Form loaded")
        'Getting IP address from the text file in the Release folder
        EthernetIPforSLCMicroCom1.IPAddress = Strings.Left(My.Computer.FileSystem.ReadAllText("getip.txt"), 14)
        Writetolog("ip address read")
        lblipaddress.Text = "PLC: " & EthernetIPforSLCMicroCom1.IPAddress
        m_reader.IpAddress = "192.168.111.10" & Strings.Right((EthernetIPforSLCMicroCom1.IPAddress), 1)
        lblQRipaddress.Text = "QR: " & m_reader.IpAddress
        lblPCIPaddress.Text = "PC: " & "192.168.111.24" & Strings.Right((EthernetIPforSLCMicroCom1.IPAddress), 1)
        m_reader.CommandPort = 9003
        m_reader.DataPort = 9004
        lblExtrudername.Text = "Extruder " & Strings.Right((EthernetIPforSLCMicroCom1.IPAddress), 1)
        'Connect TCP/IP.
        Writetolog("Connecting to QRcode scanner")
        m_reader.Connect(AddressOf ReceivedDataAction)
        cmdSEND.Enabled = True
    End Sub
    '=======================BARCODE SCANNER PROGRAM=======================================================

    Dim m_searcher As New ReaderSearcher()
    Dim m_nicList As New List(Of NicSearchResult)()
    Dim COMMAND As String
    Dim isCamTrigg As Boolean = False
    Dim camconfig As Integer = 1

    Sub QRTRIGG()
        Writetolog("Qrtigger started")
        Try
            lblDataText.Text = ""
            'BarcodrReaderControl.LON() 'SENDING LON COMMAND FOR TRIGGERING QRCODE SCANNER
            ReceivedDataWrite(m_reader.ExecCommand("LON"))
            'Catch cex As 

            '    ' ExtErrCode shows the number of command error
            '    '
            '    camerror = "Command err," & cex.ExtErrCode

        Catch ex As Exception
            Label1.Text = ex.Message
            Writetolog("Trigger Failed")
        End Try
        EthernetIPforSLCMicroCom1.Write("B9:0/6", "0")
        Writetolog("QR triggered")
    End Sub


    Sub Camconfigchange()
        Writetolog("Read failed attempting to change config")
        camfailcount += 1
        If camconfig = 3 Then
            camconfig = 1
        Else camconfig += 1
        End If
        lbCameraFail.Text = "Camerafailcount:" & camfailcount
        lbCamconfig.Text = "Cam config= " & CStr(camconfig)

        Try
            '  BarcodrReaderControl.BLOAD(camconfig)
            ReceivedDataWrite(m_reader.ExecCommand("BLOAD," & camconfig))
            Writetolog($"BLOAD {camconfig}")
        Catch cex As Exception
            Writetolog("BLOAD failed")
        End Try
        Threading.Thread.Sleep(500)
    End Sub

    Private Sub ReceivedDataAction(data As Byte())
        'Define received data actions here.Defined actions work asynchronously.
        '"ReceivedDataWrite" works when reading data was received.
        BeginInvoke(New delegateUserControl(AddressOf ReceivedDataWrite), System.Text.Encoding.ASCII.GetString(data))
    End Sub

    Private Sub cmdSEND_Click(sender As Object, e As EventArgs) Handles cmdSEND.Click
        'If comboBox1.SelectedItem <> vbNullString Then
        'ExecCommand("command")is for sending a command and getting a command response.
        ReceivedDataWrite(m_reader.ExecCommand(COMMAND))
        'End If
    End Sub

    'delegateUserControl is for controlling UserControl from other threads.
    Private Delegate Sub delegateUserControl(str As String)
    Private Delegate Sub PLCcommerror(er As Exception)
    Private Sub ReceivedDataWrite(receivedData As String)
        lblDataText.Text = (receivedData)

        If lblDataText.Text = "ERROR" & vbCr And camfailcount < 3 Then
            EthernetIPforSLCMicroCom1.Write("B9:0/6", "0")
            Camconfigchange()
            QRTRIGG()
        ElseIf IsNumeric(receivedData) Then
            Writetolog($"QRcode read successful")
            EthernetIPforSLCMicroCom1.Write("B9:0/6", "1")
            camfailcount = 0
        End If
    End Sub

    'Dispose before closing Form for avoiding error.
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) _
     Handles Me.FormClosing
        m_reader.Dispose()
    End Sub

    Private Sub cmdLON_Click(sender As Object, e As EventArgs) Handles cmdLON.Click
        If camfailcount = 3 Then
            camfailcount = 0
        End If
        QRTRIGG()
    End Sub

    'To send commands to the SR-1000 Barcode scanner
    Private Sub tbCommand_TextChanged(sender As Object, e As EventArgs) Handles tbCommand.TextChanged
        COMMAND = tbCommand.Text
    End Sub
    'To Reconnect to camera when disconnected
    Private Sub cmdReconnect_Click(sender As Object, e As EventArgs) Handles cmdReconnect.Click
        ConnectQR()
    End Sub
    '========================PLC CONTROL==================================================================
    'Qr trigger from PLC when Extruder is in
    Private Sub QRCODETRIGGER(sender As Object, e As EventArgs) Handles fromPLCQRtrigger.DataChanged
        If fromPLCQRtrigger.Value = True And isCamTrigg = False Then
            If camfailcount = 3 Then
                camfailcount = 0
            End If
            QRTRIGG()
            isCamTrigg = True
        End If
        isCamTrigg = False
    End Sub

    Private Sub ConnectQR()
        Writetolog($"Trying to connect to QR")
        m_reader.Connect(AddressOf ReceivedDataAction)
        Writetolog($"Tried connecting to QR")
    End Sub

    'When barcode is recieved from the barcode scanner B9:0/6 is enabled. It trigger this sub routine to get data from the SQL database
    Private Sub BlFromPLC_NewBarcodeMemory_ValueChanged(sender As Object, e As EventArgs) Handles blFromPLC_NewBarcodeMemory.ValueChanged
        'Declare Local variables
        Dim BC(3) As String
        Dim ascii As String = lblDataText.Text
        Dim Valid_Barcode As String
        'Check to see if the flag has changed

        If blFromPLC_NewBarcodeMemory.Value = True Then
            Writetolog($"New Barcode read")
            Try

                If ascii <> "ERROR" & vbCr Then
                    RefreshDB(lblDataText.Text)
                    Valid_Barcode = "1"
                    EthernetIPforSLCMicroCom1.Write("B9:0/10", Valid_Barcode)
                    Writetolog($"Valid QR code read")
                Else
                    Valid_Barcode = "0"
                    EthernetIPforSLCMicroCom1.Write("B9:0/10", Valid_Barcode)
                    Writetolog($"Invalid QR code read")
                End If

            Catch ex As Exception
                Valid_Barcode = "0"
                EthernetIPforSLCMicroCom1.Write("B9:0/10", Valid_Barcode)
                ClearData()
                lbException.Text = CStr(ex.Message)
            End Try
        Else
            Valid_Barcode = "0"
            EthernetIPforSLCMicroCom1.Write("B9:0/10", Valid_Barcode)
        End If
    End Sub

    'Used for pinging the PLC all the time to show connection status on the HMI.
    Private Sub EthernetIPforSLCMicroCom1_DataReceived(sender As Object, e As PlcComEventArgs) Handles EthernetIPforSLCMicroCom1.DataReceived
        If DataSubscriberPCACTIVE.Value = "False" Then
            EthernetIPforSLCMicroCom1.Write("B9:2/15", "1")
        End If
    End Sub


    '========================SQLDATA CONTROL==================================================================
    Private SQL As New MoldsSQLCE
    'getting values from the SQL Database and updating all the labels and values on PLC 
    Private Sub RefreshDB(Fiix_ID As String)
        Writetolog($"SQL Access started for taking appropriate valiues")
        If Fiix_ID = "NoQRData" Or Fiix_ID = "ERROR" & vbCr Then
            Exit Sub
        End If
        SQL.AddParam("@id", Fiix_ID)
        SQL.ExecQuery("SELECT moldno,speed,pressure,type,RateofPress,control,rampdowntime FROM MoldsDB WHERE fiix_id=@id", 0)
        Writetolog($"SQL query is ran")
        lFiix_ID1.Text = Fiix_ID
        lToPLC_Speed.Text = SQL.SQLDS.Tables(0).Rows(0).Item("speed")
        lToPLC_Pressure.Text = SQL.SQLDS.Tables(0).Rows(0).Item("pressure")
        lToPLC_MoldType.Text = SQL.SQLDS.Tables(0).Rows(0).Item("type")
        lToPLC_Moldnumber.Text = SQL.SQLDS.Tables(0).Rows(0).Item("moldno")
        lToPLC_ROP.Text = SQL.SQLDS.Tables(0).Rows(0).Item("RateofPress")
        lToPLC_MoldControl.Text = SQL.SQLDS.Tables(0).Rows(0).Item("control") 'v2
        lToPLC_MoldRampdowntime.Text = SQL.SQLDS.Tables(0).Rows(0).Item("rampdowntime")
        EthernetIPforSLCMicroCom1.Write("N11:8", lToPLC_Pressure.Text)
        EthernetIPforSLCMicroCom1.Write("N11:10", lToPLC_ROP.Text)
        EthernetIPforSLCMicroCom1.Write("F12:3", lToPLC_Speed.Text)
        EthernetIPforSLCMicroCom1.Write("ST13:1", Trim(lToPLC_MoldType.Text))
        EthernetIPforSLCMicroCom1.Write("b9:4", lToPLC_MoldControl.Text)
        EthernetIPforSLCMicroCom1.Write("N11:15", lToPLC_MoldRampdowntime.Text) 'v3
        Writetolog($"SQL access was successful")
        ' lDBRefreshedCount.Text = SQL.RecordCount
    End Sub
    'Getting Values from HMI and updating the Database for the mold no selected
    Private Sub BlUpdate_ValueChanged(sender As Object, e As EventArgs) Handles blupdate.ValueChanged

        If blupdate.Text = "True" Then
            Writetolog($"Database update started")
            Try
                SQL.AddParam("@mold", CInt(blFromPLC_Setmold.Text))
                If blFromPLC_updatepressure.Text = "True" Then
                    SQL.AddParam("@setpressure", blFromPLC_SetPressure.Text)
                    SQL.ExecQuery("UPDATE MoldsDB SET pressure=@setpressure  WHERE moldno=@mold", 0)
                End If
                If blFromPLC_updatespeed.Text = "True" Then
                    SQL.AddParam("@setspeed", blFromPLC_SetSpeed.Text)
                    SQL.ExecQuery("UPDATE MoldsDB SET speed=@setspeed  WHERE moldno=@mold", 0)
                End If
                If blFromPLC_updateROP.Text = "True" Then
                    SQL.AddParam("@setrop", blfromPLC_setROP.Text)
                    SQL.ExecQuery("UPDATE MoldsDB SET RateofPress=@setrop  WHERE moldno=@mold", 0)
                End If
                'SQL.AddParam("fiix_id", 0)
                'SQL.ExecQuery("SELECT fiix_id FROM MoldsDB WHERE moldno=@mold", 0)
                'lFiix_ID1.Text = SQL.SQLDS.Tables(0).Rows(0).Item("fiix_id")
                'RefreshDB(lFiix_ID1.Text)
                EthernetIPforSLCMicroCom1.Write("B9:0/11", "0")
                EthernetIPforSLCMicroCom1.Write("B9:0/12", "0")
                EthernetIPforSLCMicroCom1.Write("B9:0/13", "0")
                EthernetIPforSLCMicroCom1.Write("B9:0/14", "0")
                SQL.Params.Clear()
                Writetolog($"Database update Successful")
            Catch ex As Exception
                EthernetIPforSLCMicroCom1.Write("B9:0/14", "0")
                ClearData()
                lbException.Text = CStr(ex.Message)
                Writetolog($"Database update failed")
            End Try
        End If

    End Sub

    'Clearing all the data once to get new values in
    Private Sub ClearData()
        lToPLC_Speed.Text = 0
        lToPLC_Pressure.Text = 0
        lToPLC_MoldType.Text = 0
        lToPLC_Moldnumber.Text = 0
    End Sub

    '========================APPLICATION CONTROL==================================================================
    'Sub networklist()
    '    'Get a list of IP addresses for all network interfaces on the local computer

    '    Dim networkInterfaces As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()
    '    Dim PCIPaddress As String = "0.0.0.0"
    '    For Each networkInterface As NetworkInterface In networkInterfaces
    '        Dim ipProperties As IPInterfaceProperties = networkInterface.GetIPProperties()
    '        Dim unicastAddresses As UnicastIPAddressInformationCollection = ipProperties.UnicastAddresses()

    '        If networkInterface.Name.Contains("Ethernet") Then
    '            PCIPaddress = unicastAddresses(1).Address.ToString
    '        End If
    '    Next
    '    EthernetIPforSLCMicroCom1.IPAddress = "192.168.111.1" & Strings.Right((PCIPaddress), 1)
    '    lblPCIPaddress.Text = "PC: " & PCIPADDRESS
    '    lblipaddress.Text = "PLC: " & EthernetIPforSLCMicroCom1.IPAddress
    '    m_reader.IpAddress = "192.168.111.10" & Strings.Right((PCIPaddress), 1)
    '    lblQRipaddress.Text = "QR: " & m_reader.IpAddress
    '    lblPCIPaddress.Text = "PC: " & "192.168.111.24" & Strings.Right((PCIPaddress), 1)
    '    m_reader.CommandPort = 9003
    '    m_reader.DataPort = 9004
    '    lblExtrudername.Text = "Extruder " & Strings.Right((EthernetIPforSLCMicroCom1.IPAddress), 1)
    'End Sub

    Private Sub EthernetIPforSLCMicroCom1_ComError(sender As Object, e As PlcComEventArgs) Handles EthernetIPforSLCMicroCom1.ComError
        MsgBox("Make Sure you have correct IP address on the getip text file in the application folder", MsgBoxStyle.OkOnly)
    End Sub

    Private Sub NoQRAlm_DataChanged(sender As Object, e As PlcComEventArgs) Handles NoQRAlm.DataChanged 'v3.1
        Writetolog($"Reconnecting due to QRcode read failure")
        ConnectQR()
    End Sub
    'v3.2 logging added to several places in the program.
    Sub Writetolog(log As String)
        Dim filePath As String = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log.txt")
        Using writer As StreamWriter = New StreamWriter(filePath, True)
            writer.WriteLine($"{DateTime.Now}--{log}")
        End Using
    End Sub
End Class
