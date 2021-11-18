<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Configuracion
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
        Me.DtReg = New System.Windows.Forms.DataGridView()
        Me.BtCons = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnDel = New System.Windows.Forms.Button()
        Me.BtnUpd = New System.Windows.Forms.Button()
        CType(Me.DtReg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DtReg
        '
        Me.DtReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DtReg.Location = New System.Drawing.Point(33, 88)
        Me.DtReg.Name = "DtReg"
        Me.DtReg.RowTemplate.Height = 28
        Me.DtReg.Size = New System.Drawing.Size(736, 272)
        Me.DtReg.TabIndex = 0
        '
        'BtCons
        '
        Me.BtCons.Location = New System.Drawing.Point(145, 389)
        Me.BtCons.Name = "BtCons"
        Me.BtCons.Size = New System.Drawing.Size(94, 33)
        Me.BtCons.TabIndex = 1
        Me.BtCons.Text = "Consultar"
        Me.BtCons.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(255, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(359, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Consulta, Modificación y Eliminación de Registros "
        '
        'BtnDel
        '
        Me.BtnDel.Location = New System.Drawing.Point(330, 389)
        Me.BtnDel.Name = "BtnDel"
        Me.BtnDel.Size = New System.Drawing.Size(100, 33)
        Me.BtnDel.TabIndex = 3
        Me.BtnDel.Text = "Eliminar"
        Me.BtnDel.UseVisualStyleBackColor = True
        '
        'BtnUpd
        '
        Me.BtnUpd.Location = New System.Drawing.Point(526, 389)
        Me.BtnUpd.Name = "BtnUpd"
        Me.BtnUpd.Size = New System.Drawing.Size(88, 33)
        Me.BtnUpd.TabIndex = 4
        Me.BtnUpd.Text = "Modificar"
        Me.BtnUpd.UseVisualStyleBackColor = True
        '
        'Configuracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnUpd)
        Me.Controls.Add(Me.BtnDel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtCons)
        Me.Controls.Add(Me.DtReg)
        Me.Name = "Configuracion"
        Me.Text = "Configuracion"
        CType(Me.DtReg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DtReg As DataGridView
    Friend WithEvents BtCons As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnDel As Button
    Friend WithEvents BtnUpd As Button
End Class
