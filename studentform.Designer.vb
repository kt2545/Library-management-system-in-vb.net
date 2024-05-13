<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studentform
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
        Me.stdname = New System.Windows.Forms.Label()
        Me.stddep = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.phno = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.insert = New System.Windows.Forms.Button()
        Me.update = New System.Windows.Forms.Button()
        Me.Delete = New System.Windows.Forms.Button()
        Me.search = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.stdid = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.collegeid = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'stdname
        '
        Me.stdname.AutoSize = True
        Me.stdname.BackColor = System.Drawing.Color.White
        Me.stdname.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stdname.ForeColor = System.Drawing.Color.Black
        Me.stdname.Location = New System.Drawing.Point(175, 115)
        Me.stdname.Name = "stdname"
        Me.stdname.Size = New System.Drawing.Size(124, 32)
        Me.stdname.TabIndex = 0
        Me.stdname.Text = "Std Name"
        '
        'stddep
        '
        Me.stddep.AutoSize = True
        Me.stddep.BackColor = System.Drawing.Color.White
        Me.stddep.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stddep.ForeColor = System.Drawing.Color.Black
        Me.stddep.Location = New System.Drawing.Point(175, 196)
        Me.stddep.Name = "stddep"
        Me.stddep.Size = New System.Drawing.Size(152, 32)
        Me.stddep.TabIndex = 1
        Me.stddep.Text = "Department"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(851, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 32)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Semester"
        '
        'phno
        '
        Me.phno.AutoSize = True
        Me.phno.BackColor = System.Drawing.Color.White
        Me.phno.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phno.ForeColor = System.Drawing.Color.Black
        Me.phno.Location = New System.Drawing.Point(851, 122)
        Me.phno.Name = "phno"
        Me.phno.Size = New System.Drawing.Size(123, 32)
        Me.phno.TabIndex = 3
        Me.phno.Text = "Phone no"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(175, 274)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 32)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Roll no"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(851, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 32)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "D.O.B"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(375, 122)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(291, 26)
        Me.TextBox1.TabIndex = 6
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(376, 274)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(291, 26)
        Me.TextBox2.TabIndex = 7
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(1025, 122)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(291, 26)
        Me.TextBox3.TabIndex = 10
        '
        'insert
        '
        Me.insert.BackColor = System.Drawing.SystemColors.Window
        Me.insert.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.insert.ForeColor = System.Drawing.Color.Black
        Me.insert.Location = New System.Drawing.Point(152, 375)
        Me.insert.Name = "insert"
        Me.insert.Size = New System.Drawing.Size(175, 48)
        Me.insert.TabIndex = 12
        Me.insert.Text = "Insert"
        Me.insert.UseVisualStyleBackColor = False
        '
        'update
        '
        Me.update.BackColor = System.Drawing.SystemColors.Window
        Me.update.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update.ForeColor = System.Drawing.Color.Black
        Me.update.Location = New System.Drawing.Point(492, 375)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(175, 48)
        Me.update.TabIndex = 13
        Me.update.Text = "Update"
        Me.update.UseVisualStyleBackColor = False
        '
        'Delete
        '
        Me.Delete.BackColor = System.Drawing.SystemColors.Window
        Me.Delete.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete.ForeColor = System.Drawing.Color.Black
        Me.Delete.Location = New System.Drawing.Point(824, 375)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(175, 48)
        Me.Delete.TabIndex = 14
        Me.Delete.Text = "Delete"
        Me.Delete.UseVisualStyleBackColor = False
        '
        'search
        '
        Me.search.BackColor = System.Drawing.SystemColors.Window
        Me.search.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.search.ForeColor = System.Drawing.Color.Black
        Me.search.Location = New System.Drawing.Point(1147, 375)
        Me.search.Name = "search"
        Me.search.Size = New System.Drawing.Size(175, 48)
        Me.search.TabIndex = 15
        Me.search.Text = "Search"
        Me.search.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(-3, 467)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1486, 758)
        Me.DataGridView1.TabIndex = 16
        '
        'stdid
        '
        Me.stdid.AutoSize = True
        Me.stdid.BackColor = System.Drawing.Color.White
        Me.stdid.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stdid.ForeColor = System.Drawing.Color.Black
        Me.stdid.Location = New System.Drawing.Point(175, 30)
        Me.stdid.Name = "stdid"
        Me.stdid.Size = New System.Drawing.Size(80, 32)
        Me.stdid.TabIndex = 17
        Me.stdid.Text = "Std Id"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(376, 37)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(291, 26)
        Me.TextBox5.TabIndex = 18
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.TextBox7)
        Me.Panel1.Controls.Add(Me.collegeid)
        Me.Panel1.Controls.Add(Me.search)
        Me.Panel1.Controls.Add(Me.stdname)
        Me.Panel1.Controls.Add(Me.TextBox5)
        Me.Panel1.Controls.Add(Me.stddep)
        Me.Panel1.Controls.Add(Me.stdid)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.phno)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Delete)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.update)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.insert)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1483, 461)
        Me.Panel1.TabIndex = 20
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(1026, 198)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(291, 26)
        Me.DateTimePicker1.TabIndex = 24
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(380, 200)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(286, 28)
        Me.ComboBox2.TabIndex = 23
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.ComboBox1.Location = New System.Drawing.Point(1025, 37)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(291, 28)
        Me.ComboBox1.TabIndex = 22
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(1026, 274)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(291, 26)
        Me.TextBox7.TabIndex = 21
        '
        'collegeid
        '
        Me.collegeid.AutoSize = True
        Me.collegeid.BackColor = System.Drawing.Color.White
        Me.collegeid.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.collegeid.ForeColor = System.Drawing.Color.Black
        Me.collegeid.Location = New System.Drawing.Point(847, 267)
        Me.collegeid.Name = "collegeid"
        Me.collegeid.Size = New System.Drawing.Size(122, 32)
        Me.collegeid.TabIndex = 20
        Me.collegeid.Text = "CollegeId"
        '
        'studentform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1484, 1227)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "studentform"
        Me.Text = "studentform"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents stdname As Label
    Friend WithEvents stddep As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents phno As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents insert As Button
    Friend WithEvents update As Button
    Friend WithEvents Delete As Button
    Friend WithEvents search As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents stdid As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents collegeid As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
