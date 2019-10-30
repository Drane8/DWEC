<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fVuelos
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
        Me.cbOrigen = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtnInternacional = New System.Windows.Forms.RadioButton()
        Me.rbtnNacional = New System.Windows.Forms.RadioButton()
        Me.lbNacional = New System.Windows.Forms.ListBox()
        Me.lbInternacional = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.numBilletes = New System.Windows.Forms.NumericUpDown()
        Me.cbTarifa = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lbVuelos = New System.Windows.Forms.ListBox()
        Me.lbPrecios = New System.Windows.Forms.ListBox()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPrecio = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnAnular = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.numBilletes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Origen"
        '
        'cbOrigen
        '
        Me.cbOrigen.FormattingEnabled = True
        Me.cbOrigen.Location = New System.Drawing.Point(9, 31)
        Me.cbOrigen.Name = "cbOrigen"
        Me.cbOrigen.Size = New System.Drawing.Size(121, 21)
        Me.cbOrigen.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtnInternacional)
        Me.GroupBox1.Controls.Add(Me.rbtnNacional)
        Me.GroupBox1.Location = New System.Drawing.Point(142, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(250, 39)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Destino"
        '
        'rbtnInternacional
        '
        Me.rbtnInternacional.AutoSize = True
        Me.rbtnInternacional.Location = New System.Drawing.Point(156, 16)
        Me.rbtnInternacional.Name = "rbtnInternacional"
        Me.rbtnInternacional.Size = New System.Drawing.Size(86, 17)
        Me.rbtnInternacional.TabIndex = 0
        Me.rbtnInternacional.Text = "Internacional"
        Me.rbtnInternacional.UseVisualStyleBackColor = True
        '
        'rbtnNacional
        '
        Me.rbtnNacional.AutoSize = True
        Me.rbtnNacional.Checked = True
        Me.rbtnNacional.Location = New System.Drawing.Point(6, 16)
        Me.rbtnNacional.Name = "rbtnNacional"
        Me.rbtnNacional.Size = New System.Drawing.Size(67, 17)
        Me.rbtnNacional.TabIndex = 0
        Me.rbtnNacional.TabStop = True
        Me.rbtnNacional.Text = "Nacional"
        Me.rbtnNacional.UseVisualStyleBackColor = True
        '
        'lbNacional
        '
        Me.lbNacional.FormattingEnabled = True
        Me.lbNacional.Location = New System.Drawing.Point(142, 58)
        Me.lbNacional.Name = "lbNacional"
        Me.lbNacional.Size = New System.Drawing.Size(120, 82)
        Me.lbNacional.TabIndex = 3
        '
        'lbInternacional
        '
        Me.lbInternacional.Enabled = False
        Me.lbInternacional.FormattingEnabled = True
        Me.lbInternacional.Location = New System.Drawing.Point(272, 58)
        Me.lbInternacional.Name = "lbInternacional"
        Me.lbInternacional.Size = New System.Drawing.Size(120, 82)
        Me.lbInternacional.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nº de billetes"
        '
        'numBilletes
        '
        Me.numBilletes.Location = New System.Drawing.Point(84, 69)
        Me.numBilletes.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.numBilletes.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numBilletes.Name = "numBilletes"
        Me.numBilletes.Size = New System.Drawing.Size(46, 20)
        Me.numBilletes.TabIndex = 5
        Me.numBilletes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numBilletes.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cbTarifa
        '
        Me.cbTarifa.FormattingEnabled = True
        Me.cbTarifa.Location = New System.Drawing.Point(9, 119)
        Me.cbTarifa.Name = "cbTarifa"
        Me.cbTarifa.Size = New System.Drawing.Size(121, 21)
        Me.cbTarifa.TabIndex = 1
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(9, 156)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(69, 95)
        Me.btnAdd.TabIndex = 6
        Me.btnAdd.Text = "Añadir vuelo"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lbVuelos
        '
        Me.lbVuelos.FormattingEnabled = True
        Me.lbVuelos.Location = New System.Drawing.Point(84, 156)
        Me.lbVuelos.Name = "lbVuelos"
        Me.lbVuelos.Size = New System.Drawing.Size(158, 95)
        Me.lbVuelos.TabIndex = 3
        '
        'lbPrecios
        '
        Me.lbPrecios.Enabled = False
        Me.lbPrecios.FormattingEnabled = True
        Me.lbPrecios.Location = New System.Drawing.Point(248, 156)
        Me.lbPrecios.Name = "lbPrecios"
        Me.lbPrecios.Size = New System.Drawing.Size(69, 95)
        Me.lbPrecios.TabIndex = 3
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(323, 156)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(69, 95)
        Me.btnEliminar.TabIndex = 6
        Me.btnEliminar.Text = "Eliminar vuelo"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(104, 257)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Total a pagar -->"
        '
        'lblPrecio
        '
        Me.lblPrecio.AutoSize = True
        Me.lblPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrecio.Location = New System.Drawing.Point(244, 257)
        Me.lblPrecio.Name = "lblPrecio"
        Me.lblPrecio.Size = New System.Drawing.Size(40, 20)
        Me.lblPrecio.TabIndex = 7
        Me.lblPrecio.Text = "0,00"
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(9, 344)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(383, 35)
        Me.btnSalir.TabIndex = 8
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(9, 284)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(233, 54)
        Me.btnAceptar.TabIndex = 8
        Me.btnAceptar.Text = "ACEPTAR COMPRA"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnAnular
        '
        Me.btnAnular.Location = New System.Drawing.Point(248, 284)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(144, 54)
        Me.btnAnular.TabIndex = 8
        Me.btnAnular.Text = "ANULAR COMPRA"
        Me.btnAnular.UseVisualStyleBackColor = True
        '
        'fVuelos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 393)
        Me.Controls.Add(Me.btnAnular)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lblPrecio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.numBilletes)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbPrecios)
        Me.Controls.Add(Me.lbVuelos)
        Me.Controls.Add(Me.lbInternacional)
        Me.Controls.Add(Me.lbNacional)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cbTarifa)
        Me.Controls.Add(Me.cbOrigen)
        Me.Controls.Add(Me.Label1)
        Me.Name = "fVuelos"
        Me.Text = "Vuelos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.numBilletes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbOrigen As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbtnInternacional As RadioButton
    Friend WithEvents rbtnNacional As RadioButton
    Friend WithEvents lbNacional As ListBox
    Friend WithEvents lbInternacional As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents numBilletes As NumericUpDown
    Friend WithEvents cbTarifa As ComboBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents lbVuelos As ListBox
    Friend WithEvents lbPrecios As ListBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents lblPrecio As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnAnular As Button
End Class
