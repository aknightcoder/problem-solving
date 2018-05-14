using System;

namespace problemsolving.Arrays
{
    public class RoboToPath
    {
        private readonly int _x;

        private readonly int _y;

        public RoboToPath(int x, int y)
        {
            _x = x;
            _y = y;
        }

        public void FindPaths(int i, int j, string path)
        {
            if (i > _x || j > _y) return;

            path += string.Format("({0} -> {1}) ", j, i);

            if (i == _x || j == _y)
            {
                Console.WriteLine(path);
                return;
            }

            FindPaths(i + 1, j, path);
            FindPaths(i, j + 1, path);
        }
    }
}
