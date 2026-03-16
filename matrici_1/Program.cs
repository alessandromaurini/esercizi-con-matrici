using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrici_sybau
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool continua = true;
            int[,] matrice = null;
            while (continua)
            {
                stampaMenu();
                Console.Write("Scegliere la prossima operazione: ");
                string scelta = Console.ReadLine();
                switch (scelta)
                {
                    case "1":
                        matrice = matrice1();
                        break;

                    case "2":
                        if (matrice != null)
                            matrice2(matrice);
                        else Console.Write("Manca la matrice!");
                        break;

                    case "3":
                        continua = false;
                        break;

                    default:
                        Console.WriteLine("Scelta non valida.");
                        break;
                }
            }
        }
        static void stampaMenu()
        {
            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine("1 - Creazione matrice");
            Console.WriteLine("2 - Stampa matrice");
            Console.WriteLine("0 - ESCI");
        }
        static int[,] matrice1()
        {
            Console.Write("Numero righe: ");
            int r = int.Parse(Console.ReadLine());

            Console.Write("Numero colonne: ");
            int c = int.Parse(Console.ReadLine());

            int [,]m = new int[r, c];

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write($"Inserisci valore [{i},{j}]: ");
                    m[i, j] = int.Parse(Console.ReadLine());
                }
            }
            return m;
        }
        static void matrice2(int[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    Console.Write(m[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
