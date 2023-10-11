<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Test2Task3Form
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
        Me.yVars = New System.Windows.Forms.ListBox()
        Me.solveBtn = New System.Windows.Forms.Button()
        Me.xVars = New System.Windows.Forms.ListBox()
        Me.hVarInput = New System.Windows.Forms.TextBox()
        Me.hVarLabel = New System.Windows.Forms.Label()
        Me.bVariableInput = New System.Windows.Forms.TextBox()
        Me.aVariableInput = New System.Windows.Forms.TextBox()
        Me.bVariableLabel = New System.Windows.Forms.Label()
        Me.aVarLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'yVars
        '
        Me.yVars.FormattingEnabled = True
        Me.yVars.ItemHeight = 15
        Me.yVars.Location = New System.Drawing.Point(600, 104)
        Me.yVars.Name = "yVars"
        Me.yVars.Size = New System.Drawing.Size(120, 94)
        Me.yVars.TabIndex = 30
        '
        'solveBtn
        '
        Me.solveBtn.Location = New System.Drawing.Point(347, 324)
        Me.solveBtn.Name = "solveBtn"
        Me.solveBtn.Size = New System.Drawing.Size(75, 23)
        Me.solveBtn.TabIndex = 29
        Me.solveBtn.Text = "Solve"
        Me.solveBtn.UseVisualStyleBackColor = True
        '
        'xVars
        '
        Me.xVars.FormattingEnabled = True
        Me.xVars.ItemHeight = 15
        Me.xVars.Location = New System.Drawing.Point(447, 104)
        Me.xVars.Name = "xVars"
        Me.xVars.Size = New System.Drawing.Size(120, 94)
        Me.xVars.TabIndex = 28
        '
        'hVarInput
        '
        Me.hVarInput.Location = New System.Drawing.Point(133, 202)
        Me.hVarInput.Name = "hVarInput"
        Me.hVarInput.PlaceholderText = "Input number"
        Me.hVarInput.Size = New System.Drawing.Size(100, 23)
        Me.hVarInput.TabIndex = 27
        '
        'hVarLabel
        '
        Me.hVarLabel.AutoSize = True
        Me.hVarLabel.Location = New System.Drawing.Point(81, 205)
        Me.hVarLabel.Name = "hVarLabel"
        Me.hVarLabel.Size = New System.Drawing.Size(27, 15)
        Me.hVarLabel.TabIndex = 26
        Me.hVarLabel.Text = "H ="
        '
        'bVariableInput
        '
        Me.bVariableInput.Location = New System.Drawing.Point(133, 140)
        Me.bVariableInput.Name = "bVariableInput"
        Me.bVariableInput.PlaceholderText = "Input number"
        Me.bVariableInput.Size = New System.Drawing.Size(100, 23)
        Me.bVariableInput.TabIndex = 25
        '
        'aVariableInput
        '
        Me.aVariableInput.Location = New System.Drawing.Point(133, 104)
        Me.aVariableInput.Name = "aVariableInput"
        Me.aVariableInput.PlaceholderText = "Input number"
        Me.aVariableInput.Size = New System.Drawing.Size(100, 23)
        Me.aVariableInput.TabIndex = 24
        '
        'bVariableLabel
        '
        Me.bVariableLabel.AutoSize = True
        Me.bVariableLabel.Location = New System.Drawing.Point(81, 143)
        Me.bVariableLabel.Name = "bVariableLabel"
        Me.bVariableLabel.Size = New System.Drawing.Size(25, 15)
        Me.bVariableLabel.TabIndex = 23
        Me.bVariableLabel.Text = "B ="
        '
        'aVarLabel
        '
        Me.aVarLabel.AutoSize = True
        Me.aVarLabel.Location = New System.Drawing.Point(81, 107)
        Me.aVarLabel.Name = "aVarLabel"
        Me.aVarLabel.Size = New System.Drawing.Size(26, 15)
        Me.aVarLabel.TabIndex = 22
        Me.aVarLabel.Text = "A ="
        '
        'Test2Task3Form
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
        Me.Name = "Test2Task3Form"
        Me.Text = "Test2Task3Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents yVars As ListBox
    Friend WithEvents solveBtn As Button
    Friend WithEvents xVars As ListBox
    Friend WithEvents hVarInput As TextBox
    Friend WithEvents hVarLabel As Label
    Friend WithEvents bVariableInput As TextBox
    Friend WithEvents aVariableInput As TextBox
    Friend WithEvents bVariableLabel As Label
    Friend WithEvents aVarLabel As Label
End Class
