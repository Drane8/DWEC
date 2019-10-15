<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fC7
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
        Me.lvArrayOriginal = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'lvArrayOriginal
        '
        Me.lvArrayOriginal.HideSelection = False
        Me.lvArrayOriginal.Location = New System.Drawing.Point(12, 12)
        Me.lvArrayOriginal.Name = "lvArrayOriginal"
        Me.lvArrayOriginal.Size = New System.Drawing.Size(412, 381)
        Me.lvArrayOriginal.TabIndex = 0
        Me.lvArrayOriginal.TileSize = New System.Drawing.Size(30, 30)
        Me.lvArrayOriginal.UseCompatibleStateImageBehavior = False
        Me.lvArrayOriginal.View = System.Windows.Forms.View.SmallIcon
        '
        'fC7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 450)
        Me.Controls.Add(Me.lvArrayOriginal)
        Me.Name = "fC7"
        Me.Text = "Ejercicio C7"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lvArrayOriginal As ListView
End Class
