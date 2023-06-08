<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_laser_manual
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
        Me.btn_MDI = New System.Windows.Forms.Button()
        Me.tx_MDI = New System.Windows.Forms.TextBox()
        Me.btn_Gotozero = New System.Windows.Forms.Button()
        Me.btn_home = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.tx_z = New System.Windows.Forms.TextBox()
        Me.tx_x = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tx_y = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_zerox = New System.Windows.Forms.Button()
        Me.btn_zeroy = New System.Windows.Forms.Button()
        Me.btn_zeroz = New System.Windows.Forms.Button()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.tx_jog = New System.Windows.Forms.TextBox()
        Me.btn_jogmenos = New System.Windows.Forms.Button()
        Me.btn_jogmais = New System.Windows.Forms.Button()
        Me.btn_ymenos = New System.Windows.Forms.Button()
        Me.btn_xmais = New System.Windows.Forms.Button()
        Me.btn_xmenos = New System.Windows.Forms.Button()
        Me.btn_ymais = New System.Windows.Forms.Button()
        Me.btn_zmenos = New System.Windows.Forms.Button()
        Me.btn_zmais = New System.Windows.Forms.Button()
        Me.timer_Refresh = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.timer_update_position = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutomaticGcodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LiveWebcamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.trackbar_spindle = New System.Windows.Forms.TrackBar()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.combobox_steps = New System.Windows.Forms.ComboBox()
        Me.btnMenos = New System.Windows.Forms.Button()
        Me.btnMais = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_Infoco = New System.Windows.Forms.TextBox()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.trackbar_spindle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_MDI
        '
        Me.btn_MDI.Location = New System.Drawing.Point(48, 80)
        Me.btn_MDI.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_MDI.Name = "btn_MDI"
        Me.btn_MDI.Size = New System.Drawing.Size(121, 39)
        Me.btn_MDI.TabIndex = 39
        Me.btn_MDI.Text = "Send MDI"
        Me.btn_MDI.UseVisualStyleBackColor = True
        '
        'tx_MDI
        '
        Me.tx_MDI.Location = New System.Drawing.Point(19, 47)
        Me.tx_MDI.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tx_MDI.Name = "tx_MDI"
        Me.tx_MDI.Size = New System.Drawing.Size(209, 22)
        Me.tx_MDI.TabIndex = 37
        '
        'btn_Gotozero
        '
        Me.btn_Gotozero.Location = New System.Drawing.Point(1050, 441)
        Me.btn_Gotozero.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_Gotozero.Name = "btn_Gotozero"
        Me.btn_Gotozero.Size = New System.Drawing.Size(147, 49)
        Me.btn_Gotozero.TabIndex = 55
        Me.btn_Gotozero.Text = "Go To Zero"
        Me.btn_Gotozero.UseVisualStyleBackColor = True
        '
        'btn_home
        '
        Me.btn_home.Location = New System.Drawing.Point(842, 441)
        Me.btn_home.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(147, 49)
        Me.btn_home.TabIndex = 40
        Me.btn_home.Text = "Tool Change Position"
        Me.btn_home.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.tx_z)
        Me.GroupBox4.Controls.Add(Me.tx_x)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.tx_y)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.btn_zerox)
        Me.GroupBox4.Controls.Add(Me.btn_zeroy)
        Me.GroupBox4.Controls.Add(Me.btn_zeroz)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(821, 68)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(423, 193)
        Me.GroupBox4.TabIndex = 53
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Real Position"
        '
        'tx_z
        '
        Me.tx_z.Location = New System.Drawing.Point(46, 134)
        Me.tx_z.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tx_z.Name = "tx_z"
        Me.tx_z.Size = New System.Drawing.Size(167, 22)
        Me.tx_z.TabIndex = 10
        Me.tx_z.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tx_x
        '
        Me.tx_x.Location = New System.Drawing.Point(45, 37)
        Me.tx_x.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tx_x.MaxLength = 2
        Me.tx_x.Name = "tx_x"
        Me.tx_x.Size = New System.Drawing.Size(167, 22)
        Me.tx_x.TabIndex = 3
        Me.tx_x.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "X"
        '
        'tx_y
        '
        Me.tx_y.Location = New System.Drawing.Point(45, 86)
        Me.tx_y.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tx_y.Name = "tx_y"
        Me.tx_y.Size = New System.Drawing.Size(167, 22)
        Me.tx_y.TabIndex = 8
        Me.tx_y.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Y"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Z"
        '
        'btn_zerox
        '
        Me.btn_zerox.Location = New System.Drawing.Point(234, 37)
        Me.btn_zerox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_zerox.Name = "btn_zerox"
        Me.btn_zerox.Size = New System.Drawing.Size(137, 34)
        Me.btn_zerox.TabIndex = 43
        Me.btn_zerox.Text = "Zero X"
        Me.btn_zerox.UseVisualStyleBackColor = True
        '
        'btn_zeroy
        '
        Me.btn_zeroy.Location = New System.Drawing.Point(234, 86)
        Me.btn_zeroy.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_zeroy.Name = "btn_zeroy"
        Me.btn_zeroy.Size = New System.Drawing.Size(137, 34)
        Me.btn_zeroy.TabIndex = 44
        Me.btn_zeroy.Text = "Zero Y"
        Me.btn_zeroy.UseVisualStyleBackColor = True
        '
        'btn_zeroz
        '
        Me.btn_zeroz.Location = New System.Drawing.Point(234, 134)
        Me.btn_zeroz.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_zeroz.Name = "btn_zeroz"
        Me.btn_zeroz.Size = New System.Drawing.Size(137, 34)
        Me.btn_zeroz.TabIndex = 47
        Me.btn_zeroz.Text = "Zero Z"
        Me.btn_zeroz.UseVisualStyleBackColor = True
        '
        'btn_reset
        '
        Me.btn_reset.BackColor = System.Drawing.Color.IndianRed
        Me.btn_reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_reset.Location = New System.Drawing.Point(24, 508)
        Me.btn_reset.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(247, 84)
        Me.btn_reset.TabIndex = 52
        Me.btn_reset.Text = "RESET"
        Me.btn_reset.UseVisualStyleBackColor = False
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
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(24, 68)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(247, 223)
        Me.GroupBox2.TabIndex = 48
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
        'timer_Refresh
        '
        Me.timer_Refresh.Enabled = True
        Me.timer_Refresh.Interval = 500
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'timer_update_position
        '
        Me.timer_update_position.Interval = 700
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModeToolStripMenuItem, Me.LiveWebcamToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1279, 28)
        Me.MenuStrip1.TabIndex = 62
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ModeToolStripMenuItem
        '
        Me.ModeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManualToolStripMenuItem, Me.AutomaticGcodeToolStripMenuItem})
        Me.ModeToolStripMenuItem.Name = "ModeToolStripMenuItem"
        Me.ModeToolStripMenuItem.Size = New System.Drawing.Size(62, 24)
        Me.ModeToolStripMenuItem.Text = "Mode"
        '
        'ManualToolStripMenuItem
        '
        Me.ManualToolStripMenuItem.Name = "ManualToolStripMenuItem"
        Me.ManualToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ManualToolStripMenuItem.Text = "Manual"
        '
        'AutomaticGcodeToolStripMenuItem
        '
        Me.AutomaticGcodeToolStripMenuItem.Name = "AutomaticGcodeToolStripMenuItem"
        Me.AutomaticGcodeToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.AutomaticGcodeToolStripMenuItem.Text = "Automatic (G-code)"
        '
        'LiveWebcamToolStripMenuItem
        '
        Me.LiveWebcamToolStripMenuItem.Name = "LiveWebcamToolStripMenuItem"
        Me.LiveWebcamToolStripMenuItem.Size = New System.Drawing.Size(111, 24)
        Me.LiveWebcamToolStripMenuItem.Text = "Live Webcam"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(851, 328)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(69, 16)
        Me.Label19.TabIndex = 59
        Me.Label19.Text = "Power [W]"
        '
        'trackbar_spindle
        '
        Me.trackbar_spindle.Location = New System.Drawing.Point(842, 359)
        Me.trackbar_spindle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.trackbar_spindle.Maximum = 15000
        Me.trackbar_spindle.Name = "trackbar_spindle"
        Me.trackbar_spindle.Size = New System.Drawing.Size(356, 56)
        Me.trackbar_spindle.TabIndex = 57
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.tx_MDI)
        Me.GroupBox3.Controls.Add(Me.btn_MDI)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(24, 328)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(247, 138)
        Me.GroupBox3.TabIndex = 64
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Manual Data Input (MDI)"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label6)
        Me.GroupBox5.Controls.Add(Me.Label5)
        Me.GroupBox5.Controls.Add(Me.combobox_steps)
        Me.GroupBox5.Controls.Add(Me.btnMenos)
        Me.GroupBox5.Controls.Add(Me.btnMais)
        Me.GroupBox5.Controls.Add(Me.Label2)
        Me.GroupBox5.Controls.Add(Me.txt_Infoco)
        Me.GroupBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(336, 68)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(333, 264)
        Me.GroupBox5.TabIndex = 64
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Laser Focus Parameters"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 162)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 16)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Scale:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(110, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 16)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Máx: 22 mm"
        '
        'combobox_steps
        '
        Me.combobox_steps.FormattingEnabled = True
        Me.combobox_steps.Items.AddRange(New Object() {"1.000", "0.100", "0.010", "0.001"})
        Me.combobox_steps.Location = New System.Drawing.Point(91, 159)
        Me.combobox_steps.Name = "combobox_steps"
        Me.combobox_steps.Size = New System.Drawing.Size(121, 24)
        Me.combobox_steps.TabIndex = 4
        '
        'btnMenos
        '
        Me.btnMenos.Location = New System.Drawing.Point(155, 113)
        Me.btnMenos.Name = "btnMenos"
        Me.btnMenos.Size = New System.Drawing.Size(44, 40)
        Me.btnMenos.TabIndex = 3
        Me.btnMenos.Text = "-"
        Me.btnMenos.UseVisualStyleBackColor = True
        '
        'btnMais
        '
        Me.btnMais.Location = New System.Drawing.Point(99, 113)
        Me.btnMais.Name = "btnMais"
        Me.btnMais.Size = New System.Drawing.Size(44, 40)
        Me.btnMais.TabIndex = 2
        Me.btnMais.Text = "+"
        Me.btnMais.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(99, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Focus Distance"
        '
        'txt_Infoco
        '
        Me.txt_Infoco.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_Infoco.Location = New System.Drawing.Point(99, 50)
        Me.txt_Infoco.Multiline = True
        Me.txt_Infoco.Name = "txt_Infoco"
        Me.txt_Infoco.Size = New System.Drawing.Size(100, 27)
        Me.txt_Infoco.TabIndex = 0
        Me.txt_Infoco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form_laser_manual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1279, 621)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.trackbar_spindle)
        Me.Controls.Add(Me.btn_Gotozero)
        Me.Controls.Add(Me.btn_home)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btn_reset)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form_laser_manual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laser Machine Control"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.trackbar_spindle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_MDI As Button
    Friend WithEvents tx_MDI As TextBox
    Friend WithEvents btn_Gotozero As Button
    Friend WithEvents btn_home As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents tx_z As TextBox
    Friend WithEvents tx_x As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tx_y As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_zerox As Button
    Friend WithEvents btn_reset As Button
    Friend WithEvents btn_zeroy As Button
    Friend WithEvents btn_zeroz As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label21 As Label
    Friend WithEvents tx_jog As TextBox
    Friend WithEvents btn_jogmenos As Button
    Friend WithEvents btn_jogmais As Button
    Friend WithEvents btn_ymenos As Button
    Friend WithEvents btn_xmais As Button
    Friend WithEvents btn_xmenos As Button
    Friend WithEvents btn_ymais As Button
    Friend WithEvents btn_zmenos As Button
    Friend WithEvents btn_zmais As Button
    Friend WithEvents timer_Refresh As Timer
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents timer_update_position As Timer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ModeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AutomaticGcodeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label19 As Label
    Friend WithEvents trackbar_spindle As TrackBar
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents LiveWebcamToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents combobox_steps As ComboBox
    Friend WithEvents btnMenos As Button
    Friend WithEvents btnMais As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_Infoco As TextBox
End Class
