<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fCompra
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
        Me.tbPeliculaSelec = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.numEntradas = New System.Windows.Forms.NumericUpDown()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbtn5 = New System.Windows.Forms.RadioButton()
        Me.rbtn6 = New System.Windows.Forms.RadioButton()
        Me.rbtn7 = New System.Windows.Forms.RadioButton()
        Me.btnComprar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbTotal = New System.Windows.Forms.TextBox()
        Me.btnVolver = New System.Windows.Forms.Button()
        CType(Me.numEntradas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Película seleccionada"
        '
        'tbPeliculaSelec
        '
        Me.tbPeliculaSelec.Enabled = False
        Me.tbPeliculaSelec.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPeliculaSelec.Location = New System.Drawing.Point(200, 19)
        Me.tbPeliculaSelec.Name = "tbPeliculaSelec"
        Me.tbPeliculaSelec.Size = New System.Drawing.Size(272, 29)
        Me.tbPeliculaSelec.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(190, 24)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nº DE ENTRADAS:"
        '
        'numEntradas
        '
        Me.numEntradas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numEntradas.Location = New System.Drawing.Point(200, 56)
        Me.numEntradas.Name = "numEntradas"
        Me.numEntradas.Size = New System.Drawing.Size(120, 29)
        Me.numEntradas.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbtn5)
        Me.GroupBox1.Controls.Add(Me.rbtn6)
        Me.GroupBox1.Controls.Add(Me.rbtn7)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 114)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(456, 103)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "PRECIO"
        '
        'rbtn5
        '
        Me.rbtn5.AutoSize = True
        Me.rbtn5.Location = New System.Drawing.Point(335, 47)
        Me.rbtn5.Name = "rbtn5"
        Me.rbtn5.Size = New System.Drawing.Size(73, 28)
        Me.rbtn5.TabIndex = 0
        Me.rbtn5.Text = "5,00€"
        Me.rbtn5.UseVisualStyleBackColor = True
        '
        'rbtn6
        '
        Me.rbtn6.AutoSize = True
        Me.rbtn6.Location = New System.Drawing.Point(196, 47)
        Me.rbtn6.Name = "rbtn6"
        Me.rbtn6.Size = New System.Drawing.Size(73, 28)
        Me.rbtn6.TabIndex = 0
        Me.rbtn6.Text = "6,00€"
        Me.rbtn6.UseVisualStyleBackColor = True
        '
        'rbtn7
        '
        Me.rbtn7.AutoSize = True
        Me.rbtn7.Checked = True
        Me.rbtn7.Location = New System.Drawing.Point(52, 47)
        Me.rbtn7.Name = "rbtn7"
        Me.rbtn7.Size = New System.Drawing.Size(73, 28)
        Me.rbtn7.TabIndex = 0
        Me.rbtn7.TabStop = True
        Me.rbtn7.Text = "7,20€"
        Me.rbtn7.UseVisualStyleBackColor = True
        '
        'btnComprar
        '
        Me.btnComprar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComprar.Location = New System.Drawing.Point(16, 224)
        Me.btnComprar.Name = "btnComprar"
        Me.btnComprar.Size = New System.Drawing.Size(456, 57)
        Me.btnComprar.TabIndex = 4
        Me.btnComprar.Text = "Comprar"
        Me.btnComprar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 312)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Total a pagar:"
        '
        'tbTotal
        '
        Me.tbTotal.Enabled = False
        Me.tbTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTotal.Location = New System.Drawing.Point(142, 309)
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.Size = New System.Drawing.Size(330, 29)
        Me.tbTotal.TabIndex = 1
        Me.tbTotal.Text = "0,00 €"
        Me.tbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnVolver
        '
        Me.btnVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.Location = New System.Drawing.Point(383, 390)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(89, 31)
        Me.btnVolver.TabIndex = 4
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'fCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 450)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnComprar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.numEntradas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbPeliculaSelec)
        Me.Controls.Add(Me.Label1)
        Me.Name = "fCompra"
        Me.Text = "Form1"
        CType(Me.numEntradas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tbPeliculaSelec As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents numEntradas As NumericUpDown
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rbtn5 As RadioButton
    Friend WithEvents rbtn6 As RadioButton
    Friend WithEvents rbtn7 As RadioButton
    Friend WithEvents btnComprar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents tbTotal As TextBox
    Friend WithEvents btnVolver As Button
End Class
