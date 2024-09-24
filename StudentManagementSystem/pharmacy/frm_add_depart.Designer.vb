<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_add_depart
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
        Me.dgvdepart = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.id_depart = New System.Windows.Forms.TextBox()
        Me.na_depart = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.dgvdepart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvdepart
        '
        Me.dgvdepart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvdepart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdepart.Location = New System.Drawing.Point(314, 4)
        Me.dgvdepart.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dgvdepart.Name = "dgvdepart"
        Me.dgvdepart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvdepart.Size = New System.Drawing.Size(392, 209)
        Me.dgvdepart.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "رقم القسم"
        '
        'id_depart
        '
        Me.id_depart.Location = New System.Drawing.Point(97, 19)
        Me.id_depart.Name = "id_depart"
        Me.id_depart.Size = New System.Drawing.Size(210, 26)
        Me.id_depart.TabIndex = 2
        '
        'na_depart
        '
        Me.na_depart.Location = New System.Drawing.Point(97, 71)
        Me.na_depart.Name = "na_depart"
        Me.na_depart.Size = New System.Drawing.Size(210, 26)
        Me.na_depart.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "اسم القسم"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 126)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 39)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "جديد"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(107, 126)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(97, 39)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "اضافة"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(210, 126)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(97, 39)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "حذف"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(16, 168)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(188, 39)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "تعديل"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(210, 168)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(97, 39)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "رجوع"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'frm_add_depart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(712, 232)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.na_depart)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.id_depart)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvdepart)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MaximizeBox = False
        Me.Name = "frm_add_depart"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.Text = "اضافة قسم"
        CType(Me.dgvdepart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvdepart As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents id_depart As System.Windows.Forms.TextBox
    Friend WithEvents na_depart As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
End Class
