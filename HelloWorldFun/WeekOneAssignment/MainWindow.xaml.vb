' Gregory Tidd
' Week 1 Individual 
' Due 9/28/15
'Hello World forms 1.0
Class MainWindow
    Private Sub button2_Click(sender As Object, e As RoutedEventArgs) Handles btnExit.Click
        Me.Close() 'closes the program

    End Sub

    Private Sub btnEarthlyGreeting_Click(sender As Object, e As RoutedEventArgs) Handles btnEarthlyGreeting.Click
        Dim earthlyGreetingForm = New HelloForm 'creates new instance of the HelloForm from the blueprint
        earthlyGreetingForm.ShowDialog() 'pops up form and cannot access the previous form until closed

    End Sub

    Private Sub btnFun_Click(sender As Object, e As RoutedEventArgs) Handles btnFun.Click
        Dim havingFun = New Fun 'creates new instance of the fun form from blueprint
        havingFun.ShowDialog() 'pops up form and cannot access the previous form until closed could also be
        'Show()

    End Sub
End Class
