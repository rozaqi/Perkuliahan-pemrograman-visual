Imports MySql.Data.MySqlClient

Public Class Hosts
    Sub tampilData_hosts()
        'buka koneksi database
        konek()
        da = New MySqlDataAdapter("SELECT * FROM hosts", Koneksi)
        dt = New DataTable
        da.Fill(dt)
        dgv_hosts.Rows.Clear()
        For i = 0 To dt.Rows.Count - 1
            dgv_hosts.Rows.Add(dt.Rows(i).Item(0))
            dgv_hosts.Rows(i).Cells(1).Value = dt.Rows(i).Item(1)
            dgv_hosts.Rows(i).Cells(2).Value = dt.Rows(i).Item(2)
            dgv_hosts.Rows(i).Cells(3).Value = dt.Rows(i).Item(3)
            dgv_hosts.Rows(i).Cells(4).Value = dt.Rows(i).Item(4)
        Next
        'tutup koneksi database
        Diskonek()
    End Sub

    Private Sub bkosongkan_hosts_Click(sender As Object, e As EventArgs) Handles bkosongkan_hosts.Click
        tid_hosts.Text = ""
        thost_name.Text = ""
        tram.Text = ""
        tcores.Text = ""
        tdisk.Text = ""
    End Sub

    Private Sub bkeluar_rs_Click(sender As Object, e As EventArgs) Handles bkeluar_hosts.Click
        Me.Close()
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilData_hosts()
    End Sub

    Private Sub bsimpan_rs_Click(sender As Object, e As EventArgs) Handles bsimpan_hosts.Click
        'Simpan Baru
        Try
            konek()

            If ketemu_hosts = True Then
                'Ubah Data
                Try
                    konek()

                    cmd = New MySqlCommand("UPDATE hosts SET host_name = '" & thost_name.Text & "', ram = '" & tram.Text & "', cores_thread = '" & tcores.Text & "', disk = '" & tdisk.Text & "' WHERE id = '" & tid_hosts.Text & "' ", Koneksi)
                    cmd.ExecuteNonQuery()
                    MsgBox("Ubah Data Sukses!")


                    Diskonek()
                Catch ex As Exception
                    MsgBox(ex.Message)

                End Try
            Else
                'Simpan Baru
                Try
                    konek()

                    cmd = New MySqlCommand("INSERT INTO hosts (id, host_name, ram, cores_thread, disk) VALUES ('" & tid_hosts.Text & "','" & thost_name.Text & "','" & tram.Text & "','" & tcores.Text & "', '" & tdisk.Text & "')", Koneksi)
                    cmd.ExecuteNonQuery()
                    MsgBox("Simpan Data Sukses!")


                    Diskonek()
                Catch ex As Exception
                    MsgBox(ex.Message)

                End Try
            End If
            Diskonek()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        tampilData_hosts()
        bkosongkan_hosts_Click(sender, e)

        Diskonek()
    End Sub


    Private Sub tcari_hosts_TextChanged(sender As Object, e As KeyPressEventArgs) Handles tcari_hosts.KeyPress
        If e.KeyChar = Chr(13) Then
            konek()

            cmd = New MySqlCommand("SELECT * FROM hosts WHERE id = '" & tcari_hosts.Text & "'", Koneksi)
            dr = cmd.ExecuteReader
            If dr.Read Then
                tid_hosts.Text = dr.Item(0)
                thost_name.Text = dr.Item(1)
                tram.Text = dr.Item(2)
                tcores.Text = dr.Item(3)
                tdisk.Text = dr.Item(4)
                MsgBox("Data Ditemukan")
                ketemu_hosts = True
            Else
                MsgBox("Maaf, Data tidak ditemukan!")
                bkosongkan_hosts_Click(sender, e)
                tcari_hosts.Focus()
                ketemu_hosts = False
            End If


            Diskonek()

        End If
    End Sub

    Private Sub bhapus_rs_Click(sender As Object, e As EventArgs) Handles bhapus_rs.Click
        If ketemu_hosts = True Then
            Try
                konek()

                If MessageBox.Show("Apakah Anda Yakin Akan Menghapus Data ini?", "Konfirmasi", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
                    cmd = New MySqlCommand("DELETE FROM hosts WHERE id = '" & tid_hosts.Text & "' ", Koneksi)

                    cmd.ExecuteReader()
                    MsgBox("Hapus Data Sukses!")
                    tampilData_hosts()
                    bkosongkan_hosts_Click(sender, e)
                End If

                Diskonek()

            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End If
    End Sub
End Class