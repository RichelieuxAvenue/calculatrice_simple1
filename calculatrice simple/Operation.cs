namespace calculatrice_simple;

public class Operation
{
    public static int addition(int a, int b)
    {
        return a + b;
    }

    public static int soustraction(int a, int b)
    {
        return a - b;
    }

    public static int multiplication(int a, int b)
    {
        return a * b;
    }

    public static int division(int a, int b)
    {
        if (b < 0)
        {
            Console.WriteLine("ERREUR division par 0");
            return -1;
        }
        return a / b;
    }
}