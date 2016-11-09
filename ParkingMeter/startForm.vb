Imports System.Drawing.Text
Public Class startForm
    Private Sub startForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pfc As New PrivateFontCollection()
        pfc.AddFontFile("c:\users\gabriel\documents\visual studio 2015\Projects\4HC3\ParkingMeter\RobotoMedium.ttf")
        timeLabel.Font = New Font(pfc.Families(0), 36, FontStyle.Regular)
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        timeLabel.Text = Format(TimeOfDay, "Short Time")
    End Sub

    Private Sub startLabel_Click(sender As Object, e As EventArgs) Handles startLabel.Click
        LangScreen1.Visible = True
    End Sub

    Private Sub timeLabel_Click(sender As Object, e As EventArgs) Handles timeLabel.Click
        LangScreen1.Visible = True
    End Sub

    Private Sub LangScreen1_Load_1(sender As Object, e As EventArgs) Handles LangScreen1.Load
        Timer1.Stop()
    End Sub
End Class