<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class langScreen
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(langScreen))
        Me.bEnglish = New System.Windows.Forms.Button()
        Me.bFrench = New System.Windows.Forms.Button()
        Me.bSpanish = New System.Windows.Forms.Button()
        Me.bChinese = New System.Windows.Forms.Button()
        Me.bArabic = New System.Windows.Forms.Button()
        Me.bItalian = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'bEnglish
        '
        Me.bEnglish.BackgroundImage = CType(resources.GetObject("bEnglish.BackgroundImage"), System.Drawing.Image)
        Me.bEnglish.Location = New System.Drawing.Point(144, 112)
        Me.bEnglish.Name = "bEnglish"
        Me.bEnglish.Size = New System.Drawing.Size(713, 81)
        Me.bEnglish.TabIndex = 0
        Me.bEnglish.UseVisualStyleBackColor = True
        '
        'bFrench
        '
        Me.bFrench.BackgroundImage = CType(resources.GetObject("bFrench.BackgroundImage"), System.Drawing.Image)
        Me.bFrench.Location = New System.Drawing.Point(144, 199)
        Me.bFrench.Name = "bFrench"
        Me.bFrench.Size = New System.Drawing.Size(713, 81)
        Me.bFrench.TabIndex = 1
        Me.bFrench.UseVisualStyleBackColor = True
        '
        'bSpanish
        '
        Me.bSpanish.BackgroundImage = CType(resources.GetObject("bSpanish.BackgroundImage"), System.Drawing.Image)
        Me.bSpanish.Location = New System.Drawing.Point(144, 285)
        Me.bSpanish.Name = "bSpanish"
        Me.bSpanish.Size = New System.Drawing.Size(713, 81)
        Me.bSpanish.TabIndex = 2
        Me.bSpanish.UseVisualStyleBackColor = True
        '
        'bChinese
        '
        Me.bChinese.BackgroundImage = CType(resources.GetObject("bChinese.BackgroundImage"), System.Drawing.Image)
        Me.bChinese.Location = New System.Drawing.Point(144, 371)
        Me.bChinese.Name = "bChinese"
        Me.bChinese.Size = New System.Drawing.Size(713, 81)
        Me.bChinese.TabIndex = 3
        Me.bChinese.UseVisualStyleBackColor = True
        '
        'bArabic
        '
        Me.bArabic.BackgroundImage = CType(resources.GetObject("bArabic.BackgroundImage"), System.Drawing.Image)
        Me.bArabic.Location = New System.Drawing.Point(144, 458)
        Me.bArabic.Name = "bArabic"
        Me.bArabic.Size = New System.Drawing.Size(713, 81)
        Me.bArabic.TabIndex = 4
        Me.bArabic.UseVisualStyleBackColor = True
        '
        'bItalian
        '
        Me.bItalian.BackgroundImage = CType(resources.GetObject("bItalian.BackgroundImage"), System.Drawing.Image)
        Me.bItalian.Location = New System.Drawing.Point(144, 544)
        Me.bItalian.Name = "bItalian"
        Me.bItalian.Size = New System.Drawing.Size(713, 81)
        Me.bItalian.TabIndex = 5
        Me.bItalian.UseVisualStyleBackColor = True
        '
        'langScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.Controls.Add(Me.bItalian)
        Me.Controls.Add(Me.bArabic)
        Me.Controls.Add(Me.bChinese)
        Me.Controls.Add(Me.bSpanish)
        Me.Controls.Add(Me.bFrench)
        Me.Controls.Add(Me.bEnglish)
        Me.Name = "langScreen"
        Me.Size = New System.Drawing.Size(1000, 700)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents bEnglish As Button
    Friend WithEvents bFrench As Button
    Friend WithEvents bSpanish As Button
    Friend WithEvents bChinese As Button
    Friend WithEvents bArabic As Button
    Friend WithEvents bItalian As Button
End Class
