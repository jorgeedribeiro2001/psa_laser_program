<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_camara
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
        Me.pictCamImagem = New System.Windows.Forms.PictureBox()
        Me.cmbCameras = New System.Windows.Forms.ComboBox()
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.btnEncerrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_capture = New System.Windows.Forms.Button()
        CType(Me.pictCamImagem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pictCamImagem
        '
        Me.pictCamImagem.Location = New System.Drawing.Point(12, 36)
        Me.pictCamImagem.Name = "pictCamImagem"
        Me.pictCamImagem.Size = New System.Drawing.Size(776, 388)
        Me.pictCamImagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictCamImagem.TabIndex = 0
        Me.pictCamImagem.TabStop = False
        '
        'cmbCameras
        '
        Me.cmbCameras.FormattingEnabled = True
        Me.cmbCameras.Location = New System.Drawing.Point(126, 6)
        Me.cmbCameras.Name = "cmbCameras"
        Me.cmbCameras.Size = New System.Drawing.Size(305, 24)
        Me.cmbCameras.TabIndex = 1
        '
        'btnIniciar
        '
        Me.btnIniciar.Location = New System.Drawing.Point(530, 443)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(126, 31)
        Me.btnIniciar.TabIndex = 2
        Me.btnIniciar.Text = "Turn On"
        Me.btnIniciar.UseVisualStyleBackColor = True
        '
        'btnEncerrar
        '
        Me.btnEncerrar.Location = New System.Drawing.Point(662, 443)
        Me.btnEncerrar.Name = "btnEncerrar"
        Me.btnEncerrar.Size = New System.Drawing.Size(126, 31)
        Me.btnEncerrar.TabIndex = 3
        Me.btnEncerrar.Text = "Turn Off"
        Me.btnEncerrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Choose Camera:"
        '
        'btn_capture
        '
        Me.btn_capture.Location = New System.Drawing.Point(398, 443)
        Me.btn_capture.Name = "btn_capture"
        Me.btn_capture.Size = New System.Drawing.Size(126, 31)
        Me.btn_capture.TabIndex = 5
        Me.btn_capture.Text = "Capture"
        Me.btn_capture.UseVisualStyleBackColor = True
        '
        'form_camara
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 486)
        Me.Controls.Add(Me.btn_capture)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnEncerrar)
        Me.Controls.Add(Me.btnIniciar)
        Me.Controls.Add(Me.cmbCameras)
        Me.Controls.Add(Me.pictCamImagem)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "form_camara"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Live Webcam"
        CType(Me.pictCamImagem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pictCamImagem As PictureBox
    Friend WithEvents cmbCameras As ComboBox
    Friend WithEvents btnIniciar As Button
    Friend WithEvents btnEncerrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_capture As Button
End Class
