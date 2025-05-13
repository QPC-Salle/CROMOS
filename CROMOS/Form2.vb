Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class