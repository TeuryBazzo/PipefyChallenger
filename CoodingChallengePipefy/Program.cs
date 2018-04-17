using System;
using System.Text.RegularExpressions;

namespace CoodingChallengePipefy
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Desafio Pipefy");

            while (true)
            {
                Console.Write("Digite o numero que deseja : ");
                var key = Console.ReadLine();

                var numberIsValid = ValidKey(key);

                if (!numberIsValid)
                {
                    Console.WriteLine("Numero invalido");
                    continue;
                }

                Console.WriteLine("Saida :");

                Saida(Convert.ToInt32(key));
            }

        }

        private static void Saida(int numero)
        {
            var numeroConcatenado = string.Empty;

            for (int i = 0; i < numero; i++)
            {
                numeroConcatenado = ConcatenaNumero(numero, numeroConcatenado);
            }

            for (int i = 0; i < numero; i++)
            {
                Console.WriteLine(numeroConcatenado);

                if (numero == 1) return;

                ImprimeOsNumerosNaColuna(i, numero);
            }
        }

        private static string ConcatenaNumero(int numero, string numeroConcatenado)
        {
            return string.Concat(numero.ToString(), numeroConcatenado);
        }

        private static void ImprimeOsNumerosNaColuna(int coluna, int numero)
        {
            var backspace = AdicionaBlankSpace(coluna);

            for (int i = 0; i < numero; i++)
            {
                Console.WriteLine(backspace + numero);
            }
        }

        private static string AdicionaBlankSpace(int p)
        {
            var blank = string.Empty;

            for (int i = 0; i < p; i++)
            {
                blank = string.Concat(" ", blank);
            }

            return blank;
        }

        private static bool ValidKey(string key)
        {
            return Regex.IsMatch(key, "^[0-9]$");
        }

    }

}
