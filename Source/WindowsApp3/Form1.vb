Public Class Calculator
    Dim F As Double = 229
    Dim S, R As Double
    Dim Opt As String

    Private Sub Numbers(sender As Object, e As EventArgs) Handles two.Click, three.Click, six.Click, seven.Click, one.Click, nine.Click, four.Click, five.Click, eight.Click, zero.Click, dot.Click
        Dim B As Button = sender

        If (Textbox1.Text = "0") Then
            Textbox1.Clear()
            Textbox1.Text = B.Text
        ElseIf (B.Text = ".") Then
            If (Not Textbox1.Text.Contains(".")) Then
                Textbox1.Text = Textbox1.Text + B.Text
            End If
        Else
            Textbox1.Text = Textbox1.Text + B.Text
        End If
    End Sub

    Private Sub Operators(sender As Object, e As EventArgs) Handles Subtraction.Click, Multiplication.Click, Division.Click, Addition.Click
        Dim B As Button = sender
        If F = 229 Then
            F = Convert.ToDouble(Textbox1.Text)
            Opt = B.Text
            Textbox1.Text = ""
        Else
            S = Convert.ToDouble(Textbox1.Text)
            If Opt = "+" Then
                F = F + S
            ElseIf Opt = "-" Then
                F = F - S
            ElseIf Opt = "x" Then
                F = F * S
            ElseIf Opt = "÷" Then
                F = F / S
            Else
                F = F / 100
            End If
            Textbox1.Text = ""
            Opt = B.Text
        End If
    End Sub

    Private Sub Result_Click(sender As Object, e As EventArgs) Handles Result.Click
        S = Convert.ToDouble(Textbox1.Text)

        If Opt = "+" Then
            R = F + S
            Textbox1.Text = Convert.ToDouble(R)
        ElseIf Opt = "-" Then
            R = F - S
            Textbox1.Text = Convert.ToDouble(R)
        ElseIf Opt = "x" Then
            R = F * S
            Textbox1.Text = Convert.ToDouble(R)
        ElseIf Opt = "÷" Then
            R = F / S
            Textbox1.Text = Convert.ToDouble(R)
        Else
            R = F / 100
            Textbox1.Text = Convert.ToDouble(R)
        End If
    End Sub

    Private Sub Percentage_Click(sender As Object, e As EventArgs) Handles Percentage.Click
        F = Val(Textbox1.Text)
        Opt = "%"
    End Sub

    Private Sub AorS_Click(sender As Object, e As EventArgs) Handles AorS.Click
        Dim AorS As Double
        AorS = Convert.ToDouble(Textbox1.Text)
        Textbox1.Text = Convert.ToString(-1 * AorS)
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        If Textbox1.Text > 0 Then
            Textbox1.Text = Textbox1.Text.Remove(Textbox1.Text.Length - 1, 1)

        End If

        If Textbox1.Text = "" Then
            Textbox1.Text = ""
        End If
    End Sub

    Private Sub Textbox1_TextChanged(sender As Object, e As EventArgs) Handles Textbox1.TextChanged

    End Sub

    Private Sub Clear_Click(sender As Object, e As EventArgs) Handles Clear.Click
        Textbox1.Clear()
        Dim Fn, Sn As String
        Fn = Convert.ToString(F)
        Sn = Convert.ToString(S)

        F = 229
        Sn = ""
    End Sub

End Class
