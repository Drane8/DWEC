<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fC1
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
        Me.btnNumeros.Size = New System.Drawing.Size(95, 64)
        Me.btnNumeros.TabIndex = 0
        Me.btnNumeros.Text = "Introducir numeros"
        Me.btnNumeros.UseVisualStyleBackColor = True
        '
        'lblResul
        '
        Me.lblResul.AutoSize = True
        Me.lblResul.Location = New System.Drawing.Point(12, 80)
        Me.lblResul.Name = "lblResul"
        Me.lblResul.Size = New System.Drawing.Size(96, 13)
        Me.lblResul.TabIndex = 1
        Me.lblResul.Text = "Numeros positivos:"
        '
        'fC1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(120, 267)
        Me.Controls.Add(Me.lblResul)
        Me.Controls.Add(Me.btnNumeros)
        Me.Name = "fC1"
        Me.Text = "Ejercicio C1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNumeros As Button
    Friend WithEvents lblResul As Label
End Class
