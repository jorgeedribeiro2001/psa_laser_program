<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class selecao_modo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.btn_login_guest = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.checkbox_laser = New System.Windows.Forms.CheckBox()
        Me.checkbox_milling = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_incorrectlogin = New System.Windows.Forms.Label()
        Me.combobox_user = New System.Windows.Forms.ComboBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.btn_definitions = New System.Windows.Forms.Button()
        Me.btn_webcam = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(39, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(42, 117)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_password.Size = New System.Drawing.Size(162, 22)
        Me.txt_password.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'btn_login
        '
        Me.btn_login.Location = New System.Drawing.Point(42, 182)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(162, 35)
        Me.btn_login.TabIndex = 4
        Me.btn_login.Text = "Log In"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'btn_login_guest
        '
        Me.btn_login_guest.Location = New System.Drawing.Point(42, 223)
        Me.btn_login_guest.Name = "btn_login_guest"
        Me.btn_login_guest.Size = New System.Drawing.Size(162, 35)
        Me.btn_login_guest.TabIndex = 5
        Me.btn_login_guest.Text = "Log In As Guest"
        Me.btn_login_guest.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(262, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Select Machine:"
        '
        'checkbox_laser
        '
        Me.checkbox_laser.AutoSize = True
        Me.checkbox_laser.Location = New System.Drawing.Point(265, 43)
        Me.checkbox_laser.Name = "checkbox_laser"
        Me.checkbox_laser.Size = New System.Drawing.Size(117, 20)
        Me.checkbox_laser.TabIndex = 7
        Me.checkbox_laser.Text = "Laser Machine"
        Me.checkbox_laser.UseVisualStyleBackColor = True
        '
        'checkbox_milling
        '
        Me.checkbox_milling.AutoSize = True
        Me.checkbox_milling.Location = New System.Drawing.Point(265, 69)
        Me.checkbox_milling.Name = "checkbox_milling"
        Me.checkbox_milling.Size = New System.Drawing.Size(152, 20)
        Me.checkbox_milling.TabIndex = 8
        Me.checkbox_milling.Text = "Milling CNC Machine"
        Me.checkbox_milling.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "User Authentication"
        '
        'txt_incorrectlogin
        '
        Me.txt_incorrectlogin.AutoSize = True
        Me.txt_incorrectlogin.ForeColor = System.Drawing.Color.Red
        Me.txt_incorrectlogin.Location = New System.Drawing.Point(39, 151)
        Me.txt_incorrectlogin.Name = "txt_incorrectlogin"
        Me.txt_incorrectlogin.Size = New System.Drawing.Size(100, 16)
        Me.txt_incorrectlogin.TabIndex = 10
        Me.txt_incorrectlogin.Text = "Incorrect Login!!"
        '
        'combobox_user
        '
        Me.combobox_user.FormattingEnabled = True
        Me.combobox_user.Location = New System.Drawing.Point(42, 65)
        Me.combobox_user.Name = "combobox_user"
        Me.combobox_user.Size = New System.Drawing.Size(162, 24)
        Me.combobox_user.TabIndex = 11
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'btn_definitions
        '
        Me.btn_definitions.Location = New System.Drawing.Point(265, 223)
        Me.btn_definitions.Name = "btn_definitions"
        Me.btn_definitions.Size = New System.Drawing.Size(162, 35)
        Me.btn_definitions.TabIndex = 12
        Me.btn_definitions.Text = "Definitions"
        Me.btn_definitions.UseVisualStyleBackColor = True
        '
        'btn_webcam
        '
        Me.btn_webcam.Location = New System.Drawing.Point(265, 182)
        Me.btn_webcam.Name = "btn_webcam"
        Me.btn_webcam.Size = New System.Drawing.Size(162, 35)
        Me.btn_webcam.TabIndex = 13
        Me.btn_webcam.Text = "Live Webcam"
        Me.btn_webcam.UseVisualStyleBackColor = True
        '
        'selecao_modo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 269)
        Me.Controls.Add(Me.btn_webcam)
        Me.Controls.Add(Me.btn_definitions)
        Me.Controls.Add(Me.combobox_user)
        Me.Controls.Add(Me.txt_incorrectlogin)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.checkbox_milling)
        Me.Controls.Add(Me.checkbox_laser)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_login_guest)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "selecao_modo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Profile Selection"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_password As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_login As Button
    Friend WithEvents btn_login_guest As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents checkbox_laser As CheckBox
    Friend WithEvents checkbox_milling As CheckBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_incorrectlogin As Label
    Friend WithEvents combobox_user As ComboBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btn_definitions As Button
    Friend WithEvents btn_webcam As Button
End Class
