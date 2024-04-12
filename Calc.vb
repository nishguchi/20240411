Public Class Calc
    Private Sub Calc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("+")
        ComboBox1.Items.Add("-")
        ComboBox1.Items.Add("*")
        ComboBox1.Items.Add("/")
    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        Select Case ComboBox1.SelectedItem
            Case "+"
                textAdd()
                Label2.Text = Integer.Parse(numBox1.Text) + Integer.Parse(numBox2.Text)
            Case "-"
                Label2.Text = Integer.Parse(numBox1.Text) - Integer.Parse(numBox2.Text)
            Case "*"
                Label2.Text = Integer.Parse(numBox1.Text) * Integer.Parse(numBox2.Text)
            Case "/"
                Label2.Text = Integer.Parse(numBox1.Text) / Integer.Parse(numBox2.Text)
        End Select
    End Sub

    Private Sub textAdd()
        Dim num As Integer
        If Not Integer.TryParse(num, numBox1.Text) And Integer.Parse(numBox2.Text) Then
            Label2.Text = numBox1.Text + numBox2.Text
        End If

    End Sub

End Class
