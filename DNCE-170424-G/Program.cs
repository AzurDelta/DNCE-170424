using System.Dynamic;

namespace DNCE_170424_G
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strs = new[] { "str","str", "str3", "notastring","notastring", "maybeastring" };
            int[] ints = new[] { 5, 3, 6, 7, 9,9,3,3,4 };
            var strsList = new List<string>() { "str","str", "str3", "notastring","notastring", "maybeastring" };
            DoublesDistinct(strs);
            DoublesDistinct(ints);
            DoublesDistinct(strsList);
        }

        static void DoublesDistinct<T>(T[] args)
        {
            var len = args.Length;
            
            for (int i = 0; i < len; i++)
            {
                if (i == 0 || !args[i].Equals(args[i - 1]))
                    Console.WriteLine(args[i]);
            }   
        }
        
        static void DoublesDistinct<T>(List<T> args)
        {
            var len = args.Count;
            
            args = args.Where((arg, i) => i == 0 || !arg.Equals(args[i - 1])).ToList(); 
            args.ForEach(x => Console.WriteLine(x));
        }

    }
}
