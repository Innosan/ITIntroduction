<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Test3Task3
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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader()
        Me.getSumBtn = New System.Windows.Forms.Button()
        Me.fillMatrixesBtn = New System.Windows.Forms.Button()
        Me.firstMatrixView = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader7 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader8 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader9 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader10 = New System.Windows.Forms.ColumnHeader()
        Me.secondMatrixView = New System.Windows.Forms.ListView()
        Me.ColumnHeader11 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader12 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader13 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader14 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader15 = New System.Windows.Forms.ColumnHeader()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(447, 34)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(306, 175)
        Me.ListView1.TabIndex = 1
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'getSumBtn
        '
        Me.getSumBtn.Location = New System.Drawing.Point(447, 255)
        Me.getSumBtn.Name = "getSumBtn"
        Me.getSumBtn.Size = New System.Drawing.Size(306, 44)
        Me.getSumBtn.TabIndex = 2
        Me.getSumBtn.Text = "Sum matrixes"
        Me.getSumBtn.UseVisualStyleBackColor = True
        '
        'fillMatrixesBtn
        '
        Me.fillMatrixesBtn.Location = New System.Drawing.Point(33, 491)
        Me.fillMatrixesBtn.Name = "fillMatrixesBtn"
        Me.fillMatrixesBtn.Size = New System.Drawing.Size(304, 44)
        Me.fillMatrixesBtn.TabIndex = 4
        Me.fillMatrixesBtn.Text = "Fill matrixes"
        Me.fillMatrixesBtn.UseVisualStyleBackColor = True
        '
        'firstMatrixView
        '
        Me.firstMatrixView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10})
        Me.firstMatrixView.FullRowSelect = True
        Me.firstMatrixView.GridLines = True
        Me.firstMatrixView.Location = New System.Drawing.Point(33, 34)
        Me.firstMatrixView.Name = "firstMatrixView"
        Me.firstMatrixView.Size = New System.Drawing.Size(304, 175)
        Me.firstMatrixView.TabIndex = 3
        Me.firstMatrixView.UseCompatibleStateImageBehavior = False
        Me.firstMatrixView.View = System.Windows.Forms.View.Details
        '
        'secondMatrixView
        '
        Me.secondMatrixView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15})
        Me.secondMatrixView.FullRowSelect = True
        Me.secondMatrixView.GridLines = True
        Me.secondMatrixView.Location = New System.Drawing.Point(33, 255)
        Me.secondMatrixView.Name = "secondMatrixView"
        Me.secondMatrixView.Size = New System.Drawing.Size(304, 175)
        Me.secondMatrixView.TabIndex = 5
        Me.secondMatrixView.UseCompatibleStateImageBehavior = False
        Me.secondMatrixView.View = System.Windows.Forms.View.Details
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "First matrix"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 227)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Second matrix"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(447, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Summed matrixes"
        '
        'Test3Task3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 558)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.secondMatrixView)
        Me.Controls.Add(Me.fillMatrixesBtn)
        Me.Controls.Add(Me.firstMatrixView)
        Me.Controls.Add(Me.getSumBtn)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "Test3Task3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Test3Task3"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents getSumBtn As Button
    Friend WithEvents fillMatrixesBtn As Button
    Friend WithEvents firstMatrixView As ListView
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents secondMatrixView As ListView
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents ColumnHeader15 As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
