using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Teacher : SchoolClass
    {
        private String name;       
        private String subjectName;
        private int numberOfLessons;
        private int numberOfExcercises;
        private List<Teacher> teachers = new List<Teacher>();

        public Teacher(string name, string subjectName, int numberOfLessons, int numberOfExcercises)
        {
            this.name = name;
            this.subjectName = subjectName;
            this.numberOfLessons = numberOfLessons;
            this.numberOfExcercises = numberOfExcercises;
        }
        public Teacher() {}
               

        public void addTeacher(Teacher teacher)
        {
            if (!teachers.Contains(teacher))
            {
                teachers.Add(teacher);

            }
            else
            {
                Console.WriteLine(teacher.name + " has been already added");
            }
        }

        public override string ToString()
        {
            return  name + " Przedmiot: " + subjectName + " Liczba lekcji: " + numberOfLessons + " Liczba zadań: " + numberOfExcercises;
        }

        public void printTeacher()
        {
            foreach(Teacher a in teachers){
                System.Console.WriteLine(a);
            }
        }
    }
}
