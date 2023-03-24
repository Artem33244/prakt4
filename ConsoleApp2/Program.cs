public class Orc
{
    public int GoldCapacity { get; private set; }
    private static int _orcCount = 0;
    private static bool _isFirstOrc = true;
    
    public Orc()
    {
        _orcCount++;

        if (_isFirstOrc)
        {
            GoldCapacity = 2;
            _isFirstOrc = false;
        }
        else if (_orcCount <= 5)
        {
            GoldCapacity = GoldCapacity + 2;
        }
        else
        {
            GoldCapacity = GoldCapacity - 2;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество орков: ");
        int orcCount = int.Parse(Console.ReadLine());
        for (int i = 0; i < orcCount; i++)
        {
            Orc orc = new Orc();
            Console.WriteLine($"Орк {i + 1}: Кол-во переносимого золота - {orc.GoldCapacity}");
        }

        Console.ReadKey();
    }
}