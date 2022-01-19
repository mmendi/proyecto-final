<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PersonalEmpresaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AgregarNuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListarRegistroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirDelSistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FInalizarProgramaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PersonalEmpresaToolStripMenuItem, Me.ListarRegistroToolStripMenuItem, Me.SalirDelSistemaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1256, 27)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PersonalEmpresaToolStripMenuItem
        '
        Me.PersonalEmpresaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarNuevoToolStripMenuItem, Me.ModificaciónToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.PersonalEmpresaToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.PersonalEmpresaToolStripMenuItem.Name = "PersonalEmpresaToolStripMenuItem"
        Me.PersonalEmpresaToolStripMenuItem.Size = New System.Drawing.Size(71, 23)
        Me.PersonalEmpresaToolStripMenuItem.Text = "Clientes"
        '
        'AgregarNuevoToolStripMenuItem
        '
        Me.AgregarNuevoToolStripMenuItem.Name = "AgregarNuevoToolStripMenuItem"
        Me.AgregarNuevoToolStripMenuItem.Size = New System.Drawing.Size(172, 24)
        Me.AgregarNuevoToolStripMenuItem.Text = "Agregar Nuevo"
        '
        'ModificaciónToolStripMenuItem
        '
        Me.ModificaciónToolStripMenuItem.Name = "ModificaciónToolStripMenuItem"
        Me.ModificaciónToolStripMenuItem.Size = New System.Drawing.Size(172, 24)
        Me.ModificaciónToolStripMenuItem.Text = "Modificar"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(172, 24)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'ListarRegistroToolStripMenuItem
        '
        Me.ListarRegistroToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.ListarRegistroToolStripMenuItem.Name = "ListarRegistroToolStripMenuItem"
        Me.ListarRegistroToolStripMenuItem.Size = New System.Drawing.Size(139, 23)
        Me.ListarRegistroToolStripMenuItem.Text = "Listado de Clientes"
        '
        'SalirDelSistemaToolStripMenuItem
        '
        Me.SalirDelSistemaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FInalizarProgramaToolStripMenuItem})
        Me.SalirDelSistemaToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Bold)
        Me.SalirDelSistemaToolStripMenuItem.Name = "SalirDelSistemaToolStripMenuItem"
        Me.SalirDelSistemaToolStripMenuItem.Size = New System.Drawing.Size(125, 23)
        Me.SalirDelSistemaToolStripMenuItem.Text = "Salir del Sistema"
        '
        'FInalizarProgramaToolStripMenuItem
        '
        Me.FInalizarProgramaToolStripMenuItem.Name = "FInalizarProgramaToolStripMenuItem"
        Me.FInalizarProgramaToolStripMenuItem.Size = New System.Drawing.Size(195, 24)
        Me.FInalizarProgramaToolStripMenuItem.Text = "Finalizar Programa"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1256, 301)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema de Clientes"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PersonalEmpresaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarNuevoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ModificaciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListarRegistroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirDelSistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FInalizarProgramaToolStripMenuItem As ToolStripMenuItem
End Class
