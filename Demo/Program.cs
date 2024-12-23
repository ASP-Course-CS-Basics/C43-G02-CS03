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

            #region Part 05 Switch with goto
            //Console.Write("Please enter your Budget: ");
            //int budget = int.Parse(Console.ReadLine());

            //switch (budget)
            //{
            //    case 3000:
            //        Console.WriteLine("Option 03");
            //        //Console.WriteLine("Option 02");
            //        //Console.WriteLine("Option 01");
            //        goto case 2000;
            //    case 2000:
            //        Console.WriteLine("Option 02");
            //        //Console.WriteLine("Option 01");
            //        goto case 1000;
            //    case 1000:
            //        Console.WriteLine("Option 01");
            //        break;
            //}
            #endregion

            #region Part 06 Evolution of Switch in C# 7.0 (Continued)
            //object Input;
            ///*1- */Input = 5;//Boxing
            ///*2- */Input = 10.5;//double
            ///*3- */Input = new Person() { Id = 200,Name = "Eslam Elsaadany" };//Reference Input in Stack which is of object datatype refer to new object in heap of Person Type(Class Reference Type).
            //switch (Input)
            //{
            //    /*1- */case int localInput when localInput>=5 && localInput<20://Unboxing
            //        Console.WriteLine("int Input");
            //        break;
            //    /*2- */case double localInput:
            //        Console.WriteLine("double Input");
            //        break;
            //    /*3- */case Person person when person.Id == 200:
            //        Console.WriteLine($"Person Name : {person.Name}");
            //        break;
            //    default:
            //        Console.WriteLine("Unknown Input");
            //        break;
            //}
            #endregion

            #region Part 07 Evolution of Switch in C# 8.0
            #region Example 01 [Switch Expression ( Before C# 8.0  && After C# 8.0 )]
            //string Option = Console.ReadLine()??"0";
            //string message = string.Empty;//string.empty like "" => string message = "";

            ///Before C# 8.0
            ///switch (Option)
            ///{
            ///    case "1":
            ///        message = "Use Option 1";
            ///        break;
            ///    case "2":
            ///        message = "Use Option 2";
            ///        break;
            ///    case "3":
            ///        message = "Use Option 3";
            ///        break;
            ///    default:
            ///        message = "Unsupported Option";
            ///        break;
            ///}
            ///Console.WriteLine(message);

            ///After C# 8.0
            ///message = Option switch
            ///{
            ///    "1" => "Use Option 1",
            ///    "2" => "Use Option 2",
            ///    "3" => "Use Option 3",
            ///     _  => "Unsupported Option"
            ///};
            ///Console.WriteLine(message);

            #endregion

            #region Example 02 [Switch Syntax suger when Switch on object ( Before C# 8.0  && After C# 8.0 )]
            //Person Human = new Person() { Id = 100, Name = "Eslam Elsaadany", Age = 22 };
            //Person Human2  = new Person() { Id = 100,Name = "Ahmed Ashraf",Age = 24 };
            ///Before C# 8.0
            ///
            ///switch (Human)
            ///{
            ///    case Person when Human.Id == 100 && Human.Name == "Eslam Elsaadany"://Tell Compiler that this Human is Of Type Person, and put multi Conditions.
            ///        Console.WriteLine($"Your Age is : {Human.Age}");
            ///        break;
            ///    case Person when Human.Age == 22:
            ///        Console.WriteLine($"Hello {Human.Name}, Your Id = {Human.Id}");
            ///        break;
            ///} 

            ///After C# 8.0
            ///
            ///switch (Human)
            ///{
            ///    case { Id: 100, Age: > 22 }:
            ///        Console.WriteLine($"Hello {Human.Name}, Your Age is {Human.Age}");
            ///        break;
            ///}

            #endregion


            #endregion

            #region Part 08 Evolution of Switch in C# 9.0
            #region Make Conditioning on variable of Type Reference Type Like Class(Person) Before C# 9.0
            //// You Need First To Make Reference Of Type Object And Then Let It To Refer To New Object Of Type Class (Person).
            ////And in [Case] ,tell the compiler to deal with this reference as Person Class Type and give alias name foe reference.
            //object human = new Person() { Id = 100, Name = "Eslam Elsaadany", Age = 22 };

            //switch (human)
            //{
            //    case Person person when person.Id == 100 && person.Name == "Eslam Elsaadany":
            //        Console.WriteLine($"Hello Eslam, Your Age Is {person.Age}");
            //        break;
            //}
            #endregion

            #region Make Conditioning on variable of Type Reference Type Like Class(Person) After C# 9.0
            ////You Can Make Conditioning On Variable Of Type Person Direct
            //Person human = new Person() { Id = 100,Name = "Eslam Elsaadany",Age = 24};

            //switch (human)
            //{
            //    //Before Syntax Suger of C# 9.0
            //    case Person when human.Id == 100 && human.Name == "Eslam Elsaadany":
            //        Console.WriteLine($"Hello Eslam, Your Age is {human.Age}");
            //        break;
            //    //After Syntax Suger Of C# 9.0
            //    case { Id: 100, Name: "Eslam Elsaadany", Age: > 20 and < 25 }:
            //        Console.WriteLine($"Hello Eslam, Your Age is {human.Age} And You Are old");
            //        break;
            //}
            #endregion

            #region Using Switch Expression
            ///*1- */Person human = new Person() { Id = 100, Name = "Eslam Elsaadany", Age = 22 };
            ///*2- */ human = new Person() { Id = 100, Name = "Eslam Elsaadany", Age = 30 };
            ///*3- */ human = new Person() { Id = 100, Name = "Eslam Elsaadany", Age = 36 };
            //string message = "";

            //message = human switch
            //{
            //    { Id: 100, Name: "Eslam Elsaadany", Age: > 20 and < 25 } => $"Hello {human.Name}, Your Age is {human.Age}, And You Are Old",
            //    { Age:30} => "Hello Anonymous, Your Age is 30",
            //    _ => "Unknown Person"
            //};

            ///*1- */Console.WriteLine(message);//Hello Eslam Elsaadany, Your Age is 22, And You Are Old
            ///*2- */Console.WriteLine(message);//Hello Anonymous, Your Age is 30
            ///*3- */Console.WriteLine(message);//Unknown Person
            #endregion
            #endregion

        }
    }
}
