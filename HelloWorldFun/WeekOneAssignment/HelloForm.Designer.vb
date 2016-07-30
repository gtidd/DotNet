<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HelloForm
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblHelloWorld = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(120, 92)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(146, 41)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "Go Back"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblHelloWorld
        '
        Me.lblHelloWorld.AutoSize = True
        Me.lblHelloWorld.Location = New System.Drawing.Point(165, 39)
        Me.lblHelloWorld.Name = "lblHelloWorld"
        Me.lblHelloWorld.Size = New System.Drawing.Size(62, 13)
        Me.lblHelloWorld.TabIndex = 1
        Me.lblHelloWorld.Text = "Hello World"
        '
        'HelloForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(390, 145)
        Me.Controls.Add(Me.lblHelloWorld)
        Me.Controls.Add(Me.btnExit)
        Me.Name = "HelloForm"
        Me.Text = "HelloForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Forms.Button
    Friend WithEvents lblHelloWorld As Forms.Label
End Class
