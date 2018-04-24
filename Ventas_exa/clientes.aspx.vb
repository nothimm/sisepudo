
Imports System.Data
Imports System.Data.SqlClient

Partial Class clientes
    Inherits System.Web.UI.Page

    Protected Sub btn_insertar_cliente_Click(sender As Object, e As EventArgs) Handles btn_insertar_cliente.Click
        Dim cadena As New StringBuilder
        With cadena
            .Append("insert into Clienetes values ('")
            .Append(txt_rut.Text & "','")
            .Append(txt_nom_cliente.Text & "')")
        End With

        Using cn As New SqlConnection(ConfigurationManager.ConnectionStrings("cnn").ToString)
            Using cmd As New SqlCommand(cadena.ToString, cn)

                Try
                    cn.Open()
                    cmd.ExecuteNonQuery()
                    cn.Close()
                Catch ex As Exception
                    Label1.Text = ex.Message
                    Label1.Visible = True
                    Label1.ForeColor = Drawing.Color.Red
                End Try
            End Using
        End Using
        llenar_demas()
    End Sub
    Private Sub llenar_demas()
        Dim cadena1 As New StringBuilder
        With cadena1
            .Append("insert into telefonos(numero, descripcion, Rut_cliente) values ('")
            .Append(txt_telefono.Text & "','")
            .Append(txt_des.Text & "','")
            .Append(txt_rut.Text & "')")
        End With

        Using cn1 As New SqlConnection(ConfigurationManager.ConnectionStrings("cnn").ToString)
            Using cmd1 As New SqlCommand(cadena1.ToString, cn1)

                Try
                    cn1.Open()
                    cmd1.ExecuteNonQuery()
                    cn1.Close()
                Catch ex As Exception
                    Label1.Text = ex.Message
                    Label1.Visible = True
                    Label1.ForeColor = Drawing.Color.Red
                End Try
            End Using
        End Using
        Dim cadena2 As New StringBuilder
        With cadena2
            .Append("insert into direcciones(calle,numero,comunidad,ciudad, Rud_clienete) values ('")
            .Append(txt_calle.Text & "','")
            .Append(txt_numero.Text & "','")
            .Append(txt_comunidad.Text & "','")
            .Append(txt_ciudad.Text & "','")
            .Append(txt_rut.Text & "')")
        End With

        Using cn2 As New SqlConnection(ConfigurationManager.ConnectionStrings("cnn").ToString)
            Using cmd2 As New SqlCommand(cadena2.ToString, cn2)

                Try
                    cn2.Open()
                    cmd2.ExecuteNonQuery()
                    cn2.Close()
                Catch ex As Exception
                    Label1.Text = ex.Message
                    Label1.Visible = True
                    Label1.ForeColor = Drawing.Color.Red
                End Try
            End Using
        End Using
    End Sub
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        llenor_grilla()
    End Sub
    Private Sub llenor_grilla()
        Dim da As New SqlDataAdapter
        Dim ds As New DataSet
        Dim cnn As New SqlConnection(ConfigurationManager.ConnectionStrings("cnn").ToString)
        Dim cmd As New SqlCommand
        Try
            cnn.Open()
            cmd = New SqlCommand("select Rut_cliente,nombre from Clienetes ", cnn)
            da.SelectCommand = cmd
            da.Fill(ds)
            cnn.Close()
            ListBox1.DataSource = ds
            ListBox1.DataTextField = "nombre"
            ListBox1.DataValueField = "Rut_cliente"
            ListBox1.DataBind()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Protected Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click
        llenor_grilla()
    End Sub
    Protected Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim ds As New DataSet

        Using cnn As New SqlConnection(ConfigurationManager.ConnectionStrings("cnn").ToString)
            Using cmd As New SqlCommand("select c.Rut_cliente,c.nombre,d.calle,d.numero,d.comunidad,d.ciudad,t.numero,t.descripcion from Clienetes c inner join direcciones d on d.Rud_clienete=c.Rut_cliente inner join telefonos t on t.Rut_cliente = c.Rut_cliente where c.Rut_cliente = '" & ListBox1.SelectedValue & "' and t.prinsipal = 1", cnn)
                Dim da As New SqlDataAdapter
                cnn.Open()
                da.SelectCommand = cmd
                da.Fill(ds)
                cnn.Close()
            End Using
        End Using

        txt_rut.Text = If(ds.Tables(0).Rows(0).Item("c.Rut_cliente").ToString = "", "", ds.Tables(0).Rows(0).Item("c.Rut_cliente").ToString)
        txt_nom_cliente.Text = If(ds.Tables(0).Rows(0).Item("c.nombre").ToString = "", "", ds.Tables(0).Rows(0).Item("c.nombre").ToString)
        txt_calle.Text = If(ds.Tables(0).Rows(0).Item("d.calle").ToString = "", "", ds.Tables(0).Rows(0).Item("calle").ToString)
        txt_numero.Text = If(ds.Tables(0).Rows(0).Item("d.numero").ToString = "", "", ds.Tables(0).Rows(0).Item("d.numero").ToString)
        txt_comunidad.Text = If(ds.Tables(0).Rows(0).Item("d.comumindad").ToString = "", "", ds.Tables(0).Rows(0).Item("d.comunidad").ToString)
        txt_ciudad.Text = If(ds.Tables(0).Rows(0).Item("d.ciudad").ToString = "", "", ds.Tables(0).Rows(0).Item("d.ciudad").ToString)
        txt_telefono.Text = If(ds.Tables(0).Rows(0).Item("t.numero").ToString = "", "", ds.Tables(0).Rows(0).Item("t.numero").ToString)
        txt_des.Text = If(ds.Tables(0).Rows(0).Item("t.descripcion").ToString = "", "", ds.Tables(0).Rows(0).Item("t.descripcion").ToString)

    End Sub
    Protected Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        Dim cadena As New StringBuilder
        With cadena
            .Append("update Clientes set nombre = '")
            .Append(txt_nom_cliente.Text.Trim & "' where Rut_cliente = '")
            .Append(ListBox1.SelectedValue & "'")
        End With
        Using cn As New SqlConnection(ConfigurationManager.ConnectionStrings("cnn").ToString)
            Using cmd As New SqlCommand(cadena.ToString, cn)
                'cmd.CommandType = CommandType.Text
                'cmd.CommandText = cadena
                'cmd.Connection = cn
                Try
                    cn.Open()
                    cmd.ExecuteNonQuery()
                    ClientScript.RegisterStartupScript(Me.GetType(), "ClientScript", "alert ('Se guardo correctamente')", True)

                Catch ex As Exception
                Finally
                    cn.Close()
                End Try
            End Using
        End Using
        Dim cadena1 As New StringBuilder
        With cadena1
            .Append("update telefonos set numero = '")
            .Append(txt_numero.Text.Trim & "', detalles = '")
            .Append(txt_des.Text.Trim & "' where Rut_cliente = '")
            .Append(ListBox1.SelectedValue & "'")
        End With
        Using cn1 As New SqlConnection(ConfigurationManager.ConnectionStrings("cnn").ToString)
            Using cmd1 As New SqlCommand(cadena1.ToString, cn1)
                'cmd.CommandType = CommandType.Text
                'cmd.CommandText = cadena
                'cmd.Connection = cn
                Try
                    cn1.Open()
                    cmd1.ExecuteNonQuery()
                    ClientScript.RegisterStartupScript(Me.GetType(), "ClientScript", "alert ('Se guardo correctamente')", True)

                Catch ex As Exception
                Finally
                    cn1.Close()
                End Try
            End Using
        End Using
        Dim cadena2 As New StringBuilder
        With cadena2
            .Append("update direcciones set calle = '")
            .Append(txt_calle.Text.Trim & "', numero = '")
            .Append(txt_numero.Text.Trim & "', comunidad = '")
            .Append(txt_comunidad.Text.Trim & "', ciudad = '")
            .Append(txt_ciudad.Text.Trim & "' where Rut_cliente = '")
            .Append(ListBox1.SelectedValue & "'")
        End With
        Using cn2 As New SqlConnection(ConfigurationManager.ConnectionStrings("cnn").ToString)
            Using cmd2 As New SqlCommand(cadena1.ToString, cn2)
                'cmd.CommandType = CommandType.Text
                'cmd.CommandText = cadena
                'cmd.Connection = cn
                Try
                    cn2.Open()
                    cmd2.ExecuteNonQuery()
                    ClientScript.RegisterStartupScript(Me.GetType(), "ClientScript", "alert ('Se guardo correctamente')", True)

                Catch ex As Exception
                Finally
                    cn2.Close()
                End Try
            End Using
        End Using
    End Sub
    Protected Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click

    End Sub
End Class
