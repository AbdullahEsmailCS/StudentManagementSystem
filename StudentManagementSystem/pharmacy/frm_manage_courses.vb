Imports System.Data.OleDb
Public Class frm_manage_courses
    Public dt_co As New DataTable

    Public Sub fillcourse()

        Dim qur As String = "select * from tb_courses"
        ad = New OleDbDataAdapter(qur, sqlco)
        ad.Fill(dt_co)
        dgvcor.DataSource = dt_co
        dt_co.Constraints.Add("prim", dt_co.Columns("id_course"), True)
        dgvcor.Columns(0).HeaderText = "رقم المادة"
        dgvcor.Columns(1).HeaderText = "اسم المادة"
    End Sub
    Public ch As Integer = BindingContext(dt_co).Position

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim frm As New frm_add_course
        frm.Show()
    End Sub

    Private Sub frm_manage_courses_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillcourse()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try


            Dim row As DataRow = dt_co.Rows.Find(ch)
            If row IsNot Nothing Then

                row.Delete()

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Dim ch As Integer = BindingContext(dt_co).Position
        'Dim row As DataRow = dt_co.Rows.Find(ch)
        'If row IsNot Nothing Then
        '    Dim frm As New frm_add_course
        '    frm.txtidcourse.Text = row(0)
        '    frm.
        '    frm.txtco_name.Text = row(1)

        'End If
        cmdb = New OleDbCommandBuilder(ad)
        ad.Update(dt_co)
        MsgBox("تم التعديل", MsgBoxStyle.Information, "تعديل")






    End Sub
End Class