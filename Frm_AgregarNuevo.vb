Imports System.Data.OleDb 'permite el manejo de BBDD access
Public Class Frm_AgregarNuevo

    Private Sub Frm_AgregarNuevo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Interface_Entrada()
        Text_Matricula.Select()
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
        CMB_Guardar.Enabled = False
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
        CMB_Guardar.Enabled = True
    End Sub

    Private Sub CMB_Buscar_Click(sender As Object, e As EventArgs) Handles CMB_Buscar.Click
        If Buscar_Registro(Text_Matricula.Text) = True Then
            'mostrar mensaje que el registro existe
            MessageBox.Show("El registro ya existe")
            Text_Matricula.Focus()
        Else
            Interface_Datos()
            Text_Nombre.Focus()
        End If
    End Sub

    Function Buscar_Registro(ByVal xMatricula As String) As Boolean
        'convertir cadena en numérico
        Dim Matricula As Double
        Matricula = Convert.ToInt32(xMatricula)

        'conexión
        Dim Conexion As New OleDbConnection
        Conexion.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BBDDmaestra.accdb;Persist Security Info=False")

        'cadena SQL
        Dim CadenaSql As String = "SELECT * FROM personal WHERE matricula = " & Matricula

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
            Text_Nombre.Text = Dset.Tables(0).Rows(0)("nombre").ToString()
            Text_Direccion.Text = Dset.Tables(0).Rows(0)("direccion").ToString()
            Text_Edad.Text = Dset.Tables(0).Rows(0)("edad").ToString()
            Text_DNI.Text = Dset.Tables(0).Rows(0)("dni").ToString()
            Text_CUIT.Text = Dset.Tables(0).Rows(0)("cuit").ToString()
            Text_Telefono.Text = Dset.Tables(0).Rows(0)("telefono").ToString()
            Text_Mail.Text = Dset.Tables(0).Rows(0)("mail").ToString()
            Dset.Dispose()
            Return True
        End If
    End Function

    Function Agregar_Registro(ByVal Matricula As String, ByVal Nombre As String, ByVal Direccion As String, ByVal Edad As String, ByVal DNI As String, ByVal CUIT As String, ByVal Telefono As String, ByVal Mail As String) As Boolean
        'convertir
        Dim Cod As Integer = Convert.ToInt32(Matricula)
        Dim Eda As Integer = Convert.ToInt32(Edad)
        Dim Doc As Integer = Convert.ToInt32(DNI)
        Dim Tel As Integer = Convert.ToInt64(Telefono)

        'conexión
        Dim Conexion As New OleDbConnection
        Conexion.ConnectionString = ("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BBDDmaestra.accdb;Persist Security Info=False")

        'instrucción SQL
        Dim CadenaSQL As String = "INSERT INTO personal (matricula, nombre, direccion, edad, dni, cuit, telefono, mail) "
        CadenaSQL = CadenaSQL + "  VALUES ( " & Cod & ","
        CadenaSQL = CadenaSQL + "          '" & Nombre & "',"
        CadenaSQL = CadenaSQL + "          '" & Direccion & "',"
        CadenaSQL = CadenaSQL + "          '" & Eda & "',"
        CadenaSQL = CadenaSQL + "          '" & Doc & "',"
        CadenaSQL = CadenaSQL + "          '" & CUIT & "',"
        CadenaSQL = CadenaSQL + "          '" & Tel & "',"
        CadenaSQL = CadenaSQL + "          '" & Mail & "')"

        'crear un comando
        Dim Comando As OleDbCommand = Conexion.CreateCommand()
        Comando.CommandText = CadenaSQL

        'ejecutar la consulta de acción
        Conexion.Open()
        Comando.ExecuteNonQuery()
        Conexion.Close()
        Return True
    End Function

    Private Sub CMB_Guardar_Click(sender As Object, e As EventArgs) Handles CMB_Guardar.Click
        Agregar_Registro(Text_Matricula.Text, Text_Nombre.Text, Text_Direccion.Text, Text_Edad.Text, Text_DNI.Text, Text_CUIT.Text, Text_Telefono.Text, Text_Mail.Text) 'guarda los datos en la BBDD
        Interface_Entrada() 'prepara el formulario para ingresar un nuevo registro
        Text_Matricula.Focus() 'envía el foco al text_matrícula
        Limpiar_Formulario() 'limpia el formulario
    End Sub

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

    Private Sub CMB_Cancelar_Click(sender As Object, e As EventArgs) Handles CMB_Cancelar.Click
        Me.Close()
    End Sub

    Private Sub Text_Nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Text_Nombre.KeyPress
        'este método se ejecuta cada vez que el usuario presiona tecla enter, pasando al textbox siguiente
        If Asc(e.KeyChar) = 13 Then
            Text_Direccion.Focus()
        End If
    End Sub

    Private Sub Text_Direccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Text_Direccion.KeyPress
        'este método se ejecuta cada vez que el usuario presiona tecla enter, pasando al textbox siguiente
        If Asc(e.KeyChar) = 13 Then
            Text_Edad.Focus()
        End If
    End Sub

    Private Sub Text_Edad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Text_Edad.KeyPress
        'este método se ejecuta cada vez que el usuario presiona tecla enter, pasando al textbox siguiente
        If Asc(e.KeyChar) = 13 Then
            Text_DNI.Focus()
        End If
    End Sub

    Private Sub Text_DNI_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Text_DNI.KeyPress
        'este método se ejecuta cada vez que el usuario presiona tecla enter, pasando al textbox siguiente
        If Asc(e.KeyChar) = 13 Then
            Text_CUIT.Focus()
        End If
    End Sub

    Private Sub Text_CUIT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Text_CUIT.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Text_Telefono.Focus()
        End If
    End Sub

    Private Sub Text_Telefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Text_Telefono.KeyPress
        'este método se ejecuta cada vez que el usuario presiona tecla enter, pasando al textbox siguiente
        If Asc(e.KeyChar) = 13 Then
            Text_Mail.Focus()
        End If
    End Sub

    Private Sub Text_Mail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Text_Mail.KeyPress
        'este método se ejecuta cada vez que el usuario presiona tecla enter, pasando al textbox siguiente
        If Asc(e.KeyChar) = 13 Then
            CMB_Guardar.PerformClick()
        End If
    End Sub

End Class