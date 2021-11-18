Imports MySql.Data.MySqlClient

Public Class Configuracion

    Dim Conexion As New MySqlConnection
    Dim DataAdapter As New MySqlDataAdapter
    Dim DataSet As New DataSet
    Dim Cmd As New MySqlCommand
    Dim Sql As String
    Dim sw As Boolean = False

    Private Sub BtCons_Click(sender As Object, e As EventArgs) Handles BtCons.Click
        Try
            Conexion.ConnectionString = "Server=localhost;Database=fase4;Uid=root;password=;"
            Sql = "select * from usuario "
            Conexion.Open()
            DataAdapter = New MySqlDataAdapter(Sql, Conexion)
            DataSet.Clear()
            DataAdapter.Fill(DataSet, "registros")
            DtReg.DataSource = DataSet
            DtReg.DataMember = "registros"
            Conexion.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Conexion.Close()
        End Try

    End Sub

    Private Sub BtnDel_Click(sender As Object, e As EventArgs) Handles BtnDel.Click
        Try
            Conexion.ConnectionString = "Server=localhost;Database=fase4;Uid=root;password=;"
            Sql = "delete from usuario where Id = '" & DtReg.CurrentRow.Cells(0).Value & "'"
            Conexion.Open()
            Cmd = New MySqlCommand(Sql, Conexion)
            Cmd.ExecuteNonQuery()

            Sql = "select * from usuario "
            DataAdapter = New MySqlDataAdapter(Sql, Conexion)
            DataSet.Clear()
            DataAdapter.Fill(DataSet, "registros")
            DtReg.DataSource = DataSet
            DtReg.DataMember = "registros"
            Conexion.Close()
            MsgBox("Dato Eliminado")
        Catch ex As Exception
            Conexion.Close()
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub BtnUpd_Click(sender As Object, e As EventArgs) Handles BtnUpd.Click
        Conexion.ConnectionString = "Server=localhost;Database=fase4;Uid=root;password=;"
        Sql = "UPDATE `usuario` SET Nombre='" & DtReg.CurrentRow.Cells(1).Value & "', Programa ='" & DtReg.CurrentRow.Cells(2).Value & " ', Semestre ='" & DtReg.CurrentRow.Cells(3).Value & "', Usuario='" & DtReg.CurrentRow.Cells(4).Value & "', Contraseña ='" & DtReg.CurrentRow.Cells(5).Value & "' WHERE Id = '" & DtReg.CurrentRow.Cells(0).Value & "'"
        Conexion.Open()
        Cmd = New MySqlCommand(Sql, Conexion)
        Cmd.ExecuteNonQuery()

        Sql = "select * from usuario "
        DataAdapter = New MySqlDataAdapter(Sql, Conexion)
        DataSet.Clear()
        DataAdapter.Fill(DataSet, "registros")
        DtReg.DataSource = DataSet
        DtReg.DataMember = "registros"
        Conexion.Close()
        MsgBox("Dato Modificado")
    End Sub

    Private Sub BtnIns_Click(sender As Object, e As EventArgs) Handles BtnIns.Click
        Conexion.ConnectionString = "Server=localhost;Database=fase4;Uid=root;password=;"
        Sql = "INSERT INTO usuario(Nombre, Programa, Semestre, Usuario, Contraseña) VALUES ('" & DtReg.CurrentRow.Cells(1).Value & "','" & DtReg.CurrentRow.Cells(2).Value & "','" & DtReg.CurrentRow.Cells(3).Value & "','" & DtReg.CurrentRow.Cells(4).Value & "','" & DtReg.CurrentRow.Cells(5).Value & "')"
        Conexion.Open()
        Cmd = New MySqlCommand(Sql, Conexion)
        Cmd.ExecuteNonQuery()

        Sql = "select * from usuario "
        DataAdapter = New MySqlDataAdapter(Sql, Conexion)
        DataSet.Clear()
        DataAdapter.Fill(DataSet, "registros")
        DtReg.DataSource = DataSet
        DtReg.DataMember = "registros"
        Conexion.Close()
        MsgBox("Dato Modificado")
    End Sub
End Class