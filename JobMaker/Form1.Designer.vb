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
        Me.JobCategoryBox = New System.Windows.Forms.TextBox()
        Me.JobModelBox = New System.Windows.Forms.TextBox()
        Me.JobWeaponsBox = New System.Windows.Forms.TextBox()
        Me.JobSalaryBox = New System.Windows.Forms.TextBox()
        Me.JobNameBox = New System.Windows.Forms.TextBox()
        Me.TeamBox = New System.Windows.Forms.TextBox()
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
        Me.CodeBox = New System.Windows.Forms.RichTextBox()
        Me.ColorLabel = New System.Windows.Forms.Label()
        Me.ColorBox = New System.Windows.Forms.TextBox()
        Me.Maximum = New System.Windows.Forms.NumericUpDown()
        Me.jobmax = New System.Windows.Forms.Label()
        Me.CommandBox = New System.Windows.Forms.TextBox()
        Me.jobcommand = New System.Windows.Forms.Label()
        Me.ColorPick = New System.Windows.Forms.Button()
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Maximum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pictureBox1
        '
        Me.pictureBox1.BackgroundImage = Global.JobMaker.My.Resources.Models.icon175x175
        resources.ApplyResources(Me.pictureBox1, "pictureBox1")
        Me.pictureBox1.Name = "pictureBox1"
        Me.pictureBox1.TabStop = False
        '
        'LangSelector
        '
        Me.LangSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        resources.ApplyResources(Me.LangSelector, "LangSelector")
        Me.LangSelector.FormattingEnabled = True
        Me.LangSelector.Items.AddRange(New Object() {resources.GetString("LangSelector.Items"), resources.GetString("LangSelector.Items1")})
        Me.LangSelector.Name = "LangSelector"
        '
        'BrowseModels
        '
        resources.ApplyResources(Me.BrowseModels, "BrowseModels")
        Me.BrowseModels.Name = "BrowseModels"
        Me.BrowseModels.UseVisualStyleBackColor = True
        '
        'VoteNo
        '
        resources.ApplyResources(Me.VoteNo, "VoteNo")
        Me.VoteNo.ForeColor = System.Drawing.Color.White
        Me.VoteNo.Name = "VoteNo"
        Me.VoteNo.TabStop = True
        Me.VoteNo.UseVisualStyleBackColor = True
        '
        'VoteYes
        '
        resources.ApplyResources(Me.VoteYes, "VoteYes")
        Me.VoteYes.ForeColor = System.Drawing.Color.White
        Me.VoteYes.Name = "VoteYes"
        Me.VoteYes.TabStop = True
        Me.VoteYes.UseVisualStyleBackColor = True
        '
        'JobCategoryBox
        '
        resources.ApplyResources(Me.JobCategoryBox, "JobCategoryBox")
        Me.JobCategoryBox.Name = "JobCategoryBox"
        '
        'JobModelBox
        '
        resources.ApplyResources(Me.JobModelBox, "JobModelBox")
        Me.JobModelBox.Name = "JobModelBox"
        '
        'JobWeaponsBox
        '
        resources.ApplyResources(Me.JobWeaponsBox, "JobWeaponsBox")
        Me.JobWeaponsBox.Name = "JobWeaponsBox"
        '
        'JobSalaryBox
        '
        resources.ApplyResources(Me.JobSalaryBox, "JobSalaryBox")
        Me.JobSalaryBox.Name = "JobSalaryBox"
        '
        'JobNameBox
        '
        resources.ApplyResources(Me.JobNameBox, "JobNameBox")
        Me.JobNameBox.Name = "JobNameBox"
        '
        'TeamBox
        '
        Me.TeamBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.TeamBox, "TeamBox")
        Me.TeamBox.Name = "TeamBox"
        '
        'jobvote
        '
        resources.ApplyResources(Me.jobvote, "jobvote")
        Me.jobvote.ForeColor = System.Drawing.Color.White
        Me.jobvote.Name = "jobvote"
        '
        'jobcategory
        '
        resources.ApplyResources(Me.jobcategory, "jobcategory")
        Me.jobcategory.ForeColor = System.Drawing.Color.White
        Me.jobcategory.Name = "jobcategory"
        '
        'jobmodels
        '
        resources.ApplyResources(Me.jobmodels, "jobmodels")
        Me.jobmodels.ForeColor = System.Drawing.Color.White
        Me.jobmodels.Name = "jobmodels"
        '
        'jobsalary
        '
        resources.ApplyResources(Me.jobsalary, "jobsalary")
        Me.jobsalary.ForeColor = System.Drawing.Color.White
        Me.jobsalary.Name = "jobsalary"
        '
        'jobweapons
        '
        resources.ApplyResources(Me.jobweapons, "jobweapons")
        Me.jobweapons.ForeColor = System.Drawing.Color.White
        Me.jobweapons.Name = "jobweapons"
        '
        'jobname
        '
        resources.ApplyResources(Me.jobname, "jobname")
        Me.jobname.ForeColor = System.Drawing.Color.White
        Me.jobname.Name = "jobname"
        '
        'teamname
        '
        resources.ApplyResources(Me.teamname, "teamname")
        Me.teamname.ForeColor = System.Drawing.Color.White
        Me.teamname.Name = "teamname"
        '
        'VoteResult
        '
        resources.ApplyResources(Me.VoteResult, "VoteResult")
        Me.VoteResult.ForeColor = System.Drawing.Color.White
        Me.VoteResult.Name = "VoteResult"
        '
        'Timer
        '
        Me.Timer.Interval = 25
        '
        'GenCode
        '
        resources.ApplyResources(Me.GenCode, "GenCode")
        Me.GenCode.Name = "GenCode"
        Me.GenCode.UseVisualStyleBackColor = True
        '
        'CodeBox
        '
        resources.ApplyResources(Me.CodeBox, "CodeBox")
        Me.CodeBox.Name = "CodeBox"
        '
        'ColorLabel
        '
        resources.ApplyResources(Me.ColorLabel, "ColorLabel")
        Me.ColorLabel.ForeColor = System.Drawing.Color.White
        Me.ColorLabel.Name = "ColorLabel"
        '
        'ColorBox
        '
        resources.ApplyResources(Me.ColorBox, "ColorBox")
        Me.ColorBox.Name = "ColorBox"
        '
        'Maximum
        '
        resources.ApplyResources(Me.Maximum, "Maximum")
        Me.Maximum.Name = "Maximum"
        '
        'jobmax
        '
        resources.ApplyResources(Me.jobmax, "jobmax")
        Me.jobmax.ForeColor = System.Drawing.Color.White
        Me.jobmax.Name = "jobmax"
        '
        'CommandBox
        '
        resources.ApplyResources(Me.CommandBox, "CommandBox")
        Me.CommandBox.Name = "CommandBox"
        '
        'jobcommand
        '
        resources.ApplyResources(Me.jobcommand, "jobcommand")
        Me.jobcommand.ForeColor = System.Drawing.Color.White
        Me.jobcommand.Name = "jobcommand"
        '
        'ColorPick
        '
        resources.ApplyResources(Me.ColorPick, "ColorPick")
        Me.ColorPick.Name = "ColorPick"
        Me.ColorPick.UseVisualStyleBackColor = True
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.Controls.Add(Me.CommandBox)
        Me.Controls.Add(Me.jobcommand)
        Me.Controls.Add(Me.jobmax)
        Me.Controls.Add(Me.Maximum)
        Me.Controls.Add(Me.ColorLabel)
        Me.Controls.Add(Me.CodeBox)
        Me.Controls.Add(Me.GenCode)
        Me.Controls.Add(Me.pictureBox1)
        Me.Controls.Add(Me.LangSelector)
        Me.Controls.Add(Me.ColorPick)
        Me.Controls.Add(Me.BrowseModels)
        Me.Controls.Add(Me.VoteNo)
        Me.Controls.Add(Me.VoteYes)
        Me.Controls.Add(Me.JobCategoryBox)
        Me.Controls.Add(Me.JobModelBox)
        Me.Controls.Add(Me.JobWeaponsBox)
        Me.Controls.Add(Me.JobSalaryBox)
        Me.Controls.Add(Me.JobNameBox)
        Me.Controls.Add(Me.ColorBox)
        Me.Controls.Add(Me.TeamBox)
        Me.Controls.Add(Me.jobvote)
        Me.Controls.Add(Me.jobcategory)
        Me.Controls.Add(Me.jobmodels)
        Me.Controls.Add(Me.jobsalary)
        Me.Controls.Add(Me.jobweapons)
        Me.Controls.Add(Me.jobname)
        Me.Controls.Add(Me.teamname)
        Me.Controls.Add(Me.VoteResult)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Maximum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents pictureBox1 As PictureBox
    Private WithEvents LangSelector As ComboBox
    Private WithEvents BrowseModels As Button
    Private WithEvents VoteNo As RadioButton
    Private WithEvents VoteYes As RadioButton
    Private WithEvents JobCategoryBox As TextBox
    Public WithEvents JobModelBox As TextBox
    Private WithEvents JobWeaponsBox As TextBox
    Private WithEvents JobSalaryBox As TextBox
    Private WithEvents JobNameBox As TextBox
    Private WithEvents TeamBox As TextBox
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
    Friend WithEvents CodeBox As RichTextBox
    Private WithEvents ColorLabel As Label
    Private WithEvents ColorBox As TextBox
    Friend WithEvents Maximum As NumericUpDown
    Private WithEvents jobmax As Label
    Private WithEvents CommandBox As TextBox
    Private WithEvents jobcommand As Label
    Private WithEvents ColorPick As Button
End Class
