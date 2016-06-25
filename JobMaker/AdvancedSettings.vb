Imports JobMaker.Form1
Public Class AdvancedSettings

    Private Sub AdvancedSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        changecheck.CheckState = CheckState.Checked
        changecheck.CheckState = CheckState.Unchecked
    End Sub

    Private Sub NeedChangeFromText_TextChanged(sender As Object, e As EventArgs) Handles NeedChangeFromText.TextChanged
        If NeedCangeFromPanel.Enabled Then
            If NeedChangeFromText.Text IsNot "" Then
                If NeedChangeFromText.Text > "TEAM_" Then
                    ChangeFromPanel.BackColor = Color.Lime
                Else
                    ChangeFromPanel.BackColor = Color.Red
                End If
            Else
                ChangeFromPanel.BackColor = Color.Red
            End If

            Try
                Form1.GenerateCode()
            Catch ex As Exception

            End Try

            SaveVars.ChangeFromTxt = NeedChangeFromText.Text
        End If
    End Sub

    Private Sub changecheck_CheckedChanged(sender As Object, e As EventArgs) Handles changecheck.CheckedChanged
        If changecheck.Checked Then
            SaveVars.ChangeFromChk = "true"
            ChangeFromPanel.Enabled = True
            If NeedChangeFromText.Text IsNot "" Then
                If NeedChangeFromText.Text > "TEAM_" Then
                    ChangeFromPanel.BackColor = Color.Lime
                Else
                    ChangeFromPanel.BackColor = Color.Red
                End If
            Else
                ChangeFromPanel.BackColor = Color.Red
            End If
        Else
            SaveVars.ChangeFromChk = "false"
            ChangeFromPanel.Enabled = False
            ChangeFromPanel.BackColor = Color.LightGray
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

    Private Sub DeathCheck_CheckedChanged(sender As Object, e As EventArgs) Handles DeathCheck.CheckedChanged
        If DeathCheck.Checked Then
            SaveVars.DeadCheck = "true"
        Else
            SaveVars.DeadCheck = "false"
        End If
        Form1.GenerateCode()
    End Sub

    Private Sub CustomCheckGroup_TextChanged(sender As Object, e As EventArgs) Handles CustomCheckGroup.TextChanged
        If CustomCheckGroup.Text IsNot "" Then
            CustomCheckPanel.BackColor = Color.Lime
        Else
            CustomCheckPanel.BackColor = Color.Red
        End If
        Try
            Form1.GenerateCode()
        Catch ex As Exception

        End Try
        SaveVars.CustomCheckTxt = CustomCheckGroup.Text
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CustomChckCheck.CheckedChanged
        If CustomChckCheck.Checked Then
            SaveVars.CustomCheckChk = "true"
            CustomCheckPanel.Enabled = True
            If CustomCheckGroup.Text = "" Then
                CustomCheckPanel.BackColor = Color.Red
            Else
                CustomCheckPanel.BackColor = Color.Lime
            End If
        Else
            SaveVars.CustomCheckChk = "false"
            CustomCheckPanel.Enabled = False
            CustomCheckPanel.BackColor = Color.LightGray
        End If
        Try
            Form1.GenerateCode()
        Catch ex As Exception

        End Try
    End Sub
End Class