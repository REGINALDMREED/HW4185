<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmExercise
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.lblBirthDate = New System.Windows.Forms.Label()
        Me.lblBDDate = New System.Windows.Forms.Label()
        Me.lblBDMonth = New System.Windows.Forms.Label()
        Me.lblBDYear = New System.Windows.Forms.Label()
        Me.txtBDDay = New System.Windows.Forms.TextBox()
        Me.txtBDMonth = New System.Windows.Forms.TextBox()
        Me.txtBDYear = New System.Windows.Forms.TextBox()
        Me.txtCDDay = New System.Windows.Forms.TextBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblDisplayHours = New System.Windows.Forms.Label()
        Me.lblDisplayName = New System.Windows.Forms.Label()
        Me.lblNHours = New System.Windows.Forms.Label()
        Me.lblCurrentDate = New System.Windows.Forms.Label()
        Me.lblCDDate = New System.Windows.Forms.Label()
        Me.lblCDMonth = New System.Windows.Forms.Label()
        Me.txtCDMonth = New System.Windows.Forms.TextBox()
        Me.lblCDYear = New System.Windows.Forms.Label()
        Me.txtCDYear = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Location = New System.Drawing.Point(91, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(126, 13)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Calculate Workout Hours"
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(37, 45)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(57, 13)
        Me.lblFirstName.TabIndex = 1
        Me.lblFirstName.Text = "First Name"
        '
        'txtFirst
        '
        Me.txtFirst.Location = New System.Drawing.Point(105, 38)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(100, 20)
        Me.txtFirst.TabIndex = 2
        '
        'lblBirthDate
        '
        Me.lblBirthDate.AutoSize = True
        Me.lblBirthDate.Location = New System.Drawing.Point(47, 68)
        Me.lblBirthDate.Name = "lblBirthDate"
        Me.lblBirthDate.Size = New System.Drawing.Size(51, 13)
        Me.lblBirthDate.TabIndex = 3
        Me.lblBirthDate.Text = "BirthDate"
        '
        'lblBDDate
        '
        Me.lblBDDate.AutoSize = True
        Me.lblBDDate.Location = New System.Drawing.Point(44, 90)
        Me.lblBDDate.Name = "lblBDDate"
        Me.lblBDDate.Size = New System.Drawing.Size(30, 13)
        Me.lblBDDate.TabIndex = 4
        Me.lblBDDate.Text = "Date"
        '
        'lblBDMonth
        '
        Me.lblBDMonth.AutoSize = True
        Me.lblBDMonth.Location = New System.Drawing.Point(44, 122)
        Me.lblBDMonth.Name = "lblBDMonth"
        Me.lblBDMonth.Size = New System.Drawing.Size(37, 13)
        Me.lblBDMonth.TabIndex = 5
        Me.lblBDMonth.Text = "Month"
        '
        'lblBDYear
        '
        Me.lblBDYear.AutoSize = True
        Me.lblBDYear.Location = New System.Drawing.Point(52, 168)
        Me.lblBDYear.Name = "lblBDYear"
        Me.lblBDYear.Size = New System.Drawing.Size(29, 13)
        Me.lblBDYear.TabIndex = 6
        Me.lblBDYear.Text = "Year"
        '
        'txtBDDay
        '
        Me.txtBDDay.Location = New System.Drawing.Point(105, 83)
        Me.txtBDDay.Name = "txtBDDay"
        Me.txtBDDay.Size = New System.Drawing.Size(100, 20)
        Me.txtBDDay.TabIndex = 7
        '
        'txtBDMonth
        '
        Me.txtBDMonth.Location = New System.Drawing.Point(105, 115)
        Me.txtBDMonth.Name = "txtBDMonth"
        Me.txtBDMonth.Size = New System.Drawing.Size(100, 20)
        Me.txtBDMonth.TabIndex = 8
        '
        'txtBDYear
        '
        Me.txtBDYear.Location = New System.Drawing.Point(105, 161)
        Me.txtBDYear.Name = "txtBDYear"
        Me.txtBDYear.Size = New System.Drawing.Size(100, 20)
        Me.txtBDYear.TabIndex = 9
        '
        'txtCDDay
        '
        Me.txtCDDay.Location = New System.Drawing.Point(105, 231)
        Me.txtCDDay.Name = "txtCDDay"
        Me.txtCDDay.Size = New System.Drawing.Size(100, 20)
        Me.txtCDDay.TabIndex = 10
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(34, 394)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 11
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(166, 394)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(271, 394)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(37, 445)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 14
        Me.lblName.Text = "Name"
        '
        'lblDisplayHours
        '
        Me.lblDisplayHours.AutoSize = True
        Me.lblDisplayHours.Location = New System.Drawing.Point(31, 494)
        Me.lblDisplayHours.Name = "lblDisplayHours"
        Me.lblDisplayHours.Size = New System.Drawing.Size(149, 13)
        Me.lblDisplayHours.TabIndex = 15
        Me.lblDisplayHours.Text = "Number of hours excercised is"
        '
        'lblDisplayName
        '
        Me.lblDisplayName.AutoSize = True
        Me.lblDisplayName.Location = New System.Drawing.Point(285, 445)
        Me.lblDisplayName.Name = "lblDisplayName"
        Me.lblDisplayName.Size = New System.Drawing.Size(39, 13)
        Me.lblDisplayName.TabIndex = 16
        Me.lblDisplayName.Text = "Label2"
        '
        'lblNHours
        '
        Me.lblNHours.AutoSize = True
        Me.lblNHours.Location = New System.Drawing.Point(285, 494)
        Me.lblNHours.Name = "lblNHours"
        Me.lblNHours.Size = New System.Drawing.Size(39, 13)
        Me.lblNHours.TabIndex = 17
        Me.lblNHours.Text = "Label1"
        '
        'lblCurrentDate
        '
        Me.lblCurrentDate.AutoSize = True
        Me.lblCurrentDate.Location = New System.Drawing.Point(44, 201)
        Me.lblCurrentDate.Name = "lblCurrentDate"
        Me.lblCurrentDate.Size = New System.Drawing.Size(67, 13)
        Me.lblCurrentDate.TabIndex = 18
        Me.lblCurrentDate.Text = "Current Date"
        '
        'lblCDDate
        '
        Me.lblCDDate.AutoSize = True
        Me.lblCDDate.Location = New System.Drawing.Point(47, 237)
        Me.lblCDDate.Name = "lblCDDate"
        Me.lblCDDate.Size = New System.Drawing.Size(30, 13)
        Me.lblCDDate.TabIndex = 19
        Me.lblCDDate.Text = "Date"
        '
        'lblCDMonth
        '
        Me.lblCDMonth.AutoSize = True
        Me.lblCDMonth.Location = New System.Drawing.Point(44, 277)
        Me.lblCDMonth.Name = "lblCDMonth"
        Me.lblCDMonth.Size = New System.Drawing.Size(37, 13)
        Me.lblCDMonth.TabIndex = 20
        Me.lblCDMonth.Text = "Month"
        '
        'txtCDMonth
        '
        Me.txtCDMonth.Location = New System.Drawing.Point(105, 277)
        Me.txtCDMonth.Name = "txtCDMonth"
        Me.txtCDMonth.Size = New System.Drawing.Size(100, 20)
        Me.txtCDMonth.TabIndex = 21
        '
        'lblCDYear
        '
        Me.lblCDYear.AutoSize = True
        Me.lblCDYear.Location = New System.Drawing.Point(44, 314)
        Me.lblCDYear.Name = "lblCDYear"
        Me.lblCDYear.Size = New System.Drawing.Size(29, 13)
        Me.lblCDYear.TabIndex = 22
        Me.lblCDYear.Text = "Year"
        '
        'txtCDYear
        '
        Me.txtCDYear.Location = New System.Drawing.Point(105, 314)
        Me.txtCDYear.Name = "txtCDYear"
        Me.txtCDYear.Size = New System.Drawing.Size(100, 20)
        Me.txtCDYear.TabIndex = 23
        '
        'FrmExercise
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(372, 532)
        Me.Controls.Add(Me.txtCDYear)
        Me.Controls.Add(Me.lblCDYear)
        Me.Controls.Add(Me.txtCDMonth)
        Me.Controls.Add(Me.lblCDMonth)
        Me.Controls.Add(Me.lblCDDate)
        Me.Controls.Add(Me.lblCurrentDate)
        Me.Controls.Add(Me.lblNHours)
        Me.Controls.Add(Me.lblDisplayName)
        Me.Controls.Add(Me.lblDisplayHours)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtCDDay)
        Me.Controls.Add(Me.txtBDYear)
        Me.Controls.Add(Me.txtBDMonth)
        Me.Controls.Add(Me.txtBDDay)
        Me.Controls.Add(Me.lblBDYear)
        Me.Controls.Add(Me.lblBDMonth)
        Me.Controls.Add(Me.lblBDDate)
        Me.Controls.Add(Me.lblBirthDate)
        Me.Controls.Add(Me.txtFirst)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "FrmExercise"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtFirst As TextBox
    Friend WithEvents lblBirthDate As Label
    Friend WithEvents lblBDDate As Label
    Friend WithEvents lblBDMonth As Label
    Friend WithEvents lblBDYear As Label
    Friend WithEvents txtBDDay As TextBox
    Friend WithEvents txtBDMonth As TextBox
    Friend WithEvents txtBDYear As TextBox
    Friend WithEvents txtCDDay As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblName As Label
    Friend WithEvents lblDisplayHours As Label
    Friend WithEvents lblDisplayName As Label
    Friend WithEvents lblNHours As Label
    Friend WithEvents lblCurrentDate As Label
    Friend WithEvents lblCDDate As Label
    Friend WithEvents lblCDMonth As Label
    Friend WithEvents txtCDMonth As TextBox
    Friend WithEvents lblCDYear As Label
    Friend WithEvents txtCDYear As TextBox
End Class
