Imports System.Drawing.Text
Public Class prScreen
    Private Sub prScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim pfc2 As New PrivateFontCollection()
        pfc2.AddFontFile("c:\users\gabriel\documents\visual studio 2015\Projects\4HC3\ParkingMeter\RobotoMedium.ttf")
        prTimeLabel.Font = New Font(pfc2.Families(0), 36, FontStyle.Regular)
        Timer2.Start()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        prTimeLabel.Text = Format(TimeOfDay, "Short Time")
    End Sub

    Private Sub prBackLabel_Click(sender As Object, e As EventArgs) Handles prBackLabel.Click
        startForm.LangScreen1.Visible = True
        Me.Visible = False
    End Sub

    Private Sub bPurchase_Click(sender As Object, e As EventArgs) Handles bPurchase.Click

    End Sub

    Private Sub bRefund_Click(sender As Object, e As EventArgs) Handles bRefund.Click

    End Sub

    Private Sub bCancelPR_Click(sender As Object, e As EventArgs) Handles bCancelPR.Click

    End Sub
End Class
