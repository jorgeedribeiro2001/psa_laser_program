Imports Mach4
Imports System.IO



Public Class Form_milling



    Public mach As Mach4.IMach4
    Public scriptObject As Mach4.IMyScriptObject

    Public OK As Boolean

    'conecçao com Mach3
    Private Sub GetMachIntance()

        Try

            mach = GetObject(, "Mach4.Document")
            scriptObject = mach.GetScriptDispatch()

        Catch ex As Exception

            mach = Nothing
            scriptObject = Nothing

        End Try


    End Sub


    'funçao de segurança
    Private Sub EverythingOK()

        '     If Not IsNumeric(tx_asize.Text) Then
        '     MsgBox(Prompt:="The input must be numeric and the decimal signal must be "",""")
        '     OK = False
        '      ElseIf Not IsNumeric(tx_bsize.Text) Then
        '     MsgBox(Prompt:="The input must be numeric and the decimal signal must be "",""")
        '     OK = False
        '     ElseIf Not IsNumeric(tx_rsize.Text) Then
        '    MsgBox(Prompt:="The input must be numeric and the decimal signal must be "",""")
        '     OK = False
        '    ElseIf Not IsNumeric(tx_depth.Text) Then
        '    MsgBox(Prompt:="The input must be numeric and the decimal signal must be "",""")
        '   OK = False
        '  ElseIf Not IsNumeric(tx_edge.Text) Then
        '     MsgBox(Prompt:="The input must be numeric and the decimal signal must be "",""")
        '    OK = False
        '   ElseIf Not IsNumeric(tx_feedratecut.Text) Then
        '  MsgBox(Prompt:="The input must be numeric and the decimal signal must be "",""")
        '     OK = False
        '     ElseIf Not IsNumeric(tx_feedrateholes.Text) Then
        '    MsgBox(Prompt:="The input must be numeric and the decimal signal must be "",""")
        '   OK = False
        '  Else
        OK = True
        '  End If


    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetMachIntance()
        timer_Refresh.Enabled = True
        timer_update_position.Enabled = True
        timer_interface.Enabled = True

        If ch_Extract.CheckState = False Then

            ch_fillet.Visible = False

        Else

            ch_fillet.Visible = True

        End If


        If ch_fillet.CheckState = False Then

            label_raiocanto.Visible = False
            tx_rsize.Visible = False
            Label13.Visible = False

        Else

            label_raiocanto.Visible = True
            tx_rsize.Visible = True
            Label13.Visible = True

        End If

        'default values

        tx_edge.Text = My.Settings.TextBoxEdge
        tx_feedratecut.Text = My.Settings.TextBoxFeedCut
        tx_depth.Text = My.Settings.TextBoxDepth
        tx_feedrateholes.Text = My.Settings.TextBoxFeedHole
        tx_rsize.Text = My.Settings.TextBoxCorner
        tx_depthcut.Text = My.Settings.TextBoxDepthCut
        tx_asize.Text = My.Settings.TextBoxLen
        tx_bsize.Text = My.Settings.TextBoxWid



    End Sub


    'Timers ||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

    'Timer de leds de reset, start e spindle
    Private Sub timer_Refresh_Tick(sender As Object, e As EventArgs) Handles timer_Refresh.Tick


        If scriptObject.GetOEMLed(164) = True Then
            btn_spindle.BackColor = Color.Green
            btn_spindle.Text = "Turn Spindle Off"
        Else
            btn_spindle.BackColor = Color.White
            btn_spindle.Text = "Turn Spindle On"
        End If

        'Nota: Led do Start estão embutidos no contador_tempo

        If scriptObject.GetOEMLed(800) = False Then
            btn_reset.BackColor = Color.Green
            btn_reset.Text = "ENGAGED"
        Else
            btn_reset.BackColor = Color.DarkRed
            btn_reset.Text = "DESENGAGED"
        End If


    End Sub

    'Timer atualizaçao da posiçao atua da fresa
    Private Sub timer_update_position_Tick(sender As Object, e As EventArgs) Handles timer_update_position.Tick

        Dim positionx As Double
        Dim positiony As Double
        Dim positionz As Double

        Dim aux As String


        aux = scriptObject.GetABSPostion(0)


        positionx = scriptObject.GetOEMDRO(800).ToString()


        positiony = scriptObject.GetOEMDRO(801).ToString()
        positionz = scriptObject.GetOEMDRO(802).ToString()

        positionx = Math.Round(positionx, 3)
        positiony = Math.Round(positiony, 3)
        positionz = Math.Round(positionz, 3)

        tx_x.Text = CStr(positionx)
        tx_y.Text = CStr(positiony)
        tx_z.Text = CStr(positionz)

        scriptObject.SetSpinSpeed(trackbar_spindle.Value)
        label_value.Text = scriptObject.GetRPM()

    End Sub

    'Timer atualizaçao da interface gráfica
    Private Sub timer_interface_Tick(sender As Object, e As EventArgs) Handles timer_interface.Tick


        If ((ch_Extract.Checked = True) And (ch_ucut.Checked = True)) Then

            ch_Extract.CheckState = False

        ElseIf ((ch_ucut.Checked = True) And (ch_Extract.Checked = True)) Then

            ch_ucut.CheckState = False

        End If


        If ((ch_fillet.Checked = True) And (ch_Extract.Checked = True) And (ch_holes1.Checked = True) And (ch_holes2.Checked = True)) Then

            PictureBox1.Image = My.Resources.Corte_Extract_Cem_cantosmeios

        ElseIf ((ch_fillet.Checked = True) And (ch_Extract.Checked = True) And (ch_holes1.Checked = True) And (ch_holes2.Checked = False)) Then

            PictureBox1.Image = My.Resources.Corte_Extract_Cem_cantos

        ElseIf ((ch_fillet.Checked = True) And (ch_Extract.Checked = True) And (ch_holes1.Checked = False) And (ch_holes2.Checked = False)) Then

            PictureBox1.Image = My.Resources.Corte_Extract_Cem

        ElseIf ((ch_fillet.Checked = False) And (ch_Extract.Checked = True) And (ch_holes1.Checked = False) And (ch_holes2.Checked = False)) Then

            PictureBox1.Image = My.Resources.Corte_Extract_Sem

        ElseIf ((ch_fillet.Checked = False) And (ch_Extract.Checked = True) And (ch_holes1.Checked = True) And (ch_holes2.Checked = False)) Then

            PictureBox1.Image = My.Resources.Corte_Extract_Sem_cantos

        ElseIf ((ch_fillet.Checked = False) And (ch_Extract.Checked = True) And (ch_holes1.Checked = True) And (ch_holes2.Checked = True)) Then

            PictureBox1.Image = My.Resources.Corte_Extract_Sem_cantosmeios

        ElseIf ((ch_fillet.Checked = False) And (ch_Extract.Checked = False) And (ch_holes1.Checked = True) And (ch_holes2.Checked = True) And (ch_ucut.Checked = False)) Then

            PictureBox1.Image = My.Resources.Corte_Sem_cantosmeios

        ElseIf ((ch_fillet.Checked = False) And (ch_Extract.Checked = False) And (ch_holes1.Checked = True) And (ch_holes2.Checked = False) And (ch_ucut.Checked = False)) Then

            PictureBox1.Image = My.Resources.Corte_Sem_cantos

        ElseIf ((ch_fillet.Checked = False) And (ch_Extract.Checked = False) And (ch_holes1.Checked = False) And (ch_holes2.Checked = False) And (ch_ucut.Checked = False)) Then

            PictureBox1.Image = My.Resources.Corte_Sem

        ElseIf ((ch_fillet.Checked = False) And (ch_Extract.Checked = False) And (ch_holes1.Checked = False) And (ch_holes2.Checked = True) And (ch_ucut.Checked = False)) Then

            PictureBox1.Image = My.Resources.Corte_Sem_meios

        ElseIf ((ch_fillet.Checked = True) And (ch_Extract.Checked = True) And (ch_holes1.Checked = False) And (ch_holes2.Checked = True)) Then

            PictureBox1.Image = My.Resources.Corte_Extract_Cem_meios

        ElseIf ((ch_fillet.Checked = False) And (ch_Extract.Checked = True) And (ch_holes1.Checked = False) And (ch_holes2.Checked = True)) Then

            PictureBox1.Image = My.Resources.Corte_Extract_Sem_meios

        ElseIf ((ch_ucut.Checked = True) And (ch_holes1.Checked = False) And (ch_holes2.Checked = False)) Then

            PictureBox1.Image = My.Resources.Corte_U_Sem

        ElseIf ((ch_ucut.Checked = True) And (ch_holes1.Checked = True) And (ch_holes2.Checked = False)) Then

            PictureBox1.Image = My.Resources.Corte_U_Sem_cantos

        ElseIf ((ch_ucut.Checked = True) And (ch_holes1.Checked = True) And (ch_holes2.Checked = True)) Then

            PictureBox1.Image = My.Resources.Corte_U_Sem_cantosmeios

        ElseIf ((ch_ucut.Checked = True) And (ch_holes1.Checked = False) And (ch_holes2.Checked = True)) Then

            PictureBox1.Image = My.Resources.Corte_U_Sem_meios

        End If


    End Sub

    Private Sub contador_tempo_Tick(sender As Object, e As EventArgs) Handles contador_tempo.Tick

        If scriptObject.GetOEMLed(804) = True Then
            btn_start.BackColor = Color.Green
            cutting_time_milling = cutting_time_milling + 1

        Else
            btn_start.BackColor = Color.White
        End If

    End Sub




    'Buttons |||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||


    Private Sub btn_config_Click(sender As Object, e As EventArgs) Handles btn_config.Click

        'save configurations
        My.Settings.TextBoxDepth = tx_depth.Text
        My.Settings.TextBoxEdge = tx_edge.Text
        My.Settings.TextBoxFeedCut = tx_feedratecut.Text
        My.Settings.TextBoxDepth = tx_depth.Text
        My.Settings.TextBoxFeedHole = tx_feedrateholes.Text
        My.Settings.TextBoxCorner = tx_rsize.Text
        My.Settings.TextBoxDepthCut = tx_depthcut.Text
        My.Settings.TextBoxLen = tx_asize.Text
        My.Settings.TextBoxWid = tx_bsize.Text


    End Sub


    'enviar gcode manual por linha
    Private Sub btn_MDI_Click(sender As Object, e As EventArgs) Handles btn_MDI.Click

        GetMachIntance()

        scriptObject.Code(tx_MDI.Text.Trim)

        log_register(active_user, "User Send a MDI to Milling Machine with the Line:" + tx_MDI.Text)

    End Sub




    'posiçao manual do MPG
    'posiçao manual do MPG
    Private Sub btn_xmais_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_xmais.MouseDown
        scriptObject.DoOEMButton(307)
    End Sub

    Private Sub btn_xmais_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_xmais.MouseUp
        scriptObject.DoOEMButton(334)
        log_register(active_user, "User moved Axis X Positive with the Manual Button")
    End Sub

    Private Sub btn_xmenos_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_xmenos.MouseUp

        scriptObject.DoOEMButton(334)
        log_register(active_user, "User moved Axis X Negative with the Manual Button")

    End Sub

    Private Sub btn_xmenos_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_xmenos.MouseDown

        scriptObject.DoOEMButton(308)

    End Sub

    '----------------
    Private Sub btn_ymais_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_ymais.MouseDown

        scriptObject.DoOEMButton(309)

    End Sub

    Private Sub btn_ymais_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_ymais.MouseUp

        scriptObject.DoOEMButton(335)
        log_register(active_user, "User moved Axis Y Positive with the Manual Button")

    End Sub

    Private Sub btn_ymenos_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_ymenos.MouseUp

        scriptObject.DoOEMButton(335)
        log_register(active_user, "User moved Axis Y Negative with the Manual Button")

    End Sub

    Private Sub btn_ymenos_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_ymenos.MouseDown

        scriptObject.DoOEMButton(310)

    End Sub
    '----------------------------------
    Private Sub btn_zmais_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_zmais.MouseDown

        scriptObject.DoOEMButton(311)

    End Sub

    Private Sub btn_zmais_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_zmais.MouseUp

        scriptObject.DoOEMButton(336)
        log_register(active_user, "User moved Axis Z Positive with the Manual Button")

    End Sub

    Private Sub btn_zmenos_MouseUp(sender As Object, e As MouseEventArgs) Handles btn_zmenos.MouseUp

        scriptObject.DoOEMButton(336)
        log_register(active_user, "User moved Axis Z Negative with the Manual Button")

    End Sub

    Private Sub btn_zmenos_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_zmenos.MouseDown

        scriptObject.DoOEMButton(312)

    End Sub




    'inicio, stop e fim de pograma + reset
    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click

        scriptObject.DoOEMButton(1000)
        log_register(active_user, "User Started the Program")

    End Sub

    Private Sub btn_feedhold_Click(sender As Object, e As EventArgs) Handles btn_feedhold.Click

        scriptObject.DoOEMButton(1001)
        log_register(active_user, "User Feedholded the Program on Running")


    End Sub

    Private Sub btn_stop_Click(sender As Object, e As EventArgs) Handles btn_stop.Click

        scriptObject.DoOEMButton(1003)

        'segurança para o motion card STB4100
        trackbar_spindle.Value = 0

        log_register(active_user, "User Stopped the Program on Running ")

    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click

        scriptObject.DoOEMButton(1021)

    End Sub




    'zerar a maquina de acordo com a peça
    Private Sub btn_zerox_Click(sender As Object, e As EventArgs) Handles btn_zerox.Click

        scriptObject.DoOEMButton(1008)
        scriptObject.SetMachZero(0)
        log_register(active_user, "User Defined the Axis X Position equal a Zero ")


    End Sub

    Private Sub btn_zeroy_Click(sender As Object, e As EventArgs) Handles btn_zeroy.Click

        scriptObject.DoOEMButton(1009)
        scriptObject.SetMachZero(1)
        log_register(active_user, "User Defined the Axis Y Position equal a Zero ")

    End Sub

    Private Sub btn_zeroz_Click(sender As Object, e As EventArgs) Handles btn_zeroz.Click

        scriptObject.DoOEMButton(1010)
        scriptObject.SetMachZero(2)


        scriptObject.Sleep(1000)

        GetMachIntance()

        scriptObject.Code("G00 Z5.0")

        log_register(active_user, "User Defined the Axis Z Position equal a Zero ")

    End Sub




    'botao de muda de fresa
    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click

        GetMachIntance()

        scriptObject.Code("G28")

        log_register(active_user, "User Moved to Machine Position")

    End Sub



    Private Sub btn_Gotozero_Click(sender As Object, e As EventArgs) Handles btn_Gotozero.Click

        GetMachIntance()

        scriptObject.Code("G00 X0.0 Y0.0 Z0.0")

        log_register(active_user, "User Moved to the User Center Position")

    End Sub



    Private Sub btn_spindle_Click(sender As Object, e As EventArgs) Handles btn_spindle.Click

        scriptObject.DoSpinCW()

        log_register(active_user, "User Started Manually the Spindle at rotation " + trackbar_spindle.Value + "rpm")

        If btn_spindle.BackColor = Color.Green Then

            scriptObject.DoSpinStop()
            trackbar_spindle.Value = 0

        End If

    End Sub


    'carregar gcode exterior
    Private Sub btn_LoadGcode_Click(sender As Object, e As EventArgs) Handles btn_LoadGcode.Click


        If OpenFileDialog1.ShowDialog = DialogResult.OK Then


            tx_Gcode.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)

        End If

        Dim path_file As String

        path_file = System.IO.Path.GetFullPath(OpenFileDialog1.FileName)

        'Carrega automáticamente 
        scriptObject.LoadFile(path_file)

        scriptObject.DoOEMButton(216) '1003)

        log_register(active_user, "User Loaded a G-Code Program Externally")


    End Sub



    'jog
    Private Sub btn_jogmais_Click(sender As Object, e As EventArgs) Handles btn_jogmais.Click
        scriptObject.DoOEMButton(111)
        tx_jog.Text = scriptObject.GetOEMDRO(3)
    End Sub

    Private Sub btn_jogmenos_Click(sender As Object, e As EventArgs) Handles btn_jogmenos.Click
        scriptObject.DoOEMButton(112)
        tx_jog.Text = scriptObject.GetOEMDRO(3)
    End Sub



    'botao que gera o algoritmo de gcode
    Private Sub btn_Gcode_Click(sender As Object, e As EventArgs) Handles btn_Gcode.Click


        EverythingOK()

        If OK = True Then

            'fecha o codigo aberto
            scriptObject.DoOEMButton(169)


            Dim a As String
            Dim b As String
            Dim r As String
            Dim feedrate_cut As String
            Dim feedrate_holes As String
            Dim profundidadecorte As String

            Dim bordo As String
            Dim profundidade As String
            Dim tipo_1 As String
            Dim tipo_2 As String


            a = tx_asize.Text
            b = tx_bsize.Text
            feedrate_cut = tx_feedratecut.Text
            feedrate_holes = tx_feedrateholes.Text
            profundidadecorte = tx_depthcut.Text

            Dim header As String
            Dim cut As String
            Dim footer As String

            'cabeçalho
            header = "(Progam1)" + vbCrLf +
                     "G90 G94 G91.1 G40 G49 G17 G21" + vbCrLf +
                     "G00 Z5.0" + vbCrLf +
                     "X0.0 Y0.0"



            'corte da placa
            If ((ch_fillet.Checked = False) And (ch_Extract.Checked = False) And (ch_ucut.Checked = False)) Then

                'sem raio de canto
                cut = "G00 X-40.0" + vbCrLf +
                      "G00 Y" + b + vbCrLf +
                      "G01 Z-" + profundidadecorte + " F" + feedrate_cut + vbCrLf +
                      "X" + a + vbCrLf +
                      "Y0.0" + vbCrLf +
                      "G00 Z5.0"

            ElseIf ((ch_fillet.Checked = False) And (ch_Extract.Checked = False) And (ch_ucut.Checked = True)) Then

                'ucut sem raio de canto 
                cut = "G00 Y-40.0" + vbCrLf +
                      "G01 Z-" + profundidadecorte + " F" + feedrate_cut + vbCrLf +
                      "Y" + b + vbCrLf +
                      "Z5.0" + vbCrLf +
                      "G00 X" + a + vbCrLf +
                      "G01 Z-" + profundidadecorte + " F" + feedrate_cut + vbCrLf +
                      "Y0.0" + vbCrLf +
                      "X0.0" + vbCrLf +
                      "G00 Z5.0"

            ElseIf ((ch_fillet.Checked = False) And (ch_Extract.Checked = True) And (ch_ucut.Checked = False)) Then

                'Extract sem raio de canto 
                cut = "G00 Y-40.0" + vbCrLf +
                      "G01 Z-" + profundidadecorte + " F" + feedrate_cut + vbCrLf +
                      "Y" + b + vbCrLf +
                      "X" + a + vbCrLf +
                      "Y0.0" + vbCrLf +
                      "X0.0" + vbCrLf +
                      "G00 Z5.0"


            ElseIf ((ch_fillet.Checked = True) And (ch_Extract.Checked = True) And (ch_ucut.Checked = False)) Then

                r = tx_rsize.Text

                'Extract com raio de canto
                cut = "G00 X-40.0" + vbCrLf +
                       "G01 Z-" + profundidadecorte + " F" + feedrate_cut + vbCrLf +
                       "X" + CStr(CDbl(a) - CDbl(r)) + vbCrLf +
                       "G03 Y" + r + " X" + a + " I0.0" + " J " + r + " F" + feedrate_cut + vbCrLf +
                       "G01 Y" + CStr(CDbl(b) - CDbl(r)) + vbCrLf +
                       "G03 Y" + b + " X" + CStr(CDbl(a) - CDbl(r)) + " I-" + r + " J0.0" + " F" + feedrate_cut + vbCrLf +
                       "G01 X" + r + vbCrLf +
                       "G03 Y" + CStr(CDbl(b) - CDbl(r)) + " X0.0" + " I0.0" + " J-" + r + " F" + feedrate_cut + vbCrLf +
                       "G01 Y" + r + vbCrLf +
                       "G03 Y0.0" + " X" + r + " I" + r + " J0.0" + " F" + feedrate_cut + vbCrLf +
                       "G00 Z5.0"

            End If



            'furos
            bordo = tx_edge.Text
            profundidade = tx_depth.Text

            If (ch_holes1.Checked = True) Then
                'furos cantos
                tipo_1 = "G00 X" + bordo + " Y" + bordo + vbCrLf +
                     "G81 Z-" + profundidade + " R5.0" + " F" + feedrate_holes + vbCrLf +
                     "Y" + CStr(CDbl(b) - CDbl(bordo)) + vbCrLf +
                     "X" + CStr(CDbl(a) - CDbl(bordo)) + vbCrLf +
                     "Y" + bordo + vbCrLf +
                     "G80" + vbCrLf +
                     "G00 Z5.0" + vbCrLf +
                     "X0.0 Y0.0"
            End If

            If ch_holes2.Checked = True Then
                'furos meios
                tipo_2 = "G00 X" + bordo + " Y" + CStr(CDbl(b) / 2) + vbCrLf +
                         "G81 Z-" + profundidade + " R5.0" + " F" + feedrate_holes + vbCrLf +
                         "X" + CStr(CDbl(a) / 2) + " Y" + CStr(CDbl(b) - CDbl(bordo)) + vbCrLf +
                         "X" + CStr(CDbl(a) - CDbl(bordo)) + " Y" + CStr(CDbl(b) / 2) + vbCrLf +
                         "X" + CStr(CDbl(a) / 2) + " Y" + bordo + vbCrLf +
                         "G80" + vbCrLf +
                         "G00 Z5.0" + vbCrLf +
                         "X0.0 Y0.0"
            End If


            'rodapé
            footer = "G00 X0.0 Y0.0" + vbCrLf +
                         "M30"


            If ((ch_holes1.Checked = True) And (ch_holes2.Checked = False)) Then

                tx_Gcode.Text = header + vbCrLf + cut + vbCrLf + tipo_1 + vbCrLf + footer

            ElseIf ((ch_holes1.Checked = False) And (ch_holes2.Checked = True)) Then

                tx_Gcode.Text = header + vbCrLf + cut + vbCrLf + tipo_2 + vbCrLf + footer

            ElseIf ((ch_holes1.Checked = True) And (ch_holes2.Checked = True)) Then

                tx_Gcode.Text = header + vbCrLf + cut + vbCrLf + tipo_1 + vbCrLf + tipo_2 + vbCrLf + footer

            Else

                tx_Gcode.Text = header + vbCrLf + cut + vbCrLf + footer

            End If




            Dim path As String = "C:\Gcode.txt"

            If Not System.IO.File.Exists("C:\Gcode.txt") Then
                System.IO.File.Create("C:\Gcode.txt").Dispose()
            End If


            'escrever o codigo criado automaticamente no ficheito txt
            System.IO.File.WriteAllText("C:\Gcode.txt", tx_Gcode.Text)

            ' Dim file As TextWriter = New StreamWriter(path)

            ' file.Write(tx_Gcode.Text)

            ' file.Close()

            'Carrega automáticamente 
            scriptObject.LoadFile(path)

            scriptObject.DoOEMButton(216) '1003)
        End If

        log_register(active_user, "User Generated a Program")

    End Sub




    '|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||






    'checkbox fillet
    Private Sub ch_admitir_CheckedChanged(sender As Object, e As EventArgs) Handles ch_fillet.CheckedChanged

        If ch_fillet.CheckState = False Then

            label_raiocanto.Visible = False
            tx_rsize.Visible = False
            Label13.Visible = False

        Else

            label_raiocanto.Visible = True
            tx_rsize.Visible = True
            Label13.Visible = True
        End If


    End Sub

    'checkbox de extaçao completa
    Private Sub ch_Extract_CheckedChanged(sender As Object, e As EventArgs) Handles ch_Extract.CheckedChanged

        If ch_Extract.CheckState = False Then

            ch_fillet.Visible = False
            ch_fillet.CheckState = False

        Else

            ch_fillet.Visible = True

        End If

    End Sub

    Private Sub btn_livewebcam_Click(sender As Object, e As EventArgs) Handles btn_livewebcam.Click
        log_register(active_user, "User started Live Webcam")
        form_camara.Show()
    End Sub
End Class


