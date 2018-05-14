using System;

namespace problemsolving.Arrays
{
    public class RotateMatrix
    {
        private readonly int _size;

        private readonly int[,] _matrix;

        public RotateMatrix(int size)
        {
            _size = size;

            _matrix = new int[_size, _size];

            InitializeMatrix();
        }

        public void Rotate()
        {
            for (int j = 0; j < _size; j++)
            {
                var layer = j;
                var last = _size - 1 - layer;

                for (var i = layer; i < last; i++){
                    var left = _matrix[layer, i];
                    var offset = i - layer;

                    _matrix[layer, i] = _matrix[i, last]; //right -> top
                    _matrix[i, last] = _matrix[last, last - offset]; //bottom -> right
                    _matrix[last, last - offset] = _matrix[last - offset, layer]; //left -> bottom
                    _matrix[last - offset, layer] = left;
                }
            }
        }

        public void PrintMatrix()
        {
            for (int i = 0; i < _size; i++)
            {
                for (int j = 0; j < _size; j++)
                {
                    Console.Write("{0} ", _matrix[i, j]);
                }

                Console.WriteLine();
            }
        }

        private void InitializeMatrix()
        {
            var counter = 1;
            for (int i = 0; i < _size; i++)
            {
                for (int j = 0; j < _size; j++) 
                {
                    _matrix[i, j] = counter++;
                }
            }
        }
    }
}
