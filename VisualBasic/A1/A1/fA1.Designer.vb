<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class fA1
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
        Me.rbSum = New System.Windows.Forms.RadioButton()
        Me.rbRes = New System.Windows.Forms.RadioButton()
        Me.rbDiv = New System.Windows.Forms.RadioButton()
        Me.rbMul = New System.Windows.Forms.RadioButton()
        Me.rbMe = New System.Windows.Forms.RadioButton()
        Me.rbMa = New System.Windows.Forms.RadioButton()
        Me.rbMenIg = New System.Windows.Forms.RadioButton()
        Me.rbMayIg = New System.Windows.Forms.RadioButton()
        Me.rbDis = New System.Windows.Forms.RadioButton()
        Me.rbIg = New System.Windows.Forms.RadioButton()
        Me.tb1 = New System.Windows.Forms.TextBox()
        Me.tb2 = New System.Windows.Forms.TextBox()
        Me.btnOpe = New System.Windows.Forms.Button()
        Me.lblResul = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'rbSum
        '
        Me.rbSum.AutoSize = True
        Me.rbSum.Location = New System.Drawing.Point(24, 41)
        Me.rbSum.Name = "rbSum"
        Me.rbSum.Size = New System.Drawing.Size(55, 17)
        Me.rbSum.TabIndex = 0
        Me.rbSum.TabStop = True
        Me.rbSum.Text = "Sumar"
        Me.rbSum.UseVisualStyleBackColor = True
        '
        'rbRes
        '
        Me.rbRes.AutoSize = True
        Me.rbRes.Location = New System.Drawing.Point(148, 41)
        Me.rbRes.Name = "rbRes"
        Me.rbRes.Size = New System.Drawing.Size(56, 17)
        Me.rbRes.TabIndex = 1
        Me.rbRes.TabStop = True
        Me.rbRes.Text = "Restar"
        Me.rbRes.UseVisualStyleBackColor = True
        '
        'rbDiv
        '
        Me.rbDiv.AutoSize = True
        Me.rbDiv.Location = New System.Drawing.Point(148, 64)
        Me.rbDiv.Name = "rbDiv"
        Me.rbDiv.Size = New System.Drawing.Size(54, 17)
        Me.rbDiv.TabIndex = 3
        Me.rbDiv.TabStop = True
        Me.rbDiv.Text = "Dividir"
        Me.rbDiv.UseVisualStyleBackColor = True
        '
        'rbMul
        '
        Me.rbMul.AutoSize = True
        Me.rbMul.Location = New System.Drawing.Point(24, 64)
        Me.rbMul.Name = "rbMul"
        Me.rbMul.Size = New System.Drawing.Size(72, 17)
        Me.rbMul.TabIndex = 2
        Me.rbMul.TabStop = True
        Me.rbMul.Text = "Multiplicar"
        Me.rbMul.UseVisualStyleBackColor = True
        '
        'rbMe
        '
        Me.rbMe.AutoSize = True
        Me.rbMe.Location = New System.Drawing.Point(148, 87)
        Me.rbMe.Name = "rbMe"
        Me.rbMe.Size = New System.Drawing.Size(55, 17)
        Me.rbMe.TabIndex = 5
        Me.rbMe.TabStop = True
        Me.rbMe.Text = "Menor"
        Me.rbMe.UseVisualStyleBackColor = True
        '
        'rbMa
        '
        Me.rbMa.AutoSize = True
        Me.rbMa.Location = New System.Drawing.Point(24, 87)
        Me.rbMa.Name = "rbMa"
        Me.rbMa.Size = New System.Drawing.Size(54, 17)
        Me.rbMa.TabIndex = 4
        Me.rbMa.TabStop = True
        Me.rbMa.Text = "Mayor"
        Me.rbMa.UseVisualStyleBackColor = True
        '
        'rbMenIg
        '
        Me.rbMenIg.AutoSize = True
        Me.rbMenIg.Location = New System.Drawing.Point(148, 110)
        Me.rbMenIg.Name = "rbMenIg"
        Me.rbMenIg.Size = New System.Drawing.Size(89, 17)
        Me.rbMenIg.TabIndex = 7
        Me.rbMenIg.TabStop = True
        Me.rbMenIg.Text = "Menor o igual"
        Me.rbMenIg.UseVisualStyleBackColor = True
        '
        'rbMayIg
        '
        Me.rbMayIg.AutoSize = True
        Me.rbMayIg.Location = New System.Drawing.Point(24, 110)
        Me.rbMayIg.Name = "rbMayIg"
        Me.rbMayIg.Size = New System.Drawing.Size(88, 17)
        Me.rbMayIg.TabIndex = 6
        Me.rbMayIg.TabStop = True
        Me.rbMayIg.Text = "Mayor o igual"
        Me.rbMayIg.UseVisualStyleBackColor = True
        '
        'rbDis
        '
        Me.rbDis.AutoSize = True
        Me.rbDis.Location = New System.Drawing.Point(148, 133)
        Me.rbDis.Name = "rbDis"
        Me.rbDis.Size = New System.Drawing.Size(60, 17)
        Me.rbDis.TabIndex = 9
        Me.rbDis.TabStop = True
        Me.rbDis.Text = "Distinto"
        Me.rbDis.UseVisualStyleBackColor = True
        '
        'rbIg
        '
        Me.rbIg.AutoSize = True
        Me.rbIg.Location = New System.Drawing.Point(24, 133)
        Me.rbIg.Name = "rbIg"
        Me.rbIg.Size = New System.Drawing.Size(48, 17)
        Me.rbIg.TabIndex = 8
        Me.rbIg.TabStop = True
        Me.rbIg.Text = "Igual"
        Me.rbIg.UseVisualStyleBackColor = True
        '
        'tb1
        '
        Me.tb1.Location = New System.Drawing.Point(12, 12)
        Me.tb1.Name = "tb1"
        Me.tb1.Size = New System.Drawing.Size(100, 20)
        Me.tb1.TabIndex = 10
        '
        'tb2
        '
        Me.tb2.Location = New System.Drawing.Point(124, 12)
        Me.tb2.Name = "tb2"
        Me.tb2.Size = New System.Drawing.Size(100, 20)
        Me.tb2.TabIndex = 10
        '
        'btnOpe
        '
        Me.btnOpe.Location = New System.Drawing.Point(80, 166)
        Me.btnOpe.Name = "btnOpe"
        Me.btnOpe.Size = New System.Drawing.Size(75, 23)
        Me.btnOpe.TabIndex = 11
        Me.btnOpe.Text = "Realizar operacion"
        Me.btnOpe.UseVisualStyleBackColor = True
        '
        'lblResul
        '
        Me.lblResul.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblResul.Location = New System.Drawing.Point(12, 203)
        Me.lblResul.Name = "lblResul"
        Me.lblResul.Size = New System.Drawing.Size(212, 28)
        Me.lblResul.TabIndex = 12
        Me.lblResul.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'fA1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(241, 251)
        Me.Controls.Add(Me.lblResul)
        Me.Controls.Add(Me.btnOpe)
        Me.Controls.Add(Me.tb2)
        Me.Controls.Add(Me.tb1)
        Me.Controls.Add(Me.rbDis)
        Me.Controls.Add(Me.rbIg)
        Me.Controls.Add(Me.rbMenIg)
        Me.Controls.Add(Me.rbMayIg)
        Me.Controls.Add(Me.rbMe)
        Me.Controls.Add(Me.rbMa)
        Me.Controls.Add(Me.rbDiv)
        Me.Controls.Add(Me.rbMul)
        Me.Controls.Add(Me.rbRes)
        Me.Controls.Add(Me.rbSum)
        Me.Name = "fA1"
        Me.Text = "Ejercicio A1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rbSum As RadioButton
    Friend WithEvents rbRes As RadioButton
    Friend WithEvents rbDiv As RadioButton
    Friend WithEvents rbMul As RadioButton
    Friend WithEvents rbMe As RadioButton
    Friend WithEvents rbMa As RadioButton
    Friend WithEvents rbMenIg As RadioButton
    Friend WithEvents rbMayIg As RadioButton
    Friend WithEvents rbDis As RadioButton
    Friend WithEvents rbIg As RadioButton
    Friend WithEvents tb1 As TextBox
    Friend WithEvents tb2 As TextBox
    Friend WithEvents btnOpe As Button
    Friend WithEvents lblResul As Label
End Class
