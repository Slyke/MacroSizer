Public Class frmPreview

    Dim captureImage As Bitmap
    Dim scanLinesVisible As Boolean
    Dim onScreenLines As Graphics
    Dim mouseDraggingForm As Boolean = False
    Dim mouseDragX As Integer
    Dim mouseDragY As Integer

    Private Sub frmPreview_Click(sender As Object, e As EventArgs) Handles Me.Click

        Try
            Me.BackgroundImage.Dispose()
        Catch ex As Exception

        End Try

        Me.BackgroundImage = resizeImage(takePicture(), Me.Width, Me.Height)

    End Sub

    Private Sub frmPreview_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick

        If Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None Then
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
            FullScreenToolStripMenuItem.Checked = False
        Else
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            FullScreenToolStripMenuItem.Checked = True
        End If

    End Sub

    Private Sub frmPreview_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.DoubleBuffered = getDoubleBufferedMemory()

        Me.Left = getPreviewerX()
        Me.Top = getPreviewerY()
        Me.Width = getPreviewerWidth()
        Me.Height = getPreviewerHeight()
        Me.FormBorderStyle = getPreviewerWindowState()

        tmrRefresh.Start()

    End Sub

    Private Sub tmrRefresh_Tick(sender As Object, e As EventArgs) Handles tmrRefresh.Tick

        If Me.Visible = False Then
            tmrRefresh.Stop()
        End If

        Me.DoubleBuffered = getDoubleBufferedMemory()

        Try
            Me.BackgroundImage.Dispose()
        Catch ex As Exception

        End Try

        If (getDrawScanningBorders()) Then

            Try
                onScreenLines.Dispose()
            Catch ex As Exception

            End Try

            If Not (scanLinesVisible) Then
                Dim area As Rectangle
                Dim randomGenerator As New Random
                Dim randomColor As New Color
                randomColor = Color.FromArgb(randomGenerator.Next(0, 255), randomGenerator.Next(0, 255), randomGenerator.Next(0, 255), randomGenerator.Next(0, 255))
                Dim randomBrushColor As New SolidBrush(randomColor)
                Dim drawingPen As New Pen(randomBrushColor, 20)

                If getRelativeSetting(relativeSettings.relativeHeight) Then
                    area.Height = ((getGrabHeight() / 100) * Screen.PrimaryScreen.Bounds.Height)
                Else
                    area.Height = getGrabHeight()
                End If

                If getRelativeSetting(relativeSettings.relativeWidth) Then
                    area.Width = ((getGrabWidth() / 100) * Screen.PrimaryScreen.Bounds.Width)
                Else
                    area.Width = getGrabWidth()
                End If

                If getRelativeSetting(relativeSettings.relativeX) Then
                    area.X = ((getXPosition() / 100) * Screen.PrimaryScreen.Bounds.Width)
                Else
                    area.X = getXPosition()
                End If

                If getRelativeSetting(relativeSettings.relativeY) Then
                    area.Y = ((getYPosition() / 100) * Screen.PrimaryScreen.Bounds.Height)
                Else
                    area.Y = getYPosition()
                End If

                onScreenLines = Graphics.FromHwnd(New IntPtr(0))
                onScreenLines.DrawRectangle(drawingPen, area.X, area.Y, area.Width, area.Height)
            End If

            scanLinesVisible = Not scanLinesVisible

        End If

        tmrRefresh.Interval = getRedrawSpeed()
        Me.BackgroundImage = resizeImage(takePicture(), Me.Width, Me.Height)

    End Sub

    Private Function takePicture() As System.Drawing.Bitmap

        Try
            captureImage.Dispose()
        Catch ex As Exception

        End Try

        Dim area As Rectangle

        Dim graph As Graphics

        If getRelativeSetting(relativeSettings.relativeHeight) Then
            area.Height = ((getGrabHeight() / 100) * Screen.PrimaryScreen.Bounds.Height)
        Else
            area.Height = getGrabHeight()
        End If

        If getRelativeSetting(relativeSettings.relativeWidth) Then
            area.Width = ((getGrabWidth() / 100) * Screen.PrimaryScreen.Bounds.Width)
        Else
            area.Width = getGrabWidth()
        End If

        If getRelativeSetting(relativeSettings.relativeX) Then
            area.X = ((getXPosition() / 100) * Screen.PrimaryScreen.Bounds.Width)
        Else
            area.X = getXPosition()
        End If

        If getRelativeSetting(relativeSettings.relativeY) Then
            area.Y = ((getYPosition() / 100) * Screen.PrimaryScreen.Bounds.Height)
        Else
            area.Y = getYPosition()
        End If

        captureImage = New Bitmap(area.Width, area.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb)

        graph = Graphics.FromImage(captureImage)

        graph.CopyFromScreen(area.X, area.Y, 0, 0, area.Size)
        graph.Dispose()

        Return captureImage

    End Function

    Private Function resizeImage(ByVal theImage As System.Drawing.Bitmap, ByVal newXPixels As Integer, ByVal newYPixels As Integer) As Bitmap

        Dim newSize As Size

        If Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None Then
            If getOffsetCalcMode(zoomOffsetMode.freeWindow) Then
                newSize.Height = newYPixels + getScreenHeightOffset()
                newSize.Width = newXPixels + getScreenWidthOffset()
            Else
                newSize.Height = newYPixels
                newSize.Width = newXPixels
            End If
        Else
            If getOffsetCalcMode(zoomOffsetMode.bordered) Then
                newSize.Height = newYPixels + getScreenHeightOffset()
                newSize.Width = newXPixels + getScreenWidthOffset()
            Else
                newSize.Height = newYPixels
                newSize.Width = newXPixels
            End If
        End If

        If newSize.Height <= 0 Then
            newSize.Height = 1
        End If

        If newSize.Width <= 0 Then
            newSize.Width = 1
        End If

        Return New Bitmap(theImage, newSize)

    End Function

    Private Sub frmPreview_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown

        If e.Button = Windows.Forms.MouseButtons.Left Then
            mouseDraggingForm = True
            mouseDragX = e.X
            mouseDragY = e.Y
        End If

    End Sub

    Private Sub frmPreview_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If mouseDraggingForm = True Then
            Dim newPoint As Point = New Point
            newPoint.X = Me.Location.X + (e.X - mouseDragX)
            newPoint.Y = Me.Location.Y + (e.Y - mouseDragY)
            Me.Location = newPoint
            newPoint = Nothing
        End If
    End Sub

    Private Sub frmPreview_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        If e.Button = Windows.Forms.MouseButtons.Left Then
            mouseDraggingForm = False
        ElseIf e.Button = Windows.Forms.MouseButtons.Right Then
            DoubleBufferedToolStripMenuItem.Checked = getDoubleBufferedMemory()
        End If

        setPreviewerX(Me.Left)
        setPreviewerY(Me.Top)
        setPreviewerWidth(Me.Width)
        setPreviewerHeight(Me.Height)
        setPreviewerWindowState(Me.FormBorderStyle)

        saveSettingsFile(getSettingsFile(), generateSettingsStringArray())

    End Sub

    Private Sub frmPreview_Resize(sender As Object, e As EventArgs) Handles Me.Resize


        If getDrawOnResize() Then

            Try
                Me.BackgroundImage.Dispose()
            Catch ex As Exception

            End Try

            Me.BackgroundImage = resizeImage(takePicture(), Me.Width, Me.Height)
        End If

    End Sub

    Private Sub frmPreview_ResizeBegin(sender As Object, e As EventArgs) Handles Me.ResizeBegin
        tmrRefresh.Enabled = False
    End Sub

    Private Sub frmPreview_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd

        setPreviewerX(Me.Left)
        setPreviewerY(Me.Top)
        setPreviewerWidth(Me.Width)
        setPreviewerHeight(Me.Height)
        setPreviewerWindowState(Me.FormBorderStyle)

        saveSettingsFile(getSettingsFile(), generateSettingsStringArray())

        Try
            Me.BackgroundImage.Dispose()
        Catch ex As Exception

        End Try
        Me.BackgroundImage.Dispose()
        Me.BackgroundImage = resizeImage(takePicture(), Me.Width, Me.Height)
        tmrRefresh.Enabled = True

    End Sub

    Private Sub ShowSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowSettingsToolStripMenuItem.Click
        frmMain.Show()
        frmMain.BringToFront()
    End Sub

    Private Sub FullScreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FullScreenToolStripMenuItem.Click

        If Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None Then
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
            FullScreenToolStripMenuItem.Checked = False
        Else
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            FullScreenToolStripMenuItem.Checked = True
        End If

    End Sub

    Private Sub DoubleBufferedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DoubleBufferedToolStripMenuItem.Click

        DoubleBufferedToolStripMenuItem.Checked = Not DoubleBufferedToolStripMenuItem.Checked

        frmMain.chkDoubleBufferedRedraw.Checked = DoubleBufferedToolStripMenuItem.Checked
        setDoubleBufferedMemory(DoubleBufferedToolStripMenuItem.Checked)

    End Sub

    Private Sub HideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HideToolStripMenuItem.Click
        tmrRefresh.Stop()
        Me.Visible = False

    End Sub
End Class