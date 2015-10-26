Imports System.IO

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Compile_SIC_Click(sender As Object, e As EventArgs) Handles Compile_sic.Click
        File.Copy(OpenFileDialog.FileName, "C:\Assembler Files\Input.sic", True)
        'My.Computer.FileSystem.CopyFile(OpenFileDialog.FileName, "C:\Assembler Files\Input.sic",
        'Microsoft.VisualBasic.FileIO.UIOption.AllDialogs,
        ' Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing)
        Process.Start(".\Assembler.exe", "/C Pause")
    End Sub

    Private Sub New_Text_Click(sender As Object, e As EventArgs) Handles New_Text.Click
        RichTextBox.Clear()
    End Sub

    Private Sub Open_Text_Click(sender As Object, e As EventArgs) Handles Open_Text.Click
        If OpenFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then

            RichTextBox().LoadFile(OpenFileDialog.FileName, _
                                    RichTextBoxStreamType.PlainText)
            Label3.Text = OpenFileDialog.SafeFileName
        End If
    End Sub

    Private Sub Save_Text_Click(sender As Object, e As EventArgs) Handles Save_Text.Click
        If SaveFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                RichTextBox.SaveFile(SaveFileDialog.FileName, _
                                  RichTextBoxStreamType.PlainText)
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End If
    End Sub

End Class