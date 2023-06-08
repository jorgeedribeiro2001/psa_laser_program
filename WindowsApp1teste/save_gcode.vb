Public Class save_gcode
    Private Sub save_gcode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer_interface.Enabled = True
    End Sub
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        verific = True
        program_name = txt_program_name.Text
        program_project = txt_project_name.Text
        program_comments = txt_program_comment.Text

        log_register(active_user, "User Saved a Gcode Program with the Name= " + program_name)
        Me.Close()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        verific = False
        Me.Close()
    End Sub

    Private Sub Timer_interface_Tick(sender As Object, e As EventArgs) Handles Timer_interface.Tick
        If Len(txt_program_name.Text) > 0 And Len(txt_project_name.Text) > 0 Then
            btn_save.Enabled = True
        Else
            btn_save.Enabled = False
        End If
    End Sub
End Class