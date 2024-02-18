using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Лаба9
{
    public class StudentArray
    {
        static Random rnd = new Random();

        Student[] chess;

        public int Length
        {
            get { return chess.Length; }
        }
        public StudentArray (int length)
        {
            chess = new Student[length];
            for (int i = 0; i < length; i++)
            {
                chess[i] = new Student("Святослав", rnd.Next(18, 27), rnd.Next(0, 10) + rnd.NextDouble());
            }
        }
        public StudentArray (StudentArray other)
        {
            this.chess = new Student[other.Length];
            for (int i = 0; i < other.Length; i++)
            {
                this.chess[i] = new Student(other.chess[i]);
            }
        }
        public string Show()
        {
            string chessShow = "";
            for (int i = 0; i < chess.Length; i++)
            {
                chessShow += chess[i].Show() + "\n";
            }
            return chessShow;
        }

        public Student this[int index]
        {
            get
            {
                if (0 <= index && index < chess.Length)
                {
                    return chess[index];
                }
                else
                {
                    throw new Exception("Индекс выходит за пределы коллекции");
                }
            }
            set
            {
                if (0 <= index && index < chess.Length)
                {
                    chess[index] = value;
                }
                else
                {
                    Console.WriteLine("Индекс выходит за пределы коллекции");
                }
                
            }
        }
    } 
}