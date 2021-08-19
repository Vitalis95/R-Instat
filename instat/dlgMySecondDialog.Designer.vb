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
        Me.UcrBase = New instat.ucrButtons()
        Me.UcrSelectorByDataFrameAddRemove1 = New instat.ucrSelectorByDataFrameAddRemove()
        Me.UcrReceiverMySecondDialog1 = New instat.ucrReceiverSingle()
        Me.UcrReceiverMySecondDialog2 = New instat.ucrReceiverSingle()
        Me.lblStationData = New System.Windows.Forms.Label()
        Me.lblSatelliteData = New System.Windows.Forms.Label()
        Me.UcrSelectorByDataFrameAddRemove2 = New instat.ucrSelectorByDataFrameAddRemove()
        Me.UcrSelector1 = New instat.ucrSelector()
        Me.lblFactors = New System.Windows.Forms.Label()
        Me.cblComparativeStatistics = New System.Windows.Forms.ComboBox()
        Me.lblComparativeStatistics = New System.Windows.Forms.Label()
        Me.rdoOmitMissing = New instat.ucrRadio()
        Me.UcrReceiverDayOfYear = New instat.ucrReceiverSingle()
        Me.lblDayOfYear = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'UcrBase
        '
        Me.UcrBase.Location = New System.Drawing.Point(12, 348)
        Me.UcrBase.Name = "UcrBase"
        Me.UcrBase.Size = New System.Drawing.Size(410, 52)
        Me.UcrBase.TabIndex = 0
        '
        'UcrSelectorByDataFrameAddRemove1
        '
        Me.UcrSelectorByDataFrameAddRemove1.bDropUnusedFilterLevels = False
        Me.UcrSelectorByDataFrameAddRemove1.bShowHiddenColumns = False
        Me.UcrSelectorByDataFrameAddRemove1.bUseCurrentFilter = True
        Me.UcrSelectorByDataFrameAddRemove1.Location = New System.Drawing.Point(0, 0)
        Me.UcrSelectorByDataFrameAddRemove1.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrSelectorByDataFrameAddRemove1.Name = "UcrSelectorByDataFrameAddRemove1"
        Me.UcrSelectorByDataFrameAddRemove1.Size = New System.Drawing.Size(210, 180)
        Me.UcrSelectorByDataFrameAddRemove1.TabIndex = 1
        '
        'UcrReceiverMySecondDialog1
        '
        Me.UcrReceiverMySecondDialog1.frmParent = Me
        Me.UcrReceiverMySecondDialog1.Location = New System.Drawing.Point(302, 34)
        Me.UcrReceiverMySecondDialog1.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrReceiverMySecondDialog1.Name = "UcrReceiverMySecondDialog1"
        Me.UcrReceiverMySecondDialog1.Selector = Nothing
        Me.UcrReceiverMySecondDialog1.Size = New System.Drawing.Size(120, 20)
        Me.UcrReceiverMySecondDialog1.strNcFilePath = ""
        Me.UcrReceiverMySecondDialog1.TabIndex = 2
        Me.UcrReceiverMySecondDialog1.ucrSelector = Nothing
        '
        'UcrReceiverMySecondDialog2
        '
        Me.UcrReceiverMySecondDialog2.frmParent = Me
        Me.UcrReceiverMySecondDialog2.Location = New System.Drawing.Point(302, 77)
        Me.UcrReceiverMySecondDialog2.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrReceiverMySecondDialog2.Name = "UcrReceiverMySecondDialog2"
        Me.UcrReceiverMySecondDialog2.Selector = Nothing
        Me.UcrReceiverMySecondDialog2.Size = New System.Drawing.Size(120, 20)
        Me.UcrReceiverMySecondDialog2.strNcFilePath = ""
        Me.UcrReceiverMySecondDialog2.TabIndex = 3
        Me.UcrReceiverMySecondDialog2.ucrSelector = Nothing
        '
        'lblStationData
        '
        Me.lblStationData.AutoSize = True
        Me.lblStationData.Location = New System.Drawing.Point(299, 21)
        Me.lblStationData.Name = "lblStationData"
        Me.lblStationData.Size = New System.Drawing.Size(66, 13)
        Me.lblStationData.TabIndex = 4
        Me.lblStationData.Text = "Station Data"
        '
        'lblSatelliteData
        '
        Me.lblSatelliteData.AutoSize = True
        Me.lblSatelliteData.Location = New System.Drawing.Point(299, 64)
        Me.lblSatelliteData.Name = "lblSatelliteData"
        Me.lblSatelliteData.Size = New System.Drawing.Size(68, 13)
        Me.lblSatelliteData.TabIndex = 5
        Me.lblSatelliteData.Text = "Satelite Data"
        '
        'UcrSelectorByDataFrameAddRemove2
        '
        Me.UcrSelectorByDataFrameAddRemove2.bDropUnusedFilterLevels = False
        Me.UcrSelectorByDataFrameAddRemove2.bShowHiddenColumns = False
        Me.UcrSelectorByDataFrameAddRemove2.bUseCurrentFilter = True
        Me.UcrSelectorByDataFrameAddRemove2.Location = New System.Drawing.Point(0, 0)
        Me.UcrSelectorByDataFrameAddRemove2.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrSelectorByDataFrameAddRemove2.Name = "UcrSelectorByDataFrameAddRemove2"
        Me.UcrSelectorByDataFrameAddRemove2.Size = New System.Drawing.Size(210, 180)
        Me.UcrSelectorByDataFrameAddRemove2.TabIndex = 6
        '
        'UcrSelector1
        '
        Me.UcrSelector1.bShowHiddenColumns = False
        Me.UcrSelector1.Location = New System.Drawing.Point(274, 156)
        Me.UcrSelector1.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrSelector1.Name = "UcrSelector1"
        Me.UcrSelector1.Size = New System.Drawing.Size(148, 130)
        Me.UcrSelector1.TabIndex = 7
        '
        'lblFactors
        '
        Me.lblFactors.AutoSize = True
        Me.lblFactors.Location = New System.Drawing.Point(271, 143)
        Me.lblFactors.Name = "lblFactors"
        Me.lblFactors.Size = New System.Drawing.Size(42, 13)
        Me.lblFactors.TabIndex = 8
        Me.lblFactors.Text = "Factors"
        '
        'cblComparativeStatistics
        '
        Me.cblComparativeStatistics.FormattingEnabled = True
        Me.cblComparativeStatistics.Location = New System.Drawing.Point(274, 302)
        Me.cblComparativeStatistics.Name = "cblComparativeStatistics"
        Me.cblComparativeStatistics.Size = New System.Drawing.Size(121, 21)
        Me.cblComparativeStatistics.TabIndex = 9
        '
        'lblComparativeStatistics
        '
        Me.lblComparativeStatistics.AutoSize = True
        Me.lblComparativeStatistics.Location = New System.Drawing.Point(271, 286)
        Me.lblComparativeStatistics.Name = "lblComparativeStatistics"
        Me.lblComparativeStatistics.Size = New System.Drawing.Size(111, 13)
        Me.lblComparativeStatistics.TabIndex = 10
        Me.lblComparativeStatistics.Text = "Comparative Statistics"
        '
        'rdoOmitMissing
        '
        Me.rdoOmitMissing.Location = New System.Drawing.Point(0, 268)
        Me.rdoOmitMissing.Name = "rdoOmitMissing"
        Me.rdoOmitMissing.Size = New System.Drawing.Size(100, 20)
        Me.rdoOmitMissing.TabIndex = 11
        '
        'UcrReceiverDayOfYear
        '
        Me.UcrReceiverDayOfYear.frmParent = Me
        Me.UcrReceiverDayOfYear.Location = New System.Drawing.Point(302, 110)
        Me.UcrReceiverDayOfYear.Margin = New System.Windows.Forms.Padding(0)
        Me.UcrReceiverDayOfYear.Name = "UcrReceiverDayOfYear"
        Me.UcrReceiverDayOfYear.Selector = Nothing
        Me.UcrReceiverDayOfYear.Size = New System.Drawing.Size(120, 20)
        Me.UcrReceiverDayOfYear.strNcFilePath = ""
        Me.UcrReceiverDayOfYear.TabIndex = 12
        Me.UcrReceiverDayOfYear.ucrSelector = Nothing
        '
        'lblDayOfYear
        '
        Me.lblDayOfYear.AutoSize = True
        Me.lblDayOfYear.Location = New System.Drawing.Point(299, 97)
        Me.lblDayOfYear.Name = "lblDayOfYear"
        Me.lblDayOfYear.Size = New System.Drawing.Size(65, 13)
        Me.lblDayOfYear.TabIndex = 13
        Me.lblDayOfYear.Text = "Day Of Year"
        '
        'dlgMySecondDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 450)
        Me.Controls.Add(Me.lblDayOfYear)
        Me.Controls.Add(Me.UcrReceiverDayOfYear)
        Me.Controls.Add(Me.rdoOmitMissing)
        Me.Controls.Add(Me.lblComparativeStatistics)
        Me.Controls.Add(Me.cblComparativeStatistics)
        Me.Controls.Add(Me.lblFactors)
        Me.Controls.Add(Me.UcrSelector1)
        Me.Controls.Add(Me.UcrSelectorByDataFrameAddRemove2)
        Me.Controls.Add(Me.lblSatelliteData)
        Me.Controls.Add(Me.lblStationData)
        Me.Controls.Add(Me.UcrReceiverMySecondDialog2)
        Me.Controls.Add(Me.UcrReceiverMySecondDialog1)
        Me.Controls.Add(Me.UcrSelectorByDataFrameAddRemove1)
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
    Friend WithEvents UcrSelectorByDataFrameAddRemove1 As ucrSelectorByDataFrameAddRemove
    Friend WithEvents UcrReceiverMySecondDialog1 As ucrReceiverSingle
    Friend WithEvents lblDayOfYear As Label
    Friend WithEvents UcrReceiverDayOfYear As ucrReceiverSingle
    Friend WithEvents rdoOmitMissing As ucrRadio
    Friend WithEvents lblComparativeStatistics As Label
    Friend WithEvents cblComparativeStatistics As ComboBox
    Friend WithEvents lblFactors As Label
    Friend WithEvents UcrSelector1 As ucrSelector
    Friend WithEvents UcrSelectorByDataFrameAddRemove2 As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblSatelliteData As Label
    Friend WithEvents lblStationData As Label
    Friend WithEvents UcrReceiverMySecondDialog2 As ucrReceiverSingle
End Class
