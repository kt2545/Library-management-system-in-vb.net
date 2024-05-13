<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class College
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(College))
        Me.cinsert = New System.Windows.Forms.Button()
        Me.cupdate = New System.Windows.Forms.Button()
        Me.cname = New System.Windows.Forms.Label()
        Me.ccode = New System.Windows.Forms.Label()
        Me.caddress = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.cid = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.cdelete = New System.Windows.Forms.Button()
        Me.csearch = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.backbtndash = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cinsert
        '
        Me.cinsert.BackColor = System.Drawing.Color.White
        Me.cinsert.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cinsert.ForeColor = System.Drawing.Color.Black
        Me.cinsert.Location = New System.Drawing.Point(117, 383)
        Me.cinsert.Name = "cinsert"
        Me.cinsert.Size = New System.Drawing.Size(181, 65)
        Me.cinsert.TabIndex = 4
        Me.cinsert.Text = "Insert "
        Me.cinsert.UseVisualStyleBackColor = False
        '
        'cupdate
        '
        Me.cupdate.BackColor = System.Drawing.Color.White
        Me.cupdate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cupdate.ForeColor = System.Drawing.Color.Black
        Me.cupdate.Location = New System.Drawing.Point(392, 383)
        Me.cupdate.Name = "cupdate"
        Me.cupdate.Size = New System.Drawing.Size(181, 65)
        Me.cupdate.TabIndex = 5
        Me.cupdate.Text = "Update "
        Me.cupdate.UseVisualStyleBackColor = False
        '
        'cname
        '
        Me.cname.AutoSize = True
        Me.cname.BackColor = System.Drawing.Color.White
        Me.cname.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cname.ForeColor = System.Drawing.Color.Black
        Me.cname.Location = New System.Drawing.Point(156, 116)
        Me.cname.Name = "cname"
        Me.cname.Size = New System.Drawing.Size(173, 32)
        Me.cname.TabIndex = 8
        Me.cname.Text = "College Name"
        '
        'ccode
        '
        Me.ccode.AutoSize = True
        Me.ccode.BackColor = System.Drawing.Color.White
        Me.ccode.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ccode.ForeColor = System.Drawing.Color.Black
        Me.ccode.Location = New System.Drawing.Point(165, 179)
        Me.ccode.Name = "ccode"
        Me.ccode.Size = New System.Drawing.Size(164, 32)
        Me.ccode.TabIndex = 9
        Me.ccode.Text = "College Code"
        '
        'caddress
        '
        Me.caddress.AutoSize = True
        Me.caddress.BackColor = System.Drawing.Color.White
        Me.caddress.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.caddress.ForeColor = System.Drawing.Color.Black
        Me.caddress.Location = New System.Drawing.Point(131, 242)
        Me.caddress.Name = "caddress"
        Me.caddress.Size = New System.Drawing.Size(198, 32)
        Me.caddress.TabIndex = 10
        Me.caddress.Text = "College Address"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(392, 122)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(558, 26)
        Me.TextBox1.TabIndex = 12
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(392, 185)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(558, 26)
        Me.TextBox2.TabIndex = 13
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(392, 248)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(558, 26)
        Me.TextBox3.TabIndex = 14
        '
        'cid
        '
        Me.cid.AutoSize = True
        Me.cid.BackColor = System.Drawing.Color.White
        Me.cid.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cid.ForeColor = System.Drawing.Color.Black
        Me.cid.Location = New System.Drawing.Point(200, 57)
        Me.cid.Name = "cid"
        Me.cid.Size = New System.Drawing.Size(129, 32)
        Me.cid.TabIndex = 16
        Me.cid.Text = "College Id"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(392, 63)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(558, 26)
        Me.TextBox4.TabIndex = 17
        '
        'cdelete
        '
        Me.cdelete.BackColor = System.Drawing.Color.White
        Me.cdelete.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdelete.ForeColor = System.Drawing.Color.Black
        Me.cdelete.Location = New System.Drawing.Point(678, 383)
        Me.cdelete.Name = "cdelete"
        Me.cdelete.Size = New System.Drawing.Size(181, 65)
        Me.cdelete.TabIndex = 18
        Me.cdelete.Text = "Delete"
        Me.cdelete.UseVisualStyleBackColor = False
        '
        'csearch
        '
        Me.csearch.BackColor = System.Drawing.Color.White
        Me.csearch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.csearch.ForeColor = System.Drawing.Color.Black
        Me.csearch.Location = New System.Drawing.Point(964, 383)
        Me.csearch.Name = "csearch"
        Me.csearch.Size = New System.Drawing.Size(174, 65)
        Me.csearch.TabIndex = 19
        Me.csearch.Text = "Search"
        Me.csearch.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(-5, 503)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1535, 722)
        Me.DataGridView1.TabIndex = 20
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel1.Location = New System.Drawing.Point(1133, 110)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(295, 202)
        Me.Panel1.TabIndex = 21
        '
        'backbtndash
        '
        Me.backbtndash.BackColor = System.Drawing.Color.Yellow
        Me.backbtndash.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.backbtndash.ForeColor = System.Drawing.Color.Black
        Me.backbtndash.Location = New System.Drawing.Point(1397, 12)
        Me.backbtndash.Name = "backbtndash"
        Me.backbtndash.Size = New System.Drawing.Size(120, 47)
        Me.backbtndash.TabIndex = 22
        Me.backbtndash.Text = "Back"
        Me.backbtndash.UseVisualStyleBackColor = False
        '
        'College
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(120, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1529, 1224)
        Me.Controls.Add(Me.backbtndash)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.csearch)
        Me.Controls.Add(Me.cdelete)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.cid)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.caddress)
        Me.Controls.Add(Me.ccode)
        Me.Controls.Add(Me.cname)
        Me.Controls.Add(Me.cupdate)
        Me.Controls.Add(Me.cinsert)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "College"
        Me.Text = "dashboard"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cinsert As Button
    Friend WithEvents cupdate As Button
    Friend WithEvents cname As Label
    Friend WithEvents ccode As Label
    Friend WithEvents caddress As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents cid As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents cdelete As Button
    Friend WithEvents csearch As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents backbtndash As Button
End Class
