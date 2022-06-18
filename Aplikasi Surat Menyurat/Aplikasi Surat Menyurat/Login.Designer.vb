<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRLogin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBPassword = New System.Windows.Forms.TextBox()
        Me.BBatal = New System.Windows.Forms.Button()
        Me.BLogin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(90, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "USERNAME"
        '
        'TBUsername
        '
        Me.TBUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBUsername.Location = New System.Drawing.Point(90, 100)
        Me.TBUsername.Name = "TBUsername"
        Me.TBUsername.Size = New System.Drawing.Size(300, 26)
        Me.TBUsername.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(90, 180)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "PASSWORD"
        '
        'TBPassword
        '
        Me.TBPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBPassword.Location = New System.Drawing.Point(90, 200)
        Me.TBPassword.Name = "TBPassword"
        Me.TBPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TBPassword.Size = New System.Drawing.Size(300, 26)
        Me.TBPassword.TabIndex = 3
        '
        'BBatal
        '
        Me.BBatal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBatal.Location = New System.Drawing.Point(90, 343)
        Me.BBatal.Name = "BBatal"
        Me.BBatal.Size = New System.Drawing.Size(100, 30)
        Me.BBatal.TabIndex = 4
        Me.BBatal.Text = "BATAL"
        Me.BBatal.UseVisualStyleBackColor = True
        '
        'BLogin
        '
        Me.BLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BLogin.Location = New System.Drawing.Point(290, 343)
        Me.BLogin.Name = "BLogin"
        Me.BLogin.Size = New System.Drawing.Size(100, 30)
        Me.BLogin.TabIndex = 5
        Me.BLogin.Text = "LOGIN"
        Me.BLogin.UseVisualStyleBackColor = True
        '
        'FRLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(464, 441)
        Me.Controls.Add(Me.BLogin)
        Me.Controls.Add(Me.BBatal)
        Me.Controls.Add(Me.TBPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TBUsername)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(480, 480)
        Me.MinimumSize = New System.Drawing.Size(480, 480)
        Me.Name = "FRLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TBUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TBPassword As System.Windows.Forms.TextBox
    Friend WithEvents BBatal As System.Windows.Forms.Button
    Friend WithEvents BLogin As System.Windows.Forms.Button
End Class
