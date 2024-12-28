using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Assignment_OOP_C_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q01.Create an Enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this Enum.

            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.Write($"{day} " );  
            //}
            #endregion
            #region Q2.Create an Enum called "Seas on" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
            //Console.WriteLine("Enter a season: ");
            //Seas_on season;
            //if (Enum.TryParse(Console.ReadLine(), out season))
            //{
            //    switch (season)
            //    {
            //        case Seas_on.Spring:
            //            Console.WriteLine("spring march to may");
            //            break;
            //        case Seas_on.Winter:
            //            Console.WriteLine(" December to February");
            //            break;
            //        case Seas_on.Summer:
            //            Console.WriteLine(" summer june to august");
            //            break;
            //        case Seas_on.Autumn:
            //            Console.WriteLine("autumn September to November");
            //            break;  
            //    }
            //}
            #endregion
            #region Q3.Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission existed inside variable
            //Permissions permission = Permissions.Read;
            // permission^= Permissions.Delete;
            // permission^= Permissions.Delete;
            //Console.WriteLine(permission);
            //if ((Permissions.write & permission) == Permissions.write)

            //    Console.WriteLine("You Has Read Permission");
            //else
            //    permission ^= Permissions.write;

            //Console.WriteLine( permission);



            #endregion
            #region Q4.Create an Enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
            //Console.Write("Enter a Color : ");
            //Colors color;
            //if (Enum.TryParse(Console.ReadLine(), out color))

            //    Console.WriteLine($"{color}  is a primary color");
            //else Console.WriteLine($"{color} is Not a primary color");
            

            #endregion
        }

    }
}
    