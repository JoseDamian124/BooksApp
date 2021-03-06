﻿using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            char lectura;
            do
            {
                Console.WriteLine("[A]gregar | [M]odificar autor | [E]liminar | [V]er autores | [S]alir ");
                Console.Write("Selecciona una opcion: ");
                lectura = Char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();
                switch(lectura)
                {
                    case 'A':
                        AddAuthor();
                        break;
                    case 'V':
                        ShowAuthor();
                        break;
                    case 'M':
                        ModifyAuthor();
                        break;
                    case 'E':
                        DeleteAuthor();
                        break;
                    case 'S':
                        Console.WriteLine("Adios. Programa Finalizado");
                        break;
                }

                Console.WriteLine();
                
            } while (lectura != 'S');
            Console.WriteLine("");
        }

        private static void DeleteAuthor()
        {
            throw new NotImplementedException();
        }

        private static void ModifyAuthor()
        {
            throw new NotImplementedException();
        }

        private static void ShowAuthor()
        {
            Console.WriteLine("Mostrando autores..."); 
        }

        private static void AddAuthor()
        {
            Console.WriteLine("Agregando autores...");
        }
    }
}
