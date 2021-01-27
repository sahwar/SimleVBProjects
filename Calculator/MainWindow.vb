Public Class MainWindow

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As Double
        Double.TryParse(TextBox1.Text, a)
        Dim b As Double
        Double.TryParse(TextBox2.Text, b)
        Dim c As Double = a + b
        TextBox3.Text = Str(c)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a As Double
        Double.TryParse(TextBox1.Text, a)
        Dim b As Double
        Double.TryParse(TextBox2.Text, b)
        Dim c As Double = a - b
        TextBox3.Text = Str(c)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim a As Double
        Double.TryParse(TextBox1.Text, a)
        Dim b As Double
        Double.TryParse(TextBox2.Text, b)
        Dim c As Double = a * b
        TextBox3.Text = Str(c)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim a As Double
        Double.TryParse(TextBox1.Text, a)
        Dim b As Double
        Double.TryParse(TextBox2.Text, b)
        Dim c As Double = a / b
        TextBox3.Text = Str(c)
    End Sub

End Class

