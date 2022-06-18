<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRDafNIK
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRDafNIK))
        Me.LVDafNIK = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TBNama = New System.Windows.Forms.TextBox()
        Me.TBNIK = New System.Windows.Forms.TextBox()
        Me.TBKK = New System.Windows.Forms.TextBox()
        Me.TBTeL = New System.Windows.Forms.TextBox()
        Me.TaL = New System.Windows.Forms.DateTimePicker()
        Me.CBJK = New System.Windows.Forms.ComboBox()
        Me.TBAlamat = New System.Windows.Forms.TextBox()
        Me.CBAgama = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.CBHK = New System.Windows.Forms.ComboBox()
        Me.CBPendidikan = New System.Windows.Forms.ComboBox()
        Me.CBSK = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CBKerja = New System.Windows.Forms.ComboBox()
        Me.TBAyah = New System.Windows.Forms.TextBox()
        Me.TBIbu = New System.Windows.Forms.TextBox()
        Me.IDAlamat = New System.Windows.Forms.Label()
        Me.LVAlamat = New System.Windows.Forms.ListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BCariKK = New System.Windows.Forms.Button()
        Me.BCariNIK = New System.Windows.Forms.Button()
        Me.BCariNama = New System.Windows.Forms.Button()
        Me.BTambah = New System.Windows.Forms.Button()
        Me.BUbah = New System.Windows.Forms.Button()
        Me.BHapus = New System.Windows.Forms.Button()
        Me.BKembali = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.CBWN = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'LVDafNIK
        '
        Me.LVDafNIK.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.LVDafNIK.GridLines = True
        Me.LVDafNIK.Location = New System.Drawing.Point(12, 461)
        Me.LVDafNIK.Name = "LVDafNIK"
        Me.LVDafNIK.Size = New System.Drawing.Size(680, 160)
        Me.LVDafNIK.TabIndex = 0
        Me.LVDafNIK.UseCompatibleStateImageBehavior = False
        Me.LVDafNIK.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "No. KK"
        Me.ColumnHeader1.Width = 160
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nama"
        Me.ColumnHeader2.Width = 200
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "NIK"
        Me.ColumnHeader3.Width = 160
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "NO."
        Me.ColumnHeader4.Width = 40
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Alamat"
        Me.ColumnHeader5.Width = 120
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "No. KK"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(367, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NIK"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(367, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nama"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Kewarganegaraan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 102)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 19)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Tempat Lahir"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(367, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 19)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Tanggal Lahir"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 142)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 19)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Jenis Kelamin"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 305)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 19)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Alamat"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(367, 305)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 19)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "<< Pilih Alamat"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(367, 142)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 19)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "Agama"
        '
        'TBNama
        '
        Me.TBNama.Location = New System.Drawing.Point(492, 59)
        Me.TBNama.Name = "TBNama"
        Me.TBNama.Size = New System.Drawing.Size(200, 26)
        Me.TBNama.TabIndex = 12
        '
        'TBNIK
        '
        Me.TBNIK.Location = New System.Drawing.Point(492, 19)
        Me.TBNIK.MaxLength = 16
        Me.TBNIK.Name = "TBNIK"
        Me.TBNIK.Size = New System.Drawing.Size(200, 26)
        Me.TBNIK.TabIndex = 13
        '
        'TBKK
        '
        Me.TBKK.Location = New System.Drawing.Point(147, 19)
        Me.TBKK.MaxLength = 16
        Me.TBKK.Name = "TBKK"
        Me.TBKK.Size = New System.Drawing.Size(200, 26)
        Me.TBKK.TabIndex = 14
        '
        'TBTeL
        '
        Me.TBTeL.Location = New System.Drawing.Point(147, 99)
        Me.TBTeL.Name = "TBTeL"
        Me.TBTeL.Size = New System.Drawing.Size(200, 26)
        Me.TBTeL.TabIndex = 15
        '
        'TaL
        '
        Me.TaL.Location = New System.Drawing.Point(492, 96)
        Me.TaL.Name = "TaL"
        Me.TaL.Size = New System.Drawing.Size(200, 26)
        Me.TaL.TabIndex = 16
        '
        'CBJK
        '
        Me.CBJK.FormattingEnabled = True
        Me.CBJK.Location = New System.Drawing.Point(147, 139)
        Me.CBJK.Name = "CBJK"
        Me.CBJK.Size = New System.Drawing.Size(200, 27)
        Me.CBJK.TabIndex = 17
        '
        'TBAlamat
        '
        Me.TBAlamat.Location = New System.Drawing.Point(147, 302)
        Me.TBAlamat.Name = "TBAlamat"
        Me.TBAlamat.Size = New System.Drawing.Size(200, 26)
        Me.TBAlamat.TabIndex = 18
        '
        'CBAgama
        '
        Me.CBAgama.FormattingEnabled = True
        Me.CBAgama.Location = New System.Drawing.Point(492, 139)
        Me.CBAgama.Name = "CBAgama"
        Me.CBAgama.Size = New System.Drawing.Size(200, 27)
        Me.CBAgama.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 183)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(90, 19)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "Status Kawin"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(367, 183)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(76, 19)
        Me.Label12.TabIndex = 21
        Me.Label12.Text = "Pendidikan"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 224)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(129, 19)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "Hubungan Keluarga"
        '
        'CBHK
        '
        Me.CBHK.FormattingEnabled = True
        Me.CBHK.Location = New System.Drawing.Point(147, 221)
        Me.CBHK.Name = "CBHK"
        Me.CBHK.Size = New System.Drawing.Size(200, 27)
        Me.CBHK.TabIndex = 23
        '
        'CBPendidikan
        '
        Me.CBPendidikan.FormattingEnabled = True
        Me.CBPendidikan.Location = New System.Drawing.Point(492, 180)
        Me.CBPendidikan.Name = "CBPendidikan"
        Me.CBPendidikan.Size = New System.Drawing.Size(200, 27)
        Me.CBPendidikan.TabIndex = 24
        '
        'CBSK
        '
        Me.CBSK.FormattingEnabled = True
        Me.CBSK.Location = New System.Drawing.Point(147, 180)
        Me.CBSK.Name = "CBSK"
        Me.CBSK.Size = New System.Drawing.Size(200, 27)
        Me.CBSK.TabIndex = 25
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(367, 224)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(70, 19)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Pekerjaan"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(12, 265)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 19)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "Nama Ayah"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(367, 265)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(70, 19)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "Nama Ibu"
        '
        'CBKerja
        '
        Me.CBKerja.FormattingEnabled = True
        Me.CBKerja.Location = New System.Drawing.Point(492, 224)
        Me.CBKerja.Name = "CBKerja"
        Me.CBKerja.Size = New System.Drawing.Size(200, 27)
        Me.CBKerja.TabIndex = 29
        '
        'TBAyah
        '
        Me.TBAyah.Location = New System.Drawing.Point(147, 262)
        Me.TBAyah.Name = "TBAyah"
        Me.TBAyah.Size = New System.Drawing.Size(200, 26)
        Me.TBAyah.TabIndex = 30
        '
        'TBIbu
        '
        Me.TBIbu.Location = New System.Drawing.Point(492, 262)
        Me.TBIbu.Name = "TBIbu"
        Me.TBIbu.Size = New System.Drawing.Size(200, 26)
        Me.TBIbu.TabIndex = 31
        '
        'IDAlamat
        '
        Me.IDAlamat.AutoSize = True
        Me.IDAlamat.Location = New System.Drawing.Point(367, 345)
        Me.IDAlamat.Name = "IDAlamat"
        Me.IDAlamat.Size = New System.Drawing.Size(0, 19)
        Me.IDAlamat.TabIndex = 32
        Me.IDAlamat.Visible = False
        '
        'LVAlamat
        '
        Me.LVAlamat.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7})
        Me.LVAlamat.GridLines = True
        Me.LVAlamat.Location = New System.Drawing.Point(492, 302)
        Me.LVAlamat.Name = "LVAlamat"
        Me.LVAlamat.Size = New System.Drawing.Size(200, 101)
        Me.LVAlamat.TabIndex = 33
        Me.LVAlamat.UseCompatibleStateImageBehavior = False
        Me.LVAlamat.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "NO."
        Me.ColumnHeader6.Width = 40
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Alamat"
        Me.ColumnHeader7.Width = 150
        '
        'BCariKK
        '
        Me.BCariKK.Location = New System.Drawing.Point(12, 420)
        Me.BCariKK.Name = "BCariKK"
        Me.BCariKK.Size = New System.Drawing.Size(90, 30)
        Me.BCariKK.TabIndex = 34
        Me.BCariKK.Text = "Cari KK"
        Me.BCariKK.UseVisualStyleBackColor = True
        '
        'BCariNIK
        '
        Me.BCariNIK.Location = New System.Drawing.Point(119, 420)
        Me.BCariNIK.Name = "BCariNIK"
        Me.BCariNIK.Size = New System.Drawing.Size(90, 30)
        Me.BCariNIK.TabIndex = 35
        Me.BCariNIK.Text = "Cari NIK"
        Me.BCariNIK.UseVisualStyleBackColor = True
        '
        'BCariNama
        '
        Me.BCariNama.Location = New System.Drawing.Point(236, 420)
        Me.BCariNama.Name = "BCariNama"
        Me.BCariNama.Size = New System.Drawing.Size(90, 30)
        Me.BCariNama.TabIndex = 36
        Me.BCariNama.Text = "Cari Nama"
        Me.BCariNama.UseVisualStyleBackColor = True
        '
        'BTambah
        '
        Me.BTambah.Location = New System.Drawing.Point(353, 420)
        Me.BTambah.Name = "BTambah"
        Me.BTambah.Size = New System.Drawing.Size(90, 30)
        Me.BTambah.TabIndex = 37
        Me.BTambah.Text = "TAMBAH"
        Me.BTambah.UseVisualStyleBackColor = True
        '
        'BUbah
        '
        Me.BUbah.Location = New System.Drawing.Point(479, 420)
        Me.BUbah.Name = "BUbah"
        Me.BUbah.Size = New System.Drawing.Size(90, 30)
        Me.BUbah.TabIndex = 38
        Me.BUbah.Text = "UBAH"
        Me.BUbah.UseVisualStyleBackColor = True
        '
        'BHapus
        '
        Me.BHapus.Location = New System.Drawing.Point(602, 420)
        Me.BHapus.Name = "BHapus"
        Me.BHapus.Size = New System.Drawing.Size(90, 30)
        Me.BHapus.TabIndex = 39
        Me.BHapus.Text = "HAPUS"
        Me.BHapus.UseVisualStyleBackColor = True
        '
        'BKembali
        '
        Me.BKembali.Location = New System.Drawing.Point(315, 639)
        Me.BKembali.Name = "BKembali"
        Me.BKembali.Size = New System.Drawing.Size(90, 30)
        Me.BKembali.TabIndex = 40
        Me.BKembali.Text = "KEMBALI"
        Me.BKembali.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(12, 442)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(680, 160)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'CBWN
        '
        Me.CBWN.FormattingEnabled = True
        Me.CBWN.Location = New System.Drawing.Point(147, 59)
        Me.CBWN.Name = "CBWN"
        Me.CBWN.Size = New System.Drawing.Size(200, 27)
        Me.CBWN.TabIndex = 41
        '
        'FRDafNIK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 681)
        Me.Controls.Add(Me.CBWN)
        Me.Controls.Add(Me.BKembali)
        Me.Controls.Add(Me.BHapus)
        Me.Controls.Add(Me.BUbah)
        Me.Controls.Add(Me.BTambah)
        Me.Controls.Add(Me.BCariNama)
        Me.Controls.Add(Me.BCariNIK)
        Me.Controls.Add(Me.BCariKK)
        Me.Controls.Add(Me.LVAlamat)
        Me.Controls.Add(Me.IDAlamat)
        Me.Controls.Add(Me.TBIbu)
        Me.Controls.Add(Me.TBAyah)
        Me.Controls.Add(Me.CBKerja)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.CBSK)
        Me.Controls.Add(Me.CBPendidikan)
        Me.Controls.Add(Me.CBHK)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.CBAgama)
        Me.Controls.Add(Me.TBAlamat)
        Me.Controls.Add(Me.CBJK)
        Me.Controls.Add(Me.TaL)
        Me.Controls.Add(Me.TBTeL)
        Me.Controls.Add(Me.TBKK)
        Me.Controls.Add(Me.TBNIK)
        Me.Controls.Add(Me.TBNama)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LVDafNIK)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(720, 720)
        Me.MinimumSize = New System.Drawing.Size(720, 720)
        Me.Name = "FRDafNIK"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Daftar NIK"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LVDafNIK As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TBNama As System.Windows.Forms.TextBox
    Friend WithEvents TBNIK As System.Windows.Forms.TextBox
    Friend WithEvents TBKK As System.Windows.Forms.TextBox
    Friend WithEvents TBTeL As System.Windows.Forms.TextBox
    Friend WithEvents TaL As System.Windows.Forms.DateTimePicker
    Friend WithEvents CBJK As System.Windows.Forms.ComboBox
    Friend WithEvents TBAlamat As System.Windows.Forms.TextBox
    Friend WithEvents CBAgama As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents CBHK As System.Windows.Forms.ComboBox
    Friend WithEvents CBPendidikan As System.Windows.Forms.ComboBox
    Friend WithEvents CBSK As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents CBKerja As System.Windows.Forms.ComboBox
    Friend WithEvents TBAyah As System.Windows.Forms.TextBox
    Friend WithEvents TBIbu As System.Windows.Forms.TextBox
    Friend WithEvents IDAlamat As System.Windows.Forms.Label
    Friend WithEvents LVAlamat As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents BCariKK As System.Windows.Forms.Button
    Friend WithEvents BCariNIK As System.Windows.Forms.Button
    Friend WithEvents BCariNama As System.Windows.Forms.Button
    Friend WithEvents BTambah As System.Windows.Forms.Button
    Friend WithEvents BUbah As System.Windows.Forms.Button
    Friend WithEvents BHapus As System.Windows.Forms.Button
    Friend WithEvents BKembali As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents CBWN As System.Windows.Forms.ComboBox
End Class
