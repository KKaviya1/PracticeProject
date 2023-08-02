using Student;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Enter student information:");
                Student student1 = GetStudentFromUserInput();
                DataStorage.Instance.AddStudent(student1);

                Console.WriteLine("\nEnter teacher information:");
                Teacher teacher1 = GetTeacherFromUserInput();
                DataStorage.Instance.AddTeacher(teacher1);

                Console.WriteLine("\nEnter subject information:");
                Subject subject1 = GetSubjectFromUserInput();
                DataStorage.Instance.AddSubject(subject1);

                Console.WriteLine("\nEnter the class and section to display students:");
                string classAndSectionInput = Console.ReadLine();
                List<Student> studentsInClass = DataStorage.Instance.GetStudentsByClassAndSection(classAndSectionInput);
                Console.WriteLine("\nStudents in class " + classAndSectionInput + ":");
                foreach (var student in studentsInClass)
                {
                    Console.WriteLine($"{student.Name}");
                }

                Console.WriteLine("\nEnter the teacher name to display subjects:");
                string teacherNameInput = Console.ReadLine();
                List<Subject> subjectsTaughtByTeacher = DataStorage.Instance.GetSubjectsTaughtByTeacher(teacherNameInput);
                Console.WriteLine("\nSubjects taught by " + teacherNameInput + ":");
                foreach (var subject in subjectsTaughtByTeacher)
                {
                    Console.WriteLine($"{subject.Name} - {subject.SubjectCode}");
                }
            }

            static Student GetStudentFromUserInput()
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Class and Section: ");
                string classAndSection = Console.ReadLine();

                return new Student { Name = name, ClassAndSection = classAndSection };
            }

            static Teacher GetTeacherFromUserInput()
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Class and Section: ");
                string classAndSection = Console.ReadLine();

                return new Teacher { Name = name, ClassAndSection = classAndSection };
            }

            static Subject GetSubjectFromUserInput()
            {
                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Subject Code: ");
                string subjectCode = Console.ReadLine();

                Console.Write("Teacher Name: ");
                string teacherName = Console.ReadLine();

                return new Subject { Name = name, SubjectCode = subjectCode, Teacher = new Teacher { Name = teacherName } };
            }
        }

    }


