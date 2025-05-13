Imports System.Data.SqlClient
Imports Microsoft.VisualBasic
Imports MySql.Data.MySqlClient
Imports Mysqlx.Crud
Imports Mysqlx.Resultset
Imports Mysqlx.XDevAPI.Relational

Public Class SQLControl
    Public dbconn As MySqlConnection
    Public dbcmd As MySqlCommand
    Public query As String
    Public sqldr As SqlDataReader
    Public sqlRS As SqlResult


    Public Function Connect()
        If dbconn Is Nothing Then
            dbconn = New MySqlConnection()
        End If
        dbconn.ConnectionString = "server=localhost;user id=root;password=;database=cromos"

        Try
            dbconn.Open()

        Catch ex As Exception
            MsgBox("Error de connexió: " & ex.Message)

        Finally

        End Try
    End Function

    Public Function HasConnection() As Boolean
        If dbconn Is Nothing Then
            dbconn = New MySqlConnection()
        End If
        dbconn.ConnectionString = "server=localhost;user id=root;password=;database=cromos"

        Try
            dbconn.Open()
            Return True
        Catch ex As Exception
            MsgBox("Error de connexió: " & ex.Message)
            Return False
        Finally
            dbconn.Close()
        End Try
    End Function

    Public Function User_Exists(user As String, passwrd As String) As Boolean
        Connect()
        Try
            query = "SELECT * FROM usuaris WHERE nom_usuari = '" + user + "' & contrasenya_hash = '" + passwrd + "'"
            dbcmd = New MySqlCommand(query, dbconn)
            'error
            Dim Rows = dbcmd.ExecuteNonQuery()
            If (Rows < 0) Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            MsgBox("Error de connexió: " & ex.Message)
            Return False
        Finally
            dbconn.Close()
        End Try
    End Function

    Public Function CreateUser(user As String, pass As String)
        Connect()
        Try
            query = "INSERT INTO usuaris (nom_usuari, contrasenya_hash) VALUES ('" + user + "', '" + pass + "')"
            dbcmd = New MySqlCommand(query, dbconn)
            Dim Rows = dbcmd.ExecuteNonQuery()
            If (Rows < 0) Then
                MsgBox("Error al crear el usuario")
            Else
                MsgBox("Usuario creado correctamente")
            End If
        Catch ex As Exception
            MsgBox("Error de connexió: " & ex.Message)
        Finally
            dbconn.Close()
        End Try
    End Function
End Class
