using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrici_1
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
                        Console.Write("Numero righe: ");
                        int righe = int.Parse(Console.ReadLine());

                        Console.Write("Numero colonne: ");
                        int colonne = int.Parse(Console.ReadLine());

                        matrice = new int[righe, colonne];

                        for (int i = 0; i < righe; i++)
                        {
                            for (int j = 0; j < colonne; j++)
                            {
                                Console.Write($"Inserisci valore [{i},{j}]: ");
                                matrice[i, j] = int.Parse(Console.ReadLine());
                            }
                        }
                        break;

                    case "2":
                        for (int i = 0; i < matrice.GetLength(0); i++)
                        {
                            for (int j = 0; j < matrice.GetLength(1); j++)
                            {
                                Console.Write(matrice[i, j] + "\t");
                            }
                            Console.WriteLine();
                        }
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
    }
}
