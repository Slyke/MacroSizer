Module settingsHolder

    Private xPos As Double = 400
    Private yPos As Double = 400
    Private grabWidth As Double = 20
    Private grabHeight As Double = 20
    Private drawOnResize As Boolean = False
    Private xRelative As Boolean = False
    Private yRelative As Boolean = False
    Private widthRelative As Boolean = True
    Private heightRelative As Boolean = True
    Private redrawSpeed As Integer = 250
    Private drawScanningBordersToScreen As Boolean = False
    Private showPreviewerOnStartup As Boolean = True
    Private doubleBufferedMemory As Boolean = True
    Private startMinimized As Boolean = False
    Private startWithWindows As Boolean = False
    Private offsetCalcMode As Integer
    Private offsetBorderedCalc As Boolean
    Private offsetFreeWindowCalc As Boolean

    Private previewerWindowState As Integer = 4
    Private previewerX As Integer = 0
    Private previewerY As Integer = 0
    Private previewerWidth As Integer = 200
    Private previewerHeight As Integer = 200

    Private settingsX As Integer
    Private settingsY As Integer

    Private settingsNewLine As Boolean = False

    Private screenHeightOffset As Integer = -37
    Private screenWidthOffset As Integer = -15

    Private Const SETTINGS_FILE As String = "./macrosizer.dat"
    Private Const SETTING_XPOS As String = "xpos"
    Private Const SETTING_YPOS As String = "ypos"
    Private Const SETTING_CAPWIDTH As String = "capwidth"
    Private Const SETTING_CAPHEIGHT As String = "capheight"
    Private Const SETTING_CAPRELATIVES As String = "relativeconfig"
    Private Const SETTING_REFRESHRATE As String = "refreshrate"
    Private Const SETTING_DRAWONRESIZE As String = "drawonresize"
    Private Const SETTING_DRAWSCANNINGBORDERS As String = "drawscanningborders"
    Private Const SETTING_SHOWPREVIEWONSTARTUP As String = "showpreviewonstartup"
    Private Const SETTING_HEIGHTOFFSET As String = "resizeheightoffset"
    Private Const SETTING_WIDTHOFFSET As String = "resizewidthoffset"
    Private Const SETTING_DOUBLEBUFFEREDMEMORY As String = "doublebufferedmemory"
    Private Const SETTING_STARTMINIMIZED As String = "startminimized"
    Private Const SETTING_STARTWITHWINDOWS As String = "startwithwindows"
    Private Const SETTING_OFFSETMODE As String = "resizeoffsetmode"
    Private Const SETTING_NEWLINE As String = "splitsettings_crlf"
    Private Const WINDOW_PREVIEW_X As String = "previewer_x"
    Private Const WINDOW_PREVIEW_Y As String = "previewer_y"
    Private Const WINDOW_PREVIEW_WIDTH As String = "previewer_width"
    Private Const WINDOW_PREVIEW_HEIGHT As String = "previewer_height"
    Private Const WINDOW_PREVIEW_STATE As String = "previewer_state"
    Private Const WINDOW_SETTINGS_X As String = "settings_x"
    Private Const WINDOW_SETTINGS_Y As String = "settings_y"

    Private Const DEFAULT_RELATIVESETTING As Integer = 12
    Private Const DEFAULT_OFFSETCALC As Integer = 1

    Public Enum relativeSettings
        relativeX = 1
        relativeY = 2
        relativeWidth = 4
        relativeHeight = 8
    End Enum

    Public Enum zoomOffsetMode
        bordered = 1
        freeWindow = 2
    End Enum

    Public Function generateSettingsStringArray() As String

        Dim returnString As String = ""
        Dim relativeSettingStore As Integer = 0
        Dim offsetCalc As Integer = 0

        If xRelative Then
            relativeSettingStore += relativeSettings.relativeX
        End If
        If yRelative Then
            relativeSettingStore += relativeSettings.relativeY
        End If
        If widthRelative Then
            relativeSettingStore += relativeSettings.relativeWidth
        End If
        If heightRelative Then
            relativeSettingStore += relativeSettings.relativeHeight
        End If

        If offsetBorderedCalc Then
            offsetCalc += zoomOffsetMode.bordered
        End If
        If offsetFreeWindowCalc Then
            offsetCalc += zoomOffsetMode.freeWindow
        End If

        returnString &= SETTING_XPOS & KV_Separate & xPos.ToString & KV_EndKey
        returnString &= SETTING_YPOS & KV_Separate & yPos.ToString & KV_EndKey
        returnString &= SETTING_CAPWIDTH & KV_Separate & grabWidth.ToString & KV_EndKey
        returnString &= SETTING_CAPHEIGHT & KV_Separate & grabHeight.ToString & KV_EndKey
        returnString &= SETTING_CAPRELATIVES & KV_Separate & relativeSettingStore.ToString & KV_EndKey
        returnString &= SETTING_REFRESHRATE & KV_Separate & redrawSpeed.ToString & KV_EndKey
        returnString &= SETTING_DRAWONRESIZE & KV_Separate & drawOnResize.ToString & KV_EndKey
        returnString &= SETTING_SHOWPREVIEWONSTARTUP & KV_Separate & showPreviewerOnStartup.ToString & KV_EndKey
        returnString &= SETTING_DRAWSCANNINGBORDERS & KV_Separate & drawScanningBordersToScreen.ToString & KV_EndKey
        returnString &= SETTING_DOUBLEBUFFEREDMEMORY & KV_Separate & doubleBufferedMemory.ToString & KV_EndKey
        returnString &= SETTING_STARTMINIMIZED & KV_Separate & startMinimized.ToString & KV_EndKey
        returnString &= SETTING_STARTWITHWINDOWS & KV_Separate & startWithWindows.ToString & KV_EndKey
        returnString &= SETTING_NEWLINE & KV_Separate & settingsNewLine.ToString & KV_EndKey
        returnString &= WINDOW_PREVIEW_X & KV_Separate & previewerX.ToString & KV_EndKey
        returnString &= WINDOW_PREVIEW_Y & KV_Separate & previewerY.ToString & KV_EndKey
        returnString &= WINDOW_PREVIEW_WIDTH & KV_Separate & previewerWidth.ToString & KV_EndKey
        returnString &= WINDOW_PREVIEW_HEIGHT & KV_Separate & previewerHeight.ToString & KV_EndKey
        returnString &= WINDOW_PREVIEW_STATE & KV_Separate & previewerWindowState.ToString & KV_EndKey
        returnString &= WINDOW_SETTINGS_X & KV_Separate & settingsX.ToString & KV_EndKey
        returnString &= WINDOW_SETTINGS_Y & KV_Separate & settingsY.ToString & KV_EndKey
        returnString &= SETTING_OFFSETMODE & KV_Separate & offsetCalc.ToString & KV_EndKey

        returnString &= SETTING_HEIGHTOFFSET & KV_Separate & screenHeightOffset.ToString & KV_EndKey
        returnString &= SETTING_WIDTHOFFSET & KV_Separate & screenWidthOffset.ToString & KV_EndKey

        If settingsNewLine Then
            returnString = returnString.Replace(KV_EndKey, (KV_EndKey & KV_EoL))
        End If

        Return returnString

    End Function

    Public Sub loadSettingsFromString(inputSettingsString As String)

        setXPosition(getValueFromString(inputSettingsString, SETTING_XPOS, xPos))
        setYPosition(getValueFromString(inputSettingsString, SETTING_YPOS, yPos))
        setGrabWidth(getValueFromString(inputSettingsString, SETTING_CAPWIDTH, grabWidth))
        setGrabHeight(getValueFromString(inputSettingsString, SETTING_CAPHEIGHT, grabHeight))
        setRedrawSpeed(getValueFromString(inputSettingsString, SETTING_REFRESHRATE, redrawSpeed))
        setDrawOnResize(getValueFromString(inputSettingsString, SETTING_DRAWONRESIZE, drawOnResize))
        setShowPreviewerOnStartup(getValueFromString(inputSettingsString, SETTING_SHOWPREVIEWONSTARTUP, showPreviewerOnStartup))
        setDrawScanningBordersToScreen(getValueFromString(inputSettingsString, SETTING_DRAWSCANNINGBORDERS, drawScanningBordersToScreen))
        setDoubleBufferedMemory(getValueFromString(inputSettingsString, SETTING_DOUBLEBUFFEREDMEMORY, doubleBufferedMemory))
        setStartMinimized(getValueFromString(inputSettingsString, SETTING_STARTMINIMIZED, startMinimized))
        setStartWithWindows(getValueFromString(inputSettingsString, SETTING_STARTWITHWINDOWS, startWithWindows))
        setSettingsNewLine(getValueFromString(inputSettingsString, SETTING_NEWLINE, settingsNewLine))
        setPreviewerX(getValueFromString(inputSettingsString, WINDOW_PREVIEW_X, previewerX))
        setPreviewerY(getValueFromString(inputSettingsString, WINDOW_PREVIEW_Y, previewerY))
        setPreviewerWidth(getValueFromString(inputSettingsString, WINDOW_PREVIEW_WIDTH, previewerWidth))
        setPreviewerHeight(getValueFromString(inputSettingsString, WINDOW_PREVIEW_HEIGHT, previewerHeight))
        setPreviewerWindowState(getValueFromString(inputSettingsString, WINDOW_PREVIEW_STATE, previewerWindowState))
        setSettingsX(getValueFromString(inputSettingsString, WINDOW_SETTINGS_X, settingsX))
        setSettingsY(getValueFromString(inputSettingsString, WINDOW_SETTINGS_Y, settingsY))

        Dim relativeSettingGet As Integer = getValueFromString(inputSettingsString, SETTING_CAPRELATIVES, DEFAULT_RELATIVESETTING)
        setRelativeSetting(relativeSettings.relativeX, (relativeSettings.relativeX And relativeSettingGet))
        setRelativeSetting(relativeSettings.relativeY, (relativeSettings.relativeY And relativeSettingGet))
        setRelativeSetting(relativeSettings.relativeWidth, (relativeSettings.relativeWidth And relativeSettingGet))
        setRelativeSetting(relativeSettings.relativeHeight, (relativeSettings.relativeHeight And relativeSettingGet))

        Dim offsetCalc As Integer = getValueFromString(inputSettingsString, SETTING_OFFSETMODE, DEFAULT_OFFSETCALC)
        setOffsetCalcMode(zoomOffsetMode.bordered, (zoomOffsetMode.bordered And offsetCalc))
        setOffsetCalcMode(zoomOffsetMode.freeWindow, (zoomOffsetMode.freeWindow And offsetCalc))

    End Sub

    Public Function getSettingsY() As Integer

        Return settingsY

    End Function

    Public Sub setSettingsY(newSettingsY As Integer)

        settingsY = newSettingsY

    End Sub

    Public Function getSettingsX() As Integer

        Return settingsX

    End Function

    Public Sub setSettingsX(newSettingsX As Integer)

        settingsX = newSettingsX

    End Sub

    Public Function getPreviewerHeight() As Integer

        Return previewerHeight

    End Function

    Public Sub setPreviewerHeight(newPreviewerHeight As Integer)

        previewerHeight = newPreviewerHeight

    End Sub

    Public Function getPreviewerWidth() As Integer

        Return previewerWidth

    End Function

    Public Sub setPreviewerWidth(newPreviewerWidth As Integer)

        previewerWidth = newPreviewerWidth

    End Sub

    Public Function getPreviewerY() As Integer

        Return previewerY

    End Function

    Public Sub setPreviewerY(newPreviewerY As Integer)

        previewerY = newPreviewerY

    End Sub

    Public Function getPreviewerX() As Integer

        Return previewerX

    End Function

    Public Sub setPreviewerX(newPreviewerX As Integer)

        previewerX = newPreviewerX

    End Sub

    Public Function getSettingsNewLine() As Boolean

        Return settingsNewLine

    End Function

    Public Sub setSettingsNewLine(newSettingsNewLine As Boolean)

        settingsNewLine = newSettingsNewLine

    End Sub

    Public Function getPreviewerWindowState() As Integer

        Return previewerWindowState

    End Function

    Public Sub setPreviewerWindowState(newPreviewerWindowState As Integer)

        previewerWindowState = newPreviewerWindowState

    End Sub

    Public Function getStartWithWindows() As Boolean

        Return startWithWindows

    End Function

    Public Sub setStartWithWindows(newStartWithWindows As Boolean)

        startWithWindows = newStartWithWindows

    End Sub

    Public Function getStartMinimized() As Boolean

        Return startMinimized

    End Function

    Public Sub setStartMinimized(newStartMinimized As Boolean)

        startMinimized = newStartMinimized

    End Sub

    Public Function getDoubleBufferedMemory() As Boolean

        Return doubleBufferedMemory

    End Function

    Public Sub setDoubleBufferedMemory(newDoubleBufferedMemory As Boolean)

        doubleBufferedMemory = newDoubleBufferedMemory

    End Sub

    Public Function getSettingsFile() As String

        Return SETTINGS_FILE

    End Function

    Public Function getShowPreviewerOnStartup() As Boolean

        Return showPreviewerOnStartup

    End Function

    Public Function getDrawScanningBorders() As Integer

        Return drawScanningBordersToScreen

    End Function

    Public Function getRedrawSpeed() As Integer

        Return redrawSpeed

    End Function

    Public Function getXPosition() As Double

        Return xPos

    End Function

    Public Function getYPosition() As Double

        Return yPos

    End Function

    Public Sub setYPosition(newY As Double)

        yPos = newY

    End Sub

    Public Sub setXPosition(newX As Double)

        xPos = newX

    End Sub

    Public Sub setDrawOnResize(newSetting As Boolean)

        drawOnResize = newSetting

    End Sub

    Public Function getGrabWidth() As Double

        Return grabWidth

    End Function

    Public Function getGrabHeight() As Double

        Return grabHeight

    End Function

    Public Sub setGrabWidth(newWidth As Double)

        grabWidth = newWidth

    End Sub

    Public Sub setGrabHeight(newHeight As Double)

        grabHeight = newHeight

    End Sub

    Public Sub setRedrawSpeed(newDrawSpeed As Integer)

        redrawSpeed = newDrawSpeed

    End Sub

    Public Sub setShowPreviewerOnStartup(newShowOnStartupSetting As Boolean)

        showPreviewerOnStartup = newShowOnStartupSetting

    End Sub

    Public Sub setDrawScanningBordersToScreen(newScanningDrawSetting As Boolean)

        drawScanningBordersToScreen = newScanningDrawSetting

    End Sub

    Public Function getDrawOnResize() As Integer

        Return drawOnResize

    End Function

    Public Function getScreenHeightOffset() As Integer

        Return screenHeightOffset

    End Function

    Public Function getScreenWidthOffset() As Integer

        Return screenWidthOffset

    End Function

    Public Function getRelativeSetting(ByVal settingToGet As relativeSettings) As Boolean
        If settingToGet = relativeSettings.relativeX Then
            Return xRelative
        ElseIf settingToGet = relativeSettings.relativeY Then
            Return yRelative
        ElseIf settingToGet = relativeSettings.relativeWidth Then
            Return widthRelative
        ElseIf settingToGet = relativeSettings.relativeHeight Then
            Return heightRelative
        Else
            Return False
        End If
    End Function

    Public Sub setRelativeSetting(ByVal settingToSet As relativeSettings, whatToSetAs As Boolean)
        If settingToSet = relativeSettings.relativeX Then
            xRelative = whatToSetAs
        ElseIf settingToSet = relativeSettings.relativeY Then
            yRelative = whatToSetAs
        ElseIf settingToSet = relativeSettings.relativeWidth Then
            widthRelative = whatToSetAs
        ElseIf settingToSet = relativeSettings.relativeHeight Then
            heightRelative = whatToSetAs
        End If
    End Sub

    Public Function getOffsetCalcMode(ByVal settingToGet As zoomOffsetMode) As Boolean
        If (settingToGet = zoomOffsetMode.bordered) Then
            Return offsetBorderedCalc
        ElseIf settingToGet = zoomOffsetMode.freeWindow Then
            Return offsetFreeWindowCalc
        Else
            Return False
        End If
    End Function

    Public Sub setOffsetCalcMode(ByVal settingToSet As zoomOffsetMode, whatToSetAs As Boolean)
        If settingToSet = zoomOffsetMode.bordered Then
            offsetBorderedCalc = whatToSetAs
        ElseIf settingToSet = zoomOffsetMode.freeWindow Then
            offsetFreeWindowCalc = whatToSetAs
        End If
    End Sub

End Module
