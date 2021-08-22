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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button_kirim = New System.Windows.Forms.Button()
        Me.Button_batal = New System.Windows.Forms.Button()
        Me.Button_hapus = New System.Windows.Forms.Button()
        Me.waktu = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Alamat = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.ComboBox_agama = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ComboBox_jeniskelamin = New System.Windows.Forms.ComboBox()
        Me.No_HP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Email = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.NIK = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Nama = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button_keluar = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(343, 44)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Form Pendaftaran"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Location = New System.Drawing.Point(21, 539)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(837, 197)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(151, 25)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Data Terdaftar"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(7, 67)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(824, 118)
        Me.DataGridView1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Button_kirim)
        Me.GroupBox1.Controls.Add(Me.Button_batal)
        Me.GroupBox1.Controls.Add(Me.Button_hapus)
        Me.GroupBox1.Controls.Add(Me.waktu)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Alamat)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.ComboBox_agama)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.ComboBox_jeniskelamin)
        Me.GroupBox1.Controls.Add(Me.No_HP)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Email)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.NIK)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Nama)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(661, 472)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'Button_kirim
        '
        Me.Button_kirim.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_kirim.Location = New System.Drawing.Point(265, 415)
        Me.Button_kirim.Name = "Button_kirim"
        Me.Button_kirim.Size = New System.Drawing.Size(108, 31)
        Me.Button_kirim.TabIndex = 79
        Me.Button_kirim.Text = "Kirim"
        Me.Button_kirim.UseVisualStyleBackColor = True
        '
        'Button_batal
        '
        Me.Button_batal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_batal.Location = New System.Drawing.Point(379, 415)
        Me.Button_batal.Name = "Button_batal"
        Me.Button_batal.Size = New System.Drawing.Size(108, 31)
        Me.Button_batal.TabIndex = 81
        Me.Button_batal.Text = "Batal"
        Me.Button_batal.UseVisualStyleBackColor = True
        '
        'Button_hapus
        '
        Me.Button_hapus.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_hapus.Location = New System.Drawing.Point(493, 415)
        Me.Button_hapus.Name = "Button_hapus"
        Me.Button_hapus.Size = New System.Drawing.Size(108, 31)
        Me.Button_hapus.TabIndex = 80
        Me.Button_hapus.Text = "Hapus"
        Me.Button_hapus.UseVisualStyleBackColor = True
        '
        'waktu
        '
        Me.waktu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.waktu.Location = New System.Drawing.Point(265, 360)
        Me.waktu.Multiline = True
        Me.waktu.Name = "waktu"
        Me.waktu.ReadOnly = True
        Me.waktu.Size = New System.Drawing.Size(183, 28)
        Me.waktu.TabIndex = 83
        Me.waktu.Text = "00/00/0000 00:00:00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(33, 363)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(154, 20)
        Me.Label6.TabIndex = 82
        Me.Label6.Text = "Date (Real Time)"
        '
        'Alamat
        '
        Me.Alamat.BackColor = System.Drawing.SystemColors.Window
        Me.Alamat.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Alamat.Location = New System.Drawing.Point(265, 232)
        Me.Alamat.Multiline = True
        Me.Alamat.Name = "Alamat"
        Me.Alamat.Size = New System.Drawing.Size(360, 122)
        Me.Alamat.TabIndex = 78
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(33, 235)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 20)
        Me.Label7.TabIndex = 77
        Me.Label7.Text = "Alamat"
        '
        'ComboBox_agama
        '
        Me.ComboBox_agama.FormattingEnabled = True
        Me.ComboBox_agama.Items.AddRange(New Object() {"Islam", "Kristen Protestan", "Kristen Katolik", "Buddha", "Hindu", "Konghucu", "Agama Lainnya"})
        Me.ComboBox_agama.Location = New System.Drawing.Point(265, 202)
        Me.ComboBox_agama.Name = "ComboBox_agama"
        Me.ComboBox_agama.Size = New System.Drawing.Size(124, 24)
        Me.ComboBox_agama.TabIndex = 71
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(33, 202)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 20)
        Me.Label10.TabIndex = 70
        Me.Label10.Text = "Agama"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(33, 173)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(127, 20)
        Me.Label9.TabIndex = 69
        Me.Label9.Text = "Jenis Kelamin"
        '
        'ComboBox_jeniskelamin
        '
        Me.ComboBox_jeniskelamin.FormattingEnabled = True
        Me.ComboBox_jeniskelamin.Items.AddRange(New Object() {"Laki-Laki", "Perempuan", "Lainnya"})
        Me.ComboBox_jeniskelamin.Location = New System.Drawing.Point(265, 169)
        Me.ComboBox_jeniskelamin.Name = "ComboBox_jeniskelamin"
        Me.ComboBox_jeniskelamin.Size = New System.Drawing.Size(124, 24)
        Me.ComboBox_jeniskelamin.TabIndex = 68
        '
        'No_HP
        '
        Me.No_HP.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.No_HP.Location = New System.Drawing.Point(265, 135)
        Me.No_HP.Multiline = True
        Me.No_HP.Name = "No_HP"
        Me.No_HP.Size = New System.Drawing.Size(183, 28)
        Me.No_HP.TabIndex = 52
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 20)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "No HP (+62)"
        '
        'Email
        '
        Me.Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email.Location = New System.Drawing.Point(265, 101)
        Me.Email.Multiline = True
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(360, 28)
        Me.Email.TabIndex = 39
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 104)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 20)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Email"
        '
        'NIK
        '
        Me.NIK.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NIK.Location = New System.Drawing.Point(265, 67)
        Me.NIK.Multiline = True
        Me.NIK.Name = "NIK"
        Me.NIK.Size = New System.Drawing.Size(360, 28)
        Me.NIK.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(33, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(192, 20)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Nomor Identitas (NIK)"
        '
        'Nama
        '
        Me.Nama.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nama.Location = New System.Drawing.Point(265, 33)
        Me.Nama.Multiline = True
        Me.Nama.Name = "Nama"
        Me.Nama.Size = New System.Drawing.Size(360, 28)
        Me.Nama.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nama"
        '
        'Button_keluar
        '
        Me.Button_keluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_keluar.Location = New System.Drawing.Point(730, 476)
        Me.Button_keluar.Name = "Button_keluar"
        Me.Button_keluar.Size = New System.Drawing.Size(108, 31)
        Me.Button_keluar.TabIndex = 4
        Me.Button_keluar.Text = "Keluar"
        Me.Button_keluar.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label11.Location = New System.Drawing.Point(454, 141)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(180, 17)
        Me.Label11.TabIndex = 84
        Me.Label11.Text = "contoh : 085156982660"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(879, 748)
        Me.Controls.Add(Me.Button_keluar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Pendaftaran"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Nama As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label8 As Label
    Friend WithEvents Button_kirim As Button
    Friend WithEvents Button_batal As Button
    Friend WithEvents Button_hapus As Button
    Friend WithEvents waktu As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Alamat As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents ComboBox_agama As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ComboBox_jeniskelamin As ComboBox
    Friend WithEvents No_HP As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Email As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents NIK As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button_keluar As Button
    Friend WithEvents Label11 As Label
End Class
