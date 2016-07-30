'Greg Tidd
' 10/4/15
'VB.NET
'Tim Hagan
Class MainWindow
    Dim totalCost As Decimal = 0

    Private Sub cbAppliances_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAppliances.SelectionChanged
        Dim appliance As String 'if we do not pass this as a String the program will throw an exception I learned this the hard way over many hours

        ' Get value entered by the user
        appliance = cmbAppliances.Text

        If appliance = "Washer" Then
            txtNumOfGal.IsEnabled = True
            txtWaterCost.IsEnabled = True
        Else
            txtWaterCost.Clear()
            txtNumOfGal.Clear()
            txtNumOfGal.IsEnabled = False
            txtWaterCost.IsEnabled = False
        End If

    End Sub

    Private Sub txtCost_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCost.LostFocus
        Dim cost As String

        ' Validate that cost entered is number display message box if value entered is incorrect
        Try
            cost = Convert.ToDouble(txtCost.Text)
        Catch ex As Exception
            If txtCost.Text <> "" Then
                MsgBox("Please enter correct numeric value in Cost/kW", , "Incorrect Value")
                txtCost.Focus()
            End If
        End Try

    End Sub

    Private Sub txtPowerNeeded_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPowerNeeded.LostFocus
        Dim power As String

        ' Validate that power entered is number display message box if value entered is incorrect
        Try
            ' Validates that powerneeded is numeric
            power = Convert.ToDouble(txtPowerNeeded.Text)
        Catch ex As Exception
            ' Display error message if value is incorrect
            If txtPowerNeeded.Text <> "" Then
                MsgBox("Please enter numeric value in Power needed", , "Incorrect Value")
                ' Bring focus on powerneeded textbox
                txtPowerNeeded.Focus()
            End If
        End Try

    End Sub

    Private Sub txtHourlyCost_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtHourlyCost.LostFocus
        Dim hours As String

        Try
            hours = Convert.ToDecimal(txtHourlyCost.Text)
            If (Convert.ToDouble(hours) > 24) Then
                MsgBox("Hours cannot be greater then 24", , "Incorrect Value")
                txtHourlyCost.Focus()
            End If
        Catch ex As Exception
            If txtHourlyCost.Text <> "" Then
                MsgBox("Please enter numeric value in Hours used", , "Incorrect Value")
                txtHourlyCost.Focus()
            End If
        End Try

    End Sub

    Private Sub btnExit_Click(sender As Object, e As RoutedEventArgs) Handles btnExit.Click
        Me.Close() 'Closes Form
    End Sub

    Private Sub btnClear_Click(sender As Object, e As RoutedEventArgs) Handles btnClear.Click
        txtAvgUse.Clear() 'Clearing all fields including the read only.
        txtCost.Clear()
        txtHourlyCost.Clear()
        txtPowerNeeded.Clear()
        txtYearlyCost.Clear()
        txtNumOfGal.Clear()
        txtWaterCost.Clear()
        cmbAppliances.SelectedIndex = -1
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As RoutedEventArgs) Handles btnCalculate.Click
        Dim cost, power, hours, noGallons, costGallons As String
        Dim appliance As String
        Dim appCost As Decimal

        cost = txtCost.Text
        power = txtPowerNeeded.Text
        appliance = cmbAppliances.Text

        ' Validate that appliance is selected
        If cmbAppliances.Text = "" Then
            MsgBox("Please select an appliance", , "Value Required")
            cmbAppliances.Focus()
            Exit Sub
        End If

        ' Validate that cost entered is number display message box if value entered is incorrect
        Try
            If txtCost.Text = "" Then
                MsgBox("Please enter Cost/kW", , "Value Required")
                txtCost.Focus()
                Exit Sub
            End If
            cost = Convert.ToDouble(txtCost.Text)
        Catch ex As Exception
            If txtCost.Text <> "" Then
                MsgBox("Please enter numeric value in Cost/kW", , "Incorrect Value")
                txtCost.Focus()
                Exit Sub
            End If
        End Try

        ' Validate that powerneeded entered is number display message box if value entered is incorrect
        Try
            ' Validates that power is numeric
            If txtPowerNeeded.Text = "" Then
                MsgBox("Please enter Power needed", , "Value Required")
                ' Bring focus on power textbox
                txtPowerNeeded.Focus()
                Exit Sub
            Else
                power = Convert.ToDouble(txtPowerNeeded.Text)
            End If
        Catch ex As Exception
            ' Display error message if value is incorrect
            If txtPowerNeeded.Text <> "" Then
                MsgBox("Please enter numeric value in Power needed", , "Incorrect Value")
                ' Bring focus on power textbox
                txtPowerNeeded.Focus()
                Exit Sub
            End If
        End Try


        Try
            If txtAvgUse.Text = "" Then
                MsgBox("Please enter Hours used", , "Value Required")
                txtHourlyCost.Focus()
                Exit Sub
            End If
            hours = Convert.ToDecimal(txtAvgUse.Text)
            If (Convert.ToDouble(hours) > 24) Then
                MsgBox("Hours cannot be greater then 24", , "Incorrect Value")
                txtAvgUse.Focus()
                Exit Sub
            End If
        Catch ex As Exception
            If txtAvgUse.Text <> "" Then
                MsgBox("Please enter numeric value in Hours used", , "Incorrect Value")
                txtAvgUse.Focus()
                Exit Sub
            End If
        End Try

        If appliance = "Washer" Or appliance.Contains("washer") Then
            Try
                ' Validates that Number of Gallons is numeric
                If txtNumOfGal.Text = "" Then
                    MsgBox("Please enter Number of Gallons", , "Value Required")
                    ' Bring focus on Number of Gallons textbox
                    txtNumOfGal.Focus()
                    Exit Sub
                Else
                    noGallons = Convert.ToDecimal(txtNumOfGal.Text)
                End If
            Catch ex As Exception
                If txtNumOfGal.Text <> "" Then
                    MsgBox("Please enter numeric value in Number of Gallons", , "Incorrect Value")
                    txtNumOfGal.Focus()
                    Exit Sub
                End If
            End Try

            Try
                ' Validates that Cost of Gallons is numeric
                If txtWaterCost.Text = "" Then
                    MsgBox("Please enter Cost of Gallons", , "Value Required")
                    ' Bring focus on Cost of Gallons textbox
                    txtWaterCost.Focus()
                    Exit Sub
                Else
                    costGallons = Convert.ToDecimal(txtWaterCost.Text)
                End If
            Catch ex As Exception
                If txtWaterCost.Text <> "" Then
                    MsgBox("Please enter numeric value in Cost of Gallons", , "Incorrect Value")
                    txtWaterCost.Focus()
                    Exit Sub
                End If
            End Try

            appCost = Convert.ToDouble(cost) * Convert.ToDouble(power) * Convert.ToDouble(hours) * costGallons * noGallons
            totalCost = appCost + totalCost
        Else
            appCost = Convert.ToDouble(cost) * Convert.ToDouble(power) * Convert.ToDouble(hours)
            totalCost = appCost + totalCost
        End If


        txtYearlyCost.Text = totalCost.ToString("C")

        ' adds to datagrid
        Dim n As Integer = dataGrid.RowValidationRules.Add()
        dataGrid.Items(n).Cells(0).Value = appliance
        dataGrid.Items(n).Cells(1).Value = hours
        dataGrid.Items(n).Cells(2).Value = appCost.ToString("C")


    End Sub

    Private Sub txtNumOfGal_Validated(sender As Object, e As EventArgs) Handles txtNumOfGal.LostFocus
        Dim noGallons As String

        Try
            noGallons = Convert.ToDecimal(txtNumOfGal.Text)
        Catch ex As Exception
            If txtNumOfGal.Text <> "" Then
                MsgBox("Please enter numeric value in Number of Gallons", , "Incorrect Value")
                txtNumOfGal.Focus()
                Exit Sub
            End If
        End Try

    End Sub

    Private Sub txtWaterCost_Validated(sender As Object, e As EventArgs) Handles txtWaterCost.LostFocus
        Dim costGallons As String

        Try
            costGallons = Convert.ToDecimal(txtWaterCost.Text)
        Catch ex As Exception
            If txtWaterCost.Text <> "" Then
                MsgBox("Please enter numeric value in Cost f Gallons", , "Incorrect Value")
                txtWaterCost.Focus()
                Exit Sub
            End If
        End Try

    End Sub
End Class

