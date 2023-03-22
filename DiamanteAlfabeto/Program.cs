using System.Collections.Specialized;

namespace DiamanteAlfabeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Desenho de diamante com letras do alfabeto!");
                Console.WriteLine();
                Console.Write("Digite uma letra para ser o centro do diamante: ");

                char letraEscolhida = Console.ReadLine().ToUpper()[0];

                int pontoMaisDistante = letraEscolhida - 'A' + 1; 

                for (int linha = 0; linha < pontoMaisDistante; linha++)
                {

                    for (int espacoFora = 0; espacoFora < pontoMaisDistante - linha - 1; espacoFora++)
                        Console.Write(" ");
                   
                    Console.Write((char)('A' + linha)); 

                    if (linha > 0)
                    {
                        for (int espacosDentro = 0; espacosDentro < 2 * linha - 1; espacosDentro++)
                            Console.Write(" ");

                        Console.Write((char)('A' + linha));
                    }
                    
                    Console.WriteLine();
                }

                for (int linha = pontoMaisDistante - 2; linha >= 0; linha--)
                {

                    for (int espacoFora = 0; espacoFora < pontoMaisDistante - linha - 1; espacoFora++)
                        Console.Write(" ");

                    Console.Write((char)('A' + linha)); 

                    if (linha > 0)
                    {
                        for (int espacosDentro = 0; espacosDentro < 2 * linha - 1; espacosDentro++)
                            Console.Write(" ");

                        Console.Write((char)('A' + linha));
                    }

                    Console.WriteLine();
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}

