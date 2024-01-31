Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.X509

Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles menu_vms.Click
        Form3.ShowDialog()
    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub menu_ipam_Click(sender As Object, e As EventArgs) Handles menu_ipam.Click
        IPAM.ShowDialog()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        konek()
        cmd = New MySqlCommand("Select Count(*) FROM ipam", Koneksi)
        Dim count As Int32 = CType(cmd.ExecuteScalar(), Int32)
        show_ipam.Text = String.Format("{0}", count)

        cmd = New MySqlCommand("Select Count(*) FROM vms", Koneksi)
        Dim count2 As Int32 = CType(cmd.ExecuteScalar(), Int32)
        show_vms.Text = String.Format("{0}", count2)

        cmd = New MySqlCommand("Select Count(*) FROM r_s", Koneksi)
        Dim count3 As Int32 = CType(cmd.ExecuteScalar(), Int32)
        show_rs.Text = String.Format("{0}", count3)

        cmd = New MySqlCommand("Select Count(*) FROM hosts", Koneksi)
        Dim count4 As Int32 = CType(cmd.ExecuteScalar(), Int32)
        show_hosts.Text = String.Format("{0}", count4)

        da = New MySqlDataAdapter("SELECT * FROM ipam", Koneksi)
        dt = New DataTable
        da.Fill(dt)
        dgv_rcip.Rows.Clear()
        For i = 0 To dt.Rows.Count - 1
            dgv_rcip.Rows.Add(dt.Rows(i).Item(1))
        Next

        da = New MySqlDataAdapter("SELECT * FROM vms", Koneksi)
        dt = New DataTable
        da.Fill(dt)
        dgv_vms.Rows.Clear()
        For i = 0 To dt.Rows.Count - 1
            dgv_vms.Rows.Add(dt.Rows(i).Item(1))
        Next

        da = New MySqlDataAdapter("SELECT * FROM r_s", Koneksi)
        dt = New DataTable
        da.Fill(dt)
        dgv_rs2.Rows.Clear()
        For i = 0 To dt.Rows.Count - 1
            dgv_rs2.Rows.Add(dt.Rows(i).Item(1))
        Next

        Diskonek()

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles show_hosts.Click

    End Sub

    Private Sub show_vms_Click(sender As Object, e As EventArgs) Handles show_vms.Click

    End Sub

    Private Sub menu_rs_Click(sender As Object, e As EventArgs) Handles menu_rs.Click
        router_switch.ShowDialog()
    End Sub

    Private Sub menu_hosts_Click(sender As Object, e As EventArgs) Handles menu_hosts.Click
        Hosts.ShowDialog()
    End Sub
End Class