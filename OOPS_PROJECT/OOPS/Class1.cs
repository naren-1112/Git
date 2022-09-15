using System;
namespace OOPS
{
    public class Student
            {
                public string Name;
                public int Class;
                public char Section;

                public virtual void gets()
                {
                    Console.WriteLine("Enter the Student Details");
                    Console.WriteLine("-------------------");
                    Console.WriteLine("Enter the Student name");
                    Name = Console.ReadLine();
                    Console.WriteLine("Enter the Class");
                    Class = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the Section");
                    Section = Convert.ToChar(Console.ReadLine());
                }
                public virtual void prints()
                {
                    Console.WriteLine("Print the Student Details");
                    Console.WriteLine(Name);
                    Console.WriteLine(Class);
                    Console.WriteLine(Section);
                }
            }
            public class Teacher : Student
            {
                public string Subject;
                public override void gets()
                {
                    Console.WriteLine("Enter the Teacher Details");
                    Console.WriteLine("-------------------");
                    Console.WriteLine("Enter the Teacher Name");
                    Name = Console.ReadLine();
                    Console.WriteLine("Enter the Class");
                    Class = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the Section");
                    Section = Convert.ToChar(Console.ReadLine());
                    Console.WriteLine("Enter the Subject");
                    Subject = Console.ReadLine();
                }
                public override void prints()
                {
                    Console.WriteLine("Print the Student Details");
                    Console.WriteLine(Name);
                    Console.WriteLine(Class);
                    Console.WriteLine(Section);
                    Console.WriteLine(Subject);
                }
            }
            public class Subject : Student
            {
                public string Subject_Code;
                public override void gets()
                {
                    Console.WriteLine("Enter the Subject Details");
                    Console.WriteLine("-------------------");
                    Console.WriteLine("Enter the Subject Name");
                    Name = Console.ReadLine();
                    Console.WriteLine("Enter the Subject Code");
                    Subject_Code = Console.ReadLine();

                }
                public override void prints()
                {
                    Console.WriteLine("Print the Subject Details");
                    Console.WriteLine(Name);
                    Console.WriteLine(Subject_Code);
                    Console.ReadLine();

                }
            }
        }
 
