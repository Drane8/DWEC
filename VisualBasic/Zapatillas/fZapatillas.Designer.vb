<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fZapatillas
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
        Me.lbMarca = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbRun = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbTrail = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbTotal = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbDisp = New System.Windows.Forms.TextBox()
        Me.rbtnTrail = New System.Windows.Forms.RadioButton()
        Me.rbtnRun = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbUnidades = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.chbTotal = New System.Windows.Forms.CheckBox()
        Me.tbTotal = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tbFormato = New System.Windows.Forms.TextBox()
        Me.tbMarca = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Marca"
        '
        'lbMarca
        '
        Me.lbMarca.FormattingEnabled = True
        Me.lbMarca.Location = New System.Drawing.Point(12, 25)
        Me.lbMarca.Name = "lbMarca"
        Me.lbMarca.Size = New System.Drawing.Size(120, 134)
        Me.lbMarca.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(138, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "RUNNING"
        '
        'lbRun
        '
        Me.lbRun.Enabled = False
        Me.lbRun.FormattingEnabled = True
        Me.lbRun.Location = New System.Drawing.Point(142, 25)
        Me.lbRun.Name = "lbRun"
        Me.lbRun.Size = New System.Drawing.Size(50, 134)
        Me.lbRun.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(200, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "TRAIL"
        '
        'lbTrail
        '
        Me.lbTrail.Enabled = False
        Me.lbTrail.FormattingEnabled = True
        Me.lbTrail.Location = New System.Drawing.Point(200, 25)
        Me.lbTrail.Name = "lbTrail"
        Me.lbTrail.Size = New System.Drawing.Size(50, 134)
        Me.lbTrail.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(259, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Total"
        '
        'lbTotal
        '
        Me.lbTotal.Enabled = False
        Me.lbTotal.FormattingEnabled = True
        Me.lbTotal.Location = New System.Drawing.Point(259, 25)
        Me.lbTotal.Name = "lbTotal"
        Me.lbTotal.Size = New System.Drawing.Size(50, 134)
        Me.lbTotal.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbDisp)
        Me.GroupBox1.Controls.Add(Me.rbtnTrail)
        Me.GroupBox1.Controls.Add(Me.rbtnRun)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(315, 59)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(157, 100)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Disponibilidad por Formato"
        '
        'tbDisp
        '
        Me.tbDisp.Enabled = False
        Me.tbDisp.Location = New System.Drawing.Point(74, 65)
        Me.tbDisp.Name = "tbDisp"
        Me.tbDisp.Size = New System.Drawing.Size(70, 20)
        Me.tbDisp.TabIndex = 1
        Me.tbDisp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rbtnTrail
        '
        Me.rbtnTrail.AutoSize = True
        Me.rbtnTrail.Location = New System.Drawing.Point(88, 29)
        Me.rbtnTrail.Name = "rbtnTrail"
        Me.rbtnTrail.Size = New System.Drawing.Size(56, 17)
        Me.rbtnTrail.TabIndex = 0
        Me.rbtnTrail.Text = "TRAIL"
        Me.rbtnTrail.UseVisualStyleBackColor = True
        '
        'rbtnRun
        '
        Me.rbtnRun.AutoSize = True
        Me.rbtnRun.Checked = True
        Me.rbtnRun.Location = New System.Drawing.Point(6, 29)
        Me.rbtnRun.Name = "rbtnRun"
        Me.rbtnRun.Size = New System.Drawing.Size(76, 17)
        Me.rbtnRun.TabIndex = 0
        Me.rbtnRun.TabStop = True
        Me.rbtnRun.Text = "RUNNING"
        Me.rbtnRun.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Disponibles"
        '
        'tbUnidades
        '
        Me.tbUnidades.Location = New System.Drawing.Point(171, 74)
        Me.tbUnidades.Name = "tbUnidades"
        Me.tbUnidades.Size = New System.Drawing.Size(70, 20)
        Me.tbUnidades.TabIndex = 1
        Me.tbUnidades.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(48, 77)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Unidades a comprar -->"
        '
        'chbTotal
        '
        Me.chbTotal.AutoSize = True
        Me.chbTotal.Location = New System.Drawing.Point(110, 167)
        Me.chbTotal.Name = "chbTotal"
        Me.chbTotal.Size = New System.Drawing.Size(143, 17)
        Me.chbTotal.TabIndex = 3
        Me.chbTotal.Text = "Mostrar Total General -->"
        Me.chbTotal.UseVisualStyleBackColor = True
        '
        'tbTotal
        '
        Me.tbTotal.Enabled = False
        Me.tbTotal.Location = New System.Drawing.Point(259, 165)
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.Size = New System.Drawing.Size(50, 20)
        Me.tbTotal.TabIndex = 1
        Me.tbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tbUnidades)
        Me.GroupBox2.Controls.Add(Me.tbFormato)
        Me.GroupBox2.Controls.Add(Me.tbMarca)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 191)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(297, 100)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'tbFormato
        '
        Me.tbFormato.Enabled = False
        Me.tbFormato.Location = New System.Drawing.Point(151, 45)
        Me.tbFormato.Name = "tbFormato"
        Me.tbFormato.Size = New System.Drawing.Size(114, 20)
        Me.tbFormato.TabIndex = 1
        Me.tbFormato.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbMarca
        '
        Me.tbMarca.Enabled = False
        Me.tbMarca.Location = New System.Drawing.Point(31, 45)
        Me.tbMarca.Name = "tbMarca"
        Me.tbMarca.Size = New System.Drawing.Size(114, 20)
        Me.tbMarca.TabIndex = 1
        Me.tbMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(285, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "COMPRAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(12, 298)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(145, 30)
        Me.btnNuevo.TabIndex = 5
        Me.btnNuevo.Text = "Nueva Marca"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(164, 298)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(145, 30)
        Me.btnEliminar.TabIndex = 5
        Me.btnEliminar.Text = "Eliminar Marca"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(322, 196)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(150, 132)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'fZapatillas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 344)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.tbTotal)
        Me.Controls.Add(Me.chbTotal)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbTotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbTrail)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbRun)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbMarca)
        Me.Controls.Add(Me.Label1)
        Me.Name = "fZapatillas"
        Me.Text = "Zapatillas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbMarca As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbRun As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lbTrail As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lbTotal As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbUnidades As TextBox
    Friend WithEvents rbtnTrail As RadioButton
    Friend WithEvents rbtnRun As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents chbTotal As CheckBox
    Friend WithEvents tbTotal As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tbFormato As TextBox
    Friend WithEvents tbMarca As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents tbDisp As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnSalir As Button
End Class
