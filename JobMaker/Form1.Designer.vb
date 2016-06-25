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
        Me.LanguageSelector = New System.Windows.Forms.PictureBox()
        Me.LanguageMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EnglishToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.РусскийToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.GenCode = New System.Windows.Forms.Button()
        Me.CodeBox = New System.Windows.Forms.RichTextBox()
        Me.ColorLabel = New System.Windows.Forms.Label()
        Me.ColorBox = New System.Windows.Forms.TextBox()
        Me.JobMaximum = New System.Windows.Forms.NumericUpDown()
        Me.jobmax = New System.Windows.Forms.Label()
        Me.CommandBox = New System.Windows.Forms.TextBox()
        Me.jobcommand = New System.Windows.Forms.Label()
        Me.ColorPick = New System.Windows.Forms.Button()
        Me.DescriptionLabel = New System.Windows.Forms.Label()
        Me.DescriptionBox = New System.Windows.Forms.TextBox()
        Me.TeamPanel = New System.Windows.Forms.Panel()
        Me.JobNamePanel = New System.Windows.Forms.Panel()
        Me.JobColorPanel = New System.Windows.Forms.Panel()
        Me.SalaryPanel = New System.Windows.Forms.Panel()
        Me.WeaponsPanel = New System.Windows.Forms.Panel()
        Me.ModelsPanel = New System.Windows.Forms.Panel()
        Me.CategoryPanel = New System.Windows.Forms.Panel()
        Me.DescriptionPanel = New System.Windows.Forms.Panel()
        Me.CommandPanel = New System.Windows.Forms.Panel()
        Me.JobMaxPanel = New System.Windows.Forms.Panel()
        Me.CopyAll = New System.Windows.Forms.Button()
        Me.ColorSwatchPanel = New System.Windows.Forms.Panel()
        Me.NoAccept = New System.Windows.Forms.Button()
        Me.acceptcolor = New System.Windows.Forms.Button()
        Me.BlueLabel = New System.Windows.Forms.Label()
        Me.GreenLabel = New System.Windows.Forms.Label()
        Me.RedLabel = New System.Windows.Forms.Label()
        Me.ResultValue = New System.Windows.Forms.Label()
        Me.BlueBar = New System.Windows.Forms.HScrollBar()
        Me.GreenBar = New System.Windows.Forms.HScrollBar()
        Me.RedBar = New System.Windows.Forms.HScrollBar()
        Me.ResultColorPanel = New System.Windows.Forms.Panel()
        Me.author = New System.Windows.Forms.Label()
        Me.JobLicense = New System.Windows.Forms.Label()
        Me.JobAdmin = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.AdminResult = New System.Windows.Forms.Label()
        Me.User = New System.Windows.Forms.RadioButton()
        Me.Admin = New System.Windows.Forms.RadioButton()
        Me.SuperAdmin = New System.Windows.Forms.RadioButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LicenseNo = New System.Windows.Forms.RadioButton()
        Me.LicenseYes = New System.Windows.Forms.RadioButton()
        Me.LicenseResult = New System.Windows.Forms.Label()
        Me.ShowAdvSet = New System.Windows.Forms.Button()
        Me.VersLabel = New System.Windows.Forms.Label()
        Me.WeaponShow = New System.Windows.Forms.Button()
        Me.MainMenu = New System.Windows.Forms.MenuStrip()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tip = New System.Windows.Forms.ToolTip(Me.components)
        Me.HideCode = New System.Windows.Forms.Button()
        Me.TeamTip = New System.Windows.Forms.Label()
        Me.NameTip = New System.Windows.Forms.Label()
        Me.ColorTip = New System.Windows.Forms.Label()
        Me.SalaryTip = New System.Windows.Forms.Label()
        Me.VoteTip = New System.Windows.Forms.Label()
        Me.WeaponTip = New System.Windows.Forms.Label()
        Me.ModelTip = New System.Windows.Forms.Label()
        Me.CategoryTip = New System.Windows.Forms.Label()
        Me.MaxTip = New System.Windows.Forms.Label()
        Me.CommandTip = New System.Windows.Forms.Label()
        Me.DescriptionTip = New System.Windows.Forms.Label()
        Me.LicenseTip = New System.Windows.Forms.Label()
        Me.AdminTip = New System.Windows.Forms.Label()
        CType(Me.LanguageSelector, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LanguageMenu.SuspendLayout()
        CType(Me.JobMaximum, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ColorSwatchPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.MainMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'LanguageSelector
        '
        Me.LanguageSelector.BackgroundImage = Global.JobMaker.My.Resources.Models.icon175x175
        resources.ApplyResources(Me.LanguageSelector, "LanguageSelector")
        Me.LanguageSelector.ContextMenuStrip = Me.LanguageMenu
        Me.LanguageSelector.Name = "LanguageSelector"
        Me.LanguageSelector.TabStop = False
        '
        'LanguageMenu
        '
        Me.LanguageMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnglishToolStripMenuItem, Me.РусскийToolStripMenuItem})
        Me.LanguageMenu.Name = "ContextMenuStrip1"
        resources.ApplyResources(Me.LanguageMenu, "LanguageMenu")
        '
        'EnglishToolStripMenuItem
        '
        Me.EnglishToolStripMenuItem.Name = "EnglishToolStripMenuItem"
        resources.ApplyResources(Me.EnglishToolStripMenuItem, "EnglishToolStripMenuItem")
        '
        'РусскийToolStripMenuItem
        '
        Me.РусскийToolStripMenuItem.Name = "РусскийToolStripMenuItem"
        resources.ApplyResources(Me.РусскийToolStripMenuItem, "РусскийToolStripMenuItem")
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
        Me.VoteNo.Checked = True
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
        'JobMaximum
        '
        resources.ApplyResources(Me.JobMaximum, "JobMaximum")
        Me.JobMaximum.Name = "JobMaximum"
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
        'DescriptionLabel
        '
        resources.ApplyResources(Me.DescriptionLabel, "DescriptionLabel")
        Me.DescriptionLabel.ForeColor = System.Drawing.Color.White
        Me.DescriptionLabel.Name = "DescriptionLabel"
        '
        'DescriptionBox
        '
        resources.ApplyResources(Me.DescriptionBox, "DescriptionBox")
        Me.DescriptionBox.Name = "DescriptionBox"
        '
        'TeamPanel
        '
        Me.TeamPanel.BackColor = System.Drawing.Color.Red
        resources.ApplyResources(Me.TeamPanel, "TeamPanel")
        Me.TeamPanel.Name = "TeamPanel"
        '
        'JobNamePanel
        '
        Me.JobNamePanel.BackColor = System.Drawing.Color.Red
        resources.ApplyResources(Me.JobNamePanel, "JobNamePanel")
        Me.JobNamePanel.Name = "JobNamePanel"
        '
        'JobColorPanel
        '
        Me.JobColorPanel.BackColor = System.Drawing.Color.Lime
        resources.ApplyResources(Me.JobColorPanel, "JobColorPanel")
        Me.JobColorPanel.Name = "JobColorPanel"
        '
        'SalaryPanel
        '
        Me.SalaryPanel.BackColor = System.Drawing.Color.Red
        resources.ApplyResources(Me.SalaryPanel, "SalaryPanel")
        Me.SalaryPanel.Name = "SalaryPanel"
        '
        'WeaponsPanel
        '
        Me.WeaponsPanel.BackColor = System.Drawing.Color.Red
        resources.ApplyResources(Me.WeaponsPanel, "WeaponsPanel")
        Me.WeaponsPanel.Name = "WeaponsPanel"
        '
        'ModelsPanel
        '
        Me.ModelsPanel.BackColor = System.Drawing.Color.Red
        resources.ApplyResources(Me.ModelsPanel, "ModelsPanel")
        Me.ModelsPanel.Name = "ModelsPanel"
        '
        'CategoryPanel
        '
        Me.CategoryPanel.BackColor = System.Drawing.Color.Red
        resources.ApplyResources(Me.CategoryPanel, "CategoryPanel")
        Me.CategoryPanel.Name = "CategoryPanel"
        '
        'DescriptionPanel
        '
        Me.DescriptionPanel.BackColor = System.Drawing.Color.Red
        resources.ApplyResources(Me.DescriptionPanel, "DescriptionPanel")
        Me.DescriptionPanel.Name = "DescriptionPanel"
        '
        'CommandPanel
        '
        Me.CommandPanel.BackColor = System.Drawing.Color.Red
        resources.ApplyResources(Me.CommandPanel, "CommandPanel")
        Me.CommandPanel.Name = "CommandPanel"
        '
        'JobMaxPanel
        '
        Me.JobMaxPanel.BackColor = System.Drawing.Color.Lime
        resources.ApplyResources(Me.JobMaxPanel, "JobMaxPanel")
        Me.JobMaxPanel.Name = "JobMaxPanel"
        '
        'CopyAll
        '
        resources.ApplyResources(Me.CopyAll, "CopyAll")
        Me.CopyAll.Name = "CopyAll"
        Me.CopyAll.UseVisualStyleBackColor = True
        '
        'ColorSwatchPanel
        '
        Me.ColorSwatchPanel.BackColor = System.Drawing.Color.White
        Me.ColorSwatchPanel.Controls.Add(Me.NoAccept)
        Me.ColorSwatchPanel.Controls.Add(Me.acceptcolor)
        Me.ColorSwatchPanel.Controls.Add(Me.BlueLabel)
        Me.ColorSwatchPanel.Controls.Add(Me.GreenLabel)
        Me.ColorSwatchPanel.Controls.Add(Me.RedLabel)
        Me.ColorSwatchPanel.Controls.Add(Me.ResultValue)
        Me.ColorSwatchPanel.Controls.Add(Me.BlueBar)
        Me.ColorSwatchPanel.Controls.Add(Me.GreenBar)
        Me.ColorSwatchPanel.Controls.Add(Me.RedBar)
        Me.ColorSwatchPanel.Controls.Add(Me.ResultColorPanel)
        resources.ApplyResources(Me.ColorSwatchPanel, "ColorSwatchPanel")
        Me.ColorSwatchPanel.Name = "ColorSwatchPanel"
        '
        'NoAccept
        '
        resources.ApplyResources(Me.NoAccept, "NoAccept")
        Me.NoAccept.FlatAppearance.BorderSize = 0
        Me.NoAccept.Name = "NoAccept"
        Me.NoAccept.UseVisualStyleBackColor = True
        '
        'acceptcolor
        '
        resources.ApplyResources(Me.acceptcolor, "acceptcolor")
        Me.acceptcolor.FlatAppearance.BorderSize = 0
        Me.acceptcolor.Name = "acceptcolor"
        Me.acceptcolor.UseVisualStyleBackColor = True
        '
        'BlueLabel
        '
        Me.BlueLabel.ForeColor = System.Drawing.Color.Blue
        resources.ApplyResources(Me.BlueLabel, "BlueLabel")
        Me.BlueLabel.Name = "BlueLabel"
        '
        'GreenLabel
        '
        Me.GreenLabel.ForeColor = System.Drawing.Color.Green
        resources.ApplyResources(Me.GreenLabel, "GreenLabel")
        Me.GreenLabel.Name = "GreenLabel"
        '
        'RedLabel
        '
        Me.RedLabel.ForeColor = System.Drawing.Color.Red
        resources.ApplyResources(Me.RedLabel, "RedLabel")
        Me.RedLabel.Name = "RedLabel"
        '
        'ResultValue
        '
        resources.ApplyResources(Me.ResultValue, "ResultValue")
        Me.ResultValue.Name = "ResultValue"
        '
        'BlueBar
        '
        resources.ApplyResources(Me.BlueBar, "BlueBar")
        Me.BlueBar.LargeChange = 5
        Me.BlueBar.Maximum = 259
        Me.BlueBar.Name = "BlueBar"
        '
        'GreenBar
        '
        resources.ApplyResources(Me.GreenBar, "GreenBar")
        Me.GreenBar.LargeChange = 5
        Me.GreenBar.Maximum = 259
        Me.GreenBar.Name = "GreenBar"
        '
        'RedBar
        '
        Me.RedBar.LargeChange = 5
        resources.ApplyResources(Me.RedBar, "RedBar")
        Me.RedBar.Maximum = 259
        Me.RedBar.Name = "RedBar"
        '
        'ResultColorPanel
        '
        Me.ResultColorPanel.BackColor = System.Drawing.Color.Black
        resources.ApplyResources(Me.ResultColorPanel, "ResultColorPanel")
        Me.ResultColorPanel.Name = "ResultColorPanel"
        '
        'author
        '
        resources.ApplyResources(Me.author, "author")
        Me.author.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.author.Name = "author"
        '
        'JobLicense
        '
        resources.ApplyResources(Me.JobLicense, "JobLicense")
        Me.JobLicense.ForeColor = System.Drawing.Color.White
        Me.JobLicense.Name = "JobLicense"
        '
        'JobAdmin
        '
        resources.ApplyResources(Me.JobAdmin, "JobAdmin")
        Me.JobAdmin.ForeColor = System.Drawing.Color.White
        Me.JobAdmin.Name = "JobAdmin"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.VoteNo)
        Me.Panel1.Controls.Add(Me.VoteYes)
        Me.Panel1.Controls.Add(Me.VoteResult)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.AdminTip)
        Me.Panel2.Controls.Add(Me.AdminResult)
        Me.Panel2.Controls.Add(Me.User)
        Me.Panel2.Controls.Add(Me.Admin)
        Me.Panel2.Controls.Add(Me.SuperAdmin)
        Me.Panel2.Controls.Add(Me.JobAdmin)
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'AdminResult
        '
        resources.ApplyResources(Me.AdminResult, "AdminResult")
        Me.AdminResult.Name = "AdminResult"
        '
        'User
        '
        resources.ApplyResources(Me.User, "User")
        Me.User.BackColor = System.Drawing.SystemColors.Highlight
        Me.User.Checked = True
        Me.User.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.User.Name = "User"
        Me.User.TabStop = True
        Me.User.UseVisualStyleBackColor = False
        '
        'Admin
        '
        resources.ApplyResources(Me.Admin, "Admin")
        Me.Admin.BackColor = System.Drawing.SystemColors.Highlight
        Me.Admin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Admin.Name = "Admin"
        Me.Admin.UseVisualStyleBackColor = False
        '
        'SuperAdmin
        '
        resources.ApplyResources(Me.SuperAdmin, "SuperAdmin")
        Me.SuperAdmin.BackColor = System.Drawing.SystemColors.Highlight
        Me.SuperAdmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SuperAdmin.Name = "SuperAdmin"
        Me.SuperAdmin.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.LicenseTip)
        Me.Panel3.Controls.Add(Me.LicenseNo)
        Me.Panel3.Controls.Add(Me.LicenseYes)
        Me.Panel3.Controls.Add(Me.LicenseResult)
        Me.Panel3.Controls.Add(Me.JobLicense)
        resources.ApplyResources(Me.Panel3, "Panel3")
        Me.Panel3.Name = "Panel3"
        '
        'LicenseNo
        '
        resources.ApplyResources(Me.LicenseNo, "LicenseNo")
        Me.LicenseNo.Checked = True
        Me.LicenseNo.ForeColor = System.Drawing.Color.White
        Me.LicenseNo.Name = "LicenseNo"
        Me.LicenseNo.TabStop = True
        Me.LicenseNo.UseVisualStyleBackColor = True
        '
        'LicenseYes
        '
        resources.ApplyResources(Me.LicenseYes, "LicenseYes")
        Me.LicenseYes.ForeColor = System.Drawing.Color.White
        Me.LicenseYes.Name = "LicenseYes"
        Me.LicenseYes.UseVisualStyleBackColor = True
        '
        'LicenseResult
        '
        resources.ApplyResources(Me.LicenseResult, "LicenseResult")
        Me.LicenseResult.ForeColor = System.Drawing.Color.White
        Me.LicenseResult.Name = "LicenseResult"
        '
        'ShowAdvSet
        '
        resources.ApplyResources(Me.ShowAdvSet, "ShowAdvSet")
        Me.ShowAdvSet.Name = "ShowAdvSet"
        Me.ShowAdvSet.UseVisualStyleBackColor = True
        '
        'VersLabel
        '
        resources.ApplyResources(Me.VersLabel, "VersLabel")
        Me.VersLabel.ForeColor = System.Drawing.SystemColors.ScrollBar
        Me.VersLabel.Name = "VersLabel"
        '
        'WeaponShow
        '
        resources.ApplyResources(Me.WeaponShow, "WeaponShow")
        Me.WeaponShow.Name = "WeaponShow"
        Me.WeaponShow.UseVisualStyleBackColor = True
        '
        'MainMenu
        '
        Me.MainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UpdateToolStripMenuItem, Me.ChangesToolStripMenuItem})
        resources.ApplyResources(Me.MainMenu, "MainMenu")
        Me.MainMenu.Name = "MainMenu"
        Me.MainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        resources.ApplyResources(Me.UpdateToolStripMenuItem, "UpdateToolStripMenuItem")
        '
        'ChangesToolStripMenuItem
        '
        Me.ChangesToolStripMenuItem.Name = "ChangesToolStripMenuItem"
        resources.ApplyResources(Me.ChangesToolStripMenuItem, "ChangesToolStripMenuItem")
        '
        'HideCode
        '
        resources.ApplyResources(Me.HideCode, "HideCode")
        Me.HideCode.Name = "HideCode"
        Me.HideCode.UseVisualStyleBackColor = True
        '
        'TeamTip
        '
        resources.ApplyResources(Me.TeamTip, "TeamTip")
        Me.TeamTip.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.TeamTip.Name = "TeamTip"
        Me.tip.SetToolTip(Me.TeamTip, resources.GetString("TeamTip.ToolTip"))
        '
        'NameTip
        '
        resources.ApplyResources(Me.NameTip, "NameTip")
        Me.NameTip.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.NameTip.Name = "NameTip"
        Me.tip.SetToolTip(Me.NameTip, resources.GetString("NameTip.ToolTip"))
        '
        'ColorTip
        '
        resources.ApplyResources(Me.ColorTip, "ColorTip")
        Me.ColorTip.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ColorTip.Name = "ColorTip"
        Me.tip.SetToolTip(Me.ColorTip, resources.GetString("ColorTip.ToolTip"))
        '
        'SalaryTip
        '
        resources.ApplyResources(Me.SalaryTip, "SalaryTip")
        Me.SalaryTip.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.SalaryTip.Name = "SalaryTip"
        Me.tip.SetToolTip(Me.SalaryTip, resources.GetString("SalaryTip.ToolTip"))
        '
        'VoteTip
        '
        resources.ApplyResources(Me.VoteTip, "VoteTip")
        Me.VoteTip.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.VoteTip.Name = "VoteTip"
        Me.tip.SetToolTip(Me.VoteTip, resources.GetString("VoteTip.ToolTip"))
        '
        'WeaponTip
        '
        resources.ApplyResources(Me.WeaponTip, "WeaponTip")
        Me.WeaponTip.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.WeaponTip.Name = "WeaponTip"
        Me.tip.SetToolTip(Me.WeaponTip, resources.GetString("WeaponTip.ToolTip"))
        '
        'ModelTip
        '
        resources.ApplyResources(Me.ModelTip, "ModelTip")
        Me.ModelTip.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ModelTip.Name = "ModelTip"
        Me.tip.SetToolTip(Me.ModelTip, resources.GetString("ModelTip.ToolTip"))
        '
        'CategoryTip
        '
        resources.ApplyResources(Me.CategoryTip, "CategoryTip")
        Me.CategoryTip.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CategoryTip.Name = "CategoryTip"
        Me.tip.SetToolTip(Me.CategoryTip, resources.GetString("CategoryTip.ToolTip"))
        '
        'MaxTip
        '
        resources.ApplyResources(Me.MaxTip, "MaxTip")
        Me.MaxTip.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.MaxTip.Name = "MaxTip"
        Me.tip.SetToolTip(Me.MaxTip, resources.GetString("MaxTip.ToolTip"))
        '
        'CommandTip
        '
        resources.ApplyResources(Me.CommandTip, "CommandTip")
        Me.CommandTip.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CommandTip.Name = "CommandTip"
        Me.tip.SetToolTip(Me.CommandTip, resources.GetString("CommandTip.ToolTip"))
        '
        'DescriptionTip
        '
        resources.ApplyResources(Me.DescriptionTip, "DescriptionTip")
        Me.DescriptionTip.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DescriptionTip.Name = "DescriptionTip"
        Me.tip.SetToolTip(Me.DescriptionTip, resources.GetString("DescriptionTip.ToolTip"))
        '
        'LicenseTip
        '
        resources.ApplyResources(Me.LicenseTip, "LicenseTip")
        Me.LicenseTip.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LicenseTip.Name = "LicenseTip"
        Me.tip.SetToolTip(Me.LicenseTip, resources.GetString("LicenseTip.ToolTip"))
        '
        'AdminTip
        '
        resources.ApplyResources(Me.AdminTip, "AdminTip")
        Me.AdminTip.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AdminTip.Name = "AdminTip"
        Me.tip.SetToolTip(Me.AdminTip, resources.GetString("AdminTip.ToolTip"))
        '
        'Form1
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.Controls.Add(Me.DescriptionTip)
        Me.Controls.Add(Me.CommandTip)
        Me.Controls.Add(Me.MaxTip)
        Me.Controls.Add(Me.CategoryTip)
        Me.Controls.Add(Me.ModelTip)
        Me.Controls.Add(Me.WeaponTip)
        Me.Controls.Add(Me.VoteTip)
        Me.Controls.Add(Me.SalaryTip)
        Me.Controls.Add(Me.ColorTip)
        Me.Controls.Add(Me.NameTip)
        Me.Controls.Add(Me.TeamTip)
        Me.Controls.Add(Me.MainMenu)
        Me.Controls.Add(Me.HideCode)
        Me.Controls.Add(Me.WeaponShow)
        Me.Controls.Add(Me.VersLabel)
        Me.Controls.Add(Me.ColorSwatchPanel)
        Me.Controls.Add(Me.CopyAll)
        Me.Controls.Add(Me.DescriptionBox)
        Me.Controls.Add(Me.DescriptionLabel)
        Me.Controls.Add(Me.CommandBox)
        Me.Controls.Add(Me.jobcommand)
        Me.Controls.Add(Me.jobmax)
        Me.Controls.Add(Me.JobMaximum)
        Me.Controls.Add(Me.ColorLabel)
        Me.Controls.Add(Me.CodeBox)
        Me.Controls.Add(Me.GenCode)
        Me.Controls.Add(Me.LanguageSelector)
        Me.Controls.Add(Me.ColorPick)
        Me.Controls.Add(Me.BrowseModels)
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
        Me.Controls.Add(Me.JobMaxPanel)
        Me.Controls.Add(Me.CommandPanel)
        Me.Controls.Add(Me.DescriptionPanel)
        Me.Controls.Add(Me.CategoryPanel)
        Me.Controls.Add(Me.ModelsPanel)
        Me.Controls.Add(Me.WeaponsPanel)
        Me.Controls.Add(Me.SalaryPanel)
        Me.Controls.Add(Me.JobColorPanel)
        Me.Controls.Add(Me.JobNamePanel)
        Me.Controls.Add(Me.TeamPanel)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.author)
        Me.Controls.Add(Me.ShowAdvSet)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        CType(Me.LanguageSelector, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LanguageMenu.ResumeLayout(False)
        CType(Me.JobMaximum, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ColorSwatchPanel.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.MainMenu.ResumeLayout(False)
        Me.MainMenu.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents LanguageSelector As PictureBox
    Private WithEvents BrowseModels As Button
    Private WithEvents VoteNo As RadioButton
    Private WithEvents VoteYes As RadioButton
    Private WithEvents JobCategoryBox As TextBox
    Public WithEvents JobModelBox As TextBox
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
    Friend WithEvents GenCode As Button
    Friend WithEvents CodeBox As RichTextBox
    Private WithEvents ColorLabel As Label
    Private WithEvents ColorBox As TextBox
    Friend WithEvents JobMaximum As NumericUpDown
    Private WithEvents jobmax As Label
    Private WithEvents CommandBox As TextBox
    Private WithEvents jobcommand As Label
    Private WithEvents ColorPick As Button
    Private WithEvents DescriptionLabel As Label
    Private WithEvents DescriptionBox As TextBox
    Friend WithEvents TeamPanel As Panel
    Friend WithEvents JobNamePanel As Panel
    Friend WithEvents JobColorPanel As Panel
    Friend WithEvents SalaryPanel As Panel
    Friend WithEvents WeaponsPanel As Panel
    Friend WithEvents ModelsPanel As Panel
    Friend WithEvents CategoryPanel As Panel
    Friend WithEvents DescriptionPanel As Panel
    Friend WithEvents CommandPanel As Panel
    Friend WithEvents JobMaxPanel As Panel
    Friend WithEvents CopyAll As Button
    Friend WithEvents ColorSwatchPanel As Panel
    Friend WithEvents RedBar As HScrollBar
    Friend WithEvents ResultColorPanel As Panel
    Friend WithEvents ResultValue As Label
    Friend WithEvents RedLabel As Label
    Friend WithEvents GreenLabel As Label
    Friend WithEvents GreenBar As HScrollBar
    Friend WithEvents BlueLabel As Label
    Friend WithEvents BlueBar As HScrollBar
    Friend WithEvents acceptcolor As Button
    Friend WithEvents NoAccept As Button
    Friend WithEvents LanguageMenu As ContextMenuStrip
    Friend WithEvents EnglishToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents РусскийToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents author As Label
    Private WithEvents JobLicense As Label
    Private WithEvents JobAdmin As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents SuperAdmin As RadioButton
    Friend WithEvents User As RadioButton
    Friend WithEvents Admin As RadioButton
    Friend WithEvents AdminResult As Label
    Friend WithEvents Panel3 As Panel
    Private WithEvents LicenseNo As RadioButton
    Private WithEvents LicenseYes As RadioButton
    Private WithEvents LicenseResult As Label
    Friend WithEvents ShowAdvSet As Button
    Friend WithEvents VersLabel As Label
    Private WithEvents WeaponShow As Button
    Friend WithEvents MainMenu As MenuStrip
    Friend WithEvents UpdateToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangesToolStripMenuItem As ToolStripMenuItem
    Public WithEvents JobWeaponsBox As TextBox
    Friend WithEvents tip As ToolTip
    Friend WithEvents HideCode As Button
    Friend WithEvents TeamTip As Label
    Friend WithEvents AdminTip As Label
    Friend WithEvents LicenseTip As Label
    Friend WithEvents NameTip As Label
    Friend WithEvents ColorTip As Label
    Friend WithEvents SalaryTip As Label
    Friend WithEvents VoteTip As Label
    Friend WithEvents WeaponTip As Label
    Friend WithEvents ModelTip As Label
    Friend WithEvents CategoryTip As Label
    Friend WithEvents MaxTip As Label
    Friend WithEvents CommandTip As Label
    Friend WithEvents DescriptionTip As Label
End Class
