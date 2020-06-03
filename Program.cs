using System;

namespace Calculadora2
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadoraCientifica calc = new CalculadoraCientifica();
            Console.WriteLine("Digite uma operação no formato de ex: 12 x 3");
            calc.ControlarMetodos(Console.ReadLine());
            Console.WriteLine("Resultado:"+calc.resultado);

        }
    }
}
