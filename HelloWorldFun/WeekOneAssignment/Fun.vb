' Gregory Tidd
' Week 1 Individual 
' Due 9/28/15
'Hello World forms 1.0

Public Class Fun

    Dim ColorClickCount As Integer = 0 'Declaring global variables viewable by all sub classes
    Dim LangClickCount As Integer = 0
    Dim LeapClickCount As Integer = 0

    Private Sub btnStrobe_Click(sender As Object, e As EventArgs) Handles btnStrobe.Click
        If (lblHello.Visible = True) Then 'if visible will hide and vice versa
            lblHello.Visible = False
        Else
            lblHello.Visible = True
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close() 'Closes form
    End Sub

    Private Sub btnColor_Click(sender As Object, e As EventArgs) Handles btnColor.Click

        If Not ColorClickCount = 3 Then 'Select the color base on click amount tried an If statement first
            'but that failed miserably
            ColorClickCount += 1
        Else
            ColorClickCount = 0
        End If
        Select Case ColorClickCount
            Case Is = 0
                lblHello.ForeColor = System.Drawing.Color.Black
            Case Is = 1
                lblHello.ForeColor = System.Drawing.Color.Blue
            Case Is = 2
                lblHello.ForeColor = System.Drawing.Color.Red
            Case Is = 3
                lblHello.ForeColor = System.Drawing.Color.Gold
        End Select


    End Sub

    Private Sub btnLanguage_Click(sender As Object, e As EventArgs) Handles btnLanguage.Click

        If Not LangClickCount = 3 Then ' another switch for language clicks 
            LangClickCount += 1
        Else
            LangClickCount = 0
        End If
        Select Case LangClickCount
            Case Is = 0
                lblHello.Text = "Hello World"
            Case Is = 1
                lblHello.Text = "Dutch: Hallo Wereld"
            Case Is = 2
                lblHello.Text = "Turkish: Merhaba Dünya"
            Case Is = 3
                lblHello.Text = "Filipino: Kamusta mundo"
        End Select
    End Sub

    Private Sub btnLeapFrog_Click(sender As Object, e As EventArgs) Handles btnLeapFrog.Click
        If Not LeapClickCount = 3 Then 'although I wanted this to be random I still managed to get the label to 
            'leap around
            LeapClickCount += 1
        Else
            LeapClickCount = 0
        End If
        Select Case LeapClickCount
            Case Is = 0
                lblHello.Top = lblHello.Top + 50
            Case Is = 1
                lblHello.Top = lblHello.Top - 50
            Case Is = 2
                lblHello.Left = lblHello.Left + 200
            Case Is = 3
                lblHello.Left = lblHello.Left - 200
        End Select
    End Sub
End Class