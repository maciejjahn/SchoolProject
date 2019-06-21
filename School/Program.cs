using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            //NEW SCHOOLCLASSES
            SchoolClass classA = new SchoolClass();
            SchoolClass classB = new SchoolClass();
            SchoolClass classC = new SchoolClass();
            SchoolClass classD= new SchoolClass();

            //NEW TEACHERS
            Teacher teacher1 = new Teacher("Adam Wesołowski", "Matematyka", 32, 34);
            Teacher teacher2 = new Teacher("Ewa Matuszewska", "Język polski", 32, 50);
            Teacher teacher3 = new Teacher("Wojciech Olszewski", "Fizyka", 22, 34);
            Teacher teacher4 = new Teacher("Zbigniew Zamachowski", "Filozofia", 40, 40);
                        
            //ADDING TEACHERS TO THE LIST
            Teacher teacher = new Teacher();
            teacher.addTeacher(teacher1);
            teacher.addTeacher(teacher2);
            teacher.addTeacher(teacher3);
            teacher.addTeacher(teacher4);
            teacher.addTeacher(teacher4);//it will result in message "Zbigniew Zamachowski has been already added"
            teacher.printTeacher();

            //ADDING TEACHERS TO CLASSES
            classA.addTeachersToClass(teacher1);
            classA.addTeachersToClass(teacher2);
            classA.addTeachersToClass(teacher3);
            classB.addTeachersToClass(teacher3);
            classB.addTeachersToClass(teacher2);
            classC.addTeachersToClass(teacher1);
            classC.addTeachersToClass(teacher4);
            classD.addTeachersToClass(teacher4);
            
            //NUMBER OF TEACHERS IN CLASS
            classA.numberOfTeachers();
     
            //ADDING STUDENTS TO CLASSES
            classA.addStudent(1, "Maciej Kononowicz");
            classA.addStudent(2, "Adam Zagłębny");
            classA.addStudent(3, "Mirosław Baka");
            //classA.addStudent(3, "Weronika Migdałowska")//adding the same ID will result in error
            
            classA.printStudent(1);//print single student
            classA.printStudent(5);//it wil result in "There is no student with this id" message
            classA.printAllStudents();//print all students from classA


        }
    }
}
