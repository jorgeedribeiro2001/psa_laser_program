Imports System.ComponentModel
Imports System.Data.SqlClient
Public Class selecao_modo

    'Dim com As New SqlConnection
    'Dim cmd As New SqlCommand
    Dim verific_mach3_open As Boolean
    Dim mach As Mach4.IMach4
    Dim scriptObject As Mach4.IMyScriptObject

    Private Sub selecao_modo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_login.Enabled = False
        btn_login_guest.Enabled = False
        txt_incorrectlogin.Text = ""
        active_user = "guest"

        'Ligação com servidor do Microsoft Azure
        com.ConnectionString = "Data Source=data-server-psa2.database.windows.net;Initial Catalog=basededados1;User ID=jorge.e.ribeiro;Password=PSAlaser2023"
        'Login: jorge.e.ribeiro Password: PSAlaser2023

        'Ligação com o servidor local
        'com.ConnectionString = "Data Source=(LocalDB)\MSSQLLocalDB; AttachDbFilename= 'C:\data_server.mdf'; Integrated Security=True"

        Try
            If com.State = ConnectionState.Open Then
                com.Close()
            End If
            com.Open()
        Catch ex As System.Data.SqlClient.SqlException
            MessageBox.Show("It was not possible to connect into the DataBase." & vbCrLf & "Please check the Internet. It is not possible connect in Eduroam, please change the Wireless Conection.", "Error: DataBase not Connected", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End Try

        'Atualiza o combobox com os usernames
        Dim query As String = "SELECT Username FROM table_users"

        Using command As New SqlCommand(query, com)
            Using reader As SqlDataReader = command.ExecuteReader()
                combobox_user.Items.Clear()
                While reader.Read()
                    combobox_user.Items.Add(reader.GetString(0))
                End While
            End Using
        End Using

        'Vai buscar as variaveis do tempo à base de dados
        query = "SELECT Cutting_time_laser_0_25 ,Cutting_time_laser_25_50,Cutting_time_laser_50_75, Cutting_time_laser_75_100, Cutting_time_milling, laser_offline FROM table_time_cutting WHERE ID = 1"
        Using command As New SqlCommand(query, com)
            Using reader As SqlDataReader = command.ExecuteReader()

                If reader.Read() Then
                    cutting_time_1_25 = CInt(reader.GetString(0))
                    cutting_time_25_50 = CInt(reader.GetString(1))
                    cutting_time_50_75 = CInt(reader.GetString(2))
                    cutting_time_75_100 = CInt(reader.GetString(3))
                    cutting_time_milling = CInt(reader.GetString(4))
                    laser_offline = CInt(reader.GetString(5))
                End If
            End Using
        End Using

    End Sub

    Private Sub selecao_modo_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        If com.State = ConnectionState.Open Then
            com.Close()
        End If

        com.Open()

        Dim query As String = "UPDATE table_time_cutting SET Cutting_time_laser_0_25  = @Cutting_time_laser_0_25, Cutting_time_laser_25_50 =@Cutting_time_laser_25_50, Cutting_time_laser_50_75=@Cutting_time_laser_50_75, Cutting_time_laser_75_100= @Cutting_time_laser_75_100, Cutting_time_milling= @Cutting_time_milling, laser_offline= @laser_offline  WHERE ID = 1;"

        Using command As New SqlCommand(query, com)
            ' Add parameters for the values to be inserted
            command.Parameters.AddWithValue("@Cutting_time_laser_0_25", cutting_time_1_25)
            command.Parameters.AddWithValue("@Cutting_time_laser_25_50", cutting_time_25_50)
            command.Parameters.AddWithValue("@Cutting_time_laser_50_75", cutting_time_50_75)
            command.Parameters.AddWithValue("@Cutting_time_laser_75_100", cutting_time_75_100)
            command.Parameters.AddWithValue("@Cutting_time_milling", cutting_time_milling)
            command.Parameters.AddWithValue("@laser_offline", laser_offline)

            ' Execute the SQL query
            command.ExecuteNonQuery()
        End Using

        com.Close()

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If (checkbox_laser.Checked Or checkbox_milling.Checked) Then
            'Verifica se está selecionado só um checkbox
            btn_login_guest.Enabled = True
        Else
            btn_login.Enabled = False
            btn_login_guest.Enabled = False
        End If

        If Len(combobox_user.SelectedItem) > 0 And Len(txt_password.Text) And (checkbox_laser.Checked Or checkbox_milling.Checked) Then
            btn_login.Enabled = True
        End If

        If Len(combobox_user.SelectedItem) > 0 And Len(txt_password.Text) Then
            btn_definitions.Enabled = True
        Else
            btn_definitions.Enabled = False
        End If
    End Sub

    Private Sub checkbox_laser_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox_laser.CheckedChanged
        'Evita checkboxs estarem ativas em simultaneo
        If checkbox_laser.Checked Then
            checkbox_milling.Enabled = False
        Else
            checkbox_milling.Enabled = True
        End If
    End Sub

    Private Sub checkbox_milling_CheckedChanged(sender As Object, e As EventArgs) Handles checkbox_milling.CheckedChanged
        'Evita checkboxs estarem ativas em simultaneo
        If checkbox_milling.Checked Then
            checkbox_laser.Enabled = False
        Else
            checkbox_laser.Enabled = True
        End If
    End Sub

    Private Sub btn_login_guest_Click(sender As Object, e As EventArgs) Handles btn_login_guest.Click
        active_user = "guest"

        check_mach3()

        If checkbox_milling.Checked = True And verific_mach3_open = True Then
            Form_milling.ShowDialog()
            Me.Close()

        ElseIf checkbox_laser.Checked = True And verific_mach3_open = True Then
            Form_laser_manual.Show()
        End If

    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click

        Dim password As String = ""
        Dim query As String = "SELECT Password FROM table_users  WHERE Username = @Username"

        If com.State = ConnectionState.Open Then
            com.Close()
        End If
        com.Open()

        Using command As New SqlCommand(query, com)

            command.Parameters.AddWithValue("@Username", combobox_user.SelectedItem.ToString())

            Using reader As SqlDataReader = command.ExecuteReader()

                If reader.Read() Then
                    password = reader.GetString(0)
                End If
            End Using
        End Using

        com.Close()

        check_mach3()

        If String.Compare(password, CStr(txt_password.Text)) = 0 Then
            active_user = combobox_user.SelectedItem.ToString()

            If checkbox_milling.Checked = True And verific_mach3_open = True Then
                log_register(active_user, "Log In with Milling Machine")
                Form_milling.ShowDialog()

            ElseIf checkbox_laser.Checked = True And verific_mach3_open = True Then
                log_register(active_user, "Log In with Laser Machine")
                Form_laser_manual.Show()

            End If

        Else
            txt_incorrectlogin.Text = "Incorrect Login !!!"
            log_register(active_user, "Someone Attempted To Log In With a Wrong Password ")
        End If

    End Sub

    Private Sub btn_definitions_Click(sender As Object, e As EventArgs) Handles btn_definitions.Click

        If com.State = ConnectionState.Open Then
            com.Close()
        End If
        com.Open()

        active_user = combobox_user.SelectedItem.ToString()

        Dim password As String = ""
        Dim query As String = "SELECT Password FROM table_users  WHERE Username = @Username"

        Using command As New SqlCommand(query, com)

            command.Parameters.AddWithValue("@Username", combobox_user.SelectedItem.ToString())

            Using reader As SqlDataReader = command.ExecuteReader()

                If reader.Read() Then
                    password = reader.GetString(0)
                End If
            End Using
        End Using

        com.Close()

        If String.Compare(password, CStr(txt_password.Text)) = 0 And String.Compare(combobox_user.SelectedItem.ToString(), "admin") = 0 Then
            log_register(active_user, "Log in in the Program Definitions")
            Data_Base_Plataform.Show()
        ElseIf String.Compare(combobox_user.SelectedItem.ToString(), "admin") = 0 Then
            log_register(active_user, "Someone Attempted To Log In With a Wrong Password ")
            txt_incorrectlogin.Text = "Incorrect Login !!!"
        Else
            log_register(active_user, "Attempted To Log In Definitions")
            MsgBox("You should login with admin !!!")
        End If


    End Sub

    Private Sub txt_password_TextChanged(sender As Object, e As EventArgs) Handles txt_password.TextChanged
        txt_incorrectlogin.Text = ""
    End Sub

    Public Sub check_mach3()
        Try
            verific_mach3_open = True
            Dim teste As String = ""
            mach = GetObject(, "Mach4.Document")
            scriptObject = mach.GetScriptDispatch()
            teste = scriptObject.GetABSPostion(0)

        Catch ex As System.NullReferenceException
            MessageBox.Show("Open First the Mach3 Software to Proceed.", "Error: Mach3 Closed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            verific_mach3_open = False

        Catch ex As System.Exception
            MessageBox.Show("Open First the Mach3 Software to Proceed." & vbCrLf & "If Appears the Same Error, run Mach3.reg and Verify if ActiveX is Running.", "Error: Mach3 Closed", MessageBoxButtons.OK, MessageBoxIcon.Error)
            verific_mach3_open = False
        End Try
    End Sub

    Private Sub btn_webcam_Click(sender As Object, e As EventArgs) Handles btn_webcam.Click
        Dim password As String = ""
        Dim query As String = "SELECT Password FROM table_users  WHERE Username = @Username"

        If Not (combobox_user.SelectedIndex = -1) Then

            If com.State = ConnectionState.Open Then
                com.Close()
            End If
            com.Open()

            Using command As New SqlCommand(query, com)

                command.Parameters.AddWithValue("@Username", combobox_user.SelectedItem.ToString())

                Using reader As SqlDataReader = command.ExecuteReader()

                    If reader.Read() Then
                        password = reader.GetString(0)
                    End If
                End Using
            End Using

            com.Close()

            If String.Compare(password, CStr(txt_password.Text)) = 0 Then
                active_user = combobox_user.SelectedItem.ToString()

                log_register(active_user, "User started Live Webcam")
                form_camara.Show()

            Else
                txt_incorrectlogin.Text = "Incorrect Login !!!"
                log_register(active_user, "Someone Attempted To Log In With a Wrong Password ")
            End If

        Else
            active_user = "guest"
            log_register(active_user, "User started Live Webcam")
            form_camara.Show()

        End If
    End Sub
End Class