<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        Me.IngresoDeProductoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfMarcaLineaModeloToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AsocProdToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'IngresoDeProductoToolStripMenuItem
        '
        Me.IngresoDeProductoToolStripMenuItem.Name = "IngresoDeProductoToolStripMenuItem"
        Me.IngresoDeProductoToolStripMenuItem.Size = New System.Drawing.Size(126, 20)
        Me.IngresoDeProductoToolStripMenuItem.Text = "Ingreso de Producto"
        '
        'VentasToolStripMenuItem
        '
        Me.VentasToolStripMenuItem.Name = "VentasToolStripMenuItem"
        Me.VentasToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.VentasToolStripMenuItem.Text = "Ventas"
        '
        'ConfMarcaLineaModeloToolStripMenuItem
        '
        Me.ConfMarcaLineaModeloToolStripMenuItem.Name = "ConfMarcaLineaModeloToolStripMenuItem"
        Me.ConfMarcaLineaModeloToolStripMenuItem.Size = New System.Drawing.Size(159, 20)
        Me.ConfMarcaLineaModeloToolStripMenuItem.Text = "Conf. Marca,Linea,Modelo"
        '
        'AsocProdToolStripMenuItem
        '
        Me.AsocProdToolStripMenuItem.Name = "AsocProdToolStripMenuItem"
        Me.AsocProdToolStripMenuItem.Size = New System.Drawing.Size(138, 20)
        Me.AsocProdToolStripMenuItem.Text = "Asoc. Prod<->Modelo"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresoDeProductoToolStripMenuItem, Me.VentasToolStripMenuItem, Me.ConfMarcaLineaModeloToolStripMenuItem, Me.AsocProdToolStripMenuItem, Me.ReportesToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(606, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ProyInventario.My.Resources.Resources.mongodb
        Me.ClientSize = New System.Drawing.Size(606, 308)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPrincipal"
        Me.Text = "SISTEMA DE INVENTARIO"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IngresoDeProductoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VentasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfMarcaLineaModeloToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AsocProdToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
End Class
