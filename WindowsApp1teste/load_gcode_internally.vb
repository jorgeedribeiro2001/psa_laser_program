Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class load_gcode_internally

    'Carrega a tabela com tudo


    Private Sub load_gcode_internally_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh()
    End Sub

    Public Sub refresh()

        If com.State = ConnectionState.Open Then
            com.Close()
        End If
        com.Open()

        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = $"SELECT Id,Name,Project,Comments,Saved_by_User FROM table_gcode_programs;"
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView_Programs.DataSource = dt

        Dim uniqueValues As New List(Of String)()

        'Atualiza comboboxes
        Dim query As String = "SELECT Name FROM table_gcode_programs"
        Using command As New SqlCommand(query, com)
            Using reader As SqlDataReader = command.ExecuteReader()
                combobox_names.Items.Clear()
                While reader.Read()
                    Dim value As String = reader.GetString(0)
                    If Not uniqueValues.Contains(value) Then
                        uniqueValues.Add(value)
                    End If
                End While
            End Using
        End Using

        For Each value As String In uniqueValues
            combobox_names.Items.Add(value)
        Next

        uniqueValues.Clear()

        query = "SELECT Project FROM table_gcode_programs"

        Using command As New SqlCommand(query, com)
            Using reader As SqlDataReader = command.ExecuteReader()
                combobox_project.Items.Clear()
                While reader.Read()
                    Dim value As String = reader.GetString(0)
                    If Not uniqueValues.Contains(value) Then
                        uniqueValues.Add(value)
                    End If
                End While
            End Using
        End Using

        For Each value As String In uniqueValues
            combobox_project.Items.Add(value)
        Next

        uniqueValues.Clear()

        query = "SELECT Saved_by_user FROM table_gcode_programs"
        Using command As New SqlCommand(query, com)
            Using reader As SqlDataReader = command.ExecuteReader()
                combobox_user.Items.Clear()
                While reader.Read()
                    Dim value As String = reader.GetString(0)
                    If Not uniqueValues.Contains(value) Then
                        uniqueValues.Add(value)
                    End If
                End While
            End Using
        End Using

        For Each value As String In uniqueValues
            combobox_user.Items.Add(value)
        Next

        uniqueValues.Clear()

        id_to_load = 0

    End Sub

    Private Sub timer_interface_Tick(sender As Object, e As EventArgs) Handles timer_interface.Tick
        If id_to_load > 0 Then
            btn_load.Enabled = True
        Else
            btn_load.Enabled = False
        End If


    End Sub

    Private Sub btn_apply_filters_Click(sender As Object, e As EventArgs) Handles btn_apply_filters.Click

        Dim query As String = "SELECT Id, Name,Project,Comments,Saved_by_User FROM table_gcode_programs WHERE 1 = 1"

        If combobox_names.SelectedIndex <> -1 Then
            query += " AND Name = @Name"
        End If

        If combobox_project.SelectedIndex <> -1 Then
            query += " AND Project = @Project"
        End If

        If combobox_user.SelectedIndex <> -1 Then
            query += " AND Saved_by_User = @SavedByUser"
        End If

        Dim dt As New DataTable()

        Using command As New SqlCommand(query, com)
            If combobox_names.SelectedIndex <> -1 Then
                command.Parameters.AddWithValue("@Name", combobox_names.SelectedItem.ToString())
            End If
            If combobox_project.SelectedIndex <> -1 Then
                command.Parameters.AddWithValue("@Project", combobox_project.SelectedItem.ToString())
            End If
            If combobox_user.SelectedIndex <> -1 Then
                command.Parameters.AddWithValue("@SavedByUser", combobox_user.SelectedItem.ToString())
            End If

            Using adapter As New SqlDataAdapter(command)
                adapter.Fill(dt)
            End Using
        End Using

        DataGridView_Programs.DataSource = dt

    End Sub

    Private Sub btn_delete_filters_Click(sender As Object, e As EventArgs) Handles btn_delete_filters.Click
        combobox_names.SelectedIndex = -1
        combobox_project.SelectedIndex = -1
        combobox_user.SelectedIndex = -1
    End Sub

    Private Sub DataGridView_Programs_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView_Programs.CellClick
        Dim selected_row As Integer

        selected_row = CInt((DataGridView_Programs.SelectedCells.Item(0).RowIndex.ToString))

        'Verifica se selecionou uma linha vazia sem nada
        If DataGridView_Programs.Rows(selected_row).Cells(0).Value.ToString() = "" Then
            id_to_load = 0
            Return
        Else
            id_to_load = CInt(DataGridView_Programs.Rows(selected_row).Cells(0).Value.ToString())
        End If
    End Sub

    Private Sub btn_load_Click(sender As Object, e As EventArgs) Handles btn_load.Click

        'Faz clear na listbox e fecha o arquivo no mach3
        Form_laser_automatic.Listbox_gcode.Items.Clear()
        Form_laser_automatic.scriptObject.DoOEMButton(169)

        'Verifica a conexão
        If com.State = ConnectionState.Open Then
            com.Close()
        End If

        com.Open()

        'Vai buscar o gcode com o index escolhido
        Dim query As String = "SELECT GCode FROM table_gcode_programs WHERE ID = @id"

        Using command As New SqlCommand(query, com)
            command.Parameters.AddWithValue("@Id", id_to_load)
            Using reader As SqlDataReader = command.ExecuteReader()
                While reader.Read()
                    gcode_to_load = reader.GetString(0)
                End While
            End Using
        End Using

        com.Close()

        'Grava um ficheiro temp com gcode para carregar no mach3

        Dim folderPath As String = "C:\"
        Dim filePath As String = folderPath & "\Temp.txt"

        If (Not System.IO.Directory.Exists(folderPath)) Then
            Dim saveFileDialog As New SaveFileDialog()
            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                folderPath = saveFileDialog.FileName
            End If
        End If

        If (System.IO.File.Exists(filePath)) Then
            System.IO.File.Delete(filePath)
        End If

        System.IO.File.Create(filePath).Dispose()


        'Faz a transformação de string para a listbox, dividindo a string por espaços e colocando na linha e escreve um ficheiro temp para mandar para o mach3
        Dim lines As String() = gcode_to_load.Split(Environment.NewLine)
        For Each line As String In lines
            Form_laser_automatic.Listbox_gcode.Items.Add(line)
        Next

        'Copia cada linha para uma string e de seguida escreve no ficheiro Temp
        Dim lines1 As New List(Of String)
        For Each item As Object In Form_laser_automatic.Listbox_gcode.Items
            lines1.Add(item.ToString())
        Next
        Using writer As New StreamWriter(filePath)
            For Each line As String In lines1
                writer.WriteLine(line)
            Next
        End Using

        'Manda-o para o Mach3
        Form_laser_automatic.scriptObject.LoadFile(filePath)
        Form_laser_automatic.scriptObject.DoOEMButton(216)

        log_register(active_user, "User Loaded a Gcode Program Saved Inside with ID=" + gcode_to_load)
        MsgBox("Program Loaded successfully!")

        Me.Close()

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        If com.State = ConnectionState.Open Then
            com.Close()
        End If

        com.Open()

        Dim query As String = "DELETE FROM table_gcode_programs WHERE Id=@Id;"

        Using command As New SqlCommand(query, com)
            command.Parameters.AddWithValue("@Id", id_to_load)
            command.ExecuteNonQuery()
        End Using

        com.Close()

        log_register(active_user, "User Deleted a Gcode Program Saved Inside with ID=" + gcode_to_load)
        refresh()
    End Sub

    Private Sub btn_refresh_Click(sender As Object, e As EventArgs) Handles btn_refresh.Click
        refresh()
    End Sub


End Class