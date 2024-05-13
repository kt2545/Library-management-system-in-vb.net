Public Class Frontpage
    Private Sub adminbtn_Click(sender As Object, e As EventArgs) Handles adminbtn.Click
        Me.Hide()
        admin.Show()
    End Sub

    Private Sub superadminbtn_Click(sender As Object, e As EventArgs) Handles superadminbtn.Click
        Me.Hide()
        Collegeui.Show()
    End Sub

    Private Sub Frontpage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class