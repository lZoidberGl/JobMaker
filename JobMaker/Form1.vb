Imports System.Globalization
Imports System.Threading
Imports JobMaker.My.Resources
Imports JobMaker.ModelsSelectorForm
Imports System.IO
Imports System.Text

Public Class Form1
    'Standart size 640; 400
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''↓---------SETS LOCALIZATION----------↓''

        If (CultureInfo.InstalledUICulture.EnglishName = "Russian (Russia)") Then
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("ru-RU")
        Else
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US")
        End If

        ''↑---------SETS LOCALIZATION----------↑''
        Me.Width = 640
        Me.Height = 570
        LoadDefaults()
    End Sub

    Private Sub LoadDefaults()
        ''↓---------USES LOCALIZATION----------↓''
        If (Thread.CurrentThread.CurrentUICulture Is CultureInfo.GetCultureInfo("en-US")) Then
            Me.Text = Localization.ProgramName
            teamname.Text = Localization.TeamName
            jobname.Text = Localization.JobName
            jobsalary.Text = Localization.JobSalary
            jobvote.Text = Localization.JobVote
            jobweapons.Text = Localization.JobWeapons
            jobmodels.Text = Localization.JobModels
            jobcategory.Text = Localization.JobCategory
            VoteYes.Text = Localization.VoteYes
            VoteNo.Text = Localization.VoteNo
            ModelsSelectorForm.sourcesite.Text = Localization.SourceSite
            GenCode.Text = Localization.Generate
            ColorLabel.Text = Localization.JobColor
            jobmax.Text = Localization.JobMax
            jobcommand.Text = Localization.JobCommand
            DescriptionLabel.Text = Localization.JobDescription
            CopyAll.Text = Localization.CopyButton
            JobLicense.Text = Localization.JobLicense
            User.Text = Localization.User
            Admin.Text = Localization.Admin
            SuperAdmin.Text = Localization.SuperAdmin
            LicenseNo.Text = Localization.LicenseNo
            LicenseYes.Text = Localization.LicenseYes
            JobAdmin.Text = Localization.JobAdmin
        End If

        If (Thread.CurrentThread.CurrentUICulture Is CultureInfo.GetCultureInfo("ru-RU")) Then
            Me.Text = Localization.ProgramNameRU
            teamname.Text = Localization.TeamNameRU
            jobname.Text = Localization.JobNameRU
            jobsalary.Text = Localization.JobSalaryRU
            jobvote.Text = Localization.JobVoteRU
            jobweapons.Text = Localization.JobWeaponsRU
            jobmodels.Text = Localization.JobModelsRU
            jobcategory.Text = Localization.JobCategoryRU
            VoteYes.Text = Localization.VoteYesRU
            VoteNo.Text = Localization.VoteNoRU
            ModelsSelectorForm.sourcesite.Text = Localization.SourceSiteRU
            GenCode.Text = Localization.GenerateRU
            ColorLabel.Text = Localization.JobColorRU
            jobmax.Text = Localization.JobMaxRU
            jobcommand.Text = Localization.JobCommandRU
            DescriptionLabel.Text = Localization.JobDescriptionRU
            CopyAll.Text = Localization.CopyButtonRU
            JobLicense.Text = Localization.JobLicenseRU
            User.Text = Localization.UserRU
            Admin.Text = Localization.AdminRU
            SuperAdmin.Text = Localization.SuperAdminRU
            LicenseNo.Text = Localization.LicenseNoRU
            LicenseYes.Text = Localization.LicenseYesRU
            JobAdmin.Text = Localization.JobAdminRU
        End If
        ''↑---------USES LOCALIZATION----------↑''
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles BrowseModels.Click
        ModelsSelectorForm.Show()
    End Sub

    Private Sub VoteYes_CheckedChanged(sender As Object, e As EventArgs) Handles VoteYes.CheckedChanged, VoteNo.CheckedChanged
        If (VoteYes.Checked) Then
            VoteResult.Text = "true"
        Else
            VoteResult.Text = "false"
        End If
        GenerateCode()
    End Sub

    Private Sub GenCode_Click(sender As Object, e As EventArgs) Handles GenCode.Click
        ExtendMe()
        GenerateCode()
    End Sub

    Private Sub GenerateCode()
        'CodeBox.Text + Environment.NewLine
        CodeBox.Text = "TEAM_" + TeamBox.Text + " = DarkRP.createJob(" + Chr(34) + JobNameBox.Text + Chr(34) + ",{"
        CodeBox.Text = CodeBox.Text + Environment.NewLine + "	color = Color(" + ColorBox.Text + ",255),"
        CodeBox.Text = CodeBox.Text + Environment.NewLine + "	model = {" + JobModelBox.Text + "},"
        CodeBox.Text = CodeBox.Text + Environment.NewLine + "	description = [[" + DescriptionBox.Text + "]],"
        CodeBox.Text = CodeBox.Text + Environment.NewLine + "	weapons = {" + JobWeaponsBox.Text + "},"
        CodeBox.Text = CodeBox.Text + Environment.NewLine + "	command = " + Chr(34) + CommandBox.Text + Chr(34) + ","
        CodeBox.Text = CodeBox.Text + Environment.NewLine + "	max = " + JobMaximum.Value.ToString() + ","
        CodeBox.Text = CodeBox.Text + Environment.NewLine + "	salary = " + JobSalaryBox.Text + ","
        CodeBox.Text = CodeBox.Text + Environment.NewLine + "	admin = " + AdminResult.Text + ","
        CodeBox.Text = CodeBox.Text + Environment.NewLine + "	vote = " + VoteResult.Text + ","
        CodeBox.Text = CodeBox.Text + Environment.NewLine + "	hasLicense =" + LicenseResult.Text + ","
        CodeBox.Text = CodeBox.Text + Environment.NewLine + "	category = " + Chr(34) + JobCategoryBox.Text + Chr(34)
        CodeBox.Text = CodeBox.Text + Environment.NewLine + "})"
    End Sub

    Private Sub ExtendMe()
        Anim.Start()
        CodeBox.Visible = True
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs) Handles Anim.Tick
        If Me.Width < 1150 Then
            Me.Width = Width + 15
        Else
            Anim.Stop()
        End If
    End Sub

    Private Sub TeamBox_TextChanged(sender As Object, e As EventArgs) Handles TeamBox.TextChanged
        If TeamBox.Text IsNot "" Then
            TeamPanel.BackColor = Color.Lime
        Else
            TeamPanel.BackColor = Color.Red
        End If
        GenerateCode()
    End Sub

    Private Sub JobNameBox_TextChanged(sender As Object, e As EventArgs) Handles JobNameBox.TextChanged
        If JobNameBox.Text IsNot "" Then
            JobNamePanel.BackColor = Color.Lime
        Else
            JobNamePanel.BackColor = Color.Red
        End If
        GenerateCode()
    End Sub

    Private Sub ColorBox_TextChanged(sender As Object, e As EventArgs) Handles ColorBox.TextChanged
        If ColorBox.Text IsNot "" Then
            JobColorPanel.BackColor = Color.Lime
        Else
            JobColorPanel.BackColor = Color.Red
        End If
        GenerateCode()
    End Sub

    Private Sub JobSalaryBox_TextChanged(sender As Object, e As EventArgs) Handles JobSalaryBox.TextChanged
        If JobSalaryBox.Text IsNot "" Then
            SalaryPanel.BackColor = Color.Lime
        Else
            SalaryPanel.BackColor = Color.Red
        End If
        GenerateCode()
    End Sub

    Private Sub JobWeaponsBox_TextChanged(sender As Object, e As EventArgs) Handles JobWeaponsBox.TextChanged
        If JobWeaponsBox.Text IsNot "" Then
            WeaponsPanel.BackColor = Color.Lime
        Else
            WeaponsPanel.BackColor = Color.Red
        End If
        GenerateCode()
    End Sub

    Private Sub JobModelBox_TextChanged(sender As Object, e As EventArgs) Handles JobModelBox.TextChanged
        If JobModelBox.Text IsNot "" Then
            ModelsPanel.BackColor = Color.Lime
        Else
            ModelsPanel.BackColor = Color.Red
        End If
        GenerateCode()
    End Sub

    Private Sub JobCategoryBox_TextChanged(sender As Object, e As EventArgs) Handles JobCategoryBox.TextChanged
        If JobCategoryBox.Text IsNot "" Then
            CategoryPanel.BackColor = Color.Lime
        Else
            CategoryPanel.BackColor = Color.Red
        End If
        GenerateCode()
    End Sub

    Private Sub JobMaximum_ValueChanged(sender As Object, e As EventArgs) Handles JobMaximum.ValueChanged
        GenerateCode()
    End Sub

    Private Sub CommandBox_TextChanged(sender As Object, e As EventArgs) Handles CommandBox.TextChanged
        If CommandBox.Text IsNot "" Then
            CommandPanel.BackColor = Color.Lime
        Else
            CommandPanel.BackColor = Color.Red
        End If
        GenerateCode()
    End Sub

    Private Sub DescriptionBox_TextChanged(sender As Object, e As EventArgs) Handles DescriptionBox.TextChanged
        If DescriptionBox.Text IsNot "" Then
            DescriptionPanel.BackColor = Color.Lime
        Else
            DescriptionPanel.BackColor = Color.Red
        End If
        GenerateCode()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles CopyAll.Click
        Dim TextCopied As String
        If (Thread.CurrentThread.CurrentUICulture Is CultureInfo.GetCultureInfo("en-US")) Then
            TextCopied = "Text copied!"
        End If
        If (Thread.CurrentThread.CurrentUICulture Is CultureInfo.GetCultureInfo("ru-RU")) Then
            TextCopied = "Текст скопирован!"
        End If
        CodeBox.SelectAll()
        CodeBox.Copy()
        MsgBox(TextCopied)
    End Sub

    Private Sub RedBar_Scroll(sender As Object, e As ScrollEventArgs) Handles RedBar.Scroll, GreenBar.Scroll, BlueBar.Scroll
        ResultValue.Text = RedBar.Value & "," & GreenBar.Value & "," & BlueBar.Value
        ResultColorPanel.BackColor = Color.FromArgb(RedBar.Value, GreenBar.Value, BlueBar.Value)
    End Sub

    Private Sub acceptcolor_Click(sender As Object, e As EventArgs) Handles acceptcolor.Click
        ColorBox.Text = ResultValue.Text
        ColorSwatchPanel.Visible = False
    End Sub

    Private Sub ColorPick_Click(sender As Object, e As EventArgs) Handles ColorPick.Click
        ColorSwatchPanel.Visible = True
    End Sub
    Dim x, y As Integer
    Dim newpoint As New Point
    Private Sub ColorSwatchPanel_MouseDown(sender As Object, e As MouseEventArgs) Handles ColorSwatchPanel.MouseDown
        x = Control.MousePosition.X - ColorSwatchPanel.Location.X
        y = Control.MousePosition.Y - ColorSwatchPanel.Location.Y
    End Sub

    Private Sub NoAccept_Click(sender As Object, e As EventArgs) Handles NoAccept.Click
        ColorSwatchPanel.Visible = False
    End Sub

    Private Sub EnglishToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnglishToolStripMenuItem.Click
        Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US")
        LoadDefaults()
    End Sub

    Private Sub РусскийToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles РусскийToolStripMenuItem.Click
        Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("ru-RU")
        LoadDefaults()
    End Sub

    Private Sub AdminCheck1_CheckedChanged(sender As Object, e As EventArgs) Handles SuperAdmin.CheckedChanged, Admin.CheckedChanged, User.CheckedChanged
        If SuperAdmin.Checked Then
            AdminResult.Text = "2"
        End If
        If Admin.Checked Then
            AdminResult.Text = "1"
        End If
        If User.Checked Then
            AdminResult.Text = "0"
        End If
        GenerateCode()
    End Sub

    Private Sub LanguageSelector_Click(sender As Object, e As EventArgs) Handles LanguageSelector.Click
        LanguageMenu.Show()
        LanguageMenu.Location = MousePosition
    End Sub

    Private Sub LicenseYes_CheckedChanged(sender As Object, e As EventArgs) Handles LicenseYes.CheckedChanged, LicenseNo.CheckedChanged
        If LicenseYes.Checked Then
            LicenseResult.Text = "true"
        Else
            LicenseResult.Text = "false"
        End If
        GenerateCode()
    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles ShowAdvSet.Click
        AdvancedSettings.Show()
    End Sub

    Private Sub ColorSwatchPanel_MouseMove(sender As Object, e As MouseEventArgs) Handles ColorSwatchPanel.MouseMove
        If e.Button = MouseButtons.Left Then
            newpoint = MousePosition
            newpoint.X -= (x)
            newpoint.Y -= (y)
            ColorSwatchPanel.Location = newpoint
        End If
    End Sub
End Class
