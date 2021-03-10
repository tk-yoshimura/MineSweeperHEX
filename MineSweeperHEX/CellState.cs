using MineSweeperHEX.Properties;
using System.Collections.Generic;
using System.Drawing;

namespace MineSweeperHEX {
    public enum CellState {
        Void,
        Detect1,
        Detect2,
        Detect3,
        Detect4,
        Detect5,
        Detect6,
        Mine,
        Locked,
        Fraged,
        Unknown,
        Bomb
    }

    public static class CellImageTable {
        static Dictionary<CellState, Bitmap> table = new Dictionary<CellState, Bitmap> {
            { CellState.Void, Resources.cell_void },
            { CellState.Detect1, Resources.cell_detect1 },
            { CellState.Detect2, Resources.cell_detect2 },
            { CellState.Detect3, Resources.cell_detect3 },
            { CellState.Detect4, Resources.cell_detect4 },
            { CellState.Detect5, Resources.cell_detect5 },
            { CellState.Detect6, Resources.cell_detect6 },
            { CellState.Mine, Resources.cell_mine },
            { CellState.Locked, Resources.cell_locked },
            { CellState.Fraged, Resources.cell_frag },
            { CellState.Unknown, Resources.cell_unknown },
            { CellState.Bomb, Resources.cell_bomb },
        };

        public static Bitmap Image(CellState state) => table[state];
    }
}
