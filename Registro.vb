Imports MySql.Data.MySqlClient

Public Class Registro
    Private Sub BtnReg_Click(sender As Object, e As EventArgs) Handles BtnReg.Click
        If (registrar(TxNom.Text, TxProg.Text, TxSem.Text, TxUsr.Text, TxPss.Text)) Then
            Dim inicio As New Inicio
            inicio.Show()
            Me.Close()
        End If
    End Sub

    Private Sub BtnOut_Click(sender As Object, e As EventArgs) Handles BtnOut.Click
        TxNom.Text = ""
        TxProg.Text = ""
        TxPss.Text = ""
        TxSem.Text = ""
        TxUsr.Text = ""
        Dim inicio As New Inicio
        inicio.Show()
        Me.Close()
    End Sub

    Function registrar(ByVal nombre As String, ByVal progr As String, ByVal Sem As String, ByVal Usu As String, ByVal Pss As String)
        Dim Conexion As New MySqlConnection
        Dim Command As New MySqlCommand
        Dim Sql As String
        Dim sw As Boolean = False

        Try
            Conexion.ConnectionString = "Server=localhost;Database=fase4;Uid=root;password=;"
            Sql = "INSERT INTO usuario(Nombre, Programa, Semestre, Usuario, Contraseña) VALUES ('" & nombre & "','" & progr & "','" & Sem & "','" & Usu & "','" & Pss & "')"
            Conexion.Open()
            Command = New MySqlCommand(Sql, Conexion)
            Command.ExecuteNonQuery()

            If (Command.ExecuteNonQuery() <> 0) Then
                MessageBox.Show("Registro Exitoso", "Sistema")
                sw = True
                Conexion.Close()
            Else
                MessageBox.Show("Datos no Validos", "Sistema")
                sw = False
                Conexion.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Conexion.Close()
        End Try
        Return (sw)
    End Function
End Class