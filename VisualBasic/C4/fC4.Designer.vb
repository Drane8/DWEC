<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fC4
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
        Me.lbAlumnos = New System.Windows.Forms.ListBox()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.tbNota = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnNota = New System.Windows.Forms.Button()
        Me.btnMedia = New System.Windows.Forms.Button()
        Me.lblMedia = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbAlumnos
        '
        Me.lbAlumnos.FormattingEnabled = True
        Me.lbAlumnos.Location = New System.Drawing.Point(13, 13)
        Me.lbAlumnos.Name = "lbAlumnos"
        Me.lbAlumnos.Size = New System.Drawing.Size(113, 238)
        Me.lbAlumnos.TabIndex = 0
        '
        'tbNombre
        '
        Me.tbNombre.Location = New System.Drawing.Point(133, 13)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(100, 20)
        Me.tbNombre.TabIndex = 1
        '
        'tbNota
        '
        Me.tbNota.Location = New System.Drawing.Point(133, 40)
        Me.tbNota.Name = "tbNota"
        Me.tbNota.Size = New System.Drawing.Size(100, 20)
        Me.tbNota.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(240, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(247, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nota"
        '
        'btnNota
        '
        Me.btnNota.Location = New System.Drawing.Point(133, 66)
        Me.btnNota.Name = "btnNota"
        Me.btnNota.Size = New System.Drawing.Size(151, 23)
        Me.btnNota.TabIndex = 5
        Me.btnNota.Text = "Añadir nota"
        Me.btnNota.UseVisualStyleBackColor = True
        '
        'btnMedia
        '
        Me.btnMedia.Location = New System.Drawing.Point(133, 95)
        Me.btnMedia.Name = "btnMedia"
        Me.btnMedia.Size = New System.Drawing.Size(151, 40)
        Me.btnMedia.TabIndex = 6
        Me.btnMedia.Text = "Calcular media"
        Me.btnMedia.UseVisualStyleBackColor = True
        '
        'lblMedia
        '
        Me.lblMedia.Location = New System.Drawing.Point(133, 143)
        Me.lblMedia.Name = "lblMedia"
        Me.lblMedia.Size = New System.Drawing.Size(151, 23)
        Me.lblMedia.TabIndex = 7
        Me.lblMedia.Text = "Media: 00.00"
        Me.lblMedia.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'fC4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(293, 263)
        Me.Controls.Add(Me.lblMedia)
        Me.Controls.Add(Me.btnMedia)
        Me.Controls.Add(Me.btnNota)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbNota)
        Me.Controls.Add(Me.tbNombre)
        Me.Controls.Add(Me.lbAlumnos)
        Me.Name = "fC4"
        Me.Text = "Ejercicio C4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbAlumnos As ListBox
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents tbNota As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnNota As Button
    Friend WithEvents btnMedia As Button
    Friend WithEvents lblMedia As Label
End Class
