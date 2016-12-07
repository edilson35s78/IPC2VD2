Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub op1_Click(sender As Object, e As EventArgs) Handles op1.Click
        resu.Text = (TextBox2.Text * TextBox1.Text ^ TextBox3.Text).ToString

    End Sub

    Private Sub op2_Click(sender As Object, e As EventArgs) Handles op2.Click
        resu.Text = ((TextBox3.Text - TextBox1.Text) / TextBox1.Text * TextBox2.Text).ToString
    End Sub
End Class
