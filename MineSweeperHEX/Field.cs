using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using HexGrid;

namespace MineSweeperHEX {
    public class Field {
        public static int Count(int size) => checked(1 + size * (size - 1) / 2 * 6);

        private readonly GridMapping mapping;
        private readonly Random random;
        
        public HexaGrid Grid  { get; private set; }
        public int Size => Grid.Size;
        public int MineGenerates { get; private set; }
        public CellState[] MineState { get; private set; }
        public CellState[] DisplayState { get; private set; }

        public Field(int size, int mines, Random random) {
            if (size < 1) {
                throw new ArgumentException(nameof(size));
            }

            int count = Count(size);

            if (mines < 1 || mines * 2 >= count) {
                throw new ArgumentException(nameof(mines));
            }

            HexaGrid grid = new HexaGrid(size);
            if (grid.Count != count) {
                throw new Exception(nameof(count));
            }

            this.Grid = grid;
            this.mapping = new GridMapping(grid);

            this.random = random;
            
            this.MineGenerates = mines;

            Initialize();
        }

        public int Unknowns {
            get {
                int unknowns =
                    DisplayState.Where(
                        (state) => state == CellState.Unknown || state == CellState.Fraged || state == CellState.Locked)
                    .Count();

                return unknowns;
            }
        }

        public int Frags { 
            get {
                int frags =
                    DisplayState.Where(
                        (state) => state == CellState.Fraged)
                    .Count();

                return frags;
            }
        }

        public bool Cleared => MineGenerates >= Unknowns;

        public bool IsWin => Cleared && !DisplayState.Any((state) => state == CellState.Bomb || state == CellState.Mine);

        public bool IsLose => DisplayState.Any((state) => state == CellState.Bomb);

        public bool IsInitialized => DisplayState.All((state) => state == CellState.Unknown);

        public void Initialize() {
            this.DisplayState = Enumerable.Repeat(CellState.Unknown, Count(Size)).ToArray();
            
            this.MineState =
                Enumerable.Repeat(CellState.Mine, MineGenerates)
                .Concat(Enumerable.Repeat(CellState.Void, Count(Size) - MineGenerates))
                .OrderBy((_) => random.Next()).ToArray();

            List<int> safe_list = MineState
                .Select((state, index) => index)
                .Where((index) => MineState[index] == CellState.Void).ToList(); 

            while(safe_list.Count > 0){
                int killmines = 0;

                foreach (Cell cell in Grid.Cells) {
                    int detects =
                        cell.IndexList.Select((link) => MineState[link.index])
                        .Where((state) => state == CellState.Mine)
                        .Count();

                    int links = cell.Links;

                    if (detects >= links) {
                        MineState[cell.IndexList.ToArray()[random.Next(links)].index] = CellState.Void;
                        killmines++;
                    }
                }

                if (killmines <= 0) {
                    break;
                }

                while (killmines > 0 && safe_list.Count > 0) {
                    int index = safe_list[random.Next(safe_list.Count)];

                    MineState[index] = CellState.Mine;

                    safe_list.Remove(index);
                    
                    killmines--;
                }

                if (killmines > 0) { 
                    List<int> void_list = MineState
                        .Select((state, index) => index)
                        .Where((index) => MineState[index] == CellState.Void).ToList(); 

                    while (killmines > 0 && void_list.Count > 0) {
                        int index = void_list[random.Next(void_list.Count)];

                        MineState[index] = CellState.Mine;

                        void_list.Remove(index);
                    
                        killmines--;
                    }

                    if (killmines > 0) {
                        throw new Exception("Faild Initialize.");
                    }

                    break;
                }
            }

            int mines = MineState.Where((state) => state == CellState.Mine).Count();

            if (mines != MineGenerates) { 
                throw new Exception("Faild Initialize.");
            }

            foreach (Cell cell in Grid.Cells) {
                int detects =
                    cell.IndexList.Select((link) => MineState[link.index])
                    .Where((state) => state == CellState.Mine)
                    .Count();
                
                if (MineState[cell.Index] == CellState.Mine) {
                    continue;
                }

                if (detects == 0) {
                    continue;
                }

                switch (detects) {
                    case 1:
                        MineState[cell.Index] = CellState.Detect1;
                        break;
                    case 2:
                        MineState[cell.Index] = CellState.Detect2;
                        break;
                    case 3:
                        MineState[cell.Index] = CellState.Detect3;
                        break;
                    case 4:
                        MineState[cell.Index] = CellState.Detect4;
                        break;
                    case 5:
                        MineState[cell.Index] = CellState.Detect5;
                        break;
                    case 6:
                        MineState[cell.Index] = CellState.Detect6;
                        break;
                }
            }
        }

        public Cell Map(int x, int y) {
            int index = mapping[x, y];
            return index >= 0 ? Grid[index] : Cell.Invalid;
        }

        public void Disclose(int x, int y) {
            int cell_index = mapping[x, y];

            if (cell_index == Cell.None) {
                return;
            }

            if (IsWin || IsLose) {
                return;
            }

            if (DisplayState[cell_index] != CellState.Unknown) {
                return;
            }

            while (MineState[cell_index] == CellState.Mine && IsInitialized) {
                Initialize();
            };

            if (MineState[cell_index] == CellState.Mine) {
                DiscloseAllMines();
                DisplayState[cell_index] = CellState.Bomb;
            }
            else {
                DiscloseVoids(cell_index);
            }
        }

        public void DiscloseAllMines() {
            for (int i = 0; i < Grid.Count; i++) {
                if (MineState[i] == CellState.Mine) {
                    DisplayState[i] = MineState[i];
                }
            }
        }

        public void DiscloseVoids(int cell_index) {
            List<int> searched_indexes = new(new int[] { Cell.None, cell_index });
            Stack<int> searching_indexes = new();

            searching_indexes.Push(cell_index);

            while (searching_indexes.Count > 0) {
                int searching_index = searching_indexes.Pop();

                if (MineState[searching_index] != CellState.Mine && DisplayState[searching_index] != CellState.Fraged) {
                    DisplayState[searching_index] = MineState[searching_index];
                }
                if (MineState[searching_index] != CellState.Void) {
                    continue;
                }

                foreach ((_, int linked_index) in Grid[searching_index].IndexList) {
                    if (!searched_indexes.Contains(linked_index)) {
                        searched_indexes.Add(linked_index);
                        searching_indexes.Push(linked_index);
                    }
                }
            }
        }

        public void DiscloseAllVoids() {
            for (int i = 0; i < Grid.Count; i++) {
                if (MineState[i] == CellState.Void) {
                    DiscloseVoids(i);
                }
            }
        }

        public void Lock(int x, int y) { 
            int cell_index = mapping[x, y];

            if (cell_index == Cell.None) {
                return;
            }

            if (IsWin || IsLose) {
                return;
            }

            if (DisplayState[cell_index] == CellState.Unknown) {
                DisplayState[cell_index] = CellState.Fraged;
            }
            else if (DisplayState[cell_index] == CellState.Fraged) {
                DisplayState[cell_index] = CellState.Locked;
            }
            else if (DisplayState[cell_index] == CellState.Locked) {
                DisplayState[cell_index] = CellState.Unknown;
            }
            else if(DisplayState[cell_index] != CellState.Void) {
                IEnumerable<int> links = Grid.Cells[cell_index].IndexList.Select((link) => link.index);

                IEnumerable<int> unknowns = links
                    .Where((index) => {
                        CellState state = DisplayState[index];
                        return state == CellState.Unknown || state == CellState.Fraged || state == CellState.Locked;
                    });

                IEnumerable<int> mines = links
                    .Where((index) => {
                        CellState state = MineState[index];
                        return state == CellState.Mine;
                    });
                
                if (unknowns.Count() == mines.Count()) {
                    foreach (int index in unknowns) {
                        DisplayState[index] = CellState.Fraged;
                    }
                }
            }
        }

        public void LockConfirmedMines() {
            if (IsWin || IsLose) {
                return;
            }

            for (int i = 0; i < Grid.Count; i++) {
                if (DisplayState[i] == CellState.Unknown || DisplayState[i] == CellState.Fraged
                    || DisplayState[i] == CellState.Locked || DisplayState[i] == CellState.Void) {

                    continue;
                }

                IEnumerable<int> links = Grid.Cells[i].IndexList.Select((link) => link.index);

                IEnumerable<int> unknowns = links
                    .Where((index) => {
                        CellState state = DisplayState[index];
                        return state == CellState.Unknown || state == CellState.Fraged || state == CellState.Locked;
                    });

                IEnumerable<int> mines = links
                    .Where((index) => {
                        CellState state = MineState[index];
                        return state == CellState.Mine;
                    });
                
                if (unknowns.Count() == mines.Count()) {
                    foreach (int index in unknowns) {
                        DisplayState[index] = CellState.Fraged;
                    }
                }
            }
        }
    }
}
