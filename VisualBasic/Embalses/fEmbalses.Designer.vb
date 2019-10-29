<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fEmbalses
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
        Me.lbEmbalse = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbCapacidad = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbEmbalsado = New System.Windows.Forms.ListBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbEmbalse = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnEmbalse = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbPorcentaje = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbTotal = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnOpcion = New System.Windows.Forms.Button()
        Me.rbtnMostrar = New System.Windows.Forms.RadioButton()
        Me.rbtnEliminar = New System.Windows.Forms.RadioButton()
        Me.rbtnModificar = New System.Windows.Forms.RadioButton()
        Me.tbEmbalsado = New System.Windows.Forms.TextBox()
        Me.tbCapacidad = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Embalse"
        '
        'lbEmbalse
        '
        Me.lbEmbalse.FormattingEnabled = True
        Me.lbEmbalse.Location = New System.Drawing.Point(16, 30)
        Me.lbEmbalse.Name = "lbEmbalse"
        Me.lbEmbalse.Size = New System.Drawing.Size(95, 69)
        Me.lbEmbalse.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(117, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Capacidad"
        '
        'lbCapacidad
        '
        Me.lbCapacidad.FormattingEnabled = True
        Me.lbCapacidad.Location = New System.Drawing.Point(117, 30)
        Me.lbCapacidad.Name = "lbCapacidad"
        Me.lbCapacidad.Size = New System.Drawing.Size(56, 69)
        Me.lbCapacidad.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(179, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Embalsado"
        '
        'lbEmbalsado
        '
        Me.lbEmbalsado.FormattingEnabled = True
        Me.lbEmbalsado.Location = New System.Drawing.Point(179, 30)
        Me.lbEmbalsado.Name = "lbEmbalsado"
        Me.lbEmbalsado.Size = New System.Drawing.Size(56, 69)
        Me.lbEmbalsado.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(285, 30)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(179, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Embalsado"
        '
        'tbEmbalse
        '
        Me.tbEmbalse.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbEmbalse.Location = New System.Drawing.Point(285, 30)
        Me.tbEmbalse.Name = "tbEmbalse"
        Me.tbEmbalse.Size = New System.Drawing.Size(100, 20)
        Me.tbEmbalse.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(268, 14)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Embalse a añadir o Mostrar"
        '
        'btnEmbalse
        '
        Me.btnEmbalse.Location = New System.Drawing.Point(271, 56)
        Me.btnEmbalse.Name = "btnEmbalse"
        Me.btnEmbalse.Size = New System.Drawing.Size(132, 23)
        Me.btnEmbalse.TabIndex = 3
        Me.btnEmbalse.Text = "Añadir o Mostrar"
        Me.btnEmbalse.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(302, 82)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "% Embalsado"
        '
        'tbPorcentaje
        '
        Me.tbPorcentaje.Enabled = False
        Me.tbPorcentaje.Location = New System.Drawing.Point(285, 98)
        Me.tbPorcentaje.Name = "tbPorcentaje"
        Me.tbPorcentaje.Size = New System.Drawing.Size(100, 20)
        Me.tbPorcentaje.TabIndex = 2
        Me.tbPorcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(81, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Total embalses:"
        '
        'tbTotal
        '
        Me.tbTotal.Enabled = False
        Me.tbTotal.Location = New System.Drawing.Point(117, 116)
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.Size = New System.Drawing.Size(100, 20)
        Me.tbTotal.TabIndex = 2
        Me.tbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnOpcion)
        Me.GroupBox1.Controls.Add(Me.rbtnMostrar)
        Me.GroupBox1.Controls.Add(Me.rbtnEliminar)
        Me.GroupBox1.Controls.Add(Me.rbtnModificar)
        Me.GroupBox1.Controls.Add(Me.tbEmbalsado)
        Me.GroupBox1.Controls.Add(Me.tbCapacidad)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 142)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(233, 125)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones"
        '
        'btnOpcion
        '
        Me.btnOpcion.Location = New System.Drawing.Point(179, 20)
        Me.btnOpcion.Name = "btnOpcion"
        Me.btnOpcion.Size = New System.Drawing.Size(48, 40)
        Me.btnOpcion.TabIndex = 3
        Me.btnOpcion.Text = "Hacer"
        Me.btnOpcion.UseVisualStyleBackColor = True
        '
        'rbtnMostrar
        '
        Me.rbtnMostrar.AutoSize = True
        Me.rbtnMostrar.Location = New System.Drawing.Point(7, 66)
        Me.rbtnMostrar.Name = "rbtnMostrar"
        Me.rbtnMostrar.Size = New System.Drawing.Size(226, 17)
        Me.rbtnMostrar.TabIndex = 0
        Me.rbtnMostrar.TabStop = True
        Me.rbtnMostrar.Text = "Mostrar total Capacidad / Total embalsado"
        Me.rbtnMostrar.UseVisualStyleBackColor = True
        '
        'rbtnEliminar
        '
        Me.rbtnEliminar.AutoSize = True
        Me.rbtnEliminar.Location = New System.Drawing.Point(7, 43)
        Me.rbtnEliminar.Name = "rbtnEliminar"
        Me.rbtnEliminar.Size = New System.Drawing.Size(103, 17)
        Me.rbtnEliminar.TabIndex = 0
        Me.rbtnEliminar.TabStop = True
        Me.rbtnEliminar.Text = "Eliminar embalse"
        Me.rbtnEliminar.UseVisualStyleBackColor = True
        '
        'rbtnModificar
        '
        Me.rbtnModificar.AutoSize = True
        Me.rbtnModificar.Checked = True
        Me.rbtnModificar.Location = New System.Drawing.Point(7, 20)
        Me.rbtnModificar.Name = "rbtnModificar"
        Me.rbtnModificar.Size = New System.Drawing.Size(166, 17)
        Me.rbtnModificar.TabIndex = 0
        Me.rbtnModificar.TabStop = True
        Me.rbtnModificar.Text = "Modificar cantidad embalsada"
        Me.rbtnModificar.UseVisualStyleBackColor = True
        '
        'tbEmbalsado
        '
        Me.tbEmbalsado.Enabled = False
        Me.tbEmbalsado.Location = New System.Drawing.Point(153, 89)
        Me.tbEmbalsado.Name = "tbEmbalsado"
        Me.tbEmbalsado.Size = New System.Drawing.Size(66, 20)
        Me.tbEmbalsado.TabIndex = 2
        '
        'tbCapacidad
        '
        Me.tbCapacidad.Enabled = False
        Me.tbCapacidad.Location = New System.Drawing.Point(69, 89)
        Me.tbCapacidad.Name = "tbCapacidad"
        Me.tbCapacidad.Size = New System.Drawing.Size(66, 20)
        Me.tbCapacidad.TabIndex = 2
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(255, 142)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(148, 125)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'fEmbalses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(416, 283)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnEmbalse)
        Me.Controls.Add(Me.tbTotal)
        Me.Controls.Add(Me.tbPorcentaje)
        Me.Controls.Add(Me.tbEmbalse)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbEmbalsado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbCapacidad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbEmbalse)
        Me.Controls.Add(Me.Label1)
        Me.Name = "fEmbalses"
        Me.Text = "Embalses"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbEmbalse As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbCapacidad As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lbEmbalsado As ListBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbEmbalse As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnEmbalse As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents tbPorcentaje As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents tbTotal As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnOpcion As Button
    Friend WithEvents rbtnMostrar As RadioButton
    Friend WithEvents rbtnEliminar As RadioButton
    Friend WithEvents rbtnModificar As RadioButton
    Friend WithEvents tbEmbalsado As TextBox
    Friend WithEvents tbCapacidad As TextBox
    Friend WithEvents btnSalir As Button
End Class
