<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class startForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(startForm))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.timeLabel = New System.Windows.Forms.Label()
        Me.startLabel = New System.Windows.Forms.Label()
        Me.LangScreen1 = New ParkingMeter.langScreen()
        Me.PrScreen1 = New ParkingMeter.prScreen()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'timeLabel
        '
        Me.timeLabel.BackColor = System.Drawing.Color.Transparent
        Me.timeLabel.Location = New System.Drawing.Point(557, 144)
        Me.timeLabel.Name = "timeLabel"
        Me.timeLabel.Size = New System.Drawing.Size(415, 156)
        Me.timeLabel.TabIndex = 0
        Me.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'startLabel
        '
        Me.startLabel.BackColor = System.Drawing.Color.Transparent
        Me.startLabel.Location = New System.Drawing.Point(-8, -30)
        Me.startLabel.Name = "startLabel"
        Me.startLabel.Size = New System.Drawing.Size(1000, 700)
        Me.startLabel.TabIndex = 1
        Me.startLabel.Text = "Label1"
        '
        'LangScreen1
        '
        Me.LangScreen1.BackColor = System.Drawing.Color.Transparent
        Me.LangScreen1.BackgroundImage = CType(resources.GetObject("LangScreen1.BackgroundImage"), System.Drawing.Image)
        Me.LangScreen1.Location = New System.Drawing.Point(-5, 0)
        Me.LangScreen1.Name = "LangScreen1"
        Me.LangScreen1.Size = New System.Drawing.Size(1000, 700)
        Me.LangScreen1.TabIndex = 2
        Me.LangScreen1.Visible = False
        '
        'PrScreen1
        '
        Me.PrScreen1.BackgroundImage = CType(resources.GetObject("PrScreen1.BackgroundImage"), System.Drawing.Image)
        Me.PrScreen1.Location = New System.Drawing.Point(0, 0)
        Me.PrScreen1.Name = "PrScreen1"
        Me.PrScreen1.Size = New System.Drawing.Size(1000, 700)
        Me.PrScreen1.TabIndex = 3
        Me.PrScreen1.Visible = False
        '
        'startForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.PrScreen1)
        Me.Controls.Add(Me.LangScreen1)
        Me.Controls.Add(Me.timeLabel)
        Me.Controls.Add(Me.startLabel)
        Me.Name = "startForm"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents timeLabel As Label
    Friend WithEvents startLabel As Label
    Friend WithEvents LangScreen1 As langScreen
    Friend WithEvents Label1 As Label
    Friend WithEvents PrScreen1 As prScreen
End Class
