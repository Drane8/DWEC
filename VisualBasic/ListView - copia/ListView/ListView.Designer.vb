<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListView
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
        Me.txtCampo1 = New System.Windows.Forms.TextBox()
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
        Me.lstVPrincipal = New System.Windows.Forms.ListView()
        Me.lstVCampo1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstVCampo2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lstVCampo3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'txtCampo1
        '
        Me.txtCampo1.Location = New System.Drawing.Point(180, 88)
        Me.txtCampo1.Name = "txtCampo1"
        Me.txtCampo1.Size = New System.Drawing.Size(176, 20)
        Me.txtCampo1.TabIndex = 3
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
        Me.lblCampo1.Size = New System.Drawing.Size(72, 13)
        Me.lblCampo1.TabIndex = 8
        Me.lblCampo1.Text = "Columna Nº 1"
        '
        'lblCampo2
        '
        Me.lblCampo2.AutoSize = True
        Me.lblCampo2.Location = New System.Drawing.Point(81, 137)
        Me.lblCampo2.Name = "lblCampo2"
        Me.lblCampo2.Size = New System.Drawing.Size(72, 13)
        Me.lblCampo2.TabIndex = 9
        Me.lblCampo2.Text = "Columna Nº 2"
        '
        'lblCampo3
        '
        Me.lblCampo3.AutoSize = True
        Me.lblCampo3.Location = New System.Drawing.Point(81, 180)
        Me.lblCampo3.Name = "lblCampo3"
        Me.lblCampo3.Size = New System.Drawing.Size(72, 13)
        Me.lblCampo3.TabIndex = 10
        Me.lblCampo3.Text = "Columna Nº 3"
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
        'lstVPrincipal
        '
        Me.lstVPrincipal.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lstVCampo1, Me.lstVCampo2, Me.lstVCampo3})
        Me.lstVPrincipal.FullRowSelect = True
        Me.lstVPrincipal.GridLines = True
        Me.lstVPrincipal.HideSelection = False
        Me.lstVPrincipal.Location = New System.Drawing.Point(481, 67)
        Me.lstVPrincipal.Name = "lstVPrincipal"
        Me.lstVPrincipal.Size = New System.Drawing.Size(465, 374)
        Me.lstVPrincipal.TabIndex = 28
        Me.lstVPrincipal.UseCompatibleStateImageBehavior = False
        Me.lstVPrincipal.View = System.Windows.Forms.View.Details
        '
        'lstVCampo1
        '
        Me.lstVCampo1.Text = "Columna 1"
        Me.lstVCampo1.Width = 154
        '
        'lstVCampo2
        '
        Me.lstVCampo2.Text = "Columna 2"
        Me.lstVCampo2.Width = 162
        '
        'lstVCampo3
        '
        Me.lstVCampo3.Text = "Campo 3"
        Me.lstVCampo3.Width = 139
        '
        'frmListView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1031, 524)
        Me.Controls.Add(Me.lstVPrincipal)
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
        Me.Controls.Add(Me.txtCampo1)
        Me.Name = "frmListView"
        Me.Text = "Ejemplo de funcionamiento para ListBox"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCampo1 As TextBox
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
    Friend WithEvents lstVPrincipal As Windows.Forms.ListView
    Friend WithEvents lstVCampo1 As ColumnHeader
    Friend WithEvents lstVCampo2 As ColumnHeader
    Friend WithEvents lstVCampo3 As ColumnHeader
End Class
