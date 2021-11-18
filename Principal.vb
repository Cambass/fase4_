Public Class Principal
    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.IsMdiContainer = True
    End Sub

    Private Sub CiclosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CiclosToolStripMenuItem1.Click
        Dim cP As New CiclosProgramación
        cP.MdiParent = Me
        Me.SplitContainer1.Panel2.Controls.Add(cP)
        cP.Show()
    End Sub

    Private Sub ConsultarEstudianteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarEstudianteToolStripMenuItem.Click
        Dim conf As New Configuracion()
        conf.MdiParent = Me
        Me.SplitContainer1.Panel2.Controls.Add(conf)
        conf.Show()
    End Sub
End Class