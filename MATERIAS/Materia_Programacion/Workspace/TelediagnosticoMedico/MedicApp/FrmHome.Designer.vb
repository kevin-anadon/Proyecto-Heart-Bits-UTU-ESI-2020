<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmHome
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmHome))
        Me.PanelLeft = New System.Windows.Forms.Panel()
        Me.PanelButtons = New System.Windows.Forms.Panel()
        Me.DragCtrl = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Elipse = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.TimerRequests = New System.Windows.Forms.Timer(Me.components)
        Me.PnlChat = New System.Windows.Forms.Panel()
        Me.TxtChatSend = New System.Windows.Forms.TextBox()
        Me.BtnSend = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnMore = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.PnlChatBack = New Guna.UI2.WinForms.Guna2Panel()
        Me.TxtChat = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PnlTittleChat = New Guna.UI2.WinForms.Guna2Panel()
        Me.LblPatient = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PnlRequest = New System.Windows.Forms.Panel()
        Me.DgvRequests = New Guna.UI.WinForms.GunaDataGridView()
        Me.PnlTittle = New Guna.UI2.WinForms.Guna2Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblListado = New System.Windows.Forms.Label()
        Me.BtnLogOut = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnRequest = New Guna.UI2.WinForms.Guna2Button()
        Me.BtnHome = New Guna.UI2.WinForms.Guna2Button()
        Me.PicBar = New System.Windows.Forms.PictureBox()
        Me.PicLogo = New System.Windows.Forms.PictureBox()
        Me.PanelHome = New System.Windows.Forms.Panel()
        Me.LblConnect = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.LblPhone = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LblAge = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblCi = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LblName = New System.Windows.Forms.Label()
        Me.LblTitle1 = New System.Windows.Forms.Label()
        Me.Lblbody = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PicHome = New System.Windows.Forms.PictureBox()
        Me.PicSys = New System.Windows.Forms.PictureBox()
        Me.TimerChat = New System.Windows.Forms.Timer(Me.components)
        Me.PanelLeft.SuspendLayout()
        Me.PanelButtons.SuspendLayout()
        Me.PnlChat.SuspendLayout()
        Me.PnlChatBack.SuspendLayout()
        Me.PnlTittleChat.SuspendLayout()
        Me.PnlRequest.SuspendLayout()
        CType(Me.DgvRequests, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlTittle.SuspendLayout()
        CType(Me.PicBar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelHome.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicHome, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicSys, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelLeft
        '
        Me.PanelLeft.BackColor = System.Drawing.Color.White
        Me.PanelLeft.Controls.Add(Me.PanelButtons)
        Me.PanelLeft.Controls.Add(Me.PicLogo)
        Me.PanelLeft.Location = New System.Drawing.Point(0, 0)
        Me.PanelLeft.Name = "PanelLeft"
        Me.PanelLeft.Size = New System.Drawing.Size(188, 640)
        Me.PanelLeft.TabIndex = 6
        '
        'PanelButtons
        '
        Me.PanelButtons.Controls.Add(Me.BtnLogOut)
        Me.PanelButtons.Controls.Add(Me.BtnRequest)
        Me.PanelButtons.Controls.Add(Me.BtnHome)
        Me.PanelButtons.Controls.Add(Me.PicBar)
        Me.PanelButtons.Location = New System.Drawing.Point(19, 108)
        Me.PanelButtons.Name = "PanelButtons"
        Me.PanelButtons.Size = New System.Drawing.Size(166, 515)
        Me.PanelButtons.TabIndex = 1
        '
        'DragCtrl
        '
        Me.DragCtrl.TargetControl = Me
        '
        'Elipse
        '
        Me.Elipse.BorderRadius = 10
        Me.Elipse.TargetControl = Me
        '
        'TimerRequests
        '
        Me.TimerRequests.Interval = 1000
        '
        'PnlChat
        '
        Me.PnlChat.BackColor = System.Drawing.Color.Transparent
        Me.PnlChat.BackgroundImage = CType(resources.GetObject("PnlChat.BackgroundImage"), System.Drawing.Image)
        Me.PnlChat.Controls.Add(Me.TxtChatSend)
        Me.PnlChat.Controls.Add(Me.BtnSend)
        Me.PnlChat.Controls.Add(Me.BtnMore)
        Me.PnlChat.Controls.Add(Me.Guna2Button1)
        Me.PnlChat.Controls.Add(Me.PnlChatBack)
        Me.PnlChat.Controls.Add(Me.PnlTittleChat)
        Me.PnlChat.ForeColor = System.Drawing.Color.Transparent
        Me.PnlChat.Location = New System.Drawing.Point(188, 0)
        Me.PnlChat.Name = "PnlChat"
        Me.PnlChat.Size = New System.Drawing.Size(872, 640)
        Me.PnlChat.TabIndex = 58
        Me.PnlChat.Visible = False
        '
        'TxtChatSend
        '
        Me.TxtChatSend.AccessibleDescription = "TxtCredUser"
        Me.TxtChatSend.AccessibleName = "TxtCredUser"
        Me.TxtChatSend.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtChatSend.BackColor = System.Drawing.Color.White
        Me.TxtChatSend.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtChatSend.Font = New System.Drawing.Font("Segoe UI Emoji", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtChatSend.ForeColor = System.Drawing.Color.Black
        Me.TxtChatSend.Location = New System.Drawing.Point(25, 584)
        Me.TxtChatSend.Name = "TxtChatSend"
        Me.TxtChatSend.Size = New System.Drawing.Size(711, 22)
        Me.TxtChatSend.TabIndex = 0
        '
        'BtnSend
        '
        Me.BtnSend.AccessibleDescription = "BtnForeText"
        Me.BtnSend.AccessibleName = "BtnForeText"
        Me.BtnSend.BorderColor = System.Drawing.Color.FromArgb(CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.BtnSend.BorderRadius = 10
        Me.BtnSend.BorderThickness = 2
        Me.BtnSend.CheckedState.Parent = Me.BtnSend
        Me.BtnSend.CustomImages.Parent = Me.BtnSend
        Me.BtnSend.FillColor = System.Drawing.Color.Transparent
        Me.BtnSend.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnSend.ForeColor = System.Drawing.Color.Transparent
        Me.BtnSend.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.BtnSend.HoverState.Parent = Me.BtnSend
        Me.BtnSend.Image = Global.MedicApp.My.Resources.Resources.mdi_send
        Me.BtnSend.Location = New System.Drawing.Point(807, 570)
        Me.BtnSend.Name = "BtnSend"
        Me.BtnSend.PressedDepth = 0
        Me.BtnSend.ShadowDecoration.Parent = Me.BtnSend
        Me.BtnSend.Size = New System.Drawing.Size(53, 45)
        Me.BtnSend.TabIndex = 60
        '
        'BtnMore
        '
        Me.BtnMore.AccessibleDescription = "BtnForeText"
        Me.BtnMore.AccessibleName = "BtnForeText"
        Me.BtnMore.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.BtnMore.BorderRadius = 10
        Me.BtnMore.BorderThickness = 2
        Me.BtnMore.CheckedState.Parent = Me.BtnMore
        Me.BtnMore.CustomImages.Parent = Me.BtnMore
        Me.BtnMore.FillColor = System.Drawing.Color.Transparent
        Me.BtnMore.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BtnMore.ForeColor = System.Drawing.Color.Transparent
        Me.BtnMore.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.BtnMore.HoverState.Parent = Me.BtnMore
        Me.BtnMore.Image = Global.MedicApp.My.Resources.Resources.Vector1
        Me.BtnMore.Location = New System.Drawing.Point(752, 570)
        Me.BtnMore.Name = "BtnMore"
        Me.BtnMore.PressedDepth = 0
        Me.BtnMore.ShadowDecoration.Parent = Me.BtnMore
        Me.BtnMore.Size = New System.Drawing.Size(53, 45)
        Me.BtnMore.TabIndex = 59
        '
        'Guna2Button1
        '
        Me.Guna2Button1.AccessibleDescription = "BtnForeText"
        Me.Guna2Button1.AccessibleName = "BtnForeText"
        Me.Guna2Button1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Guna2Button1.BorderRadius = 10
        Me.Guna2Button1.BorderThickness = 2
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Guna2Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.HoverState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Location = New System.Drawing.Point(7, 570)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.PressedDepth = 0
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(739, 45)
        Me.Guna2Button1.TabIndex = 58
        '
        'PnlChatBack
        '
        Me.PnlChatBack.AccessibleDescription = "PnlColorInfo"
        Me.PnlChatBack.AccessibleName = "PnlColorInfo"
        Me.PnlChatBack.BorderColor = System.Drawing.Color.DimGray
        Me.PnlChatBack.BorderRadius = 6
        Me.PnlChatBack.BorderThickness = 1
        Me.PnlChatBack.Controls.Add(Me.TxtChat)
        Me.PnlChatBack.Controls.Add(Me.Label4)
        Me.PnlChatBack.FillColor = System.Drawing.Color.White
        Me.PnlChatBack.Location = New System.Drawing.Point(7, 67)
        Me.PnlChatBack.Name = "PnlChatBack"
        Me.PnlChatBack.ShadowDecoration.Parent = Me.PnlChatBack
        Me.PnlChatBack.Size = New System.Drawing.Size(849, 480)
        Me.PnlChatBack.TabIndex = 57
        '
        'TxtChat
        '
        Me.TxtChat.BorderThickness = 0
        Me.TxtChat.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtChat.DefaultText = ""
        Me.TxtChat.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TxtChat.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TxtChat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtChat.DisabledState.Parent = Me.TxtChat
        Me.TxtChat.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TxtChat.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtChat.FocusedState.Parent = Me.TxtChat
        Me.TxtChat.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtChat.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TxtChat.HoverState.Parent = Me.TxtChat
        Me.TxtChat.Location = New System.Drawing.Point(3, 31)
        Me.TxtChat.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtChat.Multiline = True
        Me.TxtChat.Name = "TxtChat"
        Me.TxtChat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtChat.PlaceholderText = ""
        Me.TxtChat.ReadOnly = True
        Me.TxtChat.SelectedText = ""
        Me.TxtChat.ShadowDecoration.Parent = Me.TxtChat
        Me.TxtChat.Size = New System.Drawing.Size(843, 404)
        Me.TxtChat.TabIndex = 55
        '
        'Label4
        '
        Me.Label4.AccessibleDescription = "LblResults"
        Me.Label4.AccessibleName = "LblResults"
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(246, Byte), Integer), CType(CType(135, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(1, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 30)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Sistema"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PnlTittleChat
        '
        Me.PnlTittleChat.AccessibleDescription = "PnlColorInfo"
        Me.PnlTittleChat.AccessibleName = "PnlColorInfo"
        Me.PnlTittleChat.BorderRadius = 11
        Me.PnlTittleChat.Controls.Add(Me.LblPatient)
        Me.PnlTittleChat.Controls.Add(Me.Label2)
        Me.PnlTittleChat.FillColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.PnlTittleChat.Location = New System.Drawing.Point(6, 13)
        Me.PnlTittleChat.Name = "PnlTittleChat"
        Me.PnlTittleChat.ShadowDecoration.Parent = Me.PnlTittleChat
        Me.PnlTittleChat.Size = New System.Drawing.Size(850, 51)
        Me.PnlTittleChat.TabIndex = 56
        '
        'LblPatient
        '
        Me.LblPatient.AccessibleDescription = "LblResults"
        Me.LblPatient.AccessibleName = "LblResults"
        Me.LblPatient.BackColor = System.Drawing.Color.Transparent
        Me.LblPatient.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPatient.ForeColor = System.Drawing.Color.White
        Me.LblPatient.Location = New System.Drawing.Point(411, 0)
        Me.LblPatient.Name = "LblPatient"
        Me.LblPatient.Size = New System.Drawing.Size(379, 51)
        Me.LblPatient.TabIndex = 53
        Me.LblPatient.Text = "Patient"
        Me.LblPatient.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AccessibleDescription = "LblResults"
        Me.Label2.AccessibleName = "LblResults"
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(443, 51)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "En una conversación con el Paciente: "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PnlRequest
        '
        Me.PnlRequest.BackColor = System.Drawing.Color.Transparent
        Me.PnlRequest.BackgroundImage = CType(resources.GetObject("PnlRequest.BackgroundImage"), System.Drawing.Image)
        Me.PnlRequest.Controls.Add(Me.DgvRequests)
        Me.PnlRequest.Controls.Add(Me.PnlTittle)
        Me.PnlRequest.Controls.Add(Me.LblListado)
        Me.PnlRequest.ForeColor = System.Drawing.Color.Transparent
        Me.PnlRequest.Location = New System.Drawing.Point(188, 0)
        Me.PnlRequest.Name = "PnlRequest"
        Me.PnlRequest.Size = New System.Drawing.Size(872, 640)
        Me.PnlRequest.TabIndex = 34
        Me.PnlRequest.Visible = False
        '
        'DgvRequests
        '
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.White
        Me.DgvRequests.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        Me.DgvRequests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvRequests.BackgroundColor = System.Drawing.Color.White
        Me.DgvRequests.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DgvRequests.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvRequests.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DgvRequests.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.DgvRequests.ColumnHeadersHeight = 4
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgvRequests.DefaultCellStyle = DataGridViewCellStyle6
        Me.DgvRequests.EnableHeadersVisualStyles = False
        Me.DgvRequests.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvRequests.Location = New System.Drawing.Point(18, 128)
        Me.DgvRequests.Name = "DgvRequests"
        Me.DgvRequests.ReadOnly = True
        Me.DgvRequests.RowHeadersVisible = False
        Me.DgvRequests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvRequests.Size = New System.Drawing.Size(842, 492)
        Me.DgvRequests.TabIndex = 57
        Me.DgvRequests.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna
        Me.DgvRequests.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvRequests.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.DgvRequests.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.DgvRequests.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.DgvRequests.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.DgvRequests.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.DgvRequests.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvRequests.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvRequests.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvRequests.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DgvRequests.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White
        Me.DgvRequests.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.DgvRequests.ThemeStyle.HeaderStyle.Height = 4
        Me.DgvRequests.ThemeStyle.ReadOnly = True
        Me.DgvRequests.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.DgvRequests.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.DgvRequests.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.DgvRequests.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        Me.DgvRequests.ThemeStyle.RowsStyle.Height = 22
        Me.DgvRequests.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(229, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DgvRequests.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(71, Byte), Integer), CType(CType(69, Byte), Integer), CType(CType(94, Byte), Integer))
        '
        'PnlTittle
        '
        Me.PnlTittle.AccessibleDescription = "PnlColorInfo"
        Me.PnlTittle.AccessibleName = "PnlColorInfo"
        Me.PnlTittle.BorderRadius = 11
        Me.PnlTittle.Controls.Add(Me.Label1)
        Me.PnlTittle.FillColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.PnlTittle.Location = New System.Drawing.Point(12, 30)
        Me.PnlTittle.Name = "PnlTittle"
        Me.PnlTittle.ShadowDecoration.Parent = Me.PnlTittle
        Me.PnlTittle.Size = New System.Drawing.Size(850, 51)
        Me.PnlTittle.TabIndex = 55
        '
        'Label1
        '
        Me.Label1.AccessibleDescription = "LblResults"
        Me.Label1.AccessibleName = "LblResults"
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(460, 51)
        Me.Label1.TabIndex = 52
        Me.Label1.Text = "PETICIONES SOLICITADAS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblListado
        '
        Me.LblListado.AccessibleDescription = "LblResults"
        Me.LblListado.AccessibleName = "LblResults"
        Me.LblListado.BackColor = System.Drawing.SystemColors.Control
        Me.LblListado.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblListado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.LblListado.Location = New System.Drawing.Point(18, 88)
        Me.LblListado.Name = "LblListado"
        Me.LblListado.Size = New System.Drawing.Size(844, 37)
        Me.LblListado.TabIndex = 56
        Me.LblListado.Text = "LISTADO DE PETICIONES"
        Me.LblListado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnLogOut
        '
        Me.BtnLogOut.AccessibleDescription = "BtnLogin"
        Me.BtnLogOut.AccessibleName = "BtnLogin"
        Me.BtnLogOut.Animated = True
        Me.BtnLogOut.BorderRadius = 6
        Me.BtnLogOut.CheckedState.Parent = Me.BtnLogOut
        Me.BtnLogOut.CustomImages.Parent = Me.BtnLogOut
        Me.BtnLogOut.FillColor = System.Drawing.Color.White
        Me.BtnLogOut.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogOut.ForeColor = System.Drawing.Color.Black
        Me.BtnLogOut.HoverState.Parent = Me.BtnLogOut
        Me.BtnLogOut.Image = CType(resources.GetObject("BtnLogOut.Image"), System.Drawing.Image)
        Me.BtnLogOut.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnLogOut.Location = New System.Drawing.Point(8, 482)
        Me.BtnLogOut.Name = "BtnLogOut"
        Me.BtnLogOut.ShadowDecoration.Parent = Me.BtnLogOut
        Me.BtnLogOut.Size = New System.Drawing.Size(146, 30)
        Me.BtnLogOut.TabIndex = 33
        Me.BtnLogOut.Text = "Cerrar Sesión"
        Me.BtnLogOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BtnRequest
        '
        Me.BtnRequest.AccessibleDescription = "BtnLogin"
        Me.BtnRequest.AccessibleName = "BtnLogin"
        Me.BtnRequest.Animated = True
        Me.BtnRequest.BorderRadius = 6
        Me.BtnRequest.CheckedState.Parent = Me.BtnRequest
        Me.BtnRequest.CustomImages.Parent = Me.BtnRequest
        Me.BtnRequest.FillColor = System.Drawing.Color.White
        Me.BtnRequest.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRequest.ForeColor = System.Drawing.Color.Black
        Me.BtnRequest.HoverState.Parent = Me.BtnRequest
        Me.BtnRequest.Image = CType(resources.GetObject("BtnRequest.Image"), System.Drawing.Image)
        Me.BtnRequest.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.BtnRequest.Location = New System.Drawing.Point(8, 58)
        Me.BtnRequest.Name = "BtnRequest"
        Me.BtnRequest.ShadowDecoration.Parent = Me.BtnRequest
        Me.BtnRequest.Size = New System.Drawing.Size(146, 30)
        Me.BtnRequest.TabIndex = 32
        Me.BtnRequest.Text = "Peticiones"
        Me.BtnRequest.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BtnHome
        '
        Me.BtnHome.AccessibleDescription = "BtnLogin"
        Me.BtnHome.AccessibleName = "BtnLogin"
        Me.BtnHome.Animated = True
        Me.BtnHome.BorderRadius = 6
        Me.BtnHome.CheckedState.Parent = Me.BtnHome
        Me.BtnHome.CustomImages.Parent = Me.BtnHome
        Me.BtnHome.FillColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.BtnHome.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHome.ForeColor = System.Drawing.Color.White
        Me.BtnHome.HoverState.Parent = Me.BtnHome
        Me.BtnHome.Image = CType(resources.GetObject("BtnHome.Image"), System.Drawing.Image)
        Me.BtnHome.Location = New System.Drawing.Point(8, 22)
        Me.BtnHome.Name = "BtnHome"
        Me.BtnHome.ShadowDecoration.Parent = Me.BtnHome
        Me.BtnHome.Size = New System.Drawing.Size(146, 30)
        Me.BtnHome.TabIndex = 31
        Me.BtnHome.Text = "Página principal"
        '
        'PicBar
        '
        Me.PicBar.BackColor = System.Drawing.Color.Transparent
        Me.PicBar.Image = CType(resources.GetObject("PicBar.Image"), System.Drawing.Image)
        Me.PicBar.Location = New System.Drawing.Point(160, 22)
        Me.PicBar.Name = "PicBar"
        Me.PicBar.Size = New System.Drawing.Size(10, 30)
        Me.PicBar.TabIndex = 30
        Me.PicBar.TabStop = False
        '
        'PicLogo
        '
        Me.PicLogo.Image = CType(resources.GetObject("PicLogo.Image"), System.Drawing.Image)
        Me.PicLogo.Location = New System.Drawing.Point(19, 13)
        Me.PicLogo.Name = "PicLogo"
        Me.PicLogo.Size = New System.Drawing.Size(77, 80)
        Me.PicLogo.TabIndex = 0
        Me.PicLogo.TabStop = False
        '
        'PanelHome
        '
        Me.PanelHome.BackColor = System.Drawing.Color.Transparent
        Me.PanelHome.BackgroundImage = CType(resources.GetObject("PanelHome.BackgroundImage"), System.Drawing.Image)
        Me.PanelHome.Controls.Add(Me.LblConnect)
        Me.PanelHome.Controls.Add(Me.Label11)
        Me.PanelHome.Controls.Add(Me.LblPhone)
        Me.PanelHome.Controls.Add(Me.Label7)
        Me.PanelHome.Controls.Add(Me.LblEmail)
        Me.PanelHome.Controls.Add(Me.Label5)
        Me.PanelHome.Controls.Add(Me.LblAge)
        Me.PanelHome.Controls.Add(Me.Label3)
        Me.PanelHome.Controls.Add(Me.LblCi)
        Me.PanelHome.Controls.Add(Me.Label9)
        Me.PanelHome.Controls.Add(Me.LblName)
        Me.PanelHome.Controls.Add(Me.LblTitle1)
        Me.PanelHome.Controls.Add(Me.Lblbody)
        Me.PanelHome.Controls.Add(Me.PictureBox2)
        Me.PanelHome.Controls.Add(Me.PicHome)
        Me.PanelHome.Controls.Add(Me.PicSys)
        Me.PanelHome.ForeColor = System.Drawing.Color.Transparent
        Me.PanelHome.Location = New System.Drawing.Point(188, 0)
        Me.PanelHome.Name = "PanelHome"
        Me.PanelHome.Size = New System.Drawing.Size(872, 640)
        Me.PanelHome.TabIndex = 7
        '
        'LblConnect
        '
        Me.LblConnect.AccessibleDescription = "LblTitle3"
        Me.LblConnect.AccessibleName = "LblTitle3"
        Me.LblConnect.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblConnect.AutoSize = True
        Me.LblConnect.BackColor = System.Drawing.Color.Transparent
        Me.LblConnect.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblConnect.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblConnect.ForeColor = System.Drawing.Color.DarkGray
        Me.LblConnect.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblConnect.Location = New System.Drawing.Point(484, 602)
        Me.LblConnect.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblConnect.Name = "LblConnect"
        Me.LblConnect.Size = New System.Drawing.Size(51, 13)
        Me.LblConnect.TabIndex = 33
        Me.LblConnect.Text = "Conexion"
        Me.LblConnect.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AccessibleDescription = "LblTitle3"
        Me.Label11.AccessibleName = "LblTitle3"
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Label11.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label11.Location = New System.Drawing.Point(482, 585)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(217, 15)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "Conexión"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblPhone
        '
        Me.LblPhone.AccessibleDescription = "LblTitle3"
        Me.LblPhone.AccessibleName = "LblTitle3"
        Me.LblPhone.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblPhone.AutoSize = True
        Me.LblPhone.BackColor = System.Drawing.Color.Transparent
        Me.LblPhone.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblPhone.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPhone.ForeColor = System.Drawing.Color.DarkGray
        Me.LblPhone.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblPhone.Location = New System.Drawing.Point(487, 525)
        Me.LblPhone.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblPhone.Name = "LblPhone"
        Me.LblPhone.Size = New System.Drawing.Size(22, 13)
        Me.LblPhone.TabIndex = 31
        Me.LblPhone.Text = "Tel"
        Me.LblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.AccessibleDescription = "LblTitle3"
        Me.Label7.AccessibleName = "LblTitle3"
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Label7.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label7.Location = New System.Drawing.Point(485, 508)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(217, 15)
        Me.Label7.TabIndex = 30
        Me.Label7.Text = "Número telefónico"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblEmail
        '
        Me.LblEmail.AccessibleDescription = "LblTitle3"
        Me.LblEmail.AccessibleName = "LblTitle3"
        Me.LblEmail.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblEmail.AutoSize = True
        Me.LblEmail.BackColor = System.Drawing.Color.Transparent
        Me.LblEmail.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmail.ForeColor = System.Drawing.Color.DarkGray
        Me.LblEmail.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblEmail.Location = New System.Drawing.Point(486, 473)
        Me.LblEmail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(38, 13)
        Me.LblEmail.TabIndex = 29
        Me.LblEmail.Text = "Correo"
        Me.LblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AccessibleDescription = "LblTitle3"
        Me.Label5.AccessibleName = "LblTitle3"
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Label5.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label5.Location = New System.Drawing.Point(484, 456)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(217, 15)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Dirección de correo electrónico"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblAge
        '
        Me.LblAge.AccessibleDescription = "LblTitle3"
        Me.LblAge.AccessibleName = "LblTitle3"
        Me.LblAge.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblAge.AutoSize = True
        Me.LblAge.BackColor = System.Drawing.Color.Transparent
        Me.LblAge.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAge.ForeColor = System.Drawing.Color.DarkGray
        Me.LblAge.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblAge.Location = New System.Drawing.Point(485, 429)
        Me.LblAge.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblAge.Name = "LblAge"
        Me.LblAge.Size = New System.Drawing.Size(32, 13)
        Me.LblAge.TabIndex = 27
        Me.LblAge.Text = "Edad"
        Me.LblAge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AccessibleDescription = "LblTitle3"
        Me.Label3.AccessibleName = "LblTitle3"
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(483, 412)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(166, 15)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Edad"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblCi
        '
        Me.LblCi.AccessibleDescription = "LblTitle3"
        Me.LblCi.AccessibleName = "LblTitle3"
        Me.LblCi.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblCi.AutoSize = True
        Me.LblCi.BackColor = System.Drawing.Color.Transparent
        Me.LblCi.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblCi.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCi.ForeColor = System.Drawing.Color.DarkGray
        Me.LblCi.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblCi.Location = New System.Drawing.Point(484, 386)
        Me.LblCi.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblCi.Name = "LblCi"
        Me.LblCi.Size = New System.Drawing.Size(57, 13)
        Me.LblCi.TabIndex = 25
        Me.LblCi.Text = "Credencial"
        Me.LblCi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AccessibleDescription = "LblTitle3"
        Me.Label9.AccessibleName = "LblTitle3"
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Label9.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label9.Location = New System.Drawing.Point(482, 369)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(166, 15)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "Documento o Credencial"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblName
        '
        Me.LblName.AccessibleDescription = "LblTitle3"
        Me.LblName.AccessibleName = "LblTitle3"
        Me.LblName.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblName.AutoSize = True
        Me.LblName.BackColor = System.Drawing.Color.Transparent
        Me.LblName.Cursor = System.Windows.Forms.Cursors.Default
        Me.LblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblName.ForeColor = System.Drawing.Color.DarkGray
        Me.LblName.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LblName.Location = New System.Drawing.Point(483, 342)
        Me.LblName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(91, 13)
        Me.LblName.TabIndex = 17
        Me.LblName.Text = "Nombre Completo"
        Me.LblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblTitle1
        '
        Me.LblTitle1.AccessibleDescription = "LblTitle2"
        Me.LblTitle1.AccessibleName = "LblTitle2"
        Me.LblTitle1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblTitle1.BackColor = System.Drawing.Color.Transparent
        Me.LblTitle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTitle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LblTitle1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblTitle1.Location = New System.Drawing.Point(567, 294)
        Me.LblTitle1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LblTitle1.Name = "LblTitle1"
        Me.LblTitle1.Size = New System.Drawing.Size(215, 25)
        Me.LblTitle1.TabIndex = 16
        Me.LblTitle1.Text = "ACERCA DEL MÉDICO"
        Me.LblTitle1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Lblbody
        '
        Me.Lblbody.AccessibleDescription = "LblTitle3"
        Me.Lblbody.AccessibleName = "LblTitle3"
        Me.Lblbody.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lblbody.BackColor = System.Drawing.Color.Transparent
        Me.Lblbody.Cursor = System.Windows.Forms.Cursors.Default
        Me.Lblbody.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblbody.ForeColor = System.Drawing.Color.FromArgb(CType(CType(98, Byte), Integer), CType(CType(186, Byte), Integer), CType(CType(172, Byte), Integer))
        Me.Lblbody.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Lblbody.Location = New System.Drawing.Point(482, 325)
        Me.Lblbody.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Lblbody.Name = "Lblbody"
        Me.Lblbody.Size = New System.Drawing.Size(143, 15)
        Me.Lblbody.TabIndex = 15
        Me.Lblbody.Text = "Nombre Completo"
        Me.Lblbody.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(395, 235)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(90, 84)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PicHome
        '
        Me.PicHome.Image = CType(resources.GetObject("PicHome.Image"), System.Drawing.Image)
        Me.PicHome.Location = New System.Drawing.Point(18, 35)
        Me.PicHome.Name = "PicHome"
        Me.PicHome.Size = New System.Drawing.Size(842, 200)
        Me.PicHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PicHome.TabIndex = 0
        Me.PicHome.TabStop = False
        '
        'PicSys
        '
        Me.PicSys.BackColor = System.Drawing.Color.Transparent
        Me.PicSys.Image = CType(resources.GetObject("PicSys.Image"), System.Drawing.Image)
        Me.PicSys.Location = New System.Drawing.Point(22, 250)
        Me.PicSys.Name = "PicSys"
        Me.PicSys.Size = New System.Drawing.Size(408, 390)
        Me.PicSys.TabIndex = 2
        Me.PicSys.TabStop = False
        '
        'TimerChat
        '
        Me.TimerChat.Interval = 1000
        '
        'FrmHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1060, 640)
        Me.Controls.Add(Me.PnlChat)
        Me.Controls.Add(Me.PnlRequest)
        Me.Controls.Add(Me.PanelLeft)
        Me.Controls.Add(Me.PanelHome)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FrmHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Telediagnóstico Médico: MedicApp."
        Me.PanelLeft.ResumeLayout(False)
        Me.PanelButtons.ResumeLayout(False)
        Me.PnlChat.ResumeLayout(False)
        Me.PnlChat.PerformLayout()
        Me.PnlChatBack.ResumeLayout(False)
        Me.PnlTittleChat.ResumeLayout(False)
        Me.PnlRequest.ResumeLayout(False)
        CType(Me.DgvRequests, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlTittle.ResumeLayout(False)
        CType(Me.PicBar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelHome.ResumeLayout(False)
        Me.PanelHome.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicHome, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicSys, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelLeft As Panel
    Friend WithEvents PanelButtons As Panel
    Friend WithEvents PicBar As PictureBox
    Friend WithEvents PicLogo As PictureBox
    Friend WithEvents PanelHome As Panel
    Public WithEvents LblConnect As Label
    Public WithEvents Label11 As Label
    Public WithEvents LblPhone As Label
    Public WithEvents Label7 As Label
    Public WithEvents LblEmail As Label
    Public WithEvents Label5 As Label
    Public WithEvents LblAge As Label
    Public WithEvents Label3 As Label
    Public WithEvents LblCi As Label
    Public WithEvents Label9 As Label
    Public WithEvents LblName As Label
    Public WithEvents LblTitle1 As Label
    Public WithEvents Lblbody As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PicHome As PictureBox
    Friend WithEvents PicSys As PictureBox
    Friend WithEvents BtnHome As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnRequest As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents DragCtrl As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Elipse As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents BtnLogOut As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PnlRequest As Panel
    Friend WithEvents PnlTittle As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents LblListado As Label
    Friend WithEvents TimerRequests As Timer
    Friend WithEvents DgvRequests As Guna.UI.WinForms.GunaDataGridView
    Friend WithEvents PnlChat As Panel
    Friend WithEvents PnlTittleChat As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents LblPatient As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PnlChatBack As Guna.UI2.WinForms.Guna2Panel
    Friend WithEvents TxtChat As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnSend As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BtnMore As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TxtChatSend As TextBox
    Friend WithEvents TimerChat As Timer
End Class
