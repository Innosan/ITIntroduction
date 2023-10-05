<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.xLabel = New System.Windows.Forms.Label()
        Me.answerLabel = New System.Windows.Forms.Label()
        Me.xInputBox = New System.Windows.Forms.TextBox()
        Me.solveBtn = New System.Windows.Forms.Button()
        Me.answerLabel1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'xLabel
        '
        Me.xLabel.AutoSize = True
        Me.xLabel.Location = New System.Drawing.Point(123, 79)
        Me.xLabel.Name = "xLabel"
        Me.xLabel.Size = New System.Drawing.Size(25, 15)
        Me.xLabel.TabIndex = 0
        Me.xLabel.Text = "X ="
        '
        'answerLabel
        '
        Me.answerLabel.AutoSize = True
        Me.answerLabel.Location = New System.Drawing.Point(123, 129)
        Me.answerLabel.Name = "answerLabel"
        Me.answerLabel.Size = New System.Drawing.Size(25, 15)
        Me.answerLabel.TabIndex = 1
        Me.answerLabel.Text = "Y ="
        '
        'xInputBox
        '
        Me.xInputBox.Location = New System.Drawing.Point(163, 76)
        Me.xInputBox.Name = "xInputBox"
        Me.xInputBox.PlaceholderText = "Input X"
        Me.xInputBox.Size = New System.Drawing.Size(100, 23)
        Me.xInputBox.TabIndex = 2
        '
        'solveBtn
        '
        Me.solveBtn.Location = New System.Drawing.Point(279, 311)
        Me.solveBtn.Name = "solveBtn"
        Me.solveBtn.Size = New System.Drawing.Size(239, 84)
        Me.solveBtn.TabIndex = 3
        Me.solveBtn.Text = "Solve"
        Me.solveBtn.UseVisualStyleBackColor = True
        '
        'answerLabel1
        '
        Me.answerLabel1.AutoSize = True
        Me.answerLabel1.Location = New System.Drawing.Point(163, 129)
        Me.answerLabel1.Name = "answerLabel1"
        Me.answerLabel1.Size = New System.Drawing.Size(10, 15)
        Me.answerLabel1.TabIndex = 4
        Me.answerLabel1.Text = " "
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.answerLabel1)
        Me.Controls.Add(Me.solveBtn)
        Me.Controls.Add(Me.xInputBox)
        Me.Controls.Add(Me.answerLabel)
        Me.Controls.Add(Me.xLabel)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents xLabel As Label
    Friend WithEvents answerLabel As Label
    Friend WithEvents xInputBox As TextBox
    Friend WithEvents solveBtn As Button
    Friend WithEvents answerLabel1 As Label
End Class
