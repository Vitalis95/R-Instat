﻿' R- Instat
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

Public Class clsInstatOptionsDefaults
    Public Shared ReadOnly DEFAULTbIncludeRDefaultParameters As Boolean = False
    Public Shared ReadOnly DEFAULTbCommandsinOutput As Boolean = False
    Public Shared ReadOnly DEFAULTbIncludeCommentDefault As Boolean = True
    Public Shared ReadOnly DEFAULTbShowProcurementMenu As Boolean = False
    Public Shared ReadOnly DEFAULTbShowTricotMenu As Boolean = False
    Public Shared ReadOnly DEFAULTbShowTricotXpMenu As Boolean = False
    Public Shared ReadOnly DEFAULTbShowClimaticMenu As Boolean = True
    Public Shared ReadOnly DEFAULTbShowStructuredMenu As Boolean = False
    Public Shared ReadOnly DEFAULTbShowOptionsByContextMenu As Boolean = False
    Public Shared ReadOnly DEFAULTfntOutput As Font = New Font(FontFamily.GenericMonospace, 11, FontStyle.Regular)
    Public Shared ReadOnly DEFAULTclrOutput As Color = Color.Blue
    Public Shared ReadOnly DEFAULTfntComment As Font = New Font(FontFamily.GenericSansSerif, 11, FontStyle.Regular)
    Public Shared ReadOnly DEFAULTclrComment As Color = Color.Green
    Public Shared ReadOnly DEFAULTfntScript As Font = New Font(FontFamily.GenericSansSerif, 11, FontStyle.Regular)
    Public Shared ReadOnly DEFAULTclrScript As Color = Color.Black
    Public Shared ReadOnly DEFAULTfntEditor As Font = New Font(FontFamily.GenericSansSerif, 10, FontStyle.Regular)
    Public Shared ReadOnly DEFAULTclrEditor As Color = Color.Black
    Public Shared ReadOnly DEFAULTiPreviewRows As Integer = 10
    Public Shared ReadOnly DEFAULTiMaxRows As Integer = 1000
    Public Shared ReadOnly DEFAULTiMaxCols As Integer = 50
    Public Shared ReadOnly DEFAULTiUndoColLimit As Integer = 200
    Public Shared ReadOnly DEFAULTiUndoRowLimit As Integer = 200000
    Public Shared ReadOnly DEFAULTstrComment As String = "Dialog:"
    Public Shared ReadOnly DEFAULTstrGraphDisplayOption As String = "view_output_window"
    Public Shared ReadOnly DEFAULTbChangeDataFrame As Boolean = False
    ' Fixed language to English
    ' TODO is this what we want?
    Public Shared ReadOnly DEFAULTstrLanguageCultureCode As String = "en-GB"
    'Public Shared ReadOnly DEFAULTstrLanguageCultureCode As String = Threading.Thread.CurrentThread.CurrentUICulture.Name
    Public Shared ReadOnly DEFAULTstrWorkingDirectory As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
    Public Shared ReadOnly DEFAULTlstColourPalette As List(Of Color) = ({Color.Aqua, Color.Gray, Color.LightGreen, Color.AliceBlue, Color.Maroon, Color.Green, Color.LightPink, Color.LightSkyBlue, Color.Brown, Color.MediumPurple, Color.White}).ToList
    Public Shared ReadOnly DEFAULTiDigits As Integer = 4
    Public Shared ReadOnly DEFAULTbShowSignifStars As Boolean = False
    Public Shared ReadOnly DEFAULTbAutoSaveData As Boolean = True
    Public Shared ReadOnly DEFAULTbSwitchOffUndo As Boolean = False
    Public Shared ReadOnly DEFAULTiAutoSaveDataMinutes As Integer = 10
    Public Shared ReadOnly DEFAULTbShowWaitDialog As Boolean = True
    Public Shared ReadOnly DEFAULTiWaitTimeDelaySeconds As Integer = 2
    Public Shared ReadOnly DEFAULTiToolbarHeight As Integer = 30
    Public Shared ReadOnly DEFAULTstrClimsoftDatabaseName As String = "mariadb_climsoft_db_v4"
    Public Shared ReadOnly DEFAULTstrClimsoftHost As String = "127.0.0.1"
    Public Shared ReadOnly DEFAULTstrClimsoftPort As String = "3308"
    Public Shared ReadOnly DEFAULTstrClimsoftUsername As String = "root"
    Public Shared ReadOnly DEFAULTiMaxOutputsHeight As Integer = 500
    Public Shared ReadOnly DEFAULTiMaxWidth As Integer = 80
    Public Shared ReadOnly DEFAULTbRemindLaterOption As Boolean = False
End Class
