namespace RegexTester
{
  partial class frmMain
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
      this.StatusStrip = new System.Windows.Forms.StatusStrip();
      this.sbStatus = new System.Windows.Forms.ToolStripStatusLabel();
      this.sbMatches = new System.Windows.Forms.ToolStripStatusLabel();
      this.sbTime = new System.Windows.Forms.ToolStripStatusLabel();
      this.MenuStrip = new System.Windows.Forms.MenuStrip();
      this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuFileOpenTestFile = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuFileSaveResultsAs = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuFileLine1 = new System.Windows.Forms.ToolStripSeparator();
      this.mnuFileExit = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuEditCopyWholeRegExAsC = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuEditCopyWholeRegExAsVB = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuEditLine1 = new System.Windows.Forms.ToolStripSeparator();
      this.mnuEditZoomIn = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuEditZoomOut = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuHelpInfo = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuHelpLine1 = new System.Windows.Forms.ToolStripSeparator();
      this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
      this.optionToolTip = new System.Windows.Forms.ToolTip(this.components);
      this.gbWordWrap = new System.Windows.Forms.GroupBox();
      this.chkInputWordWrap = new System.Windows.Forms.CheckBox();
      this.chkResultWordWrap = new System.Windows.Forms.CheckBox();
      this.txtReplace = new FastColoredTextBoxNS.FastColoredTextBox();
      this.txtPattern = new FastColoredTextBoxNS.FastColoredTextBox();
      this.gbOptions = new System.Windows.Forms.GroupBox();
      this.cbGlobal = new System.Windows.Forms.CheckBox();
      this.cbRightToLeft = new System.Windows.Forms.CheckBox();
      this.cbCultureInvariant = new System.Windows.Forms.CheckBox();
      this.cbIgnoreCase = new System.Windows.Forms.CheckBox();
      this.cbSingleLine = new System.Windows.Forms.CheckBox();
      this.cbIgnoreWhiteSpace = new System.Windows.Forms.CheckBox();
      this.cbMultiline = new System.Windows.Forms.CheckBox();
      this.cbECMAScript = new System.Windows.Forms.CheckBox();
      this.cbExplicitCapture = new System.Windows.Forms.CheckBox();
      this.cbCompiled = new System.Windows.Forms.CheckBox();
      this.cbMatchImmediately = new System.Windows.Forms.CheckBox();
      this.lblReplacement = new System.Windows.Forms.Label();
      this.lblRegular = new System.Windows.Forms.Label();
      this.btnReplace = new System.Windows.Forms.Button();
      this.btnMatches = new System.Windows.Forms.Button();
      this.btnStop = new System.Windows.Forms.Button();
      this.tbPanelFull = new System.Windows.Forms.TableLayoutPanel();
      this.grdResult = new System.Windows.Forms.DataGridView();
      this.splitInputResult = new RegexTester.SplitContainerEx();
      this.tlpInput = new System.Windows.Forms.TableLayoutPanel();
      this.lblInput = new System.Windows.Forms.Label();
      this.fctbInput = new FastColoredTextBoxNS.FastColoredTextBox();
      this.tlpResult = new System.Windows.Forms.TableLayoutPanel();
      this.lblResult = new System.Windows.Forms.Label();
      this.fctbResult = new FastColoredTextBoxNS.FastColoredTextBox();
      this.StatusStrip.SuspendLayout();
      this.MenuStrip.SuspendLayout();
      this.gbWordWrap.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txtReplace)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtPattern)).BeginInit();
      this.gbOptions.SuspendLayout();
      this.tbPanelFull.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.grdResult)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.splitInputResult)).BeginInit();
      this.splitInputResult.Panel1.SuspendLayout();
      this.splitInputResult.Panel2.SuspendLayout();
      this.splitInputResult.SuspendLayout();
      this.tlpInput.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.fctbInput)).BeginInit();
      this.tlpResult.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.fctbResult)).BeginInit();
      this.SuspendLayout();
      // 
      // StatusStrip
      // 
      this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbStatus,
            this.sbMatches,
            this.sbTime});
      this.StatusStrip.Location = new System.Drawing.Point(0, 487);
      this.StatusStrip.Name = "StatusStrip";
      this.StatusStrip.Size = new System.Drawing.Size(812, 22);
      this.StatusStrip.TabIndex = 17;
      this.StatusStrip.Text = "StatusStrip";
      // 
      // sbStatus
      // 
      this.sbStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.sbStatus.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.sbStatus.Name = "sbStatus";
      this.sbStatus.Size = new System.Drawing.Size(797, 17);
      this.sbStatus.Spring = true;
      this.sbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // sbMatches
      // 
      this.sbMatches.Name = "sbMatches";
      this.sbMatches.Size = new System.Drawing.Size(0, 17);
      // 
      // sbTime
      // 
      this.sbTime.Name = "sbTime";
      this.sbTime.Size = new System.Drawing.Size(0, 17);
      // 
      // MenuStrip
      // 
      this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit,
            this.mnuHelp});
      this.MenuStrip.Location = new System.Drawing.Point(0, 0);
      this.MenuStrip.Name = "MenuStrip";
      this.MenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
      this.MenuStrip.Size = new System.Drawing.Size(812, 24);
      this.MenuStrip.TabIndex = 16;
      // 
      // mnuFile
      // 
      this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileOpenTestFile,
            this.mnuFileSaveResultsAs,
            this.mnuFileLine1,
            this.mnuFileExit});
      this.mnuFile.Name = "mnuFile";
      this.mnuFile.Size = new System.Drawing.Size(37, 20);
      this.mnuFile.Text = "File";
      // 
      // mnuFileOpenTestFile
      // 
      this.mnuFileOpenTestFile.Image = global::RegexTester.Properties.Resources.document_flat_open;
      this.mnuFileOpenTestFile.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.mnuFileOpenTestFile.Name = "mnuFileOpenTestFile";
      this.mnuFileOpenTestFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
      this.mnuFileOpenTestFile.Size = new System.Drawing.Size(178, 22);
      this.mnuFileOpenTestFile.Text = "Open File";
      this.mnuFileOpenTestFile.Click += new System.EventHandler(this.mnuFileOpenTestFile_Click);
      // 
      // mnuFileSaveResultsAs
      // 
      this.mnuFileSaveResultsAs.Image = global::RegexTester.Properties.Resources.save_as;
      this.mnuFileSaveResultsAs.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.mnuFileSaveResultsAs.Name = "mnuFileSaveResultsAs";
      this.mnuFileSaveResultsAs.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
      this.mnuFileSaveResultsAs.Size = new System.Drawing.Size(178, 22);
      this.mnuFileSaveResultsAs.Text = "Save Results";
      this.mnuFileSaveResultsAs.Click += new System.EventHandler(this.mnuFileSaveResultsAs_Click);
      // 
      // mnuFileLine1
      // 
      this.mnuFileLine1.Name = "mnuFileLine1";
      this.mnuFileLine1.Size = new System.Drawing.Size(175, 6);
      // 
      // mnuFileExit
      // 
      this.mnuFileExit.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.mnuFileExit.Name = "mnuFileExit";
      this.mnuFileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
      this.mnuFileExit.Size = new System.Drawing.Size(178, 22);
      this.mnuFileExit.Text = "Exit";
      this.mnuFileExit.Click += new System.EventHandler(this.mnuFileExit_Click);
      // 
      // mnuEdit
      // 
      this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEditCopyWholeRegExAsC,
            this.mnuEditCopyWholeRegExAsVB,
            this.mnuEditLine1,
            this.mnuEditZoomIn,
            this.mnuEditZoomOut});
      this.mnuEdit.Name = "mnuEdit";
      this.mnuEdit.Size = new System.Drawing.Size(39, 20);
      this.mnuEdit.Text = "Edit";
      // 
      // mnuEditCopyWholeRegExAsC
      // 
      this.mnuEditCopyWholeRegExAsC.Name = "mnuEditCopyWholeRegExAsC";
      this.mnuEditCopyWholeRegExAsC.Size = new System.Drawing.Size(168, 22);
      this.mnuEditCopyWholeRegExAsC.Text = "Copy RegEx as C#";
      this.mnuEditCopyWholeRegExAsC.Click += new System.EventHandler(this.mnuEditCopyWholeRegExAsC_Click);
      // 
      // mnuEditCopyWholeRegExAsVB
      // 
      this.mnuEditCopyWholeRegExAsVB.Name = "mnuEditCopyWholeRegExAsVB";
      this.mnuEditCopyWholeRegExAsVB.Size = new System.Drawing.Size(168, 22);
      this.mnuEditCopyWholeRegExAsVB.Text = "Copy RegEx as VB";
      this.mnuEditCopyWholeRegExAsVB.Click += new System.EventHandler(this.mnuEditCopyWholeRegExAsVB_Click);
      // 
      // mnuEditLine1
      // 
      this.mnuEditLine1.Name = "mnuEditLine1";
      this.mnuEditLine1.Size = new System.Drawing.Size(165, 6);
      // 
      // mnuEditZoomIn
      // 
      this.mnuEditZoomIn.Image = global::RegexTester.Properties.Resources.zoom_in;
      this.mnuEditZoomIn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.mnuEditZoomIn.Name = "mnuEditZoomIn";
      this.mnuEditZoomIn.ShortcutKeyDisplayString = "Ctrl +";
      this.mnuEditZoomIn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
      this.mnuEditZoomIn.Size = new System.Drawing.Size(168, 22);
      this.mnuEditZoomIn.Text = "Zoom In";
      this.mnuEditZoomIn.Click += new System.EventHandler(this.mnuEditZoomIn_Click);
      // 
      // mnuEditZoomOut
      // 
      this.mnuEditZoomOut.Image = global::RegexTester.Properties.Resources.zoom_out;
      this.mnuEditZoomOut.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.mnuEditZoomOut.Name = "mnuEditZoomOut";
      this.mnuEditZoomOut.ShortcutKeyDisplayString = "Ctrl -";
      this.mnuEditZoomOut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
      this.mnuEditZoomOut.Size = new System.Drawing.Size(168, 22);
      this.mnuEditZoomOut.Text = "Zoom Out";
      this.mnuEditZoomOut.Click += new System.EventHandler(this.mnuEditZoomOut_Click);
      // 
      // mnuHelp
      // 
      this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpInfo,
            this.mnuHelpLine1,
            this.mnuHelpAbout});
      this.mnuHelp.Name = "mnuHelp";
      this.mnuHelp.Size = new System.Drawing.Size(44, 20);
      this.mnuHelp.Text = "Help";
      // 
      // mnuHelpInfo
      // 
      this.mnuHelpInfo.Image = global::RegexTester.Properties.Resources.info;
      this.mnuHelpInfo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.mnuHelpInfo.Name = "mnuHelpInfo";
      this.mnuHelpInfo.Size = new System.Drawing.Size(107, 22);
      this.mnuHelpInfo.Text = "Info";
      this.mnuHelpInfo.Click += new System.EventHandler(this.mnuHelpInfo_Click);
      // 
      // mnuHelpLine1
      // 
      this.mnuHelpLine1.Name = "mnuHelpLine1";
      this.mnuHelpLine1.Size = new System.Drawing.Size(104, 6);
      // 
      // mnuHelpAbout
      // 
      this.mnuHelpAbout.Image = global::RegexTester.Properties.Resources.help;
      this.mnuHelpAbout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
      this.mnuHelpAbout.Name = "mnuHelpAbout";
      this.mnuHelpAbout.Size = new System.Drawing.Size(107, 22);
      this.mnuHelpAbout.Text = "About";
      this.mnuHelpAbout.Click += new System.EventHandler(this.mnuHelpAbout_Click);
      // 
      // gbWordWrap
      // 
      this.gbWordWrap.Controls.Add(this.chkInputWordWrap);
      this.gbWordWrap.Controls.Add(this.chkResultWordWrap);
      this.gbWordWrap.Location = new System.Drawing.Point(4, 94);
      this.gbWordWrap.Name = "gbWordWrap";
      this.gbWordWrap.Size = new System.Drawing.Size(126, 58);
      this.gbWordWrap.TabIndex = 27;
      this.gbWordWrap.TabStop = false;
      // 
      // chkInputWordWrap
      // 
      this.chkInputWordWrap.AccessibleDescription = "";
      this.chkInputWordWrap.AutoSize = true;
      this.chkInputWordWrap.Checked = true;
      this.chkInputWordWrap.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chkInputWordWrap.Location = new System.Drawing.Point(8, 12);
      this.chkInputWordWrap.Name = "chkInputWordWrap";
      this.chkInputWordWrap.Size = new System.Drawing.Size(105, 17);
      this.chkInputWordWrap.TabIndex = 15;
      this.chkInputWordWrap.Text = "Input WordWrap";
      this.chkInputWordWrap.CheckedChanged += new System.EventHandler(this.chkInputWordWrap_CheckedChanged);
      // 
      // chkResultWordWrap
      // 
      this.chkResultWordWrap.AccessibleDescription = "";
      this.chkResultWordWrap.AutoSize = true;
      this.chkResultWordWrap.Checked = true;
      this.chkResultWordWrap.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chkResultWordWrap.Location = new System.Drawing.Point(8, 35);
      this.chkResultWordWrap.Name = "chkResultWordWrap";
      this.chkResultWordWrap.Size = new System.Drawing.Size(111, 17);
      this.chkResultWordWrap.TabIndex = 16;
      this.chkResultWordWrap.Text = "Result WordWrap";
      this.chkResultWordWrap.CheckedChanged += new System.EventHandler(this.chkResultWordWrap_CheckedChanged);
      // 
      // txtReplace
      // 
      this.txtReplace.AllowMacroRecording = false;
      this.txtReplace.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtReplace.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
      this.txtReplace.AutoIndent = false;
      this.txtReplace.AutoIndentChars = false;
      this.txtReplace.AutoIndentExistingLines = false;
      this.txtReplace.AutoScrollMinSize = new System.Drawing.Size(0, 14);
      this.txtReplace.BackBrush = null;
      this.txtReplace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.txtReplace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtReplace.CharHeight = 14;
      this.txtReplace.CharWidth = 8;
      this.txtReplace.CommentPrefix = "";
      this.txtReplace.Cursor = System.Windows.Forms.Cursors.IBeam;
      this.txtReplace.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.txtReplace.Font = new System.Drawing.Font("Courier New", 9.75F);
      this.txtReplace.Hotkeys = resources.GetString("txtReplace.Hotkeys");
      this.txtReplace.IsReplaceMode = false;
      this.txtReplace.Location = new System.Drawing.Point(136, 71);
      this.txtReplace.Name = "txtReplace";
      this.txtReplace.Paddings = new System.Windows.Forms.Padding(0);
      this.txtReplace.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.txtReplace.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txtReplace.ServiceColors")));
      this.txtReplace.ShowLineNumbers = false;
      this.txtReplace.Size = new System.Drawing.Size(372, 20);
      this.txtReplace.TabIndex = 19;
      this.txtReplace.WordWrap = true;
      this.txtReplace.Zoom = 100;
      this.txtReplace.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.txtReplace_TextChanged);
      // 
      // txtPattern
      // 
      this.txtPattern.AllowMacroRecording = false;
      this.txtPattern.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtPattern.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
      this.txtPattern.AutoIndent = false;
      this.txtPattern.AutoIndentChars = false;
      this.txtPattern.AutoIndentExistingLines = false;
      this.txtPattern.AutoScrollMinSize = new System.Drawing.Size(0, 14);
      this.txtPattern.BackBrush = null;
      this.txtPattern.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.txtPattern.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtPattern.CharHeight = 14;
      this.txtPattern.CharWidth = 8;
      this.txtPattern.Cursor = System.Windows.Forms.Cursors.IBeam;
      this.txtPattern.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.txtPattern.Font = new System.Drawing.Font("Courier New", 9.75F);
      this.txtPattern.Hotkeys = resources.GetString("txtPattern.Hotkeys");
      this.txtPattern.IsReplaceMode = false;
      this.txtPattern.LeftBracket = '(';
      this.txtPattern.LeftBracket2 = '[';
      this.txtPattern.Location = new System.Drawing.Point(136, 29);
      this.txtPattern.Name = "txtPattern";
      this.txtPattern.Paddings = new System.Windows.Forms.Padding(0);
      this.txtPattern.RightBracket = ')';
      this.txtPattern.RightBracket2 = ']';
      this.txtPattern.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.txtPattern.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("txtPattern.ServiceColors")));
      this.txtPattern.ShowLineNumbers = false;
      this.txtPattern.Size = new System.Drawing.Size(667, 34);
      this.txtPattern.TabIndex = 18;
      this.txtPattern.WordWrap = true;
      this.txtPattern.Zoom = 100;
      this.txtPattern.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.txtPattern_TextChanged);
      this.txtPattern.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPattern_KeyUp);
      // 
      // gbOptions
      // 
      this.gbOptions.Controls.Add(this.cbGlobal);
      this.gbOptions.Controls.Add(this.cbRightToLeft);
      this.gbOptions.Controls.Add(this.cbCultureInvariant);
      this.gbOptions.Controls.Add(this.cbIgnoreCase);
      this.gbOptions.Controls.Add(this.cbSingleLine);
      this.gbOptions.Controls.Add(this.cbIgnoreWhiteSpace);
      this.gbOptions.Controls.Add(this.cbMultiline);
      this.gbOptions.Controls.Add(this.cbECMAScript);
      this.gbOptions.Controls.Add(this.cbExplicitCapture);
      this.gbOptions.Controls.Add(this.cbCompiled);
      this.gbOptions.Location = new System.Drawing.Point(136, 94);
      this.gbOptions.Name = "gbOptions";
      this.gbOptions.Size = new System.Drawing.Size(602, 58);
      this.gbOptions.TabIndex = 20;
      this.gbOptions.TabStop = false;
      // 
      // cbGlobal
      // 
      this.cbGlobal.AutoSize = true;
      this.cbGlobal.Location = new System.Drawing.Point(437, 35);
      this.cbGlobal.Name = "cbGlobal";
      this.cbGlobal.Size = new System.Drawing.Size(56, 17);
      this.cbGlobal.TabIndex = 9;
      this.cbGlobal.Text = "Global";
      this.cbGlobal.UseVisualStyleBackColor = true;
      this.cbGlobal.CheckedChanged += new System.EventHandler(this.cb_CheckChanged);
      // 
      // cbRightToLeft
      // 
      this.cbRightToLeft.AutoSize = true;
      this.cbRightToLeft.Location = new System.Drawing.Point(237, 35);
      this.cbRightToLeft.Name = "cbRightToLeft";
      this.cbRightToLeft.Size = new System.Drawing.Size(88, 17);
      this.cbRightToLeft.TabIndex = 5;
      this.cbRightToLeft.Text = "Right To Left";
      this.cbRightToLeft.CheckedChanged += new System.EventHandler(this.cb_CheckChanged);
      // 
      // cbCultureInvariant
      // 
      this.cbCultureInvariant.AutoSize = true;
      this.cbCultureInvariant.Location = new System.Drawing.Point(13, 35);
      this.cbCultureInvariant.Name = "cbCultureInvariant";
      this.cbCultureInvariant.Size = new System.Drawing.Size(103, 17);
      this.cbCultureInvariant.TabIndex = 1;
      this.cbCultureInvariant.Text = "Culture Invariant";
      this.cbCultureInvariant.CheckedChanged += new System.EventHandler(this.cb_CheckChanged);
      // 
      // cbIgnoreCase
      // 
      this.cbIgnoreCase.AccessibleDescription = "";
      this.cbIgnoreCase.AutoSize = true;
      this.cbIgnoreCase.Location = new System.Drawing.Point(13, 12);
      this.cbIgnoreCase.Name = "cbIgnoreCase";
      this.cbIgnoreCase.Size = new System.Drawing.Size(83, 17);
      this.cbIgnoreCase.TabIndex = 0;
      this.cbIgnoreCase.Text = "Ignore Case";
      this.cbIgnoreCase.CheckedChanged += new System.EventHandler(this.cb_CheckChanged);
      // 
      // cbSingleLine
      // 
      this.cbSingleLine.AutoSize = true;
      this.cbSingleLine.Location = new System.Drawing.Point(354, 12);
      this.cbSingleLine.Name = "cbSingleLine";
      this.cbSingleLine.Size = new System.Drawing.Size(71, 17);
      this.cbSingleLine.TabIndex = 6;
      this.cbSingleLine.Text = "Singleline";
      this.cbSingleLine.CheckedChanged += new System.EventHandler(this.cb_CheckChanged);
      // 
      // cbIgnoreWhiteSpace
      // 
      this.cbIgnoreWhiteSpace.AutoSize = true;
      this.cbIgnoreWhiteSpace.Location = new System.Drawing.Point(437, 12);
      this.cbIgnoreWhiteSpace.Name = "cbIgnoreWhiteSpace";
      this.cbIgnoreWhiteSpace.Size = new System.Drawing.Size(153, 17);
      this.cbIgnoreWhiteSpace.TabIndex = 8;
      this.cbIgnoreWhiteSpace.Text = "Ignore Pattern Whitespace";
      this.cbIgnoreWhiteSpace.CheckedChanged += new System.EventHandler(this.cb_CheckChanged);
      // 
      // cbMultiline
      // 
      this.cbMultiline.AutoSize = true;
      this.cbMultiline.Location = new System.Drawing.Point(354, 35);
      this.cbMultiline.Name = "cbMultiline";
      this.cbMultiline.Size = new System.Drawing.Size(64, 17);
      this.cbMultiline.TabIndex = 7;
      this.cbMultiline.Text = "Multiline";
      this.cbMultiline.CheckedChanged += new System.EventHandler(this.cb_CheckChanged);
      // 
      // cbECMAScript
      // 
      this.cbECMAScript.AutoSize = true;
      this.cbECMAScript.Location = new System.Drawing.Point(130, 35);
      this.cbECMAScript.Name = "cbECMAScript";
      this.cbECMAScript.Size = new System.Drawing.Size(86, 17);
      this.cbECMAScript.TabIndex = 3;
      this.cbECMAScript.Text = "ECMA Script";
      this.cbECMAScript.CheckedChanged += new System.EventHandler(this.cb_CheckChanged);
      // 
      // cbExplicitCapture
      // 
      this.cbExplicitCapture.AutoSize = true;
      this.cbExplicitCapture.Location = new System.Drawing.Point(237, 12);
      this.cbExplicitCapture.Name = "cbExplicitCapture";
      this.cbExplicitCapture.Size = new System.Drawing.Size(99, 17);
      this.cbExplicitCapture.TabIndex = 4;
      this.cbExplicitCapture.Text = "Explicit Capture";
      this.cbExplicitCapture.CheckedChanged += new System.EventHandler(this.cb_CheckChanged);
      // 
      // cbCompiled
      // 
      this.cbCompiled.AutoSize = true;
      this.cbCompiled.Location = new System.Drawing.Point(130, 12);
      this.cbCompiled.Name = "cbCompiled";
      this.cbCompiled.Size = new System.Drawing.Size(69, 17);
      this.cbCompiled.TabIndex = 2;
      this.cbCompiled.Text = "Compiled";
      this.cbCompiled.CheckedChanged += new System.EventHandler(this.cb_CheckChanged);
      // 
      // cbMatchImmediately
      // 
      this.cbMatchImmediately.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.cbMatchImmediately.AutoSize = true;
      this.cbMatchImmediately.Location = new System.Drawing.Point(537, 74);
      this.cbMatchImmediately.Name = "cbMatchImmediately";
      this.cbMatchImmediately.Size = new System.Drawing.Size(114, 17);
      this.cbMatchImmediately.TabIndex = 21;
      this.cbMatchImmediately.Text = "Match Immediately";
      this.cbMatchImmediately.UseVisualStyleBackColor = true;
      // 
      // lblReplacement
      // 
      this.lblReplacement.AutoSize = true;
      this.lblReplacement.Location = new System.Drawing.Point(6, 75);
      this.lblReplacement.Name = "lblReplacement";
      this.lblReplacement.Size = new System.Drawing.Size(124, 13);
      this.lblReplacement.TabIndex = 25;
      this.lblReplacement.Text = "Replacement Expression";
      // 
      // lblRegular
      // 
      this.lblRegular.AutoSize = true;
      this.lblRegular.Location = new System.Drawing.Point(6, 29);
      this.lblRegular.Name = "lblRegular";
      this.lblRegular.Size = new System.Drawing.Size(98, 13);
      this.lblRegular.TabIndex = 24;
      this.lblRegular.Text = "Regular Expression";
      // 
      // btnReplace
      // 
      this.btnReplace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnReplace.Enabled = false;
      this.btnReplace.Location = new System.Drawing.Point(731, 69);
      this.btnReplace.Name = "btnReplace";
      this.btnReplace.Size = new System.Drawing.Size(72, 24);
      this.btnReplace.TabIndex = 23;
      this.btnReplace.Text = "Replace";
      this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
      // 
      // btnMatches
      // 
      this.btnMatches.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnMatches.Enabled = false;
      this.btnMatches.Location = new System.Drawing.Point(657, 69);
      this.btnMatches.Name = "btnMatches";
      this.btnMatches.Size = new System.Drawing.Size(72, 24);
      this.btnMatches.TabIndex = 22;
      this.btnMatches.Text = "Matches";
      this.btnMatches.Click += new System.EventHandler(this.btnMatches_Click);
      // 
      // btnStop
      // 
      this.btnStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnStop.Location = new System.Drawing.Point(657, 69);
      this.btnStop.Name = "btnStop";
      this.btnStop.Size = new System.Drawing.Size(72, 24);
      this.btnStop.TabIndex = 26;
      this.btnStop.Text = "Stop";
      this.btnStop.Visible = false;
      this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
      // 
      // tbPanelFull
      // 
      this.tbPanelFull.ColumnCount = 1;
      this.tbPanelFull.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tbPanelFull.Controls.Add(this.grdResult, 0, 1);
      this.tbPanelFull.Controls.Add(this.splitInputResult, 0, 0);
      this.tbPanelFull.Location = new System.Drawing.Point(4, 158);
      this.tbPanelFull.Name = "tbPanelFull";
      this.tbPanelFull.RowCount = 2;
      this.tbPanelFull.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.78F));
      this.tbPanelFull.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.22F));
      this.tbPanelFull.Size = new System.Drawing.Size(799, 326);
      this.tbPanelFull.TabIndex = 28;
      // 
      // grdResult
      // 
      this.grdResult.AllowUserToAddRows = false;
      this.grdResult.AllowUserToDeleteRows = false;
      this.grdResult.AllowUserToResizeRows = false;
      this.grdResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.grdResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
      this.grdResult.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
      this.grdResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.grdResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.grdResult.Location = new System.Drawing.Point(3, 210);
      this.grdResult.MultiSelect = false;
      this.grdResult.Name = "grdResult";
      this.grdResult.ReadOnly = true;
      this.grdResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.grdResult.ShowEditingIcon = false;
      this.grdResult.Size = new System.Drawing.Size(793, 113);
      this.grdResult.TabIndex = 2;
      // 
      // splitInputResult
      // 
      this.splitInputResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.splitInputResult.Location = new System.Drawing.Point(3, 3);
      this.splitInputResult.Name = "splitInputResult";
      // 
      // splitInputResult.Panel1
      // 
      this.splitInputResult.Panel1.Controls.Add(this.tlpInput);
      // 
      // splitInputResult.Panel2
      // 
      this.splitInputResult.Panel2.Controls.Add(this.tlpResult);
      this.splitInputResult.Size = new System.Drawing.Size(793, 201);
      this.splitInputResult.SplitterDistance = 534;
      this.splitInputResult.SplitterWidth = 4;
      this.splitInputResult.TabIndex = 0;
      this.splitInputResult.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitInputResult_SplitterMoved);
      // 
      // tlpInput
      // 
      this.tlpInput.ColumnCount = 1;
      this.tlpInput.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tlpInput.Controls.Add(this.lblInput, 0, 0);
      this.tlpInput.Controls.Add(this.fctbInput, 0, 1);
      this.tlpInput.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tlpInput.Location = new System.Drawing.Point(0, 0);
      this.tlpInput.Name = "tlpInput";
      this.tlpInput.RowCount = 2;
      this.tlpInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
      this.tlpInput.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tlpInput.Size = new System.Drawing.Size(534, 201);
      this.tlpInput.TabIndex = 1;
      // 
      // lblInput
      // 
      this.lblInput.AutoSize = true;
      this.lblInput.Location = new System.Drawing.Point(3, 0);
      this.lblInput.Name = "lblInput";
      this.lblInput.Size = new System.Drawing.Size(55, 13);
      this.lblInput.TabIndex = 10;
      this.lblInput.Text = "Input Text";
      // 
      // fctbInput
      // 
      this.fctbInput.AllowMacroRecording = false;
      this.fctbInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.fctbInput.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
      this.fctbInput.AutoIndent = false;
      this.fctbInput.AutoIndentChars = false;
      this.fctbInput.AutoIndentExistingLines = false;
      this.fctbInput.AutoScrollMinSize = new System.Drawing.Size(0, 14);
      this.fctbInput.BackBrush = null;
      this.fctbInput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.fctbInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.fctbInput.CharHeight = 14;
      this.fctbInput.CharWidth = 8;
      this.fctbInput.Cursor = System.Windows.Forms.Cursors.IBeam;
      this.fctbInput.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.fctbInput.Font = new System.Drawing.Font("Courier New", 9.75F);
      this.fctbInput.Hotkeys = resources.GetString("fctbInput.Hotkeys");
      this.fctbInput.IsReplaceMode = false;
      this.fctbInput.Location = new System.Drawing.Point(3, 16);
      this.fctbInput.Name = "fctbInput";
      this.fctbInput.Paddings = new System.Windows.Forms.Padding(0);
      this.fctbInput.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.fctbInput.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctbInput.ServiceColors")));
      this.fctbInput.Size = new System.Drawing.Size(528, 182);
      this.fctbInput.TabIndex = 0;
      this.fctbInput.WordWrap = true;
      this.fctbInput.Zoom = 100;
      // 
      // tlpResult
      // 
      this.tlpResult.ColumnCount = 1;
      this.tlpResult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tlpResult.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tlpResult.Controls.Add(this.lblResult, 0, 0);
      this.tlpResult.Controls.Add(this.fctbResult, 0, 1);
      this.tlpResult.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tlpResult.Location = new System.Drawing.Point(0, 0);
      this.tlpResult.Name = "tlpResult";
      this.tlpResult.RowCount = 2;
      this.tlpResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 13F));
      this.tlpResult.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tlpResult.Size = new System.Drawing.Size(255, 201);
      this.tlpResult.TabIndex = 1;
      // 
      // lblResult
      // 
      this.lblResult.AutoSize = true;
      this.lblResult.Location = new System.Drawing.Point(3, 0);
      this.lblResult.Name = "lblResult";
      this.lblResult.Size = new System.Drawing.Size(61, 13);
      this.lblResult.TabIndex = 11;
      this.lblResult.Text = "Result Text";
      // 
      // fctbResult
      // 
      this.fctbResult.AllowMacroRecording = false;
      this.fctbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.fctbResult.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
      this.fctbResult.AutoIndent = false;
      this.fctbResult.AutoIndentChars = false;
      this.fctbResult.AutoIndentExistingLines = false;
      this.fctbResult.AutoScrollMinSize = new System.Drawing.Size(0, 14);
      this.fctbResult.BackBrush = null;
      this.fctbResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.fctbResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.fctbResult.CharHeight = 14;
      this.fctbResult.CharWidth = 8;
      this.fctbResult.Cursor = System.Windows.Forms.Cursors.IBeam;
      this.fctbResult.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
      this.fctbResult.Font = new System.Drawing.Font("Courier New", 9.75F);
      this.fctbResult.Hotkeys = resources.GetString("fctbResult.Hotkeys");
      this.fctbResult.IsReplaceMode = false;
      this.fctbResult.Location = new System.Drawing.Point(3, 16);
      this.fctbResult.Name = "fctbResult";
      this.fctbResult.Paddings = new System.Windows.Forms.Padding(0);
      this.fctbResult.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
      this.fctbResult.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctbResult.ServiceColors")));
      this.fctbResult.Size = new System.Drawing.Size(249, 182);
      this.fctbResult.TabIndex = 1;
      this.fctbResult.WordWrap = true;
      this.fctbResult.Zoom = 100;
      // 
      // frmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(812, 509);
      this.Controls.Add(this.tbPanelFull);
      this.Controls.Add(this.gbWordWrap);
      this.Controls.Add(this.txtReplace);
      this.Controls.Add(this.txtPattern);
      this.Controls.Add(this.gbOptions);
      this.Controls.Add(this.cbMatchImmediately);
      this.Controls.Add(this.lblReplacement);
      this.Controls.Add(this.lblRegular);
      this.Controls.Add(this.btnReplace);
      this.Controls.Add(this.btnMatches);
      this.Controls.Add(this.btnStop);
      this.Controls.Add(this.StatusStrip);
      this.Controls.Add(this.MenuStrip);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "frmMain";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Regex Tester";
      this.Load += new System.EventHandler(this.frmMain_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMain_KeyDown);
      this.StatusStrip.ResumeLayout(false);
      this.StatusStrip.PerformLayout();
      this.MenuStrip.ResumeLayout(false);
      this.MenuStrip.PerformLayout();
      this.gbWordWrap.ResumeLayout(false);
      this.gbWordWrap.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txtReplace)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtPattern)).EndInit();
      this.gbOptions.ResumeLayout(false);
      this.gbOptions.PerformLayout();
      this.tbPanelFull.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.grdResult)).EndInit();
      this.splitInputResult.Panel1.ResumeLayout(false);
      this.splitInputResult.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.splitInputResult)).EndInit();
      this.splitInputResult.ResumeLayout(false);
      this.tlpInput.ResumeLayout(false);
      this.tlpInput.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.fctbInput)).EndInit();
      this.tlpResult.ResumeLayout(false);
      this.tlpResult.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.fctbResult)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    internal System.Windows.Forms.StatusStrip StatusStrip;
    internal System.Windows.Forms.ToolStripStatusLabel sbStatus;
    internal System.Windows.Forms.ToolStripStatusLabel sbMatches;
    internal System.Windows.Forms.ToolStripStatusLabel sbTime;
    internal System.Windows.Forms.MenuStrip MenuStrip;
    internal System.Windows.Forms.ToolStripMenuItem mnuFile;
    internal System.Windows.Forms.ToolStripMenuItem mnuFileOpenTestFile;
    internal System.Windows.Forms.ToolStripMenuItem mnuFileSaveResultsAs;
    internal System.Windows.Forms.ToolStripSeparator mnuFileLine1;
    internal System.Windows.Forms.ToolStripMenuItem mnuFileExit;
    internal System.Windows.Forms.ToolStripMenuItem mnuEdit;
    internal System.Windows.Forms.ToolStripMenuItem mnuEditCopyWholeRegExAsC;
    internal System.Windows.Forms.ToolStripMenuItem mnuEditCopyWholeRegExAsVB;
    internal System.Windows.Forms.ToolStripSeparator mnuEditLine1;
    internal System.Windows.Forms.ToolStripMenuItem mnuEditZoomIn;
    internal System.Windows.Forms.ToolStripMenuItem mnuEditZoomOut;
    internal System.Windows.Forms.ToolStripMenuItem mnuHelp;
    internal System.Windows.Forms.ToolStripMenuItem mnuHelpInfo;
    internal System.Windows.Forms.ToolStripSeparator mnuHelpLine1;
    internal System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
    private System.Windows.Forms.ToolTip optionToolTip;
    internal System.Windows.Forms.GroupBox gbWordWrap;
    private System.Windows.Forms.CheckBox chkInputWordWrap;
    private System.Windows.Forms.CheckBox chkResultWordWrap;
    internal FastColoredTextBoxNS.FastColoredTextBox txtReplace;
    internal FastColoredTextBoxNS.FastColoredTextBox txtPattern;
    internal System.Windows.Forms.GroupBox gbOptions;
    internal System.Windows.Forms.CheckBox cbGlobal;
    private System.Windows.Forms.CheckBox cbRightToLeft;
    private System.Windows.Forms.CheckBox cbCultureInvariant;
    private System.Windows.Forms.CheckBox cbIgnoreCase;
    private System.Windows.Forms.CheckBox cbSingleLine;
    private System.Windows.Forms.CheckBox cbIgnoreWhiteSpace;
    private System.Windows.Forms.CheckBox cbMultiline;
    private System.Windows.Forms.CheckBox cbECMAScript;
    private System.Windows.Forms.CheckBox cbExplicitCapture;
    private System.Windows.Forms.CheckBox cbCompiled;
    internal System.Windows.Forms.CheckBox cbMatchImmediately;
    internal System.Windows.Forms.Label lblReplacement;
    internal System.Windows.Forms.Label lblRegular;
    private System.Windows.Forms.Button btnReplace;
    private System.Windows.Forms.Button btnMatches;
    private System.Windows.Forms.Button btnStop;
    private System.Windows.Forms.TableLayoutPanel tbPanelFull;
    private SplitContainerEx splitInputResult;
    internal System.Windows.Forms.TableLayoutPanel tlpInput;
    internal System.Windows.Forms.Label lblInput;
    internal FastColoredTextBoxNS.FastColoredTextBox fctbInput;
    internal System.Windows.Forms.TableLayoutPanel tlpResult;
    internal System.Windows.Forms.Label lblResult;
    internal FastColoredTextBoxNS.FastColoredTextBox fctbResult;
    private System.Windows.Forms.DataGridView grdResult;
  }
}

