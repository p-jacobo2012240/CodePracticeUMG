Imports System.Data.SqlClient
Public Class ventas

    Private Sub ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrirConexion()
        llenarDatagridviewventaas(ventasgrid)
        llenarDatagridviewventaasdetalle(gridDetalle)
    End Sub

    Private Sub REGRESARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REGRESARToolStripMenuItem.Click
        frmPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ventasgrid.CellContentClick
        abrirConexion()
        llenarDatagridviewventaas(ventasgrid)
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim vNit As String = TextBox1.Text
        Dim vFecha As String = TextBox2.Text
        Dim vMonto As String = TextBox3.Text


        Dim con As New SqlConnection(My.Settings.Conexion)
        Dim sql As String = "INSERT INTO TB_FACTURA(nit,fecha,monto) 
                VALUES('" + vNit + "', '" + vFecha + "', '" + vMonto + "')"

        Dim cmd As New SqlCommand(sql, con)

        Try
            con.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("LA INFORMACION SE HA INSERTADO CORRECTAMENTE")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class