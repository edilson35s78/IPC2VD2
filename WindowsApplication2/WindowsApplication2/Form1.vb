Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub op1_Click(sender As Object, e As EventArgs) Handles op1.Click
        resu.Text = (TextBox2.Text * TextBox1.Text ^ TextBox3.Text).ToString

    End Sub

    Private Sub op2_Click(sender As Object, e As EventArgs) Handles op2.Click
        resu.Text = ((TextBox3.Text - TextBox1.Text) / TextBox1.Text * TextBox2.Text).ToString
    End Sub

    Private Sub Op3_Click(sender As Object, e As EventArgs) Handles Op3.Click
        resu.Text = ((TextBox2.Text) ^ (1 / 2) - (TextBox1.Text * TextBox3.Text) ^ (1 / 2)).ToString

    End Sub

    Private Sub op4_Click(sender As Object, e As EventArgs) Handles op4.Click
        resu.Text = (((TextBox1.Text) ^ (-1 * TextBox2.Text) + TextBox1.Text ^ (TextBox2.Text)) / TextBox3.Text).ToString

    End Sub
End Class
