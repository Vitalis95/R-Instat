﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgMosaicPlot
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
        Me.components = New System.ComponentModel.Container()
        Me.lblFactors = New System.Windows.Forms.Label()
        Me.lblFillColour = New System.Windows.Forms.Label()
        Me.lblConditionFactors = New System.Windows.Forms.Label()
        Me.lblWeights = New System.Windows.Forms.Label()
        Me.lblPartitioningType = New System.Windows.Forms.Label()
        Me.ucrNudXAxisLabelsAngle = New instat.ucrNud()
        Me.ucrInputPartitioning = New instat.ucrInputComboBox()
        Me.ucrChkOmitMissing = New instat.ucrCheck()
        Me.ucrReceiverWeights = New instat.ucrReceiverSingle()
        Me.ucrReceiverConditions = New instat.ucrReceiverMultiple()
        Me.ucrReceiverFill = New instat.ucrReceiverSingle()
        Me.ucrReceiverX = New instat.ucrReceiverMultiple()
        Me.ucrSaveMosaicPlot = New instat.ucrSave()
        Me.ucrChkXAxisLabelAngle = New instat.ucrCheck()
        Me.ucrSelectorMosaicPlot = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrBase = New instat.ucrButtons()
        Me.contextMenuStripOptions = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.toolStripMenuItemPlotOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripMenuItemMosaicOptions = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemMosaicJitter = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItemMosaicText = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdOptions = New instat.ucrSplitButton()
        Me.ucrInputStation = New instat.ucrInputComboBox()
        Me.ucr1stFactorReceiver = New instat.ucrReceiverSingle()
        Me.lblFacetBy = New System.Windows.Forms.Label()
        Me.ucrInputLegendPosition = New instat.ucrInputComboBox()
        Me.ucrChkLegend = New instat.ucrCheck()
        Me.ucrChkJitter = New instat.ucrCheck()
        Me.lblSizeJitter = New System.Windows.Forms.Label()
        Me.ucrNudJitter = New instat.ucrNud()
        Me.lblColourJitter = New System.Windows.Forms.Label()
        Me.ucrColors = New instat.ucrColors()
        Me.ucrColorsLabel = New instat.ucrColors()
        Me.lblColourLabel = New System.Windows.Forms.Label()
        Me.ucrNudSizeLabel = New instat.ucrNud()
        Me.lblSizeLabel = New System.Windows.Forms.Label()
        Me.ucrChkLabel = New instat.ucrCheck()
        Me.contextMenuStripOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblFactors
        '
        Me.lblFactors.AutoSize = True
        Me.lblFactors.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFactors.Location = New System.Drawing.Point(286, 33)
        Me.lblFactors.Name = "lblFactors"
        Me.lblFactors.Size = New System.Drawing.Size(45, 13)
        Me.lblFactors.TabIndex = 1
        Me.lblFactors.Text = "Factors:"
        '
        'lblFillColour
        '
        Me.lblFillColour.AutoSize = True
        Me.lblFillColour.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFillColour.Location = New System.Drawing.Point(286, 161)
        Me.lblFillColour.Name = "lblFillColour"
        Me.lblFillColour.Size = New System.Drawing.Size(103, 13)
        Me.lblFillColour.TabIndex = 3
        Me.lblFillColour.Text = "Fill Colour (Optional):"
        '
        'lblConditionFactors
        '
        Me.lblConditionFactors.AutoSize = True
        Me.lblConditionFactors.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblConditionFactors.Location = New System.Drawing.Point(282, 210)
        Me.lblConditionFactors.Name = "lblConditionFactors"
        Me.lblConditionFactors.Size = New System.Drawing.Size(140, 13)
        Me.lblConditionFactors.TabIndex = 5
        Me.lblConditionFactors.Text = "Condition Factors (Optional):"
        '
        'lblWeights
        '
        Me.lblWeights.AutoSize = True
        Me.lblWeights.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblWeights.Location = New System.Drawing.Point(282, 337)
        Me.lblWeights.Name = "lblWeights"
        Me.lblWeights.Size = New System.Drawing.Size(97, 13)
        Me.lblWeights.TabIndex = 7
        Me.lblWeights.Text = "Weights (Optional):"
        '
        'lblPartitioningType
        '
        Me.lblPartitioningType.AutoSize = True
        Me.lblPartitioningType.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPartitioningType.Location = New System.Drawing.Point(9, 239)
        Me.lblPartitioningType.Name = "lblPartitioningType"
        Me.lblPartitioningType.Size = New System.Drawing.Size(62, 13)
        Me.lblPartitioningType.TabIndex = 11
        Me.lblPartitioningType.Text = "Partitioning:"
        '
        'ucrNudXAxisLabelsAngle
        '
        Me.ucrNudXAxisLabelsAngle.AutoSize = True
        Me.ucrNudXAxisLabelsAngle.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXAxisLabelsAngle.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudXAxisLabelsAngle.Location = New System.Drawing.Point(140, 326)
        Me.ucrNudXAxisLabelsAngle.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudXAxisLabelsAngle.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudXAxisLabelsAngle.Name = "ucrNudXAxisLabelsAngle"
        Me.ucrNudXAxisLabelsAngle.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudXAxisLabelsAngle.TabIndex = 15
        Me.ucrNudXAxisLabelsAngle.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputPartitioning
        '
        Me.ucrInputPartitioning.AddQuotesIfUnrecognised = True
        Me.ucrInputPartitioning.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputPartitioning.GetSetSelectedIndex = -1
        Me.ucrInputPartitioning.IsReadOnly = False
        Me.ucrInputPartitioning.Location = New System.Drawing.Point(96, 239)
        Me.ucrInputPartitioning.Name = "ucrInputPartitioning"
        Me.ucrInputPartitioning.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputPartitioning.TabIndex = 12
        '
        'ucrChkOmitMissing
        '
        Me.ucrChkOmitMissing.AutoSize = True
        Me.ucrChkOmitMissing.Checked = False
        Me.ucrChkOmitMissing.Location = New System.Drawing.Point(9, 278)
        Me.ucrChkOmitMissing.Name = "ucrChkOmitMissing"
        Me.ucrChkOmitMissing.Size = New System.Drawing.Size(224, 23)
        Me.ucrChkOmitMissing.TabIndex = 13
        '
        'ucrReceiverWeights
        '
        Me.ucrReceiverWeights.AutoSize = True
        Me.ucrReceiverWeights.frmParent = Me
        Me.ucrReceiverWeights.Location = New System.Drawing.Point(284, 352)
        Me.ucrReceiverWeights.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverWeights.Name = "ucrReceiverWeights"
        Me.ucrReceiverWeights.Selector = Nothing
        Me.ucrReceiverWeights.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverWeights.strNcFilePath = ""
        Me.ucrReceiverWeights.TabIndex = 8
        Me.ucrReceiverWeights.ucrSelector = Nothing
        '
        'ucrReceiverConditions
        '
        Me.ucrReceiverConditions.AutoSize = True
        Me.ucrReceiverConditions.frmParent = Me
        Me.ucrReceiverConditions.Location = New System.Drawing.Point(284, 225)
        Me.ucrReceiverConditions.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverConditions.Name = "ucrReceiverConditions"
        Me.ucrReceiverConditions.Selector = Nothing
        Me.ucrReceiverConditions.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverConditions.strNcFilePath = ""
        Me.ucrReceiverConditions.TabIndex = 6
        Me.ucrReceiverConditions.ucrSelector = Nothing
        '
        'ucrReceiverFill
        '
        Me.ucrReceiverFill.AutoSize = True
        Me.ucrReceiverFill.frmParent = Me
        Me.ucrReceiverFill.Location = New System.Drawing.Point(284, 176)
        Me.ucrReceiverFill.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverFill.Name = "ucrReceiverFill"
        Me.ucrReceiverFill.Selector = Nothing
        Me.ucrReceiverFill.Size = New System.Drawing.Size(120, 20)
        Me.ucrReceiverFill.strNcFilePath = ""
        Me.ucrReceiverFill.TabIndex = 4
        Me.ucrReceiverFill.ucrSelector = Nothing
        '
        'ucrReceiverX
        '
        Me.ucrReceiverX.AutoSize = True
        Me.ucrReceiverX.frmParent = Me
        Me.ucrReceiverX.Location = New System.Drawing.Point(284, 48)
        Me.ucrReceiverX.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverX.Name = "ucrReceiverX"
        Me.ucrReceiverX.Selector = Nothing
        Me.ucrReceiverX.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverX.strNcFilePath = ""
        Me.ucrReceiverX.TabIndex = 2
        Me.ucrReceiverX.ucrSelector = Nothing
        '
        'ucrSaveMosaicPlot
        '
        Me.ucrSaveMosaicPlot.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveMosaicPlot.Location = New System.Drawing.Point(9, 513)
        Me.ucrSaveMosaicPlot.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveMosaicPlot.Name = "ucrSaveMosaicPlot"
        Me.ucrSaveMosaicPlot.Size = New System.Drawing.Size(317, 24)
        Me.ucrSaveMosaicPlot.TabIndex = 16
        '
        'ucrChkXAxisLabelAngle
        '
        Me.ucrChkXAxisLabelAngle.AutoSize = True
        Me.ucrChkXAxisLabelAngle.Checked = False
        Me.ucrChkXAxisLabelAngle.Location = New System.Drawing.Point(9, 326)
        Me.ucrChkXAxisLabelAngle.Name = "ucrChkXAxisLabelAngle"
        Me.ucrChkXAxisLabelAngle.Size = New System.Drawing.Size(168, 23)
        Me.ucrChkXAxisLabelAngle.TabIndex = 14
        '
        'ucrSelectorMosaicPlot
        '
        Me.ucrSelectorMosaicPlot.AutoSize = True
        Me.ucrSelectorMosaicPlot.bDropUnusedFilterLevels = False
        Me.ucrSelectorMosaicPlot.bShowHiddenColumns = False
        Me.ucrSelectorMosaicPlot.bUseCurrentFilter = True
        Me.ucrSelectorMosaicPlot.Location = New System.Drawing.Point(9, 10)
        Me.ucrSelectorMosaicPlot.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorMosaicPlot.Name = "ucrSelectorMosaicPlot"
        Me.ucrSelectorMosaicPlot.Size = New System.Drawing.Size(213, 183)
        Me.ucrSelectorMosaicPlot.TabIndex = 0
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(14, 544)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 17
        '
        'contextMenuStripOptions
        '
        Me.contextMenuStripOptions.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripMenuItemPlotOptions, Me.toolStripMenuItemMosaicOptions, Me.ToolStripMenuItemMosaicJitter, Me.ToolStripMenuItemMosaicText})
        Me.contextMenuStripOptions.Name = "contextMenuStripOk"
        Me.contextMenuStripOptions.Size = New System.Drawing.Size(186, 92)
        '
        'toolStripMenuItemPlotOptions
        '
        Me.toolStripMenuItemPlotOptions.Name = "toolStripMenuItemPlotOptions"
        Me.toolStripMenuItemPlotOptions.Size = New System.Drawing.Size(185, 22)
        Me.toolStripMenuItemPlotOptions.Text = "Plot Options"
        '
        'toolStripMenuItemMosaicOptions
        '
        Me.toolStripMenuItemMosaicOptions.Name = "toolStripMenuItemMosaicOptions"
        Me.toolStripMenuItemMosaicOptions.Size = New System.Drawing.Size(185, 22)
        Me.toolStripMenuItemMosaicOptions.Text = "Mosaic Options"
        '
        'ToolStripMenuItemMosaicJitter
        '
        Me.ToolStripMenuItemMosaicJitter.Name = "ToolStripMenuItemMosaicJitter"
        Me.ToolStripMenuItemMosaicJitter.Size = New System.Drawing.Size(185, 22)
        Me.ToolStripMenuItemMosaicJitter.Text = "Mosaic Jitter Options"
        '
        'ToolStripMenuItemMosaicText
        '
        Me.ToolStripMenuItemMosaicText.Name = "ToolStripMenuItemMosaicText"
        Me.ToolStripMenuItemMosaicText.Size = New System.Drawing.Size(185, 22)
        Me.ToolStripMenuItemMosaicText.Text = "Mosaic Text Options"
        '
        'cmdOptions
        '
        Me.cmdOptions.AllowDrop = True
        Me.cmdOptions.AutoSize = True
        Me.cmdOptions.ContextMenuStrip = Me.contextMenuStripOptions
        Me.cmdOptions.Location = New System.Drawing.Point(9, 199)
        Me.cmdOptions.Name = "cmdOptions"
        Me.cmdOptions.Size = New System.Drawing.Size(148, 23)
        Me.cmdOptions.SplitMenuStrip = Me.contextMenuStripOptions
        Me.cmdOptions.TabIndex = 19
        Me.cmdOptions.Tag = "Plot Options"
        Me.cmdOptions.Text = "Plot Options"
        Me.cmdOptions.UseVisualStyleBackColor = True
        '
        'ucrInputStation
        '
        Me.ucrInputStation.AddQuotesIfUnrecognised = True
        Me.ucrInputStation.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputStation.GetSetSelectedIndex = -1
        Me.ucrInputStation.IsReadOnly = False
        Me.ucrInputStation.Location = New System.Drawing.Point(321, 381)
        Me.ucrInputStation.Name = "ucrInputStation"
        Me.ucrInputStation.Size = New System.Drawing.Size(101, 21)
        Me.ucrInputStation.TabIndex = 96
        '
        'ucr1stFactorReceiver
        '
        Me.ucr1stFactorReceiver.AutoSize = True
        Me.ucr1stFactorReceiver.frmParent = Me
        Me.ucr1stFactorReceiver.Location = New System.Drawing.Point(209, 382)
        Me.ucr1stFactorReceiver.Margin = New System.Windows.Forms.Padding(0)
        Me.ucr1stFactorReceiver.Name = "ucr1stFactorReceiver"
        Me.ucr1stFactorReceiver.Selector = Nothing
        Me.ucr1stFactorReceiver.Size = New System.Drawing.Size(110, 26)
        Me.ucr1stFactorReceiver.strNcFilePath = ""
        Me.ucr1stFactorReceiver.TabIndex = 95
        Me.ucr1stFactorReceiver.ucrSelector = Nothing
        '
        'lblFacetBy
        '
        Me.lblFacetBy.AutoSize = True
        Me.lblFacetBy.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFacetBy.Location = New System.Drawing.Point(212, 367)
        Me.lblFacetBy.Name = "lblFacetBy"
        Me.lblFacetBy.Size = New System.Drawing.Size(52, 13)
        Me.lblFacetBy.TabIndex = 94
        Me.lblFacetBy.Tag = ""
        Me.lblFacetBy.Text = "Facet By:"
        '
        'ucrInputLegendPosition
        '
        Me.ucrInputLegendPosition.AddQuotesIfUnrecognised = True
        Me.ucrInputLegendPosition.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputLegendPosition.GetSetSelectedIndex = -1
        Me.ucrInputLegendPosition.IsReadOnly = False
        Me.ucrInputLegendPosition.Location = New System.Drawing.Point(91, 381)
        Me.ucrInputLegendPosition.Name = "ucrInputLegendPosition"
        Me.ucrInputLegendPosition.Size = New System.Drawing.Size(112, 21)
        Me.ucrInputLegendPosition.TabIndex = 98
        '
        'ucrChkLegend
        '
        Me.ucrChkLegend.AutoSize = True
        Me.ucrChkLegend.Checked = False
        Me.ucrChkLegend.Location = New System.Drawing.Point(9, 382)
        Me.ucrChkLegend.Name = "ucrChkLegend"
        Me.ucrChkLegend.Size = New System.Drawing.Size(98, 24)
        Me.ucrChkLegend.TabIndex = 97
        '
        'ucrChkJitter
        '
        Me.ucrChkJitter.AutoSize = True
        Me.ucrChkJitter.Checked = False
        Me.ucrChkJitter.Location = New System.Drawing.Point(9, 429)
        Me.ucrChkJitter.Name = "ucrChkJitter"
        Me.ucrChkJitter.Size = New System.Drawing.Size(98, 24)
        Me.ucrChkJitter.TabIndex = 99
        '
        'lblSizeJitter
        '
        Me.lblSizeJitter.AutoSize = True
        Me.lblSizeJitter.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSizeJitter.Location = New System.Drawing.Point(104, 431)
        Me.lblSizeJitter.Name = "lblSizeJitter"
        Me.lblSizeJitter.Size = New System.Drawing.Size(30, 13)
        Me.lblSizeJitter.TabIndex = 100
        Me.lblSizeJitter.Tag = ""
        Me.lblSizeJitter.Text = "Size:"
        '
        'ucrNudJitter
        '
        Me.ucrNudJitter.AutoSize = True
        Me.ucrNudJitter.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudJitter.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudJitter.Location = New System.Drawing.Point(140, 430)
        Me.ucrNudJitter.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudJitter.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudJitter.Name = "ucrNudJitter"
        Me.ucrNudJitter.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudJitter.TabIndex = 101
        Me.ucrNudJitter.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblColourJitter
        '
        Me.lblColourJitter.AutoSize = True
        Me.lblColourJitter.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColourJitter.Location = New System.Drawing.Point(224, 431)
        Me.lblColourJitter.Name = "lblColourJitter"
        Me.lblColourJitter.Size = New System.Drawing.Size(40, 13)
        Me.lblColourJitter.TabIndex = 102
        Me.lblColourJitter.Tag = ""
        Me.lblColourJitter.Text = "Colour:"
        '
        'ucrColors
        '
        Me.ucrColors.AddQuotesIfUnrecognised = True
        Me.ucrColors.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrColors.GetSetSelectedIndex = -1
        Me.ucrColors.IsReadOnly = False
        Me.ucrColors.Location = New System.Drawing.Point(272, 428)
        Me.ucrColors.Name = "ucrColors"
        Me.ucrColors.Size = New System.Drawing.Size(70, 22)
        Me.ucrColors.TabIndex = 202
        '
        'ucrColorsLabel
        '
        Me.ucrColorsLabel.AddQuotesIfUnrecognised = True
        Me.ucrColorsLabel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrColorsLabel.GetSetSelectedIndex = -1
        Me.ucrColorsLabel.IsReadOnly = False
        Me.ucrColorsLabel.Location = New System.Drawing.Point(272, 473)
        Me.ucrColorsLabel.Name = "ucrColorsLabel"
        Me.ucrColorsLabel.Size = New System.Drawing.Size(70, 22)
        Me.ucrColorsLabel.TabIndex = 207
        '
        'lblColourLabel
        '
        Me.lblColourLabel.AutoSize = True
        Me.lblColourLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColourLabel.Location = New System.Drawing.Point(224, 475)
        Me.lblColourLabel.Name = "lblColourLabel"
        Me.lblColourLabel.Size = New System.Drawing.Size(40, 13)
        Me.lblColourLabel.TabIndex = 206
        Me.lblColourLabel.Tag = ""
        Me.lblColourLabel.Text = "Colour:"
        '
        'ucrNudSizeLabel
        '
        Me.ucrNudSizeLabel.AutoSize = True
        Me.ucrNudSizeLabel.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSizeLabel.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudSizeLabel.Location = New System.Drawing.Point(140, 475)
        Me.ucrNudSizeLabel.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudSizeLabel.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudSizeLabel.Name = "ucrNudSizeLabel"
        Me.ucrNudSizeLabel.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudSizeLabel.TabIndex = 205
        Me.ucrNudSizeLabel.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblSizeLabel
        '
        Me.lblSizeLabel.AutoSize = True
        Me.lblSizeLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSizeLabel.Location = New System.Drawing.Point(104, 475)
        Me.lblSizeLabel.Name = "lblSizeLabel"
        Me.lblSizeLabel.Size = New System.Drawing.Size(30, 13)
        Me.lblSizeLabel.TabIndex = 204
        Me.lblSizeLabel.Tag = ""
        Me.lblSizeLabel.Text = "Size:"
        '
        'ucrChkLabel
        '
        Me.ucrChkLabel.AutoSize = True
        Me.ucrChkLabel.Checked = False
        Me.ucrChkLabel.Location = New System.Drawing.Point(9, 471)
        Me.ucrChkLabel.Name = "ucrChkLabel"
        Me.ucrChkLabel.Size = New System.Drawing.Size(98, 24)
        Me.ucrChkLabel.TabIndex = 203
        '
        'dlgMosaicPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(441, 605)
        Me.Controls.Add(Me.ucrColorsLabel)
        Me.Controls.Add(Me.lblColourLabel)
        Me.Controls.Add(Me.ucrNudSizeLabel)
        Me.Controls.Add(Me.lblSizeLabel)
        Me.Controls.Add(Me.ucrChkLabel)
        Me.Controls.Add(Me.ucrColors)
        Me.Controls.Add(Me.lblColourJitter)
        Me.Controls.Add(Me.ucrNudJitter)
        Me.Controls.Add(Me.lblSizeJitter)
        Me.Controls.Add(Me.ucrChkJitter)
        Me.Controls.Add(Me.ucrInputStation)
        Me.Controls.Add(Me.ucr1stFactorReceiver)
        Me.Controls.Add(Me.lblFacetBy)
        Me.Controls.Add(Me.ucrInputLegendPosition)
        Me.Controls.Add(Me.ucrChkLegend)
        Me.Controls.Add(Me.cmdOptions)
        Me.Controls.Add(Me.ucrNudXAxisLabelsAngle)
        Me.Controls.Add(Me.ucrInputPartitioning)
        Me.Controls.Add(Me.lblPartitioningType)
        Me.Controls.Add(Me.ucrChkOmitMissing)
        Me.Controls.Add(Me.lblWeights)
        Me.Controls.Add(Me.ucrReceiverWeights)
        Me.Controls.Add(Me.lblConditionFactors)
        Me.Controls.Add(Me.ucrReceiverConditions)
        Me.Controls.Add(Me.lblFillColour)
        Me.Controls.Add(Me.ucrReceiverFill)
        Me.Controls.Add(Me.lblFactors)
        Me.Controls.Add(Me.ucrReceiverX)
        Me.Controls.Add(Me.ucrSaveMosaicPlot)
        Me.Controls.Add(Me.ucrChkXAxisLabelAngle)
        Me.Controls.Add(Me.ucrSelectorMosaicPlot)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgMosaicPlot"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mosaic Plot"
        Me.contextMenuStripOptions.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSaveMosaicPlot As ucrSave
    Friend WithEvents ucrChkXAxisLabelAngle As ucrCheck
    Friend WithEvents ucrSelectorMosaicPlot As ucrSelectorByDataFrameAddRemove
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrReceiverX As ucrReceiverMultiple
    Friend WithEvents lblFactors As Label
    Friend WithEvents ucrReceiverFill As ucrReceiverSingle
    Friend WithEvents lblFillColour As Label
    Friend WithEvents lblConditionFactors As Label
    Friend WithEvents ucrReceiverConditions As ucrReceiverMultiple
    Friend WithEvents lblWeights As Label
    Friend WithEvents ucrReceiverWeights As ucrReceiverSingle
    Friend WithEvents ucrChkOmitMissing As ucrCheck
    Friend WithEvents lblPartitioningType As Label
    Friend WithEvents ucrInputPartitioning As ucrInputComboBox
    Friend WithEvents ucrNudXAxisLabelsAngle As ucrNud
    Friend WithEvents cmdOptions As ucrSplitButton
    Friend WithEvents contextMenuStripOptions As ContextMenuStrip
    Friend WithEvents toolStripMenuItemPlotOptions As ToolStripMenuItem
    Friend WithEvents toolStripMenuItemMosaicOptions As ToolStripMenuItem
    Friend WithEvents ucrInputStation As ucrInputComboBox
    Friend WithEvents ucr1stFactorReceiver As ucrReceiverSingle
    Friend WithEvents lblFacetBy As Label
    Friend WithEvents ucrInputLegendPosition As ucrInputComboBox
    Friend WithEvents ucrChkLegend As ucrCheck
    Friend WithEvents ToolStripMenuItemMosaicJitter As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItemMosaicText As ToolStripMenuItem
    Friend WithEvents lblColourJitter As Label
    Friend WithEvents ucrNudJitter As ucrNud
    Friend WithEvents lblSizeJitter As Label
    Friend WithEvents ucrChkJitter As ucrCheck
    Friend WithEvents ucrColors As ucrColors
    Friend WithEvents ucrColorsLabel As ucrColors
    Friend WithEvents lblColourLabel As Label
    Friend WithEvents ucrNudSizeLabel As ucrNud
    Friend WithEvents lblSizeLabel As Label
    Friend WithEvents ucrChkLabel As ucrCheck
End Class
