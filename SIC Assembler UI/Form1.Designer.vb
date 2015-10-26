<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.Compile_sic = New System.Windows.Forms.Button()
        Me.New_Text = New System.Windows.Forms.Button()
        Me.Open_Text = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Save_Text = New System.Windows.Forms.Button()
        Me.RichTextBox = New System.Windows.Forms.RichTextBox()
        Me.SaveFileDialog = New System.Windows.Forms.SaveFileDialog()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(144, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SIC/XE ASSEMBLER"
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.Filter = "SIC Source Code|*.SIC"
        '
        'Compile_sic
        '
        Me.Compile_sic.Font = New System.Drawing.Font("Constantia", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Compile_sic.Location = New System.Drawing.Point(426, 65)
        Me.Compile_sic.Name = "Compile_sic"
        Me.Compile_sic.Size = New System.Drawing.Size(86, 35)
        Me.Compile_sic.TabIndex = 3
        Me.Compile_sic.Text = "Complie"
        Me.Compile_sic.UseVisualStyleBackColor = True
        '
        'New_Text
        '
        Me.New_Text.Location = New System.Drawing.Point(12, 50)
        Me.New_Text.Name = "New_Text"
        Me.New_Text.Size = New System.Drawing.Size(63, 24)
        Me.New_Text.TabIndex = 4
        Me.New_Text.Text = "New"
        Me.New_Text.UseVisualStyleBackColor = True
        '
        'Open_Text
        '
        Me.Open_Text.Location = New System.Drawing.Point(93, 50)
        Me.Open_Text.Name = "Open_Text"
        Me.Open_Text.Size = New System.Drawing.Size(69, 24)
        Me.Open_Text.TabIndex = 5
        Me.Open_Text.Text = "Open"
        Me.Open_Text.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 24)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Currently Opned File  :"
        '
        'Save_Text
        '
        Me.Save_Text.Location = New System.Drawing.Point(184, 50)
        Me.Save_Text.Name = "Save_Text"
        Me.Save_Text.Size = New System.Drawing.Size(63, 24)
        Me.Save_Text.TabIndex = 9
        Me.Save_Text.Text = "Save"
        Me.Save_Text.UseVisualStyleBackColor = True
        '
        'RichTextBox
        '
        Me.RichTextBox.AcceptsTab = True
        Me.RichTextBox.AutoWordSelection = True
        Me.RichTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RichTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox.ForeColor = System.Drawing.SystemColors.Desktop
        Me.RichTextBox.Location = New System.Drawing.Point(12, 121)
        Me.RichTextBox.Name = "RichTextBox"
        Me.RichTextBox.Size = New System.Drawing.Size(500, 324)
        Me.RichTextBox.TabIndex = 3
        Me.RichTextBox.Text = ""
        '
        'SaveFileDialog
        '
        Me.SaveFileDialog.Filter = "SIC Files|*.sic|All Files|*.*"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(168, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(181, 24)
        Me.Label3.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(524, 457)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.RichTextBox)
        Me.Controls.Add(Me.Save_Text)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Open_Text)
        Me.Controls.Add(Me.New_Text)
        Me.Controls.Add(Me.Compile_sic)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "SIC Assembler"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Compile_sic As System.Windows.Forms.Button
    Friend WithEvents New_Text As System.Windows.Forms.Button
    Friend WithEvents Open_Text As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Save_Text As System.Windows.Forms.Button
    Friend WithEvents RichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents SaveFileDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
