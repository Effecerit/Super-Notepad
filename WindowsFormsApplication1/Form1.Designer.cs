namespace WindowsFormsApplication1
{
    partial class FrmSuperNotepad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSuperNotepad));
            this.mnsMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolparToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatToolparToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSFile = new System.Windows.Forms.ToolStrip();
            this.TSbtnOpen = new System.Windows.Forms.ToolStripButton();
            this.TSbtnSave = new System.Windows.Forms.ToolStripButton();
            this.TSbtnCut = new System.Windows.Forms.ToolStripButton();
            this.TSbtnPaste = new System.Windows.Forms.ToolStripButton();
            this.TSbtnUndo = new System.Windows.Forms.ToolStripButton();
            this.TSbtnPinNote = new System.Windows.Forms.ToolStripButton();
            this.TSFormat = new System.Windows.Forms.ToolStrip();
            this.TScbfont = new System.Windows.Forms.ToolStripComboBox();
            this.TScbSize = new System.Windows.Forms.ToolStripComboBox();
            this.TSsbtnTextColor = new System.Windows.Forms.ToolStripSplitButton();
            this.TSsbtnBackGroundColor = new System.Windows.Forms.ToolStripSplitButton();
            this.TSsbtnFormColor = new System.Windows.Forms.ToolStripSplitButton();
            this.TScbFile = new System.Windows.Forms.ToolStripComboBox();
            this.TBMain = new System.Windows.Forms.TextBox();
            this.FdFont = new System.Windows.Forms.FontDialog();
            this.CdColor = new System.Windows.Forms.ColorDialog();
            this.mnsMenu.SuspendLayout();
            this.TSFile.SuspendLayout();
            this.TSFormat.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsMenu
            // 
            this.mnsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.mnsMenu.Location = new System.Drawing.Point(0, 0);
            this.mnsMenu.Name = "mnsMenu";
            this.mnsMenu.Size = new System.Drawing.Size(744, 24);
            this.mnsMenu.TabIndex = 0;
            this.mnsMenu.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(111, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.undoToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolparToolStripMenuItem,
            this.formatToolparToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // fileToolparToolStripMenuItem
            // 
            this.fileToolparToolStripMenuItem.Name = "fileToolparToolStripMenuItem";
            this.fileToolparToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.fileToolparToolStripMenuItem.Text = "File Toolbar";
            // 
            // formatToolparToolStripMenuItem
            // 
            this.formatToolparToolStripMenuItem.Name = "formatToolparToolStripMenuItem";
            this.formatToolparToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.formatToolparToolStripMenuItem.Text = "Format Toolbar";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // TSFile
            // 
            this.TSFile.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.TSFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSbtnOpen,
            this.TSbtnSave,
            this.TSbtnCut,
            this.TSbtnPaste,
            this.TSbtnUndo,
            this.TSbtnPinNote});
            this.TSFile.Location = new System.Drawing.Point(0, 24);
            this.TSFile.Name = "TSFile";
            this.TSFile.Size = new System.Drawing.Size(744, 37);
            this.TSFile.TabIndex = 1;
            this.TSFile.Text = "toolbar";
            // 
            // TSbtnOpen
            // 
            this.TSbtnOpen.Image = ((System.Drawing.Image)(resources.GetObject("TSbtnOpen.Image")));
            this.TSbtnOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSbtnOpen.Name = "TSbtnOpen";
            this.TSbtnOpen.Size = new System.Drawing.Size(70, 34);
            this.TSbtnOpen.Text = "Open";
            // 
            // TSbtnSave
            // 
            this.TSbtnSave.Image = ((System.Drawing.Image)(resources.GetObject("TSbtnSave.Image")));
            this.TSbtnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSbtnSave.Name = "TSbtnSave";
            this.TSbtnSave.Size = new System.Drawing.Size(65, 34);
            this.TSbtnSave.Text = "Save";
            // 
            // TSbtnCut
            // 
            this.TSbtnCut.Image = ((System.Drawing.Image)(resources.GetObject("TSbtnCut.Image")));
            this.TSbtnCut.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSbtnCut.Name = "TSbtnCut";
            this.TSbtnCut.Size = new System.Drawing.Size(60, 34);
            this.TSbtnCut.Text = "Cut";
            // 
            // TSbtnPaste
            // 
            this.TSbtnPaste.Image = ((System.Drawing.Image)(resources.GetObject("TSbtnPaste.Image")));
            this.TSbtnPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSbtnPaste.Name = "TSbtnPaste";
            this.TSbtnPaste.Size = new System.Drawing.Size(69, 34);
            this.TSbtnPaste.Text = "Paste";
            // 
            // TSbtnUndo
            // 
            this.TSbtnUndo.Image = ((System.Drawing.Image)(resources.GetObject("TSbtnUndo.Image")));
            this.TSbtnUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSbtnUndo.Name = "TSbtnUndo";
            this.TSbtnUndo.Size = new System.Drawing.Size(70, 34);
            this.TSbtnUndo.Text = "Undo";
            // 
            // TSbtnPinNote
            // 
            this.TSbtnPinNote.Image = ((System.Drawing.Image)(resources.GetObject("TSbtnPinNote.Image")));
            this.TSbtnPinNote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSbtnPinNote.Name = "TSbtnPinNote";
            this.TSbtnPinNote.Size = new System.Drawing.Size(87, 34);
            this.TSbtnPinNote.Text = "Pin Note";
            // 
            // TSFormat
            // 
            this.TSFormat.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.TSFormat.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TScbfont,
            this.TScbSize,
            this.TSsbtnTextColor,
            this.TSsbtnBackGroundColor,
            this.TSsbtnFormColor,
            this.TScbFile});
            this.TSFormat.Location = new System.Drawing.Point(0, 61);
            this.TSFormat.Name = "TSFormat";
            this.TSFormat.Size = new System.Drawing.Size(744, 37);
            this.TSFormat.TabIndex = 2;
            this.TSFormat.Text = "toolStrip2";
            // 
            // TScbfont
            // 
            this.TScbfont.Name = "TScbfont";
            this.TScbfont.Size = new System.Drawing.Size(121, 37);
            this.TScbfont.Text = "Font";
            // 
            // TScbSize
            // 
            this.TScbSize.Name = "TScbSize";
            this.TScbSize.Size = new System.Drawing.Size(75, 37);
            this.TScbSize.Text = "Size";
            // 
            // TSsbtnTextColor
            // 
            this.TSsbtnTextColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSsbtnTextColor.Image = ((System.Drawing.Image)(resources.GetObject("TSsbtnTextColor.Image")));
            this.TSsbtnTextColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSsbtnTextColor.Name = "TSsbtnTextColor";
            this.TSsbtnTextColor.Size = new System.Drawing.Size(46, 34);
            this.TSsbtnTextColor.Text = "Text Color";
            // 
            // TSsbtnBackGroundColor
            // 
            this.TSsbtnBackGroundColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSsbtnBackGroundColor.Image = ((System.Drawing.Image)(resources.GetObject("TSsbtnBackGroundColor.Image")));
            this.TSsbtnBackGroundColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSsbtnBackGroundColor.Name = "TSsbtnBackGroundColor";
            this.TSsbtnBackGroundColor.Size = new System.Drawing.Size(46, 34);
            this.TSsbtnBackGroundColor.Text = "Background Color";
            this.TSsbtnBackGroundColor.ButtonClick += new System.EventHandler(this.TSsbtnBackGroundColor_ButtonClick);
            // 
            // TSsbtnFormColor
            // 
            this.TSsbtnFormColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TSsbtnFormColor.Image = ((System.Drawing.Image)(resources.GetObject("TSsbtnFormColor.Image")));
            this.TSsbtnFormColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TSsbtnFormColor.Name = "TSsbtnFormColor";
            this.TSsbtnFormColor.Size = new System.Drawing.Size(46, 34);
            this.TSsbtnFormColor.Text = "Notepad Color";
            // 
            // TScbFile
            // 
            this.TScbFile.Name = "TScbFile";
            this.TScbFile.Size = new System.Drawing.Size(121, 37);
            this.TScbFile.Text = "Files";
            // 
            // TBMain
            // 
            this.TBMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBMain.Location = new System.Drawing.Point(0, 98);
            this.TBMain.Multiline = true;
            this.TBMain.Name = "TBMain";
            this.TBMain.Size = new System.Drawing.Size(744, 404);
            this.TBMain.TabIndex = 3;
            this.TBMain.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // FdFont
            // 
            this.FdFont.Apply += new System.EventHandler(this.FdFont_Apply);
            // 
            // FrmSuperNotepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 502);
            this.Controls.Add(this.TBMain);
            this.Controls.Add(this.TSFormat);
            this.Controls.Add(this.TSFile);
            this.Controls.Add(this.mnsMenu);
            this.MainMenuStrip = this.mnsMenu;
            this.Name = "FrmSuperNotepad";
            this.Text = "SuperNotepad";
            this.mnsMenu.ResumeLayout(false);
            this.mnsMenu.PerformLayout();
            this.TSFile.ResumeLayout(false);
            this.TSFile.PerformLayout();
            this.TSFormat.ResumeLayout(false);
            this.TSFormat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolparToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatToolparToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStrip TSFile;
        private System.Windows.Forms.ToolStripButton TSbtnOpen;
        private System.Windows.Forms.ToolStripButton TSbtnSave;
        private System.Windows.Forms.ToolStripButton TSbtnCut;
        private System.Windows.Forms.ToolStripButton TSbtnPaste;
        private System.Windows.Forms.ToolStripButton TSbtnUndo;
        private System.Windows.Forms.ToolStripButton TSbtnPinNote;
        private System.Windows.Forms.ToolStrip TSFormat;
        private System.Windows.Forms.TextBox TBMain;
        private System.Windows.Forms.ToolStripComboBox TScbfont;
        private System.Windows.Forms.ToolStripComboBox TScbSize;
        private System.Windows.Forms.ToolStripSplitButton TSsbtnTextColor;
        private System.Windows.Forms.ToolStripSplitButton TSsbtnBackGroundColor;
        private System.Windows.Forms.ToolStripComboBox TScbFile;
        private System.Windows.Forms.FontDialog FdFont;
        private System.Windows.Forms.ColorDialog CdColor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton TSsbtnFormColor;
    }
}

