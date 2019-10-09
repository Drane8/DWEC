<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fB7
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
        Me.tbCadena = New System.Windows.Forms.TextBox()
        Me.btnContar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblResul
        '
        Me.lblResul.Location = New System.Drawing.Point(92, 65)
        Me.lblResul.Name = "lblResul"
        Me.lblResul.Size = New System.Drawing.Size(51, 15)
        Me.lblResul.TabIndex = 0
        Me.lblResul.Text = "0"
        Me.lblResul.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tbCadena
        '
        Me.tbCadena.Location = New System.Drawing.Point(13, 13)
        Me.tbCadena.Name = "tbCadena"
        Me.tbCadena.Size = New System.Drawing.Size(209, 20)
        Me.tbCadena.TabIndex = 1
        '
        'btnContar
        '
        Me.btnContar.Location = New System.Drawing.Point(62, 39)
        Me.btnContar.Name = "btnContar"
        Me.btnContar.Size = New System.Drawing.Size(111, 23)
        Me.btnContar.TabIndex = 2
        Me.btnContar.Text = "Contar vocales"
        Me.btnContar.UseVisualStyleBackColor = True
        '
        'fB7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(234, 90)
        Me.Controls.Add(Me.btnContar)
        Me.Controls.Add(Me.tbCadena)
        Me.Controls.Add(Me.lblResul)
        Me.Name = "fB7"
        Me.Text = "Ejercicio B7"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblResul As Label
    Friend WithEvents tbCadena As TextBox
    Friend WithEvents btnContar As Button
End Class
