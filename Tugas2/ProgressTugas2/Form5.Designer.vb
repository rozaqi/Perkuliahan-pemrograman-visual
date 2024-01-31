<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Hosts
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
        tcari_hosts = New TextBox()
        cari = New Label()
        dgv_hosts = New DataGridView()
        bkeluar_hosts = New Button()
        bhapus_rs = New Button()
        bsimpan_hosts = New Button()
        bkosongkan_hosts = New Button()
        tdisk = New TextBox()
        tcores = New TextBox()
        tram = New TextBox()
        thost_name = New TextBox()
        tid_hosts = New TextBox()
        Label4 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        idrs = New Label()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        CType(dgv_hosts, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' tcari_hosts
        ' 
        tcari_hosts.Location = New Point(402, 48)
        tcari_hosts.Name = "tcari_hosts"
        tcari_hosts.Size = New Size(52, 23)
        tcari_hosts.TabIndex = 52
        ' 
        ' cari
        ' 
        cari.AutoSize = True
        cari.Font = New Font("Segoe UI Emoji", 12F)
        cari.Location = New Point(395, 14)
        cari.Name = "cari"
        cari.Size = New Size(150, 21)
        cari.TabIndex = 51
        cari.Text = "Find Data (Based ID)"
        ' 
        ' dgv_hosts
        ' 
        dgv_hosts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_hosts.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5})
        dgv_hosts.Location = New Point(12, 325)
        dgv_hosts.Name = "dgv_hosts"
        dgv_hosts.Size = New Size(615, 286)
        dgv_hosts.TabIndex = 50
        ' 
        ' bkeluar_hosts
        ' 
        bkeluar_hosts.Font = New Font("Segoe UI Emoji", 12F)
        bkeluar_hosts.Location = New Point(439, 288)
        bkeluar_hosts.Name = "bkeluar_hosts"
        bkeluar_hosts.Size = New Size(106, 31)
        bkeluar_hosts.TabIndex = 49
        bkeluar_hosts.Text = "Keluar"
        bkeluar_hosts.UseVisualStyleBackColor = True
        ' 
        ' bhapus_rs
        ' 
        bhapus_rs.Font = New Font("Segoe UI Emoji", 12F)
        bhapus_rs.Location = New Point(327, 288)
        bhapus_rs.Name = "bhapus_rs"
        bhapus_rs.Size = New Size(106, 31)
        bhapus_rs.TabIndex = 48
        bhapus_rs.Text = "Hapus"
        bhapus_rs.UseVisualStyleBackColor = True
        ' 
        ' bsimpan_hosts
        ' 
        bsimpan_hosts.Font = New Font("Segoe UI Emoji", 12F)
        bsimpan_hosts.Location = New Point(214, 288)
        bsimpan_hosts.Name = "bsimpan_hosts"
        bsimpan_hosts.Size = New Size(106, 31)
        bsimpan_hosts.TabIndex = 47
        bsimpan_hosts.Text = "Simpan"
        bsimpan_hosts.UseVisualStyleBackColor = True
        ' 
        ' bkosongkan_hosts
        ' 
        bkosongkan_hosts.Font = New Font("Segoe UI Emoji", 12F)
        bkosongkan_hosts.Location = New Point(103, 288)
        bkosongkan_hosts.Name = "bkosongkan_hosts"
        bkosongkan_hosts.Size = New Size(106, 31)
        bkosongkan_hosts.TabIndex = 46
        bkosongkan_hosts.Text = "Kosongkan"
        bkosongkan_hosts.UseVisualStyleBackColor = True
        ' 
        ' tdisk
        ' 
        tdisk.Location = New Point(159, 246)
        tdisk.Name = "tdisk"
        tdisk.Size = New Size(71, 23)
        tdisk.TabIndex = 45
        ' 
        ' tcores
        ' 
        tcores.Location = New Point(159, 187)
        tcores.Name = "tcores"
        tcores.Size = New Size(208, 23)
        tcores.TabIndex = 44
        ' 
        ' tram
        ' 
        tram.Location = New Point(159, 131)
        tram.Name = "tram"
        tram.Size = New Size(208, 23)
        tram.TabIndex = 43
        ' 
        ' thost_name
        ' 
        thost_name.Location = New Point(159, 76)
        thost_name.Name = "thost_name"
        thost_name.Size = New Size(208, 23)
        thost_name.TabIndex = 42
        ' 
        ' tid_hosts
        ' 
        tid_hosts.Location = New Point(159, 16)
        tid_hosts.Name = "tid_hosts"
        tid_hosts.Size = New Size(71, 23)
        tid_hosts.TabIndex = 41
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(16, 182)
        Label4.Name = "Label4"
        Label4.Size = New Size(138, 25)
        Label4.TabIndex = 40
        Label4.Text = "Cores & Thread :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(98, 241)
        Label3.Name = "Label3"
        Label3.Size = New Size(56, 25)
        Label3.TabIndex = 39
        Label3.Text = "Disk :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(93, 126)
        Label2.Name = "Label2"
        Label2.Size = New Size(61, 25)
        Label2.TabIndex = 38
        Label2.Text = "RAM :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(40, 71)
        Label1.Name = "Label1"
        Label1.Size = New Size(114, 25)
        Label1.TabIndex = 37
        Label1.Text = "Host Name :"
        ' 
        ' idrs
        ' 
        idrs.AutoSize = True
        idrs.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        idrs.Location = New Point(115, 14)
        idrs.Name = "idrs"
        idrs.Size = New Size(39, 25)
        idrs.TabIndex = 36
        idrs.Text = "ID :"
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "ID"
        Column1.Name = "Column1"
        Column1.Width = 80
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Host Name"
        Column2.Name = "Column2"
        Column2.Width = 160
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "RAM"
        Column3.Name = "Column3"
        Column3.Width = 130
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Cores & Thread"
        Column4.Name = "Column4"
        Column4.Width = 130
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Disk"
        Column5.Name = "Column5"
        Column5.Width = 80
        ' 
        ' Hosts
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(631, 612)
        Controls.Add(tcari_hosts)
        Controls.Add(cari)
        Controls.Add(dgv_hosts)
        Controls.Add(bkeluar_hosts)
        Controls.Add(bhapus_rs)
        Controls.Add(bsimpan_hosts)
        Controls.Add(bkosongkan_hosts)
        Controls.Add(tdisk)
        Controls.Add(tcores)
        Controls.Add(tram)
        Controls.Add(thost_name)
        Controls.Add(tid_hosts)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(idrs)
        Name = "Hosts"
        Text = "Hosts"
        CType(dgv_hosts, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tcari_hosts As TextBox
    Friend WithEvents cari As Label
    Friend WithEvents dgv_hosts As DataGridView
    Friend WithEvents bkeluar_hosts As Button
    Friend WithEvents bhapus_rs As Button
    Friend WithEvents bsimpan_hosts As Button
    Friend WithEvents bkosongkan_hosts As Button
    Friend WithEvents tdisk As TextBox
    Friend WithEvents tcores As TextBox
    Friend WithEvents tram As TextBox
    Friend WithEvents thost_name As TextBox
    Friend WithEvents tid_hosts As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents idrs As Label
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
