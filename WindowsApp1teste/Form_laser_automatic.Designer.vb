<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form_laser_automatic
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
        Me.btn_LoadGcode = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_edge = New System.Windows.Forms.TextBox()
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
        Me.Panel_dxf_drawing = New System.Windows.Forms.Panel()
        Me.btn_home = New System.Windows.Forms.Button()
        Me.btn_reset = New System.Windows.Forms.Button()
        Me.btn_stop = New System.Windows.Forms.Button()
        Me.btn_clear_gcode = New System.Windows.Forms.Button()
        Me.btn_feedhold = New System.Windows.Forms.Button()
        Me.btn_start = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.txt_laser_power = New System.Windows.Forms.TextBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.txt_parameters_cutting_feedrate = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.txt_parameters_z_feedrate = New System.Windows.Forms.TextBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.txt_parameters_z_cutting = New System.Windows.Forms.TextBox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.txt_parameters_safe_distance = New System.Windows.Forms.TextBox()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.btn_generate_gcode = New System.Windows.Forms.Button()
        Me.btn_save_dxf = New System.Windows.Forms.Button()
        Me.btn_dxf_update = New System.Windows.Forms.Button()
        Me.tabcontrol_shape_template = New System.Windows.Forms.TabControl()
        Me.tabpage_retangular = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_hole_diameter = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_corner_radius = New System.Windows.Forms.TextBox()
        Me.txt_width = New System.Windows.Forms.TextBox()
        Me.txt_length = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.label_raiocanto = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Positiongroupbox = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_center_y = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_center_x = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tabpage_slot = New System.Windows.Forms.TabPage()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_slot_width = New System.Windows.Forms.TextBox()
        Me.txt_slot_length = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txt_slot_center_y = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txt_slot_center_x = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.tabpage_circle_hole = New System.Windows.Forms.TabPage()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.checkbox_pattern_y = New System.Windows.Forms.CheckBox()
        Me.txt_hole_instances_y = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.checkbox_pattern_x = New System.Windows.Forms.CheckBox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.txt_hole_spacing_y = New System.Windows.Forms.TextBox()
        Me.txt_hole_instances_x = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.txt_hole_spacing_x = New System.Windows.Forms.TextBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txt_hole_diameter1 = New System.Windows.Forms.TextBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_hole_center_y = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txt_hole_center_x = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.timer_interface = New System.Windows.Forms.Timer(Me.components)
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.timer_update_position = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ManualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AutomaticGcodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LiveWebcamToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tx_z = New System.Windows.Forms.TextBox()
        Me.tx_x = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.tx_y = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.btn_zero_x = New System.Windows.Forms.Button()
        Me.btn_zero_y = New System.Windows.Forms.Button()
        Me.btn_zero_z = New System.Windows.Forms.Button()
        Me.OpenFile_Dxf = New System.Windows.Forms.OpenFileDialog()
        Me.Listbox_gcode = New System.Windows.Forms.ListBox()
        Me.Timer_drawing_templates = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.contador_tempo = New System.Windows.Forms.Timer(Me.components)
        Me.btn_save_gcode = New System.Windows.Forms.Button()
        Me.btn_load_internally = New System.Windows.Forms.Button()
        Me.btn_save_internally = New System.Windows.Forms.Button()
        Me.checkbox_holes1 = New System.Windows.Forms.CheckBox()
        Me.checkbox_holes2 = New System.Windows.Forms.CheckBox()
        Me.checkbox_fillet = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.tabcontrol_shape_template.SuspendLayout()
        Me.tabpage_retangular.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Positiongroupbox.SuspendLayout()
        Me.tabpage_slot.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.tabpage_circle_hole.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_LoadGcode
        '
        Me.btn_LoadGcode.Location = New System.Drawing.Point(1249, 566)
        Me.btn_LoadGcode.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_LoadGcode.Name = "btn_LoadGcode"
        Me.btn_LoadGcode.Size = New System.Drawing.Size(121, 49)
        Me.btn_LoadGcode.TabIndex = 85
        Me.btn_LoadGcode.Text = "Load G-code Externally"
        Me.btn_LoadGcode.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(100, 111)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(37, 16)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "[mm]"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 16)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Dist. from edge"
        '
        'txt_edge
        '
        Me.txt_edge.Location = New System.Drawing.Point(18, 109)
        Me.txt_edge.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_edge.Name = "txt_edge"
        Me.txt_edge.Size = New System.Drawing.Size(72, 22)
        Me.txt_edge.TabIndex = 30
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Location = New System.Drawing.Point(58, 24)
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
        Me.Panel3.Location = New System.Drawing.Point(219, 23)
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
        'Panel_dxf_drawing
        '
        Me.Panel_dxf_drawing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel_dxf_drawing.Location = New System.Drawing.Point(679, 230)
        Me.Panel_dxf_drawing.Name = "Panel_dxf_drawing"
        Me.Panel_dxf_drawing.Size = New System.Drawing.Size(423, 478)
        Me.Panel_dxf_drawing.TabIndex = 92
        '
        'btn_home
        '
        Me.btn_home.Location = New System.Drawing.Point(348, 661)
        Me.btn_home.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(147, 42)
        Me.btn_home.TabIndex = 65
        Me.btn_home.Text = "Machine Position"
        Me.btn_home.UseVisualStyleBackColor = True
        '
        'btn_reset
        '
        Me.btn_reset.BackColor = System.Drawing.Color.IndianRed
        Me.btn_reset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_reset.Location = New System.Drawing.Point(1121, 672)
        Me.btn_reset.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_reset.Name = "btn_reset"
        Me.btn_reset.Size = New System.Drawing.Size(247, 36)
        Me.btn_reset.TabIndex = 77
        Me.btn_reset.Text = "RESET"
        Me.btn_reset.UseVisualStyleBackColor = False
        '
        'btn_stop
        '
        Me.btn_stop.BackColor = System.Drawing.Color.Salmon
        Me.btn_stop.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_stop.Location = New System.Drawing.Point(1250, 632)
        Me.btn_stop.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_stop.Name = "btn_stop"
        Me.btn_stop.Size = New System.Drawing.Size(118, 36)
        Me.btn_stop.TabIndex = 76
        Me.btn_stop.Text = "Stop"
        Me.btn_stop.UseVisualStyleBackColor = False
        '
        'btn_clear_gcode
        '
        Me.btn_clear_gcode.Location = New System.Drawing.Point(1122, 487)
        Me.btn_clear_gcode.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_clear_gcode.Name = "btn_clear_gcode"
        Me.btn_clear_gcode.Size = New System.Drawing.Size(248, 29)
        Me.btn_clear_gcode.TabIndex = 67
        Me.btn_clear_gcode.Text = "Clear"
        Me.btn_clear_gcode.UseVisualStyleBackColor = True
        '
        'btn_feedhold
        '
        Me.btn_feedhold.BackColor = System.Drawing.Color.White
        Me.btn_feedhold.Location = New System.Drawing.Point(514, 661)
        Me.btn_feedhold.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_feedhold.Name = "btn_feedhold"
        Me.btn_feedhold.Size = New System.Drawing.Size(147, 42)
        Me.btn_feedhold.TabIndex = 75
        Me.btn_feedhold.Text = "Feed Hold"
        Me.btn_feedhold.UseVisualStyleBackColor = False
        '
        'btn_start
        '
        Me.btn_start.BackColor = System.Drawing.Color.PaleGreen
        Me.btn_start.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_start.Location = New System.Drawing.Point(1122, 632)
        Me.btn_start.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_start.Name = "btn_start"
        Me.btn_start.Size = New System.Drawing.Size(118, 36)
        Me.btn_start.TabIndex = 66
        Me.btn_start.Text = "Start"
        Me.btn_start.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.btn_generate_gcode)
        Me.GroupBox1.Controls.Add(Me.btn_save_dxf)
        Me.GroupBox1.Controls.Add(Me.btn_dxf_update)
        Me.GroupBox1.Controls.Add(Me.tabcontrol_shape_template)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 30)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(659, 627)
        Me.GroupBox1.TabIndex = 71
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Shape Cutting Template "
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label47)
        Me.GroupBox6.Controls.Add(Me.txt_laser_power)
        Me.GroupBox6.Controls.Add(Me.Label48)
        Me.GroupBox6.Controls.Add(Me.Label45)
        Me.GroupBox6.Controls.Add(Me.txt_parameters_cutting_feedrate)
        Me.GroupBox6.Controls.Add(Me.Label46)
        Me.GroupBox6.Controls.Add(Me.Label43)
        Me.GroupBox6.Controls.Add(Me.txt_parameters_z_feedrate)
        Me.GroupBox6.Controls.Add(Me.Label44)
        Me.GroupBox6.Controls.Add(Me.Label41)
        Me.GroupBox6.Controls.Add(Me.txt_parameters_z_cutting)
        Me.GroupBox6.Controls.Add(Me.Label42)
        Me.GroupBox6.Controls.Add(Me.Label39)
        Me.GroupBox6.Controls.Add(Me.txt_parameters_safe_distance)
        Me.GroupBox6.Controls.Add(Me.Label40)
        Me.GroupBox6.Location = New System.Drawing.Point(6, 349)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(643, 217)
        Me.GroupBox6.TabIndex = 96
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Cutting Parameters"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(309, 43)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(82, 16)
        Me.Label47.TabIndex = 107
        Me.Label47.Text = "Laser Power"
        '
        'txt_laser_power
        '
        Me.txt_laser_power.Location = New System.Drawing.Point(404, 37)
        Me.txt_laser_power.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_laser_power.Name = "txt_laser_power"
        Me.txt_laser_power.Size = New System.Drawing.Size(108, 22)
        Me.txt_laser_power.TabIndex = 106
        Me.txt_laser_power.Text = "0"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Location = New System.Drawing.Point(525, 39)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(28, 16)
        Me.Label48.TabIndex = 108
        Me.Label48.Text = "[W]"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(-3, 103)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(108, 16)
        Me.Label45.TabIndex = 104
        Me.Label45.Text = "Cutting Feedrate "
        '
        'txt_parameters_cutting_feedrate
        '
        Me.txt_parameters_cutting_feedrate.Location = New System.Drawing.Point(117, 100)
        Me.txt_parameters_cutting_feedrate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_parameters_cutting_feedrate.Name = "txt_parameters_cutting_feedrate"
        Me.txt_parameters_cutting_feedrate.Size = New System.Drawing.Size(108, 22)
        Me.txt_parameters_cutting_feedrate.TabIndex = 103
        Me.txt_parameters_cutting_feedrate.Text = "2000"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(238, 102)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(37, 16)
        Me.Label46.TabIndex = 105
        Me.Label46.Text = "[mm]"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Location = New System.Drawing.Point(26, 131)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(73, 16)
        Me.Label43.TabIndex = 101
        Me.Label43.Text = "Feedrate Z"
        '
        'txt_parameters_z_feedrate
        '
        Me.txt_parameters_z_feedrate.Location = New System.Drawing.Point(117, 129)
        Me.txt_parameters_z_feedrate.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_parameters_z_feedrate.Name = "txt_parameters_z_feedrate"
        Me.txt_parameters_z_feedrate.Size = New System.Drawing.Size(108, 22)
        Me.txt_parameters_z_feedrate.TabIndex = 100
        Me.txt_parameters_z_feedrate.Text = "200"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Location = New System.Drawing.Point(238, 131)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(37, 16)
        Me.Label44.TabIndex = 102
        Me.Label44.Text = "[mm]"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Location = New System.Drawing.Point(15, 45)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(84, 16)
        Me.Label41.TabIndex = 98
        Me.Label41.Text = "Cutting Label"
        '
        'txt_parameters_z_cutting
        '
        Me.txt_parameters_z_cutting.Location = New System.Drawing.Point(117, 39)
        Me.txt_parameters_z_cutting.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_parameters_z_cutting.Name = "txt_parameters_z_cutting"
        Me.txt_parameters_z_cutting.Size = New System.Drawing.Size(108, 22)
        Me.txt_parameters_z_cutting.TabIndex = 97
        Me.txt_parameters_z_cutting.Text = "0"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Location = New System.Drawing.Point(238, 41)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(37, 16)
        Me.Label42.TabIndex = 99
        Me.Label42.Text = "[mm]"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(8, 73)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(91, 16)
        Me.Label39.TabIndex = 95
        Me.Label39.Text = "Safe Distance"
        '
        'txt_parameters_safe_distance
        '
        Me.txt_parameters_safe_distance.Location = New System.Drawing.Point(117, 67)
        Me.txt_parameters_safe_distance.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_parameters_safe_distance.Name = "txt_parameters_safe_distance"
        Me.txt_parameters_safe_distance.Size = New System.Drawing.Size(108, 22)
        Me.txt_parameters_safe_distance.TabIndex = 94
        Me.txt_parameters_safe_distance.Text = "5"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(238, 69)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(37, 16)
        Me.Label40.TabIndex = 96
        Me.Label40.Text = "[mm]"
        '
        'btn_generate_gcode
        '
        Me.btn_generate_gcode.Location = New System.Drawing.Point(516, 572)
        Me.btn_generate_gcode.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_generate_gcode.Name = "btn_generate_gcode"
        Me.btn_generate_gcode.Size = New System.Drawing.Size(137, 33)
        Me.btn_generate_gcode.TabIndex = 93
        Me.btn_generate_gcode.Text = "Generate G-code"
        Me.btn_generate_gcode.UseVisualStyleBackColor = True
        '
        'btn_save_dxf
        '
        Me.btn_save_dxf.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_save_dxf.Location = New System.Drawing.Point(373, 572)
        Me.btn_save_dxf.Name = "btn_save_dxf"
        Me.btn_save_dxf.Size = New System.Drawing.Size(137, 33)
        Me.btn_save_dxf.TabIndex = 95
        Me.btn_save_dxf.Text = "Save Dxf"
        Me.btn_save_dxf.UseVisualStyleBackColor = True
        '
        'btn_dxf_update
        '
        Me.btn_dxf_update.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.btn_dxf_update.Location = New System.Drawing.Point(232, 575)
        Me.btn_dxf_update.Name = "btn_dxf_update"
        Me.btn_dxf_update.Size = New System.Drawing.Size(135, 30)
        Me.btn_dxf_update.TabIndex = 91
        Me.btn_dxf_update.Text = "Update Dxf"
        Me.btn_dxf_update.UseVisualStyleBackColor = True
        '
        'tabcontrol_shape_template
        '
        Me.tabcontrol_shape_template.Controls.Add(Me.tabpage_retangular)
        Me.tabcontrol_shape_template.Controls.Add(Me.tabpage_slot)
        Me.tabcontrol_shape_template.Controls.Add(Me.tabpage_circle_hole)
        Me.tabcontrol_shape_template.Location = New System.Drawing.Point(6, 31)
        Me.tabcontrol_shape_template.Name = "tabcontrol_shape_template"
        Me.tabcontrol_shape_template.SelectedIndex = 0
        Me.tabcontrol_shape_template.Size = New System.Drawing.Size(647, 312)
        Me.tabcontrol_shape_template.TabIndex = 94
        '
        'tabpage_retangular
        '
        Me.tabpage_retangular.Controls.Add(Me.GroupBox4)
        Me.tabpage_retangular.Controls.Add(Me.GroupBox3)
        Me.tabpage_retangular.Controls.Add(Me.Positiongroupbox)
        Me.tabpage_retangular.Location = New System.Drawing.Point(4, 25)
        Me.tabpage_retangular.Name = "tabpage_retangular"
        Me.tabpage_retangular.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpage_retangular.Size = New System.Drawing.Size(639, 283)
        Me.tabpage_retangular.TabIndex = 0
        Me.tabpage_retangular.Text = "Retangular"
        Me.tabpage_retangular.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Panel1)
        Me.GroupBox4.Controls.Add(Me.Panel3)
        Me.GroupBox4.Controls.Add(Me.checkbox_holes1)
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.checkbox_holes2)
        Me.GroupBox4.Controls.Add(Me.Label14)
        Me.GroupBox4.Controls.Add(Me.txt_edge)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.txt_hole_diameter)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Location = New System.Drawing.Point(269, 6)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(364, 140)
        Me.GroupBox4.TabIndex = 37
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Hole"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(275, 115)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(37, 16)
        Me.Label15.TabIndex = 34
        Me.Label15.Text = "[mm]"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(195, 88)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(62, 16)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Diameter"
        '
        'txt_hole_diameter
        '
        Me.txt_hole_diameter.Location = New System.Drawing.Point(195, 112)
        Me.txt_hole_diameter.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_hole_diameter.Name = "txt_hole_diameter"
        Me.txt_hole_diameter.Size = New System.Drawing.Size(69, 22)
        Me.txt_hole_diameter.TabIndex = 32
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txt_corner_radius)
        Me.GroupBox3.Controls.Add(Me.txt_width)
        Me.GroupBox3.Controls.Add(Me.txt_length)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.label_raiocanto)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.checkbox_fillet)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 112)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(257, 166)
        Me.GroupBox3.TabIndex = 36
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Dimension Parameters"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 16)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Length (X)"
        '
        'txt_corner_radius
        '
        Me.txt_corner_radius.Location = New System.Drawing.Point(87, 129)
        Me.txt_corner_radius.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_corner_radius.Name = "txt_corner_radius"
        Me.txt_corner_radius.Size = New System.Drawing.Size(108, 22)
        Me.txt_corner_radius.TabIndex = 23
        '
        'txt_width
        '
        Me.txt_width.Location = New System.Drawing.Point(87, 59)
        Me.txt_width.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_width.Name = "txt_width"
        Me.txt_width.Size = New System.Drawing.Size(108, 22)
        Me.txt_width.TabIndex = 21
        '
        'txt_length
        '
        Me.txt_length.Location = New System.Drawing.Point(87, 26)
        Me.txt_length.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_length.Name = "txt_length"
        Me.txt_length.Size = New System.Drawing.Size(108, 22)
        Me.txt_length.TabIndex = 19
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(208, 129)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 16)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "[mm]"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(208, 28)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 16)
        Me.Label11.TabIndex = 28
        Me.Label11.Text = "[mm]"
        '
        'label_raiocanto
        '
        Me.label_raiocanto.AutoSize = True
        Me.label_raiocanto.Location = New System.Drawing.Point(0, 132)
        Me.label_raiocanto.Name = "label_raiocanto"
        Me.label_raiocanto.Size = New System.Drawing.Size(87, 16)
        Me.label_raiocanto.TabIndex = 24
        Me.label_raiocanto.Text = "Corner radius"
        Me.label_raiocanto.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 62)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 16)
        Me.Label6.TabIndex = 22
        Me.Label6.Text = "Width (Y)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(208, 63)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(37, 16)
        Me.Label12.TabIndex = 29
        Me.Label12.Text = "[mm]"
        '
        'Positiongroupbox
        '
        Me.Positiongroupbox.Controls.Add(Me.Label1)
        Me.Positiongroupbox.Controls.Add(Me.Label2)
        Me.Positiongroupbox.Controls.Add(Me.txt_center_y)
        Me.Positiongroupbox.Controls.Add(Me.Label3)
        Me.Positiongroupbox.Controls.Add(Me.txt_center_x)
        Me.Positiongroupbox.Controls.Add(Me.Label4)
        Me.Positiongroupbox.Location = New System.Drawing.Point(6, 6)
        Me.Positiongroupbox.Name = "Positiongroupbox"
        Me.Positiongroupbox.Size = New System.Drawing.Size(257, 100)
        Me.Positiongroupbox.TabIndex = 35
        Me.Positiongroupbox.TabStop = False
        Me.Positiongroupbox.Text = "Location"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 16)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Center (Y)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(208, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 16)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "[mm]"
        '
        'txt_center_y
        '
        Me.txt_center_y.Location = New System.Drawing.Point(87, 65)
        Me.txt_center_y.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_center_y.Name = "txt_center_y"
        Me.txt_center_y.Size = New System.Drawing.Size(108, 22)
        Me.txt_center_y.TabIndex = 38
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(208, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 16)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "[mm]"
        '
        'txt_center_x
        '
        Me.txt_center_x.Location = New System.Drawing.Point(87, 32)
        Me.txt_center_x.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_center_x.Name = "txt_center_x"
        Me.txt_center_x.Size = New System.Drawing.Size(108, 22)
        Me.txt_center_x.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 16)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Center (X)"
        '
        'tabpage_slot
        '
        Me.tabpage_slot.Controls.Add(Me.PictureBox1)
        Me.tabpage_slot.Controls.Add(Me.GroupBox7)
        Me.tabpage_slot.Controls.Add(Me.GroupBox8)
        Me.tabpage_slot.Location = New System.Drawing.Point(4, 25)
        Me.tabpage_slot.Name = "tabpage_slot"
        Me.tabpage_slot.Padding = New System.Windows.Forms.Padding(3)
        Me.tabpage_slot.Size = New System.Drawing.Size(639, 283)
        Me.tabpage_slot.TabIndex = 1
        Me.tabpage_slot.Text = "Slot"
        Me.tabpage_slot.UseVisualStyleBackColor = True
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label8)
        Me.GroupBox7.Controls.Add(Me.txt_slot_width)
        Me.GroupBox7.Controls.Add(Me.txt_slot_length)
        Me.GroupBox7.Controls.Add(Me.Label16)
        Me.GroupBox7.Controls.Add(Me.Label18)
        Me.GroupBox7.Controls.Add(Me.Label19)
        Me.GroupBox7.Location = New System.Drawing.Point(6, 112)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(257, 98)
        Me.GroupBox7.TabIndex = 38
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Dimension Parameters"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(66, 16)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Length (X)"
        '
        'txt_slot_width
        '
        Me.txt_slot_width.Location = New System.Drawing.Point(87, 59)
        Me.txt_slot_width.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_slot_width.Name = "txt_slot_width"
        Me.txt_slot_width.Size = New System.Drawing.Size(108, 22)
        Me.txt_slot_width.TabIndex = 21
        '
        'txt_slot_length
        '
        Me.txt_slot_length.Location = New System.Drawing.Point(87, 26)
        Me.txt_slot_length.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_slot_length.Name = "txt_slot_length"
        Me.txt_slot_length.Size = New System.Drawing.Size(108, 22)
        Me.txt_slot_length.TabIndex = 19
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(208, 28)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(37, 16)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "[mm]"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 62)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(61, 16)
        Me.Label18.TabIndex = 22
        Me.Label18.Text = "Width (Y)"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(208, 63)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(37, 16)
        Me.Label19.TabIndex = 29
        Me.Label19.Text = "[mm]"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Label20)
        Me.GroupBox8.Controls.Add(Me.Label24)
        Me.GroupBox8.Controls.Add(Me.txt_slot_center_y)
        Me.GroupBox8.Controls.Add(Me.Label25)
        Me.GroupBox8.Controls.Add(Me.txt_slot_center_x)
        Me.GroupBox8.Controls.Add(Me.Label26)
        Me.GroupBox8.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(257, 100)
        Me.GroupBox8.TabIndex = 37
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Location"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(10, 69)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(66, 16)
        Me.Label20.TabIndex = 37
        Me.Label20.Text = "Center (Y)"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(208, 34)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(37, 16)
        Me.Label24.TabIndex = 40
        Me.Label24.Text = "[mm]"
        '
        'txt_slot_center_y
        '
        Me.txt_slot_center_y.Location = New System.Drawing.Point(87, 65)
        Me.txt_slot_center_y.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_slot_center_y.Name = "txt_slot_center_y"
        Me.txt_slot_center_y.Size = New System.Drawing.Size(108, 22)
        Me.txt_slot_center_y.TabIndex = 38
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(208, 69)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(37, 16)
        Me.Label25.TabIndex = 41
        Me.Label25.Text = "[mm]"
        '
        'txt_slot_center_x
        '
        Me.txt_slot_center_x.Location = New System.Drawing.Point(87, 32)
        Me.txt_slot_center_x.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_slot_center_x.Name = "txt_slot_center_x"
        Me.txt_slot_center_x.Size = New System.Drawing.Size(108, 22)
        Me.txt_slot_center_x.TabIndex = 36
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(11, 36)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(65, 16)
        Me.Label26.TabIndex = 39
        Me.Label26.Text = "Center (X)"
        '
        'tabpage_circle_hole
        '
        Me.tabpage_circle_hole.Controls.Add(Me.GroupBox11)
        Me.tabpage_circle_hole.Controls.Add(Me.GroupBox10)
        Me.tabpage_circle_hole.Controls.Add(Me.GroupBox9)
        Me.tabpage_circle_hole.Location = New System.Drawing.Point(4, 25)
        Me.tabpage_circle_hole.Name = "tabpage_circle_hole"
        Me.tabpage_circle_hole.Size = New System.Drawing.Size(639, 283)
        Me.tabpage_circle_hole.TabIndex = 2
        Me.tabpage_circle_hole.Text = "Circle/ Hole"
        Me.tabpage_circle_hole.UseVisualStyleBackColor = True
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.Label35)
        Me.GroupBox11.Controls.Add(Me.checkbox_pattern_y)
        Me.GroupBox11.Controls.Add(Me.txt_hole_instances_y)
        Me.GroupBox11.Controls.Add(Me.Label31)
        Me.GroupBox11.Controls.Add(Me.Label36)
        Me.GroupBox11.Controls.Add(Me.checkbox_pattern_x)
        Me.GroupBox11.Controls.Add(Me.Label37)
        Me.GroupBox11.Controls.Add(Me.txt_hole_spacing_y)
        Me.GroupBox11.Controls.Add(Me.txt_hole_instances_x)
        Me.GroupBox11.Controls.Add(Me.Label38)
        Me.GroupBox11.Controls.Add(Me.Label32)
        Me.GroupBox11.Controls.Add(Me.Label34)
        Me.GroupBox11.Controls.Add(Me.Label33)
        Me.GroupBox11.Controls.Add(Me.txt_hole_spacing_x)
        Me.GroupBox11.Location = New System.Drawing.Point(280, 6)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(307, 203)
        Me.GroupBox11.TabIndex = 43
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Linear Pattern"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(43, 169)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(64, 16)
        Me.Label35.TabIndex = 43
        Me.Label35.Text = "Instances"
        '
        'checkbox_pattern_y
        '
        Me.checkbox_pattern_y.AutoSize = True
        Me.checkbox_pattern_y.Location = New System.Drawing.Point(6, 111)
        Me.checkbox_pattern_y.Name = "checkbox_pattern_y"
        Me.checkbox_pattern_y.Size = New System.Drawing.Size(102, 20)
        Me.checkbox_pattern_y.TabIndex = 50
        Me.checkbox_pattern_y.Text = "Direction (Y)"
        Me.checkbox_pattern_y.UseVisualStyleBackColor = True
        '
        'txt_hole_instances_y
        '
        Me.txt_hole_instances_y.Location = New System.Drawing.Point(113, 165)
        Me.txt_hole_instances_y.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_hole_instances_y.Name = "txt_hole_instances_y"
        Me.txt_hole_instances_y.Size = New System.Drawing.Size(108, 22)
        Me.txt_hole_instances_y.TabIndex = 44
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(43, 77)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(64, 16)
        Me.Label31.TabIndex = 43
        Me.Label31.Text = "Instances"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(234, 134)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(37, 16)
        Me.Label36.TabIndex = 46
        Me.Label36.Text = "[mm]"
        '
        'checkbox_pattern_x
        '
        Me.checkbox_pattern_x.AutoSize = True
        Me.checkbox_pattern_x.Location = New System.Drawing.Point(6, 23)
        Me.checkbox_pattern_x.Name = "checkbox_pattern_x"
        Me.checkbox_pattern_x.Size = New System.Drawing.Size(101, 20)
        Me.checkbox_pattern_x.TabIndex = 49
        Me.checkbox_pattern_x.Text = "Direction (X)"
        Me.checkbox_pattern_x.UseVisualStyleBackColor = True
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(47, 138)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(60, 16)
        Me.Label37.TabIndex = 45
        Me.Label37.Text = "Spacing "
        '
        'txt_hole_spacing_y
        '
        Me.txt_hole_spacing_y.Location = New System.Drawing.Point(113, 132)
        Me.txt_hole_spacing_y.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_hole_spacing_y.Name = "txt_hole_spacing_y"
        Me.txt_hole_spacing_y.Size = New System.Drawing.Size(108, 22)
        Me.txt_hole_spacing_y.TabIndex = 42
        '
        'txt_hole_instances_x
        '
        Me.txt_hole_instances_x.Location = New System.Drawing.Point(113, 73)
        Me.txt_hole_instances_x.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_hole_instances_x.Name = "txt_hole_instances_x"
        Me.txt_hole_instances_x.Size = New System.Drawing.Size(108, 22)
        Me.txt_hole_instances_x.TabIndex = 44
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(234, 169)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(19, 16)
        Me.Label38.TabIndex = 47
        Me.Label38.Text = "[-]"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(234, 42)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(37, 16)
        Me.Label32.TabIndex = 46
        Me.Label32.Text = "[mm]"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(47, 46)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(60, 16)
        Me.Label34.TabIndex = 45
        Me.Label34.Text = "Spacing "
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(234, 77)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(19, 16)
        Me.Label33.TabIndex = 47
        Me.Label33.Text = "[-]"
        '
        'txt_hole_spacing_x
        '
        Me.txt_hole_spacing_x.Location = New System.Drawing.Point(113, 40)
        Me.txt_hole_spacing_x.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_hole_spacing_x.Name = "txt_hole_spacing_x"
        Me.txt_hole_spacing_x.Size = New System.Drawing.Size(108, 22)
        Me.txt_hole_spacing_x.TabIndex = 42
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.Label30)
        Me.GroupBox10.Controls.Add(Me.Label29)
        Me.GroupBox10.Controls.Add(Me.txt_hole_diameter1)
        Me.GroupBox10.Location = New System.Drawing.Point(6, 121)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(257, 88)
        Me.GroupBox10.TabIndex = 42
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Hole Parameters"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(11, 42)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(62, 16)
        Me.Label30.TabIndex = 40
        Me.Label30.Text = "Diameter"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(208, 42)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(37, 16)
        Me.Label29.TabIndex = 41
        Me.Label29.Text = "[mm]"
        '
        'txt_hole_diameter1
        '
        Me.txt_hole_diameter1.Location = New System.Drawing.Point(87, 39)
        Me.txt_hole_diameter1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_hole_diameter1.Name = "txt_hole_diameter1"
        Me.txt_hole_diameter1.Size = New System.Drawing.Size(108, 22)
        Me.txt_hole_diameter1.TabIndex = 39
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Label9)
        Me.GroupBox9.Controls.Add(Me.Label17)
        Me.GroupBox9.Controls.Add(Me.txt_hole_center_y)
        Me.GroupBox9.Controls.Add(Me.Label27)
        Me.GroupBox9.Controls.Add(Me.txt_hole_center_x)
        Me.GroupBox9.Controls.Add(Me.Label28)
        Me.GroupBox9.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(257, 100)
        Me.GroupBox9.TabIndex = 38
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Location"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 69)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 16)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Center (Y)"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(208, 34)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(37, 16)
        Me.Label17.TabIndex = 40
        Me.Label17.Text = "[mm]"
        '
        'txt_hole_center_y
        '
        Me.txt_hole_center_y.Location = New System.Drawing.Point(87, 65)
        Me.txt_hole_center_y.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_hole_center_y.Name = "txt_hole_center_y"
        Me.txt_hole_center_y.Size = New System.Drawing.Size(108, 22)
        Me.txt_hole_center_y.TabIndex = 38
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(208, 69)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(37, 16)
        Me.Label27.TabIndex = 41
        Me.Label27.Text = "[mm]"
        '
        'txt_hole_center_x
        '
        Me.txt_hole_center_x.Location = New System.Drawing.Point(87, 32)
        Me.txt_hole_center_x.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_hole_center_x.Name = "txt_hole_center_x"
        Me.txt_hole_center_x.Size = New System.Drawing.Size(108, 22)
        Me.txt_hole_center_x.TabIndex = 36
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(11, 36)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(65, 16)
        Me.Label28.TabIndex = 39
        Me.Label28.Text = "Center (X)"
        '
        'timer_interface
        '
        Me.timer_interface.Enabled = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'timer_update_position
        '
        Me.timer_update_position.Interval = 500
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModeToolStripMenuItem, Me.LiveWebcamToolStripMenuItem, Me.AboutToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1382, 30)
        Me.MenuStrip1.TabIndex = 87
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ModeToolStripMenuItem
        '
        Me.ModeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ManualToolStripMenuItem, Me.AutomaticGcodeToolStripMenuItem})
        Me.ModeToolStripMenuItem.Name = "ModeToolStripMenuItem"
        Me.ModeToolStripMenuItem.Size = New System.Drawing.Size(62, 26)
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
        Me.LiveWebcamToolStripMenuItem.Size = New System.Drawing.Size(111, 26)
        Me.LiveWebcamToolStripMenuItem.Text = "Live Webcam"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(64, 26)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(55, 26)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tx_z)
        Me.GroupBox2.Controls.Add(Me.tx_x)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.tx_y)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.btn_zero_x)
        Me.GroupBox2.Controls.Add(Me.btn_zero_y)
        Me.GroupBox2.Controls.Add(Me.btn_zero_z)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(679, 30)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(423, 193)
        Me.GroupBox2.TabIndex = 88
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Real Position"
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
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(13, 38)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(15, 16)
        Me.Label21.TabIndex = 5
        Me.Label21.Text = "X"
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
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(13, 89)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(16, 16)
        Me.Label22.TabIndex = 9
        Me.Label22.Text = "Y"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(16, 136)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(15, 16)
        Me.Label23.TabIndex = 11
        Me.Label23.Text = "Z"
        '
        'btn_zero_x
        '
        Me.btn_zero_x.Location = New System.Drawing.Point(234, 37)
        Me.btn_zero_x.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_zero_x.Name = "btn_zero_x"
        Me.btn_zero_x.Size = New System.Drawing.Size(137, 34)
        Me.btn_zero_x.TabIndex = 43
        Me.btn_zero_x.Text = "Zero X"
        Me.btn_zero_x.UseVisualStyleBackColor = True
        '
        'btn_zero_y
        '
        Me.btn_zero_y.Location = New System.Drawing.Point(234, 86)
        Me.btn_zero_y.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_zero_y.Name = "btn_zero_y"
        Me.btn_zero_y.Size = New System.Drawing.Size(137, 34)
        Me.btn_zero_y.TabIndex = 44
        Me.btn_zero_y.Text = "Zero Y"
        Me.btn_zero_y.UseVisualStyleBackColor = True
        '
        'btn_zero_z
        '
        Me.btn_zero_z.Location = New System.Drawing.Point(234, 134)
        Me.btn_zero_z.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_zero_z.Name = "btn_zero_z"
        Me.btn_zero_z.Size = New System.Drawing.Size(137, 34)
        Me.btn_zero_z.TabIndex = 47
        Me.btn_zero_z.Text = "Zero Z"
        Me.btn_zero_z.UseVisualStyleBackColor = True
        '
        'OpenFile_Dxf
        '
        Me.OpenFile_Dxf.FileName = "OpenFileDialog2"
        '
        'Listbox_gcode
        '
        Me.Listbox_gcode.FormattingEnabled = True
        Me.Listbox_gcode.ItemHeight = 16
        Me.Listbox_gcode.Location = New System.Drawing.Point(1122, 46)
        Me.Listbox_gcode.Name = "Listbox_gcode"
        Me.Listbox_gcode.Size = New System.Drawing.Size(248, 436)
        Me.Listbox_gcode.TabIndex = 91
        '
        'Timer_drawing_templates
        '
        Me.Timer_drawing_templates.Enabled = True
        Me.Timer_drawing_templates.Interval = 1000
        '
        'contador_tempo
        '
        Me.contador_tempo.Enabled = True
        Me.contador_tempo.Interval = 1000
        '
        'btn_save_gcode
        '
        Me.btn_save_gcode.Location = New System.Drawing.Point(1249, 520)
        Me.btn_save_gcode.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_save_gcode.Name = "btn_save_gcode"
        Me.btn_save_gcode.Size = New System.Drawing.Size(121, 42)
        Me.btn_save_gcode.TabIndex = 93
        Me.btn_save_gcode.Text = "Save G-Code Externally"
        Me.btn_save_gcode.UseVisualStyleBackColor = True
        '
        'btn_load_internally
        '
        Me.btn_load_internally.Location = New System.Drawing.Point(1122, 566)
        Me.btn_load_internally.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_load_internally.Name = "btn_load_internally"
        Me.btn_load_internally.Size = New System.Drawing.Size(121, 49)
        Me.btn_load_internally.TabIndex = 94
        Me.btn_load_internally.Text = "Load G-code Internally"
        Me.btn_load_internally.UseVisualStyleBackColor = True
        '
        'btn_save_internally
        '
        Me.btn_save_internally.Location = New System.Drawing.Point(1122, 520)
        Me.btn_save_internally.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btn_save_internally.Name = "btn_save_internally"
        Me.btn_save_internally.Size = New System.Drawing.Size(121, 42)
        Me.btn_save_internally.TabIndex = 95
        Me.btn_save_internally.Text = "Save G-Code Internally"
        Me.btn_save_internally.UseVisualStyleBackColor = True
        '
        'checkbox_holes1
        '
        Me.checkbox_holes1.AutoSize = True
        Me.checkbox_holes1.Checked = Global.WindowsApp1teste.My.MySettings.Default.CheckHoles1
        Me.checkbox_holes1.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.WindowsApp1teste.My.MySettings.Default, "CheckHoles1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.checkbox_holes1.Location = New System.Drawing.Point(17, 42)
        Me.checkbox_holes1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.checkbox_holes1.Name = "checkbox_holes1"
        Me.checkbox_holes1.Size = New System.Drawing.Size(18, 17)
        Me.checkbox_holes1.TabIndex = 13
        Me.checkbox_holes1.UseVisualStyleBackColor = True
        '
        'checkbox_holes2
        '
        Me.checkbox_holes2.AutoSize = True
        Me.checkbox_holes2.Checked = Global.WindowsApp1teste.My.MySettings.Default.CheckHoles2
        Me.checkbox_holes2.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.WindowsApp1teste.My.MySettings.Default, "CheckHoles2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.checkbox_holes2.Location = New System.Drawing.Point(175, 42)
        Me.checkbox_holes2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.checkbox_holes2.Name = "checkbox_holes2"
        Me.checkbox_holes2.Size = New System.Drawing.Size(18, 17)
        Me.checkbox_holes2.TabIndex = 14
        Me.checkbox_holes2.UseVisualStyleBackColor = True
        '
        'checkbox_fillet
        '
        Me.checkbox_fillet.AutoSize = True
        Me.checkbox_fillet.Checked = Global.WindowsApp1teste.My.MySettings.Default.CheckFillet
        Me.checkbox_fillet.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.WindowsApp1teste.My.MySettings.Default, "CheckFillet", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.checkbox_fillet.Location = New System.Drawing.Point(9, 105)
        Me.checkbox_fillet.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.checkbox_fillet.Name = "checkbox_fillet"
        Me.checkbox_fillet.Size = New System.Drawing.Size(57, 20)
        Me.checkbox_fillet.TabIndex = 25
        Me.checkbox_fillet.Text = "Fillet"
        Me.checkbox_fillet.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.WindowsApp1teste.My.Resources.Resources.dimensoes_slot
        Me.PictureBox1.Location = New System.Drawing.Point(269, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(364, 204)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 39
        Me.PictureBox1.TabStop = False
        '
        'Form_laser_automatic
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1382, 714)
        Me.Controls.Add(Me.btn_load_internally)
        Me.Controls.Add(Me.btn_save_internally)
        Me.Controls.Add(Me.btn_save_gcode)
        Me.Controls.Add(Me.Panel_dxf_drawing)
        Me.Controls.Add(Me.Listbox_gcode)
        Me.Controls.Add(Me.btn_start)
        Me.Controls.Add(Me.btn_LoadGcode)
        Me.Controls.Add(Me.btn_stop)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.btn_home)
        Me.Controls.Add(Me.btn_reset)
        Me.Controls.Add(Me.btn_clear_gcode)
        Me.Controls.Add(Me.btn_feedhold)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form_laser_automatic"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Laser Machine Control Automatic Mode"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.tabcontrol_shape_template.ResumeLayout(False)
        Me.tabpage_retangular.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Positiongroupbox.ResumeLayout(False)
        Me.Positiongroupbox.PerformLayout()
        Me.tabpage_slot.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.tabpage_circle_hole.ResumeLayout(False)
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_LoadGcode As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_edge As TextBox
    Friend WithEvents checkbox_holes2 As CheckBox
    Friend WithEvents checkbox_holes1 As CheckBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel10 As Panel
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents btn_home As Button
    Friend WithEvents btn_reset As Button
    Friend WithEvents btn_stop As Button
    Friend WithEvents btn_clear_gcode As Button
    Friend WithEvents btn_feedhold As Button
    Friend WithEvents btn_start As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents checkbox_fillet As CheckBox
    Friend WithEvents label_raiocanto As Label
    Friend WithEvents txt_width As TextBox
    Friend WithEvents txt_corner_radius As TextBox
    Friend WithEvents txt_length As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents timer_interface As Timer
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents timer_update_position As Timer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ModeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ManualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AutomaticGcodeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tx_z As TextBox
    Friend WithEvents tx_x As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents tx_y As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents btn_zero_x As Button
    Friend WithEvents btn_zero_y As Button
    Friend WithEvents btn_zero_z As Button
    Friend WithEvents OpenFile_Dxf As OpenFileDialog
    Friend WithEvents Listbox_gcode As ListBox
    Friend WithEvents Panel_dxf_drawing As Panel
    Friend WithEvents btn_generate_gcode As Button
    Friend WithEvents tabcontrol_shape_template As TabControl
    Friend WithEvents tabpage_retangular As TabPage
    Friend WithEvents tabpage_slot As TabPage
    Friend WithEvents tabpage_circle_hole As TabPage
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Positiongroupbox As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_center_y As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_center_x As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txt_hole_diameter As TextBox
    Friend WithEvents Timer_drawing_templates As Timer
    Friend WithEvents btn_save_dxf As Button
    Friend WithEvents btn_dxf_update As Button
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_slot_width As TextBox
    Friend WithEvents txt_slot_length As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents Label20 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents txt_slot_center_y As TextBox
    Friend WithEvents Label25 As Label
    Friend WithEvents txt_slot_center_x As TextBox
    Friend WithEvents Label26 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents Label31 As Label
    Friend WithEvents txt_hole_instances_x As TextBox
    Friend WithEvents Label32 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents txt_hole_spacing_x As TextBox
    Friend WithEvents Label33 As Label
    Friend WithEvents GroupBox10 As GroupBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents txt_hole_diameter1 As TextBox
    Friend WithEvents GroupBox9 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents txt_hole_center_y As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents txt_hole_center_x As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents checkbox_pattern_y As CheckBox
    Friend WithEvents txt_hole_instances_y As TextBox
    Friend WithEvents Label36 As Label
    Friend WithEvents checkbox_pattern_x As CheckBox
    Friend WithEvents Label37 As Label
    Friend WithEvents txt_hole_spacing_y As TextBox
    Friend WithEvents Label38 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents txt_parameters_safe_distance As TextBox
    Friend WithEvents Label40 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents txt_parameters_z_cutting As TextBox
    Friend WithEvents Label42 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents txt_parameters_cutting_feedrate As TextBox
    Friend WithEvents Label46 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents txt_parameters_z_feedrate As TextBox
    Friend WithEvents Label44 As Label
    Friend WithEvents contador_tempo As Timer
    Friend WithEvents Label47 As Label
    Friend WithEvents txt_laser_power As TextBox
    Friend WithEvents Label48 As Label
    Friend WithEvents btn_save_gcode As Button
    Friend WithEvents btn_load_internally As Button
    Friend WithEvents btn_save_internally As Button
    Friend WithEvents LiveWebcamToolStripMenuItem As ToolStripMenuItem
End Class
