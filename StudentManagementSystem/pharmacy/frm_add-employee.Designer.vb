<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_add_employee
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.txtnam = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtnum = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtaddress = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtcert = New System.Windows.Forms.ComboBox()
        Me.txtspecif = New System.Windows.Forms.ComboBox()
        Me.dgvemploy = New System.Windows.Forms.DataGridView()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmb_depart = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.dgvemploy, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "الرقم"
        '
        'txtid
        '
        Me.txtid.Location = New System.Drawing.Point(110, 12)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(227, 29)
        Me.txtid.TabIndex = 1
        '
        'txtnam
        '
        Me.txtnam.Location = New System.Drawing.Point(110, 47)
        Me.txtnam.Name = "txtnam"
        Me.txtnam.Size = New System.Drawing.Size(227, 29)
        Me.txtnam.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 50)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "الاسم"
        '
        'txtnum
        '
        Me.txtnum.Location = New System.Drawing.Point(110, 82)
        Me.txtnum.Name = "txtnum"
        Me.txtnum.Size = New System.Drawing.Size(227, 29)
        Me.txtnum.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 82)
        Me.Label3.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "الهاتف"
        '
        'txtaddress
        '
        Me.txtaddress.Location = New System.Drawing.Point(110, 117)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.Size = New System.Drawing.Size(227, 29)
        Me.txtaddress.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 117)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 24)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "العنوان"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 153)
        Me.Label5.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 24)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "المؤهل العلمي"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 191)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 24)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "التخصص"
        '
        'txtcert
        '
        Me.txtcert.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtcert.FormattingEnabled = True
        Me.txtcert.Items.AddRange(New Object() {"بكالريوس", "ماجستير", "دكتورة", "بروفيسور"})
        Me.txtcert.Location = New System.Drawing.Point(110, 153)
        Me.txtcert.Name = "txtcert"
        Me.txtcert.Size = New System.Drawing.Size(227, 32)
        Me.txtcert.TabIndex = 11
        '
        'txtspecif
        '
        Me.txtspecif.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtspecif.FormattingEnabled = True
        Me.txtspecif.Items.AddRange(New Object() {"تقنية معلومات", "برمجة", "محاسبة", "معمارية", "انجليزي", "جرافكس", "شبكات"})
        Me.txtspecif.Location = New System.Drawing.Point(110, 191)
        Me.txtspecif.Name = "txtspecif"
        Me.txtspecif.Size = New System.Drawing.Size(227, 32)
        Me.txtspecif.TabIndex = 12
        '
        'dgvemploy
        '
        Me.dgvemploy.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvemploy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvemploy.Location = New System.Drawing.Point(343, 12)
        Me.dgvemploy.Name = "dgvemploy"
        Me.dgvemploy.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvemploy.Size = New System.Drawing.Size(704, 253)
        Me.dgvemploy.TabIndex = 13
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(247, 18)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(99, 40)
        Me.Button6.TabIndex = 18
        Me.Button6.Text = "خروج"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(375, 18)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(99, 40)
        Me.Button5.TabIndex = 17
        Me.Button5.Text = "تعديل"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(630, 18)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(99, 40)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "حفظ"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(495, 18)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(99, 40)
        Me.Button3.TabIndex = 15
        Me.Button3.Text = "حذف"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(746, 18)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(99, 40)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "جديد"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.Button5)
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 271)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1028, 75)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        '
        'cmb_depart
        '
        Me.cmb_depart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_depart.FormattingEnabled = True
        Me.cmb_depart.Items.AddRange(New Object() {"تقنية معلومات", "برمجة", "محاسبة", "معمارية", "انجليزي", "جرافكس", "شبكات"})
        Me.cmb_depart.Location = New System.Drawing.Point(110, 233)
        Me.cmb_depart.Name = "cmb_depart"
        Me.cmb_depart.Size = New System.Drawing.Size(227, 32)
        Me.cmb_depart.TabIndex = 21
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 233)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 24)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "القسم"
        '
        'frm_add_employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1065, 381)
        Me.Controls.Add(Me.cmb_depart)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvemploy)
        Me.Controls.Add(Me.txtspecif)
        Me.Controls.Add(Me.txtcert)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtaddress)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtnum)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtnam)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "frm_add_employee"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "اضافة موظف"
        CType(Me.dgvemploy, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtid As System.Windows.Forms.TextBox
    Friend WithEvents txtnam As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtnum As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtaddress As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtcert As System.Windows.Forms.ComboBox
    Friend WithEvents txtspecif As System.Windows.Forms.ComboBox
    Friend WithEvents dgvemploy As System.Windows.Forms.DataGridView
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_depart As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
