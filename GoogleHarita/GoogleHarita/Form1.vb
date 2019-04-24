Imports System.Text

Public Class HaritaForm1
    Private Sub SplitContainer1_Panel2_Paint(sender As Object, e As PaintEventArgs) Handles SplitContainerGH.Panel2.Paint

    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub

    Private Sub adreseGitButton1_Click(sender As Object, e As EventArgs) Handles adreseGitButton1.Click
        Dim adres, sehir, ulke As String
        adres = adresTextBox1.Text.Trim
        sehir = sehirTextBox2.Text.Trim
        ulke = ulkeTextBox3.Text.Trim

        Dim Gezintiadres As New StringBuilder
        Gezintiadres.Append("https://maps.google.com/maps?q=")
        If adres.Length > 0 Then
            Gezintiadres.Append(adres + "," & "+")
        End If
        If sehir.Length > 0 Then
            Gezintiadres.Append(sehir + "," & "+")
        End If
        If ulke.Length > 0 Then
            Gezintiadres.Append(ulke + "," & "+")
        End If
        GHWebBrowser1.Navigate(Gezintiadres.ToString)
    End Sub
End Class
