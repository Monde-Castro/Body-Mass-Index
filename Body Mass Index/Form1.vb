Public Class frmBMI

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear label and textboxes
        txtLength.Clear()
        txtWeight.Clear()
        lblUnderweight.Text = " "
        lblNormal.Text = " "
        lblOverweight.Text = " "
        lblObese.Text = " "

        txtWeight.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Declare variables
        Dim decMemberWeight As Decimal = 0
        Dim decMemberLength As Decimal = 0
        Dim decBMI As Decimal = 0

        'Input 
        decMemberLength = CDec(txtLength.Text)
        decMemberWeight = CDec(txtWeight.Text)

        'Processing
        'Calculate the body mass index
        decBMI = CDec(decMemberWeight / (decMemberLength / 100) ^ 2)

        If decBMI < 18 Then
            lblUnderweight.Text = "Underweight "
        Else
            lblUnderweight.Text = " "
        End If
        If (decBMI >= 18 And decBMI < 25) Then
            lblNormal.Text = "Normal "
        Else
            lblNormal.Text = " "
        End If
        If (decBMI >= 25 And decBMI < 30) Then
            lblOverweight.Text = " Overweight"
        Else
            lblOverweight.Text = " "
        End If
        If decBMI >= 30 Then
            lblObese.Text = " Obese"
        Else
            lblObese.Text = " "

        End If
    End Sub
End Class
