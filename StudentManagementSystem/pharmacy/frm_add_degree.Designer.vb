<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_add_degree
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmb_id_st = New System.Windows.Forms.ComboBox()
        Me.cmb_st_id_course = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_degree = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.dgv_degree = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.dgv_degree, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb_id_st
        '
        Me.cmb_id_st.FormattingEnabled = True
        Me.cmb_id_st.Location = New System.Drawing.Point(82, 14)
        Me.cmb_id_st.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmb_id_st.Name = "cmb_id_st"
        Me.cmb_id_st.Size = New System.Drawing.Size(235, 28)
        Me.cmb_id_st.TabIndex = 0
        '
        'cmb_st_id_course
        '
        Me.cmb_st_id_course.FormattingEnabled = True
        Me.cmb_st_id_course.Location = New System.Drawing.Point(82, 58)
        Me.cmb_st_id_course.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cmb_st_id_course.Name = "cmb_st_id_course"
        Me.cmb_st_id_course.Size = New System.Drawing.Size(235, 28)
        Me.cmb_st_id_course.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "رقم الطالب"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 63)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "رقم المادة"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "الدرجة"
        '
        'txt_degree
        '
        Me.txt_degree.Location = New System.Drawing.Point(82, 104)
        Me.txt_degree.Name = "txt_degree"
        Me.txt_degree.Size = New System.Drawing.Size(235, 26)
        Me.txt_degree.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(14, 152)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(151, 35)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "حفظ"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(170, 152)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(151, 35)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "الرئيسية"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'dgv_degree
        '
        Me.dgv_degree.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_degree.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_degree.Location = New System.Drawing.Point(327, 14)
        Me.dgv_degree.Name = "dgv_degree"
        Me.dgv_degree.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv_degree.Size = New System.Drawing.Size(438, 173)
        Me.dgv_degree.TabIndex = 8
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(14, 193)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(151, 35)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "حذف"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(171, 193)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(151, 35)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "تعديل"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(328, 193)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(151, 35)
        Me.Button5.TabIndex = 11
        Me.Button5.Text = "جديد"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'frm_add_degree
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(777, 246)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.dgv_degree)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_degree)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_st_id_course)
        Me.Controls.Add(Me.cmb_id_st)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "frm_add_degree"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "اضافة درجة"
        CType(Me.dgv_degree, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmb_id_st As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_st_id_course As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_degree As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents dgv_degree As System.Windows.Forms.DataGridView
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
