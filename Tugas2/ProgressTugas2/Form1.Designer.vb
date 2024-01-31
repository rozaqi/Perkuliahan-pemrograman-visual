<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IPAM
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lid = New Label()
        lip = New Label()
        lgw = New Label()
        lassign = New Label()
        tid = New TextBox()
        tip = New TextBox()
        tgw = New TextBox()
        cassign = New ComboBox()
        bkosongkan = New Button()
        bsimpan = New Button()
        bhapus = New Button()
        DGV = New DataGridView()
        ID = New DataGridViewTextBoxColumn()
        Column1 = New DataGridViewTextBoxColumn()
        Column3 = New DataGridViewTextBoxColumn()
        column4 = New DataGridViewTextBoxColumn()
        bkeluar = New Button()
        cari = New Label()
        tcari = New TextBox()
        CType(DGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lid
        ' 
        lid.AutoSize = True
        lid.Font = New Font("Segoe UI Emoji", 12F)
        lid.Location = New Point(96, 46)
        lid.Name = "lid"
        lid.Size = New Size(36, 21)
        lid.TabIndex = 0
        lid.Text = "ID : "
        ' 
        ' lip
        ' 
        lip.AutoSize = True
        lip.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lip.Location = New Point(38, 102)
        lip.Name = "lip"
        lip.Size = New Size(94, 21)
        lip.TabIndex = 1
        lip.Text = "IP Address : "
        ' 
        ' lgw
        ' 
        lgw.AutoSize = True
        lgw.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lgw.Location = New Point(51, 167)
        lgw.Name = "lgw"
        lgw.Size = New Size(81, 21)
        lgw.TabIndex = 2
        lgw.Text = "Gateway : "
        ' 
        ' lassign
        ' 
        lassign.AutoSize = True
        lassign.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lassign.Location = New Point(19, 224)
        lassign.Name = "lassign"
        lassign.Size = New Size(113, 21)
        lassign.TabIndex = 3
        lassign.Text = "Assign to VM : "
        ' 
        ' tid
        ' 
        tid.Location = New Point(138, 43)
        tid.Name = "tid"
        tid.Size = New Size(54, 29)
        tid.TabIndex = 4
        ' 
        ' tip
        ' 
        tip.Location = New Point(138, 99)
        tip.Name = "tip"
        tip.Size = New Size(177, 29)
        tip.TabIndex = 5
        ' 
        ' tgw
        ' 
        tgw.Location = New Point(138, 164)
        tgw.Name = "tgw"
        tgw.Size = New Size(177, 29)
        tgw.TabIndex = 6
        ' 
        ' cassign
        ' 
        cassign.DropDownStyle = ComboBoxStyle.DropDownList
        cassign.FormattingEnabled = True
        cassign.Location = New Point(138, 224)
        cassign.Name = "cassign"
        cassign.Size = New Size(177, 29)
        cassign.TabIndex = 8
        ' 
        ' bkosongkan
        ' 
        bkosongkan.Font = New Font("Segoe UI Emoji", 12F)
        bkosongkan.Location = New Point(57, 284)
        bkosongkan.Name = "bkosongkan"
        bkosongkan.Size = New Size(106, 31)
        bkosongkan.TabIndex = 9
        bkosongkan.Text = "Kosongkan"
        bkosongkan.UseVisualStyleBackColor = True
        ' 
        ' bsimpan
        ' 
        bsimpan.Font = New Font("Segoe UI Emoji", 12F)
        bsimpan.Location = New Point(168, 284)
        bsimpan.Name = "bsimpan"
        bsimpan.Size = New Size(106, 31)
        bsimpan.TabIndex = 10
        bsimpan.Text = "Simpan"
        bsimpan.UseVisualStyleBackColor = True
        ' 
        ' bhapus
        ' 
        bhapus.Font = New Font("Segoe UI Emoji", 12F)
        bhapus.Location = New Point(281, 284)
        bhapus.Name = "bhapus"
        bhapus.Size = New Size(106, 31)
        bhapus.TabIndex = 11
        bhapus.Text = "Hapus"
        bhapus.UseVisualStyleBackColor = True
        ' 
        ' DGV
        ' 
        DGV.BackgroundColor = SystemColors.ActiveCaption
        DGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV.Columns.AddRange(New DataGridViewColumn() {ID, Column1, Column3, column4})
        DGV.GridColor = SystemColors.InactiveBorder
        DGV.Location = New Point(19, 330)
        DGV.Name = "DGV"
        DGV.Size = New Size(628, 293)
        DGV.TabIndex = 12
        ' 
        ' ID
        ' 
        ID.HeaderText = "ID"
        ID.Name = "ID"
        ID.Width = 70
        ' 
        ' Column1
        ' 
        Column1.HeaderText = "IP Address"
        Column1.Name = "Column1"
        Column1.Width = 150
        ' 
        ' Column3
        ' 
        Column3.HeaderText = "Gateway"
        Column3.Name = "Column3"
        Column3.Width = 150
        ' 
        ' column4
        ' 
        column4.HeaderText = "Assign to VM"
        column4.Name = "column4"
        column4.Width = 150
        ' 
        ' bkeluar
        ' 
        bkeluar.Font = New Font("Segoe UI Emoji", 12F)
        bkeluar.Location = New Point(393, 284)
        bkeluar.Name = "bkeluar"
        bkeluar.Size = New Size(106, 31)
        bkeluar.TabIndex = 13
        bkeluar.Text = "Keluar"
        bkeluar.UseVisualStyleBackColor = True
        ' 
        ' cari
        ' 
        cari.AutoSize = True
        cari.Font = New Font("Segoe UI Emoji", 12F)
        cari.Location = New Point(357, 46)
        cari.Name = "cari"
        cari.Size = New Size(150, 21)
        cari.TabIndex = 14
        cari.Text = "Find Data (Based ID)"
        ' 
        ' tcari
        ' 
        tcari.Location = New Point(364, 80)
        tcari.Name = "tcari"
        tcari.Size = New Size(52, 29)
        tcari.TabIndex = 15
        ' 
        ' IPAM
        ' 
        AutoScaleDimensions = New SizeF(10F, 21F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(666, 633)
        Controls.Add(tcari)
        Controls.Add(cari)
        Controls.Add(bkeluar)
        Controls.Add(DGV)
        Controls.Add(bhapus)
        Controls.Add(bsimpan)
        Controls.Add(bkosongkan)
        Controls.Add(cassign)
        Controls.Add(tgw)
        Controls.Add(tip)
        Controls.Add(tid)
        Controls.Add(lassign)
        Controls.Add(lgw)
        Controls.Add(lip)
        Controls.Add(lid)
        Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4)
        Name = "IPAM"
        Text = "Menu IPAM"
        CType(DGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lid As Label
    Friend WithEvents lip As Label
    Friend WithEvents lgw As Label
    Friend WithEvents lassign As Label
    Friend WithEvents tid As TextBox
    Friend WithEvents tip As TextBox
    Friend WithEvents tgw As TextBox
    Friend WithEvents cassign As ComboBox
    Friend WithEvents bkosongkan As Button
    Friend WithEvents bsimpan As Button
    Friend WithEvents bhapus As Button
    Friend WithEvents DGV As DataGridView
    Friend WithEvents bkeluar As Button
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents column4 As DataGridViewTextBoxColumn
    Friend WithEvents cari As Label
    Friend WithEvents tcari As TextBox

End Class
