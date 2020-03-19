<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTP2_bis
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdTP2 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtNote1 = New System.Windows.Forms.TextBox()
        Me.txtNote2 = New System.Windows.Forms.TextBox()
        Me.txtNote3 = New System.Windows.Forms.TextBox()
        Me.txtNote4 = New System.Windows.Forms.TextBox()
        Me.txtNote5 = New System.Windows.Forms.TextBox()
        Me.txtNote6 = New System.Windows.Forms.TextBox()
        Me.txtNote7 = New System.Windows.Forms.TextBox()
        Me.txtNote8 = New System.Windows.Forms.TextBox()
        Me.txtNote9 = New System.Windows.Forms.TextBox()
        Me.cmdCharger = New System.Windows.Forms.Button()
        Me.cmdMoyenne = New System.Windows.Forms.Button()
        Me.lblMoyenne = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cmdTP2
        '
        Me.cmdTP2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTP2.Location = New System.Drawing.Point(32, 52)
        Me.cmdTP2.Name = "cmdTP2"
        Me.cmdTP2.Size = New System.Drawing.Size(100, 36)
        Me.cmdTP2.TabIndex = 0
        Me.cmdTP2.Text = "TP2"
        Me.cmdTP2.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(32, 140)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 36)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Quitter"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtNote1
        '
        Me.txtNote1.Location = New System.Drawing.Point(265, 62)
        Me.txtNote1.Name = "txtNote1"
        Me.txtNote1.Size = New System.Drawing.Size(100, 22)
        Me.txtNote1.TabIndex = 2
        '
        'txtNote2
        '
        Me.txtNote2.Location = New System.Drawing.Point(400, 62)
        Me.txtNote2.Name = "txtNote2"
        Me.txtNote2.Size = New System.Drawing.Size(100, 22)
        Me.txtNote2.TabIndex = 3
        '
        'txtNote3
        '
        Me.txtNote3.Location = New System.Drawing.Point(535, 62)
        Me.txtNote3.Name = "txtNote3"
        Me.txtNote3.Size = New System.Drawing.Size(100, 22)
        Me.txtNote3.TabIndex = 4
        '
        'txtNote4
        '
        Me.txtNote4.Location = New System.Drawing.Point(265, 116)
        Me.txtNote4.Name = "txtNote4"
        Me.txtNote4.Size = New System.Drawing.Size(100, 22)
        Me.txtNote4.TabIndex = 5
        '
        'txtNote5
        '
        Me.txtNote5.Location = New System.Drawing.Point(400, 116)
        Me.txtNote5.Name = "txtNote5"
        Me.txtNote5.Size = New System.Drawing.Size(100, 22)
        Me.txtNote5.TabIndex = 6
        '
        'txtNote6
        '
        Me.txtNote6.Location = New System.Drawing.Point(535, 116)
        Me.txtNote6.Name = "txtNote6"
        Me.txtNote6.Size = New System.Drawing.Size(100, 22)
        Me.txtNote6.TabIndex = 7
        '
        'txtNote7
        '
        Me.txtNote7.Location = New System.Drawing.Point(265, 176)
        Me.txtNote7.Name = "txtNote7"
        Me.txtNote7.Size = New System.Drawing.Size(100, 22)
        Me.txtNote7.TabIndex = 8
        '
        'txtNote8
        '
        Me.txtNote8.Location = New System.Drawing.Point(400, 176)
        Me.txtNote8.Name = "txtNote8"
        Me.txtNote8.Size = New System.Drawing.Size(100, 22)
        Me.txtNote8.TabIndex = 9
        '
        'txtNote9
        '
        Me.txtNote9.Location = New System.Drawing.Point(535, 176)
        Me.txtNote9.Name = "txtNote9"
        Me.txtNote9.Size = New System.Drawing.Size(100, 22)
        Me.txtNote9.TabIndex = 10
        '
        'cmdCharger
        '
        Me.cmdCharger.Location = New System.Drawing.Point(265, 231)
        Me.cmdCharger.Name = "cmdCharger"
        Me.cmdCharger.Size = New System.Drawing.Size(100, 29)
        Me.cmdCharger.TabIndex = 11
        Me.cmdCharger.Text = "Charger"
        Me.cmdCharger.UseVisualStyleBackColor = True
        '
        'cmdMoyenne
        '
        Me.cmdMoyenne.Location = New System.Drawing.Point(265, 292)
        Me.cmdMoyenne.Name = "cmdMoyenne"
        Me.cmdMoyenne.Size = New System.Drawing.Size(100, 36)
        Me.cmdMoyenne.TabIndex = 12
        Me.cmdMoyenne.Text = "Moyenne"
        Me.cmdMoyenne.UseVisualStyleBackColor = True
        '
        'lblMoyenne
        '
        Me.lblMoyenne.AutoSize = True
        Me.lblMoyenne.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoyenne.Location = New System.Drawing.Point(418, 295)
        Me.lblMoyenne.Name = "lblMoyenne"
        Me.lblMoyenne.Size = New System.Drawing.Size(23, 25)
        Me.lblMoyenne.TabIndex = 13
        Me.lblMoyenne.Text = "0"
        '
        'frmTP2_bis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblMoyenne)
        Me.Controls.Add(Me.cmdMoyenne)
        Me.Controls.Add(Me.cmdCharger)
        Me.Controls.Add(Me.txtNote9)
        Me.Controls.Add(Me.txtNote8)
        Me.Controls.Add(Me.txtNote7)
        Me.Controls.Add(Me.txtNote6)
        Me.Controls.Add(Me.txtNote5)
        Me.Controls.Add(Me.txtNote4)
        Me.Controls.Add(Me.txtNote3)
        Me.Controls.Add(Me.txtNote2)
        Me.Controls.Add(Me.txtNote1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cmdTP2)
        Me.Name = "frmTP2_bis"
        Me.Text = "TP2_bis"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmdTP2 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents txtNote1 As TextBox
    Friend WithEvents txtNote2 As TextBox
    Friend WithEvents txtNote3 As TextBox
    Friend WithEvents txtNote4 As TextBox
    Friend WithEvents txtNote5 As TextBox
    Friend WithEvents txtNote6 As TextBox
    Friend WithEvents txtNote7 As TextBox
    Friend WithEvents txtNote8 As TextBox
    Friend WithEvents txtNote9 As TextBox
    Friend WithEvents cmdCharger As Button
    Friend WithEvents cmdMoyenne As Button
    Friend WithEvents lblMoyenne As Label
End Class
