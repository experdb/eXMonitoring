﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCurrentStatements
    'Inherits Monitoring.frmMonBase
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCurrentStatements))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.bckmanual = New System.ComponentModel.BackgroundWorker()
        Me.btnPause = New eXperDB.BaseControls.Button()
        Me.btnExcel = New eXperDB.BaseControls.Button()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.lblCurrentTm = New System.Windows.Forms.Label()
        Me.lblCollectTime = New System.Windows.Forms.Label()
        Me.MsgLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New eXperDB.BaseControls.Panel()
        Me.dgvStmtList = New eXperDB.BaseControls.DataGridView()
        Me.STMTTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.STMTData = New eXperDB.Monitoring.STMTData()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnEditFiltering = New eXperDB.BaseControls.Button()
        Me.cbxHideSysSQL = New eXperDB.BaseControls.CheckBox()
        Me.txtSQL = New eXperDB.BaseControls.TextBox()
        Me.lblQuery = New eXperDB.BaseControls.Label()
        Me.lblSort = New eXperDB.BaseControls.Label()
        Me.cmbOrder = New eXperDB.BaseControls.ComboBox()
        Me.nudStmtcnt = New eXperDB.BaseControls.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblCurrentStatements = New System.Windows.Forms.Label()
        Me.coldgvStmtListDB = New eXperDB.BaseControls.DataGridViewAutoFilterTextBoxColumn()
        Me.coldgvStmtListUser = New eXperDB.BaseControls.DataGridViewAutoFilterTextBoxColumn()
        Me.coldgvStmtListCalls = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.coldgvStmtListTotalTime = New eXperDB.Controls.DataGridViewTimespanColumn()
        Me.coldgvStmtListAvgTime = New eXperDB.Controls.DataGridViewTimespanColumn()
        Me.coldgvStmtListQuery = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvStmtList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STMTTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STMTData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.nudStmtcnt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bckmanual
        '
        Me.bckmanual.WorkerReportsProgress = True
        Me.bckmanual.WorkerSupportsCancellation = True
        '
        'btnPause
        '
        Me.btnPause.BackColor = System.Drawing.Color.Silver
        Me.btnPause.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnPause.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnPause.FixedHeight = False
        Me.btnPause.FixedWidth = False
        Me.btnPause.Font = New System.Drawing.Font("Webdings", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.btnPause.ForeColor = System.Drawing.Color.Blue
        Me.btnPause.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnPause.LineColor = System.Drawing.Color.LightGray
        Me.btnPause.Location = New System.Drawing.Point(1107, 15)
        Me.btnPause.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPause.Name = "btnPause"
        Me.btnPause.Radius = 5
        Me.btnPause.Size = New System.Drawing.Size(34, 31)
        Me.btnPause.TabIndex = 19
        Me.btnPause.Text = "q"
        Me.btnPause.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnPause.UseVisualStyleBackColor = True
        '
        'btnExcel
        '
        Me.btnExcel.BackColor = System.Drawing.Color.Silver
        Me.btnExcel.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnExcel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.btnExcel.FixedHeight = False
        Me.btnExcel.FixedWidth = False
        Me.btnExcel.Font = New System.Drawing.Font("Gulim", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        Me.btnExcel.ForeColor = System.Drawing.Color.Yellow
        Me.btnExcel.GraColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.btnExcel.Image = CType(resources.GetObject("btnExcel.Image"), System.Drawing.Image)
        Me.btnExcel.LineColor = System.Drawing.Color.LightGray
        Me.btnExcel.Location = New System.Drawing.Point(1147, 15)
        Me.btnExcel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Radius = 5
        Me.btnExcel.Size = New System.Drawing.Size(34, 31)
        Me.btnExcel.TabIndex = 13
        Me.btnExcel.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(56, Byte), Integer), CType(CType(56, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TableLayoutPanel2.ColumnCount = 8
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 380.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.lblCurrentTm, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblCollectTime, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnExcel, 7, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.MsgLabel, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.btnPause, 6, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1184, 50)
        Me.TableLayoutPanel2.TabIndex = 16
        '
        'lblCurrentTm
        '
        Me.lblCurrentTm.AutoSize = True
        Me.lblCurrentTm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCurrentTm.ForeColor = System.Drawing.Color.White
        Me.lblCurrentTm.Location = New System.Drawing.Point(623, 0)
        Me.lblCurrentTm.Name = "lblCurrentTm"
        Me.lblCurrentTm.Size = New System.Drawing.Size(194, 50)
        Me.lblCurrentTm.TabIndex = 25
        Me.lblCurrentTm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCollectTime
        '
        Me.lblCollectTime.AutoSize = True
        Me.lblCollectTime.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCollectTime.ForeColor = System.Drawing.Color.White
        Me.lblCollectTime.Location = New System.Drawing.Point(423, 0)
        Me.lblCollectTime.Name = "lblCollectTime"
        Me.lblCollectTime.Size = New System.Drawing.Size(194, 50)
        Me.lblCollectTime.TabIndex = 24
        Me.lblCollectTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'MsgLabel
        '
        Me.MsgLabel.AutoSize = True
        Me.MsgLabel.BackColor = System.Drawing.Color.Transparent
        Me.MsgLabel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MsgLabel.ForeColor = System.Drawing.Color.White
        Me.MsgLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MsgLabel.Location = New System.Drawing.Point(43, 0)
        Me.MsgLabel.Name = "MsgLabel"
        Me.MsgLabel.Size = New System.Drawing.Size(374, 50)
        Me.MsgLabel.TabIndex = 0
        Me.MsgLabel.Text = "Text"
        Me.MsgLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 50)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "      "
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgvStmtList)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1184, 632)
        Me.Panel1.TabIndex = 19
        '
        'dgvStmtList
        '
        Me.dgvStmtList.AllowUserToAddRows = False
        Me.dgvStmtList.AllowUserToDeleteRows = False
        Me.dgvStmtList.AllowUserToOrderColumns = True
        Me.dgvStmtList.AllowUserToResizeRows = False
        Me.dgvStmtList.AutoGenerateColumns = False
        Me.dgvStmtList.BackgroundColor = System.Drawing.Color.Black
        Me.dgvStmtList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Gulim", 9.569597!)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.DimGray
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStmtList.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvStmtList.ColumnHeadersHeight = 24
        Me.dgvStmtList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvStmtList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.coldgvStmtListDB, Me.coldgvStmtListUser, Me.coldgvStmtListCalls, Me.coldgvStmtListTotalTime, Me.coldgvStmtListAvgTime, Me.coldgvStmtListQuery})
        Me.dgvStmtList.DataSource = Me.STMTTableBindingSource
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(32, Byte), Integer), CType(CType(36, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Gulim", 9.569597!)
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvStmtList.DefaultCellStyle = DataGridViewCellStyle5
        Me.dgvStmtList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvStmtList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.dgvStmtList.EnableHeadersVisualStyles = False
        Me.dgvStmtList.Font = New System.Drawing.Font("Gulim", 9.569597!)
        Me.dgvStmtList.GridColor = System.Drawing.Color.Black
        Me.dgvStmtList.Location = New System.Drawing.Point(0, 33)
        Me.dgvStmtList.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dgvStmtList.Name = "dgvStmtList"
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Gulim", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(129, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvStmtList.RowHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvStmtList.RowHeadersVisible = False
        Me.dgvStmtList.RowTemplate.Height = 23
        Me.dgvStmtList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvStmtList.Size = New System.Drawing.Size(1184, 599)
        Me.dgvStmtList.TabIndex = 11
        Me.dgvStmtList.TagValueMatchColor = System.Drawing.Color.Black
        Me.dgvStmtList.UseTagValueMatchColor = False
        '
        'STMTTableBindingSource
        '
        Me.STMTTableBindingSource.DataMember = "STMTTable"
        Me.STMTTableBindingSource.DataSource = Me.STMTData
        '
        'STMTData
        '
        Me.STMTData.DataSetName = "STMTData"
        Me.STMTData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.TableLayoutPanel1.ColumnCount = 11
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnEditFiltering, 6, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cbxHideSysSQL, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.txtSQL, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblQuery, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblSort, 8, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbOrder, 9, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.nudStmtcnt, 10, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblCurrentStatements, 1, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1184, 33)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'btnEditFiltering
        '
        Me.btnEditFiltering.BackColor = System.Drawing.Color.Transparent
        Me.btnEditFiltering.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.btnEditFiltering.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnEditFiltering.FixedHeight = False
        Me.btnEditFiltering.FixedWidth = False
        Me.btnEditFiltering.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEditFiltering.Font = New System.Drawing.Font("Gulim", 9.0!)
        Me.btnEditFiltering.ForeColor = System.Drawing.Color.White
        Me.btnEditFiltering.GraColor = System.Drawing.Color.Gray
        Me.btnEditFiltering.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnEditFiltering.LineColor = System.Drawing.Color.Gray
        Me.btnEditFiltering.Location = New System.Drawing.Point(693, 3)
        Me.btnEditFiltering.Name = "btnEditFiltering"
        Me.btnEditFiltering.Radius = 10
        Me.btnEditFiltering.Size = New System.Drawing.Size(114, 27)
        Me.btnEditFiltering.TabIndex = 35
        Me.btnEditFiltering.Text = "F333"
        Me.btnEditFiltering.UnCheckFillColor = System.Drawing.Color.Gray
        Me.btnEditFiltering.UseVisualStyleBackColor = False
        Me.btnEditFiltering.Visible = False
        '
        'cbxHideSysSQL
        '
        Me.cbxHideSysSQL.AutoSize = True
        Me.cbxHideSysSQL.CheckFillColor = System.Drawing.Color.FromArgb(CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer), CType(CType(127, Byte), Integer))
        Me.cbxHideSysSQL.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cbxHideSysSQL.ForeColor = System.Drawing.Color.White
        Me.cbxHideSysSQL.LineColor = System.Drawing.Color.Gray
        Me.cbxHideSysSQL.Location = New System.Drawing.Point(543, 11)
        Me.cbxHideSysSQL.Margin = New System.Windows.Forms.Padding(3, 3, 3, 6)
        Me.cbxHideSysSQL.Name = "cbxHideSysSQL"
        Me.cbxHideSysSQL.Radius = 10
        Me.cbxHideSysSQL.Size = New System.Drawing.Size(144, 16)
        Me.cbxHideSysSQL.TabIndex = 34
        Me.cbxHideSysSQL.Text = "F331"
        Me.cbxHideSysSQL.UnCheckFillColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbxHideSysSQL.UseVisualStyleBackColor = True
        '
        'txtSQL
        '
        Me.txtSQL.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtSQL.BackColor = System.Drawing.SystemColors.Window
        Me.txtSQL.code = False
        Me.txtSQL.FixedWidth = False
        Me.txtSQL.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtSQL.impossibleinput = "`~!@#$%^&*\{}"
        Me.txtSQL.Location = New System.Drawing.Point(323, 6)
        Me.txtSQL.Name = "txtSQL"
        Me.txtSQL.Necessary = False
        Me.txtSQL.PossibleInput = ""
        Me.txtSQL.Prefix = ""
        Me.txtSQL.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtSQL.Size = New System.Drawing.Size(194, 21)
        Me.txtSQL.StatusTip = ""
        Me.txtSQL.TabIndex = 33
        Me.txtSQL.Value = ""
        '
        'lblQuery
        '
        Me.lblQuery.ControlLength = eXperDB.BaseControls.Label.enmLength.[Short]
        Me.lblQuery.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblQuery.FixedHeight = False
        Me.lblQuery.FixedWidth = False
        Me.lblQuery.ForeColor = System.Drawing.Color.White
        Me.lblQuery.LineSpacing = 0.0!
        Me.lblQuery.Location = New System.Drawing.Point(243, 0)
        Me.lblQuery.Name = "lblQuery"
        Me.lblQuery.Size = New System.Drawing.Size(74, 33)
        Me.lblQuery.TabIndex = 32
        Me.lblQuery.Text = "Query"
        Me.lblQuery.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblSort
        '
        Me.lblSort.BackColor = System.Drawing.Color.Transparent
        Me.lblSort.ControlLength = eXperDB.BaseControls.Label.enmLength.[Short]
        Me.lblSort.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblSort.FixedHeight = False
        Me.lblSort.FixedWidth = False
        Me.lblSort.Font = New System.Drawing.Font("Gulim", 9.2!)
        Me.lblSort.ForeColor = System.Drawing.Color.White
        Me.lblSort.LineSpacing = 0.0!
        Me.lblSort.Location = New System.Drawing.Point(937, 2)
        Me.lblSort.Name = "lblSort"
        Me.lblSort.Size = New System.Drawing.Size(64, 31)
        Me.lblSort.TabIndex = 28
        Me.lblSort.Text = "F325"
        Me.lblSort.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cmbOrder
        '
        Me.cmbOrder.BackColor = System.Drawing.SystemColors.Window
        Me.cmbOrder.DisplayMember = "All"
        Me.cmbOrder.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.cmbOrder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbOrder.FixedWidth = False
        Me.cmbOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbOrder.Font = New System.Drawing.Font("Gulim", 9.065934!)
        Me.cmbOrder.FormattingEnabled = True
        Me.cmbOrder.Items.AddRange(New Object() {"Calls", "TotalTime", "AvgTime"})
        Me.cmbOrder.Location = New System.Drawing.Point(1007, 8)
        Me.cmbOrder.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cmbOrder.Name = "cmbOrder"
        Me.cmbOrder.Necessary = False
        Me.cmbOrder.Size = New System.Drawing.Size(94, 20)
        Me.cmbOrder.StatusTip = ""
        Me.cmbOrder.TabIndex = 21
        Me.cmbOrder.ValueText = ""
        '
        'nudStmtcnt
        '
        Me.nudStmtcnt.AutoReturnTabIndex = False
        Me.nudStmtcnt.BackColor = System.Drawing.SystemColors.Window
        Me.nudStmtcnt.ControlLength = eXperDB.BaseControls.NumericUpDown.enmLength.[Short]
        Me.nudStmtcnt.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.nudStmtcnt.FixedWidth = False
        Me.nudStmtcnt.Font = New System.Drawing.Font("Batang", 9.990663!)
        Me.nudStmtcnt.Location = New System.Drawing.Point(1107, 6)
        Me.nudStmtcnt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.nudStmtcnt.Maximum = New Decimal(New Integer() {500, 0, 0, 0})
        Me.nudStmtcnt.Minimum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.nudStmtcnt.Name = "nudStmtcnt"
        Me.nudStmtcnt.Necessary = False
        Me.nudStmtcnt.Size = New System.Drawing.Size(74, 23)
        Me.nudStmtcnt.StatusTip = ""
        Me.nudStmtcnt.TabIndex = 11
        Me.nudStmtcnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudStmtcnt.Value = New Decimal(New Integer() {30, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Label2.Location = New System.Drawing.Point(3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 33)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "      "
        '
        'lblCurrentStatements
        '
        Me.lblCurrentStatements.AutoSize = True
        Me.lblCurrentStatements.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCurrentStatements.ForeColor = System.Drawing.Color.White
        Me.lblCurrentStatements.Location = New System.Drawing.Point(43, 0)
        Me.lblCurrentStatements.Name = "lblCurrentStatements"
        Me.lblCurrentStatements.Size = New System.Drawing.Size(194, 33)
        Me.lblCurrentStatements.TabIndex = 3
        Me.lblCurrentStatements.Text = "F339"
        Me.lblCurrentStatements.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'coldgvStmtListDB
        '
        Me.coldgvStmtListDB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.coldgvStmtListDB.DataPropertyName = "DATABASE_NAME"
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0"
        Me.coldgvStmtListDB.DefaultCellStyle = DataGridViewCellStyle2
        Me.coldgvStmtListDB.Frozen = True
        Me.coldgvStmtListDB.HeaderText = "F090"
        Me.coldgvStmtListDB.MinimumWidth = 100
        Me.coldgvStmtListDB.Name = "coldgvStmtListDB"
        Me.coldgvStmtListDB.ReadOnly = True
        Me.coldgvStmtListDB.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'coldgvStmtListUser
        '
        Me.coldgvStmtListUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.coldgvStmtListUser.DataPropertyName = "USER_NAME"
        Me.coldgvStmtListUser.HeaderText = "F008"
        Me.coldgvStmtListUser.MinimumWidth = 100
        Me.coldgvStmtListUser.Name = "coldgvStmtListUser"
        Me.coldgvStmtListUser.ReadOnly = True
        Me.coldgvStmtListUser.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'coldgvStmtListCalls
        '
        Me.coldgvStmtListCalls.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.coldgvStmtListCalls.DataPropertyName = "CALLS"
        Me.coldgvStmtListCalls.HeaderText = "Calls"
        Me.coldgvStmtListCalls.MinimumWidth = 100
        Me.coldgvStmtListCalls.Name = "coldgvStmtListCalls"
        Me.coldgvStmtListCalls.ReadOnly = True
        '
        'coldgvStmtListTotalTime
        '
        Me.coldgvStmtListTotalTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.coldgvStmtListTotalTime.BaseUnit = eXperDB.Controls.DataGridViewTimespanCell.SizeUnit.Milliseconds
        Me.coldgvStmtListTotalTime.DataPropertyName = "TOTAL_TIME"
        DataGridViewCellStyle3.Format = "N2"
        DataGridViewCellStyle3.NullValue = "12"
        Me.coldgvStmtListTotalTime.DefaultCellStyle = DataGridViewCellStyle3
        Me.coldgvStmtListTotalTime.FillWeight = 140.0!
        Me.coldgvStmtListTotalTime.FormatString = "dd\ \d\a\y\ hh\:mm\:ss\.ffff"
        Me.coldgvStmtListTotalTime.HeaderText = "Total time"
        Me.coldgvStmtListTotalTime.MinimumWidth = 140
        Me.coldgvStmtListTotalTime.Name = "coldgvStmtListTotalTime"
        Me.coldgvStmtListTotalTime.ReadOnly = True
        Me.coldgvStmtListTotalTime.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.coldgvStmtListTotalTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.coldgvStmtListTotalTime.Width = 140
        '
        'coldgvStmtListAvgTime
        '
        Me.coldgvStmtListAvgTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.coldgvStmtListAvgTime.BaseUnit = eXperDB.Controls.DataGridViewTimespanCell.SizeUnit.Milliseconds
        Me.coldgvStmtListAvgTime.DataPropertyName = "AVG_TIME"
        DataGridViewCellStyle4.Format = "N2"
        DataGridViewCellStyle4.NullValue = "12"
        Me.coldgvStmtListAvgTime.DefaultCellStyle = DataGridViewCellStyle4
        Me.coldgvStmtListAvgTime.FillWeight = 140.0!
        Me.coldgvStmtListAvgTime.FormatString = "dd\ \d\a\y\ hh\:mm\:ss\.ffff"
        Me.coldgvStmtListAvgTime.HeaderText = "Avg Time"
        Me.coldgvStmtListAvgTime.MinimumWidth = 140
        Me.coldgvStmtListAvgTime.Name = "coldgvStmtListAvgTime"
        Me.coldgvStmtListAvgTime.ReadOnly = True
        Me.coldgvStmtListAvgTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.coldgvStmtListAvgTime.Width = 140
        '
        'coldgvStmtListQuery
        '
        Me.coldgvStmtListQuery.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.coldgvStmtListQuery.DataPropertyName = "QUERY"
        Me.coldgvStmtListQuery.HeaderText = "F084"
        Me.coldgvStmtListQuery.MinimumWidth = 120
        Me.coldgvStmtListQuery.Name = "coldgvStmtListQuery"
        Me.coldgvStmtListQuery.ReadOnly = True
        '
        'frmCurrentStatements
        '
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1184, 682)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TableLayoutPanel2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "frmCurrentStatements"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Current Statements"
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgvStmtList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STMTTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STMTData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.nudStmtcnt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

End Sub
    Friend WithEvents bckmanual As System.ComponentModel.BackgroundWorker
    Friend WithEvents btnExcel As eXperDB.BaseControls.Button
    Friend WithEvents btnPause As eXperDB.BaseControls.Button
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents MsgLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As eXperDB.BaseControls.Panel
    Friend WithEvents dgvStmtList As eXperDB.BaseControls.DataGridView
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblCurrentStatements As System.Windows.Forms.Label
    Friend WithEvents nudStmtcnt As eXperDB.BaseControls.NumericUpDown
    Friend WithEvents cmbOrder As eXperDB.BaseControls.ComboBox
    Friend WithEvents lblSort As eXperDB.BaseControls.Label
    Friend WithEvents lblCurrentTm As System.Windows.Forms.Label
    Friend WithEvents lblCollectTime As System.Windows.Forms.Label
    Friend WithEvents txtSQL As eXperDB.BaseControls.TextBox
    Friend WithEvents lblQuery As eXperDB.BaseControls.Label
    Friend WithEvents cbxHideSysSQL As eXperDB.BaseControls.CheckBox
    Friend WithEvents btnEditFiltering As eXperDB.BaseControls.Button
    Friend WithEvents STMTTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents STMTData As eXperDB.Monitoring.STMTData
    Friend WithEvents coldgvStmtListDB As eXperDB.BaseControls.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents coldgvStmtListUser As eXperDB.BaseControls.DataGridViewAutoFilterTextBoxColumn
    Friend WithEvents coldgvStmtListCalls As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents coldgvStmtListTotalTime As eXperDB.Controls.DataGridViewTimespanColumn
    Friend WithEvents coldgvStmtListAvgTime As eXperDB.Controls.DataGridViewTimespanColumn
    Friend WithEvents coldgvStmtListQuery As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
