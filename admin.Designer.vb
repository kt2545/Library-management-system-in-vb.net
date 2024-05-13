<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class admin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(admin))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.clzloginbtn = New System.Windows.Forms.Button()
        Me.clzloginlbl = New System.Windows.Forms.Label()
        Me.clzpasslbl = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.clzcodelbl = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.clzloginbtn)
        Me.Panel1.Controls.Add(Me.clzloginlbl)
        Me.Panel1.Controls.Add(Me.clzpasslbl)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.clzcodelbl)
        Me.Panel1.Location = New System.Drawing.Point(761, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(573, 648)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.DarkOrange
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(430, 574)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 47)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'clzloginbtn
        '
        Me.clzloginbtn.BackColor = System.Drawing.Color.CornflowerBlue
        Me.clzloginbtn.Font = New System.Drawing.Font("Segoe UI Black", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clzloginbtn.ForeColor = System.Drawing.Color.White
        Me.clzloginbtn.Location = New System.Drawing.Point(172, 465)
        Me.clzloginbtn.Name = "clzloginbtn"
        Me.clzloginbtn.Size = New System.Drawing.Size(176, 60)
        Me.clzloginbtn.TabIndex = 8
        Me.clzloginbtn.Text = "Login"
        Me.clzloginbtn.UseVisualStyleBackColor = False
        '
        'clzloginlbl
        '
        Me.clzloginlbl.AutoSize = True
        Me.clzloginlbl.BackColor = System.Drawing.Color.CornflowerBlue
        Me.clzloginlbl.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clzloginlbl.ForeColor = System.Drawing.Color.White
        Me.clzloginlbl.Location = New System.Drawing.Point(101, 42)
        Me.clzloginlbl.Name = "clzloginlbl"
        Me.clzloginlbl.Size = New System.Drawing.Size(337, 65)
        Me.clzloginlbl.TabIndex = 7
        Me.clzloginlbl.Text = "College Login"
        '
        'clzpasslbl
        '
        Me.clzpasslbl.AutoSize = True
        Me.clzpasslbl.BackColor = System.Drawing.Color.White
        Me.clzpasslbl.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clzpasslbl.Location = New System.Drawing.Point(28, 352)
        Me.clzpasslbl.Name = "clzpasslbl"
        Me.clzpasslbl.Size = New System.Drawing.Size(186, 38)
        Me.clzpasslbl.TabIndex = 5
        Me.clzpasslbl.Text = "Clz password"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(230, 354)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(243, 39)
        Me.TextBox1.TabIndex = 3
        Me.TextBox1.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 257)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 38)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "College Id"
        '
        'clzcodelbl
        '
        Me.clzcodelbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.clzcodelbl.Location = New System.Drawing.Point(230, 256)
        Me.clzcodelbl.Name = "clzcodelbl"
        Me.clzcodelbl.Size = New System.Drawing.Size(243, 39)
        Me.clzcodelbl.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Location = New System.Drawing.Point(3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(752, 658)
        Me.Panel2.TabIndex = 1
        '
        'admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1339, 658)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "admin"
        Me.Text = "admin"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents clzloginbtn As Button
    Friend WithEvents clzloginlbl As Label
    Friend WithEvents clzpasslbl As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents clzcodelbl As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
End Class
