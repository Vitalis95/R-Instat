<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgMySecondDialog
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
        Me.lblStationData = New System.Windows.Forms.Label()
        Me.lblSatelliteData = New System.Windows.Forms.Label()
        Me.lblFactors = New System.Windows.Forms.Label()
        Me.ucrComparativeStatistics = New System.Windows.Forms.ComboBox()
        Me.lblComparativeStatistics = New System.Windows.Forms.Label()
        Me.lblDayOfYear = New System.Windows.Forms.Label()
        Me.ucrReceiverDayOfYear = New instat.ucrReceiverSingle()
        Me.ucrSelectorFactors = New instat.ucrSelector()
        Me.ucrReceiverSatelliteData = New instat.ucrReceiverSingle()
        Me.ucrReceiverStationData = New instat.ucrReceiverSingle()
        Me.ucrSelectorByDataFrame = New instat.ucrSelectorByDataFrameAddRemove()
        Me.UcrBase = New instat.ucrButtons()
        Me.ucrChkOmitMissing = New instat.ucrCheck()
        Me.SuspendLayout()
        '
        'lblStationData
        '
        Me.lblStationData.AutoSize = True
        Me.lblStationData.Location = New System.Drawing.Point(296, 17)
        Me.lblStationData.Name = "lblStationData"
        Me.lblStationData.Size = New System.Drawing.Size(69, 13)
        Me.lblStationData.TabIndex = 4
        Me.lblStationData.Text = "Station Data:"
        '
        'lblSatelliteData
        '
        Me.lblSatelliteData.AutoSize = True
        Me.lblSatelliteData.Location = New System.Drawing.Point(299, 64)
        Me.lblSatelliteData.Name = "lblSatelliteData"
        Me.lblSatelliteData.Size = New System.Drawing.Size(71, 13)
        Me.lblSatelliteData.TabIndex = 5
        Me.lblSatelliteData.Text = "Satelite Data:"
        '
        'lblFactors
        '
        Me.lblFactors.AutoSize = True
        Me.lblFactors.Location = New System.Drawing.Point(304, 155)
        Me.lblFactors.Name = "lblFactors"
        Me.lblFactors.Size = New System.Drawing.Size(45, 13)
        Me.lblFactors.TabIndex = 8
        Me.lblFactors.Text = "Factors:"
        '
        'ucrComparativeStatistics
        '
        Me.ucrComparativeStatistics.FormattingEnabled = True
        Me.ucrComparativeStatistics.Location = New System.Drawing.Point(312, 337)
        Me.ucrComparativeStatistics.Name = "ucrComparativeStatistics"
        Me.ucrComparativeStatistics.Size = New System.Drawing.Size(121, 21)
        Me.ucrComparativeStatistics.TabIndex = 9
        '
        'lblComparativeStatistics
        '
        Me.lblComparativeStatistics.AutoSize = True
        Me.lblComparativeStatistics.Location = New System.Drawing.Point(309, 321)
        Me.lblComparativeStatistics.Name = "lblComparativeStatistics"
        Me.lblComparativeStatistics.Size = New System.Drawing.Size(114, 13)
        Me.lblComparativeStatistics.TabIndex = 10
        Me.lblComparativeStatistics.Text = "Comparative Statistics:"
        '
        'lblDayOfYear
        '
        Me.lblDayOfYear.AutoSize = True
        Me.lblDayOfYear.Location = New System.Drawing.Point(299, 105)
        Me.lblDayOfYear.Name = "lblDayOfYear"
        Me.lblDayOfYear.Size = New System.Drawing.Size(68, 13)
        Me.lblDayOfYear.TabIndex = 13
        Me.lblDayOfYear.Text = "Day Of Year:"
        '
        'ucrReceiverDayOfYear
        '
        Me.ucrReceiverDayOfYear.frmParent = Me
        Me.ucrReceiverDayOfYear.Location = New System.Drawing.Point(302, 120)
        Me.ucrReceiverDayOfYear.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverDayOfYear.Name = "ucrReceiverDayOfYear"
        Me.ucrReceiverDayOfYear.Selector = Nothing
        Me.ucrReceiverDayOfYear.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverDayOfYear.strNcFilePath = ""
        Me.ucrReceiverDayOfYear.TabIndex = 12
        Me.ucrReceiverDayOfYear.ucrSelector = Nothing
        '
        'ucrSelectorFactors
        '
        Me.ucrSelectorFactors.bShowHiddenColumns = False
        Me.ucrSelectorFactors.Location = New System.Drawing.Point(307, 168)
        Me.ucrSelectorFactors.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorFactors.Name = "ucrSelectorFactors"
        Me.ucrSelectorFactors.Size = New System.Drawing.Size(148, 130)
        Me.ucrSelectorFactors.TabIndex = 7
        '
        'ucrReceiverSatelliteData
        '
        Me.ucrReceiverSatelliteData.frmParent = Me
        Me.ucrReceiverSatelliteData.Location = New System.Drawing.Point(301, 81)
        Me.ucrReceiverSatelliteData.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverSatelliteData.Name = "ucrReceiverSatelliteData"
        Me.ucrReceiverSatelliteData.Selector = Nothing
        Me.ucrReceiverSatelliteData.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverSatelliteData.strNcFilePath = ""
        Me.ucrReceiverSatelliteData.TabIndex = 3
        Me.ucrReceiverSatelliteData.ucrSelector = Nothing
        '
        'ucrReceiverStationData
        '
        Me.ucrReceiverStationData.frmParent = Me
        Me.ucrReceiverStationData.Location = New System.Drawing.Point(302, 34)
        Me.ucrReceiverStationData.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverStationData.Name = "ucrReceiverStationData"
        Me.ucrReceiverStationData.Selector = Nothing
        Me.ucrReceiverStationData.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverStationData.strNcFilePath = ""
        Me.ucrReceiverStationData.TabIndex = 2
        Me.ucrReceiverStationData.ucrSelector = Nothing
        '
        'ucrSelectorByDataFrame
        '
        Me.ucrSelectorByDataFrame.bDropUnusedFilterLevels = False
        Me.ucrSelectorByDataFrame.bShowHiddenColumns = False
        Me.ucrSelectorByDataFrame.bUseCurrentFilter = True
        Me.ucrSelectorByDataFrame.Location = New System.Drawing.Point(8, 6)
        Me.ucrSelectorByDataFrame.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorByDataFrame.Name = "ucrSelectorByDataFrame"
        Me.ucrSelectorByDataFrame.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorByDataFrame.TabIndex = 1
        '
        'UcrBase
        '
        Me.UcrBase.Location = New System.Drawing.Point(12, 393)
        Me.UcrBase.Name = "UcrBase"
        Me.UcrBase.Size = New System.Drawing.Size(409, 52)
        Me.UcrBase.TabIndex = 0
        '
        'ucrChkOmitMissing
        '
        Me.ucrChkOmitMissing.Checked = False
        Me.ucrChkOmitMissing.Location = New System.Drawing.Point(8, 257)
        Me.ucrChkOmitMissing.Name = "ucrChkOmitMissing"
        Me.ucrChkOmitMissing.Size = New System.Drawing.Size(156, 20)
        Me.ucrChkOmitMissing.TabIndex = 14
        '
        'dlgMySecondDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 450)
        Me.Controls.Add(Me.ucrChkOmitMissing)
        Me.Controls.Add(Me.lblDayOfYear)
        Me.Controls.Add(Me.ucrReceiverDayOfYear)
        Me.Controls.Add(Me.lblComparativeStatistics)
        Me.Controls.Add(Me.ucrComparativeStatistics)
        Me.Controls.Add(Me.lblFactors)
        Me.Controls.Add(Me.ucrSelectorFactors)
        Me.Controls.Add(Me.lblSatelliteData)
        Me.Controls.Add(Me.lblStationData)
        Me.Controls.Add(Me.ucrReceiverSatelliteData)
        Me.Controls.Add(Me.ucrReceiverStationData)
        Me.Controls.Add(Me.ucrSelectorByDataFrame)
        Me.Controls.Add(Me.UcrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgMySecondDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comparative Analysis"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UcrBase As ucrButtons
    Friend WithEvents ucrSelectorByDataFrame As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrReceiverStationData As ucrReceiverSingle
    Friend WithEvents lblDayOfYear As Label
    Friend WithEvents ucrReceiverDayOfYear As ucrReceiverSingle
    Friend WithEvents lblComparativeStatistics As Label
    Friend WithEvents ucrComparativeStatistics As ComboBox
    Friend WithEvents lblFactors As Label
    Friend WithEvents ucrSelectorFactors As ucrSelector
    Friend WithEvents lblSatelliteData As Label
    Friend WithEvents lblStationData As Label
    Friend WithEvents ucrReceiverSatelliteData As ucrReceiverSingle
    Friend WithEvents ucrChkOmitMissing As ucrCheck
End Class
