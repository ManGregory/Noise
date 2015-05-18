namespace NoiseWin
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.miSave = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.miClose = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.miAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpRoomType = new System.Windows.Forms.GroupBox();
            this.cmbSummaryDurationOfExposure = new System.Windows.Forms.ComboBox();
            this.cmbDurationOfExposure = new System.Windows.Forms.ComboBox();
            this.cmbTimeOfTheDay = new System.Windows.Forms.ComboBox();
            this.cmbObjectPlace = new System.Windows.Forms.ComboBox();
            this.cmbNoiseCharacter = new System.Windows.Forms.ComboBox();
            this.cmbInRoom = new System.Windows.Forms.ComboBox();
            this.cmbRoomType = new System.Windows.Forms.ComboBox();
            this.cmbTableType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnAddPartition = new System.Windows.Forms.Button();
            this.btnClearMap = new System.Windows.Forms.Button();
            this.btnAddNoiseSource = new System.Windows.Forms.Button();
            this.pnlData = new System.Windows.Forms.Panel();
            this.tcMap = new System.Windows.Forms.TabControl();
            this.tpMap = new System.Windows.Forms.TabPage();
            this.pnlWrapper = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnlMap = new System.Windows.Forms.Panel();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.pgMapControl = new System.Windows.Forms.PropertyGrid();
            this.tpDescription = new System.Windows.Forms.TabPage();
            this.lstNoiseSources = new System.Windows.Forms.ListBox();
            this.wbInputTable = new System.Windows.Forms.WebBrowser();
            this.tpCalcTable = new System.Windows.Forms.TabPage();
            this.wbCalc = new System.Windows.Forms.WebBrowser();
            this.msMapControl = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miLinkElements = new System.Windows.Forms.ToolStripMenuItem();
            this.miRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.msMain.SuspendLayout();
            this.pnlControls.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpRoomType.SuspendLayout();
            this.pnlData.SuspendLayout();
            this.tcMap.SuspendLayout();
            this.tpMap.SuspendLayout();
            this.pnlWrapper.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.tpDescription.SuspendLayout();
            this.tpCalcTable.SuspendLayout();
            this.msMapControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.msMain.Size = new System.Drawing.Size(914, 24);
            this.msMain.TabIndex = 0;
            this.msMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miOpen,
            this.miSave,
            this.toolStripMenuItem2,
            this.miClose});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // miOpen
            // 
            this.miOpen.Name = "miOpen";
            this.miOpen.Size = new System.Drawing.Size(132, 22);
            this.miOpen.Text = "Открыть";
            this.miOpen.Click += new System.EventHandler(this.miOpen_Click);
            // 
            // miSave
            // 
            this.miSave.Name = "miSave";
            this.miSave.Size = new System.Drawing.Size(132, 22);
            this.miSave.Text = "Сохранить";
            this.miSave.Click += new System.EventHandler(this.miSave_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(129, 6);
            // 
            // miClose
            // 
            this.miClose.Name = "miClose";
            this.miClose.Size = new System.Drawing.Size(132, 22);
            this.miClose.Text = "Выход";
            this.miClose.Click += new System.EventHandler(this.miClose_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miHelp,
            this.toolStripMenuItem3,
            this.miAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.helpToolStripMenuItem.Text = "Справка";
            // 
            // miHelp
            // 
            this.miHelp.Name = "miHelp";
            this.miHelp.Size = new System.Drawing.Size(149, 22);
            this.miHelp.Text = "Помощь";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(146, 6);
            // 
            // miAbout
            // 
            this.miAbout.Name = "miAbout";
            this.miAbout.Size = new System.Drawing.Size(149, 22);
            this.miAbout.Text = "О программе";
            this.miAbout.Click += new System.EventHandler(this.miAbout_Click);
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.panel1);
            this.pnlControls.Controls.Add(this.btnCalc);
            this.pnlControls.Controls.Add(this.btnAddPartition);
            this.pnlControls.Controls.Add(this.btnClearMap);
            this.pnlControls.Controls.Add(this.btnAddNoiseSource);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControls.Location = new System.Drawing.Point(0, 24);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(914, 305);
            this.pnlControls.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grpRoomType);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 251);
            this.panel1.TabIndex = 5;
            // 
            // grpRoomType
            // 
            this.grpRoomType.Controls.Add(this.cmbSummaryDurationOfExposure);
            this.grpRoomType.Controls.Add(this.cmbDurationOfExposure);
            this.grpRoomType.Controls.Add(this.cmbTimeOfTheDay);
            this.grpRoomType.Controls.Add(this.cmbObjectPlace);
            this.grpRoomType.Controls.Add(this.cmbNoiseCharacter);
            this.grpRoomType.Controls.Add(this.cmbInRoom);
            this.grpRoomType.Controls.Add(this.cmbRoomType);
            this.grpRoomType.Controls.Add(this.cmbTableType);
            this.grpRoomType.Controls.Add(this.label8);
            this.grpRoomType.Controls.Add(this.label7);
            this.grpRoomType.Controls.Add(this.label6);
            this.grpRoomType.Controls.Add(this.label5);
            this.grpRoomType.Controls.Add(this.label4);
            this.grpRoomType.Controls.Add(this.label3);
            this.grpRoomType.Controls.Add(this.label2);
            this.grpRoomType.Controls.Add(this.label1);
            this.grpRoomType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpRoomType.Location = new System.Drawing.Point(0, 0);
            this.grpRoomType.Name = "grpRoomType";
            this.grpRoomType.Size = new System.Drawing.Size(914, 251);
            this.grpRoomType.TabIndex = 4;
            this.grpRoomType.TabStop = false;
            this.grpRoomType.Text = "Характеристики помещения или территории";
            // 
            // cmbSummaryDurationOfExposure
            // 
            this.cmbSummaryDurationOfExposure.FormattingEnabled = true;
            this.cmbSummaryDurationOfExposure.Location = new System.Drawing.Point(304, 212);
            this.cmbSummaryDurationOfExposure.Name = "cmbSummaryDurationOfExposure";
            this.cmbSummaryDurationOfExposure.Size = new System.Drawing.Size(598, 22);
            this.cmbSummaryDurationOfExposure.TabIndex = 16;
            this.cmbSummaryDurationOfExposure.SelectedIndexChanged += new System.EventHandler(this.cmbTableType_SelectedIndexChanged);
            // 
            // cmbDurationOfExposure
            // 
            this.cmbDurationOfExposure.FormattingEnabled = true;
            this.cmbDurationOfExposure.Location = new System.Drawing.Point(304, 184);
            this.cmbDurationOfExposure.Name = "cmbDurationOfExposure";
            this.cmbDurationOfExposure.Size = new System.Drawing.Size(598, 22);
            this.cmbDurationOfExposure.TabIndex = 15;
            this.cmbDurationOfExposure.SelectedIndexChanged += new System.EventHandler(this.cmbTableType_SelectedIndexChanged);
            // 
            // cmbTimeOfTheDay
            // 
            this.cmbTimeOfTheDay.FormattingEnabled = true;
            this.cmbTimeOfTheDay.Location = new System.Drawing.Point(304, 156);
            this.cmbTimeOfTheDay.Name = "cmbTimeOfTheDay";
            this.cmbTimeOfTheDay.Size = new System.Drawing.Size(598, 22);
            this.cmbTimeOfTheDay.TabIndex = 14;
            this.cmbTimeOfTheDay.SelectedIndexChanged += new System.EventHandler(this.cmbTableType_SelectedIndexChanged);
            // 
            // cmbObjectPlace
            // 
            this.cmbObjectPlace.FormattingEnabled = true;
            this.cmbObjectPlace.Location = new System.Drawing.Point(304, 128);
            this.cmbObjectPlace.Name = "cmbObjectPlace";
            this.cmbObjectPlace.Size = new System.Drawing.Size(598, 22);
            this.cmbObjectPlace.TabIndex = 13;
            this.cmbObjectPlace.SelectedIndexChanged += new System.EventHandler(this.cmbTableType_SelectedIndexChanged);
            // 
            // cmbNoiseCharacter
            // 
            this.cmbNoiseCharacter.FormattingEnabled = true;
            this.cmbNoiseCharacter.Location = new System.Drawing.Point(304, 100);
            this.cmbNoiseCharacter.Name = "cmbNoiseCharacter";
            this.cmbNoiseCharacter.Size = new System.Drawing.Size(598, 22);
            this.cmbNoiseCharacter.TabIndex = 12;
            this.cmbNoiseCharacter.SelectedIndexChanged += new System.EventHandler(this.cmbTableType_SelectedIndexChanged);
            // 
            // cmbInRoom
            // 
            this.cmbInRoom.FormattingEnabled = true;
            this.cmbInRoom.Location = new System.Drawing.Point(304, 72);
            this.cmbInRoom.Name = "cmbInRoom";
            this.cmbInRoom.Size = new System.Drawing.Size(598, 22);
            this.cmbInRoom.TabIndex = 11;
            this.cmbInRoom.SelectedIndexChanged += new System.EventHandler(this.cmbTableType_SelectedIndexChanged);
            // 
            // cmbRoomType
            // 
            this.cmbRoomType.FormattingEnabled = true;
            this.cmbRoomType.Location = new System.Drawing.Point(304, 45);
            this.cmbRoomType.Name = "cmbRoomType";
            this.cmbRoomType.Size = new System.Drawing.Size(598, 22);
            this.cmbRoomType.TabIndex = 10;
            this.cmbRoomType.SelectedIndexChanged += new System.EventHandler(this.cmbTableType_SelectedIndexChanged);
            // 
            // cmbTableType
            // 
            this.cmbTableType.FormattingEnabled = true;
            this.cmbTableType.Location = new System.Drawing.Point(304, 18);
            this.cmbTableType.Name = "cmbTableType";
            this.cmbTableType.Size = new System.Drawing.Size(598, 22);
            this.cmbTableType.TabIndex = 8;
            this.cmbTableType.SelectedIndexChanged += new System.EventHandler(this.cmbTableType_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(284, 14);
            this.label8.TabIndex = 7;
            this.label8.Text = "Суммарная длительность воздействия за смену:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 14);
            this.label7.TabIndex = 6;
            this.label7.Text = "Нормативная таблица:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(282, 14);
            this.label6.TabIndex = 5;
            this.label6.Text = "Длительность воздействия прерывистого шума:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "РТ внутри или снаружи помещения:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 14);
            this.label4.TabIndex = 3;
            this.label4.Text = "Характер шума: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Местоположение объекта:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Время суток:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название помещения или территории: ";
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(353, 9);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(111, 39);
            this.btnCalc.TabIndex = 3;
            this.btnCalc.Text = "Выполнить расчет\r\n";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnAddPartition
            // 
            this.btnAddPartition.Location = new System.Drawing.Point(119, 9);
            this.btnAddPartition.Name = "btnAddPartition";
            this.btnAddPartition.Size = new System.Drawing.Size(108, 39);
            this.btnAddPartition.TabIndex = 2;
            this.btnAddPartition.Text = "Добавить перегородку";
            this.btnAddPartition.UseVisualStyleBackColor = true;
            this.btnAddPartition.Click += new System.EventHandler(this.btnAddPartition_Click);
            // 
            // btnClearMap
            // 
            this.btnClearMap.Location = new System.Drawing.Point(236, 9);
            this.btnClearMap.Name = "btnClearMap";
            this.btnClearMap.Size = new System.Drawing.Size(111, 39);
            this.btnClearMap.TabIndex = 1;
            this.btnClearMap.Text = "Очистить карту-схему";
            this.btnClearMap.UseVisualStyleBackColor = true;
            this.btnClearMap.Click += new System.EventHandler(this.btnClearMap_Click);
            // 
            // btnAddNoiseSource
            // 
            this.btnAddNoiseSource.Location = new System.Drawing.Point(5, 9);
            this.btnAddNoiseSource.Name = "btnAddNoiseSource";
            this.btnAddNoiseSource.Size = new System.Drawing.Size(108, 39);
            this.btnAddNoiseSource.TabIndex = 0;
            this.btnAddNoiseSource.Text = "Добавить источник шума";
            this.btnAddNoiseSource.UseVisualStyleBackColor = true;
            this.btnAddNoiseSource.Click += new System.EventHandler(this.btnAddNoiseSource_Click);
            // 
            // pnlData
            // 
            this.pnlData.Controls.Add(this.tcMap);
            this.pnlData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlData.Location = new System.Drawing.Point(0, 329);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(914, 176);
            this.pnlData.TabIndex = 2;
            // 
            // tcMap
            // 
            this.tcMap.Controls.Add(this.tpMap);
            this.tcMap.Controls.Add(this.tpDescription);
            this.tcMap.Controls.Add(this.tpCalcTable);
            this.tcMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMap.Location = new System.Drawing.Point(0, 0);
            this.tcMap.Name = "tcMap";
            this.tcMap.SelectedIndex = 0;
            this.tcMap.Size = new System.Drawing.Size(914, 176);
            this.tcMap.TabIndex = 0;
            // 
            // tpMap
            // 
            this.tpMap.Controls.Add(this.pnlWrapper);
            this.tpMap.Location = new System.Drawing.Point(4, 23);
            this.tpMap.Name = "tpMap";
            this.tpMap.Padding = new System.Windows.Forms.Padding(3);
            this.tpMap.Size = new System.Drawing.Size(906, 149);
            this.tpMap.TabIndex = 0;
            this.tpMap.Text = "Карта-схема";
            this.tpMap.UseVisualStyleBackColor = true;
            // 
            // pnlWrapper
            // 
            this.pnlWrapper.Controls.Add(this.splitter1);
            this.pnlWrapper.Controls.Add(this.pnlMap);
            this.pnlWrapper.Controls.Add(this.pnlInfo);
            this.pnlWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWrapper.Location = new System.Drawing.Point(3, 3);
            this.pnlWrapper.Name = "pnlWrapper";
            this.pnlWrapper.Size = new System.Drawing.Size(900, 143);
            this.pnlWrapper.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(596, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(12, 143);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // pnlMap
            // 
            this.pnlMap.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMap.Location = new System.Drawing.Point(0, 0);
            this.pnlMap.Name = "pnlMap";
            this.pnlMap.Size = new System.Drawing.Size(608, 143);
            this.pnlMap.TabIndex = 1;
            // 
            // pnlInfo
            // 
            this.pnlInfo.Controls.Add(this.pgMapControl);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlInfo.Location = new System.Drawing.Point(608, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(292, 143);
            this.pnlInfo.TabIndex = 0;
            // 
            // pgMapControl
            // 
            this.pgMapControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgMapControl.Location = new System.Drawing.Point(0, 0);
            this.pgMapControl.Name = "pgMapControl";
            this.pgMapControl.Size = new System.Drawing.Size(292, 143);
            this.pgMapControl.TabIndex = 0;
            this.pgMapControl.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.pgMapControl_PropertyValueChanged);
            // 
            // tpDescription
            // 
            this.tpDescription.Controls.Add(this.lstNoiseSources);
            this.tpDescription.Controls.Add(this.wbInputTable);
            this.tpDescription.Location = new System.Drawing.Point(4, 23);
            this.tpDescription.Name = "tpDescription";
            this.tpDescription.Padding = new System.Windows.Forms.Padding(3);
            this.tpDescription.Size = new System.Drawing.Size(906, 149);
            this.tpDescription.TabIndex = 1;
            this.tpDescription.Text = "Источники шума";
            this.tpDescription.UseVisualStyleBackColor = true;
            // 
            // lstNoiseSources
            // 
            this.lstNoiseSources.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstNoiseSources.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstNoiseSources.FormattingEnabled = true;
            this.lstNoiseSources.ItemHeight = 16;
            this.lstNoiseSources.Location = new System.Drawing.Point(3, 3);
            this.lstNoiseSources.Name = "lstNoiseSources";
            this.lstNoiseSources.Size = new System.Drawing.Size(900, 143);
            this.lstNoiseSources.TabIndex = 0;
            this.lstNoiseSources.Visible = false;
            // 
            // wbInputTable
            // 
            this.wbInputTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbInputTable.Location = new System.Drawing.Point(3, 3);
            this.wbInputTable.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbInputTable.Name = "wbInputTable";
            this.wbInputTable.Size = new System.Drawing.Size(900, 143);
            this.wbInputTable.TabIndex = 1;
            // 
            // tpCalcTable
            // 
            this.tpCalcTable.Controls.Add(this.wbCalc);
            this.tpCalcTable.Location = new System.Drawing.Point(4, 23);
            this.tpCalcTable.Name = "tpCalcTable";
            this.tpCalcTable.Padding = new System.Windows.Forms.Padding(3);
            this.tpCalcTable.Size = new System.Drawing.Size(906, 149);
            this.tpCalcTable.TabIndex = 2;
            this.tpCalcTable.Text = "Расчет";
            this.tpCalcTable.UseVisualStyleBackColor = true;
            // 
            // wbCalc
            // 
            this.wbCalc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbCalc.Location = new System.Drawing.Point(3, 3);
            this.wbCalc.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbCalc.Name = "wbCalc";
            this.wbCalc.Size = new System.Drawing.Size(900, 143);
            this.wbCalc.TabIndex = 0;
            // 
            // msMapControl
            // 
            this.msMapControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miLinkElements,
            this.miRemove});
            this.msMapControl.Name = "msMapControl";
            this.msMapControl.Size = new System.Drawing.Size(207, 48);
            this.msMapControl.Opening += new System.ComponentModel.CancelEventHandler(this.msMapControl_Opening);
            // 
            // miLinkElements
            // 
            this.miLinkElements.Name = "miLinkElements";
            this.miLinkElements.Size = new System.Drawing.Size(206, 22);
            this.miLinkElements.Text = "Связать с перегородкой";
            this.miLinkElements.Click += new System.EventHandler(this.miLinkElements_Click);
            // 
            // miRemove
            // 
            this.miRemove.Name = "miRemove";
            this.miRemove.Size = new System.Drawing.Size(206, 22);
            this.miRemove.Text = "Удалить";
            this.miRemove.Click += new System.EventHandler(this.miRemove_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 505);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.msMain);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.msMain;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Программа для оценки производственного шума ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.pnlControls.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.grpRoomType.ResumeLayout(false);
            this.grpRoomType.PerformLayout();
            this.pnlData.ResumeLayout(false);
            this.tcMap.ResumeLayout(false);
            this.tpMap.ResumeLayout(false);
            this.pnlWrapper.ResumeLayout(false);
            this.pnlInfo.ResumeLayout(false);
            this.tpDescription.ResumeLayout(false);
            this.tpCalcTable.ResumeLayout(false);
            this.msMapControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miOpen;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miSave;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem miClose;
        private System.Windows.Forms.ToolStripMenuItem miHelp;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem miAbout;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.TabControl tcMap;
        private System.Windows.Forms.TabPage tpMap;
        private System.Windows.Forms.Panel pnlWrapper;
        private System.Windows.Forms.Panel pnlMap;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.TabPage tpDescription;
        private System.Windows.Forms.TabPage tpCalcTable;
        private System.Windows.Forms.Button btnClearMap;
        private System.Windows.Forms.Button btnAddNoiseSource;
        private System.Windows.Forms.PropertyGrid pgMapControl;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ContextMenuStrip msMapControl;
        private System.Windows.Forms.ToolStripMenuItem miRemove;
        private System.Windows.Forms.Button btnAddPartition;
        private System.Windows.Forms.ListBox lstNoiseSources;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.WebBrowser wbInputTable;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpRoomType;
        private System.Windows.Forms.ComboBox cmbNoiseCharacter;
        private System.Windows.Forms.ComboBox cmbInRoom;
        private System.Windows.Forms.ComboBox cmbRoomType;
        private System.Windows.Forms.ComboBox cmbTableType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSummaryDurationOfExposure;
        private System.Windows.Forms.ComboBox cmbDurationOfExposure;
        private System.Windows.Forms.ComboBox cmbTimeOfTheDay;
        private System.Windows.Forms.ComboBox cmbObjectPlace;
        private System.Windows.Forms.WebBrowser wbCalc;
        private System.Windows.Forms.ToolStripMenuItem miLinkElements;
        private System.Windows.Forms.Timer timer1;
    }
}

