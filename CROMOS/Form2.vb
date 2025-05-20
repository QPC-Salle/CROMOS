Public Class Form2
    'declare
    Dim usuario As String = Form1.getUser()
    Dim User_Visit As String
    Dim SQL As New SQLControl()
    Public Sub Form2_LoadUser(sender As Object, e As EventArgs, User As String)
        usuario = User
        Form2_Load(sender, e)

    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        Label1.Text = usuario

        TBoxUsername.Text = " "
        BExit.Visible = True
        BTrade.Visible = True
        BVisit.Visible = True
        BLog_out.Visible = True
    End Sub


    Private Sub BLog_out_Click(sender As Object, e As EventArgs) Handles BLog_out.Click
        Form1.Form1_Load(sender, e)
        Form1.Show()
        Me.Close()

    End Sub

    Private Sub BExit_Click(sender As Object, e As EventArgs) Handles BExit.Click
        MsgBox("Gracias por usar Cromos", MsgBoxStyle.Information, "Cromos")
        Me.Close()
    End Sub

    Private Sub BTrad_Click(sender As Object, e As EventArgs) Handles BTrade.Click
        User_Visit = TBoxUsername.Text.Trim()
        Form4.Form4_LoadUser(sender, e, usuario, User_Visit)
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub BVisit_Click(sender As Object, e As EventArgs) Handles BVisit.Click
        User_Visit = TBoxUsername.Text.Trim()
        If SQL.User_Exists(User_Visit) Then
            Form3.LoadUser(sender, e, User_Visit)
            Form3.Show()
            Me.Hide()
        Else
            MsgBox("El usuario no existe", MsgBoxStyle.Critical, "Cromos")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim form3 As New Form3()
        form3.LoadUser(sender, e, usuario)
        form3.Show()
    End Sub

    Private Sub TBoxUsername_TextChanged(sender As Object, e As EventArgs) Handles TBoxUsername.TextChanged

    End Sub
End Class