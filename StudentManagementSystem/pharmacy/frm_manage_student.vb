Imports System.Data.OleDb
Public Class frm_manage_student
    Sub filldgv()

        ds.Clear()
        Dim qur As String = "select * from tb_student"
        ad = New OleDbDataAdapter(qur, sqlco)
        ad.Fill(ds, "student")
        dgvmaanage_st.DataSource = ds.Tables("student")
        ds.Tables("student").Constraints.Add("primry", ds.Tables("student").Columns("st_id"), True)
        With dgvmaanage_st
            .Columns(0).HeaderText = "الرقم"
            .Columns(1).HeaderText = "الاسم"
            .Columns(2).HeaderText = "الهاتف"
            .Columns(3).HeaderText = "تاريخ الميلاد"
            .Columns(4).HeaderText = "القسم"
            .Columns(5).HeaderText = "الصورة"
        End With
    End Sub
    Private Sub frm_manage_student_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        filldgv()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click

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

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_add.Click
        Dim frm As New frm_add_student
        frm.Show()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Dim ed As Integer = BindingContext(ds.Tables("student")).Position
        'Dim frm As New frm_add_student
        'frm.Show()
        'Dim row As DataRow = ds.Tables("student").Rows.Find(ed)
        'If row IsNot Nothing Then
        '    frm.txtid.Text = row(0)
        '    frm.txtid.Enabled = False

        '    frm.txtname.Text = row(1)
        '    frm.txtphone.Text = row(2)
        '    frm.txtdate.Value = row(3)
        '    frm.cmb_depart.Text = row(4)
        '    If Not IsDBNull(row(5)) Then
        '        Dim ms As New System.IO.MemoryStream(CType(row(5), Byte()))
        '        frm.PictureBox1.Image = Image.FromStream(ms)
        '    Else
        '        MsgBox("لايوجد صورة")
        '        frm.PictureBox1.Image = Nothing


        '    End If
        '    frm.state = "edit"

        'End If
    End Sub
End Class