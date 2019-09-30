<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListbox
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
        Me.lstBN1 = New System.Windows.Forms.ListBox()
        Me.txtCampo1 = New System.Windows.Forms.TextBox()
        Me.lstBN2 = New System.Windows.Forms.ListBox()
        Me.lstBN3 = New System.Windows.Forms.ListBox()
        Me.txtCampo2 = New System.Windows.Forms.TextBox()
        Me.txtCampo3 = New System.Windows.Forms.TextBox()
        Me.lblCampo1 = New System.Windows.Forms.Label()
        Me.lblCampo2 = New System.Windows.Forms.Label()
        Me.lblCampo3 = New System.Windows.Forms.Label()
        Me.btnAñadir = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lblContador = New System.Windows.Forms.Label()
        Me.lblCon1 = New System.Windows.Forms.Label()
        Me.lblCon2 = New System.Windows.Forms.Label()
        Me.lblCon3 = New System.Windows.Forms.Label()
        Me.btnActualiza = New System.Windows.Forms.Button()
        Me.btnBorra = New System.Windows.Forms.Button()
        Me.btnCopiar = New System.Windows.Forms.Button()
        Me.rbLista1 = New System.Windows.Forms.RadioButton()
        Me.rbLista2 = New System.Windows.Forms.RadioButton()
        Me.rbLista3 = New System.Windows.Forms.RadioButton()
        Me.cbLista1 = New System.Windows.Forms.CheckBox()
        Me.cbLista2 = New System.Windows.Forms.CheckBox()
        Me.cbLista3 = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstBN1
        '
        Me.lstBN1.FormattingEnabled = True
        Me.lstBN1.Location = New System.Drawing.Point(470, 57)
        Me.lstBN1.Name = "lstBN1"
        Me.lstBN1.Size = New System.Drawing.Size(137, 368)
        Me.lstBN1.TabIndex = 0
        '
        'txtCampo1
        '
        Me.txtCampo1.Location = New System.Drawing.Point(180, 88)
        Me.txtCampo1.Name = "txtCampo1"
        Me.txtCampo1.Size = New System.Drawing.Size(176, 20)
        Me.txtCampo1.TabIndex = 3
        '
        'lstBN2
        '
        Me.lstBN2.FormattingEnabled = True
        Me.lstBN2.Location = New System.Drawing.Point(628, 57)
        Me.lstBN2.Name = "lstBN2"
        Me.lstBN2.Size = New System.Drawing.Size(137, 368)
        Me.lstBN2.TabIndex = 4
        '
        'lstBN3
        '
        Me.lstBN3.FormattingEnabled = True
        Me.lstBN3.Location = New System.Drawing.Point(793, 57)
        Me.lstBN3.Name = "lstBN3"
        Me.lstBN3.Size = New System.Drawing.Size(137, 368)
        Me.lstBN3.TabIndex = 5
        '
        'txtCampo2
        '
        Me.txtCampo2.Location = New System.Drawing.Point(180, 134)
        Me.txtCampo2.Name = "txtCampo2"
        Me.txtCampo2.Size = New System.Drawing.Size(176, 20)
        Me.txtCampo2.TabIndex = 6
        '
        'txtCampo3
        '
        Me.txtCampo3.Location = New System.Drawing.Point(180, 173)
        Me.txtCampo3.Name = "txtCampo3"
        Me.txtCampo3.Size = New System.Drawing.Size(176, 20)
        Me.txtCampo3.TabIndex = 7
        '
        'lblCampo1
        '
        Me.lblCampo1.AutoSize = True
        Me.lblCampo1.Location = New System.Drawing.Point(81, 91)
        Me.lblCampo1.Name = "lblCampo1"
        Me.lblCampo1.Size = New System.Drawing.Size(93, 13)
        Me.lblCampo1.TabIndex = 8
        Me.lblCampo1.Text = "Campo de txt Nº 1"
        '
        'lblCampo2
        '
        Me.lblCampo2.AutoSize = True
        Me.lblCampo2.Location = New System.Drawing.Point(81, 137)
        Me.lblCampo2.Name = "lblCampo2"
        Me.lblCampo2.Size = New System.Drawing.Size(93, 13)
        Me.lblCampo2.TabIndex = 9
        Me.lblCampo2.Text = "Campo de txt Nº 2"
        '
        'lblCampo3
        '
        Me.lblCampo3.AutoSize = True
        Me.lblCampo3.Location = New System.Drawing.Point(81, 180)
        Me.lblCampo3.Name = "lblCampo3"
        Me.lblCampo3.Size = New System.Drawing.Size(93, 13)
        Me.lblCampo3.TabIndex = 10
        Me.lblCampo3.Text = "Campo de txt Nº 3"
        '
        'btnAñadir
        '
        Me.btnAñadir.AutoEllipsis = True
        Me.btnAñadir.Location = New System.Drawing.Point(39, 237)
        Me.btnAñadir.Name = "btnAñadir"
        Me.btnAñadir.Size = New System.Drawing.Size(120, 52)
        Me.btnAñadir.TabIndex = 11
        Me.btnAñadir.Text = "&Añadir"
        Me.btnAñadir.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.AutoEllipsis = True
        Me.btnSalir.Location = New System.Drawing.Point(875, 447)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(71, 47)
        Me.btnSalir.TabIndex = 12
        Me.btnSalir.Text = "&Fin"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'lblContador
        '
        Me.lblContador.AutoSize = True
        Me.lblContador.Location = New System.Drawing.Point(298, 39)
        Me.lblContador.Name = "lblContador"
        Me.lblContador.Size = New System.Drawing.Size(160, 13)
        Me.lblContador.TabIndex = 13
        Me.lblContador.Text = "Numero de elementos en la lista:"
        '
        'lblCon1
        '
        Me.lblCon1.AutoSize = True
        Me.lblCon1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCon1.Location = New System.Drawing.Point(489, 39)
        Me.lblCon1.Name = "lblCon1"
        Me.lblCon1.Size = New System.Drawing.Size(64, 13)
        Me.lblCon1.TabIndex = 14
        Me.lblCon1.Text = "Listbox 1:    "
        '
        'lblCon2
        '
        Me.lblCon2.AutoSize = True
        Me.lblCon2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCon2.Location = New System.Drawing.Point(648, 39)
        Me.lblCon2.Name = "lblCon2"
        Me.lblCon2.Size = New System.Drawing.Size(64, 13)
        Me.lblCon2.TabIndex = 15
        Me.lblCon2.Text = "Listbox 2:    "
        '
        'lblCon3
        '
        Me.lblCon3.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblCon3.Location = New System.Drawing.Point(814, 39)
        Me.lblCon3.Name = "lblCon3"
        Me.lblCon3.Size = New System.Drawing.Size(93, 13)
        Me.lblCon3.TabIndex = 16
        Me.lblCon3.Text = "Listbox 3:    "
        '
        'btnActualiza
        '
        Me.btnActualiza.AutoEllipsis = True
        Me.btnActualiza.Location = New System.Drawing.Point(165, 237)
        Me.btnActualiza.Name = "btnActualiza"
        Me.btnActualiza.Size = New System.Drawing.Size(120, 52)
        Me.btnActualiza.TabIndex = 17
        Me.btnActualiza.Text = "A&ctualizar"
        Me.btnActualiza.UseVisualStyleBackColor = True
        '
        'btnBorra
        '
        Me.btnBorra.AutoEllipsis = True
        Me.btnBorra.Location = New System.Drawing.Point(291, 237)
        Me.btnBorra.Name = "btnBorra"
        Me.btnBorra.Size = New System.Drawing.Size(120, 52)
        Me.btnBorra.TabIndex = 18
        Me.btnBorra.Text = "&Elimina"
        Me.btnBorra.UseVisualStyleBackColor = True
        '
        'btnCopiar
        '
        Me.btnCopiar.AutoEllipsis = True
        Me.btnCopiar.Location = New System.Drawing.Point(39, 305)
        Me.btnCopiar.Name = "btnCopiar"
        Me.btnCopiar.Size = New System.Drawing.Size(224, 52)
        Me.btnCopiar.TabIndex = 19
        Me.btnCopiar.Text = "&Copiar "
        Me.btnCopiar.UseVisualStyleBackColor = True
        '
        'rbLista1
        '
        Me.rbLista1.AutoSize = True
        Me.rbLista1.Location = New System.Drawing.Point(19, 22)
        Me.rbLista1.Name = "rbLista1"
        Me.rbLista1.Size = New System.Drawing.Size(71, 17)
        Me.rbLista1.TabIndex = 21
        Me.rbLista1.TabStop = True
        Me.rbLista1.Text = "List Box 1"
        Me.rbLista1.UseVisualStyleBackColor = True
        '
        'rbLista2
        '
        Me.rbLista2.AutoSize = True
        Me.rbLista2.Location = New System.Drawing.Point(19, 45)
        Me.rbLista2.Name = "rbLista2"
        Me.rbLista2.Size = New System.Drawing.Size(71, 17)
        Me.rbLista2.TabIndex = 22
        Me.rbLista2.TabStop = True
        Me.rbLista2.Text = "List Box 2"
        Me.rbLista2.UseVisualStyleBackColor = True
        '
        'rbLista3
        '
        Me.rbLista3.AutoSize = True
        Me.rbLista3.Location = New System.Drawing.Point(19, 67)
        Me.rbLista3.Name = "rbLista3"
        Me.rbLista3.Size = New System.Drawing.Size(71, 17)
        Me.rbLista3.TabIndex = 23
        Me.rbLista3.TabStop = True
        Me.rbLista3.Text = "List Box 3"
        Me.rbLista3.UseVisualStyleBackColor = True
        '
        'cbLista1
        '
        Me.cbLista1.AutoSize = True
        Me.cbLista1.Location = New System.Drawing.Point(106, 22)
        Me.cbLista1.Name = "cbLista1"
        Me.cbLista1.Size = New System.Drawing.Size(111, 17)
        Me.cbLista1.TabIndex = 24
        Me.cbLista1.Text = "Destino List Box 1"
        Me.cbLista1.UseVisualStyleBackColor = True
        '
        'cbLista2
        '
        Me.cbLista2.AutoSize = True
        Me.cbLista2.Location = New System.Drawing.Point(106, 44)
        Me.cbLista2.Name = "cbLista2"
        Me.cbLista2.Size = New System.Drawing.Size(111, 17)
        Me.cbLista2.TabIndex = 25
        Me.cbLista2.Text = "Destino List Box 2"
        Me.cbLista2.UseVisualStyleBackColor = True
        '
        'cbLista3
        '
        Me.cbLista3.AutoSize = True
        Me.cbLista3.Location = New System.Drawing.Point(106, 67)
        Me.cbLista3.Name = "cbLista3"
        Me.cbLista3.Size = New System.Drawing.Size(111, 17)
        Me.cbLista3.TabIndex = 26
        Me.cbLista3.Text = "Destino List Box 3"
        Me.cbLista3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbLista3)
        Me.GroupBox1.Controls.Add(Me.rbLista1)
        Me.GroupBox1.Controls.Add(Me.cbLista2)
        Me.GroupBox1.Controls.Add(Me.rbLista2)
        Me.GroupBox1.Controls.Add(Me.cbLista1)
        Me.GroupBox1.Controls.Add(Me.rbLista3)
        Me.GroupBox1.Location = New System.Drawing.Point(46, 363)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(217, 95)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Copiar"
        '
        'frmListbox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1031, 524)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCopiar)
        Me.Controls.Add(Me.btnBorra)
        Me.Controls.Add(Me.btnActualiza)
        Me.Controls.Add(Me.lblCon3)
        Me.Controls.Add(Me.lblCon2)
        Me.Controls.Add(Me.lblCon1)
        Me.Controls.Add(Me.lblContador)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAñadir)
        Me.Controls.Add(Me.lblCampo3)
        Me.Controls.Add(Me.lblCampo2)
        Me.Controls.Add(Me.lblCampo1)
        Me.Controls.Add(Me.txtCampo3)
        Me.Controls.Add(Me.txtCampo2)
        Me.Controls.Add(Me.lstBN3)
        Me.Controls.Add(Me.lstBN2)
        Me.Controls.Add(Me.txtCampo1)
        Me.Controls.Add(Me.lstBN1)
        Me.Name = "frmListbox"
        Me.Text = "Ejemplo de funcionamiento para ListBox"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstBN1 As Windows.Forms.ListBox
    Friend WithEvents txtCampo1 As TextBox
    Friend WithEvents lstBN2 As Windows.Forms.ListBox
    Friend WithEvents lstBN3 As Windows.Forms.ListBox
    Friend WithEvents txtCampo2 As TextBox
    Friend WithEvents txtCampo3 As TextBox
    Friend WithEvents lblCampo1 As Label
    Friend WithEvents lblCampo2 As Label
    Friend WithEvents lblCampo3 As Label
    Friend WithEvents btnAñadir As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents lblContador As Label
    Friend WithEvents lblCon1 As Label
    Friend WithEvents lblCon2 As Label
    Friend WithEvents lblCon3 As Label
    Friend WithEvents btnActualiza As Button
    Friend WithEvents btnBorra As Button
    Friend WithEvents btnCopiar As Button
    Friend WithEvents rbLista1 As RadioButton
    Friend WithEvents rbLista2 As RadioButton
    Friend WithEvents rbLista3 As RadioButton
    Friend WithEvents cbLista1 As CheckBox
    Friend WithEvents cbLista2 As CheckBox
    Friend WithEvents cbLista3 As CheckBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
