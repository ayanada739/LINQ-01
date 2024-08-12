using System.Text;

namespace LINQ_01
{
    internal class Program
    {
        //static var Print(var X)
        //{
        //    return X;
        //}

        //static dynamic Print(dynamic X)
        //{
        //    return X;
        //}



        static void Main(string[] args)
        {



            #region C# Keywords : Implicitly Typed Local Variable [var, dynamic]

            // C# Keywords; Implicitly Typed Local Variable [var — dynamic]

            #region C# Keyword : var

            // var
            //var Data01 = "Ahmed";

            // Complier Will Detect Datatype Of Local Variable Based On Initial Value, At Compilation Time
            // Must Be Initialized
            // Can't Initialized Local Variable With Null
            // Can't Change Datatype Of The Local Variable After Initialization
            // Can't Use var as Parameter Or Retrurntype


            //var X = 12;

            //var X; //Invalid

            //var X = null;

            //Data01 = 12;


            /*
             var X = 12;
             X = "Ahmed";
             X = new Object()
             */


            #endregion

            #region C# Keyword : dynamic

            //dynamic

            //dynamic Data02 = "Ahmed"; // Like var in JS

            // CLR Detect Datatype Of Local Variable Based On Last Value,At Runtine
            // Don't Need To Be Initialized
            // Can Initialized Local Variable With Null
            // Can Change Datatype Of The Local Variable After Initialization
            // Can Use var as Parameter Or Retrurntype
            // Be Careful When Using dynamic Keyword

            //Console.WriteLine(Data02.GetType().Name);

            //Data02 = 12;

            //Console.WriteLine(Data02.GetType().Name);

            //Data02 = 'a';

            //Console.WriteLine(Data02.GetType().Name);

            //Data02 = 1.9;

            //Console.WriteLine(Data02.GetType().Name);

            //dynamic X = null;

            //Console.WriteLine(Data02.GetType().Name);



            #endregion

            #endregion


            #region Extension Methods
            // Extension Methods

            //int Number = 12345; //54321

            // var Result = IntExtension.Reverse(Number);

            // Console.WriteLine(Result);

            // Number.Reverse();

            //var Result = Number.Reverse();

            //Number.Reverse();
            //Console.WriteLine(Result);

            #endregion

            #region Anonymous Type

            //Anonymous Type

            //Employee Emp01 = new Employee() { Id = l, Name = "ahmed", Salary = 12000 };

            //var Emp01 = new { Id = 1, Name = "ahmed", Salary = 12000.0 };  // Anonyaous Type
            //var Emp02 = new { Id = 1, Name = "ahmed", Salary = 12000.0 };  // var Emp01= new { Id=1, Name = 123, Salary = 12000.0};

            //Emp01.1d = 12; // Invalid-Immutable Type- Can't Change Its value After Creation

            //var Emp02 = Emp01 with { Id = 12};// New Feature C# 10.0

            //console ,WriteLine(Emp01 .GetType().Name); //<>f_AnonymousType0'3
            //ConsoIe ,WriteLine(Emp02. GetType().Name); //<>f_AnonymousType0'3

            //Console.WriteLine(Emp01);
            //Console.WriteLine(Emp02);


            //The Same Anonymous As long as:
            //1. The Property Naming [Case Sensitive]
            //2. The Property Order
            //3. The Property Datatype


            //if (Emp01.Equals(Emp02)) //Compare Reference
            //{
            //    Console.WriteLine(value: "EQUALS");
            //}
            //else
            //{
            //    Console.WriteLine(value: "EQUALS");

            //} 
            #endregion

            #region LINQ
            // LINQ: Language Integrated Query
            //     : +40 Extesion methods (LINQ Operators) using Against Any Data [Data in Sequence) ,Reradtess Data Store
            //     : 13 Category
            //     : LINQ Operators Exits Class "Enumerable"

            //Sequence: Object From Class Implement Interface "Enumerable"
            // Local Sequence : L20, L2XML
            // Remote Sequence : L2EF

            //Input Sequence ==> LINQ Operator ==> Output Sequence
            //Input Sequence ==> LINQ Operator ==> One Value
            //               ==> LINQ Operator ==> Output Sequence


            //List<int> Numbers = new List<int>() { 1, 2, 3, 4, 5, 6 };

            //var Result = Enumerable.Where(Numbers, N => N % 2 == 0);

            //var Result = Numbers.Where( N => N % 2 == 0);

            //Numbers.Any();

            //var Result = Enumerable.Range(start: 1, count: 100);

            // foreach (var item in Result)
            // {
            //     Console.WriteLine(item);
            // } 
            #endregion
        }
    }
}
