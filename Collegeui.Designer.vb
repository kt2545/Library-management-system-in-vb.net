<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Collegeui
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Collegeui))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Stock = New System.Windows.Forms.Button()
        Me.logoutbtn = New System.Windows.Forms.Button()
        Me.Book = New System.Windows.Forms.Button()
        Me.Breturn = New System.Windows.Forms.Button()
        Me.Issue = New System.Windows.Forms.Button()
        Me.Student = New System.Windows.Forms.Button()
        Me.Home = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Stock)
        Me.Panel1.Controls.Add(Me.logoutbtn)
        Me.Panel1.Controls.Add(Me.Book)
        Me.Panel1.Controls.Add(Me.Breturn)
        Me.Panel1.Controls.Add(Me.Issue)
        Me.Panel1.Controls.Add(Me.Student)
        Me.Panel1.Controls.Add(Me.Home)
        Me.Panel1.Location = New System.Drawing.Point(6, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(432, 1114)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(429, 335)
        Me.Panel3.TabIndex = 7
        '
        'Stock
        '
        Me.Stock.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Stock.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Stock.ForeColor = System.Drawing.Color.Yellow
        Me.Stock.Location = New System.Drawing.Point(6, 738)
        Me.Stock.Name = "Stock"
        Me.Stock.Size = New System.Drawing.Size(416, 75)
        Me.Stock.TabIndex = 6
        Me.Stock.Text = "Stock"
        Me.Stock.UseVisualStyleBackColor = False
        '
        'logoutbtn
        '
        Me.logoutbtn.BackColor = System.Drawing.Color.DarkSlateGray
        Me.logoutbtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logoutbtn.ForeColor = System.Drawing.Color.Yellow
        Me.logoutbtn.Location = New System.Drawing.Point(6, 1027)
        Me.logoutbtn.Name = "logoutbtn"
        Me.logoutbtn.Size = New System.Drawing.Size(416, 75)
        Me.logoutbtn.TabIndex = 5
        Me.logoutbtn.Text = "Logout"
        Me.logoutbtn.UseVisualStyleBackColor = False
        '
        'Book
        '
        Me.Book.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Book.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Book.ForeColor = System.Drawing.Color.Yellow
        Me.Book.Location = New System.Drawing.Point(3, 495)
        Me.Book.Name = "Book"
        Me.Book.Size = New System.Drawing.Size(416, 75)
        Me.Book.TabIndex = 4
        Me.Book.Text = "Book"
        Me.Book.UseVisualStyleBackColor = False
        '
        'Breturn
        '
        Me.Breturn.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Breturn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Breturn.ForeColor = System.Drawing.Color.Yellow
        Me.Breturn.Location = New System.Drawing.Point(6, 657)
        Me.Breturn.Name = "Breturn"
        Me.Breturn.Size = New System.Drawing.Size(416, 75)
        Me.Breturn.TabIndex = 3
        Me.Breturn.Text = "Return"
        Me.Breturn.UseVisualStyleBackColor = False
        '
        'Issue
        '
        Me.Issue.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Issue.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Issue.ForeColor = System.Drawing.Color.Yellow
        Me.Issue.Location = New System.Drawing.Point(6, 576)
        Me.Issue.Name = "Issue"
        Me.Issue.Size = New System.Drawing.Size(416, 75)
        Me.Issue.TabIndex = 2
        Me.Issue.Text = "Issue"
        Me.Issue.UseVisualStyleBackColor = False
        '
        'Student
        '
        Me.Student.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Student.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Student.ForeColor = System.Drawing.Color.Yellow
        Me.Student.Location = New System.Drawing.Point(3, 414)
        Me.Student.Name = "Student"
        Me.Student.Size = New System.Drawing.Size(416, 75)
        Me.Student.TabIndex = 1
        Me.Student.Text = "Student"
        Me.Student.UseVisualStyleBackColor = False
        '
        'Home
        '
        Me.Home.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Home.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Home.ForeColor = System.Drawing.Color.Yellow
        Me.Home.Location = New System.Drawing.Point(6, 341)
        Me.Home.Name = "Home"
        Me.Home.Size = New System.Drawing.Size(416, 67)
        Me.Home.TabIndex = 0
        Me.Home.Text = "Home"
        Me.Home.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(444, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1081, 1102)
        Me.Panel2.TabIndex = 1
        '
        'Collegeui
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1526, 1107)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Collegeui"
        Me.Text = "Collegeui"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Student As Button
    Friend WithEvents Home As Button
    Friend WithEvents logoutbtn As Button
    Friend WithEvents Book As Button
    Friend WithEvents Breturn As Button
    Friend WithEvents Issue As Button
    Friend WithEvents Stock As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
End Class
