<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fB6
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
        Me.tbNum = New System.Windows.Forms.TextBox()
        Me.btnCalcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblResul
        '
        Me.lblResul.Location = New System.Drawing.Point(13, 65)
        Me.lblResul.Name = "lblResul"
        Me.lblResul.Size = New System.Drawing.Size(100, 23)
        Me.lblResul.TabIndex = 0
        Me.lblResul.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'tbNum
        '
        Me.tbNum.Location = New System.Drawing.Point(13, 13)
        Me.tbNum.Name = "tbNum"
        Me.tbNum.Size = New System.Drawing.Size(100, 20)
        Me.tbNum.TabIndex = 1
        '
        'btnCalcular
        '
        Me.btnCalcular.Location = New System.Drawing.Point(26, 39)
        Me.btnCalcular.Name = "btnCalcular"
        Me.btnCalcular.Size = New System.Drawing.Size(75, 23)
        Me.btnCalcular.TabIndex = 2
        Me.btnCalcular.Text = "Calcular"
        Me.btnCalcular.UseVisualStyleBackColor = True
        '
        'fB6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(128, 98)
        Me.Controls.Add(Me.btnCalcular)
        Me.Controls.Add(Me.tbNum)
        Me.Controls.Add(Me.lblResul)
        Me.Name = "fB6"
        Me.Text = "Ejercicio B6"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblResul As Label
    Friend WithEvents tbNum As TextBox
    Friend WithEvents btnCalcular As Button
End Class
