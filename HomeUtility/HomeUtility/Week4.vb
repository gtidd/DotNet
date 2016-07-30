'Greg Tidd
'10/22/15
'Week 4 Individual Tim Hagen POS/408

'I rebuilt my whole program while in the hospital recovering from surgery I felt this looked cleaner and 
'was plaaned out better. Previously I just tried to build it without planning left too many mistakes.


Imports System.IO

Public Class Week4

    Dim totalCost As Decimal = 0



    Private Sub cbAppliances_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbAppliances.SelectedValueChanged

        Dim appliance As String

        ' Get value entered by the user
        appliance = cbAppliances.Text

        Dim powerArray(20, 1) As String, y As Integer = 0, x As Integer = 0
        Dim fullpath = "power.txt"

        ' Read Power rating from file
        Using sr As StreamReader = New StreamReader(fullpath)
            Do While sr.Peek() >= 0
                For Each c As String In sr.ReadToEnd().Split(CType(Chr(10), Char))
                    For Each d As String In c.Split(" ")
                        If y = 2 Then
                            x += 1
                            y = 0
                        End If
                        powerArray(x, y) = d
                        y += 1
                    Next
                Next
            Loop
        End Using

        ' set power rating
        tbPower.Text = powerArray(cbAppliances.SelectedIndex, 1)

        'Checks for washer upper an lower case I have tried to use OR but it would not work so I did 
        'else if
        If appliance.ToString.Contains("Washer") Then
            CostGallonTextBox.Enabled = True
            NoGallonsTextBox.Enabled = True
        ElseIf appliance.ToString.Contains("washer") Then
            CostGallonTextBox.Enabled = True
            NoGallonsTextBox.Enabled = True
        Else
            CostGallonTextBox.Clear()
            NoGallonsTextBox.Clear()
            CostGallonTextBox.Enabled = False
            NoGallonsTextBox.Enabled = False
        End If

    End Sub

    Private Sub tbCost_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbCost.Validated
        Dim cost As String

        ' Validate that cost entered is number display message box if value entered is incorrect
        Try
            cost = Convert.ToDouble(tbCost.Text)
        Catch ex As Exception
            If tbCost.Text <> "" Then
                MsgBox("Please enter numeric value in Cost/kW", , "Incorrect Value")
                tbCost.Focus()
            End If
        End Try

    End Sub

    Private Sub tbPower_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbPower.Validated
        Dim power As String

        ' Validate that power entered is number display message box if value entered is incorrect
        Try
            ' Validates that power is numeric
            power = Convert.ToDouble(tbPower.Text)
        Catch ex As Exception
            ' Display error message if value is incorrect
            If tbPower.Text <> "" Then
                MsgBox("Please enter numeric value in Power needed", , "Incorrect Value")
                ' Bring focus on power textbox
                tbPower.Focus()
            End If
        End Try

    End Sub

    Private Sub tbHour_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbHour.Validated
        Dim hours As String

        Try
            hours = Convert.ToDecimal(tbHour.Text)
            If (Convert.ToDouble(hours) > 24) Then
                MsgBox("Hours cannot be greater then 24", , "Incorrect Value")
                tbHour.Focus()
            End If
        Catch ex As Exception
            If tbHour.Text <> "" Then
                MsgBox("Please enter numeric value in Hours used", , "Incorrect Value")
                tbHour.Focus()
            End If
        End Try

    End Sub

    Private Sub CalculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateButton.Click
        Dim cost, power, hours, noGallons, costGallons As String
        Dim appliance As String
        Dim appCost As Decimal

        cost = tbCost.Text
        power = tbPower.Text
        appliance = cbAppliances.Text

        ' Validate that appliance is selected
        If cbAppliances.Text = "" Then
            MsgBox("Please select an appliance", , "Value Required")
            cbAppliances.Focus()
            Exit Sub
        End If

        ' Validate that cost entered is number display message box if value entered is incorrect
        Try
            If tbCost.Text = "" Then
                MsgBox("Please enter Cost/kW", , "Value Required")
                tbCost.Focus()
                Exit Sub
            End If
            cost = Convert.ToDouble(tbCost.Text)
        Catch ex As Exception
            If tbCost.Text <> "" Then
                MsgBox("Please enter numeric value in Cost/kW", , "Incorrect Value")
                tbCost.Focus()
                Exit Sub
            End If
        End Try

        ' Validate that power entered is number display message box if value entered is incorrect
        Try
            ' Validates that power is numeric
            If tbPower.Text = "" Then
                MsgBox("Please enter Power needed", , "Value Required")
                ' Bring focus on power textbox
                tbPower.Focus()
                Exit Sub
            Else
                power = Convert.ToDouble(tbPower.Text)
            End If
        Catch ex As Exception
            ' Display error message if value is incorrect
            If tbPower.Text <> "" Then
                MsgBox("Please enter numeric value in Power needed", , "Incorrect Value")
                ' Bring focus on power textbox
                tbPower.Focus()
                Exit Sub
            End If
        End Try


        Try
            If tbHour.Text = "" Then
                MsgBox("Please enter Hours used", , "Value Required")
                tbHour.Focus()
                Exit Sub
            End If
            hours = Convert.ToDecimal(tbHour.Text)
            If (Convert.ToDouble(hours) > 24) Then
                MsgBox("Hours cannot be greater then 24", , "Incorrect Value")
                tbHour.Focus()
                Exit Sub
            End If
        Catch ex As Exception
            If tbHour.Text <> "" Then
                MsgBox("Please enter numeric value in Hours used", , "Incorrect Value")
                tbHour.Focus()
                Exit Sub
            End If
        End Try

        If appliance = "Washer" Then
            Try
                ' Validates that Number of Gallons is numeric
                If NoGallonsTextBox.Text = "" Then
                    MsgBox("Please enter Number of Gallons", , "Value Required")
                    ' Bring focus on Number of Gallons textbox
                    NoGallonsTextBox.Focus()
                    Exit Sub
                Else
                    noGallons = Convert.ToDecimal(NoGallonsTextBox.Text)
                End If
            Catch ex As Exception
                If NoGallonsTextBox.Text <> "" Then
                    MsgBox("Please enter numeric value in Number of Gallons", , "Incorrect Value")
                    NoGallonsTextBox.Focus()
                    Exit Sub
                End If
            End Try

            Try
                ' Validates that Cost of Gallons is numeric
                If CostGallonTextBox.Text = "" Then
                    MsgBox("Please enter Cost of Gallons", , "Value Required")
                    ' Bring focus on Cost of Gallons textbox
                    CostGallonTextBox.Focus()
                    Exit Sub
                Else
                    costGallons = Convert.ToDecimal(CostGallonTextBox.Text)
                End If
            Catch ex As Exception
                If tbHour.Text <> "" Then
                    MsgBox("Please enter numeric value in Cost of Gallons", , "Incorrect Value")
                    tbHour.Focus()
                    Exit Sub
                End If
            End Try

            appCost = Convert.ToDouble(cost) * Convert.ToDouble(power) * Convert.ToDouble(hours) * costGallons * noGallons
            totalCost = appCost + totalCost
        Else
            appCost = Convert.ToDouble(cost) * Convert.ToDouble(power) * Convert.ToDouble(hours)
            totalCost = appCost + totalCost
        End If

        'lbMsg.Text = "Cost for operating these is " & totalCost.ToString("C")
        TotalTextBox.Text = totalCost.ToString("C")

        ' Add row using the Add subroutine.
        Dim n As Integer = DataGridView1.Rows.Add()
        DataGridView1.Rows.Item(n).Cells(0).Value = appliance
        DataGridView1.Rows.Item(n).Cells(1).Value = hours
        DataGridView1.Rows.Item(n).Cells(2).Value = appCost.ToString("C")

    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        'clears all
        cbAppliances.SelectedIndex = 0 ' does not like -1 here will cause exception
        tbCost.Clear()
        tbHour.Clear()
        tbPower.Clear()
        NoGallonsTextBox.Clear()
        CostGallonTextBox.Clear()
    End Sub

    Private Sub NoGallonsTextBox_Validated(sender As Object, e As EventArgs) Handles NoGallonsTextBox.Validated
        Dim noGallons As String
        'converts to decimal and checks value
        Try
            noGallons = Convert.ToDecimal(NoGallonsTextBox.Text)
        Catch ex As Exception
            If NoGallonsTextBox.Text <> "" Then
                MsgBox("Please enter numeric value in Number of Gallons", , "Incorrect Value")
                NoGallonsTextBox.Focus()
                Exit Sub
            End If
        End Try

    End Sub

    Private Sub CostGallonTextBox_Validated(sender As Object, e As EventArgs) Handles CostGallonTextBox.Validated
        Dim costGallons As String

        Try
            costGallons = Convert.ToDecimal(CostGallonTextBox.Text)
        Catch ex As Exception
            If CostGallonTextBox.Text <> "" Then
                MsgBox("Please enter numeric value in Cost f Gallons", , "Incorrect Value")
                CostGallonTextBox.Focus()
                Exit Sub
            End If
        End Try

    End Sub

    Private Sub ExportButton_Click(sender As Object, e As EventArgs) Handles ExportButton.Click
        Dim cellvalue As String
        Dim rowLine As String = ""
        'Checks if file exists then creates new if not
        Dim fileExists As Boolean = File.Exists("appliances.txt")

        Using writer As New StreamWriter("appliances.txt", True)
            If Not fileExists Then
                writer.WriteLine("Appliances, Hours Used, Cost")
            End If
            writer.Close()
        End Using


        Dim fsStream As New FileStream("appliances.txt", FileMode.Append, FileAccess.Write)
        Dim sw As New StreamWriter(fsStream)
        'runs through the datagrid and prints text 
        For j = 0 To (DataGridView1.Rows.Count - 1)
            For I = 0 To (DataGridView1.Columns.Count - 1)
                If Not TypeOf DataGridView1.Item(I, j).Value Is DBNull Then
                    cellvalue = DataGridView1.Item(I, j).Value
                Else
                    cellvalue = ""
                End If
                rowLine = rowLine + cellvalue + ", "
            Next
            rowLine = rowLine.Remove(rowLine.Length - 1, 1)
            sw.WriteLine(rowLine)
            rowLine = ""
        Next

        sw.Flush()
        MsgBox("Data Exported Successfully")
        sw.Close()

    End Sub

    Private Sub Week4_Load(sender As Object, e As EventArgs) Handles Me.Load
        cbAppliances.Items.AddRange(File.ReadAllLines("appliances.txt"))
    End Sub

    Private Sub btExit_Click(sender As Object, e As EventArgs) Handles btExit.Click
        Me.Close()

    End Sub

End Class