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
                    'textWords()
                End If
            Case "-"
                If judge = True Then
                    Label2.Text = Integer.Parse(numBox1.Text) - Integer.Parse(numBox2.Text)
                Else
                    'textWords()
                End If
            Case "*"
                If judge = True Then
                    Label2.Text = Integer.Parse(numBox1.Text) * Integer.Parse(numBox2.Text)
                Else
                    'textWords()
                End If
            Case "/"
                If judge = True Then
                    Label2.Text = Math.Round(Integer.Parse(numBox1.Text) / Integer.Parse(numBox2.Text), 4)
                Else
                    textWords()
                End If
            Case ""
                Label3.Text = "四則演算子を選択してください"
        End Select


    End Sub

    Function textAdd()
        Dim num As Integer

        Label3.Text = ""

        '文字変換判定
        If Integer.TryParse(numBox1.Text, num) = False And Integer.TryParse(numBox2.Text, num) = False Then
            textWords()
            Return False
        End If

        If Integer.TryParse(numBox1.Text, num) = False Then
            textWords()
            Return False
        End If
        If Integer.TryParse(numBox2.Text, num) = False Then
            textWords()
            Return False
        End If




        If Integer.Parse(numBox1.Text) < 0 And Integer.Parse(numBox2.Text) < 0 Then
            numBox1.Text = ""
            numBox2.Text = ""
            Label3.Text = "マイナス値は計算できません"
            Return False

        ElseIf Integer.Parse(numBox1.Text) < 0 Then
            numBox1.Text = ""
            Label3.Text = "マイナス値は計算できません"
            Return False

        ElseIf Integer.Parse(numBox2.Text) < 0 Then
            numBox2.Text = ""
            Label3.Text = "マイナス値は計算できません"
            Return False
        End If



        '変換可
        Return True
    End Function


    Private Sub textWords()

        '空か判定
        If numBox1.Text = "" Or numBox2.Text = "" Then
            Label3.Text = "入力値が空です"
            'メソッドを抜ける
            Exit Sub
        End If

        '数字同士以外の組み合わせ
        '文字列連結
        Label2.Text = numBox1.Text + numBox2.Text
        Label3.Text = "入力値が数字ではありません"

    End Sub


End Class
