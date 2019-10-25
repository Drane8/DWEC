<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fPortada
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
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.pbPortada = New System.Windows.Forms.PictureBox()
        CType(Me.pbPortada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(12, 418)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(296, 48)
        Me.btnSalir.TabIndex = 0
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'pbPortada
        '
        Me.pbPortada.Location = New System.Drawing.Point(13, 13)
        Me.pbPortada.Name = "pbPortada"
        Me.pbPortada.Size = New System.Drawing.Size(295, 399)
        Me.pbPortada.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPortada.TabIndex = 1
        Me.pbPortada.TabStop = False
        '
        'fPortada
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(320, 478)
        Me.Controls.Add(Me.pbPortada)
        Me.Controls.Add(Me.btnSalir)
        Me.Name = "fPortada"
        Me.Text = "Portada"
        CType(Me.pbPortada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSalir As Button
    Friend WithEvents pbPortada As PictureBox
End Class
