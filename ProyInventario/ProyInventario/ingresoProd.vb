Imports System.Data.SqlClient

Public Class ingresoProd
    Private Sub ingresoProd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrirConexion()
        llenarDatagridview(GridProducto)
    End Sub

    Private Sub IngresoDeProductoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresoDeProductoToolStripMenuItem.Click
        frmPrincipal.Show()
        Me.Hide()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridProducto.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim vNombre As String = TextBox1.Text
        Dim vdes As String = TextBox2.Text
        Dim vCant As String = TextBox3.Text
        Dim vPrecio As String = TextBox4.Text

        Dim con As New SqlConnection(My.Settings.Conexion)
        Dim sql As String = "INSERT INTO TB_REPUESTO(nombre,descripcion,cantidad,precio)
                VALUES('" + vNombre + "', '" + vdes + "', '" + vCant + "', '" + vPrecio + "')"

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


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim vId As String = TextBox5.Text

        Dim con As New SqlConnection(My.Settings.Conexion)
        Dim sql As String = "DELETE TB_REPUESTO WHERE cod_repuesto ='" + vId + "'"


        Dim cmd As New SqlCommand(sql, con)

        Try
            con.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("SE ELIMINO CORRECTAMENTE")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class