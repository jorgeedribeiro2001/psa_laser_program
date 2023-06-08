<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Data_Base_Plataform
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.combobox_names = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_comments = New System.Windows.Forms.TextBox()
        Me.btn_modify = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_insert = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView_Users = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btn_clear_log = New System.Windows.Forms.Button()
        Me.btn_update_log = New System.Windows.Forms.Button()
        Me.datagridview_log = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.combobox_names_log = New System.Windows.Forms.ComboBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_cutting_time_milling = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_offline_laser = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btn_reset_laser_time = New System.Windows.Forms.Button()
        Me.txt_cutting_time_75_100 = New System.Windows.Forms.TextBox()
        Me.txt_cutting_time_50_75 = New System.Windows.Forms.TextBox()
        Me.txt_cutting_time_25_50 = New System.Windows.Forms.TextBox()
        Me.txt_cutting_time_1_25 = New System.Windows.Forms.TextBox()
        Me.label_time_1_25 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DataserverDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView_Users, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.datagridview_log, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataserverDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1083, 469)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.DataGridView_Users)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1075, 440)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "User Definitions"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_update)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.combobox_names)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txt_name)
        Me.GroupBox1.Controls.Add(Me.txt_comments)
        Me.GroupBox1.Controls.Add(Me.btn_modify)
        Me.GroupBox1.Controls.Add(Me.btn_delete)
        Me.GroupBox1.Controls.Add(Me.btn_insert)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_username)
        Me.GroupBox1.Controls.Add(Me.txt_password)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(418, 274)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add User"
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(274, 223)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(129, 28)
        Me.btn_update.TabIndex = 14
        Me.btn_update.Text = "Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(124, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(19, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "or"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 34)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Choose Name:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'combobox_names
        '
        Me.combobox_names.FormattingEnabled = True
        Me.combobox_names.Location = New System.Drawing.Point(127, 31)
        Me.combobox_names.Name = "combobox_names"
        Me.combobox_names.Size = New System.Drawing.Size(129, 24)
        Me.combobox_names.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Insert Name:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(127, 83)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(129, 22)
        Me.txt_name.TabIndex = 2
        '
        'txt_comments
        '
        Me.txt_comments.Location = New System.Drawing.Point(127, 167)
        Me.txt_comments.Multiline = True
        Me.txt_comments.Name = "txt_comments"
        Me.txt_comments.Size = New System.Drawing.Size(129, 84)
        Me.txt_comments.TabIndex = 10
        '
        'btn_modify
        '
        Me.btn_modify.Location = New System.Drawing.Point(274, 155)
        Me.btn_modify.Name = "btn_modify"
        Me.btn_modify.Size = New System.Drawing.Size(129, 28)
        Me.btn_modify.TabIndex = 0
        Me.btn_modify.Text = "Modify"
        Me.btn_modify.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(274, 189)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(129, 28)
        Me.btn_delete.TabIndex = 3
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_insert
        '
        Me.btn_insert.Location = New System.Drawing.Point(274, 121)
        Me.btn_insert.Name = "btn_insert"
        Me.btn_insert.Size = New System.Drawing.Size(129, 28)
        Me.btn_insert.TabIndex = 0
        Me.btn_insert.Text = "Insert"
        Me.btn_insert.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Insert Username:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Insert Comments:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(127, 111)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(129, 22)
        Me.txt_username.TabIndex = 6
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(127, 139)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(129, 22)
        Me.txt_password.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Insert Password:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGridView_Users
        '
        Me.DataGridView_Users.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Users.Location = New System.Drawing.Point(466, 16)
        Me.DataGridView_Users.Name = "DataGridView_Users"
        Me.DataGridView_Users.RowHeadersWidth = 51
        Me.DataGridView_Users.RowTemplate.Height = 24
        Me.DataGridView_Users.Size = New System.Drawing.Size(603, 356)
        Me.DataGridView_Users.TabIndex = 11
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btn_clear_log)
        Me.TabPage2.Controls.Add(Me.btn_update_log)
        Me.TabPage2.Controls.Add(Me.datagridview_log)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.combobox_names_log)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1075, 440)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "User History"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btn_clear_log
        '
        Me.btn_clear_log.Location = New System.Drawing.Point(399, 12)
        Me.btn_clear_log.Name = "btn_clear_log"
        Me.btn_clear_log.Size = New System.Drawing.Size(129, 28)
        Me.btn_clear_log.TabIndex = 17
        Me.btn_clear_log.Text = "Clear"
        Me.btn_clear_log.UseVisualStyleBackColor = True
        '
        'btn_update_log
        '
        Me.btn_update_log.Location = New System.Drawing.Point(264, 12)
        Me.btn_update_log.Name = "btn_update_log"
        Me.btn_update_log.Size = New System.Drawing.Size(129, 28)
        Me.btn_update_log.TabIndex = 16
        Me.btn_update_log.Text = "Update"
        Me.btn_update_log.UseVisualStyleBackColor = True
        '
        'datagridview_log
        '
        Me.datagridview_log.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridview_log.Location = New System.Drawing.Point(18, 55)
        Me.datagridview_log.Name = "datagridview_log"
        Me.datagridview_log.RowHeadersWidth = 51
        Me.datagridview_log.RowTemplate.Height = 24
        Me.datagridview_log.Size = New System.Drawing.Size(1039, 356)
        Me.datagridview_log.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(97, 16)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Choose Name:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'combobox_names_log
        '
        Me.combobox_names_log.FormattingEnabled = True
        Me.combobox_names_log.Location = New System.Drawing.Point(118, 15)
        Me.combobox_names_log.Name = "combobox_names_log"
        Me.combobox_names_log.Size = New System.Drawing.Size(129, 24)
        Me.combobox_names_log.TabIndex = 13
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.GroupBox4)
        Me.TabPage3.Controls.Add(Me.GroupBox3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 25)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1075, 440)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Machine Time Management"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label15)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Controls.Add(Me.txt_cutting_time_milling)
        Me.GroupBox4.Location = New System.Drawing.Point(6, 272)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(486, 162)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Milling Cutting Time"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(120, 36)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(84, 16)
        Me.Label15.TabIndex = 13
        Me.Label15.Text = "Cutting Time:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(145, 125)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(165, 31)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Reset"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txt_cutting_time_milling
        '
        Me.txt_cutting_time_milling.Location = New System.Drawing.Point(210, 36)
        Me.txt_cutting_time_milling.Name = "txt_cutting_time_milling"
        Me.txt_cutting_time_milling.Size = New System.Drawing.Size(100, 22)
        Me.txt_cutting_time_milling.TabIndex = 12
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_offline_laser)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.btn_reset_laser_time)
        Me.GroupBox3.Controls.Add(Me.txt_cutting_time_75_100)
        Me.GroupBox3.Controls.Add(Me.txt_cutting_time_50_75)
        Me.GroupBox3.Controls.Add(Me.txt_cutting_time_25_50)
        Me.GroupBox3.Controls.Add(Me.txt_cutting_time_1_25)
        Me.GroupBox3.Controls.Add(Me.label_time_1_25)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 6)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(486, 260)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Laser Cutting Time"
        '
        'txt_offline_laser
        '
        Me.txt_offline_laser.Location = New System.Drawing.Point(210, 175)
        Me.txt_offline_laser.Name = "txt_offline_laser"
        Me.txt_offline_laser.Size = New System.Drawing.Size(100, 22)
        Me.txt_offline_laser.TabIndex = 12
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(157, 175)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(47, 16)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Offline:"
        '
        'btn_reset_laser_time
        '
        Me.btn_reset_laser_time.Location = New System.Drawing.Point(145, 212)
        Me.btn_reset_laser_time.Name = "btn_reset_laser_time"
        Me.btn_reset_laser_time.Size = New System.Drawing.Size(165, 31)
        Me.btn_reset_laser_time.TabIndex = 10
        Me.btn_reset_laser_time.Text = "Reset"
        Me.btn_reset_laser_time.UseVisualStyleBackColor = True
        '
        'txt_cutting_time_75_100
        '
        Me.txt_cutting_time_75_100.Location = New System.Drawing.Point(210, 147)
        Me.txt_cutting_time_75_100.Name = "txt_cutting_time_75_100"
        Me.txt_cutting_time_75_100.Size = New System.Drawing.Size(100, 22)
        Me.txt_cutting_time_75_100.TabIndex = 9
        '
        'txt_cutting_time_50_75
        '
        Me.txt_cutting_time_50_75.Location = New System.Drawing.Point(210, 122)
        Me.txt_cutting_time_50_75.Name = "txt_cutting_time_50_75"
        Me.txt_cutting_time_50_75.Size = New System.Drawing.Size(100, 22)
        Me.txt_cutting_time_50_75.TabIndex = 8
        '
        'txt_cutting_time_25_50
        '
        Me.txt_cutting_time_25_50.Location = New System.Drawing.Point(210, 96)
        Me.txt_cutting_time_25_50.Name = "txt_cutting_time_25_50"
        Me.txt_cutting_time_25_50.Size = New System.Drawing.Size(100, 22)
        Me.txt_cutting_time_25_50.TabIndex = 7
        '
        'txt_cutting_time_1_25
        '
        Me.txt_cutting_time_1_25.Location = New System.Drawing.Point(210, 68)
        Me.txt_cutting_time_1_25.Name = "txt_cutting_time_1_25"
        Me.txt_cutting_time_1_25.Size = New System.Drawing.Size(100, 22)
        Me.txt_cutting_time_1_25.TabIndex = 6
        '
        'label_time_1_25
        '
        Me.label_time_1_25.AutoSize = True
        Me.label_time_1_25.Location = New System.Drawing.Point(144, 57)
        Me.label_time_1_25.Name = "label_time_1_25"
        Me.label_time_1_25.Size = New System.Drawing.Size(0, 16)
        Me.label_time_1_25.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(132, 71)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 16)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "1% to 25%:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(125, 96)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(79, 16)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "26% to 50%:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(125, 122)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 16)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "51% to 75%:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(118, 147)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(86, 16)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "76% to 100%:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(94, 41)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(262, 16)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Cutting Time (By Laser Power Percentage):"
        '
        'Data_Base_Plataform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1107, 485)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Data_Base_Plataform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Program Definitions"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView_Users, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.datagridview_log, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataserverDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btn_delete As Button
    Friend WithEvents txt_name As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_insert As Button
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents DataserverDataSetBindingSource As BindingSource
    Friend WithEvents txt_comments As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_password As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_username As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView_Users As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents combobox_names As ComboBox
    Friend WithEvents btn_modify As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents datagridview_log As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents combobox_names_log As ComboBox
    Friend WithEvents btn_update_log As Button
    Friend WithEvents btn_clear_log As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents label_time_1_25 As Label
    Friend WithEvents txt_cutting_time_75_100 As TextBox
    Friend WithEvents txt_cutting_time_50_75 As TextBox
    Friend WithEvents txt_cutting_time_25_50 As TextBox
    Friend WithEvents txt_cutting_time_1_25 As TextBox
    Friend WithEvents btn_reset_laser_time As Button
    Friend WithEvents txt_offline_laser As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents txt_cutting_time_milling As TextBox
End Class
