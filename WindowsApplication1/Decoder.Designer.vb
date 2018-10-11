<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Decoder
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.InputBox = New System.Windows.Forms.TextBox()
        Me.OutputBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SeedBox = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'InputBox
        '
        Me.InputBox.Location = New System.Drawing.Point(12, 30)
        Me.InputBox.MaxLength = 1000000
        Me.InputBox.Multiline = True
        Me.InputBox.Name = "InputBox"
        Me.InputBox.Size = New System.Drawing.Size(525, 100)
        Me.InputBox.TabIndex = 0
        '
        'OutputBox
        '
        Me.OutputBox.Location = New System.Drawing.Point(12, 204)
        Me.OutputBox.Multiline = True
        Me.OutputBox.Name = "OutputBox"
        Me.OutputBox.ReadOnly = True
        Me.OutputBox.Size = New System.Drawing.Size(525, 100)
        Me.OutputBox.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 136)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(93, 49)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Verschlüsseln"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(111, 136)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 49)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Entschlüsseln"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Input"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 188)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Output"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(210, 136)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(93, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Copy"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'SeedBox
        '
        Me.SeedBox.Location = New System.Drawing.Point(408, 166)
        Me.SeedBox.MaxLength = 9
        Me.SeedBox.Name = "SeedBox"
        Me.SeedBox.Size = New System.Drawing.Size(129, 20)
        Me.SeedBox.TabIndex = 7
        Me.SeedBox.Text = "123456789"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(309, 163)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(93, 23)
        Me.Button4.TabIndex = 8
        Me.Button4.Text = "Reset Seed"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(210, 162)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(93, 23)
        Me.Button5.TabIndex = 9
        Me.Button5.Text = "Paste"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Decoder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 314)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.SeedBox)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.OutputBox)
        Me.Controls.Add(Me.InputBox)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(565, 353)
        Me.MinimumSize = New System.Drawing.Size(565, 39)
        Me.Name = "Decoder"
        Me.ShowIcon = False
        Me.Text = "Decoder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents InputBox As TextBox
    Friend WithEvents OutputBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents SeedBox As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
End Class
