Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class admin
    Private Sub admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim con As SqlConnection = New SqlConnection("Data Source=PRABHAT\SQLEXPRESS;Initial Catalog=LibraryManagement;Integrated Security=SSPI")
            Dim cmd As SqlCommand = New SqlCommand("Select * from clzlogin ", con)

            cmd.CommandType = CommandType.StoredProcedure


        Catch ex As Exception

            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub clzpasslbl_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub clzcodelbl_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub clzloginbtn_Click(sender As Object, e As EventArgs) Handles clzloginbtn.Click
        Try
            If String.IsNullOrEmpty(clzcodelbl.Text) OrElse String.IsNullOrEmpty(TextBox1.Text) Then
                MsgBox("Please enter both college code and password.", vbExclamation)
                Return
            End If

            Using connection As New SqlConnection("Data Source=KAPIL;Initial Catalog=LibraryManagement;Integrated Security=True")
                connection.Open()

                Using command As New SqlCommand("[dbo].[usp_s_libadmin]", connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddWithValue("@CollegeId", clzcodelbl.Text)
                    command.Parameters.AddWithValue("@password1", TextBox1.Text)
                    command.Parameters.Add("@result1", SqlDbType.Int).Direction = ParameterDirection.Output

                    command.ExecuteNonQuery()
                    Dim result As Integer = Convert.ToInt32(command.Parameters("@result1").Value)
                    If result = 1 Then
                        ' User is valid
                        MsgBox("Login successful!", vbInformation)
                        Me.Hide()
                        Collegeui.Show()
                    Else
                        ' User is invalid
                        MsgBox("Invalid username or password.", vbCritical)
                    End If
                End Using
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub




    Private Sub clzcodelbl_TextChanged_1(sender As Object, e As EventArgs) Handles clzcodelbl.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Frontpage.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class