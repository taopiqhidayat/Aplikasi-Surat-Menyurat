<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRDashboard))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LVDafOt = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BCariNamaOt = New System.Windows.Forms.Button()
        Me.BCariNIKOt = New System.Windows.Forms.Button()
        Me.TBNamaOt = New System.Windows.Forms.TextBox()
        Me.TBNIKOt = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LVDafDD = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BCariNama = New System.Windows.Forms.Button()
        Me.BCariNIK = New System.Windows.Forms.Button()
        Me.TBNama = New System.Windows.Forms.TextBox()
        Me.TBNIK = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BDomisili = New System.Windows.Forms.Button()
        Me.BSKTM = New System.Windows.Forms.Button()
        Me.BRegSur = New System.Windows.Forms.Button()
        Me.BDNIK = New System.Windows.Forms.Button()
        Me.BKeluar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.LVDafDD)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(563, 657)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LVDafOt)
        Me.GroupBox2.Controls.Add(Me.BCariNamaOt)
        Me.GroupBox2.Controls.Add(Me.BCariNIKOt)
        Me.GroupBox2.Controls.Add(Me.TBNamaOt)
        Me.GroupBox2.Controls.Add(Me.TBNIKOt)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Location = New System.Drawing.Point(20, 335)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(520, 307)
        Me.GroupBox2.TabIndex = 14
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Data Orangtua"
        '
        'LVDafOt
        '
        Me.LVDafOt.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.LVDafOt.GridLines = True
        Me.LVDafOt.Location = New System.Drawing.Point(15, 110)
        Me.LVDafOt.Name = "LVDafOt"
        Me.LVDafOt.Size = New System.Drawing.Size(490, 190)
        Me.LVDafOt.TabIndex = 13
        Me.LVDafOt.UseCompatibleStateImageBehavior = False
        Me.LVDafOt.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "NIK"
        Me.ColumnHeader4.Width = 160
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Nama"
        Me.ColumnHeader5.Width = 200
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Alamat "
        Me.ColumnHeader6.Width = 120
        '
        'BCariNamaOt
        '
        Me.BCariNamaOt.Location = New System.Drawing.Point(378, 70)
        Me.BCariNamaOt.Name = "BCariNamaOt"
        Me.BCariNamaOt.Size = New System.Drawing.Size(100, 30)
        Me.BCariNamaOt.TabIndex = 11
        Me.BCariNamaOt.Text = "Cari Nama"
        Me.BCariNamaOt.UseVisualStyleBackColor = True
        '
        'BCariNIKOt
        '
        Me.BCariNIKOt.Location = New System.Drawing.Point(378, 29)
        Me.BCariNIKOt.Name = "BCariNIKOt"
        Me.BCariNIKOt.Size = New System.Drawing.Size(100, 30)
        Me.BCariNIKOt.TabIndex = 10
        Me.BCariNIKOt.Text = "Cari NIK"
        Me.BCariNIKOt.UseVisualStyleBackColor = True
        '
        'TBNamaOt
        '
        Me.TBNamaOt.Location = New System.Drawing.Point(133, 74)
        Me.TBNamaOt.Name = "TBNamaOt"
        Me.TBNamaOt.Size = New System.Drawing.Size(200, 26)
        Me.TBNamaOt.TabIndex = 7
        '
        'TBNIKOt
        '
        Me.TBNIKOt.Location = New System.Drawing.Point(133, 26)
        Me.TBNIKOt.MaxLength = 16
        Me.TBNIKOt.Name = "TBNIKOt"
        Me.TBNIKOt.Size = New System.Drawing.Size(200, 26)
        Me.TBNIKOt.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 77)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 19)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nama Orangtua"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "NIK Orangtua"
        '
        'LVDafDD
        '
        Me.LVDafDD.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.LVDafDD.GridLines = True
        Me.LVDafDD.Location = New System.Drawing.Point(35, 130)
        Me.LVDafDD.Name = "LVDafDD"
        Me.LVDafDD.Size = New System.Drawing.Size(490, 190)
        Me.LVDafDD.TabIndex = 12
        Me.LVDafDD.UseCompatibleStateImageBehavior = False
        Me.LVDafDD.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "NIK"
        Me.ColumnHeader1.Width = 160
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nama"
        Me.ColumnHeader2.Width = 200
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Alamat"
        Me.ColumnHeader3.Width = 120
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.BCariNama)
        Me.GroupBox3.Controls.Add(Me.BCariNIK)
        Me.GroupBox3.Controls.Add(Me.TBNama)
        Me.GroupBox3.Controls.Add(Me.TBNIK)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(20, 20)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(520, 307)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Data Diri"
        '
        'BCariNama
        '
        Me.BCariNama.Location = New System.Drawing.Point(376, 69)
        Me.BCariNama.Name = "BCariNama"
        Me.BCariNama.Size = New System.Drawing.Size(100, 30)
        Me.BCariNama.TabIndex = 9
        Me.BCariNama.Text = "Cari Nama"
        Me.BCariNama.UseVisualStyleBackColor = True
        '
        'BCariNIK
        '
        Me.BCariNIK.Location = New System.Drawing.Point(376, 24)
        Me.BCariNIK.Name = "BCariNIK"
        Me.BCariNIK.Size = New System.Drawing.Size(100, 30)
        Me.BCariNIK.TabIndex = 8
        Me.BCariNIK.Text = "Cari NIK"
        Me.BCariNIK.UseVisualStyleBackColor = True
        '
        'TBNama
        '
        Me.TBNama.Location = New System.Drawing.Point(131, 72)
        Me.TBNama.Name = "TBNama"
        Me.TBNama.Size = New System.Drawing.Size(200, 26)
        Me.TBNama.TabIndex = 5
        '
        'TBNIK
        '
        Me.TBNIK.Location = New System.Drawing.Point(131, 24)
        Me.TBNIK.MaxLength = 16
        Me.TBNIK.Name = "TBNIK"
        Me.TBNIK.Size = New System.Drawing.Size(200, 26)
        Me.TBNIK.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nama"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NIK"
        '
        'BDomisili
        '
        Me.BDomisili.Location = New System.Drawing.Point(594, 20)
        Me.BDomisili.Name = "BDomisili"
        Me.BDomisili.Size = New System.Drawing.Size(90, 30)
        Me.BDomisili.TabIndex = 1
        Me.BDomisili.Text = "Domisili"
        Me.BDomisili.UseVisualStyleBackColor = True
        '
        'BSKTM
        '
        Me.BSKTM.Location = New System.Drawing.Point(594, 68)
        Me.BSKTM.Name = "BSKTM"
        Me.BSKTM.Size = New System.Drawing.Size(90, 30)
        Me.BSKTM.TabIndex = 2
        Me.BSKTM.Text = "SKTM"
        Me.BSKTM.UseVisualStyleBackColor = True
        '
        'BRegSur
        '
        Me.BRegSur.Location = New System.Drawing.Point(594, 116)
        Me.BRegSur.Name = "BRegSur"
        Me.BRegSur.Size = New System.Drawing.Size(90, 50)
        Me.BRegSur.TabIndex = 3
        Me.BRegSur.Text = "Registrasi Surat"
        Me.BRegSur.UseVisualStyleBackColor = True
        '
        'BDNIK
        '
        Me.BDNIK.Location = New System.Drawing.Point(594, 184)
        Me.BDNIK.Name = "BDNIK"
        Me.BDNIK.Size = New System.Drawing.Size(90, 30)
        Me.BDNIK.TabIndex = 4
        Me.BDNIK.Text = "Daftar NIK"
        Me.BDNIK.UseVisualStyleBackColor = True
        '
        'BKeluar
        '
        Me.BKeluar.Location = New System.Drawing.Point(594, 232)
        Me.BKeluar.Name = "BKeluar"
        Me.BKeluar.Size = New System.Drawing.Size(90, 30)
        Me.BKeluar.TabIndex = 5
        Me.BKeluar.Text = "KELUAR"
        Me.BKeluar.UseVisualStyleBackColor = True
        '
        'FRDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(704, 681)
        Me.Controls.Add(Me.BKeluar)
        Me.Controls.Add(Me.BDNIK)
        Me.Controls.Add(Me.BRegSur)
        Me.Controls.Add(Me.BSKTM)
        Me.Controls.Add(Me.BDomisili)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(720, 720)
        Me.MinimumSize = New System.Drawing.Size(720, 720)
        Me.Name = "FRDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplikasi Surat Menyurat Desa Kutawaringin"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BCariNamaOt As System.Windows.Forms.Button
    Friend WithEvents BCariNIKOt As System.Windows.Forms.Button
    Friend WithEvents BCariNama As System.Windows.Forms.Button
    Friend WithEvents BCariNIK As System.Windows.Forms.Button
    Friend WithEvents TBNamaOt As System.Windows.Forms.TextBox
    Friend WithEvents TBNIKOt As System.Windows.Forms.TextBox
    Friend WithEvents TBNama As System.Windows.Forms.TextBox
    Friend WithEvents TBNIK As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LVDafOt As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents LVDafDD As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents BDomisili As System.Windows.Forms.Button
    Friend WithEvents BSKTM As System.Windows.Forms.Button
    Friend WithEvents BRegSur As System.Windows.Forms.Button
    Friend WithEvents BDNIK As System.Windows.Forms.Button
    Friend WithEvents BKeluar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
End Class
