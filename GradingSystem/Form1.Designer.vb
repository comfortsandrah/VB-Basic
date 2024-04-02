<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        Label4 = New Label()
        Panel2 = New Panel()
        Panel4 = New Panel()
        GetAverageBtn = New Button()
        ResetBtn = New Button()
        Mark3 = New TextBox()
        Mark4 = New TextBox()
        Mark2 = New TextBox()
        Mark1 = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        subjectOne = New Label()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        Panel4.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(911, 635)
        Panel1.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.BackColor = Color.Aqua
        Label4.Dock = DockStyle.Top
        Label4.Font = New Font("Verdana", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(0, 0)
        Label4.MinimumSize = New Size(0, 75)
        Label4.Name = "Label4"
        Label4.Size = New Size(911, 75)
        Label4.TabIndex = 15
        Label4.Text = "Grading System"
        Label4.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel2
        ' 
        Panel2.Controls.Add(Panel4)
        Panel2.Controls.Add(Mark3)
        Panel2.Controls.Add(Mark4)
        Panel2.Controls.Add(Mark2)
        Panel2.Controls.Add(Mark1)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label2)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(subjectOne)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(0, 0)
        Panel2.Margin = New Padding(0)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(250, 120, 250, 50)
        Panel2.Size = New Size(911, 635)
        Panel2.TabIndex = 10
        ' 
        ' Panel4
        ' 
        Panel4.Controls.Add(GetAverageBtn)
        Panel4.Controls.Add(ResetBtn)
        Panel4.Location = New Point(260, 439)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(431, 91)
        Panel4.TabIndex = 14
        ' 
        ' GetAverageBtn
        ' 
        GetAverageBtn.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Right
        GetAverageBtn.BackColor = Color.Aqua
        GetAverageBtn.Font = New Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        GetAverageBtn.Location = New Point(260, 0)
        GetAverageBtn.Name = "GetAverageBtn"
        GetAverageBtn.Size = New Size(171, 79)
        GetAverageBtn.TabIndex = 12
        GetAverageBtn.Text = "Get Average"
        GetAverageBtn.UseVisualStyleBackColor = False
        ' 
        ' ResetBtn
        ' 
        ResetBtn.BackColor = Color.Salmon
        ResetBtn.Font = New Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ResetBtn.Location = New Point(0, 3)
        ResetBtn.Name = "ResetBtn"
        ResetBtn.Size = New Size(143, 76)
        ResetBtn.TabIndex = 11
        ResetBtn.Text = "Reset"
        ResetBtn.UseVisualStyleBackColor = False
        ' 
        ' Mark3
        ' 
        Mark3.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Mark3.Font = New Font("Verdana", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Mark3.Location = New Point(591, 285)
        Mark3.MaximumSize = New Size(100, 50)
        Mark3.MinimumSize = New Size(100, 50)
        Mark3.Name = "Mark3"
        Mark3.PlaceholderText = "0"
        Mark3.Size = New Size(100, 42)
        Mark3.TabIndex = 9
        Mark3.TextAlign = HorizontalAlignment.Right
        ' 
        ' Mark4
        ' 
        Mark4.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Mark4.Font = New Font("Verdana", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Mark4.Location = New Point(591, 354)
        Mark4.MaximumSize = New Size(100, 50)
        Mark4.MinimumSize = New Size(100, 50)
        Mark4.Name = "Mark4"
        Mark4.PlaceholderText = "0"
        Mark4.Size = New Size(100, 42)
        Mark4.TabIndex = 8
        Mark4.TextAlign = HorizontalAlignment.Right
        ' 
        ' Mark2
        ' 
        Mark2.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        Mark2.Font = New Font("Verdana", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Mark2.Location = New Point(591, 214)
        Mark2.MaximumSize = New Size(100, 50)
        Mark2.MinimumSize = New Size(100, 50)
        Mark2.Name = "Mark2"
        Mark2.PlaceholderText = "0"
        Mark2.Size = New Size(100, 42)
        Mark2.TabIndex = 7
        Mark2.TextAlign = HorizontalAlignment.Right
        ' 
        ' Mark1
        ' 
        Mark1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left
        Mark1.Font = New Font("Verdana", 14F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Mark1.Location = New Point(591, 138)
        Mark1.MaximumSize = New Size(100, 50)
        Mark1.MinimumSize = New Size(100, 50)
        Mark1.Name = "Mark1"
        Mark1.PlaceholderText = "0 "
        Mark1.Size = New Size(100, 42)
        Mark1.TabIndex = 5
        Mark1.TextAlign = HorizontalAlignment.Right
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BorderStyle = BorderStyle.FixedSingle
        Label3.FlatStyle = FlatStyle.System
        Label3.Font = New Font("Verdana", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(260, 354)
        Label3.MinimumSize = New Size(250, 50)
        Label3.Name = "Label3"
        Label3.Size = New Size(250, 50)
        Label3.TabIndex = 4
        Label3.Text = "Subject Four"
        Label3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BorderStyle = BorderStyle.FixedSingle
        Label2.FlatStyle = FlatStyle.System
        Label2.Font = New Font("Verdana", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(260, 285)
        Label2.MinimumSize = New Size(250, 50)
        Label2.Name = "Label2"
        Label2.Size = New Size(250, 50)
        Label2.TabIndex = 3
        Label2.Text = "Subject Three"
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BorderStyle = BorderStyle.FixedSingle
        Label1.FlatStyle = FlatStyle.System
        Label1.Font = New Font("Verdana", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(260, 214)
        Label1.MinimumSize = New Size(250, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(250, 50)
        Label1.TabIndex = 2
        Label1.Text = "Subject Two"
        Label1.TextAlign = ContentAlignment.TopCenter
        ' 
        ' subjectOne
        ' 
        subjectOne.AutoSize = True
        subjectOne.BorderStyle = BorderStyle.FixedSingle
        subjectOne.FlatStyle = FlatStyle.System
        subjectOne.Font = New Font("Verdana", 14F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        subjectOne.Location = New Point(260, 138)
        subjectOne.MinimumSize = New Size(250, 50)
        subjectOne.Name = "subjectOne"
        subjectOne.Size = New Size(250, 50)
        subjectOne.TabIndex = 0
        subjectOne.Text = "Subject One"
        subjectOne.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(911, 635)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        Panel4.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents subjectOne As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Mark2 As TextBox
    Friend WithEvents Mark1 As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Mark3 As TextBox
    Friend WithEvents Mark4 As TextBox
    Friend WithEvents ResetBtn As Button
    Friend WithEvents GetAverageBtn As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label4 As Label

End Class
