<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.sshowpass = New System.Windows.Forms.CheckBox()
        Me.csadminlbl = New System.Windows.Forms.Label()
        Me.sback = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.password = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.user = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(2, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1349, 708)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BackgroundImage = CType(resources.GetObject("Panel3.BackgroundImage"), System.Drawing.Image)
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Panel3.Location = New System.Drawing.Point(10, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(747, 687)
        Me.Panel3.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.sshowpass)
        Me.Panel2.Controls.Add(Me.csadminlbl)
        Me.Panel2.Controls.Add(Me.sback)
        Me.Panel2.Controls.Add(Me.TextBox2)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.password)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.user)
        Me.Panel2.Location = New System.Drawing.Point(752, 9)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(578, 678)
        Me.Panel2.TabIndex = 1
        '
        'sshowpass
        '
        Me.sshowpass.AutoSize = True
        Me.sshowpass.BackColor = System.Drawing.SystemColors.HotTrack
        Me.sshowpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sshowpass.ForeColor = System.Drawing.Color.White
        Me.sshowpass.Location = New System.Drawing.Point(260, 363)
        Me.sshowpass.Name = "sshowpass"
        Me.sshowpass.Size = New System.Drawing.Size(179, 29)
        Me.sshowpass.TabIndex = 9
        Me.sshowpass.Text = "Show Password"
        Me.sshowpass.UseVisualStyleBackColor = False
        '
        'csadminlbl
        '
        Me.csadminlbl.AutoSize = True
        Me.csadminlbl.BackColor = System.Drawing.Color.White
        Me.csadminlbl.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.csadminlbl.Location = New System.Drawing.Point(66, 15)
        Me.csadminlbl.Name = "csadminlbl"
        Me.csadminlbl.Size = New System.Drawing.Size(450, 65)
        Me.csadminlbl.TabIndex = 8
        Me.csadminlbl.Text = "SuperAdmin Login"
        '
        'sback
        '
        Me.sback.BackColor = System.Drawing.SystemColors.HotTrack
        Me.sback.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sback.ForeColor = System.Drawing.Color.White
        Me.sback.Location = New System.Drawing.Point(436, 534)
        Me.sback.Name = "sback"
        Me.sback.Size = New System.Drawing.Size(98, 46)
        Me.sback.TabIndex = 6
        Me.sback.Text = "Back"
        Me.sback.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(260, 286)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(221, 35)
        Me.TextBox2.TabIndex = 5
        Me.TextBox2.UseSystemPasswordChar = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(260, 180)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(221, 35)
        Me.TextBox1.TabIndex = 4
        '
        'password
        '
        Me.password.AutoSize = True
        Me.password.BackColor = System.Drawing.Color.White
        Me.password.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.password.Location = New System.Drawing.Point(93, 283)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(139, 38)
        Me.password.TabIndex = 3
        Me.password.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(236, 448)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 54)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "login"
        '
        'user
        '
        Me.user.AutoSize = True
        Me.user.BackColor = System.Drawing.Color.White
        Me.user.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.user.Location = New System.Drawing.Point(84, 177)
        Me.user.Name = "user"
        Me.user.Size = New System.Drawing.Size(148, 38)
        Me.user.TabIndex = 0
        Me.user.Text = "Username"
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1344, 703)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "login"
        Me.Text = "login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents password As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents user As Label
    Friend WithEvents sback As Button
    Friend WithEvents csadminlbl As Label
    Friend WithEvents sshowpass As CheckBox
    Friend WithEvents Panel3 As Panel
End Class
