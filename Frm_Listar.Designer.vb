<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Listar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Listar))
        Me.PersonalBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.PersonalBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PersonalDataGridView = New System.Windows.Forms.DataGridView()
        Me.CMB_Cancelar = New System.Windows.Forms.Button()
        Me.CMB_Imprimir = New System.Windows.Forms.Button()
        Me.CMB_Actualizar = New System.Windows.Forms.Button()
        Me.Text_Buscar = New System.Windows.Forms.TextBox()
        Me.CMB_Buscar = New System.Windows.Forms.Button()
        Me.PersonalBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BBDDmaestraDataSet = New ProyectoEmpresa.BBDDmaestraDataSet()
        Me.PersonalTableAdapter = New ProyectoEmpresa.BBDDmaestraDataSetTableAdapters.PersonalTableAdapter()
        Me.TableAdapterManager = New ProyectoEmpresa.BBDDmaestraDataSetTableAdapters.TableAdapterManager()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.PersonalBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PersonalBindingNavigator.SuspendLayout()
        CType(Me.PersonalDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PersonalBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BBDDmaestraDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PersonalBindingNavigator
        '
        Me.PersonalBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PersonalBindingNavigator.BindingSource = Me.PersonalBindingSource
        Me.PersonalBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PersonalBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PersonalBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PersonalBindingNavigatorSaveItem})
        Me.PersonalBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PersonalBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PersonalBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PersonalBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PersonalBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PersonalBindingNavigator.Name = "PersonalBindingNavigator"
        Me.PersonalBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PersonalBindingNavigator.Size = New System.Drawing.Size(1243, 25)
        Me.PersonalBindingNavigator.TabIndex = 0
        Me.PersonalBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'PersonalBindingNavigatorSaveItem
        '
        Me.PersonalBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PersonalBindingNavigatorSaveItem.Image = CType(resources.GetObject("PersonalBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PersonalBindingNavigatorSaveItem.Name = "PersonalBindingNavigatorSaveItem"
        Me.PersonalBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PersonalBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'PersonalDataGridView
        '
        Me.PersonalDataGridView.AutoGenerateColumns = False
        Me.PersonalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PersonalDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.PersonalDataGridView.DataSource = Me.PersonalBindingSource
        Me.PersonalDataGridView.Location = New System.Drawing.Point(12, 41)
        Me.PersonalDataGridView.Name = "PersonalDataGridView"
        Me.PersonalDataGridView.Size = New System.Drawing.Size(1219, 452)
        Me.PersonalDataGridView.TabIndex = 1
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
        Me.CMB_Cancelar.Location = New System.Drawing.Point(1119, 515)
        Me.CMB_Cancelar.Name = "CMB_Cancelar"
        Me.CMB_Cancelar.Size = New System.Drawing.Size(112, 25)
        Me.CMB_Cancelar.TabIndex = 6
        Me.CMB_Cancelar.Text = "Cancelar"
        Me.CMB_Cancelar.UseVisualStyleBackColor = False
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
        Me.CMB_Imprimir.Image = Global.ProyectoEmpresa.My.Resources.Resources.Button
        Me.CMB_Imprimir.Location = New System.Drawing.Point(859, 515)
        Me.CMB_Imprimir.Name = "CMB_Imprimir"
        Me.CMB_Imprimir.Size = New System.Drawing.Size(112, 25)
        Me.CMB_Imprimir.TabIndex = 5
        Me.CMB_Imprimir.Text = "Imprimir"
        Me.CMB_Imprimir.UseVisualStyleBackColor = False
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
        Me.CMB_Actualizar.Location = New System.Drawing.Point(300, 518)
        Me.CMB_Actualizar.Name = "CMB_Actualizar"
        Me.CMB_Actualizar.Size = New System.Drawing.Size(112, 25)
        Me.CMB_Actualizar.TabIndex = 4
        Me.CMB_Actualizar.Text = "Actualizar"
        Me.CMB_Actualizar.UseVisualStyleBackColor = False
        '
        'Text_Buscar
        '
        Me.Text_Buscar.Location = New System.Drawing.Point(12, 518)
        Me.Text_Buscar.Multiline = True
        Me.Text_Buscar.Name = "Text_Buscar"
        Me.Text_Buscar.Size = New System.Drawing.Size(112, 25)
        Me.Text_Buscar.TabIndex = 2
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
        Me.CMB_Buscar.Location = New System.Drawing.Point(12, 549)
        Me.CMB_Buscar.Name = "CMB_Buscar"
        Me.CMB_Buscar.Size = New System.Drawing.Size(112, 25)
        Me.CMB_Buscar.TabIndex = 3
        Me.CMB_Buscar.Text = "Buscar"
        Me.CMB_Buscar.UseVisualStyleBackColor = False
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.PersonalTableAdapter = Me.PersonalTableAdapter
        Me.TableAdapterManager.UpdateOrder = ProyectoEmpresa.BBDDmaestraDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Matricula"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Matricula"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 80
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 230
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Direccion"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Direccion"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 250
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Edad"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Edad"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 40
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "DNI"
        Me.DataGridViewTextBoxColumn5.HeaderText = "DNI"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "CUIT"
        Me.DataGridViewTextBoxColumn6.HeaderText = "CUIT"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Telefono"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Telefono"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Mail"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Mail"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 250
        '
        'Frm_Listar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1243, 599)
        Me.Controls.Add(Me.CMB_Cancelar)
        Me.Controls.Add(Me.CMB_Imprimir)
        Me.Controls.Add(Me.CMB_Actualizar)
        Me.Controls.Add(Me.Text_Buscar)
        Me.Controls.Add(Me.CMB_Buscar)
        Me.Controls.Add(Me.PersonalDataGridView)
        Me.Controls.Add(Me.PersonalBindingNavigator)
        Me.Name = "Frm_Listar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_Listar"
        CType(Me.PersonalBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PersonalBindingNavigator.ResumeLayout(False)
        Me.PersonalBindingNavigator.PerformLayout()
        CType(Me.PersonalDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PersonalBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BBDDmaestraDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BBDDmaestraDataSet As BBDDmaestraDataSet
    Friend WithEvents PersonalBindingSource As BindingSource
    Friend WithEvents PersonalTableAdapter As BBDDmaestraDataSetTableAdapters.PersonalTableAdapter
    Friend WithEvents TableAdapterManager As BBDDmaestraDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PersonalBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents PersonalBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents PersonalDataGridView As DataGridView
    Friend WithEvents CMB_Cancelar As Button
    Friend WithEvents CMB_Imprimir As Button
    Friend WithEvents CMB_Actualizar As Button
    Friend WithEvents Text_Buscar As TextBox
    Friend WithEvents CMB_Buscar As Button
    Friend WithEvents PrintForm1 As PowerPacks.Printing.PrintForm
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
End Class
