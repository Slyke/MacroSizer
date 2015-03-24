<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPreview))
        Me.tmrRefresh = New System.Windows.Forms.Timer(Me.components)
        Me.mnuPreviewMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.DoubleBufferedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FullScreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ShowSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
        Me.HideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPreviewMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'tmrRefresh
        '
        Me.tmrRefresh.Enabled = True
        Me.tmrRefresh.Interval = 250
        '
        'mnuPreviewMenu
        '
        Me.mnuPreviewMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DoubleBufferedToolStripMenuItem, Me.FullScreenToolStripMenuItem, Me.ToolStripMenuItem1, Me.ShowSettingsToolStripMenuItem, Me.ToolStripMenuItem2, Me.HideToolStripMenuItem})
        Me.mnuPreviewMenu.Name = "mnuPreviewMenu"
        Me.mnuPreviewMenu.Size = New System.Drawing.Size(161, 104)
        '
        'DoubleBufferedToolStripMenuItem
        '
        Me.DoubleBufferedToolStripMenuItem.Name = "DoubleBufferedToolStripMenuItem"
        Me.DoubleBufferedToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.DoubleBufferedToolStripMenuItem.Text = "Double Buffered"
        '
        'FullScreenToolStripMenuItem
        '
        Me.FullScreenToolStripMenuItem.Name = "FullScreenToolStripMenuItem"
        Me.FullScreenToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.FullScreenToolStripMenuItem.Text = "Borderless"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(157, 6)
        '
        'ShowSettingsToolStripMenuItem
        '
        Me.ShowSettingsToolStripMenuItem.Name = "ShowSettingsToolStripMenuItem"
        Me.ShowSettingsToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.ShowSettingsToolStripMenuItem.Text = "Show Settings"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(157, 6)
        '
        'HideToolStripMenuItem
        '
        Me.HideToolStripMenuItem.Name = "HideToolStripMenuItem"
        Me.HideToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.HideToolStripMenuItem.Text = "Hide"
        '
        'frmPreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 545)
        Me.ContextMenuStrip = Me.mnuPreviewMenu
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPreview"
        Me.Text = "MacroSizer Preview"
        Me.mnuPreviewMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tmrRefresh As System.Windows.Forms.Timer
    Friend WithEvents mnuPreviewMenu As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents DoubleBufferedToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FullScreenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ShowSettingsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents HideToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
