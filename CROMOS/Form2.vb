Public Class Form2
    'declare
    Dim usuario As String

    Public Sub Form2_LoadUser(sender As Object, e As EventArgs, User As String)
        usuario = User
        Form2_Load(sender, e)

    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        Label1.Text = Form1.getUser()
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

    End Sub

    Private Sub BVisit_Click(sender As Object, e As EventArgs) Handles BVisit.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim form3 As New Form3()
        form3.LoadUser(sender, e, usuario)
        form3.Show()
    End Sub
End Class