<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.chkStartWithWindows = New System.Windows.Forms.CheckBox()
        Me.chkStartMinimized = New System.Windows.Forms.CheckBox()
        Me.chkOpenPreviewerOnStartup = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkHeightRelative = New System.Windows.Forms.CheckBox()
        Me.chkWidthRelative = New System.Windows.Forms.CheckBox()
        Me.chkYRelative = New System.Windows.Forms.CheckBox()
        Me.chkXRelative = New System.Windows.Forms.CheckBox()
        Me.btnSetManualDimension = New System.Windows.Forms.Button()
        Me.btnSetManualPosition = New System.Windows.Forms.Button()
        Me.txtHeightGrab = New System.Windows.Forms.TextBox()
        Me.txtWidthGrab = New System.Windows.Forms.TextBox()
        Me.txtYPos = New System.Windows.Forms.TextBox()
        Me.txtXPos = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chkDrawScanningBorders = New System.Windows.Forms.CheckBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.chkDrawOnResize = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtRedrawSpeed = New System.Windows.Forms.TextBox()
        Me.cmdShowPreviewer = New System.Windows.Forms.Button()
        Me.mnuSystemTray = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ShowPreviewerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SetManualPositionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetManualDimensionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.DrawScanningBordersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.nioSystemTray = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.chkDoubleBufferedRedraw = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.mnuSystemTray.SuspendLayout()
        Me.SuspendLayout()
        '
        'chkStartWithWindows
        '
        Me.chkStartWithWindows.AutoSize = True
        Me.chkStartWithWindows.Location = New System.Drawing.Point(12, 12)
        Me.chkStartWithWindows.Name = "chkStartWithWindows"
        Me.chkStartWithWindows.Size = New System.Drawing.Size(117, 17)
        Me.chkStartWithWindows.TabIndex = 0
        Me.chkStartWithWindows.Text = "Start with Windows"
        Me.chkStartWithWindows.UseVisualStyleBackColor = True
        '
        'chkStartMinimized
        '
        Me.chkStartMinimized.AutoSize = True
        Me.chkStartMinimized.Location = New System.Drawing.Point(12, 35)
        Me.chkStartMinimized.Name = "chkStartMinimized"
        Me.chkStartMinimized.Size = New System.Drawing.Size(96, 17)
        Me.chkStartMinimized.TabIndex = 1
        Me.chkStartMinimized.Text = "Start minimized"
        Me.chkStartMinimized.UseVisualStyleBackColor = True
        '
        'chkOpenPreviewerOnStartup
        '
        Me.chkOpenPreviewerOnStartup.AutoSize = True
        Me.chkOpenPreviewerOnStartup.Checked = True
        Me.chkOpenPreviewerOnStartup.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkOpenPreviewerOnStartup.Location = New System.Drawing.Point(12, 58)
        Me.chkOpenPreviewerOnStartup.Name = "chkOpenPreviewerOnStartup"
        Me.chkOpenPreviewerOnStartup.Size = New System.Drawing.Size(151, 17)
        Me.chkOpenPreviewerOnStartup.TabIndex = 2
        Me.chkOpenPreviewerOnStartup.Text = "Open previewer on startup"
        Me.chkOpenPreviewerOnStartup.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkHeightRelative)
        Me.GroupBox1.Controls.Add(Me.chkWidthRelative)
        Me.GroupBox1.Controls.Add(Me.chkYRelative)
        Me.GroupBox1.Controls.Add(Me.chkXRelative)
        Me.GroupBox1.Controls.Add(Me.btnSetManualDimension)
        Me.GroupBox1.Controls.Add(Me.btnSetManualPosition)
        Me.GroupBox1.Controls.Add(Me.txtHeightGrab)
        Me.GroupBox1.Controls.Add(Me.txtWidthGrab)
        Me.GroupBox1.Controls.Add(Me.txtYPos)
        Me.GroupBox1.Controls.Add(Me.txtXPos)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(216, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(295, 145)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Position and dimension"
        '
        'chkHeightRelative
        '
        Me.chkHeightRelative.AutoSize = True
        Me.chkHeightRelative.Checked = True
        Me.chkHeightRelative.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkHeightRelative.Location = New System.Drawing.Point(171, 107)
        Me.chkHeightRelative.Name = "chkHeightRelative"
        Me.chkHeightRelative.Size = New System.Drawing.Size(65, 17)
        Me.chkHeightRelative.TabIndex = 15
        Me.chkHeightRelative.Text = "Relative"
        Me.chkHeightRelative.UseVisualStyleBackColor = True
        '
        'chkWidthRelative
        '
        Me.chkWidthRelative.AutoSize = True
        Me.chkWidthRelative.Checked = True
        Me.chkWidthRelative.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkWidthRelative.Location = New System.Drawing.Point(171, 80)
        Me.chkWidthRelative.Name = "chkWidthRelative"
        Me.chkWidthRelative.Size = New System.Drawing.Size(65, 17)
        Me.chkWidthRelative.TabIndex = 14
        Me.chkWidthRelative.Text = "Relative"
        Me.chkWidthRelative.UseVisualStyleBackColor = True
        '
        'chkYRelative
        '
        Me.chkYRelative.AutoSize = True
        Me.chkYRelative.Location = New System.Drawing.Point(171, 53)
        Me.chkYRelative.Name = "chkYRelative"
        Me.chkYRelative.Size = New System.Drawing.Size(65, 17)
        Me.chkYRelative.TabIndex = 13
        Me.chkYRelative.Text = "Relative"
        Me.chkYRelative.UseVisualStyleBackColor = True
        '
        'chkXRelative
        '
        Me.chkXRelative.AutoSize = True
        Me.chkXRelative.Location = New System.Drawing.Point(171, 26)
        Me.chkXRelative.Name = "chkXRelative"
        Me.chkXRelative.Size = New System.Drawing.Size(65, 17)
        Me.chkXRelative.TabIndex = 12
        Me.chkXRelative.Text = "Relative"
        Me.chkXRelative.UseVisualStyleBackColor = True
        '
        'btnSetManualDimension
        '
        Me.btnSetManualDimension.Location = New System.Drawing.Point(188, 131)
        Me.btnSetManualDimension.Name = "btnSetManualDimension"
        Me.btnSetManualDimension.Size = New System.Drawing.Size(101, 36)
        Me.btnSetManualDimension.TabIndex = 11
        Me.btnSetManualDimension.Text = "Manual dimension set"
        Me.btnSetManualDimension.UseVisualStyleBackColor = True
        Me.btnSetManualDimension.Visible = False
        '
        'btnSetManualPosition
        '
        Me.btnSetManualPosition.Location = New System.Drawing.Point(9, 130)
        Me.btnSetManualPosition.Name = "btnSetManualPosition"
        Me.btnSetManualPosition.Size = New System.Drawing.Size(101, 37)
        Me.btnSetManualPosition.TabIndex = 10
        Me.btnSetManualPosition.Text = "Manual position set"
        Me.btnSetManualPosition.UseVisualStyleBackColor = True
        Me.btnSetManualPosition.Visible = False
        '
        'txtHeightGrab
        '
        Me.txtHeightGrab.Location = New System.Drawing.Point(53, 104)
        Me.txtHeightGrab.MaxLength = 5
        Me.txtHeightGrab.Name = "txtHeightGrab"
        Me.txtHeightGrab.Size = New System.Drawing.Size(95, 20)
        Me.txtHeightGrab.TabIndex = 9
        Me.txtHeightGrab.Text = "100"
        '
        'txtWidthGrab
        '
        Me.txtWidthGrab.Location = New System.Drawing.Point(53, 77)
        Me.txtWidthGrab.MaxLength = 5
        Me.txtWidthGrab.Name = "txtWidthGrab"
        Me.txtWidthGrab.Size = New System.Drawing.Size(95, 20)
        Me.txtWidthGrab.TabIndex = 8
        Me.txtWidthGrab.Text = "100"
        '
        'txtYPos
        '
        Me.txtYPos.Location = New System.Drawing.Point(53, 50)
        Me.txtYPos.MaxLength = 5
        Me.txtYPos.Name = "txtYPos"
        Me.txtYPos.Size = New System.Drawing.Size(95, 20)
        Me.txtYPos.TabIndex = 7
        Me.txtYPos.Text = "1"
        '
        'txtXPos
        '
        Me.txtXPos.Location = New System.Drawing.Point(53, 23)
        Me.txtXPos.MaxLength = 5
        Me.txtXPos.Name = "txtXPos"
        Me.txtXPos.Size = New System.Drawing.Size(95, 20)
        Me.txtXPos.TabIndex = 6
        Me.txtXPos.Text = "1"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 111)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Height"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 80)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Width"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Y"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "X"
        '
        'chkDrawScanningBorders
        '
        Me.chkDrawScanningBorders.AutoSize = True
        Me.chkDrawScanningBorders.Location = New System.Drawing.Point(12, 92)
        Me.chkDrawScanningBorders.Name = "chkDrawScanningBorders"
        Me.chkDrawScanningBorders.Size = New System.Drawing.Size(135, 17)
        Me.chkDrawScanningBorders.TabIndex = 4
        Me.chkDrawScanningBorders.Text = "Draw scanning borders"
        Me.chkDrawScanningBorders.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(12, 212)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(101, 44)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(410, 212)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(101, 44)
        Me.cmdSave.TabIndex = 6
        Me.cmdSave.Text = "Save"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'chkDrawOnResize
        '
        Me.chkDrawOnResize.AutoSize = True
        Me.chkDrawOnResize.Location = New System.Drawing.Point(12, 116)
        Me.chkDrawOnResize.Name = "chkDrawOnResize"
        Me.chkDrawOnResize.Size = New System.Drawing.Size(136, 17)
        Me.chkDrawOnResize.TabIndex = 7
        Me.chkDrawOnResize.Text = "Draw preview on resize"
        Me.chkDrawOnResize.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 176)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Redraw speed (ms)"
        '
        'txtRedrawSpeed
        '
        Me.txtRedrawSpeed.Location = New System.Drawing.Point(113, 173)
        Me.txtRedrawSpeed.MaxLength = 4
        Me.txtRedrawSpeed.Name = "txtRedrawSpeed"
        Me.txtRedrawSpeed.Size = New System.Drawing.Size(34, 20)
        Me.txtRedrawSpeed.TabIndex = 16
        Me.txtRedrawSpeed.Text = "250"
        '
        'cmdShowPreviewer
        '
        Me.cmdShowPreviewer.Location = New System.Drawing.Point(207, 212)
        Me.cmdShowPreviewer.Name = "cmdShowPreviewer"
        Me.cmdShowPreviewer.Size = New System.Drawing.Size(119, 44)
        Me.cmdShowPreviewer.TabIndex = 17
        Me.cmdShowPreviewer.Text = "Show Previewer"
        Me.cmdShowPreviewer.UseVisualStyleBackColor = True
        '
        'mnuSystemTray
        '
        Me.mnuSystemTray.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ShowPreviewerToolStripMenuItem, Me.ToolStripMenuItem1, Me.SettingsToolStripMenuItem, Me.ToolStripMenuItem2, Me.SetManualPositionToolStripMenuItem, Me.SetManualDimensionToolStripMenuItem, Me.ToolStripMenuItem3, Me.DrawScanningBordersToolStripMenuItem, Me.ToolStripMenuItem4, Me.AboutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.mnuSystemTray.Name = "mnuSystemTray"
        Me.mnuSystemTray.Size = New System.Drawing.Size(197, 182)
        '
        'ShowPreviewerToolStripMenuItem
        '
        Me.ShowPreviewerToolStripMenuItem.Name = "ShowPreviewerToolStripMenuItem"
        Me.ShowPreviewerToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.ShowPreviewerToolStripMenuItem.Text = "Show Previewer"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(193, 6)
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(193, 6)
        '
        'SetManualPositionToolStripMenuItem
        '
        Me.SetManualPositionToolStripMenuItem.Name = "SetManualPositionToolStripMenuItem"
        Me.SetManualPositionToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.SetManualPositionToolStripMenuItem.Text = "Set Manual Position"
        '
        'SetManualDimensionToolStripMenuItem
        '
        Me.SetManualDimensionToolStripMenuItem.Name = "SetManualDimensionToolStripMenuItem"
        Me.SetManualDimensionToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.SetManualDimensionToolStripMenuItem.Text = "Set Manual Dimension"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(193, 6)
        '
        'DrawScanningBordersToolStripMenuItem
        '
        Me.DrawScanningBordersToolStripMenuItem.Name = "DrawScanningBordersToolStripMenuItem"
        Me.DrawScanningBordersToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.DrawScanningBordersToolStripMenuItem.Text = "Draw Scanning Borders"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(193, 6)
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'nioSystemTray
        '
        Me.nioSystemTray.ContextMenuStrip = Me.mnuSystemTray
        Me.nioSystemTray.Icon = CType(resources.GetObject("nioSystemTray.Icon"), System.Drawing.Icon)
        Me.nioSystemTray.Text = "MacroSizer"
        Me.nioSystemTray.Visible = True
        '
        'chkDoubleBufferedRedraw
        '
        Me.chkDoubleBufferedRedraw.AutoSize = True
        Me.chkDoubleBufferedRedraw.Location = New System.Drawing.Point(12, 140)
        Me.chkDoubleBufferedRedraw.Name = "chkDoubleBufferedRedraw"
        Me.chkDoubleBufferedRedraw.Size = New System.Drawing.Size(143, 17)
        Me.chkDoubleBufferedRedraw.TabIndex = 19
        Me.chkDoubleBufferedRedraw.Text = "Double Buffered Memory"
        Me.chkDoubleBufferedRedraw.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 265)
        Me.Controls.Add(Me.chkDoubleBufferedRedraw)
        Me.Controls.Add(Me.cmdShowPreviewer)
        Me.Controls.Add(Me.txtRedrawSpeed)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.chkDrawOnResize)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.chkDrawScanningBorders)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chkOpenPreviewerOnStartup)
        Me.Controls.Add(Me.chkStartMinimized)
        Me.Controls.Add(Me.chkStartWithWindows)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(612, 321)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MacroSizer Settings"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.mnuSystemTray.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkStartWithWindows As System.Windows.Forms.CheckBox
    Friend WithEvents chkStartMinimized As System.Windows.Forms.CheckBox
    Friend WithEvents chkOpenPreviewerOnStartup As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtXPos As System.Windows.Forms.TextBox
    Friend WithEvents btnSetManualPosition As System.Windows.Forms.Button
    Friend WithEvents txtHeightGrab As System.Windows.Forms.TextBox
    Friend WithEvents txtWidthGrab As System.Windows.Forms.TextBox
    Friend WithEvents txtYPos As System.Windows.Forms.TextBox
    Friend WithEvents btnSetManualDimension As System.Windows.Forms.Button
    Friend WithEvents chkDrawScanningBorders As System.Windows.Forms.CheckBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents chkDrawOnResize As System.Windows.Forms.CheckBox
    Friend WithEvents chkXRelative As System.Windows.Forms.CheckBox
    Friend WithEvents chkYRelative As System.Windows.Forms.CheckBox
    Friend WithEvents chkHeightRelative As System.Windows.Forms.CheckBox
    Friend WithEvents chkWidthRelative As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRedrawSpeed As System.Windows.Forms.TextBox
    Friend WithEvents cmdShowPreviewer As System.Windows.Forms.Button
    Friend WithEvents mnuSystemTray As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ShowPreviewerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents SetManualPositionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SetManualDimensionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DrawScanningBordersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents nioSystemTray As System.Windows.Forms.NotifyIcon
    Friend WithEvents chkDoubleBufferedRedraw As System.Windows.Forms.CheckBox

End Class
