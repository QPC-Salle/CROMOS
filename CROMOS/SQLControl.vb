Imports System.Data.SqlClient
Imports System.Runtime.Remoting.Messaging
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

    Public Function getConnection() As MySqlConnection
        Return dbconn
    End Function
    Public Function Connect()
        dbconn = New MySqlConnection()

        dbconn.ConnectionString = "server=localhost;user id=root;password=;database=cromos"


        Try
            dbconn.Open()
        Catch ex As Exception
            MsgBox("Error de connexió: " & ex.Message)

        Finally

        End Try
    End Function

    Public Function HasConnection() As Boolean
        Dim Connected As Boolean = False
        Connect()
        If dbconn.State = ConnectionState.Open Then
            dbconn.Close()
            Connected = True
        End If
        Return Connected
    End Function
    Public Function getUserID(user As String) As Integer
        Using conn As New MySqlConnection("server=localhost;user id=root;password=;database=cromos")
            conn.Open()
            query = "SELECT id FROM usuaris WHERE nom_usuari = @user"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@user", user)
                Dim userID As Object = cmd.ExecuteScalar()
                If userID IsNot Nothing AndAlso Not IsDBNull(userID) Then
                    Return Convert.ToInt32(userID)
                Else
                    MsgBox("El usuario no existe")
                    Return -1
                End If
            End Using
        End Using
    End Function
    Public Function User_Exists(user As String, passwrd As String) As Boolean
        Using conn As New MySqlConnection("server=localhost;user id=root;password=;database=cromos")
            conn.Open()
            query = "SELECT COUNT(*) FROM usuaris WHERE nom_usuari = @user AND contrasenya_hash = @pass"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@user", user)
                cmd.Parameters.AddWithValue("@pass", passwrd)
                Dim count As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function
    Public Function User_Exists(user As String) As Boolean
        ' Inicializa la conexión si es necesario
        If dbconn Is Nothing Then
            Connect()
        End If
        If dbconn.State <> ConnectionState.Open Then
            dbconn.Open()
        End If
        Try
            query = "SELECT COUNT(*) FROM usuaris WHERE nom_usuari = @user"
            dbcmd = New MySqlCommand(query, dbconn)
            dbcmd.Parameters.AddWithValue("@user", user)
            Dim count As Integer = Convert.ToInt32(dbcmd.ExecuteScalar())
            Return count > 0
        Catch ex As Exception
            MsgBox("Error de connexió: " & ex.Message)
            Return False
        Finally
            dbconn.Close()
        End Try
    End Function
    Public Function CreateUser(user As String, pass As String)
        Using conn As New MySqlConnection("server=localhost;user id=root;password=;database=cromos")
            conn.Open()
            query = "INSERT INTO usuaris (nom_usuari, contrasenya_hash) VALUES (@user, @pass)"
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@user", user)
                cmd.Parameters.AddWithValue("@pass", pass)
                Dim Rows = cmd.ExecuteNonQuery()
                If (Rows < 0) Then
                    MsgBox("Error al crear el usuario")
                Else
                    MsgBox("Usuario creado correctamente")
                End If
            End Using
        End Using
    End Function
    Public Sub ReposarTenda()
        ' Obté l'ID de la tenda
        Dim tendaId As Integer = getUserID("tenda")
        If tendaId = -1 Then Exit Sub

        Connect()
        Try
            ' Per cada cromo existent, posa la quantitat a 100 si és menor
            Dim query As String = "SELECT id FROM cromos"
            Dim cmd As New MySqlCommand(query, getConnection())
            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            Dim cromoIds As New List(Of Integer)
            While reader.Read()
                cromoIds.Add(Convert.ToInt32(reader("id")))
            End While
            reader.Close()

            For Each cromoId In cromoIds
                ' Comprova la quantitat actual
                Dim queryCheck As String = "SELECT quantitat FROM coleccio WHERE usuari_id = @tendaId AND cromo_id = @cromoId"
                Dim cmdCheck As New MySqlCommand(queryCheck, getConnection())
                cmdCheck.Parameters.AddWithValue("@tendaId", tendaId)
                cmdCheck.Parameters.AddWithValue("@cromoId", cromoId)
                Dim result = cmdCheck.ExecuteScalar()
                If result Is Nothing OrElse IsDBNull(result) Then
                    ' Si no existeix, crea'l amb 100
                    Dim queryInsert As String = "INSERT INTO coleccio (usuari_id, cromo_id, quantitat) VALUES (@tendaId, @cromoId, 100)"
                    Dim cmdInsert As New MySqlCommand(queryInsert, getConnection())
                    cmdInsert.Parameters.AddWithValue("@tendaId", tendaId)
                    cmdInsert.Parameters.AddWithValue("@cromoId", cromoId)
                    cmdInsert.ExecuteNonQuery()
                ElseIf Convert.ToInt32(result) < 100 Then
                    ' Si existeix i és menor de 100, actualitza a 100
                    Dim queryUpdate As String = "UPDATE coleccio SET quantitat = 100 WHERE usuari_id = @tendaId AND cromo_id = @cromoId"
                    Dim cmdUpdate As New MySqlCommand(queryUpdate, getConnection())
                    cmdUpdate.Parameters.AddWithValue("@tendaId", tendaId)
                    cmdUpdate.Parameters.AddWithValue("@cromoId", cromoId)
                    cmdUpdate.ExecuteNonQuery()
                End If
            Next
        Catch ex As Exception
            MsgBox("Error reposant la tenda: " & ex.Message)
        Finally
            dbconn.Close()
        End Try
    End Sub
End Class
