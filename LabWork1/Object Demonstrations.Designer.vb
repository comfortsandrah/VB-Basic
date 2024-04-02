<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Object_Demonstrations
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        TextBox1 = New TextBox()
        DisplayTest = New GroupBox()
        FontGroupBox = New GroupBox()
        Tahoma = New RadioButton()
        MagnetoBtn = New RadioButton()
        GaramondBtn = New RadioButton()
        PictureBox1 = New PictureBox()
        FontStyleGroupBox = New GroupBox()
        CheckedListBox1 = New CheckedListBox()
        LoadBtn = New Button()
        ExitBtn = New Button()
        Panel1 = New Panel()
        Label1 = New Label()
        RedBtn = New RadioButton()
        BlueBtn = New RadioButton()
        GreenBtn = New RadioButton()
        FontColorGroupBox = New GroupBox()
        DisplayTest.SuspendLayout()
        FontGroupBox.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        FontStyleGroupBox.SuspendLayout()
        Panel1.SuspendLayout()
        FontColorGroupBox.SuspendLayout()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(24, 35)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(279, 59)
        TextBox1.TabIndex = 0
        ' 
        ' DisplayTest
        ' 
        DisplayTest.Controls.Add(TextBox1)
        DisplayTest.FlatStyle = FlatStyle.Flat
        DisplayTest.Location = New Point(22, 95)
        DisplayTest.Name = "DisplayTest"
        DisplayTest.Size = New Size(325, 115)
        DisplayTest.TabIndex = 1
        DisplayTest.TabStop = False
        DisplayTest.Text = "Display Test"
        ' 
        ' FontGroupBox
        ' 
        FontGroupBox.Controls.Add(Tahoma)
        FontGroupBox.Controls.Add(MagnetoBtn)
        FontGroupBox.Controls.Add(GaramondBtn)
        FontGroupBox.Location = New Point(368, 95)
        FontGroupBox.Name = "FontGroupBox"
        FontGroupBox.Size = New Size(594, 115)
        FontGroupBox.TabIndex = 2
        FontGroupBox.TabStop = False
        FontGroupBox.Text = "Font"
        ' 
        ' Tahoma
        ' 
        Tahoma.AutoSize = True
        Tahoma.Location = New Point(316, 52)
        Tahoma.Name = "Tahoma"
        Tahoma.Size = New Size(99, 29)
        Tahoma.TabIndex = 2
        Tahoma.TabStop = True
        Tahoma.Text = "Tahoma"
        Tahoma.UseVisualStyleBackColor = True
        ' 
        ' MagnetoBtn
        ' 
        MagnetoBtn.AutoSize = True
        MagnetoBtn.Location = New Point(188, 52)
        MagnetoBtn.Name = "MagnetoBtn"
        MagnetoBtn.Size = New Size(109, 29)
        MagnetoBtn.TabIndex = 1
        MagnetoBtn.TabStop = True
        MagnetoBtn.Text = "Magneto"
        MagnetoBtn.UseVisualStyleBackColor = True
        ' 
        ' GaramondBtn
        ' 
        GaramondBtn.AutoSize = True
        GaramondBtn.Location = New Point(51, 52)
        GaramondBtn.Name = "GaramondBtn"
        GaramondBtn.Size = New Size(121, 29)
        GaramondBtn.TabIndex = 0
        GaramondBtn.TabStop = True
        GaramondBtn.Text = "Garamond"
        GaramondBtn.UseVisualStyleBackColor = True
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Location = New Point(36, 227)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(359, 233)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' FontStyleGroupBox
        ' 
        FontStyleGroupBox.Controls.Add(CheckedListBox1)
        FontStyleGroupBox.Location = New Point(462, 227)
        FontStyleGroupBox.Name = "FontStyleGroupBox"
        FontStyleGroupBox.Size = New Size(243, 233)
        FontStyleGroupBox.TabIndex = 4
        FontStyleGroupBox.TabStop = False
        FontStyleGroupBox.Text = "Font Style"
        ' 
        ' CheckedListBox1
        ' 
        CheckedListBox1.BackColor = SystemColors.Menu
        CheckedListBox1.BorderStyle = BorderStyle.None
        CheckedListBox1.Font = New Font("Segoe UI", 9F)
        CheckedListBox1.FormattingEnabled = True
        CheckedListBox1.Items.AddRange(New Object() {"Italic", "Bold", "Bold Italic"})
        CheckedListBox1.Location = New Point(32, 42)
        CheckedListBox1.Name = "CheckedListBox1"
        CheckedListBox1.Size = New Size(191, 140)
        CheckedListBox1.TabIndex = 1
        ' 
        ' LoadBtn
        ' 
        LoadBtn.Location = New Point(109, 558)
        LoadBtn.Name = "LoadBtn"
        LoadBtn.Size = New Size(209, 75)
        LoadBtn.TabIndex = 6
        LoadBtn.Text = "Load Picture"
        LoadBtn.UseVisualStyleBackColor = True
        ' 
        ' ExitBtn
        ' 
        ExitBtn.Location = New Point(730, 562)
        ExitBtn.Name = "ExitBtn"
        ExitBtn.Size = New Size(195, 71)
        ExitBtn.TabIndex = 7
        ExitBtn.Text = "Exit"
        ExitBtn.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label1)
        Panel1.Location = New Point(2, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1289, 78)
        Panel1.TabIndex = 8
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Label1.Location = New Point(475, 22)
        Label1.Name = "Label1"
        Label1.Size = New Size(208, 25)
        Label1.TabIndex = 0
        Label1.Text = "Object Demonstrations"
        ' 
        ' RedBtn
        ' 
        RedBtn.AutoSize = True
        RedBtn.Location = New Point(29, 173)
        RedBtn.Name = "RedBtn"
        RedBtn.Size = New Size(67, 29)
        RedBtn.TabIndex = 3
        RedBtn.TabStop = True
        RedBtn.Text = "Red"
        RedBtn.UseVisualStyleBackColor = True
        ' 
        ' BlueBtn
        ' 
        BlueBtn.AutoSize = True
        BlueBtn.Location = New Point(29, 107)
        BlueBtn.Name = "BlueBtn"
        BlueBtn.Size = New Size(70, 29)
        BlueBtn.TabIndex = 4
        BlueBtn.TabStop = True
        BlueBtn.Text = "Blue"
        BlueBtn.UseVisualStyleBackColor = True
        ' 
        ' GreenBtn
        ' 
        GreenBtn.AutoSize = True
        GreenBtn.Location = New Point(29, 42)
        GreenBtn.Name = "GreenBtn"
        GreenBtn.Size = New Size(83, 29)
        GreenBtn.TabIndex = 5
        GreenBtn.TabStop = True
        GreenBtn.Text = "Green"
        GreenBtn.UseVisualStyleBackColor = True
        ' 
        ' FontColorGroupBox
        ' 
        FontColorGroupBox.Controls.Add(GreenBtn)
        FontColorGroupBox.Controls.Add(BlueBtn)
        FontColorGroupBox.Controls.Add(RedBtn)
        FontColorGroupBox.Location = New Point(730, 227)
        FontColorGroupBox.Name = "FontColorGroupBox"
        FontColorGroupBox.Size = New Size(232, 233)
        FontColorGroupBox.TabIndex = 5
        FontColorGroupBox.TabStop = False
        FontColorGroupBox.Text = "Font Color"
        ' 
        ' Object_Demonstrations
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1273, 652)
        Controls.Add(Panel1)
        Controls.Add(ExitBtn)
        Controls.Add(LoadBtn)
        Controls.Add(FontColorGroupBox)
        Controls.Add(FontStyleGroupBox)
        Controls.Add(PictureBox1)
        Controls.Add(FontGroupBox)
        Controls.Add(DisplayTest)
        Name = "Object_Demonstrations"
        Text = "Object_Demonstrations"
        DisplayTest.ResumeLayout(False)
        DisplayTest.PerformLayout()
        FontGroupBox.ResumeLayout(False)
        FontGroupBox.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        FontStyleGroupBox.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        FontColorGroupBox.ResumeLayout(False)
        FontColorGroupBox.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents DisplayTest As GroupBox
    Friend WithEvents FontGroupBox As GroupBox
    Friend WithEvents Tahoma As RadioButton
    Friend WithEvents MagnetoBtn As RadioButton
    Friend WithEvents GaramondBtn As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents FontStyleGroupBox As GroupBox
    Friend WithEvents LoadBtn As Button
    Friend WithEvents ExitBtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents RedBtn As RadioButton
    Friend WithEvents BlueBtn As RadioButton
    Friend WithEvents GreenBtn As RadioButton
    Friend WithEvents FontColorGroupBox As GroupBox
End Class
