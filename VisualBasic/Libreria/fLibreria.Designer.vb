<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fLibreria
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OpcionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VerPortadasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbLibros = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbUnidades = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbOpcion = New System.Windows.Forms.GroupBox()
        Me.rbtnBaja = New System.Windows.Forms.RadioButton()
        Me.rbtnMod = New System.Windows.Forms.RadioButton()
        Me.rbtnAlta = New System.Windows.Forms.RadioButton()
        Me.btnOpc = New System.Windows.Forms.Button()
        Me.gbAlta = New System.Windows.Forms.GroupBox()
        Me.btnAltaCancelar = New System.Windows.Forms.Button()
        Me.btnAltaConfirmar = New System.Windows.Forms.Button()
        Me.tbAltaUni = New System.Windows.Forms.TextBox()
        Me.tbAltaTit = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gbMod = New System.Windows.Forms.GroupBox()
        Me.btnModCanc = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnModConf = New System.Windows.Forms.Button()
        Me.tbModUni = New System.Windows.Forms.TextBox()
        Me.gbBaja = New System.Windows.Forms.GroupBox()
        Me.btnBajCan = New System.Windows.Forms.Button()
        Me.btnBaja = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.gbOpcion.SuspendLayout()
        Me.gbAlta.SuspendLayout()
        Me.gbMod.SuspendLayout()
        Me.gbBaja.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpcionesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(513, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OpcionesToolStripMenuItem
        '
        Me.OpcionesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerPortadasToolStripMenuItem, Me.ToolStripSeparator1, Me.SalirToolStripMenuItem})
        Me.OpcionesToolStripMenuItem.Name = "OpcionesToolStripMenuItem"
        Me.OpcionesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.OpcionesToolStripMenuItem.Text = "Opciones"
        '
        'VerPortadasToolStripMenuItem
        '
        Me.VerPortadasToolStripMenuItem.Name = "VerPortadasToolStripMenuItem"
        Me.VerPortadasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.VerPortadasToolStripMenuItem.Text = "Ver portadas"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(169, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Librería ""Draniel"""
        '
        'lbLibros
        '
        Me.lbLibros.FormattingEnabled = True
        Me.lbLibros.Items.AddRange(New Object() {"BIDASOA", "IGNACIO", "PASIONES ROMANAS"})
        Me.lbLibros.Location = New System.Drawing.Point(12, 91)
        Me.lbLibros.Name = "lbLibros"
        Me.lbLibros.Size = New System.Drawing.Size(176, 186)
        Me.lbLibros.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Título"
        '
        'lbUnidades
        '
        Me.lbUnidades.Enabled = False
        Me.lbUnidades.FormattingEnabled = True
        Me.lbUnidades.Items.AddRange(New Object() {"15", "8", "4"})
        Me.lbUnidades.Location = New System.Drawing.Point(206, 91)
        Me.lbUnidades.Name = "lbUnidades"
        Me.lbUnidades.Size = New System.Drawing.Size(60, 186)
        Me.lbUnidades.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(207, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Unidades"
        '
        'gbOpcion
        '
        Me.gbOpcion.Controls.Add(Me.rbtnBaja)
        Me.gbOpcion.Controls.Add(Me.rbtnMod)
        Me.gbOpcion.Controls.Add(Me.rbtnAlta)
        Me.gbOpcion.Location = New System.Drawing.Point(284, 91)
        Me.gbOpcion.Name = "gbOpcion"
        Me.gbOpcion.Size = New System.Drawing.Size(217, 123)
        Me.gbOpcion.TabIndex = 4
        Me.gbOpcion.TabStop = False
        Me.gbOpcion.Text = "Opciones"
        '
        'rbtnBaja
        '
        Me.rbtnBaja.AutoSize = True
        Me.rbtnBaja.Location = New System.Drawing.Point(31, 86)
        Me.rbtnBaja.Name = "rbtnBaja"
        Me.rbtnBaja.Size = New System.Drawing.Size(51, 17)
        Me.rbtnBaja.TabIndex = 0
        Me.rbtnBaja.Text = "Bajas"
        Me.rbtnBaja.UseVisualStyleBackColor = True
        '
        'rbtnMod
        '
        Me.rbtnMod.AutoSize = True
        Me.rbtnMod.Location = New System.Drawing.Point(31, 56)
        Me.rbtnMod.Name = "rbtnMod"
        Me.rbtnMod.Size = New System.Drawing.Size(96, 17)
        Me.rbtnMod.TabIndex = 0
        Me.rbtnMod.Text = "Modificaciones"
        Me.rbtnMod.UseVisualStyleBackColor = True
        '
        'rbtnAlta
        '
        Me.rbtnAlta.AutoSize = True
        Me.rbtnAlta.Checked = True
        Me.rbtnAlta.Location = New System.Drawing.Point(31, 26)
        Me.rbtnAlta.Name = "rbtnAlta"
        Me.rbtnAlta.Size = New System.Drawing.Size(48, 17)
        Me.rbtnAlta.TabIndex = 0
        Me.rbtnAlta.TabStop = True
        Me.rbtnAlta.Text = "Altas"
        Me.rbtnAlta.UseVisualStyleBackColor = True
        '
        'btnOpc
        '
        Me.btnOpc.Location = New System.Drawing.Point(284, 232)
        Me.btnOpc.Name = "btnOpc"
        Me.btnOpc.Size = New System.Drawing.Size(217, 45)
        Me.btnOpc.TabIndex = 5
        Me.btnOpc.Text = "Ir a opción"
        Me.btnOpc.UseVisualStyleBackColor = True
        '
        'gbAlta
        '
        Me.gbAlta.Controls.Add(Me.btnAltaCancelar)
        Me.gbAlta.Controls.Add(Me.btnAltaConfirmar)
        Me.gbAlta.Controls.Add(Me.tbAltaUni)
        Me.gbAlta.Controls.Add(Me.tbAltaTit)
        Me.gbAlta.Controls.Add(Me.Label4)
        Me.gbAlta.Controls.Add(Me.Label5)
        Me.gbAlta.Enabled = False
        Me.gbAlta.Location = New System.Drawing.Point(12, 296)
        Me.gbAlta.Name = "gbAlta"
        Me.gbAlta.Size = New System.Drawing.Size(489, 62)
        Me.gbAlta.TabIndex = 6
        Me.gbAlta.TabStop = False
        Me.gbAlta.Text = "ALTAS"
        '
        'btnAltaCancelar
        '
        Me.btnAltaCancelar.Location = New System.Drawing.Point(405, 19)
        Me.btnAltaCancelar.Name = "btnAltaCancelar"
        Me.btnAltaCancelar.Size = New System.Drawing.Size(75, 32)
        Me.btnAltaCancelar.TabIndex = 4
        Me.btnAltaCancelar.Text = "Cancelar"
        Me.btnAltaCancelar.UseVisualStyleBackColor = True
        '
        'btnAltaConfirmar
        '
        Me.btnAltaConfirmar.Location = New System.Drawing.Point(324, 19)
        Me.btnAltaConfirmar.Name = "btnAltaConfirmar"
        Me.btnAltaConfirmar.Size = New System.Drawing.Size(75, 32)
        Me.btnAltaConfirmar.TabIndex = 4
        Me.btnAltaConfirmar.Text = "Confirmar"
        Me.btnAltaConfirmar.UseVisualStyleBackColor = True
        '
        'tbAltaUni
        '
        Me.tbAltaUni.Location = New System.Drawing.Point(260, 31)
        Me.tbAltaUni.Name = "tbAltaUni"
        Me.tbAltaUni.Size = New System.Drawing.Size(47, 20)
        Me.tbAltaUni.TabIndex = 0
        '
        'tbAltaTit
        '
        Me.tbAltaTit.Location = New System.Drawing.Point(7, 31)
        Me.tbAltaTit.Name = "tbAltaTit"
        Me.tbAltaTit.Size = New System.Drawing.Size(247, 20)
        Me.tbAltaTit.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Título"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(257, 15)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Unidades"
        '
        'gbMod
        '
        Me.gbMod.Controls.Add(Me.btnModCanc)
        Me.gbMod.Controls.Add(Me.Label6)
        Me.gbMod.Controls.Add(Me.btnModConf)
        Me.gbMod.Controls.Add(Me.tbModUni)
        Me.gbMod.Enabled = False
        Me.gbMod.Location = New System.Drawing.Point(12, 368)
        Me.gbMod.Name = "gbMod"
        Me.gbMod.Size = New System.Drawing.Size(489, 62)
        Me.gbMod.TabIndex = 6
        Me.gbMod.TabStop = False
        Me.gbMod.Text = "MODIFICACIONES"
        '
        'btnModCanc
        '
        Me.btnModCanc.Location = New System.Drawing.Point(405, 20)
        Me.btnModCanc.Name = "btnModCanc"
        Me.btnModCanc.Size = New System.Drawing.Size(75, 32)
        Me.btnModCanc.TabIndex = 4
        Me.btnModCanc.Text = "Cancelar"
        Me.btnModCanc.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 30)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Unidades"
        '
        'btnModConf
        '
        Me.btnModConf.Location = New System.Drawing.Point(324, 20)
        Me.btnModConf.Name = "btnModConf"
        Me.btnModConf.Size = New System.Drawing.Size(75, 32)
        Me.btnModConf.TabIndex = 4
        Me.btnModConf.Text = "Confirmar"
        Me.btnModConf.UseVisualStyleBackColor = True
        '
        'tbModUni
        '
        Me.tbModUni.Location = New System.Drawing.Point(64, 27)
        Me.tbModUni.Name = "tbModUni"
        Me.tbModUni.Size = New System.Drawing.Size(112, 20)
        Me.tbModUni.TabIndex = 0
        '
        'gbBaja
        '
        Me.gbBaja.Controls.Add(Me.btnBajCan)
        Me.gbBaja.Controls.Add(Me.btnBaja)
        Me.gbBaja.Enabled = False
        Me.gbBaja.Location = New System.Drawing.Point(12, 440)
        Me.gbBaja.Name = "gbBaja"
        Me.gbBaja.Size = New System.Drawing.Size(489, 62)
        Me.gbBaja.TabIndex = 6
        Me.gbBaja.TabStop = False
        Me.gbBaja.Text = "BAJAS"
        '
        'btnBajCan
        '
        Me.btnBajCan.Location = New System.Drawing.Point(405, 21)
        Me.btnBajCan.Name = "btnBajCan"
        Me.btnBajCan.Size = New System.Drawing.Size(75, 32)
        Me.btnBajCan.TabIndex = 4
        Me.btnBajCan.Text = "Cancelar"
        Me.btnBajCan.UseVisualStyleBackColor = True
        '
        'btnBaja
        '
        Me.btnBaja.Location = New System.Drawing.Point(9, 21)
        Me.btnBaja.Name = "btnBaja"
        Me.btnBaja.Size = New System.Drawing.Size(390, 32)
        Me.btnBaja.TabIndex = 0
        Me.btnBaja.Text = "Dar de baja"
        Me.btnBaja.UseVisualStyleBackColor = True
        '
        'fLibreria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 526)
        Me.Controls.Add(Me.gbBaja)
        Me.Controls.Add(Me.gbMod)
        Me.Controls.Add(Me.gbAlta)
        Me.Controls.Add(Me.btnOpc)
        Me.Controls.Add(Me.gbOpcion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbUnidades)
        Me.Controls.Add(Me.lbLibros)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "fLibreria"
        Me.Text = "Ejercicio Libreria"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.gbOpcion.ResumeLayout(False)
        Me.gbOpcion.PerformLayout()
        Me.gbAlta.ResumeLayout(False)
        Me.gbAlta.PerformLayout()
        Me.gbMod.ResumeLayout(False)
        Me.gbMod.PerformLayout()
        Me.gbBaja.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OpcionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VerPortadasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents lbLibros As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lbUnidades As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents gbOpcion As GroupBox
    Friend WithEvents rbtnBaja As RadioButton
    Friend WithEvents rbtnMod As RadioButton
    Friend WithEvents rbtnAlta As RadioButton
    Friend WithEvents btnOpc As Button
    Friend WithEvents gbAlta As GroupBox
    Friend WithEvents tbAltaUni As TextBox
    Friend WithEvents tbAltaTit As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents gbMod As GroupBox
    Friend WithEvents gbBaja As GroupBox
    Friend WithEvents btnAltaCancelar As Button
    Friend WithEvents btnAltaConfirmar As Button
    Friend WithEvents btnModCanc As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents btnModConf As Button
    Friend WithEvents tbModUni As TextBox
    Friend WithEvents btnBaja As Button
    Friend WithEvents btnBajCan As Button
End Class
