Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'setting format tanggal
        DateTimePicker1.Format = DateTimePickerFormat.Custom
        DateTimePicker1.CustomFormat = "dd MMMM yyyy"
        DateTimePicker1.Value = Format(Now)
    End Sub

    Private Sub BtnTampilkan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTampilkan.Click
        Dim JK As String
        Dim Makanan As String
        Dim Minuman As String

        'menentukan jenis kelamin
        If RbLaki.Checked = True Then
            JK = RbLaki.Text
        Else
            JK = RbPerempuan.Text
        End If

        'menentukan menu makanan
        If CheckNasgor.Checked = True Then
            Makanan = Makanan & CheckNasgor.Text & ", "
        End If
        If CheckAyamBakar.Checked = True Then
            Makanan = Makanan & CheckAyamBakar.Text & ", "
        End If
        If CheckAyamGoreng.Checked = True Then
            Makanan = Makanan & CheckAyamGoreng.Text & ", "
        End If
        If CheckMieGoreng.Checked = True Then
            Makanan = Makanan & CheckMieGoreng.Text & ", "
        End If
        If CheckMieRebus.Checked = True Then
            Makanan = Makanan & CheckMieRebus.Text & ", "
        End If
        If CheckMieSetan.Checked = True Then
            Makanan = Makanan & CheckMieSetan.Text & ", "
        End If

        'menentukan menu minuman
        If CheckEsTeh.Checked = True Then
            Minuman = Minuman & CheckEsTeh.Text & ", "
        End If
        If CheckTehAnget.Checked = True Then
            Minuman = Minuman & CheckTehAnget.Text & ", "
        End If
        If CheckEsJeruk.Checked = True Then
            Minuman = Minuman & CheckEsJeruk.Text & ", "
        End If
        If CheckJusMangga.Checked = True Then
            Minuman = Minuman & CheckJusMangga.Text & ", "
        End If
        If CheckJusJambu.Checked = True Then
            Minuman = Minuman & CheckJusJambu.Text & ", "
        End If
        If CheckJusAlpukat.Checked = True Then
            Minuman = Minuman & CheckJusAlpukat.Text & ", "
        End If

        'menampilkan message pop up
        MessageBox.Show("Nama Pelanggan : " & TxtNama.Text & vbCrLf & "Jenis Kelamin : " & JK & vbCrLf & "Status : " & CmbStatus.Text & vbCrLf & "Nomor Meja : " & TxtNoMeja.Text & vbCrLf & "Pilihan Makanan : " & Makanan & vbCrLf & "Pilihan Minuman : " & Minuman & vbCrLf & "Tanggal Pemesanan : " & DateTimePicker1.Text, "Hasil Pengisian", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub TxtNoMeja_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNoMeja.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack) Then e.Handled = True
    End Sub

End Class
