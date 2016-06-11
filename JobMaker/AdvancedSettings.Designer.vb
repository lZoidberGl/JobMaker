<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdvancedSettings
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdvancedSettings))
        Me.AdminResult = New System.Windows.Forms.Label()
        Me.Admin = New System.Windows.Forms.RadioButton()
        Me.SuperAdmin = New System.Windows.Forms.RadioButton()
        Me.JobAdmin = New System.Windows.Forms.Label()
        Me.NeedCangeFromPanel = New System.Windows.Forms.Panel()
        Me.NeedChangeFrom = New System.Windows.Forms.Label()
        Me.ChangeFromPanel = New System.Windows.Forms.Panel()
        Me.NeedChangeFromText = New System.Windows.Forms.TextBox()
        Me.changecheck = New System.Windows.Forms.CheckBox()
        Me.Panele = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.HoboPanel = New System.Windows.Forms.Panel()
        Me.HoboCheck = New System.Windows.Forms.CheckBox()
        Me.Hobo = New System.Windows.Forms.Label()
        Me.MedicPanel = New System.Windows.Forms.Panel()
        Me.MedicCheck = New System.Windows.Forms.CheckBox()
        Me.Medic = New System.Windows.Forms.Label()
        Me.MayorPanel = New System.Windows.Forms.Panel()
        Me.MayorCheck = New System.Windows.Forms.CheckBox()
        Me.Mayor = New System.Windows.Forms.Label()
        Me.ChiefPanel = New System.Windows.Forms.Panel()
        Me.ChiefCheck = New System.Windows.Forms.CheckBox()
        Me.Chief = New System.Windows.Forms.Label()
        Me.CookPanel = New System.Windows.Forms.Panel()
        Me.CookCheck = New System.Windows.Forms.CheckBox()
        Me.Cook = New System.Windows.Forms.Label()
        Me.ComingSoon = New System.Windows.Forms.Label()
        Me.NeedCangeFromPanel.SuspendLayout()
        Me.ChangeFromPanel.SuspendLayout()
        Me.Panele.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.HoboPanel.SuspendLayout()
        Me.MedicPanel.SuspendLayout()
        Me.MayorPanel.SuspendLayout()
        Me.ChiefPanel.SuspendLayout()
        Me.CookPanel.SuspendLayout()
        Me.SuspendLayout()
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
        'NeedCangeFromPanel
        '
        Me.NeedCangeFromPanel.Controls.Add(Me.NeedChangeFrom)
        Me.NeedCangeFromPanel.Controls.Add(Me.ChangeFromPanel)
        Me.NeedCangeFromPanel.Controls.Add(Me.changecheck)
        resources.ApplyResources(Me.NeedCangeFromPanel, "NeedCangeFromPanel")
        Me.NeedCangeFromPanel.Name = "NeedCangeFromPanel"
        '
        'NeedChangeFrom
        '
        resources.ApplyResources(Me.NeedChangeFrom, "NeedChangeFrom")
        Me.NeedChangeFrom.ForeColor = System.Drawing.Color.White
        Me.NeedChangeFrom.Name = "NeedChangeFrom"
        '
        'ChangeFromPanel
        '
        Me.ChangeFromPanel.BackColor = System.Drawing.Color.Red
        Me.ChangeFromPanel.Controls.Add(Me.NeedChangeFromText)
        resources.ApplyResources(Me.ChangeFromPanel, "ChangeFromPanel")
        Me.ChangeFromPanel.Name = "ChangeFromPanel"
        '
        'NeedChangeFromText
        '
        Me.NeedChangeFromText.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.NeedChangeFromText, "NeedChangeFromText")
        Me.NeedChangeFromText.Name = "NeedChangeFromText"
        '
        'changecheck
        '
        resources.ApplyResources(Me.changecheck, "changecheck")
        Me.changecheck.Name = "changecheck"
        Me.changecheck.UseVisualStyleBackColor = True
        '
        'Panele
        '
        Me.Panele.Controls.Add(Me.NeedCangeFromPanel)
        Me.Panele.Controls.Add(Me.Panel2)
        Me.Panele.Controls.Add(Me.HoboPanel)
        Me.Panele.Controls.Add(Me.MedicPanel)
        Me.Panele.Controls.Add(Me.MayorPanel)
        Me.Panele.Controls.Add(Me.ChiefPanel)
        Me.Panele.Controls.Add(Me.CookPanel)
        resources.ApplyResources(Me.Panele, "Panele")
        Me.Panele.Name = "Panele"
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
        'HoboPanel
        '
        Me.HoboPanel.Controls.Add(Me.HoboCheck)
        Me.HoboPanel.Controls.Add(Me.Hobo)
        resources.ApplyResources(Me.HoboPanel, "HoboPanel")
        Me.HoboPanel.Name = "HoboPanel"
        '
        'HoboCheck
        '
        resources.ApplyResources(Me.HoboCheck, "HoboCheck")
        Me.HoboCheck.Name = "HoboCheck"
        Me.HoboCheck.UseVisualStyleBackColor = True
        '
        'Hobo
        '
        resources.ApplyResources(Me.Hobo, "Hobo")
        Me.Hobo.ForeColor = System.Drawing.Color.White
        Me.Hobo.Name = "Hobo"
        '
        'MedicPanel
        '
        Me.MedicPanel.Controls.Add(Me.MedicCheck)
        Me.MedicPanel.Controls.Add(Me.Medic)
        resources.ApplyResources(Me.MedicPanel, "MedicPanel")
        Me.MedicPanel.Name = "MedicPanel"
        '
        'MedicCheck
        '
        resources.ApplyResources(Me.MedicCheck, "MedicCheck")
        Me.MedicCheck.Name = "MedicCheck"
        Me.MedicCheck.UseVisualStyleBackColor = True
        '
        'Medic
        '
        resources.ApplyResources(Me.Medic, "Medic")
        Me.Medic.ForeColor = System.Drawing.Color.White
        Me.Medic.Name = "Medic"
        '
        'MayorPanel
        '
        Me.MayorPanel.Controls.Add(Me.MayorCheck)
        Me.MayorPanel.Controls.Add(Me.Mayor)
        resources.ApplyResources(Me.MayorPanel, "MayorPanel")
        Me.MayorPanel.Name = "MayorPanel"
        '
        'MayorCheck
        '
        resources.ApplyResources(Me.MayorCheck, "MayorCheck")
        Me.MayorCheck.Name = "MayorCheck"
        Me.MayorCheck.UseVisualStyleBackColor = True
        '
        'Mayor
        '
        resources.ApplyResources(Me.Mayor, "Mayor")
        Me.Mayor.ForeColor = System.Drawing.Color.White
        Me.Mayor.Name = "Mayor"
        '
        'ChiefPanel
        '
        Me.ChiefPanel.Controls.Add(Me.ChiefCheck)
        Me.ChiefPanel.Controls.Add(Me.Chief)
        resources.ApplyResources(Me.ChiefPanel, "ChiefPanel")
        Me.ChiefPanel.Name = "ChiefPanel"
        '
        'ChiefCheck
        '
        resources.ApplyResources(Me.ChiefCheck, "ChiefCheck")
        Me.ChiefCheck.Name = "ChiefCheck"
        Me.ChiefCheck.UseVisualStyleBackColor = True
        '
        'Chief
        '
        resources.ApplyResources(Me.Chief, "Chief")
        Me.Chief.ForeColor = System.Drawing.Color.White
        Me.Chief.Name = "Chief"
        '
        'CookPanel
        '
        Me.CookPanel.Controls.Add(Me.CookCheck)
        Me.CookPanel.Controls.Add(Me.Cook)
        resources.ApplyResources(Me.CookPanel, "CookPanel")
        Me.CookPanel.Name = "CookPanel"
        '
        'CookCheck
        '
        resources.ApplyResources(Me.CookCheck, "CookCheck")
        Me.CookCheck.Name = "CookCheck"
        Me.CookCheck.UseVisualStyleBackColor = True
        '
        'Cook
        '
        resources.ApplyResources(Me.Cook, "Cook")
        Me.Cook.ForeColor = System.Drawing.Color.White
        Me.Cook.Name = "Cook"
        '
        'ComingSoon
        '
        resources.ApplyResources(Me.ComingSoon, "ComingSoon")
        Me.ComingSoon.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ComingSoon.Name = "ComingSoon"
        '
        'AdvancedSettings
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Highlight
        Me.Controls.Add(Me.ComingSoon)
        Me.Controls.Add(Me.Panele)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "AdvancedSettings"
        Me.NeedCangeFromPanel.ResumeLayout(False)
        Me.NeedCangeFromPanel.PerformLayout()
        Me.ChangeFromPanel.ResumeLayout(False)
        Me.ChangeFromPanel.PerformLayout()
        Me.Panele.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.HoboPanel.ResumeLayout(False)
        Me.HoboPanel.PerformLayout()
        Me.MedicPanel.ResumeLayout(False)
        Me.MedicPanel.PerformLayout()
        Me.MayorPanel.ResumeLayout(False)
        Me.MayorPanel.PerformLayout()
        Me.ChiefPanel.ResumeLayout(False)
        Me.ChiefPanel.PerformLayout()
        Me.CookPanel.ResumeLayout(False)
        Me.CookPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents AdminResult As Label
    Public WithEvents Admin As RadioButton
    Public WithEvents SuperAdmin As RadioButton
    Public WithEvents JobAdmin As Label
    Public WithEvents NeedCangeFromPanel As Panel
    Public WithEvents Panele As FlowLayoutPanel
    Public WithEvents Panel2 As Panel
    Public WithEvents changecheck As CheckBox
    Public WithEvents ComingSoon As Label
    Public WithEvents HoboPanel As Panel
    Friend WithEvents HoboCheck As CheckBox
    Public WithEvents Hobo As Label
    Public WithEvents MedicPanel As Panel
    Friend WithEvents MedicCheck As CheckBox
    Public WithEvents Medic As Label
    Public WithEvents MayorPanel As Panel
    Friend WithEvents MayorCheck As CheckBox
    Public WithEvents Mayor As Label
    Public WithEvents ChiefPanel As Panel
    Friend WithEvents ChiefCheck As CheckBox
    Public WithEvents Chief As Label
    Public WithEvents CookPanel As Panel
    Friend WithEvents CookCheck As CheckBox
    Public WithEvents Cook As Label
    Public WithEvents NeedChangeFrom As Label
    Public WithEvents ChangeFromPanel As Panel
    Public WithEvents NeedChangeFromText As TextBox
End Class
