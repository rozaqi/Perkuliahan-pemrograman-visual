<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class router_switch
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
        idrs = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        tid_rs = New TextBox()
        tname_device = New TextBox()
        ttype_device = New TextBox()
        ttype = New TextBox()
        ttport = New TextBox()
        bkeluar_rs = New Button()
        bhapus_rs = New Button()
        bsimpan_rs = New Button()
        bkosongkan_rs = New Button()
        dgv_rs = New DataGridView()
        Column1 = New DataGridViewTextBoxColumn()
        Column2 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        Column4 = New DataGridViewTextBoxColumn()
        Column5 = New DataGridViewTextBoxColumn()
        tcari_rs = New TextBox()
        cari = New Label()
        CType(dgv_rs, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' idrs
        ' 
        idrs.AutoSize = True
        idrs.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        idrs.Location = New Point(105, 35)
        idrs.Name = "idrs"
        idrs.Size = New Size(39, 25)
        idrs.TabIndex = 0
        idrs.Text = "ID :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 92)
        Label1.Name = "Label1"
        Label1.Size = New Size(132, 25)
        Label1.TabIndex = 1
        Label1.Text = "Device Name :"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(23, 147)
        Label2.Name = "Label2"
        Label2.Size = New Size(121, 25)
        Label2.TabIndex = 2
        Label2.Text = "Device Type :"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(89, 262)
        Label3.Name = "Label3"
        Label3.Size = New Size(55, 25)
        Label3.TabIndex = 3
        Label3.Text = "Port :"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(84, 203)
        Label4.Name = "Label4"
        Label4.Size = New Size(60, 25)
        Label4.TabIndex = 4
        Label4.Text = "Type :"
        ' 
        ' tid_rs
        ' 
        tid_rs.Location = New Point(150, 37)
        tid_rs.Name = "tid_rs"
        tid_rs.Size = New Size(71, 23)
        tid_rs.TabIndex = 5
        ' 
        ' tname_device
        ' 
        tname_device.Location = New Point(150, 97)
        tname_device.Name = "tname_device"
        tname_device.Size = New Size(208, 23)
        tname_device.TabIndex = 6
        ' 
        ' ttype_device
        ' 
        ttype_device.Location = New Point(150, 152)
        ttype_device.Name = "ttype_device"
        ttype_device.Size = New Size(208, 23)
        ttype_device.TabIndex = 7
        ' 
        ' ttype
        ' 
        ttype.Location = New Point(150, 208)
        ttype.Name = "ttype"
        ttype.Size = New Size(208, 23)
        ttype.TabIndex = 8
        ' 
        ' ttport
        ' 
        ttport.Location = New Point(150, 267)
        ttport.Name = "ttport"
        ttport.Size = New Size(71, 23)
        ttport.TabIndex = 9
        ' 
        ' bkeluar_rs
        ' 
        bkeluar_rs.Font = New Font("Segoe UI Emoji", 12F)
        bkeluar_rs.Location = New Point(430, 309)
        bkeluar_rs.Name = "bkeluar_rs"
        bkeluar_rs.Size = New Size(106, 31)
        bkeluar_rs.TabIndex = 32
        bkeluar_rs.Text = "Keluar"
        bkeluar_rs.UseVisualStyleBackColor = True
        ' 
        ' bhapus_rs
        ' 
        bhapus_rs.Font = New Font("Segoe UI Emoji", 12F)
        bhapus_rs.Location = New Point(318, 309)
        bhapus_rs.Name = "bhapus_rs"
        bhapus_rs.Size = New Size(106, 31)
        bhapus_rs.TabIndex = 31
        bhapus_rs.Text = "Hapus"
        bhapus_rs.UseVisualStyleBackColor = True
        ' 
        ' bsimpan_rs
        ' 
        bsimpan_rs.Font = New Font("Segoe UI Emoji", 12F)
        bsimpan_rs.Location = New Point(205, 309)
        bsimpan_rs.Name = "bsimpan_rs"
        bsimpan_rs.Size = New Size(106, 31)
        bsimpan_rs.TabIndex = 30
        bsimpan_rs.Text = "Simpan"
        bsimpan_rs.UseVisualStyleBackColor = True
        ' 
        ' bkosongkan_rs
        ' 
        bkosongkan_rs.Font = New Font("Segoe UI Emoji", 12F)
        bkosongkan_rs.Location = New Point(94, 309)
        bkosongkan_rs.Name = "bkosongkan_rs"
        bkosongkan_rs.Size = New Size(106, 31)
        bkosongkan_rs.TabIndex = 29
        bkosongkan_rs.Text = "Kosongkan"
        bkosongkan_rs.UseVisualStyleBackColor = True
        ' 
        ' dgv_rs
        ' 
        dgv_rs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_rs.Columns.AddRange(New DataGridViewColumn() {Column1, Column2, Column3, Column4, Column5})
        dgv_rs.Location = New Point(3, 346)
        dgv_rs.Name = "dgv_rs"
        dgv_rs.Size = New Size(615, 286)
        dgv_rs.TabIndex = 33
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "ID"
        Column1.Name = "Column1"
        Column1.Width = 80
        ' 
        ' Column2
        ' 
        Column2.HeaderText = "Device Name"
        Column2.Name = "Column2"
        Column2.Width = 160
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Device Type"
        Column3.Name = "Column3"
        Column3.Width = 130
        ' 
        ' Column4
        ' 
        Column4.HeaderText = "Type"
        Column4.Name = "Column4"
        Column4.Width = 130
        ' 
        ' Column5
        ' 
        Column5.HeaderText = "Port"
        Column5.Name = "Column5"
        Column5.Width = 80
        ' 
        ' tcari_rs
        ' 
        tcari_rs.Location = New Point(393, 69)
        tcari_rs.Name = "tcari_rs"
        tcari_rs.Size = New Size(52, 23)
        tcari_rs.TabIndex = 35
        ' 
        ' cari
        ' 
        cari.AutoSize = True
        cari.Font = New Font("Segoe UI Emoji", 12F)
        cari.Location = New Point(386, 35)
        cari.Name = "cari"
        cari.Size = New Size(150, 21)
        cari.TabIndex = 34
        cari.Text = "Find Data (Based ID)"
        ' 
        ' router_switch
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(617, 625)
        Controls.Add(tcari_rs)
        Controls.Add(cari)
        Controls.Add(dgv_rs)
        Controls.Add(bkeluar_rs)
        Controls.Add(bhapus_rs)
        Controls.Add(bsimpan_rs)
        Controls.Add(bkosongkan_rs)
        Controls.Add(ttport)
        Controls.Add(ttype)
        Controls.Add(ttype_device)
        Controls.Add(tname_device)
        Controls.Add(tid_rs)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(idrs)
        Name = "router_switch"
        Text = "Router & Switch"
        CType(dgv_rs, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents idrs As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tid_rs As TextBox
    Friend WithEvents tname_device As TextBox
    Friend WithEvents ttype_device As TextBox
    Friend WithEvents ttype As TextBox
    Friend WithEvents ttport As TextBox
    Friend WithEvents bkeluar_rs As Button
    Friend WithEvents bhapus_rs As Button
    Friend WithEvents bsimpan_rs As Button
    Friend WithEvents bkosongkan_rs As Button
    Friend WithEvents dgv_rs As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents tcari_rs As TextBox
    Friend WithEvents cari As Label
End Class
