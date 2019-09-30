<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fCalculadora
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
        Me.tbHistorial = New System.Windows.Forms.TextBox()
        Me.tbResul = New System.Windows.Forms.TextBox()
        Me.btnPorcentaje = New System.Windows.Forms.Button()
        Me.btnRaiz = New System.Windows.Forms.Button()
        Me.btnCuadrado = New System.Windows.Forms.Button()
        Me.btn1x = New System.Windows.Forms.Button()
        Me.btnDiv = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.btnC = New System.Windows.Forms.Button()
        Me.btnCE = New System.Windows.Forms.Button()
        Me.btnResta = New System.Windows.Forms.Button()
        Me.btn6 = New System.Windows.Forms.Button()
        Me.btn5 = New System.Windows.Forms.Button()
        Me.btn4 = New System.Windows.Forms.Button()
        Me.btnMult = New System.Windows.Forms.Button()
        Me.btn9 = New System.Windows.Forms.Button()
        Me.btn8 = New System.Windows.Forms.Button()
        Me.btn7 = New System.Windows.Forms.Button()
        Me.btnResul = New System.Windows.Forms.Button()
        Me.btnComa = New System.Windows.Forms.Button()
        Me.btn0 = New System.Windows.Forms.Button()
        Me.btnCambio = New System.Windows.Forms.Button()
        Me.btnSuma = New System.Windows.Forms.Button()
        Me.btn3 = New System.Windows.Forms.Button()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbHistorial
        '
        Me.tbHistorial.BackColor = System.Drawing.Color.LightGray
        Me.tbHistorial.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbHistorial.Enabled = False
        Me.tbHistorial.Location = New System.Drawing.Point(0, 0)
        Me.tbHistorial.Multiline = True
        Me.tbHistorial.Name = "tbHistorial"
        Me.tbHistorial.Size = New System.Drawing.Size(228, 36)
        Me.tbHistorial.TabIndex = 0
        '
        'tbResul
        '
        Me.tbResul.BackColor = System.Drawing.Color.LightGray
        Me.tbResul.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbResul.Enabled = False
        Me.tbResul.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbResul.Location = New System.Drawing.Point(0, 35)
        Me.tbResul.Name = "tbResul"
        Me.tbResul.Size = New System.Drawing.Size(228, 31)
        Me.tbResul.TabIndex = 1
        Me.tbResul.Text = "0"
        Me.tbResul.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnPorcentaje
        '
        Me.btnPorcentaje.BackColor = System.Drawing.Color.Gainsboro
        Me.btnPorcentaje.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnPorcentaje.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnPorcentaje.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPorcentaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPorcentaje.Location = New System.Drawing.Point(0, 73)
        Me.btnPorcentaje.Name = "btnPorcentaje"
        Me.btnPorcentaje.Size = New System.Drawing.Size(57, 46)
        Me.btnPorcentaje.TabIndex = 2
        Me.btnPorcentaje.Text = "%"
        Me.btnPorcentaje.UseVisualStyleBackColor = False
        '
        'btnRaiz
        '
        Me.btnRaiz.BackColor = System.Drawing.Color.Gainsboro
        Me.btnRaiz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnRaiz.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnRaiz.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRaiz.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRaiz.Location = New System.Drawing.Point(57, 73)
        Me.btnRaiz.Name = "btnRaiz"
        Me.btnRaiz.Size = New System.Drawing.Size(57, 46)
        Me.btnRaiz.TabIndex = 2
        Me.btnRaiz.Text = "√"
        Me.btnRaiz.UseVisualStyleBackColor = False
        '
        'btnCuadrado
        '
        Me.btnCuadrado.BackColor = System.Drawing.Color.Gainsboro
        Me.btnCuadrado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCuadrado.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnCuadrado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCuadrado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCuadrado.Location = New System.Drawing.Point(114, 73)
        Me.btnCuadrado.Name = "btnCuadrado"
        Me.btnCuadrado.Size = New System.Drawing.Size(57, 46)
        Me.btnCuadrado.TabIndex = 2
        Me.btnCuadrado.Text = "x²"
        Me.btnCuadrado.UseVisualStyleBackColor = False
        '
        'btn1x
        '
        Me.btn1x.BackColor = System.Drawing.Color.Gainsboro
        Me.btn1x.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn1x.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btn1x.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn1x.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1x.Location = New System.Drawing.Point(171, 73)
        Me.btn1x.Name = "btn1x"
        Me.btn1x.Size = New System.Drawing.Size(57, 46)
        Me.btn1x.TabIndex = 2
        Me.btn1x.Text = "1/x"
        Me.btn1x.UseVisualStyleBackColor = False
        '
        'btnDiv
        '
        Me.btnDiv.BackColor = System.Drawing.Color.Gainsboro
        Me.btnDiv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnDiv.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnDiv.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue
        Me.btnDiv.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnDiv.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btnDiv.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDiv.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDiv.Location = New System.Drawing.Point(171, 119)
        Me.btnDiv.Name = "btnDiv"
        Me.btnDiv.Size = New System.Drawing.Size(57, 46)
        Me.btnDiv.TabIndex = 3
        Me.btnDiv.Text = "÷"
        Me.btnDiv.UseVisualStyleBackColor = False
        '
        'btnBorrar
        '
        Me.btnBorrar.BackColor = System.Drawing.Color.Gainsboro
        Me.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar.Location = New System.Drawing.Point(114, 119)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(57, 46)
        Me.btnBorrar.TabIndex = 4
        Me.btnBorrar.Text = "←"
        Me.btnBorrar.UseVisualStyleBackColor = False
        '
        'btnC
        '
        Me.btnC.BackColor = System.Drawing.Color.Gainsboro
        Me.btnC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnC.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnC.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnC.Location = New System.Drawing.Point(57, 119)
        Me.btnC.Name = "btnC"
        Me.btnC.Size = New System.Drawing.Size(57, 46)
        Me.btnC.TabIndex = 5
        Me.btnC.Text = "C"
        Me.btnC.UseVisualStyleBackColor = False
        '
        'btnCE
        '
        Me.btnCE.BackColor = System.Drawing.Color.Gainsboro
        Me.btnCE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCE.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCE.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCE.Location = New System.Drawing.Point(0, 119)
        Me.btnCE.Name = "btnCE"
        Me.btnCE.Size = New System.Drawing.Size(57, 46)
        Me.btnCE.TabIndex = 6
        Me.btnCE.Text = "CE"
        Me.btnCE.UseVisualStyleBackColor = False
        '
        'btnResta
        '
        Me.btnResta.BackColor = System.Drawing.Color.Gainsboro
        Me.btnResta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnResta.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnResta.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue
        Me.btnResta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnResta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btnResta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResta.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResta.Location = New System.Drawing.Point(171, 211)
        Me.btnResta.Name = "btnResta"
        Me.btnResta.Size = New System.Drawing.Size(57, 46)
        Me.btnResta.TabIndex = 11
        Me.btnResta.Text = "-"
        Me.btnResta.UseVisualStyleBackColor = False
        '
        'btn6
        '
        Me.btn6.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btn6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn6.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btn6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn6.Location = New System.Drawing.Point(114, 211)
        Me.btn6.Name = "btn6"
        Me.btn6.Size = New System.Drawing.Size(57, 46)
        Me.btn6.TabIndex = 12
        Me.btn6.Text = "6"
        Me.btn6.UseVisualStyleBackColor = False
        '
        'btn5
        '
        Me.btn5.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btn5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn5.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btn5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn5.Location = New System.Drawing.Point(57, 211)
        Me.btn5.Name = "btn5"
        Me.btn5.Size = New System.Drawing.Size(57, 46)
        Me.btn5.TabIndex = 13
        Me.btn5.Text = "5"
        Me.btn5.UseVisualStyleBackColor = False
        '
        'btn4
        '
        Me.btn4.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btn4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn4.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btn4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn4.Location = New System.Drawing.Point(0, 211)
        Me.btn4.Name = "btn4"
        Me.btn4.Size = New System.Drawing.Size(57, 46)
        Me.btn4.TabIndex = 14
        Me.btn4.Text = "4"
        Me.btn4.UseVisualStyleBackColor = False
        '
        'btnMult
        '
        Me.btnMult.BackColor = System.Drawing.Color.Gainsboro
        Me.btnMult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnMult.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnMult.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue
        Me.btnMult.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnMult.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btnMult.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMult.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMult.Location = New System.Drawing.Point(171, 165)
        Me.btnMult.Name = "btnMult"
        Me.btnMult.Size = New System.Drawing.Size(57, 46)
        Me.btnMult.TabIndex = 7
        Me.btnMult.Text = "×"
        Me.btnMult.UseVisualStyleBackColor = False
        '
        'btn9
        '
        Me.btn9.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btn9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn9.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btn9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn9.Location = New System.Drawing.Point(114, 165)
        Me.btn9.Name = "btn9"
        Me.btn9.Size = New System.Drawing.Size(57, 46)
        Me.btn9.TabIndex = 8
        Me.btn9.Text = "9"
        Me.btn9.UseVisualStyleBackColor = False
        '
        'btn8
        '
        Me.btn8.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btn8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn8.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btn8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn8.Location = New System.Drawing.Point(57, 165)
        Me.btn8.Name = "btn8"
        Me.btn8.Size = New System.Drawing.Size(57, 46)
        Me.btn8.TabIndex = 9
        Me.btn8.Text = "8"
        Me.btn8.UseVisualStyleBackColor = False
        '
        'btn7
        '
        Me.btn7.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btn7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn7.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btn7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn7.Location = New System.Drawing.Point(0, 165)
        Me.btn7.Name = "btn7"
        Me.btn7.Size = New System.Drawing.Size(57, 46)
        Me.btn7.TabIndex = 10
        Me.btn7.Text = "7"
        Me.btn7.UseVisualStyleBackColor = False
        '
        'btnResul
        '
        Me.btnResul.BackColor = System.Drawing.Color.Gainsboro
        Me.btnResul.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnResul.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnResul.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue
        Me.btnResul.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnResul.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btnResul.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnResul.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnResul.Location = New System.Drawing.Point(171, 303)
        Me.btnResul.Name = "btnResul"
        Me.btnResul.Size = New System.Drawing.Size(57, 46)
        Me.btnResul.TabIndex = 19
        Me.btnResul.Text = "="
        Me.btnResul.UseVisualStyleBackColor = False
        '
        'btnComa
        '
        Me.btnComa.BackColor = System.Drawing.Color.Gainsboro
        Me.btnComa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnComa.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnComa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnComa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnComa.Location = New System.Drawing.Point(114, 303)
        Me.btnComa.Name = "btnComa"
        Me.btnComa.Size = New System.Drawing.Size(57, 46)
        Me.btnComa.TabIndex = 20
        Me.btnComa.Text = ","
        Me.btnComa.UseVisualStyleBackColor = False
        '
        'btn0
        '
        Me.btn0.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btn0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn0.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btn0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn0.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn0.Location = New System.Drawing.Point(57, 303)
        Me.btn0.Name = "btn0"
        Me.btn0.Size = New System.Drawing.Size(57, 46)
        Me.btn0.TabIndex = 21
        Me.btn0.Text = "0"
        Me.btn0.UseVisualStyleBackColor = False
        '
        'btnCambio
        '
        Me.btnCambio.BackColor = System.Drawing.Color.Gainsboro
        Me.btnCambio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnCambio.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnCambio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCambio.Location = New System.Drawing.Point(0, 303)
        Me.btnCambio.Name = "btnCambio"
        Me.btnCambio.Size = New System.Drawing.Size(57, 46)
        Me.btnCambio.TabIndex = 22
        Me.btnCambio.Text = "±"
        Me.btnCambio.UseVisualStyleBackColor = False
        '
        'btnSuma
        '
        Me.btnSuma.BackColor = System.Drawing.Color.Gainsboro
        Me.btnSuma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSuma.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btnSuma.FlatAppearance.CheckedBackColor = System.Drawing.Color.SteelBlue
        Me.btnSuma.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue
        Me.btnSuma.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btnSuma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSuma.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSuma.Location = New System.Drawing.Point(171, 257)
        Me.btnSuma.Name = "btnSuma"
        Me.btnSuma.Size = New System.Drawing.Size(57, 46)
        Me.btnSuma.TabIndex = 15
        Me.btnSuma.Text = "+"
        Me.btnSuma.UseVisualStyleBackColor = False
        '
        'btn3
        '
        Me.btn3.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btn3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn3.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btn3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn3.Location = New System.Drawing.Point(114, 257)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(57, 46)
        Me.btn3.TabIndex = 16
        Me.btn3.Text = "3"
        Me.btn3.UseVisualStyleBackColor = False
        '
        'btn2
        '
        Me.btn2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btn2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn2.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn2.Location = New System.Drawing.Point(57, 257)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(57, 46)
        Me.btn2.TabIndex = 17
        Me.btn2.Text = "2"
        Me.btn2.UseVisualStyleBackColor = False
        '
        'btn1
        '
        Me.btn1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btn1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn1.FlatAppearance.BorderColor = System.Drawing.Color.LightGray
        Me.btn1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn1.Location = New System.Drawing.Point(0, 257)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(57, 46)
        Me.btn1.TabIndex = 18
        Me.btn1.Text = "1"
        Me.btn1.UseVisualStyleBackColor = False
        '
        'fCalculadora
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(228, 349)
        Me.Controls.Add(Me.btnResul)
        Me.Controls.Add(Me.btnComa)
        Me.Controls.Add(Me.btn0)
        Me.Controls.Add(Me.btnCambio)
        Me.Controls.Add(Me.btnSuma)
        Me.Controls.Add(Me.btn3)
        Me.Controls.Add(Me.btn2)
        Me.Controls.Add(Me.btn1)
        Me.Controls.Add(Me.btnResta)
        Me.Controls.Add(Me.btn6)
        Me.Controls.Add(Me.btn5)
        Me.Controls.Add(Me.btn4)
        Me.Controls.Add(Me.btnMult)
        Me.Controls.Add(Me.btn9)
        Me.Controls.Add(Me.btn8)
        Me.Controls.Add(Me.btn7)
        Me.Controls.Add(Me.btnDiv)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnC)
        Me.Controls.Add(Me.btnCE)
        Me.Controls.Add(Me.btn1x)
        Me.Controls.Add(Me.btnCuadrado)
        Me.Controls.Add(Me.btnRaiz)
        Me.Controls.Add(Me.btnPorcentaje)
        Me.Controls.Add(Me.tbResul)
        Me.Controls.Add(Me.tbHistorial)
        Me.Name = "fCalculadora"
        Me.Text = "Calculadora"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbHistorial As TextBox
    Friend WithEvents tbResul As TextBox
    Friend WithEvents btnPorcentaje As Button
    Friend WithEvents btnRaiz As Button
    Friend WithEvents btnCuadrado As Button
    Friend WithEvents btn1x As Button
    Friend WithEvents btnDiv As Button
    Friend WithEvents btnBorrar As Button
    Friend WithEvents btnC As Button
    Friend WithEvents btnCE As Button
    Friend WithEvents btnResta As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btnMult As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn7 As Button
    Friend WithEvents btnResul As Button
    Friend WithEvents btnComa As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btnCambio As Button
    Friend WithEvents btnSuma As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn1 As Button
End Class
