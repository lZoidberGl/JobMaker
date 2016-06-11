Imports System.Globalization
Imports System.Threading
Imports JobMaker.My.Resources
Imports JobMaker.ModelsSelectorForm
Imports System.IO
Imports System.Text

Public Class Form1
    'Link template "https://dl.dropboxusercontent.com/s/7lxyq9ks0tut177/versionNew.txt?dl=1"
    Dim NewVer As String = ""
    Dim ThisVer As String = Application.ProductVersion
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
        Me.Height = 598
        LoadLanguages()
        VersLabel.Text = "Beta " + Application.ProductVersion

        CheckIfUpdated()
    End Sub

    Private Sub CheckIfUpdated()
        Dim updatepassed As String = ""
        If (CultureInfo.InstalledUICulture.EnglishName = "Russian (Russia)") Then
            updatepassed = "Успешно обновлено!"
        Else
            updatepassed = "Successfully updated!"
        End If

        If ThisVer.Contains(NewVer) Then
            If File.Exists(Application.StartupPath + "\updated.txt") Then
                MsgBox(updatepassed)
                Try
                    File.Delete(Application.StartupPath + "\updated.txt")
                Catch ex As Exception
                End Try
            End If
        End If
    End Sub

    Private Sub LoadLanguages()
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
            ShowAdvSet.Text = Localization.AdvSettings
            AdvancedSettings.NeedChangeFrom.Text = Localization.NeedChangeFrom
            AdvancedSettings.ComingSoon.Text = Localization.ComingSoon
            AdvancedSettings.Hobo.Text = Localization.Hobo
            AdvancedSettings.Medic.Text = Localization.Medic
            AdvancedSettings.Mayor.Text = Localization.Mayor
            AdvancedSettings.Chief.Text = Localization.Chief
            AdvancedSettings.Cook.Text = Localization.Cook
            WeaponSelectorForm.CheckBox26.Text = Localization.BatteringRam
            WeaponSelectorForm.CheckBox27.Text = Localization.WeaponChecker
            WeaponSelectorForm.CheckBox29.Text = Localization.Medkit
            WeaponSelectorForm.CheckBox30.Text = Localization.Lockpick
            WeaponSelectorForm.CheckBox28.Text = Localization.Stunstick
            WeaponSelectorForm.CheckBox25.Text = Localization.ArrestStick
            WeaponSelectorForm.CheckBox24.Text = Localization.UnArrestStick
            UpdateToolStripMenuItem.Text = Localization.UpdateMenu
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
            ShowAdvSet.Text = Localization.AdvSettingsRU
            AdvancedSettings.NeedChangeFrom.Text = Localization.NeedChangeFromRU
            AdvancedSettings.ComingSoon.Text = Localization.ComingSoonRU
            AdvancedSettings.Hobo.Text = Localization.HoboRU
            AdvancedSettings.Medic.Text = Localization.MedicRU
            AdvancedSettings.Mayor.Text = Localization.MayorRU
            AdvancedSettings.Chief.Text = Localization.ChiefRU
            AdvancedSettings.Cook.Text = Localization.CookRU
            WeaponSelectorForm.CheckBox26.Text = Localization.BatteringRamRU
            WeaponSelectorForm.CheckBox27.Text = Localization.WeaponCheckerRU
            WeaponSelectorForm.CheckBox29.Text = Localization.MedkitRU
            WeaponSelectorForm.CheckBox30.Text = Localization.LockpickRU
            WeaponSelectorForm.CheckBox28.Text = Localization.StunstickRU
            WeaponSelectorForm.CheckBox25.Text = Localization.ArrestStickRU
            WeaponSelectorForm.CheckBox24.Text = Localization.UnArrestStickRU
            UpdateToolStripMenuItem.Text = Localization.UpdateMenuRU
        End If
        ''↑---------USES LOCALIZATION----------↑''
    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles BrowseModels.Click
        ModelsSelectorForm.Show()
        ModelSelectorSaveProgress()
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

    Public Sub GenerateCode()
        'CodeBox.Text + Environment.NewLine
        CodeBox.Text = "" + TeamBox.Text + " = DarkRP.createJob(" + Chr(34) + JobNameBox.Text + Chr(34) + ",{"
        CodeBox.Text = CodeBox.Text + Environment.NewLine + "	color = Color(" + ColorBox.Text + ",255),"
        CodeBox.Text = CodeBox.Text + Environment.NewLine + "	model = {" + JobModelBox.Text + "},"
        CodeBox.Text = CodeBox.Text + Environment.NewLine + "	description = [[" + DescriptionBox.Text + "]],"
        CodeBox.Text = CodeBox.Text + Environment.NewLine + "	weapons = {" + JobWeaponsBox.Text + "},"
        CodeBox.Text = CodeBox.Text + Environment.NewLine + "	command = " + Chr(34) + CommandBox.Text + Chr(34) + ","
        CodeBox.Text = CodeBox.Text + Environment.NewLine + "	max = " + JobMaximum.Value.ToString() + ","
        CodeBox.Text = CodeBox.Text + Environment.NewLine + "	salary = " + JobSalaryBox.Text + ","
        CodeBox.Text = CodeBox.Text + Environment.NewLine + "	admin = " + AdminResult.Text + ","
        CodeBox.Text = CodeBox.Text + Environment.NewLine + "	vote = " + VoteResult.Text + ","
        CodeBox.Text = CodeBox.Text + Environment.NewLine + "	hasLicense = " + LicenseResult.Text
        If JobCategoryBox.Text IsNot "" Then
            CodeBox.Text = CodeBox.Text + "," + Environment.NewLine + "	category = " + Chr(34) + JobCategoryBox.Text + Chr(34)
        End If
        If AdvancedSettings.changecheck.CheckState = CheckState.Checked Then
            CodeBox.Text = CodeBox.Text + "," + Environment.NewLine + "	NeedToChangeFrom = {" + AdvancedSettings.NeedChangeFromText.Text + "}"
        End If
        If AdvancedSettings.HoboCheck.CheckState = CheckState.Checked Then
            CodeBox.Text = CodeBox.Text + "," + Environment.NewLine + "	hobo = true"
        End If
        If AdvancedSettings.MedicCheck.CheckState = CheckState.Checked Then
            CodeBox.Text = CodeBox.Text + "," + Environment.NewLine + "	medic = true"
        End If
        If AdvancedSettings.MayorCheck.CheckState = CheckState.Checked Then
            CodeBox.Text = CodeBox.Text + "," + Environment.NewLine + "	mayor = true"
        End If
        If AdvancedSettings.ChiefCheck.CheckState = CheckState.Checked Then
            CodeBox.Text = CodeBox.Text + "," + Environment.NewLine + "	chief = true"
        End If
        If AdvancedSettings.CookCheck.CheckState = CheckState.Checked Then
            CodeBox.Text = CodeBox.Text + "," + Environment.NewLine + "	cook = true"
        End If
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
            If TeamBox.Text > "TEAM_" Then
                TeamPanel.BackColor = Color.Lime
            Else
                TeamPanel.BackColor = Color.Red
            End If
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
        Dim TextCopied As String = ""
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
        LoadLanguages()
    End Sub

    Private Sub РусскийToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles РусскийToolStripMenuItem.Click
        Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("ru-RU")
        LoadLanguages()
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
        AdvSetSaveProgress()
        LoadLanguages()
    End Sub

    Private Sub ColorSwatchPanel_MouseMove(sender As Object, e As MouseEventArgs) Handles ColorSwatchPanel.MouseMove
        If e.Button = MouseButtons.Left Then
            newpoint = MousePosition
            newpoint.X -= (x)
            newpoint.Y -= (y)
            ColorSwatchPanel.Location = newpoint
        End If
    End Sub

    Public Sub ModelSelectorSaveProgress()
        ''Saves all progress in model selector''
        If SaveVars.chk1 = "true" Then
            ModelsSelectorForm.checkBox1.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox1.CheckState = CheckState.Unchecked
        End If

        If SaveVars.chk2 = "true" Then
            ModelsSelectorForm.checkBox2.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox2.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk3 = "true" Then
            ModelsSelectorForm.checkBox3.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox3.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk4 = "true" Then
            ModelsSelectorForm.checkBox4.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox4.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk5 = "true" Then
            ModelsSelectorForm.checkBox5.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox5.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk6 = "true" Then
            ModelsSelectorForm.checkBox6.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox6.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk7 = "true" Then
            ModelsSelectorForm.checkBox7.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox7.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk8 = "true" Then
            ModelsSelectorForm.checkBox8.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox8.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk9 = "true" Then
            ModelsSelectorForm.checkBox9.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox9.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk10 = "true" Then
            ModelsSelectorForm.checkBox10.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox10.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk11 = "true" Then
            ModelsSelectorForm.checkBox11.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox11.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk12 = "true" Then
            ModelsSelectorForm.checkBox12.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox12.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk13 = "true" Then
            ModelsSelectorForm.checkBox13.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox13.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk14 = "true" Then
            ModelsSelectorForm.checkBox14.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox14.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk15 = "true" Then
            ModelsSelectorForm.checkBox15.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox15.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk16 = "true" Then
            ModelsSelectorForm.checkBox16.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox16.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk17 = "true" Then
            ModelsSelectorForm.checkBox17.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox17.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk18 = "true" Then
            ModelsSelectorForm.checkBox18.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox18.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk19 = "true" Then
            ModelsSelectorForm.checkBox19.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox19.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk20 = "true" Then
            ModelsSelectorForm.checkBox20.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox20.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk21 = "true" Then
            ModelsSelectorForm.checkBox21.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox21.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk22 = "true" Then
            ModelsSelectorForm.checkBox22.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox22.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk23 = "true" Then
            ModelsSelectorForm.checkBox23.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox23.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk24 = "true" Then
            ModelsSelectorForm.checkBox24.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox24.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk25 = "true" Then
            ModelsSelectorForm.checkBox25.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox25.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk26 = "true" Then
            ModelsSelectorForm.checkBox26.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox26.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk27 = "true" Then
            ModelsSelectorForm.checkBox27.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox27.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk28 = "true" Then
            ModelsSelectorForm.checkBox28.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox28.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk29 = "true" Then
            ModelsSelectorForm.checkBox29.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox29.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk30 = "true" Then
            ModelsSelectorForm.checkBox30.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox30.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk31 = "true" Then
            ModelsSelectorForm.checkBox31.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox31.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk32 = "true" Then
            ModelsSelectorForm.checkBox32.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox32.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk33 = "true" Then
            ModelsSelectorForm.checkBox33.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox33.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk34 = "true" Then
            ModelsSelectorForm.checkBox34.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox34.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk35 = "true" Then
            ModelsSelectorForm.checkBox35.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox35.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk36 = "true" Then
            ModelsSelectorForm.checkBox36.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox36.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk37 = "true" Then
            ModelsSelectorForm.checkBox37.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox37.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk38 = "true" Then
            ModelsSelectorForm.checkBox38.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox38.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk39 = "true" Then
            ModelsSelectorForm.checkBox39.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox39.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk40 = "true" Then
            ModelsSelectorForm.checkBox40.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox40.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk41 = "true" Then
            ModelsSelectorForm.checkBox41.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox41.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk42 = "true" Then
            ModelsSelectorForm.checkBox42.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox42.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk43 = "true" Then
            ModelsSelectorForm.checkBox43.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox43.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk44 = "true" Then
            ModelsSelectorForm.checkBox44.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox44.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk45 = "true" Then
            ModelsSelectorForm.checkBox45.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox45.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk46 = "true" Then
            ModelsSelectorForm.checkBox46.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox46.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk47 = "true" Then
            ModelsSelectorForm.checkBox47.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox47.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk48 = "true" Then
            ModelsSelectorForm.checkBox48.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox48.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk49 = "true" Then
            ModelsSelectorForm.checkBox49.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox49.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk50 = "true" Then
            ModelsSelectorForm.checkBox50.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox50.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk51 = "true" Then
            ModelsSelectorForm.checkBox51.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox51.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk52 = "true" Then
            ModelsSelectorForm.checkBox52.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox52.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk53 = "true" Then
            ModelsSelectorForm.checkBox53.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox53.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk54 = "true" Then
            ModelsSelectorForm.checkBox54.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox54.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk55 = "true" Then
            ModelsSelectorForm.checkBox55.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox55.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk56 = "true" Then
            ModelsSelectorForm.checkBox56.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox56.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk57 = "true" Then
            ModelsSelectorForm.checkBox57.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox57.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk58 = "true" Then
            ModelsSelectorForm.checkBox58.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox58.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk59 = "true" Then
            ModelsSelectorForm.checkBox59.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox59.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk60 = "true" Then
            ModelsSelectorForm.checkBox60.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox60.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk61 = "true" Then
            ModelsSelectorForm.checkBox61.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox61.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk62 = "true" Then
            ModelsSelectorForm.checkBox62.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox62.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk63 = "true" Then
            ModelsSelectorForm.checkBox63.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox63.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk64 = "true" Then
            ModelsSelectorForm.checkBox64.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox64.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk65 = "true" Then
            ModelsSelectorForm.checkBox65.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox65.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk66 = "true" Then
            ModelsSelectorForm.checkBox66.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox66.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk67 = "true" Then
            ModelsSelectorForm.checkBox67.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox67.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk68 = "true" Then
            ModelsSelectorForm.checkBox68.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox68.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk69 = "true" Then
            ModelsSelectorForm.checkBox69.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox69.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk70 = "true" Then
            ModelsSelectorForm.checkBox70.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox70.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk71 = "true" Then
            ModelsSelectorForm.checkBox71.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox71.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk72 = "true" Then
            ModelsSelectorForm.checkBox72.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox72.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk73 = "true" Then
            ModelsSelectorForm.checkBox73.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox73.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk74 = "true" Then
            ModelsSelectorForm.checkBox74.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox74.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk75 = "true" Then
            ModelsSelectorForm.checkBox75.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox75.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk76 = "true" Then
            ModelsSelectorForm.checkBox76.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox76.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk77 = "true" Then
            ModelsSelectorForm.checkBox77.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox77.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk78 = "true" Then
            ModelsSelectorForm.checkBox78.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox78.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk79 = "true" Then
            ModelsSelectorForm.checkBox79.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox79.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk80 = "true" Then
            ModelsSelectorForm.checkBox80.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox80.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk81 = "true" Then
            ModelsSelectorForm.checkBox81.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox81.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk82 = "true" Then
            ModelsSelectorForm.checkBox82.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox82.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk83 = "true" Then
            ModelsSelectorForm.checkBox83.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox83.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk84 = "true" Then
            ModelsSelectorForm.checkBox84.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox84.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk85 = "true" Then
            ModelsSelectorForm.checkBox85.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox85.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk86 = "true" Then
            ModelsSelectorForm.checkBox86.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox86.CheckState = CheckState.Unchecked
        End If
        If SaveVars.chk87 = "true" Then
            ModelsSelectorForm.checkBox87.CheckState = CheckState.Checked
        Else
            ModelsSelectorForm.checkBox87.CheckState = CheckState.Unchecked
        End If
    End Sub

    Private Sub AdvSetSaveProgress()
        If SaveVars.ChangeFromChk = "true" Then
            AdvancedSettings.changecheck.CheckState = CheckState.Checked
        Else
            AdvancedSettings.changecheck.CheckState = CheckState.Unchecked
        End If

        If SaveVars.HoChk = "true" Then
            AdvancedSettings.HoboCheck.CheckState = CheckState.Checked
        Else
            AdvancedSettings.HoboCheck.CheckState = CheckState.Unchecked
        End If

        If SaveVars.Medchk = "true" Then
            AdvancedSettings.MedicCheck.CheckState = CheckState.Checked
        Else
            AdvancedSettings.MedicCheck.CheckState = CheckState.Unchecked
        End If

        If SaveVars.MayChk = "true" Then
            AdvancedSettings.MayorCheck.CheckState = CheckState.Checked
        Else
            AdvancedSettings.MayorCheck.CheckState = CheckState.Unchecked
        End If

        If SaveVars.ChiChk = "true" Then
            AdvancedSettings.ChiefCheck.CheckState = CheckState.Checked
        Else
            AdvancedSettings.ChiefCheck.CheckState = CheckState.Unchecked
        End If

        If SaveVars.CoChk = "true" Then
            AdvancedSettings.CookCheck.CheckState = CheckState.Checked
        Else
            AdvancedSettings.CookCheck.CheckState = CheckState.Unchecked
        End If

        If SaveVars.ChangeFromTxt IsNot "TEAM_" Then
            AdvancedSettings.NeedChangeFromText.Text = SaveVars.ChangeFromTxt
        End If
    End Sub

    Private Sub WeaponSelectorSaveProgress()
        If SaveVars.Wchk1 = "true" Then
            WeaponSelectorForm.CheckBox1.CheckState = CheckState.Checked
        Else
            WeaponSelectorForm.CheckBox1.CheckState = CheckState.Unchecked
        End If
        If SaveVars.Wchk2 = "true" Then
            WeaponSelectorForm.CheckBox2.CheckState = CheckState.Checked
        Else
            WeaponSelectorForm.CheckBox2.CheckState = CheckState.Unchecked
        End If
        If SaveVars.Wchk3 = "true" Then
            WeaponSelectorForm.CheckBox3.CheckState = CheckState.Checked
        Else
            WeaponSelectorForm.CheckBox3.CheckState = CheckState.Unchecked
        End If
        If SaveVars.Wchk4 = "true" Then
            WeaponSelectorForm.CheckBox4.CheckState = CheckState.Checked
        Else
            WeaponSelectorForm.CheckBox4.CheckState = CheckState.Unchecked
        End If
        If SaveVars.Wchk5 = "true" Then
            WeaponSelectorForm.CheckBox5.CheckState = CheckState.Checked
        Else
            WeaponSelectorForm.CheckBox5.CheckState = CheckState.Unchecked
        End If
        If SaveVars.Wchk6 = "true" Then
            WeaponSelectorForm.CheckBox6.CheckState = CheckState.Checked
        Else
            WeaponSelectorForm.CheckBox6.CheckState = CheckState.Unchecked
        End If
        If SaveVars.Wchk7 = "true" Then
            WeaponSelectorForm.CheckBox7.CheckState = CheckState.Checked
        Else
            WeaponSelectorForm.CheckBox7.CheckState = CheckState.Unchecked
        End If
        If SaveVars.Wchk8 = "true" Then
            WeaponSelectorForm.CheckBox8.CheckState = CheckState.Checked
        Else
            WeaponSelectorForm.CheckBox8.CheckState = CheckState.Unchecked
        End If
        If SaveVars.Wchk9 = "true" Then
            WeaponSelectorForm.CheckBox9.CheckState = CheckState.Checked
        Else
            WeaponSelectorForm.CheckBox9.CheckState = CheckState.Unchecked
        End If
        If SaveVars.Wchk10 = "true" Then
            WeaponSelectorForm.CheckBox10.CheckState = CheckState.Checked
        Else
            WeaponSelectorForm.CheckBox10.CheckState = CheckState.Unchecked
        End If
        If SaveVars.Wchk11 = "true" Then
            WeaponSelectorForm.CheckBox11.CheckState = CheckState.Checked
        Else
            WeaponSelectorForm.CheckBox11.CheckState = CheckState.Unchecked
        End If
        If SaveVars.Wchk12 = "true" Then
            WeaponSelectorForm.CheckBox12.CheckState = CheckState.Checked
        Else
            WeaponSelectorForm.CheckBox12.CheckState = CheckState.Unchecked
        End If
        If SaveVars.Wchk13 = "true" Then
            WeaponSelectorForm.CheckBox13.CheckState = CheckState.Checked
        Else
            WeaponSelectorForm.CheckBox13.CheckState = CheckState.Unchecked
        End If
        If SaveVars.Wchk14 = "true" Then
            WeaponSelectorForm.CheckBox14.CheckState = CheckState.Checked
        Else
            WeaponSelectorForm.CheckBox14.CheckState = CheckState.Unchecked
        End If
        If SaveVars.Wchk15 = "true" Then
            WeaponSelectorForm.CheckBox15.CheckState = CheckState.Checked
        Else
            WeaponSelectorForm.CheckBox15.CheckState = CheckState.Unchecked
        End If
        If SaveVars.Wchk16 = "true" Then
            WeaponSelectorForm.CheckBox16.CheckState = CheckState.Checked
        Else
            WeaponSelectorForm.CheckBox16.CheckState = CheckState.Unchecked
        End If
        If SaveVars.Wchk17 = "true" Then
            WeaponSelectorForm.CheckBox17.CheckState = CheckState.Checked
        Else
            WeaponSelectorForm.CheckBox17.CheckState = CheckState.Unchecked
        End If
        If SaveVars.Wchk18 = "true" Then
            WeaponSelectorForm.CheckBox18.CheckState = CheckState.Checked
        Else
            WeaponSelectorForm.CheckBox18.CheckState = CheckState.Unchecked
        End If
        If SaveVars.Wchk19 = "true" Then
            WeaponSelectorForm.CheckBox19.CheckState = CheckState.Checked
        Else
            WeaponSelectorForm.CheckBox19.CheckState = CheckState.Unchecked
        End If
        If SaveVars.Wchk20 = "true" Then
            WeaponSelectorForm.CheckBox20.CheckState = CheckState.Checked
        Else
            WeaponSelectorForm.CheckBox20.CheckState = CheckState.Unchecked
        End If
        If SaveVars.Wchk21 = "true" Then
            WeaponSelectorForm.CheckBox21.CheckState = CheckState.Checked
        Else
            WeaponSelectorForm.CheckBox21.CheckState = CheckState.Unchecked
        End If
        If SaveVars.Wchk22 = "true" Then
            WeaponSelectorForm.CheckBox22.CheckState = CheckState.Checked
        Else
            WeaponSelectorForm.CheckBox22.CheckState = CheckState.Unchecked
        End If
        If SaveVars.Wchk23 = "true" Then
            WeaponSelectorForm.CheckBox23.CheckState = CheckState.Checked
        Else
            WeaponSelectorForm.CheckBox23.CheckState = CheckState.Unchecked
        End If
        If SaveVars.Wchk24 = "true" Then
            WeaponSelectorForm.CheckBox24.CheckState = CheckState.Checked
        Else
            WeaponSelectorForm.CheckBox24.CheckState = CheckState.Unchecked
        End If
        If SaveVars.Wchk25 = "true" Then
            WeaponSelectorForm.CheckBox25.CheckState = CheckState.Checked
        Else
            WeaponSelectorForm.CheckBox25.CheckState = CheckState.Unchecked
        End If
        If SaveVars.Wchk26 = "true" Then
            WeaponSelectorForm.CheckBox26.CheckState = CheckState.Checked
        Else
            WeaponSelectorForm.CheckBox26.CheckState = CheckState.Unchecked
        End If
        If SaveVars.Wchk27 = "true" Then
            WeaponSelectorForm.CheckBox27.CheckState = CheckState.Checked
        Else
            WeaponSelectorForm.CheckBox27.CheckState = CheckState.Unchecked
        End If
        If SaveVars.Wchk28 = "true" Then
            WeaponSelectorForm.CheckBox28.CheckState = CheckState.Checked
        Else
            WeaponSelectorForm.CheckBox28.CheckState = CheckState.Unchecked
        End If
        If SaveVars.Wchk29 = "true" Then
            WeaponSelectorForm.CheckBox29.CheckState = CheckState.Checked
        Else
            WeaponSelectorForm.CheckBox29.CheckState = CheckState.Unchecked
        End If
        If SaveVars.Wchk30 = "true" Then
            WeaponSelectorForm.CheckBox30.CheckState = CheckState.Checked
        Else
            WeaponSelectorForm.CheckBox30.CheckState = CheckState.Unchecked
        End If
        If SaveVars.Wchk31 = "true" Then
            WeaponSelectorForm.CheckBox31.CheckState = CheckState.Checked
        Else
            WeaponSelectorForm.CheckBox31.CheckState = CheckState.Unchecked
        End If

    End Sub

    Private Sub Button1_Click_3(sender As Object, e As EventArgs) Handles WeaponShow.Click
        WeaponSelectorForm.Show()
        LoadLanguages()
        WeaponSelectorSaveProgress()
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UpdateToolStripMenuItem.Click

        If (Thread.CurrentThread.CurrentUICulture Is CultureInfo.GetCultureInfo("ru-RU")) Then
            MessageBox.Show("Пока не готово!")
        Else
            MessageBox.Show("Not implemented yet!")
        End If
    End Sub

    Private Sub CmdWork()

        Dim delpath = Environment.CurrentDirectory + "\JobMaker.exe"
        Dim movepath = Environment.CurrentDirectory + "\Update.exe"
        Dim killproc = "JobMaker.exe"

        Dim Process = New Process()
        Process.StartInfo.FileName = "cmd.exe"
        Process.StartInfo.Arguments = "/C taskkill /IM " + Chr(34) + killproc + Chr(34) + "& Timeout 1  & Del /F " + Chr(34) + delpath + Chr(34) + " & Move /Y " + Chr(34) + movepath + Chr(34) + " " + Chr(34) + delpath + Chr(34) + " & START " + Chr(34) + Chr(34) + " " + Chr(34) + delpath + Chr(34)
        File.Create("updated.txt")
        Process.Start()
    End Sub
End Class
