Public Class frmMain

    Private startingUp As Boolean = True

    Private Sub frmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        e.Cancel = True
        updateSettings()
        Me.Visible = False

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadSettingsFromString(loadSettingsFile(getSettingsFile()))

        If My.Application.CommandLineArgs.Count = 2 Then
            If My.Application.CommandLineArgs(0) = "settings" Or My.Application.CommandLineArgs(0) = "setting" Then
                loadSettingsFromString(My.Application.CommandLineArgs(1))
            End If
        End If
        startingUp = True

        updateSettings()

        If getShowPreviewerOnStartup() Then
            frmPreview.Show()
            frmPreview.BringToFront()
        End If

        DrawScanningBordersToolStripMenuItem.Checked = chkDrawScanningBorders.Checked

        Me.Left = getSettingsX()
        Me.Top = getSettingsY()

    End Sub


    Private Sub cmdSave_Click(sender As Object, e As EventArgs) Handles cmdSave.Click

        saveSettings()

        saveSettingsFile(getSettingsFile(), generateSettingsStringArray())

        nioSystemTray.Visible = True
        Me.Visible = False

    End Sub

    Private Sub saveSettings()

        setXPosition(txtXPos.Text)
        setYPosition(txtYPos.Text)
        setGrabWidth(txtWidthGrab.Text)
        setGrabHeight(txtHeightGrab.Text)
        setDrawOnResize(chkDrawOnResize.Checked)
        setRelativeSetting(relativeSettings.relativeX, chkXRelative.Checked)
        setRelativeSetting(relativeSettings.relativeY, chkYRelative.Checked)
        setRelativeSetting(relativeSettings.relativeHeight, chkHeightRelative.Checked)
        setRelativeSetting(relativeSettings.relativeWidth, chkWidthRelative.Checked)
        setRedrawSpeed(txtRedrawSpeed.Text)
        setDrawScanningBordersToScreen(chkDrawScanningBorders.Checked)
        setShowPreviewerOnStartup(chkOpenPreviewerOnStartup.Checked)
        setStartWithWindows(chkStartWithWindows.Checked)
        setStartMinimized(chkStartMinimized.Checked)
        setDoubleBufferedMemory(chkDoubleBufferedRedraw.Checked)

        frmPreview.DoubleBufferedToolStripMenuItem.Checked = chkDoubleBufferedRedraw.Checked
        DrawScanningBordersToolStripMenuItem.Checked = chkDrawScanningBorders.Checked

        Try
            If getStartWithWindows() Then
                Dim regKey As Microsoft.Win32.RegistryKey
                regKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
                regKey.SetValue("Microsizer", Application.ExecutablePath)
                regKey.Close()
            Else
                Dim regKey As Microsoft.Win32.RegistryKey
                regKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\Run", True)
                regKey.DeleteValue("Microsizer", False)
                regKey.Close()
            End If
        Catch ex As Exception
            setStartWithWindows(False)
            chkStartWithWindows.Checked = False
            MsgBox("Couldn't get permission to start with Windows. Try running this again as an administrator. Will revert settings.")
        End Try

    End Sub

    Private Sub updateSettings()

        txtXPos.Text = getXPosition()
        txtYPos.Text = getYPosition()
        txtWidthGrab.Text = getGrabWidth()
        txtHeightGrab.Text = getGrabHeight()
        txtRedrawSpeed.Text = getRedrawSpeed()
        chkDrawOnResize.Checked = getDrawOnResize()
        chkDrawScanningBorders.Checked = getDrawScanningBorders()
        chkOpenPreviewerOnStartup.Checked = getShowPreviewerOnStartup()
        chkXRelative.Checked = getRelativeSetting(relativeSettings.relativeX)
        chkYRelative.Checked = getRelativeSetting(relativeSettings.relativeY)
        chkHeightRelative.Checked = getRelativeSetting(relativeSettings.relativeHeight)
        chkWidthRelative.Checked = getRelativeSetting(relativeSettings.relativeWidth)
        chkDoubleBufferedRedraw.Checked = getDoubleBufferedMemory()
        chkStartWithWindows.Checked = getStartWithWindows()
        chkStartMinimized.Checked = getStartMinimized()

        Me.Left = getSettingsX()
        Me.Top = getSettingsY()

    End Sub

    Private Sub cmdShowPreviewer_Click(sender As Object, e As EventArgs) Handles cmdShowPreviewer.Click

        frmPreview.Show()
        frmPreview.BringToFront()

    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click

        nioSystemTray.Visible = False
        Me.Visible = True
        Me.BringToFront()

    End Sub

    Private Sub ShowPreviewerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowPreviewerToolStripMenuItem.Click

        frmPreview.Show()
        frmPreview.BringToFront()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        System.Windows.Forms.Application.Exit()
        nioSystemTray.Visible = False
        End

    End Sub

    Private Sub DrawScanningBordersToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DrawScanningBordersToolStripMenuItem.Click

        DrawScanningBordersToolStripMenuItem.Checked = Not DrawScanningBordersToolStripMenuItem.Checked

        chkDrawScanningBorders.Checked = DrawScanningBordersToolStripMenuItem.Checked

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        updateSettings()
        Me.Visible = False

    End Sub

    Private Sub frmMain_Move(sender As Object, e As EventArgs) Handles Me.Move
        setSettingsX(Me.Left)
        setSettingsY(Me.Top)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Created by: Slyke" & vbCrLf & "Email: Slyke@phoxenix.com")
    End Sub

    Private Sub frmMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        If startingUp Then
            Me.Visible = Not chkStartMinimized.Checked
            startingUp = False
        End If


    End Sub

    Private Sub nioSystemTray_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles nioSystemTray.MouseDoubleClick
        Me.Show()
        Me.BringToFront()
    End Sub

    Private Sub btnSetManualPosition_Click(sender As Object, e As EventArgs) Handles btnSetManualPosition.Click
        MsgBox("Not yet working.")
    End Sub

    Private Sub btnSetManualDimension_Click(sender As Object, e As EventArgs) Handles btnSetManualDimension.Click
        MsgBox("Not yet working.")
    End Sub
End Class
