<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bissue
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
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.breset = New System.Windows.Forms.Button()
        Me.update = New System.Windows.Forms.Button()
        Me.insert = New System.Windows.Forms.Button()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.bookidd = New System.Windows.Forms.Label()
        Me.issuedate = New System.Windows.Forms.Label()
        Me.stdName = New System.Windows.Forms.Label()
        Me.stdid = New System.Windows.Forms.Label()
        Me.bookname = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.studentid = New System.Windows.Forms.ComboBox()
        Me.bookid = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(13, 478)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1403, 347)
        Me.DataGridView1.TabIndex = 53
        '
        'breset
        '
        Me.breset.BackColor = System.Drawing.Color.White
        Me.breset.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.breset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.breset.Location = New System.Drawing.Point(1081, 342)
        Me.breset.Name = "breset"
        Me.breset.Size = New System.Drawing.Size(192, 60)
        Me.breset.TabIndex = 52
        Me.breset.Text = "Reset"
        Me.breset.UseVisualStyleBackColor = False
        '
        'update
        '
        Me.update.BackColor = System.Drawing.Color.White
        Me.update.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.update.Location = New System.Drawing.Point(624, 342)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(192, 60)
        Me.update.TabIndex = 50
        Me.update.Text = "Update"
        Me.update.UseVisualStyleBackColor = False
        '
        'insert
        '
        Me.insert.BackColor = System.Drawing.Color.White
        Me.insert.Font = New System.Drawing.Font("Cambria", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.insert.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.insert.Location = New System.Drawing.Point(134, 342)
        Me.insert.Name = "insert"
        Me.insert.Size = New System.Drawing.Size(192, 60)
        Me.insert.TabIndex = 49
        Me.insert.Text = "Insert"
        Me.insert.UseVisualStyleBackColor = False
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(319, 105)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(244, 26)
        Me.TextBox4.TabIndex = 46
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(902, 103)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(244, 26)
        Me.TextBox2.TabIndex = 44
        '
        'bookidd
        '
        Me.bookidd.AutoSize = True
        Me.bookidd.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.bookidd.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bookidd.ForeColor = System.Drawing.Color.White
        Me.bookidd.Location = New System.Drawing.Point(692, 53)
        Me.bookidd.Name = "bookidd"
        Me.bookidd.Size = New System.Drawing.Size(102, 35)
        Me.bookidd.TabIndex = 42
        Me.bookidd.Text = "Book Id"
        '
        'issuedate
        '
        Me.issuedate.AutoSize = True
        Me.issuedate.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.issuedate.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.issuedate.ForeColor = System.Drawing.Color.White
        Me.issuedate.Location = New System.Drawing.Point(1247, 53)
        Me.issuedate.Name = "issuedate"
        Me.issuedate.Size = New System.Drawing.Size(135, 35)
        Me.issuedate.TabIndex = 41
        Me.issuedate.Text = "Issue Date"
        '
        'stdName
        '
        Me.stdName.AutoSize = True
        Me.stdName.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.stdName.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stdName.ForeColor = System.Drawing.Color.White
        Me.stdName.Location = New System.Drawing.Point(408, 53)
        Me.stdName.Name = "stdName"
        Me.stdName.Size = New System.Drawing.Size(84, 35)
        Me.stdName.TabIndex = 39
        Me.stdName.Text = "Name"
        '
        'stdid
        '
        Me.stdid.AutoSize = True
        Me.stdid.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.stdid.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stdid.ForeColor = System.Drawing.Color.White
        Me.stdid.Location = New System.Drawing.Point(76, 53)
        Me.stdid.Name = "stdid"
        Me.stdid.Size = New System.Drawing.Size(135, 35)
        Me.stdid.TabIndex = 38
        Me.stdid.Text = "Student Id"
        '
        'bookname
        '
        Me.bookname.AutoSize = True
        Me.bookname.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.bookname.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bookname.ForeColor = System.Drawing.Color.White
        Me.bookname.Location = New System.Drawing.Point(956, 53)
        Me.bookname.Name = "bookname"
        Me.bookname.Size = New System.Drawing.Size(149, 35)
        Me.bookname.TabIndex = 37
        Me.bookname.Text = "Book Name"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.studentid)
        Me.Panel1.Controls.Add(Me.update)
        Me.Panel1.Controls.Add(Me.bookid)
        Me.Panel1.Controls.Add(Me.breset)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.insert)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.bookname)
        Me.Panel1.Controls.Add(Me.bookidd)
        Me.Panel1.Controls.Add(Me.issuedate)
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Me.stdid)
        Me.Panel1.Controls.Add(Me.stdName)
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1418, 443)
        Me.Panel1.TabIndex = 36
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(1204, 102)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(191, 30)
        Me.DateTimePicker1.TabIndex = 47
        '
        'studentid
        '
        Me.studentid.FormattingEnabled = True
        Me.studentid.Location = New System.Drawing.Point(36, 105)
        Me.studentid.Name = "studentid"
        Me.studentid.Size = New System.Drawing.Size(180, 28)
        Me.studentid.TabIndex = 38
        '
        'bookid
        '
        Me.bookid.FormattingEnabled = True
        Me.bookid.Location = New System.Drawing.Point(650, 103)
        Me.bookid.Name = "bookid"
        Me.bookid.Size = New System.Drawing.Size(180, 28)
        Me.bookid.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(639, 410)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 29)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Issue  Records"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(13, 831)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView2.RowHeadersWidth = 62
        Me.DataGridView2.RowTemplate.Height = 28
        Me.DataGridView2.Size = New System.Drawing.Size(721, 305)
        Me.DataGridView2.TabIndex = 54
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(740, 831)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.RowHeadersWidth = 62
        Me.DataGridView3.RowTemplate.Height = 28
        Me.DataGridView3.Size = New System.Drawing.Size(676, 305)
        Me.DataGridView3.TabIndex = 55
        '
        'bissue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1438, 1138)
        Me.Controls.Add(Me.DataGridView3)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "bissue"
        Me.Text = "bissue"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents breset As Button
    Friend WithEvents update As Button
    Friend WithEvents insert As Button
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents bookidd As Label
    Friend WithEvents issuedate As Label
    Friend WithEvents stdName As Label
    Friend WithEvents stdid As Label
    Friend WithEvents bookname As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents studentid As ComboBox
    Friend WithEvents bookid As ComboBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridView3 As DataGridView
End Class
