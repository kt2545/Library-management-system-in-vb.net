Imports System.Data.SqlClient
Imports project1.LibraryManagementDataSet1TableAdapters

Public Class Collegeui
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Student.Click
        Me.Hide()
        studentform.Show()
    End Sub

    Private Sub Collegeui_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Home_Click(sender As Object, e As EventArgs) Handles Home.Click

    End Sub

    Private Sub logoutbtn_Click(sender As Object, e As EventArgs) Handles logoutbtn.Click
        Me.Hide()
        admin.Show()
    End Sub

    Private Sub Breturn_Click(sender As Object, e As EventArgs) Handles Breturn.Click
        Me.Hide()
        bookreturn.Show()
    End Sub

    Private Sub Book_Click(sender As Object, e As EventArgs) Handles Book.Click
        Me.Hide()
        booksrecord.Show()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Issue_Click(sender As Object, e As EventArgs) Handles Issue.Click
        Me.Hide()
        bissue.Show()
    End Sub

    Private Sub Stock_Click(sender As Object, e As EventArgs) Handles Stock.Click
        Me.Hide()
        stockk.Show()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class