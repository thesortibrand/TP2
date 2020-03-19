Public Class frmTP2_bis
    Dim matrice(2, 2) As Single
    Dim a As Integer
    Dim moyenne As Double
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Creé par Daniel GARCIA")
        Me.Close()
    End Sub

    Private Sub cmdTP2_Click(sender As Object, e As EventArgs) Handles cmdTP2.Click
        frmTP2.Show()
        Me.Hide()
    End Sub

    Private Sub cmdCharger_Click(sender As Object, e As EventArgs) Handles cmdCharger.Click
        a = 0
        moyenne = 0
        lblMoyenne.Text = CStr(moyenne)

        Try
            If txtNote1.Text > 0 Then
                matrice(0, 0) = CSng(txtNote1.Text)
                a = a + 1
            End If

            If txtNote2.Text > 0 Then
                matrice(0, 1) = CSng(txtNote2.Text)
                a = a + 1
            End If

            If txtNote3.Text > 0 Then
                matrice(0, 2) = CSng(txtNote3.Text)
                a = a + 1
            End If

            If txtNote4.Text > 0 Then
                matrice(1, 0) = CSng(txtNote4.Text)
                a = a + 1
            End If

            If txtNote5.Text > 0 Then
                matrice(1, 1) = CSng(txtNote5.Text)
                a = a + 1
            End If

            If txtNote6.Text > 0 Then
                matrice(1, 2) = CSng(txtNote6.Text)
                a = a + 1
            End If

            If txtNote7.Text > 0 Then
                matrice(2, 0) = CSng(txtNote7.Text)
                a = a + 1
            End If

            If txtNote8.Text > 0 Then
                matrice(2, 1) = CSng(txtNote8.Text)
                a = a + 1
            End If

            If txtNote9.Text > 0 Then
                matrice(2, 2) = CSng(txtNote9.Text)
                a = a + 1
            End If

            If a = 9 Then
                MsgBox("Tous les données bien enregistrées")
            Else
                MsgBox("Verifiez que tous les boites sont bien remplis")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub cmdMoyenne_Click(sender As Object, e As EventArgs) Handles cmdMoyenne.Click
        Dim i, j As Integer

        moyenne = 0

        If a <> 9 Then
            MsgBox("Verifiez que tous les boites sont bien remplis")
        Else
            For i = 0 To 2
                For j = 0 To 2
                    moyenne = moyenne + matrice(i, j)
                Next
            Next

            moyenne = moyenne / 9
        End If

        lblMoyenne.Text = CStr(moyenne)


    End Sub

    Private Sub txtNote_TextChanged(sender As Object, e As EventArgs) Handles txtNote1.TextChanged, txtNote2.TextChanged, txtNote3.TextChanged, txtNote4.TextChanged, txtNote5.TextChanged,
            txtNote6.TextChanged, txtNote7.TextChanged, txtNote8.TextChanged, txtNote9.TextChanged
        If IsNumeric(sender.Text) = False Then
            sender.Text = ""
        End If

    End Sub
End Class