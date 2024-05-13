Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class studentform


    Private Sub studentform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim con As SqlConnection = New SqlConnection("Data Source=KAPIL;Initial Catalog=LibraryManagement;Integrated Security=SSPI")
            Dim cmd As SqlCommand = New SqlCommand("Select * from student", con)
            con.Open()
            GetData()
            con.Close()
            ' cmd.CommandType = CommandType.StoredProcedure


        Catch ex As Exception

            MessageBox.Show("An error occurred: " & ex.Message)
        End Try
    End Sub
    Private Sub GetData()
        Using con As New SqlConnection("Data Source=KAPIL;Initial Catalog=LibraryManagement;Integrated Security=True")
            Dim command As New SqlCommand("Select * from student", con)
            ' command.CommandType = CommandType.StoredProcedure

            Dim adapter As New SqlDataAdapter(command)
            Dim dataTable As New DataTable()

            adapter.Fill(dataTable)

            DataGridView1.DataSource = dataTable
        End Using
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub insert_Click(sender As Object, e As EventArgs) Handles insert.Click
        Try
            Using con As New SqlConnection("Data Source=KAPIL;Initial Catalog=LibraryManagement;Integrated Security=True")
                con.Open()
                Using Command As New SqlCommand("[dbo].[usp_I_student]", con)
                    Command.Parameters.AddWithValue("@Name", TextBox1.Text())
                    Command.Parameters.AddWithValue("@Department", ComboBox2.Text())
                    Command.Parameters.AddWithValue("@semester", ComboBox1.Text())
                    Command.Parameters.AddWithValue("@rollno", TextBox2.Text())
                    Command.Parameters.AddWithValue("@phoneno", TextBox3.Text())
                    Command.Parameters.AddWithValue("@DOB", DateTimePicker1.Value)
                    Command.CommandType = CommandType.StoredProcedure
                    Command.ExecuteNonQuery()
                    MessageBox.Show("Student Records Inserted Successfully")


                End Using
                con.Close()
            End Using
            GetData()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub update_Click(sender As Object, e As EventArgs) Handles update.Click
        Try
            Using con As New SqlConnection("Data Source=KAPIL;Initial Catalog=LibraryManagement;Integrated Security=True")
                con.Open()
                Using Command As New SqlCommand("[dbo].[usp_u_student]", con)
                    Command.Parameters.AddWithValue("@studentid", TextBox5.Text())
                    Command.Parameters.AddWithValue("@Name", TextBox1.Text())
                    Command.Parameters.AddWithValue("@Department", ComboBox2.Text())
                    Command.Parameters.AddWithValue("@semester", ComboBox1.Text())
                    Command.Parameters.AddWithValue("@rollno", TextBox2.Text())
                    Command.Parameters.AddWithValue("@phoneno", TextBox3.Text())
                    Command.Parameters.AddWithValue("@DOB", DateTimePicker1.Value())
                    Command.CommandType = CommandType.StoredProcedure
                    Command.ExecuteNonQuery()
                    MessageBox.Show("Student Records Updated Successfully")


                End Using
                con.Close()
            End Using
            GetData()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try


    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        Try
            Using con As New SqlConnection("Data Source=KAPIL;Initial Catalog=LibraryManagement;Integrated Security=True")
                con.Open()
                Using Command As New SqlCommand("[dbo].[usp_d_student]", con)
                    Command.Parameters.AddWithValue("@Name", TextBox1.Text())
                    Command.Parameters.AddWithValue("@Department", ComboBox2.Text())
                    Command.Parameters.AddWithValue("@semester", ComboBox1.Text())
                    Command.Parameters.AddWithValue("@rollno", TextBox2.Text())
                    Command.Parameters.AddWithValue("@phoneno", TextBox3.Text())
                    Command.Parameters.AddWithValue("@DOB", DateTimePicker1.Value)
                    Command.CommandType = CommandType.StoredProcedure
                    Command.ExecuteNonQuery()
                    'MessageBox.Show("Student Records Updated Successfully")


                End Using
                con.Close()
            End Using
            GetData()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try

    End Sub

    Private Sub search_Click(sender As Object, e As EventArgs) Handles search.Click
        Try
            Dim semester As Integer = ComboBox1.Text
            Using con As New SqlConnection("Data Source=KAPIL;Initial Catalog=LibraryManagement;Integrated Security=True")
                con.Open()
                Dim command As New SqlCommand("select * from student where semester='" & semester & "' ", con)
                Dim adapter As New SqlDataAdapter(command)
                Dim dataTable As New DataTable()

                adapter.Fill(dataTable)

                DataGridView1.DataSource = dataTable
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
    Dim key = 0
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        TextBox5.Text = (row.Cells(0).Value.ToString)
        TextBox1.Text = (row.Cells(1).Value.ToString)
        ComboBox2.Text = (row.Cells(2).Value.ToString)
        ComboBox1.Text = (row.Cells(3).Value.ToString)
        TextBox2.Text = (row.Cells(4).Value.ToString)
        TextBox3.Text = (row.Cells(5).Value.ToString)
        DateTimePicker1.Value = (row.Cells(6).Value.ToString)
        If TextBox1.Text = " " Then
            key = 0
        Else
            Dim cellValue As String = row.Cells(0).Value.ToString()
            'Integer.TryParse(cellValue, key)
        End If

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub
End Class