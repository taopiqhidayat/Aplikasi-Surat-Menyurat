<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRRegSur
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRRegSur))
        Me.LVSurat = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.IDS = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TBWK = New System.Windows.Forms.TextBox()
        Me.TBPerihal = New System.Windows.Forms.TextBox()
        Me.TBNoS = New System.Windows.Forms.TextBox()
        Me.CBJS = New System.Windows.Forms.ComboBox()
        Me.CBKategori = New System.Windows.Forms.ComboBox()
        Me.Tanggal = New System.Windows.Forms.DateTimePicker()
        Me.RTBKeterangan = New System.Windows.Forms.RichTextBox()
        Me.BTamMas = New System.Windows.Forms.Button()
        Me.BTambah = New System.Windows.Forms.Button()
        Me.BUbah = New System.Windows.Forms.Button()
        Me.BTamKel = New System.Windows.Forms.Button()
        Me.BKembali = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.TAMBAH = New System.Windows.Forms.Button()
        Me.JT = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LVSurat
        '
        Me.LVSurat.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.LVSurat.GridLines = True
        Me.LVSurat.Location = New System.Drawing.Point(12, 389)
        Me.LVSurat.Name = "LVSurat"
        Me.LVSurat.Size = New System.Drawing.Size(680, 210)
        Me.LVSurat.TabIndex = 0
        Me.LVSurat.UseCompatibleStateImageBehavior = False
        Me.LVSurat.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "NO."
        Me.ColumnHeader1.Width = 40
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "No. Surat"
        Me.ColumnHeader2.Width = 160
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Perihal"
        Me.ColumnHeader3.Width = 200
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Waktu Kegiatan"
        Me.ColumnHeader4.Width = 180
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Tanggal"
        Me.ColumnHeader5.Width = 120
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Kategori Surat"
        '
        'IDS
        '
        Me.IDS.AutoSize = True
        Me.IDS.Location = New System.Drawing.Point(22, 227)
        Me.IDS.Name = "IDS"
        Me.IDS.Size = New System.Drawing.Size(0, 19)
        Me.IDS.TabIndex = 1
        Me.IDS.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 19)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "No. Surat"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 19)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Perihal"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 19)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Waktu Kegiatan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(369, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 19)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Jenis Surat"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(369, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 19)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Kategori"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(369, 109)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 19)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Tanggal"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 154)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 19)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Keterangan"
        '
        'TBWK
        '
        Me.TBWK.Location = New System.Drawing.Point(135, 106)
        Me.TBWK.Name = "TBWK"
        Me.TBWK.Size = New System.Drawing.Size(200, 26)
        Me.TBWK.TabIndex = 9
        '
        'TBPerihal
        '
        Me.TBPerihal.Location = New System.Drawing.Point(135, 61)
        Me.TBPerihal.Name = "TBPerihal"
        Me.TBPerihal.Size = New System.Drawing.Size(200, 26)
        Me.TBPerihal.TabIndex = 10
        '
        'TBNoS
        '
        Me.TBNoS.Location = New System.Drawing.Point(135, 16)
        Me.TBNoS.Name = "TBNoS"
        Me.TBNoS.Size = New System.Drawing.Size(200, 26)
        Me.TBNoS.TabIndex = 11
        '
        'CBJS
        '
        Me.CBJS.FormattingEnabled = True
        Me.CBJS.Location = New System.Drawing.Point(482, 16)
        Me.CBJS.Name = "CBJS"
        Me.CBJS.Size = New System.Drawing.Size(200, 27)
        Me.CBJS.TabIndex = 12
        '
        'CBKategori
        '
        Me.CBKategori.FormattingEnabled = True
        Me.CBKategori.Location = New System.Drawing.Point(482, 61)
        Me.CBKategori.Name = "CBKategori"
        Me.CBKategori.Size = New System.Drawing.Size(200, 27)
        Me.CBKategori.TabIndex = 13
        '
        'Tanggal
        '
        Me.Tanggal.Location = New System.Drawing.Point(482, 103)
        Me.Tanggal.Name = "Tanggal"
        Me.Tanggal.Size = New System.Drawing.Size(200, 26)
        Me.Tanggal.TabIndex = 14
        '
        'RTBKeterangan
        '
        Me.RTBKeterangan.Location = New System.Drawing.Point(125, 151)
        Me.RTBKeterangan.Name = "RTBKeterangan"
        Me.RTBKeterangan.Size = New System.Drawing.Size(555, 95)
        Me.RTBKeterangan.TabIndex = 15
        Me.RTBKeterangan.Text = ""
        '
        'BTamMas
        '
        Me.BTamMas.Location = New System.Drawing.Point(26, 293)
        Me.BTamMas.Name = "BTamMas"
        Me.BTamMas.Size = New System.Drawing.Size(165, 40)
        Me.BTamMas.TabIndex = 16
        Me.BTamMas.Text = "Tampilkan Surat Masuk"
        Me.BTamMas.UseVisualStyleBackColor = True
        '
        'BTambah
        '
        Me.BTambah.Location = New System.Drawing.Point(245, 293)
        Me.BTambah.Name = "BTambah"
        Me.BTambah.Size = New System.Drawing.Size(90, 40)
        Me.BTambah.TabIndex = 17
        Me.BTambah.Text = "TAMBAH"
        Me.BTambah.UseVisualStyleBackColor = True
        '
        'BUbah
        '
        Me.BUbah.Location = New System.Drawing.Point(373, 293)
        Me.BUbah.Name = "BUbah"
        Me.BUbah.Size = New System.Drawing.Size(90, 40)
        Me.BUbah.TabIndex = 19
        Me.BUbah.Text = "UBAH"
        Me.BUbah.UseVisualStyleBackColor = True
        '
        'BTamKel
        '
        Me.BTamKel.Location = New System.Drawing.Point(515, 293)
        Me.BTamKel.Name = "BTamKel"
        Me.BTamKel.Size = New System.Drawing.Size(165, 40)
        Me.BTamKel.TabIndex = 21
        Me.BTamKel.Text = "Tampilkan Surat Keluar"
        Me.BTamKel.UseVisualStyleBackColor = True
        '
        'BKembali
        '
        Me.BKembali.Location = New System.Drawing.Point(315, 620)
        Me.BKembali.Name = "BKembali"
        Me.BKembali.Size = New System.Drawing.Size(90, 30)
        Me.BKembali.TabIndex = 22
        Me.BKembali.Text = "KEMBALI"
        Me.BKembali.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(12, 352)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(680, 210)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'TAMBAH
        '
        Me.TAMBAH.Location = New System.Drawing.Point(168, 293)
        Me.TAMBAH.Name = "TAMBAH"
        Me.TAMBAH.Size = New System.Drawing.Size(90, 40)
        Me.TAMBAH.TabIndex = 17
        Me.TAMBAH.Text = "TAMBAH"
        Me.TAMBAH.UseVisualStyleBackColor = True
        '
        'JT
        '
        Me.JT.AutoSize = True
        Me.JT.Font = New System.Drawing.Font("Times New Roman", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.JT.Location = New System.Drawing.Point(245, 350)
        Me.JT.Name = "JT"
        Me.JT.Size = New System.Drawing.Size(240, 22)
        Me.JT.TabIndex = 23
        Me.JT.Text = "DAFTAR SURAT KELUAR"
        '
        'FRRegSur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 681)
        Me.Controls.Add(Me.JT)
        Me.Controls.Add(Me.BKembali)
        Me.Controls.Add(Me.BTamKel)
        Me.Controls.Add(Me.BUbah)
        Me.Controls.Add(Me.BTambah)
        Me.Controls.Add(Me.BTamMas)
        Me.Controls.Add(Me.RTBKeterangan)
        Me.Controls.Add(Me.Tanggal)
        Me.Controls.Add(Me.CBKategori)
        Me.Controls.Add(Me.CBJS)
        Me.Controls.Add(Me.TBNoS)
        Me.Controls.Add(Me.TBPerihal)
        Me.Controls.Add(Me.TBWK)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.IDS)
        Me.Controls.Add(Me.LVSurat)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(720, 720)
        Me.MinimumSize = New System.Drawing.Size(720, 720)
        Me.Name = "FRRegSur"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registrasi Surat"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LVSurat As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents IDS As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TBWK As System.Windows.Forms.TextBox
    Friend WithEvents TBPerihal As System.Windows.Forms.TextBox
    Friend WithEvents TBNoS As System.Windows.Forms.TextBox
    Friend WithEvents CBJS As System.Windows.Forms.ComboBox
    Friend WithEvents CBKategori As System.Windows.Forms.ComboBox
    Friend WithEvents Tanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents RTBKeterangan As System.Windows.Forms.RichTextBox
    Friend WithEvents BTamMas As System.Windows.Forms.Button
    Friend WithEvents BTambah As System.Windows.Forms.Button
    Friend WithEvents BUbah As System.Windows.Forms.Button
    Friend WithEvents BTamKel As System.Windows.Forms.Button
    Friend WithEvents BKembali As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents TAMBAH As System.Windows.Forms.Button
    Friend WithEvents JT As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
End Class
