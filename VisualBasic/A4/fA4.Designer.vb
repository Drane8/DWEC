<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fA4
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
        Me.tbGrados = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnConvertir = New System.Windows.Forms.Button()
        Me.lblResul = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tbGrados
        '
        Me.tbGrados.Location = New System.Drawing.Point(2, 25)
        Me.tbGrados.Name = "tbGrados"
        Me.tbGrados.Size = New System.Drawing.Size(94, 20)
        Me.tbGrados.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Introduzca ℃"
        '
        'btnConvertir
        '
        Me.btnConvertir.Location = New System.Drawing.Point(102, 25)
        Me.btnConvertir.Name = "btnConvertir"
        Me.btnConvertir.Size = New System.Drawing.Size(59, 20)
        Me.btnConvertir.TabIndex = 2
        Me.btnConvertir.Text = "Convertir"
        Me.btnConvertir.UseVisualStyleBackColor = True
        '
        'lblResul
        '
        Me.lblResul.Location = New System.Drawing.Point(167, 25)
        Me.lblResul.Name = "lblResul"
        Me.lblResul.Size = New System.Drawing.Size(100, 20)
        Me.lblResul.TabIndex = 1
        Me.lblResul.Text = "Fahrenheit: "
        Me.lblResul.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fA4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(271, 58)
        Me.Controls.Add(Me.btnConvertir)
        Me.Controls.Add(Me.lblResul)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbGrados)
        Me.Name = "fA4"
        Me.Text = "Ejercicio A4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbGrados As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnConvertir As Button
    Friend WithEvents lblResul As Label
End Class
