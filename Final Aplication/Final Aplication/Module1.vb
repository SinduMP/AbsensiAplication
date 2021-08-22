Imports MySql.Data.MySqlClient
Module Module1
    Dim serv As String = "Server = localhost" & ";"
    Dim dbase As String = "Database = dbpendaftaran" & ";"
    Dim uid As String = "uid = root" & ";"
    Dim pwd As String = "pwd = root" & ";"
    'login
    'Dim ConString = serv & dbase & uid & pwd & "default command timeout = 3600; Allow User Variables = true"
    'non login
    Dim ConString = "server=localhost;user id=root;" &
                                "password=;database=dbpendaftaran"
    Public db As New MySqlConnection(ConString)
    Public myCommand As MySqlCommand
    Public myAdapter As MySqlDataAdapter
    Public myDataset As DataSet
    Public myReader As MySqlDataReader
    Public Sub bukaDB()
        Try
            tutupDB()
            db.Open()
            'MessageBox.Show("Connection Successfully", "Connection", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As MySqlException
            MessageBox.Show("Caution!" & ex.Message, "Connection", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Public Sub tutupDB()
        If db.State = ConnectionState.Open Then
            db.Close()
        End If
    End Sub
    'Form
    Public Function getTableGame() As DataTable
        Dim myDataTable As DataTable

        Try
            bukaDB()
            myCommand = New MySqlCommand("SELECT * FROM pendaftar ORDER BY NIK", db)
            myAdapter = New MySqlDataAdapter(myCommand)
            myDataset = New DataSet

            myAdapter.Fill(myDataset, "NIK")
            myDataTable = myDataset.Tables(0)
            Return (myDataTable)

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing

        Finally
            tutupDB()

        End Try
    End Function
    Public Function getViewGame(ByVal NIK As String) As DataTable
        Dim myViewTable As DataTable

        Try
            bukaDB()
            myCommand = New MySqlCommand("SELECT * FROM pendaftar WHERE NIK = @NIK", db)
            myCommand.Parameters.AddWithValue("@NIK", NIK)
            myAdapter = New MySqlDataAdapter(myCommand)
            myDataset = New DataSet
            myAdapter.Fill(myDataset, "NIK")
            myViewTable = myDataset.Tables(0)
            Return (myViewTable)

        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing

        Finally
            tutupDB()

        End Try
    End Function
    Public Sub tambah_menu(ByVal NIK As String, ByVal Nama As String, ByVal No_HP As String, ByVal Email As String, ByVal Waktu_Daftar As String, ByVal Alamat As String, ByVal Agama As String, ByVal Jenis_kelamin As String)
        myCommand = New MySqlCommand
        myCommand.Connection = db
        myCommand.CommandText = "INSERT INTO pendaftar (NIK, Nama, No_HP, Email, Waktu_Daftar, Alamat, Agama, Jenis_kelamin) VALUES (@NIK, @Nama, @No_HP, @Email, @Waktu_Daftar, @Alamat, @Agama, @Jenis_kelamin)"
        myCommand.Parameters.AddWithValue("@NIK", NIK)
        myCommand.Parameters.AddWithValue("@Nama", Nama)
        myCommand.Parameters.AddWithValue("@No_HP", No_HP)
        myCommand.Parameters.AddWithValue("@Email", Email)
        myCommand.Parameters.AddWithValue("@Waktu_Daftar", Waktu_Daftar)
        myCommand.Parameters.AddWithValue("@Alamat", Alamat)
        myCommand.Parameters.AddWithValue("@Agama", Agama)
        myCommand.Parameters.AddWithValue("@Jenis_kelamin", Jenis_kelamin)
        Try
            bukaDB()
            myCommand.ExecuteNonQuery()
            tutupDB()

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Gagal dalam menyimpan data")

        Finally
            tutupDB()

        End Try
    End Sub
    Public Sub hapus_menu(ByVal NIK As String)
        myCommand = New MySqlCommand
        myCommand.Connection = db
        myCommand.CommandText = "DELETE FROM pendaftar WHERE NIK = @NIK"
        myCommand.Parameters.AddWithValue("@NIK", NIK)

        Try
            bukaDB()
            myCommand.ExecuteNonQuery()
            bersih_menu()
            tutupDB()

        Catch ex As Exception
            MsgBox(ex.Message)
            MsgBox("Gagal menghapus data")
        Finally
            tutupDB()

        End Try
    End Sub
    Public Sub bersih_menu()
        With Form1
            .Nama.Text = ""
            .No_HP.Text = ""
            .NIK.Text = ""
            .Email.Text = ""
            .Alamat.Text = ""
        End With
    End Sub
End Module
