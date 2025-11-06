namespace uitvragen;

class Program
{
    static void Main(string[] args)
    {
        double[] percentage = new double[] { 0.5, 0.75, 1.25, 5.65, 9.99 };
        double temp = percentage[3];
        Console.WriteLine(temp);

        temp = percentage[1];
        Console.WriteLine(temp);

        temp = percentage[2];
        Console.WriteLine(temp);
    }
}
