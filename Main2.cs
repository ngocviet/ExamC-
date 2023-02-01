using System.Collections;

namespace Quesstion2
{
    internal class Program
    {
        static void horizontalLine()
        {
            Console.WriteLine("----------------------------");
        }

        static int radomID(List<Student> list)
        {
            Random random = new Random();
            int id = random.Next(0, 100);
            foreach (Student student in list)
            {
                if (student.StudentNumber.Equals(id.ToString()))
                {
                    radomID(list);
                }
                else
                {
                    return id;
                }
            }
            return 0;
        }
        static void disPlayStudentHaveHightsAge(List<Student> list)
        {
            List<Student> returnList = new List<Student>();
            Student st = list.First();
            foreach (var item in list)
            {
                if(item.StudentAge > st.StudentAge)
                {
                    st = item;
                }
            }
            foreach (var item in list)
            {
                if (item.StudentAge == st.StudentAge)
                {
                    returnList.Add(item);
                }
            }
            if(returnList.Count ==1)
            {
                Console.Write("The oldest students is: ");
                Console.WriteLine(returnList.First());
                return;
            }
            Console.WriteLine("The oldest students are: ");
            foreach (var item in returnList)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            List<Student> arlist = new List<Student>();
            int index = 0;
            Boolean viet = true;
            while (viet)
            {
                try
                {
                    Console.Write("Enter the number of students: ");
                    string indexString = Console.ReadLine();
                    index = Int32.Parse(indexString);
                    viet = false;
                }
                catch (Exception)
                {
                    viet = true;
                }

            }
            horizontalLine();
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine($"Enter the student {i + 1}: ");
                Student st1 = new Student();
                st1.input();
                st1.StudentNumber = radomID(arlist).ToString();
                arlist.Add(st1);
                horizontalLine();
            }
            Console.WriteLine("The list of students is: ");
            foreach (var item in arlist)
            {
                Console.WriteLine(item);
            }
            horizontalLine();
            disPlayStudentHaveHightsAge(arlist);

        }
    }
}