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

            #region Part 02 If & Switch [Numeric Datatypes (Comparsion Operators)]
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

            #region Part 03 Conditional Statments - If, Switch [String Datatype]
            #region Using If - Else
            //Console.Write("Please enter your name: ");
            //string Name = Console.ReadLine() ?? "No Name";

            //if (Name == "Eslam")
            //    Console.WriteLine("Hello Eslam!");
            //else if (Name == "Ahmed")
            //    Console.WriteLine("Hello Ahmed!");
            //else if (Name == "Mohamed")
            //    Console.WriteLine("Hello Mohamed!");
            //else if (Name == "Hany")
            //    Console.WriteLine("Hello Hany!");
            //else if (Name == "Sama")
            //    Console.WriteLine("Hello Sama!"); 
            #endregion

            #region Using Switch - Case
            //Console.Write("Please enter your name: ");
            //string Name = Console.ReadLine() ?? "No Name";

            //switch(Name)
            //{
            //    case "Eslam":
            //        Console.WriteLine("Hello Eslam!");
            //        break;
            //    case "Ahmed":
            //        Console.WriteLine("Hello Ahmed!");
            //        break;
            //    case "Mohamed":
            //        Console.WriteLine("Hello Mohamed!");
            //        break;
            //    case "Hany":
            //        Console.WriteLine("Hello Hany!");
            //        break;
            //    case "Sama":
            //        Console.WriteLine("Hello Sama!");
            //        break;
            //}
            #endregion

            /*
              * 1- When Switching On Variable Of Type Reference Type( e.g -> String ), And Cases Are Less Than Or Equal Five ( Cases <= 5 ),
              * Compiler Not Do Effort ( Cost ) For Generating Jumb Table, It's Just Convert Switch - Cases Into If - Else Chains.
              * 2- If Cases Are More Than  Five Cases, Compiler Will Do Effort( Cost ), And Generate Jumb Table For Switch Cases,
              * Because Effort Of Generating Jumb Table Is Less Than Find Value at O(n) when Converting To If - Else Chains.
             */
            #endregion

            #region Part 04 Switch in C# is Different
            //// You Can Use Comparison Operators In Cases In Switch Case
            //// But There Is In C# Onl, So It's Different.
            //Console.Write("Enter Your Age: ");
            //int.TryParse(Console.ReadLine(),out int Age);

            //switch (Age)
            //{
            //    case > 22://You Can Use Comparison Operator
            //        Console.WriteLine("You Are More Than 22");
            //        break;
            //    case < 22:
            //        Console.WriteLine("You Are Less Than 22");
            //        break;
            //    default :
            //        Console.WriteLine("You Are 22");
            //        break;
            //}
            #endregion

        }
    }
}
