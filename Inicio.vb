Imports MySql.Data.MySqlClient

Public Class Inicio

    Private Sub BtIng_Click(sender As Object, e As EventArgs) Handles BtIng.Click
        If (login(txtUsr.Text, txtPss.Text)) Then
            Dim principal As New Principal
            principal.Show()
            Me.Hide()
        End If

    End Sub

    Function login(ByVal usuario As String, ByVal contraseña As String)
        Dim Conexion As New MySqlConnection
        Dim DataAdapter As New MySqlDataAdapter
        Dim DataSet As New DataSet
        Dim Sql As String
        Dim sw As Boolean = False

        Try
            Conexion.ConnectionString = "Server=localhost;Database=fase4;Uid=root;password=;"
            Sql = "select * from usuario where Usuario='" & usuario & "' and Contraseña='" & contraseña & "'"
            Conexion.Open()
            DataAdapter = New MySqlDataAdapter(Sql, Conexion)
            DataSet.Clear()
            DataAdapter.Fill(DataSet, "usuario")

            If (DataSet.Tables("usuario").Rows.Count() <> 0) Then
                MessageBox.Show("Bienvenido al Sistema", "Sistema")
                sw = True
            Else
                MessageBox.Show("Datos no Validos", "Sistema")
                sw = False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return (sw)
    End Function

    Private Sub BtReg_Click(sender As Object, e As EventArgs) Handles BtReg.Click
        Dim registro As New Registro
        registro.Show()
        Me.Hide()
    End Sub
End Class
