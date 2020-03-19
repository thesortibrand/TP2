<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTP2
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
        Me.cmdEssai = New System.Windows.Forms.Button()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.lblMoyenne = New System.Windows.Forms.Label()
        Me.cmdMoyenne = New System.Windows.Forms.Button()
        Me.txtNote6 = New System.Windows.Forms.TextBox()
        Me.txtNote5 = New System.Windows.Forms.TextBox()
        Me.txtNote4 = New System.Windows.Forms.TextBox()
        Me.txtNote3 = New System.Windows.Forms.TextBox()
        Me.txtNote2 = New System.Windows.Forms.TextBox()
        Me.txtNote1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdEssai
        '
        Me.cmdEssai.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEssai.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdEssai.Location = New System.Drawing.Point(60, 72)
        Me.cmdEssai.Name = "cmdEssai"
        Me.cmdEssai.Size = New System.Drawing.Size(84, 62)
        Me.cmdEssai.TabIndex = 0
        Me.cmdEssai.Text = "Essai"
        Me.cmdEssai.UseVisualStyleBackColor = True
        '
        'GroupBox
        '
        Me.GroupBox.Controls.Add(Me.lblMoyenne)
        Me.GroupBox.Controls.Add(Me.cmdMoyenne)
        Me.GroupBox.Controls.Add(Me.txtNote6)
        Me.GroupBox.Controls.Add(Me.txtNote5)
        Me.GroupBox.Controls.Add(Me.txtNote4)
        Me.GroupBox.Controls.Add(Me.txtNote3)
        Me.GroupBox.Controls.Add(Me.txtNote2)
        Me.GroupBox.Controls.Add(Me.txtNote1)
        Me.GroupBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox.Location = New System.Drawing.Point(238, 72)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(442, 193)
        Me.GroupBox.TabIndex = 1
        Me.GroupBox.TabStop = False
        Me.GroupBox.Text = "Application"
        '
        'lblMoyenne
        '
        Me.lblMoyenne.AutoSize = True
        Me.lblMoyenne.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMoyenne.Location = New System.Drawing.Point(255, 141)
        Me.lblMoyenne.Name = "lblMoyenne"
        Me.lblMoyenne.Size = New System.Drawing.Size(20, 24)
        Me.lblMoyenne.TabIndex = 7
        Me.lblMoyenne.Text = "0"
        '
        'cmdMoyenne
        '
        Me.cmdMoyenne.Location = New System.Drawing.Point(86, 133)
        Me.cmdMoyenne.Name = "cmdMoyenne"
        Me.cmdMoyenne.Size = New System.Drawing.Size(123, 36)
        Me.cmdMoyenne.TabIndex = 6
        Me.cmdMoyenne.Text = "Moyenne"
        Me.cmdMoyenne.UseVisualStyleBackColor = True
        '
        'txtNote6
        '
        Me.txtNote6.Location = New System.Drawing.Point(307, 81)
        Me.txtNote6.Name = "txtNote6"
        Me.txtNote6.Size = New System.Drawing.Size(100, 30)
        Me.txtNote6.TabIndex = 5
        '
        'txtNote5
        '
        Me.txtNote5.Location = New System.Drawing.Point(169, 81)
        Me.txtNote5.Name = "txtNote5"
        Me.txtNote5.Size = New System.Drawing.Size(100, 30)
        Me.txtNote5.TabIndex = 4
        '
        'txtNote4
        '
        Me.txtNote4.Location = New System.Drawing.Point(30, 81)
        Me.txtNote4.Name = "txtNote4"
        Me.txtNote4.Size = New System.Drawing.Size(100, 30)
        Me.txtNote4.TabIndex = 3
        '
        'txtNote3
        '
        Me.txtNote3.Location = New System.Drawing.Point(307, 39)
        Me.txtNote3.Name = "txtNote3"
        Me.txtNote3.Size = New System.Drawing.Size(100, 30)
        Me.txtNote3.TabIndex = 2
        '
        'txtNote2
        '
        Me.txtNote2.Location = New System.Drawing.Point(169, 39)
        Me.txtNote2.Name = "txtNote2"
        Me.txtNote2.Size = New System.Drawing.Size(100, 30)
        Me.txtNote2.TabIndex = 1
        '
        'txtNote1
        '
        Me.txtNote1.Location = New System.Drawing.Point(30, 39)
        Me.txtNote1.Name = "txtNote1"
        Me.txtNote1.Size = New System.Drawing.Size(100, 30)
        Me.txtNote1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(60, 204)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(84, 44)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Quitter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(407, 302)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 37)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "TP2 bis"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmTP2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 402)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox)
        Me.Controls.Add(Me.cmdEssai)
        Me.Name = "frmTP2"
        Me.Text = "TP2"
        Me.GroupBox.ResumeLayout(False)
        Me.GroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmdEssai As Button
    Friend WithEvents GroupBox As GroupBox
    Friend WithEvents txtNote6 As TextBox
    Friend WithEvents txtNote5 As TextBox
    Friend WithEvents txtNote4 As TextBox
    Friend WithEvents txtNote3 As TextBox
    Friend WithEvents txtNote2 As TextBox
    Friend WithEvents txtNote1 As TextBox
    Friend WithEvents lblMoyenne As Label
    Friend WithEvents cmdMoyenne As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
