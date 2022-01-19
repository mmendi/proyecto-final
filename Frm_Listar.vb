Public Class Frm_Listar
    Private Sub PersonalBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PersonalBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PersonalBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BBDDmaestraDataSet)

    End Sub

    Private Sub Frm_Listar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'BBDDmaestraDataSet.Personal' Puede moverla o quitarla según sea necesario.
        Me.PersonalTableAdapter.Fill(Me.BBDDmaestraDataSet.Personal)

    End Sub

    Private Sub CMB_Buscar_Click(sender As Object, e As EventArgs) Handles CMB_Buscar.Click
        Me.PersonalTableAdapter.FillBy((Me.BBDDmaestraDataSet.Personal), Text_Buscar.Text)
    End Sub

    Private Sub CMB_Actualizar_Click(sender As Object, e As EventArgs) Handles CMB_Actualizar.Click
        Me.PersonalTableAdapter.Fill(Me.BBDDmaestraDataSet.Personal)
    End Sub

    Private Sub CMB_Imprimir_Click(sender As Object, e As EventArgs) Handles CMB_Imprimir.Click
        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub CMB_Cancelar_Click(sender As Object, e As EventArgs) Handles CMB_Cancelar.Click
        Me.Close()
    End Sub
End Class