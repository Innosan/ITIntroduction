<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Test2Task1Form
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.bVariableInput = New System.Windows.Forms.TextBox()
        Me.aVariableInput = New System.Windows.Forms.TextBox()
        Me.bVariableLabel = New System.Windows.Forms.Label()
        Me.aVarLabel = New System.Windows.Forms.Label()
        Me.hVarInput = New System.Windows.Forms.TextBox()
        Me.hVarLabel = New System.Windows.Forms.Label()
        Me.xVars = New System.Windows.Forms.ListBox()
        Me.solveBtn = New System.Windows.Forms.Button()
        Me.yVars = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'bVariableInput
        '
        Me.bVariableInput.Location = New System.Drawing.Point(147, 122)
        Me.bVariableInput.Name = "bVariableInput"
        Me.bVariableInput.PlaceholderText = "Input number"
        Me.bVariableInput.Size = New System.Drawing.Size(100, 23)
        Me.bVariableInput.TabIndex = 7
        '
        'aVariableInput
        '
        Me.aVariableInput.Location = New System.Drawing.Point(147, 86)
        Me.aVariableInput.Name = "aVariableInput"
        Me.aVariableInput.PlaceholderText = "Input number"
        Me.aVariableInput.Size = New System.Drawing.Size(100, 23)
        Me.aVariableInput.TabIndex = 6
        '
        'bVariableLabel
        '
        Me.bVariableLabel.AutoSize = True
        Me.bVariableLabel.Location = New System.Drawing.Point(95, 125)
        Me.bVariableLabel.Name = "bVariableLabel"
        Me.bVariableLabel.Size = New System.Drawing.Size(25, 15)
        Me.bVariableLabel.TabIndex = 5
        Me.bVariableLabel.Text = "B ="
        '
        'aVarLabel
        '
        Me.aVarLabel.AutoSize = True
        Me.aVarLabel.Location = New System.Drawing.Point(95, 89)
        Me.aVarLabel.Name = "aVarLabel"
        Me.aVarLabel.Size = New System.Drawing.Size(26, 15)
        Me.aVarLabel.TabIndex = 4
        Me.aVarLabel.Text = "A ="
        '
        'hVarInput
        '
        Me.hVarInput.Location = New System.Drawing.Point(147, 184)
        Me.hVarInput.Name = "hVarInput"
        Me.hVarInput.PlaceholderText = "Input number"
        Me.hVarInput.Size = New System.Drawing.Size(100, 23)
        Me.hVarInput.TabIndex = 9
        '
        'hVarLabel
        '
        Me.hVarLabel.AutoSize = True
        Me.hVarLabel.Location = New System.Drawing.Point(95, 187)
        Me.hVarLabel.Name = "hVarLabel"
        Me.hVarLabel.Size = New System.Drawing.Size(27, 15)
        Me.hVarLabel.TabIndex = 8
        Me.hVarLabel.Text = "H ="
        '
        'xVars
        '
        Me.xVars.FormattingEnabled = True
        Me.xVars.ItemHeight = 15
        Me.xVars.Location = New System.Drawing.Point(461, 86)
        Me.xVars.Name = "xVars"
        Me.xVars.Size = New System.Drawing.Size(120, 94)
        Me.xVars.TabIndex = 10
        '
        'solveBtn
        '
        Me.solveBtn.Location = New System.Drawing.Point(361, 306)
        Me.solveBtn.Name = "solveBtn"
        Me.solveBtn.Size = New System.Drawing.Size(75, 23)
        Me.solveBtn.TabIndex = 11
        Me.solveBtn.Text = "Solve"
        Me.solveBtn.UseVisualStyleBackColor = True
        '
        'yVars
        '
        Me.yVars.FormattingEnabled = True
        Me.yVars.ItemHeight = 15
        Me.yVars.Location = New System.Drawing.Point(614, 86)
        Me.yVars.Name = "yVars"
        Me.yVars.Size = New System.Drawing.Size(120, 94)
        Me.yVars.TabIndex = 12
        '
        'Test2Task1Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.yVars)
        Me.Controls.Add(Me.solveBtn)
        Me.Controls.Add(Me.xVars)
        Me.Controls.Add(Me.hVarInput)
        Me.Controls.Add(Me.hVarLabel)
        Me.Controls.Add(Me.bVariableInput)
        Me.Controls.Add(Me.aVariableInput)
        Me.Controls.Add(Me.bVariableLabel)
        Me.Controls.Add(Me.aVarLabel)
        Me.Name = "Test2Task1Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Test2Task1Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bVariableInput As TextBox
    Friend WithEvents aVariableInput As TextBox
    Friend WithEvents bVariableLabel As Label
    Friend WithEvents aVarLabel As Label
    Friend WithEvents hVarInput As TextBox
    Friend WithEvents hVarLabel As Label
    Friend WithEvents xVars As ListBox
    Friend WithEvents solveBtn As Button
    Friend WithEvents yVars As ListBox
End Class
