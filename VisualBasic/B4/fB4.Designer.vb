<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fB4
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblResul = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tbNum
        '
        Me.tbNum.Location = New System.Drawing.Point(12, 12)
        Me.tbNum.Name = "tbNum"
        Me.tbNum.Size = New System.Drawing.Size(100, 20)
        Me.tbNum.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(118, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 20)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Contar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblResul
        '
        Me.lblResul.AutoSize = True
        Me.lblResul.Location = New System.Drawing.Point(199, 15)
        Me.lblResul.Name = "lblResul"
        Me.lblResul.Size = New System.Drawing.Size(13, 13)
        Me.lblResul.TabIndex = 2
        Me.lblResul.Text = "0"
        '
        'fB4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(270, 50)
        Me.Controls.Add(Me.lblResul)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tbNum)
        Me.Name = "fB4"
        Me.Text = "Ejercicio B4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbNum As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents lblResul As Label
End Class
