<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fC6
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
        Me.lbArray = New System.Windows.Forms.ListBox()
        Me.btnInsertar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.tbValor = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lbArray
        '
        Me.lbArray.FormattingEnabled = True
        Me.lbArray.Location = New System.Drawing.Point(12, 12)
        Me.lbArray.Name = "lbArray"
        Me.lbArray.Size = New System.Drawing.Size(83, 199)
        Me.lbArray.TabIndex = 0
        '
        'btnInsertar
        '
        Me.btnInsertar.Location = New System.Drawing.Point(102, 13)
        Me.btnInsertar.Name = "btnInsertar"
        Me.btnInsertar.Size = New System.Drawing.Size(75, 23)
        Me.btnInsertar.TabIndex = 1
        Me.btnInsertar.Text = "Insertar"
        Me.btnInsertar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(103, 68)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 1
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'tbValor
        '
        Me.tbValor.Location = New System.Drawing.Point(103, 42)
        Me.tbValor.Name = "tbValor"
        Me.tbValor.Size = New System.Drawing.Size(74, 20)
        Me.tbValor.TabIndex = 2
        '
        'fC6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(190, 231)
        Me.Controls.Add(Me.tbValor)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnInsertar)
        Me.Controls.Add(Me.lbArray)
        Me.Name = "fC6"
        Me.Text = "Ejercicio C6"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbArray As ListBox
    Friend WithEvents btnInsertar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents tbValor As TextBox
End Class
