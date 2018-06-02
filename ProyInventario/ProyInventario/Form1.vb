Imports System.Data.SqlClient

Public Class frmLogin

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_Login_Click(sender As Object, e As EventArgs) Handles btn_Login.Click
        Dim connection As New SqlConnection("Server= PABLO; Database = INVEN; Integrated Security = true")

        Dim command As New SqlCommand("select * from TB_EMPLEADO where usuario = @username and pass = @password", connection)

        command.Parameters.Add("@username", SqlDbType.VarChar).Value = ct_User.Text
        command.Parameters.Add("@password", SqlDbType.VarChar).Value = ct_Password.Text

        Dim adapter As New SqlDataAdapter(command)

        Dim table As New DataTable()

        adapter.Fill(table)

        If table.Rows.Count() <= 0 Then

            MessageBox.Show("USUARIO O PASSWORD INVALIDO")

        Else
            'MessageBox.Show("Login Successfully")
            frmPrincipal.Show()
            Me.Hide()

        End If

    End Sub
End Class
