using System;

namespace Aula09Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculadoraCientifica calc = new CalculadoraCientifica();
            Console.WriteLine("Digite uma operação no formato do exemplo: 10 x 5");
            calc.ControlarMetodos( Console.ReadLine() );

            Console.WriteLine("Resultado= "+calc.resultado);

            Console.WriteLine("Resultado= "+calc.resultado);
        }
    }
}
