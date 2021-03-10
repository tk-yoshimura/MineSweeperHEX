using System;
using System.Drawing;
using System.Windows.Forms;

namespace MineSweeperHEX {
    public partial class MainForm : Form {

        public MainForm() {
            InitializeComponent();
            UpdateStatus();
        }

        private void SetField(int gridsize, int mines) {
            fieldPanel.SetField(gridsize, mines);
            ClientSize = fieldPanel.Size = fieldPanel.MinimumSize;
            ClientSize = new Size(ClientSize.Width, ClientSize.Height + menuStrip.Height + statusStrip.Height);
            UpdateStatus();
        }

        private void UpdateStatus() {
            if (fieldPanel.Field.IsLose) {
                toolStripStatusLabelMines.Text = "You Lose... Please Restart.";
                toolStripStatusLabelDisclose.Text = string.Empty;
            }
            else if (fieldPanel.Field.IsWin) {
                toolStripStatusLabelMines.Text = "You Win. Congratulations!";
                toolStripStatusLabelDisclose.Text = string.Empty;
            }
            else {
                int remaining_mines = Math.Max(0, fieldPanel.Field.MineGenerates - fieldPanel.Field.Frags);

                toolStripStatusLabelMines.Text = $"RemainingMines:{remaining_mines}";

                int remaining_disclose = Math.Max(0, fieldPanel.Field.Unknowns - fieldPanel.Field.MineGenerates);

                toolStripStatusLabelDisclose.Text = $"Disclose:{remaining_disclose}";
            }
        }

        private void ToolStripStart_Click(object sender, EventArgs e) {
            fieldPanel.Initialize();
            UpdateStatus();
        }

        private void ToolStripLevelEasy_Click(object sender, EventArgs e) {
            SetField(gridsize: 8, mines: 16);
        }

        private void ToolStripLevelNormal_Click(object sender, EventArgs e) {
            SetField(gridsize: 10, mines: 32);
        }

        private void ToolStripLevelHard_Click(object sender, EventArgs e) {
            SetField(gridsize: 12, mines: 64);
        }

        private void ToolStripLevelCustom_Click(object sender, EventArgs e) {
            SettingCustomForm form = new SettingCustomForm() {
                StartPosition = FormStartPosition.CenterParent
            };

            form.ShowDialog();

            if (form.DialogResult == DialogResult.OK) {
                SetField(form.GridSize, form.Mines);
            }
        }

        private void FieldPanel_MouseClick(object sender, MouseEventArgs e) {
            UpdateStatus();
        }

        private void ToolStripDiscloseVoid_Click(object sender, EventArgs e) {
            fieldPanel.DiscloseAllVoids();
            UpdateStatus();
        }
    }
}
