Public Class Frm_Login
    Private Sub CMB_Ingresar_Click(sender As Object, e As EventArgs) Handles CMB_Ingresar.Click
        If Text_Usuario.Text = "mmendi" And Text_Contraseña.Text = "3167" Then
            Principal.Show()
            Me.Hide()
        Else
            MsgBox("Usuario y/o Contraseña incorrecto.", MsgBoxStyle.OkOnly, "Inválido!")
        End If
    End Sub

    Private Sub CMB_Salir_Click(sender As Object, e As EventArgs) Handles CMB_Salir.Click
        End
    End Sub

    Private Sub Text_Usuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Text_Usuario.KeyPress
        'este método se ejecuta cada vez que el usuario presiona tecla enter, pasando al textbox siguiente
        If Asc(e.KeyChar) = 13 Then
            Text_Contraseña.Focus()
        End If
    End Sub

    Private Sub Text_Contraseña_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Text_Contraseña.KeyPress
        'este método se ejecuta cada vez que el usuario presiona tecla enter, pasando al textbox siguiente
        If Asc(e.KeyChar) = 13 Then
            CMB_Ingresar.PerformClick()
        End If
    End Sub

    Private Sub Lab_Inicial_Click(sender As Object, e As EventArgs) Handles Lab_Inicial.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class