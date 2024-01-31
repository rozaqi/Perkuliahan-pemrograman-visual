<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        PnlSideBar = New Panel()
        menu_hosts = New Button()
        menu_rs = New Button()
        menu_vms = New Button()
        menu_ipam = New Button()
        menu_main_dashboard = New Button()
        Panel2 = New Panel()
        Panel1 = New Panel()
        Label1 = New Label()
        Label2 = New Label()
        Panel3 = New Panel()
        show_ipam = New Label()
        Panel4 = New Panel()
        show_vms = New Label()
        Label3 = New Label()
        Panel5 = New Panel()
        show_hosts = New Label()
        Label4 = New Label()
        show_rs = New Label()
        Panel6 = New Panel()
        Label5 = New Label()
        dgv_rcip = New DataGridView()
        rcip = New DataGridViewTextBoxColumn()
        dgv_vms = New DataGridView()
        DataGridViewTextBoxColumn1 = New DataGridViewTextBoxColumn()
        dgv_rs2 = New DataGridView()
        DataGridViewTextBoxColumn2 = New DataGridViewTextBoxColumn()
        Label8 = New Label()
        PnlSideBar.SuspendLayout()
        Panel1.SuspendLayout()
        Panel3.SuspendLayout()
        Panel4.SuspendLayout()
        Panel5.SuspendLayout()
        Panel6.SuspendLayout()
        CType(dgv_rcip, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgv_vms, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgv_rs2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PnlSideBar
        ' 
        PnlSideBar.BackColor = Color.FromArgb(CByte(52), CByte(73), CByte(94))
        PnlSideBar.Controls.Add(menu_hosts)
        PnlSideBar.Controls.Add(menu_rs)
        PnlSideBar.Controls.Add(menu_vms)
        PnlSideBar.Controls.Add(menu_ipam)
        PnlSideBar.Controls.Add(menu_main_dashboard)
        PnlSideBar.Controls.Add(Panel2)
        PnlSideBar.Dock = DockStyle.Left
        PnlSideBar.Location = New Point(0, 0)
        PnlSideBar.Name = "PnlSideBar"
        PnlSideBar.Size = New Size(131, 799)
        PnlSideBar.TabIndex = 0
        ' 
        ' menu_hosts
        ' 
        menu_hosts.Dock = DockStyle.Top
        menu_hosts.Location = New Point(0, 285)
        menu_hosts.Name = "menu_hosts"
        menu_hosts.Size = New Size(131, 47)
        menu_hosts.TabIndex = 5
        menu_hosts.Text = "Hosts"
        menu_hosts.UseVisualStyleBackColor = True
        ' 
        ' menu_rs
        ' 
        menu_rs.Dock = DockStyle.Top
        menu_rs.Location = New Point(0, 238)
        menu_rs.Name = "menu_rs"
        menu_rs.Size = New Size(131, 47)
        menu_rs.TabIndex = 4
        menu_rs.Text = "Router and Switch"
        menu_rs.UseVisualStyleBackColor = True
        ' 
        ' menu_vms
        ' 
        menu_vms.Dock = DockStyle.Top
        menu_vms.Location = New Point(0, 191)
        menu_vms.Name = "menu_vms"
        menu_vms.Size = New Size(131, 47)
        menu_vms.TabIndex = 3
        menu_vms.Text = "VMs"
        menu_vms.UseVisualStyleBackColor = True
        ' 
        ' menu_ipam
        ' 
        menu_ipam.Dock = DockStyle.Top
        menu_ipam.Location = New Point(0, 144)
        menu_ipam.Name = "menu_ipam"
        menu_ipam.Size = New Size(131, 47)
        menu_ipam.TabIndex = 2
        menu_ipam.Text = "IPAM"
        menu_ipam.UseVisualStyleBackColor = True
        ' 
        ' menu_main_dashboard
        ' 
        menu_main_dashboard.Dock = DockStyle.Top
        menu_main_dashboard.Location = New Point(0, 97)
        menu_main_dashboard.Name = "menu_main_dashboard"
        menu_main_dashboard.Size = New Size(131, 47)
        menu_main_dashboard.TabIndex = 1
        menu_main_dashboard.Text = "Main Dashboard"
        menu_main_dashboard.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(46), CByte(204), CByte(113))
        Panel2.Dock = DockStyle.Top
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(131, 97)
        Panel2.TabIndex = 1
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(46), CByte(204), CByte(113))
        Panel1.Controls.Add(Label1)
        Panel1.Dock = DockStyle.Top
        Panel1.Location = New Point(131, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(977, 100)
        Panel1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(22, 31)
        Label1.Name = "Label1"
        Label1.Size = New Size(400, 32)
        Label1.TabIndex = 0
        Label1.Text = "IT Inventory Management System"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(49, 104)
        Label2.Name = "Label2"
        Label2.Size = New Size(56, 25)
        Label2.TabIndex = 2
        Label2.Text = "IPAM"
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(52), CByte(152), CByte(219))
        Panel3.Controls.Add(show_ipam)
        Panel3.Controls.Add(Label2)
        Panel3.Location = New Point(236, 130)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(151, 141)
        Panel3.TabIndex = 3
        ' 
        ' show_ipam
        ' 
        show_ipam.AutoSize = True
        show_ipam.Font = New Font("Yu Gothic", 36.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        show_ipam.Location = New Point(49, 32)
        show_ipam.Name = "show_ipam"
        show_ipam.Size = New Size(55, 61)
        show_ipam.TabIndex = 5
        show_ipam.Text = "3"
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(52), CByte(152), CByte(219))
        Panel4.Controls.Add(show_vms)
        Panel4.Controls.Add(Label3)
        Panel4.Location = New Point(450, 130)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(156, 141)
        Panel4.TabIndex = 4
        ' 
        ' show_vms
        ' 
        show_vms.AutoSize = True
        show_vms.Font = New Font("Yu Gothic", 36.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        show_vms.Location = New Point(57, 32)
        show_vms.Name = "show_vms"
        show_vms.Size = New Size(55, 61)
        show_vms.TabIndex = 6
        show_vms.Text = "3"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(21, 110)
        Label3.Name = "Label3"
        Label3.Size = New Size(118, 20)
        Label3.TabIndex = 2
        Label3.Text = "Virtual Machines"
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = Color.FromArgb(CByte(52), CByte(152), CByte(219))
        Panel5.Controls.Add(show_hosts)
        Panel5.Controls.Add(Label4)
        Panel5.Location = New Point(659, 130)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(157, 141)
        Panel5.TabIndex = 4
        ' 
        ' show_hosts
        ' 
        show_hosts.AutoSize = True
        show_hosts.Font = New Font("Yu Gothic", 36.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        show_hosts.Location = New Point(53, 32)
        show_hosts.Name = "show_hosts"
        show_hosts.Size = New Size(55, 61)
        show_hosts.TabIndex = 8
        show_hosts.Text = "0"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(50, 105)
        Label4.Name = "Label4"
        Label4.Size = New Size(58, 25)
        Label4.TabIndex = 2
        Label4.Text = "Hosts"
        ' 
        ' show_rs
        ' 
        show_rs.AutoSize = True
        show_rs.Font = New Font("Yu Gothic", 36.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        show_rs.Location = New Point(53, 32)
        show_rs.Name = "show_rs"
        show_rs.Size = New Size(55, 61)
        show_rs.TabIndex = 7
        show_rs.Text = "0"
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = Color.FromArgb(CByte(52), CByte(152), CByte(219))
        Panel6.Controls.Add(Label5)
        Panel6.Controls.Add(show_rs)
        Panel6.Location = New Point(858, 130)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(161, 141)
        Panel6.TabIndex = 4
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(12, 108)
        Label5.Name = "Label5"
        Label5.Size = New Size(137, 21)
        Label5.TabIndex = 2
        Label5.Text = "Router and Switch"
        ' 
        ' dgv_rcip
        ' 
        dgv_rcip.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_rcip.Columns.AddRange(New DataGridViewColumn() {rcip})
        dgv_rcip.Location = New Point(201, 319)
        dgv_rcip.Name = "dgv_rcip"
        dgv_rcip.Size = New Size(223, 150)
        dgv_rcip.TabIndex = 5
        ' 
        ' rcip
        ' 
        rcip.HeaderText = "Recent IP"
        rcip.Name = "rcip"
        rcip.Width = 180
        ' 
        ' dgv_vms
        ' 
        dgv_vms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_vms.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn1})
        dgv_vms.Location = New Point(518, 319)
        dgv_vms.Name = "dgv_vms"
        dgv_vms.Size = New Size(223, 150)
        dgv_vms.TabIndex = 6
        ' 
        ' DataGridViewTextBoxColumn1
        ' 
        DataGridViewTextBoxColumn1.HeaderText = "Recent VMs"
        DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        DataGridViewTextBoxColumn1.Width = 180
        ' 
        ' dgv_rs2
        ' 
        dgv_rs2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgv_rs2.Columns.AddRange(New DataGridViewColumn() {DataGridViewTextBoxColumn2})
        dgv_rs2.Location = New Point(836, 319)
        dgv_rs2.Name = "dgv_rs2"
        dgv_rs2.Size = New Size(223, 150)
        dgv_rs2.TabIndex = 7
        ' 
        ' DataGridViewTextBoxColumn2
        ' 
        DataGridViewTextBoxColumn2.HeaderText = "Recent Router & Switch"
        DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        DataGridViewTextBoxColumn2.Width = 180
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(238, 517)
        Label8.Name = "Label8"
        Label8.Size = New Size(171, 84)
        Label8.TabIndex = 8
        Label8.Text = "Identitas Team :" & vbCrLf & "(Kelompok 8)" & vbCrLf & "1. Abdul Rozaqi Wildan" & vbCrLf & "2. Yudi Putra Wiratama"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(236), CByte(240), CByte(241))
        ClientSize = New Size(1108, 799)
        Controls.Add(Label8)
        Controls.Add(dgv_rs2)
        Controls.Add(dgv_vms)
        Controls.Add(dgv_rcip)
        Controls.Add(Panel6)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel3)
        Controls.Add(Panel1)
        Controls.Add(PnlSideBar)
        Name = "Form2"
        Text = "IT Inventory Management System"
        PnlSideBar.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel3.ResumeLayout(False)
        Panel3.PerformLayout()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        Panel5.ResumeLayout(False)
        Panel5.PerformLayout()
        Panel6.ResumeLayout(False)
        Panel6.PerformLayout()
        CType(dgv_rcip, ComponentModel.ISupportInitialize).EndInit()
        CType(dgv_vms, ComponentModel.ISupportInitialize).EndInit()
        CType(dgv_rs2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PnlSideBar As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents menu_vms As Button
    Friend WithEvents menu_ipam As Button
    Friend WithEvents menu_main_dashboard As Button
    Friend WithEvents menu_rs As Button
    Friend WithEvents menu_hosts As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents show_ipam As Label
    Friend WithEvents show_vms As Label
    Friend WithEvents show_rs As Label
    Friend WithEvents show_hosts As Label
    Friend WithEvents dgv_rcip As DataGridView
    Friend WithEvents rcip As DataGridViewTextBoxColumn
    Friend WithEvents dgv_vms As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents dgv_rs2 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Label8 As Label
End Class
