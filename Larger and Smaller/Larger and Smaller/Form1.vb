Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim intA As Integer
        Dim intB As Integer
        intA = CInt(txtA.Text)
        intB = CInt(txtB.Text)

        ' say there equal
        If intA = intB Then
            lblResult.Text = "They are Equal"

        ElseIf intA > intB Then

            lblResult.Text = "Integer A is the Larger Number"

        ElseIf intA < intB Then
            lblResult.Text = "Integer B is the Larger Number"


        End If


    End Sub
End Class
