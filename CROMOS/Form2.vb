Public Class Form2
    'declare
    Dim user As String
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'initz
        user = " "
        TBoxUsername.Text = ""
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

    End Sub
End Class