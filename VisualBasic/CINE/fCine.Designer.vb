<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fCine
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(fCine))
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.mnuSalas = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSala1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSala2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSala3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSala4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFin = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompraDeLocalidadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbSalas = New System.Windows.Forms.ComboBox()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbPeliculas = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.pbCartel = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblEntradas = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnTerminar = New System.Windows.Forms.Button()
        Me.rtbSinopsis = New System.Windows.Forms.RichTextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.mnuMain.SuspendLayout()
        CType(Me.pbCartel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSalas, Me.CompraDeLocalidadesToolStripMenuItem})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(693, 24)
        Me.mnuMain.TabIndex = 1
        Me.mnuMain.Text = "MenuStrip1"
        '
        'mnuSalas
        '
        Me.mnuSalas.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuSala1, Me.mnuSala2, Me.mnuSala3, Me.mnuSala4, Me.ToolStripSeparator1, Me.mnuFin})
        Me.mnuSalas.Name = "mnuSalas"
        Me.mnuSalas.Size = New System.Drawing.Size(45, 20)
        Me.mnuSalas.Text = "Salas"
        '
        'mnuSala1
        '
        Me.mnuSala1.Name = "mnuSala1"
        Me.mnuSala1.Size = New System.Drawing.Size(117, 22)
        Me.mnuSala1.Text = "Sala 1"
        '
        'mnuSala2
        '
        Me.mnuSala2.Name = "mnuSala2"
        Me.mnuSala2.Size = New System.Drawing.Size(117, 22)
        Me.mnuSala2.Text = "Sala 2"
        '
        'mnuSala3
        '
        Me.mnuSala3.Name = "mnuSala3"
        Me.mnuSala3.Size = New System.Drawing.Size(117, 22)
        Me.mnuSala3.Text = "Sala 3"
        '
        'mnuSala4
        '
        Me.mnuSala4.Name = "mnuSala4"
        Me.mnuSala4.Size = New System.Drawing.Size(117, 22)
        Me.mnuSala4.Text = "Sala 4"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(114, 6)
        '
        'mnuFin
        '
        Me.mnuFin.Name = "mnuFin"
        Me.mnuFin.Size = New System.Drawing.Size(117, 22)
        Me.mnuFin.Text = "Finalizar"
        '
        'CompraDeLocalidadesToolStripMenuItem
        '
        Me.CompraDeLocalidadesToolStripMenuItem.Name = "CompraDeLocalidadesToolStripMenuItem"
        Me.CompraDeLocalidadesToolStripMenuItem.Size = New System.Drawing.Size(140, 20)
        Me.CompraDeLocalidadesToolStripMenuItem.Text = "Compra de localidades"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Salas"
        '
        'cbSalas
        '
        Me.cbSalas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSalas.FormattingEnabled = True
        Me.cbSalas.Items.AddRange(New Object() {"Sala 1", "Sala 2", "Sala 3", "Sala 4"})
        Me.cbSalas.Location = New System.Drawing.Point(16, 41)
        Me.cbSalas.Name = "cbSalas"
        Me.cbSalas.Size = New System.Drawing.Size(115, 32)
        Me.cbSalas.TabIndex = 3
        '
        'lblTitulo
        '
        Me.lblTitulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTitulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.ForeColor = System.Drawing.Color.Red
        Me.lblTitulo.Location = New System.Drawing.Point(165, 24)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(495, 47)
        Me.lblTitulo.TabIndex = 4
        Me.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Título"
        '
        'lbPeliculas
        '
        Me.lbPeliculas.Enabled = False
        Me.lbPeliculas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbPeliculas.FormattingEnabled = True
        Me.lbPeliculas.ItemHeight = 24
        Me.lbPeliculas.Items.AddRange(New Object() {"ARGO", "A ROMA CON AMOR", "EL LADRÓN DE PALABRAS", "EL PROFESOR"})
        Me.lbPeliculas.Location = New System.Drawing.Point(16, 99)
        Me.lbPeliculas.Name = "lbPeliculas"
        Me.lbPeliculas.Size = New System.Drawing.Size(257, 148)
        Me.lbPeliculas.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(289, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Cartel"
        '
        'pbCartel
        '
        Me.pbCartel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbCartel.ErrorImage = CType(resources.GetObject("pbCartel.ErrorImage"), System.Drawing.Image)
        Me.pbCartel.Location = New System.Drawing.Point(292, 99)
        Me.pbCartel.Name = "pbCartel"
        Me.pbCartel.Size = New System.Drawing.Size(169, 245)
        Me.pbCartel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbCartel.TabIndex = 7
        Me.pbCartel.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(478, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Sinopsis"
        '
        'lblEntradas
        '
        Me.lblEntradas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEntradas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblEntradas.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEntradas.ForeColor = System.Drawing.Color.Black
        Me.lblEntradas.Location = New System.Drawing.Point(52, 293)
        Me.lblEntradas.Name = "lblEntradas"
        Me.lblEntradas.Size = New System.Drawing.Size(185, 103)
        Me.lblEntradas.TabIndex = 4
        Me.lblEntradas.Text = "0"
        Me.lblEntradas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(49, 259)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(186, 24)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Entradas Compradas"
        '
        'btnTerminar
        '
        Me.btnTerminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTerminar.Location = New System.Drawing.Point(410, 373)
        Me.btnTerminar.Name = "btnTerminar"
        Me.btnTerminar.Size = New System.Drawing.Size(271, 50)
        Me.btnTerminar.TabIndex = 9
        Me.btnTerminar.Text = "&Terminar"
        Me.btnTerminar.UseVisualStyleBackColor = True
        '
        'rtbSinopsis
        '
        Me.rtbSinopsis.Location = New System.Drawing.Point(481, 99)
        Me.rtbSinopsis.Name = "rtbSinopsis"
        Me.rtbSinopsis.Size = New System.Drawing.Size(200, 244)
        Me.rtbSinopsis.TabIndex = 10
        Me.rtbSinopsis.Text = ""
        '
        'Timer1
        '
        Me.Timer1.Interval = 700
        '
        'fCine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 491)
        Me.Controls.Add(Me.rtbSinopsis)
        Me.Controls.Add(Me.btnTerminar)
        Me.Controls.Add(Me.pbCartel)
        Me.Controls.Add(Me.lbPeliculas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblEntradas)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.cbSalas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.mnuMain)
        Me.MainMenuStrip = Me.mnuMain
        Me.Name = "fCine"
        Me.Text = "CINE"
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        CType(Me.pbCartel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnuMain As MenuStrip
    Friend WithEvents mnuSalas As ToolStripMenuItem
    Friend WithEvents mnuSala1 As ToolStripMenuItem
    Friend WithEvents mnuSala2 As ToolStripMenuItem
    Friend WithEvents mnuSala3 As ToolStripMenuItem
    Friend WithEvents mnuSala4 As ToolStripMenuItem
    Friend WithEvents mnuFin As ToolStripMenuItem
    Friend WithEvents CompraDeLocalidadesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents Label1 As Label
    Friend WithEvents cbSalas As ComboBox
    Friend WithEvents lblTitulo As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbPeliculas As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents pbCartel As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents lblEntradas As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnTerminar As Button
    Friend WithEvents rtbSinopsis As RichTextBox
    Friend WithEvents Timer1 As Timer
End Class
