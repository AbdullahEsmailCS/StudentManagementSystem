Imports System.Data.OleDb
Public Class frm_add_degree
    Dim dt_info As New DataTable
    Public dt As New DataTable
    Public dt_course As New DataTable
    Sub get_id_student()
        dt.Clear()
        Dim qur As String = "select * from tb_student"
        ad = New OleDbDataAdapter(qur, sqlco)
        ad.Fill(dt)
        cmb_id_st.DataSource = dt
        cmb_id_st.DisplayMember = "st_name"
        cmb_id_st.ValueMember = "st_id"

    End Sub

    Sub get_id_course()
        dt_course.Clear()
        Dim st As String = "select * from tb_courses"
        ad = New OleDbDataAdapter(st, sqlco)
        ad.Fill(dt_course)
        cmb_st_id_course.DataSource = dt_course
        cmb_st_id_course.DisplayMember = "course_name"
        cmb_st_id_course.ValueMember = "id_course"

    End Sub
    'Sub filll()
    '    ds.Clear()
    '    Dim qur As String = "select tb_student.st_name,tb_courses.course_name  from tb_degree inner join tb_student on tb_student.st_id = tb_degree.st_id inner join tb_courses on tb_courses.id_course=tb_degree.course_id"
    '    ad = New OleDbDataAdapter(qur, sqlco)
    '    ad.Fill(dt_info)
    '    dgv_degree.DataSource = dt_info
    '    'ds.Tables("degree").Constraints.Add("primary", ds.Tables("degree").Columns("st_id"), True)
    '    'With dgv_degree
    '    '    .Columns(0).HeaderText = "اسم الطالب"
    '    '    .Columns(1).HeaderText = " المادة"
    '    '    .Columns(2).HeaderText = "الدرجة"

    '    'End With
    'End Sub

    Private Sub frm_add_degree_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        get_id_course()
        get_id_student()
        'filll()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Try
        '    Dim row As DataRow = ds.Tables("degree").NewRow
        '    row(0) = cmb_id_st.SelectedValue
        '    row(1) = cmb_st_id_course.SelectedValue
        '    row(2) = txt_degree.Text
        '    ds.Tables("degree").Rows.Add(row)
        '    cmdb = New OleDbCommandBuilder(ad)
        '    ad.Update(ds, "degree")
        '    MsgBox("تمت العملية بنجاح")
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        Try
            Dim str As String = "insert into tb_degree (st_id,course_id,st_degree) values(@st_id,@id_course,@degree)"
            cmd = New OleDbCommand(str, sqlco)
            cmd.Parameters.Add(New OleDbParameter("@st_id", OleDbType.Numeric)).Value = cmb_id_st.SelectedValue
            cmd.Parameters.Add(New OleDbParameter("@id_course", OleDbType.Numeric)).Value = cmb_id_st.SelectedValue
            cmd.Parameters.Add(New OleDbParameter("@degree", OleDbType.Numeric)).Value = Val(txt_degree.Text)
            sqlco.Open()
            cmd.ExecuteNonQuery()
            MsgBox("تمت العملية بنجاح")
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlco.Close()
        End Try
        'filll()

     
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        main.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim delet As Integer = BindingContext(ds.Tables("degree")).Position

            Dim del As String = "delete from tb_student where st_id=" & delet
            cmd = New OleDbCommand(del, sqlco)
            sqlco.Open()
            cmd.ExecuteNonQuery()
            MsgBox("تم حذف السجل")

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            sqlco.Close()
        End Try
        'filll()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim upd As Integer = BindingContext(ds.Tables("degree")).Position
        'Dim row As DataRow = ds.Tables("degree").Rows.Find(upd)
        'If row IsNot Nothing Then
        '    cmb_id_st.Text = row(0)
        '    cmb_id_st.Enabled = False
        '    cmb_st_id_course.Text = (1)
        '    cmb_st_id_course.Enabled = False
        '    txt_degree.Text = row(2)
        'End If
        'Dim query As String = "select * from tb_degree where st_id=" & upd
        cmdb = New OleDbCommandBuilder(ad)
        ad.Update(ds, "degree")
        MsgBox("تم التحديث")
        'filll()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        txt_degree.Clear()

    End Sub
End Class