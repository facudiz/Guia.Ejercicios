using Billetes;
namespace Ejercicio20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Euro e = 100;
            Dolar d = 500;

            Euro auxEuro = e + d;
            Console.WriteLine(auxEuro.getCantidad());
        }
    }
}