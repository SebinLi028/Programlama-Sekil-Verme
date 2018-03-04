static void Main(string[] args)
{
    Console.Write("Bir sayi giriniz: ");
    int sayi = int.Parse(Console.ReadLine());
    for (int i = 0; i < sayi; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            if (i > j) Console.Write(" ");
            else for (int a = 0; a < sayi; a++) Console.Write("*");
        }
        Console.WriteLine();
    }
    Console.ReadKey();
}
