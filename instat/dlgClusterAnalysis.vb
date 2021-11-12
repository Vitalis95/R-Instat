' R- Instat
' Copyright (C) 2015-2017
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat.Translations
Public Class dlgClusterAnalysis
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private Sub dlgClusterAnalysis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOkEnabled()
    End Sub
    Private Sub InitialiseDialog()
        Dim dctMetric As New Dictionary(Of String, String)
        Dim dctMethod As New Dictionary(Of String, String)

        ucrReceiverClusterData.SetParameterIsRFunction()
        ucrReceiverClusterData.Selector = ucrSelectorClusterData
        ucrReceiverClusterData.SetMeAsReceiver()
        ucrReceiverClusterData.SetDataType("numeric")

        ucrSelectorClusterData.SetParameterIsrfunction()

        ucrPnlClusterData.AddRadioButton(rdoPartitioningData)
        ucrPnlClusterData.AddRadioButton(rdoHierarchicalData)
        ucrPnlClusterData.AddFunctionNamesCondition(rdoPartitioningData, {"pam"})
        ucrPnlClusterData.AddFunctionNamesCondition(rdoHierarchicalData, {"agnes"})

        ucrInputMetric.SetParameter(New RParameter("metric", 3))
        dctMetric.Add("euclidean", Chr(34) & "euclidean" & Chr(34))
        dctMetric.Add("manhattan", Chr(34) & "manhattan" & Chr(34))
        ucrInputMetric.SetItems(dctMetric)
        ucrInputMetric.SetRDefault(Chr(34) & "euclidean" & Chr(34))

        ucrChkMetric.SetText("Metric:")
        ucrChkMetric.AddToLinkedControls(ucrInputMetric, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkMetric.AddFunctionNamesCondition(True, "pam")


        ucrPnlSelectData.AddRadioButton(rdoNumericVariables)
        ucrPnlSelectData.AddRadioButton(rdoDataFrame)

        ucrChkStand.SetParameter(New RParameter("stand", 4))
        ucrChkStand.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkStand.SetRDefault("FALSE")
        ucrChkStand.SetText("Stand:")

        ucrInputMethod.SetParameter(New RParameter("method"), 4)
        dctMethod.Add("average", Chr(34) & "average" & Chr(34))
        dctMethod.Add("single", Chr(34) & "single" & Chr(34))
        dctMethod.Add("complete", Chr(34) & "complete" & Chr(34))
        dctMethod.Add("ward", Chr(34) & "ward" & Chr(34))
        dctMethod.Add("weighted", Chr(34) & "weighted" & Chr(34))
        dctMethod.Add("flexible", Chr(34) & "flexible" & Chr(34))
        ucrInputMethod.SetItems(dctMethod)
        ucrInputMethod.SetRDefault(Chr(34) & "average" & Chr(34))

        ucrChkMethod.SetText("Method:")
        ucrChkMethod.AddToLinkedControls(ucrInputMethod, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkMethod.AddFunctionNamesCondition(True, "pam")

        ucrPnlClusterData.AddToLinkedControls(ucrChkMethod, {rdoHierarchicalData}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=False)
        ucrPnlClusterData.AddToLinkedControls(ucrPnlClusterData, {rdoPartitioningData}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=False)

    End Sub
    Private Sub SetDefaults()

    End Sub
    Private Sub SetRCodeForControls(bReset As Boolean)

    End Sub
    Private Sub TestOkEnabled()

    End Sub
End Class