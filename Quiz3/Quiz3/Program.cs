using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<Student> students = new List<Student>
            {
                new Student("Giorgi", "Amiranashvili", new DateTime(2002, 11, 23), 'M', "Caucasus University", "Computer Science", "Programmer", 4),
                new Student("Giorgi", "Javakhishvili", new DateTime(2002, 7, 22), 'M', "Caucasus University", "Math", "Math", 1),
                new Student("Teo", "Zardiashvili", new DateTime(1998, 6, 15), 'F', "Free University", "Business", "businesswoman", 3),
                new Student("Irakli", "Potskhverashvili", new DateTime(1991, 4, 8), 'M', "Tbilisi State University", "Economy", "Economist", 2)
            };

            foreach (var student in students)
            {
                Console.WriteLine(student);
                Console.WriteLine();
            }


            int numberOfGirls = students.Count(student => student.Skesi == 'F');
            int numberOfBoys = students.Count(student => student.Skesi == 'M');


            Console.WriteLine($"Gogo studentebi aris {numberOfGirls}");
            Console.WriteLine($"Bichi studentebi aris {numberOfBoys}");



            var top3Students = students
                .Where(student => student.nishnebisSashualo() >= 90)
                .OrderByDescending(student => student.nishnebisSashualo());


            if (top3Students.Any())
            {
                Console.WriteLine("top 3 studenti aris: ");
                foreach (var student in top3Students)
                {
                    Console.WriteLine($"{student.Saxeli} {student.Gvari} - {student.nishnebisSashualo()}");
                }
            }
            else
            {
                Console.WriteLine("kvela students 90ze dabali akvs nishani");
            }
            
            
            var ufrosiStudenti = students
                .OrderBy(student => student.DabadebisDge)
                .FirstOrDefault();


            Console.WriteLine(ufrosiStudenti != null
                ? $"kvelaze ufrosi studenti aris {ufrosiStudenti.Saxeli} {ufrosiStudenti.Gvari}"
                : "No students found.");
            

            Console.ReadLine();
        }
    }
}
