Imports MySql.Data.MySqlClient
Public Class IPAM

    Sub tampilData()
        'buka koneksi database
        konek()
        da = New MySqlDataAdapter("SELECT * FROM ipam", Koneksi)
        dt = New DataTable
        da.Fill(dt)
        DGV.Rows.Clear()
        For i = 0 To dt.Rows.Count - 1
            DGV.Rows.Add(dt.Rows(i).Item(0))
            DGV.Rows(i).Cells(1).Value = dt.Rows(i).Item(1)
            DGV.Rows(i).Cells(2).Value = dt.Rows(i).Item(2)
            DGV.Rows(i).Cells(3).Value = dt.Rows(i).Item(3)
        Next
        'tutup koneksi database
        Diskonek()
    End Sub
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lid.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lip.Click

    End Sub

    Private Sub bkosongkan_Click(sender As Object, e As EventArgs) Handles bkosongkan.Click
        tid.Text = ""
        tip.Text = ""
        tgw.Text = ""
        cassign.Text = ""
        tid.Focus()
    End Sub

    Private Sub bsimpan_Click(sender As Object, e As EventArgs) Handles bsimpan.Click
        'Uji jika ketemu = true, maka edit data, selain itu simpan batu
        If ketemu = True Then
            'Ubah Data
            Try
                konek()

                cmd = New MySqlCommand("UPDATE ipam SET ip_address = '" & tip.Text & "', gateway = '" & tgw.Text & "', assign_to_vm = '" & cassign.Text & "' WHERE id = '" & tid.Text & "' ", Koneksi)
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

                cmd = New MySqlCommand("INSERT INTO ipam (id, ip_address, gateway, assign_to_vm) VALUES ('" & tid.Text & "','" & tip.Text & "','" & tgw.Text & "', '" & cassign.Text & "')", Koneksi)
                cmd.ExecuteNonQuery()
                MsgBox("Simpan Data Sukses!")


                Diskonek()
            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End If


        tampilData()
        bkosongkan_Click(sender, e)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellContentClick

    End Sub

    Private Sub bkeluar_Click(sender As Object, e As EventArgs) Handles bkeluar.Click
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        tampilData()
    End Sub

    Private Sub cassign_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cassign.Click

        Dim cmd As New MySqlCommand("SELECT id,vm_name FROM vms", Koneksi)
        Dim da As New MySqlDataAdapter(cmd)
        Dim dt As New DataTable
        da.Fill(dt)
        cassign.DataSource = dt
        cassign.DisplayMember = "vm_name"
        cassign.ValueMember = "id"
        cassign.Text = "Select VM"


    End Sub

    Private Sub cari_Click(sender As Object, e As EventArgs) Handles cari.Click

    End Sub

    Private Sub tcari_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tcari.KeyPress
        If e.KeyChar = Chr(13) Then
            konek()

            cmd = New MySqlCommand("SELECT * FROM ipam WHERE id = '" & tcari.Text & "'", Koneksi)
            dr = cmd.ExecuteReader
            If dr.Read Then
                tid.Text = dr.Item(0)
                tip.Text = dr.Item(1)
                tgw.Text = dr.Item(2)
                cassign.Text = dr.Item(3)
                MsgBox("Data Ditemukan")
                ketemu = True
            Else
                MsgBox("Maaf, Data tidak ditemukan!")
                ' bkosongkan_Click(sender, e)
                tid.Focus()
                ketemu = False
            End If


            Diskonek()

        End If
    End Sub

    Private Sub bhapus_Click(sender As Object, e As EventArgs) Handles bhapus.Click
        If ketemu = True Then
            Try
                konek()

                If MessageBox.Show("Apakah Anda Yakin Akan Menghapus Data ini?", "Konfirmasi", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
                    cmd = New MySqlCommand("DELETE FROM ipam WHERE id = '" & tid.Text & "' ", Koneksi)

                    cmd.ExecuteReader()
                    MsgBox("Hapus Data Sukses!")
                    tampilData()
                    bkosongkan_Click(sender, e)
                End If

                Diskonek()

            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End If
    End Sub

End Class
