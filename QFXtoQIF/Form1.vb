Imports System.IO
Imports System.Text
Imports System.Xml

Public Class Form1
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim oFile As New OpenFileDialog
        oFile.Filter = "QFX files (*.qfx)|*.qfx"
        If oFile.ShowDialog() = DialogResult.OK Then
            TextBoxInputFile.Text = oFile.FileName
        End If
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        If File.Exists(TextBoxInputFile.Text) Then
            RichTextBoxResult.Clear()
            Try
                Dim reader As StreamReader = My.Computer.FileSystem.OpenTextFileReader(TextBoxInputFile.Text, Encoding.Default)
                Dim lineStr As String
                Dim resultStr As New StringBuilder
                Dim dateStr As String
                Do
                    lineStr = reader.ReadLine
                    If lineStr Is Nothing Then Exit Do
                    If lineStr.StartsWith("<DTPOSTED>") Then
                        datestr=lineStr.Substring("<DTPOSTED>".Length, 8)
                        resultStr.AppendLine("D" + DateTime.ParseExact(dateStr, "yyyyMMdd", Nothing))
                        Continue Do
                    End If
                    If lineStr.StartsWith("<TRNAMT>") Then
                        resultStr.AppendLine("T" + lineStr.Substring("<TRNAMT>".Length))
                        resultStr.AppendLine("C*")
                        Continue Do
                    End If
                    If lineStr.StartsWith("<NAME>") Then
                        resultStr.AppendLine("P" + lineStr.Substring("<NAME>".Length))
                        resultStr.AppendLine("^")
                        Continue Do
                    End If
                Loop
                reader.Close()
                RichTextBoxResult.Text = resultStr.ToString
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("QFX input file not found.")
        End If
    End Sub

    Private Sub btnSaveQIF_Click(sender As Object, e As EventArgs) Handles btnSaveQIF.Click
        Dim sFileDlg As New SaveFileDialog
        sFileDlg.Filter = "QIF files (*.qif)|*.qif"
        If sFileDlg.ShowDialog = DialogResult.OK Then
            RichTextBoxResult.SaveFile(sFileDlg.FileName, RichTextBoxStreamType.PlainText)
        End If
    End Sub
End Class
