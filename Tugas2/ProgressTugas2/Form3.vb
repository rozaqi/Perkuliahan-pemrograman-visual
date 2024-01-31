Imports System.Formats
Imports System.Security.Cryptography
Imports MySql.Data.MySqlClient

Public Class Form3

    Sub tampilData_vms()
        'buka koneksi database
        konek()
        da = New MySqlDataAdapter("SELECT * FROM vms", Koneksi)
        dt = New DataTable
        da.Fill(dt)
        DGV_VMS.Rows.Clear()
        For i = 0 To dt.Rows.Count - 1
            DGV_VMS.Rows.Add(dt.Rows(i).Item(0))
            DGV_VMS.Rows(i).Cells(1).Value = dt.Rows(i).Item(1)
            DGV_VMS.Rows(i).Cells(2).Value = dt.Rows(i).Item(2)
            DGV_VMS.Rows(i).Cells(3).Value = dt.Rows(i).Item(3)
        Next
        'tutup koneksi database
        Diskonek()
    End Sub
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilData_vms()
    End Sub

    Private Sub bkosongkan_vms_Click(sender As Object, e As EventArgs) Handles bkosongkan_vms.Click
        tid_vms.Text = ""
        tvm_name.Text = ""
        tcluster.Text = ""
        tnotes.Text = ""
        tid_vms.Focus()
    End Sub

    Private Sub notes_TextChanged(sender As Object, e As EventArgs) Handles tnotes.TextChanged

    End Sub

    Private Sub DGV_VMS_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_VMS.CellContentClick

    End Sub

    Private Sub bkeluar_vms_Click(sender As Object, e As EventArgs) Handles bkeluar_vms.Click
        Me.Close()
    End Sub

    Private Sub bsimpan_vms_Click(sender As Object, e As EventArgs) Handles bsimpan_vms.Click
        'Simpan Baru
        Try
            konek()

            If ketemu_vms = True Then
                'Ubah Data
                Try
                    konek()

                    cmd = New MySqlCommand("UPDATE vms SET vm_name = '" & tvm_name.Text & "', cluster = '" & tcluster.Text & "', notes = '" & tnotes.Text & "' WHERE id = '" & tid_vms.Text & "' ", Koneksi)
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

                    cmd = New MySqlCommand("INSERT INTO vms (id, vm_name, cluster, notes) VALUES ('" & tid_vms.Text & "','" & tvm_name.Text & "','" & tcluster.Text & "', '" & tnotes.Text & "')", Koneksi)
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

        tampilData_vms()
        bkosongkan_vms_Click(sender, e)

        Diskonek()
    End Sub

    Private Sub tid_vms_TextChanged(sender As Object, e As EventArgs) Handles tid_vms.TextChanged

    End Sub

    Private Sub tcari_vms_TextChanged(sender As Object, e As KeyPressEventArgs) Handles tcari_vms.KeyPress
        If e.KeyChar = Chr(13) Then
            konek()

            cmd = New MySqlCommand("SELECT * FROM vms WHERE id = '" & tcari_vms.Text & "'", Koneksi)
            dr = cmd.ExecuteReader
            If dr.Read Then
                tid_vms.Text = dr.Item(0)
                tvm_name.Text = dr.Item(1)
                tcluster.Text = dr.Item(2)
                tnotes.Text = dr.Item(3)
                MsgBox("Data Ditemukan")
                ketemu_vms = True
            Else
                MsgBox("Maaf, Data tidak ditemukan!")
                bkosongkan_vms_Click(sender, e)
                tcari_vms.Focus()
                ketemu_vms = False
            End If


            Diskonek()

        End If
    End Sub

    Private Sub bhapus_vms_Click(sender As Object, e As EventArgs) Handles bhapus_vms.Click
        If ketemu_vms = True Then
            Try
                konek()

                If MessageBox.Show("Apakah Anda Yakin Akan Menghapus Data ini?", "Konfirmasi", MessageBoxButtons.YesNo) = System.Windows.Forms.DialogResult.Yes Then
                    cmd = New MySqlCommand("DELETE FROM vms WHERE id = '" & tid_vms.Text & "' ", Koneksi)

                    cmd.ExecuteReader()
                    MsgBox("Hapus Data Sukses!")
                    tampilData_vms()
                    bkosongkan_vms_Click(sender, e)
                End If

                Diskonek()

            Catch ex As Exception
                MsgBox(ex.Message)

            End Try
        End If
    End Sub

    Private Sub tcari_vms_TextChanged(sender As Object, e As EventArgs) Handles tcari_vms.TextChanged

    End Sub
End Class