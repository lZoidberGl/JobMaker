Public Class WeaponSelectorForm
    Private Sub WeaponSelectorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            SaveVars.Wchk1 = "true"
            Label1.Text = Chr(34) + "weapon_357" + Chr(34) + ", "
        Else
            SaveVars.Wchk1 = "false"
            Label1.Text = ""
        End If

        DoItTogether()
        Form1.GenerateCode()
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            SaveVars.Wchk2 = "true"
            Label2.Text = Chr(34) + "weapon_ar2" + Chr(34) + ", "
        Else
            SaveVars.Wchk2 = "false"
            Label2.Text = ""
        End If

        DoItTogether()
        Form1.GenerateCode()
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            SaveVars.Wchk3 = "true"
            Label3.Text = Chr(34) + "weapon_pistol" + Chr(34) + ", "
        Else
            SaveVars.Wchk3 = "false"
            Label3.Text = ""
        End If

        DoItTogether()
        Form1.GenerateCode()
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked Then
            SaveVars.Wchk4 = "true"
            Label4.Text = Chr(34) + "weapon_stunstick" + Chr(34) + ", "
        Else
            SaveVars.Wchk4 = "false"
            Label4.Text = ""
        End If

        DoItTogether()
        Form1.GenerateCode()
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked Then
            SaveVars.Wchk5 = "true"
            Label5.Text = Chr(34) + "weapon_bugbait" + Chr(34) + ", "
        Else
            SaveVars.Wchk5 = "false"
            Label5.Text = ""
        End If

        DoItTogether()
        Form1.GenerateCode()
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked Then
            SaveVars.Wchk6 = "true"
            Label6.Text = Chr(34) + "weapon_crossbow" + Chr(34) + ", "
        Else
            SaveVars.Wchk6 = "false"
            Label6.Text = ""
        End If

        DoItTogether()
        Form1.GenerateCode()
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.Checked Then
            SaveVars.Wchk7 = "true"
            Label7.Text = Chr(34) + "weapon_crowbar" + Chr(34) + ", "
        Else
            SaveVars.Wchk7 = "false"
            Label7.Text = ""
        End If

        DoItTogether()
        Form1.GenerateCode()
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.CheckedChanged
        If CheckBox8.Checked Then
            SaveVars.Wchk8 = "true"
            Label8.Text = Chr(34) + "weapon_frag" + Chr(34) + ", "
        Else
            SaveVars.Wchk8 = "false"
            Label8.Text = ""
        End If

        DoItTogether()
        Form1.GenerateCode()
    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.CheckedChanged
        If CheckBox9.Checked Then
            SaveVars.Wchk9 = "true"
            Label9.Text = Chr(34) + "weapon_smg1" + Chr(34) + ", "
        Else
            SaveVars.Wchk9 = "false"
            Label9.Text = ""
        End If

        DoItTogether()
        Form1.GenerateCode()
    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox10.CheckedChanged
        If CheckBox10.Checked Then
            SaveVars.Wchk10 = "true"
            Label10.Text = Chr(34) + "weapon_shotgun" + Chr(34) + ", "
        Else
            SaveVars.Wchk10 = "false"
            Label10.Text = ""
        End If

        DoItTogether()
        Form1.GenerateCode()
    End Sub

    Private Sub CheckBox11_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox11.CheckedChanged
        If CheckBox11.Checked Then
            SaveVars.Wchk11 = "true"
            Label11.Text = Chr(34) + "weapon_rpg" + Chr(34) + ", "
        Else
            SaveVars.Wchk11 = "false"
            Label11.Text = ""
        End If

        DoItTogether()
        Form1.GenerateCode()
    End Sub

    Private Sub CheckBox12_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox12.CheckedChanged
        If CheckBox12.Checked Then
            SaveVars.Wchk12 = "true"
            Label12.Text = Chr(34) + "weapon_fists" + Chr(34) + ", "
        Else
            SaveVars.Wchk12 = "false"
            Label12.Text = ""
        End If

        DoItTogether()
        Form1.GenerateCode()
    End Sub

    Private Sub CheckBox13_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox13.CheckedChanged
        If CheckBox13.Checked Then
            SaveVars.Wchk13 = "true"
            Label13.Text = Chr(34) + "weapon_slam" + Chr(34) + ", "
        Else
            SaveVars.Wchk13 = "false"
            Label13.Text = ""
        End If

        DoItTogether()
        Form1.GenerateCode()
    End Sub

    Private Sub CheckBox14_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox14.CheckedChanged
        If CheckBox14.Checked Then
            SaveVars.Wchk14 = "true"
            Label14.Text = Chr(34) + "weapon_ak472" + Chr(34) + ", "
        Else
            SaveVars.Wchk14 = "false"
            Label14.Text = ""
        End If

        DoItTogether()
        Form1.GenerateCode()
    End Sub

    Private Sub CheckBox15_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox15.CheckedChanged
        If CheckBox15.Checked Then
            SaveVars.Wchk15 = "true"
            Label15.Text = Chr(34) + "weapon_deagle2" + Chr(34) + ", "
        Else
            SaveVars.Wchk15 = "false"
            Label15.Text = ""
        End If

        DoItTogether()
        Form1.GenerateCode()
    End Sub

    Private Sub CheckBox16_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox16.CheckedChanged
        If CheckBox16.Checked Then
            SaveVars.Wchk16 = "true"
            Label16.Text = Chr(34) + "weapon_fiveseven2" + Chr(34) + ", "
        Else
            SaveVars.Wchk16 = "false"
            Label16.Text = ""
        End If

        DoItTogether()
        Form1.GenerateCode()
    End Sub

    Private Sub CheckBox17_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox17.CheckedChanged
        If CheckBox17.Checked Then
            SaveVars.Wchk17 = "true"
            Label17.Text = Chr(34) + "weapon_glock2" + Chr(34) + ", "
        Else
            SaveVars.Wchk17 = "false"
            Label17.Text = ""
        End If

        DoItTogether()
        Form1.GenerateCode()
    End Sub

    Private Sub CheckBox18_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox18.CheckedChanged
        If CheckBox18.Checked Then
            SaveVars.Wchk18 = "true"
            Label18.Text = Chr(34) + "weapon_m42" + Chr(34) + ", "
        Else
            SaveVars.Wchk18 = "false"
            Label18.Text = ""
        End If

        DoItTogether()
        Form1.GenerateCode()
    End Sub

    Private Sub CheckBox19_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox19.CheckedChanged
        If CheckBox19.Checked Then
            SaveVars.Wchk19 = "true"
            Label19.Text = Chr(34) + "weapon_mac102" + Chr(34) + ", "
        Else
            SaveVars.Wchk19 = "false"
            Label19.Text = ""
        End If

        DoItTogether()
        Form1.GenerateCode()
    End Sub

    Private Sub CheckBox20_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox20.CheckedChanged
        If CheckBox20.Checked Then
            SaveVars.Wchk20 = "true"
            Label20.Text = Chr(34) + "weapon_mp52" + Chr(34) + ", "
        Else
            SaveVars.Wchk20 = "false"
            Label20.Text = ""
        End If

        DoItTogether()
        Form1.GenerateCode()
    End Sub

    Private Sub CheckBox21_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox21.CheckedChanged
        If CheckBox21.Checked Then
            SaveVars.Wchk21 = "true"
            Label21.Text = Chr(34) + "weapon_p2282" + Chr(34) + ", "
        Else
            SaveVars.Wchk21 = "false"
            Label21.Text = ""
        End If

        DoItTogether()
        Form1.GenerateCode()
    End Sub

    Private Sub CheckBox22_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox22.CheckedChanged
        If CheckBox22.Checked Then
            SaveVars.Wchk22 = "true"
            Label22.Text = Chr(34) + "weapon_pumpshotgun2" + Chr(34) + ", "
        Else
            SaveVars.Wchk22 = "false"
            Label22.Text = ""
        End If

        DoItTogether()
        Form1.GenerateCode()
    End Sub

    Private Sub CheckBox23_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox23.CheckedChanged
        If CheckBox23.Checked Then
            SaveVars.Wchk23 = "true"
            Label23.Text = Chr(34) + "ls_sniper" + Chr(34) + ", "
        Else
            SaveVars.Wchk23 = "false"
            Label23.Text = ""
        End If

        DoItTogether()
        Form1.GenerateCode()
    End Sub

    Private Sub CheckBox24_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox24.CheckedChanged
        If CheckBox24.Checked Then
            SaveVars.Wchk24 = "true"
            Label24.Text = Chr(34) + "unarrest_stick" + Chr(34) + ", "
        Else
            SaveVars.Wchk24 = "false"
            Label24.Text = ""
        End If

        DoItTogether()
        Form1.GenerateCode()
    End Sub

    Private Sub CheckBox25_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox25.CheckedChanged
        If CheckBox25.Checked Then
            SaveVars.Wchk25 = "true"
            Label25.Text = Chr(34) + "arrest_stick" + Chr(34) + ", "
        Else
            SaveVars.Wchk25 = "false"
            Label25.Text = ""
        End If

        DoItTogether()
        Form1.GenerateCode()
    End Sub

    Private Sub CheckBox26_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox26.CheckedChanged
        If CheckBox26.Checked Then
            SaveVars.Wchk26 = "true"
            Label26.Text = Chr(34) + "door_ram" + Chr(34) + ", "
        Else
            SaveVars.Wchk26 = "false"
            Label26.Text = ""
        End If

        DoItTogether()
        Form1.GenerateCode()
    End Sub

    Private Sub CheckBox27_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox27.CheckedChanged
        If CheckBox27.Checked Then
            SaveVars.Wchk27 = "true"
            Label27.Text = Chr(34) + "weaponchecker" + Chr(34) + ", "
        Else
            SaveVars.Wchk27 = "false"
            Label27.Text = ""
        End If

        DoItTogether()
        Form1.GenerateCode()
    End Sub

    Private Sub CheckBox28_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox28.CheckedChanged
        If CheckBox28.Checked Then
            SaveVars.Wchk28 = "true"
            Label28.Text = Chr(34) + "stunstick" + Chr(34) + ", "
        Else
            SaveVars.Wchk28 = "false"
            Label28.Text = ""
        End If

        DoItTogether()
        Form1.GenerateCode()
    End Sub

    Private Sub CheckBox29_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox29.CheckedChanged
        If CheckBox29.Checked Then
            SaveVars.Wchk29 = "true"
            Label29.Text = Chr(34) + "med_kit" + Chr(34) + ", "
        Else
            SaveVars.Wchk29 = "false"
            Label29.Text = ""
        End If

        DoItTogether()
        Form1.GenerateCode()
    End Sub

    Private Sub CheckBox30_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox30.CheckedChanged
        If CheckBox30.Checked Then
            SaveVars.Wchk30 = "true"
            Label30.Text = Chr(34) + "lockpick" + Chr(34) + ", "
        Else
            SaveVars.Wchk30 = "false"
            Label30.Text = ""
        End If

        DoItTogether()
        Form1.GenerateCode()
    End Sub

    Private Sub CheckBox31_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox31.CheckedChanged
        If CheckBox31.Checked Then
            SaveVars.Wchk31 = "true"
            Label31.Text = Chr(34) + "weapon_medkit" + Chr(34) + ", "
        Else
            SaveVars.Wchk31 = "false"
            Label31.Text = ""
        End If

        DoItTogether()
        Form1.GenerateCode()
    End Sub

    Private Sub DoItTogether()
        Dim MainString As String = Label1.Text + Label2.Text + Label3.Text + Label4.Text + Label5.Text + Label6.Text + Label7.Text + Label8.Text + Label9.Text + Label10.Text + Label11.Text + Label12.Text + Label13.Text + Label14.Text + Label15.Text + Label16.Text + Label17.Text + Label18.Text + Label19.Text + Label20.Text + Label21.Text + Label22.Text + Label23.Text + Label24.Text + Label25.Text + Label26.Text + Label27.Text + Label28.Text + Label29.Text + Label30.Text + Label31.Text
        If MainString > "" Then
            Form1.JobWeaponsBox.Text = MainString.Substring(0, MainString.Length - 2)
        Else
            Form1.JobWeaponsBox.Text = ""
        End If
    End Sub
End Class