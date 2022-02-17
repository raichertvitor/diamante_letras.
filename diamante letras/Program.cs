using System;

namespace diamante_letras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma letra: ");
            char letraFim = Convert.ToChar(Console.ReadLine().ToUpper());
            char letraIni = 'A';
            int espaço = 0;

            for (letraIni = 'A'; letraIni <= letraFim; letraIni++)
            {
                Console.Write($"{new string(' ', letraFim - letraIni)}{letraIni}");
                if (letraIni != 'A')
                {
                    Console.Write($"{new string(' ', espaço++)}{letraIni}");
                }
                espaço++;
                Console.WriteLine();

            }

            espaço = letraFim - 'A';
            for (letraIni = (char)(letraFim - 1); letraIni >= 'A'; letraIni--)
            {
                espaço--;
                Console.Write($"{new string(' ', letraFim - letraIni)}{letraIni}");
                if (letraIni != 'A')
                {
                    Console.Write($"{new string(' ', espaço * 2 - 1)}{letraIni}");
                }
                Console.WriteLine();
            }
        }
    }
}
