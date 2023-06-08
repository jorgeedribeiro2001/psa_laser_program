Imports AForge.Video
Imports AForge.Video.DirectShow
Public Class form_camara
    Private _filterInfoCollection As FilterInfoCollection
    Private _videoCaptureDevice As VideoCaptureDevice

    Public Sub New()
        InitializeComponent()
        _filterInfoCollection = New FilterInfoCollection(FilterCategory.VideoInputDevice)
        For Each filterInfo As FilterInfo In _filterInfoCollection
            cmbCameras.Items.Add(filterInfo.Name)
        Next
        cmbCameras.SelectedIndex = 0
        _videoCaptureDevice = New VideoCaptureDevice()
    End Sub

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        _videoCaptureDevice = New VideoCaptureDevice(_filterInfoCollection(cmbCameras.SelectedIndex).MonikerString)
        AddHandler _videoCaptureDevice.NewFrame, AddressOf VideoCaptureDevice_NewFrame
        _videoCaptureDevice.Start()
    End Sub

    Private Sub VideoCaptureDevice_NewFrame(sender As Object, e As NewFrameEventArgs)
        pictCamImagem.Image = DirectCast(e.Frame.Clone(), Bitmap)
    End Sub

    Private Sub btnEncerrar_Click(sender As Object, e As EventArgs) Handles btnEncerrar.Click
        Encerrar()
        DisplayWhiteImage()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Encerrar()
    End Sub

    Private Sub Encerrar()
        If Not (_videoCaptureDevice Is Nothing) Then
            If _videoCaptureDevice.IsRunning Then
                RemoveHandler _videoCaptureDevice.NewFrame, AddressOf VideoCaptureDevice_NewFrame
                _videoCaptureDevice.SignalToStop()
                _videoCaptureDevice = Nothing
            End If
        End If
    End Sub

    Private Sub cmbCameras_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCameras.SelectedIndexChanged
        Encerrar()
        DisplayWhiteImage()
    End Sub

    Private Sub DisplayWhiteImage()
        Dim whiteImage As New Bitmap(pictCamImagem.Width, pictCamImagem.Height)
        Using g As Graphics = Graphics.FromImage(whiteImage)
            g.FillRectangle(Brushes.White, 0, 0, whiteImage.Width, whiteImage.Height)
        End Using
        pictCamImagem.Image = whiteImage
    End Sub

    Private Sub Form_camara_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayWhiteImage()
    End Sub

    Private Sub btn_capture_Click(sender As Object, e As EventArgs) Handles btn_capture.Click
        If Not (_videoCaptureDevice Is Nothing) Then
            ' Take a snapshot of the current frame
            Dim snapshot As Bitmap = DirectCast(pictCamImagem.Image.Clone(), Bitmap)

            ' Display a SaveFileDialog to choose the save location and filename
            Using dialog As New SaveFileDialog()
                dialog.Filter = "JPEG Image|*.jpg"
                dialog.Title = "Save Screenshot"
                dialog.DefaultExt = "jpg"
                dialog.AddExtension = True

                If dialog.ShowDialog() = DialogResult.OK Then
                    ' Save the snapshot as a JPEG image
                    snapshot.Save(dialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
                    log_register(active_user, "User has captured a Picture in the Live Webcam")
                    MessageBox.Show("Screenshot saved successfully.")
                End If
            End Using
        Else
            MessageBox.Show("Please start the camera before taking a screenshot.")
        End If
    End Sub
End Class