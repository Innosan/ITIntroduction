<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.aVarLabel = New System.Windows.Forms.Label()
        Me.bVariableLabel = New System.Windows.Forms.Label()
        Me.aVariableInput = New System.Windows.Forms.TextBox()
        Me.bVariableInput = New System.Windows.Forms.TextBox()
        Me.answerLabel = New System.Windows.Forms.Label()
        Me.answerLabel1 = New System.Windows.Forms.Label()
        Me.solveMathBtn = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'aVarLabel
        '
        Me.aVarLabel.AutoSize = True
        Me.aVarLabel.Location = New System.Drawing.Point(122, 98)
        Me.aVarLabel.Name = "aVarLabel"
        Me.aVarLabel.Size = New System.Drawing.Size(26, 15)
        Me.aVarLabel.TabIndex = 0
        Me.aVarLabel.Text = "A ="
        '
        'bVariableLabel
        '
        Me.bVariableLabel.AutoSize = True
        Me.bVariableLabel.Location = New System.Drawing.Point(122, 134)
        Me.bVariableLabel.Name = "bVariableLabel"
        Me.bVariableLabel.Size = New System.Drawing.Size(25, 15)
        Me.bVariableLabel.TabIndex = 1
        Me.bVariableLabel.Text = "B ="
        '
        'aVariableInput
        '
        Me.aVariableInput.Location = New System.Drawing.Point(174, 95)
        Me.aVariableInput.Name = "aVariableInput"
        Me.aVariableInput.PlaceholderText = "Input number"
        Me.aVariableInput.Size = New System.Drawing.Size(100, 23)
        Me.aVariableInput.TabIndex = 2
        '
        'bVariableInput
        '
        Me.bVariableInput.Location = New System.Drawing.Point(174, 131)
        Me.bVariableInput.Name = "bVariableInput"
        Me.bVariableInput.PlaceholderText = "Input number"
        Me.bVariableInput.Size = New System.Drawing.Size(100, 23)
        Me.bVariableInput.TabIndex = 3
        '
        'answerLabel
        '
        Me.answerLabel.AutoSize = True
        Me.answerLabel.Location = New System.Drawing.Point(122, 204)
        Me.answerLabel.Name = "answerLabel"
        Me.answerLabel.Size = New System.Drawing.Size(24, 15)
        Me.answerLabel.TabIndex = 4
        Me.answerLabel.Text = "F ="
        '
        'answerLabel1
        '
        Me.answerLabel1.AutoSize = True
        Me.answerLabel1.Location = New System.Drawing.Point(174, 204)
        Me.answerLabel1.Name = "answerLabel1"
        Me.answerLabel1.Size = New System.Drawing.Size(10, 15)
        Me.answerLabel1.TabIndex = 5
        Me.answerLabel1.Text = " "
        '
        'solveMathBtn
        '
        Me.solveMathBtn.Location = New System.Drawing.Point(282, 377)
        Me.solveMathBtn.Name = "solveMathBtn"
        Me.solveMathBtn.Size = New System.Drawing.Size(240, 34)
        Me.solveMathBtn.TabIndex = 6
        Me.solveMathBtn.Text = "Solve"
        Me.solveMathBtn.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.exitButton.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.exitButton.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.exitButton.Location = New System.Drawing.Point(571, 377)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(94, 34)
        Me.exitButton.TabIndex = 7
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.solveMathBtn)
        Me.Controls.Add(Me.answerLabel1)
        Me.Controls.Add(Me.answerLabel)
        Me.Controls.Add(Me.bVariableInput)
        Me.Controls.Add(Me.aVariableInput)
        Me.Controls.Add(Me.bVariableLabel)
        Me.Controls.Add(Me.aVarLabel)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents aVarLabel As Label
    Friend WithEvents bVariableLabel As Label
    Friend WithEvents aVariableInput As TextBox
    Friend WithEvents bVariableInput As TextBox
    Friend WithEvents answerLabel As Label
    Friend WithEvents answerLabel1 As Label
    Friend WithEvents solveMathBtn As Button
    Friend WithEvents exitButton As Button
End Class
