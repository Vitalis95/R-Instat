<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sdgOptions
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
        Me.ucrButtonsDescribeDisplay = New instat.ucrButtonsSubdialogue()
        Me.lblDist = New System.Windows.Forms.Label()
        Me.ucrInputDist = New instat.ucrInputComboBox()
        Me.lblDays = New System.Windows.Forms.Label()
        Me.ucrNudDays = New instat.ucrNud()
        Me.lblCount = New System.Windows.Forms.Label()
        Me.ucrNudCount = New instat.ucrNud()
        Me.lblBins = New System.Windows.Forms.Label()
        Me.ucrInputBins = New instat.ucrInputComboBox()
        Me.ucrChkCalcByMonth = New instat.ucrCheck()
        Me.ucrNudBins = New instat.ucrNud()
        Me.lblNumberBins = New System.Windows.Forms.Label()
        Me.ucrPnlBins = New instat.UcrPanel()
        Me.rdoAutoCalculate = New System.Windows.Forms.RadioButton()
        Me.rdoSpecifyBins = New System.Windows.Forms.RadioButton()
        Me.UcrPanel1 = New instat.UcrPanel()
        Me.SuspendLayout()
        '
        'ucrButtonsDescribeDisplay
        '
        Me.ucrButtonsDescribeDisplay.AutoSize = True
        Me.ucrButtonsDescribeDisplay.Location = New System.Drawing.Point(52, 251)
        Me.ucrButtonsDescribeDisplay.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrButtonsDescribeDisplay.Name = "ucrButtonsDescribeDisplay"
        Me.ucrButtonsDescribeDisplay.Size = New System.Drawing.Size(393, 46)
        Me.ucrButtonsDescribeDisplay.TabIndex = 3
        '
        'lblDist
        '
        Me.lblDist.AutoSize = True
        Me.lblDist.Location = New System.Drawing.Point(340, 185)
        Me.lblDist.Name = "lblDist"
        Me.lblDist.Size = New System.Drawing.Size(93, 20)
        Me.lblDist.TabIndex = 25
        Me.lblDist.Text = "Distribution:"
        '
        'ucrInputDist
        '
        Me.ucrInputDist.AddQuotesIfUnrecognised = True
        Me.ucrInputDist.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputDist.GetSetSelectedIndex = -1
        Me.ucrInputDist.IsReadOnly = False
        Me.ucrInputDist.Location = New System.Drawing.Point(436, 180)
        Me.ucrInputDist.Margin = New System.Windows.Forms.Padding(9, 9, 9, 9)
        Me.ucrInputDist.Name = "ucrInputDist"
        Me.ucrInputDist.Size = New System.Drawing.Size(116, 32)
        Me.ucrInputDist.TabIndex = 26
        '
        'lblDays
        '
        Me.lblDays.AutoSize = True
        Me.lblDays.Location = New System.Drawing.Point(15, 184)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(49, 20)
        Me.lblDays.TabIndex = 23
        Me.lblDays.Text = "Days:"
        '
        'ucrNudDays
        '
        Me.ucrNudDays.AutoSize = True
        Me.ucrNudDays.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDays.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudDays.Location = New System.Drawing.Point(70, 180)
        Me.ucrNudDays.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrNudDays.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudDays.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudDays.Name = "ucrNudDays"
        Me.ucrNudDays.Size = New System.Drawing.Size(75, 32)
        Me.ucrNudDays.TabIndex = 24
        Me.ucrNudDays.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblCount
        '
        Me.lblCount.AutoSize = True
        Me.lblCount.Location = New System.Drawing.Point(172, 185)
        Me.lblCount.Name = "lblCount"
        Me.lblCount.Size = New System.Drawing.Size(56, 20)
        Me.lblCount.TabIndex = 29
        Me.lblCount.Text = "Count:"
        '
        'ucrNudCount
        '
        Me.ucrNudCount.AutoSize = True
        Me.ucrNudCount.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCount.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudCount.Location = New System.Drawing.Point(254, 180)
        Me.ucrNudCount.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrNudCount.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudCount.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudCount.Name = "ucrNudCount"
        Me.ucrNudCount.Size = New System.Drawing.Size(75, 38)
        Me.ucrNudCount.TabIndex = 30
        Me.ucrNudCount.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblBins
        '
        Me.lblBins.AutoSize = True
        Me.lblBins.Location = New System.Drawing.Point(436, 115)
        Me.lblBins.Name = "lblBins"
        Me.lblBins.Size = New System.Drawing.Size(44, 20)
        Me.lblBins.TabIndex = 27
        Me.lblBins.Text = "Bins:"
        '
        'ucrInputBins
        '
        Me.ucrInputBins.AddQuotesIfUnrecognised = True
        Me.ucrInputBins.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputBins.GetSetSelectedIndex = -1
        Me.ucrInputBins.IsReadOnly = False
        Me.ucrInputBins.Location = New System.Drawing.Point(481, 109)
        Me.ucrInputBins.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputBins.Name = "ucrInputBins"
        Me.ucrInputBins.Size = New System.Drawing.Size(198, 32)
        Me.ucrInputBins.TabIndex = 28
        '
        'ucrChkCalcByMonth
        '
        Me.ucrChkCalcByMonth.AutoSize = True
        Me.ucrChkCalcByMonth.Checked = False
        Me.ucrChkCalcByMonth.Location = New System.Drawing.Point(475, 15)
        Me.ucrChkCalcByMonth.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrChkCalcByMonth.Name = "ucrChkCalcByMonth"
        Me.ucrChkCalcByMonth.Size = New System.Drawing.Size(208, 35)
        Me.ucrChkCalcByMonth.TabIndex = 33
        '
        'ucrNudBins
        '
        Me.ucrNudBins.AutoSize = True
        Me.ucrNudBins.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudBins.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudBins.Location = New System.Drawing.Point(591, 66)
        Me.ucrNudBins.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.ucrNudBins.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudBins.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudBins.Name = "ucrNudBins"
        Me.ucrNudBins.Size = New System.Drawing.Size(75, 42)
        Me.ucrNudBins.TabIndex = 34
        Me.ucrNudBins.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblNumberBins
        '
        Me.lblNumberBins.AutoSize = True
        Me.lblNumberBins.Location = New System.Drawing.Point(471, 71)
        Me.lblNumberBins.Name = "lblNumberBins"
        Me.lblNumberBins.Size = New System.Drawing.Size(113, 20)
        Me.lblNumberBins.TabIndex = 35
        Me.lblNumberBins.Text = "Numer of Bins:"
        '
        'ucrPnlBins
        '
        Me.ucrPnlBins.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlBins.Location = New System.Drawing.Point(12, 18)
        Me.ucrPnlBins.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrPnlBins.Name = "ucrPnlBins"
        Me.ucrPnlBins.Size = New System.Drawing.Size(421, 123)
        Me.ucrPnlBins.TabIndex = 36
        '
        'rdoAutoCalculate
        '
        Me.rdoAutoCalculate.Location = New System.Drawing.Point(33, 84)
        Me.rdoAutoCalculate.Name = "rdoAutoCalculate"
        Me.rdoAutoCalculate.Size = New System.Drawing.Size(133, 24)
        Me.rdoAutoCalculate.TabIndex = 39
        Me.rdoAutoCalculate.TabStop = True
        Me.rdoAutoCalculate.Text = "RadioButton1"
        Me.rdoAutoCalculate.UseVisualStyleBackColor = True
        '
        'rdoSpecifyBins
        '
        Me.rdoSpecifyBins.Location = New System.Drawing.Point(212, 84)
        Me.rdoSpecifyBins.Name = "rdoSpecifyBins"
        Me.rdoSpecifyBins.Size = New System.Drawing.Size(133, 24)
        Me.rdoSpecifyBins.TabIndex = 40
        Me.rdoSpecifyBins.TabStop = True
        Me.rdoSpecifyBins.Text = "RadioButton1"
        Me.rdoSpecifyBins.UseVisualStyleBackColor = True
        '
        'UcrPanel1
        '
        Me.UcrPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UcrPanel1.Location = New System.Drawing.Point(487, 269)
        Me.UcrPanel1.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.UcrPanel1.Name = "UcrPanel1"
        Me.UcrPanel1.Size = New System.Drawing.Size(280, 30)
        Me.UcrPanel1.TabIndex = 41
        '
        'sdgOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(684, 343)
        Me.Controls.Add(Me.UcrPanel1)
        Me.Controls.Add(Me.rdoSpecifyBins)
        Me.Controls.Add(Me.rdoAutoCalculate)
        Me.Controls.Add(Me.ucrPnlBins)
        Me.Controls.Add(Me.lblNumberBins)
        Me.Controls.Add(Me.ucrNudBins)
        Me.Controls.Add(Me.ucrChkCalcByMonth)
        Me.Controls.Add(Me.lblCount)
        Me.Controls.Add(Me.ucrNudCount)
        Me.Controls.Add(Me.lblBins)
        Me.Controls.Add(Me.ucrInputBins)
        Me.Controls.Add(Me.lblDist)
        Me.Controls.Add(Me.ucrInputDist)
        Me.Controls.Add(Me.lblDays)
        Me.Controls.Add(Me.ucrNudDays)
        Me.Controls.Add(Me.ucrButtonsDescribeDisplay)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
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
    Friend WithEvents ucrChkCalcByMonth As ucrCheck
    Friend WithEvents ucrNudBins As ucrNud
    Friend WithEvents lblNumberBins As Label
    Friend WithEvents ucrPnlBins As UcrPanel
    Friend WithEvents rdoAutoCalculate As RadioButton
    Friend WithEvents rdoSpecifyBins As RadioButton
    Friend WithEvents UcrPanel1 As UcrPanel
End Class
