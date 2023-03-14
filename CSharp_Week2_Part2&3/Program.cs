using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3-16 ----------------------------------------------------- //
            List<string> strings = new List<string>();

            strings.Add("First");
            strings.Add("Second");
            strings.Add("Third");

          
            RemoveLast(strings);

            strings.ForEach(Console.WriteLine);
            

        }
           // 3-16 ----------------------------------------------------- //
           public static void RemoveLast(List<string> strings)
            {
                if (strings.Count > 0)
                {
                    strings.RemoveAt(strings.Count - 1);
                }
            }

    }
}