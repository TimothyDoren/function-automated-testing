using test_function;
using static test_function.NewFunction;
foreach(var i in new int[] {int.MinValue,-15, -11, -10, -9, -1, 0, 1, 2, 3, 4, 5, 9, 10, int.MaxValue})
{
    try
    {
        Console.WriteLine(NewFunction.AFunction(i));
    }
    catch
    {
        Console.WriteLine("Nah, threw an Exception!");
    }
}



