<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fA5
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
        Me.tbHoras = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbMinutos = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbSegundos = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAdelantar = New System.Windows.Forms.Button()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'tbHoras
        '
        Me.tbHoras.Location = New System.Drawing.Point(74, 9)
        Me.tbHoras.Name = "tbHoras"
        Me.tbHoras.Size = New System.Drawing.Size(32, 20)
        Me.tbHoras.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Horas"
        '
        'tbMinutos
        '
        Me.tbMinutos.Location = New System.Drawing.Point(74, 35)
        Me.tbMinutos.Name = "tbMinutos"
        Me.tbMinutos.Size = New System.Drawing.Size(32, 20)
        Me.tbMinutos.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Minutos"
        '
        'tbSegundos
        '
        Me.tbSegundos.Location = New System.Drawing.Point(74, 61)
        Me.tbSegundos.Name = "tbSegundos"
        Me.tbSegundos.Size = New System.Drawing.Size(32, 20)
        Me.tbSegundos.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Segundos"
        '
        'btnAdelantar
        '
        Me.btnAdelantar.Location = New System.Drawing.Point(126, 8)
        Me.btnAdelantar.Name = "btnAdelantar"
        Me.btnAdelantar.Size = New System.Drawing.Size(75, 45)
        Me.btnAdelantar.TabIndex = 2
        Me.btnAdelantar.Text = "Adelantar hora"
        Me.btnAdelantar.UseVisualStyleBackColor = True
        '
        'lblHora
        '
        Me.lblHora.Location = New System.Drawing.Point(126, 57)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(75, 23)
        Me.lblHora.TabIndex = 3
        Me.lblHora.Text = "00:00:00"
        Me.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fA5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(213, 94)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.btnAdelantar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbSegundos)
        Me.Controls.Add(Me.tbMinutos)
        Me.Controls.Add(Me.tbHoras)
        Me.Name = "fA5"
        Me.Text = "Ejercicio A5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbHoras As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbMinutos As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbSegundos As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAdelantar As Button
    Friend WithEvents lblHora As Label
End Class
