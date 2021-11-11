<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TxNom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxProg = New System.Windows.Forms.TextBox()
        Me.TxSem = New System.Windows.Forms.TextBox()
        Me.TxUsr = New System.Windows.Forms.TextBox()
        Me.TxPss = New System.Windows.Forms.TextBox()
        Me.BtnOut = New System.Windows.Forms.Button()
        Me.BtnReg = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TxNom
        '
        Me.TxNom.Location = New System.Drawing.Point(137, 114)
        Me.TxNom.Name = "TxNom"
        Me.TxNom.Size = New System.Drawing.Size(176, 26)
        Me.TxNom.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(73, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Registrar un Nuevo Estudiante"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(68, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(58, 151)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Programa:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(62, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Semestre:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(73, 217)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "usuario:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(48, 248)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 19)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Contraseña:"
        '
        'TxProg
        '
        Me.TxProg.Location = New System.Drawing.Point(137, 146)
        Me.TxProg.Name = "TxProg"
        Me.TxProg.Size = New System.Drawing.Size(176, 26)
        Me.TxProg.TabIndex = 7
        '
        'TxSem
        '
        Me.TxSem.Location = New System.Drawing.Point(137, 180)
        Me.TxSem.Name = "TxSem"
        Me.TxSem.Size = New System.Drawing.Size(176, 26)
        Me.TxSem.TabIndex = 8
        '
        'TxUsr
        '
        Me.TxUsr.Location = New System.Drawing.Point(136, 212)
        Me.TxUsr.Name = "TxUsr"
        Me.TxUsr.Size = New System.Drawing.Size(177, 26)
        Me.TxUsr.TabIndex = 9
        '
        'TxPss
        '
        Me.TxPss.Location = New System.Drawing.Point(137, 248)
        Me.TxPss.Name = "TxPss"
        Me.TxPss.Size = New System.Drawing.Size(176, 26)
        Me.TxPss.TabIndex = 10
        '
        'BtnOut
        '
        Me.BtnOut.Location = New System.Drawing.Point(85, 322)
        Me.BtnOut.Name = "BtnOut"
        Me.BtnOut.Size = New System.Drawing.Size(75, 34)
        Me.BtnOut.TabIndex = 11
        Me.BtnOut.Text = "Salir"
        Me.BtnOut.UseVisualStyleBackColor = True
        '
        'BtnReg
        '
        Me.BtnReg.Location = New System.Drawing.Point(214, 322)
        Me.BtnReg.Name = "BtnReg"
        Me.BtnReg.Size = New System.Drawing.Size(75, 34)
        Me.BtnReg.TabIndex = 12
        Me.BtnReg.Text = "Registrar"
        Me.BtnReg.UseVisualStyleBackColor = True
        '
        'Registro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 376)
        Me.Controls.Add(Me.BtnReg)
        Me.Controls.Add(Me.BtnOut)
        Me.Controls.Add(Me.TxPss)
        Me.Controls.Add(Me.TxUsr)
        Me.Controls.Add(Me.TxSem)
        Me.Controls.Add(Me.TxProg)
        Me.Controls.Add(Me.TxNom)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Registro"
        Me.Text = "Registro"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxNom As TextBox
    Friend WithEvents TxProg As TextBox
    Friend WithEvents TxSem As TextBox
    Friend WithEvents TxUsr As TextBox
    Friend WithEvents TxPss As TextBox
    Friend WithEvents BtnOut As Button
    Friend WithEvents BtnReg As Button
End Class
