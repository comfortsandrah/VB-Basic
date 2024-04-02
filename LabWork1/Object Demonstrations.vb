Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Object_Demonstrations
    Private Sub Object_Demonstrations_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles DisplayTest.Enter


    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles FontColorGroupBox.Enter

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged


    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles GreenBtn.CheckedChanged
        TextBox1.ForeColor = Color.Green
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RedBtn.CheckedChanged
        TextBox1.ForeColor = Color.Red
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Close()

    End Sub

    Private Sub LoadBtn_Click(sender As Object, e As EventArgs) Handles LoadBtn.Click
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files (*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG"
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim filePath As String = openFileDialog.FileName
            PictureBox1.Image = Image.FromFile(filePath)
        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub GaramondBtn_CheckedChanged(sender As Object, e As EventArgs) Handles GaramondBtn.CheckedChanged
        TextBox1.Font = New Font("Garamond", 12, FontStyle.Regular)
    End Sub

    Private Sub RadioBtn2_CheckedChanged(sender As Object, e As EventArgs) Handles MagnetoBtn.CheckedChanged
        TextBox1.Font = New Font("Magneto", 12, FontStyle.Regular)
    End Sub

    Private Sub RadioBtn3_CheckedChanged(sender As Object, e As EventArgs) Handles Tahoma.CheckedChanged
        TextBox1.Font = New Font("Tahoma", 12, FontStyle.Regular)
    End Sub

    Private Sub BlueBtn_CheckedChanged(sender As Object, e As EventArgs) Handles BlueBtn.CheckedChanged
        TextBox1.ForeColor = Color.Blue
    End Sub
End Class