using System;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace DBA_Exam
{
    class Program
    {
        public static void Main(string[] args)
        {
            int input;
            do
            {
                Selection();
                input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    //case 0: Environment.Exit(0); break;
                    case 1: Duplicate(); break;
                    case 2: Print(); break;
                    case 3: Employees(); break;
 
                }

            } while (input != 4);
         System.Environment.Exit(0);
        }

        public static void Selection()
        {

            Console.WriteLine("\n***************************************************\n" +
            "Select One (Enter the required Selection) \n" +
            "1.Duplicate Array \n" +
            "2.Print \n" +
            "3.Employees \n" +
            "4.Exit \n" +
            "***************************************************");
        }
        public static void Duplicate()
        {
           var arrayList = new List<int>{5,1,4,6,7,3,5,7,3 };

            var duplicate = arrayList.GroupBy(x => x)
              .Where(g => g.Count() > 1)
              .Select(y => y.Key)
              .ToList();

            Console.WriteLine(String.Join(", ", duplicate));
        }
        public static  void Print()
        {

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                Console.Write('\n');
            
            }
 
           
 
        }

        public static void Employees()
        {
            int newlyHiredMales, newlyHiredFemale, permanentMale, permanentFemale, resignedMale, resignedFemales;
            Console.Write("Enter the number of newly hired males: ");
            newlyHiredMales = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of newly hired females: ");
            newlyHiredFemale = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of permanent position males: ");
            permanentMale = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of permanent position females: ");
            permanentFemale = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of newly resigned males: ");
            resignedMale = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of newly resigned females: ");
            resignedFemales = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("===");
            Console.WriteLine("Thank you for the Information");
            Console.WriteLine("===");
            Console.WriteLine("Here is the Summary !!!\n");


            GetHiredEmployeesPercentage(newlyHiredMales, newlyHiredFemale);
            GetPermanentEmployeesPercentage(permanentMale, permanentFemale);
            GetResignedEmployeesPercentage(resignedMale, resignedFemales);

        }

        public static void GetHiredEmployeesPercentage(int male, int female)
        { 
     
            Console.WriteLine($"Number of hired employee: {GetTotal(male, female)} ");
            Console.WriteLine($"Male: {GetPercentage(male, GetTotal(male, female))}%");
            Console.WriteLine($"Female: {GetPercentage(female, GetTotal(male, female))}% \n");

        }
        public static void GetPermanentEmployeesPercentage(int male, int female)
        {

            Console.WriteLine($"Number of Permanent employee: {GetTotal(male, female)} ");
            Console.WriteLine($"Male: {GetPercentage(male, GetTotal(male, female))}%");
            Console.WriteLine($"Female: {GetPercentage(female, GetTotal(male, female))}% \n");

        }

        public static void GetResignedEmployeesPercentage(int male, int female)
        {

            Console.WriteLine($"Number of Resigned Employee: {GetTotal(male, female)} ");
            Console.WriteLine($"Male: {GetPercentage(male, GetTotal(male, female))}%");
            Console.WriteLine($"Female: {GetPercentage(female, GetTotal(male, female))}% \n");

        }
        public static double GetPercentage(int a, int b)
            => Math.Round(((double)a / (double)b) * 100, 2);

        public static int GetTotal(int totalMale, int totalFemale)  
            => totalMale + totalFemale;
   
   

    }
}
