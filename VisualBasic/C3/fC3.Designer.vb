<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fC3
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
        Me.lblMatriz = New System.Windows.Forms.Label()
        Me.lblResul = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblMatriz
        '
        Me.lblMatriz.AutoSize = True
        Me.lblMatriz.Location = New System.Drawing.Point(13, 13)
        Me.lblMatriz.Name = "lblMatriz"
        Me.lblMatriz.Size = New System.Drawing.Size(0, 13)
        Me.lblMatriz.TabIndex = 0
        '
        'lblResul
        '
        Me.lblResul.AutoSize = True
        Me.lblResul.Location = New System.Drawing.Point(13, 80)
        Me.lblResul.Name = "lblResul"
        Me.lblResul.Size = New System.Drawing.Size(37, 13)
        Me.lblResul.TabIndex = 1
        Me.lblResul.Text = "Suma:"
        '
        'fC3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(131, 112)
        Me.Controls.Add(Me.lblResul)
        Me.Controls.Add(Me.lblMatriz)
        Me.Name = "fC3"
        Me.Text = "Ejercicio C3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMatriz As Label
    Friend WithEvents lblResul As Label
End Class
