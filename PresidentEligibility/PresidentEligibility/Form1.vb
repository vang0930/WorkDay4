Option Strict On

Public Class Form1
    '1/21/1982


    Private Sub btnEligibility_Click(sender As System.Object, e As System.EventArgs) Handles btnEligibility.Click


        If (radBornYes.Checked = True) And (radResidentYes.Checked = True) And (IsDate(txtBirthDay.Text) = True) Then
            Dim req As Date = #1/21/1982 12:01:00 AM#
            '''''''''''''''''''''''''''''''''''''''
            If (IsDate(txtBirthDay.Text) = True) And (CDate(txtBirthDay.Text) <= req) Then
                txtEligibleResult.Text = "Congratulations, you are eligible to be President!"
            Else
                txtEligibleResult.Text = "Sorry, you are not eligible to be the President."
            End If
            '''''''''''''''''''''''''''''''''''''''
        ElseIf (IsDate(txtBirthDay.Text) = False) Then
            MessageBox.Show("Please enter in a valid birthdate.")
        Else
            txtEligibleResult.Text = "Sorry, you are not eligible to be the President."
        End If


    End Sub


End Class