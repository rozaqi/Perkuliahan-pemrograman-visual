Imports MySql.Data.MySqlClient
Module MKoneksiMySQL
    Dim constring = "Server=localhost; Database=it_inventory; User=root; Password="
    Public Koneksi As New MySqlConnection(constring)

    Public da As MySqlDataAdapter = Nothing
    Public cmd As MySqlCommand = Nothing
    Public dt As New DataTable
    Public dr As MySqlDataReader
    Public ketemu As Boolean = False
    Public ketemu_vms As Boolean = False
    Public ketemu_rs As Boolean = False
    Public ketemu_hosts As Boolean = False
    Public Sub konek()
        Try
            If Not Koneksi Is Nothing Then Koneksi.Close()
            Koneksi.Open()
            ' MsgBox("Koneksi Berhasil dilakukan")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Function Diskonek()
        Koneksi.Close()
        Return Koneksi
    End Function
End Module
