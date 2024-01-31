Imports System.Formats
Imports System.Security.Cryptography
Imports System.Text.Json
Imports MySql.Data.MySqlClient

Public Class router_switch
    Sub tampilData_rs()
        'buka koneksi database
        konek()
        da = New MySqlDataAdapter("SELECT * FROM r_s", Koneksi)
        dt = New DataTable
        da.Fill(dt)
        dgv_rs.Rows.Clear()
        For i = 0 To dt.Rows.Count - 1
            dgv_rs.Rows.Add(dt.Rows(i).Item(0))
            dgv_rs.Rows(i).Cells(1).Value = dt.Rows(i).Item(1)
            dgv_rs.Rows(i).Cells(2).Value = dt.Rows(i).Item(2)
            dgv_rs.Rows(i).Cells(3).Value = dt.Rows(i).Item(3)
            dgv_rs.Rows(i).Cells(4).Value = dt.Rows(i).Item(4)
        Next
        'tutup koneksi database
        Diskonek()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles idrs.Click

    End Sub

    Private Sub bkosongkan_rs_Click(sender As Object, e As EventArgs) Handles bkosongkan_rs.Click
        tid_rs.Text = ""
        tname_device.Text = ""
        ttype_device.Text = ""
        ttype.Text = ""
        ttport.Text = ""
    End Sub

    Private Sub bsimpan_vms_Click(sender As Object, e As EventArgs) Handles bsimpan_rs.Click
        'Simpan Baru
        Try
            konek()

            If ketemu_rs = True Then
                'Ubah Data
                Try
                    konek()

                    cmd = New MySqlCommand("UPDATE r_s SET device_name = '" & tname_device.Text & "', device_type = '" & ttype_device.Text & "', type = '" & ttype.Text & "', port = '" & ttport.Text & "' WHERE id = '" & tid_rs.Text & "' ", Koneksi)
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

                    cmd = New MySqlCommand("INSERT INTO r_s (id, device_name, device_type, type, port) VALUES ('" & tid_rs.Text & "','" & tname_device.Text & "','" & ttype_device.Text & "','" & ttype.Text & "', '" & ttport.Text & "')", Koneksi)
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

        tampilData_rs()
        bkosongkan_rs_Click(sender, e)

        Diskonek()
    End Sub

    Private Sub dgv_rs_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_rs.CellContentClick

    End Sub

    Private Sub bkeluar_rs_Click(sender As Object, e As EventArgs) Handles bkeluar_rs.Click
        Me.Close()
    End Sub

    Private Sub router_switch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilData_rs()
    End Sub

    Private Sub tid_rs_TextChanged(sender As Object, e As EventArgs) Handles tid_rs.TextChanged

    End Sub

    Private Sub tcari_rs_TextChanged(sender As Object, e As KeyPressEventArgs) Handles tcari_rs.KeyPress
        If e.KeyChar = Chr(13) Then
            konek()

            cmd = New MySqlCommand("SELECT * FROM r_s WHERE id = '" & tcari_rs.Text & "'", Koneksi)
            dr = cmd.ExecuteReader
            If dr.Read Then
                tid_rs.Text = dr.Item(0)
                tname_device.Text = dr.Item(1)
                ttype_device.Text = dr.Item(2)
                ttype.Text = dr.Item(3)
                ttport.Text = dr.Item(4)
                MsgBox("Data Ditemukan")
                ketemu_rs = True
            Else
                MsgBox("Maaf, Data tidak ditemukan!")
                bkosongkan_rs_Click(sender, e)
                tcari_rs.Focus()
                ketemu_rs = False
            End If


            Diskonek()

        End If
    End Sub

    Private Sub bhapus_rs_Click(sender As Object, e As EventArgs) Handles bhapus_rs.Click
        If ketemu_rs = True Then
            Try
                konek()

                If MessageBox.Show("Apakah Anda Yakin Akan Menghapus Data ini?", "Konfirmasi", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
                    cmd = New MySqlCommand("DELETE FROM r_s WHERE id = '" & tid_rs.Text & "' ", Koneksi)

                    cmd.ExecuteReader()
                    MsgBox("Hapus Data Sukses!")
                    tampilData_rs()
                    bkosongkan_rs_Click(sender, e)
                End If

                Diskonek()

            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End If
    End Sub

    Private Sub tcari_rs_TextChanged(sender As Object, e As EventArgs) Handles tcari_rs.TextChanged

    End Sub
End Class