<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdvancedSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdvancedSettings))
        Me.CommandBox = New System.Windows.Forms.TextBox()
        Me.jobcommand = New System.Windows.Forms.Label()
        Me.CommandPanel = New System.Windows.Forms.Panel()
        Me.AdminResult = New System.Windows.Forms.Label()
        Me.Admin = New System.Windows.Forms.RadioButton()
        Me.SuperAdmin = New System.Windows.Forms.RadioButton()
        Me.JobAdmin = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CommandPanel.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
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
        'CommandPanel
        '
        Me.CommandPanel.BackColor = System.Drawing.Color.Red
        Me.CommandPanel.Controls.Add(Me.CommandBox)
        resources.ApplyResources(Me.CommandPanel, "CommandPanel")
        Me.CommandPanel.Name = "CommandPanel"
        '
        'AdminResult
        '
        resources.ApplyResources(Me.AdminResult, "AdminResult")
        Me.AdminResult.Name = "AdminResult"
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
        'JobAdmin
        '
        resources.ApplyResources(Me.JobAdmin, "JobAdmin")
        Me.JobAdmin.ForeColor = System.Drawing.Color.White
        Me.JobAdmin.Name = "JobAdmin"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.jobcommand)
        Me.Panel1.Controls.Add(Me.CommandPanel)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel2)
        resources.ApplyResources(Me.FlowLayoutPanel1, "FlowLayoutPanel1")
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.JobAdmin)
        Me.Panel2.Controls.Add(Me.AdminResult)
        Me.Panel2.Controls.Add(Me.Admin)
        Me.Panel2.Controls.Add(Me.SuperAdmin)
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'AdvancedSettings
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "AdvancedSettings"
        Me.CommandPanel.ResumeLayout(False)
        Me.CommandPanel.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents CommandBox As TextBox
    Private WithEvents jobcommand As Label
    Friend WithEvents CommandPanel As Panel
    Friend WithEvents AdminResult As Label
    Friend WithEvents Admin As RadioButton
    Friend WithEvents SuperAdmin As RadioButton
    Private WithEvents JobAdmin As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel2 As Panel
End Class
