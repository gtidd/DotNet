<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Week4
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbCost = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbAppliances = New System.Windows.Forms.ComboBox()
        Me.tbPower = New System.Windows.Forms.TextBox()
        Me.tbHour = New System.Windows.Forms.TextBox()
        Me.CalculateButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NoGallonsTextBox = New System.Windows.Forms.TextBox()
        Me.CostGallonTextBox = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ExportButton = New System.Windows.Forms.Button()
        Me.btExit = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cost / kW-hour"
        '
        'tbCost
        '
        Me.tbCost.Location = New System.Drawing.Point(142, 53)
        Me.tbCost.Name = "tbCost"
        Me.tbCost.Size = New System.Drawing.Size(83, 20)
        Me.tbCost.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Home Appliances"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Power Rating in kW"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 124)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Hours Used / Day"
        '
        'cbAppliances
        '
        Me.cbAppliances.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbAppliances.FormattingEnabled = True
        Me.cbAppliances.Location = New System.Drawing.Point(142, 19)
        Me.cbAppliances.Name = "cbAppliances"
        Me.cbAppliances.Size = New System.Drawing.Size(156, 21)
        Me.cbAppliances.TabIndex = 5
        '
        'tbPower
        '
        Me.tbPower.Location = New System.Drawing.Point(142, 87)
        Me.tbPower.Name = "tbPower"
        Me.tbPower.Size = New System.Drawing.Size(83, 20)
        Me.tbPower.TabIndex = 6
        '
        'tbHour
        '
        Me.tbHour.Location = New System.Drawing.Point(142, 121)
        Me.tbHour.Name = "tbHour"
        Me.tbHour.Size = New System.Drawing.Size(83, 20)
        Me.tbHour.TabIndex = 7
        '
        'CalculateButton
        '
        Me.CalculateButton.Location = New System.Drawing.Point(273, 229)
        Me.CalculateButton.Name = "CalculateButton"
        Me.CalculateButton.Size = New System.Drawing.Size(215, 28)
        Me.CalculateButton.TabIndex = 9
        Me.CalculateButton.Text = "Calculate"
        Me.CalculateButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(33, 229)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(206, 28)
        Me.ClearButton.TabIndex = 10
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "No of Gallons"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(30, 191)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Cost Per Gallon"
        '
        'NoGallonsTextBox
        '
        Me.NoGallonsTextBox.Enabled = False
        Me.NoGallonsTextBox.Location = New System.Drawing.Point(142, 155)
        Me.NoGallonsTextBox.Name = "NoGallonsTextBox"
        Me.NoGallonsTextBox.Size = New System.Drawing.Size(83, 20)
        Me.NoGallonsTextBox.TabIndex = 13
        Me.NoGallonsTextBox.TabStop = False
        '
        'CostGallonTextBox
        '
        Me.CostGallonTextBox.Enabled = False
        Me.CostGallonTextBox.Location = New System.Drawing.Point(141, 188)
        Me.CostGallonTextBox.Name = "CostGallonTextBox"
        Me.CostGallonTextBox.Size = New System.Drawing.Size(84, 20)
        Me.CostGallonTextBox.TabIndex = 14
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.Location = New System.Drawing.Point(389, 41)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.RowTemplate.Height = 16
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.ShowCellErrors = False
        Me.DataGridView1.ShowCellToolTips = False
        Me.DataGridView1.ShowEditingIcon = False
        Me.DataGridView1.ShowRowErrors = False
        Me.DataGridView1.Size = New System.Drawing.Size(351, 147)
        Me.DataGridView1.TabIndex = 16
        '
        'Column1
        '
        Me.Column1.HeaderText = "Home Appliance"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "Number of hours per day"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "Cost"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'TotalTextBox
        '
        Me.TotalTextBox.Enabled = False
        Me.TotalTextBox.Location = New System.Drawing.Point(315, 188)
        Me.TotalTextBox.Name = "TotalTextBox"
        Me.TotalTextBox.Size = New System.Drawing.Size(68, 20)
        Me.TotalTextBox.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(254, 191)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Total Cost"
        '
        'ExportButton
        '
        Me.ExportButton.Location = New System.Drawing.Point(522, 229)
        Me.ExportButton.Name = "ExportButton"
        Me.ExportButton.Size = New System.Drawing.Size(196, 28)
        Me.ExportButton.TabIndex = 19
        Me.ExportButton.Text = "Export"
        Me.ExportButton.UseVisualStyleBackColor = True
        '
        'btExit
        '
        Me.btExit.Location = New System.Drawing.Point(273, 291)
        Me.btExit.Name = "btExit"
        Me.btExit.Size = New System.Drawing.Size(215, 28)
        Me.btExit.TabIndex = 20
        Me.btExit.Text = "Exit"
        Me.btExit.UseVisualStyleBackColor = True
        '
        'Week4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 373)
        Me.Controls.Add(Me.btExit)
        Me.Controls.Add(Me.ExportButton)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TotalTextBox)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.CostGallonTextBox)
        Me.Controls.Add(Me.NoGallonsTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.CalculateButton)
        Me.Controls.Add(Me.tbHour)
        Me.Controls.Add(Me.tbPower)
        Me.Controls.Add(Me.cbAppliances)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbCost)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Week4"
        Me.Text = "Home Utility Auditing Program"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbCost As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cbAppliances As System.Windows.Forms.ComboBox
    Friend WithEvents tbPower As System.Windows.Forms.TextBox
    Friend WithEvents tbHour As System.Windows.Forms.TextBox
    Friend WithEvents CalculateButton As System.Windows.Forms.Button
    Friend WithEvents ClearButton As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents NoGallonsTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CostGallonTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TotalTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ExportButton As System.Windows.Forms.Button
    Friend WithEvents btExit As Button
End Class
