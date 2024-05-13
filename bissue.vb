Imports System.Data.SqlClient
Imports System.Drawing.Text
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports project1.LibraryManagementDataSet1TableAdapters
Public Class bissue
    Public con As New SqlConnection("Data Source=KAPIL;Initial Catalog=LibraryManagement;Integrated Security=True")
    Private Sub bissue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillstudent()
        fillbook()
        Try
            Dim con As SqlConnection = New SqlConnection("Data Source=KAPIL;Initial Catalog=LibraryManagement;Integrated Security=SSPI")
            Dim cmd As SqlCommand = New SqlCommand("Select * from issue", con)
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
            Dim command As New SqlCommand("Select * from issue", con)
            ' command.CommandType = CommandType.StoredProcedure

            Dim adapter As New SqlDataAdapter(command)
            Dim dataTable As New DataTable()

            adapter.Fill(dataTable)

            DataGridView1.DataSource = dataTable
        End Using
    End Sub
    Private Sub fillstudent()
        Using con As New SqlConnection("Data Source=KAPIL;Initial Catalog=LibraryManagement;Integrated Security=True")
            con.Open()
            Dim query = "select * from student"
            Dim command As New SqlCommand(query, con)
            Dim adapter As New SqlDataAdapter(command)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)
            studentid.DataSource = dataTable
            studentid.DisplayMember = "studentid"
            studentid.ValueMember = "studentid"
            con.Close()
        End Using


    End Sub

    Private Sub fillbook()
        Using con As New SqlConnection("Data Source=KAPIL;Initial Catalog=LibraryManagement;Integrated Security=True")
            con.Open()
            Dim query = "select * from book"
            Dim command As New SqlCommand(query, con)
            Dim adapter As New SqlDataAdapter(command)
            Dim dataTable As New DataTable()
            adapter.Fill(dataTable)
            bookid.DataSource = dataTable
            bookid.DisplayMember = "bookid"
            bookid.ValueMember = "bookid"
            con.Close()
        End Using


    End Sub





    Private Sub GetStudentName()
        con.Open()

        Dim selectedValue As String = String.Empty

        ' Check if the SelectedItem is a DataRowView
        If TypeOf studentid.SelectedItem Is DataRowView Then
            ' Retrieve the underlying data item from the DataRowView
            Dim rowView As DataRowView = DirectCast(studentid.SelectedItem, DataRowView)
            selectedValue = rowView.Row("studentid").ToString()
        Else
            ' Handle the case where SelectedItem is not a DataRowView (e.g., if it's a plain value)
            selectedValue = studentid.SelectedItem.ToString()
        End If

        Dim query = "SELECT Name FROM student WHERE studentid = " & selectedValue
        Dim command = New SqlCommand(query, con)

        Dim dataTable As New DataTable()
        Dim reader As SqlDataReader
        reader = command.ExecuteReader()
        If reader.Read() Then
            TextBox4.Text = reader("Name").ToString()
        End If
        'reader.Close()
        con.Close()
    End Sub


    Private Sub GetBookName()
        con.Open()

        Dim selectedValue As String = String.Empty
        ' Check if the SelectedItem is a DataRowView
        If TypeOf bookid.SelectedItem Is DataRowView Then
            ' Retrieve the underlying data item from the DataRowView
            Dim rowView As DataRowView = DirectCast(bookid.SelectedItem, DataRowView)
            selectedValue = rowView.Row("bookid").ToString()
        Else
            '  Handle the Case where SelectedItem Is Not a DataRowView (e.g., If it's a plain value)
            selectedValue = bookid.SelectedItem.ToString()
        End If

        Dim query = "SELECT bookname FROM book WHERE bookid = " & selectedValue
        Dim command = New SqlCommand(query, con)

        Dim dataTable As New DataTable()
        Dim reader As SqlDataReader
        reader = command.ExecuteReader()
        If reader.Read() Then
            TextBox2.Text = reader("bookname").ToString()
        End If
        reader.Close()
        con.Close()
    End Sub



    Private Function CountIssuedBooks(studentId As String) As Integer
        Dim count As Integer = 0

        Try
            con.Open()
            Using command As New SqlCommand("[dbo].[usp_GetIssuedBooksCount]", con)
                command.Parameters.AddWithValue("@studentid", studentId)
                command.CommandType = CommandType.StoredProcedure
                count = Convert.ToInt32(command.ExecuteScalar())
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            con.Close()
        End Try

        Return count
    End Function





    Private Sub insert_Click(sender As Object, e As EventArgs) Handles insert.Click
        Try
            ' Retrieve the customizable value from the database
            Dim maxBooksAllowed As Integer = GetMaxBooksAllowedFromDatabase()

            ' Check if the student has already issued the maximum number of books
            If CountIssuedBooks(studentid.Text()) >= maxBooksAllowed Then
                MsgBox("You have already reached the maximum limit of books that can be issued.", vbInformation)
                Return
            End If

            con.Open()

            Dim updateStockQuery As String = "UPDATE stock SET quantity = quantity - 1 WHERE bookid = @bookid"
            Using updateStockCommand As New SqlCommand(updateStockQuery, con)
                updateStockCommand.Parameters.AddWithValue("@bookid", bookid.Text())
                updateStockCommand.ExecuteNonQuery()
            End Using

            Using command As New SqlCommand("[dbo].[usp_I_issue]", con)
                command.Parameters.AddWithValue("@studentid", studentid.Text())
                command.Parameters.AddWithValue("@Name", TextBox4.Text())
                command.Parameters.AddWithValue("@bookid", bookid.Text())
                command.Parameters.AddWithValue("@bookname", TextBox2.Text())
                command.Parameters.AddWithValue("issuedate", DateTimePicker1.Value())
                command.CommandType = CommandType.StoredProcedure
                command.ExecuteNonQuery()
            End Using
            GetData()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            con.Close()
        End Try
    End Sub


    Private Function GetMaxBooksAllowedFromDatabase() As Integer
        Dim maxBooksAllowed As Integer = 3 ' Default value if retrieval from the database fails

        Try
            con.Open()
            Using command As New SqlCommand("SELECT MaxBooksAllowed FROM LibrarySettings", con)
                maxBooksAllowed = Convert.ToInt32(command.ExecuteScalar())
            End Using
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            con.Close()
        End Try

        Return maxBooksAllowed
    End Function


    Private Sub stdid_Click(sender As Object, e As EventArgs) Handles stdid.Click

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles studentid.SelectedIndexChanged
        GetStudentName()
    End Sub

    Private Sub bid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles bookid.SelectedIndexChanged
        GetBookName()
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub update_Click(sender As Object, e As EventArgs) Handles update.Click
        Try
            con.Open()
            Using command As New SqlCommand("[dbo].[usp_u_issue]", con)
                command.Parameters.AddWithValue("@studentid", studentid.Text())
                command.Parameters.AddWithValue("@Name", TextBox4.Text())
                command.Parameters.AddWithValue("@bookid", bookid.Text())
                command.Parameters.AddWithValue("@bookname", TextBox2.Text())
                command.Parameters.AddWithValue("issuedate", DateTimePicker1.Value())
                command.CommandType = CommandType.StoredProcedure
                command.ExecuteNonQuery()

            End Using
            GetData()
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
        con.Close()




    End Sub



    Private Sub breset_Click(sender As Object, e As EventArgs) Handles breset.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        GetData()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class