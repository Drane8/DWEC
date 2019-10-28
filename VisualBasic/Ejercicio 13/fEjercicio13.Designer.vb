<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fEjercicio13
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
        Me.lbArticulo = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbTipo = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbPrecio = New System.Windows.Forms.ListBox()
        Me.btnEliArt = New System.Windows.Forms.Button()
        Me.btnEliPro = New System.Windows.Forms.Button()
        Me.btnAnadir = New System.Windows.Forms.Button()
        Me.tbUnidades = New System.Windows.Forms.TextBox()
        Me.cbDto = New System.Windows.Forms.CheckBox()
        Me.cbProductos = New System.Windows.Forms.ComboBox()
        Me.lbCompras = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCompra = New System.Windows.Forms.Button()
        Me.lbTotal = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbUds = New System.Windows.Forms.TextBox()
        Me.tbPrecio = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbArticulo = New System.Windows.Forms.TextBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbUnidades = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbArticulo
        '
        Me.lbArticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbArticulo.FormattingEnabled = True
        Me.lbArticulo.Location = New System.Drawing.Point(12, 36)
        Me.lbArticulo.Name = "lbArticulo"
        Me.lbArticulo.Size = New System.Drawing.Size(178, 95)
        Me.lbArticulo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Artículo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(216, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tipo de producto"
        '
        'lbTipo
        '
        Me.lbTipo.Enabled = False
        Me.lbTipo.FormattingEnabled = True
        Me.lbTipo.Location = New System.Drawing.Point(219, 36)
        Me.lbTipo.Name = "lbTipo"
        Me.lbTipo.Size = New System.Drawing.Size(108, 95)
        Me.lbTipo.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(353, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Precio"
        '
        'lbPrecio
        '
        Me.lbPrecio.Enabled = False
        Me.lbPrecio.FormattingEnabled = True
        Me.lbPrecio.Location = New System.Drawing.Point(356, 36)
        Me.lbPrecio.Name = "lbPrecio"
        Me.lbPrecio.Size = New System.Drawing.Size(40, 95)
        Me.lbPrecio.TabIndex = 0
        '
        'btnEliArt
        '
        Me.btnEliArt.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliArt.Location = New System.Drawing.Point(12, 137)
        Me.btnEliArt.Name = "btnEliArt"
        Me.btnEliArt.Size = New System.Drawing.Size(178, 23)
        Me.btnEliArt.TabIndex = 2
        Me.btnEliArt.Text = "Eliminar artículo seleccionado"
        Me.btnEliArt.UseVisualStyleBackColor = True
        '
        'btnEliPro
        '
        Me.btnEliPro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliPro.Location = New System.Drawing.Point(197, 137)
        Me.btnEliPro.Name = "btnEliPro"
        Me.btnEliPro.Size = New System.Drawing.Size(158, 23)
        Me.btnEliPro.TabIndex = 2
        Me.btnEliPro.Text = "Eliminar productos -->"
        Me.btnEliPro.UseVisualStyleBackColor = True
        '
        'btnAnadir
        '
        Me.btnAnadir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnadir.Location = New System.Drawing.Point(15, 167)
        Me.btnAnadir.Name = "btnAnadir"
        Me.btnAnadir.Size = New System.Drawing.Size(175, 46)
        Me.btnAnadir.TabIndex = 3
        Me.btnAnadir.Text = "Añadir al carrito Unidades -->"
        Me.btnAnadir.UseVisualStyleBackColor = True
        '
        'tbUnidades
        '
        Me.tbUnidades.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUnidades.Location = New System.Drawing.Point(208, 174)
        Me.tbUnidades.Name = "tbUnidades"
        Me.tbUnidades.Size = New System.Drawing.Size(100, 32)
        Me.tbUnidades.TabIndex = 4
        Me.tbUnidades.Text = "0"
        Me.tbUnidades.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cbDto
        '
        Me.cbDto.AutoSize = True
        Me.cbDto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDto.Location = New System.Drawing.Point(326, 176)
        Me.cbDto.Name = "cbDto"
        Me.cbDto.Size = New System.Drawing.Size(158, 28)
        Me.cbDto.TabIndex = 5
        Me.cbDto.Text = "Aplicar dto 10%"
        Me.cbDto.UseVisualStyleBackColor = True
        '
        'cbProductos
        '
        Me.cbProductos.FormattingEnabled = True
        Me.cbProductos.Location = New System.Drawing.Point(362, 137)
        Me.cbProductos.Name = "cbProductos"
        Me.cbProductos.Size = New System.Drawing.Size(121, 21)
        Me.cbProductos.TabIndex = 6
        '
        'lbCompras
        '
        Me.lbCompras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCompras.FormattingEnabled = True
        Me.lbCompras.Location = New System.Drawing.Point(12, 244)
        Me.lbCompras.Name = "lbCompras"
        Me.lbCompras.Size = New System.Drawing.Size(340, 108)
        Me.lbCompras.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(205, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Artículo---Unidades---Total a pagar"
        '
        'btnCompra
        '
        Me.btnCompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompra.Location = New System.Drawing.Point(358, 244)
        Me.btnCompra.Name = "btnCompra"
        Me.btnCompra.Size = New System.Drawing.Size(126, 108)
        Me.btnCompra.TabIndex = 3
        Me.btnCompra.Text = "Comprar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "======" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cancelar Compra"
        Me.btnCompra.UseVisualStyleBackColor = True
        '
        'lbTotal
        '
        Me.lbTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbTotal.Location = New System.Drawing.Point(9, 355)
        Me.lbTotal.Name = "lbTotal"
        Me.lbTotal.Size = New System.Drawing.Size(468, 13)
        Me.lbTotal.TabIndex = 1
        Me.lbTotal.Text = "Importe Total:     0"
        Me.lbTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.cbTipo)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.tbUds)
        Me.GroupBox1.Controls.Add(Me.tbPrecio)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.tbArticulo)
        Me.GroupBox1.Controls.Add(Me.btnNuevo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 371)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(472, 100)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(412, 58)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(29, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Uds"
        '
        'cbTipo
        '
        Me.cbTipo.FormattingEnabled = True
        Me.cbTipo.Location = New System.Drawing.Point(178, 73)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(182, 21)
        Me.cbTipo.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(366, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Precio"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(175, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Tipo de producto"
        '
        'tbUds
        '
        Me.tbUds.Location = New System.Drawing.Point(415, 74)
        Me.tbUds.Name = "tbUds"
        Me.tbUds.Size = New System.Drawing.Size(50, 20)
        Me.tbUds.TabIndex = 1
        '
        'tbPrecio
        '
        Me.tbPrecio.Location = New System.Drawing.Point(366, 74)
        Me.tbPrecio.Name = "tbPrecio"
        Me.tbPrecio.Size = New System.Drawing.Size(43, 20)
        Me.tbPrecio.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Artículo"
        '
        'tbArticulo
        '
        Me.tbArticulo.Location = New System.Drawing.Point(6, 74)
        Me.tbArticulo.Name = "tbArticulo"
        Me.tbArticulo.Size = New System.Drawing.Size(166, 20)
        Me.tbArticulo.TabIndex = 1
        '
        'btnNuevo
        '
        Me.btnNuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNuevo.Location = New System.Drawing.Point(6, 19)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(459, 23)
        Me.btnNuevo.TabIndex = 0
        Me.btnNuevo.Text = "Nuevo artículo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(424, 17)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Unidades"
        '
        'lbUnidades
        '
        Me.lbUnidades.Enabled = False
        Me.lbUnidades.FormattingEnabled = True
        Me.lbUnidades.Location = New System.Drawing.Point(425, 36)
        Me.lbUnidades.Name = "lbUnidades"
        Me.lbUnidades.Size = New System.Drawing.Size(57, 95)
        Me.lbUnidades.TabIndex = 0
        '
        'fEjercicio13
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(492, 514)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cbProductos)
        Me.Controls.Add(Me.cbDto)
        Me.Controls.Add(Me.tbUnidades)
        Me.Controls.Add(Me.btnCompra)
        Me.Controls.Add(Me.btnAnadir)
        Me.Controls.Add(Me.btnEliPro)
        Me.Controls.Add(Me.btnEliArt)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbTotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbUnidades)
        Me.Controls.Add(Me.lbPrecio)
        Me.Controls.Add(Me.lbCompras)
        Me.Controls.Add(Me.lbTipo)
        Me.Controls.Add(Me.lbArticulo)
        Me.Name = "fEjercicio13"
        Me.Text = "Ejercicio 13"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbArticulo As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbTipo As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lbPrecio As ListBox
    Friend WithEvents btnEliArt As Button
    Friend WithEvents btnEliPro As Button
    Friend WithEvents btnAnadir As Button
    Friend WithEvents tbUnidades As TextBox
    Friend WithEvents cbDto As CheckBox
    Friend WithEvents cbProductos As ComboBox
    Friend WithEvents lbCompras As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnCompra As Button
    Friend WithEvents lbTotal As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents tbUds As TextBox
    Friend WithEvents tbPrecio As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tbArticulo As TextBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents lbUnidades As ListBox
    Friend WithEvents cbTipo As ComboBox
End Class
