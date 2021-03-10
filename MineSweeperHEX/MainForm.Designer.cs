
namespace MineSweeperHEX {
    partial class MainForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.fieldPanel = new MineSweeperHEX.FieldPanel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripGame = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStart = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLevel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLevelEasy = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLevelNormal = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLevelHard = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripLevelCustom = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDiscloseVoid = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelMines = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelDisclose = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // fieldPanel
            // 
            this.fieldPanel.Location = new System.Drawing.Point(0, 24);
            this.fieldPanel.MinimumSize = new System.Drawing.Size(420, 368);
            this.fieldPanel.Name = "fieldPanel";
            this.fieldPanel.Size = new System.Drawing.Size(420, 368);
            this.fieldPanel.TabIndex = 0;
            this.fieldPanel.Text = "fieldPanel";
            this.fieldPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FieldPanel_MouseClick);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripGame});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(420, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // toolStripGame
            // 
            this.toolStripGame.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStart,
            this.toolStripLevel,
            this.toolStripDiscloseVoid});
            this.toolStripGame.Name = "toolStripGame";
            this.toolStripGame.Size = new System.Drawing.Size(49, 20);
            this.toolStripGame.Text = "Game";
            // 
            // toolStripStart
            // 
            this.toolStripStart.Name = "toolStripStart";
            this.toolStripStart.ShortcutKeyDisplayString = "Ctrl+S";
            this.toolStripStart.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.toolStripStart.Size = new System.Drawing.Size(169, 22);
            this.toolStripStart.Text = "Start";
            this.toolStripStart.Click += new System.EventHandler(this.ToolStripStart_Click);
            // 
            // toolStripLevel
            // 
            this.toolStripLevel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLevelEasy,
            this.toolStripLevelNormal,
            this.toolStripLevelHard,
            this.toolStripLevelCustom});
            this.toolStripLevel.Name = "toolStripLevel";
            this.toolStripLevel.Size = new System.Drawing.Size(169, 22);
            this.toolStripLevel.Text = "Level";
            // 
            // toolStripLevelEasy
            // 
            this.toolStripLevelEasy.Name = "toolStripLevelEasy";
            this.toolStripLevelEasy.Size = new System.Drawing.Size(114, 22);
            this.toolStripLevelEasy.Text = "Easy";
            this.toolStripLevelEasy.Click += new System.EventHandler(this.ToolStripLevelEasy_Click);
            // 
            // toolStripLevelNormal
            // 
            this.toolStripLevelNormal.Name = "toolStripLevelNormal";
            this.toolStripLevelNormal.Size = new System.Drawing.Size(114, 22);
            this.toolStripLevelNormal.Text = "Normal";
            this.toolStripLevelNormal.Click += new System.EventHandler(this.ToolStripLevelNormal_Click);
            // 
            // toolStripLevelHard
            // 
            this.toolStripLevelHard.Name = "toolStripLevelHard";
            this.toolStripLevelHard.Size = new System.Drawing.Size(114, 22);
            this.toolStripLevelHard.Text = "Hard";
            this.toolStripLevelHard.Click += new System.EventHandler(this.ToolStripLevelHard_Click);
            // 
            // toolStripLevelCustom
            // 
            this.toolStripLevelCustom.Name = "toolStripLevelCustom";
            this.toolStripLevelCustom.Size = new System.Drawing.Size(114, 22);
            this.toolStripLevelCustom.Text = "Custom";
            this.toolStripLevelCustom.Click += new System.EventHandler(this.ToolStripLevelCustom_Click);
            // 
            // toolStripDiscloseVoid
            // 
            this.toolStripDiscloseVoid.Name = "toolStripDiscloseVoid";
            this.toolStripDiscloseVoid.Size = new System.Drawing.Size(169, 22);
            this.toolStripDiscloseVoid.Text = "Disclose void cells";
            this.toolStripDiscloseVoid.Click += new System.EventHandler(this.ToolStripDiscloseVoid_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelMines,
            this.toolStripStatusLabelDisclose});
            this.statusStrip.Location = new System.Drawing.Point(0, 392);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(420, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabelMines
            // 
            this.toolStripStatusLabelMines.Name = "toolStripStatusLabelMines";
            this.toolStripStatusLabelMines.Size = new System.Drawing.Size(355, 17);
            this.toolStripStatusLabelMines.Spring = true;
            this.toolStripStatusLabelMines.Text = "RemainingMines";
            this.toolStripStatusLabelMines.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabelDisclose
            // 
            this.toolStripStatusLabelDisclose.Name = "toolStripStatusLabelDisclose";
            this.toolStripStatusLabelDisclose.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusLabelDisclose.Text = "Disclose";
            this.toolStripStatusLabelDisclose.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 414);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.fieldPanel);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "MineSweeper HEX";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FieldPanel fieldPanel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripGame;
        private System.Windows.Forms.ToolStripMenuItem toolStripStart;
        private System.Windows.Forms.ToolStripMenuItem toolStripLevel;
        private System.Windows.Forms.ToolStripMenuItem toolStripLevelEasy;
        private System.Windows.Forms.ToolStripMenuItem toolStripLevelNormal;
        private System.Windows.Forms.ToolStripMenuItem toolStripLevelHard;
        private System.Windows.Forms.ToolStripMenuItem toolStripLevelCustom;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMines;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDisclose;
        private System.Windows.Forms.ToolStripMenuItem toolStripDiscloseVoid;
    }
}

