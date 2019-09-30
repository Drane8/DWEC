<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fOperaciones
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
        Me.tb1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tb2 = New System.Windows.Forms.TextBox()
        Me.btnOpe = New System.Windows.Forms.Button()
        Me.lblResul = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tb1
        '
        Me.tb1.Location = New System.Drawing.Point(69, 19)
        Me.tb1.Name = "tb1"
        Me.tb1.Size = New System.Drawing.Size(100, 20)
        Me.tb1.TabIndex = 0
        Me.tb1.Text = "0"
        Me.tb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Numero 1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Numero 2"
        '
        'tb2
        '
        Me.tb2.Location = New System.Drawing.Point(69, 45)
        Me.tb2.Name = "tb2"
        Me.tb2.Size = New System.Drawing.Size(100, 20)
        Me.tb2.TabIndex = 2
        Me.tb2.Text = "0"
        Me.tb2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnOpe
        '
        Me.btnOpe.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.25!)
        Me.btnOpe.Location = New System.Drawing.Point(175, 22)
        Me.btnOpe.Name = "btnOpe"
        Me.btnOpe.Size = New System.Drawing.Size(94, 34)
        Me.btnOpe.TabIndex = 6
        Me.btnOpe.Text = "+"
        Me.btnOpe.UseVisualStyleBackColor = True
        '
        'lblResul
        '
        Me.lblResul.AutoSize = True
        Me.lblResul.Location = New System.Drawing.Point(275, 36)
        Me.lblResul.Name = "lblResul"
        Me.lblResul.Size = New System.Drawing.Size(73, 13)
        Me.lblResul.TabIndex = 10
        Me.lblResul.Text = "RESULTADO"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(125, 71)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(94, 23)
        Me.btnSalir.TabIndex = 11
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'fOperaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(356, 109)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblResul)
        Me.Controls.Add(Me.btnOpe)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tb2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tb1)
        Me.Name = "fOperaciones"
        Me.Text = "Operaciones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tb1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tb2 As TextBox
    Friend WithEvents btnOpe As Button
    Friend WithEvents lblResul As Label
    Friend WithEvents btnSalir As Button
End Class
