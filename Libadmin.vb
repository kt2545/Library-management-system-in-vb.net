Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Libadmin
    Private Sub Libadmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Dim con As New SqlConnection("Data Source=KAPIL;Initial Catalog=LibraryManagement;Integrated Security=True")
            Dim command As New SqlCommand("Select * from libadmin", con)
            con.Open()
            GetData()
            GetData1()
            con.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub GetData()
        Using con As New SqlConnection("Data Source=KAPIL;Initial Catalog=LibraryManagement;Integrated Security=True")
            Dim command As New SqlCommand("Select * from libadmin", con)
            ' command.CommandType = CommandType.StoredProcedure

            Dim adapter As New SqlDataAdapter(command)
            Dim dataTable As New DataTable()

            adapter.Fill(dataTable)

            DataGridView1.DataSource = dataTable
        End Using
    End Sub
    Private Sub cinsert_Click(sender As Object, e As EventArgs) Handles cinsert.Click
        Try
            Using con As New SqlConnection("Data Source=KAPIL;Initial Catalog=LibraryManagement;Integrated Security=True")
                con.Open()
                Using Command As New SqlCommand("[dbo].[usp_I_libadmin]", con)
                    Command.Parameters.AddWithValue("@CollegeId", TextBox6.Text())
                    Command.Parameters.AddWithValue("@Name", TextBox1.Text())
                    Command.Parameters.AddWithValue("@phoneno", TextBox2.Text())
                    Command.Parameters.AddWithValue("@College_Code", TextBox3.Text())
                    Command.Parameters.AddWithValue("@password1", TextBox4.Text())
                    Command.CommandType = CommandType.StoredProcedure
                    Command.ExecuteNonQuery()
                    MessageBox.Show("College Records Inserted Successfully")


                End Using
                GetData()
                con.Close()
            End Using

        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub cupdate_Click(sender As Object, e As EventArgs) Handles cupdate.Click
        Try
            Using con As New SqlConnection("Data Source=KAPIL;Initial Catalog=LibraryManagement;Integrated Security=True")
                con.Open()
                Using command As New SqlCommand("[dbo].[usp_u_libadmin]", con)
                    command.Parameters.AddWithValue("@CollegeId", TextBox6.Text())
                    command.Parameters.AddWithValue("@librarianid", TextBox5.Text())
                    command.Parameters.AddWithValue("@Name", TextBox1.Text())
                    command.Parameters.AddWithValue("@phoneno", TextBox2.Text())
                    command.Parameters.AddWithValue("@College_Code", TextBox3.Text)
                    command.Parameters.AddWithValue("@password1 ", TextBox4.Text)
                    command.CommandType = CommandType.StoredProcedure
                    command.ExecuteNonQuery()
                End Using
                GetData()
                con.Close()
            End Using


        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub cdelete_Click(sender As Object, e As EventArgs) Handles cdelete.Click
        Try
            Using con As New SqlConnection("Data Source=KAPIL;Initial Catalog=LibraryManagement;Integrated Security=True")
                con.Open()
                Using command As New SqlCommand("[dbo].[usp_d_libadmin]", con)
                    command.Parameters.AddWithValue("@CollegeId", TextBox6.Text())
                    command.Parameters.AddWithValue("@Name", TextBox1.Text())
                    command.Parameters.AddWithValue("@phoneno", TextBox2.Text())
                    command.Parameters.AddWithValue("@College_Code", TextBox3.Text)
                    command.Parameters.AddWithValue("@password1 ", TextBox4.Text)
                    command.CommandType = CommandType.StoredProcedure
                    command.ExecuteNonQuery()
                End Using
                GetData()
                con.Close()
            End Using


        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub Back_Click(sender As Object, e As EventArgs) Handles Back.Click
        Me.Hide()
        Frontpage.Show()
    End Sub

    Private Sub ccode_Click(sender As Object, e As EventArgs) Handles ccode.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub cname_Click(sender As Object, e As EventArgs) Handles cname.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub csearch_Click(sender As Object, e As EventArgs) Handles csearch.Click
        Try
            Dim Libid As Integer = TextBox5.Text
            Using con As New SqlConnection("Data Source=KAPIL;Initial Catalog=LibraryManagement;Integrated Security=True")
                con.Open()
                Dim command As New SqlCommand("select * from libadmin where librarianid='" & Libid & "' ", con)
                Dim adapter As New SqlDataAdapter(command)
                Dim dataTable As New DataTable()

                adapter.Fill(dataTable)

                DataGridView1.DataSource = dataTable
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub GetData1()
        Using con As New SqlConnection("Data Source=KAPIL;Initial Catalog=LibraryManagement;Integrated Security=True")
            Dim command As New SqlCommand("Select * from CollegeA", con)
            ' command.CommandType = CommandType.StoredProcedure

            Dim adapter As New SqlDataAdapter(command)
            Dim dataTable As New DataTable()

            adapter.Fill(dataTable)

            DataGridView2.DataSource = dataTable
        End Using
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub
End Class