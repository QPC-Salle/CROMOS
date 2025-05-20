Imports Microsoft.VisualBasic.ApplicationServices
Imports MySql.Data.MySqlClient

Public Class Form4
    Dim User As String
    Dim VisitUser As String
    Dim SQL As New SQLControl()
    Dim Npages1 As Integer = 1
    Dim Npages2 As Integer = 1


    Dim ArrTeams As String() = New String(19) {
        "Deportivo Alavés", '0
        "Atletic Club", '1
        "Atletic de Madrid", '2
        "FC Barcelona", '3
        "Real Betis", '4
        "RC Celta", '5
        "RCD Espanyol", '6
        "Getafe CF", '7
        "Girona FC", '8
        "UD Las Palmas", '9
        "CD Leganés", '10
        "Real Madrid", '11
        "RCD Mallorca", '12
        "CA Osasuna", '13
        "Rayo Vallecano", '14
        "Real Sociedad", '15
        "Sevilla FC", '16
        "Valencia CF", '17
        "R.Valladolid CF", '18
        "Villarreal CF" '19
    }
    Public Sub Form4_LoadUser(sender As Object, e As EventArgs, user1 As String, user2 As String)
        User = user1
        VisitUser = user2
        Form4_Load(sender, e)
    End Sub
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LUser.Text = User
        LVUser.Text = VisitUser
        LBUser.Items.Clear()
        LBUser.Items.AddRange(ArrTeams)
        LBVUser.Items.Clear()
        LBVUser.Items.AddRange(ArrTeams)
        LBUser.SelectedIndex = 0
        LBVUser.SelectedIndex = 0

        GetCollection(User, 1)
        GetCollection(VisitUser, 2)
    End Sub
    Private Sub GetCollection(user As String, Screen As Integer)
        SQL.Connect()
        Try
            ' ¡Aquí ya está abierta la conexión!
            Dim userID As Integer = SQL.getUserID(user)
            If userID = -1 Then Exit Sub

            Dim query As String = "SELECT cromo_id, c.nom_jugador, SUM(quantitat) AS total " &
                              "FROM coleccio " &
                              "INNER JOIN cromos c ON c.id = coleccio.cromo_id " &
                              "WHERE usuari_id = @usuari_id " &
                              "AND cromo_id <= 18 * @pages " &
                              "AND cromo_id > 18 * (@pages - 1) " &
                              "GROUP BY coleccio.cromo_id, c.nom_jugador " &
                              "ORDER BY coleccio.cromo_id"
            Dim dbcmd As New MySqlCommand(query, SQL.getConnection())
            dbcmd.Parameters.AddWithValue("@usuari_id", userID)
            If Screen = 1 Then
                dbcmd.Parameters.AddWithValue("@pages", Npages1)
            Else
                dbcmd.Parameters.AddWithValue("@pages", Npages2)
            End If
            Dim adapter As New MySqlDataAdapter(dbcmd)
            Dim table As New DataTable()
            adapter.Fill(table)
            If Screen = 1 Then
                DGVUser.DataSource = table
            Else
                DGVVisitUser.DataSource = table
            End If

        Catch ex As Exception
            MsgBox("Error de connexió: " & ex.Message)

        Finally
            SQL.dbconn.Close() ' Tanca només un cop tot s’ha fet
        End Try
    End Sub

    Private Sub LBUser_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles LBUser.SelectedIndexChanged
        Npages1 = LBUser.SelectedIndex + 1
        GetCollection(User, 1)
    End Sub

    Private Sub LBVUser_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LBVUser.SelectedIndexChanged
        Npages2 = LBVUser.SelectedIndex + 1
        GetCollection(VisitUser, 2)

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTrade.Click
        Intercanvia()
        SQL.ReposarTenda()
    End Sub

    Private Sub Intercanvia()
        ' Comprova que hi ha una fila seleccionada a cada DataGridView
        If DGVUser.SelectedRows.Count = 0 Or DGVVisitUser.SelectedRows.Count = 0 Then
            MsgBox("Selecciona un cromo de cada usuari per fer l'intercanvi.", MsgBoxStyle.Exclamation)
            Exit Sub
        End If

        ' Obté l'ID i el nom del cromo seleccionat de cada usuari
        Dim cromoUserId As Integer = Convert.ToInt32(DGVUser.SelectedRows(0).Cells("cromo_id").Value)
        Dim cromoUserNom As String = DGVUser.SelectedRows(0).Cells("nom_jugador").Value.ToString()
        Dim cromoVisitUserId As Integer = Convert.ToInt32(DGVVisitUser.SelectedRows(0).Cells("cromo_id").Value)
        Dim cromoVisitUserNom As String = DGVVisitUser.SelectedRows(0).Cells("nom_jugador").Value.ToString()

        ' Missatge de confirmació
        Dim missatge As String = "Acceptar canvi? El """ & VisitUser & """ et vol canviar """ & cromoVisitUserNom & """ per """ & cromoUserNom & """"
        Dim resposta = MsgBox(missatge, MsgBoxStyle.YesNo Or MsgBoxStyle.Question, "Confirmar intercanvi")

        If resposta <> MsgBoxResult.Yes Then
            Exit Sub
        End If

        ' Obté els ID d'usuari
        Dim userId As Integer = SQL.getUserID(User)
        Dim visitUserId As Integer = SQL.getUserID(VisitUser)

        ' Intercanvi del cromo de l'usuari principal al visitant
        CanviaCromo(userId, visitUserId, cromoUserId)

        ' Intercanvi del cromo del visitant a l'usuari principal
        CanviaCromo(visitUserId, userId, cromoVisitUserId)

        ' Refresca les col·leccions
        GetCollection(User, 1)
        GetCollection(VisitUser, 2)

        MsgBox("Intercanvi realitzat correctament!", MsgBoxStyle.Information)
        Try
            SQL.Connect()
            Dim queryIntercanvi As String = "INSERT INTO intercanvis (usuari_ofereix_id, usuari_rep_id, cromo_ofert_id, cromo_demanat_id) " &
                                            "VALUES (@ofereix, @rep, @ofert, @demanat)"
            Dim cmdIntercanvi As New MySqlCommand(queryIntercanvi, SQL.getConnection())
            cmdIntercanvi.Parameters.AddWithValue("@ofereix", userId)
            cmdIntercanvi.Parameters.AddWithValue("@rep", visitUserId)
            cmdIntercanvi.Parameters.AddWithValue("@ofert", cromoUserId)
            cmdIntercanvi.Parameters.AddWithValue("@demanat", cromoVisitUserId)

            cmdIntercanvi.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("No s'ha pogut guardar l'intercanvi: " & ex.Message, MsgBoxStyle.Exclamation)
        Finally
            SQL.dbconn.Close()
        End Try
    End Sub

    Private Sub CanviaCromo(fromUserId As Integer, toUserId As Integer, cromoId As Integer)
        SQL.Connect()
        Try
            ' Resta 1 al cromo del propietari original
            Dim queryRestar As String = "UPDATE coleccio SET quantitat = quantitat - 1 WHERE usuari_id = @fromUserId AND cromo_id = @cromoId AND quantitat > 0"
            Dim cmdRestar As New MySqlCommand(queryRestar, SQL.getConnection())
            cmdRestar.Parameters.AddWithValue("@fromUserId", fromUserId)
            cmdRestar.Parameters.AddWithValue("@cromoId", cromoId)
            cmdRestar.ExecuteNonQuery()

            ' Comprova si el destinatari ja té el cromo
            Dim queryComprova As String = "SELECT quantitat FROM coleccio WHERE usuari_id = @toUserId AND cromo_id = @cromoId"
            Dim cmdComprova As New MySqlCommand(queryComprova, SQL.getConnection())
            cmdComprova.Parameters.AddWithValue("@toUserId", toUserId)
            cmdComprova.Parameters.AddWithValue("@cromoId", cromoId)
            Dim result = cmdComprova.ExecuteScalar()

            If result Is Nothing OrElse IsDBNull(result) Then
                ' Si no el té, crea'l amb quantitat 1
                Dim queryInsert As String = "INSERT INTO coleccio (usuari_id, cromo_id, quantitat) VALUES (@toUserId, @cromoId, 1)"
                Dim cmdInsert As New MySqlCommand(queryInsert, SQL.getConnection())
                cmdInsert.Parameters.AddWithValue("@toUserId", toUserId)
                cmdInsert.Parameters.AddWithValue("@cromoId", cromoId)
                cmdInsert.ExecuteNonQuery()
            Else
                ' Si ja el té, suma 1 a la quantitat
                Dim queryUpdate As String = "UPDATE coleccio SET quantitat = quantitat + 1 WHERE usuari_id = @toUserId AND cromo_id = @cromoId"
                Dim cmdUpdate As New MySqlCommand(queryUpdate, SQL.getConnection())
                cmdUpdate.Parameters.AddWithValue("@toUserId", toUserId)
                cmdUpdate.Parameters.AddWithValue("@cromoId", cromoId)
                cmdUpdate.ExecuteNonQuery()
            End If
        Catch ex As Exception
            MsgBox("Error en l'intercanvi: " & ex.Message, MsgBoxStyle.Critical)
        Finally
            SQL.dbconn.Close()
        End Try
    End Sub

    Private Sub BCancelTrade_Click(sender As Object, e As EventArgs) Handles BCancelTrade.Click
        Form2.Form2_LoadUser(sender, e, User)
        Form2.Show()
        Me.Close()
        MsgBox("Intercanvi cancel·lat", MsgBoxStyle.Information)
    End Sub

End Class