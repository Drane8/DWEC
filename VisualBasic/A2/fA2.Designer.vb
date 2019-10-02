<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fA2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnComprobar = New System.Windows.Forms.Button()
        Me.lblResul = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tbNum1
        '
        Me.tbNum1.Location = New System.Drawing.Point(12, 38)
        Me.tbNum1.Name = "tbNum1"
        Me.tbNum1.Size = New System.Drawing.Size(100, 20)
        Me.tbNum1.TabIndex = 0
        '
        'tbNum2
        '
        Me.tbNum2.Location = New System.Drawing.Point(123, 38)
        Me.tbNum2.Name = "tbNum2"
        Me.tbNum2.Size = New System.Drawing.Size(100, 20)
        Me.tbNum2.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(58, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Introduzca dos numeros"
        '
        'btnComprobar
        '
        Me.btnComprobar.Location = New System.Drawing.Point(81, 64)
        Me.btnComprobar.Name = "btnComprobar"
        Me.btnComprobar.Size = New System.Drawing.Size(75, 23)
        Me.btnComprobar.TabIndex = 2
        Me.btnComprobar.Text = "Comprobar"
        Me.btnComprobar.UseVisualStyleBackColor = True
        '
        'lblResul
        '
        Me.lblResul.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblResul.Location = New System.Drawing.Point(58, 103)
        Me.lblResul.Name = "lblResul"
        Me.lblResul.Size = New System.Drawing.Size(120, 35)
        Me.lblResul.TabIndex = 3
        Me.lblResul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fA2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(235, 154)
        Me.Controls.Add(Me.lblResul)
        Me.Controls.Add(Me.btnComprobar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbNum2)
        Me.Controls.Add(Me.tbNum1)
        Me.MaximumSize = New System.Drawing.Size(251, 193)
        Me.MinimumSize = New System.Drawing.Size(251, 193)
        Me.Name = "fA2"
        Me.Text = "Ejercicio A2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbNum1 As TextBox
    Friend WithEvents tbNum2 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnComprobar As Button
    Friend WithEvents lblResul As Label
End Class
