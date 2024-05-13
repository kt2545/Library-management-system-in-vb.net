<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frontpage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frontpage))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.superadminbtn = New System.Windows.Forms.Button()
        Me.adminbtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.superadminbtn)
        Me.Panel1.Controls.Add(Me.adminbtn)
        Me.Panel1.Location = New System.Drawing.Point(395, 56)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(556, 545)
        Me.Panel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Control
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Black", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(409, 45)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Choose your preferences"
        '
        'superadminbtn
        '
        Me.superadminbtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.superadminbtn.Location = New System.Drawing.Point(159, 347)
        Me.superadminbtn.Name = "superadminbtn"
        Me.superadminbtn.Size = New System.Drawing.Size(211, 59)
        Me.superadminbtn.TabIndex = 1
        Me.superadminbtn.Text = "Super Admin"
        Me.superadminbtn.UseVisualStyleBackColor = True
        '
        'adminbtn
        '
        Me.adminbtn.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adminbtn.Location = New System.Drawing.Point(159, 202)
        Me.adminbtn.Name = "adminbtn"
        Me.adminbtn.Size = New System.Drawing.Size(211, 64)
        Me.adminbtn.TabIndex = 0
        Me.adminbtn.Text = "Admin"
        Me.adminbtn.UseVisualStyleBackColor = True
        '
        'Frontpage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1344, 921)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Name = "Frontpage"
        Me.Text = "frontpage"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents superadminbtn As Button
    Friend WithEvents adminbtn As Button
    Friend WithEvents Label1 As Label
End Class
