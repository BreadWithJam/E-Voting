Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Module ModuleGlobalProcedure
    Public Function fnConnectToDatabase() As Boolean
        Try
            'database credentials
            servername = "localhost"
            databasename = "votingsystem"
            databaseuserid = "root"
            databasepassword = "jamycalubay@@@22"
            port = "3306"

            If connection.State = ConnectionState.Closed Then
                connection = New MySqlConnection

                strConnection = "SERVER=" & servername & ";" _
                                & "DATABASE=" & databasename & ";" _
                                & "USERNAME=" & databaseuserid & ";" _
                                & "PASSWORD=" & databasepassword & ";" _
                                & "PORT=" & port & ";" _
                                & "DEFAULT COMMAND TIMEOUT=" & 20 * 60
                connection.ConnectionString = strConnection
                connection.Open()
                command.Connection = connection
                Return True
            Else
                connection.Close()
                Return False
            End If

        Catch ex As Exception
            MessageBox.Show("" & ex.Message)

        End Try
        Return False
    End Function

    Public Sub checkDatabaseConnection()
        If fnConnectToDatabase() = True Then
        Else
            connection.Open()
        End If
    End Sub

End Module
