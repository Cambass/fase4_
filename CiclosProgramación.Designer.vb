<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CiclosProgramación
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtInf = New System.Windows.Forms.Button()
        Me.BtVid = New System.Windows.Forms.Button()
        Me.CpTx = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(303, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ciclos de Programación"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtInf
        '
        Me.BtInf.Location = New System.Drawing.Point(431, 450)
        Me.BtInf.Name = "BtInf"
        Me.BtInf.Size = New System.Drawing.Size(93, 32)
        Me.BtInf.TabIndex = 1
        Me.BtInf.Text = "Información"
        Me.BtInf.UseVisualStyleBackColor = True
        '
        'BtVid
        '
        Me.BtVid.Location = New System.Drawing.Point(638, 450)
        Me.BtVid.Name = "BtVid"
        Me.BtVid.Size = New System.Drawing.Size(81, 32)
        Me.BtVid.TabIndex = 2
        Me.BtVid.Text = "Video"
        Me.BtVid.UseVisualStyleBackColor = True
        '
        'CpTx
        '
        Me.CpTx.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CpTx.Enabled = False
        Me.CpTx.Location = New System.Drawing.Point(676, 42)
        Me.CpTx.Name = "CpTx"
        Me.CpTx.Size = New System.Drawing.Size(626, 402)
        Me.CpTx.TabIndex = 3
        Me.CpTx.Text = ""
        Me.CpTx.Visible = False
        '
        'CiclosProgramación
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1338, 496)
        Me.Controls.Add(Me.CpTx)
        Me.Controls.Add(Me.BtVid)
        Me.Controls.Add(Me.BtInf)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CiclosProgramación"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CiclosProgramación"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents BtInf As Button
    Friend WithEvents BtVid As Button
    Friend WithEvents CpTx As RichTextBox
End Class
