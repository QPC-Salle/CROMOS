<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Me.LUser = New System.Windows.Forms.Label()
        Me.LTeam = New System.Windows.Forms.Label()
        Me.LCollectionOwned = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BBack = New System.Windows.Forms.Button()
        Me.Lpageº = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LUser
        '
        Me.LUser.AutoSize = True
        Me.LUser.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LUser.Location = New System.Drawing.Point(33, 17)
        Me.LUser.Name = "LUser"
        Me.LUser.Size = New System.Drawing.Size(64, 22)
        Me.LUser.TabIndex = 0
        Me.LUser.Text = "Label1"
        '
        'LTeam
        '
        Me.LTeam.AutoSize = True
        Me.LTeam.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTeam.Location = New System.Drawing.Point(35, 92)
        Me.LTeam.Name = "LTeam"
        Me.LTeam.Size = New System.Drawing.Size(86, 29)
        Me.LTeam.TabIndex = 3
        Me.LTeam.Text = "Label3"
        '
        'LCollectionOwned
        '
        Me.LCollectionOwned.AutoSize = True
        Me.LCollectionOwned.Font = New System.Drawing.Font("Microsoft Sans Serif", 17.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LCollectionOwned.Location = New System.Drawing.Point(297, 92)
        Me.LCollectionOwned.Name = "LCollectionOwned"
        Me.LCollectionOwned.Size = New System.Drawing.Size(86, 29)
        Me.LCollectionOwned.TabIndex = 4
        Me.LCollectionOwned.Text = "Label4"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(231, 608)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(43, 34)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "-->"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(137, 608)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(43, 34)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "<--"
        Me.Button2.UseVisualStyleBackColor = True
        Me.Button2.Visible = False
        '
        'BBack
        '
        Me.BBack.Location = New System.Drawing.Point(75, 42)
        Me.BBack.Name = "BBack"
        Me.BBack.Size = New System.Drawing.Size(75, 23)
        Me.BBack.TabIndex = 9
        Me.BBack.Text = "Enrere"
        Me.BBack.UseVisualStyleBackColor = True
        '
        'Lpageº
        '
        Me.Lpageº.AutoSize = True
        Me.Lpageº.Location = New System.Drawing.Point(199, 619)
        Me.Lpageº.Name = "Lpageº"
        Me.Lpageº.Size = New System.Drawing.Size(13, 13)
        Me.Lpageº.TabIndex = 10
        Me.Lpageº.Text = "1"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(40, 124)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(343, 478)
        Me.DataGridView1.TabIndex = 11
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 659)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Lpageº)
        Me.Controls.Add(Me.BBack)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LCollectionOwned)
        Me.Controls.Add(Me.LTeam)
        Me.Controls.Add(Me.LUser)
        Me.Name = "Form3"
        Me.Text = "Form3"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LUser As Label
    Friend WithEvents LTeam As Label
    Friend WithEvents LCollectionOwned As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents BBack As Button
    Friend WithEvents Lpageº As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class

