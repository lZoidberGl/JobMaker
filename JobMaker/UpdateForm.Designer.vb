<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UpdateForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdateForm))
        Me.DoMagic = New System.Windows.Forms.Button()
        Me.MainText = New System.Windows.Forms.Label()
        Me.DownloadProgressBar = New System.Windows.Forms.ProgressBar()
        Me.DownloadPersentage = New System.Windows.Forms.Label()
        Me.ExtendPanel = New System.Windows.Forms.Button()
        Me.ChangeLog = New System.Windows.Forms.RichTextBox()
        Me.ExtendAnim = New System.Windows.Forms.Timer(Me.components)
        Me.MakeSmaller = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'DoMagic
        '
        resources.ApplyResources(Me.DoMagic, "DoMagic")
        Me.DoMagic.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DoMagic.Name = "DoMagic"
        Me.DoMagic.UseVisualStyleBackColor = True
        '
        'MainText
        '
        resources.ApplyResources(Me.MainText, "MainText")
        Me.MainText.Name = "MainText"
        '
        'DownloadProgressBar
        '
        resources.ApplyResources(Me.DownloadProgressBar, "DownloadProgressBar")
        Me.DownloadProgressBar.Name = "DownloadProgressBar"
        '
        'DownloadPersentage
        '
        resources.ApplyResources(Me.DownloadPersentage, "DownloadPersentage")
        Me.DownloadPersentage.Name = "DownloadPersentage"
        '
        'ExtendPanel
        '
        Me.ExtendPanel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        resources.ApplyResources(Me.ExtendPanel, "ExtendPanel")
        Me.ExtendPanel.Name = "ExtendPanel"
        Me.ExtendPanel.UseVisualStyleBackColor = True
        '
        'ChangeLog
        '
        resources.ApplyResources(Me.ChangeLog, "ChangeLog")
        Me.ChangeLog.Name = "ChangeLog"
        '
        'ExtendAnim
        '
        Me.ExtendAnim.Interval = 10
        '
        'MakeSmaller
        '
        Me.MakeSmaller.Interval = 10
        '
        'UpdateForm
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.Controls.Add(Me.ExtendPanel)
        Me.Controls.Add(Me.DownloadPersentage)
        Me.Controls.Add(Me.DownloadProgressBar)
        Me.Controls.Add(Me.MainText)
        Me.Controls.Add(Me.DoMagic)
        Me.Controls.Add(Me.ChangeLog)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "UpdateForm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DownloadProgressBar As ProgressBar
    Public WithEvents DoMagic As Button
    Public WithEvents MainText As Label
    Friend WithEvents DownloadPersentage As Label
    Friend WithEvents ExtendPanel As Button
    Friend WithEvents ChangeLog As RichTextBox
    Friend WithEvents ExtendAnim As Timer
    Friend WithEvents MakeSmaller As Timer
End Class
