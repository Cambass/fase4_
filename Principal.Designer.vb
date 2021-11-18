<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Principal
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CursosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeguridadInformaticaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RealidadVirtualToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CondicionalesToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.IAToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CiclosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfiguraciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarEstudianteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditarEstudianteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(214, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(464, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bienvenidos al Modulo de Aprendizaje UNAD 2021"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Cursor = System.Windows.Forms.Cursors.HSplit
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 36)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.MenuStrip1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Size = New System.Drawing.Size(1029, 562)
        Me.SplitContainer1.SplitterDistance = 43
        Me.SplitContainer1.TabIndex = 1
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CursosToolStripMenuItem, Me.ConfiguraciónToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1029, 27)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CursosToolStripMenuItem
        '
        Me.CursosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SeguridadInformaticaToolStripMenuItem, Me.RealidadVirtualToolStripMenuItem1, Me.CondicionalesToolStripMenuItem2, Me.IAToolStripMenuItem1, Me.CiclosToolStripMenuItem1})
        Me.CursosToolStripMenuItem.Name = "CursosToolStripMenuItem"
        Me.CursosToolStripMenuItem.Size = New System.Drawing.Size(63, 23)
        Me.CursosToolStripMenuItem.Text = "Cursos"
        '
        'SeguridadInformaticaToolStripMenuItem
        '
        Me.SeguridadInformaticaToolStripMenuItem.Name = "SeguridadInformaticaToolStripMenuItem"
        Me.SeguridadInformaticaToolStripMenuItem.Size = New System.Drawing.Size(251, 24)
        Me.SeguridadInformaticaToolStripMenuItem.Text = "Seguridad Informatica"
        '
        'RealidadVirtualToolStripMenuItem1
        '
        Me.RealidadVirtualToolStripMenuItem1.Name = "RealidadVirtualToolStripMenuItem1"
        Me.RealidadVirtualToolStripMenuItem1.Size = New System.Drawing.Size(251, 24)
        Me.RealidadVirtualToolStripMenuItem1.Text = "Realidad Virtual"
        '
        'CondicionalesToolStripMenuItem2
        '
        Me.CondicionalesToolStripMenuItem2.Name = "CondicionalesToolStripMenuItem2"
        Me.CondicionalesToolStripMenuItem2.Size = New System.Drawing.Size(251, 24)
        Me.CondicionalesToolStripMenuItem2.Text = "Condicionales Programación"
        '
        'IAToolStripMenuItem1
        '
        Me.IAToolStripMenuItem1.Name = "IAToolStripMenuItem1"
        Me.IAToolStripMenuItem1.Size = New System.Drawing.Size(251, 24)
        Me.IAToolStripMenuItem1.Text = "Inteligencia Artificial"
        '
        'CiclosToolStripMenuItem1
        '
        Me.CiclosToolStripMenuItem1.Name = "CiclosToolStripMenuItem1"
        Me.CiclosToolStripMenuItem1.Size = New System.Drawing.Size(251, 24)
        Me.CiclosToolStripMenuItem1.Text = "Ciclos Programación"
        '
        'ConfiguraciónToolStripMenuItem
        '
        Me.ConfiguraciónToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConsultarEstudianteToolStripMenuItem, Me.EditarEstudianteToolStripMenuItem})
        Me.ConfiguraciónToolStripMenuItem.Name = "ConfiguraciónToolStripMenuItem"
        Me.ConfiguraciónToolStripMenuItem.Size = New System.Drawing.Size(106, 23)
        Me.ConfiguraciónToolStripMenuItem.Text = "Configuración"
        '
        'ConsultarEstudianteToolStripMenuItem
        '
        Me.ConsultarEstudianteToolStripMenuItem.Name = "ConsultarEstudianteToolStripMenuItem"
        Me.ConsultarEstudianteToolStripMenuItem.Size = New System.Drawing.Size(205, 24)
        Me.ConsultarEstudianteToolStripMenuItem.Text = "Consultar Estudiante"
        '
        'EditarEstudianteToolStripMenuItem
        '
        Me.EditarEstudianteToolStripMenuItem.Name = "EditarEstudianteToolStripMenuItem"
        Me.EditarEstudianteToolStripMenuItem.Size = New System.Drawing.Size(205, 24)
        Me.EditarEstudianteToolStripMenuItem.Text = "Editar Estudiante"
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1029, 598)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Label1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Principal"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CursosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeguridadInformaticaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RealidadVirtualToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CondicionalesToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents IAToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CiclosToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ConfiguraciónToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConsultarEstudianteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarEstudianteToolStripMenuItem As ToolStripMenuItem
End Class
