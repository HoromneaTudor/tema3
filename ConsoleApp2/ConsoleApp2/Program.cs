﻿using LibrarieEntitati;
using System;


namespace EvidentaStudenti3
{
    class Program
    {
        static void Main(string[] args)
        {
            string optiune;
            Student s = new Student("Tudor");
            while (true)
            {

                Console.WriteLine("S: Citire note de la tastatura ca un sir de caractere");
                Console.WriteLine("T: Citire note de la tastatura cate o nota pe rand");
                Console.WriteLine("C: Citire note din linia de comanda");
                Console.WriteLine("A: Afisare note");
                Console.WriteLine("I: Info autor");
                Console.WriteLine("X: Iesire");
                Console.WriteLine();


                Console.Write("Dati optiunea:");
                    optiune = Console.ReadLine();

                

                switch (optiune.ToUpper())
                {
                    case "S":

                        string note;
                        Console.WriteLine("Dati notele separate prin spatiu:");
                        note = Console.ReadLine();

                        //s.SetNote(note);
                        break;
                    case "A":
                        //Console.WriteLine(s.ConversieLaSir());
                        s.ConversieLaSir();
                        break;
                    case "T":
                        Console.Write("Dati numarul de note:");
                        int numar = Convert.ToInt32(Console.ReadLine());

                        int[] noteINT = new int[numar];
                        for (int i = 0; i < numar; i++)
                        {
                            Console.Write("Nota numarul {0}:", i);
                            noteINT[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        //s.SetNote(noteINT);
                        break;
                    case "C":
                        // s.SetNote(args);
                        s.Setnote("1 2 3 4 5 , 4 5 6 7 8 , 3 4 5");

                        // Console.WriteLine(s.ConversieLaSir());
                        break;
                    case "X":
                        Environment.Exit(0);
                        break;
                    case "I":
                        Console.WriteLine("Horomnea Tudor 3122A");
                        break;
                    default:
                        Console.WriteLine("Optiune inexistenta.");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
                
            }
        }
    }
}
        
    
