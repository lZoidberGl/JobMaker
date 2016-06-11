Public Class ModelsSelectorForm
    Public Sub ModelsSelectorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub checkBox1_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox1.CheckedChanged
        If checkBox1.Checked Then
            panel1.BackColor = Color.Lime
            label1.Text = Chr(34) + "models/player/alyx.mdl" + Chr(34) + ","
            SaveVars.chk1 = "true"
        Else
            panel1.BackColor = Color.Red
            label1.Text = ""
            SaveVars.chk1 = "false"
        End If
    End Sub

    Public Sub checkBox2_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox2.CheckedChanged
        If checkBox2.Checked Then
            panel2.BackColor = Color.Lime
            label2.Text = Chr(34) + "models/player/barney.mdl" + Chr(34) + ","
            SaveVars.chk2 = "true"
        Else
            panel2.BackColor = Color.Red
            label2.Text = ""
            SaveVars.chk2 = "false"
        End If
    End Sub

    Public Sub checkBox3_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox3.CheckedChanged
        If checkBox3.Checked Then
            panel3.BackColor = Color.Lime
            label3.Text = Chr(34) + "models/player/breen.mdl" + Chr(34) + ","
            SaveVars.chk3 = "true"
        Else
            panel3.BackColor = Color.Red
            label3.Text = ""
            SaveVars.chk3 = "false"
        End If
    End Sub

    Public Sub checkBox4_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox4.CheckedChanged
        If checkBox4.Checked Then
            panel4.BackColor = Color.Lime
            label4.Text = Chr(34) + "models/player/charple.mdl" + Chr(34) + ","
            SaveVars.chk4 = "true"
        Else
            panel4.BackColor = Color.Red
            label4.Text = ""
            SaveVars.chk4 = "false"
        End If
    End Sub

    Public Sub checkBox5_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox5.CheckedChanged
        If checkBox5.Checked Then
            panel5.BackColor = Color.Lime
            label5.Text = Chr(34) + "models/player/p2_chell.mdl" + Chr(34) + ","
            SaveVars.chk5 = "true"
        Else
            panel5.BackColor = Color.Red
            label5.Text = ""
            SaveVars.chk5 = "false"
        End If
    End Sub

    Public Sub checkBox6_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox6.CheckedChanged
        If checkBox6.Checked Then
            panel6.BackColor = Color.Lime
            label6.Text = Chr(34) + "models/player/combine_soldier.mdl" + Chr(34) + ","
            SaveVars.chk6 = "true"
        Else
            panel6.BackColor = Color.Red
            label6.Text = ""
            SaveVars.chk6 = "false"
        End If
    End Sub

    Public Sub checkBox7_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox7.CheckedChanged
        If checkBox7.Checked Then
            panel7.BackColor = Color.Lime
            label7.Text = Chr(34) + "models/player/combine_super_soldier.mdl" + Chr(34) + ","
            SaveVars.chk7 = "true"
        Else
            panel7.BackColor = Color.Red
            label7.Text = ""
            SaveVars.chk7 = "false"
        End If
    End Sub

    Public Sub checkBox8_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox8.CheckedChanged
        If checkBox8.Checked Then
            panel8.BackColor = Color.Lime
            label8.Text = Chr(34) + "models/player/combine_soldier_prisonguard.mdl" + Chr(34) + ","
            SaveVars.chk8 = "true"
        Else
            panel8.BackColor = Color.Red
            label8.Text = ""
            SaveVars.chk8 = "false"
        End If
    End Sub

    Public Sub checkBox9_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox9.CheckedChanged
        If checkBox9.Checked Then
            panel9.BackColor = Color.Lime
            label9.Text = Chr(34) + "models/player/corpse1.mdl" + Chr(34) + ","
            SaveVars.chk9 = "true"
        Else
            panel9.BackColor = Color.Red
            label9.Text = ""
            SaveVars.chk9 = "false"
        End If
    End Sub

    Public Sub checkBox10_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox10.CheckedChanged
        If checkBox10.Checked Then
            panel10.BackColor = Color.Lime
            label10.Text = Chr(34) + "models/player/arctic.mdl" + Chr(34) + ","
            SaveVars.chk10 = "true"
        Else
            panel10.BackColor = Color.Red
            label10.Text = ""
            SaveVars.chk10 = "false"
        End If
    End Sub

    Public Sub checkBox11_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox11.CheckedChanged
        If checkBox11.Checked Then
            panel11.BackColor = Color.Lime
            label11.Text = Chr(34) + "models/player/gasmask.mdl" + Chr(34) + ","
            SaveVars.chk11 = "true"
        Else
            panel11.BackColor = Color.Red
            label11.Text = ""
            SaveVars.chk11 = "false"
        End If
    End Sub

    Public Sub checkBox12_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox12.CheckedChanged
        If checkBox12.Checked Then
            panel12.BackColor = Color.Lime
            label12.Text = Chr(34) + "models/player/guerilla.mdl" + Chr(34) + ","
            SaveVars.chk12 = "true"
        Else
            panel12.BackColor = Color.Red
            label12.Text = ""
            SaveVars.chk12 = "false"
        End If
    End Sub

    Public Sub checkBox13_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox13.CheckedChanged
        If checkBox13.Checked Then
            panel13.BackColor = Color.Lime
            label13.Text = Chr(34) + "models/player/leet.mdl" + Chr(34) + ","
            SaveVars.chk13 = "true"
        Else
            panel13.BackColor = Color.Red
            label13.Text = ""
            SaveVars.chk13 = "false"
        End If
    End Sub

    Public Sub checkBox14_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox14.CheckedChanged
        If checkBox14.Checked Then
            panel14.BackColor = Color.Lime
            label14.Text = Chr(34) + "models/player/phoenix.mdl" + Chr(34) + ","
            SaveVars.chk14 = "true"
        Else
            panel14.BackColor = Color.Red
            label14.Text = ""
            SaveVars.chk14 = "false"
        End If
    End Sub

    Public Sub checkBox15_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox15.CheckedChanged
        If checkBox15.Checked Then
            panel15.BackColor = Color.Lime
            label15.Text = Chr(34) + "models/player/riot.mdl" + Chr(34) + ","
            SaveVars.chk15 = "true"
        Else
            panel15.BackColor = Color.Red
            label15.Text = ""
            SaveVars.chk15 = "false"
        End If
    End Sub

    Public Sub checkBox16_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox16.CheckedChanged
        If checkBox16.Checked Then
            panel16.BackColor = Color.Lime
            label16.Text = Chr(34) + "models/player/swat.mdl" + Chr(34) + ","
            SaveVars.chk16 = "true"
        Else
            panel16.BackColor = Color.Red
            label16.Text = ""
            SaveVars.chk16 = "false"
        End If
    End Sub

    Public Sub checkBox17_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox17.CheckedChanged
        If checkBox17.Checked Then
            panel17.BackColor = Color.Lime
            label17.Text = Chr(34) + "models/player/urban.mdl" + Chr(34) + ","
            SaveVars.chk17 = "true"
        Else
            panel17.BackColor = Color.Red
            label17.Text = ""
            SaveVars.chk17 = "false"
        End If
    End Sub

    Public Sub checkBox18_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox18.CheckedChanged
        If checkBox18.Checked Then
            panel18.BackColor = Color.Lime
            label18.Text = Chr(34) + "models/player/eli.mdl" + Chr(34) + ","
            SaveVars.chk18 = "true"
        Else
            panel18.BackColor = Color.Red
            label18.Text = ""
            SaveVars.chk18 = "false"
        End If
    End Sub

    Public Sub checkBox19_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox19.CheckedChanged
        If checkBox19.Checked Then
            panel19.BackColor = Color.Lime
            label19.Text = Chr(34) + "models/player/Group01/female_01.mdl" + Chr(34) + ","
            SaveVars.chk19 = "true"
        Else
            panel19.BackColor = Color.Red
            label19.Text = ""
            SaveVars.chk19 = "false"
        End If
    End Sub

    Public Sub checkBox20_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox20.CheckedChanged
        If checkBox20.Checked Then
            panel20.BackColor = Color.Lime
            label20.Text = Chr(34) + "models/player/Group01/female_02.mdl" + Chr(34) + ","
            SaveVars.chk20 = "true"
        Else
            panel20.BackColor = Color.Red
            label20.Text = ""
            SaveVars.chk20 = "false"
        End If
    End Sub

    Public Sub checkBox21_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox21.CheckedChanged
        If checkBox21.Checked Then
            panel21.BackColor = Color.Lime
            label21.Text = Chr(34) + "models/player/Group01/female_03.mdl" + Chr(34) + ","
            SaveVars.chk21 = "true"
        Else
            panel21.BackColor = Color.Red
            label21.Text = ""
            SaveVars.chk21 = "false"
        End If
    End Sub

    Public Sub checkBox22_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox22.CheckedChanged
        If checkBox22.Checked Then
            panel22.BackColor = Color.Lime
            label22.Text = Chr(34) + "models/player/Group01/female_04.mdl" + Chr(34) + ","
            SaveVars.chk22 = "true"
        Else
            panel22.BackColor = Color.Red
            label22.Text = ""
            SaveVars.chk22 = "false"
        End If
    End Sub

    Public Sub checkBox23_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox23.CheckedChanged
        If checkBox23.Checked Then
            panel23.BackColor = Color.Lime
            label23.Text = Chr(34) + "models/player/Group01/female_05.mdl" + Chr(34) + ","
            SaveVars.chk23 = "true"
        Else
            panel23.BackColor = Color.Red
            label23.Text = ""
            SaveVars.chk23 = "false"
        End If
    End Sub

    Public Sub checkBox24_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox24.CheckedChanged
        If checkBox24.Checked Then
            panel24.BackColor = Color.Lime
            label24.Text = Chr(34) + "models/player/Group01/female_06.mdl" + Chr(34) + ","
            SaveVars.chk24 = "true"
        Else
            panel24.BackColor = Color.Red
            label24.Text = ""
            SaveVars.chk24 = "false"
        End If
    End Sub

    Public Sub checkBox25_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox25.CheckedChanged
        If checkBox25.Checked Then
            panel25.BackColor = Color.Lime
            label25.Text = Chr(34) + "models/player/Group03/female_01.mdl" + Chr(34) + ","
            SaveVars.chk25 = "true"
        Else
            panel25.BackColor = Color.Red
            label25.Text = ""
            SaveVars.chk25 = "false"
        End If
    End Sub

    Public Sub checkBox26_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox26.CheckedChanged
        If checkBox26.Checked Then
            panel26.BackColor = Color.Lime
            label26.Text = Chr(34) + "models/player/Group03/female_02.mdl" + Chr(34) + ","
            SaveVars.chk26 = "true"
        Else
            panel26.BackColor = Color.Red
            label26.Text = ""
            SaveVars.chk26 = "false"
        End If
    End Sub

    Public Sub checkBox27_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox27.CheckedChanged
        If checkBox27.Checked Then
            panel27.BackColor = Color.Lime
            label27.Text = Chr(34) + "models/player/Group03/female_03.mdl" + Chr(34) + ","
            SaveVars.chk27 = "true"
        Else
            panel27.BackColor = Color.Red
            label27.Text = ""
            SaveVars.chk27 = "false"
        End If
    End Sub

    Public Sub checkBox28_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox28.CheckedChanged
        If checkBox28.Checked Then
            panel28.BackColor = Color.Lime
            label28.Text = Chr(34) + "models/player/Group03/female_04.mdl" + Chr(34) + ","
            SaveVars.chk28 = "true"
        Else
            panel28.BackColor = Color.Red
            label28.Text = ""
            SaveVars.chk28 = "false"
        End If
    End Sub

    Public Sub checkBox29_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox29.CheckedChanged
        If checkBox29.Checked Then
            panel29.BackColor = Color.Lime
            label29.Text = Chr(34) + "models/player/Group03/female_05.mdl" + Chr(34) + ","
            SaveVars.chk29 = "true"
        Else
            panel29.BackColor = Color.Red
            label29.Text = ""
            SaveVars.chk29 = "false"
        End If
    End Sub

    Public Sub checkBox30_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox30.CheckedChanged
        If checkBox30.Checked Then
            panel30.BackColor = Color.Lime
            label30.Text = Chr(34) + "models/player/Group03/female_06.mdl" + Chr(34) + ","
            SaveVars.chk30 = "true"
        Else
            panel30.BackColor = Color.Red
            label30.Text = ""
            SaveVars.chk30 = "false"
        End If
    End Sub

    Public Sub checkBox31_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox31.CheckedChanged
        If checkBox31.Checked Then
            panel31.BackColor = Color.Lime
            label31.Text = Chr(34) + "models/player/gman_high.mdl" + Chr(34) + ","
            SaveVars.chk31 = "true"
        Else
            panel31.BackColor = Color.Red
            label31.Text = ""
            SaveVars.chk31 = "false"
        End If
    End Sub

    Public Sub checkBox32_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox32.CheckedChanged
        If checkBox32.Checked Then
            panel32.BackColor = Color.Lime
            label32.Text = Chr(34) + "models/player/hostage/hostage_01.mdl" + Chr(34) + ","
            SaveVars.chk32 = "true"
        Else
            panel32.BackColor = Color.Red
            label32.Text = ""
            SaveVars.chk32 = "false"
        End If
    End Sub

    Public Sub checkBox33_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox33.CheckedChanged
        If checkBox33.Checked Then
            panel33.BackColor = Color.Lime
            label33.Text = Chr(34) + "models/player/hostage/hostage_02.mdl" + Chr(34) + ","
            SaveVars.chk33 = "true"
        Else
            panel33.BackColor = Color.Red
            label33.Text = ""
            SaveVars.chk33 = "false"
        End If
    End Sub

    Public Sub checkBox34_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox34.CheckedChanged
        If checkBox34.Checked Then
            panel34.BackColor = Color.Lime
            label34.Text = Chr(34) + "models/player/hostage/hostage_03.mdl" + Chr(34) + ","
            SaveVars.chk34 = "true"
        Else
            panel34.BackColor = Color.Red
            label34.Text = ""
            SaveVars.chk34 = "false"
        End If
    End Sub

    Public Sub checkBox35_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox35.CheckedChanged
        If checkBox35.Checked Then
            panel35.BackColor = Color.Lime
            label35.Text = Chr(34) + "models/player/hostage/hostage_04.mdl" + Chr(34) + ","
            SaveVars.chk35 = "true"
        Else
            panel35.BackColor = Color.Red
            label35.Text = ""
            SaveVars.chk35 = "false"
        End If
    End Sub

    Public Sub checkBox36_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox36.CheckedChanged
        If checkBox36.Checked Then
            panel36.BackColor = Color.Lime
            label36.Text = Chr(34) + "models/player/kleiner.mdl" + Chr(34) + ","
            SaveVars.chk36 = "true"
        Else
            panel36.BackColor = Color.Red
            label36.Text = ""
            SaveVars.chk36 = "false"
        End If
    End Sub

    Public Sub checkBox37_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox37.CheckedChanged
        If checkBox37.Checked Then
            panel37.BackColor = Color.Lime
            label37.Text = Chr(34) + "models/player/magnusson.mdl" + Chr(34) + ","
            SaveVars.chk37 = "true"
        Else
            panel37.BackColor = Color.Red
            label37.Text = ""
            SaveVars.chk37 = "false"
        End If
    End Sub

    Public Sub checkBox38_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox38.CheckedChanged
        If checkBox38.Checked Then
            panel38.BackColor = Color.Lime
            label38.Text = Chr(34) + "models/player/Group01/male_01.mdl" + Chr(34) + ","
            SaveVars.chk38 = "true"
        Else
            panel38.BackColor = Color.Red
            label38.Text = ""
            SaveVars.chk38 = "false"
        End If
    End Sub

    Public Sub checkBox39_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox39.CheckedChanged
        If checkBox39.Checked Then
            panel39.BackColor = Color.Lime
            label39.Text = Chr(34) + "models/player/Group01/male_02.mdl" + Chr(34) + ","
            SaveVars.chk39 = "true"
        Else
            panel39.BackColor = Color.Red
            label39.Text = ""
            SaveVars.chk39 = "false"
        End If
    End Sub

    Public Sub checkBox40_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox40.CheckedChanged
        If checkBox40.Checked Then
            panel40.BackColor = Color.Lime
            label40.Text = Chr(34) + "models/player/Group01/male_03.mdl" + Chr(34) + ","
            SaveVars.chk40 = "true"
        Else
            panel40.BackColor = Color.Red
            label40.Text = ""
            SaveVars.chk40 = "false"
        End If
    End Sub

    Public Sub checkBox41_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox41.CheckedChanged
        If checkBox41.Checked Then
            panel41.BackColor = Color.Lime
            label41.Text = Chr(34) + "models/player/Group01/male_04.mdl" + Chr(34) + ","
            SaveVars.chk41 = "true"
        Else
            panel41.BackColor = Color.Red
            label41.Text = ""
            SaveVars.chk41 = "false"
        End If
    End Sub

    Public Sub checkBox42_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox42.CheckedChanged
        If checkBox42.Checked Then
            panel42.BackColor = Color.Lime
            label42.Text = Chr(34) + "models/player/Group01/male_05.mdl" + Chr(34) + ","
            SaveVars.chk42 = "true"
        Else
            panel42.BackColor = Color.Red
            label42.Text = ""
            SaveVars.chk42 = "false"
        End If
    End Sub

    Public Sub checkBox43_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox43.CheckedChanged
        If checkBox43.Checked Then
            panel43.BackColor = Color.Lime
            label43.Text = Chr(34) + "models/player/Group01/male_06.mdl" + Chr(34) + ","
            SaveVars.chk43 = "true"
        Else
            panel43.BackColor = Color.Red
            label43.Text = ""
            SaveVars.chk43 = "false"
        End If
    End Sub

    Public Sub checkBox44_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox44.CheckedChanged
        If checkBox44.Checked Then
            panel44.BackColor = Color.Lime
            label44.Text = Chr(34) + "models/player/Group01/male_07.mdl" + Chr(34) + ","
            SaveVars.chk44 = "true"
        Else
            panel44.BackColor = Color.Red
            label44.Text = ""
            SaveVars.chk44 = "false"
        End If
    End Sub

    Public Sub checkBox45_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox45.CheckedChanged
        If checkBox45.Checked Then
            panel45.BackColor = Color.Lime
            label45.Text = Chr(34) + "models/player/Group01/male_08.mdl" + Chr(34) + ","
            SaveVars.chk45 = "true"
        Else
            panel45.BackColor = Color.Red
            label45.Text = ""
            SaveVars.chk45 = "false"
        End If
    End Sub

    Public Sub checkBox46_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox46.CheckedChanged
        If checkBox46.Checked Then
            panel46.BackColor = Color.Lime
            label46.Text = Chr(34) + "models/player/Group01/male_09.mdl" + Chr(34) + ","
            SaveVars.chk46 = "true"
        Else
            panel46.BackColor = Color.Red
            label46.Text = ""
            SaveVars.chk46 = "false"
        End If
    End Sub

    Public Sub checkBox47_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox47.CheckedChanged
        If checkBox47.Checked Then
            panel47.BackColor = Color.Lime
            label47.Text = Chr(34) + "models/player/Group03/male_01.mdl" + Chr(34) + ","
            SaveVars.chk47 = "true"
        Else
            panel47.BackColor = Color.Red
            label47.Text = ""
            SaveVars.chk47 = "false"
        End If
    End Sub

    Public Sub checkBox48_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox48.CheckedChanged
        If checkBox48.Checked Then
            panel48.BackColor = Color.Lime
            label48.Text = Chr(34) + "models/player/Group03/male_02.mdl" + Chr(34) + ","
            SaveVars.chk48 = "true"
        Else
            panel48.BackColor = Color.Red
            label48.Text = ""
            SaveVars.chk48 = "false"
        End If
    End Sub

    Public Sub checkBox49_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox49.CheckedChanged
        If checkBox49.Checked Then
            panel49.BackColor = Color.Lime
            label49.Text = Chr(34) + "models/player/Group03/male_03.mdl" + Chr(34) + ","
            SaveVars.chk49 = "true"
        Else
            panel49.BackColor = Color.Red
            label49.Text = ""
            SaveVars.chk49 = "false"
        End If
    End Sub

    Public Sub checkBox50_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox50.CheckedChanged
        If checkBox50.Checked Then
            panel50.BackColor = Color.Lime
            label50.Text = Chr(34) + "models/player/Group03/male_04.mdl" + Chr(34) + ","
            SaveVars.chk50 = "true"
        Else
            panel50.BackColor = Color.Red
            label50.Text = ""
            SaveVars.chk50 = "false"
        End If
    End Sub

    Public Sub checkBox51_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox51.CheckedChanged
        If checkBox51.Checked Then
            panel51.BackColor = Color.Lime
            label51.Text = Chr(34) + "models/player/Group03/male_05.mdl" + Chr(34) + ","
            SaveVars.chk51 = "true"
        Else
            panel51.BackColor = Color.Red
            label51.Text = ""
            SaveVars.chk51 = "false"
        End If
    End Sub

    Public Sub checkBox52_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox52.CheckedChanged
        If checkBox52.Checked Then
            panel52.BackColor = Color.Lime
            label52.Text = Chr(34) + "models/player/Group03/male_06.mdl" + Chr(34) + ","
            SaveVars.chk52 = "true"
        Else
            panel52.BackColor = Color.Red
            label52.Text = ""
            SaveVars.chk52 = "false"
        End If
    End Sub

    Public Sub checkBox53_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox53.CheckedChanged
        If checkBox53.Checked Then
            panel53.BackColor = Color.Lime
            label53.Text = Chr(34) + "models/player/Group03/male_07.mdl" + Chr(34) + ","
            SaveVars.chk53 = "true"
        Else
            panel53.BackColor = Color.Red
            label53.Text = ""
            SaveVars.chk53 = "false"
        End If
    End Sub

    Public Sub checkBox54_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox54.CheckedChanged
        If checkBox54.Checked Then
            panel54.BackColor = Color.Lime
            label54.Text = Chr(34) + "models/player/Group03/male_08.mdl" + Chr(34) + ","
            SaveVars.chk54 = "true"
        Else
            panel54.BackColor = Color.Red
            label54.Text = ""
            SaveVars.chk54 = "false"
        End If
    End Sub

    Public Sub checkBox55_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox55.CheckedChanged
        If checkBox55.Checked Then
            panel55.BackColor = Color.Lime
            label55.Text = Chr(34) + "models/player/Group03/male_09.mdl" + Chr(34) + ","
            SaveVars.chk55 = "true"
        Else
            panel55.BackColor = Color.Red
            label55.Text = ""
            SaveVars.chk55 = "false"
        End If
    End Sub

    Public Sub checkBox56_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox56.CheckedChanged
        If checkBox56.Checked Then
            panel56.BackColor = Color.Lime
            label56.Text = Chr(34) + "models/player/Group03m/male_01.mdl" + Chr(34) + ","
            SaveVars.chk56 = "true"
        Else
            panel56.BackColor = Color.Red
            label56.Text = ""
            SaveVars.chk56 = "false"
        End If
    End Sub

    Public Sub checkBox57_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox57.CheckedChanged
        If checkBox57.Checked Then
            panel57.BackColor = Color.Lime
            label57.Text = Chr(34) + "models/player/Group03m/male_02.mdl" + Chr(34) + ","
            SaveVars.chk57 = "true"
        Else
            panel57.BackColor = Color.Red
            label57.Text = ""
            SaveVars.chk57 = "false"
        End If
    End Sub

    Public Sub checkBox58_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox58.CheckedChanged
        If checkBox58.Checked Then
            panel58.BackColor = Color.Lime
            label58.Text = Chr(34) + "models/player/Group03m/male_03.mdl" + Chr(34) + ","
            SaveVars.chk58 = "true"
        Else
            panel58.BackColor = Color.Red
            label58.Text = ""
            SaveVars.chk58 = "false"
        End If
    End Sub

    Public Sub checkBox59_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox59.CheckedChanged
        If checkBox59.Checked Then
            panel59.BackColor = Color.Lime
            label59.Text = Chr(34) + "models/player/Group03m/male_04.mdl" + Chr(34) + ","
            SaveVars.chk59 = "true"
        Else
            panel59.BackColor = Color.Red
            label59.Text = ""
            SaveVars.chk59 = "false"
        End If
    End Sub

    Public Sub checkBox60_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox60.CheckedChanged
        If checkBox60.Checked Then
            panel60.BackColor = Color.Lime
            label60.Text = Chr(34) + "models/player/Group03m/male_05.mdl" + Chr(34) + ","
            SaveVars.chk60 = "true"
        Else
            panel60.BackColor = Color.Red
            label60.Text = ""
            SaveVars.chk60 = "false"
        End If
    End Sub

    Public Sub checkBox61_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox61.CheckedChanged
        If checkBox61.Checked Then
            panel61.BackColor = Color.Lime
            label61.Text = Chr(34) + "models/player/Group03m/male_06.mdl" + Chr(34) + ","
            SaveVars.chk61 = "true"
        Else
            panel61.BackColor = Color.Red
            label61.Text = ""
            SaveVars.chk61 = "false"
        End If
    End Sub

    Public Sub checkBox62_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox62.CheckedChanged
        If checkBox62.Checked Then
            panel62.BackColor = Color.Lime
            label62.Text = Chr(34) + "models/player/Group03m/male_07.mdl" + Chr(34) + ","
            SaveVars.chk62 = "true"
        Else
            panel62.BackColor = Color.Red
            label62.Text = ""
            SaveVars.chk62 = "false"
        End If
    End Sub

    Public Sub checkBox63_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox63.CheckedChanged
        If checkBox63.Checked Then
            panel63.BackColor = Color.Lime
            label63.Text = Chr(34) + "models/player/Group03m/male_08.mdl" + Chr(34) + ","
            SaveVars.chk63 = "true"
        Else
            panel63.BackColor = Color.Red
            label63.Text = ""
            SaveVars.chk63 = "false"
        End If
    End Sub

    Public Sub checkBox64_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox64.CheckedChanged
        If checkBox64.Checked Then
            panel64.BackColor = Color.Lime
            label64.Text = Chr(34) + "models/player/Group03m/male_09.mdl" + Chr(34) + ","
            SaveVars.chk64 = "true"
        Else
            panel64.BackColor = Color.Red
            label64.Text = ""
            SaveVars.chk64 = "false"
        End If
    End Sub

    Public Sub checkBox65_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox65.CheckedChanged
        If checkBox65.Checked Then
            panel65.BackColor = Color.Lime
            label65.Text = Chr(34) + "models/player/Group03m/female_01.mdl" + Chr(34) + ","
            SaveVars.chk65 = "true"
        Else
            panel65.BackColor = Color.Red
            label65.Text = ""
            SaveVars.chk65 = "false"
        End If
    End Sub

    Public Sub checkBox66_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox66.CheckedChanged
        If checkBox66.Checked Then
            panel66.BackColor = Color.Lime
            label66.Text = Chr(34) + "models/player/Group03m/female_02.mdl" + Chr(34) + ","
            SaveVars.chk66 = "true"
        Else
            panel66.BackColor = Color.Red
            label66.Text = ""
            SaveVars.chk66 = "false"
        End If
    End Sub

    Public Sub checkBox67_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox67.CheckedChanged
        If checkBox67.Checked Then
            panel67.BackColor = Color.Lime
            label67.Text = Chr(34) + "models/player/Group03m/female_03.mdl" + Chr(34) + ","
            SaveVars.chk67 = "true"
        Else
            panel67.BackColor = Color.Red
            label67.Text = ""
            SaveVars.chk67 = "false"
        End If
    End Sub

    Public Sub checkBox68_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox68.CheckedChanged
        If checkBox68.Checked Then
            panel68.BackColor = Color.Lime
            label68.Text = Chr(34) + "models/player/Group03m/female_04.mdl" + Chr(34) + ","
            SaveVars.chk68 = "true"
        Else
            panel68.BackColor = Color.Red
            label68.Text = ""
            SaveVars.chk68 = "false"
        End If
    End Sub

    Public Sub checkBox69_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox69.CheckedChanged
        If checkBox69.Checked Then
            panel69.BackColor = Color.Lime
            label69.Text = Chr(34) + "models/player/Group03m/female_05.mdl" + Chr(34) + ","
            SaveVars.chk69 = "true"
        Else
            panel69.BackColor = Color.Red
            label69.Text = ""
            SaveVars.chk69 = "false"
        End If
    End Sub

    Public Sub checkBox70_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox70.CheckedChanged
        If checkBox70.Checked Then
            panel70.BackColor = Color.Lime
            label70.Text = Chr(34) + "models/player/Group03m/female_06.mdl" + Chr(34) + ","
            SaveVars.chk70 = "true"
        Else
            panel70.BackColor = Color.Red
            label70.Text = ""
            SaveVars.chk70 = "false"
        End If
    End Sub

    Public Sub checkBox71_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox71.CheckedChanged
        If checkBox71.Checked Then
            panel71.BackColor = Color.Lime
            label71.Text = Chr(34) + "models/player/dod_american.mdl" + Chr(34) + ","
            SaveVars.chk71 = "true"
        Else
            panel71.BackColor = Color.Red
            label71.Text = ""
            SaveVars.chk71 = "false"
        End If
    End Sub

    Public Sub checkBox72_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox72.CheckedChanged
        If checkBox72.Checked Then
            panel72.BackColor = Color.Lime
            label72.Text = Chr(34) + "models/player/dod_german.mdl" + Chr(34) + ","
            SaveVars.chk72 = "true"
        Else
            panel72.BackColor = Color.Red
            label72.Text = ""
            SaveVars.chk72 = "false"
        End If
    End Sub

    Public Sub checkBox73_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox73.CheckedChanged
        If checkBox73.Checked Then
            panel73.BackColor = Color.Lime
            label73.Text = Chr(34) + "models/player/monk.mdl" + Chr(34) + ","
            SaveVars.chk73 = "true"
        Else
            panel73.BackColor = Color.Red
            label73.Text = ""
            SaveVars.chk73 = "false"
        End If
    End Sub

    Public Sub checkBox74_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox74.CheckedChanged
        If checkBox74.Checked Then
            panel74.BackColor = Color.Lime
            label74.Text = Chr(34) + "models/player/mossman.mdl" + Chr(34) + ","
            SaveVars.chk74 = "true"
        Else
            panel74.BackColor = Color.Red
            label74.Text = ""
            SaveVars.chk74 = "false"
        End If
    End Sub

    Public Sub checkBox75_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox75.CheckedChanged
        If checkBox75.Checked Then
            panel75.BackColor = Color.Lime
            label75.Text = Chr(34) + "models/player/mossman_arctic.mdl" + Chr(34) + ","
            SaveVars.chk75 = "true"
        Else
            panel75.BackColor = Color.Red
            label75.Text = ""
            SaveVars.chk75 = "false"
        End If
    End Sub

    Public Sub checkBox76_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox76.CheckedChanged
        If checkBox76.Checked Then
            panel76.BackColor = Color.Lime
            label76.Text = Chr(34) + "models/player/odessa.mdl" + Chr(34) + ","
            SaveVars.chk76 = "true"
        Else
            panel76.BackColor = Color.Red
            label76.Text = ""
            SaveVars.chk76 = "false"
        End If
    End Sub

    Public Sub checkBox77_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox77.CheckedChanged
        If checkBox77.Checked Then
            panel77.BackColor = Color.Lime
            label77.Text = Chr(34) + "models/player/police.mdl" + Chr(34) + ","
            SaveVars.chk77 = "true"
        Else
            panel77.BackColor = Color.Red
            label77.Text = ""
            SaveVars.chk77 = "false"
        End If
    End Sub

    Public Sub checkBox78_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox78.CheckedChanged
        If checkBox78.Checked Then
            panel78.BackColor = Color.Lime
            label78.Text = Chr(34) + "models/player/police_fem.mdl" + Chr(34) + ","
            SaveVars.chk78 = "true"
        Else
            panel78.BackColor = Color.Red
            label78.Text = ""
            SaveVars.chk78 = "false"
        End If
    End Sub

    Public Sub checkBox79_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox79.CheckedChanged
        If checkBox79.Checked Then
            panel79.BackColor = Color.Lime
            label79.Text = Chr(34) + "models/player/Group02/male_02.mdl" + Chr(34) + ","
            SaveVars.chk79 = "true"
        Else
            panel79.BackColor = Color.Red
            label79.Text = ""
            SaveVars.chk79 = "false"
        End If
    End Sub

    Public Sub checkBox80_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox80.CheckedChanged
        If checkBox80.Checked Then
            panel80.BackColor = Color.Lime
            label80.Text = Chr(34) + "models/player/Group02/male_04.mdl" + Chr(34) + ","
            SaveVars.chk80 = "true"
        Else
            panel80.BackColor = Color.Red
            label80.Text = ""
            SaveVars.chk80 = "false"
        End If
    End Sub

    Public Sub checkBox81_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox81.CheckedChanged
        If checkBox81.Checked Then
            panel81.BackColor = Color.Lime
            label81.Text = Chr(34) + "models/player/Group02/male_06.mdl" + Chr(34) + ","
            SaveVars.chk81 = "true"
        Else
            panel81.BackColor = Color.Red
            label81.Text = ""
            SaveVars.chk81 = "false"
        End If
    End Sub

    Public Sub checkBox82_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox82.CheckedChanged
        If checkBox82.Checked Then
            panel82.BackColor = Color.Lime
            label82.Text = Chr(34) + "models/player/Group02/male_08.mdl" + Chr(34) + ","
            SaveVars.chk82 = "true"
        Else
            panel82.BackColor = Color.Red
            label82.Text = ""
            SaveVars.chk82 = "false"
        End If
    End Sub

    Public Sub checkBox83_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox83.CheckedChanged
        If checkBox83.Checked Then
            panel83.BackColor = Color.Lime
            label83.Text = Chr(34) + "models/player/skeleton.mdl" + Chr(34) + ","
            SaveVars.chk83 = "true"
        Else
            panel83.BackColor = Color.Red
            label83.Text = ""
            SaveVars.chk83 = "false"
        End If
    End Sub

    Public Sub checkBox84_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox84.CheckedChanged
        If checkBox84.Checked Then
            panel84.BackColor = Color.Lime
            label84.Text = Chr(34) + "models/player/soldier_stripped.mdl" + Chr(34) + ","
            SaveVars.chk84 = "true"
        Else
            panel84.BackColor = Color.Red
            label84.Text = ""
            SaveVars.chk84 = "false"
        End If
    End Sub

    Public Sub checkBox85_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox85.CheckedChanged
        If checkBox85.Checked Then
            panel85.BackColor = Color.Lime
            label85.Text = Chr(34) + "models/player/zombie_classic.mdl" + Chr(34) + ","
            SaveVars.chk85 = "true"
        Else
            panel85.BackColor = Color.Red
            label85.Text = ""
            SaveVars.chk85 = "false"
        End If
    End Sub

    Public Sub checkBox86_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox86.CheckedChanged
        If checkBox86.Checked Then
            panel86.BackColor = Color.Lime
            label86.Text = Chr(34) + "models/player/zombie_fast.mdl" + Chr(34) + ","
            SaveVars.chk86 = "true"
        Else
            panel86.BackColor = Color.Red
            label86.Text = ""
            SaveVars.chk86 = "false"
        End If
    End Sub

    Public Sub checkBox87_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox87.CheckedChanged
        If checkBox87.Checked Then
            panel87.BackColor = Color.Lime
            label87.Text = Chr(34) + "models/player/zombie_soldier.mdl" + Chr(34) + ","
            SaveVars.chk87 = "true"
        Else
            panel87.BackColor = Color.Red
            label87.Text = ""
            SaveVars.chk87 = "false"
        End If
    End Sub

    Public Sub label22_TextChanged(sender As Object, e As EventArgs) Handles label9.TextChanged, label87.TextChanged, label86.TextChanged, label85.TextChanged, label84.TextChanged, label83.TextChanged, label82.TextChanged, label81.TextChanged, label80.TextChanged, label8.TextChanged, label79.TextChanged, label78.TextChanged, label77.TextChanged, label76.TextChanged, label75.TextChanged, label74.TextChanged, label73.TextChanged, label72.TextChanged, label71.TextChanged, label70.TextChanged, label7.TextChanged, label69.TextChanged, label68.TextChanged, label67.TextChanged, label66.TextChanged, label65.TextChanged, label64.TextChanged, label63.TextChanged, label62.TextChanged, label61.TextChanged, label60.TextChanged, label6.TextChanged, label59.TextChanged, label58.TextChanged, label57.TextChanged, label56.TextChanged, label55.TextChanged, label54.TextChanged, label53.TextChanged, label52.TextChanged, label51.TextChanged, label50.TextChanged, label5.TextChanged, label49.TextChanged, label48.TextChanged, label47.TextChanged, label46.TextChanged, label45.TextChanged, label44.TextChanged, label43.TextChanged, label42.TextChanged, label41.TextChanged, label40.TextChanged, label4.TextChanged, label39.TextChanged, label38.TextChanged, label37.TextChanged, label36.TextChanged, label35.TextChanged, label34.TextChanged, label33.TextChanged, label32.TextChanged, label31.TextChanged, label30.TextChanged, label3.TextChanged, label29.TextChanged, label28.TextChanged, label27.TextChanged, label26.TextChanged, label25.TextChanged, label24.TextChanged, label23.TextChanged, label22.TextChanged, label21.TextChanged, label20.TextChanged, label2.TextChanged, label19.TextChanged, label18.TextChanged, label17.TextChanged, label16.TextChanged, label15.TextChanged, label14.TextChanged, label13.TextChanged, label12.TextChanged, label11.TextChanged, label10.TextChanged, label1.TextChanged
        Form1.JobModelBox.Text = (label1.Text + label2.Text + label3.Text + label4.Text + label5.Text + label6.Text + label7.Text + label8.Text + label9.Text + label10.Text + label11.Text + label12.Text + label13.Text + label14.Text + label15.Text + label16.Text + label17.Text + label18.Text + label19.Text + label20.Text + label21.Text + label22.Text + label23.Text + label24.Text + label25.Text + label26.Text + label27.Text + label28.Text + label29.Text + label30.Text + label31.Text + label32.Text + label33.Text + label34.Text + label35.Text + label36.Text + label37.Text + label38.Text + label39.Text + label40.Text + label41.Text + label42.Text + label43.Text + label44.Text + label45.Text + label46.Text + label47.Text + label48.Text + label49.Text + label50.Text + label51.Text + label52.Text + label53.Text + label54.Text + label55.Text + label56.Text + label57.Text + label58.Text + label59.Text + label60.Text + label61.Text + label62.Text + label63.Text + label64.Text + label65.Text + label66.Text + label67.Text + label68.Text + label69.Text + label70.Text + label71.Text + label72.Text + label73.Text + label74.Text + label75.Text + label76.Text + label77.Text + label78.Text + label79.Text + label80.Text + label81.Text + label82.Text + label83.Text + label84.Text + label85.Text + label86.Text + label87.Text)
        If Form1.JobModelBox.Text.Length > 0 Then
            Form1.JobModelBox.Text = Form1.JobModelBox.Text.Substring(0, Form1.JobModelBox.Text.Length - 1)
        End If
    End Sub

    Public Sub sourcesite_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles sourcesite.LinkClicked
        Process.Start("https://www.thecodingbeast.com/tools/models")
    End Sub
End Class