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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.pictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LangSelector = New System.Windows.Forms.ComboBox()
        Me.BrowseModels = New System.Windows.Forms.Button()
        Me.VoteNo = New System.Windows.Forms.RadioButton()
        Me.VoteYes = New System.Windows.Forms.RadioButton()
        Me.textBox7 = New System.Windows.Forms.TextBox()
        Me.ModelText = New System.Windows.Forms.TextBox()
        Me.textBox5 = New System.Windows.Forms.TextBox()
        Me.textBox3 = New System.Windows.Forms.TextBox()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.jobvote = New System.Windows.Forms.Label()
        Me.jobcategory = New System.Windows.Forms.Label()
        Me.jobmodels = New System.Windows.Forms.Label()
        Me.jobsalary = New System.Windows.Forms.Label()
        Me.jobweapons = New System.Windows.Forms.Label()
        Me.jobname = New System.Windows.Forms.Label()
        Me.teamname = New System.Windows.Forms.Label()
        Me.VoteResult = New System.Windows.Forms.Label()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.GenCode = New System.Windows.Forms.Button()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pictureBox1
        '
        Me.pictureBox1.BackgroundImage = Global.JobMaker.My.Resources.Models.icon175x175
        Me.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.pictureBox1.Location = New System.Drawing.Point(475, 335)
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.Size = New System.Drawing.Size(27, 27)
        Me.pictureBox1.TabIndex = 26
        Me.pictureBox1.TabStop = False
        '
        'LangSelector
        '
        Me.LangSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.LangSelector.Font = New System.Drawing.Font("Segoe Print", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LangSelector.FormattingEnabled = True
        Me.LangSelector.Items.AddRange(New Object() {"Русский", "English"})
        Me.LangSelector.Location = New System.Drawing.Point(505, 335)
        Me.LangSelector.Name = "LangSelector"
        Me.LangSelector.Size = New System.Drawing.Size(121, 27)
        Me.LangSelector.TabIndex = 25
        '
        'BrowseModels
        '
        Me.BrowseModels.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.BrowseModels.Location = New System.Drawing.Point(420, 197)
        Me.BrowseModels.Name = "BrowseModels"
        Me.BrowseModels.Size = New System.Drawing.Size(31, 29)
        Me.BrowseModels.TabIndex = 24
        Me.BrowseModels.Text = "..."
        Me.BrowseModels.UseVisualStyleBackColor = True
        '
        'VoteNo
        '
        Me.VoteNo.AutoSize = True
        Me.VoteNo.ForeColor = System.Drawing.Color.White
        Me.VoteNo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.VoteNo.Location = New System.Drawing.Point(566, 134)
        Me.VoteNo.Name = "VoteNo"
        Me.VoteNo.Size = New System.Drawing.Size(48, 17)
        Me.VoteNo.TabIndex = 21
        Me.VoteNo.TabStop = True
        Me.VoteNo.Text = "#NO"
        Me.VoteNo.UseVisualStyleBackColor = True
        '
        'VoteYes
        '
        Me.VoteYes.AutoSize = True
        Me.VoteYes.ForeColor = System.Drawing.Color.White
        Me.VoteYes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.VoteYes.Location = New System.Drawing.Point(507, 134)
        Me.VoteYes.Name = "VoteYes"
        Me.VoteYes.Size = New System.Drawing.Size(53, 17)
        Me.VoteYes.TabIndex = 22
        Me.VoteYes.TabStop = True
        Me.VoteYes.Text = "#YES"
        Me.VoteYes.UseVisualStyleBackColor = True
        '
        'textBox7
        '
        Me.textBox7.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.textBox7.Location = New System.Drawing.Point(457, 232)
        Me.textBox7.Name = "textBox7"
        Me.textBox7.Size = New System.Drawing.Size(157, 29)
        Me.textBox7.TabIndex = 16
        '
        'ModelText
        '
        Me.ModelText.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ModelText.Location = New System.Drawing.Point(457, 197)
        Me.ModelText.Name = "ModelText"
        Me.ModelText.Size = New System.Drawing.Size(157, 29)
        Me.ModelText.TabIndex = 17
        '
        'textBox5
        '
        Me.textBox5.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.textBox5.Location = New System.Drawing.Point(457, 162)
        Me.textBox5.Name = "textBox5"
        Me.textBox5.Size = New System.Drawing.Size(157, 29)
        Me.textBox5.TabIndex = 18
        '
        'textBox3
        '
        Me.textBox3.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.textBox3.Location = New System.Drawing.Point(457, 95)
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New System.Drawing.Size(157, 29)
        Me.textBox3.TabIndex = 15
        '
        'textBox2
        '
        Me.textBox2.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.textBox2.Location = New System.Drawing.Point(457, 60)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(157, 29)
        Me.textBox2.TabIndex = 19
        '
        'textBox1
        '
        Me.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.textBox1.Font = New System.Drawing.Font("Segoe Print", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.textBox1.Location = New System.Drawing.Point(457, 25)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(157, 29)
        Me.textBox1.TabIndex = 20
        '
        'jobvote
        '
        Me.jobvote.AutoSize = True
        Me.jobvote.Font = New System.Drawing.Font("Segoe Print", 10.0!, System.Drawing.FontStyle.Bold)
        Me.jobvote.ForeColor = System.Drawing.Color.White
        Me.jobvote.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.jobvote.Location = New System.Drawing.Point(12, 130)
        Me.jobvote.Name = "jobvote"
        Me.jobvote.Size = New System.Drawing.Size(77, 24)
        Me.jobvote.TabIndex = 12
        Me.jobvote.Text = "#JobVote"
        '
        'jobcategory
        '
        Me.jobcategory.AutoSize = True
        Me.jobcategory.Font = New System.Drawing.Font("Segoe Print", 10.0!, System.Drawing.FontStyle.Bold)
        Me.jobcategory.ForeColor = System.Drawing.Color.White
        Me.jobcategory.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.jobcategory.Location = New System.Drawing.Point(12, 233)
        Me.jobcategory.Name = "jobcategory"
        Me.jobcategory.Size = New System.Drawing.Size(108, 24)
        Me.jobcategory.TabIndex = 13
        Me.jobcategory.Text = "#JobCategory"
        '
        'jobmodels
        '
        Me.jobmodels.AutoSize = True
        Me.jobmodels.Font = New System.Drawing.Font("Segoe Print", 10.0!, System.Drawing.FontStyle.Bold)
        Me.jobmodels.ForeColor = System.Drawing.Color.White
        Me.jobmodels.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.jobmodels.Location = New System.Drawing.Point(12, 198)
        Me.jobmodels.Name = "jobmodels"
        Me.jobmodels.Size = New System.Drawing.Size(92, 24)
        Me.jobmodels.TabIndex = 14
        Me.jobmodels.Text = "#JobModels"
        '
        'jobsalary
        '
        Me.jobsalary.AutoSize = True
        Me.jobsalary.Font = New System.Drawing.Font("Segoe Print", 10.0!, System.Drawing.FontStyle.Bold)
        Me.jobsalary.ForeColor = System.Drawing.Color.White
        Me.jobsalary.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.jobsalary.Location = New System.Drawing.Point(12, 96)
        Me.jobsalary.Name = "jobsalary"
        Me.jobsalary.Size = New System.Drawing.Size(89, 24)
        Me.jobsalary.TabIndex = 10
        Me.jobsalary.Text = "#JobSalary"
        '
        'jobweapons
        '
        Me.jobweapons.AutoSize = True
        Me.jobweapons.Font = New System.Drawing.Font("Segoe Print", 10.0!, System.Drawing.FontStyle.Bold)
        Me.jobweapons.ForeColor = System.Drawing.Color.White
        Me.jobweapons.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.jobweapons.Location = New System.Drawing.Point(12, 163)
        Me.jobweapons.Name = "jobweapons"
        Me.jobweapons.Size = New System.Drawing.Size(106, 24)
        Me.jobweapons.TabIndex = 9
        Me.jobweapons.Text = "#JobWeapons"
        '
        'jobname
        '
        Me.jobname.AutoSize = True
        Me.jobname.Font = New System.Drawing.Font("Segoe Print", 10.0!, System.Drawing.FontStyle.Bold)
        Me.jobname.ForeColor = System.Drawing.Color.White
        Me.jobname.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.jobname.Location = New System.Drawing.Point(12, 61)
        Me.jobname.Name = "jobname"
        Me.jobname.Size = New System.Drawing.Size(85, 24)
        Me.jobname.TabIndex = 8
        Me.jobname.Text = "#JobName"
        '
        'teamname
        '
        Me.teamname.AutoSize = True
        Me.teamname.Font = New System.Drawing.Font("Segoe Print", 10.0!, System.Drawing.FontStyle.Bold)
        Me.teamname.ForeColor = System.Drawing.Color.White
        Me.teamname.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.teamname.Location = New System.Drawing.Point(12, 26)
        Me.teamname.Name = "teamname"
        Me.teamname.Size = New System.Drawing.Size(64, 24)
        Me.teamname.TabIndex = 11
        Me.teamname.Text = "#TEAM"
        '
        'VoteResult
        '
        Me.VoteResult.AutoSize = True
        Me.VoteResult.ForeColor = System.Drawing.Color.White
        Me.VoteResult.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.VoteResult.Location = New System.Drawing.Point(442, 137)
        Me.VoteResult.Name = "VoteResult"
        Me.VoteResult.Size = New System.Drawing.Size(59, 13)
        Me.VoteResult.TabIndex = 23
        Me.VoteResult.Text = "VoteResult"
        Me.VoteResult.Visible = False
        '
        'Timer
        '
        Me.Timer.Enabled = True
        Me.Timer.Interval = 1000
        '
        'GenCode
        '
        Me.GenCode.Location = New System.Drawing.Point(165, 322)
        Me.GenCode.Name = "GenCode"
        Me.GenCode.Size = New System.Drawing.Size(296, 40)
        Me.GenCode.TabIndex = 27
        Me.GenCode.Text = "#Generate"
        Me.GenCode.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.ClientSize = New System.Drawing.Size(626, 362)
        Me.Controls.Add(Me.GenCode)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.LangSelector)
        Me.Controls.Add(Me.BrowseModels)
        Me.Controls.Add(Me.VoteNo)
        Me.Controls.Add(Me.VoteYes)
        Me.Controls.Add(Me.textBox7)
        Me.Controls.Add(Me.ModelText)
        Me.Controls.Add(Me.textBox5)
        Me.Controls.Add(Me.textBox3)
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.jobvote)
        Me.Controls.Add(Me.jobcategory)
        Me.Controls.Add(Me.jobmodels)
        Me.Controls.Add(Me.jobsalary)
        Me.Controls.Add(Me.jobweapons)
        Me.Controls.Add(Me.jobname)
        Me.Controls.Add(Me.teamname)
        Me.Controls.Add(Me.VoteResult)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents LangSelector As ComboBox
    Private WithEvents BrowseModels As Button
    Private WithEvents VoteNo As RadioButton
    Private WithEvents VoteYes As RadioButton
    Private WithEvents textBox7 As TextBox
    Public WithEvents ModelText As TextBox
    Private WithEvents textBox5 As TextBox
    Private WithEvents textBox3 As TextBox
    Private WithEvents textBox2 As TextBox
    Private WithEvents textBox1 As TextBox
    Private WithEvents jobvote As Label
    Private WithEvents jobcategory As Label
    Private WithEvents jobmodels As Label
    Private WithEvents jobsalary As Label
    Private WithEvents jobweapons As Label
    Private WithEvents jobname As Label
    Private WithEvents teamname As Label
    Private WithEvents VoteResult As Label
    Private WithEvents Timer As Timer
    Friend WithEvents GenCode As Button
End Class
