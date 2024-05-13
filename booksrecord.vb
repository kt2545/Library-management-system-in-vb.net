Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class booksrecord
    Private Sub booksrecord_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim con As SqlConnection = New SqlConnection("Data Source=KAPIL;Initial Catalog=LibraryManagement;Integrated Security=SSPI")
            Dim cmd As SqlCommand = New SqlCommand("Select * from book", con)
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
            Dim command As New SqlCommand("Select * from book", con)
            ' command.CommandType = CommandType.StoredProcedure

            Dim adapter As New SqlDataAdapter(command)
            Dim dataTable As New DataTable()

            adapter.Fill(dataTable)

            DataGridView1.DataSource = dataTable
        End Using
    End Sub

 

    Private Sub update_Click(sender As Object, e As EventArgs) Handles update.Click
        Try
            Using con As New SqlConnection("Data Source=KAPIL;Initial Catalog=LibraryManagement;Integrated Security=True")
                con.Open()
                Using Command As New SqlCommand("[dbo].[usp_u_book]", con)
                    Command.CommandType = CommandType.StoredProcedure
                    Command.Parameters.AddWithValue("@bookid", TextBox1.Text())
                    Command.Parameters.AddWithValue("@bookname", TextBox2.Text())
                    Command.Parameters.AddWithValue("@Author", TextBox3.Text())
                    Command.Parameters.AddWithValue("@Publisher", TextBox4.Text())
                    Command.Parameters.AddWithValue("@price", TextBox5.Text())
                    Command.Parameters.AddWithValue("@quantity", TextBox6.Text())
                    Command.CommandType = CommandType.StoredProcedure
                    Command.ExecuteNonQuery()
                    MessageBox.Show("Book Records Inserted Successfully")

                    Dim stockCommand As New SqlCommand("UPDATE stock SET quantity = @quantity WHERE bookid = @bookid", con)
                    stockCommand.Parameters.AddWithValue("@quantity", TextBox6.Text())
                    stockCommand.Parameters.AddWithValue("@bookid", TextBox1.Text())
                    stockCommand.ExecuteNonQuery()

                End Using
                con.Close()
            End Using
            GetData()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        Try
            Dim b_id As Integer = TextBox1.Text
            Using con As New SqlConnection("Data Source=KAPIL;Initial Catalog=LibraryManagement;Integrated Security=True")
                con.Open()

                ' Delete records from the stock table for the corresponding bookid
                Dim deleteStockCommand As New SqlCommand("DELETE FROM stock WHERE bookid='" & b_id & "'", con)
                deleteStockCommand.ExecuteNonQuery()

                ' Delete the book record from the book table
                Dim deleteBookCommand As New SqlCommand("DELETE FROM book WHERE bookid='" & b_id & "'", con)
                deleteBookCommand.ExecuteNonQuery()

                MessageBox.Show("Records deleted successfully")
            End Using
            GetData()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub bselect_Click(sender As Object, e As EventArgs) Handles bselect.Click, Button1.Click
        Try
            Dim bookname As String = TextBox2.Text

            Using con As New SqlConnection("Data Source=KAPIL;Initial Catalog=LibraryManagement;Integrated Security=True")
                con.Open()
                Dim query As String = "select * FROM book WHERE bookname = @bookname"

                Using command As New SqlCommand(query, con)
                    command.Parameters.AddWithValue("@bookname", bookname)

                    Dim dataTable As New DataTable()
                    Dim adapter As New SqlDataAdapter(command)

                    adapter.Fill(dataTable)
                    If dataTable.Rows.Count > 0 Then
                        DataGridView1.DataSource = dataTable
                    Else
                        MessageBox.Show("No records found for the entered book name.")
                    End If
                End Using
            End Using

            GetData()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Dim key = 0
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        TextBox1.Text = (row.Cells(0).Value.ToString)
        TextBox2.Text = (row.Cells(1).Value.ToString)
        TextBox3.Text = (row.Cells(2).Value.ToString)
        TextBox4.Text = (row.Cells(3).Value.ToString)
        TextBox5.Text = (row.Cells(4).Value.ToString)
        TextBox6.Text = (row.Cells(5).Value.ToString)
        If TextBox1.Text = " " Then
            key = 0
        Else
            Dim cellValue As String = row.Cells(0).Value.ToString()
            'Integer.TryParse(cellValue, key)
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class