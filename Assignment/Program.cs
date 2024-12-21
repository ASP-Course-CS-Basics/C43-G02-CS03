namespace Assignment
{
    internal class Program
    {
        private static int n;

        static void Main(string[] args)
        {
            #region Q1
            //int number = int.Parse(Console.ReadLine());
            //string res = (number % 3 == 0 && number % 4 == 0) ? "Yes" : "No";
            //Console.WriteLine(res);
            #endregion

            #region Q2
            //int num = int.Parse(Console.ReadLine());
            //string res = num > 0 ? "Positive" : num < 0 ? "Negative" : "Zero";
            //Console.WriteLine(res);
            #endregion

            #region Q3
            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());
            //int z = int.Parse(Console.ReadLine());

            //int max = x;
            //int min = x;

            //if (y > max)
            //    max = y;
            //if (z > max)
            //    max=z;

            //if(y<min)
            //    min = y;
            //if(z<min)
            //    min = z;

            //Console.WriteLine($"Max Element = {max}\nMin Element = {min}");
            #endregion

            #region Q4
            //int num = int.Parse(Console.ReadLine());
            //string res = num % 2 == 0 ? "Even" : "Odd";
            //Console.WriteLine(res);
            #endregion

            #region Q5
            //char x = char.Parse(Console.ReadLine());
            //string res = (x == 'a' ||x=='A'|| x == 'e' ||x=='E'|| x == 'i' ||x== 'I' || x == 'o' ||x=='O'|| x == 'u'||x=='U') ? "Vowel" : "Consonant";
            //Console.WriteLine(res);
            #endregion

            #region Q6
            //int num = int.Parse(Console.ReadLine());
            //for(int i=1; i <= num; i++)
            //{
            //    Console.Write(i);
            //    Console.Write(" ");
            //}
            #endregion

            #region Q7
            //int num = int.Parse(Console.ReadLine());
            //for(int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine($"{num} * {i} = {num*i}");

            //}
            #endregion

            #region Q8
            //int num = int.Parse(Console.ReadLine());
            //for(int i = 1; i <= num; i++)
            //{
            //    if(i%2 == 0) { 
            //        Console.Write(i);
            //        Console.Write(" ");
            //    }
            //}
            #endregion

            #region Q9
            //int Base = int.Parse(Console.ReadLine());
            //int Exponent = int.Parse(Console.ReadLine());
            //int result = 1;
            //for(int i = 1; i <= Exponent; i++)
            //{
            //    result *= Base;
            //}
            //Console.WriteLine(result);
            #endregion

            #region Q10
            //Console.WriteLine("Enter Marks Of Five subjects : ");
            //float a = float.Parse(Console.ReadLine());
            //float b = float.Parse(Console.ReadLine());
            //float c = float.Parse(Console.ReadLine());
            //float d = float.Parse(Console.ReadLine());
            //float e = float.Parse(Console.ReadLine());

            //float Total = a + b + c + d + e;
            //float Avg = Total/5;
            //float Per = Total/500*100;
            //Console.WriteLine($"Total Marks = {Total}\nAverage Marks = {Avg}\nPercentage = {Per}");
            #endregion

            #region Q11
            //int month = int.Parse(Console.ReadLine());
            //if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12) {
            //    Console.WriteLine($"Days in Month {month} is 31 Day");
            //}
            //else if(month == 4 || month == 6 || month == 9 || month == 11)
            //{
            //    Console.WriteLine($"Days in Month {month} is 30 Day");
            //}
            //else if (month == 2)
            //{
            //    Console.WriteLine($"Days in Month {month} is 28 Day");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid month number");
            //}
            #endregion

            #region Q12
            //Console.WriteLine("Enter Two Numbers To Make Calculations On Them : ");
            //double x = double.Parse(Console.ReadLine());
            //double y = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the operator : + - * / %");
            //char z = char.Parse(Console.ReadLine());

            //switch (z)
            //{
            //    case '+':
            //        Console.WriteLine($"{x} + {y} = {x + y}");
            //        break;
            //    case '-':
            //        Console.WriteLine($"{x} - {y} = {x - y}");
            //        break;
            //    case '*':
            //        Console.WriteLine($"{x} * {y} = {x * y}");
            //        break;
            //    case '/':
            //        Console.WriteLine($"{x} / {y} = {x / y}");
            //        break;
            //    case '%':
            //        Console.WriteLine($"{x} % {y} = {x % y}");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Operator");
            //        break;
            //}
            #endregion

            #region Q13
            //string? str = Console.ReadLine();
            //for(int i = str.Length-1; i >= 0; i--)
            //{
            //    Console.Write(str[i]);
            //}
            #endregion

            #region Q14
            //int num = int.Parse(Console.ReadLine());//14589
            //int result = 0;
            //while (num != 0)
            //{
            //    result = result*10 + num % 10;
            //    num = num / 10;
            //}
            //Console.WriteLine(result);
            #endregion

            #region Q15
            //int start = int.Parse(Console.ReadLine());
            //int end = int.Parse(Console.ReadLine());
            //for(int i = start; i <= end; i++)
            //{
            //int count = 0;
            //    for(int j = 1; j <= i; j++)
            //    {
            //        if(i%j == 0)
            //        {
            //            count++;
            //        }
            //    }
            //    if(count == 2)
            //    {
            //        Console.Write(i);
            //        Console.Write(" ");
            //    }
            //}
            #endregion

            #region Q16
            //int num = int.Parse(Console.ReadLine());//25
            //string res = "";
            //int x = num;
            //while (x > 0)
            //{
            //    res = (x % 2) + res;
            //    x /= 2;
            //}
            //Console.WriteLine($"The Binary of {num} is {res}");
            #endregion


        }
    }
}
