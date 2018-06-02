Imports System.Data.SqlClient
Public Class reporte
    Private Sub REGRESARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REGRESARToolStripMenuItem.Click
        Me.Close()
        frmPrincipal.Show()
    End Sub


    Private Sub reporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrirConexion()
        llenarDatagridviewfiltro(gridFiltro)
    End Sub

End Class