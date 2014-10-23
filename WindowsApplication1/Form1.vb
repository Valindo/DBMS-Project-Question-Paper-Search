Imports Oracle.DataAccess.Client

Public Class Form1
    Dim connection As New OracleConnection
    Dim da As OracleDataAdapter
    Dim t As New DataTable

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Form2.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' connection = New OracleConnection("Data Source=XE;User Id=admins;password=password")
        'connection.Open()
        'da = New OracleDataAdapter("select * from Qsearch", connection)
        't = New DataTable()
        'da.Fill(t)
        'DataGridView1.DataSource = t
        'connection.Close()

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Form2.Show()

    End Sub

    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form3.Show()
    End Sub
End Class
