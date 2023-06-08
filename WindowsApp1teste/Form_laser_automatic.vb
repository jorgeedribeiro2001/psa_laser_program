Imports System.Reflection.Emit
Imports Mach4
Imports System.IO
Imports System.Windows.Forms.LinkLabel

Imports netDxf
Imports netDxf.Entities
Imports netDxf.Objects
Imports System.Data.SqlTypes
Imports System.Windows.Forms.VisualStyles
Imports System.Net.Security
Imports System.ComponentModel
Imports System.Data.SqlClient

Public Class Form_laser_automatic


    Public mach As Mach4.IMach4
    Public scriptObject As Mach4.IMyScriptObject

    Public OK As Boolean

    Dim doc As New DxfDocument
    Dim file As String = "C:\Disco\Trabalho\Universidade\Mestrado\1ºano\2ºSemestre\Projeto em Sistemas de Automação (PSA)\P\Programa\sample.dxf"

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



    Private Sub Form_laser_automatic_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load


        ManualToolStripMenuItem.Checked = False
        AutomaticGcodeToolStripMenuItem.Checked = True
        Form_laser_manual.Close()

        GetMachIntance()
        timer_update_position.Enabled = True
        timer_interface.Enabled = True

        btn_generate_gcode.Enabled = False
        checkbox_holes1.Checked = False
        checkbox_holes2.Checked = False

        txt_edge.Enabled = False
        txt_hole_diameter.Enabled = False

        'default values
        running_time_session = 0



    End Sub


    'Timers ||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

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

    End Sub

    'Timer atualizaçao da interface gráfica
    Private Sub timer_interface_Tick(sender As Object, e As EventArgs) Handles timer_interface.Tick

        'Verifica se o utilizador quer holes na divisão de retangulos, se não quiser desativa os txt
        If checkbox_holes1.Checked And Not (checkbox_holes2.Checked) Then
            checkbox_holes2.Enabled = False
            txt_edge.Enabled = True
            txt_hole_diameter.Enabled = True

        ElseIf checkbox_holes2.Checked And Not (checkbox_holes1.Checked) Then
            checkbox_holes1.Enabled = False
            txt_edge.Enabled = True
            txt_hole_diameter.Enabled = True
        Else
            checkbox_holes1.Enabled = True
            checkbox_holes2.Enabled = True
            txt_edge.Enabled = False
            txt_hole_diameter.Enabled = False
        End If

        'Verifica se o utilizador quer fillets na divisão de retangulos, se não quiser desativa os txt
        If checkbox_fillet.Checked Then
            txt_corner_radius.Enabled = True
        Else
            txt_corner_radius.Enabled = False
        End If

        'Verifica se o utilizador quer patterns na divisão de holes, se não quiser desativa os txt

        If checkbox_pattern_x.Checked Then
            txt_hole_spacing_x.Enabled = True
            txt_hole_instances_x.Enabled = True
        Else
            txt_hole_spacing_x.Enabled = False
            txt_hole_instances_x.Enabled = False
        End If

        If checkbox_pattern_y.Checked Then
            txt_hole_spacing_y.Enabled = True
            txt_hole_instances_y.Enabled = True
        Else
            txt_hole_spacing_y.Enabled = False
            txt_hole_instances_y.Enabled = False
        End If

        'Faz ficar o botão start verde se estiver a correr um programa

        If scriptObject.GetOEMLed(800) = False Then
            btn_reset.BackColor = Color.Green
            btn_reset.Text = "ENGAGED"
        Else
            btn_reset.BackColor = Color.DarkRed
            btn_reset.Text = "DESENGAGED"
        End If
    End Sub

    Private Sub contador_tempo_Tick(sender As Object, e As EventArgs) Handles contador_tempo.Tick

        If scriptObject.GetOEMLed(804) = True Then
            btn_start.BackColor = Color.Green

            If 0 < (laser_power / max_laser_power * 100) <= 25 Then
                cutting_time_1_25 = cutting_time_1_25 + 1
            ElseIf (25 < laser_power / max_laser_power * 100) <= 50 Then
                cutting_time_25_50 = cutting_time_25_50 + 1
            ElseIf 50 < (laser_power / max_laser_power * 100) <= 75 Then
                cutting_time_50_75 = cutting_time_50_75 + 1
            ElseIf 75 < (laser_power / max_laser_power * 100) <= 100 Then
                cutting_time_75_100 = cutting_time_75_100 + 1
            Else
                laser_offline = laser_offline + 1
            End If

        Else
            btn_start.BackColor = Color.White
        End If
    End Sub


    'Buttons |||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||



    'inicio, stop e fim de pograma + reset
    Private Sub btn_start_Click(sender As Object, e As EventArgs) Handles btn_start.Click
        scriptObject.DoOEMButton(1000)
        log_register(active_user, "User Started a Program")

    End Sub

    Private Sub btn_feedhold_Click(sender As Object, e As EventArgs) Handles btn_feedhold.Click

        scriptObject.DoOEMButton(1001)
        log_register(active_user, "User Feedholded the Program on Running")


    End Sub

    Private Sub btn_stop_Click(sender As Object, e As EventArgs) Handles btn_stop.Click

        scriptObject.DoOEMButton(1003)
        log_register(active_user, "User Stopped a Program")

        'segurança para o motion card STB4100

        scriptObject.DoOEMButton(1021)

    End Sub




    'zerar a maquina de acordo com a peça
    Private Sub btn_zerox_Click(sender As Object, e As EventArgs)

        scriptObject.DoOEMButton(1008)
        scriptObject.SetMachZero(0)


    End Sub

    Private Sub btn_zeroy_Click(sender As Object, e As EventArgs)

        scriptObject.DoOEMButton(1009)
        scriptObject.SetMachZero(1)

    End Sub

    Private Sub btn_zeroz_Click(sender As Object, e As EventArgs)

        scriptObject.DoOEMButton(1010)
        scriptObject.SetMachZero(2)


        scriptObject.Sleep(1000)

        GetMachIntance()

        scriptObject.Code("G00 Z5.0")

    End Sub

    Private Sub btn_clear_gcode_Click(sender As Object, e As EventArgs) Handles btn_clear_gcode.Click
        'Elimina conteudo da listbox, apagando o gcode
        Listbox_gcode.Items.Clear()

        'Fecha o ficheiro no Mach3
        scriptObject.DoOEMButton(169)

    End Sub

    Private Sub btn_LoadGcode_Click(sender As Object, e As EventArgs) Handles btn_LoadGcode.Click
        'Butão para Carregar g-code exterior

        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.Title = "Selecione um arquivo com G-Code para carregar"
        openFileDialog1.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*"

        If openFileDialog1.ShowDialog() = DialogResult.OK Then
            ' Obtem o caminho completo do arquivo selecionado
            Dim caminhoArquivo As String = openFileDialog1.FileName

            ' Lê o conteúdo do arquivo linha a linha
            'Dim conteudo As String = File.ReadAllText(caminhoArquivo)
            ' Dim linhas() As String = conteudo.Split(vbCrLf)

            ' Adiciona cada linha à ListBox
            ' For Each linha As String In linhas
            'Listbox_gcode.Items.Add(linha.Trim())
            ' Next

            'Faz load do ficheiro no Mach3
            scriptObject.LoadFile(caminhoArquivo)

            ' Exibe uma mensagem de confirmação para o utilizador
            MessageBox.Show("Arquivo carregado com sucesso: " & caminhoArquivo)
        End If
    End Sub



    'botao que gera o algoritmo de gcode





    '|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||

    Private Sub ManualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ManualToolStripMenuItem.Click
        Form_laser_manual.Show()
        Me.Close()
    End Sub

    Private Sub btn_dxf_update_Click(sender As Object, e As EventArgs) Handles btn_dxf_update.Click

        Dim myGraphics As Graphics = Me.Panel_dxf_drawing.CreateGraphics

        System.IO.File.Delete(file) 'Elimina o ficheiro DXF anterior
        doc.Layers.Clear()
        myGraphics.Clear(Me.Panel_dxf_drawing.BackColor)

        btn_generate_gcode.Enabled = True

        If tabcontrol_shape_template.SelectedTab Is tabpage_retangular Then
            Dim retangular_length_1 As New Line
            Dim retangular_width_1 As New Line
            Dim retangular_length_2 As New Line
            Dim retangular_width_2 As New Line


            If Len(txt_center_x.Text) > 0 And Len(txt_center_y.Text) > 0 And Len(txt_length.Text) > 0 And Len(txt_width.Text) > 0 Then

                center_x = CDbl(txt_center_x.Text)
                center_y = CDbl(txt_center_y.Text)
                retangular_length = CDbl(txt_length.Text)
                retangular_width = CDbl(txt_width.Text)
                retangular_radius = 0

                If checkbox_fillet.Checked And Len(txt_corner_radius.Text) > 0 Then
                    retangular_radius = CDbl(txt_corner_radius.Text)
                End If

                'Desenhar DXF
                If retangular_radius = 0 Then
                    retangular_length_1 = New Line(New Vector2((center_x - retangular_length / 2), (center_y + retangular_width / 2)), New Vector2((center_x + retangular_length / 2), (center_y + retangular_width / 2)))
                    DrawLines((center_x - retangular_length / 2), (center_y + retangular_width / 2), (center_x + retangular_length / 2), (center_y + retangular_width / 2))
                    retangular_width_1 = New Line(New Vector2((center_x - retangular_length / 2), (center_y + retangular_width / 2)), New Vector2((center_x - retangular_length / 2), (center_y - retangular_width / 2)))
                    DrawLines((center_x - retangular_length / 2), (center_y + retangular_width / 2), (center_x - retangular_length / 2), (center_y - retangular_width / 2))
                    retangular_length_2 = New Line(New Vector2((center_x - retangular_length / 2), (center_y - retangular_width / 2)), New Vector2((center_x + retangular_length / 2), (center_y - retangular_width / 2)))
                    DrawLines((center_x - retangular_length / 2), (center_y - retangular_width / 2), (center_x + retangular_length / 2), (center_y - retangular_width / 2))
                    retangular_width_2 = New Line(New Vector2((center_x + retangular_length / 2), (center_y + retangular_width / 2)), New Vector2((center_x + retangular_length / 2), (center_y - retangular_width / 2)))
                    DrawLines((center_x + retangular_length / 2), (center_y + retangular_width / 2), (center_x + retangular_length / 2), (center_y - retangular_width / 2))
                Else
                    retangular_length_1 = New Line(New Vector2((center_x - retangular_length / 2 + retangular_radius), (center_y + retangular_width / 2)), New Vector2((center_x + retangular_length / 2 - retangular_radius), (center_y + retangular_width / 2)))
                    DrawLines((center_x - retangular_length / 2 + retangular_radius), (center_y + retangular_width / 2), (center_x + retangular_length / 2 - retangular_radius), (center_y + retangular_width / 2))
                    retangular_width_1 = New Line(New Vector2((center_x - retangular_length / 2), (center_y + retangular_width / 2 - retangular_radius)), New Vector2((center_x - retangular_length / 2), (center_y - retangular_width / 2 + retangular_radius)))
                    DrawLines((center_x - retangular_length / 2), (center_y + retangular_width / 2 - retangular_radius), (center_x - retangular_length / 2), (center_y - retangular_width / 2 + retangular_radius))
                    retangular_length_2 = New Line(New Vector2((center_x - retangular_length / 2 + retangular_radius), (center_y - retangular_width / 2)), New Vector2((center_x + retangular_length / 2 - retangular_radius), (center_y - retangular_width / 2)))
                    DrawLines((center_x - retangular_length / 2 + retangular_radius), (center_y - retangular_width / 2), (center_x + retangular_length / 2 - retangular_radius), (center_y - retangular_width / 2))
                    retangular_width_2 = New Line(New Vector2((center_x + retangular_length / 2), (center_y + retangular_width / 2 - retangular_radius)), New Vector2((center_x + retangular_length / 2), (center_y - retangular_width / 2 + retangular_radius)))
                    DrawLines((center_x + retangular_length / 2), (center_y + retangular_width / 2 - retangular_radius), (center_x + retangular_length / 2), (center_y - retangular_width / 2 + retangular_radius))

                    Dim arc_1 As New Arc(New Vector2(center_x + retangular_length / 2 - retangular_radius, center_y + retangular_width / 2 - retangular_radius), retangular_radius, 0, 90)
                    DrawCircles((center_x + retangular_length / 2 - retangular_radius), (center_y + retangular_width / 2 - retangular_radius), retangular_radius, 0, 90)
                    Dim arc_2 As New Arc(New Vector2(center_x - retangular_length / 2 + retangular_radius, center_y + retangular_width / 2 - retangular_radius), retangular_radius, 90, 180)
                    DrawCircles((center_x - retangular_length / 2 + retangular_radius), (center_y + retangular_width / 2 - retangular_radius), retangular_radius, -90, 90)
                    Dim arc_3 As New Arc(New Vector2(center_x - retangular_length / 2 + retangular_radius, center_y - retangular_width / 2 + retangular_radius), retangular_radius, 180, 270)
                    DrawCircles((center_x - retangular_length / 2 + retangular_radius), (center_y - retangular_width / 2 + retangular_radius), retangular_radius, -180, 90)
                    Dim arc_4 As New Arc(New Vector2(center_x + retangular_length / 2 - retangular_radius, center_y - retangular_width / 2 + retangular_radius), retangular_radius, 270, 360)
                    DrawCircles((center_x + retangular_length / 2 - retangular_radius), (center_y - retangular_width / 2 + retangular_radius), retangular_radius, 0, -90)

                    doc.Entities.Add(arc_1)
                    doc.Entities.Add(arc_2)
                    doc.Entities.Add(arc_3)
                    doc.Entities.Add(arc_4)

                End If

                doc.Entities.Add(retangular_length_1)
                doc.Entities.Add(retangular_length_2)
                doc.Entities.Add(retangular_width_1)
                doc.Entities.Add(retangular_width_2)

            End If

            If checkbox_holes1.Checked And Not (checkbox_holes2.Checked) Then
                edge = CDbl(txt_edge.Text)
                diameter = CDbl(txt_hole_diameter.Text)

                Dim hole_1 As New Circle(New Vector2(center_x + retangular_length / 2 - edge, center_y + retangular_width / 2 - edge), diameter / 2)
                DrawCircles((center_x + retangular_length / 2 - edge), (center_y + retangular_width / 2 - edge), diameter / 2, 0, 360)
                Dim hole_2 As New Circle(New Vector2(center_x - retangular_length / 2 + edge, center_y + retangular_width / 2 - edge), diameter / 2)
                DrawCircles((center_x - retangular_length / 2 + edge), (center_y + retangular_width / 2 - edge), diameter / 2, 0, 360)
                Dim hole_3 As New Circle(New Vector2(center_x - retangular_length / 2 + edge, center_y - retangular_width / 2 + edge), diameter / 2)
                DrawCircles((center_x - retangular_length / 2 + edge), (center_y - retangular_width / 2 + edge), diameter / 2, 0, 360)
                Dim hole_4 As New Circle(New Vector2(center_x + retangular_length / 2 - edge, center_y - retangular_width / 2 + edge), diameter / 2)
                DrawCircles((center_x + retangular_length / 2 - edge), (center_y - retangular_width / 2 + edge), diameter / 2, 0, 360)

                doc.Entities.Add(hole_1)
                doc.Entities.Add(hole_2)
                doc.Entities.Add(hole_3)
                doc.Entities.Add(hole_4)

            ElseIf checkbox_holes2.Checked And Not (checkbox_holes1.Checked) Then

                edge = CDbl(txt_edge.Text)
                diameter = CDbl(txt_hole_diameter.Text)

                Dim hole_1 As New Circle(New Vector2(center_x, center_y + retangular_width / 2 - edge), diameter / 2)
                DrawCircles((center_x), (center_y + retangular_width / 2 - edge), diameter / 2, 0, 360)
                Dim hole_2 As New Circle(New Vector2(center_x - retangular_length / 2 + edge, center_y), diameter / 2)
                DrawCircles((center_x - retangular_length / 2 + edge), (center_y), diameter / 2, 0, 360)
                Dim hole_3 As New Circle(New Vector2(center_x, center_y - retangular_width / 2 + edge), diameter / 2)
                DrawCircles((center_x), (center_y - retangular_width / 2 + edge), diameter / 2, 0, 360)
                Dim hole_4 As New Circle(New Vector2(center_x + retangular_length / 2 - edge, -center_y), diameter / 2)
                DrawCircles((center_x + retangular_length / 2 - edge), (-center_y), diameter / 2, 0, 360)

                doc.Entities.Add(hole_1)
                doc.Entities.Add(hole_2)
                doc.Entities.Add(hole_3)
                doc.Entities.Add(hole_4)
            End If


        ElseIf tabcontrol_shape_template.SelectedTab Is tabpage_slot Then
            If Len(txt_slot_center_x.Text) > 0 And Len(txt_slot_center_y.Text) > 0 And Len(txt_slot_length.Text) > 0 And Len(txt_slot_width.Text) > 0 Then
                slot_center_x = CDbl(txt_slot_center_x.Text)
                slot_center_y = CDbl(txt_slot_center_y.Text)
                slot_length = CDbl(txt_slot_length.Text)
                slot_diameter = CDbl(txt_slot_width.Text)

                Dim slot_length_1 As New Line(New Vector2((slot_center_x - slot_length / 2 + slot_diameter / 2), slot_center_y + slot_diameter / 2), New Vector2((slot_center_x + slot_length / 2 - slot_diameter / 2), slot_center_y + slot_diameter / 2))
                DrawLines((slot_center_x - slot_length / 2 + slot_diameter / 2), slot_center_y + slot_diameter / 2, (slot_center_x + slot_length / 2 - slot_diameter / 2), slot_center_y + slot_diameter / 2)
                Dim slot_arc_1 As New Arc(New Vector2(slot_center_x + slot_length / 2 - slot_diameter / 2, slot_center_y), slot_diameter / 2, -90, 90)
                DrawCircles(slot_center_x + slot_length / 2 - slot_diameter / 2, slot_center_y, slot_diameter / 2, -90, -180)
                Dim slot_length_2 As New Line(New Vector2((slot_center_x - slot_length / 2 + slot_diameter / 2), slot_center_y - slot_diameter / 2), New Vector2((slot_center_x + slot_length / 2 - slot_diameter / 2), slot_center_y - slot_diameter / 2))
                DrawLines((slot_center_x - slot_length / 2 + slot_diameter / 2), slot_center_y - slot_diameter / 2, (slot_center_x + slot_length / 2 - slot_diameter / 2), slot_center_y - slot_diameter / 2)
                Dim slot_arc_2 As New Arc(New Vector2(slot_center_x - slot_length / 2 + slot_diameter / 2, slot_center_y), slot_diameter / 2, 90, 270)
                DrawCircles(slot_center_x - slot_length / 2 + slot_diameter / 2, slot_center_y, slot_diameter / 2, -90, 180)

                doc.Entities.Add(slot_length_1)
                doc.Entities.Add(slot_arc_1)
                doc.Entities.Add(slot_length_2)
                doc.Entities.Add(slot_arc_2)
            End If

        ElseIf tabcontrol_shape_template.SelectedTab Is tabpage_circle_hole Then
            If Len(txt_hole_center_x.Text) > 0 And Len(txt_hole_center_y.Text) > 0 And Len(txt_hole_diameter1.Text) > 0 Then
                hole_center_x = CDbl(txt_hole_center_x.Text)
                hole_center_y = CDbl(txt_hole_center_y.Text)
                hole_diameter = CDbl(txt_hole_diameter1.Text)

                If checkbox_pattern_x.Checked Then
                    hole_instances_x = CDbl(txt_hole_instances_x.Text) - 1
                    hole_spacing_x = CDbl(txt_hole_spacing_x.Text)
                Else
                    hole_instances_x = 0
                    hole_spacing_x = 0
                End If

                If checkbox_pattern_y.Checked Then
                    hole_instances_y = CDbl(txt_hole_instances_y.Text) - 1
                    hole_spacing_y = CDbl(txt_hole_spacing_y.Text)
                Else
                    hole_instances_y = 0
                    hole_spacing_y = 0
                End If

                Dim incremento_x As Double = 0
                Dim incremento_y As Double = 0

                For b = 0 To hole_instances_y
                    For a = 0 To hole_instances_x
                        Dim hole As New Circle(New Vector2(hole_center_x + incremento_x, hole_center_y + incremento_y), hole_diameter / 2)
                        DrawCircles(hole_center_x + incremento_x, hole_center_y + incremento_y, hole_diameter / 2, 0, 360)
                        incremento_x = incremento_x + hole_spacing_x
                        doc.Entities.Add(hole)
                    Next

                    incremento_y = incremento_y + hole_spacing_y
                    incremento_x = 0
                Next

            End If
            doc.Save(file)
        End If
    End Sub

    Private Sub DrawLines(ByVal x0s As Single, y0s As Single, x1s As Single, y1s As Single)

        Dim myGraphics As Graphics = Me.Panel_dxf_drawing.CreateGraphics
        Dim offsetx As Single = Me.Panel_dxf_drawing.Width / 2
        Dim offsety As Single = Me.Panel_dxf_drawing.Height / 2

        Dim OurPen As Pen
        OurPen = New Pen(Brushes.DarkGoldenrod, 1)
        myGraphics.DrawLine(OurPen, x0s + offsetx, -y0s + offsety, x1s + offsetx, -y1s + offsety)
    End Sub
    Private Sub DrawCircles(ByVal Xcs As Single, Ycs As Single, rs As Single, Ai As Single, Af As Single)

        Dim myGraphics As Graphics = Me.Panel_dxf_drawing.CreateGraphics
        Dim offsetx As Single = Me.Panel_dxf_drawing.Width / 2
        Dim offsety As Single = Me.Panel_dxf_drawing.Height / 2
        'Create pen.
        Dim OurPen As Pen
        'Draw arc to screen.
        OurPen = New Pen(Brushes.DarkGoldenrod, 1)
        myGraphics.DrawArc(OurPen, offsetx - rs + Xcs, offsety - rs - Ycs, 2 * rs, 2 * rs, Ai, -Af)


        'Centro do panel
        Dim OurPen2 As Pen
        OurPen2 = New Pen(Brushes.Black, 10)
        myGraphics.DrawLine(OurPen2, offsetx - 1, offsety - 1, offsetx + 1, offsety + 1)
        myGraphics.DrawLine(OurPen2, offsetx - 1, offsety + 1, offsetx + 1, offsety - 1)

    End Sub

    Public Function ConvertToGCode(ByVal shape As String, ByVal endX As Double, ByVal endY As Double, diameter As Double, center_x As Double, center_y As Double) As String

        If shape = "line" Then

            Listbox_gcode.Items.Add("G01 X" & endX & " Y" & endY & " F" & parameters_feedrate_cutting)

        ElseIf shape = "circle" Then

            Dim centerX As Double = center_x
            Dim centerY As Double = center_y
            Dim radius As Double = diameter / 2

            Listbox_gcode.Items.Add("G00 X" & centerX - radius & " Y" & centerY)
            Listbox_gcode.Items.Add("M3")
            Listbox_gcode.Items.Add("G01 Z" & parameters_z_cutting & " F" & parameters_feedrate_z)
            Listbox_gcode.Items.Add("G02 X" & (centerX - radius) & " Y" & (centerY) & " I" & radius & " J" & 0 & " F" & parameters_feedrate_cutting)
            Listbox_gcode.Items.Add("G00 Z" & parameters_safe_distance)
            Listbox_gcode.Items.Add("M5")

        ElseIf shape = "arc" Then
            Dim centerX As Double = center_x
            Dim centerY As Double = center_y
            Dim radius As Double = diameter / 2

            Listbox_gcode.Items.Add("G02 X" & endX & " Y" & endY & " R" & radius & " F" & parameters_feedrate_cutting)
            '" I" & centerX & " J" & centerY &
        Else
            MsgBox("Error: Function ConverttoGcode - Invalid shape type, please check!")
        End If

    End Function

    Private Sub btn_Gcode_Click(sender As Object, e As EventArgs) Handles btn_generate_gcode.Click


        'Apaga todos os itens da listbox_gcode
        Listbox_gcode.Items.Clear()

        'Fecha o ficheiro no Mach3
        scriptObject.DoOEMButton(169)

        parameters_safe_distance = CDbl(txt_parameters_safe_distance.Text)
        parameters_z_cutting = CDbl(txt_parameters_z_cutting.Text)
        parameters_feedrate_cutting = CDbl(txt_parameters_cutting_feedrate.Text)
        parameters_feedrate_z = CDbl(txt_parameters_z_feedrate.Text)

        Listbox_gcode.Items.Add("G21 ; Set units to millimeters")
        Listbox_gcode.Items.Add("G90; Use absolute coordinates")
        Listbox_gcode.Items.Add("G1 F200 ; Set feed rate To 200 mm/min")
        Listbox_gcode.Items.Add("")
        Listbox_gcode.Items.Add("S" & CInt(txt_laser_power.Text))

        If tabcontrol_shape_template.SelectedTab Is tabpage_retangular Then
            If checkbox_holes1.Checked And Not (checkbox_holes2.Checked) Then

                ConvertToGCode("circle", 0, 0, diameter, center_x - retangular_length / 2 + edge, center_y + retangular_width / 2 - edge)
                ConvertToGCode("circle", 0, 0, diameter, center_x + retangular_length / 2 - edge, center_y + retangular_width / 2 - edge)
                ConvertToGCode("circle", 0, 0, diameter, center_x + retangular_length / 2 - edge, center_y - retangular_width / 2 + edge)
                ConvertToGCode("circle", 0, 0, diameter, center_x - retangular_length / 2 + edge, center_y - retangular_width / 2 + edge)

            ElseIf checkbox_holes2.Checked And Not (checkbox_holes1.Checked) Then
                ConvertToGCode("circle", 0, 0, diameter, center_x, center_y + retangular_width / 2 - edge)
                ConvertToGCode("circle", 0, 0, diameter, center_x + retangular_length / 2 - edge, center_y)
                ConvertToGCode("circle", 0, 0, diameter, center_x, center_y - retangular_width / 2 + edge)
                ConvertToGCode("circle", 0, 0, diameter, center_x - retangular_length / 2 + edge, center_y)
            End If

            If retangular_radius = 0 Then
                Listbox_gcode.Items.Add("G00 X" & (center_x - retangular_length / 2) & " Y" & (center_y + retangular_width / 2))
                Listbox_gcode.Items.Add("G01 Z" & parameters_z_cutting & " F" & parameters_feedrate_z)
                Listbox_gcode.Items.Add("M3")
                ConvertToGCode("line", endX:=(center_x + retangular_length / 2), endY:=(center_y + retangular_width / 2), 0, 0, 0)
                ConvertToGCode("line", endX:=(center_x + retangular_length / 2), endY:=(center_y - retangular_width / 2), 0, 0, 0)
                ConvertToGCode("line", endX:=(center_x - retangular_length / 2), endY:=(center_y - retangular_width / 2), 0, 0, 0)
                ConvertToGCode("line", endX:=(center_x - retangular_length / 2), endY:=(center_y + retangular_width / 2), 0, 0, 0)
                Listbox_gcode.Items.Add("M5")
                Listbox_gcode.Items.Add("G00 Z" & parameters_safe_distance)
            Else
                Listbox_gcode.Items.Add("G00 X" & (center_x - retangular_length / 2 + retangular_radius) & " Y" & (center_y + retangular_width / 2))
                Listbox_gcode.Items.Add("G01 Z" & parameters_z_cutting & " F" & parameters_feedrate_z)
                Listbox_gcode.Items.Add("M3")
                ConvertToGCode("line", endX:=(center_x + retangular_length / 2 - retangular_radius), endY:=(center_y + retangular_width / 2), 0, 0, 0)
                ConvertToGCode("arc", endX:=(center_x + retangular_length / 2), endY:=(center_y + retangular_width / 2 - retangular_radius), retangular_radius * 2, center_x + retangular_length / 2 - retangular_radius, center_y + retangular_width / 2 - retangular_radius)
                ConvertToGCode("line", endX:=(center_x + retangular_length / 2), endY:=(center_y - retangular_width / 2 + retangular_radius), 0, 0, 0)
                ConvertToGCode("arc", endX:=(center_x + retangular_length / 2 - retangular_radius), endY:=(center_y - retangular_width / 2), retangular_radius * 2, center_x + retangular_length / 2 - retangular_radius, center_y - retangular_width / 2 + retangular_radius)
                ConvertToGCode("line", endX:=(center_x - retangular_length / 2 + retangular_radius), endY:=(center_y - retangular_width / 2), 0, 0, 0)
                ConvertToGCode("arc", endX:=(center_x - retangular_length / 2), endY:=(center_y - retangular_width / 2 + retangular_radius), retangular_radius * 2, center_x - retangular_length / 2 + retangular_radius, center_y - retangular_width / 2 + retangular_radius)
                ConvertToGCode("line", endX:=(center_x - retangular_length / 2), endY:=(center_y + retangular_width / 2 - retangular_radius), 0, 0, 0)
                ConvertToGCode("arc", endX:=(center_x - retangular_length / 2 + retangular_radius), endY:=(center_y + retangular_width / 2), retangular_radius * 2, center_x - retangular_length / 2 + retangular_radius, center_y + retangular_width / 2 - retangular_radius)
                Listbox_gcode.Items.Add("M5")
                Listbox_gcode.Items.Add("G00 Z" & parameters_safe_distance)
            End If

        ElseIf tabcontrol_shape_template.SelectedTab Is tabpage_slot Then
            Listbox_gcode.Items.Add("G00 X" & (slot_center_x - slot_length / 2 + slot_diameter / 2) & " Y" & (slot_center_y + slot_diameter / 2))
            Listbox_gcode.Items.Add("G01 Z" & parameters_z_cutting & " F" & parameters_feedrate_z)
            Listbox_gcode.Items.Add("M3")
            ConvertToGCode("line", endX:=(slot_center_x + slot_length / 2 - slot_diameter / 2), endY:=(slot_center_y + slot_diameter / 2), 0, 0, 0)
            ConvertToGCode("arc", endX:=(slot_center_x + slot_length / 2 - slot_diameter / 2), endY:=(slot_center_y - slot_diameter / 2), slot_diameter, slot_center_x + slot_length / 2 - slot_diameter / 2, slot_center_y)
            ConvertToGCode("line", endX:=(slot_center_x - slot_length / 2 + slot_diameter / 2), endY:=(slot_center_y - slot_diameter / 2), 0, 0, 0)
            ConvertToGCode("arc", endX:=(slot_center_x - slot_length / 2 + slot_diameter / 2), endY:=(slot_center_y + slot_diameter / 2), slot_diameter, slot_center_x - slot_length / 2 + slot_diameter / 2, slot_center_y)
            Listbox_gcode.Items.Add("M5")
            Listbox_gcode.Items.Add("G00 Z" & parameters_safe_distance)

        ElseIf tabcontrol_shape_template.SelectedTab Is tabpage_circle_hole Then

            Dim incremento_x As Double = 0
            Dim incremento_y As Double = 0

            For b = 0 To hole_instances_y
                For a = 0 To hole_instances_x
                    ConvertToGCode("circle", 0, 0, hole_diameter, center_x + incremento_x, center_y + incremento_y)
                    incremento_x = incremento_x + hole_spacing_x
                Next

                incremento_y = incremento_y + hole_spacing_y
                incremento_x = 0
            Next
        End If

        Listbox_gcode.Items.Add("M30")


        Dim gcode_text As New List(Of String)
        For Each item As Object In Listbox_gcode.Items
            gcode_text.Add(item.ToString())
        Next


        'Grava um ficheiro temp com gcode para carregar no mach3

        Dim folderPath As String = "C:\"
        Dim filePath As String = folderPath & "\Temp.txt"

        'Verifica se existe a pasta C:\ para criar o ficheiro temp, caso nao exista, abre savefiledialog
        If (Not System.IO.Directory.Exists(folderPath)) Then
            Dim saveFileDialog As New SaveFileDialog()
            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                folderPath = saveFileDialog.FileName
            End If
        End If

        'Atualiza, removendo e criando novamente o ficheiro caso faça update gcode várias vezes
        If (System.IO.File.Exists(filePath)) Then
            System.IO.File.Delete(filePath)
        End If

        'Cria Novo Ficheiro
        System.IO.File.Create(filePath).Dispose()

        Dim lines As New List(Of String)

        'Copia cada linha para uma string e de seguida escreve no ficheiro Temp
        For Each item As Object In Listbox_gcode.Items
            lines.Add(item.ToString())
        Next

        Using writer As New StreamWriter(filePath)
            For Each line As String In lines
                writer.WriteLine(line)
            Next
        End Using

        laser_power = CDbl(txt_laser_power.Text)

        'Manda-o para o Mach3
        scriptObject.LoadFile(filePath)
        scriptObject.DoOEMButton(216)

    End Sub

    Private Sub btn_save_gcode_Click(sender As Object, e As EventArgs) Handles btn_save_gcode.Click
        ' Get the lines of the listbox
        Dim lines As New List(Of String)

        For Each item As Object In Listbox_gcode.Items
            lines.Add(item.ToString())
        Next

        ' Create a new text file
        Dim saveFileDialog As New SaveFileDialog()
        saveFileDialog.Filter = "Text Files (*.txt)|*.txt"
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            ' Write the lines to the text file
            Using writer As New StreamWriter(saveFileDialog.FileName)
                For Each line As String In lines
                    writer.WriteLine(line)
                Next
            End Using

            ' Show a message box indicating the file has been saved
            MessageBox.Show("The file has been saved.")
        End If
    End Sub

    Private Sub btn_reset_Click(sender As Object, e As EventArgs) Handles btn_reset.Click
        scriptObject.DoOEMButton(1021)
    End Sub

    Private Sub btn_home_Click(sender As Object, e As EventArgs) Handles btn_home.Click

        GetMachIntance()
        scriptObject.Code("G28")
        log_register(active_user, "User Moved to Machine Position")
    End Sub

    Private Sub btn_zero_x_Click(sender As Object, e As EventArgs) Handles btn_zero_x.Click
        scriptObject.DoOEMButton(1008)
        scriptObject.SetMachZero(0)
        log_register(active_user, "User Defined the Axis X Position equal a Zero ")
    End Sub

    Private Sub btn_zero_y_Click(sender As Object, e As EventArgs) Handles btn_zero_y.Click
        scriptObject.DoOEMButton(1009)
        scriptObject.SetMachZero(1)
        log_register(active_user, "User Defined the Axis Y Position equal a Zero ")
    End Sub

    Private Sub btn_zero_z_Click(sender As Object, e As EventArgs) Handles btn_zero_z.Click
        scriptObject.DoOEMButton(1010)
        scriptObject.SetMachZero(2)
        scriptObject.Sleep(1000)
        GetMachIntance()
        log_register(active_user, "User Defined the Axis Z Position equal a Zero ")
    End Sub

    Private Sub btn_save_internally_Click(sender As Object, e As EventArgs) Handles btn_save_internally.Click
        program = ""
        For Each item As Object In Listbox_gcode.Items
            ' Append the text to the result variable
            program += item.ToString() & vbCrLf
        Next

        verific = True
        save_gcode.ShowDialog()
        'Caso o utilizador cancele
        If verific = False Then
            Return
        End If

        If com.State = ConnectionState.Open Then
            com.Close()
        End If
        com.Open()

        'Grava o Gcode no Servidor
        Dim query As String = "INSERT INTO table_gcode_programs (Name, Project, Comments, GCode, Saved_by_User) VALUES (@program_name, @program_project, @program_comments, @program_gcode, @user_saved);"
        Using command As New SqlCommand(query, com)
            command.Parameters.AddWithValue("@program_name", program_name)
            command.Parameters.AddWithValue("@program_project", program_project)
            command.Parameters.AddWithValue("@program_comments", program_comments)
            command.Parameters.AddWithValue("@program_gcode", program)
            command.Parameters.AddWithValue("@user_saved", active_user)
            command.ExecuteNonQuery()
        End Using

        com.Close()

    End Sub

    Private Sub btn_load_internally_Click(sender As Object, e As EventArgs) Handles btn_load_internally.Click
        load_gcode_internally.ShowDialog()
    End Sub

    Private Sub LiveWebcamToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LiveWebcamToolStripMenuItem.Click
        log_register(active_user, "User started Live Webcam")
        form_camara.Show()
    End Sub
End Class

