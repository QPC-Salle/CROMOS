Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient

Public Class Form3
    Dim User As String = Form1.getUser()
    Dim VisitUser As String = User
    Dim SQL As New SQLControl()
    Dim ArrTeams As String() = New String(19) {
        "Deportivo Alavés",'0
        "Atletic Club",'1
        "Atletic de Madrid",'2
        "FC Barcelona",'3
        "Real Betis",'4
        "RC Celta",'5
        "RCD Espanyol",'6
        "Getafe CF",'7
        "Girona FC",'8
        "UD Las Palmas",'9
        "CD Leganés",'10
        "Real Madrid",'11
        "RCD Mallorca",'12
        "CA Osasuna",'13
        "Rayo Vallecano",'14
        "Real Sociedad",'15
        "Sevilla FC",'16
        "Valencia CF",'17
        "R.Valladolid CF",'18
        "Villarreal CF"'19
    }
    Dim page As Integer = 1

    Public Sub LoadUser(sender As Object, e As EventArgs, Uss As String)
        Me.VisitUser = Uss
        Form3_Load(sender, e)
    End Sub


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            SQL.Connect() ' Abrir conexión UNA vez

            ' Ahora ya puedes hacer todas las consultas
            If Not SQL.User_Exists(VisitUser) Then
                MessageBox.Show("L'usuari no existeix")
                Exit Sub
            End If

            ShowCromos(page)
            LUser.Text = VisitUser
            LTeam.Text = ArrTeams(page - 1)
            LTeam.Visible = True
            LUser.Visible = True
            Lpageº.Text = page
        Catch ex As Exception
            MessageBox.Show("Error de connexió: " & ex.Message)
        Finally
            SQL.dbconn.Close() ' Tanca només un cop tot s’ha fet
        End Try
    End Sub

    Private Sub ShowCromos(Pagina As Integer)
        SQL.Connect()
        Try
            ' ¡Aquí ya está abierta la conexión!
            Dim userID As Integer = SQL.getUserID(VisitUser)
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
            dbcmd.Parameters.AddWithValue("@pages", Pagina)
            Dim adapter As New MySqlDataAdapter(dbcmd)
            Dim table As New DataTable()
            adapter.Fill(table)

            DataGridView1.DataSource = table


            Dim cromosDiferents As Integer = 0
            For Each row As DataRow In table.Rows
                If Convert.ToInt32(row("total")) > 0 Then
                    cromosDiferents += 1
                End If
            Next

            LCollectionOwned.Text = cromosDiferents & " / 18 "

            ' Aplicar colors estil Adrenalyn
            Select Case cromosDiferents
                Case 0
                    LCollectionOwned.ForeColor = Color.FromArgb(192, 0, 0)         ' 🔴 Vermell intens
                Case 18
                    LCollectionOwned.ForeColor = Color.FromArgb(255, 215, 0)       ' ✨ Or brillant
                Case Else
                    LCollectionOwned.ForeColor = Color.FromArgb(0, 102, 204)       ' 🟦 Blau Adrenalyn
            End Select

            ' Format extra per estil
            LCollectionOwned.Font = New Font(LCollectionOwned.Font.FontFamily, 12, FontStyle.Bold)


            DataGridView1.Columns(0).HeaderText = "Cromo ID"
            DataGridView1.Columns(1).HeaderText = "Nom Jugador"
            DataGridView1.Columns(2).HeaderText = "Quantitat"
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            SQL.dbconn.Close()
        End Try
    End Sub


    Private Sub LTeam_Click(sender As Object, e As EventArgs) Handles LTeam.Click

    End Sub
    Private Sub PreviousPage(sender As Object, e As EventArgs) Handles Button2.Click

        If page > 1 Then

            If page = 2 Then
                Button2.Hide()
            End If
            Button1.Show()
            page -= 1
            ShowCromos(page)
            LTeam.Text = ArrTeams(page - 1)
            Lpageº.Text = page

        End If
    End Sub
    Private Sub NextPage(sender As Object, e As EventArgs) Handles Button1.Click
        If page < 20 Then

            If page = 19 Then
                Button1.Hide()
            End If
            Button2.Show()
            page += 1
            ShowCromos(page)
            LTeam.Text = ArrTeams(page - 1)
            Lpageº.Text = page
        End If
    End Sub

    Private Sub BBack_Click(sender As Object, e As EventArgs) Handles BBack.Click
        Form2.Form2_LoadUser(sender, e, User)
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub LQuantity_Click(sender As Object, e As EventArgs)

    End Sub
End Class