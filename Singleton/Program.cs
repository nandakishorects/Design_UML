using System;

namespace UAHighschool
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string choice;
            while (true)
            {
                Console.WriteLine("Enter your choice:");
                Console.WriteLine("1. Set School Name");
                Console.WriteLine("2. Get School Name");
                Console.WriteLine("3. Exit");

                choice = Console.ReadLine();

                // Stop the loop if input is null or empty to prevent OOM
                if (choice == null) break;

                if (choice == "1")
                {
                    SetSchoolName();
                }
                else if (choice == "2")
                {
                    GetSchoolName();
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Thank you!!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Choice");
                }
            }
        }

        private static void SetSchoolName()
        {
            Highschool school = Highschool.GetSchoolInstance();
            Console.WriteLine("Enter the School Name:");
            string name = Console.ReadLine();
            school.schoolName = name;
            Console.WriteLine("School name set to " + school.schoolName);
        }

        private static void GetSchoolName()
        {
            Highschool school = Highschool.GetSchoolInstance();
            if (string.IsNullOrEmpty(school.schoolName))
            {
                Console.WriteLine("School name is not set");
            }
            else
            {
                Console.WriteLine("School name is " + school.schoolName);
            }
        }
    }
}
