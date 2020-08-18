using System;

namespace schoolTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentGrades = new int[] { 77, 88, 98, 76, 82 };
            foreach (var grade in studentGrades)
            {

            Console.WriteLine(grade);
            }
        }
    }
}
