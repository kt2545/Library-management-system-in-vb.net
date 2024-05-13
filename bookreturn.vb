Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar

Public Class bookreturn
    Public con As New SqlConnection("Data Source=KAPIL;Initial Catalog=LibraryManagement;Integrated Security=True")

    Private Sub bookreturn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetData()
        GetData1()
    End Sub

    Private Sub GetData()
        Using con As New SqlConnection("Data Source=KAPIL;Initial Catalog=LibraryManagement;Integrated Security=True")
            Dim command As New SqlCommand("SELECT * FROM issue", con)
            ' command.CommandType = CommandType.StoredProcedure

            Dim adapter As New SqlDataAdapter(command)
            Dim dataTable As New DataTable()

            adapter.Fill(dataTable)

            DataGridView2.DataSource = dataTable
        End Using
    End Sub
    Dim key = 0
    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick
        GetData()
        Dim row As DataGridViewRow = DataGridView2.Rows(e.RowIndex)
        ComboBox2.Text = row.Cells(1).Value.ToString()
        TextBox4.Text = row.Cells(2).Value.ToString()
        ComboBox1.Text = row.Cells(3).Value.ToString()
        TextBox2.Text = row.Cells(4).Value.ToString()

        Dim dateString As String = row.Cells(5).Value.ToString()
        Dim dateValue As Date
        If Date.TryParse(dateString, dateValue) Then
            DateTimePicker1.Value = dateValue
        End If

        If ComboBox2.Text = " " Then
            key = 0
        Else
            Dim cellValue As String = row.Cells(0).Value.ToString()
            'Integer.TryParse(cellValue, key)
        End If
    End Sub



    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Dim studentName As String = TextBox4.Text.Trim()
        If Not String.IsNullOrEmpty(studentName) Then
            con.Open()
            Dim command As New SqlCommand("SELECT studentid FROM issue WHERE Name = @Name", con)
            command.Parameters.AddWithValue("@Name", studentName)

            Dim reader As SqlDataReader = command.ExecuteReader()
            If reader.HasRows Then
                reader.Read()
                ComboBox2.SelectedItem = reader("studentid").ToString()
            Else
                ComboBox2.SelectedItem = Nothing
            End If

            reader.Close()
            con.Close()
        Else
            ComboBox2.SelectedItem = Nothing
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim bookName As String = TextBox2.Text.Trim()
        If Not String.IsNullOrEmpty(bookName) Then
            con.Open()
            Dim command As New SqlCommand("SELECT bookid FROM issue WHERE bookname = @bookname", con)
            command.Parameters.AddWithValue("@bookname", bookName)

            Dim reader As SqlDataReader = command.ExecuteReader()
            If reader.HasRows Then
                reader.Read()
                ComboBox1.SelectedItem = reader("bookid").ToString()
            Else
                ComboBox1.SelectedItem = Nothing
            End If

            reader.Close()
            con.Close()
        Else
            ComboBox1.SelectedItem = Nothing
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Collegeui.Show()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        GetData1()
        Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        ComboBox2.Text = row.Cells(1).Value.ToString()
        TextBox4.Text = row.Cells(2).Value.ToString()
        ComboBox1.Text = row.Cells(3).Value.ToString()
        TextBox2.Text = row.Cells(4).Value.ToString()

        Dim dateString As String = row.Cells(5).Value.ToString()
        Dim dateString1 As String = row.Cells(6).Value.ToString()
        Dim dateValue As Date
        If Date.TryParse(dateString, dateValue) Then
            DateTimePicker1.Value = dateValue
        End If

        If ComboBox2.Text = " " Then
            key = 0
        Else
            Dim cellValue As String = row.Cells(0).Value.ToString()
            'Integer.TryParse(cellValue, key)
        End If
        If Date.TryParse(dateString1, dateValue) Then
            DateTimePicker2.Value = dateValue
        End If

        If ComboBox2.Text = " " Then
            key = 0
        Else
            Dim cellValue As String = row.Cells(0).Value.ToString()
            'Integer.TryParse(cellValue, key)
        End If
    End Sub
    Private Sub GetData1()
        Using con As New SqlConnection("Data Source=KAPIL;Initial Catalog=LibraryManagement;Integrated Security=True")
            Dim command As New SqlCommand("SELECT * FROM breturn", con)


            Dim adapter As New SqlDataAdapter(command)
            Dim dataTable As New DataTable()

            adapter.Fill(dataTable)

            DataGridView1.DataSource = dataTable
        End Using
    End Sub
    Private Sub insert_Click(sender As Object, e As EventArgs) Handles insert.Click
        Try
            con.Open()
            Using command As New SqlCommand("[dbo].[usp_I_breturn]", con)
                command.Parameters.AddWithValue("@studentid", ComboBox2.Text())
                command.Parameters.AddWithValue("@Name", TextBox4.Text())
                command.Parameters.AddWithValue("@bookid", ComboBox1.Text())
                command.Parameters.AddWithValue("@bookname", TextBox2.Text())
                command.Parameters.AddWithValue("@issuedate", DateTimePicker1.Value())
                command.Parameters.AddWithValue("@returndate", DateTimePicker2.Value())
                command.Parameters.AddWithValue("@fine", TextBox3.Text())
                command.CommandType = CommandType.StoredProcedure
                command.ExecuteNonQuery()
            End Using
            GetData1()
            Using removeCommand As New SqlCommand("DELETE FROM issue WHERE studentid = @studentid AND bookid = @bookid", con)
                removeCommand.Parameters.AddWithValue("@studentid", ComboBox2.Text())
                removeCommand.Parameters.AddWithValue("@Name", TextBox4.Text())
                removeCommand.Parameters.AddWithValue("@bookid", ComboBox1.Text())
                removeCommand.Parameters.AddWithValue("@bookname", TextBox2.Text())
                removeCommand.Parameters.AddWithValue("@issuedate", DateTimePicker1.Value())
                removeCommand.ExecuteNonQuery()
            End Using
            Dim updateStockCommand As New SqlCommand("UPDATE stock SET quantity = quantity + 1 WHERE bookid = @bookid", con)
            updateStockCommand.Parameters.AddWithValue("@bookid", ComboBox1.Text())
            updateStockCommand.ExecuteNonQuery()

            GetData()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        Finally
            con.Close()
        End Try
    End Sub



    Private Sub calculate_Click(sender As Object, e As EventArgs) Handles calculate.Click
        Dim issueDate As DateTime = DateTimePicker1.Value
        Dim returnDate As DateTime = DateTimePicker2.Value
        Dim finePerDay As Decimal = Decimal.Parse(TextBox1.Text)
        Dim fineNotCountedDays As Integer = Integer.Parse(TextBox5.Text)

        Dim totalFine As Decimal = 0

        Dim differenceInDays As Integer = (returnDate - issueDate).Days
        If differenceInDays > fineNotCountedDays Then
            Dim fineDays As Integer = differenceInDays - fineNotCountedDays
            totalFine = fineDays * finePerDay
        End If

        TextBox3.Text = totalFine.ToString()
    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub update_Click(sender As Object, e As EventArgs) Handles update.Click
        Try
            con.Open()
            Using command As New SqlCommand("[dbo].[usp_u_breturn]", con)
                command.Parameters.AddWithValue("@studentid", ComboBox2.Text())
                command.Parameters.AddWithValue("@Name", TextBox4.Text())
                command.Parameters.AddWithValue("@bookid", ComboBox1.Text())
                command.Parameters.AddWithValue("@bookname", TextBox2.Text())
                command.Parameters.AddWithValue("@issuedate", DateTimePicker1.Value())
                command.Parameters.AddWithValue("@returndate", DateTimePicker2.Value())
                command.Parameters.AddWithValue("@fine", TextBox3.Text())
                command.CommandType = CommandType.StoredProcedure
                command.ExecuteNonQuery()
            End Using
            GetData1()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        Try
            con.Open()

            Using command As New SqlCommand("[dbo].[usp_d_breturn]", con)
                command.Parameters.AddWithValue("@studentid", ComboBox2.Text())
                command.Parameters.AddWithValue("@Name", TextBox4.Text())
                command.Parameters.AddWithValue("@bookid", ComboBox1.Text())
                command.Parameters.AddWithValue("@bookname", TextBox2.Text())
                command.CommandType = CommandType.StoredProcedure
                command.ExecuteNonQuery()
            End Using
            GetData1()
        Catch ex As Exception
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class
