namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            int number;
            int.TryParse(Console.ReadLine(), out number);
            string res = (number % 3 == 0 && number % 4 == 0) ? "Yes" : "No";
            Console.WriteLine(res);
            #endregion
        }
    }
}
