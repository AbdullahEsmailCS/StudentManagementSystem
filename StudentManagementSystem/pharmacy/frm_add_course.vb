Imports System.Data.OleDb

Public Class frm_add_course

    Dim dt As New DataTable
    Public Sub fillcourse()
        dt.Clear()
        Dim qur As String = "select * from tb_courses"
        ad = New OleDbDataAdapter(qur, sqlco)
        ad.Fill(dt)

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtco_name.Clear()
        txtidcourse.Clear()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            Dim row As DataRow = dt.NewRow
            row(0) = txtidcourse.Text
            row(1) = txtco_name.Text
            dt.Rows.Add(row)
            cmdb = New OleDbCommandBuilder(ad)
            ad.Update(dt)
            MsgBox("تمت الاضافة بنجاح")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub frm_add_course_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fillcourse()
    End Sub
End Class