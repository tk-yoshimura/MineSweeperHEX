
namespace MineSweeperHEX {
    partial class SettingCustomForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.labelGridsize = new System.Windows.Forms.Label();
            this.numericUpDownGridSize = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMines = new System.Windows.Forms.NumericUpDown();
            this.labelMines = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelAll = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGridSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMines)).BeginInit();
            this.SuspendLayout();
            // 
            // labelGridsize
            // 
            this.labelGridsize.AutoSize = true;
            this.labelGridsize.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGridsize.Location = new System.Drawing.Point(12, 15);
            this.labelGridsize.Name = "labelGridsize";
            this.labelGridsize.Size = new System.Drawing.Size(68, 21);
            this.labelGridsize.TabIndex = 0;
            this.labelGridsize.Text = "GridSize";
            // 
            // numericUpDownGridSize
            // 
            this.numericUpDownGridSize.Location = new System.Drawing.Point(115, 12);
            this.numericUpDownGridSize.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownGridSize.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericUpDownGridSize.Name = "numericUpDownGridSize";
            this.numericUpDownGridSize.Size = new System.Drawing.Size(53, 23);
            this.numericUpDownGridSize.TabIndex = 1;
            this.numericUpDownGridSize.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownGridSize.ValueChanged += new System.EventHandler(this.NumericUpDownGridSize_ValueChanged);
            // 
            // numericUpDownMines
            // 
            this.numericUpDownMines.Location = new System.Drawing.Point(115, 39);
            this.numericUpDownMines.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownMines.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownMines.Name = "numericUpDownMines";
            this.numericUpDownMines.Size = new System.Drawing.Size(53, 23);
            this.numericUpDownMines.TabIndex = 3;
            this.numericUpDownMines.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            // 
            // labelMines
            // 
            this.labelMines.AutoSize = true;
            this.labelMines.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMines.Location = new System.Drawing.Point(12, 41);
            this.labelMines.Name = "labelMines";
            this.labelMines.Size = new System.Drawing.Size(94, 21);
            this.labelMines.TabIndex = 2;
            this.labelMines.Text = "MineCounts";
            // 
            // buttonOK
            // 
            this.buttonOK.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOK.Location = new System.Drawing.Point(144, 73);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(60, 28);
            this.buttonOK.TabIndex = 4;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCancel.Location = new System.Drawing.Point(210, 73);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(60, 28);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // labelAll
            // 
            this.labelAll.AutoSize = true;
            this.labelAll.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAll.Location = new System.Drawing.Point(174, 41);
            this.labelAll.Name = "labelAll";
            this.labelAll.Size = new System.Drawing.Size(0, 21);
            this.labelAll.TabIndex = 6;
            // 
            // SettingCustomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 113);
            this.Controls.Add(this.labelAll);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.numericUpDownMines);
            this.Controls.Add(this.labelMines);
            this.Controls.Add(this.numericUpDownGridSize);
            this.Controls.Add(this.labelGridsize);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SettingCustomForm";
            this.Text = "MineSweeper HEX CustomGame";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGridSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGridsize;
        private System.Windows.Forms.NumericUpDown numericUpDownGridSize;
        private System.Windows.Forms.NumericUpDown numericUpDownMines;
        private System.Windows.Forms.Label labelMines;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelAll;
    }
}