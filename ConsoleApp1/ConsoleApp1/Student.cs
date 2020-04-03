using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidentaStudenti2
{
    public class Student
    {
     
        string nume;
        int[,] note;


    
        public Student()
        {
        }

        public Student(string _nume)
        {
            nume = _nume;
        }

        public void SetNote(string sirNote)
        {
            note = new int[4, 15];
 
            string[] notes = new string[4];
            notes = sirNote.Split(',');
            string[] temp;
            int i = 0;
            foreach (string notari in notes)
            {
                temp = notari.Split(' ');

                for (int j = 0; j < temp.Length; j++)
                {
                    Int32.TryParse(temp[j], out note[i, j]);
                   
                }
                i++;

            }
        }

        public void SetNote(int[,] _note)
        {
            note = new int[4, 15];
            note = _note;

        }
        public void ConversieLaSir()
        {
            string sNote = "Nu exista (Nu ati apelat metoda **setNote**)";
            if (note != null)
            {
                sNote = string.Join(",", note);
            }
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Notele pe anul {0} sunt: ", i + 1);
                for (int j = 0; j < 15; j++)
                    Console.Write("{0}", note[i, j]);
                Console.WriteLine();
            }
            
        }
        
        

    }
}