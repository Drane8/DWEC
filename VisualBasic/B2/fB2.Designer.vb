<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fB2
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
        Me.tbNum = New System.Windows.Forms.TextBox()
        Me.tbResul = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnInvertir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbNum
        '
        Me.tbNum.Location = New System.Drawing.Point(17, 30)
        Me.tbNum.Name = "tbNum"
        Me.tbNum.Size = New System.Drawing.Size(100, 20)
        Me.tbNum.TabIndex = 0
        '
        'tbResul
        '
        Me.tbResul.Enabled = False
        Me.tbResul.Location = New System.Drawing.Point(17, 85)
        Me.tbResul.Name = "tbResul"
        Me.tbResul.Size = New System.Drawing.Size(100, 20)
        Me.tbResul.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Introduzca un número"
        '
        'btnInvertir
        '
        Me.btnInvertir.Location = New System.Drawing.Point(30, 56)
        Me.btnInvertir.Name = "btnInvertir"
        Me.btnInvertir.Size = New System.Drawing.Size(75, 23)
        Me.btnInvertir.TabIndex = 2
        Me.btnInvertir.Text = "Invertir"
        Me.btnInvertir.UseVisualStyleBackColor = True
        '
        'fB2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(135, 123)
        Me.Controls.Add(Me.btnInvertir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbResul)
        Me.Controls.Add(Me.tbNum)
        Me.Name = "fB2"
        Me.Text = "Ejercicio B2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbNum As TextBox
    Friend WithEvents tbResul As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnInvertir As Button
End Class
