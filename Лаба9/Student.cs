using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Лаба9
{
    public class Student
    {
        private string name;
        private int age;
        private double gpa;
        public string Name
        {
            get { return name; } 
            set
            {
                if (value != null)
                {
                    name = value;
                }
            }
        }
        public int Age
        {
            get { return age; } 
            set
            {
                if (value >= 0)
                {
                    age = value;
                }
            }
        }
        public double Gpa
        {
            get { return gpa; }
            set
            {
                if (value >= 0)
                {
                    gpa = value;
                }
            }
        }
        public Student() : this ("Альберт", 18, 4.5) { }
        public Student(string name, int age, double gpa)
        {
            Name = name;
            Age = age;
            Gpa = gpa;
        }
        public Student(Student s)
        {
            Name = s.Name;
            Age = s.Age;
            Gpa = s.Gpa;
        }
        public string Show()
        {
            return ($"{Name}, {Age}, {Gpa}");
        }
        public string AgeComparison(Student j)
        {
            if (age < j.age)
            {
                return ($"{name} младше {j.name}");
            }
            else if (age > j.age)
            {
                return ($"{name} старше {j.name}");
            }
            else return ($"{name} и {j.name} ровестники");
        }
        public string GpaComparison(Student j)
        {
            if (gpa < j.gpa)
            {
                return ($"GPA студента {name} ниже GPA студента {j.name}");
            }
            else if (gpa > j.gpa)
            {
                return ($"GPA студента {name} выше GPA студента {j.name}");
            }
            else return ($"GPA студента {name} и GPA студента {j.name} равны");
        }
        public static string operator ~(Student name)
        {
            string _name = name.Name.ToLower();
            char[] letters = _name.ToCharArray();
            letters[0] = char.ToUpper(letters[0]);
            string combinedString = string.Join("", letters.ToArray());
            _name = combinedString;
            return _name;
        }
        public static Student operator ++(Student z)
        {
            Student _age = new Student(z);
            _age.Age++;
            return _age;
        }
        public static explicit operator int(Student course)
        {
            if (course.age == 18)
            {
                return 1;
            }
            else if (course.age == 19)
            {
                return 2;
            }
            else if (course.age == 20)
            {
                return 3;
            }
            else if (course.age == 21)
            {
                return 4;
            }
            else return -1;
        }
        public static implicit operator bool(Student grades)
        {
            if (grades.gpa < 6)
            {
                return true;
            }
            else return false;
        }
        public static Student operator -(Student s, double d)
        {
            Student studentNew = new Student(s);
            studentNew.Gpa -= d;
            return studentNew;
        }
        public static Student operator %(Student s, string newName)
        {
            Student studentNew = new Student(s);
            studentNew.Name = newName;
            return studentNew;
        }
        public static Student operator %(string newName, Student s)
        {
            Student studentNew = new Student(s);
            studentNew.Name = newName;
            return studentNew;
        }
    }
}