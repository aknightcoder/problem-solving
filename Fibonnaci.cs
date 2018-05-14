public class Fibonacci {

    private readonly Dictionary<int, int> _fibonnaciByLevel;

    public Fibonacci()
    {
        _fibonnaciByLevel = new Dictionary<int,int>();
    }

    public int GetFibonnaci(int level)
    {
        if (_fibonnaciByLevel.ContainsKey(level))
            return _fibonnaciByLevel[level];

        if (level <= 1)
        {
            _fibonnaciByLevel[level] = level;

            return level;
        }

        _fibonnaciByLevel[level] = GetFibonnaci(level-1)+GetFibonnaci(level-2);

        return _fibonnaciByLevel[level];
    }

    public static void main(string[] args){
        Fibonacci fib = new Fibonacci();
        Console.WriteLine(fib.GetFibonnaci(5));
        Console.ReadKey();
    }
}