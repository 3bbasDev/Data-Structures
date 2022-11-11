internal class Program
{
    public static int x = 1;
    private static void Main(string[] args)
    {
        StackRun();
    }

    private static void StackRun()
    {
        Stack.Stack<int> stack = new(10);

        stack.Puch(1);
        stack.Puch(2);
        stack.Puch(3);
        stack.Puch(4);
        stack.Pop();
        stack.GetTop(ref x);
        stack.Puch(9);
        stack.Print();
    }
}