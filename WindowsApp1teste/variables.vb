Imports System.Data.SqlClient

Module variables

    'variaveis associadas SQL Server
    Public com As New SqlConnection
    Public cmd As New SqlCommand


    Public active_user As String

    'Variáveis associadas aos cutting templates

    Public center_x As Double
    Public center_y As Double
    Public retangular_length As Double
    Public retangular_width As Double
    Public retangular_radius As Double

    Public edge As Double
    Public diameter As Double

    Public slot_center_x As Double
    Public slot_center_y As Double
    Public slot_length As Double
    Public slot_diameter As Double

    Public hole_center_x As Double
    Public hole_center_y As Double
    Public hole_diameter As Double
    Public hole_spacing_x As Double
    Public hole_instances_x As Integer
    Public hole_spacing_y As Double
    Public hole_instances_y As Integer

    'Variaveis associadas aos parametros de corte
    Public parameters_safe_distance As Double
    Public parameters_z_cutting As Double
    Public parameters_feedrate_z As Double
    Public parameters_feedrate_cutting As Double
    Public laser_power As Double
    Public max_laser_power As Double = 3000
    Public path_gcode_txt As String

    'variaveis associadas ao contador de tempo
    Public running_time_session As Double
    Public cutting_time_1_25 As Integer
    Public cutting_time_25_50 As Integer
    Public cutting_time_50_75 As Integer
    Public cutting_time_75_100 As Integer
    Public laser_offline As Integer
    Public cutting_time_milling As Integer

    'Variaveis associadas ao armazenamento de programas
    Public verific As Boolean
    Public program As String
    Public program_name As String
    Public program_project As String
    Public program_comments As String
    Public id_to_load As Integer
    Public gcode_to_load As String

End Module
