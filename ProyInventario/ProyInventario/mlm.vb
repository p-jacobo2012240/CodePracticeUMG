Imports System.Data.SqlClient

Public Class mlm
    Private Sub REGRESARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REGRESARToolStripMenuItem.Click
        Me.Close()
        frmPrincipal.Show()
    End Sub

    Private Sub mlm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        abrirConexion()
        llenarDatagridviewmarca(gridMarca)
        llenarDatagridviewmodelo(gridModelo)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim vNombre As String = TextBox1.Text

        Dim con As New SqlConnection(My.Settings.Conexion)
        Dim sql As String = "INSERT INTO TB_MARCA(nombre)
                VALUES('" + vNombre + "')"

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
        Dim vNombre As String = TextBox2.Text
        Dim vflgrodado As String = TextBox3.Text
        Dim vflgsedan As String = TextBox4.Text

        Dim con As New SqlConnection(My.Settings.Conexion)
        Dim sql As String = "INSERT INTO TB_MODELO(nombre, flg_rodado, flg_sedan)
                VALUES('" + vNombre + "','" + vflgrodado + "', '" + vflgsedan + "')"

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