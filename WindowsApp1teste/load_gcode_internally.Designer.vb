<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class load_gcode_internally
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.btn_delete_filters = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.combobox_user = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.combobox_project = New System.Windows.Forms.ComboBox()
        Me.btn_apply_filters = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.combobox_names = New System.Windows.Forms.ComboBox()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.DataGridView_Programs = New System.Windows.Forms.DataGridView()
        Me.btn_load = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.timer_interface = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView_Programs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_refresh)
        Me.GroupBox1.Controls.Add(Me.btn_delete_filters)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.combobox_user)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.combobox_project)
        Me.GroupBox1.Controls.Add(Me.btn_apply_filters)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.combobox_names)
        Me.GroupBox1.Controls.Add(Me.btn_delete)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 376)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(418, 161)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filters"
        '
        'btn_refresh
        '
        Me.btn_refresh.Location = New System.Drawing.Point(273, 20)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(129, 28)
        Me.btn_refresh.TabIndex = 20
        Me.btn_refresh.Text = "Refresh"
        Me.btn_refresh.UseVisualStyleBackColor = True
        '
        'btn_delete_filters
        '
        Me.btn_delete_filters.Location = New System.Drawing.Point(273, 122)
        Me.btn_delete_filters.Name = "btn_delete_filters"
        Me.btn_delete_filters.Size = New System.Drawing.Size(129, 28)
        Me.btn_delete_filters.TabIndex = 19
        Me.btn_delete_filters.Text = "Delete Filters"
        Me.btn_delete_filters.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 16)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Choose User:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'combobox_user
        '
        Me.combobox_user.FormattingEnabled = True
        Me.combobox_user.Location = New System.Drawing.Point(132, 111)
        Me.combobox_user.Name = "combobox_user"
        Me.combobox_user.Size = New System.Drawing.Size(129, 24)
        Me.combobox_user.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 16)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Choose Project:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'combobox_project
        '
        Me.combobox_project.FormattingEnabled = True
        Me.combobox_project.Location = New System.Drawing.Point(132, 71)
        Me.combobox_project.Name = "combobox_project"
        Me.combobox_project.Size = New System.Drawing.Size(129, 24)
        Me.combobox_project.TabIndex = 15
        '
        'btn_apply_filters
        '
        Me.btn_apply_filters.Location = New System.Drawing.Point(273, 88)
        Me.btn_apply_filters.Name = "btn_apply_filters"
        Me.btn_apply_filters.Size = New System.Drawing.Size(129, 28)
        Me.btn_apply_filters.TabIndex = 14
        Me.btn_apply_filters.Text = "Apply Filters"
        Me.btn_apply_filters.UseVisualStyleBackColor = True
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
        Me.combobox_names.Location = New System.Drawing.Point(132, 31)
        Me.combobox_names.Name = "combobox_names"
        Me.combobox_names.Size = New System.Drawing.Size(129, 24)
        Me.combobox_names.TabIndex = 11
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(273, 54)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(129, 28)
        Me.btn_delete.TabIndex = 3
        Me.btn_delete.Text = "Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'DataGridView_Programs
        '
        Me.DataGridView_Programs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView_Programs.Location = New System.Drawing.Point(12, 14)
        Me.DataGridView_Programs.Name = "DataGridView_Programs"
        Me.DataGridView_Programs.RowHeadersWidth = 51
        Me.DataGridView_Programs.RowTemplate.Height = 24
        Me.DataGridView_Programs.Size = New System.Drawing.Size(868, 356)
        Me.DataGridView_Programs.TabIndex = 13
        '
        'btn_load
        '
        Me.btn_load.Location = New System.Drawing.Point(695, 459)
        Me.btn_load.Name = "btn_load"
        Me.btn_load.Size = New System.Drawing.Size(185, 36)
        Me.btn_load.TabIndex = 15
        Me.btn_load.Text = "Load Program"
        Me.btn_load.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(695, 501)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(185, 36)
        Me.btn_cancel.TabIndex = 16
        Me.btn_cancel.Text = "Cancel Load"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'timer_interface
        '
        Me.timer_interface.Enabled = True
        Me.timer_interface.Interval = 500
        '
        'load_gcode_internally
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 549)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_load)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView_Programs)
        Me.Name = "load_gcode_internally"
        Me.Text = "Load G-Code Internally"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView_Programs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btn_delete_filters As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents combobox_user As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents combobox_project As ComboBox
    Friend WithEvents btn_apply_filters As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents combobox_names As ComboBox
    Friend WithEvents btn_delete As Button
    Friend WithEvents DataGridView_Programs As DataGridView
    Friend WithEvents btn_load As Button
    Friend WithEvents btn_cancel As Button
    Friend WithEvents timer_interface As Timer
    Friend WithEvents btn_refresh As Button
End Class
