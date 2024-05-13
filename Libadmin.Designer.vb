<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Libadmin
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
        Me.ccode = New System.Windows.Forms.Label()
        Me.cpassword = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.cinsert = New System.Windows.Forms.Button()
        Me.cupdate = New System.Windows.Forms.Button()
        Me.cdelete = New System.Windows.Forms.Button()
        Me.Back = New System.Windows.Forms.Button()
        Me.cname = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.cphno = New System.Windows.Forms.Label()
        Me.csearch = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.libid = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.collegeid = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ccode
        '
        Me.ccode.AutoSize = True
        Me.ccode.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ccode.Location = New System.Drawing.Point(585, 112)
        Me.ccode.Name = "ccode"
        Me.ccode.Size = New System.Drawing.Size(161, 32)
        Me.ccode.TabIndex = 0
        Me.ccode.Text = "College code"
        '
        'cpassword
        '
        Me.cpassword.AutoSize = True
        Me.cpassword.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cpassword.Location = New System.Drawing.Point(592, 205)
        Me.cpassword.Name = "cpassword"
        Me.cpassword.Size = New System.Drawing.Size(122, 32)
        Me.cpassword.TabIndex = 1
        Me.cpassword.Text = "Password"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(234, 118)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(211, 26)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(234, 211)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(211, 26)
        Me.TextBox2.TabIndex = 3
        '
        'cinsert
        '
        Me.cinsert.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cinsert.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cinsert.Location = New System.Drawing.Point(91, 335)
        Me.cinsert.Name = "cinsert"
        Me.cinsert.Size = New System.Drawing.Size(180, 54)
        Me.cinsert.TabIndex = 4
        Me.cinsert.Text = "Insert"
        Me.cinsert.UseVisualStyleBackColor = False
        '
        'cupdate
        '
        Me.cupdate.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cupdate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cupdate.Location = New System.Drawing.Point(348, 335)
        Me.cupdate.Name = "cupdate"
        Me.cupdate.Size = New System.Drawing.Size(180, 54)
        Me.cupdate.TabIndex = 5
        Me.cupdate.Text = "Update"
        Me.cupdate.UseVisualStyleBackColor = False
        '
        'cdelete
        '
        Me.cdelete.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cdelete.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdelete.Location = New System.Drawing.Point(646, 335)
        Me.cdelete.Name = "cdelete"
        Me.cdelete.Size = New System.Drawing.Size(180, 54)
        Me.cdelete.TabIndex = 6
        Me.cdelete.Text = "Delete"
        Me.cdelete.UseVisualStyleBackColor = False
        '
        'Back
        '
        Me.Back.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Back.Font = New System.Drawing.Font("Britannic Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Back.Location = New System.Drawing.Point(1358, 6)
        Me.Back.Name = "Back"
        Me.Back.Size = New System.Drawing.Size(128, 50)
        Me.Back.TabIndex = 7
        Me.Back.Text = "Exit"
        Me.Back.UseVisualStyleBackColor = False
        '
        'cname
        '
        Me.cname.AutoSize = True
        Me.cname.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cname.Location = New System.Drawing.Point(86, 112)
        Me.cname.Name = "cname"
        Me.cname.Size = New System.Drawing.Size(81, 32)
        Me.cname.TabIndex = 8
        Me.cname.Text = "Name"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(786, 119)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(211, 26)
        Me.TextBox3.TabIndex = 9
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(786, 205)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(211, 26)
        Me.TextBox4.TabIndex = 10
        '
        'cphno
        '
        Me.cphno.AutoSize = True
        Me.cphno.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cphno.Location = New System.Drawing.Point(85, 204)
        Me.cphno.Name = "cphno"
        Me.cphno.Size = New System.Drawing.Size(123, 32)
        Me.cphno.TabIndex = 11
        Me.cphno.Text = "Phone no"
        '
        'csearch
        '
        Me.csearch.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.csearch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.csearch.Location = New System.Drawing.Point(917, 335)
        Me.csearch.Name = "csearch"
        Me.csearch.Size = New System.Drawing.Size(180, 54)
        Me.csearch.TabIndex = 12
        Me.csearch.Text = "Search"
        Me.csearch.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(4, 428)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1476, 383)
        Me.DataGridView1.TabIndex = 13
        '
        'libid
        '
        Me.libid.AutoSize = True
        Me.libid.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.libid.Location = New System.Drawing.Point(85, 30)
        Me.libid.Name = "libid"
        Me.libid.Size = New System.Drawing.Size(124, 32)
        Me.libid.TabIndex = 14
        Me.libid.Text = "Library id"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(234, 30)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(211, 26)
        Me.TextBox5.TabIndex = 15
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(786, 30)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(211, 26)
        Me.TextBox6.TabIndex = 16
        '
        'collegeid
        '
        Me.collegeid.AutoSize = True
        Me.collegeid.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.collegeid.Location = New System.Drawing.Point(585, 30)
        Me.collegeid.Name = "collegeid"
        Me.collegeid.Size = New System.Drawing.Size(129, 32)
        Me.collegeid.TabIndex = 17
        Me.collegeid.Text = "College Id"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(6, 816)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 62
        Me.DataGridView2.RowTemplate.Height = 28
        Me.DataGridView2.Size = New System.Drawing.Size(1473, 361)
        Me.DataGridView2.TabIndex = 18
        '
        'Libadmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1492, 1176)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.collegeid)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.libid)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.csearch)
        Me.Controls.Add(Me.cphno)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.cname)
        Me.Controls.Add(Me.Back)
        Me.Controls.Add(Me.cdelete)
        Me.Controls.Add(Me.ccode)
        Me.Controls.Add(Me.cupdate)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.cinsert)
        Me.Controls.Add(Me.cpassword)
        Me.Controls.Add(Me.TextBox2)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "Libadmin"
        Me.Text = "Libadmin"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ccode As Label
    Friend WithEvents cpassword As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents cinsert As Button
    Friend WithEvents cupdate As Button
    Friend WithEvents cdelete As Button
    Friend WithEvents Back As Button
    Friend WithEvents cname As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents cphno As Label
    Friend WithEvents csearch As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents libid As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents collegeid As Label
    Friend WithEvents DataGridView2 As DataGridView
End Class
