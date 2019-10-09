<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fB5
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
        Me.tbCadena = New System.Windows.Forms.TextBox()
        Me.tbCaracter = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblResul = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tbCadena
        '
        Me.tbCadena.Location = New System.Drawing.Point(12, 25)
        Me.tbCadena.Name = "tbCadena"
        Me.tbCadena.Size = New System.Drawing.Size(196, 20)
        Me.tbCadena.TabIndex = 0
        '
        'tbCaracter
        '
        Me.tbCaracter.Location = New System.Drawing.Point(97, 65)
        Me.tbCaracter.MaxLength = 1
        Me.tbCaracter.Name = "tbCaracter"
        Me.tbCaracter.Size = New System.Drawing.Size(26, 20)
        Me.tbCaracter.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Introduzca una cadena"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(53, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Introduzca un carácter"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(73, 91)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Borrar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblResul
        '
        Me.lblResul.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblResul.Location = New System.Drawing.Point(9, 117)
        Me.lblResul.Name = "lblResul"
        Me.lblResul.Size = New System.Drawing.Size(199, 105)
        Me.lblResul.TabIndex = 4
        Me.lblResul.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'fB5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(220, 230)
        Me.Controls.Add(Me.lblResul)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbCaracter)
        Me.Controls.Add(Me.tbCadena)
        Me.Name = "fB5"
        Me.Text = "Ejercicio B5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbCadena As TextBox
    Friend WithEvents tbCaracter As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents lblResul As Label
End Class
