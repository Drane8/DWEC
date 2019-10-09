<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fB3
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
        Me.lblPregunta = New System.Windows.Forms.Label()
        Me.lblRespuesta = New System.Windows.Forms.Label()
        Me.tbNum = New System.Windows.Forms.TextBox()
        Me.btnComprobar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblPregunta
        '
        Me.lblPregunta.Location = New System.Drawing.Point(9, 9)
        Me.lblPregunta.Name = "lblPregunta"
        Me.lblPregunta.Size = New System.Drawing.Size(122, 23)
        Me.lblPregunta.TabIndex = 0
        Me.lblPregunta.Text = "¿Cuanto es XX por XX?"
        Me.lblPregunta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRespuesta
        '
        Me.lblRespuesta.Location = New System.Drawing.Point(13, 96)
        Me.lblRespuesta.Name = "lblRespuesta"
        Me.lblRespuesta.Size = New System.Drawing.Size(118, 29)
        Me.lblRespuesta.TabIndex = 1
        Me.lblRespuesta.Text = "No. Por favor inténtalo de nuevo"
        Me.lblRespuesta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbNum
        '
        Me.tbNum.Location = New System.Drawing.Point(20, 35)
        Me.tbNum.Name = "tbNum"
        Me.tbNum.Size = New System.Drawing.Size(100, 20)
        Me.tbNum.TabIndex = 2
        '
        'btnComprobar
        '
        Me.btnComprobar.Location = New System.Drawing.Point(33, 61)
        Me.btnComprobar.Name = "btnComprobar"
        Me.btnComprobar.Size = New System.Drawing.Size(75, 23)
        Me.btnComprobar.TabIndex = 3
        Me.btnComprobar.Text = "Comprobar"
        Me.btnComprobar.UseVisualStyleBackColor = True
        '
        'fB3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(142, 132)
        Me.Controls.Add(Me.btnComprobar)
        Me.Controls.Add(Me.tbNum)
        Me.Controls.Add(Me.lblRespuesta)
        Me.Controls.Add(Me.lblPregunta)
        Me.Name = "fB3"
        Me.Text = "Ejercicio B3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPregunta As Label
    Friend WithEvents lblRespuesta As Label
    Friend WithEvents tbNum As TextBox
    Friend WithEvents btnComprobar As Button
End Class
