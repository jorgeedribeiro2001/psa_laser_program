<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class save_gcode
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
        Me.btn_save = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_program_name = New System.Windows.Forms.TextBox()
        Me.txt_project_name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.txt_program_comment = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer_interface = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btn_save
        '
        Me.btn_save.Location = New System.Drawing.Point(76, 210)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(164, 37)
        Me.btn_save.TabIndex = 0
        Me.btn_save.Text = "Save"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter Name of the Program:"
        '
        'txt_program_name
        '
        Me.txt_program_name.Location = New System.Drawing.Point(189, 22)
        Me.txt_program_name.Name = "txt_program_name"
        Me.txt_program_name.Size = New System.Drawing.Size(133, 22)
        Me.txt_program_name.TabIndex = 2
        '
        'txt_project_name
        '
        Me.txt_project_name.Location = New System.Drawing.Point(189, 59)
        Me.txt_project_name.Name = "txt_project_name"
        Me.txt_project_name.Size = New System.Drawing.Size(133, 22)
        Me.txt_project_name.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(57, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Enter Project Name:"
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(76, 253)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(164, 37)
        Me.btn_cancel.TabIndex = 5
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'txt_program_comment
        '
        Me.txt_program_comment.Location = New System.Drawing.Point(12, 116)
        Me.txt_program_comment.Multiline = True
        Me.txt_program_comment.Name = "txt_program_comment"
        Me.txt_program_comment.Size = New System.Drawing.Size(310, 82)
        Me.txt_program_comment.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Enter Comments:"
        '
        'Timer_interface
        '
        '
        'save_gcode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 307)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_program_comment)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.txt_project_name)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_program_name)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_save)
        Me.Name = "save_gcode"
        Me.Text = "Save G-Code"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_save As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txt_program_name As TextBox
    Friend WithEvents txt_project_name As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_cancel As Button
    Friend WithEvents txt_program_comment As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Timer_interface As Timer
End Class
