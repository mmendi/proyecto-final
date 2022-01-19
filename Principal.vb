Public Class Principal
    Private Sub AgregarNuevoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarNuevoToolStripMenuItem.Click
        'agregar nuevo
        Dim FAN As New Frm_AgregarNuevo
        FAN.Show()
    End Sub

    Private Sub ModificaciónToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModificaciónToolStripMenuItem.Click
        'modificar
        Dim FMR As New Frm_Modificar
        FMR.Show()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        'eliminar
        Dim FER As New Frm_Eliminar
        FER.Show()
    End Sub

    Private Sub ListarRegistroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListarRegistroToolStripMenuItem.Click
        'listar 
        Dim FLR As New Frm_Listado
        FLR.Show()
    End Sub

    Private Sub FInalizarProgramaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FInalizarProgramaToolStripMenuItem.Click
        'salir del sistema
        Dim FSS As New Frm_Finalizar
        FSS.Show()
    End Sub
End Class