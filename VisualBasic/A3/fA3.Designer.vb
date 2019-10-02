<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fA3
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
        Me.tbNum1 = New System.Windows.Forms.TextBox()
        Me.tbNum2 = New System.Windows.Forms.TextBox()
        Me.tbNum3 = New System.Windows.Forms.TextBox()
        Me.lblMayor = New System.Windows.Forms.Label()
        Me.lblMedio = New System.Windows.Forms.Label()
        Me.lblMenor = New System.Windows.Forms.Label()
        Me.btnOrdenar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbNum1
        '
        Me.tbNum1.Location = New System.Drawing.Point(13, 13)
        Me.tbNum1.Name = "tbNum1"
        Me.tbNum1.Size = New System.Drawing.Size(100, 20)
        Me.tbNum1.TabIndex = 0
        '
        'tbNum2
        '
        Me.tbNum2.Location = New System.Drawing.Point(13, 40)
        Me.tbNum2.Name = "tbNum2"
        Me.tbNum2.Size = New System.Drawing.Size(100, 20)
        Me.tbNum2.TabIndex = 1
        '
        'tbNum3
        '
        Me.tbNum3.Location = New System.Drawing.Point(13, 66)
        Me.tbNum3.Name = "tbNum3"
        Me.tbNum3.Size = New System.Drawing.Size(100, 20)
        Me.tbNum3.TabIndex = 1
        '
        'lblMayor
        '
        Me.lblMayor.Location = New System.Drawing.Point(153, 13)
        Me.lblMayor.Name = "lblMayor"
        Me.lblMayor.Size = New System.Drawing.Size(100, 20)
        Me.lblMayor.TabIndex = 2
        Me.lblMayor.Text = "Mayor: "
        Me.lblMayor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMedio
        '
        Me.lblMedio.Location = New System.Drawing.Point(153, 40)
        Me.lblMedio.Name = "lblMedio"
        Me.lblMedio.Size = New System.Drawing.Size(100, 20)
        Me.lblMedio.TabIndex = 2
        Me.lblMedio.Text = "Mediano: "
        Me.lblMedio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMenor
        '
        Me.lblMenor.Location = New System.Drawing.Point(153, 66)
        Me.lblMenor.Name = "lblMenor"
        Me.lblMenor.Size = New System.Drawing.Size(100, 20)
        Me.lblMenor.TabIndex = 2
        Me.lblMenor.Text = "Menor:"
        Me.lblMenor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnOrdenar
        '
        Me.btnOrdenar.Location = New System.Drawing.Point(78, 107)
        Me.btnOrdenar.Name = "btnOrdenar"
        Me.btnOrdenar.Size = New System.Drawing.Size(117, 23)
        Me.btnOrdenar.TabIndex = 3
        Me.btnOrdenar.Text = "Ordenar"
        Me.btnOrdenar.UseVisualStyleBackColor = True
        '
        'fA3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(277, 142)
        Me.Controls.Add(Me.btnOrdenar)
        Me.Controls.Add(Me.lblMenor)
        Me.Controls.Add(Me.lblMedio)
        Me.Controls.Add(Me.lblMayor)
        Me.Controls.Add(Me.tbNum3)
        Me.Controls.Add(Me.tbNum2)
        Me.Controls.Add(Me.tbNum1)
        Me.Name = "fA3"
        Me.Text = "fA3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbNum1 As TextBox
    Friend WithEvents tbNum2 As TextBox
    Friend WithEvents tbNum3 As TextBox
    Friend WithEvents lblMayor As Label
    Friend WithEvents lblMedio As Label
    Friend WithEvents lblMenor As Label
    Friend WithEvents btnOrdenar As Button
End Class
