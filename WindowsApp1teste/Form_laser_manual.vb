Imports System.Reflection.Emit
Imports Mach4
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form_laser_manual


    Public mach As Mach4.IMach4
    Public scriptObject As Mach4.IMyScriptObject

    Public OK As Boolean
    Public verific2 As Boolean

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


    Private Sub Form_laser_manual_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ManualToolStripMenuItem.Checked = True
        AutomaticGcodeToolStripMenuItem.Checked = False


        GetMachIntance()
        timer_Refresh.Enabled = True
        timer_update_position.Enabled = True

        btnMais.Enabled = False
        btnMenos.Enabled = False

    End Sub


    'Timers ||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

    'Timer de leds de reset, start e spindle
    Private Sub timer_Refresh_Tick(sender As Object, e As EventArgs) Handles timer_Refresh.Tick
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
        Dim positionfocus As Double


        Dim aux As String

        aux = scriptObject.GetABSPostion(0)


        positionx = scriptObject.GetOEMDRO(800).ToString()
        positiony = scriptObject.GetOEMDRO(801).ToString()
        positionz = scriptObject.GetOEMDRO(802).ToString()
        positionfocus = scriptObject.GetOEMDRO(803).ToString()


        positionx = Math.Round(positionx, 3)
        positiony = Math.Round(positiony, 3)
        positionz = Math.Round(positionz, 3)
        positionfocus = Math.Round(positionfocus, 3)

        tx_x.Text = CStr(positionx)
        tx_y.Text = CStr(positiony)
        tx_z.Text = CStr(positionz)
        txt_Infoco.Text = CStr(positionfocus)

        scriptObject.SetSpinSpeed(trackbar_spindle.Value)

        If positionfocus >= 22 Then
            btnMais.Enabled = False
        ElseIf verific2 = True Then
            btnMais.Enabled = True
        End If

        If positionfocus <= 0 And verific2 = True Then
            btnMenos.Enabled = False
        ElseIf verific2 = True Then
            btnMenos.Enabled = True
        End If


    End Sub

    'Buttons |||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

    'enviar gcode manual por linha
    Private Sub btn_MDI_Click(sender As Object, e As EventArgs) Handles btn_MDI.Click

        GetMachIntance()
        scriptObject.Code(tx_MDI.Text.Trim)
        log_register(active_user, "User Send a MDI to Laser Cutting Machine with the Line:" + tx_MDI.Text)

    End Sub

    'posiçao manual do MPG
    Private Sub btn_xmais_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_xmais.MouseDown
        scriptObject.DoOEMButton(276) 'Altera o modo para cont
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
        scriptObject.DoOEMButton(276) 'Altera o modo para cont
        scriptObject.DoOEMButton(308)

    End Sub

    '----------------
    Private Sub btn_ymais_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_ymais.MouseDown
        scriptObject.DoOEMButton(276) 'Altera o modo para cont
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
        scriptObject.DoOEMButton(276) 'Altera o modo para cont
        scriptObject.DoOEMButton(310)

    End Sub
    '----------------------------------
    Private Sub btn_zmais_MouseDown(sender As Object, e As MouseEventArgs) Handles btn_zmais.MouseDown
        scriptObject.DoOEMButton(276) 'Altera o modo para cont
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
        scriptObject.DoOEMButton(276) 'Altera o modo para cont
        scriptObject.DoOEMButton(312)

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
        log_register(active_user, "User Defined the Axis Z Position equal a Zero ")
    End Sub




    'botao mover para o 0 da máquina
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



    '|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||


    Private Sub AutomaticGcodeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutomaticGcodeToolStripMenuItem.Click
        Form_laser_automatic.Show()
        Me.Close()
    End Sub

    Private Sub LiveWebcamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LiveWebcamToolStripMenuItem.Click
        log_register(active_user, "User started Live Webcam")
        form_camara.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        scriptObject.DoOEMButton(275)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        scriptObject.DoOEMButton(171)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        scriptObject.DoOEMButton(266)
    End Sub

    Private Sub btnMais_Click(sender As Object, e As EventArgs) Handles btnMais.Click
        scriptObject.DoOEMButton(313)
    End Sub

    Private Sub btnMenos_Click(sender As Object, e As EventArgs) Handles btnMenos.Click
        scriptObject.DoOEMButton(314)
    End Sub

    Private Sub combobox_steps_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combobox_steps.SelectedIndexChanged
        Dim selectedItem As String = combobox_steps.SelectedItem.ToString()

        scriptObject.DoOEMButton(275) 'Altera o modo para step
        verific2 = True

        Select Case selectedItem
            Case "1.000"
                scriptObject.DoOEMButton(265)
            Case "0.100"
                scriptObject.DoOEMButton(266)
            Case "0.010"
                scriptObject.DoOEMButton(267)
            Case "0.001"
                scriptObject.DoOEMButton(268)
        End Select

        btnMais.Enabled = True
        btnMenos.Enabled = True
    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        scriptObject.DoOEMButton(1021)
    End Sub
End Class
