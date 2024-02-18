using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using Лаба9;
namespace Лаб9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool tf = true;
            Student a = new Student("ивАн", 17, 4.5);
            Console.WriteLine(a.Show());
            Student b = new Student("ВлАдимир", 20, 4.6);
            Console.WriteLine(b.Show());
            Student c = new Student("Дмитрий", 31, 4.7);
            Console.WriteLine(c.Show());
            Console.WriteLine(a.AgeComparison(b));
            Console.WriteLine(a.GpaComparison(b));
            Console.WriteLine(~a);
            Console.WriteLine((++a).Show());
            Console.WriteLine((int)a);
            tf = a;
            Console.WriteLine((bool)tf);
            Console.WriteLine((a - 2.5).Show());
            Console.WriteLine((a % "СТЕПАН").Show());
            Console.WriteLine("1 chess");
            StudentArray w1 = new StudentArray(5);
            Console.WriteLine(w1.Show());
            Console.WriteLine("2 chess");
            StudentArray w2 = new StudentArray(5);
            Console.WriteLine(w2.Show());
            int index = FoundStudent(w1);
            if (index > 0)
            {
                Console.WriteLine(w1[index].Show());
            }
            else Console.WriteLine(-1); 
            Console.WriteLine(FoundStudent(w1));
            if (index > 0)
            {
                Console.WriteLine(w2[index].Show());
            }
            else Console.WriteLine(-1);
            Console.WriteLine(FoundStudent(w2));
            try
            {
                w2[3] = new Student("АНАТОЛИЙ", 20, 7);
                w2.Show();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            StudentArray w3 = new StudentArray(w1);
            Console.WriteLine(w3.Show());
        }
        public static int FoundStudent(StudentArray v)
        {
            int maxOld = 0;
            int index = -1;
            for (int i = 0; i < v.Length; i++)
            {
                if (v[i].Gpa > 8)
                {
                    if (v[i].Age > maxOld)
                    {
                        maxOld = v[i].Age;
                        index = i;
                    }
                }
            }
            return index;
        }
    }
}