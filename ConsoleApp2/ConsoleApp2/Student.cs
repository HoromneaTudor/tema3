using System;
namespace LibrarieEntitati
{
    public class Student
    {
        // date membre private
        string nume;
        int[][] note;
        // contructor implicit
        public Student()
        {
        }

        // constructor cu parametri
        public Student(string _nume)
        {
            nume = _nume;
        }
        public void Setnote(string sir)
        {
            note = new int[4][];
            note[0] = new int[10];
            note[1] = new int[10];
            note[2] = new int[10];
            note[3] = new int[10];
            int i = 0, j = 0;
            string[] _note = sir.Split(' ');
            foreach (var nota in _note)
            {
                if (nota == ",")
                {
                    i++;
                    j = 0;

                }
                else
                {
                    note[i][j] = Convert.ToInt32(nota);
                    j++;

                }
            }
        }
        public void ConversieLaSir()
        {
            Console.WriteLine(nume);
            for (int i = 0; i < 4; i++)
            {
                int n = i;
                n++;
                int j = 0;
                Console.Write("An{0} ", n);
                do
                {
                    Console.Write("{0} ", note[i][j]);
                    j++;
                } while (note[i][j] != 0);
                Console.Write("\n");
            }
        }
        public string[] Meniu()
        {
            string[] Meniu;
            Meniu = new string[6];

            Meniu[0] = "S: Citire note de la tastatura ca un sir de caractere";
            Meniu[1] = "T: Citire note de la tastatura cate o nota pe rand";
            Meniu[2] = "C: Citire note din linia de comanda";
            Meniu[3] = "A: Afisare note";
            Meniu[4] = "I: Info autor";
            Meniu[5] = "X: Iesire";

            return Meniu;

        }
    }
}