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
            //#endregion
            #endregion

            #region Switch Case
            Console.Write("Please enter month number exist in 1st Quarter of year: ");
            int.TryParse(Console.ReadLine(), out int MonthNumber);

            switch(MonthNumber)
            {
                case 1:
                    Console.WriteLine("Hello Jan!");
                    break;
                case 2:
                    Console.WriteLine("Hello Feb!");
                    break;
                case 3:
                    Console.WriteLine("Hello March!");
                    break;
                default:
                    Console.WriteLine("You enter monthNumber Not In 1st Quarte of year!");
                    break;
            }
            #endregion

            ///If Vs Switch
            ///*
             /// * When you need to make condition on variable of type numeric 
              ///* And compare Equallity (Case 1 , Case 2, .....)
             /// * Use ( Switch Case ) For faster access elements, because compiler generate jumb table for this switch case.
            /// * */
            #endregion


        }
    }
}
