<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Finalizar
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
        Me.CMB_Si = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CMB_No = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'CMB_Si
        '
        Me.CMB_Si.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CMB_Si.Image = Global.ProyectoEmpresa.My.Resources.Resources.Button
        Me.CMB_Si.Location = New System.Drawing.Point(34, 104)
        Me.CMB_Si.Name = "CMB_Si"
        Me.CMB_Si.Size = New System.Drawing.Size(111, 47)
        Me.CMB_Si.TabIndex = 0
        Me.CMB_Si.Text = "Sí"
        Me.CMB_Si.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(31, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(294, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "¿Está seguro que desea salir del programa?"
        '
        'CMB_No
        '
        Me.CMB_No.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CMB_No.Image = Global.ProyectoEmpresa.My.Resources.Resources.Button
        Me.CMB_No.Location = New System.Drawing.Point(214, 104)
        Me.CMB_No.Name = "CMB_No"
        Me.CMB_No.Size = New System.Drawing.Size(111, 47)
        Me.CMB_No.TabIndex = 1
        Me.CMB_No.Text = "No"
        Me.CMB_No.UseVisualStyleBackColor = True
        '
        'Frm_Finalizar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 190)
        Me.Controls.Add(Me.CMB_No)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CMB_Si)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frm_Finalizar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Finalizar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CMB_Si As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents CMB_No As Button
End Class
