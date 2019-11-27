
using System;
using System.Collections.Generic;
using System.Linq;

namespace StBase
{
    public class Program
    {
        public static void Main(string[] args)
        {
            using (StudentContext db = new StudentContext())
            {
                Student student1 = new Student { Surname = "Бестаченко", Name = "Єгор", Position = "Project Manager" };
                Student student2 = new Student { Surname = "Балко", Name = "Владислав", Position = "Developer" };
                Student student3 = new Student { Surname = "Янiшевський", Name = "Вiктор", Position = "Developer" };
                Student student4 = new Student { Surname = "Шабатура", Name = "Тарас", Position = "UI/UX Designer" };
                Student student5 = new Student { Surname = "Ягнищак", Name = "Назар", Position  = "Business Analyst" };
                Student student6 = new Student { Surname = "Заєць", Name = "Iлля", Position = "Business Analyst" };

                db.Students.Add(student1);
                db.Students.Add(student2);
                db.Students.Add(student3);
                db.Students.Add(student4);
                db.Students.Add(student5);
                db.Students.Add(student6);

                db.SaveChanges();

                var students = db.Students.ToList();
                Console.WriteLine("IDK-team:\n");
                foreach (Student student in students)
                {
                    Console.WriteLine($"{student.Id}. {student.Surname} {student.Name} - {student.Position}");
                }
            }
            Console.Read();
        }
    }
}
