using System;
using System.Windows.Forms;

namespace MineSweeperHEX {
    public partial class SettingCustomForm : Form {

        public int GridSize { get; private set; } = 8;

        public int Mines { get; private set; } = 16;

        public SettingCustomForm(int gridsize, int mines) {
            InitializeComponent();

            numericUpDownGridSize.Value = gridsize;
            numericUpDownMines.Value = mines;

            ChangedGridSize();
        }

        private void ChangedGridSize() { 
            int gridsize = (int)numericUpDownGridSize.Value;
            int maxmines = Field.Count(gridsize) / 2;

            if (numericUpDownMines.Value > maxmines) {
                numericUpDownMines.Value = maxmines;
            }

            numericUpDownMines.Maximum = maxmines;

            labelAll.Text = $"/ {Field.Count(gridsize)}";
        }

        private void ButtonOK_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;

            GridSize = (int)numericUpDownGridSize.Value;
            Mines = (int)numericUpDownMines.Value;

            Close();
        }

        private void ButtonCancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;            
            Close();
        }

        private void NumericUpDownGridSize_ValueChanged(object sender, EventArgs e) {
            ChangedGridSize();
        }
    }
}
