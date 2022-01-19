<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Login))
        Me.Lab_Inicial = New System.Windows.Forms.Label()
        Me.Lab_Usuario = New System.Windows.Forms.Label()
        Me.Lab_Contraseña = New System.Windows.Forms.Label()
        Me.Text_Usuario = New System.Windows.Forms.TextBox()
        Me.Text_Contraseña = New System.Windows.Forms.TextBox()
        Me.CMB_Ingresar = New System.Windows.Forms.Button()
        Me.CMB_Salir = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Lab_Inicial
        '
        Me.Lab_Inicial.AutoSize = True
        Me.Lab_Inicial.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Lab_Inicial.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Inicial.Location = New System.Drawing.Point(256, 12)
        Me.Lab_Inicial.Name = "Lab_Inicial"
        Me.Lab_Inicial.Size = New System.Drawing.Size(258, 16)
        Me.Lab_Inicial.TabIndex = 0
        Me.Lab_Inicial.Text = "Ingrese el Usuario y la Contraseña"
        '
        'Lab_Usuario
        '
        Me.Lab_Usuario.AutoSize = True
        Me.Lab_Usuario.Location = New System.Drawing.Point(230, 61)
        Me.Lab_Usuario.Name = "Lab_Usuario"
        Me.Lab_Usuario.Size = New System.Drawing.Size(68, 16)
        Me.Lab_Usuario.TabIndex = 1
        Me.Lab_Usuario.Text = "Usuario:"
        '
        'Lab_Contraseña
        '
        Me.Lab_Contraseña.AutoSize = True
        Me.Lab_Contraseña.Location = New System.Drawing.Point(230, 108)
        Me.Lab_Contraseña.Name = "Lab_Contraseña"
        Me.Lab_Contraseña.Size = New System.Drawing.Size(97, 16)
        Me.Lab_Contraseña.TabIndex = 2
        Me.Lab_Contraseña.Text = "Contraseña:"
        '
        'Text_Usuario
        '
        Me.Text_Usuario.Location = New System.Drawing.Point(338, 54)
        Me.Text_Usuario.Name = "Text_Usuario"
        Me.Text_Usuario.Size = New System.Drawing.Size(202, 23)
        Me.Text_Usuario.TabIndex = 3
        '
        'Text_Contraseña
        '
        Me.Text_Contraseña.Location = New System.Drawing.Point(338, 101)
        Me.Text_Contraseña.Name = "Text_Contraseña"
        Me.Text_Contraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Text_Contraseña.Size = New System.Drawing.Size(202, 23)
        Me.Text_Contraseña.TabIndex = 4
        '
        'CMB_Ingresar
        '
        Me.CMB_Ingresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CMB_Ingresar.Image = Global.ProyectoEmpresa.My.Resources.Resources.Button
        Me.CMB_Ingresar.Location = New System.Drawing.Point(270, 169)
        Me.CMB_Ingresar.Name = "CMB_Ingresar"
        Me.CMB_Ingresar.Size = New System.Drawing.Size(102, 41)
        Me.CMB_Ingresar.TabIndex = 5
        Me.CMB_Ingresar.Text = "Ingresar"
        Me.CMB_Ingresar.UseVisualStyleBackColor = True
        '
        'CMB_Salir
        '
        Me.CMB_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CMB_Salir.Image = Global.ProyectoEmpresa.My.Resources.Resources.Button
        Me.CMB_Salir.Location = New System.Drawing.Point(438, 169)
        Me.CMB_Salir.Name = "CMB_Salir"
        Me.CMB_Salir.Size = New System.Drawing.Size(102, 41)
        Me.CMB_Salir.TabIndex = 6
        Me.CMB_Salir.Text = "Salir"
        Me.CMB_Salir.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(199, 198)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Frm_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 222)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CMB_Salir)
        Me.Controls.Add(Me.CMB_Ingresar)
        Me.Controls.Add(Me.Text_Contraseña)
        Me.Controls.Add(Me.Text_Usuario)
        Me.Controls.Add(Me.Lab_Contraseña)
        Me.Controls.Add(Me.Lab_Usuario)
        Me.Controls.Add(Me.Lab_Inicial)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Frm_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Iniciar Sesión"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lab_Inicial As Label
    Friend WithEvents Lab_Usuario As Label
    Friend WithEvents Lab_Contraseña As Label
    Friend WithEvents Text_Usuario As TextBox
    Friend WithEvents Text_Contraseña As TextBox
    Friend WithEvents CMB_Ingresar As Button
    Friend WithEvents CMB_Salir As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
