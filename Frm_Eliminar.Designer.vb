<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_Eliminar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Eliminar))
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.CMB_Cancelar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Text_CUIT = New System.Windows.Forms.TextBox()
        Me.Lab_CUIT = New System.Windows.Forms.Label()
        Me.Text_Mail = New System.Windows.Forms.TextBox()
        Me.Text_Telefono = New System.Windows.Forms.TextBox()
        Me.Lab_Mail = New System.Windows.Forms.Label()
        Me.Lab_Telefono = New System.Windows.Forms.Label()
        Me.Text_Nombre = New System.Windows.Forms.TextBox()
        Me.Text_DNI = New System.Windows.Forms.TextBox()
        Me.Lab_DNI = New System.Windows.Forms.Label()
        Me.CMB_Buscar = New System.Windows.Forms.Button()
        Me.Text_Edad = New System.Windows.Forms.TextBox()
        Me.Text_Direccion = New System.Windows.Forms.TextBox()
        Me.Text_Matricula = New System.Windows.Forms.TextBox()
        Me.Lab_Edad = New System.Windows.Forms.Label()
        Me.Lab_Direccion = New System.Windows.Forms.Label()
        Me.Lab_Nombre = New System.Windows.Forms.Label()
        Me.Lab_Matricula = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'CMB_Cancelar
        '
        Me.CMB_Cancelar.BackColor = System.Drawing.SystemColors.Control
        Me.CMB_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMB_Cancelar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.CMB_Cancelar.FlatAppearance.BorderSize = 0
        Me.CMB_Cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.CMB_Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.CMB_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CMB_Cancelar.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMB_Cancelar.Image = Global.ProyectoEmpresa.My.Resources.Resources.Button
        Me.CMB_Cancelar.Location = New System.Drawing.Point(466, 347)
        Me.CMB_Cancelar.Name = "CMB_Cancelar"
        Me.CMB_Cancelar.Size = New System.Drawing.Size(106, 29)
        Me.CMB_Cancelar.TabIndex = 17
        Me.CMB_Cancelar.Text = "Salir"
        Me.CMB_Cancelar.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Text_CUIT)
        Me.GroupBox1.Controls.Add(Me.Lab_CUIT)
        Me.GroupBox1.Controls.Add(Me.Text_Mail)
        Me.GroupBox1.Controls.Add(Me.Text_Telefono)
        Me.GroupBox1.Controls.Add(Me.Lab_Mail)
        Me.GroupBox1.Controls.Add(Me.Lab_Telefono)
        Me.GroupBox1.Controls.Add(Me.Text_Nombre)
        Me.GroupBox1.Controls.Add(Me.Text_DNI)
        Me.GroupBox1.Controls.Add(Me.Lab_DNI)
        Me.GroupBox1.Controls.Add(Me.CMB_Buscar)
        Me.GroupBox1.Controls.Add(Me.Text_Edad)
        Me.GroupBox1.Controls.Add(Me.Text_Direccion)
        Me.GroupBox1.Controls.Add(Me.Text_Matricula)
        Me.GroupBox1.Controls.Add(Me.Lab_Edad)
        Me.GroupBox1.Controls.Add(Me.Lab_Direccion)
        Me.GroupBox1.Controls.Add(Me.Lab_Nombre)
        Me.GroupBox1.Controls.Add(Me.Lab_Matricula)
        Me.GroupBox1.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(560, 293)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        '
        'Text_CUIT
        '
        Me.Text_CUIT.Location = New System.Drawing.Point(171, 183)
        Me.Text_CUIT.Name = "Text_CUIT"
        Me.Text_CUIT.Size = New System.Drawing.Size(116, 23)
        Me.Text_CUIT.TabIndex = 12
        '
        'Lab_CUIT
        '
        Me.Lab_CUIT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lab_CUIT.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_CUIT.Location = New System.Drawing.Point(21, 185)
        Me.Lab_CUIT.Name = "Lab_CUIT"
        Me.Lab_CUIT.Size = New System.Drawing.Size(144, 20)
        Me.Lab_CUIT.TabIndex = 11
        Me.Lab_CUIT.Text = "CUIT o CUIL"
        '
        'Text_Mail
        '
        Me.Text_Mail.Location = New System.Drawing.Point(171, 248)
        Me.Text_Mail.Name = "Text_Mail"
        Me.Text_Mail.Size = New System.Drawing.Size(370, 23)
        Me.Text_Mail.TabIndex = 16
        '
        'Text_Telefono
        '
        Me.Text_Telefono.Location = New System.Drawing.Point(171, 214)
        Me.Text_Telefono.Name = "Text_Telefono"
        Me.Text_Telefono.Size = New System.Drawing.Size(116, 23)
        Me.Text_Telefono.TabIndex = 14
        '
        'Lab_Mail
        '
        Me.Lab_Mail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lab_Mail.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Mail.Location = New System.Drawing.Point(21, 248)
        Me.Lab_Mail.Name = "Lab_Mail"
        Me.Lab_Mail.Size = New System.Drawing.Size(144, 20)
        Me.Lab_Mail.TabIndex = 15
        Me.Lab_Mail.Text = "Mail"
        '
        'Lab_Telefono
        '
        Me.Lab_Telefono.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lab_Telefono.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Telefono.Location = New System.Drawing.Point(21, 216)
        Me.Lab_Telefono.Name = "Lab_Telefono"
        Me.Lab_Telefono.Size = New System.Drawing.Size(144, 21)
        Me.Lab_Telefono.TabIndex = 13
        Me.Lab_Telefono.Text = "Teléfono"
        '
        'Text_Nombre
        '
        Me.Text_Nombre.Location = New System.Drawing.Point(171, 63)
        Me.Text_Nombre.Name = "Text_Nombre"
        Me.Text_Nombre.Size = New System.Drawing.Size(370, 23)
        Me.Text_Nombre.TabIndex = 4
        '
        'Text_DNI
        '
        Me.Text_DNI.Location = New System.Drawing.Point(171, 153)
        Me.Text_DNI.Name = "Text_DNI"
        Me.Text_DNI.Size = New System.Drawing.Size(116, 23)
        Me.Text_DNI.TabIndex = 10
        '
        'Lab_DNI
        '
        Me.Lab_DNI.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lab_DNI.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_DNI.Location = New System.Drawing.Point(21, 155)
        Me.Lab_DNI.Name = "Lab_DNI"
        Me.Lab_DNI.Size = New System.Drawing.Size(144, 20)
        Me.Lab_DNI.TabIndex = 9
        Me.Lab_DNI.Text = "DNI"
        '
        'CMB_Buscar
        '
        Me.CMB_Buscar.BackColor = System.Drawing.SystemColors.Control
        Me.CMB_Buscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMB_Buscar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.CMB_Buscar.FlatAppearance.BorderSize = 0
        Me.CMB_Buscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.CMB_Buscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.CMB_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CMB_Buscar.Image = Global.ProyectoEmpresa.My.Resources.Resources.Button
        Me.CMB_Buscar.Location = New System.Drawing.Point(253, 27)
        Me.CMB_Buscar.Name = "CMB_Buscar"
        Me.CMB_Buscar.Size = New System.Drawing.Size(112, 25)
        Me.CMB_Buscar.TabIndex = 2
        Me.CMB_Buscar.Text = "Buscar"
        Me.CMB_Buscar.UseVisualStyleBackColor = False
        '
        'Text_Edad
        '
        Me.Text_Edad.Location = New System.Drawing.Point(171, 124)
        Me.Text_Edad.Name = "Text_Edad"
        Me.Text_Edad.Size = New System.Drawing.Size(39, 23)
        Me.Text_Edad.TabIndex = 8
        '
        'Text_Direccion
        '
        Me.Text_Direccion.Location = New System.Drawing.Point(171, 92)
        Me.Text_Direccion.Name = "Text_Direccion"
        Me.Text_Direccion.Size = New System.Drawing.Size(370, 23)
        Me.Text_Direccion.TabIndex = 6
        '
        'Text_Matricula
        '
        Me.Text_Matricula.Location = New System.Drawing.Point(171, 29)
        Me.Text_Matricula.Name = "Text_Matricula"
        Me.Text_Matricula.Size = New System.Drawing.Size(63, 23)
        Me.Text_Matricula.TabIndex = 1
        '
        'Lab_Edad
        '
        Me.Lab_Edad.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lab_Edad.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Edad.Location = New System.Drawing.Point(21, 124)
        Me.Lab_Edad.Name = "Lab_Edad"
        Me.Lab_Edad.Size = New System.Drawing.Size(144, 20)
        Me.Lab_Edad.TabIndex = 7
        Me.Lab_Edad.Text = "Edad"
        '
        'Lab_Direccion
        '
        Me.Lab_Direccion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lab_Direccion.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Direccion.Location = New System.Drawing.Point(21, 92)
        Me.Lab_Direccion.Name = "Lab_Direccion"
        Me.Lab_Direccion.Size = New System.Drawing.Size(144, 21)
        Me.Lab_Direccion.TabIndex = 5
        Me.Lab_Direccion.Text = "Dirección"
        '
        'Lab_Nombre
        '
        Me.Lab_Nombre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lab_Nombre.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Nombre.Location = New System.Drawing.Point(21, 63)
        Me.Lab_Nombre.Name = "Lab_Nombre"
        Me.Lab_Nombre.Size = New System.Drawing.Size(144, 20)
        Me.Lab_Nombre.TabIndex = 3
        Me.Lab_Nombre.Text = "Apellido y Nombre"
        '
        'Lab_Matricula
        '
        Me.Lab_Matricula.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Lab_Matricula.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_Matricula.Location = New System.Drawing.Point(21, 32)
        Me.Lab_Matricula.Name = "Lab_Matricula"
        Me.Lab_Matricula.Size = New System.Drawing.Size(144, 20)
        Me.Lab_Matricula.TabIndex = 0
        Me.Lab_Matricula.Text = " Nº Cliente"
        '
        'Frm_Eliminar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 401)
        Me.Controls.Add(Me.CMB_Cancelar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Frm_Eliminar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Eliminar Registro"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
    Friend WithEvents CMB_Cancelar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Text_Mail As TextBox
    Friend WithEvents Text_Telefono As TextBox
    Friend WithEvents Lab_Mail As Label
    Friend WithEvents Lab_Telefono As Label
    Friend WithEvents Text_Nombre As TextBox
    Friend WithEvents Text_DNI As TextBox
    Friend WithEvents Lab_DNI As Label
    Friend WithEvents CMB_Buscar As Button
    Friend WithEvents Text_Edad As TextBox
    Friend WithEvents Text_Direccion As TextBox
    Friend WithEvents Text_Matricula As TextBox
    Friend WithEvents Lab_Edad As Label
    Friend WithEvents Lab_Direccion As Label
    Friend WithEvents Lab_Nombre As Label
    Friend WithEvents Lab_Matricula As Label
    Friend WithEvents Text_CUIT As TextBox
    Friend WithEvents Lab_CUIT As Label
End Class
