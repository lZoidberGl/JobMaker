Imports JobMaker.Form1
Public Class AdvancedSettings

    Private Sub AdvancedSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub NeedChangeFromText_TextChanged(sender As Object, e As EventArgs)
        If NeedChangeFromText.Text IsNot "" Then
            ChangeFromPanel.BackColor = Color.Lime
        Else
            ChangeFromPanel.BackColor = Color.Red
        End If
        Try
            Form1.GenerateCode()
        Catch ex As Exception

        End Try
        SaveVars.ChangeFromTxt = NeedChangeFromText.Text
    End Sub

    Private Sub changecheck_CheckedChanged(sender As Object, e As EventArgs) Handles changecheck.CheckedChanged
        If changecheck.Checked Then
            ChangeFromPanel.Enabled = True
            SaveVars.ChangeFromChk = "true"
        Else
            ChangeFromPanel.Enabled = False
            SaveVars.ChangeFromChk = "false"
        End If
        Form1.GenerateCode()
    End Sub

    Private Sub ChiefCheck_CheckedChanged(sender As Object, e As EventArgs) Handles ChiefCheck.CheckedChanged
        If ChiefCheck.Checked Then
            SaveVars.ChiChk = "true"
        Else
            SaveVars.ChiChk = "false"
        End If
        Form1.GenerateCode()
    End Sub

    Private Sub MedicCheck_CheckedChanged(sender As Object, e As EventArgs) Handles MedicCheck.CheckedChanged
        If MedicCheck.Checked Then
            SaveVars.Medchk = "true"
        Else
            SaveVars.Medchk = "false"
        End If
        Form1.GenerateCode()
    End Sub

    Private Sub MayorCheck_CheckedChanged(sender As Object, e As EventArgs) Handles MayorCheck.CheckedChanged
        If MayorCheck.Checked Then
            SaveVars.MayChk = "true"
        Else
            SaveVars.MayChk = "false"
        End If
        Form1.GenerateCode()
    End Sub

    Private Sub HoboCheck_CheckedChanged(sender As Object, e As EventArgs) Handles HoboCheck.CheckedChanged
        If HoboCheck.Checked Then
            SaveVars.HoChk = "true"
        Else
            SaveVars.HoChk = "false"
        End If
        Form1.GenerateCode()
    End Sub

    Private Sub CookCheck_CheckedChanged(sender As Object, e As EventArgs) Handles CookCheck.CheckedChanged
        If CookCheck.Checked Then
            SaveVars.CoChk = "true"
        Else
            SaveVars.CoChk = "false"
        End If
        Form1.GenerateCode()
    End Sub
End Class