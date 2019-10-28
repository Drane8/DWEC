<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fPerfumes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbPerfumes = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbUnidades = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbPrecio = New System.Windows.Forms.ListBox()
        Me.pbPerfume = New System.Windows.Forms.PictureBox()
        Me.lbVentas = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnVenta = New System.Windows.Forms.Button()
        Me.tbUnidades = New System.Windows.Forms.TextBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtn50 = New System.Windows.Forms.RadioButton()
        Me.rbtn20 = New System.Windows.Forms.RadioButton()
        Me.rbtn10 = New System.Windows.Forms.RadioButton()
        Me.btnSalir = New System.Windows.Forms.Button()
        CType(Me.pbPerfume, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Perfumes"
        '
        'lbPerfumes
        '
        Me.lbPerfumes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPerfumes.FormattingEnabled = True
        Me.lbPerfumes.Location = New System.Drawing.Point(12, 25)
        Me.lbPerfumes.Name = "lbPerfumes"
        Me.lbPerfumes.Size = New System.Drawing.Size(96, 134)
        Me.lbPerfumes.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(136, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Precio"
        '
        'lbUnidades
        '
        Me.lbUnidades.Enabled = False
        Me.lbUnidades.FormattingEnabled = True
        Me.lbUnidades.Location = New System.Drawing.Point(205, 25)
        Me.lbUnidades.Name = "lbUnidades"
        Me.lbUnidades.Size = New System.Drawing.Size(50, 134)
        Me.lbUnidades.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(204, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Unidades"
        '
        'lbPrecio
        '
        Me.lbPrecio.Enabled = False
        Me.lbPrecio.FormattingEnabled = True
        Me.lbPrecio.Location = New System.Drawing.Point(129, 25)
        Me.lbPrecio.Name = "lbPrecio"
        Me.lbPrecio.Size = New System.Drawing.Size(51, 134)
        Me.lbPrecio.TabIndex = 1
        '
        'pbPerfume
        '
        Me.pbPerfume.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbPerfume.Location = New System.Drawing.Point(273, 25)
        Me.pbPerfume.Name = "pbPerfume"
        Me.pbPerfume.Size = New System.Drawing.Size(134, 212)
        Me.pbPerfume.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPerfume.TabIndex = 2
        Me.pbPerfume.TabStop = False
        '
        'lbVentas
        '
        Me.lbVentas.FormattingEnabled = True
        Me.lbVentas.Location = New System.Drawing.Point(432, 25)
        Me.lbVentas.Name = "lbVentas"
        Me.lbVentas.Size = New System.Drawing.Size(50, 160)
        Me.lbVentas.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(437, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Ventas"
        '
        'btnVenta
        '
        Me.btnVenta.Location = New System.Drawing.Point(12, 183)
        Me.btnVenta.Name = "btnVenta"
        Me.btnVenta.Size = New System.Drawing.Size(168, 46)
        Me.btnVenta.TabIndex = 3
        Me.btnVenta.Text = "&Venta"
        Me.btnVenta.UseVisualStyleBackColor = True
        '
        'tbUnidades
        '
        Me.tbUnidades.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbUnidades.Location = New System.Drawing.Point(204, 192)
        Me.tbUnidades.Name = "tbUnidades"
        Me.tbUnidades.Size = New System.Drawing.Size(51, 29)
        Me.tbUnidades.TabIndex = 4
        Me.tbUnidades.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(413, 191)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(97, 46)
        Me.lblTotal.TabIndex = 0
        Me.lblTotal.Text = "0"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(517, 25)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 211)
        Me.btnBorrar.TabIndex = 5
        Me.btnBorrar.Text = "Borrar Ventas"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtn50)
        Me.GroupBox1.Controls.Add(Me.rbtn20)
        Me.GroupBox1.Controls.Add(Me.rbtn10)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 253)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 47)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Descuento"
        '
        'rbtn50
        '
        Me.rbtn50.AutoSize = True
        Me.rbtn50.Location = New System.Drawing.Point(148, 19)
        Me.rbtn50.Name = "rbtn50"
        Me.rbtn50.Size = New System.Drawing.Size(45, 17)
        Me.rbtn50.TabIndex = 0
        Me.rbtn50.TabStop = True
        Me.rbtn50.Text = "50%"
        Me.rbtn50.UseVisualStyleBackColor = True
        '
        'rbtn20
        '
        Me.rbtn20.AutoSize = True
        Me.rbtn20.Location = New System.Drawing.Point(77, 19)
        Me.rbtn20.Name = "rbtn20"
        Me.rbtn20.Size = New System.Drawing.Size(45, 17)
        Me.rbtn20.TabIndex = 0
        Me.rbtn20.TabStop = True
        Me.rbtn20.Text = "20%"
        Me.rbtn20.UseVisualStyleBackColor = True
        '
        'rbtn10
        '
        Me.rbtn10.AutoSize = True
        Me.rbtn10.Checked = True
        Me.rbtn10.Location = New System.Drawing.Point(6, 19)
        Me.rbtn10.Name = "rbtn10"
        Me.rbtn10.Size = New System.Drawing.Size(45, 17)
        Me.rbtn10.TabIndex = 0
        Me.rbtn10.TabStop = True
        Me.rbtn10.Text = "10%"
        Me.rbtn10.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(218, 243)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(374, 57)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "&Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'fPerfumes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 311)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.tbUnidades)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnVenta)
        Me.Controls.Add(Me.pbPerfume)
        Me.Controls.Add(Me.lbPrecio)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbVentas)
        Me.Controls.Add(Me.lbUnidades)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbPerfumes)
        Me.Controls.Add(Me.Label1)
        Me.Name = "fPerfumes"
        Me.Text = "Perfumes"
        CType(Me.pbPerfume, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbPerfumes As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbUnidades As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lbPrecio As ListBox
    Friend WithEvents pbPerfume As PictureBox
    Friend WithEvents lbVentas As ListBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnVenta As Button
    Friend WithEvents tbUnidades As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnBorrar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbtn50 As RadioButton
    Friend WithEvents rbtn20 As RadioButton
    Friend WithEvents rbtn10 As RadioButton
    Friend WithEvents btnSalir As Button
End Class
