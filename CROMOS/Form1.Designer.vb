<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBUser = New System.Windows.Forms.TextBox()
        Me.TBPassword = New System.Windows.Forms.TextBox()
        Me.TBPassword2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BRegister = New System.Windows.Forms.Button()
        Me.BLogin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuari"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(76, 150)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contrasenya"
        '
        'TBUser
        '
        Me.TBUser.Location = New System.Drawing.Point(235, 103)
        Me.TBUser.Name = "TBUser"
        Me.TBUser.Size = New System.Drawing.Size(100, 20)
        Me.TBUser.TabIndex = 2
        '
        'TBPassword
        '
        Me.TBPassword.Location = New System.Drawing.Point(235, 147)
        Me.TBPassword.Name = "TBPassword"
        Me.TBPassword.Size = New System.Drawing.Size(100, 20)
        Me.TBPassword.TabIndex = 3
        '
        'TBPassword2
        '
        Me.TBPassword2.Location = New System.Drawing.Point(235, 195)
        Me.TBPassword2.Name = "TBPassword2"
        Me.TBPassword2.Size = New System.Drawing.Size(100, 20)
        Me.TBPassword2.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(76, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Contrasenya un altre cop"
        '
        'BRegister
        '
        Me.BRegister.Location = New System.Drawing.Point(235, 263)
        Me.BRegister.Name = "BRegister"
        Me.BRegister.Size = New System.Drawing.Size(99, 48)
        Me.BRegister.TabIndex = 6
        Me.BRegister.Text = "Registrarse"
        Me.BRegister.UseVisualStyleBackColor = True
        '
        'BLogin
        '
        Me.BLogin.Location = New System.Drawing.Point(79, 263)
        Me.BLogin.Name = "BLogin"
        Me.BLogin.Size = New System.Drawing.Size(99, 48)
        Me.BLogin.TabIndex = 7
        Me.BLogin.Text = "Inicia Sessio"
        Me.BLogin.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 361)
        Me.Controls.Add(Me.BLogin)
        Me.Controls.Add(Me.BRegister)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TBPassword2)
        Me.Controls.Add(Me.TBPassword)
        Me.Controls.Add(Me.TBUser)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Inici Sessio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TBUser As TextBox
    Friend WithEvents TBPassword As TextBox
    Friend WithEvents TBPassword2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BRegister As Button
    Friend WithEvents BLogin As Button
End Class
