using System.Text;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *          - Control Statements - 
             * 1- Conditional Statements ( If Else - Switch Case)
             * 2- Loop Statements ( For - Foreach - While - do While )
             */

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

            #region Part 09 Loop Statements
            // Print From 1 To 10
            #region Legacy Approach [Good Performance - Bad Mainitainability]
            ////Done In 10 Steps for 10 statements.
            //Console.WriteLine(1);
            //Console.WriteLine(2);
            //Console.WriteLine(3);
            //Console.WriteLine(4);
            //Console.WriteLine(5);
            //Console.WriteLine(6);
            //Console.WriteLine(7);
            //Console.WriteLine(8);
            //Console.WriteLine(9);
            //Console.WriteLine(10);
            #endregion

            #region Looping Approach [Bad Performane - Good Maintainability]
            ////32 Steps, 3 steps for every iterate, and last 2 steps for Exit condition ( 1- i++(10+1=11)  2- i <= 10(false) )
            //for(int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #endregion

            #region Part 10 Loop Statements - For, Foreach
            #region For Loop
            //// I need To Print Collection Elements Like Array And I Know The Number Of Elements In Array, So Use For Loop
            //int[] Numbers01 = new int[] { 1, 2, 3, 4, 5 };
            //int[] Numbers02 = { 1, 2, 3, 4, 5 };
            ////Index ->          0  1  2  3  4     Size(Length) = 5 Elements
            //int[] Numbers03 = [ 1, 2, 3, 4, 5 ];
            #region Traditional Approach
            //Console.WriteLine(Numbers03[0]);//1
            //Console.WriteLine(Numbers03[1]);//2
            //Console.WriteLine(Numbers03[2]);//3
            //Console.WriteLine(Numbers03[3]);//4
            //Console.WriteLine(Numbers03[4]);//5
            #endregion

            #region Looping Approach [For Loop]
            //for(int i = 0; i < Numbers03.Length; i++)
            //{
            //    Console.WriteLine(Numbers03[i]);
            //}
            #endregion
            #endregion

            #region Foreach Loop
            //int[] numbers = { 1, 2, 3, 4, 5 };
            //foreach(int num in numbers)
            //{
            //    Console.WriteLine(num);
            //}
            #endregion
            #endregion

            #region Part 11 Loop Statements - Do While, While
            #region do ..... While
            //int num;
            //bool Parsed;
            //do
            //{
            //    Console.Write("enter even  number: ");
            //    Parsed = int.TryParse(Console.ReadLine(), out num);
            //} while (Parsed == false || num % 2 != 0);

            #endregion

            #region While
            //int i = 1;
            //while (i <= 10)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}
            #endregion
            #endregion

            #region Part 12 String

            #region Example 01
            //string Name01 = new string("Ahmed");//Allocate new object of type string in heap, with initialized value "Ahmed"
            //Name01 = new string("Eslam");//Allocate new object of type string in heap, with initialized value "Eslam"

            //string Name02 = new string("Eslam");//Allocate new object of type string in heap, with initialized value "Eslam"
            //string Name03 = new string("Eslam");//Not Allocate new object in heap, CLR check first if there is previous object initialized with this value, if found it , it return the addres of this object to the reference (Name02) in stack
            ////So the 2 References in stack (Name02 - Name03) Refer to the same object in heap of value "Eslam"

            //Console.WriteLine($"Name02 HashCode=> {Name02.GetHashCode()}");//Name02 HashCode=>2011592142
            //Console.WriteLine($"Name03 HashCode=> {Name03.GetHashCode()}");//Name03 HashCode=>2011592142 
            #endregion

            #region Example 02
            //string Name01 = "Ahmed";
            //string Name02 = "Mahmoud";
            //Console.WriteLine("--------- Before Name02 = Name01 ------------");
            //Console.WriteLine($"Name 01 => {Name01}");//Ahmed
            //Console.WriteLine($"Hash Code => {Name01.GetHashCode()}");//1471634250
            //Console.WriteLine("*********************************");
            //Console.WriteLine($"Name 02 => {Name02}");//Mahmoud
            //Console.WriteLine($"Hash Code => {Name02.GetHashCode()}");//1652095188
            //Name02 = Name01;
            //Console.WriteLine("--------- After Name02 = Name01 ------------");
            //Console.WriteLine($"Name 01 => {Name01}");//Ahmed
            //Console.WriteLine($"Hash Code => {Name01.GetHashCode()}");//-2012901293
            //Console.WriteLine("*********************************");
            //Console.WriteLine($"Name 02 => {Name02}");//Ahmed
            //Console.WriteLine($"Hash Code => {Name02.GetHashCode()}");//-2012901293

            //Console.WriteLine("\n----------- Before Name02 = \"Yassmin\"---------");
            //Console.WriteLine($"Name 01 => {Name01}");//Ahmed
            //Console.WriteLine($"Name 02 => {Name02}");//Ahmed
            //Name02 = "Yassmin";
            //Console.WriteLine("----------- After Name02 = \"Yassmin\"---------");
            //Console.WriteLine($"Name 01 => {Name01}");//Ahmed
            //Console.WriteLine($"Name 02 => {Name02}");//Yassmin
            #endregion

            #region Example 03
            //string message = "Hello";
            //Console.Write($"Message => {message}  : HashCode => {message.GetHashCode()}\n");//251408458
            //Console.Write("Please enter your Name: ");
            //string Name = Console.ReadLine()!;
            //message = $"{message} {Name}";

            //Console.WriteLine(message);

            //Console.Write($"Message => {message}  : HashCode => {message.GetHashCode()}");//-1475770673
            #endregion
            #endregion

            #region Part 13 StringBuilder
            //StringBuilder messageBuilder = new StringBuilder("Hello");
            //Console.WriteLine($"message => {messageBuilder}");//Hello
            //Console.WriteLine($"HashCode => {messageBuilder.GetHashCode()}");//54267293

            //Console.Write("Enter Your Name: ");
            //string Name = Console.ReadLine()!;
            //messageBuilder.Append($"\t {Name}");

            //Console.WriteLine($"message => {messageBuilder}");//Hello       Eslam
            //Console.WriteLine($"HashCode => {messageBuilder.GetHashCode()}");//54267293
            #endregion




        }
    }
}
