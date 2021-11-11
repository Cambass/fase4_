<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtIng = New System.Windows.Forms.Button()
        Me.BtReg = New System.Windows.Forms.Button()
        Me.txtUsr = New System.Windows.Forms.TextBox()
        Me.txtPss = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtIng
        '
        Me.BtIng.Location = New System.Drawing.Point(154, 237)
        Me.BtIng.Name = "BtIng"
        Me.BtIng.Size = New System.Drawing.Size(93, 31)
        Me.BtIng.TabIndex = 0
        Me.BtIng.Text = "Ingresar"
        Me.BtIng.UseVisualStyleBackColor = True
        '
        'BtReg
        '
        Me.BtReg.Location = New System.Drawing.Point(154, 352)
        Me.BtReg.Name = "BtReg"
        Me.BtReg.Size = New System.Drawing.Size(103, 32)
        Me.BtReg.TabIndex = 1
        Me.BtReg.Text = "Registrar"
        Me.BtReg.UseVisualStyleBackColor = True
        '
        'txtUsr
        '
        Me.txtUsr.Location = New System.Drawing.Point(144, 150)
        Me.txtUsr.Name = "txtUsr"
        Me.txtUsr.Size = New System.Drawing.Size(128, 26)
        Me.txtUsr.TabIndex = 2
        '
        'txtPss
        '
        Me.txtPss.Location = New System.Drawing.Point(144, 193)
        Me.txtPss.Name = "txtPss"
        Me.txtPss.Size = New System.Drawing.Size(128, 26)
        Me.txtPss.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(89, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(259, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Bienvenido al Sistema Educativo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(345, 38)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Si tiene usuario y contraseña, ingrese inmediatamente. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "De lo contrario Registre" &
    "se en la parte inferior"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(158, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Ingresar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(79, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 19)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Usuario:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(61, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Contraseña:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(159, 314)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(88, 20)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Registrarse"
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 418)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtPss)
        Me.Controls.Add(Me.txtUsr)
        Me.Controls.Add(Me.BtReg)
        Me.Controls.Add(Me.BtIng)
        Me.Name = "Inicio"
        Me.Text = "Inicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtIng As Button
    Friend WithEvents BtReg As Button
    Friend WithEvents txtUsr As TextBox
    Friend WithEvents txtPss As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
End Class
