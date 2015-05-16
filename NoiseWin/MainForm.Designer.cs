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
            this.tpCalcTable = new System.Windows.Forms.TabPage();
            this.msMapControl = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddPartition = new System.Windows.Forms.Button();
            this.lstNoiseSources = new System.Windows.Forms.ListBox();
            this.msMain.SuspendLayout();
            this.pnlControls.SuspendLayout();
            this.pnlData.SuspendLayout();
            this.tcMap.SuspendLayout();
            this.tpMap.SuspendLayout();
            this.pnlWrapper.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.tpDescription.SuspendLayout();
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
            this.msMain.Size = new System.Drawing.Size(891, 24);
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
            // 
            // miSave
            // 
            this.miSave.Name = "miSave";
            this.miSave.Size = new System.Drawing.Size(132, 22);
            this.miSave.Text = "Сохранить";
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
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.btnAddPartition);
            this.pnlControls.Controls.Add(this.btnClearMap);
            this.pnlControls.Controls.Add(this.btnAddNoiseSource);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControls.Location = new System.Drawing.Point(0, 24);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(891, 58);
            this.pnlControls.TabIndex = 1;
            // 
            // btnClearMap
            // 
            this.btnClearMap.Location = new System.Drawing.Point(236, 9);
            this.btnClearMap.Name = "btnClearMap";
            this.btnClearMap.Size = new System.Drawing.Size(111, 39);
            this.btnClearMap.TabIndex = 1;
            this.btnClearMap.Text = "Очистить карту-схему";
            this.btnClearMap.UseVisualStyleBackColor = true;
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
            this.pnlData.Location = new System.Drawing.Point(0, 82);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(891, 253);
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
            this.tcMap.Size = new System.Drawing.Size(891, 253);
            this.tcMap.TabIndex = 0;
            // 
            // tpMap
            // 
            this.tpMap.Controls.Add(this.pnlWrapper);
            this.tpMap.Location = new System.Drawing.Point(4, 23);
            this.tpMap.Name = "tpMap";
            this.tpMap.Padding = new System.Windows.Forms.Padding(3);
            this.tpMap.Size = new System.Drawing.Size(883, 226);
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
            this.pnlWrapper.Size = new System.Drawing.Size(877, 220);
            this.pnlWrapper.TabIndex = 0;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(632, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(12, 220);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // pnlMap
            // 
            this.pnlMap.BackColor = System.Drawing.Color.LightGray;
            this.pnlMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMap.Location = new System.Drawing.Point(0, 0);
            this.pnlMap.Name = "pnlMap";
            this.pnlMap.Size = new System.Drawing.Size(644, 220);
            this.pnlMap.TabIndex = 1;
            // 
            // pnlInfo
            // 
            this.pnlInfo.Controls.Add(this.pgMapControl);
            this.pnlInfo.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlInfo.Location = new System.Drawing.Point(644, 0);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(233, 220);
            this.pnlInfo.TabIndex = 0;
            // 
            // pgMapControl
            // 
            this.pgMapControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pgMapControl.Location = new System.Drawing.Point(0, 0);
            this.pgMapControl.Name = "pgMapControl";
            this.pgMapControl.Size = new System.Drawing.Size(233, 220);
            this.pgMapControl.TabIndex = 0;
            this.pgMapControl.PropertyValueChanged += new System.Windows.Forms.PropertyValueChangedEventHandler(this.pgMapControl_PropertyValueChanged);
            // 
            // tpDescription
            // 
            this.tpDescription.Controls.Add(this.lstNoiseSources);
            this.tpDescription.Location = new System.Drawing.Point(4, 23);
            this.tpDescription.Name = "tpDescription";
            this.tpDescription.Padding = new System.Windows.Forms.Padding(3);
            this.tpDescription.Size = new System.Drawing.Size(883, 226);
            this.tpDescription.TabIndex = 1;
            this.tpDescription.Text = "Источники шума";
            this.tpDescription.UseVisualStyleBackColor = true;
            // 
            // tpCalcTable
            // 
            this.tpCalcTable.Location = new System.Drawing.Point(4, 23);
            this.tpCalcTable.Name = "tpCalcTable";
            this.tpCalcTable.Padding = new System.Windows.Forms.Padding(3);
            this.tpCalcTable.Size = new System.Drawing.Size(883, 226);
            this.tpCalcTable.TabIndex = 2;
            this.tpCalcTable.Text = "Расчет";
            this.tpCalcTable.UseVisualStyleBackColor = true;
            // 
            // msMapControl
            // 
            this.msMapControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miRemove});
            this.msMapControl.Name = "msMapControl";
            this.msMapControl.Size = new System.Drawing.Size(119, 26);
            // 
            // miRemove
            // 
            this.miRemove.Name = "miRemove";
            this.miRemove.Size = new System.Drawing.Size(118, 22);
            this.miRemove.Text = "Удалить";
            this.miRemove.Click += new System.EventHandler(this.miRemove_Click);
            // 
            // btnAddPartition
            // 
            this.btnAddPartition.Location = new System.Drawing.Point(120, 9);
            this.btnAddPartition.Name = "btnAddPartition";
            this.btnAddPartition.Size = new System.Drawing.Size(108, 39);
            this.btnAddPartition.TabIndex = 2;
            this.btnAddPartition.Text = "Добавить перегородку";
            this.btnAddPartition.UseVisualStyleBackColor = true;
            this.btnAddPartition.Click += new System.EventHandler(this.btnAddPartition_Click);
            // 
            // lstNoiseSources
            // 
            this.lstNoiseSources.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstNoiseSources.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstNoiseSources.FormattingEnabled = true;
            this.lstNoiseSources.ItemHeight = 16;
            this.lstNoiseSources.Location = new System.Drawing.Point(3, 3);
            this.lstNoiseSources.Name = "lstNoiseSources";
            this.lstNoiseSources.Size = new System.Drawing.Size(877, 220);
            this.lstNoiseSources.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 335);
            this.Controls.Add(this.pnlData);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.msMain);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.msMain;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Программа для оценки производственного шума ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.pnlControls.ResumeLayout(false);
            this.pnlData.ResumeLayout(false);
            this.tcMap.ResumeLayout(false);
            this.tpMap.ResumeLayout(false);
            this.pnlWrapper.ResumeLayout(false);
            this.pnlInfo.ResumeLayout(false);
            this.tpDescription.ResumeLayout(false);
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
    }
}

