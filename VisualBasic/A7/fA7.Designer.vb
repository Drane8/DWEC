<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fA7
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
        Me.tbPrimos = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'tbPrimos
        '
        Me.tbPrimos.Location = New System.Drawing.Point(12, 12)
        Me.tbPrimos.Multiline = True
        Me.tbPrimos.Name = "tbPrimos"
        Me.tbPrimos.ReadOnly = True
        Me.tbPrimos.Size = New System.Drawing.Size(157, 393)
        Me.tbPrimos.TabIndex = 0
        '
        'fA7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(183, 417)
        Me.Controls.Add(Me.tbPrimos)
        Me.Name = "fA7"
        Me.Text = "Ejercicio A7"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbPrimos As TextBox
End Class
