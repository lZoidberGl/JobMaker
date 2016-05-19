Imports System.Globalization
Imports System.Threading
Imports JobMaker.My.Resources
Imports JobMaker.ModelsSelectorForm

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''---------SET LOCALIZATION----------''

        If (CultureInfo.InstalledUICulture.EnglishName = "Russian (Russia)") Then
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("ru-RU")
        Else
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US")
        End If

        ''---------SET LOCALIZATION----------''
        LoadDefaults()
    End Sub

    Private Sub LoadDefaults()
        If (Thread.CurrentThread.CurrentUICulture Is CultureInfo.GetCultureInfo("en-US")) Then

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
        End If

        If (Thread.CurrentThread.CurrentUICulture Is CultureInfo.GetCultureInfo("ru-RU")) Then

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
        End If
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
    End Sub

    Private Sub LangSelector_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LangSelector.SelectedIndexChanged
        If (LangSelector.SelectedIndex = 0) Then
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("ru-RU")
            LoadDefaults()
        Else
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo("en-US")
            LoadDefaults()
        End If

    End Sub

    Private Sub GenCode_Click(sender As Object, e As EventArgs) Handles GenCode.Click
        GenerateCode()
    End Sub

    Private Sub GenerateCode()

    End Sub
End Class
