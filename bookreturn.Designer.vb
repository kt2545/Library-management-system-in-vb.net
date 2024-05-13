<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class bookreturn
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
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.calculate = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.fine = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Returndate = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.bookname = New System.Windows.Forms.Label()
        Me.bookid = New System.Windows.Forms.Label()
        Me.issuedate = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.update = New System.Windows.Forms.Button()
        Me.stdid = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.bselect = New System.Windows.Forms.Button()
        Me.stdName = New System.Windows.Forms.Label()
        Me.insert = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.delete = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(12, 477)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersWidth = 62
        Me.DataGridView2.RowTemplate.Height = 28
        Me.DataGridView2.Size = New System.Drawing.Size(1461, 287)
        Me.DataGridView2.TabIndex = 67
        '
        'calculate
        '
        Me.calculate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calculate.ForeColor = System.Drawing.Color.Black
        Me.calculate.Location = New System.Drawing.Point(1242, 210)
        Me.calculate.Name = "calculate"
        Me.calculate.Size = New System.Drawing.Size(191, 67)
        Me.calculate.TabIndex = 60
        Me.calculate.Text = "Calculate"
        Me.calculate.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(1094, 113)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(141, 34)
        Me.TextBox1.TabIndex = 51
        '
        'fine
        '
        Me.fine.AutoSize = True
        Me.fine.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fine.ForeColor = System.Drawing.Color.White
        Me.fine.Location = New System.Drawing.Point(1088, 63)
        Me.fine.Name = "fine"
        Me.fine.Size = New System.Drawing.Size(157, 32)
        Me.fine.TabIndex = 50
        Me.fine.Text = "Fine per Day"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(651, 263)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(191, 34)
        Me.DateTimePicker2.TabIndex = 49
        '
        'Returndate
        '
        Me.Returndate.AutoSize = True
        Me.Returndate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Returndate.ForeColor = System.Drawing.Color.White
        Me.Returndate.Location = New System.Drawing.Point(659, 210)
        Me.Returndate.Name = "Returndate"
        Me.Returndate.Size = New System.Drawing.Size(158, 32)
        Me.Returndate.TabIndex = 48
        Me.Returndate.Text = "Return  Date"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(651, 115)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(191, 34)
        Me.DateTimePicker1.TabIndex = 47
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.ComboBox2.Location = New System.Drawing.Point(45, 113)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(180, 36)
        Me.ComboBox2.TabIndex = 38
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.ComboBox1.Location = New System.Drawing.Point(365, 113)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(180, 36)
        Me.ComboBox1.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(634, 444)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 32)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Issue  Records"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(365, 265)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(244, 34)
        Me.TextBox2.TabIndex = 44
        '
        'bookname
        '
        Me.bookname.AutoSize = True
        Me.bookname.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bookname.ForeColor = System.Drawing.Color.White
        Me.bookname.Location = New System.Drawing.Point(374, 210)
        Me.bookname.Name = "bookname"
        Me.bookname.Size = New System.Drawing.Size(146, 32)
        Me.bookname.TabIndex = 37
        Me.bookname.Text = "Book Name"
        '
        'bookid
        '
        Me.bookid.AutoSize = True
        Me.bookid.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bookid.ForeColor = System.Drawing.Color.White
        Me.bookid.Location = New System.Drawing.Point(360, 63)
        Me.bookid.Name = "bookid"
        Me.bookid.Size = New System.Drawing.Size(102, 32)
        Me.bookid.TabIndex = 42
        Me.bookid.Text = "Book Id"
        '
        'issuedate
        '
        Me.issuedate.AutoSize = True
        Me.issuedate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.issuedate.ForeColor = System.Drawing.Color.White
        Me.issuedate.Location = New System.Drawing.Point(646, 63)
        Me.issuedate.Name = "issuedate"
        Me.issuedate.Size = New System.Drawing.Size(132, 32)
        Me.issuedate.TabIndex = 41
        Me.issuedate.Text = "Issue Date"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(45, 265)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(244, 34)
        Me.TextBox4.TabIndex = 46
        '
        'update
        '
        Me.update.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update.Location = New System.Drawing.Point(392, 370)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(195, 40)
        Me.update.TabIndex = 63
        Me.update.Text = "Update"
        Me.update.UseVisualStyleBackColor = True
        '
        'stdid
        '
        Me.stdid.AutoSize = True
        Me.stdid.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stdid.ForeColor = System.Drawing.Color.White
        Me.stdid.Location = New System.Drawing.Point(53, 63)
        Me.stdid.Name = "stdid"
        Me.stdid.Size = New System.Drawing.Size(132, 32)
        Me.stdid.TabIndex = 38
        Me.stdid.Text = "Student Id"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 797)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1461, 346)
        Me.DataGridView1.TabIndex = 66
        '
        'bselect
        '
        Me.bselect.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bselect.Location = New System.Drawing.Point(1073, 370)
        Me.bselect.Name = "bselect"
        Me.bselect.Size = New System.Drawing.Size(195, 40)
        Me.bselect.TabIndex = 65
        Me.bselect.Text = "Select"
        Me.bselect.UseVisualStyleBackColor = True
        '
        'stdName
        '
        Me.stdName.AutoSize = True
        Me.stdName.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stdName.ForeColor = System.Drawing.Color.White
        Me.stdName.Location = New System.Drawing.Point(53, 210)
        Me.stdName.Name = "stdName"
        Me.stdName.Size = New System.Drawing.Size(81, 32)
        Me.stdName.TabIndex = 39
        Me.stdName.Text = "Name"
        '
        'insert
        '
        Me.insert.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.insert.Location = New System.Drawing.Point(33, 370)
        Me.insert.Name = "insert"
        Me.insert.Size = New System.Drawing.Size(195, 40)
        Me.insert.TabIndex = 62
        Me.insert.Text = "Insert"
        Me.insert.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'delete
        '
        Me.delete.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete.Location = New System.Drawing.Point(719, 370)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(195, 40)
        Me.delete.TabIndex = 64
        Me.delete.Text = "Delete"
        Me.delete.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Panel1.Controls.Add(Me.TextBox5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.calculate)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.fine)
        Me.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Panel1.Controls.Add(Me.Returndate)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.bookname)
        Me.Panel1.Controls.Add(Me.bookid)
        Me.Panel1.Controls.Add(Me.issuedate)
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Me.stdid)
        Me.Panel1.Controls.Add(Me.stdName)
        Me.Panel1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.White
        Me.Panel1.Location = New System.Drawing.Point(12, 5)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1461, 439)
        Me.Panel1.TabIndex = 61
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(887, 113)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(141, 34)
        Me.TextBox5.TabIndex = 65
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(881, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(164, 32)
        Me.Label4.TabIndex = 64
        Me.Label4.Text = "No Fine Days"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(1318, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 32)
        Me.Label3.TabIndex = 63
        Me.Label3.Text = "Total"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(1292, 113)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(141, 34)
        Me.TextBox3.TabIndex = 62
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Yellow
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 42)
        Me.Button1.TabIndex = 61
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(634, 765)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 32)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Return Records"
        '
        'bookreturn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1485, 1230)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.update)
        Me.Controls.Add(Me.bselect)
        Me.Controls.Add(Me.insert)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "bookreturn"
        Me.Text = "bookreturn"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents calculate As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents fine As Label
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents Returndate As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents bookname As Label
    Friend WithEvents bookid As Label
    Friend WithEvents issuedate As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents update As Button
    Friend WithEvents stdid As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents bselect As Button
    Friend WithEvents stdName As Label
    Friend WithEvents insert As Button
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents delete As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label4 As Label
End Class
