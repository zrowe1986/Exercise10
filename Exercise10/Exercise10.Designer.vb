<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Exercise10
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

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        mnuMain = New MenuStrip()
        mnuFile = New ToolStripMenuItem()
        mnuCheck = New ToolStripMenuItem()
        mnuClear = New ToolStripMenuItem()
        mnuQuit = New ToolStripMenuItem()
        mnuHelp = New ToolStripMenuItem()
        mnuAbout = New ToolStripMenuItem()
        mnuBuildGuide = New ToolStripMenuItem()
        lblName = New Label()
        txtName = New TextBox()
        lblParts = New Label()
        clbParts = New CheckedListBox()
        lblResult = New Label()
        lblSummary = New Label()
        mnuMain.SuspendLayout()
        SuspendLayout()
        ' 
        ' mnuMain
        ' 
        mnuMain.Items.AddRange(New ToolStripItem() {mnuFile, mnuHelp})
        mnuMain.Location = New Point(0, 0)
        mnuMain.Name = "mnuMain"
        mnuMain.Size = New Size(404, 24)
        mnuMain.TabIndex = 0
        ' 
        ' mnuFile
        ' 
        mnuFile.DropDownItems.AddRange(New ToolStripItem() {mnuCheck, mnuClear, mnuQuit})
        mnuFile.Name = "mnuFile"
        mnuFile.Size = New Size(37, 20)
        mnuFile.Text = "&File"
        ' 
        ' mnuCheck
        ' 
        mnuCheck.Name = "mnuCheck"
        mnuCheck.Size = New Size(136, 22)
        mnuCheck.Text = "&Check Parts"
        ' 
        ' mnuClear
        ' 
        mnuClear.Name = "mnuClear"
        mnuClear.Size = New Size(136, 22)
        mnuClear.Text = "C&lear"
        ' 
        ' mnuQuit
        ' 
        mnuQuit.Name = "mnuQuit"
        mnuQuit.Size = New Size(136, 22)
        mnuQuit.Text = "&Quit"
        ' 
        ' mnuHelp
        ' 
        mnuHelp.DropDownItems.AddRange(New ToolStripItem() {mnuAbout, mnuBuildGuide})
        mnuHelp.Name = "mnuHelp"
        mnuHelp.Size = New Size(44, 20)
        mnuHelp.Text = "&Help"
        ' 
        ' mnuAbout
        ' 
        mnuAbout.Name = "mnuAbout"
        mnuAbout.Size = New Size(135, 22)
        mnuAbout.Text = "&About"
        ' 
        ' mnuBuildGuide
        ' 
        mnuBuildGuide.Name = "mnuBuildGuide"
        mnuBuildGuide.Size = New Size(135, 22)
        mnuBuildGuide.Text = "&Build Guide"
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblName.Location = New Point(20, 42)
        lblName.Name = "lblName"
        lblName.Size = New Size(86, 15)
        lblName.TabIndex = 1
        lblName.Text = "Builder Name:"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(120, 39)
        txtName.Name = "txtName"
        txtName.Size = New Size(260, 23)
        txtName.TabIndex = 2
        ' 
        ' lblParts
        ' 
        lblParts.AutoSize = True
        lblParts.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblParts.Location = New Point(20, 80)
        lblParts.Name = "lblParts"
        lblParts.Size = New Size(153, 15)
        lblParts.TabIndex = 3
        lblParts.Text = "Check Each Part You Have:"
        ' 
        ' clbParts
        ' 
        clbParts.CheckOnClick = True
        clbParts.FormattingEnabled = True
        clbParts.Location = New Point(20, 100)
        clbParts.Name = "clbParts"
        clbParts.Size = New Size(360, 220)
        clbParts.TabIndex = 4
        ' 
        ' lblResult
        ' 
        lblResult.BorderStyle = BorderStyle.FixedSingle
        lblResult.Location = New Point(20, 335)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(360, 80)
        lblResult.TabIndex = 5
        ' 
        ' lblSummary
        ' 
        lblSummary.Location = New Point(20, 425)
        lblSummary.Name = "lblSummary"
        lblSummary.Size = New Size(360, 45)
        lblSummary.TabIndex = 6
        ' 
        ' Exercise10
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Thistle
        ClientSize = New Size(404, 481)
        Controls.Add(lblSummary)
        Controls.Add(lblResult)
        Controls.Add(clbParts)
        Controls.Add(lblParts)
        Controls.Add(txtName)
        Controls.Add(lblName)
        Controls.Add(mnuMain)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MainMenuStrip = mnuMain
        MaximizeBox = False
        Name = "Exercise10"
        StartPosition = FormStartPosition.CenterScreen
        Text = "New Computer Build Checker"
        mnuMain.ResumeLayout(False)
        mnuMain.PerformLayout()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents mnuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCheck As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuClear As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuQuit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBuildGuide As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblParts As System.Windows.Forms.Label
    Friend WithEvents clbParts As System.Windows.Forms.CheckedListBox
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents lblSummary As System.Windows.Forms.Label

End Class