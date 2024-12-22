namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 Conditional Statments - If, Switch [Numeric Datatypes]
            #region If  else if  else
            //Console.Write("Please enter month number exist in 1st Quarter of year: ");
            //int.TryParse(Console.ReadLine(), out int MonthNumber);

            //if (MonthNumber == 1)
            //    Console.WriteLine("Hello January!");
            //else if (MonthNumber == 2)
            //    Console.WriteLine("Hello february!");
            //else if (MonthNumber == 3)
            //    Console.WriteLine("Hello March!");
            //else
            //    Console.WriteLine("You enter monthNumber Not In 1st Quarte of year!");
            #endregion

            #region Switch Case [ Numeric Type - Equallity Comparison ]
            //Console.Write("Please enter month number exist in 1st Quarter of year: ");
            //int.TryParse(Console.ReadLine(), out int MonthNumber);

            //switch (MonthNumber)
            //{
            //    case 1:
            //        Console.WriteLine("Hello Jan!");
            //        break;
            //    case 2:
            //        Console.WriteLine("Hello Feb!");
            //        break;
            //    case 3:
            //        Console.WriteLine("Hello March!");
            //        break;
            //    default:
            //        Console.WriteLine("You enter monthNumber Not In 1st Quarte of year!");
            //        break;
            //}
            #endregion

            ///If Vs Switch
            ///*
            /// * When you need to make condition on variable of type numeric 
            ///* And compare Equallity (Case 1 , Case 2, .....)
            /// * Use ( Switch Case ) For faster access elements, because compiler generate jumb table for this switch case.
            /// * */
            #endregion

            #region Part 02 Switch [Numeric Datatypes (Comparsion Operators)]
            #region Using ( If - Else )
            //Console.Write("Enter Your Age : ");
            //int.TryParse(Console.ReadLine(), out int Age);

            //if (Age > 22)
            //    Console.WriteLine("You're Greater Than 22.");
            //else if (Age < 22)
            //    Console.WriteLine("You're Less Than 22.");
            //else
            //    Console.WriteLine("You're 22."); 
            #endregion

            #region Using ( Switch - Case )
            //Console.Write("Enter Your Age : ");
            //int.TryParse(Console.ReadLine(), out int Age);

            //switch (Age) 
            //{
            //    case > 22:
            //        Console.WriteLine("You're Greater Than 22.");
            //        break;
            //    case < 22:
            //        Console.WriteLine("You're Less Than 22.");
            //        break;
            //    default:
            //        Console.WriteLine("You're 22.");
            //        break;
            //}
            #endregion
            #endregion

        }
    }
}
