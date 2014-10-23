Imports Oracle.DataAccess.Client

Public Class Form3
    Dim connection As New OracleConnection
    Dim da As OracleDataAdapter
    Dim t As New DataTable
    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Form3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Enter a string")
        Else
            connection = New OracleConnection("Data Source=XE;User Id=admins;password=password")
            connection.Open()
            da = New OracleDataAdapter("select * from ITsearch where name LIKE '%" & (TextBox1.Text) & "%'", connection)
            t = New DataTable()
            da.Fill(t)
            DataGridView1.DataSource = t
            connection.Close()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim semester As Integer

        'This is for Subject
        If TextBox3.Text = "" And TextBox4.Text = "" And TextBox6.Text = "" Then
            connection = New OracleConnection("Data Source=XE;User Id=admins;password=password")
            connection.Open()
            da = New OracleDataAdapter("select * from ITsearch where subject = '" & (TextBox2.Text) & "'", connection)
            t = New DataTable()
            da.Fill(t)
            DataGridView1.DataSource = t
            connection.Close()
        End If

        'This is for branch
        If TextBox2.Text = "" And TextBox4.Text = "" And TextBox6.Text = "" Then
            connection = New OracleConnection("Data Source=XE;User Id=admins;password=password")
            connection.Open()
            da = New OracleDataAdapter("select * from ITsearch where branch = '" & (TextBox3.Text) & "'", connection)
            t = New DataTable()
            da.Fill(t)
            DataGridView1.DataSource = t
            connection.Close()
        End If

        'This is sem
        If TextBox2.Text = "" And TextBox3.Text = "" And TextBox6.Text = "" Then
            semester = CInt(TextBox4.Text)
            connection = New OracleConnection("Data Source=XE;User Id=admins;password=password")
            connection.Open()
            da = New OracleDataAdapter("select * from ITsearch where semester = " & (TextBox4.Text), connection)
            t = New DataTable()
            da.Fill(t)
            DataGridView1.DataSource = t
            connection.Close()
        End If

        'This is year
        If TextBox2.Text = "" And TextBox3.Text = "" And TextBox4.Text = "" Then
            semester = CInt(TextBox6.Text)
            connection = New OracleConnection("Data Source=XE;User Id=admins;password=password")
            connection.Open()
            da = New OracleDataAdapter("select * from ITsearch where year = " & (TextBox6.Text), connection)
            t = New DataTable()
            da.Fill(t)
            DataGridView1.DataSource = t
            connection.Close()
        End If
    End Sub

    Private Sub TextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox6_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox6.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub
End Class