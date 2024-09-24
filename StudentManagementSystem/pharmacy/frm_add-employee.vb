Imports System.Data.OleDb
Public Class frm_add_employee
    Dim dt_emp As New DataTable
    Dim state As String = "add"
    Sub filll()
        ds.Clear()
        Dim qur As String = "select * from tb_employee"
        ad = New OleDbDataAdapter(qur, sqlco)
        ad.Fill(dt_emp)
        dgvemploy.DataSource = dt_emp
        With dgvemploy
            .Columns(0).HeaderText = "الرقم"
            .Columns(1).HeaderText = "الاسم"
            .Columns(2).HeaderText = "الهاتف"
            .Columns(3).HeaderText = "العنوان"
            .Columns(4).HeaderText = "المؤهل"
            .Columns(5).HeaderText = "التخصص"
            .Columns(6).HeaderText = "القسم"
        End With

    End Sub


    Dim dt_get_departs As New DataTable

    Sub get_depart()
        Dim query As String = "select * from tb_departs"
        ad = New OleDbDataAdapter(query, sqlco)
        ad.Fill(dt_get_departs)
        cmb_depart.DataSource = dt_get_departs
        cmb_depart.DisplayMember = "id_depart"
        cmb_depart.ValueMember = "id_depart"


    End Sub
    Sub clr()
        txtid.Clear()
        txtcert.ResetText()
        txtnam.Clear()
        txtspecif.ResetText()
        txtnum.Clear()
        txtaddress.Clear()
        txtid.Enabled = True
    End Sub

    Private Sub frm_add_employee_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        filll()
        'get_depart()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        If txtnam.Text <> String.Empty Or txtid.Text <> String.Empty Then
            If state = "add" Then
                Dim row As DataRow = dt_emp.NewRow
                row(0) = Val(txtid.Text)
                row(1) = txtnam.Text
                row(2) = txtnum.Text
                row(3) = txtaddress.Text
                row(4) = txtcert.Text
                row(5) = txtspecif.Text
                '  row(6) = cmb_depart.Text
                dt_emp.Rows.Add(row)
                cmdb = New OleDbCommandBuilder(ad)
                ad.Update(dt_emp)
                dt_emp.AcceptChanges()
                MsgBox("تمت العملية بنجاح")
                state = "edit"
            Else
                Try
                    Dim up As String = "update tb_employee set nm=@nm,phone=@ph,ad=@ad,cert=@cert,specif=@specif,id_depart=@id_depart where id=" & Val(txtid.Text)
                    cmd = New OleDbCommand(up, sqlco)
                    cmd.Parameters.Add(New OleDbParameter("@nm", OleDbType.LongVarChar)).Value = txtnam.Text
                    cmd.Parameters.Add(New OleDbParameter("@ph", OleDbType.LongVarChar)).Value = txtnum.Text
                    cmd.Parameters.Add(New OleDbParameter("@ad", OleDbType.LongVarChar)).Value = txtaddress.Text
                    cmd.Parameters.Add(New OleDbParameter("@cert", OleDbType.LongVarChar)).Value = txtcert.Text
                    cmd.Parameters.Add(New OleDbParameter("@specif", OleDbType.LongVarChar)).Value = txtspecif.Text
                    cmd.Parameters.Add(New OleDbParameter("@id_depart", OleDbType.Integer)).Value = cmb_depart.SelectedValue

                    sqlco.Open()
                    cmd.ExecuteNonQuery()
                    MsgBox("تمت العملية بنجاح", MsgBoxStyle.Information, "الاضافة")
                    state = "add"
                Catch ex As Exception
                    MsgBox(ex.Message)
                Finally
                    sqlco.Close()
                End Try

               
            End If
        End If

      
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        clr()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        main.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim x As Integer = BindingContext(dt_emp).Position
        Dim xx As Integer = dt_emp.Rows(x).Item("id")


        Try

            Dim del As String = "delete from tb_employee where id=" & xx
            cmd = New OleDbCommand(del, sqlco)
            sqlco.Open()
            cmd.ExecuteNonQuery()
            MsgBox("تم حذف السجل")
            filll()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlco.Close()
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim x As Integer = BindingContext(dt_emp).Position
        txtid.Text = dt_emp.Rows(x).Item("id")
        txtid.Enabled = False
        txtnam.Text = dt_emp.Rows(x).Item("nm")
        txtnum.Text = dt_emp.Rows(x).Item("phone")
        txtaddress.Text = dt_emp.Rows(x).Item("ad")
        txtcert.Text = dt_emp.Rows(x).Item("cert")
        txtspecif.Text = dt_emp.Rows(x).Item("specif")
        ' cmb_depart.Text = dt_emp.Rows(x).Item("id_depart")
    End Sub
End Class