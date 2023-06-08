<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_milling
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btn_xmais = New System.Windows.Forms.Button()
        Me.timer_Refresh = New System.Windows.Forms.Timer(Me.components)
        Me.btn_xmenos = New System.Windows.Forms.Button()
        Me.tx_x = New System.Windows.Forms.TextBox()
        Me.tx_MDI = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_MDI = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tx_y = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tx_z = New System.Windows.Forms.TextBox()
        Me.btn_ymenos = New System.Windows.Forms.Button()
        Me.btn_ymais = New System.Windows.Forms.Button()
        Me.btn_zmenos = New System.Windows.Forms.Button()
        Me.btn_zmais = New System.Windows.Forms.Button()
        Me.btn_Gcode = New System.Windows.Forms.Button()
        Me.tx_Gcode = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ch_ucut = New System.Windows.Forms.CheckBox()
        Me.ch_Extract = New System.Windows.Forms.CheckBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tx_depthcut = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tx_feedratecut = New System.Windows.Forms.TextBox()
        Me.ch_fillet = New System.Windows.Forms.CheckBox()
        Me.label_raiocanto = New System.Windows.Forms.Label()
        Me.tx_bsize = New System.Windows.Forms.TextBox()
        Me.tx_rsize = New System.Windows.Forms.TextBox()
        Me.tx_asize = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.tx_jog = New System.Windows.Forms.TextBox()
        Me.btn_jogmenos = New System.Windows.Forms.Button()
        Me.btn_jogmais = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tx_depth = New System.Windows.Forms.TextBox()
        Me.tx_feedrateholes = New System.Windows.Forms.TextBox()
        Me.tx_edge = New System.Windows.Forms.TextBox()
        Me.ch_holes2 = New System.Windows.Forms.CheckBox()
        Me.ch_holes1 = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btn_start = New System.Windows.Forms.Button()
        Me.btn_feedhold = New System.Windows.Forms.Button()
        Me.btn_stop = New System.Windows.Forms.Button()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.btn_zerox = New System.Windows.Forms.Button()
        Me.btn_zeroy = New System.Windows.Forms.Button()
        Me.btn_zeroz = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btn_home = New System.Windows.Forms.Button()
        Me.btn_config = New System.Windows.Forms.Button()
        Me.btn_Gotozero = New System.Windows.Forms.Button()
        Me.btn_spindle = New System.Windows.Forms.Button()
        Me.trackbar_spindle = New System.Windows.Forms.TrackBar()
        Me.label_value = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.timer_update_position = New System.Windows.Forms.Timer(Me.components)
        Me.btn_LoadGcode = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.timer_interface = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.contador_tempo = New System.Windows.Forms.Timer(Me.components)
        Me.btn_livewebcam = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.trackbar_spindle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_xmais
        '
        Me.btn_xmais.Location = New System.Drawing.Point(63, 36)
        Me.btn_xmais.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_xmais.Name = "btn_xmais"
        Me.btn_xmais.Size = New System.Drawing.Size(60, 28)
        Me.btn_xmais.TabIndex = 0
        Me.btn_xmais.Text = "X+"
        Me.btn_xmais.UseVisualStyleBackColor = True
        '
        'timer_Refresh
        '
        Me.timer_Refresh.Enabled = True
        Me.timer_Refresh.Interval = 1000
        '
        'btn_xmenos
        '
        Me.btn_xmenos.Location = New System.Drawing.Point(60, 129)
        Me.btn_xmenos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_xmenos.Name = "btn_xmenos"
        Me.btn_xmenos.Size = New System.Drawing.Size(60, 28)
        Me.btn_xmenos.TabIndex = 2
        Me.btn_xmenos.Text = "X-"
        Me.btn_xmenos.UseVisualStyleBackColor = True
        '
        'tx_x
        '
        Me.tx_x.Location = New System.Drawing.Point(45, 38)
        Me.tx_x.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tx_x.MaxLength = 2
        Me.tx_x.Name = "tx_x"
        Me.tx_x.Size = New System.Drawing.Size(96, 22)
        Me.tx_x.TabIndex = 3
        Me.tx_x.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tx_MDI
        '
        Me.tx_MDI.Location = New System.Drawing.Point(24, 468)
        Me.tx_MDI.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tx_MDI.Name = "tx_MDI"
        Me.tx_MDI.Size = New System.Drawing.Size(248, 22)
        Me.tx_MDI.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "X"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 441)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "MDI"
        '
        'btn_MDI
        '
        Me.btn_MDI.Location = New System.Drawing.Point(81, 503)
        Me.btn_MDI.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_MDI.Name = "btn_MDI"
        Me.btn_MDI.Size = New System.Drawing.Size(121, 39)
        Me.btn_MDI.TabIndex = 7
        Me.btn_MDI.Text = "Send MDI"
        Me.btn_MDI.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Y"
        '
        'tx_y
        '
        Me.tx_y.Location = New System.Drawing.Point(45, 71)
        Me.tx_y.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tx_y.Name = "tx_y"
        Me.tx_y.Size = New System.Drawing.Size(96, 22)
        Me.tx_y.TabIndex = 8
        Me.tx_y.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Z"
        '
        'tx_z
        '
        Me.tx_z.Location = New System.Drawing.Point(45, 106)
        Me.tx_z.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tx_z.Name = "tx_z"
        Me.tx_z.Size = New System.Drawing.Size(96, 22)
        Me.tx_z.TabIndex = 10
        Me.tx_z.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_ymenos
        '
        Me.btn_ymenos.Location = New System.Drawing.Point(15, 81)
        Me.btn_ymenos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_ymenos.Name = "btn_ymenos"
        Me.btn_ymenos.Size = New System.Drawing.Size(60, 28)
        Me.btn_ymenos.TabIndex = 13
        Me.btn_ymenos.Text = "Y-"
        Me.btn_ymenos.UseVisualStyleBackColor = True
        '
        'btn_ymais
        '
        Me.btn_ymais.Location = New System.Drawing.Point(108, 82)
        Me.btn_ymais.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_ymais.Name = "btn_ymais"
        Me.btn_ymais.Size = New System.Drawing.Size(60, 28)
        Me.btn_ymais.TabIndex = 12
        Me.btn_ymais.Text = "Y+"
        Me.btn_ymais.UseVisualStyleBackColor = True
        '
        'btn_zmenos
        '
        Me.btn_zmenos.Location = New System.Drawing.Point(172, 129)
        Me.btn_zmenos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_zmenos.Name = "btn_zmenos"
        Me.btn_zmenos.Size = New System.Drawing.Size(60, 28)
        Me.btn_zmenos.TabIndex = 15
        Me.btn_zmenos.Text = "Z-"
        Me.btn_zmenos.UseVisualStyleBackColor = True
        '
        'btn_zmais
        '
        Me.btn_zmais.Location = New System.Drawing.Point(172, 36)
        Me.btn_zmais.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_zmais.Name = "btn_zmais"
        Me.btn_zmais.Size = New System.Drawing.Size(60, 28)
        Me.btn_zmais.TabIndex = 14
        Me.btn_zmais.Text = "Z+"
        Me.btn_zmais.UseVisualStyleBackColor = True
        '
        'btn_Gcode
        '
        Me.btn_Gcode.Location = New System.Drawing.Point(1055, 602)
        Me.btn_Gcode.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Gcode.Name = "btn_Gcode"
        Me.btn_Gcode.Size = New System.Drawing.Size(127, 47)
        Me.btn_Gcode.TabIndex = 16
        Me.btn_Gcode.Text = "Generate G-code"
        Me.btn_Gcode.UseVisualStyleBackColor = True
        '
        'tx_Gcode
        '
        Me.tx_Gcode.Location = New System.Drawing.Point(1055, 56)
        Me.tx_Gcode.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tx_Gcode.Multiline = True
        Me.tx_Gcode.Name = "tx_Gcode"
        Me.tx_Gcode.Size = New System.Drawing.Size(275, 532)
        Me.tx_Gcode.TabIndex = 17
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ch_ucut)
        Me.GroupBox1.Controls.Add(Me.ch_Extract)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.tx_depthcut)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.tx_feedratecut)
        Me.GroupBox1.Controls.Add(Me.ch_fillet)
        Me.GroupBox1.Controls.Add(Me.label_raiocanto)
        Me.GroupBox1.Controls.Add(Me.tx_bsize)
        Me.GroupBox1.Controls.Add(Me.tx_rsize)
        Me.GroupBox1.Controls.Add(Me.tx_asize)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(305, 17)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(340, 342)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cut"
        '
        'ch_ucut
        '
        Me.ch_ucut.AutoSize = True
        Me.ch_ucut.Checked = Global.WindowsApp1teste.My.MySettings.Default.CheckUCUT
        Me.ch_ucut.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.WindowsApp1teste.My.MySettings.Default, "CheckUCUT", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ch_ucut.Location = New System.Drawing.Point(57, 63)
        Me.ch_ucut.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ch_ucut.Name = "ch_ucut"
        Me.ch_ucut.Size = New System.Drawing.Size(59, 20)
        Me.ch_ucut.TabIndex = 41
        Me.ch_ucut.Text = "U cut"
        Me.ch_ucut.UseVisualStyleBackColor = True
        '
        'ch_Extract
        '
        Me.ch_Extract.AutoSize = True
        Me.ch_Extract.Checked = Global.WindowsApp1teste.My.MySettings.Default.CheckExtract
        Me.ch_Extract.Location = New System.Drawing.Point(57, 31)
        Me.ch_Extract.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ch_Extract.Name = "ch_Extract"
        Me.ch_Extract.Size = New System.Drawing.Size(93, 20)
        Me.ch_Extract.TabIndex = 40
        Me.ch_Extract.Text = "Square cut"
        Me.ch_Extract.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(247, 250)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(37, 16)
        Me.Label18.TabIndex = 39
        Me.Label18.Text = "[mm]"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(247, 289)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(67, 16)
        Me.Label16.TabIndex = 35
        Me.Label16.Text = "[units/min]"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(19, 249)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(65, 16)
        Me.Label20.TabIndex = 38
        Me.Label20.Text = "Depth Cut"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(247, 213)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 16)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "[mm]"
        '
        'tx_depthcut
        '
        Me.tx_depthcut.Location = New System.Drawing.Point(127, 247)
        Me.tx_depthcut.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tx_depthcut.Name = "tx_depthcut"
        Me.tx_depthcut.Size = New System.Drawing.Size(108, 22)
        Me.tx_depthcut.TabIndex = 37
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(241, 133)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 16)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "[mm]"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(241, 98)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 16)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "[mm]"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 289)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 16)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Feedrate"
        '
        'tx_feedratecut
        '
        Me.tx_feedratecut.Location = New System.Drawing.Point(127, 287)
        Me.tx_feedratecut.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tx_feedratecut.Name = "tx_feedratecut"
        Me.tx_feedratecut.Size = New System.Drawing.Size(108, 22)
        Me.tx_feedratecut.TabIndex = 26
        '
        'ch_fillet
        '
        Me.ch_fillet.AutoSize = True
        Me.ch_fillet.Checked = Global.WindowsApp1teste.My.MySettings.Default.CheckFillet
        Me.ch_fillet.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.WindowsApp1teste.My.MySettings.Default, "CheckFillet", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ch_fillet.Location = New System.Drawing.Point(51, 172)
        Me.ch_fillet.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ch_fillet.Name = "ch_fillet"
        Me.ch_fillet.Size = New System.Drawing.Size(57, 20)
        Me.ch_fillet.TabIndex = 25
        Me.ch_fillet.Text = "Fillet"
        Me.ch_fillet.UseVisualStyleBackColor = True
        '
        'label_raiocanto
        '
        Me.label_raiocanto.AutoSize = True
        Me.label_raiocanto.Location = New System.Drawing.Point(19, 213)
        Me.label_raiocanto.Name = "label_raiocanto"
        Me.label_raiocanto.Size = New System.Drawing.Size(87, 16)
        Me.label_raiocanto.TabIndex = 24
        Me.label_raiocanto.Text = "Corner radius"
        Me.label_raiocanto.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tx_bsize
        '
        Me.tx_bsize.Location = New System.Drawing.Point(120, 129)
        Me.tx_bsize.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tx_bsize.Name = "tx_bsize"
        Me.tx_bsize.Size = New System.Drawing.Size(108, 22)
        Me.tx_bsize.TabIndex = 21
        '
        'tx_rsize
        '
        Me.tx_rsize.Location = New System.Drawing.Point(127, 215)
        Me.tx_rsize.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tx_rsize.Name = "tx_rsize"
        Me.tx_rsize.Size = New System.Drawing.Size(108, 22)
        Me.tx_rsize.TabIndex = 23
        '
        'tx_asize
        '
        Me.tx_asize.Location = New System.Drawing.Point(120, 96)
        Me.tx_asize.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tx_asize.Name = "tx_asize"
        Me.tx_asize.Size = New System.Drawing.Size(108, 22)
        Me.tx_asize.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 132)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 16)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Width (X)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(39, 98)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 16)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Length (Y)"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.tx_jog)
        Me.GroupBox2.Controls.Add(Me.btn_jogmenos)
        Me.GroupBox2.Controls.Add(Me.btn_jogmais)
        Me.GroupBox2.Controls.Add(Me.btn_ymenos)
        Me.GroupBox2.Controls.Add(Me.btn_xmais)
        Me.GroupBox2.Controls.Add(Me.btn_xmenos)
        Me.GroupBox2.Controls.Add(Me.btn_ymais)
        Me.GroupBox2.Controls.Add(Me.btn_zmenos)
        Me.GroupBox2.Controls.Add(Me.btn_zmais)
        Me.GroupBox2.Location = New System.Drawing.Point(24, 193)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(247, 215)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Manual"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(145, 188)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(19, 16)
        Me.Label21.TabIndex = 41
        Me.Label21.Text = "%"
        '
        'tx_jog
        '
        Me.tx_jog.Location = New System.Drawing.Point(84, 186)
        Me.tx_jog.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tx_jog.Name = "tx_jog"
        Me.tx_jog.Size = New System.Drawing.Size(56, 22)
        Me.tx_jog.TabIndex = 41
        Me.tx_jog.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btn_jogmenos
        '
        Me.btn_jogmenos.Location = New System.Drawing.Point(181, 183)
        Me.btn_jogmenos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_jogmenos.Name = "btn_jogmenos"
        Me.btn_jogmenos.Size = New System.Drawing.Size(60, 28)
        Me.btn_jogmenos.TabIndex = 17
        Me.btn_jogmenos.Text = "-"
        Me.btn_jogmenos.UseVisualStyleBackColor = True
        '
        'btn_jogmais
        '
        Me.btn_jogmais.Location = New System.Drawing.Point(5, 183)
        Me.btn_jogmais.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_jogmais.Name = "btn_jogmais"
        Me.btn_jogmais.Size = New System.Drawing.Size(60, 28)
        Me.btn_jogmais.TabIndex = 16
        Me.btn_jogmais.Text = "+"
        Me.btn_jogmais.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.tx_depth)
        Me.GroupBox3.Controls.Add(Me.tx_feedrateholes)
        Me.GroupBox3.Controls.Add(Me.tx_edge)
        Me.GroupBox3.Controls.Add(Me.ch_holes2)
        Me.GroupBox3.Controls.Add(Me.ch_holes1)
        Me.GroupBox3.Controls.Add(Me.Panel1)
        Me.GroupBox3.Controls.Add(Me.Panel3)
        Me.GroupBox3.Location = New System.Drawing.Point(305, 372)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(340, 281)
        Me.GroupBox3.TabIndex = 21
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Hole"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(247, 223)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(67, 16)
        Me.Label17.TabIndex = 36
        Me.Label17.Text = "[units/min]"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(251, 154)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(37, 16)
        Me.Label15.TabIndex = 34
        Me.Label15.Text = "[mm]"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(251, 65)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(37, 16)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "[mm]"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(171, 127)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 16)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Depth"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(167, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 16)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Dist. from edge"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(39, 223)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 16)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Feedrate"
        '
        'tx_depth
        '
        Me.tx_depth.Location = New System.Drawing.Point(171, 151)
        Me.tx_depth.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tx_depth.Name = "tx_depth"
        Me.tx_depth.Size = New System.Drawing.Size(69, 22)
        Me.tx_depth.TabIndex = 32
        '
        'tx_feedrateholes
        '
        Me.tx_feedrateholes.Location = New System.Drawing.Point(125, 220)
        Me.tx_feedrateholes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tx_feedrateholes.Name = "tx_feedrateholes"
        Me.tx_feedrateholes.Size = New System.Drawing.Size(108, 22)
        Me.tx_feedrateholes.TabIndex = 28
        '
        'tx_edge
        '
        Me.tx_edge.Location = New System.Drawing.Point(169, 63)
        Me.tx_edge.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tx_edge.Name = "tx_edge"
        Me.tx_edge.Size = New System.Drawing.Size(72, 22)
        Me.tx_edge.TabIndex = 30
        '
        'ch_holes2
        '
        Me.ch_holes2.AutoSize = True
        Me.ch_holes2.Checked = Global.WindowsApp1teste.My.MySettings.Default.CheckHoles2
        Me.ch_holes2.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.WindowsApp1teste.My.MySettings.Default, "CheckHoles2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ch_holes2.Location = New System.Drawing.Point(19, 153)
        Me.ch_holes2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ch_holes2.Name = "ch_holes2"
        Me.ch_holes2.Size = New System.Drawing.Size(18, 17)
        Me.ch_holes2.TabIndex = 14
        Me.ch_holes2.UseVisualStyleBackColor = True
        '
        'ch_holes1
        '
        Me.ch_holes1.AutoSize = True
        Me.ch_holes1.Checked = Global.WindowsApp1teste.My.MySettings.Default.CheckHoles1
        Me.ch_holes1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.WindowsApp1teste.My.MySettings.Default, "CheckHoles1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.ch_holes1.Location = New System.Drawing.Point(19, 60)
        Me.ch_holes1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ch_holes1.Name = "ch_holes1"
        Me.ch_holes1.Size = New System.Drawing.Size(18, 17)
        Me.ch_holes1.TabIndex = 13
        Me.ch_holes1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Location = New System.Drawing.Point(60, 42)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(60, 52)
        Me.Panel1.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel6.Location = New System.Drawing.Point(49, 42)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(9, 7)
        Me.Panel6.TabIndex = 4
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel5.Location = New System.Drawing.Point(3, 42)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(9, 7)
        Me.Panel5.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel2.Location = New System.Drawing.Point(49, 2)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(9, 7)
        Me.Panel2.TabIndex = 4
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel4.Location = New System.Drawing.Point(3, 2)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(9, 7)
        Me.Panel4.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel3.Controls.Add(Me.Panel10)
        Me.Panel3.Controls.Add(Me.Panel9)
        Me.Panel3.Controls.Add(Me.Panel8)
        Me.Panel3.Controls.Add(Me.Panel7)
        Me.Panel3.Location = New System.Drawing.Point(63, 134)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(60, 52)
        Me.Panel3.TabIndex = 1
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel10.Location = New System.Drawing.Point(27, 42)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(9, 7)
        Me.Panel10.TabIndex = 4
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel9.Location = New System.Drawing.Point(49, 22)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(9, 7)
        Me.Panel9.TabIndex = 4
        '
        'Panel8
        '
        Me.Panel8.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel8.Location = New System.Drawing.Point(3, 22)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(9, 7)
        Me.Panel8.TabIndex = 4
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel7.Location = New System.Drawing.Point(25, 2)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(9, 7)
        Me.Panel7.TabIndex = 4
        '
        'btn_start
        '
        Me.btn_start.BackColor = System.Drawing.Color.White
        Me.btn_start.Location = New System.Drawing.Point(673, 502)
        Me.btn_start.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(179, 46)
        Me.btn_start.TabIndex = 16
        Me.btn_start.Text = "Start"
        Me.btn_start.UseVisualStyleBackColor = False
        '
        'btn_feedhold
        '
        Me.btn_feedhold.BackColor = System.Drawing.Color.White
        Me.btn_feedhold.Location = New System.Drawing.Point(673, 553)
        Me.btn_feedhold.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_feedhold.Name = "btn_feedhold"
        Me.btn_feedhold.Size = New System.Drawing.Size(179, 46)
        Me.btn_feedhold.TabIndex = 22
        Me.btn_feedhold.Text = "Feed Hold"
        Me.btn_feedhold.UseVisualStyleBackColor = False
        '
        'btn_stop
        '
        Me.btn_stop.BackColor = System.Drawing.Color.White
        Me.btn_stop.Location = New System.Drawing.Point(673, 603)
        Me.btn_stop.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_stop.Name = "btn_stop"
        Me.btn_stop.Size = New System.Drawing.Size(179, 46)
        Me.btn_stop.TabIndex = 23
        Me.btn_stop.Text = "Stop"
        Me.btn_stop.UseVisualStyleBackColor = False
        '
        'btn_reset
        '
        Me.btn_reset.BackColor = System.Drawing.Color.IndianRed
        Me.btn_reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_reset.Location = New System.Drawing.Point(24, 571)
        Me.btn_reset.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(247, 79)
        Me.btn_reset.TabIndex = 24
        Me.btn_reset.Text = "RESET"
        Me.btn_reset.UseVisualStyleBackColor = False
        '
        'btn_zerox
        '
        Me.btn_zerox.Location = New System.Drawing.Point(196, 30)
        Me.btn_zerox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_zerox.Name = "btn_zerox"
        Me.btn_zerox.Size = New System.Drawing.Size(75, 39)
        Me.btn_zerox.TabIndex = 16
        Me.btn_zerox.Text = "Zero X"
        Me.btn_zerox.UseVisualStyleBackColor = True
        '
        'btn_zeroy
        '
        Me.btn_zeroy.Location = New System.Drawing.Point(196, 79)
        Me.btn_zeroy.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_zeroy.Name = "btn_zeroy"
        Me.btn_zeroy.Size = New System.Drawing.Size(75, 39)
        Me.btn_zeroy.TabIndex = 17
        Me.btn_zeroy.Text = "Zero Y"
        Me.btn_zeroy.UseVisualStyleBackColor = True
        '
        'btn_zeroz
        '
        Me.btn_zeroz.Location = New System.Drawing.Point(196, 127)
        Me.btn_zeroz.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_zeroz.Name = "btn_zeroz"
        Me.btn_zeroz.Size = New System.Drawing.Size(75, 39)
        Me.btn_zeroz.TabIndex = 18
        Me.btn_zeroz.Text = "Zero Z"
        Me.btn_zeroz.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.tx_z)
        Me.GroupBox4.Controls.Add(Me.tx_x)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.tx_y)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Location = New System.Drawing.Point(24, 17)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(156, 158)
        Me.GroupBox4.TabIndex = 25
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Real Position"
        '
        'btn_home
        '
        Me.btn_home.Location = New System.Drawing.Point(673, 436)
        Me.btn_home.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(147, 49)
        Me.btn_home.TabIndex = 16
        Me.btn_home.Text = "Tool Change Position"
        Me.btn_home.UseVisualStyleBackColor = True
        '
        'btn_config
        '
        Me.btn_config.Location = New System.Drawing.Point(911, 602)
        Me.btn_config.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_config.Name = "btn_config"
        Me.btn_config.Size = New System.Drawing.Size(119, 47)
        Me.btn_config.TabIndex = 26
        Me.btn_config.Text = "Save Parameters"
        Me.btn_config.UseVisualStyleBackColor = True
        '
        'btn_Gotozero
        '
        Me.btn_Gotozero.Location = New System.Drawing.Point(881, 436)
        Me.btn_Gotozero.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Gotozero.Name = "btn_Gotozero"
        Me.btn_Gotozero.Size = New System.Drawing.Size(147, 49)
        Me.btn_Gotozero.TabIndex = 27
        Me.btn_Gotozero.Text = "Go To Zero"
        Me.btn_Gotozero.UseVisualStyleBackColor = True
        '
        'btn_spindle
        '
        Me.btn_spindle.Location = New System.Drawing.Point(911, 518)
        Me.btn_spindle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_spindle.Name = "btn_spindle"
        Me.btn_spindle.Size = New System.Drawing.Size(119, 47)
        Me.btn_spindle.TabIndex = 28
        Me.btn_spindle.Text = "Turn Spindle On"
        Me.btn_spindle.UseVisualStyleBackColor = True
        '
        'trackbar_spindle
        '
        Me.trackbar_spindle.Location = New System.Drawing.Point(673, 354)
        Me.trackbar_spindle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.trackbar_spindle.Maximum = 15000
        Me.trackbar_spindle.Name = "trackbar_spindle"
        Me.trackbar_spindle.Size = New System.Drawing.Size(356, 56)
        Me.trackbar_spindle.TabIndex = 29
        '
        'label_value
        '
        Me.label_value.AutoSize = True
        Me.label_value.Location = New System.Drawing.Point(793, 394)
        Me.label_value.Name = "label_value"
        Me.label_value.Size = New System.Drawing.Size(55, 16)
        Me.label_value.TabIndex = 30
        Me.label_value.Text = "Label18"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(851, 394)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(45, 16)
        Me.Label19.TabIndex = 31
        Me.Label19.Text = "[RPM]"
        '
        'timer_update_position
        '
        Me.timer_update_position.Interval = 500
        '
        'btn_LoadGcode
        '
        Me.btn_LoadGcode.Location = New System.Drawing.Point(1208, 602)
        Me.btn_LoadGcode.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_LoadGcode.Name = "btn_LoadGcode"
        Me.btn_LoadGcode.Size = New System.Drawing.Size(120, 47)
        Me.btn_LoadGcode.TabIndex = 32
        Me.btn_LoadGcode.Text = "Load Gcode"
        Me.btn_LoadGcode.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'timer_interface
        '
        Me.timer_interface.Enabled = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(673, 17)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(356, 320)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'contador_tempo
        '
        Me.contador_tempo.Enabled = True
        Me.contador_tempo.Interval = 1000
        '
        'btn_livewebcam
        '
        Me.btn_livewebcam.Location = New System.Drawing.Point(1055, 17)
        Me.btn_livewebcam.Name = "btn_livewebcam"
        Me.btn_livewebcam.Size = New System.Drawing.Size(275, 34)
        Me.btn_livewebcam.TabIndex = 37
        Me.btn_livewebcam.Text = "Live Webcam"
        Me.btn_livewebcam.UseVisualStyleBackColor = True
        '
        'Form_milling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1356, 667)
        Me.Controls.Add(Me.btn_livewebcam)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_LoadGcode)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.label_value)
        Me.Controls.Add(Me.trackbar_spindle)
        Me.Controls.Add(Me.btn_spindle)
        Me.Controls.Add(Me.btn_MDI)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.tx_MDI)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_Gotozero)
        Me.Controls.Add(Me.btn_config)
        Me.Controls.Add(Me.btn_home)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btn_zerox)
        Me.Controls.Add(Me.btn_reset)
        Me.Controls.Add(Me.btn_zeroy)
        Me.Controls.Add(Me.btn_zeroz)
        Me.Controls.Add(Me.btn_stop)
        Me.Controls.Add(Me.btn_Gcode)
        Me.Controls.Add(Me.btn_feedhold)
        Me.Controls.Add(Me.btn_start)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tx_Gcode)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Form_milling"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CNC Policarbonato"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.trackbar_spindle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_xmais As Button
    Friend WithEvents btn_xmenos As Button
    Friend WithEvents tx_x As TextBox
    Friend WithEvents tx_MDI As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_MDI As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents tx_y As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tx_z As TextBox
    Friend WithEvents btn_ymenos As Button
    Friend WithEvents btn_ymais As Button
    Friend WithEvents btn_zmenos As Button
    Friend WithEvents btn_zmais As Button
    Friend WithEvents btn_Gcode As Button
    Friend WithEvents tx_Gcode As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents label_raiocanto As Label
    Friend WithEvents tx_bsize As TextBox
    Friend WithEvents tx_rsize As TextBox
    Friend WithEvents tx_asize As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ch_fillet As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ch_holes2 As CheckBox
    Friend WithEvents ch_holes1 As CheckBox
    Friend WithEvents btn_start As Button
    Friend WithEvents btn_feedhold As Button
    Friend WithEvents btn_stop As Button
    Friend WithEvents btn_reset As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents tx_feedratecut As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tx_feedrateholes As TextBox
    Friend WithEvents btn_zerox As Button
    Friend WithEvents btn_zeroy As Button
    Friend WithEvents btn_zeroz As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents tx_depth As TextBox
    Friend WithEvents tx_edge As TextBox
    Friend WithEvents btn_home As Button
    Friend WithEvents btn_config As Button
    Friend WithEvents btn_Gotozero As Button
    Friend WithEvents Label16 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents btn_spindle As Button
    Friend WithEvents trackbar_spindle As TrackBar
    Friend WithEvents label_value As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents timer_update_position As Timer
    Friend WithEvents Label18 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents tx_depthcut As TextBox
    Friend WithEvents btn_LoadGcode As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents ch_Extract As CheckBox
    Friend WithEvents timer_interface As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btn_jogmenos As Button
    Friend WithEvents btn_jogmais As Button
    Friend WithEvents tx_jog As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents ch_ucut As CheckBox
    Friend WithEvents timer_Refresh As Timer
    Friend WithEvents contador_tempo As Timer
    Friend WithEvents btn_livewebcam As Button
End Class
