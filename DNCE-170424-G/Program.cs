namespace DNCE_170424_G
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var len = args.Length;
            List<string> rearranged = new List<string>();
            
            for (int i = 0; i < len; i++)
            {
                if (i == 0 || args[i] != args[i - 1])
                     rearranged.Add(args[i]);
            }
            
            rearranged.ForEach(e => Console.Write($"{e}; "));
            
        }
        // аргументы передаются как аргументы "dotnet run"
    }
}
