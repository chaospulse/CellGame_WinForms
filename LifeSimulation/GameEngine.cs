using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LifeSimulation
{
    public class GameEngine
    {
        private bool[,] field; //for creating field (gaming field)
        private readonly int rows, cols;
        public int GameBrushSize { get; set; }
        public uint CurrentGeneration { get; private set; }
        //
        // constructor
        //
        public GameEngine(int rows, int cols, int density)
        {
            this.rows = rows;
            this.cols = cols;
            field = new bool[cols, rows];

            Random random = new Random();
            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    field[x, y] = random.Next(density) == 0;
                }
            }
        }
		//
		// event signature
		//
		public event Action<int, int, bool> CellUpdated;
		//
		// count neighbours
		//
		private int CountNeighbours(int x, int y)
        {
            int count = 0;

            for (int i = -1; i < 2; i++)
            {
                for (int j = -1; j < 2; j++)
                {
                    var col = (x + i + cols) % cols;
                    var row = (y + j + rows) % rows;

                    var selfChecking = col == x && row == y;
                    var hasLife = field[col, row];

                    if (hasLife && !selfChecking)
                        count++;
                }
            }
            return count;
        }
        public void NextGeneration()
        {
            //creating relates on results of CountNeighbours
            var newFeild = new bool[cols, rows];

            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    var neighboursCount = CountNeighbours(x, y);
                    var hasLife = field[x, y];

					//static genereation if hasLife
					if (!hasLife && neighboursCount == 3)
                        newFeild[x, y] = true;
					// growth if !hasLife
					else if (hasLife && (neighboursCount < 2 || neighboursCount > 3))
                        newFeild[x, y] = false;
                    else
                        newFeild[x, y] = field[x, y];
                }
            }
            ++CurrentGeneration;
            field = newFeild;
        }
        public bool[,] GetCurrentGeneration()
        {
            var copiedField = new bool[cols, rows];
            for (int x = 0; x < cols; x++)
            {
                for (int y = 0; y < rows; y++)
                {
                    copiedField[x, y] = field[x, y];
                }
            }
            return field;
        }
        private bool CheckBorders(int x, int y) { return x >= 0 && x < cols && y >= 0 && y < rows; }
        //
        // enabled timer
        //
        private void UpdateCell(int x, int y, bool value) 
        { 
            if (CheckBorders(x, y)) 
                field[x, y] = value; 
        }
        public void AddCell(int x, int y)
        {
            for (int i = x - GameBrushSize; i < x + GameBrushSize + 1; i++)
            {
                for (int j = y - GameBrushSize; j < y + GameBrushSize + 1; j++)
                {
                    UpdateCell(i, j, true);
                }
            }
        }
        public void RemoveCell(int x, int y)
        {
            for (int i = x - GameBrushSize; i < x + GameBrushSize + 1; i++)
            {
                for (int j = y - GameBrushSize; j < y + GameBrushSize + 1; j++)
                {
                    UpdateCell(i, j, false);
                }
            }
        }
        //
        // disbled timer
        //
        private void DisabledTimerUpdateCell(int x, int y, bool value) 
        {
            if (CheckBorders(x, y))
                CellUpdated?.Invoke(x, y, value);
        }
        public void DisabledTimerAddCell(int x, int y)
        {
            for (int i = x - GameBrushSize; i < x + GameBrushSize + 1; i++)
            {
                for (int j = y - GameBrushSize; j < y + GameBrushSize + 1; j++)
                {
                    DisabledTimerUpdateCell(i, j, true);
                }
            }
        }
        public void DisabledTimerRemoveCell(int x, int y)
        {
            for (int i = x - GameBrushSize; i < x + GameBrushSize + 1; i++)
            {
                for (int j = y - GameBrushSize; j < y + GameBrushSize + 1; j++)
                {
                    DisabledTimerUpdateCell(i, j, false);
                }
            }
        }
    }
}