Imports System.Data.OleDb
Imports System.IO

Public Class frm_add_student

    Public state As String = "add"
    Dim dt_get_departs As New DataTable

    Sub get_depart()
        Dim query As String = "select * from tb_departs"
        ad = New OleDbDataAdapter(query, sqlco)
        ad.Fill(dt_get_departs)
        cmb_depart.DataSource = dt_get_departs
        cmb_depart.DisplayMember = "nm_depart"
        cmb_depart.ValueMember = "nm_depart"


    End Sub

    Sub get_random_number()
        Randomize()
        Dim ran As New Random
        For i As Integer = 0 To 1000
            cmb_id_univer.Items.Add(ran.Next(1000, 9000))
        Next
    End Sub

    Sub filldgv()

        ds.Clear()
        Dim qur As String = "select * from tb_student"
        ad = New OleDbDataAdapter(qur, sqlco)
        ad.Fill(ds, "student")
        DataGridView1.DataSource = ds.Tables("student")
        ds.Tables("student").Constraints.Add("primary", ds.Tables("student").Columns("st_id"), True)

        With DataGridView1
            .Columns(0).HeaderText = "الرقم"
            .Columns(1).HeaderText = "الاسم"
            .Columns(2).HeaderText = "الهاتف"
            .Columns(3).HeaderText = "تاريخ الميلاد"
            .Columns(4).HeaderText = "القسم"
            .Columns(5).HeaderText = "الصورة"
            .Columns(6).HeaderText = "الرقم الجامعي"
        End With
    End Sub

    Sub clear()
        txtdate.ResetText()
        txtid.Clear()
        cmb_id_univer.ResetText()
        txtname.Clear()
        txtphone.Clear()
        cmb_depart.ResetText()
        PictureBox1.Image = Nothing
        txtid.Enabled = True
    End Sub
    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ofd As New OpenFileDialog
        ofd.Filter = "image (*.png;*.jpg;*.jpeg)|*.jpg;*.jpeg;*.png"
        If ofd.ShowDialog = DialogResult.OK Then
            PictureBox1.Image = Image.FromFile(ofd.FileName)
        End If
    End Sub

    Private Sub frm_add_student_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        filldgv()
        get_depart()
        get_random_number()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Try
            If state = "add" Then
                If txtid.Text = "" And txtname.Text = "" And cmb_depart.Text = "" And txtphone.Text = "" Then
                    MsgBox("الرجاء ادخال البيانات")


                Else
                    Dim row As DataRow = ds.Tables("student").NewRow
                    row(0) = Val(txtid.Text)
                    row(1) = txtname.Text
                    row(2) = txtphone.Text
                    row(3) = txtdate.Value
                    row(4) = cmb_depart.SelectedValue


                    Dim ms As New System.IO.MemoryStream
                    PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
                    Dim pic() As Byte = ms.ToArray
                    row(5) = pic




                    row(6) = cmb_id_univer.Text
                    ds.Tables("student").Rows.Add(row)
                    cmdb = New OleDbCommandBuilder(ad)
                    ad.Update(ds, "student")
                    ds.AcceptChanges()

                    MsgBox("تمت العملية بنجاح")
                    state = "edit"
                End If

            Else
                Dim xx As Integer = Val(txtid.Text)
                Dim row As DataRow = ds.Tables("student").Rows.Find(xx)


                row(1) = txtname.Text
                row(2) = txtphone.Text
                row(3) = txtdate.Value
                row(4) = cmb_depart.Text
                Dim ms As New System.IO.MemoryStream
                PictureBox1.Image.Save(ms, PictureBox1.Image.RawFormat)
                Dim pic() As Byte = ms.ToArray
                row(5) = pic
                row(6) = cmb_id_univer.Text
                cmdb = New OleDbCommandBuilder(ad)
                ad.Update(ds, "student")
                MsgBox("تمت العملية  التحديث بنجاح")
                state = "add"
                'filldgv()
            End If







        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        clear()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        main.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim x As Integer = BindingContext(ds.Tables("student")).Position
            Dim del As String = "delete from tb_student where st_id=" & x
            cmd = New OleDbCommand(del, sqlco)
            sqlco.Open()
            cmd.ExecuteNonQuery()
            MsgBox("تم حذف السجل")
            filldgv()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlco.Close()
        End Try
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim ed As Integer = BindingContext(ds.Tables("student")).Position


        Dim row As DataRow = ds.Tables("student").Rows.Find(ed)
        If row IsNot Nothing Then
            txtid.Text = row(0)
            txtid.Enabled = False

            txtname.Text = row(1)
            txtphone.Text = row(2)
            txtdate.Value = row(3)
            cmb_depart.Text = row(4)
            If Not IsDBNull(row(5)) Then
                Dim ms As New System.IO.MemoryStream(CType(row(5), Byte()))
                PictureBox1.Image = Image.FromStream(ms)
            Else
                MsgBox("لايوجد صورة")
                PictureBox1.Image = Nothing


            End If
            state = "edit"

        End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub cmb_id_univer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_id_univer.SelectedIndexChanged

    End Sub
End Class