Public Class main

    Private Sub اضافةطالبToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles اضافةطالبToolStripMenuItem.Click
        Dim frm As New frm_add_student
        ' frm.MdiParent = Me
        frm_add_student.Show()

    End Sub

    

    Private Sub اضافةمادةToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles اضافةمادةToolStripMenuItem.Click

        Dim frm As New frm_add_course
        'frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ادارةالموادToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ادارةالموادToolStripMenuItem.Click
        Dim frm As New frm_manage_courses
        'frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'For Each ctr As Control In Me.Controls
        '    If TypeOf ctr Is MdiClient Then
        '        Me.BackgroundImage = My.Resources.footer

        '    End If
        'Next
        tool_machine.Text &= Environment.MachineName


    End Sub

    Private Sub عرضالطلابToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles عرضالطلابToolStripMenuItem.Click
        Dim frm As New frm_manage_student
        'frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub اضافةالدرجةToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles اضافةالدرجةToolStripMenuItem.Click
        Dim frm As New frm_add_degree
        'frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub اضافةقسمToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles اضافةقسمToolStripMenuItem.Click
        Dim frm As New frm_add_depart
        frm.Show()
    End Sub

    Private Sub اضافةموظفToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles اضافةموظفToolStripMenuItem.Click
        Dim frm As New frm_add_employee
        ' frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim frm As New frm_add_student
        ' frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Dim frm As New frm_manage_student
        ' frm.MdiParent = Me
        frm.Show()
    End Sub

   

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Dim frm As New frm_manage_courses
        ' frm.MdiParent = Me
        frm.Show()
    End Sub

  

    Private Sub tool_date_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tool_date.Click

    End Sub

   
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        tools_date.Text = "الوقت والتاريخ         " & Now
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Dim FRM As New frm_add_course
        ' FRM.MdiParent = Me
        FRM.Show()

    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        Dim frm As New frm_add_degree
        'frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub tools_date_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tools_date.Click

    End Sub

    Private Sub طباعةToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles طباعةToolStripMenuItem.Click
       

    End Sub

    Private Sub ضافةمستخدمToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ضافةمستخدمToolStripMenuItem.Click
        Dim frm As New frm_add_users
        ' frm.MdiParent = Me
        frm.Show()
    End Sub
End Class