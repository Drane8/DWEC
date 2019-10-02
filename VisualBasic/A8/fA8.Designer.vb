<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fA8
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
        Me.tbMax = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbMin = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lblResul = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tbMax
        '
        Me.tbMax.Location = New System.Drawing.Point(59, 12)
        Me.tbMax.Name = "tbMax"
        Me.tbMax.Size = New System.Drawing.Size(25, 20)
        Me.tbMax.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Máxima"
        '
        'tbMin
        '
        Me.tbMin.Location = New System.Drawing.Point(59, 38)
        Me.tbMin.Name = "tbMin"
        Me.tbMin.Size = New System.Drawing.Size(25, 20)
        Me.tbMin.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Minima"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(90, 12)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(141, 46)
        Me.btnGuardar.TabIndex = 2
        Me.btnGuardar.Text = "Guardar temperatura"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'lblResul
        '
        Me.lblResul.Location = New System.Drawing.Point(14, 73)
        Me.lblResul.Name = "lblResul"
        Me.lblResul.Size = New System.Drawing.Size(217, 73)
        Me.lblResul.TabIndex = 4
        Me.lblResul.Text = "Total dias: 0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Media temperatura máxima: 0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Media temperatura mínima: 0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Errores:" &
    " 0" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Porcentaje de errores:  0%"
        '
        'fA8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(243, 147)
        Me.Controls.Add(Me.lblResul)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbMin)
        Me.Controls.Add(Me.tbMax)
        Me.Name = "fA8"
        Me.Text = "Ejercicio A8"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbMax As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbMin As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents lblResul As Label
End Class
