using System;

namespace UG_Project
{
    public class Program
    {
        static void Main(string[] args)
        {
            var a = PartialClassesProvider.Instance;

            a.CreateNewPartialClass("One");
            a.CreateNewPartialClass();
            a.CreateNewPartialClass("Three");

            foreach (var item in a.GetListOfPartalClasses())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("_____________________");

            a.RemoveAllPartialClasses();

            foreach (var item in a.GetListOfPartalClasses())
            {
                Console.WriteLine(item);
            }
        }
    }
}
