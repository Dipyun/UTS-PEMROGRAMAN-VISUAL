<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RbPerempuan = New System.Windows.Forms.RadioButton()
        Me.RbLaki = New System.Windows.Forms.RadioButton()
        Me.CmbStatus = New System.Windows.Forms.ComboBox()
        Me.TxtNoMeja = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CheckMieSetan = New System.Windows.Forms.CheckBox()
        Me.CheckMieRebus = New System.Windows.Forms.CheckBox()
        Me.CheckMieGoreng = New System.Windows.Forms.CheckBox()
        Me.CheckAyamGoreng = New System.Windows.Forms.CheckBox()
        Me.CheckAyamBakar = New System.Windows.Forms.CheckBox()
        Me.CheckNasgor = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.CheckJusAlpukat = New System.Windows.Forms.CheckBox()
        Me.CheckJusJambu = New System.Windows.Forms.CheckBox()
        Me.CheckJusMangga = New System.Windows.Forms.CheckBox()
        Me.CheckEsJeruk = New System.Windows.Forms.CheckBox()
        Me.CheckTehAnget = New System.Windows.Forms.CheckBox()
        Me.CheckEsTeh = New System.Windows.Forms.CheckBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.BtnTampilkan = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(298, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Aplikasi Pemesanan Menu Restoran"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nama Pelanggan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Jenis Kelamin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Status Member"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Nomor Meja"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Pilihan Makanan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 398)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Tanggal Pemesanan"
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(124, 44)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(206, 20)
        Me.TxtNama.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RbPerempuan)
        Me.GroupBox1.Controls.Add(Me.RbLaki)
        Me.GroupBox1.Location = New System.Drawing.Point(124, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(206, 46)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pilihan"
        '
        'RbPerempuan
        '
        Me.RbPerempuan.AutoSize = True
        Me.RbPerempuan.Location = New System.Drawing.Point(110, 19)
        Me.RbPerempuan.Name = "RbPerempuan"
        Me.RbPerempuan.Size = New System.Drawing.Size(79, 17)
        Me.RbPerempuan.TabIndex = 0
        Me.RbPerempuan.TabStop = True
        Me.RbPerempuan.Text = "Perempuan"
        Me.RbPerempuan.UseVisualStyleBackColor = True
        '
        'RbLaki
        '
        Me.RbLaki.AutoSize = True
        Me.RbLaki.Location = New System.Drawing.Point(17, 19)
        Me.RbLaki.Name = "RbLaki"
        Me.RbLaki.Size = New System.Drawing.Size(74, 17)
        Me.RbLaki.TabIndex = 0
        Me.RbLaki.TabStop = True
        Me.RbLaki.Text = "Laki - Laki"
        Me.RbLaki.UseVisualStyleBackColor = True
        '
        'CmbStatus
        '
        Me.CmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbStatus.FormattingEnabled = True
        Me.CmbStatus.Items.AddRange(New Object() {"Member", "Non Member"})
        Me.CmbStatus.Location = New System.Drawing.Point(124, 124)
        Me.CmbStatus.Name = "CmbStatus"
        Me.CmbStatus.Size = New System.Drawing.Size(205, 21)
        Me.CmbStatus.TabIndex = 3
        '
        'TxtNoMeja
        '
        Me.TxtNoMeja.Location = New System.Drawing.Point(124, 153)
        Me.TxtNoMeja.Name = "TxtNoMeja"
        Me.TxtNoMeja.Size = New System.Drawing.Size(206, 20)
        Me.TxtNoMeja.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CheckMieSetan)
        Me.GroupBox2.Controls.Add(Me.CheckMieRebus)
        Me.GroupBox2.Controls.Add(Me.CheckMieGoreng)
        Me.GroupBox2.Controls.Add(Me.CheckAyamGoreng)
        Me.GroupBox2.Controls.Add(Me.CheckAyamBakar)
        Me.GroupBox2.Controls.Add(Me.CheckNasgor)
        Me.GroupBox2.Location = New System.Drawing.Point(124, 181)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(205, 100)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pilihan Menu"
        '
        'CheckMieSetan
        '
        Me.CheckMieSetan.AutoSize = True
        Me.CheckMieSetan.Location = New System.Drawing.Point(119, 65)
        Me.CheckMieSetan.Name = "CheckMieSetan"
        Me.CheckMieSetan.Size = New System.Drawing.Size(74, 17)
        Me.CheckMieSetan.TabIndex = 0
        Me.CheckMieSetan.Text = "Mie Setan"
        Me.CheckMieSetan.UseVisualStyleBackColor = True
        '
        'CheckMieRebus
        '
        Me.CheckMieRebus.AutoSize = True
        Me.CheckMieRebus.Location = New System.Drawing.Point(119, 42)
        Me.CheckMieRebus.Name = "CheckMieRebus"
        Me.CheckMieRebus.Size = New System.Drawing.Size(77, 17)
        Me.CheckMieRebus.TabIndex = 0
        Me.CheckMieRebus.Text = "Mie Rebus"
        Me.CheckMieRebus.UseVisualStyleBackColor = True
        '
        'CheckMieGoreng
        '
        Me.CheckMieGoreng.AutoSize = True
        Me.CheckMieGoreng.Location = New System.Drawing.Point(119, 19)
        Me.CheckMieGoreng.Name = "CheckMieGoreng"
        Me.CheckMieGoreng.Size = New System.Drawing.Size(81, 17)
        Me.CheckMieGoreng.TabIndex = 0
        Me.CheckMieGoreng.Text = "Mie Goreng"
        Me.CheckMieGoreng.UseVisualStyleBackColor = True
        '
        'CheckAyamGoreng
        '
        Me.CheckAyamGoreng.AutoSize = True
        Me.CheckAyamGoreng.Location = New System.Drawing.Point(6, 65)
        Me.CheckAyamGoreng.Name = "CheckAyamGoreng"
        Me.CheckAyamGoreng.Size = New System.Drawing.Size(114, 17)
        Me.CheckAyamGoreng.TabIndex = 0
        Me.CheckAyamGoreng.Text = "Nasi Ayam Goreng"
        Me.CheckAyamGoreng.UseVisualStyleBackColor = True
        '
        'CheckAyamBakar
        '
        Me.CheckAyamBakar.AutoSize = True
        Me.CheckAyamBakar.Location = New System.Drawing.Point(6, 42)
        Me.CheckAyamBakar.Name = "CheckAyamBakar"
        Me.CheckAyamBakar.Size = New System.Drawing.Size(107, 17)
        Me.CheckAyamBakar.TabIndex = 0
        Me.CheckAyamBakar.Text = "Nasi Ayam Bakar"
        Me.CheckAyamBakar.UseVisualStyleBackColor = True
        '
        'CheckNasgor
        '
        Me.CheckNasgor.AutoSize = True
        Me.CheckNasgor.Location = New System.Drawing.Point(6, 19)
        Me.CheckNasgor.Name = "CheckNasgor"
        Me.CheckNasgor.Size = New System.Drawing.Size(85, 17)
        Me.CheckNasgor.TabIndex = 0
        Me.CheckNasgor.Text = "Nasi Goreng"
        Me.CheckNasgor.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 288)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(84, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Pilihan Minuman"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CheckJusAlpukat)
        Me.GroupBox3.Controls.Add(Me.CheckJusJambu)
        Me.GroupBox3.Controls.Add(Me.CheckJusMangga)
        Me.GroupBox3.Controls.Add(Me.CheckEsJeruk)
        Me.GroupBox3.Controls.Add(Me.CheckTehAnget)
        Me.GroupBox3.Controls.Add(Me.CheckEsTeh)
        Me.GroupBox3.Location = New System.Drawing.Point(124, 288)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(205, 100)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pilihan Menu"
        '
        'CheckJusAlpukat
        '
        Me.CheckJusAlpukat.AutoSize = True
        Me.CheckJusAlpukat.Location = New System.Drawing.Point(112, 65)
        Me.CheckJusAlpukat.Name = "CheckJusAlpukat"
        Me.CheckJusAlpukat.Size = New System.Drawing.Size(81, 17)
        Me.CheckJusAlpukat.TabIndex = 0
        Me.CheckJusAlpukat.Text = "Jus Alpukat"
        Me.CheckJusAlpukat.UseVisualStyleBackColor = True
        '
        'CheckJusJambu
        '
        Me.CheckJusJambu.AutoSize = True
        Me.CheckJusJambu.Location = New System.Drawing.Point(112, 42)
        Me.CheckJusJambu.Name = "CheckJusJambu"
        Me.CheckJusJambu.Size = New System.Drawing.Size(76, 17)
        Me.CheckJusJambu.TabIndex = 0
        Me.CheckJusJambu.Text = "Jus Jambu"
        Me.CheckJusJambu.UseVisualStyleBackColor = True
        '
        'CheckJusMangga
        '
        Me.CheckJusMangga.AutoSize = True
        Me.CheckJusMangga.Location = New System.Drawing.Point(112, 19)
        Me.CheckJusMangga.Name = "CheckJusMangga"
        Me.CheckJusMangga.Size = New System.Drawing.Size(84, 17)
        Me.CheckJusMangga.TabIndex = 0
        Me.CheckJusMangga.Text = "Jus Mangga"
        Me.CheckJusMangga.UseVisualStyleBackColor = True
        '
        'CheckEsJeruk
        '
        Me.CheckEsJeruk.AutoSize = True
        Me.CheckEsJeruk.Location = New System.Drawing.Point(6, 65)
        Me.CheckEsJeruk.Name = "CheckEsJeruk"
        Me.CheckEsJeruk.Size = New System.Drawing.Size(67, 17)
        Me.CheckEsJeruk.TabIndex = 0
        Me.CheckEsJeruk.Text = "Es Jeruk"
        Me.CheckEsJeruk.UseVisualStyleBackColor = True
        '
        'CheckTehAnget
        '
        Me.CheckTehAnget.AutoSize = True
        Me.CheckTehAnget.Location = New System.Drawing.Point(6, 42)
        Me.CheckTehAnget.Name = "CheckTehAnget"
        Me.CheckTehAnget.Size = New System.Drawing.Size(107, 17)
        Me.CheckTehAnget.TabIndex = 0
        Me.CheckTehAnget.Text = "Teh Anget Manis"
        Me.CheckTehAnget.UseVisualStyleBackColor = True
        '
        'CheckEsTeh
        '
        Me.CheckEsTeh.AutoSize = True
        Me.CheckEsTeh.Location = New System.Drawing.Point(6, 19)
        Me.CheckEsTeh.Name = "CheckEsTeh"
        Me.CheckEsTeh.Size = New System.Drawing.Size(91, 17)
        Me.CheckEsTeh.TabIndex = 0
        Me.CheckEsTeh.Text = "Es Teh Manis"
        Me.CheckEsTeh.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(124, 396)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(206, 20)
        Me.DateTimePicker1.TabIndex = 5
        '
        'BtnTampilkan
        '
        Me.BtnTampilkan.Location = New System.Drawing.Point(122, 425)
        Me.BtnTampilkan.Name = "BtnTampilkan"
        Me.BtnTampilkan.Size = New System.Drawing.Size(122, 51)
        Me.BtnTampilkan.TabIndex = 6
        Me.BtnTampilkan.Text = "Tampilkan"
        Me.BtnTampilkan.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(348, 485)
        Me.Controls.Add(Me.BtnTampilkan)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.CmbStatus)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtNoMeja)
        Me.Controls.Add(Me.TxtNama)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplikasi Pemesanan Menu Restoran"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtNama As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RbPerempuan As System.Windows.Forms.RadioButton
    Friend WithEvents RbLaki As System.Windows.Forms.RadioButton
    Friend WithEvents CmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents TxtNoMeja As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckMieSetan As System.Windows.Forms.CheckBox
    Friend WithEvents CheckMieRebus As System.Windows.Forms.CheckBox
    Friend WithEvents CheckMieGoreng As System.Windows.Forms.CheckBox
    Friend WithEvents CheckAyamGoreng As System.Windows.Forms.CheckBox
    Friend WithEvents CheckAyamBakar As System.Windows.Forms.CheckBox
    Friend WithEvents CheckNasgor As System.Windows.Forms.CheckBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckJusAlpukat As System.Windows.Forms.CheckBox
    Friend WithEvents CheckJusJambu As System.Windows.Forms.CheckBox
    Friend WithEvents CheckJusMangga As System.Windows.Forms.CheckBox
    Friend WithEvents CheckEsJeruk As System.Windows.Forms.CheckBox
    Friend WithEvents CheckTehAnget As System.Windows.Forms.CheckBox
    Friend WithEvents CheckEsTeh As System.Windows.Forms.CheckBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents BtnTampilkan As System.Windows.Forms.Button

End Class
