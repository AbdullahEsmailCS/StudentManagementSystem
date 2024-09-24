Imports System.Data.OleDb
Public Class frm_login
    Dim strlog As String = "select * from tb_users"
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_log.Click
        Try
            If txtid.Text <> "" And txtpw.Text <> String.Empty Then
                'لو مش فاضي سوي الشروط التاليه
                cmd = New OleDbCommand("select * from tb_user where usr=@usr and pw=@pw", sqlco)
                'اضافة البراميترات الى الCOMMAND
                cmd.Parameters.Add(New OleDbParameter("@usr", SqlDbType.Text)).Value = txtid.Text.ToLower
                cmd.Parameters.Add(New OleDbParameter("@pw", SqlDbType.Text)).Value = txtpw.Text.ToLower
                'فتح الاتصال بقاعدة البانات
                sqlco.Open()
                'اسناد المتغير cmd الى القارئ dr
                Dim dr As OleDbDataReader = cmd.ExecuteReader
                'ابدا بقراءة البانات من القاعده
                dr.Read()
                'افحص القارئ ما اذا كان يحتوي على بيانات قادمة من القاعدة ام لا
                If dr.HasRows Then
                    main.Show()
                    Me.Hide()
                Else
                    MsgBox("اسم المستخدم او كلمة المرور خاطئة", MsgBoxStyle.Exclamation, "تنبيه")
                End If
                'اغلاق اقارئ
                dr.Close()
            Else
                MsgBox(" الرجاء ادخال اسم المستخدم و كلمة المرور ", MsgBoxStyle.Exclamation, "تنبيه")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            'اغلاق الاتصال بقاعدة البانات
            sqlco.Close()
        End Try

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click

        If MsgBox("هل تريد الخروج", MsgBoxStyle.Information, "تنبية") = DialogResult.OK Then
            End
        End If
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub frm_login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
