Imports System.Data.OleDb 'permite el manejo de BBDD access
Public Class Frm_Eliminar

    Private Sub Frm_Eliminar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Interface_Entrada()
        'se ejecuta cuando se carga el formulario

        'habilitados
        Lab_Matricula.Enabled = True
        Text_Matricula.Enabled = True
        CMB_Buscar.Enabled = True

        'deshabilitados
        Lab_Nombre.Enabled = False
        Text_Nombre.Enabled = False
        Lab_Direccion.Enabled = False
        Text_Direccion.Enabled = False
        Lab_Edad.Enabled = False
        Text_Edad.Enabled = False
        Lab_DNI.Enabled = False
        Text_DNI.Enabled = False
        Lab_CUIT.Enabled = False
        Text_CUIT.Enabled = False
        Lab_Telefono.Enabled = False
        Text_Telefono.Enabled = False
        Lab_Mail.Enabled = False
        Text_Mail.Enabled = False

    End Sub

    Private Sub Interface_Datos()
        'se ejecuta cuando se ingresan nuevos datos

        'deshabilitados
        Lab_Matricula.Enabled = False
        Text_Matricula.Enabled = False
        CMB_Buscar.Enabled = False

        'habilitados
        Lab_Nombre.Enabled = True
        Text_Nombre.Enabled = True
        Lab_Direccion.Enabled = True
        Text_Direccion.Enabled = True
        Lab_Edad.Enabled = True
        Text_Edad.Enabled = True
        Lab_DNI.Enabled = True
        Text_DNI.Enabled = True
        Lab_CUIT.Enabled = True
        Text_CUIT.Enabled = True
        Lab_Telefono.Enabled = True
        Text_Telefono.Enabled = True
        Lab_Mail.Enabled = True
        Text_Mail.Enabled = True

    End Sub

    Function Buscar_Registro(ByVal xMatricula As String) As Boolean
        'convertir cadena en númerico
        Dim Matricula As Double
        Matricula = Convert.ToInt32(xMatricula)

        'conexión
        Dim Conexion As New OleDbConnection
        Conexion.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BBDDmaestra.accdb;Persist Security Info=False")

        'cadena SQL
        Dim CadenaSql As String
        CadenaSql = "SELECT * FROM personal WHERE matricula = " & Matricula

        'adaptador
        Dim Adaptador As New OleDbDataAdapter(CadenaSql, Conexion)

        'data set
        Dim Dset As New DataSet

        'llenar el data set
        Conexion.Open() 'abre conexión
        Adaptador.Fill(Dset) 'adaptador llena con datos al data set
        Conexion.Close()

        'contar registro
        If (Dset.Tables(0).Rows.Count = 0) Then
            'no encontró el registro
            Return False
        Else
            'si encontró el registro, carga los texbox del form con info del reg encontrado
            Text_Nombre.Text = Dset.Tables(0).Rows(0)("Nombre").ToString()
            Text_Direccion.Text = Dset.Tables(0).Rows(0)("Direccion").ToString()
            Text_Edad.Text = Dset.Tables(0).Rows(0)("Edad").ToString()
            Text_DNI.Text = Dset.Tables(0).Rows(0)("DNI").ToString()
            Text_CUIT.Text = Dset.Tables(0).Rows(0)("cuit").ToString()
            Text_Telefono.Text = Dset.Tables(0).Rows(0)("Telefono").ToString()
            Text_Mail.Text = Dset.Tables(0).Rows(0)("Mail").ToString()
            Dset.Dispose()
            Return True
        End If
    End Function

    Function Eliminar_Registro(ByVal Matricula As String) As Boolean
        'convertir
        Dim Cod As Integer = Convert.ToInt32(Matricula)

        'conexión
        Dim Conexion As New OleDbConnection
        Conexion.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BBDDmaestra.accdb;Persist Security Info=False")

        'instrucción SQL
        Dim CadenaSQL As String = "DELETE FROM personal WHERE matricula =" & Matricula

        'crear un comando
        Dim Comando As OleDbCommand = Conexion.CreateCommand()
        Comando.CommandText = CadenaSQL

        'ejecutar la consulta de acción
        Conexion.Open()
        Comando.ExecuteNonQuery()
        Conexion.Close()
        Return True

    End Function

    Private Sub Limpiar_Formulario()
        'limpia los texbox del formulario
        Text_Nombre.Clear()
        Text_Direccion.Clear()
        Text_Edad.Clear()
        Text_DNI.Clear()
        Text_CUIT.Clear()
        Text_Telefono.Clear()
        Text_Mail.Clear()
    End Sub

    Private Sub CMB_Buscar_Click_1(sender As Object, e As EventArgs) Handles CMB_Buscar.Click
        'buscar el registro que se desea eliminar
        If Buscar_Registro(Text_Matricula.Text) = True Then
            'pregunta si está seguro de eliminar el registro actual
            Dim Respuesta As DialogResult = MessageBox.Show("¿Está seguro que desea eliminar esté registro?", "Pregunta importante", MessageBoxButtons.YesNo)
            'evalúa la respuesta que el usuario ingresa en el messagebox
            If Respuesta = DialogResult.Yes Then
                'eliminar el registro
                Eliminar_Registro(Text_Matricula.Text)
                Limpiar_Formulario()
                Text_Matricula.Focus()
            Else
                'no eliminar el registro
                Limpiar_Formulario()
                Text_Matricula.Focus()
            End If
        Else
            'no existe el registro
            MessageBox.Show("El registro no existe")
            Text_Matricula.Focus()
        End If
    End Sub

    Private Sub CMB_Cancelar_Click_1(sender As Object, e As EventArgs) Handles CMB_Cancelar.Click
        Me.Close()
    End Sub

End Class