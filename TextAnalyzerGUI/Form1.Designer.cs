namespace TextAnalyzerGUI
{
    partial class frmTextAnalyzer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtText = new System.Windows.Forms.TextBox();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.ltvDictionary = new System.Windows.Forms.ListView();
            this.Words = new System.Windows.Forms.ColumnHeader();
            this.TimesAppeared = new System.Windows.Forms.ColumnHeader();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.grpButtons = new System.Windows.Forms.GroupBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.lblSentences = new System.Windows.Forms.Label();
            this.lblWords = new System.Windows.Forms.Label();
            this.lblUniqueWords = new System.Windows.Forms.Label();
            this.lblSentenceCount = new System.Windows.Forms.Label();
            this.lblWordCount = new System.Windows.Forms.Label();
            this.lblUniqueWordCount = new System.Windows.Forms.Label();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.tsmFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmClear = new System.Windows.Forms.ToolStripMenuItem();
            this.colorModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmClassicMode = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDarkMode = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDarkKnightMode = new System.Windows.Forms.ToolStripMenuItem();
            this.grpButtons.SuspendLayout();
            this.grpResults.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtText
            // 
            this.txtText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtText.BackColor = System.Drawing.Color.White;
            this.txtText.ForeColor = System.Drawing.Color.Black;
            this.txtText.Location = new System.Drawing.Point(7, 176);
            this.txtText.Margin = new System.Windows.Forms.Padding(4);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(429, 529);
            this.txtText.TabIndex = 4;
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAnalyze.Location = new System.Drawing.Point(7, 29);
            this.btnAnalyze.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(194, 57);
            this.btnAnalyze.TabIndex = 1;
            this.btnAnalyze.Text = "&Analyze";
            this.btnAnalyze.UseVisualStyleBackColor = false;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClear.Location = new System.Drawing.Point(242, 100);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(194, 58);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnExit.Location = new System.Drawing.Point(7, 97);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(194, 58);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // ltvDictionary
            // 
            this.ltvDictionary.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Words,
            this.TimesAppeared});
            this.ltvDictionary.FullRowSelect = true;
            this.ltvDictionary.Location = new System.Drawing.Point(516, 327);
            this.ltvDictionary.Name = "ltvDictionary";
            this.ltvDictionary.Size = new System.Drawing.Size(328, 386);
            this.ltvDictionary.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.ltvDictionary.TabIndex = 7;
            this.ltvDictionary.UseCompatibleStateImageBehavior = false;
            this.ltvDictionary.View = System.Windows.Forms.View.Details;
            // 
            // Words
            // 
            this.Words.Text = "Words";
            this.Words.Width = 150;
            // 
            // TimesAppeared
            // 
            this.TimesAppeared.Text = "Times Appeared";
            this.TimesAppeared.Width = 150;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(516, 265);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(74, 28);
            this.lblSearch.TabIndex = 5;
            this.lblSearch.Text = "Search:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(596, 265);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(248, 34);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // grpButtons
            // 
            this.grpButtons.Controls.Add(this.btnOpenFile);
            this.grpButtons.Controls.Add(this.btnClear);
            this.grpButtons.Controls.Add(this.btnExit);
            this.grpButtons.Controls.Add(this.txtText);
            this.grpButtons.Controls.Add(this.btnAnalyze);
            this.grpButtons.Location = new System.Drawing.Point(48, 39);
            this.grpButtons.Name = "grpButtons";
            this.grpButtons.Size = new System.Drawing.Size(444, 729);
            this.grpButtons.TabIndex = 1;
            this.grpButtons.TabStop = false;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnOpenFile.Location = new System.Drawing.Point(242, 29);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(194, 58);
            this.btnOpenFile.TabIndex = 2;
            this.btnOpenFile.Text = "&Open File...";
            this.btnOpenFile.UseVisualStyleBackColor = false;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // lblSentences
            // 
            this.lblSentences.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSentences.AutoSize = true;
            this.lblSentences.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSentences.Location = new System.Drawing.Point(44, 54);
            this.lblSentences.Name = "lblSentences";
            this.lblSentences.Size = new System.Drawing.Size(108, 28);
            this.lblSentences.TabIndex = 8;
            this.lblSentences.Text = "Sentences: ";
            // 
            // lblWords
            // 
            this.lblWords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWords.AutoSize = true;
            this.lblWords.Location = new System.Drawing.Point(74, 91);
            this.lblWords.Name = "lblWords";
            this.lblWords.Size = new System.Drawing.Size(78, 28);
            this.lblWords.TabIndex = 9;
            this.lblWords.Text = "Words: ";
            // 
            // lblUniqueWords
            // 
            this.lblUniqueWords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUniqueWords.AutoSize = true;
            this.lblUniqueWords.Location = new System.Drawing.Point(6, 127);
            this.lblUniqueWords.Name = "lblUniqueWords";
            this.lblUniqueWords.Size = new System.Drawing.Size(146, 28);
            this.lblUniqueWords.TabIndex = 10;
            this.lblUniqueWords.Text = "Unique Words: ";
            // 
            // lblSentenceCount
            // 
            this.lblSentenceCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSentenceCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSentenceCount.Location = new System.Drawing.Point(158, 54);
            this.lblSentenceCount.Name = "lblSentenceCount";
            this.lblSentenceCount.Size = new System.Drawing.Size(189, 32);
            this.lblSentenceCount.TabIndex = 11;
            // 
            // lblWordCount
            // 
            this.lblWordCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWordCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblWordCount.Location = new System.Drawing.Point(158, 90);
            this.lblWordCount.Name = "lblWordCount";
            this.lblWordCount.Size = new System.Drawing.Size(189, 31);
            this.lblWordCount.TabIndex = 12;
            // 
            // lblUniqueWordCount
            // 
            this.lblUniqueWordCount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUniqueWordCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblUniqueWordCount.Location = new System.Drawing.Point(158, 126);
            this.lblUniqueWordCount.Name = "lblUniqueWordCount";
            this.lblUniqueWordCount.Size = new System.Drawing.Size(189, 32);
            this.lblUniqueWordCount.TabIndex = 13;
            // 
            // grpResults
            // 
            this.grpResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpResults.Controls.Add(this.lblSentences);
            this.grpResults.Controls.Add(this.lblUniqueWordCount);
            this.grpResults.Controls.Add(this.lblWords);
            this.grpResults.Controls.Add(this.lblWordCount);
            this.grpResults.Controls.Add(this.lblUniqueWords);
            this.grpResults.Controls.Add(this.lblSentenceCount);
            this.grpResults.Location = new System.Drawing.Point(516, 39);
            this.grpResults.Name = "grpResults";
            this.grpResults.Size = new System.Drawing.Size(378, 200);
            this.grpResults.TabIndex = 14;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "Results";
            // 
            // mnuMain
            // 
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmFile,
            this.tsmOptions,
            this.colorModeToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(949, 28);
            this.mnuMain.TabIndex = 15;
            this.mnuMain.Text = "MainMenuStrip";
            // 
            // tsmFile
            // 
            this.tsmFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmOpenFile,
            this.tsmExit});
            this.tsmFile.Name = "tsmFile";
            this.tsmFile.Size = new System.Drawing.Size(46, 24);
            this.tsmFile.Text = "File";
            // 
            // tsmOpenFile
            // 
            this.tsmOpenFile.Name = "tsmOpenFile";
            this.tsmOpenFile.Size = new System.Drawing.Size(164, 26);
            this.tsmOpenFile.Text = "Open File...";
            this.tsmOpenFile.Click += new System.EventHandler(this.tsmOpenFile_Click);
            // 
            // tsmExit
            // 
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.Size = new System.Drawing.Size(164, 26);
            this.tsmExit.Text = "Exit";
            this.tsmExit.Click += new System.EventHandler(this.tsmExit_Click);
            // 
            // tsmOptions
            // 
            this.tsmOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmClear});
            this.tsmOptions.Name = "tsmOptions";
            this.tsmOptions.Size = new System.Drawing.Size(75, 24);
            this.tsmOptions.Text = "Options";
            // 
            // tsmClear
            // 
            this.tsmClear.Name = "tsmClear";
            this.tsmClear.Size = new System.Drawing.Size(126, 26);
            this.tsmClear.Text = "Clear";
            this.tsmClear.Click += new System.EventHandler(this.tsmClear_Click);
            // 
            // colorModeToolStripMenuItem
            // 
            this.colorModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmClassicMode,
            this.tsmDarkMode,
            this.tsmDarkKnightMode});
            this.colorModeToolStripMenuItem.Name = "colorModeToolStripMenuItem";
            this.colorModeToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.colorModeToolStripMenuItem.Text = "Color Mode";
            // 
            // tsmClassicMode
            // 
            this.tsmClassicMode.Name = "tsmClassicMode";
            this.tsmClassicMode.Size = new System.Drawing.Size(213, 26);
            this.tsmClassicMode.Text = "Classic Mode";
            this.tsmClassicMode.Click += new System.EventHandler(this.tsmClassicMode_Click);
            // 
            // tsmDarkMode
            // 
            this.tsmDarkMode.Name = "tsmDarkMode";
            this.tsmDarkMode.Size = new System.Drawing.Size(213, 26);
            this.tsmDarkMode.Text = "Dark Mode";
            this.tsmDarkMode.Click += new System.EventHandler(this.tsmDarkMode_Click);
            // 
            // tsmDarkKnightMode
            // 
            this.tsmDarkKnightMode.Name = "tsmDarkKnightMode";
            this.tsmDarkKnightMode.Size = new System.Drawing.Size(213, 26);
            this.tsmDarkKnightMode.Text = "Dark Knight Mode";
            this.tsmDarkKnightMode.Click += new System.EventHandler(this.tsmDarkKnightMode_Click);
            // 
            // frmTextAnalyzer
            // 
            this.AcceptButton = this.btnAnalyze;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(949, 795);
            this.Controls.Add(this.grpResults);
            this.Controls.Add(this.grpButtons);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.ltvDictionary);
            this.Controls.Add(this.mnuMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.mnuMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmTextAnalyzer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Text Analyzer";
            this.grpButtons.ResumeLayout(false);
            this.grpButtons.PerformLayout();
            this.grpResults.ResumeLayout(false);
            this.grpResults.PerformLayout();
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtText;
        private Button btnAnalyze;
        private Button btnClear;
        private Button btnExit;
        private ListView ltvDictionary;
        private ColumnHeader Words;
        private ColumnHeader TimesAppeared;
        private Label lblSearch;
        private TextBox txtSearch;
        private GroupBox grpButtons;
        private Button btnOpenFile;
        private Label lblSentences;
        private Label lblWords;
        private Label lblUniqueWords;
        private Label lblSentenceCount;
        private Label lblWordCount;
        private Label lblUniqueWordCount;
        private GroupBox grpResults;
        private MenuStrip mnuMain;
        private ToolStripMenuItem tsmFile;
        private ToolStripMenuItem tsmOpenFile;
        private ToolStripMenuItem tsmExit;
        private ToolStripMenuItem tsmOptions;
        private ToolStripMenuItem tsmClear;
        private ToolStripMenuItem colorModeToolStripMenuItem;
        private ToolStripMenuItem tsmClassicMode;
        private ToolStripMenuItem tsmDarkMode;
        private ToolStripMenuItem tsmDarkKnightMode;
    }
}