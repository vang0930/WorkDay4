<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radResidentYes = New System.Windows.Forms.RadioButton()
        Me.radResidentNo = New System.Windows.Forms.RadioButton()
        Me.txtBirthDay = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.radBornYes = New System.Windows.Forms.RadioButton()
        Me.radBornNo = New System.Windows.Forms.RadioButton()
        Me.btnEligibility = New System.Windows.Forms.Button()
        Me.txtEligibleResult = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.radBornYes)
        Me.GroupBox1.Controls.Add(Me.radBornNo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 114)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Natural Born Citizen?"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radResidentYes)
        Me.GroupBox2.Controls.Add(Me.radResidentNo)
        Me.GroupBox2.Location = New System.Drawing.Point(218, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 114)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "14-year U.S. resident?"
        '
        'radResidentYes
        '
        Me.radResidentYes.AutoSize = True
        Me.radResidentYes.Checked = True
        Me.radResidentYes.Location = New System.Drawing.Point(74, 38)
        Me.radResidentYes.Name = "radResidentYes"
        Me.radResidentYes.Size = New System.Drawing.Size(53, 21)
        Me.radResidentYes.TabIndex = 3
        Me.radResidentYes.TabStop = True
        Me.radResidentYes.Text = "Yes"
        Me.radResidentYes.UseVisualStyleBackColor = True
        '
        'radResidentNo
        '
        Me.radResidentNo.AutoSize = True
        Me.radResidentNo.Location = New System.Drawing.Point(74, 65)
        Me.radResidentNo.Name = "radResidentNo"
        Me.radResidentNo.Size = New System.Drawing.Size(47, 21)
        Me.radResidentNo.TabIndex = 4
        Me.radResidentNo.TabStop = True
        Me.radResidentNo.Text = "No"
        Me.radResidentNo.UseVisualStyleBackColor = True
        '
        'txtBirthDay
        '
        Me.txtBirthDay.Location = New System.Drawing.Point(172, 148)
        Me.txtBirthDay.Name = "txtBirthDay"
        Me.txtBirthDay.Size = New System.Drawing.Size(100, 22)
        Me.txtBirthDay.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(79, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Date of Birth"
        '
        'radBornYes
        '
        Me.radBornYes.AutoSize = True
        Me.radBornYes.Checked = True
        Me.radBornYes.Location = New System.Drawing.Point(74, 38)
        Me.radBornYes.Name = "radBornYes"
        Me.radBornYes.Size = New System.Drawing.Size(53, 21)
        Me.radBornYes.TabIndex = 1
        Me.radBornYes.TabStop = True
        Me.radBornYes.Text = "Yes"
        Me.radBornYes.UseVisualStyleBackColor = True
        '
        'radBornNo
        '
        Me.radBornNo.AutoSize = True
        Me.radBornNo.Location = New System.Drawing.Point(74, 65)
        Me.radBornNo.Name = "radBornNo"
        Me.radBornNo.Size = New System.Drawing.Size(47, 21)
        Me.radBornNo.TabIndex = 2
        Me.radBornNo.TabStop = True
        Me.radBornNo.Text = "No"
        Me.radBornNo.UseVisualStyleBackColor = True
        '
        'btnEligibility
        '
        Me.btnEligibility.Location = New System.Drawing.Point(107, 223)
        Me.btnEligibility.Name = "btnEligibility"
        Me.btnEligibility.Size = New System.Drawing.Size(203, 47)
        Me.btnEligibility.TabIndex = 6
        Me.btnEligibility.Text = "Determine Eligibility to Run for President in 2016"
        Me.btnEligibility.UseVisualStyleBackColor = True
        '
        'txtEligibleResult
        '
        Me.txtEligibleResult.Location = New System.Drawing.Point(12, 307)
        Me.txtEligibleResult.Name = "txtEligibleResult"
        Me.txtEligibleResult.ReadOnly = True
        Me.txtEligibleResult.Size = New System.Drawing.Size(406, 22)
        Me.txtEligibleResult.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 183)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(348, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "The candidate must be 35 years old before 1/21/2017"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 362)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtEligibleResult)
        Me.Controls.Add(Me.btnEligibility)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBirthDay)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Presidential Eligibility"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents radResidentYes As System.Windows.Forms.RadioButton
    Friend WithEvents radResidentNo As System.Windows.Forms.RadioButton
    Friend WithEvents txtBirthDay As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents radBornYes As System.Windows.Forms.RadioButton
    Friend WithEvents radBornNo As System.Windows.Forms.RadioButton
    Friend WithEvents btnEligibility As System.Windows.Forms.Button
    Friend WithEvents txtEligibleResult As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label

End Class
