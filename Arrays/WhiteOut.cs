using System;
namespace problemsolving.Arrays
{
    public class WhiteOut
    {
        private int _rowMax;
        private int _colMax;

        private int[,] _matrix;
        private int[] _rows;
        private int[] _cols;

        public WhiteOut(int rows, int cols)
        {
            _rowMax = rows;
            _colMax = cols;

            _cols = new int[cols];
            _rows = new int[rows];

            InitializeMatrix();
        }

        public void PrintMatrix()
        {
            Console.WriteLine();
            for (var i = 0; i < _rowMax; i++)
            {
                for (var j = 0; j < _colMax; j++)
                    Console.Write("{0} ", _matrix[i, j]);

                Console.WriteLine();
            }
        }

        public void WhiteOutRowCols()
        {
            for (var i = 0; i < _rowMax; i++)
            {
                for (var j = 0; j < _colMax; j++){
                    if (_matrix[i,j]== 0)
                    {
                        _cols[j] = 1;
                        _rows[i] = 1;

                    }
                }
            }

            for (int i = 0; i < _rows.Length; i++){

                for (int j = 0; j < _colMax; j++)
                {
                    if (_rows[i] == 1 || _cols[j] == 1)
                        _matrix[i, j] = 0; 
                }
            }
        }

        public void SetFalse(int r, int c)
        {
            _matrix[r, c] = 0;
        }

        private void InitializeMatrix()
        {
            _matrix = new int[_rowMax, _colMax];

            for (var i = 0; i < _rowMax; i++){
                for (var j = 0; j < _colMax; j++)
                    _matrix[i, j] = 1;
            }

        }
    }
}
