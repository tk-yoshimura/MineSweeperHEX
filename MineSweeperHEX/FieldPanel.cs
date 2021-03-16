using HexGrid;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MineSweeperHEX {
    public class FieldPanel : Control {
        public static Size CellSize => new(28, 24);
        public static int CellOverrap => 8; 
        public static double CellRadius => CellSize.Width / 2 - 1;
        public override Size MinimumSize => new Size(
            checked((Field.Grid.MapWidth + 1) * CellSize.Width / 2), 
            checked(Field.Grid.MapHeight * CellSize.Height + CellOverrap)
        );

        public Field Field { private set; get; }

        public FieldPanel() {
            SetField();

            MouseClick += FieldPanel_MouseClick;
            Paint += FieldPanel_Paint;

            DoubleBuffered = true;
        }

        public void Initialize() {
            Field.Initialize();
            Invalidate();
        }

        public void SetField(int size = 8, int mines = 16) {
            Field = new Field(size, mines, new Random());
            Invalidate();
        }

        public void DiscloseAllVoids() {
            Field.DiscloseAllVoids();
            Invalidate();
        }

        public void LockConfirmedMines() {
            Field.LockConfirmedMines();
            Invalidate();
        }

        private void FieldPanel_MouseClick(object sender, MouseEventArgs e) {
            int px = e.X * 2 / CellSize.Width, py = e.Y / CellSize.Height;
            Cell cell = Field.Map(px, py);

            if (cell.Index < 0) {
                return;
            }

            int ex = e.X - cell.X * CellSize.Width / 2, ey = e.Y - cell.Y * CellSize.Height;

            double dx = ex - CellSize.Width * 0.5, dy = ey - (CellSize.Height + CellOverrap) * 0.5;

            if (dx * dx + dy * dy > CellRadius * CellRadius) {
                return;
            }

            if (e.Button == MouseButtons.Right) {
                Field.Lock(px, py);
            }
            else if (e.Button == MouseButtons.Left) {
                Field.Disclose(px, py);
            }

            Invalidate();
        }

        private void FieldPanel_Paint(object sender, PaintEventArgs e) {
            for (int i = 0; i < Field.Grid.Count; i++) {
                Cell cell = Field.Grid[i];
                CellState state = Field.DisplayState[i];

                Image image = CellImageTable.Image(state);

                e.Graphics.DrawImage(image, cell.X * CellSize.Width / 2, cell.Y * CellSize.Height, image.Width, image.Height);
            }
        }
    }
}
