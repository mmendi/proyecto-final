Public Class Frm_Finalizar
    Private Sub CMB_Si_Click(sender As Object, e As EventArgs) Handles CMB_Si.Click
        Me.Close()
        Principal.Close()
    End Sub

    Private Sub CMB_No_Click(sender As Object, e As EventArgs) Handles CMB_No.Click
        Me.Close()
        Principal.Show()
    End Sub

End Class