<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TBoxUsername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTrade = New System.Windows.Forms.Button()
        Me.BVisit = New System.Windows.Forms.Button()
        Me.LUser = New System.Windows.Forms.Label()
        Me.BLog_out = New System.Windows.Forms.Button()
        Me.BExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(28, 79)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(182, 81)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TBoxUsername
        '
        Me.TBoxUsername.Location = New System.Drawing.Point(303, 43)
        Me.TBoxUsername.Name = "TBoxUsername"
        Me.TBoxUsername.Size = New System.Drawing.Size(143, 20)
        Me.TBoxUsername.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Label1"
        '
        'BTrade
        '
        Me.BTrade.Location = New System.Drawing.Point(226, 79)
        Me.BTrade.Name = "BTrade"
        Me.BTrade.Size = New System.Drawing.Size(107, 81)
        Me.BTrade.TabIndex = 6
        Me.BTrade.Text = "Intercanvi"
        Me.BTrade.UseVisualStyleBackColor = True
        '
        'BVisit
        '
        Me.BVisit.Location = New System.Drawing.Point(339, 79)
        Me.BVisit.Name = "BVisit"
        Me.BVisit.Size = New System.Drawing.Size(107, 81)
        Me.BVisit.TabIndex = 7
        Me.BVisit.Text = "Veure Cartes"
        Me.BVisit.UseVisualStyleBackColor = True
        '
        'LUser
        '
        Me.LUser.AutoSize = True
        Me.LUser.Location = New System.Drawing.Point(223, 50)
        Me.LUser.Name = "LUser"
        Me.LUser.Size = New System.Drawing.Size(77, 13)
        Me.LUser.TabIndex = 8
        Me.LUser.Text = "Buscar usuari: "
        '
        'BLog_out
        '
        Me.BLog_out.Location = New System.Drawing.Point(291, 215)
        Me.BLog_out.Name = "BLog_out"
        Me.BLog_out.Size = New System.Drawing.Size(88, 23)
        Me.BLog_out.TabIndex = 9
        Me.BLog_out.Text = "Close Session"
        Me.BLog_out.UseVisualStyleBackColor = True
        '
        'BExit
        '
        Me.BExit.Location = New System.Drawing.Point(385, 215)
        Me.BExit.Name = "BExit"
        Me.BExit.Size = New System.Drawing.Size(88, 22)
        Me.BExit.TabIndex = 10
        Me.BExit.Text = "Close"
        Me.BExit.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 250)
        Me.Controls.Add(Me.BExit)
        Me.Controls.Add(Me.BLog_out)
        Me.Controls.Add(Me.LUser)
        Me.Controls.Add(Me.BVisit)
        Me.Controls.Add(Me.BTrade)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TBoxUsername)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TBoxUsername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BTrade As Button
    Friend WithEvents LUser As Label
    Friend WithEvents BVisit As Button
    Friend WithEvents BLog_out As Button
    Friend WithEvents BExit As Button
End Class
