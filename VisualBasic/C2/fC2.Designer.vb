<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fC2
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
        Me.btnNumeros = New System.Windows.Forms.Button()
        Me.lblResul = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnNumeros
        '
        Me.btnNumeros.Location = New System.Drawing.Point(13, 13)
        Me.btnNumeros.Name = "btnNumeros"
        Me.btnNumeros.Size = New System.Drawing.Size(95, 54)
        Me.btnNumeros.TabIndex = 0
        Me.btnNumeros.Text = "Introducir numeros"
        Me.btnNumeros.UseVisualStyleBackColor = True
        '
        'lblResul
        '
        Me.lblResul.AutoSize = True
        Me.lblResul.Location = New System.Drawing.Point(13, 74)
        Me.lblResul.Name = "lblResul"
        Me.lblResul.Size = New System.Drawing.Size(70, 39)
        Me.lblResul.TabIndex = 1
        Me.lblResul.Text = "Positivos: 0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cero: 0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Negativos : 0"
        '
        'fC2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(120, 130)
        Me.Controls.Add(Me.lblResul)
        Me.Controls.Add(Me.btnNumeros)
        Me.Name = "fC2"
        Me.Text = "Ejercicio C2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNumeros As Button
    Friend WithEvents lblResul As Label
End Class
