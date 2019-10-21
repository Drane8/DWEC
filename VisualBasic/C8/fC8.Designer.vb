<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fC8
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
        Me.lblResul = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblResul
        '
        Me.lblResul.AutoSize = True
        Me.lblResul.Location = New System.Drawing.Point(12, 9)
        Me.lblResul.Name = "lblResul"
        Me.lblResul.Size = New System.Drawing.Size(0, 13)
        Me.lblResul.TabIndex = 0
        '
        'fC8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 200)
        Me.Controls.Add(Me.lblResul)
        Me.Name = "fC8"
        Me.Text = "Ejercicio C8"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblResul As Label
End Class
