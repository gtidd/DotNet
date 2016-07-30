<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fun
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
        Me.btnStrobe = New System.Windows.Forms.Button()
        Me.btnColor = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnLanguage = New System.Windows.Forms.Button()
        Me.btnLeapFrog = New System.Windows.Forms.Button()
        Me.lblHello = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnStrobe
        '
        Me.btnStrobe.Location = New System.Drawing.Point(32, 12)
        Me.btnStrobe.Name = "btnStrobe"
        Me.btnStrobe.Size = New System.Drawing.Size(200, 50)
        Me.btnStrobe.TabIndex = 0
        Me.btnStrobe.Text = "Strobe Click Fast"
        Me.btnStrobe.UseVisualStyleBackColor = True
        '
        'btnColor
        '
        Me.btnColor.Location = New System.Drawing.Point(32, 81)
        Me.btnColor.Name = "btnColor"
        Me.btnColor.Size = New System.Drawing.Size(200, 50)
        Me.btnColor.TabIndex = 1
        Me.btnColor.Text = "Color"
        Me.btnColor.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(32, 157)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(200, 50)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Back to Start"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnLanguage
        '
        Me.btnLanguage.Location = New System.Drawing.Point(32, 230)
        Me.btnLanguage.Name = "btnLanguage"
        Me.btnLanguage.Size = New System.Drawing.Size(200, 50)
        Me.btnLanguage.TabIndex = 3
        Me.btnLanguage.Text = "Multi Language"
        Me.btnLanguage.UseVisualStyleBackColor = True
        '
        'btnLeapFrog
        '
        Me.btnLeapFrog.Location = New System.Drawing.Point(32, 300)
        Me.btnLeapFrog.Name = "btnLeapFrog"
        Me.btnLeapFrog.Size = New System.Drawing.Size(200, 50)
        Me.btnLeapFrog.TabIndex = 4
        Me.btnLeapFrog.Text = "Jump Around"
        Me.btnLeapFrog.UseVisualStyleBackColor = True
        '
        'lblHello
        '
        Me.lblHello.AutoSize = True
        Me.lblHello.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHello.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblHello.Location = New System.Drawing.Point(393, 161)
        Me.lblHello.Name = "lblHello"
        Me.lblHello.Size = New System.Drawing.Size(153, 31)
        Me.lblHello.TabIndex = 5
        Me.lblHello.Text = "Hello World"
        '
        'Fun
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 375)
        Me.Controls.Add(Me.lblHello)
        Me.Controls.Add(Me.btnLeapFrog)
        Me.Controls.Add(Me.btnLanguage)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnColor)
        Me.Controls.Add(Me.btnStrobe)
        Me.Name = "Fun"
        Me.Text = "Fun"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStrobe As Forms.Button
    Friend WithEvents btnColor As Forms.Button
    Friend WithEvents btnExit As Forms.Button
    Friend WithEvents btnLanguage As Forms.Button
    Friend WithEvents btnLeapFrog As Forms.Button
    Friend WithEvents lblHello As Forms.Label
End Class
