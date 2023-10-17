<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Test3Task2
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
        Me.randomListBox = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.shiftedListBox = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.fillArrayBtn = New System.Windows.Forms.Button()
        Me.shiftArrayBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'randomListBox
        '
        Me.randomListBox.FormattingEnabled = True
        Me.randomListBox.ItemHeight = 15
        Me.randomListBox.Location = New System.Drawing.Point(96, 73)
        Me.randomListBox.Name = "randomListBox"
        Me.randomListBox.Size = New System.Drawing.Size(120, 214)
        Me.randomListBox.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(96, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Random list"
        '
        'shiftedListBox
        '
        Me.shiftedListBox.FormattingEnabled = True
        Me.shiftedListBox.ItemHeight = 15
        Me.shiftedListBox.Location = New System.Drawing.Point(369, 73)
        Me.shiftedListBox.Name = "shiftedListBox"
        Me.shiftedListBox.Size = New System.Drawing.Size(120, 214)
        Me.shiftedListBox.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(369, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Shifted list"
        '
        'fillArrayBtn
        '
        Me.fillArrayBtn.BackColor = System.Drawing.SystemColors.HotTrack
        Me.fillArrayBtn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.fillArrayBtn.Location = New System.Drawing.Point(96, 335)
        Me.fillArrayBtn.Name = "fillArrayBtn"
        Me.fillArrayBtn.Size = New System.Drawing.Size(120, 23)
        Me.fillArrayBtn.TabIndex = 2
        Me.fillArrayBtn.Text = "Fill array"
        Me.fillArrayBtn.UseVisualStyleBackColor = False
        '
        'shiftArrayBtn
        '
        Me.shiftArrayBtn.BackColor = System.Drawing.Color.SeaGreen
        Me.shiftArrayBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.shiftArrayBtn.Location = New System.Drawing.Point(369, 335)
        Me.shiftArrayBtn.Name = "shiftArrayBtn"
        Me.shiftArrayBtn.Size = New System.Drawing.Size(120, 23)
        Me.shiftArrayBtn.TabIndex = 2
        Me.shiftArrayBtn.Text = "Shift array"
        Me.shiftArrayBtn.UseVisualStyleBackColor = False
        '
        'Test3Task2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.shiftArrayBtn)
        Me.Controls.Add(Me.fillArrayBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.shiftedListBox)
        Me.Controls.Add(Me.randomListBox)
        Me.Name = "Test3Task2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Test3Task2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents randomListBox As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents shiftedListBox As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents fillArrayBtn As Button
    Friend WithEvents shiftArrayBtn As Button
End Class
