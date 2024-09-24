<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_manage_student
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
        Me.dgvmaanage_st = New System.Windows.Forms.DataGridView()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.dgvmaanage_st, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvmaanage_st
        '
        Me.dgvmaanage_st.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvmaanage_st.Location = New System.Drawing.Point(12, 12)
        Me.dgvmaanage_st.Name = "dgvmaanage_st"
        Me.dgvmaanage_st.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvmaanage_st.Size = New System.Drawing.Size(634, 242)
        Me.dgvmaanage_st.TabIndex = 0
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(131, 273)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(102, 36)
        Me.btn_delete.TabIndex = 1
        Me.btn_delete.Text = "حذف"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Location = New System.Drawing.Point(12, 273)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(102, 36)
        Me.btn_add.TabIndex = 2
        Me.btn_add.Text = "اضافة"
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(252, 273)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(102, 36)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "تعديل"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'frm_manage_student
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 346)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btn_add)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.dgvmaanage_st)
        Me.Name = "frm_manage_student"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ادارة الطلاب"
        CType(Me.dgvmaanage_st, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvmaanage_st As System.Windows.Forms.DataGridView
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_add As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
