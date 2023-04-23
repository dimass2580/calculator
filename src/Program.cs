namespace calculator
{
    internal class Program
    {
        static SuperCalcLib.BasicOperations _op = new();
        static void Main(string[] args)
        {
            Console.Write("Ввведите операцию (+ или -):");
            var operation = Console.ReadLine();
            Console.Write("Ввведите первое число:");
            if ( int.TryParse(Console.ReadLine(), out var a))
            {
                Console.Write("Ввведите второе число:");
                if (int.TryParse(Console.ReadLine(), out var b))
                {
                     switch (operation){
                        case "+":  Summ(a, b); break;
                        case "-": Raznost(a,b); break;
                        default:  HZ(); break;
                    }
                }
            }
        }
        static void Summ(int a, int b)
        {
            var res = _op.Summ(a, b);
            Console.WriteLine(res);
        }
        static void Raznost(int a, int b)
        {
            var res = _op.Razmost(a, b);
            Console.WriteLine(res);
        }
        static void HZ()=> Console.WriteLine("ХЗ");
        
    }
}