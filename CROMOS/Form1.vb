Public Class Form1
    Dim SQL As New SQLControl

    Dim Password As String
    Dim Password2 As String
    Dim User As String


    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Password = ""
        Password2 = ""
        User = ""
        TBPassword.Text = ""
        TBPassword2.Text = ""
        TBUser.Text = ""
        'If SQL.HasConnection() Then
        'MsgBox("Conexió correcta")
        'End If
    End Sub

    Private Sub BLogin_Click(sender As Object, e As EventArgs) Handles BLogin.Click
        Password = TBPassword.Text
        Password2 = TBPassword2.Text
        User = TBUser.Text
        ' Verificar si el usuario y la contraseña son correctos
        If User = "" Or Password = "" Or Password2 = "" Then
            MessageBox.Show("Por favor, complete todos los campos.")
            Form1_Load(sender, e)
        Else
            If SQL.User_Exists(User, Password) Then
                MessageBox.Show("Usuario y contraseña correctos")
                ChangeForm(sender, e)
            Else
                MessageBox.Show("Usuario o contraseña incorrectos")
                Form1_Load(sender, e)
            End If

        End If



    End Sub

    Private Sub BRegister_Click(sender As Object, e As EventArgs) Handles BRegister.Click
        Password = TBPassword.Text
        Password2 = TBPassword2.Text
        User = TBUser.Text
        ' Verificar si el usuario y la contraseña son correctos
        If SQL.User_Exists(User, Password) And Password! = Password2 Then
            MessageBox.Show("Usuario ya existe")
            Form1_Load(sender, e)
            Return
        Else
            If User = "" Or Password = "" Or Password2 = "" Then
                MessageBox.Show("Por favor, complete todos los campos.")
                Form1_Load(sender, e)
            Else
                SQL.CreateUser(User, Password)
                MessageBox.Show("Usuario creado correctamente")
                Form1_Load(sender, e)
                ChangeForm(sender, e)
            End If

        End If

    End Sub

    Public Sub ChangeForm(sender As Object, e As EventArgs)
        Dim form2 As New Form2()
        ' Mostrar el formulario
        form2.Show()
        form2.Form2_LoadUser(sender, e, User)

        ' Cerrar el formulario 
        Me.Hide()
    End Sub
    Public Function getUser() As String

        Return Me.User
    End Function
End Class
