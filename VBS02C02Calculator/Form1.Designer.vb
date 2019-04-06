<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.BTNSuma = New System.Windows.Forms.Button()
        Me.BTNResta = New System.Windows.Forms.Button()
        Me.BTNMul = New System.Windows.Forms.Button()
        Me.TXTPrimero = New System.Windows.Forms.TextBox()
        Me.TXTSegundo = New System.Windows.Forms.TextBox()
        Me.TXTResultado = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BTNSuma
        '
        Me.BTNSuma.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNSuma.Location = New System.Drawing.Point(146, 41)
        Me.BTNSuma.Name = "BTNSuma"
        Me.BTNSuma.Size = New System.Drawing.Size(108, 67)
        Me.BTNSuma.TabIndex = 0
        Me.BTNSuma.Text = "+"
        Me.BTNSuma.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        Me.BTNSuma.UseVisualStyleBackColor = True
        '
        'BTNResta
        '
        Me.BTNResta.Location = New System.Drawing.Point(146, 138)
        Me.BTNResta.Name = "BTNResta"
        Me.BTNResta.Size = New System.Drawing.Size(107, 65)
        Me.BTNResta.TabIndex = 1
        Me.BTNResta.Text = "-"
        Me.BTNResta.UseVisualStyleBackColor = True
        '
        'BTNMul
        '
        Me.BTNMul.Location = New System.Drawing.Point(146, 233)
        Me.BTNMul.Name = "BTNMul"
        Me.BTNMul.Size = New System.Drawing.Size(107, 63)
        Me.BTNMul.TabIndex = 2
        Me.BTNMul.Text = "X"
        Me.BTNMul.UseVisualStyleBackColor = True
        '
        'TXTPrimero
        '
        Me.TXTPrimero.Location = New System.Drawing.Point(24, 161)
        Me.TXTPrimero.Name = "TXTPrimero"
        Me.TXTPrimero.Size = New System.Drawing.Size(100, 20)
        Me.TXTPrimero.TabIndex = 3
        Me.TXTPrimero.Text = "primero"
        '
        'TXTSegundo
        '
        Me.TXTSegundo.Location = New System.Drawing.Point(275, 161)
        Me.TXTSegundo.Name = "TXTSegundo"
        Me.TXTSegundo.Size = New System.Drawing.Size(100, 20)
        Me.TXTSegundo.TabIndex = 4
        Me.TXTSegundo.Text = "segundo"
        '
        'TXTResultado
        '
        Me.TXTResultado.Location = New System.Drawing.Point(108, 341)
        Me.TXTResultado.Name = "TXTResultado"
        Me.TXTResultado.Size = New System.Drawing.Size(186, 20)
        Me.TXTResultado.TabIndex = 5
        Me.TXTResultado.Text = "Resultado"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 401)
        Me.Controls.Add(Me.TXTResultado)
        Me.Controls.Add(Me.TXTSegundo)
        Me.Controls.Add(Me.TXTPrimero)
        Me.Controls.Add(Me.BTNMul)
        Me.Controls.Add(Me.BTNResta)
        Me.Controls.Add(Me.BTNSuma)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTNSuma As Button
    Friend WithEvents BTNResta As Button
    Friend WithEvents BTNMul As Button
    Friend WithEvents TXTPrimero As TextBox
    Friend WithEvents TXTSegundo As TextBox
    Friend WithEvents TXTResultado As TextBox
End Class
