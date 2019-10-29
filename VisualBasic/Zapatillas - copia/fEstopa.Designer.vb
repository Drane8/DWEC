<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fEstopa
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
        Me.lbAlbum = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbCD = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbVinilo = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbTotal = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbDisp = New System.Windows.Forms.TextBox()
        Me.rbtnVinilo = New System.Windows.Forms.RadioButton()
        Me.rbtnCD = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbUnidades = New System.Windows.Forms.TextBox()
        Me.chbTotal = New System.Windows.Forms.CheckBox()
        Me.tbTotal = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Álbum"
        '
        'lbAlbum
        '
        Me.lbAlbum.FormattingEnabled = True
        Me.lbAlbum.Location = New System.Drawing.Point(12, 25)
        Me.lbAlbum.Name = "lbAlbum"
        Me.lbAlbum.Size = New System.Drawing.Size(120, 134)
        Me.lbAlbum.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(142, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "CD"
        '
        'lbCD
        '
        Me.lbCD.Enabled = False
        Me.lbCD.FormattingEnabled = True
        Me.lbCD.Location = New System.Drawing.Point(142, 25)
        Me.lbCD.Name = "lbCD"
        Me.lbCD.Size = New System.Drawing.Size(50, 134)
        Me.lbCD.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(200, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "VINILO"
        '
        'lbVinilo
        '
        Me.lbVinilo.Enabled = False
        Me.lbVinilo.FormattingEnabled = True
        Me.lbVinilo.Location = New System.Drawing.Point(200, 25)
        Me.lbVinilo.Name = "lbVinilo"
        Me.lbVinilo.Size = New System.Drawing.Size(50, 134)
        Me.lbVinilo.TabIndex = 1
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
        Me.GroupBox1.Controls.Add(Me.rbtnVinilo)
        Me.GroupBox1.Controls.Add(Me.rbtnCD)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 170)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(142, 100)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Formato"
        '
        'tbDisp
        '
        Me.tbDisp.Enabled = False
        Me.tbDisp.Location = New System.Drawing.Point(74, 65)
        Me.tbDisp.Name = "tbDisp"
        Me.tbDisp.Size = New System.Drawing.Size(62, 20)
        Me.tbDisp.TabIndex = 1
        Me.tbDisp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rbtnVinilo
        '
        Me.rbtnVinilo.AutoSize = True
        Me.rbtnVinilo.Location = New System.Drawing.Point(88, 29)
        Me.rbtnVinilo.Name = "rbtnVinilo"
        Me.rbtnVinilo.Size = New System.Drawing.Size(50, 17)
        Me.rbtnVinilo.TabIndex = 0
        Me.rbtnVinilo.Text = "Vinilo"
        Me.rbtnVinilo.UseVisualStyleBackColor = True
        '
        'rbtnCD
        '
        Me.rbtnCD.AutoSize = True
        Me.rbtnCD.Checked = True
        Me.rbtnCD.Location = New System.Drawing.Point(6, 29)
        Me.rbtnCD.Name = "rbtnCD"
        Me.rbtnCD.Size = New System.Drawing.Size(40, 17)
        Me.rbtnCD.TabIndex = 0
        Me.rbtnCD.TabStop = True
        Me.rbtnCD.Text = "CD"
        Me.rbtnCD.UseVisualStyleBackColor = True
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
        Me.tbUnidades.Location = New System.Drawing.Point(85, 46)
        Me.tbUnidades.Name = "tbUnidades"
        Me.tbUnidades.Size = New System.Drawing.Size(54, 20)
        Me.tbUnidades.TabIndex = 1
        Me.tbUnidades.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chbTotal
        '
        Me.chbTotal.AutoSize = True
        Me.chbTotal.Location = New System.Drawing.Point(9, 27)
        Me.chbTotal.Name = "chbTotal"
        Me.chbTotal.Size = New System.Drawing.Size(90, 17)
        Me.chbTotal.TabIndex = 3
        Me.chbTotal.Text = "Total General"
        Me.chbTotal.UseVisualStyleBackColor = True
        '
        'tbTotal
        '
        Me.tbTotal.Enabled = False
        Me.tbTotal.Location = New System.Drawing.Point(29, 60)
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.Size = New System.Drawing.Size(50, 20)
        Me.tbTotal.TabIndex = 1
        Me.tbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tbUnidades)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Location = New System.Drawing.Point(164, 170)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(145, 100)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 78)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "COMPRAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(12, 276)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(145, 30)
        Me.btnNuevo.TabIndex = 5
        Me.btnNuevo.Text = "Nuevo album"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(164, 276)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(145, 30)
        Me.btnEliminar.TabIndex = 5
        Me.btnEliminar.Text = "Eliminar album"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(322, 174)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(105, 132)
        Me.btnSalir.TabIndex = 6
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chbTotal)
        Me.GroupBox3.Controls.Add(Me.tbTotal)
        Me.GroupBox3.Location = New System.Drawing.Point(322, 43)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(105, 100)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "GroupBox3"
        '
        'fEstopa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 317)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbTotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbVinilo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbCD)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbAlbum)
        Me.Controls.Add(Me.Label1)
        Me.Name = "fEstopa"
        Me.Text = "Zapatillas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbAlbum As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbCD As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lbVinilo As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lbTotal As ListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents tbUnidades As TextBox
    Friend WithEvents rbtnVinilo As RadioButton
    Friend WithEvents rbtnCD As RadioButton
    Friend WithEvents chbTotal As CheckBox
    Friend WithEvents tbTotal As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents tbDisp As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents GroupBox3 As GroupBox
End Class
