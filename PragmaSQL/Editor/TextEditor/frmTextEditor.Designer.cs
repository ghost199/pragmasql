namespace PragmaSQL
{
  partial class frmTextEditor
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTextEditor));
      this.popUpTab = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.cMnuItemClose = new System.Windows.Forms.ToolStripMenuItem();
      this.cMnuCloseAll = new System.Windows.Forms.ToolStripMenuItem();
      this.cMnuCloseAllButThis = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripSeparator();
      this.switchToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
      this.cMnuItemSave = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripSeparator();
      this.cMnuNewScript = new System.Windows.Forms.ToolStripMenuItem();
      this.cMnuScriptFromFile = new System.Windows.Forms.ToolStripMenuItem();
      this.mainMenu = new System.Windows.Forms.MenuStrip();
      this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuItemOpen = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
      this.mnuItemSave = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuItemSaveAs = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuEdit = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuItemUndo = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuItemRedo = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
      this.mnuItemCut = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuItemPaste = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
      this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuItemSearchForward = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuItemSearchBackward = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
      this.mnuItemFind = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuItemReplace = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
      this.mnuItemIncSearch = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuItemRevIncSearch = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuItemGoToLine = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
      this.formatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuItemKeywordsToUppercase = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuItemKeywordsToLowercase = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuItemCapitilizeKeywords = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
      this.mnuItemScriptToUppercase = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuItemScriptToLowercase = new System.Windows.Forms.ToolStripMenuItem();
      this.popUpEditor = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.tsMnuItemUndo = new System.Windows.Forms.ToolStripMenuItem();
      this.tsMnuItemRedo = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
      this.tsMnuItemCut = new System.Windows.Forms.ToolStripMenuItem();
      this.tsMnuItemCopy = new System.Windows.Forms.ToolStripMenuItem();
      this.tsMnuItemPaste = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripSeparator();
      this.switchToScriptEditorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripSeparator();
      this.textDiffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.cMnuTextDiffAsSource = new System.Windows.Forms.ToolStripMenuItem();
      this.cMnuTextDiffAsDest = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripSeparator();
      this.findOnWebToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.statCaretPos = new System.Windows.Forms.ToolStripStatusLabel();
      this.statIncSearch = new System.Windows.Forms.ToolStripStatusLabel();
      this.statLblContentModifiedIndicator = new System.Windows.Forms.ToolStripStatusLabel();
      this.statLblContentInfo = new System.Windows.Forms.ToolStripStatusLabel();
      this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
      this.strip3 = new System.Windows.Forms.ToolStrip();
      this.btnNewScript = new System.Windows.Forms.ToolStripButton();
      this.btnSwitchToScriptEditor = new System.Windows.Forms.ToolStripButton();
      this.btnOpen = new System.Windows.Forms.ToolStripButton();
      this.btnSave = new System.Windows.Forms.ToolStripButton();
      this.btnSaveAs = new System.Windows.Forms.ToolStripButton();
      this.mnuItemSharedScriptOperations = new System.Windows.Forms.ToolStripDropDownButton();
      this.openSharedScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveAsSharedScriptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
      this.edtMatchText = new System.Windows.Forms.ToolStripTextBox();
      this.btnFindNext = new System.Windows.Forms.ToolStripButton();
      this.btnFindPrev = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.btnOutDent = new System.Windows.Forms.ToolStripButton();
      this.btnIndent = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
      this.btnToggleBlockComment = new System.Windows.Forms.ToolStripButton();
      this.btnToggleLineComment = new System.Windows.Forms.ToolStripButton();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.btnKeywordsToUppercase = new System.Windows.Forms.ToolStripButton();
      this.btnKeywordsToLowercase = new System.Windows.Forms.ToolStripButton();
      this.btnCapitalizeKeywords = new System.Windows.Forms.ToolStripButton();
      this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
      this.asSourceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.asDestToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
      this.cmbSyntaxModes = new System.Windows.Forms.ToolStripComboBox();
      this.panEditor.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.fsWatcher)).BeginInit();
      this.popUpTab.SuspendLayout();
      this.mainMenu.SuspendLayout();
      this.popUpEditor.SuspendLayout();
      this.statusStrip1.SuspendLayout();
      this.strip3.SuspendLayout();
      this.SuspendLayout();
      // 
      // _textEditor
      // 
      this._textEditor.Location = new System.Drawing.Point(0, 55);
      this._textEditor.Size = new System.Drawing.Size(877, 348);
      // 
      // panEditor
      // 
      this.panEditor.Location = new System.Drawing.Point(0, 25);
      this.panEditor.Size = new System.Drawing.Size(877, 403);
      // 
      // popUpTab
      // 
      this.popUpTab.Font = new System.Drawing.Font("Segoe UI", 8.25F);
      this.popUpTab.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cMnuItemClose,
            this.cMnuCloseAll,
            this.cMnuCloseAllButThis,
            this.toolStripMenuItem13,
            this.switchToToolStripMenuItem,
            this.toolStripMenuItem1,
            this.cMnuItemSave,
            this.toolStripMenuItem11,
            this.cMnuNewScript,
            this.cMnuScriptFromFile});
      this.popUpTab.Name = "contextMenuTab";
      this.popUpTab.Size = new System.Drawing.Size(198, 176);
      // 
      // cMnuItemClose
      // 
      this.cMnuItemClose.Name = "cMnuItemClose";
      this.cMnuItemClose.Size = new System.Drawing.Size(197, 22);
      this.cMnuItemClose.Text = "Close";
      // 
      // cMnuCloseAll
      // 
      this.cMnuCloseAll.Name = "cMnuCloseAll";
      this.cMnuCloseAll.Size = new System.Drawing.Size(197, 22);
      this.cMnuCloseAll.Text = "Close All";
      // 
      // cMnuCloseAllButThis
      // 
      this.cMnuCloseAllButThis.Name = "cMnuCloseAllButThis";
      this.cMnuCloseAllButThis.Size = new System.Drawing.Size(197, 22);
      this.cMnuCloseAllButThis.Text = "Close All But This";
      // 
      // toolStripMenuItem13
      // 
      this.toolStripMenuItem13.Name = "toolStripMenuItem13";
      this.toolStripMenuItem13.Size = new System.Drawing.Size(194, 6);
      // 
      // switchToToolStripMenuItem
      // 
      this.switchToToolStripMenuItem.Image = global::PragmaSQL.Properties.Resources.db_edit;
      this.switchToToolStripMenuItem.Name = "switchToToolStripMenuItem";
      this.switchToToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
      this.switchToToolStripMenuItem.Text = "Switch To Script Editor";
      // 
      // toolStripMenuItem1
      // 
      this.toolStripMenuItem1.Name = "toolStripMenuItem1";
      this.toolStripMenuItem1.Size = new System.Drawing.Size(194, 6);
      // 
      // cMnuItemSave
      // 
      this.cMnuItemSave.Image = global::PragmaSQL.Properties.Resources.save;
      this.cMnuItemSave.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.cMnuItemSave.Name = "cMnuItemSave";
      this.cMnuItemSave.Size = new System.Drawing.Size(197, 22);
      this.cMnuItemSave.Text = "Save Script";
      // 
      // toolStripMenuItem11
      // 
      this.toolStripMenuItem11.Name = "toolStripMenuItem11";
      this.toolStripMenuItem11.Size = new System.Drawing.Size(194, 6);
      // 
      // cMnuNewScript
      // 
      this.cMnuNewScript.Image = global::PragmaSQL.Properties.Resources.new1;
      this.cMnuNewScript.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.cMnuNewScript.Name = "cMnuNewScript";
      this.cMnuNewScript.Size = new System.Drawing.Size(197, 22);
      this.cMnuNewScript.Text = "New Text Editor";
      // 
      // cMnuScriptFromFile
      // 
      this.cMnuScriptFromFile.Image = global::PragmaSQL.Properties.Resources.folder_page_white;
      this.cMnuScriptFromFile.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.cMnuScriptFromFile.Name = "cMnuScriptFromFile";
      this.cMnuScriptFromFile.Size = new System.Drawing.Size(197, 22);
      this.cMnuScriptFromFile.Text = "Open File In New Editor";
      // 
      // mainMenu
      // 
      this.mainMenu.Font = new System.Drawing.Font("Segoe UI", 8.25F);
      this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuEdit});
      this.mainMenu.Location = new System.Drawing.Point(0, 0);
      this.mainMenu.Name = "mainMenu";
      this.mainMenu.Size = new System.Drawing.Size(877, 24);
      this.mainMenu.TabIndex = 4;
      this.mainMenu.Visible = false;
      // 
      // mnuFile
      // 
      this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemOpen,
            this.toolStripMenuItem4,
            this.mnuItemSave,
            this.mnuItemSaveAs});
      this.mnuFile.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
      this.mnuFile.MergeIndex = 0;
      this.mnuFile.Name = "mnuFile";
      this.mnuFile.Size = new System.Drawing.Size(37, 20);
      this.mnuFile.Text = "File";
      // 
      // mnuItemOpen
      // 
      this.mnuItemOpen.Name = "mnuItemOpen";
      this.mnuItemOpen.Size = new System.Drawing.Size(183, 22);
      this.mnuItemOpen.Text = "Open";
      // 
      // toolStripMenuItem4
      // 
      this.toolStripMenuItem4.Name = "toolStripMenuItem4";
      this.toolStripMenuItem4.Size = new System.Drawing.Size(180, 6);
      // 
      // mnuItemSave
      // 
      this.mnuItemSave.Name = "mnuItemSave";
      this.mnuItemSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
      this.mnuItemSave.Size = new System.Drawing.Size(183, 22);
      this.mnuItemSave.Text = "Save";
      // 
      // mnuItemSaveAs
      // 
      this.mnuItemSaveAs.Name = "mnuItemSaveAs";
      this.mnuItemSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
      this.mnuItemSaveAs.Size = new System.Drawing.Size(183, 22);
      this.mnuItemSaveAs.Text = "Save As";
      // 
      // mnuEdit
      // 
      this.mnuEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemUndo,
            this.mnuItemRedo,
            this.toolStripMenuItem5,
            this.mnuItemCut,
            this.mnuItemCopy,
            this.mnuItemPaste,
            this.toolStripMenuItem6,
            this.searchToolStripMenuItem,
            this.mnuItemGoToLine,
            this.toolStripMenuItem8,
            this.formatToolStripMenuItem});
      this.mnuEdit.MergeAction = System.Windows.Forms.MergeAction.MatchOnly;
      this.mnuEdit.MergeIndex = 1;
      this.mnuEdit.Name = "mnuEdit";
      this.mnuEdit.Size = new System.Drawing.Size(39, 20);
      this.mnuEdit.Text = "Edit";
      // 
      // mnuItemUndo
      // 
      this.mnuItemUndo.Image = global::PragmaSQL.Properties.Resources.undo;
      this.mnuItemUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.mnuItemUndo.Name = "mnuItemUndo";
      this.mnuItemUndo.Size = new System.Drawing.Size(164, 22);
      this.mnuItemUndo.Text = "Undo";
      // 
      // mnuItemRedo
      // 
      this.mnuItemRedo.Image = global::PragmaSQL.Properties.Resources.redo;
      this.mnuItemRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.mnuItemRedo.Name = "mnuItemRedo";
      this.mnuItemRedo.Size = new System.Drawing.Size(164, 22);
      this.mnuItemRedo.Text = "Redo";
      // 
      // toolStripMenuItem5
      // 
      this.toolStripMenuItem5.Name = "toolStripMenuItem5";
      this.toolStripMenuItem5.Size = new System.Drawing.Size(161, 6);
      // 
      // mnuItemCut
      // 
      this.mnuItemCut.Image = global::PragmaSQL.Properties.Resources.cut_2;
      this.mnuItemCut.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.mnuItemCut.Name = "mnuItemCut";
      this.mnuItemCut.Size = new System.Drawing.Size(164, 22);
      this.mnuItemCut.Text = "Cut";
      // 
      // mnuItemCopy
      // 
      this.mnuItemCopy.Image = global::PragmaSQL.Properties.Resources.copy;
      this.mnuItemCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.mnuItemCopy.Name = "mnuItemCopy";
      this.mnuItemCopy.Size = new System.Drawing.Size(164, 22);
      this.mnuItemCopy.Text = "Copy";
      // 
      // mnuItemPaste
      // 
      this.mnuItemPaste.Image = global::PragmaSQL.Properties.Resources.paste;
      this.mnuItemPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.mnuItemPaste.Name = "mnuItemPaste";
      this.mnuItemPaste.Size = new System.Drawing.Size(164, 22);
      this.mnuItemPaste.Text = "Paste";
      // 
      // toolStripMenuItem6
      // 
      this.toolStripMenuItem6.Name = "toolStripMenuItem6";
      this.toolStripMenuItem6.Size = new System.Drawing.Size(161, 6);
      // 
      // searchToolStripMenuItem
      // 
      this.searchToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemSearchForward,
            this.mnuItemSearchBackward,
            this.toolStripMenuItem7,
            this.mnuItemFind,
            this.mnuItemReplace,
            this.toolStripMenuItem3,
            this.mnuItemIncSearch,
            this.mnuItemRevIncSearch});
      this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
      this.searchToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.searchToolStripMenuItem.Text = "Find And Replace";
      // 
      // mnuItemSearchForward
      // 
      this.mnuItemSearchForward.Name = "mnuItemSearchForward";
      this.mnuItemSearchForward.Size = new System.Drawing.Size(213, 22);
      this.mnuItemSearchForward.Text = "Search Forward";
      // 
      // mnuItemSearchBackward
      // 
      this.mnuItemSearchBackward.Name = "mnuItemSearchBackward";
      this.mnuItemSearchBackward.Size = new System.Drawing.Size(213, 22);
      this.mnuItemSearchBackward.Text = "Serach Backward";
      // 
      // toolStripMenuItem7
      // 
      this.toolStripMenuItem7.Name = "toolStripMenuItem7";
      this.toolStripMenuItem7.Size = new System.Drawing.Size(210, 6);
      // 
      // mnuItemFind
      // 
      this.mnuItemFind.Name = "mnuItemFind";
      this.mnuItemFind.Size = new System.Drawing.Size(213, 22);
      this.mnuItemFind.Text = "Find";
      // 
      // mnuItemReplace
      // 
      this.mnuItemReplace.Name = "mnuItemReplace";
      this.mnuItemReplace.Size = new System.Drawing.Size(213, 22);
      this.mnuItemReplace.Text = "Replace";
      // 
      // toolStripMenuItem3
      // 
      this.toolStripMenuItem3.Name = "toolStripMenuItem3";
      this.toolStripMenuItem3.Size = new System.Drawing.Size(210, 6);
      // 
      // mnuItemIncSearch
      // 
      this.mnuItemIncSearch.Name = "mnuItemIncSearch";
      this.mnuItemIncSearch.Size = new System.Drawing.Size(213, 22);
      this.mnuItemIncSearch.Text = "Incremental Search";
      // 
      // mnuItemRevIncSearch
      // 
      this.mnuItemRevIncSearch.Name = "mnuItemRevIncSearch";
      this.mnuItemRevIncSearch.Size = new System.Drawing.Size(213, 22);
      this.mnuItemRevIncSearch.Text = "Reverse Incremental Search";
      // 
      // mnuItemGoToLine
      // 
      this.mnuItemGoToLine.Name = "mnuItemGoToLine";
      this.mnuItemGoToLine.Size = new System.Drawing.Size(164, 22);
      this.mnuItemGoToLine.Text = "Go To Line";
      // 
      // toolStripMenuItem8
      // 
      this.toolStripMenuItem8.Name = "toolStripMenuItem8";
      this.toolStripMenuItem8.Size = new System.Drawing.Size(161, 6);
      // 
      // formatToolStripMenuItem
      // 
      this.formatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemKeywordsToUppercase,
            this.mnuItemKeywordsToLowercase,
            this.mnuItemCapitilizeKeywords,
            this.toolStripMenuItem2,
            this.mnuItemScriptToUppercase,
            this.mnuItemScriptToLowercase});
      this.formatToolStripMenuItem.Name = "formatToolStripMenuItem";
      this.formatToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
      this.formatToolStripMenuItem.Text = "Format";
      // 
      // mnuItemKeywordsToUppercase
      // 
      this.mnuItemKeywordsToUppercase.Name = "mnuItemKeywordsToUppercase";
      this.mnuItemKeywordsToUppercase.Size = new System.Drawing.Size(195, 22);
      this.mnuItemKeywordsToUppercase.Text = "Keywords To Uppercase";
      // 
      // mnuItemKeywordsToLowercase
      // 
      this.mnuItemKeywordsToLowercase.Name = "mnuItemKeywordsToLowercase";
      this.mnuItemKeywordsToLowercase.Size = new System.Drawing.Size(195, 22);
      this.mnuItemKeywordsToLowercase.Text = "Keywords To Lowercase";
      // 
      // mnuItemCapitilizeKeywords
      // 
      this.mnuItemCapitilizeKeywords.Name = "mnuItemCapitilizeKeywords";
      this.mnuItemCapitilizeKeywords.Size = new System.Drawing.Size(195, 22);
      this.mnuItemCapitilizeKeywords.Text = "Captialize Keywords";
      // 
      // toolStripMenuItem2
      // 
      this.toolStripMenuItem2.Name = "toolStripMenuItem2";
      this.toolStripMenuItem2.Size = new System.Drawing.Size(192, 6);
      // 
      // mnuItemScriptToUppercase
      // 
      this.mnuItemScriptToUppercase.Name = "mnuItemScriptToUppercase";
      this.mnuItemScriptToUppercase.Size = new System.Drawing.Size(195, 22);
      this.mnuItemScriptToUppercase.Text = "Script To Uppercase";
      // 
      // mnuItemScriptToLowercase
      // 
      this.mnuItemScriptToLowercase.Name = "mnuItemScriptToLowercase";
      this.mnuItemScriptToLowercase.Size = new System.Drawing.Size(195, 22);
      this.mnuItemScriptToLowercase.Text = "Script To Lowercase";
      // 
      // popUpEditor
      // 
      this.popUpEditor.Font = new System.Drawing.Font("Segoe UI", 8.25F);
      this.popUpEditor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsMnuItemUndo,
            this.tsMnuItemRedo,
            this.toolStripMenuItem9,
            this.tsMnuItemCut,
            this.tsMnuItemCopy,
            this.tsMnuItemPaste,
            this.toolStripMenuItem14,
            this.switchToScriptEditorToolStripMenuItem,
            this.toolStripMenuItem12,
            this.textDiffToolStripMenuItem,
            this.toolStripMenuItem10,
            this.findOnWebToolStripMenuItem});
      this.popUpEditor.Name = "contextMenuEditor";
      this.popUpEditor.Size = new System.Drawing.Size(190, 204);
      // 
      // tsMnuItemUndo
      // 
      this.tsMnuItemUndo.Name = "tsMnuItemUndo";
      this.tsMnuItemUndo.Size = new System.Drawing.Size(189, 22);
      this.tsMnuItemUndo.Text = "Undo";
      // 
      // tsMnuItemRedo
      // 
      this.tsMnuItemRedo.Name = "tsMnuItemRedo";
      this.tsMnuItemRedo.Size = new System.Drawing.Size(189, 22);
      this.tsMnuItemRedo.Text = "Redo";
      // 
      // toolStripMenuItem9
      // 
      this.toolStripMenuItem9.Name = "toolStripMenuItem9";
      this.toolStripMenuItem9.Size = new System.Drawing.Size(186, 6);
      // 
      // tsMnuItemCut
      // 
      this.tsMnuItemCut.Image = global::PragmaSQL.Properties.Resources.cut_2;
      this.tsMnuItemCut.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsMnuItemCut.Name = "tsMnuItemCut";
      this.tsMnuItemCut.Size = new System.Drawing.Size(189, 22);
      this.tsMnuItemCut.Text = "Cut";
      // 
      // tsMnuItemCopy
      // 
      this.tsMnuItemCopy.Image = global::PragmaSQL.Properties.Resources.copy;
      this.tsMnuItemCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsMnuItemCopy.Name = "tsMnuItemCopy";
      this.tsMnuItemCopy.ShortcutKeyDisplayString = "";
      this.tsMnuItemCopy.Size = new System.Drawing.Size(189, 22);
      this.tsMnuItemCopy.Text = "Copy";
      // 
      // tsMnuItemPaste
      // 
      this.tsMnuItemPaste.Image = global::PragmaSQL.Properties.Resources.paste;
      this.tsMnuItemPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.tsMnuItemPaste.Name = "tsMnuItemPaste";
      this.tsMnuItemPaste.ShortcutKeyDisplayString = "";
      this.tsMnuItemPaste.Size = new System.Drawing.Size(189, 22);
      this.tsMnuItemPaste.Text = "Paste";
      // 
      // toolStripMenuItem14
      // 
      this.toolStripMenuItem14.Name = "toolStripMenuItem14";
      this.toolStripMenuItem14.Size = new System.Drawing.Size(186, 6);
      // 
      // switchToScriptEditorToolStripMenuItem
      // 
      this.switchToScriptEditorToolStripMenuItem.Image = global::PragmaSQL.Properties.Resources.db_edit;
      this.switchToScriptEditorToolStripMenuItem.Name = "switchToScriptEditorToolStripMenuItem";
      this.switchToScriptEditorToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
      this.switchToScriptEditorToolStripMenuItem.Text = "Switch To Script Editor";
      // 
      // toolStripMenuItem12
      // 
      this.toolStripMenuItem12.Name = "toolStripMenuItem12";
      this.toolStripMenuItem12.Size = new System.Drawing.Size(186, 6);
      // 
      // textDiffToolStripMenuItem
      // 
      this.textDiffToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cMnuTextDiffAsSource,
            this.cMnuTextDiffAsDest});
      this.textDiffToolStripMenuItem.Name = "textDiffToolStripMenuItem";
      this.textDiffToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
      this.textDiffToolStripMenuItem.Text = "Diff";
      // 
      // cMnuTextDiffAsSource
      // 
      this.cMnuTextDiffAsSource.Name = "cMnuTextDiffAsSource";
      this.cMnuTextDiffAsSource.Size = new System.Drawing.Size(124, 22);
      this.cMnuTextDiffAsSource.Text = "As Source";
      this.cMnuTextDiffAsSource.Click += new System.EventHandler(this.OnDiffScriptAsSource_Click);
      // 
      // cMnuTextDiffAsDest
      // 
      this.cMnuTextDiffAsDest.Name = "cMnuTextDiffAsDest";
      this.cMnuTextDiffAsDest.Size = new System.Drawing.Size(124, 22);
      this.cMnuTextDiffAsDest.Text = "As Dest";
      this.cMnuTextDiffAsDest.Click += new System.EventHandler(this.OnDiffScriptAsDest_Click);
      // 
      // toolStripMenuItem10
      // 
      this.toolStripMenuItem10.Name = "toolStripMenuItem10";
      this.toolStripMenuItem10.Size = new System.Drawing.Size(186, 6);
      // 
      // findOnWebToolStripMenuItem
      // 
      this.findOnWebToolStripMenuItem.Name = "findOnWebToolStripMenuItem";
      this.findOnWebToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
      this.findOnWebToolStripMenuItem.Text = "Find In Web";
      this.findOnWebToolStripMenuItem.Click += new System.EventHandler(this.findOnWebToolStripMenuItem_Click);
      // 
      // openFileDialog1
      // 
      this.openFileDialog1.DefaultExt = "sql";
      this.openFileDialog1.FileName = "openFileDialog1";
      this.openFileDialog1.Filter = "SQL Files|*.sql|Query Files|*.qry|All Files|*.*";
      // 
      // statusStrip1
      // 
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statCaretPos,
            this.statIncSearch,
            this.statLblContentModifiedIndicator,
            this.statLblContentInfo});
      this.statusStrip1.Location = new System.Drawing.Point(0, 428);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(877, 22);
      this.statusStrip1.TabIndex = 6;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // statCaretPos
      // 
      this.statCaretPos.Name = "statCaretPos";
      this.statCaretPos.Size = new System.Drawing.Size(35, 17);
      this.statCaretPos.Text = "Caret";
      this.statCaretPos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // statIncSearch
      // 
      this.statIncSearch.BackColor = System.Drawing.SystemColors.Highlight;
      this.statIncSearch.ForeColor = System.Drawing.SystemColors.HighlightText;
      this.statIncSearch.Name = "statIncSearch";
      this.statIncSearch.Size = new System.Drawing.Size(0, 17);
      // 
      // statLblContentModifiedIndicator
      // 
      this.statLblContentModifiedIndicator.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.statLblContentModifiedIndicator.Image = global::PragmaSQL.Properties.Resources.edit;
      this.statLblContentModifiedIndicator.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.statLblContentModifiedIndicator.Name = "statLblContentModifiedIndicator";
      this.statLblContentModifiedIndicator.Size = new System.Drawing.Size(16, 17);
      this.statLblContentModifiedIndicator.Text = "toolStripStatusLabel1";
      this.statLblContentModifiedIndicator.Visible = false;
      // 
      // statLblContentInfo
      // 
      this.statLblContentInfo.Name = "statLblContentInfo";
      this.statLblContentInfo.Size = new System.Drawing.Size(827, 17);
      this.statLblContentInfo.Spring = true;
      this.statLblContentInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // saveFileDialog1
      // 
      this.saveFileDialog1.DefaultExt = "sql";
      this.saveFileDialog1.Filter = "SQL Files|*.sql|Query Files|*.qry|All Files|*.*";
      // 
      // strip3
      // 
      this.strip3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
      this.strip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
      this.strip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNewScript,
            this.btnSwitchToScriptEditor,
            this.btnOpen,
            this.btnSave,
            this.btnSaveAs,
            this.mnuItemSharedScriptOperations,
            this.toolStripSeparator3,
            this.toolStripLabel3,
            this.edtMatchText,
            this.btnFindNext,
            this.btnFindPrev,
            this.toolStripSeparator4,
            this.btnOutDent,
            this.btnIndent,
            this.toolStripSeparator5,
            this.btnToggleBlockComment,
            this.btnToggleLineComment,
            this.toolStripSeparator2,
            this.btnKeywordsToUppercase,
            this.btnKeywordsToLowercase,
            this.btnCapitalizeKeywords,
            this.toolStripDropDownButton1,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.cmbSyntaxModes});
      this.strip3.Location = new System.Drawing.Point(0, 0);
      this.strip3.Name = "strip3";
      this.strip3.Size = new System.Drawing.Size(877, 25);
      this.strip3.TabIndex = 9;
      this.strip3.Text = "toolStrip2";
      // 
      // btnNewScript
      // 
      this.btnNewScript.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnNewScript.Image = global::PragmaSQL.Properties.Resources.new_style_2;
      this.btnNewScript.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnNewScript.Name = "btnNewScript";
      this.btnNewScript.Size = new System.Drawing.Size(23, 22);
      this.btnNewScript.Text = "New Script";
      this.btnNewScript.Click += new System.EventHandler(this.btnNewScript_Click);
      // 
      // btnSwitchToScriptEditor
      // 
      this.btnSwitchToScriptEditor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnSwitchToScriptEditor.Image = global::PragmaSQL.Properties.Resources.db_edit;
      this.btnSwitchToScriptEditor.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnSwitchToScriptEditor.Name = "btnSwitchToScriptEditor";
      this.btnSwitchToScriptEditor.Size = new System.Drawing.Size(23, 22);
      this.btnSwitchToScriptEditor.Text = "Switch To Script Editor";
      // 
      // btnOpen
      // 
      this.btnOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnOpen.Image = global::PragmaSQL.Properties.Resources.open;
      this.btnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnOpen.Name = "btnOpen";
      this.btnOpen.Size = new System.Drawing.Size(23, 22);
      this.btnOpen.Text = "Open";
      // 
      // btnSave
      // 
      this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnSave.Image = global::PragmaSQL.Properties.Resources.save;
      this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(23, 22);
      this.btnSave.Text = "Save";
      // 
      // btnSaveAs
      // 
      this.btnSaveAs.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnSaveAs.Image = global::PragmaSQL.Properties.Resources.SaveAs;
      this.btnSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnSaveAs.Name = "btnSaveAs";
      this.btnSaveAs.Size = new System.Drawing.Size(23, 22);
      this.btnSaveAs.Text = "Save As";
      // 
      // mnuItemSharedScriptOperations
      // 
      this.mnuItemSharedScriptOperations.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.mnuItemSharedScriptOperations.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openSharedScriptToolStripMenuItem,
            this.saveAsSharedScriptToolStripMenuItem});
      this.mnuItemSharedScriptOperations.Image = global::PragmaSQL.Properties.Resources.generic;
      this.mnuItemSharedScriptOperations.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.mnuItemSharedScriptOperations.Name = "mnuItemSharedScriptOperations";
      this.mnuItemSharedScriptOperations.Size = new System.Drawing.Size(29, 22);
      this.mnuItemSharedScriptOperations.Text = "toolStripDropDownButton1";
      // 
      // openSharedScriptToolStripMenuItem
      // 
      this.openSharedScriptToolStripMenuItem.Name = "openSharedScriptToolStripMenuItem";
      this.openSharedScriptToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
      this.openSharedScriptToolStripMenuItem.Text = "Open Shared Script";
      this.openSharedScriptToolStripMenuItem.Click += new System.EventHandler(this.openSharedScriptToolStripMenuItem_Click);
      // 
      // saveAsSharedScriptToolStripMenuItem
      // 
      this.saveAsSharedScriptToolStripMenuItem.Name = "saveAsSharedScriptToolStripMenuItem";
      this.saveAsSharedScriptToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
      this.saveAsSharedScriptToolStripMenuItem.Text = "Save As Shared Script";
      this.saveAsSharedScriptToolStripMenuItem.Click += new System.EventHandler(this.saveAsSharedScriptToolStripMenuItem_Click);
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
      // 
      // toolStripLabel3
      // 
      this.toolStripLabel3.Name = "toolStripLabel3";
      this.toolStripLabel3.Size = new System.Drawing.Size(64, 22);
      this.toolStripLabel3.Text = "Quick Find";
      // 
      // edtMatchText
      // 
      this.edtMatchText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.edtMatchText.ForeColor = System.Drawing.Color.Navy;
      this.edtMatchText.HideSelection = false;
      this.edtMatchText.Name = "edtMatchText";
      this.edtMatchText.Size = new System.Drawing.Size(150, 25);
      this.edtMatchText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.edtMatchText_KeyDown_1);
      // 
      // btnFindNext
      // 
      this.btnFindNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnFindNext.Image = global::PragmaSQL.Properties.Resources.down;
      this.btnFindNext.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnFindNext.Name = "btnFindNext";
      this.btnFindNext.Size = new System.Drawing.Size(23, 22);
      // 
      // btnFindPrev
      // 
      this.btnFindPrev.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnFindPrev.Image = global::PragmaSQL.Properties.Resources.up;
      this.btnFindPrev.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnFindPrev.Name = "btnFindPrev";
      this.btnFindPrev.Size = new System.Drawing.Size(23, 22);
      this.btnFindPrev.Text = "Find Prev";
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
      // 
      // btnOutDent
      // 
      this.btnOutDent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnOutDent.Image = global::PragmaSQL.Properties.Resources.IndentRTL;
      this.btnOutDent.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnOutDent.Name = "btnOutDent";
      this.btnOutDent.Size = new System.Drawing.Size(23, 22);
      this.btnOutDent.Text = "Outdent Selection";
      // 
      // btnIndent
      // 
      this.btnIndent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnIndent.Image = global::PragmaSQL.Properties.Resources.Indent;
      this.btnIndent.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnIndent.Name = "btnIndent";
      this.btnIndent.Size = new System.Drawing.Size(23, 22);
      this.btnIndent.Text = "Indent Selection";
      // 
      // toolStripSeparator5
      // 
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
      // 
      // btnToggleBlockComment
      // 
      this.btnToggleBlockComment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnToggleBlockComment.Image = ((System.Drawing.Image)(resources.GetObject("btnToggleBlockComment.Image")));
      this.btnToggleBlockComment.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnToggleBlockComment.Name = "btnToggleBlockComment";
      this.btnToggleBlockComment.Size = new System.Drawing.Size(23, 22);
      this.btnToggleBlockComment.Text = "Toggle Block Comment";
      // 
      // btnToggleLineComment
      // 
      this.btnToggleLineComment.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnToggleLineComment.Image = ((System.Drawing.Image)(resources.GetObject("btnToggleLineComment.Image")));
      this.btnToggleLineComment.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnToggleLineComment.Name = "btnToggleLineComment";
      this.btnToggleLineComment.Size = new System.Drawing.Size(23, 22);
      this.btnToggleLineComment.Text = "Toggle Line Comment";
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
      // 
      // btnKeywordsToUppercase
      // 
      this.btnKeywordsToUppercase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnKeywordsToUppercase.Image = global::PragmaSQL.Properties.Resources.font_increase;
      this.btnKeywordsToUppercase.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnKeywordsToUppercase.Name = "btnKeywordsToUppercase";
      this.btnKeywordsToUppercase.Size = new System.Drawing.Size(23, 22);
      this.btnKeywordsToUppercase.Text = "Convert Keywords To Uppercase";
      // 
      // btnKeywordsToLowercase
      // 
      this.btnKeywordsToLowercase.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnKeywordsToLowercase.Image = global::PragmaSQL.Properties.Resources.font_decrease;
      this.btnKeywordsToLowercase.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnKeywordsToLowercase.Name = "btnKeywordsToLowercase";
      this.btnKeywordsToLowercase.Size = new System.Drawing.Size(23, 22);
      this.btnKeywordsToLowercase.Text = "Convert Keywords To Lowercase";
      // 
      // btnCapitalizeKeywords
      // 
      this.btnCapitalizeKeywords.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
      this.btnCapitalizeKeywords.Image = global::PragmaSQL.Properties.Resources.font_capitalize;
      this.btnCapitalizeKeywords.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.btnCapitalizeKeywords.Name = "btnCapitalizeKeywords";
      this.btnCapitalizeKeywords.Size = new System.Drawing.Size(23, 22);
      this.btnCapitalizeKeywords.Text = "Captialize Keywords";
      // 
      // toolStripDropDownButton1
      // 
      this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asSourceToolStripMenuItem1,
            this.asDestToolStripMenuItem1});
      this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
      this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
      this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
      this.toolStripDropDownButton1.Size = new System.Drawing.Size(55, 22);
      this.toolStripDropDownButton1.Text = "Diff";
      // 
      // asSourceToolStripMenuItem1
      // 
      this.asSourceToolStripMenuItem1.Name = "asSourceToolStripMenuItem1";
      this.asSourceToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
      this.asSourceToolStripMenuItem1.Text = "As Source";
      this.asSourceToolStripMenuItem1.Click += new System.EventHandler(this.OnDiffScriptAsSource_Click);
      // 
      // asDestToolStripMenuItem1
      // 
      this.asDestToolStripMenuItem1.Name = "asDestToolStripMenuItem1";
      this.asDestToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
      this.asDestToolStripMenuItem1.Text = "As Dest";
      this.asDestToolStripMenuItem1.Click += new System.EventHandler(this.OnDiffScriptAsDest_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
      // 
      // toolStripLabel1
      // 
      this.toolStripLabel1.Name = "toolStripLabel1";
      this.toolStripLabel1.Size = new System.Drawing.Size(41, 22);
      this.toolStripLabel1.Text = "Syntax";
      // 
      // cmbSyntaxModes
      // 
      this.cmbSyntaxModes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbSyntaxModes.FlatStyle = System.Windows.Forms.FlatStyle.System;
      this.cmbSyntaxModes.Name = "cmbSyntaxModes";
      this.cmbSyntaxModes.Size = new System.Drawing.Size(75, 25);
      this.cmbSyntaxModes.SelectedIndexChanged += new System.EventHandler(this.cmbSyntaxModes_SelectedIndexChanged);
      // 
      // frmTextEditor
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(877, 450);
      this.Controls.Add(this.strip3);
      this.Controls.Add(this.mainMenu);
      this.Controls.Add(this.statusStrip1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.mainMenu;
      this.Name = "frmTextEditor";
      this.TabPageContextMenuStrip = this.popUpTab;
      this.TabText = "Text Editor";
      this.Text = "Text Editor";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTextEditor_FormClosing);
      this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTextEditor_FormClosed);
      this.Leave += new System.EventHandler(this.frmTextEditor_Leave);
      this.Controls.SetChildIndex(this.statusStrip1, 0);
      this.Controls.SetChildIndex(this.mainMenu, 0);
      this.Controls.SetChildIndex(this.strip3, 0);
      this.Controls.SetChildIndex(this.panEditor, 0);
      this.panEditor.ResumeLayout(false);
      this.panEditor.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.fsWatcher)).EndInit();
      this.popUpTab.ResumeLayout(false);
      this.mainMenu.ResumeLayout(false);
      this.mainMenu.PerformLayout();
      this.popUpEditor.ResumeLayout(false);
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.strip3.ResumeLayout(false);
      this.strip3.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ContextMenuStrip popUpTab;
    private System.Windows.Forms.ToolStripMenuItem cMnuItemSave;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem cMnuItemClose;
    private System.Windows.Forms.MenuStrip mainMenu;
    private System.Windows.Forms.ContextMenuStrip popUpEditor;
    private System.Windows.Forms.ToolStripMenuItem tsMnuItemCopy;
    private System.Windows.Forms.ToolStripMenuItem tsMnuItemCut;
    private System.Windows.Forms.ToolStripMenuItem tsMnuItemPaste;
    private System.Windows.Forms.ToolStripMenuItem cMnuCloseAll;
    private System.Windows.Forms.ToolStripMenuItem cMnuCloseAllButThis;
    private System.Windows.Forms.OpenFileDialog openFileDialog1;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel statLblContentInfo;
    private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    private System.Windows.Forms.ToolStripMenuItem mnuFile;
    private System.Windows.Forms.ToolStripMenuItem mnuItemOpen;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
    private System.Windows.Forms.ToolStripMenuItem mnuItemSave;
    private System.Windows.Forms.ToolStripMenuItem mnuItemSaveAs;
    private System.Windows.Forms.ToolStripMenuItem mnuEdit;
    private System.Windows.Forms.ToolStripMenuItem mnuItemRedo;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
    private System.Windows.Forms.ToolStripMenuItem mnuItemCut;
    private System.Windows.Forms.ToolStripMenuItem mnuItemCopy;
    private System.Windows.Forms.ToolStripMenuItem mnuItemPaste;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
    private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem mnuItemSearchForward;
    private System.Windows.Forms.ToolStripMenuItem mnuItemSearchBackward;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
    private System.Windows.Forms.ToolStripMenuItem mnuItemFind;
    private System.Windows.Forms.ToolStripMenuItem mnuItemReplace;
    private System.Windows.Forms.ToolStripMenuItem mnuItemUndo;
    private System.Windows.Forms.ToolStripMenuItem mnuItemGoToLine;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
    private System.Windows.Forms.ToolStripMenuItem cMnuNewScript;
    private System.Windows.Forms.ToolStripMenuItem cMnuScriptFromFile;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem11;
    private System.Windows.Forms.ToolStripMenuItem formatToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem mnuItemKeywordsToUppercase;
    private System.Windows.Forms.ToolStripMenuItem mnuItemKeywordsToLowercase;
    private System.Windows.Forms.ToolStripMenuItem mnuItemCapitilizeKeywords;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
    private System.Windows.Forms.ToolStripMenuItem mnuItemScriptToUppercase;
    private System.Windows.Forms.ToolStripMenuItem mnuItemScriptToLowercase;
    private System.Windows.Forms.ToolStripMenuItem tsMnuItemUndo;
    private System.Windows.Forms.ToolStripMenuItem tsMnuItemRedo;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem9;
    private System.Windows.Forms.ToolStrip strip3;
    private System.Windows.Forms.ToolStripLabel toolStripLabel3;
    private System.Windows.Forms.ToolStripTextBox edtMatchText;
    private System.Windows.Forms.ToolStripButton btnFindNext;
    private System.Windows.Forms.ToolStripButton btnFindPrev;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripButton btnOutDent;
    private System.Windows.Forms.ToolStripButton btnIndent;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    private System.Windows.Forms.ToolStripButton btnToggleBlockComment;
    private System.Windows.Forms.ToolStripButton btnToggleLineComment;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripButton btnKeywordsToUppercase;
    private System.Windows.Forms.ToolStripButton btnKeywordsToLowercase;
    private System.Windows.Forms.ToolStripButton btnCapitalizeKeywords;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripButton btnOpen;
    private System.Windows.Forms.ToolStripButton btnSave;
    private System.Windows.Forms.ToolStripButton btnSaveAs;
    private System.Windows.Forms.ToolStripDropDownButton mnuItemSharedScriptOperations;
    private System.Windows.Forms.ToolStripMenuItem openSharedScriptToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveAsSharedScriptToolStripMenuItem;
    private System.Windows.Forms.ToolStripStatusLabel statCaretPos;
    private System.Windows.Forms.ToolStripStatusLabel statLblContentModifiedIndicator;
    private System.Windows.Forms.ToolStripMenuItem textDiffToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem cMnuTextDiffAsSource;
    private System.Windows.Forms.ToolStripMenuItem cMnuTextDiffAsDest;
    private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
    private System.Windows.Forms.ToolStripMenuItem asSourceToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem asDestToolStripMenuItem1;
    private System.Windows.Forms.ToolStripLabel toolStripLabel1;
    private System.Windows.Forms.ToolStripComboBox cmbSyntaxModes;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem mnuItemIncSearch;
		private System.Windows.Forms.ToolStripMenuItem mnuItemRevIncSearch;
		private System.Windows.Forms.ToolStripStatusLabel statIncSearch;
		private System.Windows.Forms.ToolStripButton btnNewScript;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem10;
		private System.Windows.Forms.ToolStripMenuItem findOnWebToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem12;
    private System.Windows.Forms.ToolStripButton btnSwitchToScriptEditor;
    private System.Windows.Forms.ToolStripMenuItem switchToToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem13;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem14;
    private System.Windows.Forms.ToolStripMenuItem switchToScriptEditorToolStripMenuItem;

  }
}