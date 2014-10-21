Public Class Form2

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim text1, text2 As String
        text1 = TextBox1.Text
        text2 = MaskedTextBox1.Text
        If text1 = "admin" And text2 = "1234" Then
            Form3.Show()
            Me.Close()
        Else
            MsgBox("Invalid Username or Password")
        End If

    End Sub

    Private Sub MaskedTextBox1_MaskInputRejected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MaskInputRejectedEventArgs) Handles MaskedTextBox1.MaskInputRejected

    End Sub
End Class