namespace WinHtmlEditor
{
    sealed partial class HtmlEditor
    {
        
        private System.ComponentModel.IContainer components = null;

        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HtmlEditor));
            this.tscMain = new System.Windows.Forms.ToolStripContainer();
            this.ssHtml = new System.Windows.Forms.StatusStrip();
            this.tsslWordCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.wb = new WinHtmlEditor.Common.SubWebBrowser();
            this.cmsHtml = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiTable = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTableModify = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTableInsertRow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTableDeleteRow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiInsertImage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiShowMockup = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiGenKBI = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCopy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCut = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFind = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRemoveFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiSave = new System.Windows.Forms.ToolStripMenuItem();
            this.tsTopToolBar = new System.Windows.Forms.ToolStrip();
            this.tsfcbFontName = new WinHtmlEditor.ToolStripFontComboBox();
            this.tscbFontSize = new WinHtmlEditor.Common.ToolStripFontSizeComboBox();
            this.tsbNew = new System.Windows.Forms.ToolStripButton();
            this.tsbOpen = new System.Windows.Forms.ToolStripButton();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbUndo = new System.Windows.Forms.ToolStripButton();
            this.tsbRedo = new System.Windows.Forms.ToolStripButton();
            this.tsbJustifyCenter = new System.Windows.Forms.ToolStripButton();
            this.tsbJustifyFull = new System.Windows.Forms.ToolStripButton();
            this.tsbJustifyLeft = new System.Windows.Forms.ToolStripButton();
            this.tsbJustifyRight = new System.Windows.Forms.ToolStripButton();
            this.tsbBold = new System.Windows.Forms.ToolStripButton();
            this.tscpForeColor = new WinHtmlEditor.ToolStripColorPicker();
            this.tsbInsertImage = new System.Windows.Forms.ToolStripButton();
            this.wordDictionary = new NetSpell.SpellChecker.Dictionary.WordDictionary(this.components);
            this.spellCheck = new NetSpell.SpellChecker.Spelling(this.components);
            this.tscMain.BottomToolStripPanel.SuspendLayout();
            this.tscMain.ContentPanel.SuspendLayout();
            this.tscMain.TopToolStripPanel.SuspendLayout();
            this.tscMain.SuspendLayout();
            this.ssHtml.SuspendLayout();
            this.cmsHtml.SuspendLayout();
            this.tsTopToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tscMain
            // 
            // 
            // tscMain.BottomToolStripPanel
            // 
            this.tscMain.BottomToolStripPanel.Controls.Add(this.ssHtml);
            // 
            // tscMain.ContentPanel
            // 
            this.tscMain.ContentPanel.AutoScroll = true;
            this.tscMain.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tscMain.ContentPanel.Controls.Add(this.wb);
            this.tscMain.ContentPanel.Size = new System.Drawing.Size(1296, 462);
            this.tscMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tscMain.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tscMain.LeftToolStripPanelVisible = false;
            this.tscMain.Location = new System.Drawing.Point(0, 0);
            this.tscMain.Name = "tscMain";
            this.tscMain.RightToolStripPanelVisible = false;
            this.tscMain.Size = new System.Drawing.Size(1296, 510);
            this.tscMain.TabIndex = 0;
            this.tscMain.Text = "toolStripContainer1";
            // 
            // tscMain.TopToolStripPanel
            // 
            this.tscMain.TopToolStripPanel.Controls.Add(this.tsTopToolBar);
            // 
            // ssHtml
            // 
            this.ssHtml.Dock = System.Windows.Forms.DockStyle.None;
            this.ssHtml.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslWordCount});
            this.ssHtml.Location = new System.Drawing.Point(0, 0);
            this.ssHtml.Name = "ssHtml";
            this.ssHtml.Size = new System.Drawing.Size(1296, 22);
            this.ssHtml.TabIndex = 1;
            this.ssHtml.Text = "statusStrip1";
            // 
            // tsslWordCount
            // 
            this.tsslWordCount.Name = "tsslWordCount";
            this.tsslWordCount.Size = new System.Drawing.Size(72, 17);
            this.tsslWordCount.Text = "Word Count";
            // 
            // wb
            // 
            this.wb.ContextMenuStrip = this.cmsHtml;
            this.wb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wb.Location = new System.Drawing.Point(0, 0);
            this.wb.MinimumSize = new System.Drawing.Size(20, 22);
            this.wb.Name = "wb";
            this.wb.Size = new System.Drawing.Size(1292, 458);
            this.wb.TabIndex = 0;
            this.wb.Url = new System.Uri("http://-", System.UriKind.Absolute);
            this.wb.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.wb_DocumentCompleted);
            this.wb.Navigating += new System.Windows.Forms.WebBrowserNavigatingEventHandler(this.wb_Navigating);
            // 
            // cmsHtml
            // 
            this.cmsHtml.AllowDrop = true;
            this.cmsHtml.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTable,
            this.tsmiInsertImage,
            this.tsmiShowMockup,
            this.tsmiGenKBI,
            this.tsmiSelectAll,
            this.tsmiCopy,
            this.tsmiCut,
            this.tsmiPaste,
            this.tsmiDelete,
            this.tsmiFind,
            this.tsmiRemoveFormat,
            this.toolStripSeparator5,
            this.tsmiSave});
            this.cmsHtml.Name = "contextMenuWeb";
            this.cmsHtml.Size = new System.Drawing.Size(159, 274);
            // 
            // tsmiTable
            // 
            this.tsmiTable.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTableModify,
            this.tsmiTableInsertRow,
            this.tsmiTableDeleteRow});
            this.tsmiTable.Enabled = false;
            this.tsmiTable.Name = "tsmiTable";
            this.tsmiTable.Size = new System.Drawing.Size(158, 22);
            this.tsmiTable.Tag = "Table";
            this.tsmiTable.Text = "Table";
            this.tsmiTable.Visible = false;
            // 
            // tsmiTableModify
            // 
            this.tsmiTableModify.Image = global::WinHtmlEditor.Properties.Resources.InsertTable;
            this.tsmiTableModify.Name = "tsmiTableModify";
            this.tsmiTableModify.Size = new System.Drawing.Size(142, 22);
            this.tsmiTableModify.Tag = "TableModify";
            this.tsmiTableModify.Text = "Table Modify";
            this.tsmiTableModify.Click += new System.EventHandler(this.ContextEditorClick);
            // 
            // tsmiTableInsertRow
            // 
            this.tsmiTableInsertRow.Name = "tsmiTableInsertRow";
            this.tsmiTableInsertRow.Size = new System.Drawing.Size(142, 22);
            this.tsmiTableInsertRow.Tag = "TableInsertRow";
            this.tsmiTableInsertRow.Text = "Insert Row";
            this.tsmiTableInsertRow.Click += new System.EventHandler(this.ContextEditorClick);
            // 
            // tsmiTableDeleteRow
            // 
            this.tsmiTableDeleteRow.Name = "tsmiTableDeleteRow";
            this.tsmiTableDeleteRow.Size = new System.Drawing.Size(142, 22);
            this.tsmiTableDeleteRow.Tag = "TableDeleteRow";
            this.tsmiTableDeleteRow.Text = "Delete Row";
            this.tsmiTableDeleteRow.Click += new System.EventHandler(this.ContextEditorClick);
            // 
            // tsmiInsertImage
            // 
            this.tsmiInsertImage.Image = global::WinHtmlEditor.Properties.Resources.InsertImage;
            this.tsmiInsertImage.Name = "tsmiInsertImage";
            this.tsmiInsertImage.Size = new System.Drawing.Size(158, 22);
            this.tsmiInsertImage.Text = "InsertImage";
            this.tsmiInsertImage.Click += new System.EventHandler(this.tsmiInsertImage_Click);
            // 
            // tsmiShowMockup
            // 
            this.tsmiShowMockup.Image = global::WinHtmlEditor.Properties.Resources.Preview;
            this.tsmiShowMockup.Name = "tsmiShowMockup";
            this.tsmiShowMockup.Size = new System.Drawing.Size(158, 22);
            this.tsmiShowMockup.Text = "Show Mockup";
            this.tsmiShowMockup.Click += new System.EventHandler(this.tsmiShowMockup_Click);
            // 
            // tsmiGenKBI
            // 
            this.tsmiGenKBI.Image = global::WinHtmlEditor.Properties.Resources.Save;
            this.tsmiGenKBI.Name = "tsmiGenKBI";
            this.tsmiGenKBI.Size = new System.Drawing.Size(158, 22);
            this.tsmiGenKBI.Text = "Generate KBI";
            // 
            // tsmiSelectAll
            // 
            this.tsmiSelectAll.Name = "tsmiSelectAll";
            this.tsmiSelectAll.Size = new System.Drawing.Size(158, 22);
            this.tsmiSelectAll.Tag = "SelectAll";
            this.tsmiSelectAll.Text = "Select All";
            this.tsmiSelectAll.Visible = false;
            this.tsmiSelectAll.Click += new System.EventHandler(this.ContextEditorClick);
            // 
            // tsmiCopy
            // 
            this.tsmiCopy.Image = global::WinHtmlEditor.Properties.Resources.Copy;
            this.tsmiCopy.Name = "tsmiCopy";
            this.tsmiCopy.Size = new System.Drawing.Size(158, 22);
            this.tsmiCopy.Tag = "Copy";
            this.tsmiCopy.Text = "Copy";
            this.tsmiCopy.Visible = false;
            this.tsmiCopy.Click += new System.EventHandler(this.ContextEditorClick);
            // 
            // tsmiCut
            // 
            this.tsmiCut.Image = global::WinHtmlEditor.Properties.Resources.Cut;
            this.tsmiCut.Name = "tsmiCut";
            this.tsmiCut.Size = new System.Drawing.Size(158, 22);
            this.tsmiCut.Tag = "Cut";
            this.tsmiCut.Text = "Cut";
            this.tsmiCut.Visible = false;
            this.tsmiCut.Click += new System.EventHandler(this.ContextEditorClick);
            // 
            // tsmiPaste
            // 
            this.tsmiPaste.Image = global::WinHtmlEditor.Properties.Resources.Paste;
            this.tsmiPaste.Name = "tsmiPaste";
            this.tsmiPaste.Size = new System.Drawing.Size(158, 22);
            this.tsmiPaste.Tag = "Paste";
            this.tsmiPaste.Text = "Paste";
            this.tsmiPaste.Visible = false;
            this.tsmiPaste.Click += new System.EventHandler(this.ContextEditorClick);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Image = global::WinHtmlEditor.Properties.Resources.Delete;
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(158, 22);
            this.tsmiDelete.Tag = "Delete";
            this.tsmiDelete.Text = "Delete";
            this.tsmiDelete.Visible = false;
            this.tsmiDelete.Click += new System.EventHandler(this.ContextEditorClick);
            // 
            // tsmiFind
            // 
            this.tsmiFind.Image = global::WinHtmlEditor.Properties.Resources.Find;
            this.tsmiFind.Name = "tsmiFind";
            this.tsmiFind.Size = new System.Drawing.Size(158, 22);
            this.tsmiFind.Tag = "Find";
            this.tsmiFind.Text = "Find";
            this.tsmiFind.Visible = false;
            this.tsmiFind.Click += new System.EventHandler(this.ContextEditorClick);
            // 
            // tsmiRemoveFormat
            // 
            this.tsmiRemoveFormat.Image = global::WinHtmlEditor.Properties.Resources.RemoveFormat;
            this.tsmiRemoveFormat.Name = "tsmiRemoveFormat";
            this.tsmiRemoveFormat.Size = new System.Drawing.Size(158, 22);
            this.tsmiRemoveFormat.Tag = "RemoveFormat";
            this.tsmiRemoveFormat.Text = "Remove Format";
            this.tsmiRemoveFormat.Visible = false;
            this.tsmiRemoveFormat.Click += new System.EventHandler(this.ContextEditorClick);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(155, 6);
            this.toolStripSeparator5.Visible = false;
            // 
            // tsmiSave
            // 
            this.tsmiSave.Image = global::WinHtmlEditor.Properties.Resources.Save;
            this.tsmiSave.Name = "tsmiSave";
            this.tsmiSave.Size = new System.Drawing.Size(158, 22);
            this.tsmiSave.Tag = "Save";
            this.tsmiSave.Text = "Save";
            this.tsmiSave.Visible = false;
            this.tsmiSave.Click += new System.EventHandler(this.ContextEditorClick);
            // 
            // tsTopToolBar
            // 
            this.tsTopToolBar.Dock = System.Windows.Forms.DockStyle.None;
            this.tsTopToolBar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsTopToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsfcbFontName,
            this.tscbFontSize,
            this.tsbNew,
            this.tsbOpen,
            this.tsbSave,
            this.tsbUndo,
            this.tsbRedo,
            this.tsbJustifyCenter,
            this.tsbJustifyFull,
            this.tsbJustifyLeft,
            this.tsbJustifyRight,
            this.tsbBold,
            this.tscpForeColor,
            this.tsbInsertImage});
            this.tsTopToolBar.Location = new System.Drawing.Point(3, 0);
            this.tsTopToolBar.Name = "tsTopToolBar";
            this.tsTopToolBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.tsTopToolBar.Size = new System.Drawing.Size(596, 26);
            this.tsTopToolBar.TabIndex = 0;
            this.tsTopToolBar.Text = "topToolBar";
            // 
            // tsfcbFontName
            // 
            this.tsfcbFontName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.tsfcbFontName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.tsfcbFontName.AutoSize = false;
            this.tsfcbFontName.InternalCall = false;
            this.tsfcbFontName.Name = "tsfcbFontName";
            this.tsfcbFontName.SelectedFontItem = null;
            this.tsfcbFontName.SelectedFontNameItem = "";
            this.tsfcbFontName.Size = new System.Drawing.Size(200, 26);
            this.tsfcbFontName.Tag = "FontName";
            this.tsfcbFontName.SelectedIndexChanged += new System.EventHandler(this.tsfcbFontName_SelectedIndexChanged);
            // 
            // tscbFontSize
            // 
            this.tscbFontSize.AutoSize = false;
            this.tscbFontSize.Name = "tscbFontSize";
            this.tscbFontSize.Size = new System.Drawing.Size(75, 26);
            this.tscbFontSize.Tag = "Font Size";
            this.tscbFontSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tscbFontSize_KeyPress);
            // 
            // tsbNew
            // 
            this.tsbNew.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbNew.Image = global::WinHtmlEditor.Properties.Resources.New;
            this.tsbNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNew.Name = "tsbNew";
            this.tsbNew.Size = new System.Drawing.Size(23, 23);
            this.tsbNew.Tag = "New";
            this.tsbNew.Text = "New";
            this.tsbNew.Click += new System.EventHandler(this.tsbNew_Click);
            // 
            // tsbOpen
            // 
            this.tsbOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbOpen.Image = global::WinHtmlEditor.Properties.Resources.Open;
            this.tsbOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpen.Name = "tsbOpen";
            this.tsbOpen.Size = new System.Drawing.Size(23, 23);
            this.tsbOpen.Tag = "Open";
            this.tsbOpen.Text = "Open";
            this.tsbOpen.Click += new System.EventHandler(this.tsbOpen_Click);
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbSave.Image = global::WinHtmlEditor.Properties.Resources.Save;
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(23, 23);
            this.tsbSave.Tag = "Save";
            this.tsbSave.Text = "Save";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbUndo
            // 
            this.tsbUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbUndo.Image = global::WinHtmlEditor.Properties.Resources.Undo;
            this.tsbUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUndo.Name = "tsbUndo";
            this.tsbUndo.Size = new System.Drawing.Size(23, 23);
            this.tsbUndo.Tag = "Undo";
            this.tsbUndo.Text = "Undo";
            this.tsbUndo.Click += new System.EventHandler(this.tsbUndo_Click);
            // 
            // tsbRedo
            // 
            this.tsbRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbRedo.Image = global::WinHtmlEditor.Properties.Resources.Redo;
            this.tsbRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRedo.Name = "tsbRedo";
            this.tsbRedo.Size = new System.Drawing.Size(23, 23);
            this.tsbRedo.Tag = "Redo";
            this.tsbRedo.Text = "Redo";
            this.tsbRedo.Click += new System.EventHandler(this.tsbRedo_Click);
            // 
            // tsbJustifyCenter
            // 
            this.tsbJustifyCenter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbJustifyCenter.Image = global::WinHtmlEditor.Properties.Resources.JustifyCenter;
            this.tsbJustifyCenter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbJustifyCenter.Name = "tsbJustifyCenter";
            this.tsbJustifyCenter.Size = new System.Drawing.Size(23, 23);
            this.tsbJustifyCenter.Tag = "JustifyCenter";
            this.tsbJustifyCenter.Text = "Justify Center";
            this.tsbJustifyCenter.Click += new System.EventHandler(this.tsbJustifyCenter_Click);
            // 
            // tsbJustifyFull
            // 
            this.tsbJustifyFull.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbJustifyFull.Image = global::WinHtmlEditor.Properties.Resources.JustifyFull;
            this.tsbJustifyFull.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbJustifyFull.Name = "tsbJustifyFull";
            this.tsbJustifyFull.Size = new System.Drawing.Size(23, 23);
            this.tsbJustifyFull.Tag = "JustifyFull";
            this.tsbJustifyFull.Text = "Justify Full";
            this.tsbJustifyFull.Click += new System.EventHandler(this.tsbJustifyFull_Click);
            // 
            // tsbJustifyLeft
            // 
            this.tsbJustifyLeft.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbJustifyLeft.Image = global::WinHtmlEditor.Properties.Resources.JustifyLeft;
            this.tsbJustifyLeft.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbJustifyLeft.Name = "tsbJustifyLeft";
            this.tsbJustifyLeft.Size = new System.Drawing.Size(23, 23);
            this.tsbJustifyLeft.Tag = "JustifyLeft";
            this.tsbJustifyLeft.Text = "Justify Left";
            this.tsbJustifyLeft.Click += new System.EventHandler(this.tsbJustifyLeft_Click);
            // 
            // tsbJustifyRight
            // 
            this.tsbJustifyRight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbJustifyRight.Image = global::WinHtmlEditor.Properties.Resources.JustifyRight;
            this.tsbJustifyRight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbJustifyRight.Name = "tsbJustifyRight";
            this.tsbJustifyRight.Size = new System.Drawing.Size(23, 23);
            this.tsbJustifyRight.Tag = "JustifyRight";
            this.tsbJustifyRight.Text = "Justify Right";
            this.tsbJustifyRight.Click += new System.EventHandler(this.tsbJustifyRight_Click);
            // 
            // tsbBold
            // 
            this.tsbBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBold.Image = global::WinHtmlEditor.Properties.Resources.Bold;
            this.tsbBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBold.Name = "tsbBold";
            this.tsbBold.Size = new System.Drawing.Size(23, 23);
            this.tsbBold.Tag = "Bold";
            this.tsbBold.Text = "Bold";
            this.tsbBold.Click += new System.EventHandler(this.tsbBold_Click);
            // 
            // tscpForeColor
            // 
            this.tscpForeColor.AutoSize = false;
            this.tscpForeColor.ButtonDisplayStyle = WinHtmlEditor.ToolStripColorPickerDisplayType.UnderLineAndImage;
            this.tscpForeColor.Color = System.Drawing.Color.Black;
            this.tscpForeColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.tscpForeColor.Image = ((System.Drawing.Image)(resources.GetObject("tscpForeColor.Image")));
            this.tscpForeColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tscpForeColor.Name = "tscpForeColor";
            this.tscpForeColor.Size = new System.Drawing.Size(30, 23);
            this.tscpForeColor.Tag = "ForeColor";
            this.tscpForeColor.Text = "Fore Color";
            this.tscpForeColor.ToolTipText = "Fore Color";
            this.tscpForeColor.SelectedColorChanged += new System.EventHandler(this.tscpForeColor_SelectedColorChanged);
            this.tscpForeColor.ButtonClick += new System.EventHandler(this.tscpForeColor_SelectedColorChanged);
            // 
            // tsbInsertImage
            // 
            this.tsbInsertImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbInsertImage.Image = global::WinHtmlEditor.Properties.Resources.InsertImage;
            this.tsbInsertImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbInsertImage.Name = "tsbInsertImage";
            this.tsbInsertImage.Size = new System.Drawing.Size(23, 23);
            this.tsbInsertImage.Tag = "InsertImage";
            this.tsbInsertImage.Text = "Insert Image";
            this.tsbInsertImage.Click += new System.EventHandler(this.tsbInsertImage_Click);
            // 
            // wordDictionary
            // 
            this.wordDictionary.DictionaryFile = "en-US.dic";
            this.wordDictionary.DictionaryFolder = "dic";
            // 
            // spellCheck
            // 
            this.spellCheck.Dictionary = this.wordDictionary;
            this.spellCheck.DeletedWord += new NetSpell.SpellChecker.Spelling.DeletedWordEventHandler(this.spellCheck_DeletedWord);
            this.spellCheck.ReplacedWord += new NetSpell.SpellChecker.Spelling.ReplacedWordEventHandler(this.spellCheck_ReplacedWord);
            // 
            // HtmlEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.tscMain);
            this.Name = "HtmlEditor";
            this.Size = new System.Drawing.Size(1296, 510);
            this.Load += new System.EventHandler(this.HtmlEditor_Load);
            this.tscMain.BottomToolStripPanel.ResumeLayout(false);
            this.tscMain.BottomToolStripPanel.PerformLayout();
            this.tscMain.ContentPanel.ResumeLayout(false);
            this.tscMain.TopToolStripPanel.ResumeLayout(false);
            this.tscMain.TopToolStripPanel.PerformLayout();
            this.tscMain.ResumeLayout(false);
            this.tscMain.PerformLayout();
            this.ssHtml.ResumeLayout(false);
            this.ssHtml.PerformLayout();
            this.cmsHtml.ResumeLayout(false);
            this.tsTopToolBar.ResumeLayout(false);
            this.tsTopToolBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscMain;
        private System.Windows.Forms.ToolStrip tsTopToolBar;
        private System.Windows.Forms.ToolStripButton tsbNew;
        private System.Windows.Forms.ToolStripButton tsbOpen;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbJustifyCenter;
        private System.Windows.Forms.ToolStripButton tsbJustifyFull;
        private System.Windows.Forms.ToolStripButton tsbJustifyLeft;
        private System.Windows.Forms.ToolStripButton tsbJustifyRight;
        private System.Windows.Forms.ToolStripButton tsbBold;
        private System.Windows.Forms.ToolStripButton tsbInsertImage;
        private System.Windows.Forms.ContextMenuStrip cmsHtml;
        private System.Windows.Forms.ToolStripMenuItem tsmiSelectAll;
        private System.Windows.Forms.ToolStripMenuItem tsmiCopy;
        private System.Windows.Forms.ToolStripMenuItem tsmiCut;
        private System.Windows.Forms.ToolStripMenuItem tsmiPaste;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiFind;
        private System.Windows.Forms.ToolStripMenuItem tsmiRemoveFormat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem tsmiSave;
        internal Common.SubWebBrowser wb;
        private NetSpell.SpellChecker.Dictionary.WordDictionary wordDictionary;
        private NetSpell.SpellChecker.Spelling spellCheck;
        private WinHtmlEditor.Common.ToolStripFontSizeComboBox tscbFontSize;
        private System.Windows.Forms.ToolStripButton tsbRedo;
        private System.Windows.Forms.ToolStripMenuItem tsmiTable;
        private System.Windows.Forms.ToolStripMenuItem tsmiTableModify;
        private System.Windows.Forms.ToolStripMenuItem tsmiTableInsertRow;
        private System.Windows.Forms.ToolStripMenuItem tsmiTableDeleteRow;
        private System.Windows.Forms.StatusStrip ssHtml;
        private System.Windows.Forms.ToolStripStatusLabel tsslWordCount;
        private ToolStripColorPicker tscpForeColor;
        private ToolStripFontComboBox tsfcbFontName;
        private System.Windows.Forms.ToolStripButton tsbUndo;
        private System.Windows.Forms.ToolStripMenuItem tsmiInsertImage;
        private System.Windows.Forms.ToolStripMenuItem tsmiShowMockup;
        private System.Windows.Forms.ToolStripMenuItem tsmiGenKBI;
    }
}
