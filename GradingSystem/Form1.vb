Imports System.Numerics
Imports System.Runtime.Intrinsics.X86
Imports System.Windows

Public Class Form1
    Private Sub GetAverageBtn_Click(sender As Object, e As EventArgs) Handles GetAverageBtn.Click
        Dim Mk1 As Double = Double.Parse(Mark1.Text)
        Dim Mk2 As Double = Double.Parse(Mark2.Text)
        Dim Mk3 As Double = Double.Parse(Mark3.Text)
        Dim Mk4 As Double = Double.Parse(Mark4.Text)
        Dim total, average As Double
        Dim grade As String = ""


        total = Mk1 + Mk2 + Mk3 + Mk4
        average = total / 4

        If (average >= 75 And average <= 100) Then
            grade = "A"
        ElseIf (average >= 65) Then
            grade = "B"
        ElseIf (average >= 50) Then
            grade = "C"
        ElseIf (average >= 0) Then
            grade = "Fail"
        Else
            MessageBox.Show("Invalid")
            Return
        End If

        MessageBox.Show(String.Format("Your average marks is {0} and your grade is {1}", average, grade))
    End Sub

    Private Sub Mark1_Text_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Mark1.Validating
        Dim Mk1 As Double

        If Not Double.TryParse(Mark1.Text, Mk1) Then
            MessageBox.Show("Please enter a valid Mark.")
            Mark1.Text = ""
            e.Cancel = True
        ElseIf Mk1 < 0 Then
            MessageBox.Show("Marks cannot be negative. Please enter a valid mark.")
            Mark1.Text = ""
            e.Cancel = True
        ElseIf Mk1 > 100 Then
            MessageBox.Show("Marks cannot exceed 100. Please enter a valid mark.")
            Mark1.Text = ""
            e.Cancel = True
        End If
    End Sub

    Private Sub Mark2_Text_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Mark3.Validating
        Dim Mk2 As Double

        If Not Double.TryParse(Mark2.Text, Mk2) Then
            MessageBox.Show("Please enter a valid Mark.")
            Mark2.Text = ""
            e.Cancel = True
        ElseIf Mk2 < 0 Then
            MessageBox.Show("Marks cannot be negative. Please enter a valid mark.")
            Mark2.Text = ""
            e.Cancel = True
        ElseIf Mk2 > 100 Then
            MessageBox.Show("Marks cannot exceed 100. Please enter a valid mark.")
            Mark2.Text = ""
            e.Cancel = True
        End If
    End Sub

    Private Sub Mark3_Text_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs)
        Dim Mk3 As Double

        If Not Double.TryParse(Mark3.Text, Mk3) Then
            MessageBox.Show("Please enter a valid Mark.")
            Mark3.Text = ""
            e.Cancel = True
        ElseIf Mk3 < 0 Then
            MessageBox.Show("Marks cannot be negative. Please enter a valid mark.")
            Mark3.Text = ""
            e.Cancel = True
        ElseIf Mk3 > 100 Then
            MessageBox.Show("Marks cannot exceed 100. Please enter a valid mark.")
            Mark3.Text = ""
            e.Cancel = True
        End If
    End Sub

    Private Sub Mark4_Text_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Mark4.Validating
        Dim Mk4 As Double

        If Not Double.TryParse(Mark4.Text, Mk4) Then
            MessageBox.Show("Please enter a valid Mark.")
            Mark4.Text = ""
            e.Cancel = True
        ElseIf Mk4 < 0 Then
            MessageBox.Show("Mark4 cannot be negative. Please enter a valid mark.")
            Mark4.Text = ""
            e.Cancel = True
        ElseIf Mk4 > 100 Then
            MessageBox.Show("Mark4 cannot exceed 100. Please enter a valid mark.")
            Mark4.Text = ""
            e.Cancel = True
        End If
    End Sub

    Private Sub ResetBtn_Click(sender As Object, e As EventArgs) Handles ResetBtn.Click
        ' Clear the contents of Mark1 text box
        Mark1.Text = ""

        ' Clear the contents of Mark2 text box
        Mark2.Text = ""

        ' Clear the contents of Mark3 text box
        Mark3.Text = ""

        ' Clear the contents of Mark4 text box
        Mark4.Text = ""
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
End Class
