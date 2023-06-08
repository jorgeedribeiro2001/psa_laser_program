Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing
Imports System.Security.Cryptography.X509Certificates

Public Class Data_Base_Plataform

    'Dim com As New SqlConnection
    'Dim cmd As New SqlCommand
    Private Sub Data_Base_Plataform_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If com.State = ConnectionState.Open Then
            com.Close()
        End If

        com.Open()

        update_interface()

        'Faz updates do tempo na contagem

        txt_cutting_time_1_25.Text = TimeSpan.FromSeconds(cutting_time_1_25).ToString("hh\:mm\:ss")
        txt_cutting_time_25_50.Text = TimeSpan.FromSeconds(cutting_time_25_50).ToString("hh\:mm\:ss")
        txt_cutting_time_50_75.Text = TimeSpan.FromSeconds(cutting_time_50_75).ToString("hh\:mm\:ss")
        txt_cutting_time_75_100.Text = TimeSpan.FromSeconds(cutting_time_75_100).ToString("hh\:mm\:ss")
        txt_offline_laser.Text = TimeSpan.FromSeconds(laser_offline).ToString("hh\:mm\:ss")
        txt_cutting_time_milling.Text = TimeSpan.FromSeconds(cutting_time_milling).ToString("hh\:mm\:ss")

    End Sub

    Private Sub btn_insert_Click(sender As Object, e As EventArgs) Handles btn_insert.Click

        'Insere o utilizador na tabela de users para guardar dados

        Dim query As String = "INSERT INTO table_users (Name, Username, Password, Comments) VALUES (@Name, @Username, @Password, @Comments);"

        Using command As New SqlCommand(query, com)
            ' Add parameters for the values to be inserted
            command.Parameters.AddWithValue("@Name", txt_name.Text)
            command.Parameters.AddWithValue("@Username", txt_username.Text)
            command.Parameters.AddWithValue("@Password", txt_password.Text)
            command.Parameters.AddWithValue("@Comments", txt_comments.Text)

            ' Execute the SQL query
            command.ExecuteNonQuery()
        End Using


        'Cria tabela de historico do user

        'CREATE TABLE [dbo].[table_users] (
        '[Id]       Int            IDENTITY (1, 1) Not NULL,
        '[Name]     NVARCHAR(50)  NULL,
        '[Username] NVARCHAR(50)  NULL,
        '[Password] VARCHAR(50)   NULL,
        '[Comments] NVARCHAR(MAX) NULL,
        'PRIMARY KEY CLUSTERED ([Id] ASC)

        query = $"CREATE TABLE [dbo].[user_history_{txt_username.Text}] ([Time] NVARCHAR(MAX) NULL, [Log] NVARCHAR(MAX) NULL);"

        Using command As New SqlCommand(query, com)

            ' Execute the SQL query
            command.ExecuteNonQuery()

        End Using

        MessageBox.Show("User added successfully.")
        update_interface()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Dim query As String = "DELETE FROM table_users WHERE Name=@Name;"

        'Elimina User da tabela de users
        Using command As New SqlCommand(query, com)
            ' Add parameters for the values to be inserted
            command.Parameters.AddWithValue("@Name", txt_name.Text)

            ' Execute the SQL query
            command.ExecuteNonQuery()

            ' Display a message box to indicate that the data has been added to the table
        End Using


        'Elimina tabela de histórico
        query = $"DROP TABLE [dbo].[user_history_{txt_username.Text}];"

        Using command As New SqlCommand(query, com)
            ' Execute the SQL query
            command.ExecuteNonQuery()
        End Using

        MessageBox.Show("User Deleted successfully.")

        update_interface()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        update_interface()

    End Sub

    Public Sub update_interface()
        Dim query As String = "SELECT Name FROM table_users"

        ' Create a new SqlCommand object using the query and the SqlConnection object
        Using command As New SqlCommand(query, com)

            ' Create a new SqlDataReader object to read the data returned by the query
            Using reader As SqlDataReader = command.ExecuteReader()

                ' Clear the existing items in the ComboBox
                combobox_names.Items.Clear()
                combobox_names_log.Items.Clear()

                ' Loop through the rows returned by the query and add the names to the ComboBox
                While reader.Read()
                    combobox_names.Items.Add(reader.GetString(0))
                    combobox_names_log.Items.Add(reader.GetString(0))
                End While
            End Using
        End Using

        'Elimina todos os dados nas texboxs
        txt_name.Text = ""
        txt_username.Text = ""
        txt_password.Text = ""
        txt_comments.Text = ""

        'Anula a seleção na combobox
        combobox_names.SelectedIndex = -1

        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT * FROM table_users;"
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView_Users.DataSource = dt

    End Sub


    Private Sub btn_modify_Click(sender As Object, e As EventArgs) Handles btn_modify.Click

        Dim old_username As String

        'UPDATE Customers
        'SET ContactName = 'Alfred Schmidt', City= 'Frankfurt'
        'WHERE CustomerID = 1;"

        'Vai buscar o username antigo do user

        Dim query As String = "SELECT Username FROM table_users WHERE Name = @Name"
        Using command As New SqlCommand(query, com)
            command.Parameters.AddWithValue("@Name", combobox_names.SelectedItem.ToString())
            Using reader As SqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    old_username = reader.GetString(0)
                End If

            End Using
        End Using

        'Faz a alteração na tabela de users

        query = "UPDATE table_users SET Name = @Name, Username=@Username, Password=@Password, Comments= @Comments WHERE Name = @Name;"

        Using command As New SqlCommand(query, com)
            ' Add parameters for the values to be inserted
            command.Parameters.AddWithValue("@Name", txt_name.Text)
            command.Parameters.AddWithValue("@Username", txt_username.Text)
            command.Parameters.AddWithValue("@Password", txt_password.Text)
            command.Parameters.AddWithValue("@Comments", txt_comments.Text)

            ' Execute the SQL query
            command.ExecuteNonQuery()
        End Using

        'Altera o nome da tabela de historico

        query = $"EXEC sp_rename 'user_history_{old_username}', 'user_history_{txt_username.Text}'"

        Using command As New SqlCommand(query, com)
            ' Execute the SQL query
            command.ExecuteNonQuery()
        End Using

        ' Display a message box to indicate that the data has been added to the table
        MessageBox.Show("User modified successfully.")
        update_interface()
    End Sub

    Private Sub combobox_names_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combobox_names.SelectedIndexChanged

        Dim query As String = "SELECT Name, Username, Password, Comments FROM table_users  WHERE Name = @Name"

        ' Create a new SqlCommand object using the query and the SqlConnection object
        Using command As New SqlCommand(query, com)
            ' Add a parameter to the command for the selected name
            command.Parameters.AddWithValue("@Name", combobox_names.SelectedItem.ToString())

            ' Create a new SqlDataReader object to read the data returned by the query
            Using reader As SqlDataReader = command.ExecuteReader()

                If reader.Read() Then
                    txt_name.Text = reader.GetString(0)
                    txt_username.Text = reader.GetString(1)
                    txt_password.Text = reader.GetString(2)
                    txt_comments.Text = reader.GetString(3)
                End If
            End Using
        End Using
    End Sub

    Private Sub btn_update_log_Click(sender As Object, e As EventArgs) Handles btn_update_log.Click
        update_interface_log()
    End Sub

    Private Sub combobox_names_log_SelectedIndexChanged(sender As Object, e As EventArgs) Handles combobox_names_log.SelectedIndexChanged
        update_interface_log()
    End Sub

    Public Sub update_interface_log()
        Dim query As String = "SELECT Username FROM table_users WHERE Name = @Name"
        Dim username As String

        Using command As New SqlCommand(query, com)
            command.Parameters.AddWithValue("@Name", combobox_names_log.SelectedItem.ToString())
            Using reader As SqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    username = reader.GetString(0)
                End If
            End Using
        End Using

        cmd = com.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = $"SELECT * FROM user_history_{username};"
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        datagridview_log.DataSource = dt

    End Sub

    Private Sub btn_clear_log_Click(sender As Object, e As EventArgs) Handles btn_clear_log.Click

    End Sub

    Private Sub btn_reset_laser_time_Click(sender As Object, e As EventArgs) Handles btn_reset_laser_time.Click

        cutting_time_1_25 = 0
        cutting_time_25_50 = 0
        cutting_time_50_75 = 0
        cutting_time_75_100 = 0
        laser_offline = 0
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cutting_time_milling = 0
    End Sub
End Class