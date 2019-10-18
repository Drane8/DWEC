<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class fC7
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
        Me.lvArrayOriginal = New System.Windows.Forms.ListView()
        Me.lvArrayCambiado = New System.Windows.Forms.ListView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnMover = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lvArrayOriginal
        '
        Me.lvArrayOriginal.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid
        Me.lvArrayOriginal.FullRowSelect = True
        Me.lvArrayOriginal.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lvArrayOriginal.HideSelection = False
        Me.lvArrayOriginal.Location = New System.Drawing.Point(12, 12)
        Me.lvArrayOriginal.Name = "lvArrayOriginal"
        Me.lvArrayOriginal.Size = New System.Drawing.Size(93, 80)
        Me.lvArrayOriginal.TabIndex = 0
        Me.lvArrayOriginal.TileSize = New System.Drawing.Size(30, 30)
        Me.lvArrayOriginal.UseCompatibleStateImageBehavior = False
        Me.lvArrayOriginal.View = System.Windows.Forms.View.Details
        '
        'lvArrayCambiado
        '
        Me.lvArrayCambiado.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid
        Me.lvArrayCambiado.FullRowSelect = True
        Me.lvArrayCambiado.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lvArrayCambiado.HideSelection = False
        Me.lvArrayCambiado.Location = New System.Drawing.Point(127, 12)
        Me.lvArrayCambiado.Name = "lvArrayCambiado"
        Me.lvArrayCambiado.Size = New System.Drawing.Size(93, 80)
        Me.lvArrayCambiado.TabIndex = 0
        Me.lvArrayCambiado.TileSize = New System.Drawing.Size(30, 30)
        Me.lvArrayCambiado.UseCompatibleStateImageBehavior = False
        Me.lvArrayCambiado.View = System.Windows.Forms.View.Details
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Original"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(146, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cambiado"
        '
        'btnMover
        '
        Me.btnMover.Location = New System.Drawing.Point(12, 125)
        Me.btnMover.Name = "btnMover"
        Me.btnMover.Size = New System.Drawing.Size(208, 23)
        Me.btnMover.TabIndex = 2
        Me.btnMover.Text = "Mover"
        Me.btnMover.UseVisualStyleBackColor = True
        '
        'fC7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(233, 159)
        Me.Controls.Add(Me.btnMover)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lvArrayCambiado)
        Me.Controls.Add(Me.lvArrayOriginal)
        Me.Name = "fC7"
        Me.Text = "Ejercicio C7"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lvArrayOriginal As ListView
    Friend WithEvents lvArrayCambiado As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnMover As Button
End Class
