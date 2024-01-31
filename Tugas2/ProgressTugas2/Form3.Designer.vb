<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        tcari_vms = New TextBox()
        cari = New Label()
        bkeluar_vms = New Button()
        DGV_VMS = New DataGridView()
        tid_2 = New DataGridViewTextBoxColumn()
        tvmname2 = New DataGridViewTextBoxColumn()
        tcluster2 = New DataGridViewTextBoxColumn()
        tnotes2 = New DataGridViewTextBoxColumn()
        bhapus_vms = New Button()
        bsimpan_vms = New Button()
        bkosongkan_vms = New Button()
        tcluster = New TextBox()
        tvm_name = New TextBox()
        tid_vms = New TextBox()
        lassign = New Label()
        lgw = New Label()
        lip = New Label()
        lid = New Label()
        tnotes = New RichTextBox()
        CType(DGV_VMS, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' tcari_vms
        ' 
        tcari_vms.Location = New Point(357, 50)
        tcari_vms.Name = "tcari_vms"
        tcari_vms.Size = New Size(52, 23)
        tcari_vms.TabIndex = 30
        ' 
        ' cari
        ' 
        cari.AutoSize = True
        cari.Font = New Font("Segoe UI Emoji", 12F)
        cari.Location = New Point(350, 16)
        cari.Name = "cari"
        cari.Size = New Size(150, 21)
        cari.TabIndex = 29
        cari.Text = "Find Data (Based ID)"
        ' 
        ' bkeluar_vms
        ' 
        bkeluar_vms.Font = New Font("Segoe UI Emoji", 12F)
        bkeluar_vms.Location = New Point(386, 254)
        bkeluar_vms.Name = "bkeluar_vms"
        bkeluar_vms.Size = New Size(106, 31)
        bkeluar_vms.TabIndex = 28
        bkeluar_vms.Text = "Keluar"
        bkeluar_vms.UseVisualStyleBackColor = True
        ' 
        ' DGV_VMS
        ' 
        DGV_VMS.BackgroundColor = SystemColors.ActiveCaption
        DGV_VMS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DGV_VMS.Columns.AddRange(New DataGridViewColumn() {tid_2, tvmname2, tcluster2, tnotes2})
        DGV_VMS.GridColor = SystemColors.InactiveBorder
        DGV_VMS.Location = New Point(12, 300)
        DGV_VMS.Name = "DGV_VMS"
        DGV_VMS.ScrollBars = ScrollBars.Horizontal
        DGV_VMS.Size = New Size(948, 298)
        DGV_VMS.TabIndex = 27
        ' 
        ' tid_2
        ' 
        tid_2.HeaderText = "ID"
        tid_2.Name = "tid_2"
        tid_2.Width = 70
        ' 
        ' tvmname2
        ' 
        tvmname2.HeaderText = "VM Name"
        tvmname2.Name = "tvmname2"
        tvmname2.Width = 150
        ' 
        ' tcluster2
        ' 
        tcluster2.HeaderText = "Cluster"
        tcluster2.Name = "tcluster2"
        tcluster2.Width = 150
        ' 
        ' tnotes2
        ' 
        tnotes2.HeaderText = "Notes"
        tnotes2.Name = "tnotes2"
        tnotes2.Width = 420
        ' 
        ' bhapus_vms
        ' 
        bhapus_vms.Font = New Font("Segoe UI Emoji", 12F)
        bhapus_vms.Location = New Point(274, 254)
        bhapus_vms.Name = "bhapus_vms"
        bhapus_vms.Size = New Size(106, 31)
        bhapus_vms.TabIndex = 26
        bhapus_vms.Text = "Hapus"
        bhapus_vms.UseVisualStyleBackColor = True
        ' 
        ' bsimpan_vms
        ' 
        bsimpan_vms.Font = New Font("Segoe UI Emoji", 12F)
        bsimpan_vms.Location = New Point(161, 254)
        bsimpan_vms.Name = "bsimpan_vms"
        bsimpan_vms.Size = New Size(106, 31)
        bsimpan_vms.TabIndex = 25
        bsimpan_vms.Text = "Simpan"
        bsimpan_vms.UseVisualStyleBackColor = True
        ' 
        ' bkosongkan_vms
        ' 
        bkosongkan_vms.Font = New Font("Segoe UI Emoji", 12F)
        bkosongkan_vms.Location = New Point(50, 254)
        bkosongkan_vms.Name = "bkosongkan_vms"
        bkosongkan_vms.Size = New Size(106, 31)
        bkosongkan_vms.TabIndex = 24
        bkosongkan_vms.Text = "Kosongkan"
        bkosongkan_vms.UseVisualStyleBackColor = True
        ' 
        ' tcluster
        ' 
        tcluster.Location = New Point(131, 134)
        tcluster.Name = "tcluster"
        tcluster.Size = New Size(177, 23)
        tcluster.TabIndex = 22
        ' 
        ' tvm_name
        ' 
        tvm_name.Location = New Point(131, 69)
        tvm_name.Name = "tvm_name"
        tvm_name.Size = New Size(177, 23)
        tvm_name.TabIndex = 21
        ' 
        ' tid_vms
        ' 
        tid_vms.Location = New Point(131, 13)
        tid_vms.Name = "tid_vms"
        tid_vms.Size = New Size(54, 23)
        tid_vms.TabIndex = 20
        ' 
        ' lassign
        ' 
        lassign.AutoSize = True
        lassign.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lassign.Location = New Point(63, 196)
        lassign.Name = "lassign"
        lassign.Size = New Size(62, 21)
        lassign.TabIndex = 19
        lassign.Text = "Notes : "
        ' 
        ' lgw
        ' 
        lgw.AutoSize = True
        lgw.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lgw.Location = New Point(55, 137)
        lgw.Name = "lgw"
        lgw.Size = New Size(70, 21)
        lgw.TabIndex = 18
        lgw.Text = "Cluster : "
        ' 
        ' lip
        ' 
        lip.AutoSize = True
        lip.Font = New Font("Segoe UI Emoji", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lip.Location = New Point(34, 72)
        lip.Name = "lip"
        lip.Size = New Size(91, 21)
        lip.TabIndex = 17
        lip.Text = "VM Name : "
        ' 
        ' lid
        ' 
        lid.AutoSize = True
        lid.Font = New Font("Segoe UI Emoji", 12F)
        lid.Location = New Point(89, 16)
        lid.Name = "lid"
        lid.Size = New Size(36, 21)
        lid.TabIndex = 16
        lid.Text = "ID : "
        ' 
        ' tnotes
        ' 
        tnotes.Location = New Point(131, 195)
        tnotes.Name = "tnotes"
        tnotes.Size = New Size(278, 53)
        tnotes.TabIndex = 31
        tnotes.Text = ""
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(956, 600)
        Controls.Add(tnotes)
        Controls.Add(tcari_vms)
        Controls.Add(cari)
        Controls.Add(bkeluar_vms)
        Controls.Add(DGV_VMS)
        Controls.Add(bhapus_vms)
        Controls.Add(bsimpan_vms)
        Controls.Add(bkosongkan_vms)
        Controls.Add(tcluster)
        Controls.Add(tvm_name)
        Controls.Add(tid_vms)
        Controls.Add(lassign)
        Controls.Add(lgw)
        Controls.Add(lip)
        Controls.Add(lid)
        Name = "Form3"
        Text = "VMs"
        CType(DGV_VMS, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tcari_vms As TextBox
    Friend WithEvents cari As Label
    Friend WithEvents bkeluar_vms As Button
    Friend WithEvents DGV_VMS As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents column4 As DataGridViewTextBoxColumn
    Friend WithEvents bhapus_vms As Button
    Friend WithEvents bsimpan_vms As Button
    Friend WithEvents bkosongkan_vms As Button
    Friend WithEvents tcluster As TextBox
    Friend WithEvents tvm_name As TextBox
    Friend WithEvents tid_vms As TextBox
    Friend WithEvents lassign As Label
    Friend WithEvents lgw As Label
    Friend WithEvents lip As Label
    Friend WithEvents lid As Label
    Friend WithEvents tnotes As RichTextBox
    Friend WithEvents tid_2 As DataGridViewTextBoxColumn
    Friend WithEvents tvmname2 As DataGridViewTextBoxColumn
    Friend WithEvents tcluster2 As DataGridViewTextBoxColumn
    Friend WithEvents tnotes2 As DataGridViewTextBoxColumn
End Class
