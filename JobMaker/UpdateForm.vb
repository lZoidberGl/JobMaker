Imports System.ComponentModel
Imports System.IO.Compression
Imports System.Net
Imports System.IO
Imports System.Threading
Imports System.Globalization

Public Class UpdateForm
    Dim Web As New WebClient
    '285; 215
    Private Sub UpdateForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If File.Exists("update.zip") Then
            Try
                File.Delete("update.zip")
            Catch ex As Exception
            End Try
        End If
        Me.Height = 215

        If (Thread.CurrentThread.CurrentUICulture Is CultureInfo.GetCultureInfo("ru-RU")) Then
            Web.DownloadFile("https://onedrive.live.com/download?cid=BB4AF649BFD8B31F&resid=BB4AF649BFD8B31F%217521&authkey=AAmcdlodn55xRYY", "Changelog.txt")
            ChangeLog.Text = File.ReadAllText("Changelog.txt")
        Else
            Web.DownloadFile("https://onedrive.live.com/download?cid=BB4AF649BFD8B31F&resid=BB4AF649BFD8B31F%217520&authkey=AI1HM2jLsFs4OO0", "Changelog.txt")
            ChangeLog.Text = File.ReadAllText("Changelog.txt")
        End If

    End Sub

    Private Sub DoMagic_Click(sender As Object, e As EventArgs) Handles DoMagic.Click
        AddHandler Web.DownloadProgressChanged, AddressOf Web_ProgressChanged
        AddHandler Web.DownloadFileCompleted, AddressOf Web_DownloadCompleted

        Web.DownloadFileAsync(New Uri("https://onedrive.live.com/download?cid=BB4AF649BFD8B31F&resid=BB4AF649BFD8B31F%217519&authkey=AJ-54HiyMDM5VqA"), "update.zip")
    End Sub

    Private Sub Web_ProgressChanged(sender As Object, e As DownloadProgressChangedEventArgs)
        DownloadProgressBar.Maximum = e.TotalBytesToReceive
        DownloadProgressBar.Value = e.BytesReceived
        DownloadPersentage.Text = e.ProgressPercentage & "%"
    End Sub

    Private Sub Web_DownloadCompleted(sender As Object, e As AsyncCompletedEventArgs)
        Unzip()
    End Sub

    Private Sub Unzip()
        If File.Exists("update.zip") Then
            Dim ExtractFile As String = "update.zip"
            Dim ExtractPath As String = Application.StartupPath + "\"
            Try
                ZipFile.ExtractToDirectory(ExtractFile, ExtractPath)
            Catch ex As Exception
                MsgBox("Something gone wrong :(")
            End Try
            Try
                File.Delete(ExtractFile)
            Catch ex As Exception
                MsgBox("Something gone wrong :(")
            End Try
            If (Thread.CurrentThread.CurrentUICulture Is CultureInfo.GetCultureInfo("ru-RU")) Then
                Dim FinishMessage As String = "Загрузка окончена! Теперь Генератор профессий перезапустится."
                MsgBox(FinishMessage)
            Else
                Dim FinishMessage As String = "Downloading finished! Now JobMaker should be restarted (automatically)"
                MsgBox(FinishMessage)
            End If
            Form1.CmdWork()
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ExtendPanel.Click
        If Me.Height = 215 Then
            ExtendAnim.Start()
            ExtendPanel.Enabled = False
        End If
        If Me.Height = 400 Then
            MakeSmaller.Start()
            ChangeLog.Visible = False
            ExtendPanel.Enabled = False
        End If
    End Sub

    Private Sub ExtendAnim_Tick(sender As Object, e As EventArgs) Handles ExtendAnim.Tick
        If Me.Height < 400 Then
            Me.Height = Me.Height + 5
        Else
            ExtendPanel.Text = "↑↑↑"
            ExtendAnim.Stop()
            ExtendPanel.Enabled = True
            ChangeLog.Visible = True
        End If
    End Sub

    Private Sub MakeSmaller_Tick(sender As Object, e As EventArgs) Handles MakeSmaller.Tick
        If Me.Height = 215 Then
            ExtendPanel.Text = "↓↓↓"
            MakeSmaller.Stop()
            ExtendPanel.Enabled = True
        Else
            Me.Height = Me.Height - 5
        End If
    End Sub

    Private Sub UpdateForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        File.Delete("Changelog.txt")
    End Sub
End Class