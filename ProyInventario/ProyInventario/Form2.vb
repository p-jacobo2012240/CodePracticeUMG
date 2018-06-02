Public Class frmPrincipal

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub IngresoDeProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresoDeProductoToolStripMenuItem.Click
        ingresoProd.Show()
        Me.Hide()
    End Sub

    Private Sub VentasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VentasToolStripMenuItem.Click
        ventas.Show()
        Me.Hide()
    End Sub

    Private Sub ConfMarcaLineaModeloToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfMarcaLineaModeloToolStripMenuItem.Click
        mlm.Show()
        Me.Close()
    End Sub

    Private Sub ReportesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportesToolStripMenuItem.Click
        reporte.Show()
        Me.Close()
    End Sub
End Class