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
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.comSubject = New System.Windows.Forms.ComboBox()
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.comPeriod = New System.Windows.Forms.ComboBox()
        Me.lblPeriod = New System.Windows.Forms.Label()
        Me.comBus1 = New System.Windows.Forms.ComboBox()
        Me.lblBus1 = New System.Windows.Forms.Label()
        Me.lblWarning = New System.Windows.Forms.Label()
        Me.lblExplained = New System.Windows.Forms.Label()
        Me.comBus2 = New System.Windows.Forms.ComboBox()
        Me.lblBus2 = New System.Windows.Forms.Label()
        Me.lblSubjectExplained = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(425, 114)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(197, 23)
        Me.txtFirstName.TabIndex = 0
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(425, 160)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(197, 23)
        Me.txtLastName.TabIndex = 1
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(355, 117)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(64, 15)
        Me.lblFirstName.TabIndex = 2
        Me.lblFirstName.Text = "First Name"
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(356, 163)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(63, 15)
        Me.lblLastName.TabIndex = 3
        Me.lblLastName.Text = "Last Name"
        '
        'comSubject
        '
        Me.comSubject.FormattingEnabled = True
        Me.comSubject.Items.AddRange(New Object() {"Algebra 2", "Geometry", "Calculus", "Pre-Calc", "Trigonomotry", "English Comp 1", "English Comp 2", "Study Hall", "U.S. History", "Geography"})
        Me.comSubject.Location = New System.Drawing.Point(425, 206)
        Me.comSubject.Name = "comSubject"
        Me.comSubject.Size = New System.Drawing.Size(197, 23)
        Me.comSubject.TabIndex = 5
        '
        'lblSubject
        '
        Me.lblSubject.AutoSize = True
        Me.lblSubject.Location = New System.Drawing.Point(373, 209)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(46, 15)
        Me.lblSubject.TabIndex = 6
        Me.lblSubject.Text = "Subject"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblTitle.Location = New System.Drawing.Point(536, 42)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(342, 37)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "Field Trip Bus Sign Up Form"
        '
        'comPeriod
        '
        Me.comPeriod.FormattingEnabled = True
        Me.comPeriod.Items.AddRange(New Object() {"1st", "2nd", "3rd", "4th", "5th", "6th", "7th"})
        Me.comPeriod.Location = New System.Drawing.Point(787, 114)
        Me.comPeriod.Name = "comPeriod"
        Me.comPeriod.Size = New System.Drawing.Size(171, 23)
        Me.comPeriod.TabIndex = 8
        '
        'lblPeriod
        '
        Me.lblPeriod.AutoSize = True
        Me.lblPeriod.Location = New System.Drawing.Point(740, 117)
        Me.lblPeriod.Name = "lblPeriod"
        Me.lblPeriod.Size = New System.Drawing.Size(41, 15)
        Me.lblPeriod.TabIndex = 9
        Me.lblPeriod.Text = "Period"
        '
        'comBus1
        '
        Me.comBus1.FormattingEnabled = True
        Me.comBus1.Items.AddRange(New Object() {"Bus 1", "Bus 2", "Bus 3", "Bus 4", "Bus 5", "Bus 6"})
        Me.comBus1.Location = New System.Drawing.Point(787, 159)
        Me.comBus1.Name = "comBus1"
        Me.comBus1.Size = New System.Drawing.Size(171, 23)
        Me.comBus1.TabIndex = 10
        '
        'lblBus1
        '
        Me.lblBus1.AutoSize = True
        Me.lblBus1.Location = New System.Drawing.Point(687, 162)
        Me.lblBus1.Name = "lblBus1"
        Me.lblBus1.Size = New System.Drawing.Size(94, 15)
        Me.lblBus1.TabIndex = 11
        Me.lblBus1.Text = "Bus: First Choice"
        '
        'lblWarning
        '
        Me.lblWarning.AutoSize = True
        Me.lblWarning.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblWarning.Location = New System.Drawing.Point(787, 271)
        Me.lblWarning.Name = "lblWarning"
        Me.lblWarning.Size = New System.Drawing.Size(437, 30)
        Me.lblWarning.TabIndex = 12
        Me.lblWarning.Text = "Remember: Busses are first come, first served!"
        '
        'lblExplained
        '
        Me.lblExplained.AutoSize = True
        Me.lblExplained.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblExplained.Location = New System.Drawing.Point(772, 320)
        Me.lblExplained.Name = "lblExplained"
        Me.lblExplained.Size = New System.Drawing.Size(487, 21)
        Me.lblExplained.TabIndex = 13
        Me.lblExplained.Text = "If the busses you choose are full, you will be assigned one at random."
        '
        'comBus2
        '
        Me.comBus2.FormattingEnabled = True
        Me.comBus2.Items.AddRange(New Object() {"Bus 1", "Bus 2", "Bus 3", "Bus 4", "Bus 5", "Bus 6"})
        Me.comBus2.Location = New System.Drawing.Point(787, 206)
        Me.comBus2.Name = "comBus2"
        Me.comBus2.Size = New System.Drawing.Size(171, 23)
        Me.comBus2.TabIndex = 14
        '
        'lblBus2
        '
        Me.lblBus2.AutoSize = True
        Me.lblBus2.Location = New System.Drawing.Point(670, 209)
        Me.lblBus2.Name = "lblBus2"
        Me.lblBus2.Size = New System.Drawing.Size(111, 15)
        Me.lblBus2.TabIndex = 15
        Me.lblBus2.Text = "Bus: Second Choice"
        '
        'lblSubjectExplained
        '
        Me.lblSubjectExplained.AutoSize = True
        Me.lblSubjectExplained.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblSubjectExplained.Location = New System.Drawing.Point(300, 291)
        Me.lblSubjectExplained.Name = "lblSubjectExplained"
        Me.lblSubjectExplained.Size = New System.Drawing.Size(322, 50)
        Me.lblSubjectExplained.TabIndex = 16
        Me.lblSubjectExplained.Text = "Please enter the period you will be " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "absent and the subject of that period"
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.Lime
        Me.btnSubmit.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSubmit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSubmit.Location = New System.Drawing.Point(558, 449)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(253, 143)
        Me.btnSubmit.TabIndex = 17
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1391, 793)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.lblSubjectExplained)
        Me.Controls.Add(Me.lblBus2)
        Me.Controls.Add(Me.comBus2)
        Me.Controls.Add(Me.lblExplained)
        Me.Controls.Add(Me.lblWarning)
        Me.Controls.Add(Me.lblBus1)
        Me.Controls.Add(Me.comBus1)
        Me.Controls.Add(Me.lblPeriod)
        Me.Controls.Add(Me.comPeriod)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblSubject)
        Me.Controls.Add(Me.comSubject)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents comSubject As ComboBox
    Friend WithEvents lblSubject As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents comPeriod As ComboBox
    Friend WithEvents lblPeriod As Label
    Friend WithEvents comBus1 As ComboBox
    Friend WithEvents lblBus1 As Label
    Friend WithEvents lblWarning As Label
    Friend WithEvents lblExplained As Label
    Friend WithEvents comBus2 As ComboBox
    Friend WithEvents lblBus2 As Label
    Friend WithEvents lblSubjectExplained As Label
    Friend WithEvents btnSubmit As Button
End Class
