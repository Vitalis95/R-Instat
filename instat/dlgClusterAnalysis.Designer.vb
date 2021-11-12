<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgClusterAnalysis
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
        Me.rdoHierarchicalData = New System.Windows.Forms.RadioButton()
        Me.rdoPartitioningData = New System.Windows.Forms.RadioButton()
        Me.rdoNumericVariables = New System.Windows.Forms.RadioButton()
        Me.rdoDataFrame = New System.Windows.Forms.RadioButton()
        Me.ucrBase = New instat.ucrButtons()
        Me.ucrReceiverClusterData = New instat.ucrReceiverMultiple()
        Me.ucrSelectorClusterData = New instat.ucrSelectorByDataFrameAddRemove()
        Me.ucrPnlClusterData = New instat.UcrPanel()
        Me.ucrPnlSelectData = New instat.UcrPanel()
        Me.ucrChkMetric = New instat.ucrCheck()
        Me.ucrChkCluster = New instat.ucrCheck()
        Me.ucrChkMethod = New instat.ucrCheck()
        Me.ucrChkStand = New instat.ucrCheck()
        Me.ucrInputMetric = New instat.ucrInputComboBox()
        Me.ucrInputMethod = New instat.ucrInputComboBox()
        Me.ucrNudPamCluster = New instat.ucrNud()
        Me.SuspendLayout()
        '
        'rdoHierarchicalData
        '
        Me.rdoHierarchicalData.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoHierarchicalData.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoHierarchicalData.FlatAppearance.BorderSize = 2
        Me.rdoHierarchicalData.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoHierarchicalData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoHierarchicalData.Location = New System.Drawing.Point(277, 8)
        Me.rdoHierarchicalData.Name = "rdoHierarchicalData"
        Me.rdoHierarchicalData.Size = New System.Drawing.Size(100, 28)
        Me.rdoHierarchicalData.TabIndex = 2
        Me.rdoHierarchicalData.TabStop = True
        Me.rdoHierarchicalData.Text = "Hierarchical"
        Me.rdoHierarchicalData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoHierarchicalData.UseVisualStyleBackColor = True
        '
        'rdoPartitioningData
        '
        Me.rdoPartitioningData.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoPartitioningData.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPartitioningData.FlatAppearance.BorderSize = 2
        Me.rdoPartitioningData.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoPartitioningData.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoPartitioningData.Location = New System.Drawing.Point(179, 8)
        Me.rdoPartitioningData.Name = "rdoPartitioningData"
        Me.rdoPartitioningData.Size = New System.Drawing.Size(100, 28)
        Me.rdoPartitioningData.TabIndex = 3
        Me.rdoPartitioningData.TabStop = True
        Me.rdoPartitioningData.Text = "Partitioning"
        Me.rdoPartitioningData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoPartitioningData.UseVisualStyleBackColor = True
        '
        'rdoNumericVariables
        '
        Me.rdoNumericVariables.AutoSize = True
        Me.rdoNumericVariables.Location = New System.Drawing.Point(316, 54)
        Me.rdoNumericVariables.Name = "rdoNumericVariables"
        Me.rdoNumericVariables.Size = New System.Drawing.Size(110, 17)
        Me.rdoNumericVariables.TabIndex = 5
        Me.rdoNumericVariables.TabStop = True
        Me.rdoNumericVariables.Text = "Numeric Variables"
        Me.rdoNumericVariables.UseVisualStyleBackColor = True
        '
        'rdoDataFrame
        '
        Me.rdoDataFrame.AutoSize = True
        Me.rdoDataFrame.Location = New System.Drawing.Point(316, 76)
        Me.rdoDataFrame.Name = "rdoDataFrame"
        Me.rdoDataFrame.Size = New System.Drawing.Size(113, 17)
        Me.rdoDataFrame.TabIndex = 6
        Me.rdoDataFrame.TabStop = True
        Me.rdoDataFrame.Text = "Data Frame/Matrix"
        Me.rdoDataFrame.UseVisualStyleBackColor = True
        '
        'ucrBase
        '
        Me.ucrBase.Location = New System.Drawing.Point(7, 381)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(410, 52)
        Me.ucrBase.TabIndex = 9
        '
        'ucrReceiverClusterData
        '
        Me.ucrReceiverClusterData.frmParent = Me
        Me.ucrReceiverClusterData.Location = New System.Drawing.Point(321, 105)
        Me.ucrReceiverClusterData.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverClusterData.Name = "ucrReceiverClusterData"
        Me.ucrReceiverClusterData.Selector = Nothing
        Me.ucrReceiverClusterData.Size = New System.Drawing.Size(120, 100)
        Me.ucrReceiverClusterData.strNcFilePath = ""
        Me.ucrReceiverClusterData.TabIndex = 8
        Me.ucrReceiverClusterData.ucrSelector = Nothing
        '
        'ucrSelectorClusterData
        '
        Me.ucrSelectorClusterData.bDropUnusedFilterLevels = False
        Me.ucrSelectorClusterData.bShowHiddenColumns = False
        Me.ucrSelectorClusterData.bUseCurrentFilter = True
        Me.ucrSelectorClusterData.Location = New System.Drawing.Point(7, 26)
        Me.ucrSelectorClusterData.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorClusterData.Name = "ucrSelectorClusterData"
        Me.ucrSelectorClusterData.Size = New System.Drawing.Size(210, 180)
        Me.ucrSelectorClusterData.TabIndex = 0
        '
        'ucrPnlClusterData
        '
        Me.ucrPnlClusterData.Location = New System.Drawing.Point(179, 2)
        Me.ucrPnlClusterData.Name = "ucrPnlClusterData"
        Me.ucrPnlClusterData.Size = New System.Drawing.Size(206, 39)
        Me.ucrPnlClusterData.TabIndex = 4
        '
        'ucrPnlSelectData
        '
        Me.ucrPnlSelectData.Location = New System.Drawing.Point(295, 47)
        Me.ucrPnlSelectData.Name = "ucrPnlSelectData"
        Me.ucrPnlSelectData.Size = New System.Drawing.Size(170, 52)
        Me.ucrPnlSelectData.TabIndex = 7
        '
        'ucrChkMetric
        '
        Me.ucrChkMetric.Checked = False
        Me.ucrChkMetric.Location = New System.Drawing.Point(7, 220)
        Me.ucrChkMetric.Name = "ucrChkMetric"
        Me.ucrChkMetric.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkMetric.TabIndex = 10
        '
        'ucrChkCluster
        '
        Me.ucrChkCluster.Checked = False
        Me.ucrChkCluster.Location = New System.Drawing.Point(8, 288)
        Me.ucrChkCluster.Name = "ucrChkCluster"
        Me.ucrChkCluster.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkCluster.TabIndex = 11
        '
        'ucrChkMethod
        '
        Me.ucrChkMethod.Checked = False
        Me.ucrChkMethod.Location = New System.Drawing.Point(7, 265)
        Me.ucrChkMethod.Name = "ucrChkMethod"
        Me.ucrChkMethod.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkMethod.TabIndex = 12
        '
        'ucrChkStand
        '
        Me.ucrChkStand.Checked = False
        Me.ucrChkStand.Location = New System.Drawing.Point(7, 243)
        Me.ucrChkStand.Name = "ucrChkStand"
        Me.ucrChkStand.Size = New System.Drawing.Size(100, 20)
        Me.ucrChkStand.TabIndex = 13
        '
        'ucrInputMetric
        '
        Me.ucrInputMetric.AddQuotesIfUnrecognised = True
        Me.ucrInputMetric.GetSetSelectedIndex = -1
        Me.ucrInputMetric.IsReadOnly = False
        Me.ucrInputMetric.Location = New System.Drawing.Point(127, 219)
        Me.ucrInputMetric.Name = "ucrInputMetric"
        Me.ucrInputMetric.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputMetric.TabIndex = 14
        '
        'ucrInputMethod
        '
        Me.ucrInputMethod.AddQuotesIfUnrecognised = True
        Me.ucrInputMethod.GetSetSelectedIndex = -1
        Me.ucrInputMethod.IsReadOnly = False
        Me.ucrInputMethod.Location = New System.Drawing.Point(127, 263)
        Me.ucrInputMethod.Name = "ucrInputMethod"
        Me.ucrInputMethod.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputMethod.TabIndex = 15
        '
        'ucrNudPamCluster
        '
        Me.ucrNudPamCluster.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPamCluster.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudPamCluster.Location = New System.Drawing.Point(126, 290)
        Me.ucrNudPamCluster.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudPamCluster.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudPamCluster.Name = "ucrNudPamCluster"
        Me.ucrNudPamCluster.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudPamCluster.TabIndex = 16
        Me.ucrNudPamCluster.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'dlgClusterAnalysis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 450)
        Me.Controls.Add(Me.ucrNudPamCluster)
        Me.Controls.Add(Me.ucrInputMethod)
        Me.Controls.Add(Me.ucrInputMetric)
        Me.Controls.Add(Me.ucrChkStand)
        Me.Controls.Add(Me.ucrChkMethod)
        Me.Controls.Add(Me.ucrChkCluster)
        Me.Controls.Add(Me.ucrChkMetric)
        Me.Controls.Add(Me.ucrBase)
        Me.Controls.Add(Me.ucrReceiverClusterData)
        Me.Controls.Add(Me.rdoDataFrame)
        Me.Controls.Add(Me.rdoNumericVariables)
        Me.Controls.Add(Me.rdoPartitioningData)
        Me.Controls.Add(Me.rdoHierarchicalData)
        Me.Controls.Add(Me.ucrSelectorClusterData)
        Me.Controls.Add(Me.ucrPnlClusterData)
        Me.Controls.Add(Me.ucrPnlSelectData)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgClusterAnalysis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cluster Analysis"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrSelectorClusterData As ucrSelectorByDataFrameAddRemove
    Friend WithEvents rdoHierarchicalData As RadioButton
    Friend WithEvents rdoPartitioningData As RadioButton
    Friend WithEvents ucrPnlClusterData As UcrPanel
    Friend WithEvents rdoNumericVariables As RadioButton
    Friend WithEvents rdoDataFrame As RadioButton
    Friend WithEvents ucrPnlSelectData As UcrPanel
    Friend WithEvents ucrReceiverClusterData As ucrReceiverMultiple
    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrChkStand As ucrCheck
    Friend WithEvents ucrChkMethod As ucrCheck
    Friend WithEvents ucrChkCluster As ucrCheck
    Friend WithEvents ucrChkMetric As ucrCheck
    Friend WithEvents ucrInputMetric As ucrInputComboBox
    Friend WithEvents ucrInputMethod As ucrInputComboBox
    Friend WithEvents ucrNudPamCluster As ucrNud
End Class
