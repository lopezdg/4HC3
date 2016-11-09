<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class prScreen
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(prScreen))
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.bPurchase = New System.Windows.Forms.Button()
        Me.bRefund = New System.Windows.Forms.Button()
        Me.bCancelPR = New System.Windows.Forms.Button()
        Me.prTimeLabel = New System.Windows.Forms.Label()
        Me.prBackLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Timer2
        '
        '
        'bPurchase
        '
        Me.bPurchase.BackgroundImage = CType(resources.GetObject("bPurchase.BackgroundImage"), System.Drawing.Image)
        Me.bPurchase.Location = New System.Drawing.Point(147, 344)
        Me.bPurchase.Name = "bPurchase"
        Me.bPurchase.Size = New System.Drawing.Size(354, 218)
        Me.bPurchase.TabIndex = 0
        Me.bPurchase.UseVisualStyleBackColor = True
        '
        'bRefund
        '
        Me.bRefund.BackgroundImage = CType(resources.GetObject("bRefund.BackgroundImage"), System.Drawing.Image)
        Me.bRefund.Location = New System.Drawing.Point(507, 344)
        Me.bRefund.Name = "bRefund"
        Me.bRefund.Size = New System.Drawing.Size(354, 218)
        Me.bRefund.TabIndex = 1
        Me.bRefund.UseVisualStyleBackColor = True
        '
        'bCancelPR
        '
        Me.bCancelPR.BackgroundImage = CType(resources.GetObject("bCancelPR.BackgroundImage"), System.Drawing.Image)
        Me.bCancelPR.Location = New System.Drawing.Point(145, 566)
        Me.bCancelPR.Name = "bCancelPR"
        Me.bCancelPR.Size = New System.Drawing.Size(716, 123)
        Me.bCancelPR.TabIndex = 2
        Me.bCancelPR.UseVisualStyleBackColor = True
        '
        'prTimeLabel
        '
        Me.prTimeLabel.BackColor = System.Drawing.Color.Transparent
        Me.prTimeLabel.Location = New System.Drawing.Point(147, 91)
        Me.prTimeLabel.Name = "prTimeLabel"
        Me.prTimeLabel.Size = New System.Drawing.Size(703, 109)
        Me.prTimeLabel.TabIndex = 3
        Me.prTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'prBackLabel
        '
        Me.prBackLabel.BackColor = System.Drawing.Color.Transparent
        Me.prBackLabel.Location = New System.Drawing.Point(39, 43)
        Me.prBackLabel.Name = "prBackLabel"
        Me.prBackLabel.Size = New System.Drawing.Size(65, 65)
        Me.prBackLabel.TabIndex = 4
        '
        'prScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.Controls.Add(Me.prBackLabel)
        Me.Controls.Add(Me.prTimeLabel)
        Me.Controls.Add(Me.bCancelPR)
        Me.Controls.Add(Me.bRefund)
        Me.Controls.Add(Me.bPurchase)
        Me.Name = "prScreen"
        Me.Size = New System.Drawing.Size(1000, 700)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Timer2 As Timer
    Friend WithEvents bPurchase As Button
    Friend WithEvents bRefund As Button
    Friend WithEvents bCancelPR As Button
    Friend WithEvents prTimeLabel As Label
    Friend WithEvents prBackLabel As Label
End Class
