Public Class frmTP2
    Dim Tab(4, 9) As Integer
    Public var_test As Double

    Private Sub cmdEssai_Click(sender As Object, e As EventArgs) Handles cmdEssai.Click
        var_test = 10.5
        table_de_multiplication()
    End Sub

    Private Sub table_de_multiplication()
        Dim i, j As Integer
        For i = 1 To 5
            Debug.Print(String.Concat("Table de ", i))
            For j = 1 To 10
                Debug.Print(String.Concat(i, "x", j, "=", i * j))
                Tab(i - 1, j - 1) = i * j
            Next
        Next
        Debug.Print("fin")
    End Sub

    Private Sub cmdMoyenne_Click(sender As Object, e As EventArgs) Handles cmdMoyenne.Click
        Dim reponse, reponse2 As Integer
        Dim moyenne As Double

        Try
            moyenne = 0
            Do
                reponse = InputBox("Entrer le nombre de notes")

            Loop While reponse > 6 Or reponse < 1

            reponse2 = reponse

            If txtNote1.Text > 0 Then
                moyenne = moyenne + CDbl(txtNote1.Text)
            End If

            If txtNote2.Text > 0 Then
                moyenne = moyenne + CDbl(txtNote2.Text)
            End If

            If txtNote3.Text > 0 Then
                moyenne = moyenne + CDbl(txtNote3.Text)
            End If

            If txtNote4.Text > 0 Then
                moyenne = moyenne + CDbl(txtNote4.Text)
            End If

            If txtNote5.Text > 0 Then
                moyenne = moyenne + CDbl(txtNote5.Text)
            End If

            If txtNote6.Text > 0 Then
                moyenne = moyenne + CDbl(txtNote6.Text)
            End If

            moyenne = moyenne / reponse2
            lblMoyenne.Text = CStr(moyenne)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MessageBox.Show("fin")
        End Try




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Creé par Daniel GARCIA")
        Me.Close()
    End Sub

    Private Sub txtNote1_TextChanged(sender As Object, e As EventArgs) Handles txtNote1.TextChanged
        If IsNumeric(txtNote1.Text) = False Then
            txtNote1.Text = ""
        End If
    End Sub

    Private Sub txtNote_TextChanged(sender As Object, e As EventArgs) Handles txtNote1.TextChanged, txtNote2.TextChanged,
        txtNote3.TextChanged, txtNote4.TextChanged, txtNote5.TextChanged, txtNote6.TextChanged
        If IsNumeric(sender.Text) = False Then
            sender.Text = ""
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        frmTP2_bis.Show()
        Me.Hide()
    End Sub
End Class
