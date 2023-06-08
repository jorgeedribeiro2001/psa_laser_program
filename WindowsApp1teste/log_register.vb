Imports System.Data.SqlClient

Module log_register_function
    Public Sub log_register(ByVal user As String, ByVal log As String)

        If com.State = ConnectionState.Open Then
            com.Close()
        End If

        com.Open()

        Dim query As String = $"INSERT INTO user_history_{user} (Time,Log) VALUES (@Time, @Log);"

        Using command As New SqlCommand(query, com)
            ' Add parameters for the values to be inserted

            command.Parameters.AddWithValue("@Time", DateTime.Now.ToString("dd/MM/yyyy HH:mm"))
            command.Parameters.AddWithValue("@Log", log)

            ' Execute the SQL query
            command.ExecuteNonQuery()
        End Using

        com.Close()
    End Sub
End Module
