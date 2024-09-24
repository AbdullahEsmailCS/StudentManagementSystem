Imports System.Data.OleDb
Public Class frm_add_users
    Dim dt_user As New DataTable
    Dim ch As String = "add"
    Sub filldgv()
        dt_user.Rows.Clear()
        ad = New OleDbDataAdapter("select * from tb_user", sqlco)
        ad.Fill(dt_user)
        Me.DataGridView1.DataSource = dt_user
        dt_user.Constraints.Add("primary", dt_user.Columns("id"), True)
        Me.DataGridView1.Columns(0).HeaderText = "رقم المستخدم"
        Me.DataGridView1.Columns(1).HeaderText = "اسم المستخدم"
        Me.DataGridView1.Columns(2).HeaderText = "كلمة المرور"
    End Sub
    
    Sub clr()

        txtid.Clear()
        txtuser.Clear()
        txtpassword.Clear()
        txtid.Enabled = True
    End Sub

    Sub get_max()

    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        If txtid.Text <> "" And txtuser.Text <> String.Empty And txtpassword.Text <> "" Then

            If ch = "add" Then

                'انشاء صف في الداتا تيبل 
                Dim row As DataRow = dt_user.NewRow

                row(0) = Val(txtid.Text) ' اسناد قيم الحقول
                row(1) = txtuser.Text
                row(2) = txtpassword.Text
                dt_user.Rows.Add(row) ' اضافة السطر الى الداتا تيبل
                cmdb = New OleDbCommandBuilder(ad) ' تفعيل عملية الاضافة ع مستوى قاعدة البيانات
                ad.Update(dt_user) '
                dt_user.AcceptChanges() '
                MsgBox("تم الاضافة بنجاح", MsgBoxStyle.Information, "الاضافة")
                ch = "edit"
            Else
                Dim ro As DataRow = dt_user.Rows.Find(Val(txtid.Text)) ' البحث عن القيمة المراد تعديلها
                If ro IsNot Nothing Then ' فحص ما اذا كان موجود هذا السجل المراد تعديله
                    ro(1) = txtuser.Text ' اسناد قيم الحقول
                    ro(2) = txtpassword.Text
                    cmdb = New OleDbCommandBuilder(ad) ' تفعيل عملية الاضافة ع مستوى قاعدة البيانات
                    ad.Update(dt_user)
                    dt_user.AcceptChanges()
                    MsgBox("تم التعديل بنجاح", MsgBoxStyle.Information, "تعديل")
                    ch = "add"
                End If
            End If

        Else
            MsgBox("لا يسمح بترك الحقول فارغة الرجاء ادخال البيانات", MsgBoxStyle.Exclamation, "تحذير ")
        End If


       


    End Sub

    Private Sub frm_add_users_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        filldgv()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnnew.Click
        clr()
    End Sub

    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        Dim x As Integer = BindingContext(dt_user).Position 'الحصول على موقع السطر المراد حذفة
        txtid.Text = dt_user.Rows(x).Item("id") 'تحزين قيمة السطر المحدد في التكست ايدي
        txtid.Enabled = False
        Dim row As DataRow = dt_user.Rows.Find(txtid.Text) 'البحث عن السطر المراد حذفة 
        'If row IsNot Nothing Then ' التحقق من وجود السطر المحدد
        row.Delete()
        cmdb = New OleDbCommandBuilder(ad)
        ad.Update(dt_user)
        dt_user.AcceptChanges()
        MsgBox("تم عملية الحذف بنجاح", MsgBoxStyle.Information, "الحذف")
        'Else
        MsgBox("عذرا لايوجد بيانات لحذفها ", MsgBoxStyle.Exclamation, "تنبية")
        'End If
        'txtpassword.Text = dt_user.Rows(x).Item("pw")

    End Sub

    Private Sub btn_update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_update.Click
        Dim x As Integer = BindingContext(dt_user).Position 'الحصول على موقع السطر المحدد
        txtid.Text = dt_user.Rows(x).Item("id") 'الحصول على قيمة الحقل المراد تعديلة
        txtid.Enabled = False
        txtuser.Text = dt_user.Rows(x).Item("usr") 'الحصول على قيمة الحقل المراد تعديلة
        txtpassword.Text = dt_user.Rows(x).Item("pw") 'الحصول على قيمة الحقل المراد تعديلة


    End Sub
End Class