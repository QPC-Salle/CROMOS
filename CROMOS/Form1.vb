Public Class Form1
    Dim Password As String
    Dim Password2 As String
    Dim User As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Password = ""
        Password2 = ""
        User = ""
    End Sub

    Private Sub BLogin_Click(sender As Object, e As EventArgs) Handles BLogin.Click
        Password = TBPassword.Text
        Password2 = TBPassword2.Text
        User = TBUser.Text
        ' Verificar si el usuario y la contraseña son correctos
        If User = "" Or Password = "" Or Password2 = "" Then
            MessageBox.Show("Por favor, complete todos los campos.")
            Form1_Load(sender, e)
            Return
        End If

        ChangeForm()

    End Sub

    Private Sub BRegister_Click(sender As Object, e As EventArgs) Handles BRegister.Click
        ChangeForm()

    End Sub

    Public Sub ChangeForm()
        Dim form2 As New Form2()
        ' Mostrar el formulario
        form2.Show()
        ' Cerrar el formulario actual
        Me.Hide()
    End Sub
End Class
