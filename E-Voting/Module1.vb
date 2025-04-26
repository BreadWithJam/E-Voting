Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient
Module Module1
    Public connection As New MySqlConnection ' variable mag gunit sa imong connection
    Public command As New MySqlCommand ' variable mag gunit sa mga sql command execution
    Public strConnection As String      'will hold the database credentials (ex userid, password)
    Public servername As String     'localhost
    Public databasename As String   'UMTC
    Public databaseuserid As String 'Root
    Public databasepassword As String   'umtc or depends on the password you assigned
    Public port As String               'post no ex. 3306 or 3307
    Public studentPhotopath As String
    Public sqlAdapter As New MySqlDataAdapter
    Public datatbl As New DataTable
    Public row As Integer
    Public dr As MySqlDataReader
    Public Cimage As New DataGridViewImageColumn
    Public ds As New DataSet

End Module

