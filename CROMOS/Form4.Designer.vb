<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.DGVUser = New System.Windows.Forms.DataGridView()
        Me.BCancelTrade = New System.Windows.Forms.Button()
        Me.BTrade = New System.Windows.Forms.Button()
        Me.LBUser = New System.Windows.Forms.ListBox()
        Me.LBVUser = New System.Windows.Forms.ListBox()
        Me.DGVVisitUser = New System.Windows.Forms.DataGridView()
        Me.LUser = New System.Windows.Forms.Label()
        Me.LVUser = New System.Windows.Forms.Label()
        CType(Me.DGVUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGVVisitUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVUser
        '
        Me.DGVUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVUser.Location = New System.Drawing.Point(169, 78)
        Me.DGVUser.Name = "DGVUser"
        Me.DGVUser.Size = New System.Drawing.Size(307, 282)
        Me.DGVUser.TabIndex = 0
        '
        'BCancelTrade
        '
        Me.BCancelTrade.Location = New System.Drawing.Point(349, 380)
        Me.BCancelTrade.Name = "BCancelTrade"
        Me.BCancelTrade.Size = New System.Drawing.Size(127, 69)
        Me.BCancelTrade.TabIndex = 2
        Me.BCancelTrade.Text = "Cancela"
        Me.BCancelTrade.UseVisualStyleBackColor = True
        '
        'BTrade
        '
        Me.BTrade.Location = New System.Drawing.Point(496, 380)
        Me.BTrade.Name = "BTrade"
        Me.BTrade.Size = New System.Drawing.Size(127, 69)
        Me.BTrade.TabIndex = 3
        Me.BTrade.Text = "Intercanvi"
        Me.BTrade.UseVisualStyleBackColor = True
        '
        'LBUser
        '
        Me.LBUser.FormattingEnabled = True
        Me.LBUser.Location = New System.Drawing.Point(40, 44)
        Me.LBUser.Name = "LBUser"
        Me.LBUser.Size = New System.Drawing.Size(120, 316)
        Me.LBUser.TabIndex = 4
        '
        'LBVUser
        '
        Me.LBVUser.FormattingEnabled = True
        Me.LBVUser.Location = New System.Drawing.Point(820, 44)
        Me.LBVUser.Name = "LBVUser"
        Me.LBVUser.Size = New System.Drawing.Size(115, 316)
        Me.LBVUser.TabIndex = 5
        '
        'DGVVisitUser
        '
        Me.DGVVisitUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVVisitUser.Location = New System.Drawing.Point(496, 78)
        Me.DGVVisitUser.Name = "DGVVisitUser"
        Me.DGVVisitUser.Size = New System.Drawing.Size(318, 282)
        Me.DGVVisitUser.TabIndex = 6
        '
        'LUser
        '
        Me.LUser.AutoSize = True
        Me.LUser.Location = New System.Drawing.Point(166, 46)
        Me.LUser.Name = "LUser"
        Me.LUser.Size = New System.Drawing.Size(39, 13)
        Me.LUser.TabIndex = 13
        Me.LUser.Text = "Label1"
        '
        'LVUser
        '
        Me.LVUser.AutoSize = True
        Me.LVUser.Location = New System.Drawing.Point(493, 46)
        Me.LVUser.Name = "LVUser"
        Me.LVUser.Size = New System.Drawing.Size(39, 13)
        Me.LVUser.TabIndex = 14
        Me.LVUser.Text = "Label2"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(971, 540)
        Me.Controls.Add(Me.LVUser)
        Me.Controls.Add(Me.LUser)
        Me.Controls.Add(Me.DGVVisitUser)
        Me.Controls.Add(Me.LBVUser)
        Me.Controls.Add(Me.LBUser)
        Me.Controls.Add(Me.BTrade)
        Me.Controls.Add(Me.BCancelTrade)
        Me.Controls.Add(Me.DGVUser)
        Me.Name = "Form4"
        Me.Text = "Form4"
        CType(Me.DGVUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGVVisitUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVUser As DataGridView
    Friend WithEvents BCancelTrade As Button
    Friend WithEvents BTrade As Button
    Friend WithEvents LBUser As ListBox
    Friend WithEvents LBVUser As ListBox
    Friend WithEvents DGVVisitUser As DataGridView
    Friend WithEvents LUser As Label
    Friend WithEvents LVUser As Label
End Class
