<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Listado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Listado))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CMB_Buscar = New System.Windows.Forms.Button()
        Me.Text_Matricula = New System.Windows.Forms.TextBox()
        Me.CMB_Actualizar = New System.Windows.Forms.Button()
        Me.CMB_Imprimir = New System.Windows.Forms.Button()
        Me.CMB_Cancelar = New System.Windows.Forms.Button()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.MatriculaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EdadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DNIDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CUITDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PersonalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BBDDmaestraDataSet = New ProyectoEmpresa.BBDDmaestraDataSet()
        Me.PersonalTableAdapter = New ProyectoEmpresa.BBDDmaestraDataSetTableAdapters.PersonalTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BBDDmaestraDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MatriculaDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn, Me.EdadDataGridViewTextBoxColumn, Me.DNIDataGridViewTextBoxColumn, Me.CUITDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.MailDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.PersonalBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(29, 27)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1204, 516)
        Me.DataGridView1.TabIndex = 0
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
        Me.CMB_Buscar.Location = New System.Drawing.Point(256, 568)
        Me.CMB_Buscar.Name = "CMB_Buscar"
        Me.CMB_Buscar.Size = New System.Drawing.Size(112, 25)
        Me.CMB_Buscar.TabIndex = 2
        Me.CMB_Buscar.Text = "Buscar"
        Me.CMB_Buscar.UseVisualStyleBackColor = False
        '
        'Text_Matricula
        '
        Me.Text_Matricula.Location = New System.Drawing.Point(98, 568)
        Me.Text_Matricula.Multiline = True
        Me.Text_Matricula.Name = "Text_Matricula"
        Me.Text_Matricula.Size = New System.Drawing.Size(112, 25)
        Me.Text_Matricula.TabIndex = 1
        '
        'CMB_Actualizar
        '
        Me.CMB_Actualizar.BackColor = System.Drawing.SystemColors.Control
        Me.CMB_Actualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMB_Actualizar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.CMB_Actualizar.FlatAppearance.BorderSize = 0
        Me.CMB_Actualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.CMB_Actualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.CMB_Actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CMB_Actualizar.Image = Global.ProyectoEmpresa.My.Resources.Resources.Button
        Me.CMB_Actualizar.Location = New System.Drawing.Point(256, 613)
        Me.CMB_Actualizar.Name = "CMB_Actualizar"
        Me.CMB_Actualizar.Size = New System.Drawing.Size(112, 25)
        Me.CMB_Actualizar.TabIndex = 3
        Me.CMB_Actualizar.Text = "Actualizar"
        Me.CMB_Actualizar.UseVisualStyleBackColor = False
        '
        'CMB_Imprimir
        '
        Me.CMB_Imprimir.BackColor = System.Drawing.SystemColors.Control
        Me.CMB_Imprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CMB_Imprimir.FlatAppearance.BorderColor = System.Drawing.Color.DimGray
        Me.CMB_Imprimir.FlatAppearance.BorderSize = 0
        Me.CMB_Imprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.CMB_Imprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.CMB_Imprimir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CMB_Imprimir.Image = CType(resources.GetObject("CMB_Imprimir.Image"), System.Drawing.Image)
        Me.CMB_Imprimir.Location = New System.Drawing.Point(414, 568)
        Me.CMB_Imprimir.Name = "CMB_Imprimir"
        Me.CMB_Imprimir.Size = New System.Drawing.Size(70, 70)
        Me.CMB_Imprimir.TabIndex = 4
        Me.CMB_Imprimir.UseVisualStyleBackColor = False
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
        Me.CMB_Cancelar.Image = Global.ProyectoEmpresa.My.Resources.Resources.Button
        Me.CMB_Cancelar.Location = New System.Drawing.Point(1064, 568)
        Me.CMB_Cancelar.Name = "CMB_Cancelar"
        Me.CMB_Cancelar.Size = New System.Drawing.Size(112, 25)
        Me.CMB_Cancelar.TabIndex = 5
        Me.CMB_Cancelar.Text = "Salir"
        Me.CMB_Cancelar.UseVisualStyleBackColor = False
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'MatriculaDataGridViewTextBoxColumn
        '
        Me.MatriculaDataGridViewTextBoxColumn.DataPropertyName = "Matricula"
        Me.MatriculaDataGridViewTextBoxColumn.HeaderText = "Matricula"
        Me.MatriculaDataGridViewTextBoxColumn.Name = "MatriculaDataGridViewTextBoxColumn"
        Me.MatriculaDataGridViewTextBoxColumn.Width = 80
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.Width = 225
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "Direccion"
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        Me.DireccionDataGridViewTextBoxColumn.Width = 225
        '
        'EdadDataGridViewTextBoxColumn
        '
        Me.EdadDataGridViewTextBoxColumn.DataPropertyName = "Edad"
        Me.EdadDataGridViewTextBoxColumn.HeaderText = "Edad"
        Me.EdadDataGridViewTextBoxColumn.Name = "EdadDataGridViewTextBoxColumn"
        Me.EdadDataGridViewTextBoxColumn.Width = 50
        '
        'DNIDataGridViewTextBoxColumn
        '
        Me.DNIDataGridViewTextBoxColumn.DataPropertyName = "DNI"
        Me.DNIDataGridViewTextBoxColumn.HeaderText = "DNI"
        Me.DNIDataGridViewTextBoxColumn.Name = "DNIDataGridViewTextBoxColumn"
        '
        'CUITDataGridViewTextBoxColumn
        '
        Me.CUITDataGridViewTextBoxColumn.DataPropertyName = "CUIT"
        Me.CUITDataGridViewTextBoxColumn.HeaderText = "CUIT"
        Me.CUITDataGridViewTextBoxColumn.Name = "CUITDataGridViewTextBoxColumn"
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "Telefono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        '
        'MailDataGridViewTextBoxColumn
        '
        Me.MailDataGridViewTextBoxColumn.DataPropertyName = "Mail"
        Me.MailDataGridViewTextBoxColumn.HeaderText = "Mail"
        Me.MailDataGridViewTextBoxColumn.Name = "MailDataGridViewTextBoxColumn"
        Me.MailDataGridViewTextBoxColumn.Width = 250
        '
        'PersonalBindingSource
        '
        Me.PersonalBindingSource.DataMember = "Personal"
        Me.PersonalBindingSource.DataSource = Me.BBDDmaestraDataSet
        '
        'BBDDmaestraDataSet
        '
        Me.BBDDmaestraDataSet.DataSetName = "BBDDmaestraDataSet"
        Me.BBDDmaestraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PersonalTableAdapter
        '
        Me.PersonalTableAdapter.ClearBeforeFill = True
        '
        'Frm_Listado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 661)
        Me.Controls.Add(Me.CMB_Cancelar)
        Me.Controls.Add(Me.CMB_Imprimir)
        Me.Controls.Add(Me.CMB_Actualizar)
        Me.Controls.Add(Me.CMB_Buscar)
        Me.Controls.Add(Me.Text_Matricula)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Frm_Listado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Listado"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BBDDmaestraDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CMB_Buscar As Button
    Friend WithEvents Text_Matricula As TextBox
    Friend WithEvents CMB_Actualizar As Button
    Friend WithEvents CMB_Imprimir As Button
    Friend WithEvents CMB_Cancelar As Button
    Friend WithEvents BBDDmaestraDataSet As BBDDmaestraDataSet
    Friend WithEvents PersonalBindingSource As BindingSource
    Friend WithEvents PersonalTableAdapter As BBDDmaestraDataSetTableAdapters.PersonalTableAdapter
    Friend WithEvents MatriculaDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EdadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DNIDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CUITDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
End Class
