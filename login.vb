Imports System.Data.Sql
Imports System.Data.SqlClient
Public Class login
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim con As SqlConnection = New SqlConnection("Data Source=PRABHAT\SQLEXPRESS;Initial Catalog=LibraryManagement;Integrated Security=SSPI")
            Dim cmd As SqlCommand = New SqlCommand("Select * from adminlogin", con)

            cmd.CommandType = CommandType.StoredProcedure


        Catch ex As Exception

            MessageBox.Show("An error occurred: " & ex.Message)
        End Try

    End Sub


    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Try
            Dim username As String = TextBox1.Text
            Dim password As String = TextBox2.Text

            Using connection As New SqlConnection("Data Source=KapiL;Initial Catalog=LibraryManagement;Integrated Security=True")
                connection.Open()

                Using command As New SqlCommand("[dbo].[ValidateUser]", connection)
                    command.CommandType = CommandType.StoredProcedure
                    command.Parameters.AddWithValue("@username", username)
                    command.Parameters.AddWithValue("@password", password)
                    command.Parameters.Add("@result", SqlDbType.Int).Direction = ParameterDirection.Output

                    command.ExecuteNonQuery()

                    If CInt(command.Parameters("@result").Value) = 1 Then
                        ' User is valid
                        'MsgBox("Login successful!", vbInformation)
                        Me.Hide()
                        Frontpage.Show()
                    Else
                        ' User is invalid
                        MsgBox("Invalid username or password.", vbCritical)
                    End If
                End Using
                connection.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub



    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub jpt_Click(sender As Object, e As EventArgs) Handles sback.Click
        Me.Hide()
        Frontpage.Show()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub sshowpass_CheckedChanged(sender As Object, e As EventArgs) Handles sshowpass.CheckedChanged

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub
End Class
