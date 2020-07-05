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
        Me.TextBoxInputFile = New System.Windows.Forms.TextBox()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.RichTextBoxResult = New System.Windows.Forms.RichTextBox()
        Me.btnSaveQIF = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBoxInputFile
        '
        Me.TextBoxInputFile.Location = New System.Drawing.Point(13, 30)
        Me.TextBoxInputFile.Name = "TextBoxInputFile"
        Me.TextBoxInputFile.Size = New System.Drawing.Size(267, 20)
        Me.TextBoxInputFile.TabIndex = 0
        '
        'btnBrowse
        '
        Me.btnBrowse.Location = New System.Drawing.Point(286, 28)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowse.TabIndex = 1
        Me.btnBrowse.Text = "Browse"
        Me.btnBrowse.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Choose QFX File:"
        '
        'btnConvert
        '
        Me.btnConvert.Location = New System.Drawing.Point(13, 56)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(348, 23)
        Me.btnConvert.TabIndex = 1
        Me.btnConvert.Text = "Convert to QIF"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'RichTextBoxResult
        '
        Me.RichTextBoxResult.Location = New System.Drawing.Point(13, 104)
        Me.RichTextBoxResult.Name = "RichTextBoxResult"
        Me.RichTextBoxResult.Size = New System.Drawing.Size(348, 329)
        Me.RichTextBoxResult.TabIndex = 3
        Me.RichTextBoxResult.Text = ""
        '
        'btnSaveQIF
        '
        Me.btnSaveQIF.Location = New System.Drawing.Point(12, 439)
        Me.btnSaveQIF.Name = "btnSaveQIF"
        Me.btnSaveQIF.Size = New System.Drawing.Size(348, 23)
        Me.btnSaveQIF.TabIndex = 1
        Me.btnSaveQIF.Text = "Save QIF File"
        Me.btnSaveQIF.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Conversion Result:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 468)
        Me.Controls.Add(Me.RichTextBoxResult)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSaveQIF)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.TextBoxInputFile)
        Me.Name = "Form1"
        Me.Text = "QXF to QIF Converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxInputFile As TextBox
    Friend WithEvents btnBrowse As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnConvert As Button
    Friend WithEvents RichTextBoxResult As RichTextBox
    Friend WithEvents btnSaveQIF As Button
    Friend WithEvents Label2 As Label
End Class
