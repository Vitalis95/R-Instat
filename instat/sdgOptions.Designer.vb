<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgOptions
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
        Me.ucrButtonsDescribeDisplay = New instat.ucrButtonsSubdialogue()
        Me.lblDist = New System.Windows.Forms.Label()
        Me.ucrInputDist = New instat.ucrInputComboBox()
        Me.lblDays = New System.Windows.Forms.Label()
        Me.ucrNudDays = New instat.ucrNud()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.ucrNudCount = New instat.ucrNud()
        Me.lblBins = New System.Windows.Forms.Label()
        Me.ucrInputBins = New instat.ucrInputComboBox()
        Me.rdoAutoCalculate = New System.Windows.Forms.RadioButton()
        Me.rdoSpecifyBins = New System.Windows.Forms.RadioButton()
        Me.ucrChkCalcByMonth = New instat.ucrCheck()
        Me.ucrNudBins = New instat.ucrNud()
        Me.lblNumberBins = New System.Windows.Forms.Label()
        Me.ucrPnlBins = New instat.UcrPanel()
        Me.grpBins = New System.Windows.Forms.GroupBox()
        Me.SuspendLayout()
        '
        'ucrButtonsDescribeDisplay
        '
        Me.ucrButtonsDescribeDisplay.AutoSize = True
        Me.ucrButtonsDescribeDisplay.Location = New System.Drawing.Point(35, 163)
        Me.ucrButtonsDescribeDisplay.Name = "ucrButtonsDescribeDisplay"
        Me.ucrButtonsDescribeDisplay.Size = New System.Drawing.Size(262, 30)
        Me.ucrButtonsDescribeDisplay.TabIndex = 3
        '
        'lblDist
        '
        Me.lblDist.AutoSize = True
        Me.lblDist.Location = New System.Drawing.Point(227, 120)
        Me.lblDist.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDist.Name = "lblDist"
        Me.lblDist.Size = New System.Drawing.Size(62, 13)
        Me.lblDist.TabIndex = 25
        Me.lblDist.Text = "Distribution:"
        '
        'ucrInputDist
        '
        Me.ucrInputDist.AddQuotesIfUnrecognised = True
        Me.ucrInputDist.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDist.GetSetSelectedIndex = -1
        Me.ucrInputDist.IsReadOnly = False
        Me.ucrInputDist.Location = New System.Drawing.Point(291, 117)
        Me.ucrInputDist.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrInputDist.Name = "ucrInputDist"
        Me.ucrInputDist.Size = New System.Drawing.Size(77, 21)
        Me.ucrInputDist.TabIndex = 26
        '
        'lblDays
        '
        Me.lblDays.AutoSize = True
        Me.lblDays.Location = New System.Drawing.Point(10, 120)
        Me.lblDays.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(34, 13)
        Me.lblDays.TabIndex = 23
        Me.lblDays.Text = "Days:"
        '
        'ucrNudDays
        '
        Me.ucrNudDays.AutoSize = True
        Me.ucrNudDays.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDays.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDays.Location = New System.Drawing.Point(47, 117)
        Me.ucrNudDays.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrNudDays.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDays.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDays.Name = "ucrNudDays"
        Me.ucrNudDays.Size = New System.Drawing.Size(50, 21)
        Me.ucrNudDays.TabIndex = 24
        Me.ucrNudDays.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Location = New System.Drawing.Point(115, 120)
        Me.lblCount.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(38, 13)
        Me.lblCount.TabIndex = 29
        Me.lblCount.Text = "Count:"
        '
        'ucrNudCount
        '
        Me.ucrNudCount.AutoSize = True
        Me.ucrNudCount.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCount.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudCount.Location = New System.Drawing.Point(169, 117)
        Me.ucrNudCount.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrNudCount.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudCount.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCount.Name = "ucrNudCount"
        Me.ucrNudCount.Size = New System.Drawing.Size(50, 25)
        Me.ucrNudCount.TabIndex = 30
        Me.ucrNudCount.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblBins
        '
        Me.lblBins.AutoSize = True
        Me.lblBins.Location = New System.Drawing.Point(156, 75)
        Me.lblBins.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblBins.Name = "lblBins"
        Me.lblBins.Size = New System.Drawing.Size(30, 13)
        Me.lblBins.TabIndex = 27
        Me.lblBins.Text = "Bins:"
        '
        'ucrInputBins
        '
        Me.ucrInputBins.AddQuotesIfUnrecognised = True
        Me.ucrInputBins.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputBins.GetSetSelectedIndex = -1
        Me.ucrInputBins.IsReadOnly = False
        Me.ucrInputBins.Location = New System.Drawing.Point(201, 71)
        Me.ucrInputBins.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputBins.Name = "ucrInputBins"
        Me.ucrInputBins.Size = New System.Drawing.Size(132, 21)
        Me.ucrInputBins.TabIndex = 28
        '
        'rdoAutoCalculate
        '
        Me.rdoAutoCalculate.AutoSize = True
        Me.rdoAutoCalculate.Location = New System.Drawing.Point(20, 45)
        Me.rdoAutoCalculate.Name = "rdoAutoCalculate"
        Me.rdoAutoCalculate.Size = New System.Drawing.Size(113, 17)
        Me.rdoAutoCalculate.TabIndex = 31
        Me.rdoAutoCalculate.TabStop = True
        Me.rdoAutoCalculate.Text = "Autocalculate Bins"
        Me.rdoAutoCalculate.UseVisualStyleBackColor = True
        '
        'rdoSpecifyBins
        '
        Me.rdoSpecifyBins.AutoSize = True
        Me.rdoSpecifyBins.Location = New System.Drawing.Point(20, 71)
        Me.rdoSpecifyBins.Name = "rdoSpecifyBins"
        Me.rdoSpecifyBins.Size = New System.Drawing.Size(83, 17)
        Me.rdoSpecifyBins.TabIndex = 32
        Me.rdoSpecifyBins.TabStop = True
        Me.rdoSpecifyBins.Text = "Specify Bins"
        Me.rdoSpecifyBins.UseVisualStyleBackColor = True
        '
        'ucrChkCalcByMonth
        '
        Me.ucrChkCalcByMonth.AutoSize = True
        Me.ucrChkCalcByMonth.Checked = False
        Me.ucrChkCalcByMonth.Location = New System.Drawing.Point(149, 43)
        Me.ucrChkCalcByMonth.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrChkCalcByMonth.Name = "ucrChkCalcByMonth"
        Me.ucrChkCalcByMonth.Size = New System.Drawing.Size(139, 23)
        Me.ucrChkCalcByMonth.TabIndex = 33
        '
        'ucrNudBins
        '
        Me.ucrNudBins.AutoSize = True
        Me.ucrNudBins.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudBins.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudBins.Location = New System.Drawing.Point(366, 43)
        Me.ucrNudBins.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrNudBins.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudBins.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudBins.Name = "ucrNudBins"
        Me.ucrNudBins.Size = New System.Drawing.Size(50, 27)
        Me.ucrNudBins.TabIndex = 34
        Me.ucrNudBins.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblNumberBins
        '
        Me.lblNumberBins.AutoSize = True
        Me.lblNumberBins.Location = New System.Drawing.Point(287, 46)
        Me.lblNumberBins.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNumberBins.Name = "lblNumberBins"
        Me.lblNumberBins.Size = New System.Drawing.Size(76, 13)
        Me.lblNumberBins.TabIndex = 35
        Me.lblNumberBins.Text = "Numer of Bins:"
        '
        'ucrPnlBins
        '
        Me.ucrPnlBins.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlBins.Location = New System.Drawing.Point(13, 38)
        Me.ucrPnlBins.Name = "ucrPnlBins"
        Me.ucrPnlBins.Size = New System.Drawing.Size(130, 67)
        Me.ucrPnlBins.TabIndex = 36
        '
        'grpBins
        '
        Me.grpBins.Location = New System.Drawing.Point(5, 12)
        Me.grpBins.Name = "grpBins"
        Me.grpBins.Size = New System.Drawing.Size(419, 98)
        Me.grpBins.TabIndex = 37
        Me.grpBins.TabStop = False
        Me.grpBins.Text = "Bins"
        '
        'sdgOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 223)
        Me.Controls.Add(Me.lblNumberBins)
        Me.Controls.Add(Me.ucrNudBins)
        Me.Controls.Add(Me.ucrChkCalcByMonth)
        Me.Controls.Add(Me.rdoSpecifyBins)
        Me.Controls.Add(Me.rdoAutoCalculate)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.ucrNudCount)
        Me.Controls.Add(Me.lblBins)
        Me.Controls.Add(Me.ucrInputBins)
        Me.Controls.Add(Me.lblDist)
        Me.Controls.Add(Me.ucrInputDist)
        Me.Controls.Add(Me.lblDays)
        Me.Controls.Add(Me.ucrNudDays)
        Me.Controls.Add(Me.ucrButtonsDescribeDisplay)
        Me.Controls.Add(Me.ucrPnlBins)
        Me.Controls.Add(Me.grpBins)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Options"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrButtonsDescribeDisplay As ucrButtonsSubdialogue
    Friend WithEvents lblDist As Label
    Friend WithEvents ucrInputDist As ucrInputComboBox
    Friend WithEvents lblDays As Label
    Friend WithEvents ucrNudDays As ucrNud
    Friend WithEvents lblCount As Label
    Friend WithEvents ucrNudCount As ucrNud
    Friend WithEvents lblBins As Label
    Friend WithEvents ucrInputBins As ucrInputComboBox
    Friend WithEvents rdoAutoCalculate As RadioButton
    Friend WithEvents rdoSpecifyBins As RadioButton
    Friend WithEvents ucrChkCalcByMonth As ucrCheck
    Friend WithEvents ucrNudBins As ucrNud
    Friend WithEvents lblNumberBins As Label
    Friend WithEvents ucrPnlBins As UcrPanel
    Friend WithEvents grpBins As GroupBox
End Class
