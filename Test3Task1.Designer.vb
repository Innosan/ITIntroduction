<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Test3Task1
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
        Me.solveBtn = New System.Windows.Forms.Button()
        Me.xVariableInput = New System.Windows.Forms.TextBox()
        Me.xVarLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.sumLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'solveBtn
        '
        Me.solveBtn.Location = New System.Drawing.Point(376, 348)
        Me.solveBtn.Name = "solveBtn"
        Me.solveBtn.Size = New System.Drawing.Size(75, 23)
        Me.solveBtn.TabIndex = 33
        Me.solveBtn.Text = "Solve"
        Me.solveBtn.UseVisualStyleBackColor = True
        '
        'xVariableInput
        '
        Me.xVariableInput.Location = New System.Drawing.Point(209, 104)
        Me.xVariableInput.Name = "xVariableInput"
        Me.xVariableInput.PlaceholderText = "Input number"
        Me.xVariableInput.Size = New System.Drawing.Size(100, 23)
        Me.xVariableInput.TabIndex = 31
        '
        'xVarLabel
        '
        Me.xVarLabel.AutoSize = True
        Me.xVarLabel.Location = New System.Drawing.Point(157, 107)
        Me.xVarLabel.Name = "xVarLabel"
        Me.xVarLabel.Size = New System.Drawing.Size(25, 15)
        Me.xVarLabel.TabIndex = 30
        Me.xVarLabel.Text = "X ="
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(157, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 15)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Sum ="
        '
        'sumLabel
        '
        Me.sumLabel.AutoSize = True
        Me.sumLabel.Location = New System.Drawing.Point(209, 154)
        Me.sumLabel.Name = "sumLabel"
        Me.sumLabel.Size = New System.Drawing.Size(10, 15)
        Me.sumLabel.TabIndex = 35
        Me.sumLabel.Text = " "
        '
        'Test3Task1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.sumLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.solveBtn)
        Me.Controls.Add(Me.xVariableInput)
        Me.Controls.Add(Me.xVarLabel)
        Me.Name = "Test3Task1"
        Me.Text = "Test3Task1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents solveBtn As Button
    Friend WithEvents xVariableInput As TextBox
    Friend WithEvents xVarLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents sumLabel As Label
End Class
