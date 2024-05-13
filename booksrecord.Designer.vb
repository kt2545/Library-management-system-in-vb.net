<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class booksrecord
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.bselect = New System.Windows.Forms.Button()
        Me.delete = New System.Windows.Forms.Button()
        Me.update = New System.Windows.Forms.Button()
        Me.insert = New System.Windows.Forms.Button()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.bookid = New System.Windows.Forms.Label()
        Me.price = New System.Windows.Forms.Label()
        Me.quantity = New System.Windows.Forms.Label()
        Me.Publisher = New System.Windows.Forms.Label()
        Me.author = New System.Windows.Forms.Label()
        Me.bookname = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Location = New System.Drawing.Point(2, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1418, 443)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(553, 406)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 38)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "Book Records"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(-4, 449)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1418, 657)
        Me.DataGridView1.TabIndex = 35
        '
        'bselect
        '
        Me.bselect.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bselect.Location = New System.Drawing.Point(1062, 329)
        Me.bselect.Name = "bselect"
        Me.bselect.Size = New System.Drawing.Size(192, 60)
        Me.bselect.TabIndex = 34
        Me.bselect.Text = "Select"
        Me.bselect.UseVisualStyleBackColor = True
        '
        'delete
        '
        Me.delete.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete.Location = New System.Drawing.Point(708, 329)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(192, 60)
        Me.delete.TabIndex = 33
        Me.delete.Text = "Delete"
        Me.delete.UseVisualStyleBackColor = True
        '
        'update
        '
        Me.update.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.update.Location = New System.Drawing.Point(381, 329)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(192, 60)
        Me.update.TabIndex = 32
        Me.update.Text = "Update"
        Me.update.UseVisualStyleBackColor = True
        '
        'insert
        '
        Me.insert.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.insert.Location = New System.Drawing.Point(22, 329)
        Me.insert.Name = "insert"
        Me.insert.Size = New System.Drawing.Size(192, 60)
        Me.insert.TabIndex = 31
        Me.insert.Text = "Insert"
        Me.insert.UseVisualStyleBackColor = True
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(937, 216)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(244, 26)
        Me.TextBox6.TabIndex = 30
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(937, 120)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(244, 26)
        Me.TextBox5.TabIndex = 29
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(937, 30)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(244, 26)
        Me.TextBox4.TabIndex = 28
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(218, 231)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(244, 26)
        Me.TextBox3.TabIndex = 27
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(218, 121)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(244, 26)
        Me.TextBox2.TabIndex = 26
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(216, 26)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(244, 26)
        Me.TextBox1.TabIndex = 25
        '
        'bookid
        '
        Me.bookid.AutoSize = True
        Me.bookid.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bookid.Location = New System.Drawing.Point(33, 23)
        Me.bookid.Name = "bookid"
        Me.bookid.Size = New System.Drawing.Size(102, 32)
        Me.bookid.TabIndex = 24
        Me.bookid.Text = "Book Id"
        '
        'price
        '
        Me.price.AutoSize = True
        Me.price.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.price.Location = New System.Drawing.Point(765, 116)
        Me.price.Name = "price"
        Me.price.Size = New System.Drawing.Size(71, 32)
        Me.price.TabIndex = 23
        Me.price.Text = "Price"
        '
        'quantity
        '
        Me.quantity.AutoSize = True
        Me.quantity.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quantity.Location = New System.Drawing.Point(765, 216)
        Me.quantity.Name = "quantity"
        Me.quantity.Size = New System.Drawing.Size(113, 32)
        Me.quantity.TabIndex = 22
        Me.quantity.Text = "Quantity"
        '
        'Publisher
        '
        Me.Publisher.AutoSize = True
        Me.Publisher.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Publisher.Location = New System.Drawing.Point(765, 28)
        Me.Publisher.Name = "Publisher"
        Me.Publisher.Size = New System.Drawing.Size(121, 32)
        Me.Publisher.TabIndex = 21
        Me.Publisher.Text = "Publisher"
        '
        'author
        '
        Me.author.AutoSize = True
        Me.author.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.author.Location = New System.Drawing.Point(33, 224)
        Me.author.Name = "author"
        Me.author.Size = New System.Drawing.Size(94, 32)
        Me.author.TabIndex = 20
        Me.author.Text = "Author"
        '
        'bookname
        '
        Me.bookname.AutoSize = True
        Me.bookname.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bookname.Location = New System.Drawing.Point(33, 117)
        Me.bookname.Name = "bookname"
        Me.bookname.Size = New System.Drawing.Size(146, 32)
        Me.bookname.TabIndex = 19
        Me.bookname.Text = "Book Name"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Yellow
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(1313, 8)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(99, 48)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'booksrecord
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1422, 1111)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.bselect)
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.update)
        Me.Controls.Add(Me.insert)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.bookid)
        Me.Controls.Add(Me.price)
        Me.Controls.Add(Me.quantity)
        Me.Controls.Add(Me.Publisher)
        Me.Controls.Add(Me.author)
        Me.Controls.Add(Me.bookname)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "booksrecord"
        Me.Text = "booksrecord"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents bselect As Button
    Friend WithEvents delete As Button
    Friend WithEvents update As Button
    Friend WithEvents insert As Button
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents bookid As Label
    Friend WithEvents price As Label
    Friend WithEvents quantity As Label
    Friend WithEvents Publisher As Label
    Friend WithEvents author As Label
    Friend WithEvents bookname As Label
    Friend WithEvents Button1 As Button
End Class
