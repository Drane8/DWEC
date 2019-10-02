<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fA9
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbNum = New System.Windows.Forms.TextBox()
        Me.btnComprobar = New System.Windows.Forms.Button()
        Me.lblResul = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(110, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Introduzca un número"
        '
        'tbNum
        '
        Me.tbNum.Location = New System.Drawing.Point(12, 25)
        Me.tbNum.Name = "tbNum"
        Me.tbNum.Size = New System.Drawing.Size(160, 20)
        Me.tbNum.TabIndex = 1
        '
        'btnComprobar
        '
        Me.btnComprobar.Location = New System.Drawing.Point(55, 51)
        Me.btnComprobar.Name = "btnComprobar"
        Me.btnComprobar.Size = New System.Drawing.Size(75, 23)
        Me.btnComprobar.TabIndex = 2
        Me.btnComprobar.Text = "Comprobar"
        Me.btnComprobar.UseVisualStyleBackColor = True
        '
        'lblResul
        '
        Me.lblResul.Location = New System.Drawing.Point(12, 77)
        Me.lblResul.Name = "lblResul"
        Me.lblResul.Size = New System.Drawing.Size(160, 23)
        Me.lblResul.TabIndex = 3
        Me.lblResul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fA9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(184, 122)
        Me.Controls.Add(Me.lblResul)
        Me.Controls.Add(Me.btnComprobar)
        Me.Controls.Add(Me.tbNum)
        Me.Controls.Add(Me.Label1)
        Me.Name = "fA9"
        Me.Text = "Ejercicio A9"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tbNum As TextBox
    Friend WithEvents btnComprobar As Button
    Friend WithEvents lblResul As Label
End Class
