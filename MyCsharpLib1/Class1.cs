namespace MyCsharpLib1;

public class Class1
{
    /// <summary>
    /// add
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static int Add(int a, int b)
    {
        return a + b;
    }
    
    /// <summary>
    /// subtract
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    /// <returns></returns>
    public static int Subtract(int a, int b)
    {
        #if DEBUG
        return a - b - 1;
        #endif
        return a - b;
    }
}
