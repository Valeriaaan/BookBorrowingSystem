Imports MySql.Data.MySqlClient

' Module1: Contains global variables and functions related to database connection
Module Module1
    ' Global variables for database connection
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand
    Public adapter As New MySqlDataAdapter
    Public reader As MySqlDataReader
    Public data As New DataSet
    Public t As New DataTable

    ' Function to open the database connection
    Sub openCon()
        Try
            ' Set the connection string for MySQL database
            con.ConnectionString = "server=localhost;username=root;password=;database=library_management"

            ' Open the database connection if it is not already open
            If con.State = ConnectionState.Closed Then
                con.Open()
            End If
        Catch ex As Exception
            ' Display an error message if there is an issue connecting to the database
            MsgBox("Error connecting to the database: " & ex.Message)
        End Try
    End Sub
End Module
