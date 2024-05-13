Imports System.Collections.ObjectModel
Imports System.Data.SqlClient

Public Class College
    Private Sub dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim con As SqlConnection = New SqlConnection("Data Source=KAPIL;Initial Catalog=LibraryManagement;Integrated Security=SSPI")
            Dim cmd As SqlCommand = New SqlCommand("Select * from CollegeA", con)
            con.Open()
            GetData()
            con.Close()
            ' cmd.CommandType = CommandType.StoredProcedure


        Catch ex As Exception

            MessageBox.Show("An error occurred: " & ex.Message)
        End Try

    End Sub
    Private Sub cinsert_Click(sender As Object, e As EventArgs) Handles cinsert.Click
        Try
            Using con As New SqlConnection("Data Source=KAPIL;Initial Catalog=LibraryManagement;Integrated Security=True")
                con.Open()
                Using Command As New SqlCommand("[dbo].[usp_I_CollegeA]", con)
                    Command.Parameters.AddWithValue("@College_Name", TextBox1.Text())
                    Command.Parameters.AddWithValue("@College_Code", TextBox2.Text())
                    Command.Parameters.AddWithValue("@College_address", TextBox3.Text())
                    Command.CommandType = CommandType.StoredProcedure
                    Command.ExecuteNonQuery()
                    MessageBox.Show("College Records Inserted Successfully")


                End Using
                con.Close()
            End Using
            GetData()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

        ' Me.Hide()
        ' Insert.Show()

    End Sub
    Private Sub GetData()
        Using con As New SqlConnection("Data Source=KAPIL;Initial Catalog=LibraryManagement;Integrated Security=True")
            Dim command As New SqlCommand("Select * from CollegeA", con)
            ' command.CommandType = CommandType.StoredProcedure

            Dim adapter As New SqlDataAdapter(command)
            Dim dataTable As New DataTable()

            adapter.Fill(dataTable)

            DataGridView1.DataSource = dataTable
        End Using
    End Sub

    Private Sub deletepanel_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub cname_Click(sender As Object, e As EventArgs) Handles cname.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub cupdate_Click(sender As Object, e As EventArgs) Handles cupdate.Click
        Try
            Using con As New SqlConnection("Data Source=KAPIL;Initial Catalog=LibraryManagement;Integrated Security=True")
                con.Open()
                Using command As New SqlCommand("[dbo].[usp_u_CollegeA]", con)
                    command.Parameters.AddWithValue("@CollegeId", TextBox4.Text)
                    command.Parameters.AddWithValue("@College_Name", TextBox1.Text)
                    command.Parameters.AddWithValue("@College_Code", TextBox2.Text)
                    command.Parameters.AddWithValue("@College_address", TextBox3.Text)
                    command.CommandType = CommandType.StoredProcedure
                    command.ExecuteNonQuery()
                End Using
                con.Close()
            End Using


            GetData()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try


    End Sub

    Private Sub cdelete_Click(sender As Object, e As EventArgs) Handles cdelete.Click
        Try
            Dim cid As Integer = TextBox4.Text
            Using con As New SqlConnection("Data Source=KAPIL;Initial Catalog=LibraryManagement;Integrated Security=True")
                con.Open()
                Dim command As New SqlCommand("Delete  CollegeA where  CollegeId='" & cid & "' ", con)
                command.ExecuteNonQuery()
                MessageBox.Show("Record deteled sucessfully")
                con.Close()
            End Using
            GetData()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub csearch_Click(sender As Object, e As EventArgs) Handles csearch.Click
        Try
            Dim cid As Integer = TextBox4.Text
            Using con As New SqlConnection("Data Source=KAPIL;Initial Catalog=LibraryManagement;Integrated Security=True")
                con.Open()
                Dim command As New SqlCommand("select * from CollegeA where  CollegeId='" & cid & "' ", con)
                Dim adapter As New SqlDataAdapter(command)
                Dim dataTable As New DataTable()

                adapter.Fill(dataTable)

                DataGridView1.DataSource = dataTable
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub cid_Click(sender As Object, e As EventArgs) Handles cid.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles backbtndash.Click
        Me.Hide()
        login.Show()

    End Sub
End Class