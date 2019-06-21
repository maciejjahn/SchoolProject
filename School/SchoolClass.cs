using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class SchoolClass
    {
        private Dictionary<int, string> students = new Dictionary<int, string>();
        private int counter = 0;

        public void addStudent(int id, string value)
        {
            students.Add(id, value);
        }
        
        public void printStudent(int id)
        {
            if (students.ContainsKey(id))
            {
                Console.WriteLine(students[id]);
            }
            else
            {
                Console.WriteLine("There is no student with this id");
            }
                       
        }

        public void printAllStudents()
        {
            foreach (KeyValuePair<int, string> item in students)
            {
                Console.WriteLine("Numer: {0}, Dane: {1}", item.Key, item.Value);
            }
        }

        public void addTeachersToClass(Teacher teacher)
        {
            counter++;
        }

        public void numberOfTeachers()
        {
           Console.WriteLine("Number of teachers in this class - " + counter);
        }
    }
}
