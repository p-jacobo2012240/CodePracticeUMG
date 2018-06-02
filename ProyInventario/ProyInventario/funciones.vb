Imports System.Data.SqlClient
Imports System.Data.Sql
Module funciones

    Public cn As SqlConnection
    Public adaptador As SqlDataAdapter
    Public dt As DataTable

    Sub abrirConexion()
        Try
            cn = New SqlConnection("Server= PABLO; Database = INVEN; Integrated Security = true")
            cn.Open()
            'MessageBox.Show("CONECTADO")
        Catch ex As Exception
            MessageBox.Show("No se pudo conectar: " + ex.ToString)
        End Try
    End Sub

    Sub llenarDatagridview(ByVal dgv As DataGridView)
        Try
            adaptador = New SqlDataAdapter("SELECT nombre, descripcion, cantidad FROM TB_REPUESTO", cn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.ToString)
        End Try
    End Sub

    Sub login()

        'esto lo movi al form 1
    End Sub

    Sub llenarDatagridviewventaas(ByVal dgv As DataGridView)
        Try
            adaptador = New SqlDataAdapter("SELECT * FROM TB_FACTURA", cn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.ToString)
        End Try
    End Sub

    Sub llenarDatagridviewventaasdetalle(ByVal dgv As DataGridView)
        Try
            adaptador = New SqlDataAdapter("SELECT * FROM TB_DETALLE_FACTURA", cn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.ToString)
        End Try
    End Sub

    Sub llenarDatagridviewmarca(ByVal dgv As DataGridView)
        Try
            adaptador = New SqlDataAdapter("SELECT * FROM TB_MARCA", cn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.ToString)
        End Try
    End Sub

    Sub llenarDatagridviewmodelo(ByVal dgv As DataGridView)
        Try
            adaptador = New SqlDataAdapter("SELECT * FROM TB_MODELO", cn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.ToString)
        End Try
    End Sub

    Sub llenarDatagridviewfiltro(ByVal dgv As DataGridView)
        Try
            adaptador = New SqlDataAdapter("SELECT * FROM TB_FACTURA", cn)
            dt = New DataTable
            adaptador.Fill(dt)
            dgv.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("No se lleno el Datagridview debido a: " + ex.ToString)
        End Try
    End Sub


End Module
