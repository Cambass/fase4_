Imports Fase4_CamiloFerro.assets

Public Class CiclosProgramación
    Dim lBrowser As New WebBrowser()

    Private Sub BtVid_Click_1(sender As Object, e As EventArgs) Handles BtVid.Click
        CpTx.Enabled = False
        CpTx.Visible = False
        lBrowser.Navigate("https://www.youtube.com/watch?v=LKuZEcSmvAU")
    End Sub

    Private Sub BtInf_Click_1(sender As Object, e As EventArgs) Handles BtInf.Click
        CpTx.Enabled = True
        CpTx.Visible = True
        CpTx.Text = System.IO.File.ReadAllText("..\..\..\assets\ciclosprog.txt")
    End Sub

    Private Sub CiclosProgramación_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CpTx.Enabled = False
        CpTx.Visible = False
        Me.Controls.Add(lBrowser)
        lBrowser.Size = New Size(600, 300)
        lBrowser.Left = 50
        lBrowser.Top = 50
    End Sub
End Class