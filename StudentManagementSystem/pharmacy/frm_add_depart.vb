Imports System.Data.OleDb
Public Class frm_add_depart


    Sub filll()
        ds.Clear()
        Dim qur As String = "select * from tb_departs"
        ad = New OleDbDataAdapter(qur, sqlco)
        ad.Fill(ds, "departs")
        dgvdepart.DataSource = ds.Tables("departs")
        ds.Tables("departs").Constraints.Add("prim", ds.Tables("departs").Columns("id_depart"), True)
        With dgvdepart
            .Columns(0).HeaderText = "رقم القسم"
            .Columns(1).HeaderText = "اسم القسم"

        End With
    End Sub


    Private Sub frm_add_depart_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        filll()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            If id_depart.Text <> String.Empty And na_depart.Text <> String.Empty Then
                Dim row As DataRow = ds.Tables("departs").NewRow
                row(0) = Val(id_depart.Text)
                row(1) = na_depart.Text

                ds.Tables("departs").Rows.Add(row)
                cmdb = New OleDbCommandBuilder(ad)
                ad.Update(ds, "departs")
                MsgBox("تمت العملية بنجاح", MsgBoxStyle.Information, "الاضافة")
            Else
                MsgBox("الرجاء ادخال القيم", MsgBoxStyle.Exclamation, "خطا")
            End If

          
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        id_depart.Clear()
        na_depart.Clear()
        id_depart.Enabled = True
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        main.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        'Dim del As Integer = BindingContext(ds.Tables("departs")).Position

        Dim row As DataRow = ds.Tables("departs").Rows.Find(id_depart.Text)

        If row IsNot Nothing Then

            row.Delete()

        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

       
    End Sub

    Private Sub dgvdepart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvdepart.Click
        Dim del As Integer = BindingContext(ds.Tables("departs")).Position
        Dim row As DataRow = ds.Tables("departs").Rows.Find(del)

        If row IsNot Nothing Then

            id_depart.Text = row(0)
            id_depart.Enabled = False
            na_depart.Text = row(1)

        End If
    End Sub
End Class