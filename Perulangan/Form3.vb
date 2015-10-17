Public Class Form3


    Dim angka1, angka2 As Integer
    Dim hasil As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        angka1 = Convert.ToInt32(angka1Box.Text)
        angka2 = Convert.ToInt32(angka2Box.Text)
        If operasiBox.Text = "Tambah" Then
            hasil = angka1 + angka2
        Else
            hasil = angka1 - angka2
        End If
        hasilBox.Text = hasil
    End Sub
End Class