Public Class Form1
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Start()
        waktu.Text = DateTime.Now.ToString
    End Sub
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Nama.Text = DataGridView1.Item(0, DataGridView1.CurrentRow.Index).Value.ToString
        No_HP.Text = DataGridView1.Item(3, DataGridView1.CurrentRow.Index).Value.ToString
        NIK.Text = DataGridView1.Item(1, DataGridView1.CurrentRow.Index).Value.ToString
        Email.Text = DataGridView1.Item(2, DataGridView1.CurrentRow.Index).Value.ToString
        waktu.Text = DataGridView1.Item(7, DataGridView1.CurrentRow.Index).Value.ToString
        Alamat.Text = DataGridView1.Item(6, DataGridView1.CurrentRow.Index).Value.ToString
        ComboBox_agama.Text = DataGridView1.Item(5, DataGridView1.CurrentRow.Index).Value.ToString
        ComboBox_jeniskelamin.Text = DataGridView1.Item(4, DataGridView1.CurrentRow.Index).Value.ToString
    End Sub

    Private Sub Button_kirim_Click_1(sender As Object, e As EventArgs) Handles Button_kirim.Click
        Try
            tambah_menu(NIK.Text, Nama.Text, No_HP.Text, Email.Text, waktu.Text, Alamat.Text, ComboBox_agama.Text, ComboBox_jeniskelamin.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Isi data dengan benar", MsgBoxStyle.Critical, "Message")
        End Try

        DataGridView1.DataSource = getTableGame()
    End Sub

    Private Sub Button_batal_Click_1(sender As Object, e As EventArgs) Handles Button_batal.Click
        hapus_menu(NIK.Text)
        DataGridView1.DataSource = getTableGame()
    End Sub

    Private Sub Button_hapus_Click_1(sender As Object, e As EventArgs) Handles Button_hapus.Click
        bersih_menu()
    End Sub

    Private Sub Button_keluar_Click_1(sender As Object, e As EventArgs) Handles Button_keluar.Click
        Me.Close()
    End Sub
End Class
