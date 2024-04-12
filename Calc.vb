Public Class Calc
    Private Sub Calc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.Add("+")
        ComboBox1.Items.Add("-")
        ComboBox1.Items.Add("*")
        ComboBox1.Items.Add("/")
    End Sub

    Private Sub calcButton_Click(sender As Object, e As EventArgs) Handles calcButton.Click
        Dim judge As Boolean = True
        judge = textAdd()

        Select Case ComboBox1.SelectedItem
            Case "+"
                If judge = True Then
                    Label2.Text = Integer.Parse(numBox1.Text) + Integer.Parse(numBox2.Text)
                Else
                    Label2.Text = numBox1.Text + numBox2.Text
                End If
            Case "-"
                If judge = True Then
                    Label2.Text = Integer.Parse(numBox1.Text) - Integer.Parse(numBox2.Text)
                Else
                    Label2.Text = numBox1.Text + numBox2.Text
                End If
            Case "*"
                If judge = True Then
                    Label2.Text = Integer.Parse(numBox1.Text) * Integer.Parse(numBox2.Text)
                Else
                    Label2.Text = numBox1.Text + numBox2.Text
                End If
            Case "/"
                If judge = True Then
                    Label2.Text = Integer.Parse(numBox1.Text) / Integer.Parse(numBox2.Text)
                Else
                    Label2.Text = numBox1.Text + numBox2.Text
                End If
        End Select


    End Sub

    Function textAdd()
        Dim num As Integer

        '文字変換判定
        If Integer.TryParse(numBox1.Text, num) = False Then
            Return False
        End If
        If Integer.TryParse(numBox2.Text, num) = False Then

            Return False
        End If

        If Integer.TryParse(numBox2.Text, num) >= 999 Then
            Return False
        End If

        If Integer.TryParse(numBox1.Text, num) >= 999 Then
            Return False
        End If

        '変換可
        Return True
    End Function


End Class
