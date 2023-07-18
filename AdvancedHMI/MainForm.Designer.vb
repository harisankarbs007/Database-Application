<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    '   <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    ' <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ForceItemsIntoToolBox1 = New MfgControl.AdvancedHMI.Drivers.ForceItemsIntoToolbox()
        Me.cmdSEND = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblDataText = New System.Windows.Forms.Label()
        Me.lbException = New System.Windows.Forms.Label()
        Me.lFiixID = New System.Windows.Forms.Label()
        Me.lToPLC_ROP = New System.Windows.Forms.Label()
        Me.lToPLC_MoldType = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lToPLC_Moldnumber = New System.Windows.Forms.Label()
        Me.lPressure = New System.Windows.Forms.Label()
        Me.lToPLC_Pressure = New System.Windows.Forms.Label()
        Me.lSpeed = New System.Windows.Forms.Label()
        Me.lToPLC_Speed = New System.Windows.Forms.Label()
        Me.lFiix_ID1 = New System.Windows.Forms.Label()
        Me.lbCameraFail = New System.Windows.Forms.Label()
        Me.lbCamconfig = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblipaddress = New System.Windows.Forms.Label()
        Me.lblQRipaddress = New System.Windows.Forms.Label()
        Me.lblPCIPaddress = New System.Windows.Forms.Label()
        Me.lbl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmdReconnect = New System.Windows.Forms.Button()
        Me.LBBARCODEECXEPTION = New System.Windows.Forms.Label()
        Me.cmdLON = New AdvancedHMIControls.BasicButton()
        Me.EthernetIPforSLCMicroCom1 = New AdvancedHMIDrivers.EthernetIPforSLCMicroCom(Me.components)
        Me.lMoldType = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblExtrudername = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BasicButton1 = New AdvancedHMIControls.BasicButton()
        Me.blupdate = New AdvancedHMIControls.BasicLabel()
        Me.blFromPLC_Setmold = New AdvancedHMIControls.BasicLabel()
        Me.blFromPLC_SetPressure = New AdvancedHMIControls.BasicLabel()
        Me.blFromPLC_updateROP = New AdvancedHMIControls.BasicLabel()
        Me.blFromPLC_SetSpeed = New AdvancedHMIControls.BasicLabel()
        Me.blfromPLC_setROP = New AdvancedHMIControls.BasicLabel()
        Me.blFromPLC_updatespeed = New AdvancedHMIControls.BasicLabel()
        Me.blFromPLC_updatepressure = New AdvancedHMIControls.BasicLabel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lToPLC_MoldControl = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.blFromPLC_NewBarcodeMemory = New AdvancedHMIControls.BasicLabel()
        Me.fromPLCQRtrigger = New AdvancedHMIControls.DataSubscriber(Me.components)
        Me.DataSubscriberPCACTIVE = New AdvancedHMIControls.DataSubscriber(Me.components)
        Me.lToPLC_MoldRampdowntime = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.EthernetIPforSLCMicroCom1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.fromPLCQRtrigger, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSubscriberPCACTIVE, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(6, 572)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "For Development Source Code Visit" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "http://www.advancedhmi.com"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'cmdSEND
        '
        Me.cmdSEND.ForeColor = System.Drawing.Color.Black
        Me.cmdSEND.Location = New System.Drawing.Point(212, 28)
        Me.cmdSEND.Name = "cmdSEND"
        Me.cmdSEND.Size = New System.Drawing.Size(82, 30)
        Me.cmdSEND.TabIndex = 70
        Me.cmdSEND.Text = "SEND"
        Me.cmdSEND.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(99, 28)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(107, 27)
        Me.TextBox1.TabIndex = 72
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(186, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 16)
        Me.Label8.TabIndex = 100
        Me.Label8.Text = "NewBarcode:"
        '
        'lblDataText
        '
        Me.lblDataText.AutoSize = True
        Me.lblDataText.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDataText.ForeColor = System.Drawing.Color.Transparent
        Me.lblDataText.Location = New System.Drawing.Point(82, 68)
        Me.lblDataText.Name = "lblDataText"
        Me.lblDataText.Size = New System.Drawing.Size(70, 19)
        Me.lblDataText.TabIndex = 101
        Me.lblDataText.Text = "DataText"
        '
        'lbException
        '
        Me.lbException.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbException.AutoSize = True
        Me.lbException.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbException.ForeColor = System.Drawing.Color.Transparent
        Me.lbException.Location = New System.Drawing.Point(20, 445)
        Me.lbException.Name = "lbException"
        Me.lbException.Size = New System.Drawing.Size(88, 19)
        Me.lbException.TabIndex = 102
        Me.lbException.Text = "Exceptions"
        '
        'lFiixID
        '
        Me.lFiixID.BackColor = System.Drawing.Color.Transparent
        Me.lFiixID.Enabled = False
        Me.lFiixID.ForeColor = System.Drawing.Color.White
        Me.lFiixID.Location = New System.Drawing.Point(4, 14)
        Me.lFiixID.Name = "lFiixID"
        Me.lFiixID.Size = New System.Drawing.Size(78, 21)
        Me.lFiixID.TabIndex = 168
        Me.lFiixID.Text = "Fiix ID"
        '
        'lToPLC_ROP
        '
        Me.lToPLC_ROP.BackColor = System.Drawing.Color.Transparent
        Me.lToPLC_ROP.Enabled = False
        Me.lToPLC_ROP.ForeColor = System.Drawing.Color.White
        Me.lToPLC_ROP.Location = New System.Drawing.Point(100, 92)
        Me.lToPLC_ROP.Name = "lToPLC_ROP"
        Me.lToPLC_ROP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lToPLC_ROP.Size = New System.Drawing.Size(65, 23)
        Me.lToPLC_ROP.TabIndex = 178
        Me.lToPLC_ROP.Text = "0000"
        '
        'lToPLC_MoldType
        '
        Me.lToPLC_MoldType.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lToPLC_MoldType.AutoSize = True
        Me.lToPLC_MoldType.BackColor = System.Drawing.Color.Transparent
        Me.lToPLC_MoldType.Enabled = False
        Me.lToPLC_MoldType.ForeColor = System.Drawing.Color.White
        Me.lToPLC_MoldType.Location = New System.Drawing.Point(100, 141)
        Me.lToPLC_MoldType.Name = "lToPLC_MoldType"
        Me.lToPLC_MoldType.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lToPLC_MoldType.Size = New System.Drawing.Size(53, 23)
        Me.lToPLC_MoldType.TabIndex = 171
        Me.lToPLC_MoldType.Text = "Type"
        Me.lToPLC_MoldType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Enabled = False
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(4, 92)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 21)
        Me.Label16.TabIndex = 177
        Me.Label16.Text = "ROP"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Enabled = False
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(4, 40)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 21)
        Me.Label4.TabIndex = 173
        Me.Label4.Text = "MoldNo"
        '
        'lToPLC_Moldnumber
        '
        Me.lToPLC_Moldnumber.BackColor = System.Drawing.Color.Transparent
        Me.lToPLC_Moldnumber.Enabled = False
        Me.lToPLC_Moldnumber.ForeColor = System.Drawing.Color.White
        Me.lToPLC_Moldnumber.Location = New System.Drawing.Point(100, 40)
        Me.lToPLC_Moldnumber.Name = "lToPLC_Moldnumber"
        Me.lToPLC_Moldnumber.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lToPLC_Moldnumber.Size = New System.Drawing.Size(52, 23)
        Me.lToPLC_Moldnumber.TabIndex = 174
        Me.lToPLC_Moldnumber.Text = "0000"
        '
        'lPressure
        '
        Me.lPressure.BackColor = System.Drawing.Color.Transparent
        Me.lPressure.Enabled = False
        Me.lPressure.ForeColor = System.Drawing.Color.White
        Me.lPressure.Location = New System.Drawing.Point(4, 66)
        Me.lPressure.Name = "lPressure"
        Me.lPressure.Size = New System.Drawing.Size(90, 21)
        Me.lPressure.TabIndex = 166
        Me.lPressure.Text = "Pressure"
        '
        'lToPLC_Pressure
        '
        Me.lToPLC_Pressure.BackColor = System.Drawing.Color.Transparent
        Me.lToPLC_Pressure.Enabled = False
        Me.lToPLC_Pressure.ForeColor = System.Drawing.Color.White
        Me.lToPLC_Pressure.Location = New System.Drawing.Point(100, 66)
        Me.lToPLC_Pressure.Name = "lToPLC_Pressure"
        Me.lToPLC_Pressure.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lToPLC_Pressure.Size = New System.Drawing.Size(53, 23)
        Me.lToPLC_Pressure.TabIndex = 170
        Me.lToPLC_Pressure.Text = "0000"
        '
        'lSpeed
        '
        Me.lSpeed.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lSpeed.BackColor = System.Drawing.Color.Transparent
        Me.lSpeed.Enabled = False
        Me.lSpeed.ForeColor = System.Drawing.Color.White
        Me.lSpeed.Location = New System.Drawing.Point(-115, 249)
        Me.lSpeed.Name = "lSpeed"
        Me.lSpeed.Size = New System.Drawing.Size(79, 21)
        Me.lSpeed.TabIndex = 165
        Me.lSpeed.Text = "Speed"
        '
        'lToPLC_Speed
        '
        Me.lToPLC_Speed.BackColor = System.Drawing.Color.Transparent
        Me.lToPLC_Speed.Enabled = False
        Me.lToPLC_Speed.ForeColor = System.Drawing.Color.White
        Me.lToPLC_Speed.Location = New System.Drawing.Point(100, 118)
        Me.lToPLC_Speed.Name = "lToPLC_Speed"
        Me.lToPLC_Speed.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lToPLC_Speed.Size = New System.Drawing.Size(45, 23)
        Me.lToPLC_Speed.TabIndex = 169
        Me.lToPLC_Speed.Text = "000"
        '
        'lFiix_ID1
        '
        Me.lFiix_ID1.BackColor = System.Drawing.Color.Transparent
        Me.lFiix_ID1.Enabled = False
        Me.lFiix_ID1.ForeColor = System.Drawing.Color.White
        Me.lFiix_ID1.Location = New System.Drawing.Point(100, 14)
        Me.lFiix_ID1.Name = "lFiix_ID1"
        Me.lFiix_ID1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lFiix_ID1.Size = New System.Drawing.Size(84, 23)
        Me.lFiix_ID1.TabIndex = 172
        Me.lFiix_ID1.Text = "00000000"
        '
        'lbCameraFail
        '
        Me.lbCameraFail.AutoSize = True
        Me.lbCameraFail.ForeColor = System.Drawing.Color.Transparent
        Me.lbCameraFail.Location = New System.Drawing.Point(313, 28)
        Me.lbCameraFail.Name = "lbCameraFail"
        Me.lbCameraFail.Size = New System.Drawing.Size(105, 19)
        Me.lbCameraFail.TabIndex = 181
        Me.lbCameraFail.Text = "----------------"
        '
        'lbCamconfig
        '
        Me.lbCamconfig.AutoSize = True
        Me.lbCamconfig.ForeColor = System.Drawing.Color.Transparent
        Me.lbCamconfig.Location = New System.Drawing.Point(313, 64)
        Me.lbCamconfig.Name = "lbCamconfig"
        Me.lbCamconfig.Size = New System.Drawing.Size(105, 19)
        Me.lbCamconfig.TabIndex = 182
        Me.lbCamconfig.Text = "----------------"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox2.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.logo_crp
        Me.PictureBox2.Location = New System.Drawing.Point(548, 448)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(25, 22)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 184
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Image = Global.MfgControl.AdvancedHMI.My.Resources.Resources.AdvancedHMILogoBR
        Me.PictureBox1.Location = New System.Drawing.Point(579, 448)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 22)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 69
        Me.PictureBox1.TabStop = False
        '
        'lblipaddress
        '
        Me.lblipaddress.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblipaddress.AutoSize = True
        Me.lblipaddress.Font = New System.Drawing.Font("Arial monospaced for SAP", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblipaddress.ForeColor = System.Drawing.Color.Transparent
        Me.lblipaddress.Location = New System.Drawing.Point(526, 9)
        Me.lblipaddress.Name = "lblipaddress"
        Me.lblipaddress.Size = New System.Drawing.Size(83, 11)
        Me.lblipaddress.TabIndex = 185
        Me.lblipaddress.Text = "PLC IPAddress"
        '
        'lblQRipaddress
        '
        Me.lblQRipaddress.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblQRipaddress.AutoSize = True
        Me.lblQRipaddress.Font = New System.Drawing.Font("Arial monospaced for SAP", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQRipaddress.ForeColor = System.Drawing.Color.Transparent
        Me.lblQRipaddress.Location = New System.Drawing.Point(526, 20)
        Me.lblQRipaddress.Name = "lblQRipaddress"
        Me.lblQRipaddress.Size = New System.Drawing.Size(83, 11)
        Me.lblQRipaddress.TabIndex = 186
        Me.lblQRipaddress.Text = "QR IPAddress:"
        '
        'lblPCIPaddress
        '
        Me.lblPCIPaddress.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPCIPaddress.AutoSize = True
        Me.lblPCIPaddress.Font = New System.Drawing.Font("Arial monospaced for SAP", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPCIPaddress.ForeColor = System.Drawing.Color.Transparent
        Me.lblPCIPaddress.Location = New System.Drawing.Point(526, 30)
        Me.lblPCIPaddress.Name = "lblPCIPaddress"
        Me.lblPCIPaddress.Size = New System.Drawing.Size(83, 11)
        Me.lblPCIPaddress.TabIndex = 187
        Me.lblPCIPaddress.Text = "QR IPAddress:"
        '
        'lbl
        '
        Me.lbl.AutoSize = True
        Me.lbl.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl.ForeColor = System.Drawing.Color.Transparent
        Me.lbl.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbl.Location = New System.Drawing.Point(5, 35)
        Me.lbl.Name = "lbl"
        Me.lbl.Size = New System.Drawing.Size(88, 19)
        Me.lbl.TabIndex = 188
        Me.lbl.Text = "Command:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Transparent
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(5, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 19)
        Me.Label2.TabIndex = 189
        Me.Label2.Text = "DataText:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdReconnect)
        Me.GroupBox1.Controls.Add(Me.LBBARCODEECXEPTION)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.lbl)
        Me.GroupBox1.Controls.Add(Me.cmdLON)
        Me.GroupBox1.Controls.Add(Me.lbCamconfig)
        Me.GroupBox1.Controls.Add(Me.lbCameraFail)
        Me.GroupBox1.Controls.Add(Me.lblDataText)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.cmdSEND)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.RosyBrown
        Me.GroupBox1.Location = New System.Drawing.Point(190, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(448, 122)
        Me.GroupBox1.TabIndex = 190
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "QRCODE"
        '
        'cmdReconnect
        '
        Me.cmdReconnect.ForeColor = System.Drawing.Color.Black
        Me.cmdReconnect.Location = New System.Drawing.Point(342, 90)
        Me.cmdReconnect.Name = "cmdReconnect"
        Me.cmdReconnect.Size = New System.Drawing.Size(103, 30)
        Me.cmdReconnect.TabIndex = 195
        Me.cmdReconnect.Text = "Reconnect"
        Me.cmdReconnect.UseVisualStyleBackColor = True
        '
        'LBBARCODEECXEPTION
        '
        Me.LBBARCODEECXEPTION.AutoSize = True
        Me.LBBARCODEECXEPTION.ForeColor = System.Drawing.Color.Transparent
        Me.LBBARCODEECXEPTION.Location = New System.Drawing.Point(82, 89)
        Me.LBBARCODEECXEPTION.Name = "LBBARCODEECXEPTION"
        Me.LBBARCODEECXEPTION.Size = New System.Drawing.Size(105, 19)
        Me.LBBARCODEECXEPTION.TabIndex = 194
        Me.LBBARCODEECXEPTION.Text = "----------------"
        '
        'cmdLON
        '
        Me.cmdLON.BackColor = System.Drawing.Color.Black
        Me.cmdLON.ComComponent = Me.EthernetIPforSLCMicroCom1
        Me.cmdLON.ForeColor = System.Drawing.Color.Black
        Me.cmdLON.ForeColorAltername = System.Drawing.Color.Black
        Me.cmdLON.Highlight = False
        Me.cmdLON.HighlightColor = System.Drawing.Color.Green
        Me.cmdLON.Location = New System.Drawing.Point(212, 60)
        Me.cmdLON.MaximumHoldTime = 3000
        Me.cmdLON.MinimumHoldTime = 1000
        Me.cmdLON.Name = "cmdLON"
        Me.cmdLON.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentaryReset
        Me.cmdLON.PLCAddressClick = "b9:0/6"
        Me.cmdLON.SelectTextAlternate = False
        Me.cmdLON.Size = New System.Drawing.Size(82, 30)
        Me.cmdLON.TabIndex = 183
        Me.cmdLON.Text = "LON"
        Me.cmdLON.TextAlternate = Nothing
        Me.cmdLON.UseVisualStyleBackColor = True
        Me.cmdLON.ValueToWrite = 0
        '
        'EthernetIPforSLCMicroCom1
        '
        Me.EthernetIPforSLCMicroCom1.CIPConnectionSize = 508
        Me.EthernetIPforSLCMicroCom1.DisableSubscriptions = False
        Me.EthernetIPforSLCMicroCom1.IniFileName = ""
        Me.EthernetIPforSLCMicroCom1.IniFileSection = Nothing
        Me.EthernetIPforSLCMicroCom1.IPAddress = "192.168.111.14"
        Me.EthernetIPforSLCMicroCom1.IsPLC5 = False
        Me.EthernetIPforSLCMicroCom1.MaxPCCCPacketSize = 236
        Me.EthernetIPforSLCMicroCom1.PollRateOverride = 500
        Me.EthernetIPforSLCMicroCom1.Port = 44818
        Me.EthernetIPforSLCMicroCom1.RoutePath = Nothing
        Me.EthernetIPforSLCMicroCom1.Timeout = 5000
        '
        'lMoldType
        '
        Me.lMoldType.BackColor = System.Drawing.Color.Transparent
        Me.lMoldType.Enabled = False
        Me.lMoldType.ForeColor = System.Drawing.Color.White
        Me.lMoldType.Location = New System.Drawing.Point(4, 141)
        Me.lMoldType.Name = "lMoldType"
        Me.lMoldType.Size = New System.Drawing.Size(78, 31)
        Me.lMoldType.TabIndex = 179
        Me.lMoldType.Text = "Type"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Enabled = False
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(4, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 21)
        Me.Label3.TabIndex = 191
        Me.Label3.Text = "Speed"
        '
        'lblExtrudername
        '
        Me.lblExtrudername.BackColor = System.Drawing.Color.Transparent
        Me.lblExtrudername.Enabled = False
        Me.lblExtrudername.Font = New System.Drawing.Font("PV 8x20", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExtrudername.ForeColor = System.Drawing.Color.IndianRed
        Me.lblExtrudername.Location = New System.Drawing.Point(11, 7)
        Me.lblExtrudername.Name = "lblExtrudername"
        Me.lblExtrudername.Size = New System.Drawing.Size(201, 37)
        Me.lblExtrudername.TabIndex = 192
        Me.lblExtrudername.Text = "Extruder"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(4, 12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(207, 23)
        Me.Label5.TabIndex = 193
        Me.Label5.Text = "DB Update Command:"
        '
        'Label6
        '
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(527, 78)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 23)
        Me.Label6.TabIndex = 163
        Me.Label6.Text = "Trigger"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(128, 78)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 23)
        Me.Label11.TabIndex = 164
        Me.Label11.Text = "Mold no"
        '
        'Label7
        '
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(253, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 23)
        Me.Label7.TabIndex = 161
        Me.Label7.Text = "Trigger"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label18
        '
        Me.Label18.ForeColor = System.Drawing.Color.White
        Me.Label18.Location = New System.Drawing.Point(378, 78)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(75, 23)
        Me.Label18.TabIndex = 159
        Me.Label18.Text = "Trigger"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.White
        Me.Label15.Location = New System.Drawing.Point(253, 12)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(103, 23)
        Me.Label15.TabIndex = 150
        Me.Label15.Text = "Speed Set"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.ForeColor = System.Drawing.Color.White
        Me.Label26.Location = New System.Drawing.Point(527, 12)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(86, 23)
        Me.Label26.TabIndex = 154
        Me.Label26.Text = "ROP set"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.White
        Me.Label14.Location = New System.Drawing.Point(378, 12)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(125, 23)
        Me.Label14.TabIndex = 152
        Me.Label14.Text = "Pressure Set"
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.BasicButton1)
        Me.Panel1.Controls.Add(Me.blupdate)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.blFromPLC_Setmold)
        Me.Panel1.Controls.Add(Me.blFromPLC_SetPressure)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.blFromPLC_updateROP)
        Me.Panel1.Controls.Add(Me.Label26)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.blFromPLC_SetSpeed)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.blfromPLC_setROP)
        Me.Panel1.Controls.Add(Me.blFromPLC_updatespeed)
        Me.Panel1.Controls.Add(Me.blFromPLC_updatepressure)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Location = New System.Drawing.Point(16, 273)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(644, 169)
        Me.Panel1.TabIndex = 194
        '
        'BasicButton1
        '
        Me.BasicButton1.BackColor = System.Drawing.Color.Black
        Me.BasicButton1.ComComponent = Me.EthernetIPforSLCMicroCom1
        Me.BasicButton1.ForeColor = System.Drawing.Color.Black
        Me.BasicButton1.ForeColorAltername = System.Drawing.Color.Black
        Me.BasicButton1.Highlight = False
        Me.BasicButton1.HighlightColor = System.Drawing.Color.Green
        Me.BasicButton1.Location = New System.Drawing.Point(464, 134)
        Me.BasicButton1.MaximumHoldTime = 3000
        Me.BasicButton1.MinimumHoldTime = 500
        Me.BasicButton1.Name = "BasicButton1"
        Me.BasicButton1.OutputType = MfgControl.AdvancedHMI.Controls.OutputType.MomentaryReset
        Me.BasicButton1.PLCAddressClick = "B9:0/14"
        Me.BasicButton1.SelectTextAlternate = False
        Me.BasicButton1.Size = New System.Drawing.Size(173, 28)
        Me.BasicButton1.TabIndex = 166
        Me.BasicButton1.Text = "DB Update Reset"
        Me.BasicButton1.TextAlternate = Nothing
        Me.BasicButton1.UseVisualStyleBackColor = True
        Me.BasicButton1.ValueToWrite = 0
        '
        'blupdate
        '
        Me.blupdate.BackColor = System.Drawing.Color.Transparent
        Me.blupdate.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.blupdate.ComComponent = Me.EthernetIPforSLCMicroCom1
        Me.blupdate.DisplayAsTime = False
        Me.blupdate.ForeColor = System.Drawing.Color.White
        Me.blupdate.Highlight = False
        Me.blupdate.HighlightColor = System.Drawing.Color.Red
        Me.blupdate.HighlightForeColor = System.Drawing.Color.White
        Me.blupdate.HighlightKeyCharacter = "!"
        Me.blupdate.InterpretValueAsBCD = False
        Me.blupdate.KeypadAlphaNumeric = False
        Me.blupdate.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.blupdate.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.blupdate.KeypadMaxValue = 0R
        Me.blupdate.KeypadMinValue = 0R
        Me.blupdate.KeypadScaleFactor = 1.0R
        Me.blupdate.KeypadShowCurrentValue = False
        Me.blupdate.KeypadText = Nothing
        Me.blupdate.KeypadWidth = 300
        Me.blupdate.Location = New System.Drawing.Point(165, 42)
        Me.blupdate.Name = "blupdate"
        Me.blupdate.NumericFormat = Nothing
        Me.blupdate.PLCAddressKeypad = ""
        Me.blupdate.PLCAddressValue = "B9:0/14"
        Me.blupdate.PollRate = 0
        Me.blupdate.Size = New System.Drawing.Size(20, 23)
        Me.blupdate.TabIndex = 192
        Me.blupdate.Text = "0"
        Me.blupdate.Value = "0"
        Me.blupdate.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.blupdate.ValueLeftPadLength = 0
        Me.blupdate.ValuePrefix = Nothing
        Me.blupdate.ValueScaleFactor = 1.0R
        Me.blupdate.ValueSuffix = Nothing
        Me.blupdate.ValueToSubtractFrom = 0!
        '
        'blFromPLC_Setmold
        '
        Me.blFromPLC_Setmold.BackColor = System.Drawing.Color.Transparent
        Me.blFromPLC_Setmold.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.blFromPLC_Setmold.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.blFromPLC_Setmold.ComComponent = Me.EthernetIPforSLCMicroCom1
        Me.blFromPLC_Setmold.DisplayAsTime = False
        Me.blFromPLC_Setmold.ForeColor = System.Drawing.Color.White
        Me.blFromPLC_Setmold.Highlight = False
        Me.blFromPLC_Setmold.HighlightColor = System.Drawing.Color.Red
        Me.blFromPLC_Setmold.HighlightForeColor = System.Drawing.Color.White
        Me.blFromPLC_Setmold.HighlightKeyCharacter = "!"
        Me.blFromPLC_Setmold.InterpretValueAsBCD = False
        Me.blFromPLC_Setmold.KeypadAlphaNumeric = True
        Me.blFromPLC_Setmold.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.blFromPLC_Setmold.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.blFromPLC_Setmold.KeypadMaxValue = 0R
        Me.blFromPLC_Setmold.KeypadMinValue = 0R
        Me.blFromPLC_Setmold.KeypadScaleFactor = 1.0R
        Me.blFromPLC_Setmold.KeypadShowCurrentValue = False
        Me.blFromPLC_Setmold.KeypadText = Nothing
        Me.blFromPLC_Setmold.KeypadWidth = 300
        Me.blFromPLC_Setmold.Location = New System.Drawing.Point(133, 108)
        Me.blFromPLC_Setmold.Name = "blFromPLC_Setmold"
        Me.blFromPLC_Setmold.NumericFormat = Nothing
        Me.blFromPLC_Setmold.PLCAddressKeypad = ""
        Me.blFromPLC_Setmold.PLCAddressValue = "n11:14"
        Me.blFromPLC_Setmold.PollRate = 0
        Me.blFromPLC_Setmold.Size = New System.Drawing.Size(65, 23)
        Me.blFromPLC_Setmold.TabIndex = 165
        Me.blFromPLC_Setmold.Text = "000"
        Me.blFromPLC_Setmold.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.blFromPLC_Setmold.Value = "000"
        Me.blFromPLC_Setmold.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.blFromPLC_Setmold.ValueLeftPadLength = 0
        Me.blFromPLC_Setmold.ValuePrefix = Nothing
        Me.blFromPLC_Setmold.ValueScaleFactor = 1.0R
        Me.blFromPLC_Setmold.ValueSuffix = Nothing
        Me.blFromPLC_Setmold.ValueToSubtractFrom = 0!
        '
        'blFromPLC_SetPressure
        '
        Me.blFromPLC_SetPressure.BackColor = System.Drawing.Color.Transparent
        Me.blFromPLC_SetPressure.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.blFromPLC_SetPressure.ComComponent = Me.EthernetIPforSLCMicroCom1
        Me.blFromPLC_SetPressure.DisplayAsTime = False
        Me.blFromPLC_SetPressure.ForeColor = System.Drawing.Color.White
        Me.blFromPLC_SetPressure.Highlight = False
        Me.blFromPLC_SetPressure.HighlightColor = System.Drawing.Color.Red
        Me.blFromPLC_SetPressure.HighlightForeColor = System.Drawing.Color.White
        Me.blFromPLC_SetPressure.HighlightKeyCharacter = "!"
        Me.blFromPLC_SetPressure.InterpretValueAsBCD = False
        Me.blFromPLC_SetPressure.KeypadAlphaNumeric = False
        Me.blFromPLC_SetPressure.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.blFromPLC_SetPressure.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.blFromPLC_SetPressure.KeypadMaxValue = 0R
        Me.blFromPLC_SetPressure.KeypadMinValue = 0R
        Me.blFromPLC_SetPressure.KeypadScaleFactor = 1.0R
        Me.blFromPLC_SetPressure.KeypadShowCurrentValue = False
        Me.blFromPLC_SetPressure.KeypadText = Nothing
        Me.blFromPLC_SetPressure.KeypadWidth = 300
        Me.blFromPLC_SetPressure.Location = New System.Drawing.Point(383, 42)
        Me.blFromPLC_SetPressure.Name = "blFromPLC_SetPressure"
        Me.blFromPLC_SetPressure.NumericFormat = Nothing
        Me.blFromPLC_SetPressure.PLCAddressKeypad = ""
        Me.blFromPLC_SetPressure.PLCAddressValue = "N11:6"
        Me.blFromPLC_SetPressure.PollRate = 0
        Me.blFromPLC_SetPressure.Size = New System.Drawing.Size(65, 23)
        Me.blFromPLC_SetPressure.TabIndex = 153
        Me.blFromPLC_SetPressure.Text = "000"
        Me.blFromPLC_SetPressure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.blFromPLC_SetPressure.Value = "000"
        Me.blFromPLC_SetPressure.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.blFromPLC_SetPressure.ValueLeftPadLength = 0
        Me.blFromPLC_SetPressure.ValuePrefix = Nothing
        Me.blFromPLC_SetPressure.ValueScaleFactor = 1.0R
        Me.blFromPLC_SetPressure.ValueSuffix = Nothing
        Me.blFromPLC_SetPressure.ValueToSubtractFrom = 0!
        '
        'blFromPLC_updateROP
        '
        Me.blFromPLC_updateROP.BackColor = System.Drawing.Color.Transparent
        Me.blFromPLC_updateROP.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.blFromPLC_updateROP.ComComponent = Me.EthernetIPforSLCMicroCom1
        Me.blFromPLC_updateROP.DisplayAsTime = False
        Me.blFromPLC_updateROP.ForeColor = System.Drawing.Color.White
        Me.blFromPLC_updateROP.Highlight = False
        Me.blFromPLC_updateROP.HighlightColor = System.Drawing.Color.Red
        Me.blFromPLC_updateROP.HighlightForeColor = System.Drawing.Color.White
        Me.blFromPLC_updateROP.HighlightKeyCharacter = "!"
        Me.blFromPLC_updateROP.InterpretValueAsBCD = False
        Me.blFromPLC_updateROP.KeypadAlphaNumeric = False
        Me.blFromPLC_updateROP.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.blFromPLC_updateROP.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.blFromPLC_updateROP.KeypadMaxValue = 0R
        Me.blFromPLC_updateROP.KeypadMinValue = 0R
        Me.blFromPLC_updateROP.KeypadScaleFactor = 1.0R
        Me.blFromPLC_updateROP.KeypadShowCurrentValue = False
        Me.blFromPLC_updateROP.KeypadText = Nothing
        Me.blFromPLC_updateROP.KeypadWidth = 300
        Me.blFromPLC_updateROP.Location = New System.Drawing.Point(554, 108)
        Me.blFromPLC_updateROP.Name = "blFromPLC_updateROP"
        Me.blFromPLC_updateROP.NumericFormat = Nothing
        Me.blFromPLC_updateROP.PLCAddressKeypad = ""
        Me.blFromPLC_updateROP.PLCAddressValue = "B9:0/13"
        Me.blFromPLC_updateROP.PollRate = 0
        Me.blFromPLC_updateROP.Size = New System.Drawing.Size(20, 23)
        Me.blFromPLC_updateROP.TabIndex = 162
        Me.blFromPLC_updateROP.Text = "0"
        Me.blFromPLC_updateROP.Value = "0"
        Me.blFromPLC_updateROP.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.blFromPLC_updateROP.ValueLeftPadLength = 0
        Me.blFromPLC_updateROP.ValuePrefix = Nothing
        Me.blFromPLC_updateROP.ValueScaleFactor = 1.0R
        Me.blFromPLC_updateROP.ValueSuffix = Nothing
        Me.blFromPLC_updateROP.ValueToSubtractFrom = 0!
        '
        'blFromPLC_SetSpeed
        '
        Me.blFromPLC_SetSpeed.BackColor = System.Drawing.Color.Transparent
        Me.blFromPLC_SetSpeed.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.blFromPLC_SetSpeed.ComComponent = Me.EthernetIPforSLCMicroCom1
        Me.blFromPLC_SetSpeed.DisplayAsTime = False
        Me.blFromPLC_SetSpeed.ForeColor = System.Drawing.Color.White
        Me.blFromPLC_SetSpeed.Highlight = False
        Me.blFromPLC_SetSpeed.HighlightColor = System.Drawing.Color.Red
        Me.blFromPLC_SetSpeed.HighlightForeColor = System.Drawing.Color.White
        Me.blFromPLC_SetSpeed.HighlightKeyCharacter = "!"
        Me.blFromPLC_SetSpeed.InterpretValueAsBCD = False
        Me.blFromPLC_SetSpeed.KeypadAlphaNumeric = False
        Me.blFromPLC_SetSpeed.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.blFromPLC_SetSpeed.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.blFromPLC_SetSpeed.KeypadMaxValue = 0R
        Me.blFromPLC_SetSpeed.KeypadMinValue = 0R
        Me.blFromPLC_SetSpeed.KeypadScaleFactor = 1.0R
        Me.blFromPLC_SetSpeed.KeypadShowCurrentValue = False
        Me.blFromPLC_SetSpeed.KeypadText = Nothing
        Me.blFromPLC_SetSpeed.KeypadWidth = 300
        Me.blFromPLC_SetSpeed.Location = New System.Drawing.Point(258, 42)
        Me.blFromPLC_SetSpeed.Name = "blFromPLC_SetSpeed"
        Me.blFromPLC_SetSpeed.NumericFormat = Nothing
        Me.blFromPLC_SetSpeed.PLCAddressKeypad = ""
        Me.blFromPLC_SetSpeed.PLCAddressValue = "F12:1"
        Me.blFromPLC_SetSpeed.PollRate = 0
        Me.blFromPLC_SetSpeed.Size = New System.Drawing.Size(65, 23)
        Me.blFromPLC_SetSpeed.TabIndex = 151
        Me.blFromPLC_SetSpeed.Text = "000"
        Me.blFromPLC_SetSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.blFromPLC_SetSpeed.Value = "000"
        Me.blFromPLC_SetSpeed.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.blFromPLC_SetSpeed.ValueLeftPadLength = 0
        Me.blFromPLC_SetSpeed.ValuePrefix = Nothing
        Me.blFromPLC_SetSpeed.ValueScaleFactor = 1.0R
        Me.blFromPLC_SetSpeed.ValueSuffix = Nothing
        Me.blFromPLC_SetSpeed.ValueToSubtractFrom = 0!
        '
        'blfromPLC_setROP
        '
        Me.blfromPLC_setROP.BackColor = System.Drawing.Color.Transparent
        Me.blfromPLC_setROP.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.blfromPLC_setROP.ComComponent = Me.EthernetIPforSLCMicroCom1
        Me.blfromPLC_setROP.DisplayAsTime = False
        Me.blfromPLC_setROP.ForeColor = System.Drawing.Color.White
        Me.blfromPLC_setROP.Highlight = False
        Me.blfromPLC_setROP.HighlightColor = System.Drawing.Color.Red
        Me.blfromPLC_setROP.HighlightForeColor = System.Drawing.Color.White
        Me.blfromPLC_setROP.HighlightKeyCharacter = "!"
        Me.blfromPLC_setROP.InterpretValueAsBCD = False
        Me.blfromPLC_setROP.KeypadAlphaNumeric = False
        Me.blfromPLC_setROP.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.blfromPLC_setROP.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.blfromPLC_setROP.KeypadMaxValue = 0R
        Me.blfromPLC_setROP.KeypadMinValue = 0R
        Me.blfromPLC_setROP.KeypadScaleFactor = 1.0R
        Me.blfromPLC_setROP.KeypadShowCurrentValue = False
        Me.blfromPLC_setROP.KeypadText = Nothing
        Me.blfromPLC_setROP.KeypadWidth = 300
        Me.blfromPLC_setROP.Location = New System.Drawing.Point(527, 42)
        Me.blfromPLC_setROP.Name = "blfromPLC_setROP"
        Me.blfromPLC_setROP.NumericFormat = Nothing
        Me.blfromPLC_setROP.PLCAddressKeypad = ""
        Me.blfromPLC_setROP.PLCAddressValue = "N11:11"
        Me.blfromPLC_setROP.PollRate = 0
        Me.blfromPLC_setROP.Size = New System.Drawing.Size(65, 23)
        Me.blfromPLC_setROP.TabIndex = 155
        Me.blfromPLC_setROP.Text = "000"
        Me.blfromPLC_setROP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.blfromPLC_setROP.Value = "000"
        Me.blfromPLC_setROP.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.blfromPLC_setROP.ValueLeftPadLength = 0
        Me.blfromPLC_setROP.ValuePrefix = Nothing
        Me.blfromPLC_setROP.ValueScaleFactor = 1.0R
        Me.blfromPLC_setROP.ValueSuffix = Nothing
        Me.blfromPLC_setROP.ValueToSubtractFrom = 0!
        '
        'blFromPLC_updatespeed
        '
        Me.blFromPLC_updatespeed.BackColor = System.Drawing.Color.Transparent
        Me.blFromPLC_updatespeed.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.blFromPLC_updatespeed.ComComponent = Me.EthernetIPforSLCMicroCom1
        Me.blFromPLC_updatespeed.DisplayAsTime = False
        Me.blFromPLC_updatespeed.ForeColor = System.Drawing.Color.White
        Me.blFromPLC_updatespeed.Highlight = False
        Me.blFromPLC_updatespeed.HighlightColor = System.Drawing.Color.Red
        Me.blFromPLC_updatespeed.HighlightForeColor = System.Drawing.Color.White
        Me.blFromPLC_updatespeed.HighlightKeyCharacter = "!"
        Me.blFromPLC_updatespeed.InterpretValueAsBCD = False
        Me.blFromPLC_updatespeed.KeypadAlphaNumeric = False
        Me.blFromPLC_updatespeed.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.blFromPLC_updatespeed.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.blFromPLC_updatespeed.KeypadMaxValue = 0R
        Me.blFromPLC_updatespeed.KeypadMinValue = 0R
        Me.blFromPLC_updatespeed.KeypadScaleFactor = 1.0R
        Me.blFromPLC_updatespeed.KeypadShowCurrentValue = False
        Me.blFromPLC_updatespeed.KeypadText = Nothing
        Me.blFromPLC_updatespeed.KeypadWidth = 300
        Me.blFromPLC_updatespeed.Location = New System.Drawing.Point(280, 108)
        Me.blFromPLC_updatespeed.Name = "blFromPLC_updatespeed"
        Me.blFromPLC_updatespeed.NumericFormat = Nothing
        Me.blFromPLC_updatespeed.PLCAddressKeypad = ""
        Me.blFromPLC_updatespeed.PLCAddressValue = "B9:0/11"
        Me.blFromPLC_updatespeed.PollRate = 0
        Me.blFromPLC_updatespeed.Size = New System.Drawing.Size(20, 23)
        Me.blFromPLC_updatespeed.TabIndex = 160
        Me.blFromPLC_updatespeed.Text = "0"
        Me.blFromPLC_updatespeed.Value = "0"
        Me.blFromPLC_updatespeed.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.blFromPLC_updatespeed.ValueLeftPadLength = 0
        Me.blFromPLC_updatespeed.ValuePrefix = Nothing
        Me.blFromPLC_updatespeed.ValueScaleFactor = 1.0R
        Me.blFromPLC_updatespeed.ValueSuffix = Nothing
        Me.blFromPLC_updatespeed.ValueToSubtractFrom = 0!
        '
        'blFromPLC_updatepressure
        '
        Me.blFromPLC_updatepressure.BackColor = System.Drawing.Color.Transparent
        Me.blFromPLC_updatepressure.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.blFromPLC_updatepressure.ComComponent = Me.EthernetIPforSLCMicroCom1
        Me.blFromPLC_updatepressure.DisplayAsTime = False
        Me.blFromPLC_updatepressure.ForeColor = System.Drawing.Color.White
        Me.blFromPLC_updatepressure.Highlight = False
        Me.blFromPLC_updatepressure.HighlightColor = System.Drawing.Color.Red
        Me.blFromPLC_updatepressure.HighlightForeColor = System.Drawing.Color.White
        Me.blFromPLC_updatepressure.HighlightKeyCharacter = "!"
        Me.blFromPLC_updatepressure.InterpretValueAsBCD = False
        Me.blFromPLC_updatepressure.KeypadAlphaNumeric = False
        Me.blFromPLC_updatepressure.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.blFromPLC_updatepressure.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.blFromPLC_updatepressure.KeypadMaxValue = 0R
        Me.blFromPLC_updatepressure.KeypadMinValue = 0R
        Me.blFromPLC_updatepressure.KeypadScaleFactor = 1.0R
        Me.blFromPLC_updatepressure.KeypadShowCurrentValue = False
        Me.blFromPLC_updatepressure.KeypadText = Nothing
        Me.blFromPLC_updatepressure.KeypadWidth = 300
        Me.blFromPLC_updatepressure.Location = New System.Drawing.Point(405, 108)
        Me.blFromPLC_updatepressure.Name = "blFromPLC_updatepressure"
        Me.blFromPLC_updatepressure.NumericFormat = Nothing
        Me.blFromPLC_updatepressure.PLCAddressKeypad = ""
        Me.blFromPLC_updatepressure.PLCAddressValue = "B9:0/12"
        Me.blFromPLC_updatepressure.PollRate = 0
        Me.blFromPLC_updatepressure.Size = New System.Drawing.Size(20, 23)
        Me.blFromPLC_updatepressure.TabIndex = 158
        Me.blFromPLC_updatepressure.Text = "0"
        Me.blFromPLC_updatepressure.Value = "0"
        Me.blFromPLC_updatepressure.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.blFromPLC_updatepressure.ValueLeftPadLength = 0
        Me.blFromPLC_updatepressure.ValuePrefix = Nothing
        Me.blFromPLC_updatepressure.ValueScaleFactor = 1.0R
        Me.blFromPLC_updatepressure.ValueSuffix = Nothing
        Me.blFromPLC_updatepressure.ValueToSubtractFrom = 0!
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.lToPLC_MoldRampdowntime)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.lToPLC_MoldControl)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.lFiix_ID1)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.lFiixID)
        Me.Panel2.Controls.Add(Me.blFromPLC_NewBarcodeMemory)
        Me.Panel2.Controls.Add(Me.lToPLC_Pressure)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.lToPLC_ROP)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.lPressure)
        Me.Panel2.Controls.Add(Me.lToPLC_MoldType)
        Me.Panel2.Controls.Add(Me.lToPLC_Moldnumber)
        Me.Panel2.Controls.Add(Me.lToPLC_Speed)
        Me.Panel2.Controls.Add(Me.lMoldType)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(16, 49)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(643, 218)
        Me.Panel2.TabIndex = 195
        '
        'lToPLC_MoldControl
        '
        Me.lToPLC_MoldControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lToPLC_MoldControl.AutoSize = True
        Me.lToPLC_MoldControl.BackColor = System.Drawing.Color.Transparent
        Me.lToPLC_MoldControl.Enabled = False
        Me.lToPLC_MoldControl.ForeColor = System.Drawing.Color.White
        Me.lToPLC_MoldControl.Location = New System.Drawing.Point(100, 166)
        Me.lToPLC_MoldControl.Name = "lToPLC_MoldControl"
        Me.lToPLC_MoldControl.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lToPLC_MoldControl.Size = New System.Drawing.Size(73, 23)
        Me.lToPLC_MoldControl.TabIndex = 192
        Me.lToPLC_MoldControl.Text = "Control"
        Me.lToPLC_MoldControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Enabled = False
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(2, 166)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(78, 31)
        Me.Label10.TabIndex = 193
        Me.Label10.Text = "Control"
        '
        'blFromPLC_NewBarcodeMemory
        '
        Me.blFromPLC_NewBarcodeMemory.BackColor = System.Drawing.Color.Transparent
        Me.blFromPLC_NewBarcodeMemory.BooleanDisplay = AdvancedHMIControls.BasicLabel.BooleanDisplayOption.TrueFalse
        Me.blFromPLC_NewBarcodeMemory.ComComponent = Me.EthernetIPforSLCMicroCom1
        Me.blFromPLC_NewBarcodeMemory.DisplayAsTime = False
        Me.blFromPLC_NewBarcodeMemory.Font = New System.Drawing.Font("Arial", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.blFromPLC_NewBarcodeMemory.ForeColor = System.Drawing.Color.White
        Me.blFromPLC_NewBarcodeMemory.Highlight = False
        Me.blFromPLC_NewBarcodeMemory.HighlightColor = System.Drawing.Color.Red
        Me.blFromPLC_NewBarcodeMemory.HighlightForeColor = System.Drawing.Color.White
        Me.blFromPLC_NewBarcodeMemory.HighlightKeyCharacter = "!"
        Me.blFromPLC_NewBarcodeMemory.InterpretValueAsBCD = False
        Me.blFromPLC_NewBarcodeMemory.KeypadAlphaNumeric = False
        Me.blFromPLC_NewBarcodeMemory.KeypadFont = New System.Drawing.Font("Arial", 10.0!)
        Me.blFromPLC_NewBarcodeMemory.KeypadFontColor = System.Drawing.Color.WhiteSmoke
        Me.blFromPLC_NewBarcodeMemory.KeypadMaxValue = 0R
        Me.blFromPLC_NewBarcodeMemory.KeypadMinValue = 0R
        Me.blFromPLC_NewBarcodeMemory.KeypadScaleFactor = 1.0R
        Me.blFromPLC_NewBarcodeMemory.KeypadShowCurrentValue = False
        Me.blFromPLC_NewBarcodeMemory.KeypadText = Nothing
        Me.blFromPLC_NewBarcodeMemory.KeypadWidth = 300
        Me.blFromPLC_NewBarcodeMemory.Location = New System.Drawing.Point(276, 113)
        Me.blFromPLC_NewBarcodeMemory.Name = "blFromPLC_NewBarcodeMemory"
        Me.blFromPLC_NewBarcodeMemory.NumericFormat = Nothing
        Me.blFromPLC_NewBarcodeMemory.PLCAddressKeypad = ""
        Me.blFromPLC_NewBarcodeMemory.PLCAddressValue = "T10:1/DN"
        Me.blFromPLC_NewBarcodeMemory.PollRate = 0
        Me.blFromPLC_NewBarcodeMemory.Size = New System.Drawing.Size(67, 22)
        Me.blFromPLC_NewBarcodeMemory.TabIndex = 99
        Me.blFromPLC_NewBarcodeMemory.Text = "0"
        Me.blFromPLC_NewBarcodeMemory.Value = "0"
        Me.blFromPLC_NewBarcodeMemory.ValueLeftPadCharacter = Global.Microsoft.VisualBasic.ChrW(32)
        Me.blFromPLC_NewBarcodeMemory.ValueLeftPadLength = 0
        Me.blFromPLC_NewBarcodeMemory.ValuePrefix = Nothing
        Me.blFromPLC_NewBarcodeMemory.ValueScaleFactor = 1.0R
        Me.blFromPLC_NewBarcodeMemory.ValueSuffix = Nothing
        Me.blFromPLC_NewBarcodeMemory.ValueToSubtractFrom = 0!
        '
        'fromPLCQRtrigger
        '
        Me.fromPLCQRtrigger.ComComponent = Me.EthernetIPforSLCMicroCom1
        Me.fromPLCQRtrigger.PLCAddressValue = CType(resources.GetObject("fromPLCQRtrigger.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.fromPLCQRtrigger.Value = Nothing
        '
        'DataSubscriberPCACTIVE
        '
        Me.DataSubscriberPCACTIVE.ComComponent = Me.EthernetIPforSLCMicroCom1
        Me.DataSubscriberPCACTIVE.PLCAddressValue = CType(resources.GetObject("DataSubscriberPCACTIVE.PLCAddressValue"), MfgControl.AdvancedHMI.Drivers.PLCAddressItem)
        Me.DataSubscriberPCACTIVE.Value = Nothing
        '
        'lToPLC_MoldRampdowntime
        '
        Me.lToPLC_MoldRampdowntime.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lToPLC_MoldRampdowntime.AutoSize = True
        Me.lToPLC_MoldRampdowntime.BackColor = System.Drawing.Color.Transparent
        Me.lToPLC_MoldRampdowntime.Enabled = False
        Me.lToPLC_MoldRampdowntime.ForeColor = System.Drawing.Color.White
        Me.lToPLC_MoldRampdowntime.Location = New System.Drawing.Point(98, 188)
        Me.lToPLC_MoldRampdowntime.Name = "lToPLC_MoldRampdowntime"
        Me.lToPLC_MoldRampdowntime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lToPLC_MoldRampdowntime.Size = New System.Drawing.Size(105, 23)
        Me.lToPLC_MoldRampdowntime.TabIndex = 194
        Me.lToPLC_MoldRampdowntime.Text = "rampDown"
        Me.lToPLC_MoldRampdowntime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Enabled = False
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(2, 188)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(101, 31)
        Me.Label12.TabIndex = 195
        Me.Label12.Text = "Rampdowntime"
        '
        'MainForm
        '
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(679, 471)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblExtrudername)
        Me.Controls.Add(Me.lSpeed)
        Me.Controls.Add(Me.lblPCIPaddress)
        Me.Controls.Add(Me.lblQRipaddress)
        Me.Controls.Add(Me.lblipaddress)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lbException)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Arial", 12.0!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "AdvancedHMI v3.99x"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.EthernetIPforSLCMicroCom1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.fromPLCQRtrigger, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSubscriberPCACTIVE, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DF1ComWF1 As AdvancedHMIDrivers.SerialDF1forSLCMicroCom
    Friend WithEvents ForceItemsIntoToolBox1 As MfgControl.AdvancedHMI.Drivers.ForceItemsIntoToolbox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents cmdSEND As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents EthernetIPforSLCMicroCom1 As AdvancedHMIDrivers.EthernetIPforSLCMicroCom
    Friend WithEvents blFromPLC_NewBarcodeMemory As AdvancedHMIControls.BasicLabel
    Friend WithEvents Label8 As Label
    Friend WithEvents lblDataText As Label
    Friend WithEvents lbException As Label
    Friend WithEvents fromPLCQRtrigger As AdvancedHMIControls.DataSubscriber
    Friend WithEvents lFiixID As Label
    Friend WithEvents lToPLC_ROP As Label
    Friend WithEvents lToPLC_MoldType As Label
    Friend WithEvents lFiix_ID1 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lToPLC_Moldnumber As Label
    Friend WithEvents lPressure As Label
    Friend WithEvents lToPLC_Pressure As Label
    Friend WithEvents lSpeed As Label
    Friend WithEvents lToPLC_Speed As Label
    Friend WithEvents lbCameraFail As Label
    Friend WithEvents lbCamconfig As Label
    Friend WithEvents DataSubscriberPCACTIVE As AdvancedHMIControls.DataSubscriber
    ' Friend WithEvents SqlCeDataAdapter1 As SqlServerCe.SqlCeDataAdapter
    Friend WithEvents cmdLON As AdvancedHMIControls.BasicButton
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblipaddress As Label
    Friend WithEvents lblQRipaddress As Label
    Friend WithEvents lblPCIPaddress As Label
    Friend WithEvents lbl As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lMoldType As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblExtrudername As Label
    Friend WithEvents blfromPLC_setROP As AdvancedHMIControls.BasicLabel
    Friend WithEvents Label26 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents blFromPLC_SetSpeed As AdvancedHMIControls.BasicLabel
    Friend WithEvents blFromPLC_SetPressure As AdvancedHMIControls.BasicLabel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents blFromPLC_updateROP As AdvancedHMIControls.BasicLabel
    Friend WithEvents Label7 As Label
    Friend WithEvents blFromPLC_updatespeed As AdvancedHMIControls.BasicLabel
    Friend WithEvents Label18 As Label
    Friend WithEvents blFromPLC_updatepressure As AdvancedHMIControls.BasicLabel
    Friend WithEvents blFromPLC_Setmold As AdvancedHMIControls.BasicLabel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents blupdate As AdvancedHMIControls.BasicLabel
    Friend WithEvents BasicButton1 As AdvancedHMIControls.BasicButton
    Friend WithEvents LBBARCODEECXEPTION As Label
    Friend WithEvents cmdReconnect As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lToPLC_MoldControl As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lToPLC_MoldRampdowntime As Label
    Friend WithEvents Label12 As Label
End Class
