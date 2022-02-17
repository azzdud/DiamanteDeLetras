using System;

namespace AtividadeDiamante.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letra;
            string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int quantEspacosFora, quantEspacosDentro = 0, metade = 0;

            Console.Write("Digite a letra que ficará no MEIO: ");
            letra = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("");

            char[] charAlfabeto = alfabeto.ToCharArray();

            Console.ForegroundColor = ConsoleColor.DarkRed;

            for (int i = 0; i < charAlfabeto.Length; i++)
            {
                if (charAlfabeto[i] == letra)
                {
                    metade = i;
                }
            }

            quantEspacosFora = (metade);

            for (int i = 0; i <= metade; i++)
            {
                for (int j = 0; j < quantEspacosFora; j++)
                {
                    Console.Write(" ");
                }
                Console.Write(charAlfabeto[i]);

                for (int k = 0; k < quantEspacosDentro; k++)
                {
                    Console.Write(" ");
                }

                if (i != 0)
                {
                    Console.Write(charAlfabeto[i]);
                }
                Console.WriteLine();

                quantEspacosFora = quantEspacosFora - 1;

                if (i == 0)
                {
                    quantEspacosDentro = 1;
                }

                if (i != 0 && i != metade)
                {
                    quantEspacosDentro = quantEspacosDentro + 2;
                }
            }

            quantEspacosFora = 0;

            for (int i = 1; i <= metade; i++)
            {
                quantEspacosFora = quantEspacosFora + 1;
                if (i == metade)
                {
                    quantEspacosDentro = 1;
                }
                if (i != 0 && i != metade)
                {
                    quantEspacosDentro = quantEspacosDentro - 2;
                }


                for (int j = 0; j < quantEspacosFora; j++)
                {
                    Console.Write(" ");
                }

                Console.Write(charAlfabeto[metade - i]);

                for (int k = 0; k < quantEspacosDentro; k++)
                {
                    Console.Write(" ");
                }

                if (i != metade)
                {
                    Console.Write(charAlfabeto[metade - i]);
                }
                Console.WriteLine();

            }
            Console.ReadLine();
        }
    }
}