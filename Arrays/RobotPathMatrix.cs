using System.Collections.Generic;

namespace problemsolving.Arrays
{
    public class RobotPathMatrix
    {
        private bool[,] _matrix;

        private readonly int _height;

        private readonly int _width;

        private readonly List<string> _paths;

        public RobotPathMatrix(int height, int width)
        {
            _height = height;

            _width = width;

            _matrix = new bool[_height, _width];

            _paths = new List<string>();

            Initialize();
        }

        public void FindPath(string path = "", int i = 0, int j = 0)
        {
            if (i >= _height || j >= _width || IsBlocked(i, j)) return;

            path += string.Format("({0} -> {1}) ", j, i);

            if (i == _height - 1 && j == _width - 1)
            {
                _paths.Add(path);

                return;
            }

            FindPath(path, i, j + 1);
            FindPath(path, i + 1, j);
        }

        public void AddRoadBlock(int i, int j)
        {
            _matrix[i, j] = false;
        }

        public List<string> GetPaths()
        {
            return _paths;
        }

        private void Initialize()
        {
            for (int i = 0; i < _height; i++)
            {
                for (int j = 0; j < _width; j++){
                    _matrix[i, j] = false;
                }
            }
        }

        private bool IsBlocked(int i, int j){
            return _matrix[i, j];
        }
    }
}
